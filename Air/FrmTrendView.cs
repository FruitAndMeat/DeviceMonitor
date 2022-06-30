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
            option  = this. TrendChart.Option;
        }

        private UILineOption option; 
        

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

            #region 图表初始化
            option.Series.Clear();
            option.Title.Text = this.cmbTrendType.Text;
            option.Title.SubText = this.cmbTrendArea.Text;
            option.XAxisType = UIAxisType.DateTime;
            option.XAxis.Name = "时间";
            option.YAxis.Name = "输出电流与电压";
            option.YAxis.MaxAuto = true;
            option.Y2Axis.Name = "输出频率";
            option.Y2Axis.MaxAuto = true;
            //TrendChart.SetOption(option);
            #endregion
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {

        }

        private void cmbTrendType_SelectedIndexChanged(object sender, EventArgs e)
        {
            option.Title.Text = this.cmbTrendType.Text;
        }

        private void cmbTrendArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            option.Title.SubText = this.cmbTrendArea.Text;
        }
    }
}
