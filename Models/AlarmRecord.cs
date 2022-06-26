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
        /// <summary>
        /// 报警记录ID
        /// </summary>
        public int AlarmID { get; set; }
        /// <summary>
        /// 报警变量
        /// </summary>
        public int VariableID { get; set; }
        /// <summary>
        /// 报警时间
        /// </summary>
        public DateTime AlarmDate { get; set; }
        /// <summary>
        /// 报警值
        /// </summary>
        public double AlarmValue { get; set; }
        /// <summary>
        /// 报警类型
        /// </summary>
        public int TypeID { get; set; }
        /// <summary>
        /// 报警状态
        /// </summary>
        public int StateID { get; set; }
    }
}
