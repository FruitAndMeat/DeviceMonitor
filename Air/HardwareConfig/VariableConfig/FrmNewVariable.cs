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
using DAL;
using Models;

namespace Air
{
    public partial class FrmNewVariable : UIForm
    {
        public FrmNewVariable()
        {
            InitializeComponent();
            Initial();
        }
        public Variables variable = null;
        public VarAlarm varAlarm = null;
        
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            #region 变量数据验证
            if (this.txtVarName.Text.Length==0)
            {
                UIMessageBox.ShowWarning("请输入变量名称！");
                this.txtVarName.Focus();
                return;
            }
            #endregion
            #region 验证报警设置并封装报警对象
            if (this.cbxVarAlarm.Checked)
            {
                #region 验证报警设置
                if (!(this.cbxAlarmLoLo.Checked || this.cbxAlarmLow.Checked ||
                    this.cbxAlarmHigh.Checked || this.cbxAlarmHiHi.Checked))
                {
                    UIMessageBox.ShowWarning("选择了报警，未填写具体报警内容");
                    return;
                }

                if (this.cbxAlarmLoLo.Checked && this.txtAlarmLoLo.Text.Length == 0)
                {
                    UIMessageBox.ShowWarning("请输入报警值！");
                    this.txtAlarmLoLo.Focus();
                    return;
                }
                
                if (this.cbxAlarmLow.Checked && this.txtAlarmLow.Text.Length == 0)
                {
                    UIMessageBox.ShowWarning("请输入报警值！");
                    this.txtAlarmLow.Focus();
                    return;
                }
                
                if (this.cbxAlarmHigh.Checked && this.txtAlarmHigh.Text.Length == 0)
                {
                    UIMessageBox.ShowWarning("请输入报警值！");
                    this.txtAlarmHigh.Focus();
                    return;
                }
                
                if (this.cbxAlarmHiHi.Checked && this.txtAlarmHiHi.Text.Length == 0)
                {
                    UIMessageBox.ShowWarning("请输入报警值！");
                    this.txtAlarmHiHi.Focus();
                    return;
                }
                #endregion

                #region 封装报警


                varAlarm = new VarAlarm() { VarName=txtVarName.Text};

                if (this.cbxAlarmLoLo.Checked)
                {
                    varAlarm.listAlarm.Add(new Alarm()
                    {
                        alarmType = AlarmType.LoLo,
                        priority = Convert.ToInt32(this.txtPriorityLoLo.Text),
                        alarmLimitValue = float.Parse(this.txtAlarmLoLo.Text),
                        alarmNote = txtNoteLoLo.Text,
                    });
                }

                if (this.cbxAlarmLow.Checked)
                {
                    varAlarm.listAlarm.Add(new Alarm()
                    {
                        alarmType = AlarmType.Low,
                        priority = Convert.ToInt32(this.txtPriorityLow.Text),
                        alarmLimitValue = float.Parse(this.txtAlarmLow.Text),
                        alarmNote = txtNoteLow.Text,
                    });
                }

                if (this.cbxAlarmHigh.Checked)
                {
                    varAlarm.listAlarm.Add(new Alarm()
                    {
                        alarmType = AlarmType.High,
                        priority = Convert.ToInt32(this.txtPriorityHigh.Text),
                        alarmLimitValue = float.Parse(this.txtAlarmHigh.Text),
                        alarmNote = txtNoteHigh.Text,
                    });
                }

                if (this.cbxAlarmHiHi.Checked)
                {
                    varAlarm.listAlarm.Add(new Alarm()
                    {
                        alarmType = AlarmType.HiHi,
                        priority = Convert.ToInt32(this.txtPriorityHiHi.Text),
                        alarmLimitValue = float.Parse(this.txtAlarmHiHi.Text),
                        alarmNote = txtNoteHiHi.Text,
                    });
                }
                #endregion

            }
            #endregion

            variable = new Variables()
            {
                VarName = this.txtVarName.Text,
                storeArea = (RegisterType)Enum.Parse(typeof(RegisterType), this.cmbStoreArea.Text),
                Address = Convert.ToInt32(this.txtVarAddress.Text),
                DataType = (PLCDataType)Enum.Parse(typeof(PLCDataType), this.cmbDataType.Text),
                IsFilling = this.cbxFilling.Checked ? "Y" : "N",
                IsAlarm = this.cbxVarAlarm.Checked ? "Y" : "N",
                IsReport = this.cbxReport.Checked ? "Y" : "N",
                Note=this.txtVarNote.Text
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Initial()
        {
            //初始化存储区域下拉框
            this.cmbStoreArea.DataSource = Enum.GetNames(typeof(RegisterType));
            //初始化数据类型下拉框
            this.cmbDataType.DataSource = Enum.GetNames(typeof(PLCDataType));
        }
        #region CheckBox使能变化
        private void cbxAlarmLoLo_CheckedChanged(object sender, EventArgs e)
        {
            this.txtAlarmLoLo.Enabled = ((UICheckBox)sender).Checked;
            this.txtPriorityLoLo.Enabled = ((UICheckBox)sender).Checked;
            this.txtNoteLoLo.Enabled = ((UICheckBox)sender).Checked;
        }

        private void cbxAlarmLow_CheckedChanged(object sender, EventArgs e)
        {
            this.txtAlarmLow.Enabled = ((UICheckBox)sender).Checked;
            this.txtPriorityLow.Enabled = ((UICheckBox)sender).Checked;
            this.txtNoteLow.Enabled = ((UICheckBox)sender).Checked;
        }

        private void cbxAlarmHigh_CheckedChanged(object sender, EventArgs e)
        {
            this.txtAlarmHigh.Enabled = ((UICheckBox)sender).Checked;
            this.txtPriorityHigh.Enabled = ((UICheckBox)sender).Checked;
            this.txtNoteHigh.Enabled = ((UICheckBox)sender).Checked;
        }

        private void cbxAlarmHiHi_CheckedChanged(object sender, EventArgs e)
        {
            this.txtAlarmHiHi.Enabled = ((UICheckBox)sender).Checked;
            this.txtPriorityHiHi.Enabled = ((UICheckBox)sender).Checked;
            this.txtNoteHiHi.Enabled = ((UICheckBox)sender).Checked;
        }

        private void cbxVarAlarm_CheckedChanged(object sender, EventArgs e)
        {
            bool value = this.cbxVarAlarm.Checked;
            if (value==false)
            {
                this.cbxAlarmLoLo.Checked = value;
                this.cbxAlarmLow.Checked = value;
                this.cbxAlarmHigh.Checked = value;
                this.cbxAlarmHiHi.Checked = value;
            }
            this.cbxAlarmLoLo.Enabled = value;
            this.cbxAlarmLow.Enabled = value;
            this.cbxAlarmHigh.Enabled = value;
            this.cbxAlarmHiHi.Enabled = value;
        }
        #endregion
    }
}
