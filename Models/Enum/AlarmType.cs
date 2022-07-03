using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 报警类型枚举
    /// </summary>
    public enum AlarmType
    {
        /// <summary>
        /// 低低报警
        /// </summary>
        LoLo,
        /// <summary>
        /// 低报警
        /// </summary>
        Low,
        /// <summary>
        /// 高报警
        /// </summary>
        High,
        /// <summary>
        /// 高高报警
        /// </summary>
        HiHi
    }
}
