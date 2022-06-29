using Models;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Air
{
    public static class CommonMethod
    {

        /// <summary>加载设备配置</summary>
        /// <param name="iniPath">设备配置文件路径</param>
        /// <returns>返回一个Device对象</returns>
        public static Device LoadDevice(string iniPath)
        {
            try
            {
                IniFile iniFileEx = new IniFile(iniPath);
                return new Device()
                {
                    DeviceIP = iniFileEx.Read("1#PLC", "IP", ""),
                    IPPort = Convert.ToInt32(iniFileEx.ReadInt("1#PLC", "端口").ToString()),
                    DeviceID = Convert.ToInt32(iniFileEx.ReadInt("1#PLC", "设备ID").ToString()),
                    DeviceName = iniFileEx.Read("1#PLC", "设备名称", ""),
                    DeviceRemark = iniFileEx.Read("1#PLC", "备注", ""),
                };
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError("加载设备配置信息出现错误！" + ex.Message);
                return null;
            }
        }

        /// <summary>从XML文件读取对象信息到List集合（反序列化方式） </summary>
        /// <typeparam name="T">List集合</typeparam>
        /// <param name="xmlPath">xml文件的路径</param>
        /// <returns>返回T类型的List集合</returns>
        public static T ReadXmlToList<T>(string xmlPath) where T : class
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                var reader = File.OpenRead(xmlPath);
                var s = (T)serializer.Deserialize(reader);
                reader.Close();
                return s;
            }
            catch (Exception) { throw; }
        }


    }
}
