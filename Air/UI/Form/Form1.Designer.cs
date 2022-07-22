namespace Air
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BtnPanel = new Sunny.UI.UIPanel();
            this.btnAbout = new Sunny.UI.UIButton();
            this.lblUser = new Sunny.UI.UILabel();
            this.btnHardwareConfig = new Sunny.UI.UIButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.btnReport = new Sunny.UI.UIButton();
            this.btnTrendView = new Sunny.UI.UIButton();
            this.btnAlarmView = new Sunny.UI.UIButton();
            this.btnParamSet = new Sunny.UI.UIButton();
            this.btnIOMonitor = new Sunny.UI.UIButton();
            this.lblTime = new Sunny.UI.UILabel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.lblTitle = new Sunny.UI.UILabel();
            this.mainPanel = new Sunny.UI.UIPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnPanel.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnPanel
            // 
            this.BtnPanel.Controls.Add(this.btnAbout);
            this.BtnPanel.Controls.Add(this.lblUser);
            this.BtnPanel.Controls.Add(this.btnHardwareConfig);
            this.BtnPanel.Controls.Add(this.uiLabel2);
            this.BtnPanel.Controls.Add(this.btnReport);
            this.BtnPanel.Controls.Add(this.btnTrendView);
            this.BtnPanel.Controls.Add(this.btnAlarmView);
            this.BtnPanel.Controls.Add(this.btnParamSet);
            this.BtnPanel.Controls.Add(this.btnIOMonitor);
            this.BtnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.BtnPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.BtnPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPanel.Location = new System.Drawing.Point(0, 842);
            this.BtnPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnPanel.Name = "BtnPanel";
            this.BtnPanel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.BtnPanel.Size = new System.Drawing.Size(1400, 58);
            this.BtnPanel.Style = Sunny.UI.UIStyle.LayuiGreen;
            this.BtnPanel.TabIndex = 2;
            this.BtnPanel.Text = null;
            this.BtnPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAbout.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAbout.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.btnAbout.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnAbout.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnAbout.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAbout.Location = new System.Drawing.Point(824, 4);
            this.btnAbout.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAbout.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.btnAbout.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnAbout.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnAbout.Size = new System.Drawing.Size(129, 47);
            this.btnAbout.Style = Sunny.UI.UIStyle.LayuiGreen;
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "关    于";
            this.btnAbout.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAbout.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUser.Location = new System.Drawing.Point(1123, 12);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(141, 30);
            this.lblUser.Style = Sunny.UI.UIStyle.LayuiGreen;
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "系统管理员";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUser.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnHardwareConfig
            // 
            this.btnHardwareConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHardwareConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHardwareConfig.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnHardwareConfig.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnHardwareConfig.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.btnHardwareConfig.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnHardwareConfig.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnHardwareConfig.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHardwareConfig.Location = new System.Drawing.Point(689, 4);
            this.btnHardwareConfig.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnHardwareConfig.Name = "btnHardwareConfig";
            this.btnHardwareConfig.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnHardwareConfig.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.btnHardwareConfig.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnHardwareConfig.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnHardwareConfig.Size = new System.Drawing.Size(129, 47);
            this.btnHardwareConfig.Style = Sunny.UI.UIStyle.LayuiGreen;
            this.btnHardwareConfig.TabIndex = 0;
            this.btnHardwareConfig.Text = "硬件配置";
            this.btnHardwareConfig.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHardwareConfig.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnHardwareConfig.Click += new System.EventHandler(this.btnHardwareConfig_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(1013, 13);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(93, 29);
            this.uiLabel2.Style = Sunny.UI.UIStyle.LayuiGreen;
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "当前用户：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnReport.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnReport.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.btnReport.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnReport.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnReport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReport.Location = new System.Drawing.Point(554, 3);
            this.btnReport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnReport.Name = "btnReport";
            this.btnReport.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnReport.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.btnReport.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnReport.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnReport.Size = new System.Drawing.Size(129, 47);
            this.btnReport.Style = Sunny.UI.UIStyle.LayuiGreen;
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "数据报表";
            this.btnReport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReport.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnTrendView
            // 
            this.btnTrendView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTrendView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrendView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnTrendView.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnTrendView.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.btnTrendView.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnTrendView.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnTrendView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTrendView.Location = new System.Drawing.Point(419, 3);
            this.btnTrendView.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTrendView.Name = "btnTrendView";
            this.btnTrendView.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnTrendView.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.btnTrendView.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnTrendView.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnTrendView.Size = new System.Drawing.Size(129, 47);
            this.btnTrendView.Style = Sunny.UI.UIStyle.LayuiGreen;
            this.btnTrendView.TabIndex = 0;
            this.btnTrendView.Text = "趋势曲线";
            this.btnTrendView.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTrendView.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnTrendView.Click += new System.EventHandler(this.btnTrendView_Click);
            // 
            // btnAlarmView
            // 
            this.btnAlarmView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAlarmView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlarmView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAlarmView.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAlarmView.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.btnAlarmView.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnAlarmView.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnAlarmView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAlarmView.Location = new System.Drawing.Point(284, 3);
            this.btnAlarmView.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAlarmView.Name = "btnAlarmView";
            this.btnAlarmView.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAlarmView.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.btnAlarmView.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnAlarmView.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnAlarmView.Size = new System.Drawing.Size(129, 47);
            this.btnAlarmView.Style = Sunny.UI.UIStyle.LayuiGreen;
            this.btnAlarmView.TabIndex = 0;
            this.btnAlarmView.Text = "报警浏览";
            this.btnAlarmView.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAlarmView.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnAlarmView.Click += new System.EventHandler(this.btnAlarmView_Click);
            // 
            // btnParamSet
            // 
            this.btnParamSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnParamSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParamSet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnParamSet.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnParamSet.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.btnParamSet.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnParamSet.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnParamSet.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnParamSet.Location = new System.Drawing.Point(149, 3);
            this.btnParamSet.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnParamSet.Name = "btnParamSet";
            this.btnParamSet.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnParamSet.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.btnParamSet.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnParamSet.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnParamSet.Size = new System.Drawing.Size(129, 47);
            this.btnParamSet.Style = Sunny.UI.UIStyle.LayuiGreen;
            this.btnParamSet.TabIndex = 0;
            this.btnParamSet.Text = "参数设置";
            this.btnParamSet.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnParamSet.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnParamSet.Click += new System.EventHandler(this.btnParamSet_Click);
            // 
            // btnIOMonitor
            // 
            this.btnIOMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIOMonitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIOMonitor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnIOMonitor.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnIOMonitor.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.btnIOMonitor.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnIOMonitor.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnIOMonitor.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnIOMonitor.Location = new System.Drawing.Point(14, 3);
            this.btnIOMonitor.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnIOMonitor.Name = "btnIOMonitor";
            this.btnIOMonitor.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnIOMonitor.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.btnIOMonitor.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnIOMonitor.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnIOMonitor.Size = new System.Drawing.Size(129, 47);
            this.btnIOMonitor.Style = Sunny.UI.UIStyle.LayuiGreen;
            this.btnIOMonitor.TabIndex = 0;
            this.btnIOMonitor.Text = "数据监控";
            this.btnIOMonitor.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnIOMonitor.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnIOMonitor.Click += new System.EventHandler(this.btnIOMonitor_Click);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.Location = new System.Drawing.Point(1012, 15);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(216, 23);
            this.lblTime.Style = Sunny.UI.UIStyle.LayuiGreen;
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "2022-5-13 16:27";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTime.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.lblTitle);
            this.uiPanel1.Controls.Add(this.lblTime);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.uiPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 35);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.uiPanel1.Size = new System.Drawing.Size(1400, 58);
            this.uiPanel1.Style = Sunny.UI.UIStyle.LayuiGreen;
            this.uiPanel1.TabIndex = 5;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(513, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 47);
            this.lblTitle.Style = Sunny.UI.UIStyle.LayuiGreen;
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "界面名称";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.mainPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.mainPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mainPanel.Location = new System.Drawing.Point(0, 93);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.mainPanel.Size = new System.Drawing.Size(1400, 749);
            this.mainPanel.Style = Sunny.UI.UIStyle.LayuiGreen;
            this.mainPanel.TabIndex = 6;
            this.mainPanel.Text = null;
            this.mainPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.BtnPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExtendBox = true;
            this.ExtendSymbol = 61506;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Style = Sunny.UI.UIStyle.LayuiGreen;
            this.Text = "XXXX设备监测系统";
            this.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.BtnPanel.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIPanel BtnPanel;
        private Sunny.UI.UIButton btnIOMonitor;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel lblUser;
        private Sunny.UI.UILabel lblTime;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UIButton btnAbout;
        private Sunny.UI.UIButton btnHardwareConfig;
        private Sunny.UI.UIButton btnReport;
        private Sunny.UI.UIButton btnTrendView;
        private Sunny.UI.UIButton btnAlarmView;
        private Sunny.UI.UIButton btnParamSet;
        private Sunny.UI.UIPanel mainPanel;
        private System.Windows.Forms.Timer timer1;
    }
}

