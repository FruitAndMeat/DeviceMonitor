using DAL;
using Models;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Air
{
    public partial class FrmAlarmView : UIForm
    {
        public FrmAlarmView() {
            InitializeComponent();

        }

        private AlarmRecordServices objAlarmRS = new AlarmRecordServices();

        void UpdateDGVAlarm() {
            //this.dgvAlarm.DataSource = null;
            //this.dgvAlarm.DataSource = CommonData.alarmRecordList;

            //在dgv与list集合绑定并需要刷新数据源时，不可以赋值null给DataSource，而是需要
            //赋值一个new List<T>();否则会出现异常。
            this.dgvAlarm.DataSource = new List<AlarmRecord>();
            //这个是在初始化绑定的时候先判断列表的count是否大于0，大于0了再绑定
            //不然绑定后点击单元格会触发异常:索引-1，没有值。
            if (CommonData.alarmRecordList != null && CommonData.alarmRecordList.Count > 0) {
                this.dgvAlarm.DataSource = CommonData.alarmRecordList;
            }
            ModifyBackColor();
        }

        void ModifyBackColor() {
            if (this.dgvAlarm.Rows.Count > 0) {
                for (int i = 0; i < this.dgvAlarm.Rows.Count; i++) {
                    if (this.dgvAlarm.Rows[i].Cells[2].Value.ToString() == "Incoming") {
                        this.dgvAlarm.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 128);
                        this.dgvAlarm.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                        this.dgvAlarm.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 128, 128);
                        this.dgvAlarm.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Black;
                    }
                    else if (this.dgvAlarm.Rows[i].Cells[2].Value.ToString() == "Outgoing") {
                        this.dgvAlarm.Rows[i].DefaultCellStyle.BackColor = Color.CadetBlue;
                        this.dgvAlarm.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                        this.dgvAlarm.Rows[i].DefaultCellStyle.SelectionBackColor = Color.CadetBlue;
                        this.dgvAlarm.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Black;
                    }
                }
            }
        }

        private void CommonData_update() {
            try {
                this.dgvAlarm.Invoke(new Action(UpdateDGVAlarm));
            }
            catch { }
        }

        private void FrmAlarmView_Load(object sender, EventArgs e) {
            this.cmbAlarmType.Items.AddRange(new string[] { "实时报警", "历史报警" });
            this.cmbAlarmType.SelectedIndex = 0;
            TimeSpan ts = new TimeSpan(7, 0, 0, 0, 0);
            this.DtpStart.Value = DateTime.Now.Subtract(ts);
            this.DtpEnd.Value = DateTime.Now;
            CommonData.update += CommonData_update;
            UpdateDGVAlarm();
        }


        private void cmbAlarmType_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbAlarmType.SelectedIndex == 0) {
                CommonData.update += CommonData_update;
                UpdateDGVAlarm();
            }
        }

        private void BtnQuery_Click(object sender, EventArgs e) {
            CommonData.update -= CommonData_update;
            DateTime startTime = this.DtpStart.Value;
            DateTime endTime = this.DtpEnd.Value;
            if (endTime < startTime) {
                UIMessageBox.ShowWarning("开始时间与结束时间不符合，请检查修改后重试。");
                return;
            }
            if ((endTime - startTime).TotalDays > 7.0) {
                UIMessageBox.ShowWarning("查询范围太大，请缩小查询范围，最大间隔为7天。");
                return;
            }

            this.cmbAlarmType.SelectedIndex = 1;
            try {
                this.dgvAlarm.DataSource = objAlarmRS.QueryAlarmRecord(startTime, endTime);
                ModifyBackColor();
            }
            catch (Exception ex) {
                UIMessageBox.ShowError("历史报警查询失败：" + ex.Message);
            }

        }

        private void FrmAlarmView_FormClosed(object sender, FormClosedEventArgs e) {
            CommonData.update -= CommonData_update;
        }
    }
}
