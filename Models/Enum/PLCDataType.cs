namespace Models
{
    /// <summary>
    /// 西门子PLC的数据类型
    /// </summary>
    public enum PLCDataType
    {
        /// <summary>
        /// 布尔类型，True/False
        /// </summary>
        Bool = 0,
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
