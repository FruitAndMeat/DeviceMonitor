using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Sunny.UI;
using DAL;
using Models;

namespace Air
{
    public partial class FrmNewMachine : UIForm
    {
        public FrmNewMachine()
        {
            InitializeComponent();
        }
        
        
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtIPAddress.Text.Trim().Length<7)
            {
                UIMessageBox.ShowError("填入的IP地址不是一个有效的IP地址，请检查！");
                txtIPAddress.Focus();
                return;
            }
            if (!DataValidate.IsInteger(this.txtPort.Text.Trim()))
            {
                UIMessageBox.ShowError("端口号不是一个有效的正整数，请检查！");
                txtPort.Focus();
                return;
            }
            if (!DataValidate.IsInteger(this.txtID.Text.Trim()))
            {
                UIMessageBox.ShowError("设备ID不是一个有效的正整数，请检查！");
                txtID.Focus();
                return;
            }
            if (txtName.Text.Trim().Length==0)
            {
                UIMessageBox.ShowError("请输入设备名称");
                txtName.Focus();
                return;
            }

            #region 封装对象
            Device machine = new Device()
            {
                DeviceIP = this.txtIPAddress.Text.Trim(),
                IPPort = Convert.ToInt32(this.txtPort.Text.Trim()),
                DeviceID = Convert.ToInt32(this.txtID.Text.Trim()),
                DeviceName = this.txtName.Text.Trim(),
                DeviceRemark = this.txtRemark.Text.Trim()
            };
            #endregion
            try
            {
                IniFileEx iniFile = new IniFileEx(CommonData.deviceSetPath);
                iniFile.Write("1#PLC", "设备名称", machine.DeviceName);
                iniFile.Write("1#PLC", "IP", machine.DeviceIP);
                iniFile.Write("1#PLC", "端口", machine.IPPort);
                iniFile.Write("1#PLC", "设备ID", machine.DeviceID);
                iniFile.Write("1#PLC", "备注", machine.DeviceRemark);
                iniFile.UpdateFile();
                UIMessageBox.ShowError("保存成功！重启软件后生效");
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError("保存失败！"+ex.Message);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void FrmNewMachine_Load(object sender, EventArgs e)
        {
            this.txtIPAddress.Text = CommonData.objDevice?.DeviceIP;
            this.txtPort.Text = CommonData.objDevice?.IPPort.ToString();
            this.txtID.Text = CommonData.objDevice?.DeviceID.ToString();
            this.txtName.Text = CommonData.objDevice?.DeviceName;
            this.txtRemark.Text = CommonData.objDevice?.DeviceRemark;
        }

        #region 自定义方法
        #endregion
    }
}
