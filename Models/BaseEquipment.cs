namespace Models
{
    public class BaseEquipment
    {
        /// <summary>是否连接成功</summary>
        public bool IsConnected { get; }

        /// <summary>读取超时时间</summary>
        public int ReadTimeOut { get; set; }

        /// <summary>写入超时时间</summary>
        public int WriteTimeOut { get; set; }

        /// <summary>重连次数</summary>
        public int ReconnectTimes { get; set; }
    }
}
