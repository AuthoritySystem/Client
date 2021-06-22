using AuthoritySystem.Common.Helper;
using AuthoritySystem.Model.Entity.ApiModel;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace AuthoritySystem.Win
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private  async void btnLogin_Click(object sender, EventArgs e)
        {
            string loginId = this.txtUserName.Text.Trim();
            string pwd = this.txtPwd.Text.Trim();
            if (string.IsNullOrEmpty(loginId))
            {
                MessageBox.Show("用户名不能为空，请重新输入!");
                this.txtUserName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("密码不能为空，请重新输入!");
                this.txtPwd.Focus();
                return;
            }
            // 调用后端api接口
            string url=  $"{ConfigHelper.GetValue("WebApiUrl")}/api/login";
            var result = await HttpClientHelper.PostObjectAsync<ApiResponse, LoginRequestDto>(url, new LoginRequestDto()
            {
                LoginID = loginId,
                Password = pwd
            });
            if(result.Code==1)
            {
                MessageBox.Show("登录成功");
                // 显示主窗体
                FrmMain frmMain = new FrmMain();
                frmMain.WindowState = FormWindowState.Maximized;
                DialogResult dialogResult = frmMain.ShowDialog();
                // 主窗体退出
                if (dialogResult == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show(JsonConvert.SerializeObject(result));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancle_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("确定要退出登录吗？", "提示", MessageBoxButtons.YesNo);
            // 退出
            if(result==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
