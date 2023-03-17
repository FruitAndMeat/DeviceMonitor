using System.ComponentModel;

namespace Models
{
    /// <summary>
    /// 报表类型枚举变量
    /// </summary>
    enum ReportType
    {
        /// <summary>班报表</summary>
        [Description("班报表")]
        Tour = 0,
        /// <summary>日报表</summary>
        [Description("日报表")]
        Daily = 1,
        /// <summary>周报表</summary>
        [Description("周报表")]
        Weekly = 2,
        /// <summary>月度报表</summary>
        [Description("月度报表")]
        Monthly = 3,
        /// <summary>季度报表</summary>
        [Description("季度报表")]
        Quarterly = 4,
        /// <summary>年度报表</summary>
        [Description("年度报表")]
        Yearly = 5
    }
}
