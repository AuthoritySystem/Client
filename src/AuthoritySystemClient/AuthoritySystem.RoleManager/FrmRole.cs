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

namespace AuthoritySystem.RoleManager
{
    public partial class FrmRole : Form
    {
        // 刷新数据委托
        public Action RefreshData;

        public FrmRole()
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
            string url = $"{ConfigHelper.GetValue("WebApiUrl")}/api/Role";

            TB_Role role = new TB_Role()
            {
                RoleName=txtRoleName.Text
            };

            var responseData = await HttpClientHelper.PostObjectAsync<ApiResponse, TB_Role>(url, role);
            if (responseData.Code.Equals(1))
            {
                MessageBox.Show("添加角色成功");
                this.Close();
                // 调用委托刷新数据
                RefreshData();
            }
        }
    }
}
