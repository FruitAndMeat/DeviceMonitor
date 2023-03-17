using System;

namespace Models
{
    /// <summary>
    /// 报警实体类
    /// </summary>
    [Serializable]
    public class Alarm
    {
        /// <summary>
        /// 枚举，报警类型
        /// </summary>
        public AlarmType alarmType { get; set; }
        /// <summary>
        /// 报警限值
        /// </summary>
        public float alarmLimitValue { get; set; }
        /// <summary>
        /// 报警优先级
        /// </summary>
        public int priority { get; set; }
        /// <summary>
        /// 报警注释与说明
        /// </summary>
        public string alarmNote { get; set; }
    }
}
