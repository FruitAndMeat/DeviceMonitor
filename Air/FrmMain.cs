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
    public partial class FrmMain : UIForm
    {
        public FrmMain()
        {
            InitializeComponent();
            
        }
        //实例化一个通讯线程（实际应该一个device就实例化一个通讯线程）
        CommonThread objComm = new CommonThread();
        AlarmRecordServices objAlarmRS = new AlarmRecordServices();

        #region 事件
        private void btnIOMonitor_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmIOMonitor")==false)
            {
                OpenWindow(new FrmIOMonitor());
            }
            //((UIButton)sender).Enabled = false;
            SetEnable(sender);
        }

        private void btnParamSet_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmParamSet") == false)
            {
                OpenWindow(new FrmParamSet());
            }
            SetEnable(sender);
        }

        private void btnAlarmView_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmAlarmView") == false)
            {
                OpenWindow(new FrmAlarmView());
            }
            SetEnable(sender);
        }

        private void btnTrendView_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmTrendView") == false)
            {
                OpenWindow(new FrmTrendView());
            }
            SetEnable(sender);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmReport") == false)
            {
                OpenWindow(new FrmReport());
            }
            SetEnable(sender);
        }

        private void btnHardwareConfig_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmHardwareConfig") == false)
            {
                OpenWindow(new FrmHardwareConfig());
            }
            SetEnable(sender);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmAbout") == false)
            {
                OpenWindow(new FrmAbout());
            }
            SetEnable(sender);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (CloseWindow("FrmHome") == false)
            {
                OpenWindow(new FrmHome());
            }
        }
        //主窗体加载事件
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //初始化
            this.lblTime.Text = DateTime.Now.ToString();
            this.lblUser.Text = CommonData.SysAdmin?.LoginName;
            timer1.Enabled = true;

            InitialList();

            //打开通讯要在初始化之后(否则，commondata里的objDevice无信息)
            try
            {
                CommonData.objMod = new Modbus(CommonData.objDevice);
                CommonData.CommOk = true;
                InsertData insertData = new InsertData(1000);
                objComm.t.Start();
            }
            catch
            { CommonData.CommOk = false; }

            if (CloseWindow("FrmIOMonitor") == false)
            {
                OpenWindow(new FrmIOMonitor());
            }
            SetEnable(this.btnIOMonitor);

            InitialAlarm();
            Task.Run(new Action(CheckAlarm));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblTime.Text = DateTime.Now.ToString();
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
            frm.Parent = this.mainPanel;
            frm.Show();
        }

        /// <summary>
        /// 关闭窗口方法
        /// </summary>
        /// <param name="frmName">要检查的关闭窗口名字</param>
        /// <returns>如果当前打开的窗体就是需要打开的窗体，则返回True,并不关闭窗口。否则关闭窗口并返回false</returns>
        private bool CloseWindow(string frmName)
        {
            foreach (Control ct in this.mainPanel.Controls)
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
            foreach (Control ct in this.BtnPanel.Controls)
            {
                if (ct is UIButton)
                {
                    UIButton btn = (UIButton)ct;
                    btn.Enabled = true;
                }
            }
            ((UIButton)sender).Enabled = false;
            this.lblTitle.Text = ((UIButton)sender).Text;
        }

        //加载窗体时初始化。
        private void InitialList()
        {
            try
            {
                //1、从ini文件读取配置并保存到全局
                CommonData.objDevice = CommonMethod.LoadDevice(CommonData.deviceSetPath);
                //2、从xml文件读取变量信息。
                CommonData.variableList = CommonMethod.ReadXmlToList<List<Variables>>(CommonData.variablePath);
                CommonData.varAlarmList = CommonMethod.ReadXmlToList<List<VarAlarm>>(CommonData.varAlarmPath);
                CommonData.storeAreaList = CommonMethod.ReadXmlToList<List<StoreArea>>(CommonData.storeAreaPath);
                //3、填充报表、归档集合
                foreach (Variables item in CommonData.variableList)
                {
                    if (!CommonData.CurrentValue.ContainsKey(item.VarName))
                    {
                        CommonData.CurrentValue.Add(item.VarName, "");
                        CommonData.CurrentAddress.Add(item.VarName, item.Address.ToString());
                    }
                    switch (item.storeArea)
                    {
                        case RegisterType.CoilStatus:
                            objComm.List_0x.Add(item);
                            break;
                        case RegisterType.InputStatus:
                            objComm.List_1x.Add(item);
                            break;
                        case RegisterType.HoldingRegister:
                            objComm.List_4x.Add(item);
                            break;
                        case RegisterType.InputRegister:
                            objComm.List_3x.Add(item);
                            break;
                    }
                    if (item.IsFilling == "Y")
                    {
                        //后续添加报表所要使用的集合
                        CommonData.fileVarList.Add(item);
                    }
                    if (item.IsReport == "Y")
                    {
                        CommonData.reportVarList.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError("初始化失败:"+ex.Message);
            }
            
        }

                
        #region 初始化报警
        private Dictionary<string, float> LastValue = new Dictionary<string, float>();
        private void InitialAlarm()
        {
            foreach (VarAlarm item in CommonData.varAlarmList)
            {
                //填充LastValue字典
                //如果字典里没有这个变量，且实时值集合中有这个变量的值,则将实时值转换成浮点数并添加到字典里
                if (!LastValue.ContainsKey(item.VarName)&&CommonData.CurrentValue[item.VarName].Length>0)
                {
                    string value = CommonData.CurrentValue[item.VarName];
                    float floatValue = 0.00F;
                    float.TryParse(value, out floatValue);
                    LastValue.Add(item.VarName, floatValue);
                
                foreach (Alarm it in item.listAlarm)
                {
                    switch (it.alarmType)
                    {
                        case AlarmType.LoLo:
                        case AlarmType.Low:
                            if (floatValue<it.alarmLimitValue)
                            {
                                    AlarmRecord temp = new AlarmRecord(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                                        item.VarName,AlarmState.Incoming,it.alarmType,floatValue,it.alarmLimitValue,
                                        it.priority,it.alarmNote);
                                    objAlarmRS.InsertAlarmData(temp);
                                    NewAlarmHandle(temp);
                            }
                            break;
                        case AlarmType.High:
                        case AlarmType.HiHi:
                                if (floatValue > it.alarmLimitValue)
                                {
                                    AlarmRecord temp = new AlarmRecord(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                                        item.VarName, AlarmState.Incoming, it.alarmType, floatValue, it.alarmLimitValue,
                                        it.priority, it.alarmNote);
                                    objAlarmRS.InsertAlarmData(temp);
                                    NewAlarmHandle(temp);
                                }
                                break;
                    }
                }
                }
            }
        }

        #endregion

        #region 实时检查报警
        private void CheckAlarm()
        {
            while (true)
            {
                if (CommonData.CommOk&&LastValue.Count>0)
                {
                    foreach (VarAlarm item in CommonData.varAlarmList)
                    {
                        float storeValue = LastValue[item.VarName];
                        float actualValue =float.Parse( CommonData.CurrentValue[item.VarName]);
                        foreach (Alarm it in item.listAlarm)
                        {
                            float alarmLimitValue = it.alarmLimitValue;
                            switch (it.alarmType)
                            {
                                case AlarmType.LoLo:
                                case AlarmType.Low:
                                    if (storeValue<alarmLimitValue&&actualValue>alarmLimitValue)
                                    {
                                        AlarmRecord temp = new AlarmRecord(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                                         item.VarName, AlarmState.Outgoing, it.alarmType, actualValue, it.alarmLimitValue,
                                         it.priority, it.alarmNote);
                                        objAlarmRS.InsertAlarmData(temp);
                                        NewAlarmHandle(temp);
                                    }
                                    if (storeValue > alarmLimitValue && actualValue <= alarmLimitValue)
                                    {
                                        AlarmRecord temp = new AlarmRecord(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                                         item.VarName, AlarmState.Incoming, it.alarmType, actualValue, it.alarmLimitValue,
                                         it.priority, it.alarmNote);
                                        objAlarmRS.InsertAlarmData(temp);
                                        NewAlarmHandle(temp);
                                    }
                                    break;
                                case AlarmType.High:
                                case AlarmType.HiHi:
                                    if (storeValue > alarmLimitValue && actualValue <= alarmLimitValue)
                                    {
                                        AlarmRecord temp = new AlarmRecord(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                                         item.VarName, AlarmState.Outgoing, it.alarmType, actualValue, it.alarmLimitValue,
                                         it.priority, it.alarmNote);
                                        objAlarmRS.InsertAlarmData(temp);
                                        NewAlarmHandle(temp);
                                    }
                                    if (storeValue < alarmLimitValue && actualValue > alarmLimitValue)
                                    {
                                        AlarmRecord temp = new AlarmRecord(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                                         item.VarName, AlarmState.Incoming, it.alarmType, actualValue, it.alarmLimitValue,
                                         it.priority, it.alarmNote);
                                        objAlarmRS.InsertAlarmData(temp);
                                        NewAlarmHandle(temp);
                                    }
                                    break;
                            }
                        }
                        //更新LastValue
                        if (LastValue.ContainsKey(item.VarName))
                        {
                            LastValue[item.VarName] = actualValue;
                        }
                    }
                }
            }
        }


        #endregion

        private void NewAlarmHandle(AlarmRecord alarmRecord)
        {
            if (CommonData.alarmRecordList.Count >= CommonData.alarmRecordMax)
            {
                CommonData.alarmRecordList.RemoveAt(0);
            }
            CommonData.alarmRecordList.Add(alarmRecord);
            CommonData.UpdateAlarm();
        }

        #endregion


    }
}
