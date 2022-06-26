using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    //定义全局枚举
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

    /// <summary>
    /// 报警类型枚举
    /// </summary>
    public enum AlarmType
    {
        /// <summary>
        /// 低低报警
        /// </summary>
        LoLo,
        /// <summary>
        /// 低报警
        /// </summary>
        Low,
        /// <summary>
        /// 高报警
        /// </summary>
        High,
        /// <summary>
        /// 高高报警
        /// </summary>
        HiHi
    }

    /// <summary>
    /// 西门子PLC的数据类型
    /// </summary>
    public enum PLCDataType
    {
        /// <summary>
        /// 布尔类型，True/False
        /// </summary>
        Bool=0,
        /// <summary>
        /// 数据类型 BYTE 的操作数是位字符串，有 8 位。
        /// </summary>
        Byte = 1,
        /// <summary>
        /// 数据类型 WORD 的操作数是位字符串，有 16 位。
        /// </summary>
        Word = 2,
        /// <summary>
        /// 数据类型 DWORD 的操作数是位字符串，有 32 位。
        /// </summary>
        DWord = 3,
        /// <summary>
        /// 数据类型 INT 的操作数在存储器中占用 2 BYTE。
        /// </summary>
        Int = 4,
        /// <summary>
        /// 数据类型 DINT 的操作数在存储器中占用 4 BYTE。
        /// </summary>
        DInt = 5,
        /// <summary>
        /// 数据类型 UINT 的操作数在存储器中占用 2 BYTE。
        /// </summary>
        Uint = 6,
        /// <summary>
        /// 数据类型 REAL 的操作数长度为 32 位，用于表示浮点数。
        /// </summary>
        Real = 7,
        /// <summary>
        /// 数据类型 LREAL 的操作数长度为 64 位，用于表示浮点数。
        /// </summary>
        LReal = 8
        
    }
}
