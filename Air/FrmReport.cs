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
using DAL;
using Models;

namespace Air
{
    public partial class FrmReport : UIForm
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        List<Variables> ReportList;

        #region 自定义方法

        private void Query()
        {
            this.dgvReport.Columns.Clear();

        }
        #endregion

        private void FrmReport_Load(object sender, EventArgs e)
        {
            cmbClassSelect.Items.AddRange(new string[] { "早班", "中班", "晚班" });
            cmbReportType.Items.AddRange(new string[] { "班报表", "日报表", "周报表", "月报表" });
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            FrmQuerySelect objFrm = new FrmQuerySelect();
            objFrm.ShowDialog();
            if (objFrm.DialogResult==DialogResult.OK)
            {
                ReportList = objFrm.SelectedList;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnPriview_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }
    }
}
