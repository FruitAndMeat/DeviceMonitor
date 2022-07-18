using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
using System.Threading;

namespace Air
{
    public class CommonThread
    {
        public Task t;
        int startAddress = 0;
        public List<Variables> List_0x = new List<Variables>();
        public List<Variables> List_1x = new List<Variables>();
        public List<Variables> List_3x = new List<Variables>();
        public List<Variables> List_4x = new List<Variables>();
        public CommonThread()
        {
            t = new Task(new Action(Communication));
        }

        void Communication()
        {
            while (true)
            {
                
                if (CommonData.IsWriteing == false)
                {
                    foreach (StoreArea item in CommonData.storeAreaList)
                    {
                        startAddress = item.startAddr;
                        switch (item.registerType)
                        {
                            case RegisterType.CoilStatus:
                                //读取
                                bool[] bools= CommonData.objMod.ReadCoils((ushort)startAddress, (ushort)(item.length));
                                //解析
                                AnalyseData_0x(bools);
                                break;
                            case RegisterType.InputStatus:
                                break;
                            case RegisterType.HoldingRegister:
                                ushort[] datas= CommonData.objMod.ReadHoldingRegisters((ushort)startAddress, (ushort)item.length);
                                //解析
                                if (datas.Length == item.length)
                                {
                                    AnalyseData_4x(datas);
                                }
                                break;
                            case RegisterType.InputRegister:
                                break;
                        }
                    }
                }

                if (CommonData.UpdateUI!=null)
                {
                    CommonData.UpdateUI.Invoke();
                }
                Thread.Sleep(300);
            }
        }

        void AnalyseData_0x(bool[] bools)
        {
            if (bools != null && bools.Length > 0)
            {
                for (int i = 0; i < List_0x.Count; i++)
                {
                    switch (List_0x[i].DataType)
                    {
                        case PLCDataType.Bool:
                            CommonData.CurrentValue[List_0x[i].VarName] = bools[i].ToString();
                            break;
                    }
                }
            }
        }

        void AnalyseData_4x(ushort[] datas)
        {
            List<byte> ByteList = new List<byte>();
            List<float> FloatList = new List<float>();
            if (datas!=null&&datas.Length>0)
            {
                for (int i = 0; i < datas.Length; i++)
                {
                    ByteList.AddRange(BitConverter.GetBytes(datas[i]));
                }
                byte[] s = ByteList.ToArray();
                for (int i = 0; i < ByteList.Count/4; i++)
                {
                    FloatList.Add(BitConverter.ToSingle(new byte[] { s[4*i+2],s[4*i+3],s[4*i],s[4*i+1]}, 0));
                }
                for (int i = 0; i < List_4x.Count; i++)
                {
                    switch (List_4x[i].DataType)
                    {
                        case PLCDataType.Byte:
                            break;
                        case PLCDataType.Word:
                            break;
                        case PLCDataType.DWord:
                            break;
                        case PLCDataType.Int:
                            break;
                        case PLCDataType.DInt:
                            break;
                        case PLCDataType.Uint:
                            break;
                        case PLCDataType.Real:
                            CommonData.CurrentValue[List_4x[i].VarName] = FloatList[i].ToString("f2");
                            break;
                        case PLCDataType.LReal:
                            break;
                        default:
                            break;
                    }
                }
            }
        }

    }
}
