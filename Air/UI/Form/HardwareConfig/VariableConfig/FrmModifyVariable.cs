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
    public partial class FrmModifyVariable : UIForm
    {
        public FrmModifyVariable(Variables objVar,VarAlarm objAlarm)
        {
            InitializeComponent();
            this.objVar = objVar;
            this.objAlarm = objAlarm;
        }
        public Variables objVar;
        public VarAlarm objAlarm=null;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            #region 变量数据验证
            if (this.txtVarName.Text.Length == 0)
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


                objAlarm = new VarAlarm() { VarName = txtVarName.Text };

                if (this.cbxAlarmLoLo.Checked)
                {
                    objAlarm.listAlarm.Add(new Alarm()
                    {
                        alarmType = AlarmType.LoLo,
                        priority = Convert.ToInt32(this.txtPriorityLoLo.Text),
                        alarmLimitValue = float.Parse(this.txtAlarmLoLo.Text),
                        alarmNote = txtNoteLoLo.Text,
                    });
                }

                if (this.cbxAlarmLow.Checked)
                {
                    objAlarm.listAlarm.Add(new Alarm()
                    {
                        alarmType = AlarmType.Low,
                        priority = Convert.ToInt32(this.txtPriorityLow.Text),
                        alarmLimitValue = float.Parse(this.txtAlarmLow.Text),
                        alarmNote = txtNoteLow.Text,
                    });
                }

                if (this.cbxAlarmHigh.Checked)
                {
                    objAlarm.listAlarm.Add(new Alarm()
                    {
                        alarmType = AlarmType.High,
                        priority = Convert.ToInt32(this.txtPriorityHigh.Text),
                        alarmLimitValue = float.Parse(this.txtAlarmHigh.Text),
                        alarmNote = txtNoteHigh.Text,
                    });
                }

                if (this.cbxAlarmHiHi.Checked)
                {
                    objAlarm.listAlarm.Add(new Alarm()
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

            objVar = new Variables()
            {
                VarName = this.txtVarName.Text,
                storeArea = (RegisterType)Enum.Parse(typeof(RegisterType), value: cmbStoreArea.Text),
                Address = Convert.ToInt32(this.txtVarAddress.Text),
                DataType = (PLCDataType)Enum.Parse(typeof(PLCDataType), this.cmbDataType.Text),
                IsFilling = this.cbxFilling.Checked ? "Y" : "N",
                IsAlarm = this.cbxVarAlarm.Checked ? "Y" : "N",
                IsReport = this.cbxReport.Checked ? "Y" : "N",
                Note = this.txtVarNote.Text
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (value == false)
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

        private void FrmModifyVariable_Load(object sender, EventArgs e)
        {
            Initial();
        }


        private void Initial()
        {
            //初始化存储区域下拉框
            this.cmbStoreArea.DataSource = Enum.GetNames(typeof(RegisterType));
            //初始化数据类型下拉框
            this.cmbDataType.DataSource = Enum.GetNames(typeof(PLCDataType));
            //初始化控件内容
            this.txtVarName.Text = objVar.VarName;
            this.cmbDataType.Text = objVar.DataType.ToString();
            this.cmbStoreArea.Text = objVar.storeArea.ToString();
            this.txtVarAddress.Text = objVar.Address.ToString();
            this.cbxVarAlarm.Checked = objVar.IsAlarm == "Y" ? true : false;
            this.cbxReport.Checked = objVar.IsReport == "Y" ? true : false;
            this.cbxFilling.Checked = objVar.IsFilling == "Y" ? true : false;
            this.txtVarNote.Text = objVar.Note;
            if (objAlarm!=null)
            {
                foreach (Alarm item in objAlarm.listAlarm)
                {
                    switch (item.alarmType)
                    {
                        case AlarmType.LoLo:
                            this.cbxAlarmLoLo.Checked = true;
                            this.txtAlarmLoLo.Text = item.alarmLimitValue.ToString();
                            this.txtPriorityLoLo.Text = item.priority.ToString();
                            this.txtNoteLoLo.Text = item.alarmNote;
                            break;
                        case AlarmType.Low:
                            this.cbxAlarmLow.Checked = true;
                            this.txtAlarmLow.Text = item.alarmLimitValue.ToString();
                            this.txtPriorityLow.Text = item.priority.ToString();
                            this.txtNoteLow.Text = item.alarmNote;
                            break;
                        case AlarmType.High:
                            this.cbxAlarmHigh.Checked = true;
                            this.txtAlarmHigh.Text = item.alarmLimitValue.ToString();
                            this.txtPriorityHigh.Text = item.priority.ToString();
                            this.txtNoteHigh.Text = item.alarmNote;
                            break;
                        case AlarmType.HiHi:
                            this.cbxAlarmHiHi.Checked = true;
                            this.txtAlarmHiHi.Text = item.alarmLimitValue.ToString();
                            this.txtPriorityHiHi.Text = item.priority.ToString();
                            this.txtNoteHiHi.Text = item.alarmNote;
                            break;
                    }
                }
            }
        }
    }
}
