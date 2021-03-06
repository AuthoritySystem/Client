using AuthoritySystem.Common.Helper;
using AuthoritySystem.Model.Entity.ApiModel;
using AuthoritySystem.Model.Entity.DbModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace AuthoritySystem.Win
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            InitialSystemMenu();
        }

        private async  void InitialSystemMenu()
        {
            muMenu.Items.Clear();

            ToolStripMenuItem tsMenuItem = null;
            ToolStripMenuItem tsSubMenuItem = null;

            // 动态获取菜单
            string menuUrl = $"{ConfigHelper.GetValue("WebApiUrl")}/api/Menu";

            var responseData = await HttpClientHelper.GetObjectAsync<ApiResponseWithData<List<TB_Menu>>>(menuUrl);

            if(!responseData.Code.Equals(1))
            {
                MessageBox.Show("获取系统菜单失败");
                return;
            }
            List<TB_Menu> listMenu = responseData.Data;
            // 获取父节点
            var parentMenu = listMenu.Where(p => p.ParentID == null);
            foreach (var item in parentMenu)
            {
                tsMenuItem = new ToolStripMenuItem();
                tsMenuItem.Text = item.MenuName;
                // 添加父节点
                muMenu.Items.Add(tsMenuItem);

                // 获取所有子节点
                var childMenu = listMenu.Where(p => p.ParentID == item.ID);

                foreach (var child in childMenu)
                {
                    tsSubMenuItem = new ToolStripMenuItem();
                    tsSubMenuItem.Text = child.MenuName;
                    tsSubMenuItem.Tag = child.Url;
                    string className = $"{child.NameSpace}.{child.ClassName}";
                    tsSubMenuItem.Name = className;
                    // 子节点绑定单击事件
                    tsSubMenuItem.Click += TsSubMenuItem_Click;
                    // 添加父节点下面的子节点
                    tsMenuItem.DropDownItems.Add(tsSubMenuItem);
                }
            }
            // 建置 HELP 选单
            tsMenuItem = new ToolStripMenuItem();
            tsMenuItem.Tag = "HELP";
            tsMenuItem.Text = "说明(&H)";
            muMenu.Items.Add(tsMenuItem);


            tsSubMenuItem = new ToolStripMenuItem();
            tsSubMenuItem.Text = "使用说明(&U)";
            //tsSubMenuItem.Click += new System.EventHandler(this.ShowHelp);
            tsMenuItem.DropDownItems.Add(tsSubMenuItem);


            tsSubMenuItem = new ToolStripMenuItem();
            tsSubMenuItem.Text = "用户讯息(&I)";
            //tsSubMenuItem.Click += new System.EventHandler(this.ShowMessageSite);
            tsMenuItem.DropDownItems.Add(tsSubMenuItem);

            tsSubMenuItem = new ToolStripMenuItem();
            tsSubMenuItem.Text = string.Format("关于 {0}(&A)", this.Text);
            //tsSubMenuItem.Click += new System.EventHandler(this.ShowAboutForm);
            tsMenuItem.DropDownItems.Add(tsSubMenuItem);

            // 建置 HELP 选单
            tsMenuItem = new ToolStripMenuItem();
            tsMenuItem.Text = "关闭(&C)";
            tsMenuItem.Click += new EventHandler(tsMenuExit_Click);
            tsMenuItem.Padding = new Padding(2, 0, 2, 0);
            muMenu.Items.Add(tsMenuItem);
        }

        private void TsSubMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsMenu = sender as ToolStripMenuItem;
            ShowMdiChildForm(tsMenu.Tag.ToString(),tsMenu.Name);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("确定要退出吗?", "提示", MessageBoxButtons.YesNo);
            if(dialogResult==DialogResult.Yes)
            {
                e.Cancel = false;
            }
        }

        public void ShowMdiChildForm(string dllName,string className)
        {
            //存放窗体文件的dll文件的路径
            string path = Application.StartupPath + $"\\{dllName}";
            Assembly ab = Assembly.LoadFrom(path);
            Form form = ab.CreateInstance(className) as Form;
            form.MdiParent = this;
            form.Show();
            form.Dock = DockStyle.Fill;
        }

        public void tsMenuExit_Click(object sender,EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.YesNo);
            if(result==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
