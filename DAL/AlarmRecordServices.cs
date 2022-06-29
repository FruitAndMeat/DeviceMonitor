﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class AlarmRecordServices
    {
        public void InsertAlarmData(AlarmRecord objAlarm)
        {
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
            try
            {
                SQLHelper.Update(sql, parameters);
            }
            catch { throw; }
        }
    }
}