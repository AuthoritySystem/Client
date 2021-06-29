using AuthoritySystem.Common.Helper;
using AuthoritySystem.Model.Entity.ApiModel;
using AuthoritySystem.Model.Entity.DbModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AuthoritySystem.DepartManager
{
    public partial class FrmDepartment : Form
    {
        // 刷新数据委托
        public Action RefreshData;

        public FrmDepartment()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string url = $"{ConfigHelper.GetValue("WebApiUrl")}/api/Department";

            TB_Department dept = new TB_Department()
            {
                DepartmentName=txtDeptName.Text
            };

            var responseData = await HttpClientHelper.PostObjectAsync<ApiResponse, TB_Department>(url, dept);
            if (responseData.Code.Equals(1))
            {
                MessageBox.Show("添加部门成功");
                this.Close();
                // 调用委托刷新数据
                RefreshData();
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要取消吗?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
