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
using Models;

namespace Air
{
    public partial class FrmQuerySelect : UIForm
    {
        public FrmQuerySelect()
        {
            InitializeComponent();
            this.Load += FrmQuerySelect_Load;
        }

        /// <summary>选择完的报表变量</summary>
        public List<string> SelectedList = new List<string>();

        #region 自定义方法

        private void AddVarByArea(string areaName)
        {
            foreach (Variables item in CommonData.fileVarList)
            {
                if (item.VarName.Contains(areaName))
                {
                    SelectedList.Add(item.VarName);
                }
            }
        }

        #endregion

        private void FrmQuerySelect_Load(object sender, EventArgs e)
        {
            this.cmbAreaSelect.Items.AddRange(new string[] { "1#电机组", "2#电机组" });
            this.cmbAreaSelect.SelectedIndex = 0;
            this.rdoSelectByArea.Checked = true;
            this.tsSelectControl.Enabled = false;

            foreach (Variables item in CommonData.reportVarList)
            {
                this.tsSelectControl.ItemsLeft.Add(item.VarName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            SelectedList.Clear();
            if (rdoSelectByArea.Checked)
            {
                switch (cmbAreaSelect.Text)
                {
                    case "1#电机组":
                        AddVarByArea("1#电机");
                        break;
                    case "2#电机组":
                        AddVarByArea("2#电机");
                        break;
                }
            }
            else if (rdoSelectFree.Checked)
            {
                foreach (string varName in tsSelectControl.ItemsRight)
                {
                    foreach (Variables item in CommonData.reportVarList)
                    {
                        if (item.VarName==varName)
                        {
                            SelectedList.Add(item.VarName);
                            break;
                        }
                    }
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void rdoSelectFree_CheckedChanged(object sender, EventArgs e)
        {
            this.tsSelectControl.Enabled = rdoSelectFree.Checked;
        }

        private void rdoSelectByArea_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbAreaSelect.Enabled = rdoSelectByArea.Checked;
        }
    }
}
