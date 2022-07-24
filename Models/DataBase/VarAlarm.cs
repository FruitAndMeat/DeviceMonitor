using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
