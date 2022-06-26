namespace Air
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "XXXX设备监测系统";
            // 
            // lblSubText
            // 
            this.lblSubText.Location = new System.Drawing.Point(376, 421);
            this.lblSubText.Text = "一个小小的项目";
            // 
            // FrmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.LoginImage = Sunny.UI.UILoginForm.UILoginImage.Login4;
            this.Name = "FrmLogin";
            this.Password = "123456";
            this.SubText = "一个小小的项目";
            this.Text = "登录窗口";
            this.Title = "XXXX设备监测系统";
            this.UserName = "10001";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 750, 450);
            this.ButtonLoginClick += new System.EventHandler(this.FrmLogin_ButtonLoginClick);
            this.OnLogin += new Sunny.UI.UILoginForm.OnLoginHandle(this.FrmLogin_OnLogin);
            this.ResumeLayout(false);

        }

        #endregion
    }
}