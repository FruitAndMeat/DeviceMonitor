using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class VarRecordServices
    {

        #region 使用事务插入实时数据
        public void InsertActualData(List<VarRecord> varRecords)
        {
            List<SqlParameter[]> sqlParameters = new List<SqlParameter[]>();
            string sql = $"Insert into VarRecord(InsertTime,VarName,VarValue) " +
                        $"values (@InsertTime,@VarName,@VarValue)";
            foreach (var item in varRecords)
            {
                SqlParameter[] parameters =
                    { new SqlParameter("@InsertTime",DateTime.Now),
                    new SqlParameter("@VarName",item.VarName),
                    new SqlParameter("@VarValue",item.VarValue)
                };
                sqlParameters.Add(parameters);
            }
            try
            {
                SQLHelper.UpdateByTran(sql,sqlParameters);
            }
            catch { throw; }
        }

        #endregion

        #region 插入报表数据
        //public void InsertReportData()
        //{

        //}
        #endregion
    }
}
