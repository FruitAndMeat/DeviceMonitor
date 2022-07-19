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

namespace Air
{
    public partial class FrmIOMonitor : UIForm
    {
        public FrmIOMonitor()
        {
            InitializeComponent();
        }
        private List<UITextBox> txtBoxList = new List<UITextBox>();
        private List<UISwitch> switchList = new List<UISwitch>();

        void  SetBoolValue(object sender,bool value)
        {
            CommonData.IsWriteing = true;
            try
            {
                if (sender is UIButton)
                {
                    if (((UIButton)sender).Tag != null)
                    {
                        if (CommonData.CurrentAddress != null)
                        {
                            CommonData.objMod.WriteSingleCoil(ushort.Parse(CommonData.CurrentAddress[((UIButton)sender).Tag.ToString()]), value);
                        }
                    }
                } 
                else if (sender is UISwitch)
                {
                    if (((UISwitch)sender).Tag != null)
                    {
                        if (CommonData.CurrentAddress != null)
                        {
                            CommonData.objMod.WriteSingleCoil(ushort.Parse(CommonData.CurrentAddress[((UISwitch)sender).Tag.ToString()]), value);
                        }
                    }
                }
                //此处加上弹框显示会阻碍线程 控件值跳动。
                //UIMessageBox.ShowSuccess("修改成功");
                ShowSuccessTip("修改变量成功:"+value.ToString());
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError("修改变量出错" + ex.Message);
            }
            finally { CommonData.IsWriteing = false; }
        }

        /// <summary>
        /// 刷新UI的方法。
        /// </summary>
       public void RefreshUI()
        {
            try
            {
                foreach (UITextBox item in txtBoxList)
                {
                    if (item.Tag != null)
                    {
                        if (CommonData.CurrentValue != null && CommonData.CurrentValue.ContainsKey(item.Tag.ToString()))
                        {
                            item.Invoke(new Action(() => item.Text = CommonData.CurrentValue[item.Tag.ToString()]));
                        }
                    }
                }
                foreach (UISwitch item in switchList)
                {
                    if (item.Tag != null)
                    {
                        if (CommonData.CurrentValue != null && CommonData.CurrentValue.ContainsKey(item.Tag.ToString()))
                        {
                            item.Invoke(new Action(() => item.Active = CommonData.CurrentValue[item.Tag.ToString()] == "True" ? true : false));
                        }
                    }
                }
            }
            catch { }
        }

        

        //界面加载时，将控件添加到List集合中
        private void FrmIOMonitor_Load(object sender, EventArgs e)
        {
            //将控件在窗体加载的时候就添加到集合中
            foreach (Control item in this.GrpMotor1.Controls)
            {
                if (item is UITextBox)
                {
                    txtBoxList.Add((UITextBox)item);
                }
            }
            foreach (Control item in this.GrpMotor2.Controls)
            {
                if (item is UITextBox)
                {
                    txtBoxList.Add((UITextBox)item);
                }
            }
            foreach (Control item in this.GrpValve1.Controls)
            {
                if (item is UISwitch)
                {
                    switchList.Add((UISwitch)item);
                }
            }

            CommonData.UpdateUI = new Action(RefreshUI);

            RefreshUI();
        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            SetBoolValue(sender, true);
        }

        private void btnStop1_Click(object sender, EventArgs e)
        {
            SetBoolValue(sender, true);
        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            SetBoolValue(sender, true);
        }

        private void btnStop2_Click(object sender, EventArgs e)
        {
            SetBoolValue(sender, true);
        }
        
        private void swh1_1_Click(object sender, EventArgs e)
        {
            SetBoolValue(sender, ((UISwitch)sender).Active);
        }

        private void swh1_2_Click(object sender, EventArgs e)
        {
            SetBoolValue(sender, ((UISwitch)sender).Active);
        }

        private void swh1_3_Click(object sender, EventArgs e)
        {
            SetBoolValue(sender, ((UISwitch)sender).Active);
        }

        private void swh1_4_Click(object sender, EventArgs e)
        {
            SetBoolValue(sender, ((UISwitch)sender).Active);
        }

        private void swh2_1_Click(object sender, EventArgs e)
        {
            SetBoolValue(sender, ((UISwitch)sender).Active);
        }

        private void swh2_2_Click(object sender, EventArgs e)
        {
            SetBoolValue(sender, ((UISwitch)sender).Active);
        }

        private void swh2_3_Click(object sender, EventArgs e)
        {
            SetBoolValue(sender, ((UISwitch)sender).Active);
        }

        private void swh2_4_Click(object sender, EventArgs e)
        {
            SetBoolValue(sender, ((UISwitch)sender).Active);
        }

        private void FrmIOMonitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommonData.UpdateUI -= RefreshUI;
        }
    }
}
