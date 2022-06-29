using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using Models;

namespace Air
{
    public partial class FrmAlarmView : UIForm
    {
        public FrmAlarmView()
        {
            InitializeComponent();
            CommonData.update += CommonData_update;
        }

        void UpdateDGVAlarm()
        {
            //this.dgvAlarm.DataSource = null;
            //this.dgvAlarm.DataSource = CommonData.alarmRecordList;

            //在dgv与list集合绑定并需要刷新数据源时，不可以赋值null给DataSource，而是需要
            //赋值一个new List<T>();否则会出现异常。
            this.dgvAlarm.DataSource = new List<AlarmRecord>();
            //这个是在初始化绑定的时候先判断列表的count是否大于0，大于0了再绑定
            //不然绑定后点击单元格会触发异常:索引-1，没有值。
            if (CommonData.alarmRecordList != null && CommonData.alarmRecordList.Count > 0)
            {
                this.dgvAlarm.DataSource = CommonData.alarmRecordList;
            }
        }

        private void CommonData_update()
        {
            //this.dgvAlarm.Invoke(new Action(UpdateDGVAlarm));
        }

        private void FrmAlarmView_Load(object sender, EventArgs e)
        {
            this.cmbAlarmType.Items.AddRange(new string[] { "实时报警", "历史报警" });
            this.cmbAlarmType.SelectedIndex = 0;
        }

        private void cmbAlarmType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            UpdateDGVAlarm();
        }
    }
}
