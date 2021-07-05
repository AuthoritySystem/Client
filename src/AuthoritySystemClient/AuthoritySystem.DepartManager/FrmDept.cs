using AuthoritySystem.Common.Helper;
using AuthoritySystem.Model.Entity.ApiModel;
using AuthoritySystem.Model.Entity.ApiModel.Request;
using AuthoritySystem.Model.Entity.DbModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AuthoritySystem.DepartManager
{
    public partial class FrmDept : Form
    {
        public FrmDept()
        {
            InitializeComponent();
        }

        // 初始化数据
        private async void InitialData()
        {
            // 动态获取菜单
            string menuUrl = $"{ConfigHelper.GetValue("WebApiUrl")}/api/Department";

            var responseData = await HttpClientHelper.GetObjectAsync<ApiResponseWithData<List<TB_Department>>>(menuUrl);
            if (responseData.Code.Equals(1))
            {
                this.dgvDept.DataSource = responseData.Data;
            }
        }

        private void FrmDept_Load(object sender, EventArgs e)
        {
            InitialData();
        }

        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            FrmDepartment dept = new FrmDepartment();
            dept.RefreshData = InitialData;
            dept.ShowDialog();
        }
    }
}
