using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace Air
{
    public partial class FrmTrendView : UIForm
    {
        public FrmTrendView()
        {
            InitializeComponent();
            //option  = this. TrendChart.Option;
        }

        //private UILineOption option; 
        

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

            #region UILineChart图表初始化(废弃)
            //option.Series.Clear();
            //option.Title.Text = this.cmbTrendType.Text;
            //option.Title.SubText = this.cmbTrendArea.Text;
            //option.XAxisType = UIAxisType.DateTime;
            //option.XAxis.Name = "时间";
            //option.XAxis.AxisLabel.AutoFormat = false;
            //option.XAxis.AxisLabel.DateTimeFormat = "yyyy-MM-dd HH:mm:ss";

            //option.YAxis.Name = "输出电流与电压";
            //option.YAxis.MaxAuto = true;

            //option.Y2Axis.Name = "输出频率";
            //option.Y2Axis.MaxAuto = true;


            //TrendChart.SetOption(option);
            #endregion
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            #region UILineChart添加曲线（废弃）
            //option.Series.Clear();
            //foreach (var item in GrpVarSelect.SelectedItems)
            //{
            //    string seriesName = this.cmbTrendArea.Text + item.ToString();
            //    bool isY2  = item.ToString() == "输出频率" ? true : false;
            //    //UILineSeries lineSeries = new UILineSeries(seriesName);
            //    var lineSeries = option.AddSeries(new UILineSeries(seriesName,Color.AliceBlue,isY2));

            //    lineSeries.Visible = true;
            //    lineSeries.SymbolLineWidth = 2;
            //    lineSeries.SymbolSize = 4;
            //    lineSeries.Smooth = true;
            //    lineSeries.ShowLine = true;
            //}
            #endregion

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GrpVarSelect.UnSelectAll();
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
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

            if (BtnStop.Text=="暂停更新")
            {
                BtnStop.Text = "继续更新";
            }
            else
            {
                BtnStop.Text = "暂停更新";
            }
        }

        private void cmbTrendType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //option.Title.Text = this.cmbTrendType.Text;
        }

        private void cmbTrendArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            //option.Title.SubText = this.cmbTrendArea.Text;
            //GrpVarSelect.UnSelectAll();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
