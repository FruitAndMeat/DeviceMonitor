using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 设备实体类
    /// </summary>
    public class Device
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        public int DeviceID { get; set; }
        /// <summary>
        /// 设备IP
        /// </summary>
        public string DeviceIP { get; set; }
        /// <summary>
        /// 设备端口
        /// </summary>
        public int IPPort { get; set; }
        /// <summary>
        /// 设备名称
        /// </summary>
        public string DeviceName { get; set; }
        /// <summary>
        /// 设备备注
        /// </summary>
        public string DeviceRemark { get; set; }

        

    }
}
