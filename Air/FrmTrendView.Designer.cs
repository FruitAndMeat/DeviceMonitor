namespace Air
{
    partial class FrmTrendView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrendView));
            this.uiSplitContainer1 = new Sunny.UI.UISplitContainer();
            this.cmbTrendType = new Sunny.UI.UIComboBox();
            this.cmbTrendArea = new Sunny.UI.UIComboBox();
            this.uiCheckBoxGroup1 = new Sunny.UI.UICheckBoxGroup();
            this.btnConfirm = new Sunny.UI.UIButton();
            this.btnCancel = new Sunny.UI.UIButton();
            this.uiSplitContainer2 = new Sunny.UI.UISplitContainer();
            this.TrendChart = new Sunny.UI.UILineChart();
            this.DtpEnd = new Sunny.UI.UIDatetimePicker();
            this.DtpStart = new Sunny.UI.UIDatetimePicker();
            this.BtnQuery = new Sunny.UI.UIButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txtCount = new Sunny.UI.UIIntegerUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.uiSplitContainer1)).BeginInit();
            this.uiSplitContainer1.Panel1.SuspendLayout();
            this.uiSplitContainer1.Panel2.SuspendLayout();
            this.uiSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiSplitContainer2)).BeginInit();
            this.uiSplitContainer2.Panel1.SuspendLayout();
            this.uiSplitContainer2.Panel2.SuspendLayout();
            this.uiSplitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiSplitContainer1
            // 
            this.uiSplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSplitContainer1.IsSplitterFixed = true;
            this.uiSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.uiSplitContainer1.MinimumSize = new System.Drawing.Size(20, 20);
            this.uiSplitContainer1.Name = "uiSplitContainer1";
            // 
            // uiSplitContainer1.Panel1
            // 
            this.uiSplitContainer1.Panel1.Controls.Add(this.btnCancel);
            this.uiSplitContainer1.Panel1.Controls.Add(this.btnConfirm);
            this.uiSplitContainer1.Panel1.Controls.Add(this.uiCheckBoxGroup1);
            this.uiSplitContainer1.Panel1.Controls.Add(this.cmbTrendArea);
            this.uiSplitContainer1.Panel1.Controls.Add(this.cmbTrendType);
            // 
            // uiSplitContainer1.Panel2
            // 
            this.uiSplitContainer1.Panel2.Controls.Add(this.uiSplitContainer2);
            this.uiSplitContainer1.Size = new System.Drawing.Size(1280, 533);
            this.uiSplitContainer1.SplitterDistance = 185;
            this.uiSplitContainer1.SplitterWidth = 11;
            this.uiSplitContainer1.TabIndex = 0;
            this.uiSplitContainer1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cmbTrendType
            // 
            this.cmbTrendType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTrendType.DataSource = null;
            this.cmbTrendType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmbTrendType.FillColor = System.Drawing.Color.White;
            this.cmbTrendType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbTrendType.Location = new System.Drawing.Point(13, 13);
            this.cmbTrendType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTrendType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmbTrendType.Name = "cmbTrendType";
            this.cmbTrendType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmbTrendType.Size = new System.Drawing.Size(166, 29);
            this.cmbTrendType.TabIndex = 0;
            this.cmbTrendType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbTrendType.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cmbTrendType.SelectedIndexChanged += new System.EventHandler(this.cmbTrendType_SelectedIndexChanged);
            // 
            // cmbTrendArea
            // 
            this.cmbTrendArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTrendArea.DataSource = null;
            this.cmbTrendArea.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmbTrendArea.FillColor = System.Drawing.Color.White;
            this.cmbTrendArea.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbTrendArea.Location = new System.Drawing.Point(13, 52);
            this.cmbTrendArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTrendArea.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmbTrendArea.Name = "cmbTrendArea";
            this.cmbTrendArea.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmbTrendArea.Size = new System.Drawing.Size(166, 29);
            this.cmbTrendArea.TabIndex = 0;
            this.cmbTrendArea.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbTrendArea.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cmbTrendArea.SelectedIndexChanged += new System.EventHandler(this.cmbTrendArea_SelectedIndexChanged);
            // 
            // uiCheckBoxGroup1
            // 
            this.uiCheckBoxGroup1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiCheckBoxGroup1.ColumnInterval = 10;
            this.uiCheckBoxGroup1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCheckBoxGroup1.Items.AddRange(new object[] {
            "输出频率",
            "A相电流",
            "B相电流",
            "C相电流",
            "A相电压",
            "B相电压",
            "C相电压"});
            this.uiCheckBoxGroup1.Location = new System.Drawing.Point(13, 99);
            this.uiCheckBoxGroup1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup1.Name = "uiCheckBoxGroup1";
            this.uiCheckBoxGroup1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup1.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup1.SelectedIndexes")));
            this.uiCheckBoxGroup1.Size = new System.Drawing.Size(166, 287);
            this.uiCheckBoxGroup1.TabIndex = 1;
            this.uiCheckBoxGroup1.Text = "变量选择";
            this.uiCheckBoxGroup1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiCheckBoxGroup1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirm.Location = new System.Drawing.Point(11, 416);
            this.btnConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(169, 35);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirm.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(10, 480);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(169, 35);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // uiSplitContainer2
            // 
            this.uiSplitContainer2.CollapsePanel = Sunny.UI.UISplitContainer.UICollapsePanel.None;
            this.uiSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSplitContainer2.IsSplitterFixed = true;
            this.uiSplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.uiSplitContainer2.MinimumSize = new System.Drawing.Size(20, 20);
            this.uiSplitContainer2.Name = "uiSplitContainer2";
            this.uiSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // uiSplitContainer2.Panel1
            // 
            this.uiSplitContainer2.Panel1.Controls.Add(this.TrendChart);
            // 
            // uiSplitContainer2.Panel2
            // 
            this.uiSplitContainer2.Panel2.Controls.Add(this.txtCount);
            this.uiSplitContainer2.Panel2.Controls.Add(this.uiLabel1);
            this.uiSplitContainer2.Panel2.Controls.Add(this.DtpEnd);
            this.uiSplitContainer2.Panel2.Controls.Add(this.DtpStart);
            this.uiSplitContainer2.Panel2.Controls.Add(this.BtnQuery);
            this.uiSplitContainer2.Panel2.Controls.Add(this.uiLabel3);
            this.uiSplitContainer2.Panel2.Controls.Add(this.uiLabel2);
            this.uiSplitContainer2.Size = new System.Drawing.Size(1082, 531);
            this.uiSplitContainer2.SplitterDistance = 468;
            this.uiSplitContainer2.SplitterWidth = 1;
            this.uiSplitContainer2.TabIndex = 0;
            this.uiSplitContainer2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // TrendChart
            // 
            this.TrendChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrendChart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TrendChart.LegendFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TrendChart.Location = new System.Drawing.Point(0, 0);
            this.TrendChart.MinimumSize = new System.Drawing.Size(1, 1);
            this.TrendChart.Name = "TrendChart";
            this.TrendChart.Size = new System.Drawing.Size(1082, 468);
            this.TrendChart.SubFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TrendChart.TabIndex = 0;
            this.TrendChart.Text = "趋势曲线";
            this.TrendChart.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // DtpEnd
            // 
            this.DtpEnd.DateFormat = "yyyy-MM-dd HH:mm";
            this.DtpEnd.FillColor = System.Drawing.Color.White;
            this.DtpEnd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DtpEnd.Location = new System.Drawing.Point(430, 17);
            this.DtpEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpEnd.MaxLength = 16;
            this.DtpEnd.MinimumSize = new System.Drawing.Size(63, 0);
            this.DtpEnd.Name = "DtpEnd";
            this.DtpEnd.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.DtpEnd.Size = new System.Drawing.Size(201, 29);
            this.DtpEnd.SymbolDropDown = 61555;
            this.DtpEnd.SymbolNormal = 61555;
            this.DtpEnd.TabIndex = 9;
            this.DtpEnd.Text = "2022-06-28 16:02";
            this.DtpEnd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.DtpEnd.Value = new System.DateTime(2022, 6, 28, 16, 2, 34, 427);
            this.DtpEnd.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // DtpStart
            // 
            this.DtpStart.DateFormat = "yyyy-MM-dd HH:mm";
            this.DtpStart.FillColor = System.Drawing.Color.White;
            this.DtpStart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DtpStart.Location = new System.Drawing.Point(109, 17);
            this.DtpStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpStart.MaxLength = 16;
            this.DtpStart.MinimumSize = new System.Drawing.Size(63, 0);
            this.DtpStart.Name = "DtpStart";
            this.DtpStart.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.DtpStart.Size = new System.Drawing.Size(200, 29);
            this.DtpStart.SymbolDropDown = 61555;
            this.DtpStart.SymbolNormal = 61555;
            this.DtpStart.TabIndex = 10;
            this.DtpStart.Text = "2022-06-28 16:02";
            this.DtpStart.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.DtpStart.Value = new System.DateTime(2022, 6, 28, 16, 2, 34, 427);
            this.DtpStart.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // BtnQuery
            // 
            this.BtnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnQuery.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnQuery.Location = new System.Drawing.Point(924, 14);
            this.BtnQuery.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(115, 35);
            this.BtnQuery.TabIndex = 8;
            this.BtnQuery.Text = "查询";
            this.BtnQuery.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnQuery.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.BtnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(329, 20);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(101, 23);
            this.uiLabel3.TabIndex = 6;
            this.uiLabel3.Text = "截至时间：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(6, 20);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 7;
            this.uiLabel2.Text = "开始时间：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(653, 20);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 11;
            this.uiLabel1.Text = "显示数目：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCount.Location = new System.Drawing.Point(749, 17);
            this.txtCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCount.MinimumSize = new System.Drawing.Size(100, 0);
            this.txtCount.Name = "txtCount";
            this.txtCount.ShowText = false;
            this.txtCount.Size = new System.Drawing.Size(116, 29);
            this.txtCount.TabIndex = 12;
            this.txtCount.Text = "uiIntegerUpDown1";
            this.txtCount.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtCount.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // FrmTrendView
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 533);
            this.Controls.Add(this.uiSplitContainer1);
            this.Name = "FrmTrendView";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowTitle = false;
            this.Text = "FrmTrendView";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.FrmTrendView_Load);
            this.uiSplitContainer1.Panel1.ResumeLayout(false);
            this.uiSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiSplitContainer1)).EndInit();
            this.uiSplitContainer1.ResumeLayout(false);
            this.uiSplitContainer2.Panel1.ResumeLayout(false);
            this.uiSplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiSplitContainer2)).EndInit();
            this.uiSplitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISplitContainer uiSplitContainer1;
        private Sunny.UI.UIComboBox cmbTrendArea;
        private Sunny.UI.UIComboBox cmbTrendType;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup1;
        private Sunny.UI.UIButton btnCancel;
        private Sunny.UI.UIButton btnConfirm;
        private Sunny.UI.UISplitContainer uiSplitContainer2;
        private Sunny.UI.UILineChart TrendChart;
        private Sunny.UI.UIDatetimePicker DtpEnd;
        private Sunny.UI.UIDatetimePicker DtpStart;
        private Sunny.UI.UIButton BtnQuery;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIIntegerUpDown txtCount;
        private Sunny.UI.UILabel uiLabel1;
    }
}