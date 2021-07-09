using AuthoritySystem.Common.Helper;
using AuthoritySystem.Model.Entity.ApiModel;
using AuthoritySystem.Model.Entity.ApiModel.Request;
using AuthoritySystem.Model.Entity.DbModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AuthoritySystem.RoleManager
{
    public partial class FrmRoleManager : Form
    {
        public FrmRoleManager()
        {
            InitializeComponent();
        }

        // 初始化数据
        private async void InitialData()
        {
            // 动态获取菜单
            string menuUrl = $"{ConfigHelper.GetValue("WebApiUrl")}/api/Role/getlist";

            var responseData = await HttpClientHelper.PostObjectAsync<ApiResponseWithData<List<TB_Role>>, PagingRequest>(menuUrl, new UserRequestDto()
            {
                IsPaging = false
            });
            if (responseData.Code.Equals(1))
            {
                this.dgvRole.DataSource = responseData.Data;
            }
        }

        private void FrmRoleManager_Load(object sender, EventArgs e)
        {
            InitialData();
        }

        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            FrmRole frmRole = new FrmRole();
            frmRole.RefreshData = InitialData;
            frmRole.ShowDialog();
        }

        private void tsBtnAuthority_Click(object sender, EventArgs e)
        {
            var rows = dgvRole.SelectedRows;
            if(rows.Count>0)
            {
                FrmRoleMenu frmRoleMenu = new FrmRoleMenu();
                frmRoleMenu.RoleId = Guid.Parse(rows[0].Cells["ID"].Value.ToString());
                frmRoleMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("请先选中要设置权限的行");
            }
       
        }
    }
}
