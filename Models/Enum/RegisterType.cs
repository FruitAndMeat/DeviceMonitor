namespace Models
{
    /// <summary>
    /// 枚举，Modbus通讯寄存器类型
    /// </summary>
    public enum RegisterType
    {
        /// <summary>
        /// 离散输出线圈
        /// </summary>
        CoilStatus = 0,
        /// <summary>
        /// 离散输入
        /// </summary>
        InputStatus = 1,
        /// <summary>
        /// 保持寄存器
        /// </summary>
        HoldingRegister = 4,
        /// <summary>
        /// 输入寄存器
        /// </summary>
        InputRegister = 3
    }
}
