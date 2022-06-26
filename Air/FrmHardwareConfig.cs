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
    public partial class FrmHardwareConfig : UIForm
    {
        public FrmHardwareConfig()
        {
            InitializeComponent();
        }
        #region  事件
        private void btnModbusConfig_Click(object sender, EventArgs e)
        {
            FrmNewMachine objFrm = new FrmNewMachine();
            objFrm.ShowDialog();
        }

        private void btnVariableConfig_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmVariableConfig") == false)
            {
                OpenWindow(new FrmVariableConfig());
            }
            SetEnable(sender);
        }

        private void btnParamsSetConfig_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmParamsSetConfig") == false)
            {
                OpenWindow(new FrmParamsSetConfig());
            }
            SetEnable(sender);
        }

        private void btnAlarmConfig_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmAlarmConfig") == false)
            {
                OpenWindow(new FrmAlarmConfig());
            }
            SetEnable(sender);
        }

        private void btnTrendConfig_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmTrendConfig") == false)
            {
                OpenWindow(new FrmTrendConfig());
            }
            SetEnable(sender);
        }

        private void btnReportConfig_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmReportConfig") == false)
            {
                OpenWindow(new FrmReportConfig());
            }
            SetEnable(sender);
        }

        private void btnUserConfig_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmUserConfig") == false)
            {
                OpenWindow(new FrmUserConfig());
            }
            SetEnable(sender);
        }

        private void FrmHardwareConfig_Load(object sender, EventArgs e)
        {
            this.btnVariableConfig_Click(this.btnVariableConfig, null);
        }
        #endregion

        #region 自定义方法
        /// <summary>
        /// 打开窗口方法
        /// </summary>
        /// <param name="frm">要打开的窗口对象</param>
        private void OpenWindow(UIForm frm)
        {
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Parent = this.rightPanel;
            frm.Show();
        }

        /// <summary>
        /// 关闭窗口方法
        /// </summary>
        /// <param name="frmName">要检查的关闭窗口名字</param>
        /// <returns>如果当前打开的窗体就是需要打开的窗体，则返回True,并不关闭窗口。否则关闭窗口并返回false</returns>
        private bool CloseWindow(string frmName)
        {
            foreach (Control ct in this.rightPanel.Controls)
            {
                if (ct is UIForm)
                {
                    UIForm frm = (UIForm)ct;
                    if (frm.Name==frmName)
                    {
                        return true;
                    }
                    else
                    {
                        frm.Close();
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// 根据点击的按钮对象设置按钮的使能条件，并且更改标题文字。
        /// </summary>
        /// <param name="sender">点击的按钮控件</param>
        private void SetEnable(object sender)
        {
            foreach (Control ct in this.leftPanel.Controls)
            {
                if (ct is UIButton)
                {
                    UIButton btn = (UIButton)ct;
                    btn.Enabled = true;
                }
            }
            ((UIButton)sender).Enabled = false;
        }
        #endregion

        
    }
}
