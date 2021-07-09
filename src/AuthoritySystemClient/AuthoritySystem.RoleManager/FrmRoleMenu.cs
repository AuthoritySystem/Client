using AuthoritySystem.Common.Helper;
using AuthoritySystem.Model.Entity.ApiModel;
using AuthoritySystem.Model.Entity.ApiModel.Request;
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
    public partial class FrmRoleMenu : Form
    {
        public Guid RoleId { get; set; }

        public FrmRoleMenu()
        {
            InitializeComponent();
        }

        private void FrmRoleMenu_Load(object sender, EventArgs e)
        {
            InitialData();
        }

        // 初始化数据
        private async void InitialData()
        {
            // 动态获取菜单
            string menuUrl = $"{ConfigHelper.GetValue("WebApiUrl")}/api/RoleMenu/getlist?id={RoleId}";

            var responseData = await HttpClientHelper.GetObjectAsync<ApiResponseWithData<List<TB_RoleMenu>>>(menuUrl);
            if (responseData !=null && responseData.Code.Equals(1))
            {
                this.dgvRoleMenu.DataSource = responseData.Data;
            }
        }

        private void tsbtn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
