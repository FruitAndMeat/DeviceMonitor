﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;
using System.Windows.Forms;
using Sunny.UI;

namespace Air
{
    public partial class FrmLogin : UILoginForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        AdminServices adminServices = new AdminServices();

        private void FrmLogin_ButtonLoginClick(object sender, EventArgs e)
        {
            Admins objAdmin = new Admins() { LoginID = Convert.ToInt32(UserName), LoginPwd = Password };

            objAdmin = adminServices.AdminLogin(objAdmin);
            if (objAdmin != null)
            {
                this.DialogResult = DialogResult.OK;
                CommonData.SysAdmin = objAdmin;
            }
            else
            {
                UIMessageBox.Show("登录失败,请检查用户名及登录密码！", "登陆提示");
            }
        }
    }
}
