namespace Air
{
    partial class FrmHardwareConfig
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
            this.leftPanel = new Sunny.UI.UIPanel();
            this.btnUserConfig = new Sunny.UI.UIButton();
            this.btnReportConfig = new Sunny.UI.UIButton();
            this.btnTrendConfig = new Sunny.UI.UIButton();
            this.btnAlarmConfig = new Sunny.UI.UIButton();
            this.btnParamsSetConfig = new Sunny.UI.UIButton();
            this.btnVariableConfig = new Sunny.UI.UIButton();
            this.btnModbusConfig = new Sunny.UI.UIButton();
            this.rightPanel = new Sunny.UI.UIPanel();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.btnUserConfig);
            this.leftPanel.Controls.Add(this.btnReportConfig);
            this.leftPanel.Controls.Add(this.btnTrendConfig);
            this.leftPanel.Controls.Add(this.btnAlarmConfig);
            this.leftPanel.Controls.Add(this.btnParamsSetConfig);
            this.leftPanel.Controls.Add(this.btnVariableConfig);
            this.leftPanel.Controls.Add(this.btnModbusConfig);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.leftPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(210, 533);
            this.leftPanel.TabIndex = 0;
            this.leftPanel.Text = null;
            this.leftPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.leftPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnUserConfig
            // 
            this.btnUserConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserConfig.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUserConfig.Location = new System.Drawing.Point(10, 441);
            this.btnUserConfig.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUserConfig.Name = "btnUserConfig";
            this.btnUserConfig.Size = new System.Drawing.Size(188, 35);
            this.btnUserConfig.TabIndex = 0;
            this.btnUserConfig.Text = "用户权限配置";
            this.btnUserConfig.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUserConfig.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnUserConfig.Click += new System.EventHandler(this.btnUserConfig_Click);
            // 
            // btnReportConfig
            // 
            this.btnReportConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportConfig.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReportConfig.Location = new System.Drawing.Point(10, 376);
            this.btnReportConfig.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnReportConfig.Name = "btnReportConfig";
            this.btnReportConfig.Size = new System.Drawing.Size(188, 35);
            this.btnReportConfig.TabIndex = 0;
            this.btnReportConfig.Text = "报表信息配置";
            this.btnReportConfig.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReportConfig.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnReportConfig.Click += new System.EventHandler(this.btnReportConfig_Click);
            // 
            // btnTrendConfig
            // 
            this.btnTrendConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrendConfig.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTrendConfig.Location = new System.Drawing.Point(10, 311);
            this.btnTrendConfig.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTrendConfig.Name = "btnTrendConfig";
            this.btnTrendConfig.Size = new System.Drawing.Size(188, 35);
            this.btnTrendConfig.TabIndex = 0;
            this.btnTrendConfig.Text = "趋势信息配置";
            this.btnTrendConfig.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTrendConfig.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnTrendConfig.Click += new System.EventHandler(this.btnTrendConfig_Click);
            // 
            // btnAlarmConfig
            // 
            this.btnAlarmConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlarmConfig.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAlarmConfig.Location = new System.Drawing.Point(10, 246);
            this.btnAlarmConfig.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAlarmConfig.Name = "btnAlarmConfig";
            this.btnAlarmConfig.Size = new System.Drawing.Size(188, 35);
            this.btnAlarmConfig.TabIndex = 0;
            this.btnAlarmConfig.Text = "报警信息配置";
            this.btnAlarmConfig.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAlarmConfig.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnAlarmConfig.Click += new System.EventHandler(this.btnAlarmConfig_Click);
            // 
            // btnParamsSetConfig
            // 
            this.btnParamsSetConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParamsSetConfig.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnParamsSetConfig.Location = new System.Drawing.Point(10, 181);
            this.btnParamsSetConfig.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnParamsSetConfig.Name = "btnParamsSetConfig";
            this.btnParamsSetConfig.Size = new System.Drawing.Size(188, 35);
            this.btnParamsSetConfig.TabIndex = 0;
            this.btnParamsSetConfig.Text = "参数设置配置";
            this.btnParamsSetConfig.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnParamsSetConfig.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnParamsSetConfig.Click += new System.EventHandler(this.btnParamsSetConfig_Click);
            // 
            // btnVariableConfig
            // 
            this.btnVariableConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVariableConfig.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnVariableConfig.Location = new System.Drawing.Point(10, 116);
            this.btnVariableConfig.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnVariableConfig.Name = "btnVariableConfig";
            this.btnVariableConfig.Size = new System.Drawing.Size(188, 35);
            this.btnVariableConfig.TabIndex = 0;
            this.btnVariableConfig.Text = "I O 变 量 配置";
            this.btnVariableConfig.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnVariableConfig.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnVariableConfig.Click += new System.EventHandler(this.btnVariableConfig_Click);
            // 
            // btnModbusConfig
            // 
            this.btnModbusConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModbusConfig.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnModbusConfig.Location = new System.Drawing.Point(10, 51);
            this.btnModbusConfig.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnModbusConfig.Name = "btnModbusConfig";
            this.btnModbusConfig.Size = new System.Drawing.Size(188, 35);
            this.btnModbusConfig.TabIndex = 0;
            this.btnModbusConfig.Text = "通讯协议配置";
            this.btnModbusConfig.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnModbusConfig.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnModbusConfig.Click += new System.EventHandler(this.btnModbusConfig_Click);
            // 
            // rightPanel
            // 
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rightPanel.Location = new System.Drawing.Point(210, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rightPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(1070, 533);
            this.rightPanel.TabIndex = 1;
            this.rightPanel.Text = null;
            this.rightPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rightPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // FrmHardwareConfig
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 533);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Name = "FrmHardwareConfig";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowTitle = false;
            this.Text = "FrmHardwareConfig";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.FrmHardwareConfig_Load);
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel leftPanel;
        private Sunny.UI.UIButton btnUserConfig;
        private Sunny.UI.UIButton btnReportConfig;
        private Sunny.UI.UIButton btnTrendConfig;
        private Sunny.UI.UIButton btnAlarmConfig;
        private Sunny.UI.UIButton btnParamsSetConfig;
        private Sunny.UI.UIButton btnVariableConfig;
        private Sunny.UI.UIButton btnModbusConfig;
        private Sunny.UI.UIPanel rightPanel;
    }
}