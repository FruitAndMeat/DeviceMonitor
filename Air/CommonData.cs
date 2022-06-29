﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace Air
{
    public delegate void UpdateAlarmDelegate();

    public static class CommonData
    {
        /// <summary>全局的操作员信息 </summary>
        public static Admins SysAdmin = null;

        /// <summary>全局通讯设备信息 </summary>
        public static Device objDevice = null;

        public static Modbus objMod = null;
        
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

        /// <summary>变量名称与变量值的字典集合 </summary>
        public static Dictionary<string, string> CurrentValue = new Dictionary<string, string>();

        /// <summary>变量名称与变量地址的字典集合 </summary>
        public static Dictionary<string, string> CurrentAddress = new Dictionary<string, string>();
        /// <summary>
        /// 归档变量信息集合
        /// </summary>
        public static List<Variables> fileVarList = new List<Variables>();
        /// <summary>
        /// 数据报表信息集合
        /// </summary>
        public static List<Variables> reportVarList = new List<Variables>();

        /// <summary>
        /// 变量信息集合
        /// </summary>
        public static List<Variables> variableList = new List<Variables>();
        /// <summary>
        /// 报警信息集合
        /// </summary>
        public static List<VarAlarm> varAlarmList = new List<VarAlarm>();

        /// <summary> 存储区域集合</summary>
        public static List<StoreArea> storeAreaList = new List<StoreArea>();

        /// <summary>
        /// 报警缓存区列表
        /// </summary>
        public static List<AlarmRecord> alarmRecordList = new List<AlarmRecord>();
        /*优化*/
        /// <summary>
        /// 报警缓存区列表的最大值
        /// </summary>
        public static readonly int alarmRecordMax = 100;

        /// <summary>线程专用数据写入的标志位</summary>
        public static bool IsWriteing=false;
        /// <summary>通讯状态标志位</summary>
        public static bool CommOk = false;

        public static event UpdateAlarmDelegate update;

        public static void UpdateAlarm()
        {
            if (update!=null)
            {
                update.Invoke();
            }
        }

    }
}
