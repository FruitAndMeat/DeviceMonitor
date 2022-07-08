using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace Air
{
    class InsertData
    {

        #region 私有字段
        System.Timers.Timer _timer;
        VarRecordServices _objVRS = new VarRecordServices();
        #endregion

        public InsertData(ushort interval)
        {
            _timer = new System.Timers.Timer(interval);
            _timer.Elapsed += _timer_Elapsed;
            _timer.AutoReset = true;
            _timer.Enabled = true;
            _timer.Start();
        }

        private void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (CommonData.CommOk==true)
            {
                InsertActualData();
            }
        }
        /// <summary>
        /// 插入报表数据，一分钟一次
        /// </summary>
        private void InsertReportData()
        {
            
        }

        /// <summary>
        /// 插入实时数据
        /// </summary>
        private void InsertActualData()
        {
            if (CommonData.CurrentValue!=null&&CommonData.CurrentValue.Count>0)
            {
                List<VarRecord> varRecords = new List<VarRecord>();
                List<string> sqlList = new List<string>();//存储事务sql语句的集合
                foreach (Variables item in CommonData.fileVarList)
                {
                    string varName = item.VarName;
                    float value = 0.0F;
                    if (CommonData.CurrentValue.ContainsKey(varName)&&CommonData.CurrentValue[varName].Length>0)
                    {
                        value = Convert.ToSingle(CommonData.CurrentValue[varName]);
                    }
                    varRecords.Add(new VarRecord()
                    { InsertTime = DateTime.Now, VarName = varName, VarValue =value});
                }
                //添加完语句开始执行事务
                try
                {
                    _objVRS.InsertActualData(varRecords);
                }
                catch (Exception)
                {
                    
                }
                if (CommonData.varRecordList.Count >= CommonData.RecordCount)
                {
                    CommonData.varRecordList.RemoveAt(0);
                }
                CommonData.varRecordList.Add(varRecords);
            }
        }


    }
}
