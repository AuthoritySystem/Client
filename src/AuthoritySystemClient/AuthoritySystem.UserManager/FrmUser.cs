using AuthoritySystem.Common.Helper;
using AuthoritySystem.Model.Entity.ApiModel;
using AuthoritySystem.Model.Entity.ApiModel.Request;
using AuthoritySystem.Model.Entity.DbModel;
using Newtonsoft.Json;
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
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
             InitialData();
        }

        // 初始化数据
        private async void InitialData()
        {
            // 动态获取菜单
            string menuUrl = $"{ConfigHelper.GetValue("WebApiUrl")}/api/user/getlist";

            var responseData = await HttpClientHelper.PostObjectAsync<ApiResponseWithData<List<TB_User>>, UserRequestDto>(menuUrl,new UserRequestDto()
            { 
                  IsPaging=false
            });
            if (responseData.Code.Equals(1))
            {
                this.dgvUsers.DataSource = responseData.Data;
            }
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            FrmAddUser frmAddUser = new FrmAddUser();
            // 刷新数据
            frmAddUser.RefreshData = InitialData;
            frmAddUser.Show();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
