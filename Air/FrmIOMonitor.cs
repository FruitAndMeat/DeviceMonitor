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

        private void TimerRefresh_Tick(object sender, EventArgs e)
        {
            foreach (UITextBox item in txtBoxList)
            {
                if (item.Tag!=null)
                {
                    if (CommonData.CurrentValue!=null&&CommonData.CurrentValue.ContainsKey(item.Tag.ToString()))
                    {
                        item.Text = CommonData.CurrentValue[item.Tag.ToString()];
                    }
                }
            }
            foreach (UISwitch item in switchList)
            {
                if (item.Tag != null)
                {
                    if (CommonData.CurrentValue != null && CommonData.CurrentValue.ContainsKey(item.Tag.ToString()))
                    {
                        item.Active = CommonData.CurrentValue[item.Tag.ToString()]=="True"?true:false;
                    }
                }
            }


        }

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
        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStop1_Click(object sender, EventArgs e)
        {
            if (((UIButton)sender).Tag!=null)
            {
                if (CommonData.CurrentAddress!=null)
                {
                    CommonData.objMod.WriteSingleCoil(ushort.Parse(CommonData.CurrentAddress[((UIButton)sender).Tag.ToString()]), true);
                }
            }
            
        }

        private void btnStart2_Click(object sender, EventArgs e)
        {

        }

        private void btnStop2_Click(object sender, EventArgs e)
        {

        }

        private void swh1_1_ValueChanged(object sender, bool value)
        {

        }

        private void swh1_2_ValueChanged(object sender, bool value)
        {

        }

        private void swh1_3_ValueChanged(object sender, bool value)
        {

        }

        private void swh1_4_ValueChanged(object sender, bool value)
        {

        }

        private void swh2_1_ValueChanged(object sender, bool value)
        {

        }

        private void swh2_2_ValueChanged(object sender, bool value)
        {

        }

        private void swh2_3_ValueChanged(object sender, bool value)
        {

        }

        private void swh2_4_ValueChanged(object sender, bool value)
        {

        }
    }
}
