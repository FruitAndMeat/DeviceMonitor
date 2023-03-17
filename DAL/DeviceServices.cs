using Models;
using NModbus;
using System;
using System.Net;
using System.Net.Sockets;

namespace DAL
{
    public class DeviceServices
    {
        public DeviceServices(Device device) {
            this.device = device;
            try {
                ConnectAsync();
            }
            catch (Exception ex) {

                throw ex;
            }

        }

        #region Field&Property

        private Device device;
        private byte slaveAddress = 1;
        private TcpClient tcpClient;
        private IModbusMaster master;

        #endregion

        #region 初始化连接

        private async void ConnectAsync() {
            this.slaveAddress = Convert.ToByte(device.DeviceID);
            tcpClient = new TcpClient();
            try {
                await tcpClient.ConnectAsync(IPAddress.Parse(this.device.DeviceIP), this.device.IPPort);
                master = new ModbusFactory().CreateMaster(tcpClient);
            }
            catch (Exception) {
                //throw ex;
            }

        }

        #endregion

        #region 读取写入方法封装
        /// <summary> 读取多个离散线圈</summary>
        /// <param name="startAddress">开始地址</param>
        /// <param name="length">读取长度</param>
        /// <returns>读取结果</returns>
        public bool[] ReadCoils(ushort startAddress, ushort length) {
            bool[] bools = null;
            try {
                if (master != null) {
                    bools = master.ReadCoils(slaveAddress, Convert.ToUInt16(startAddress - 1), length);
                }
                return bools;
            }
            catch (Exception ex) {
                LogHelper.WriteLog("执行读取离散输出线圈失败：" + ex.Message);
                throw ex;
            }
        }

        /// <summary>读取多个保持性寄存器</summary>
        /// <param name="startAddress">开始地址</param>
        /// <param name="length">读取长度</param>
        /// <returns>读取结果</returns>
        public ushort[] ReadHoldingRegisters(ushort startAddress, ushort length) {
            ushort[] ushorts = null;
            try {
                if (master != null) {
                    ushorts = master.ReadHoldingRegisters(slaveAddress, Convert.ToUInt16(startAddress - 1), length);
                }
                return ushorts;
            }
            catch (Exception ex) {
                LogHelper.WriteLog("执行读取保持性寄存器失败：" + ex.Message);
                throw ex;
            }
        }

        /// <summary>写入多个连续离散寄存器</summary>
        /// <param name="startAddress">开始地址</param>
        /// <param name="datas">寄存器值集合</param>
        /// <returns>写入结果，成功则为True,反之为false。</returns>
        public void WriteMultiCoils(ushort startAddress, bool[] datas) {
            try {
                master.WriteMultipleCoils(slaveAddress, Convert.ToUInt16(startAddress - 1), datas);
            }
            catch (Exception ex) {
                LogHelper.WriteLog("执行写入多个线圈失败：" + ex.Message);
                throw ex;
            }
        }
        /// <summary>写入多个连续的寄存器</summary>
        /// <param name="startAddress">开始地址</param>
        /// <param name="datas">数据数组</param>
        /// <returns>写入结果，成功则为True,反之为false。</returns>
        public void WriteMultipleRegisters(ushort startAddress, ushort[] datas) {
            try {
                master.WriteMultipleRegisters(slaveAddress, Convert.ToUInt16(startAddress - 1), datas);
            }
            catch (Exception ex) {
                LogHelper.WriteLog("执行写入多个寄存器失败：" + ex.Message);
                throw ex;
            }
        }

        /// <summary> 写入单个线圈</summary>
        /// <param name="coilAddress">线圈地址</param>
        /// <param name="value">线圈值</param>
        /// <returns>写入结果，成功则为True,反之为false。</returns>
        public void WriteSingleCoil(ushort coilAddress, bool value) {
            try {
                master.WriteSingleCoil(slaveAddress, Convert.ToUInt16(coilAddress - 1), value);
            }
            catch (Exception ex) {
                LogHelper.WriteLog("执行写入单个线圈失败：" + ex.Message);
                throw ex;
            }
        }

        /// <summary>写入单个寄存器</summary>
        /// <param name="registerAddress">寄存器地址</param>
        /// <param name="value">寄存器值</param>
        /// <returns>写入结果，成功则为True,反之为false。</returns>
        public void WriteSingleRegister(ushort registerAddress, ushort value) {
            try {
                master.WriteSingleRegister(slaveAddress, Convert.ToUInt16(registerAddress - 1), value);
            }
            catch (Exception ex) {
                LogHelper.WriteLog("执行写入单个寄存器失败：" + ex.Message);
                throw ex;
            }
        }


        #endregion
    }
}
