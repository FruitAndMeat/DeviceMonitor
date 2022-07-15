namespace Air
{
    partial class FrmNewVariable
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.txtVarName = new Sunny.UI.UITextBox();
            this.txtVarAddress = new Sunny.UI.UITextBox();
            this.cmbMachineName = new Sunny.UI.UIComboBox();
            this.cbxVarAlarm = new Sunny.UI.UICheckBox();
            this.cbxFilling = new Sunny.UI.UICheckBox();
            this.cbxReport = new Sunny.UI.UICheckBox();
            this.btnConfirm = new Sunny.UI.UIButton();
            this.btnCancel = new Sunny.UI.UIButton();
            this.txtVarNote = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.cmbDataType = new Sunny.UI.UIComboBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.cmbStoreArea = new Sunny.UI.UIComboBox();
            this.uiLine1 = new Sunny.UI.UILine();
            this.txtAlarmHiHi = new Sunny.UI.UITextBox();
            this.txtAlarmHigh = new Sunny.UI.UITextBox();
            this.txtAlarmLow = new Sunny.UI.UITextBox();
            this.txtAlarmLoLo = new Sunny.UI.UITextBox();
            this.cbxAlarmHiHi = new Sunny.UI.UICheckBox();
            this.cbxAlarmHigh = new Sunny.UI.UICheckBox();
            this.cbxAlarmLow = new Sunny.UI.UICheckBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.cbxAlarmLoLo = new Sunny.UI.UICheckBox();
            this.txtPriorityLoLo = new Sunny.UI.UITextBox();
            this.txtPriorityLow = new Sunny.UI.UITextBox();
            this.txtPriorityHigh = new Sunny.UI.UITextBox();
            this.txtPriorityHiHi = new Sunny.UI.UITextBox();
            this.txtNoteLoLo = new Sunny.UI.UITextBox();
            this.txtNoteLow = new Sunny.UI.UITextBox();
            this.txtNoteHigh = new Sunny.UI.UITextBox();
            this.txtNoteHiHi = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(22, 65);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "变量名称：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(22, 181);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 0;
            this.uiLabel2.Text = "变量地址：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(339, 121);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 0;
            this.uiLabel3.Text = "设备名称：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.Location = new System.Drawing.Point(22, 225);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(105, 34);
            this.uiLabel7.TabIndex = 0;
            this.uiLabel7.Text = "变量注释：";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel7.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtVarName
            // 
            this.txtVarName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVarName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtVarName.Location = new System.Drawing.Point(134, 62);
            this.txtVarName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVarName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtVarName.Name = "txtVarName";
            this.txtVarName.ShowText = false;
            this.txtVarName.Size = new System.Drawing.Size(150, 29);
            this.txtVarName.TabIndex = 0;
            this.txtVarName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtVarName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtVarAddress
            // 
            this.txtVarAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVarAddress.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtVarAddress.Location = new System.Drawing.Point(134, 181);
            this.txtVarAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVarAddress.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtVarAddress.Name = "txtVarAddress";
            this.txtVarAddress.ShowText = false;
            this.txtVarAddress.Size = new System.Drawing.Size(150, 29);
            this.txtVarAddress.TabIndex = 4;
            this.txtVarAddress.Text = "0";
            this.txtVarAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtVarAddress.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.txtVarAddress.Watermark = "modbus绝对地址";
            this.txtVarAddress.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cmbMachineName
            // 
            this.cmbMachineName.DataSource = null;
            this.cmbMachineName.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmbMachineName.Enabled = false;
            this.cmbMachineName.FillColor = System.Drawing.Color.White;
            this.cmbMachineName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbMachineName.Location = new System.Drawing.Point(451, 118);
            this.cmbMachineName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMachineName.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmbMachineName.Name = "cmbMachineName";
            this.cmbMachineName.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmbMachineName.Size = new System.Drawing.Size(150, 29);
            this.cmbMachineName.TabIndex = 3;
            this.cmbMachineName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbMachineName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxVarAlarm
            // 
            this.cbxVarAlarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxVarAlarm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxVarAlarm.Location = new System.Drawing.Point(343, 181);
            this.cbxVarAlarm.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbxVarAlarm.Name = "cbxVarAlarm";
            this.cbxVarAlarm.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxVarAlarm.Size = new System.Drawing.Size(74, 29);
            this.cbxVarAlarm.TabIndex = 5;
            this.cbxVarAlarm.Text = "报警";
            this.cbxVarAlarm.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cbxVarAlarm.CheckedChanged += new System.EventHandler(this.cbxVarAlarm_CheckedChanged);
            // 
            // cbxFilling
            // 
            this.cbxFilling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxFilling.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxFilling.Location = new System.Drawing.Point(442, 181);
            this.cbxFilling.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbxFilling.Name = "cbxFilling";
            this.cbxFilling.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxFilling.Size = new System.Drawing.Size(74, 29);
            this.cbxFilling.TabIndex = 6;
            this.cbxFilling.Text = "存档";
            this.cbxFilling.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxReport
            // 
            this.cbxReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxReport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxReport.Location = new System.Drawing.Point(541, 180);
            this.cbxReport.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbxReport.Name = "cbxReport";
            this.cbxReport.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxReport.Size = new System.Drawing.Size(60, 29);
            this.cbxReport.TabIndex = 7;
            this.cbxReport.Text = "报表";
            this.cbxReport.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirm.Location = new System.Drawing.Point(158, 546);
            this.btnConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 35);
            this.btnConfirm.TabIndex = 25;
            this.btnConfirm.Text = "确认添加";
            this.btnConfirm.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirm.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(367, 546);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "取消";
            this.btnCancel.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtVarNote
            // 
            this.txtVarNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVarNote.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtVarNote.Location = new System.Drawing.Point(134, 229);
            this.txtVarNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVarNote.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtVarNote.Name = "txtVarNote";
            this.txtVarNote.ShowText = false;
            this.txtVarNote.Size = new System.Drawing.Size(467, 30);
            this.txtVarNote.TabIndex = 8;
            this.txtVarNote.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtVarNote.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(339, 65);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 23);
            this.uiLabel4.TabIndex = 0;
            this.uiLabel4.Text = "数据类型：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cmbDataType
            // 
            this.cmbDataType.DataSource = null;
            this.cmbDataType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmbDataType.FillColor = System.Drawing.Color.White;
            this.cmbDataType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbDataType.Location = new System.Drawing.Point(451, 65);
            this.cmbDataType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDataType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmbDataType.Name = "cmbDataType";
            this.cmbDataType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmbDataType.Size = new System.Drawing.Size(150, 29);
            this.cmbDataType.TabIndex = 1;
            this.cmbDataType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbDataType.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(22, 124);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(100, 23);
            this.uiLabel5.TabIndex = 0;
            this.uiLabel5.Text = "存储区域：";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cmbStoreArea
            // 
            this.cmbStoreArea.DataSource = null;
            this.cmbStoreArea.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmbStoreArea.FillColor = System.Drawing.Color.White;
            this.cmbStoreArea.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbStoreArea.Location = new System.Drawing.Point(134, 121);
            this.cmbStoreArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbStoreArea.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmbStoreArea.Name = "cmbStoreArea";
            this.cmbStoreArea.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmbStoreArea.Size = new System.Drawing.Size(150, 29);
            this.cmbStoreArea.TabIndex = 2;
            this.cmbStoreArea.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbStoreArea.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine1.Location = new System.Drawing.Point(26, 267);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(575, 29);
            this.uiLine1.TabIndex = 6;
            this.uiLine1.Text = "报警设置";
            this.uiLine1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtAlarmHiHi
            // 
            this.txtAlarmHiHi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlarmHiHi.Enabled = false;
            this.txtAlarmHiHi.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAlarmHiHi.Location = new System.Drawing.Point(134, 484);
            this.txtAlarmHiHi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAlarmHiHi.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAlarmHiHi.Name = "txtAlarmHiHi";
            this.txtAlarmHiHi.ShowText = false;
            this.txtAlarmHiHi.Size = new System.Drawing.Size(150, 30);
            this.txtAlarmHiHi.TabIndex = 22;
            this.txtAlarmHiHi.Text = "0.00";
            this.txtAlarmHiHi.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAlarmHiHi.Type = Sunny.UI.UITextBox.UIEditType.Double;
            this.txtAlarmHiHi.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtAlarmHigh
            // 
            this.txtAlarmHigh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlarmHigh.Enabled = false;
            this.txtAlarmHigh.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAlarmHigh.Location = new System.Drawing.Point(134, 436);
            this.txtAlarmHigh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAlarmHigh.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAlarmHigh.Name = "txtAlarmHigh";
            this.txtAlarmHigh.ShowText = false;
            this.txtAlarmHigh.Size = new System.Drawing.Size(150, 30);
            this.txtAlarmHigh.TabIndex = 18;
            this.txtAlarmHigh.Text = "0.00";
            this.txtAlarmHigh.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAlarmHigh.Type = Sunny.UI.UITextBox.UIEditType.Double;
            this.txtAlarmHigh.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtAlarmLow
            // 
            this.txtAlarmLow.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlarmLow.Enabled = false;
            this.txtAlarmLow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAlarmLow.Location = new System.Drawing.Point(134, 386);
            this.txtAlarmLow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAlarmLow.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAlarmLow.Name = "txtAlarmLow";
            this.txtAlarmLow.ShowText = false;
            this.txtAlarmLow.Size = new System.Drawing.Size(150, 30);
            this.txtAlarmLow.TabIndex = 14;
            this.txtAlarmLow.Text = "0.00";
            this.txtAlarmLow.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAlarmLow.Type = Sunny.UI.UITextBox.UIEditType.Double;
            this.txtAlarmLow.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtAlarmLoLo
            // 
            this.txtAlarmLoLo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlarmLoLo.Enabled = false;
            this.txtAlarmLoLo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAlarmLoLo.Location = new System.Drawing.Point(134, 341);
            this.txtAlarmLoLo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAlarmLoLo.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAlarmLoLo.Name = "txtAlarmLoLo";
            this.txtAlarmLoLo.ShowText = false;
            this.txtAlarmLoLo.Size = new System.Drawing.Size(150, 30);
            this.txtAlarmLoLo.TabIndex = 10;
            this.txtAlarmLoLo.Text = "0.00";
            this.txtAlarmLoLo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAlarmLoLo.Type = Sunny.UI.UITextBox.UIEditType.Double;
            this.txtAlarmLoLo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxAlarmHiHi
            // 
            this.cbxAlarmHiHi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxAlarmHiHi.Enabled = false;
            this.cbxAlarmHiHi.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxAlarmHiHi.Location = new System.Drawing.Point(26, 490);
            this.cbxAlarmHiHi.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbxAlarmHiHi.Name = "cbxAlarmHiHi";
            this.cbxAlarmHiHi.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxAlarmHiHi.Size = new System.Drawing.Size(69, 16);
            this.cbxAlarmHiHi.TabIndex = 21;
            this.cbxAlarmHiHi.Text = "HiHi";
            this.cbxAlarmHiHi.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cbxAlarmHiHi.CheckedChanged += new System.EventHandler(this.cbxAlarmHiHi_CheckedChanged);
            // 
            // cbxAlarmHigh
            // 
            this.cbxAlarmHigh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxAlarmHigh.Enabled = false;
            this.cbxAlarmHigh.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxAlarmHigh.Location = new System.Drawing.Point(26, 437);
            this.cbxAlarmHigh.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbxAlarmHigh.Name = "cbxAlarmHigh";
            this.cbxAlarmHigh.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxAlarmHigh.Size = new System.Drawing.Size(69, 23);
            this.cbxAlarmHigh.TabIndex = 17;
            this.cbxAlarmHigh.Text = "High";
            this.cbxAlarmHigh.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cbxAlarmHigh.CheckedChanged += new System.EventHandler(this.cbxAlarmHigh_CheckedChanged);
            // 
            // cbxAlarmLow
            // 
            this.cbxAlarmLow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxAlarmLow.Enabled = false;
            this.cbxAlarmLow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxAlarmLow.Location = new System.Drawing.Point(26, 390);
            this.cbxAlarmLow.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbxAlarmLow.Name = "cbxAlarmLow";
            this.cbxAlarmLow.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxAlarmLow.Size = new System.Drawing.Size(69, 16);
            this.cbxAlarmLow.TabIndex = 13;
            this.cbxAlarmLow.Text = "Low";
            this.cbxAlarmLow.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cbxAlarmLow.CheckedChanged += new System.EventHandler(this.cbxAlarmLow_CheckedChanged);
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.Location = new System.Drawing.Point(178, 303);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(58, 21);
            this.uiLabel6.TabIndex = 35;
            this.uiLabel6.Text = "报警值";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxAlarmLoLo
            // 
            this.cbxAlarmLoLo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxAlarmLoLo.Enabled = false;
            this.cbxAlarmLoLo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxAlarmLoLo.Location = new System.Drawing.Point(26, 348);
            this.cbxAlarmLoLo.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbxAlarmLoLo.Name = "cbxAlarmLoLo";
            this.cbxAlarmLoLo.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxAlarmLoLo.Size = new System.Drawing.Size(69, 16);
            this.cbxAlarmLoLo.TabIndex = 9;
            this.cbxAlarmLoLo.Text = "LoLo";
            this.cbxAlarmLoLo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cbxAlarmLoLo.CheckedChanged += new System.EventHandler(this.cbxAlarmLoLo_CheckedChanged);
            // 
            // txtPriorityLoLo
            // 
            this.txtPriorityLoLo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriorityLoLo.Enabled = false;
            this.txtPriorityLoLo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPriorityLoLo.Location = new System.Drawing.Point(309, 341);
            this.txtPriorityLoLo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPriorityLoLo.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPriorityLoLo.Name = "txtPriorityLoLo";
            this.txtPriorityLoLo.ShowText = false;
            this.txtPriorityLoLo.Size = new System.Drawing.Size(85, 30);
            this.txtPriorityLoLo.TabIndex = 11;
            this.txtPriorityLoLo.Text = "0";
            this.txtPriorityLoLo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPriorityLoLo.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.txtPriorityLoLo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtPriorityLow
            // 
            this.txtPriorityLow.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriorityLow.Enabled = false;
            this.txtPriorityLow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPriorityLow.Location = new System.Drawing.Point(309, 386);
            this.txtPriorityLow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPriorityLow.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPriorityLow.Name = "txtPriorityLow";
            this.txtPriorityLow.ShowText = false;
            this.txtPriorityLow.Size = new System.Drawing.Size(85, 30);
            this.txtPriorityLow.TabIndex = 15;
            this.txtPriorityLow.Text = "0";
            this.txtPriorityLow.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPriorityLow.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.txtPriorityLow.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtPriorityHigh
            // 
            this.txtPriorityHigh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriorityHigh.Enabled = false;
            this.txtPriorityHigh.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPriorityHigh.Location = new System.Drawing.Point(309, 436);
            this.txtPriorityHigh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPriorityHigh.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPriorityHigh.Name = "txtPriorityHigh";
            this.txtPriorityHigh.ShowText = false;
            this.txtPriorityHigh.Size = new System.Drawing.Size(85, 30);
            this.txtPriorityHigh.TabIndex = 19;
            this.txtPriorityHigh.Text = "0";
            this.txtPriorityHigh.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPriorityHigh.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.txtPriorityHigh.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtPriorityHiHi
            // 
            this.txtPriorityHiHi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriorityHiHi.Enabled = false;
            this.txtPriorityHiHi.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPriorityHiHi.Location = new System.Drawing.Point(309, 484);
            this.txtPriorityHiHi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPriorityHiHi.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPriorityHiHi.Name = "txtPriorityHiHi";
            this.txtPriorityHiHi.ShowText = false;
            this.txtPriorityHiHi.Size = new System.Drawing.Size(85, 30);
            this.txtPriorityHiHi.TabIndex = 23;
            this.txtPriorityHiHi.Text = "0";
            this.txtPriorityHiHi.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPriorityHiHi.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.txtPriorityHiHi.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtNoteLoLo
            // 
            this.txtNoteLoLo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoteLoLo.Enabled = false;
            this.txtNoteLoLo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNoteLoLo.Location = new System.Drawing.Point(428, 341);
            this.txtNoteLoLo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNoteLoLo.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtNoteLoLo.Name = "txtNoteLoLo";
            this.txtNoteLoLo.ShowText = false;
            this.txtNoteLoLo.Size = new System.Drawing.Size(173, 30);
            this.txtNoteLoLo.TabIndex = 12;
            this.txtNoteLoLo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNoteLoLo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtNoteLow
            // 
            this.txtNoteLow.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoteLow.Enabled = false;
            this.txtNoteLow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNoteLow.Location = new System.Drawing.Point(428, 383);
            this.txtNoteLow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNoteLow.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtNoteLow.Name = "txtNoteLow";
            this.txtNoteLow.ShowText = false;
            this.txtNoteLow.Size = new System.Drawing.Size(173, 30);
            this.txtNoteLow.TabIndex = 16;
            this.txtNoteLow.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNoteLow.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtNoteHigh
            // 
            this.txtNoteHigh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoteHigh.Enabled = false;
            this.txtNoteHigh.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNoteHigh.Location = new System.Drawing.Point(428, 430);
            this.txtNoteHigh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNoteHigh.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtNoteHigh.Name = "txtNoteHigh";
            this.txtNoteHigh.ShowText = false;
            this.txtNoteHigh.Size = new System.Drawing.Size(173, 30);
            this.txtNoteHigh.TabIndex = 20;
            this.txtNoteHigh.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNoteHigh.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtNoteHiHi
            // 
            this.txtNoteHiHi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoteHiHi.Enabled = false;
            this.txtNoteHiHi.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNoteHiHi.Location = new System.Drawing.Point(428, 483);
            this.txtNoteHiHi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNoteHiHi.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtNoteHiHi.Name = "txtNoteHiHi";
            this.txtNoteHiHi.ShowText = false;
            this.txtNoteHiHi.Size = new System.Drawing.Size(173, 30);
            this.txtNoteHiHi.TabIndex = 24;
            this.txtNoteHiHi.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNoteHiHi.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel8
            // 
            this.uiLabel8.AutoSize = true;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel8.Location = new System.Drawing.Point(323, 303);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(58, 21);
            this.uiLabel8.TabIndex = 35;
            this.uiLabel8.Text = "优先级";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel8.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel9
            // 
            this.uiLabel9.AutoSize = true;
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel9.Location = new System.Drawing.Point(477, 303);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(42, 21);
            this.uiLabel9.TabIndex = 35;
            this.uiLabel9.Text = "注释";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel9.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // FrmNewVariable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(627, 614);
            this.Controls.Add(this.txtAlarmHiHi);
            this.Controls.Add(this.txtAlarmHigh);
            this.Controls.Add(this.txtAlarmLow);
            this.Controls.Add(this.txtPriorityHiHi);
            this.Controls.Add(this.txtPriorityHigh);
            this.Controls.Add(this.txtPriorityLow);
            this.Controls.Add(this.txtPriorityLoLo);
            this.Controls.Add(this.txtNoteHiHi);
            this.Controls.Add(this.txtNoteHigh);
            this.Controls.Add(this.txtNoteLow);
            this.Controls.Add(this.txtNoteLoLo);
            this.Controls.Add(this.txtAlarmLoLo);
            this.Controls.Add(this.cbxAlarmHiHi);
            this.Controls.Add(this.cbxAlarmHigh);
            this.Controls.Add(this.cbxAlarmLow);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.cbxAlarmLoLo);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.txtVarNote);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cbxReport);
            this.Controls.Add(this.cbxFilling);
            this.Controls.Add(this.cbxVarAlarm);
            this.Controls.Add(this.cmbDataType);
            this.Controls.Add(this.cmbStoreArea);
            this.Controls.Add(this.cmbMachineName);
            this.Controls.Add(this.txtVarAddress);
            this.Controls.Add(this.txtVarName);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNewVariable";
            this.Text = "新增变量";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox txtVarName;
        private Sunny.UI.UITextBox txtVarAddress;
        private Sunny.UI.UIComboBox cmbMachineName;
        private Sunny.UI.UICheckBox cbxVarAlarm;
        private Sunny.UI.UICheckBox cbxFilling;
        private Sunny.UI.UICheckBox cbxReport;
        private Sunny.UI.UIButton btnConfirm;
        private Sunny.UI.UIButton btnCancel;
        private Sunny.UI.UITextBox txtVarNote;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIComboBox cmbDataType;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIComboBox cmbStoreArea;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UITextBox txtAlarmHiHi;
        private Sunny.UI.UITextBox txtAlarmHigh;
        private Sunny.UI.UITextBox txtAlarmLow;
        private Sunny.UI.UITextBox txtAlarmLoLo;
        private Sunny.UI.UICheckBox cbxAlarmHiHi;
        private Sunny.UI.UICheckBox cbxAlarmHigh;
        private Sunny.UI.UICheckBox cbxAlarmLow;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UICheckBox cbxAlarmLoLo;
        private Sunny.UI.UITextBox txtPriorityLoLo;
        private Sunny.UI.UITextBox txtPriorityLow;
        private Sunny.UI.UITextBox txtPriorityHigh;
        private Sunny.UI.UITextBox txtPriorityHiHi;
        private Sunny.UI.UITextBox txtNoteLoLo;
        private Sunny.UI.UITextBox txtNoteLow;
        private Sunny.UI.UITextBox txtNoteHigh;
        private Sunny.UI.UITextBox txtNoteHiHi;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel9;
    }
}