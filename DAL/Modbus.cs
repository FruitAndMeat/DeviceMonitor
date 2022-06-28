using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NModbus;
using Models;
using System.Net.Sockets;
using System.Net;

namespace DAL
{
    public class Modbus
    {
        public Modbus(Device device)
        {
            this.device = device;
            this.slaveAddress = Convert.ToByte(device.DeviceID);
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse(this.device.DeviceIP), this.device.IPPort);
            tcpClient = new TcpClient();
            tcpClient.Connect(ip);
            //socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //socket.Connect(IPAddress.Parse(this.device.DeviceIP), this.device.IPPort);
            master = new ModbusFactory().CreateMaster(tcpClient);
        }
        private Device device;
        byte slaveAddress = 1;
        private Socket socket;
        private TcpClient tcpClient;
        public IModbusMaster master;



        #region 读取写入方法封装
        /// <summary> 读取多个离散线圈</summary>
        /// <param name="startAddress">开始地址</param>
        /// <param name="length">读取长度</param>
        /// <returns>读取结果</returns>
        public bool[] ReadCoils(ushort startAddress,ushort length)
        {
            try
            {
                if (master != null)
                {   var s=master.ReadCoils(slaveAddress, Convert.ToUInt16(startAddress -1), length);
                    return s;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("执行读取离散输出线圈失败：" + ex.Message);
                throw ex;
            }
        }

        /// <summary>读取多个保持性寄存器</summary>
        /// <param name="startAddress">开始地址</param>
        /// <param name="length">读取长度</param>
        /// <returns>读取结果</returns>
        public ushort[] ReadHoldingRegisters(ushort startAddress, ushort length)
        {
            try
            {
                if (master != null)
                {
                    var s= master.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(startAddress -1), length);
                    return s;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("执行读取保持性寄存器失败：" + ex.Message);
                throw ex;
            }
        }

        /// <summary>写入多个连续离散寄存器</summary>
        /// <param name="startAddress">开始地址</param>
        /// <param name="datas">寄存器值集合</param>
        /// <returns>写入结果，成功则为True,反之为false。</returns>
        public bool WriteMultiCoils(ushort startAddress, bool[] datas)
        {
            try
            {
                
                if (master != null)
                {
                    master.WriteMultipleCoils(slaveAddress, Convert.ToUInt16(startAddress -1), datas);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("执行写入多个线圈失败：" + ex.Message);
                throw ex;
            }
        }
        /// <summary>写入多个连续的寄存器</summary>
        /// <param name="startAddress">开始地址</param>
        /// <param name="datas">数据数组</param>
        /// <returns>写入结果，成功则为True,反之为false。</returns>
        public bool WriteMultipleRegisters(ushort startAddress, ushort[] datas)
        {
            try
            {
                if (master != null)
                {
                    master.WriteMultipleRegisters(slaveAddress, Convert.ToUInt16(startAddress -1), datas);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("执行写入多个寄存器失败：" + ex.Message);
                throw ex;
            }
        }

        /// <summary> 写入单个线圈</summary>
        /// <param name="coilAddress">线圈地址</param>
        /// <param name="value">线圈值</param>
        /// <returns>写入结果，成功则为True,反之为false。</returns>
        public bool WriteSingleCoil(ushort coilAddress,bool value)
        {
            try
            {
                if (master != null)
                {
                    master.WriteSingleCoil(slaveAddress, Convert.ToUInt16(coilAddress -1), value);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("执行写入单个线圈失败：" + ex.Message);
                throw ex;
            }
        }

        /// <summary>写入单个寄存器</summary>
        /// <param name="registerAddress">寄存器地址</param>
        /// <param name="value">寄存器值</param>
        /// <returns>写入结果，成功则为True,反之为false。</returns>
        public bool WriteSingleRegister(ushort registerAddress, ushort value)
        {
            try
            {
                if (master != null)
                {
                    master.WriteSingleRegister(slaveAddress, Convert.ToUInt16(registerAddress-1), value);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("执行写入单个寄存器失败：" + ex.Message);
                throw ex;
            }
        }


        #endregion
    }
}
