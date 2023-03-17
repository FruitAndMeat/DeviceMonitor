using System;
using System.IO;

namespace DAL
{
    public static class LogHelper
    {
        /// <summary>
        /// 写入日志文件
        /// </summary>
        /// <param name="msg">错误信息文本</param>
        public static void WriteLog(string msg) {
            FileStream fs = new FileStream("log.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine($"{DateTime.Now.ToString()}：错误信息：{msg}");
            sw.Close();
            fs.Close();
        }
    }


}
