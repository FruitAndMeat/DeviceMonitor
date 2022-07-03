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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrendView));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.uiSplitContainer1 = new Sunny.UI.UISplitContainer();
            this.btnCancel = new Sunny.UI.UIButton();
            this.btnConfirm = new Sunny.UI.UIButton();
            this.GrpVarSelect = new Sunny.UI.UICheckBoxGroup();
            this.cmbTrendArea = new Sunny.UI.UIComboBox();
            this.cmbTrendType = new Sunny.UI.UIComboBox();
            this.uiSplitContainer2 = new Sunny.UI.UISplitContainer();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtCount = new Sunny.UI.UIIntegerUpDown();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.DtpEnd = new Sunny.UI.UIDatetimePicker();
            this.DtpStart = new Sunny.UI.UIDatetimePicker();
            this.BtnStop = new Sunny.UI.UIButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uiSplitContainer1)).BeginInit();
            this.uiSplitContainer1.Panel1.SuspendLayout();
            this.uiSplitContainer1.Panel2.SuspendLayout();
            this.uiSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiSplitContainer2)).BeginInit();
            this.uiSplitContainer2.Panel1.SuspendLayout();
            this.uiSplitContainer2.Panel2.SuspendLayout();
            this.uiSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.uiSplitContainer1.Panel1.Controls.Add(this.GrpVarSelect);
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
            // GrpVarSelect
            // 
            this.GrpVarSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpVarSelect.ColumnInterval = 10;
            this.GrpVarSelect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GrpVarSelect.Items.AddRange(new object[] {
            "输出频率",
            "A相电流",
            "B相电流",
            "C相电流",
            "A相电压",
            "B相电压",
            "C相电压"});
            this.GrpVarSelect.Location = new System.Drawing.Point(13, 99);
            this.GrpVarSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrpVarSelect.MinimumSize = new System.Drawing.Size(1, 1);
            this.GrpVarSelect.Name = "GrpVarSelect";
            this.GrpVarSelect.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.GrpVarSelect.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("GrpVarSelect.SelectedIndexes")));
            this.GrpVarSelect.Size = new System.Drawing.Size(166, 287);
            this.GrpVarSelect.TabIndex = 1;
            this.GrpVarSelect.Text = "变量选择";
            this.GrpVarSelect.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.GrpVarSelect.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
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
            this.uiSplitContainer2.Panel1.Controls.Add(this.chart1);
            // 
            // uiSplitContainer2.Panel2
            // 
            this.uiSplitContainer2.Panel2.Controls.Add(this.txtCount);
            this.uiSplitContainer2.Panel2.Controls.Add(this.uiLabel1);
            this.uiSplitContainer2.Panel2.Controls.Add(this.DtpEnd);
            this.uiSplitContainer2.Panel2.Controls.Add(this.DtpStart);
            this.uiSplitContainer2.Panel2.Controls.Add(this.BtnStop);
            this.uiSplitContainer2.Panel2.Controls.Add(this.uiLabel3);
            this.uiSplitContainer2.Panel2.Controls.Add(this.uiLabel2);
            this.uiSplitContainer2.Size = new System.Drawing.Size(1082, 531);
            this.uiSplitContainer2.SplitterDistance = 468;
            this.uiSplitContainer2.SplitterWidth = 1;
            this.uiSplitContainer2.TabIndex = 0;
            this.uiSplitContainer2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.AxisX.LabelStyle.Format = "yyyy-MM-dd HH:mm:ss";
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.Title = "时间";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea1.AxisX2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Interval = 0D;
            chartArea1.AxisY.Maximum = 400D;
            chartArea1.AxisY.MaximumAutoSize = 100F;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            chartArea1.AxisY.Title = "电压值";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            chartArea1.AxisY2.Title = "电流与输出频率值";
            chartArea1.AxisY2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 5F;
            legend1.Position.Width = 8F;
            legend1.Position.X = 90F;
            legend1.Position.Y = 3F;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1082, 468);
            this.chart1.TabIndex = 0;
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCount.HasMaximum = true;
            this.txtCount.HasMinimum = true;
            this.txtCount.Location = new System.Drawing.Point(749, 17);
            this.txtCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCount.Maximum = 600;
            this.txtCount.MaximumEnabled = true;
            this.txtCount.Minimum = 0;
            this.txtCount.MinimumEnabled = true;
            this.txtCount.MinimumSize = new System.Drawing.Size(100, 0);
            this.txtCount.Name = "txtCount";
            this.txtCount.ShowText = false;
            this.txtCount.Size = new System.Drawing.Size(116, 29);
            this.txtCount.TabIndex = 12;
            this.txtCount.Text = "uiIntegerUpDown1";
            this.txtCount.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtCount.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
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
            // BtnStop
            // 
            this.BtnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStop.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnStop.Location = new System.Drawing.Point(932, 11);
            this.BtnStop.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(115, 35);
            this.BtnStop.TabIndex = 8;
            this.BtnStop.Text = "暂停更新";
            this.BtnStop.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnStop.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.BtnStop.Click += new System.EventHandler(this.BtnQuery_Click);
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
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISplitContainer uiSplitContainer1;
        private Sunny.UI.UIComboBox cmbTrendArea;
        private Sunny.UI.UIComboBox cmbTrendType;
        private Sunny.UI.UICheckBoxGroup GrpVarSelect;
        private Sunny.UI.UIButton btnCancel;
        private Sunny.UI.UIButton btnConfirm;
        private Sunny.UI.UISplitContainer uiSplitContainer2;
        private Sunny.UI.UIDatetimePicker DtpEnd;
        private Sunny.UI.UIDatetimePicker DtpStart;
        private Sunny.UI.UIButton BtnStop;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIIntegerUpDown txtCount;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}