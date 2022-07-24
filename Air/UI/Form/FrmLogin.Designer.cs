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
            this.pgbar = new Sunny.UI.UIProgressIndicator();
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
            // pgbar
            // 
            this.pgbar.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pgbar.Location = new System.Drawing.Point(291, 217);
            this.pgbar.MinimumSize = new System.Drawing.Size(1, 1);
            this.pgbar.Name = "pgbar";
            this.pgbar.Size = new System.Drawing.Size(100, 100);
            this.pgbar.TabIndex = 10;
            this.pgbar.Text = "uiProgressIndicator1";
            this.pgbar.Visible = false;
            this.pgbar.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // FrmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pgbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LoginImage = Sunny.UI.UILoginForm.UILoginImage.Login4;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Password = "123456";
            this.ShowInTaskbar = true;
            this.SubText = "一个小小的项目";
            this.Text = "登录窗口";
            this.Title = "XXXX设备监测系统";
            this.TopMost = true;
            this.UserName = "10001";
            this.ButtonLoginClick += new System.EventHandler(this.FrmLogin_ButtonLoginClick);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.lblSubText, 0);
            this.Controls.SetChildIndex(this.uiPanel1, 0);
            this.Controls.SetChildIndex(this.pgbar, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIProgressIndicator pgbar;
    }
}