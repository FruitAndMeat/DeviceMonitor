using Models;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
    public class VarRecordServices
    {

        #region 使用事务插入实时数据
        public void InsertActualData(List<VarRecord> varRecords) {
            List<SqlParameter[]> sqlParameters = new List<SqlParameter[]>();
            string sql = $"Insert into VarRecord(InsertTime,VarName,VarValue) " +
                        $"values (@InsertTime,@VarName,@VarValue)";
            foreach (var item in varRecords) {
                SqlParameter[] parameters =
                    { new SqlParameter("@InsertTime",DateTime.Now),
                    new SqlParameter("@VarName",item.VarName),
                    new SqlParameter("@VarValue",item.VarValue)
                };
                sqlParameters.Add(parameters);
            }
            try {
                SQLHelper.UpdateByTran(sql, sqlParameters);
            }
            catch { throw; }
        }

        #endregion

        #region 根据时间查询历史趋势
        public DataTable GetHistoryDataByDateTime(string varName, DateTime startTime, DateTime endTime) {
            string sql = "select InsertTime,VarValue from VarRecord " +
                "where VarName=@VarName and InsertTime between @startTime and @endTime";
            SqlParameter[] parameters =
                {
                new SqlParameter("@VarName",varName),
                new SqlParameter("@startTime",startTime),
                new SqlParameter("@endTime",endTime),
            };
            try {
                return SQLHelper.GetDataSet(sql, parameters).Tables[0];
            }
            catch {
                return null;
            }
        }

        #endregion

        #region 配置sqlsugar
        public static SqlSugarScope Db = new SqlSugarScope(new ConnectionConfig() {
            ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ToString(),
            DbType = SqlSugar.DbType.SqlServer,
            IsAutoCloseConnection = true
        },
            Db => {
                Db.Aop.OnLogExecuting = (sql, pars) => {
                    Console.WriteLine(sql);
                };
            });



        #endregion

        public DataTable QueryReport(List<string> varNameList, DateTime startTime, string reportType) {
            DataTable dt = null;
            dt = Db.Queryable<VarRecord>().Where(it => varNameList.Contains(it.VarName))
                .Where(it => it.InsertTime.Second == 0 && it.InsertTime.Minute == 0)
                .WhereIF(reportType == "班报表", it => it.InsertTime <= SqlFunc.DateAdd(startTime, 8, DateType.Hour) && it.InsertTime >= startTime)
                .WhereIF(reportType == "日报表", it => it.InsertTime <= SqlFunc.DateAdd(startTime, 1, DateType.Day) && it.InsertTime >= startTime)
                .WhereIF(reportType == "周报表", it => it.InsertTime <= SqlFunc.DateAdd(startTime, 1, DateType.Weekday) && it.InsertTime >= startTime)
                .WhereIF(reportType == "月报表", it => it.InsertTime <= SqlFunc.DateAdd(startTime, 1, DateType.Month) && it.InsertTime >= startTime)
                .OrderBy(st => st.InsertTime, OrderByType.Asc)
                .ToPivotTable(it => it.VarName, it => it.InsertTime, it => it.Sum(x => x.VarValue));
            for (int i = 0; i < dt.Rows.Count; i++) {
                dt.Rows[i][0] = Convert.ToDateTime(dt.Rows[i][0]).ToString("yyyy-MM-dd HH:mm");
            }
            return dt;
        }
    }
}
