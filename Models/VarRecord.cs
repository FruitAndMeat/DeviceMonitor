using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 变量历史记录
    /// </summary>
    public class VarRecord
    {
        /// <summary>
        /// 记录ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 对应的变量ID
        /// </summary>
        public int VariableID { get; set; }
        /// <summary>
        /// 记录的时间
        /// </summary>
        public DateTime InsertDate { get; set; }
        /// <summary>
        /// 记录的值
        /// </summary>
        public double VarValue { get; set; }
    }
}
