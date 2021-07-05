using AuthoritySystem.Common.Helper;
using AuthoritySystem.Model.Entity.ApiModel;
using AuthoritySystem.Model.Entity.DbModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthoritySystem.MenuManager
{
    public partial class FrmAddMenu : Form
    {
        public Action RefreshData;

        public FrmAddMenu()
        {
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要取消吗?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string url = $"{ConfigHelper.GetValue("WebApiUrl")}/api/Menu";

            TB_Menu menu = new TB_Menu()
            {
                MenuName = this.txtName.Text,
                Url = txtUrl.Text,
                NameSpace = txtNameSpace.Text,
                ClassName=txtClassName.Text,
                ParentID=Guid.Parse("799643b8-37f6-4b66-8af8-260fcc824801")
            };

            var responseData = await HttpClientHelper.PostObjectAsync<ApiResponse, TB_Menu>(url, menu);
            if (responseData.Code.Equals(1))
            {
                MessageBox.Show("添加菜单成功");
                this.Close();
                // 调用委托刷新数据
                RefreshData();
            }
        }
    }
}
