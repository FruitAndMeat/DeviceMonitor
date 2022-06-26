using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class StoreArea
    {
        /// <summary> 存储区域的类型 </summary>
        public RegisterType registerType { get; set; }
        /// <summary> 开始地址</summary>
        public int startAddr { get; set; }
        /// <summary>长度</summary>
        public int length { get; set; }
    }
}
