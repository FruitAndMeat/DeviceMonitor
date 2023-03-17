using System;
using System.Collections.Generic;

namespace Models
{
    [Serializable]
    public class VarAlarm
    {
        /// <summary>
        /// 报警名称
        /// </summary>
        public string VarName { get; set; }
        /// <summary>
        /// 报警集合
        /// </summary>
        public List<Alarm> listAlarm = new List<Alarm>();
    }
}
