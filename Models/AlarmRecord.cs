using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 报警历史记录
    /// </summary>
    public class AlarmRecord
    {
        /// <summary>报警记录ID</summary>
        //public int alarmID { get; set; }

        /// <summary>报警时间 </summary>
        public DateTime alarmDate { get; set; }

        /// <summary>报警变量</summary>
        public string varName { get; set; }

        /// <summary>报警状态</summary>
        public AlarmState alarmState { get; set; }

        /// <summary>报警类型</summary>
        public AlarmType alarmType { get; set; }

        /// <summary>实时报警值</summary>
        public float actualValue { get; set; }

        /// <summary>设定报警值</summary>
        public float alarmValue { get; set; }

        /// <summary>报警优先级</summary>
        public int priority { get; set; }

        /// <summary>报警注释与说明</summary>
        public string alarmNote { get; set; }


        public AlarmRecord(string alarmDate,string varName,AlarmState alarmState,AlarmType alarmType,float actualValue,float alarmValue,int priority,string alarmNote)
        {
            this.alarmDate = Convert.ToDateTime(alarmDate);
            this.varName = varName;
            this.alarmState = alarmState;
            this.alarmType = alarmType;
            this.actualValue = actualValue;
            this.alarmValue = alarmValue;
            this.priority = priority;
            this.alarmNote = alarmNote;
        }
       
    }
}
