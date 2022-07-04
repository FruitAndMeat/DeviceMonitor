using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Sunny.UI;
using Models;
using DAL;

namespace Air
{
    public partial class FrmTrendView : UIForm
    {
        public FrmTrendView()
        {
            InitializeComponent();
            
        }
        /// <summary>变量数据记录访问类</summary>
        VarRecordServices objVRS = new VarRecordServices();
        

        #region 自定义私有方法
        //给chart1添加选中的变量的曲线series
        private void AddSeries()
        {
            this.chart1.Series.Clear();
            foreach (var item in GrpVarSelect.SelectedItems)
            {
                string name = this.cmbTrendArea.Text + item.ToString();
                Series series = new Series(name);
                series.ChartType = SeriesChartType.Spline;
                series.BorderWidth = 3;
                series.XValueType = ChartValueType.DateTime;
                series.YValueType = ChartValueType.Single;
                //如果是电流或者频率的点位，就添加到Y2轴
                if (item.ToString().Contains("电流") || item.ToString().Contains("频率"))
                {
                    series.YAxisType = AxisType.Secondary;
                }
                else
                {
                    series.YAxisType = AxisType.Primary;
                }
                this.chart1.Series.Add(series);
            }
        }

        private void QueryHistoryTrend(DateTime startTime, DateTime endTime)
        {
            List<DataTable> list = new List<DataTable>();
            for (int i = 0; i < this.chart1.Series.Count; i++)
            {
                DataTable dt = objVRS.GetHistoryDataByDateTime(this.chart1.Series[i].Name, startTime, endTime);
                if (dt != null)
                {
                    list.Add(dt);
                }
            }

           if (list.Count == this.chart1.Series.Count)
            {
                for (int i = 0; i < this.chart1.Series.Count; i++)
                {
                    this.chart1.Series[i].Points.Clear();
                    this.chart1.Series[i].IsValueShownAsLabel = false;
                    this.chart1.Series[i].Points.DataBind(list[i].AsEnumerable(), "InsertTime", "VarValue", "");
                }
           }

        }

        
        #endregion



        private void FrmTrendView_Load(object sender, EventArgs e)
        {
            #region 控件值初始化
            this.cmbTrendType.Items.AddRange(new string[] { "实时趋势", "历史趋势" });
            this.cmbTrendArea.Items.AddRange(new string[] { "1#电机", "2#电机" });
            this.cmbTrendType.SelectedIndex = 0;
            this.cmbTrendArea.SelectedIndex = 0;
            TimeSpan ts = new TimeSpan(7, 0, 0, 0, 0);
            this.DtpStart.Value = DateTime.Now.Subtract(ts);
            this.DtpEnd.Value = DateTime.Now;
            this.txtCount.Value = 20;

            #endregion
            
        }
        //实时趋势更新
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text=="实时趋势更新")
            {
                timer1.Enabled = true;
                btnUpdate.Text = "暂停更新";
            }
            else if(btnUpdate.Text == "暂停更新")
            {
                timer1.Enabled = false;
                btnUpdate.Text = "实时趋势更新";
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            AddSeries();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GrpVarSelect.UnSelectAll();
        }
        //历史趋势查询
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            this.cmbTrendType.SelectedIndex = 1;
            //开始历史查询就停止实时更新的使能
            timer1.Enabled = false;
            this.btnUpdate.Text="实时趋势更新";

            #region 时间范围判断
            DateTime startTime = this.DtpStart.Value;
            DateTime endTime = this.DtpEnd.Value;
            if (endTime < startTime)
            {
                UIMessageBox.ShowWarning("开始时间与结束时间不符合，请检查修改后重试。");
                return;
            }
            if ((endTime - startTime).TotalDays > 7.0)
            {
                UIMessageBox.ShowWarning("查询范围太大，请缩小查询范围，最大间隔为7天。");
                return;
            }
            
            #endregion
            //给chart1添加选中的变量的曲线series
            AddSeries();
            //历史趋势查询
            Task t= Task.Run(() => QueryHistoryTrend(startTime, endTime));

        }

        private void cmbTrendType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbTrendArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Series series in this.chart1.Series)
            {
                List<DateTime> X = new List<DateTime>();
                List <double> Y = new List<double>();
                int index = 0;
                int recordCount = CommonData.varRecordList.Count;
                for (int i = 0; i < CommonData.fileVarList.Count; i++)
                {
                    if (CommonData.fileVarList[i].VarName==series.Name)
                    {
                        index = i;
                        break;
                    }
                }
                for (int i = 0; i < recordCount; i++)
                {
                    //这里可能有bug
                    List<VarRecord> list = CommonData.varRecordList[i];
                    X.Add(list[index].InsertTime);
                    Y.Add(list[index].VarValue);
                }
                series.IsValueShownAsLabel = false;
                series.Points.DataBindXY(X, Y);
            }
        }

        private void chart1_GetToolTipText(object sender, ToolTipEventArgs e)
        {

            HitTestResult myTestResult = chart1.HitTest(e.X, e.Y, ChartElementType.DataPoint);//获取命中测试的结果
            if (myTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                int i = myTestResult.PointIndex;
                DataPoint dp = myTestResult.Series.Points[i];
                DateTime dt = DateTime.FromOADate(dp.XValue);
                string YValue = dp.YValues[0].ToString();//获取数据点的Y值
                e.Text = "名称:" + myTestResult.Series.Name + "\r\n时间:" + dt.ToString("yyyy-MM-dd HH:mm:ss") + "\r\n数值:" + YValue;
            }
        }
    }
}
