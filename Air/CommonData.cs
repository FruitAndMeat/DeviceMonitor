using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace Air
{
    public delegate void UpdateAlarmDelegate();

    /// <summary>跨界面更新UI的委托，在IO监控界面添加方法</summary>
    //public delegate void AsyncUpdateUI();

    public static class CommonData
    {
        /// <summary>全局的操作员信息 </summary>
        public static Admins SysAdmin = null;

        /// <summary>全局通讯设备信息 </summary>
        public static Device objDevice = null;

        public static DeviceServices objMod = null;

        #region 相关配置文件路径


        /// <summary>
        /// 设备配置文件路径
        /// </summary>
        public static readonly string deviceSetPath = System.Windows.Forms.Application.StartupPath + "\\ConfigFile\\DeviceSet.ini";
        /// <summary>
        /// 变量信息配置路径
        /// </summary>
        public static readonly string variablePath = System.Windows.Forms.Application.StartupPath + "\\ConfigFile\\Variables.xml";
        /// <summary>
        /// 报警信息配置路径
        /// </summary>
        public static readonly string varAlarmPath = System.Windows.Forms.Application.StartupPath + "\\ConfigFile\\VarAlarms.xml";
        /// <summary>
        /// 存储区域配置路径
        /// </summary>
        public static readonly string storeAreaPath = System.Windows.Forms.Application.StartupPath + "\\ConfigFile\\StoreArea.xml";
        #endregion


        /// <summary>变量名称与变量值的字典集合 </summary>
        public static Dictionary<string, string> CurrentValue = new Dictionary<string, string>();

        /// <summary>变量名称与变量地址的字典集合 </summary>
        public static Dictionary<string, string> CurrentAddress = new Dictionary<string, string>();

        /// <summary>归档变量信息集合</summary>
        public static List<Variables> fileVarList = new List<Variables>();

        /// <summary>数据报表信息集合 </summary>
        public static List<Variables> reportVarList = new List<Variables>();

        /// <summary>变量信息集合</summary>
        public static List<Variables> variableList = new List<Variables>();

        /// <summary>报警信息集合</summary>
        public static List<VarAlarm> varAlarmList = new List<VarAlarm>();

        /// <summary> 存储区域集合</summary>
        public static List<StoreArea> storeAreaList = new List<StoreArea>();

        /// <summary>报警缓存区列表</summary>
        public static List<AlarmRecord> alarmRecordList = new List<AlarmRecord>();
        /*优化*/
        /// <summary>
        /// 报警缓存区列表的最大值
        /// </summary>
        public static readonly int alarmRecordMax = 100;

        #region 历史趋势相关

        //双重list，一个VarRecord就是一个点，一个List<VarRecord>就是一条曲线，List<List<VarRecord>>就是几条曲线一起.
        /// <summary>趋势缓冲区变量</summary>
        public static List<List<VarRecord>> varRecordList = new List<List<VarRecord>>();
        /// <summary>趋势缓冲区存储数量，即每条曲线最多的点数。</summary>
        public const int RecordCount = 60;

        #endregion


        /// <summary>线程专用数据写入的标志位</summary>
        // public static bool IsWriteing=false;
        /// <summary>通讯状态标志位</summary>
        public static bool CommOk = false;

        /// <summary>刷新UI的全局委托</summary>
        public static Action UpdateUI;

        /// <summary>刷新报警的事件</summary>
        public static event UpdateAlarmDelegate update;

        public static void UpdateAlarm() {
            if (update != null) {
                update.Invoke();
            }
        }

    }
}
