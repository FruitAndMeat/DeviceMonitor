namespace Air
{
    partial class FrmQuerySelect
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
            this.rdoSelectByArea = new Sunny.UI.UIRadioButton();
            this.cmbAreaSelect = new Sunny.UI.UIComboBox();
            this.rdoSelectFree = new Sunny.UI.UIRadioButton();
            this.tsSelectControl = new Sunny.UI.UITransfer();
            this.btnSure = new Sunny.UI.UIButton();
            this.btnCancel = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // rdoSelectByArea
            // 
            this.rdoSelectByArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoSelectByArea.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoSelectByArea.Location = new System.Drawing.Point(22, 54);
            this.rdoSelectByArea.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdoSelectByArea.Name = "rdoSelectByArea";
            this.rdoSelectByArea.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdoSelectByArea.Size = new System.Drawing.Size(123, 25);
            this.rdoSelectByArea.TabIndex = 0;
            this.rdoSelectByArea.Text = "按区域选择：";
            this.rdoSelectByArea.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.rdoSelectByArea.CheckedChanged += new System.EventHandler(this.rdoSelectByArea_CheckedChanged);
            // 
            // cmbAreaSelect
            // 
            this.cmbAreaSelect.DataSource = null;
            this.cmbAreaSelect.FillColor = System.Drawing.Color.White;
            this.cmbAreaSelect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbAreaSelect.Location = new System.Drawing.Point(178, 54);
            this.cmbAreaSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAreaSelect.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmbAreaSelect.Name = "cmbAreaSelect";
            this.cmbAreaSelect.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmbAreaSelect.Size = new System.Drawing.Size(150, 29);
            this.cmbAreaSelect.TabIndex = 1;
            this.cmbAreaSelect.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbAreaSelect.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // rdoSelectFree
            // 
            this.rdoSelectFree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoSelectFree.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoSelectFree.Location = new System.Drawing.Point(22, 104);
            this.rdoSelectFree.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdoSelectFree.Name = "rdoSelectFree";
            this.rdoSelectFree.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdoSelectFree.Size = new System.Drawing.Size(123, 25);
            this.rdoSelectFree.TabIndex = 0;
            this.rdoSelectFree.Text = "自由选择：";
            this.rdoSelectFree.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.rdoSelectFree.CheckedChanged += new System.EventHandler(this.rdoSelectFree_CheckedChanged);
            // 
            // tsSelectControl
            // 
            this.tsSelectControl.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsSelectControl.Location = new System.Drawing.Point(22, 141);
            this.tsSelectControl.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.tsSelectControl.MinimumSize = new System.Drawing.Size(1, 1);
            this.tsSelectControl.Name = "tsSelectControl";
            this.tsSelectControl.Padding = new System.Windows.Forms.Padding(1);
            this.tsSelectControl.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.tsSelectControl.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.tsSelectControl.ShowText = false;
            this.tsSelectControl.Size = new System.Drawing.Size(500, 350);
            this.tsSelectControl.TabIndex = 2;
            this.tsSelectControl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tsSelectControl.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnSure
            // 
            this.btnSure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSure.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSure.Location = new System.Drawing.Point(82, 503);
            this.btnSure.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(100, 35);
            this.btnSure.TabIndex = 3;
            this.btnSure.Text = "确认";
            this.btnSure.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSure.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(372, 503);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmQuerySelect
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(548, 557);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSure);
            this.Controls.Add(this.tsSelectControl);
            this.Controls.Add(this.cmbAreaSelect);
            this.Controls.Add(this.rdoSelectFree);
            this.Controls.Add(this.rdoSelectByArea);
            this.Name = "FrmQuerySelect";
            this.Text = "选择报表查询变量";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIRadioButton rdoSelectByArea;
        private Sunny.UI.UIComboBox cmbAreaSelect;
        private Sunny.UI.UIRadioButton rdoSelectFree;
        private Sunny.UI.UITransfer tsSelectControl;
        private Sunny.UI.UIButton btnSure;
        private Sunny.UI.UIButton btnCancel;
    }
}