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

        List<string> ReportList;
        VarRecordServices objVRS = new VarRecordServices();

        #region 自定义方法

        

        private void InitialDGV(DataGridView dgv,List<Variables> list )
        {
            //删除表中的所有列
            dgv.Columns.Clear();
            //添加日期时间列
            DataGridViewTextBoxColumn InsertTime = new DataGridViewTextBoxColumn();
            InsertTime.DataPropertyName = "InsertTime";
            InsertTime.HeaderText = "日期时间";
            InsertTime.Name = "InsertTime";
            InsertTime.DefaultCellStyle.Format = "yyyy-MM-dd HH:00";
            InsertTime.Width = 130;
            dgv.Columns.Add(InsertTime);

            foreach (Variables item in list)
            {
                DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn();
                //newColumn.DataPropertyName = "VarValue";
                newColumn.HeaderText = item.VarName;
                newColumn.Name = item.VarName;
                newColumn.Width = 130;
                dgv.Columns.Add(newColumn);
            }

        }
        
        #endregion

        private void FrmReport_Load(object sender, EventArgs e)
        {
            cmbClassSelect.Items.AddRange(new string[] { "早班", "中班", "晚班" });
            cmbClassSelect.SelectedIndex = 0;
            cmbReportType.Items.AddRange(new string[] { "班报表", "日报表", "周报表", "月报表" });
            cmbReportType.SelectedIndex = 0;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            FrmQuerySelect objFrm = new FrmQuerySelect();
            objFrm.ShowDialog();
            if (objFrm.DialogResult==DialogResult.OK)
            {
                ReportList = objFrm.SelectedList;
                if (ReportList == null|| ReportList.Count<=0)
                {
                    UIMessageBox.ShowInfo("未选择任何变量！查询失败");
                    return;
                }
                //InitialDGV(dgvReport,ReportList);
                //DataTable dt=  objVRS.GetHistoryDataByTimeArea(ReportList, dtpQueryTime.Value, cmbReportType.Text);
                

                dgvReport.DataSource = objVRS.QueryReport(ReportList, dtpQueryTime.Value, cmbReportType.Text);
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
        //根据选择的报表类型修改时间的DateFormata
        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbReportType.Text)
            {
                case "班报表":
                    switch (cmbClassSelect.Text)
                    {
                        case "早班":dtpQueryTime.DateFormat = "yyyy-MM-dd 08:00"; break;
                        case "中班":dtpQueryTime.DateFormat = "yyyy-MM-dd 16:00";break;
                        case "晚班":dtpQueryTime.DateFormat = "yyyy-MM-dd 00:00";break;
                    }
                    break;
                case "日报表":
                case "周报表":dtpQueryTime.DateFormat = "yyyy-MM-dd 00:00";break;
                case "月报表":dtpQueryTime.DateFormat = "yyyy-MM-01 00:00";break;
            }
        }

        //根据选择的班类型修改时间的DateFormata
        private void cmbClassSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReportType.Text=="班报表")
            {
                switch (cmbClassSelect.Text)
                {
                    case "早班": dtpQueryTime.DateFormat = "yyyy-MM-dd 08:00"; break;
                    case "中班": dtpQueryTime.DateFormat = "yyyy-MM-dd 16:00"; break;
                    case "晚班": dtpQueryTime.DateFormat = "yyyy-MM-dd 00:00"; break;
                }
            }
            
        }
    }
}
