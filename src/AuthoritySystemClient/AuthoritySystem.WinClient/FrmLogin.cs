using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthoritySystem.WinClient
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnlogin_Click(object sender, EventArgs e)
        {
            //string loginUrl = $"{ConfigHelper.GetValue("WebApiUrl")}/api/login";
            //LoginRequestDto requestDto = new LoginRequestDto()
            //{
            //    LoginID = this.txtLoginID.Text.Trim(),
            //    Password = this.txtPwd.Text.Trim()
            //};
            //var result = await HttpClientHelper.PostObjectAsync<ResultContent<string>, LoginRequestDto>(loginUrl, requestDto);
            //if (result.Code == SystemCode.Success)
            //{
            //    this.DialogResult = DialogResult.OK;
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show(result.Msg);
            //}
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btncancle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要取消吗?", "提示", MessageBoxButtons.YesNo);
            // 
            if(result==DialogResult.Yes)
            {
                Application.Exit();
            }
          
        }
    }
}
