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
    public partial class FrmMenuManager : Form
    {
        public FrmMenuManager()
        {
            InitializeComponent();
        }

        private void FrmMenuManager_Load(object sender, EventArgs e)
        {
            InitialData();
        }

        // 初始化数据
        private async void InitialData()
        {
            // 动态获取菜单
            string menuUrl = $"{ConfigHelper.GetValue("WebApiUrl")}/api/Menu";

            var responseData = await HttpClientHelper.GetObjectAsync<ApiResponseWithData<List<TB_Menu>>>(menuUrl);
            if (responseData != null && responseData.Code.Equals(1))
            {
                this.dgv_Menu.DataSource = responseData.Data;
            }
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtn_Add_Click(object sender, EventArgs e)
        {
            FrmAddMenu frmAddMenu = new FrmAddMenu();
            frmAddMenu.RefreshData = InitialData;
            frmAddMenu.ShowDialog();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void tsbtn_Del_Click(object sender, EventArgs e)
        {
            var rows = dgv_Menu.SelectedRows;
            if (rows.Count > 0)
            {
                string id= rows[0].Cells["ID"].Value.ToString();
                string menuUrl = $"{ConfigHelper.GetValue("WebApiUrl")}/api/Menu?id={id}";

                var responseData = await HttpClientHelper.DeleteObjectAsync<ApiResponse>(menuUrl);
                if (responseData != null && responseData.Code.Equals(1))
                {
                    MessageBox.Show("删除数据成功");
                    InitialData();
                }
            }
            else
            {
                MessageBox.Show("请先选中要删除的行");
            }
        }
    }
}
