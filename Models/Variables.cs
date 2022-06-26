using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{
    [Serializable]
    [XmlRoot(ElementName ="Variable")]
    public class Variables
    {
        /// <summary>
       /// 变量名称
        /// </summary>
        [XmlElement(ElementName ="VarName")]
        public string VarName { get; set; }
        /// <summary>
        /// 存储区域
        /// </summary>
        [XmlElement(ElementName = "storeArea")]
        public RegisterType storeArea { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement(ElementName = "Address")]
        public int Address { get; set; }
        /// <summary>
        /// 数据类型
        /// </summary>
        [XmlElement(ElementName = "DataType")]
        public PLCDataType DataType { get; set; }
        /// <summary>
        /// 是否归档
        /// </summary>
        [XmlElement(ElementName = "IsFilling")]
        public string IsFilling { get; set; }
        /// <summary>
        /// 是否报警
        /// </summary>
        [XmlElement(ElementName = "IsAlarm")]
        public string IsAlarm { get; set; }
        /// <summary>
        /// 是否参与报表
        /// </summary>
        [XmlElement(ElementName = "IsReport")]
        public string IsReport { get; set; }
        /// <summary>
        /// 注释与说明
        /// </summary>
        [XmlElement(ElementName = "Note")]
        public string Note { get; set; }
        /// <summary>
        /// 绝对地址
        /// </summary>
        [XmlElement(ElementName = "AbsoluteAddress")]
        private string absoluteAddress;
        public string AbsoluteAddress
        {
            get
            {
                int store = 0;
                switch (storeArea)
                {
                    case RegisterType.CoilStatus: store = 0; break;
                    case RegisterType.InputStatus: store = 1; break;
                    case RegisterType.HoldingRegister: store = 4; break;
                    case RegisterType.InputRegister: store = 3; break;
                    default: store = 4; break;
                }
                return (store * 10000 + Address).ToString();
            }
            set
            {
                value = absoluteAddress;
            }
        }
    }
}
