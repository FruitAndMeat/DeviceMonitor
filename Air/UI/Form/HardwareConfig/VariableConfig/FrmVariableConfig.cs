using Models;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Air
{
    public partial class FrmVariableConfig : UIForm
    {
        public FrmVariableConfig() {
            InitializeComponent();
        }

        //定义该窗口私有的变量表，不可以直接使用全局数据的变量表，增删改变量会造成混乱。
        private List<VarAlarm> varAlarmList = new List<VarAlarm>();
        private List<Variables> variableList = new List<Variables>();

        private void UpdateDGV() {
            //在dgv与list集合绑定并需要刷新数据源时，不可以赋值null给DataSource，而是需要
            //赋值一个new List<T>();否则会出现异常。
            this.dgvVariable.DataSource = new List<Variables>();
            //这个是在初始化绑定的时候先判断列表的count是否大于0，大于0了再绑定
            //不然绑定后点击单元格会触发异常:索引-1，没有值。
            if (variableList != null && variableList.Count > 0) {
                this.dgvVariable.DataSource = this.variableList;
            }

        }
        /// <summary>
        ///  保存List对象集合到XML文件（序列化方式）
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="list">List集合</param>
        /// <param name="xmlPath">保存的路径</param>
        private void SaveListToXML(object obj, string xmlPath) {
            try {
                #region
                //using (StringWriter stringWriter = new StringWriter(new StringBuilder()))
                //{
                //    XmlSerializer xmlSerializer = new XmlSerializer(list.GetType());
                //    xmlSerializer.Serialize(stringWriter, list);

                //    FileStream fs = new FileStream(xmlPath, FileMode.OpenOrCreate);
                //    StreamWriter sw = new StreamWriter(fs);
                //    sw.Write(stringWriter.ToString());
                //    sw.Close();
                //    fs.Close();
                //}
                #endregion

                XmlSerializer serializer = new XmlSerializer(obj.GetType());
                string content = string.Empty;
                //serialize
                using (StringWriter writer = new StringWriter()) {
                    serializer.Serialize(writer, obj);
                    content = writer.ToString();
                }
                //save to file
                using (StreamWriter stream_writer = new StreamWriter(xmlPath, false, Encoding.Unicode)) {
                    stream_writer.Write(content);
                }
            }
            catch { throw; }

        }

        /// <summary>
        /// 判断再报警变量集合中，是否有查找的变量
        /// </summary>
        /// <param name="objAlarm">需要查找的报警变量</param>
        /// <param name="varAlarmList">报警变量List集合</param>
        /// <returns>返回查找结果，若为True,则为查找到，否则为false</returns>
        private bool SelectVarAlarm(VarAlarm objAlarm, List<VarAlarm> varAlarmList) {
            bool res = false;
            foreach (VarAlarm item in varAlarmList) {
                if (item.VarName == objAlarm.VarName) {
                    res = true;
                    break;
                }
            }
            return res;
        }

        #region 根据当前变量集合，自动计算存储区域
        private List<StoreArea> Calculate() {
            List<StoreArea> StoreList = new List<StoreArea>();
            List<Variables> list_0x = new List<Variables>();
            List<Variables> list_1x = new List<Variables>();
            List<Variables> list_3x = new List<Variables>();
            List<Variables> list_4x = new List<Variables>();
            foreach (Variables item in variableList) {
                switch (item.storeArea) {
                    case RegisterType.CoilStatus:
                        list_0x.Add(item);
                        break;
                    case RegisterType.InputStatus:
                        list_1x.Add(item);
                        break;
                    case RegisterType.HoldingRegister:
                        list_4x.Add(item);
                        break;
                    case RegisterType.InputRegister:
                        list_3x.Add(item);
                        break;
                }
            }
            if (list_0x.Count > 0) {
                StoreList.Add(new StoreArea {
                    registerType = RegisterType.CoilStatus,
                    startAddr = AnalyseVar(list_0x)[0],
                    length = AnalyseVar(list_0x)[1]
                });
            }
            if (list_1x.Count > 0) {
                StoreList.Add(new StoreArea {
                    registerType = RegisterType.InputStatus,
                    startAddr = AnalyseVar(list_1x)[0],
                    length = AnalyseVar(list_1x)[1]
                });
            }
            if (list_3x.Count > 0) {
                StoreList.Add(new StoreArea {
                    registerType = RegisterType.InputRegister,
                    startAddr = AnalyseVar(list_3x)[0],
                    length = AnalyseVar(list_3x)[1]
                });
            }
            if (list_4x.Count > 0) {
                StoreList.Add(new StoreArea {
                    registerType = RegisterType.HoldingRegister,
                    startAddr = AnalyseVar(list_4x)[0],
                    length = AnalyseVar(list_4x)[1]
                });
            }
            return StoreList;
        }


        /// <summary>
        /// 根据变量List集合，排序并获取集合里变量的最小开始地址和长度
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private List<int> AnalyseVar(List<Variables> list) {
            List<int> resultList = new List<int>(2);
            List<int> addressList = new List<int>();
            int start, end, length = 0;
            PLCDataType dataType = 0;
            foreach (Variables item in list) {
                addressList.Add(item.Address);
            }
            start = GetMin(addressList);
            end = GetMax(addressList);
            foreach (Variables item in list) {
                if (item.Address == end) {
                    dataType = item.DataType;
                }
            }
            switch (dataType) {
                case PLCDataType.Bool:
                    length = end - start + 1;
                    break;
                case PLCDataType.Byte:
                    length = end - start + 1;
                    break;
                case PLCDataType.Word:
                    length = end - start + 1;
                    break;
                case PLCDataType.DWord:
                    length = end - start + 2;
                    break;
                case PLCDataType.Int:
                    length = end - start + 1;
                    break;
                case PLCDataType.DInt:
                    length = end - start + 2;
                    break;
                case PLCDataType.Uint:
                    length = end - start + 2;
                    break;
                case PLCDataType.Real:
                    length = end - start + 2;
                    break;
                case PLCDataType.LReal:
                    length = end - start + 4;
                    break;
            }
            resultList.Add(start);
            resultList.Add(length);
            return resultList;

        }
        /// <summary>
        /// 获取List<int>集合里的最小值
        /// </summary>
        /// <param name="intList"></param>
        /// <returns></returns>
        private int GetMin(List<int> intList) {
            int min = int.MaxValue;
            foreach (var item in intList) {
                if (item < min) {
                    min = item;
                }
            }
            return min;
        }
        /// <summary>
        /// 获取List<int>集合里的最大值
        /// </summary>
        /// <param name="intList"></param>
        /// <returns></returns>
        private int GetMax(List<int> intList) {
            int max = int.MinValue;
            foreach (var item in intList) {
                if (item > max) {
                    max = item;
                }
            }
            return max;
        }
        #endregion

        //新增变量按钮
        private void btnNew_Click(object sender, EventArgs e) {
            FrmNewVariable objFrm = new FrmNewVariable();
            objFrm.ShowDialog();
            if (objFrm.DialogResult == DialogResult.OK) {
                variableList.Add(objFrm.variable);
                if (objFrm.varAlarm != null) {
                    varAlarmList.Add(objFrm.varAlarm);
                }
                UIMessageBox.Show("添加变量成功！");
                UpdateDGV();
            }
        }

        //修改变量按钮
        private void btnModify_Click(object sender, EventArgs e) {
            if (this.dgvVariable.SelectedRows.Count <= 0) {
                UIMessageBox.ShowWarning("未选中任何行！");
                return;
            }
            int index = this.dgvVariable.SelectedRows[0].Index;
            Variables objVar = variableList[index];
            VarAlarm objAlarm = null;
            if (objVar.IsFilling == "Y") {
                foreach (VarAlarm item in varAlarmList) {
                    if (item.VarName == objVar.VarName) {
                        objAlarm = item;
                        break;
                    }
                }
            }
            FrmModifyVariable objFrm = new FrmModifyVariable(objVar, objAlarm);
            DialogResult dr = objFrm.ShowDialog();
            if (dr == DialogResult.OK) {
                variableList[index] = objFrm.objVar;
                if (objFrm.objAlarm != null) {
                    //判断是新增还是修改，false则为新增，true为修改。
                    if (SelectVarAlarm(objFrm.objAlarm, varAlarmList)) {
                        for (int i = 0; i < this.varAlarmList.Count; i++) {
                            if (this.varAlarmList[i].VarName == objFrm.objAlarm.VarName) {
                                this.varAlarmList[i] = objFrm.objAlarm;
                                break;
                            }
                        }
                    }
                    else { this.varAlarmList.Add(objFrm.objAlarm); }
                }
            }
            UpdateDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (dgvVariable.SelectedRows.Count <= 0) {
                UIMessageBox.ShowWarning("未选中任何行！");
                return;
            }
            int index = this.dgvVariable.CurrentRow.Index;
            for (int i = 0; i < varAlarmList.Count; i++) {
                if (varAlarmList[i].VarName == variableList[index].VarName) {
                    this.varAlarmList.RemoveAt(i);
                    break;
                }
            }
            this.variableList.RemoveAt(index);
            UpdateDGV();
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            this.variableList = CommonMethod.ReadXmlToList<List<Variables>>(CommonData.variablePath);
            this.varAlarmList = CommonMethod.ReadXmlToList<List<VarAlarm>>(CommonData.varAlarmPath);
            UpdateDGV();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            try {
                //保存变量文件
                SaveListToXML(this.variableList, CommonData.variablePath);
                //保存报警变量
                SaveListToXML(this.varAlarmList, CommonData.varAlarmPath);
                //保存存储区域文件
                SaveListToXML(Calculate(), CommonData.storeAreaPath);
                UIMessageBox.Show("保存成功");
            }
            catch (Exception ex) {
                UIMessageBox.Show("保存失败" + ex.Message);
            }
        }

        private void FrmVariableConfig_Load(object sender, EventArgs e) {
            this.variableList = CommonMethod.ReadXmlToList<List<Variables>>(CommonData.variablePath);
            this.varAlarmList = CommonMethod.ReadXmlToList<List<VarAlarm>>(CommonData.varAlarmPath);
            UpdateDGV();
        }

        private void dgvVariable_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            btnModify_Click(null, null);
        }
    }
}
