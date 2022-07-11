namespace Air
{
    partial class FrmReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btnExport = new Sunny.UI.UIButton();
            this.btnPriview = new Sunny.UI.UIButton();
            this.btnPrint = new Sunny.UI.UIButton();
            this.btnQuery = new Sunny.UI.UIButton();
            this.dtpQueryTime = new Sunny.UI.UIDatetimePicker();
            this.cmbReportType = new Sunny.UI.UIComboBox();
            this.cmbClassSelect = new Sunny.UI.UIComboBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.dgvReport = new Sunny.UI.UIDataGridView();
            this.uiPanel1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.btnExport);
            this.uiPanel1.Controls.Add(this.btnPriview);
            this.uiPanel1.Controls.Add(this.btnPrint);
            this.uiPanel1.Controls.Add(this.btnQuery);
            this.uiPanel1.Controls.Add(this.dtpQueryTime);
            this.uiPanel1.Controls.Add(this.cmbReportType);
            this.uiPanel1.Controls.Add(this.cmbClassSelect);
            this.uiPanel1.Controls.Add(this.uiLabel3);
            this.uiPanel1.Controls.Add(this.uiLabel2);
            this.uiPanel1.Controls.Add(this.uiLabel1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1280, 69);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.Location = new System.Drawing.Point(1155, 15);
            this.btnExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 35);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Excel导出";
            this.btnExport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPriview
            // 
            this.btnPriview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPriview.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPriview.Location = new System.Drawing.Point(1039, 15);
            this.btnPriview.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPriview.Name = "btnPriview";
            this.btnPriview.Size = new System.Drawing.Size(100, 35);
            this.btnPriview.TabIndex = 3;
            this.btnPriview.Text = "Excel预览";
            this.btnPriview.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPriview.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnPriview.Click += new System.EventHandler(this.btnPriview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrint.Location = new System.Drawing.Point(923, 15);
            this.btnPrint.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 35);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "打印";
            this.btnPrint.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrint.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(807, 15);
            this.btnQuery.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(100, 35);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查询";
            this.btnQuery.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dtpQueryTime
            // 
            this.dtpQueryTime.DateFormat = "yyyy-MM-dd HH:00";
            this.dtpQueryTime.FillColor = System.Drawing.Color.White;
            this.dtpQueryTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpQueryTime.Location = new System.Drawing.Point(577, 19);
            this.dtpQueryTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpQueryTime.MaxLength = 16;
            this.dtpQueryTime.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpQueryTime.Name = "dtpQueryTime";
            this.dtpQueryTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpQueryTime.Size = new System.Drawing.Size(200, 29);
            this.dtpQueryTime.SymbolDropDown = 61555;
            this.dtpQueryTime.SymbolNormal = 61555;
            this.dtpQueryTime.TabIndex = 2;
            this.dtpQueryTime.Text = "2022-07-06 15:00";
            this.dtpQueryTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpQueryTime.Value = new System.DateTime(2022, 7, 6, 15, 33, 31, 824);
            this.dtpQueryTime.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cmbReportType
            // 
            this.cmbReportType.DataSource = null;
            this.cmbReportType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmbReportType.FillColor = System.Drawing.Color.White;
            this.cmbReportType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbReportType.Location = new System.Drawing.Point(346, 19);
            this.cmbReportType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbReportType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmbReportType.Size = new System.Drawing.Size(107, 29);
            this.cmbReportType.TabIndex = 1;
            this.cmbReportType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbReportType.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cmbReportType.SelectedIndexChanged += new System.EventHandler(this.cmbReportType_SelectedIndexChanged);
            // 
            // cmbClassSelect
            // 
            this.cmbClassSelect.DataSource = null;
            this.cmbClassSelect.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmbClassSelect.FillColor = System.Drawing.Color.White;
            this.cmbClassSelect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbClassSelect.Location = new System.Drawing.Point(118, 19);
            this.cmbClassSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbClassSelect.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmbClassSelect.Name = "cmbClassSelect";
            this.cmbClassSelect.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmbClassSelect.Size = new System.Drawing.Size(113, 29);
            this.cmbClassSelect.TabIndex = 1;
            this.cmbClassSelect.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbClassSelect.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cmbClassSelect.SelectedIndexChanged += new System.EventHandler(this.cmbClassSelect_SelectedIndexChanged);
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(486, 23);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(90, 21);
            this.uiLabel3.TabIndex = 0;
            this.uiLabel3.Text = "日期时间：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(256, 23);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(90, 21);
            this.uiLabel2.TabIndex = 0;
            this.uiLabel2.Text = "报表类型：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(25, 23);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(90, 21);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "班组类型：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.dgvReport);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel2.Location = new System.Drawing.Point(0, 69);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(1280, 500);
            this.uiPanel2.TabIndex = 1;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AllowUserToResizeColumns = false;
            this.dgvReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.EnableHeadersVisualStyles = false;
            this.dgvReport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgvReport.Location = new System.Drawing.Point(0, 0);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReport.RowHeight = 0;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgvReport.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReport.RowTemplate.Height = 23;
            this.dgvReport.SelectedIndex = -1;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.ShowGridLine = false;
            this.dgvReport.ShowRect = false;
            this.dgvReport.Size = new System.Drawing.Size(1280, 500);
            this.dgvReport.TabIndex = 0;
            this.dgvReport.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // FrmReport
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 569);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.Name = "FrmReport";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowTitle = false;
            this.Text = "FrmReport";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            this.uiPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIComboBox cmbReportType;
        private Sunny.UI.UIComboBox cmbClassSelect;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIButton btnExport;
        private Sunny.UI.UIButton btnPriview;
        private Sunny.UI.UIButton btnPrint;
        private Sunny.UI.UIButton btnQuery;
        private Sunny.UI.UIDatetimePicker dtpQueryTime;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIDataGridView dgvReport;
    }
}