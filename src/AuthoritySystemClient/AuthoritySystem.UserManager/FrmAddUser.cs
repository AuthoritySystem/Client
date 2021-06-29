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

namespace AuthoritySystem.UserManager
{
    public partial class FrmAddUser : Form
    {

        public Action RefreshData;

        public FrmAddUser()
        {
            InitializeComponent();
        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("确定要取消吗?","提示",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            string url= $"{ConfigHelper.GetValue("WebApiUrl")}/api/user";

            TB_User user = new TB_User()
            {
                LoginID = this.txtLogin.Text,
                Password = TxtPwd.Text,
                Name = TxtName.Text,
                LoginErrorCount=0,
                Status=0
            };

            var responseData = await HttpClientHelper.PostObjectAsync<ApiResponse, TB_User>(url,user);
            if (responseData.Code.Equals(1))
            {
                MessageBox.Show("添加用户成功");
                this.Close();
                // 调用委托刷新数据
                RefreshData();
            }
        }
    }
}
