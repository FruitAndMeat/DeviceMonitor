using DAL;
using Models;
using Sunny.UI;
using System;
using System.Windows.Forms;

namespace Air
{
    public partial class FrmLogin : UILoginForm
    {
        public FrmLogin() {
            InitializeComponent();
        }
        AdminServices adminServices = new AdminServices();

        private void FrmLogin_ButtonLoginClick(object sender, EventArgs e) {
            GetAdmin();
        }

        async void GetAdmin() {
            Admins objAdmin = new Admins() { LoginID = Convert.ToInt32(UserName), LoginPwd = Password };
            this.pgbar.Visible = true;
            await adminServices.AdminLoginAsync(objAdmin);
            if (objAdmin != null) {
                this.DialogResult = DialogResult.OK;
                CommonData.SysAdmin = objAdmin;
            }
            else {
                UIMessageBox.Show("登录失败,请检查用户名及登录密码！", "登陆提示");
            }
            pgbar.Visible = false;

        }
    }
}
