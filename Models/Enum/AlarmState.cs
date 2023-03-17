namespace Models
{
    /// <summary>
    /// 枚举，报警状态
    /// </summary>
    public enum AlarmState
    {
        /// <summary>
        /// 到达，满足触发报警的条件
        /// </summary>
        Incoming,
        /// <summary>
        /// 离去，不再满足触发报警的条件
        /// </summary>
        Outgoing,
        /// <summary>
        /// 确认，操作员已确认报警
        /// </summary>
        Acknowledge
    }
}
