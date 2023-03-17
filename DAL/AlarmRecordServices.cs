using Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AlarmRecordServices
    {
        /// <summary>
        /// 插入报警记录
        /// </summary>
        /// <param name="objAlarm">报警记录对象</param>
        public void InsertAlarmData(AlarmRecord objAlarm) {
            string sql = "Insert into AlarmRecord(AlarmDate,VarName,AlarmState,Priority,AlarmType,ActualValue,AlarmValue,AlarmNote) " +
                "values (@AlarmDate,@VarName,@AlarmState,@Priority,@AlarmType,@ActualValue,@AlarmValue,@AlarmNote)";
            SqlParameter[] parameters =
                {
                new SqlParameter("@AlarmDate",objAlarm.alarmDate),
                new SqlParameter("@VarName",objAlarm.varName),
                new SqlParameter("@AlarmState",objAlarm.alarmState.ToString()),
                new SqlParameter("@Priority",objAlarm.priority),
                new SqlParameter("@AlarmType",objAlarm.alarmType.ToString()),
                new SqlParameter("@ActualValue",objAlarm.actualValue),
                new SqlParameter("@AlarmValue",objAlarm.alarmValue),
                new SqlParameter("@AlarmNote",objAlarm.alarmNote),
                };
            try {
                SQLHelper.Update(sql, parameters);
            }
            catch { throw; }
        }

        /// <summary>
        /// 根据时间区间查询报警记录
        /// </summary>
        /// <param name="startTime">起始时间</param>
        /// <param name="endTime">终止时间</param>
        /// <returns>查询数据表</returns>
        public DataTable QueryAlarmRecord(DateTime startTime, DateTime endTime) {
            string sql = "Select AlarmDate,VarName,AlarmState,Priority,AlarmType,ActualValue,AlarmValue,AlarmNote " +
                "from AlarmRecord " +
                "where AlarmDate between @startTime and @endTime  order By AlarmID DESC";
            SqlParameter[] parameters = { new SqlParameter("@startTime", startTime), new SqlParameter("@endTime", endTime) };
            try {
                return SQLHelper.GetDataSet(sql, parameters).Tables[0];
            }
            catch (Exception) {

                throw;
            }

        }
    }
}
