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
    public partial class FrmDeviceConfig : UIForm
    {
        public FrmDeviceConfig()
        {
            InitializeComponent();
        }


        

        //窗口加载时就刷新列表。
        private void FrmModbusConfig_Load(object sender, EventArgs e)
        {
            
        }

        //单击新增按钮打开新增设备界面（未实现）
        private void btnNew_Click(object sender, EventArgs e)
        {
            //FrmNewMachine objFrm = new FrmNewMachine();
            //objFrm.ShowDialog();
            //if (objFrm.DialogResult==DialogResult.OK)
            //{
            //    FrmModbusConfig_Load(null, null);
            //}
        }

        //修改按钮单击打开修改窗口,并在修改结束后刷新界面
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (this.dgvMachines.CurrentRow==null)
            {
                UIMessageBox.ShowInfo("未选中任何行，请选中行之后，再点击修改。");
                return;
            }
            Device machine = new Device()
            {
                DeviceID = Convert.ToInt32(this.dgvMachines.CurrentRow.Cells[0].Value),
                DeviceIP = this.dgvMachines.CurrentRow.Cells[1].Value.ToString(),
                IPPort= Convert.ToInt32(this.dgvMachines.CurrentRow.Cells[2].Value),
                DeviceName = this.dgvMachines.CurrentRow.Cells[3].Value.ToString(),
                DeviceRemark = this.dgvMachines.CurrentRow.Cells[4].Value.ToString()
            };
        }

        //刷新列表按钮
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }


        //dgv单元格双击打开修改界面
        private void dgvMachines_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModify_Click(null, null);
        }
    }
}
