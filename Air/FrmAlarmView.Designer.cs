﻿namespace Air
{
    partial class FrmAlarmView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiSplitContainer1 = new Sunny.UI.UISplitContainer();
            this.DtpEnd = new Sunny.UI.UIDatetimePicker();
            this.DtpStart = new Sunny.UI.UIDatetimePicker();
            this.BtnQuery = new Sunny.UI.UIButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.cmbAlarmType = new Sunny.UI.UIComboBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.dgvAlarm = new Sunny.UI.UIDataGridView();
            this.alarmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uiSplitContainer1)).BeginInit();
            this.uiSplitContainer1.Panel1.SuspendLayout();
            this.uiSplitContainer1.Panel2.SuspendLayout();
            this.uiSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarm)).BeginInit();
            this.SuspendLayout();
            // 
            // uiSplitContainer1
            // 
            this.uiSplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiSplitContainer1.CollapsePanel = Sunny.UI.UISplitContainer.UICollapsePanel.None;
            this.uiSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSplitContainer1.IsSplitterFixed = true;
            this.uiSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.uiSplitContainer1.MinimumSize = new System.Drawing.Size(20, 20);
            this.uiSplitContainer1.Name = "uiSplitContainer1";
            this.uiSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // uiSplitContainer1.Panel1
            // 
            this.uiSplitContainer1.Panel1.Controls.Add(this.DtpEnd);
            this.uiSplitContainer1.Panel1.Controls.Add(this.DtpStart);
            this.uiSplitContainer1.Panel1.Controls.Add(this.BtnQuery);
            this.uiSplitContainer1.Panel1.Controls.Add(this.uiLabel3);
            this.uiSplitContainer1.Panel1.Controls.Add(this.uiLabel2);
            this.uiSplitContainer1.Panel1.Controls.Add(this.cmbAlarmType);
            this.uiSplitContainer1.Panel1.Controls.Add(this.uiLabel1);
            // 
            // uiSplitContainer1.Panel2
            // 
            this.uiSplitContainer1.Panel2.Controls.Add(this.dgvAlarm);
            this.uiSplitContainer1.Size = new System.Drawing.Size(1280, 533);
            this.uiSplitContainer1.SplitterDistance = 75;
            this.uiSplitContainer1.SplitterWidth = 2;
            this.uiSplitContainer1.TabIndex = 0;
            this.uiSplitContainer1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // DtpEnd
            // 
            this.DtpEnd.DateFormat = "yyyy-MM-dd HH:mm";
            this.DtpEnd.FillColor = System.Drawing.Color.White;
            this.DtpEnd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DtpEnd.Location = new System.Drawing.Point(806, 19);
            this.DtpEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpEnd.MaxLength = 16;
            this.DtpEnd.MinimumSize = new System.Drawing.Size(63, 0);
            this.DtpEnd.Name = "DtpEnd";
            this.DtpEnd.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.DtpEnd.Size = new System.Drawing.Size(200, 29);
            this.DtpEnd.SymbolDropDown = 61555;
            this.DtpEnd.SymbolNormal = 61555;
            this.DtpEnd.TabIndex = 5;
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
            this.DtpStart.Location = new System.Drawing.Point(466, 19);
            this.DtpStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpStart.MaxLength = 16;
            this.DtpStart.MinimumSize = new System.Drawing.Size(63, 0);
            this.DtpStart.Name = "DtpStart";
            this.DtpStart.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.DtpStart.Size = new System.Drawing.Size(200, 29);
            this.DtpStart.SymbolDropDown = 61555;
            this.DtpStart.SymbolNormal = 61555;
            this.DtpStart.TabIndex = 5;
            this.DtpStart.Text = "2022-06-28 16:02";
            this.DtpStart.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.DtpStart.Value = new System.DateTime(2022, 6, 28, 16, 2, 34, 427);
            this.DtpStart.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // BtnQuery
            // 
            this.BtnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnQuery.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnQuery.Location = new System.Drawing.Point(1067, 16);
            this.BtnQuery.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(100, 35);
            this.BtnQuery.TabIndex = 4;
            this.BtnQuery.Text = "查询";
            this.BtnQuery.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnQuery.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.BtnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(699, 22);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "截至时间：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(376, 22);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "开始时间：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cmbAlarmType
            // 
            this.cmbAlarmType.DataSource = null;
            this.cmbAlarmType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmbAlarmType.FillColor = System.Drawing.Color.White;
            this.cmbAlarmType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbAlarmType.Location = new System.Drawing.Point(130, 19);
            this.cmbAlarmType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAlarmType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmbAlarmType.Name = "cmbAlarmType";
            this.cmbAlarmType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmbAlarmType.Size = new System.Drawing.Size(150, 29);
            this.cmbAlarmType.TabIndex = 1;
            this.cmbAlarmType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbAlarmType.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cmbAlarmType.SelectedIndexChanged += new System.EventHandler(this.cmbAlarmType_SelectedIndexChanged);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(23, 22);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "故障类型：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // dgvAlarm
            // 
            this.dgvAlarm.AllowUserToAddRows = false;
            this.dgvAlarm.AllowUserToDeleteRows = false;
            this.dgvAlarm.AllowUserToResizeColumns = false;
            this.dgvAlarm.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvAlarm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlarm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvAlarm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlarm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlarm.ColumnHeadersHeight = 30;
            this.dgvAlarm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAlarm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alarmDate,
            this.varName,
            this.alarmState,
            this.priority,
            this.alarmType,
            this.actualValue,
            this.alarmValue,
            this.alarmNote});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlarm.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlarm.EnableHeadersVisualStyles = false;
            this.dgvAlarm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvAlarm.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgvAlarm.Location = new System.Drawing.Point(0, 0);
            this.dgvAlarm.Name = "dgvAlarm";
            this.dgvAlarm.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlarm.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAlarm.RowHeadersVisible = false;
            this.dgvAlarm.RowHeight = 0;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgvAlarm.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAlarm.RowTemplate.Height = 30;
            this.dgvAlarm.SelectedIndex = -1;
            this.dgvAlarm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlarm.ShowGridLine = false;
            this.dgvAlarm.ShowRect = false;
            this.dgvAlarm.Size = new System.Drawing.Size(1278, 454);
            this.dgvAlarm.TabIndex = 0;
            this.dgvAlarm.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // alarmDate
            // 
            this.alarmDate.DataPropertyName = "alarmDate";
            dataGridViewCellStyle3.Format = "yyyy-MM-dd HH:mm:ss";
            this.alarmDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.alarmDate.HeaderText = "日期时间";
            this.alarmDate.Name = "alarmDate";
            this.alarmDate.ReadOnly = true;
            this.alarmDate.Width = 200;
            // 
            // varName
            // 
            this.varName.DataPropertyName = "varName";
            this.varName.HeaderText = "变量名称";
            this.varName.Name = "varName";
            this.varName.ReadOnly = true;
            this.varName.Width = 150;
            // 
            // alarmState
            // 
            this.alarmState.DataPropertyName = "alarmState";
            this.alarmState.HeaderText = "报警状态";
            this.alarmState.Name = "alarmState";
            this.alarmState.ReadOnly = true;
            // 
            // priority
            // 
            this.priority.DataPropertyName = "priority";
            this.priority.HeaderText = "优先级";
            this.priority.Name = "priority";
            this.priority.ReadOnly = true;
            // 
            // alarmType
            // 
            this.alarmType.DataPropertyName = "alarmType";
            this.alarmType.HeaderText = "报警类型";
            this.alarmType.Name = "alarmType";
            this.alarmType.ReadOnly = true;
            // 
            // actualValue
            // 
            this.actualValue.DataPropertyName = "actualValue";
            this.actualValue.HeaderText = "报警值";
            this.actualValue.Name = "actualValue";
            this.actualValue.ReadOnly = true;
            // 
            // alarmValue
            // 
            this.alarmValue.DataPropertyName = "alarmValue";
            this.alarmValue.HeaderText = "报警限值";
            this.alarmValue.Name = "alarmValue";
            this.alarmValue.ReadOnly = true;
            // 
            // alarmNote
            // 
            this.alarmNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.alarmNote.DataPropertyName = "alarmNote";
            this.alarmNote.HeaderText = "报警备注";
            this.alarmNote.Name = "alarmNote";
            this.alarmNote.ReadOnly = true;
            // 
            // FrmAlarmView
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 533);
            this.Controls.Add(this.uiSplitContainer1);
            this.Name = "FrmAlarmView";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowTitle = false;
            this.Text = "FrmAlarmView";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAlarmView_FormClosed);
            this.Load += new System.EventHandler(this.FrmAlarmView_Load);
            this.uiSplitContainer1.Panel1.ResumeLayout(false);
            this.uiSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiSplitContainer1)).EndInit();
            this.uiSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISplitContainer uiSplitContainer1;
        private Sunny.UI.UIButton BtnQuery;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox cmbAlarmType;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIDataGridView dgvAlarm;
        private Sunny.UI.UIDatetimePicker DtpEnd;
        private Sunny.UI.UIDatetimePicker DtpStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn varName;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmState;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmNote;
    }
}