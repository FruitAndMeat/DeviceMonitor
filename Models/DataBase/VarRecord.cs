using SqlSugar;
using System;

namespace Models
{
    /// <summary>变量历史记录 </summary>
    public class VarRecord
    {
        /// <summary>记录ID</summary>
        [SugarColumn(IsIdentity = true)]
        public int ID { get; }

        /// <summary>对应的变量ID</summary>
        public string VarName { get; set; }

        /// <summary>记录的时间</summary>
        public DateTime InsertTime { get; set; }

        /// <summary>记录的值</summary>
        public float VarValue { get; set; }
    }
}
