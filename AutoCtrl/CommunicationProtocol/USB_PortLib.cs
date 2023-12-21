using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Management;
using System.IO.Ports;
using System.Threading;
using System.Timers;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibUsbDotNet;
using LibUsbDotNet.Main;
using AutoCtrl.CommonFunction;
using LibUsbDotNet.Info;
using LibUsbDotNet.Descriptors;
using LibUsbDotNet.LibUsb;
using LibUsbDotNet.WinUsb;
using LibUsbDotNet.DeviceNotify;

namespace AutoCtrl.CommunicationProtocol {
    public class USB_PortLib {
        #region 1. 结构体变量的定义、函数实例化
        public struct PARA_ST {
            public string errMessage;
            public RichTextBox rtbReadData;
            public RichTextBox rtbWriteData;
            public RichTextBox rtbErrInfo;
            public RichTextBox rtbOptState;
            public RichTextBox rtbDataStreamMonitor;
            public ComboBox cmbUsbPortInfoList;
            public ComboBox cmbUsbPortPidList;   //产品识别码(PID)
            public ComboBox cmbUsbPortVidList;   //供应商ID(VID)
            public ComboBox cmbDeviceType;       //区分发送卡、接收卡、多功能卡
            public ComboBox cmbOptType;          //写操作/读操作
        }

        public struct USB_DEVICE_INFO_ST {
            public string PNPDeviceID;      // 设备ID
            public string Name;             // 设备名称
            public string Description;      // 设备描述
            public string Service;          // 服务
            public string Status;           // 设备状态
            public int VID;                 // 供应商标识
            public int PID;                 // 产品编号 
            public Guid ClassGuid;          // 设备安装类GUID
        }

        public struct USB_OPERATION_ST {
            public List<byte> headPke;         //包头2*8bit：请求包(W) 55AA; 响应包(R)：AA55。
            public List<byte> ack;             //响应: 请求包无需理会。响应包：00~06(成功返回/失败超时/请求包校验错误/响应包校验错误/无效命令/节收卡回传数据长度与请求不一致/DVI加密，不支持程序更新)，08~FF(保留)。
            public List<byte> labels;          //流水号：一段时间内连续的包lable不能重复。
            public List<byte> sourceAddr;      //源地址：指发起数据包的计算机or发送卡的地址。
            public List<byte> destinationAddr; //目的地址: 指的是数据包要访问的计算机or发送卡的地址。计算机地址固定为：FE; 连接到串口的第1台设备为00,依次递增。
            public List<byte> deviceType;      //要访问的设备类型：具有串口属性的设备(eg:发送卡、电视卡)都为00,扫描卡为01,多功能卡为02。用以区别访问哪种设备的寄存器空间。
            public List<byte> portAddr;        //发送卡的网口地址： 发送卡使用哪个port口和接收卡互联。
            public List<byte> boardAddr;       //接收卡地址2*8bit。
            public List<byte> code;            //事务代码1*8bit：00~FF(读数据包/写数据包/保留...)。
            public List<byte> packetType;      //数据包的来源类型1*8bit：若为58表示数据包为硬件组合得到的请求包与响应包。其他值(eg:00)为LCT发起的请求包与响应包。
            public List<byte> regAddr;         //寄存器地址4*8bit：比如：02000023(发送卡更改视频源地址HDMI/SDI/DVI)。
            public List<byte> validLength;     //数据长度2*8bit：要操作的寄存器单元个数。
            public List<byte> data;            //负载数据1*8bit：如果是读请求包or写响应包,没有这一项。
            public List<byte> checkSum;        //校验和：除了包头之外的，所有数据按照字节累加, 再加上0x5555。
        }
        public enum USB_STATE_ENUM {
            USB_OPEN_SUCCESS,
            USB_OPEN_FAIL,
            USB_CLOSE_SUCCESS,
            USB_CLOSE_FAIL,
            USB_READ_FAIL,
            USB_READ_SUCCESS,
            USB_READ_TIME_OUT,
            USB_READ_NO_MORE_BYTES,
            USB_WRITE_FAIL,
            USB_WRITE_SUCCESS,
            USB_WRITE_TIME_OUT,
            USB_DEVICE_NOT_FOUND,
            USB_DEVICE_OUTLINE,
        }
        public enum DEVICE_TYPE {
            SEND_CARD = 00,
            RECEIVE_CARD,
            FUNCTION_CARD,
        }
        public enum OPT_TYPE {
            READ = 00,
            WRITE,
            RESERVE,
        }
        public enum OPT_TYPE_WR {
            READ = 0x14,
            WRITE,
        }
        //********************** 结构体、方法、类的实例化 *******************************//
        public PARA_ST para_St = new PARA_ST();
        public USB_DEVICE_INFO_ST usbInfo_St = new USB_DEVICE_INFO_ST();
        public USB_OPERATION_ST usbOpt_St = new USB_OPERATION_ST();
        public string[,] usbList = new string[,] { };
        public UsbRegDeviceList allDevices = UsbDevice.AllDevices;
        public CommonFunctionLib comFunLib = new CommonFunctionLib();
        public UsbDevice myUsbDevice;
        public UsbEndpointWriter writer = null;
        public UsbEndpointReader reader = null;
        System.Timers.Timer timer = new System.Timers.Timer(10);
        public DateTime LastDataEventDate = DateTime.Now;
        public Random random = new Random(unchecked((int)DateTime.Now.Ticks));
        //********************** 全局变量定义、初始化 *********************************//
        public List<byte> writePackage = new List<byte>();
        public string errComInfo = "显示USB操作---异常状态\n";
        public byte[] readBuffer;  //此长度目前还不确定，待核实一个比较兼容的长度
        public int bytesRead = 0;
        public byte[] commonData;
        public byte optRegLength;
        public byte netPortNum;
        public int optDelayMs;
        #endregion

        #region 2. USB操作封装函数
        /// <summary>
        /// 获取所有的USB设备实体（过滤没有VID和PID的设备）
        /// </summary>
        public void GetUSBInfo() {
            int cnt = 1;
            para_St.cmbUsbPortInfoList.Items.Clear();
            para_St.cmbUsbPortPidList.Items.Clear();
            para_St.cmbUsbPortVidList.Items.Clear();
            para_St.rtbDataStreamMonitor.Clear();
            foreach (UsbRegistry usb in allDevices) {
                if (usb.Open(out myUsbDevice)) {
                    if (usb.Device.Info.ProductString != null) {
                        para_St.cmbUsbPortInfoList.Items.Add(usb.Device.Info.ProductString);
                        para_St.cmbUsbPortPidList.Items.Add(usb.Pid);
                        para_St.cmbUsbPortVidList.Items.Add(usb.Vid);
                        //para_St.rtbDataStreamMonitor.AppendText(cnt + ": " + usb.Device.Info.ProductString + "," + usb.Pid + "," + usb.Vid + "," + usb.FullName + "," + usb.Device.Info.SerialString + "," + "\n");
                        cnt++;
                    }
                }
            }
        }
        /// <summary>
        /// 通过USB设备信息，选择USB设备，自动对应PID，VID
        /// </summary>
        public void SelectUsbInfoDevice() {
            for (int i = 0; i < para_St.cmbUsbPortInfoList.Items.Count; i++) {
                if (i == para_St.cmbUsbPortInfoList.SelectedIndex) {
                    para_St.cmbUsbPortPidList.SelectedIndex = i;
                    para_St.cmbUsbPortVidList.SelectedIndex = i;
                }
            }
        }
        public void SelectUsbPidDevice() {
            for (int i = 0; i < para_St.cmbUsbPortPidList.Items.Count; i++) {
                if (i == para_St.cmbUsbPortPidList.SelectedIndex) {
                    para_St.cmbUsbPortInfoList.SelectedIndex = i;
                    para_St.cmbUsbPortVidList.SelectedIndex = i;
                }
            }
        }
        public void SelectUsbVidDevice() {
            for (int i = 0; i < para_St.cmbUsbPortVidList.Items.Count; i++) {
                if (i == para_St.cmbUsbPortVidList.SelectedIndex) {
                    para_St.cmbUsbPortPidList.SelectedIndex = i;
                    para_St.cmbUsbPortInfoList.SelectedIndex = i;
                }
            }
        }
        /// <summary>
        /// USB设备Open和Close, 输入变量为Open_Enable, 变量赋值不同进行:关闭false/打开true操作
        /// </summary>
        /// <param name="isOpen"></param>
        public bool usbDeviceOpen(bool isOpen) {
            if (para_St.cmbUsbPortPidList.Text != "" && para_St.cmbUsbPortVidList.Text != "" && para_St.cmbUsbPortInfoList.Text != "") {
                //按照list所选进行参数传递
                usbInfo_St.PID = int.Parse(para_St.cmbUsbPortPidList.Text.Trim());
                usbInfo_St.VID = int.Parse(para_St.cmbUsbPortVidList.Text.Trim());
                UsbDeviceFinder myUsbFinder = new UsbDeviceFinder(usbInfo_St.VID, usbInfo_St.PID);
                //防止所选的USB，因某种原因掉线，再次打开会出现异常，所以进行二次查询比对,若不存在进行异常上报，并退出
                bool checkDevice = para_St.cmbUsbPortVidList.Text.Contains(usbInfo_St.VID.ToString()) && para_St.cmbUsbPortPidList.Text.Contains(usbInfo_St.PID.ToString()) && (myUsbDevice != null);
                if (checkDevice) {
                    if (isOpen) {
                        myUsbDevice = UsbDevice.OpenUsbDevice(myUsbFinder);
                        para_St.rtbOptState.AppendText(comFunLib.GetCurrentDataTime() + ":" + USB_STATE_ENUM.USB_OPEN_SUCCESS + "\n");
                        para_St.rtbOptState.ScrollToCaret();
                    }
                    else {
                        myUsbDevice.Close();
                        para_St.rtbOptState.AppendText(comFunLib.GetCurrentDataTime() + ":" + USB_STATE_ENUM.USB_CLOSE_SUCCESS + "\n");
                        para_St.rtbOptState.ScrollToCaret();
                    }
                    return true;
                }
                else {
                    para_St.rtbErrInfo.AppendText(comFunLib.GetCurrentDataTime() + ":" + USB_STATE_ENUM.USB_DEVICE_NOT_FOUND + "\n");
                    para_St.rtbErrInfo.ScrollToCaret();
                    return false;
                }
            }
            else {
                para_St.rtbErrInfo.AppendText(comFunLib.GetCurrentDataTime() + ":" + USB_STATE_ENUM.USB_DEVICE_NOT_FOUND + "\n");
                para_St.rtbErrInfo.ScrollToCaret();
                return false;
            }
        }

        /// <summary>
        /// 函数为USB执行Read、Write操作时的公共信息
        /// </summary>
        public bool UsbRWCommonInfo() {
            if (usbDeviceOpen(true) && myUsbDevice != null) {
                IUsbDevice wholeUsbDevice = myUsbDevice as IUsbDevice;
                if (!ReferenceEquals(wholeUsbDevice, null)) {
                    wholeUsbDevice.SetConfiguration(1);      // Select config #1
                    wholeUsbDevice.ClaimInterface(0);        // Claim interface #0.
                }
                reader = myUsbDevice.OpenEndpointReader(ReadEndpointID.Ep01);  //open read endpoint 1.
                writer = myUsbDevice.OpenEndpointWriter(WriteEndpointID.Ep01); //open write endpoint 1.
                return true;
            }
            else { return false; }
        }
        #endregion

        #region 3. 读/写寄存器---协议数据流生成
        public void writeReadFrontData(OPT_TYPE_WR otpType) {
            commonData = new byte[] {
            0x55,0x53,0x42,0x43,0x7b,0x07,0xc5,0x08,(byte)otpType,0,0,0,0,0,0x10,0xa2,0,0,0,0,0,0,0x01,0,0,0,0,0,0,0,0};
            UsbWriteCommon(commonData);
        }
        public void DataPackageInit(string regAddr, string data, DEVICE_TYPE deviceType = DEVICE_TYPE.RECEIVE_CARD, OPT_TYPE otpType = OPT_TYPE.WRITE) {
            writePackage.Clear();
            usbOpt_St.headPke = new List<byte> { 0x55, 0xAA };
            usbOpt_St.ack = new List<byte> { 0x00 };
            usbOpt_St.labels = new List<byte> { (byte)random.Next(0,255)};     //流水号,数据包的流水号, 一段时间内不能重复
            usbOpt_St.sourceAddr = new List<byte> { 0xFE };                    //计算机地址固定为FE
            usbOpt_St.destinationAddr = new List<byte> { 0x00 };               //发送卡地址固定为00
            usbOpt_St.deviceType = new List<byte> { };                         //发送卡为00, 接收卡为01, 多功能卡为02
            usbOpt_St.portAddr = new List<byte> { netPortNum };                //默认使用网口0进行互联
            usbOpt_St.boardAddr = new List<byte> { 0x00, 0x00 };               //默认不级联，使用单级board
            usbOpt_St.packetType = new List<byte> { 0x00 };                    //00表征LCT发起的请求包
            usbOpt_St.code = new List<byte> { };                               //00代表读操作，01代表写操作，其余为保留
            usbOpt_St.regAddr = new List<byte> { };                            //例：00 00 00 02([7:0],[15:8],[23:16],[31:24])
            usbOpt_St.validLength = new List<byte> { optRegLength, 0x00 };     //操作寄存器的长度例：01 00([7:0],[15:8]), 默认一次操作1个地址
            usbOpt_St.data = new List<byte> { };
            usbOpt_St.checkSum = new List<byte> { };
            RegAddrDataGenerator(regAddr, data, deviceType, otpType);          //发送卡的寄存器地址 usbOpt_St.regAddr[0~3] 分别代表寄存器 7:0,8~15,16~23,24~31 bit
            //拼接生成---写or读---寄存器数据流: 注意以下顺序不能更换,否则数据流格式就不满足协议要求
            writePackage.AddRange(usbOpt_St.headPke);
            writePackage.AddRange(usbOpt_St.ack);
            writePackage.AddRange(usbOpt_St.labels);
            writePackage.AddRange(usbOpt_St.sourceAddr);
            writePackage.AddRange(usbOpt_St.destinationAddr);
            writePackage.AddRange(usbOpt_St.deviceType);
            writePackage.AddRange(usbOpt_St.portAddr);
            writePackage.AddRange(usbOpt_St.boardAddr);
            writePackage.AddRange(usbOpt_St.code);
            writePackage.AddRange(usbOpt_St.packetType);
            writePackage.AddRange(usbOpt_St.regAddr);
            writePackage.AddRange(usbOpt_St.validLength);
            if (otpType == OPT_TYPE.WRITE) {                                   //需要注意此处如果为：read，则先执行对应的write操作
                writePackage.AddRange(usbOpt_St.data);
            }
            checkSum();
            writePackage.AddRange(usbOpt_St.checkSum);
        }
        /// <summary>
        /// 传递来自界面的 寄存器地址&配置值, 生成USB协议规格数据流
        /// </summary>
        /// <param name="regAddrr"></param>
        public void RegAddrDataGenerator(string regAddr, string data, DEVICE_TYPE deviceType = DEVICE_TYPE.RECEIVE_CARD, OPT_TYPE otpType = OPT_TYPE.WRITE) {
            //Step1: 生成-寄存器地址-数据流
            ulong reg = Convert.ToUInt64(regAddr, 16);
            for (int i = 0; i < 4; i++) {
                byte temp = (byte)((reg & ((ulong)(0xff << (i * 8)))) >> (i * 8));
                usbOpt_St.regAddr.Add(temp);
            }
            //Step2: 生成-寄存器配置值-数据流  (此处支持单一寄存器值&多地址序列值)
            if (otpType == OPT_TYPE.WRITE) {
                string[] dataArray = new string[optRegLength];
                byte[] value = new byte[optRegLength];
                dataArray = data.Split(' ');
                for (int i = 0; i < optRegLength; i++) {
                    value[i] = (byte)Convert.ToUInt64(dataArray[i], 16);
                }
                for (int i = 0; i < dataArray.Length; i++) {
                    usbOpt_St.data.Add(value[i]);
                }
            }
            //Step3: 生成-设备类型&操作类型-数据流
            usbOpt_St.deviceType.Add((byte)deviceType);
            usbOpt_St.code.Add((byte)otpType);
        }
        /// <summary>
        /// 校验和：除过包头 55AA, 之外的所有数据流相加之后，再加上0x5555
        /// </summary>
        public void checkSum() {
            ulong sum = 0;
            for (int i = 0; i < writePackage.Count; i++) {
                if (i > 1) {
                    sum += writePackage[i];
                }
            }
            sum += 0x5555;
            for (int i = 0; i < 2; i++) {
                byte temp = (byte)((sum & ((ulong)(0xff << (i * 8)))) >> (i * 8));
                usbOpt_St.checkSum.Add(temp);
            }
        }
        #endregion

        #region 4. 写寄存器---方法实现
        /// <summary>
        /// 写寄存器封装函数：将生成的写数据流打印在信息框中
        /// </summary>
        public void UsbWriteReg() {
            //writeReadFrontData(OPT_TYPE_WR.WRITE);

            //for (int i = 0; i < commonData.Length; i++) {
            //    string spaceInsert = (i != (commonData.Length - 1)) ? " " : "\n";
            //    para_St.rtbDataStreamMonitor.AppendText(commonData[i].ToString("X2") + spaceInsert);
            //    para_St.rtbDataStreamMonitor.ScrollToCaret();
            //}
            UsbWriteCommon(writePackage.ToArray());
            for (int i = 0; i < writePackage.Count; i++) {
                string spaceInsert = (i != (writePackage.Count - 1)) ? " " : "\n";
                para_St.rtbDataStreamMonitor.AppendText(writePackage[i].ToString("X2") + spaceInsert);
                para_St.rtbDataStreamMonitor.ScrollToCaret();
            }
        }

        //public void DriverChipWriteReg(string regAddr, string data) {
        //    optRegLength = Convert.ToByte(para_St.le, 16);
        //    usbDriver.UsbRWCommonInfo(); //初始化USB相关参数
        //    usbDriver.DataPackageInit(regAddr, data, deviceType, otpType);
        //    usbDriver.UsbWriteReg();
        //}

        /// <summary>
        /// USB设备进行写操作,输入变量为cmdLine1(字节变量)
        /// </summary>
        /// <param name="cmdLine"></param>
        /// <returns></returns>
        public bool UsbWriteCommon(byte[] cmdLine) {
            ErrorCode ec = ErrorCode.None;
            if (para_St.cmbUsbPortPidList.Text != "" && para_St.cmbUsbPortVidList.Text != "" && para_St.cmbUsbPortInfoList.Text != "") {
                if (UsbRWCommonInfo()) {
                    try {
                        int bytesWritten;
                        ec = writer.Write(cmdLine, optDelayMs, out bytesWritten);
                        switch (ec) {
                            case 0:  //None\OK\Success
                                para_St.rtbOptState.AppendText(comFunLib.GetCurrentDataTime() + ":" + USB_STATE_ENUM.USB_WRITE_SUCCESS + "\n");
                                para_St.rtbOptState.ScrollToCaret();
                                break;
                            default:
                                para_St.rtbErrInfo.AppendText(comFunLib.GetCurrentDataTime() + ":" + ec + "\n");    //全部写入error Message
                                para_St.rtbErrInfo.ScrollToCaret();
                                break;
                        }
                    }
                    catch (Exception ex) {
                        para_St.rtbErrInfo.AppendText((ec != ErrorCode.None ? ec + ":" : String.Empty) + ex.Message + "\n");    //全部写入error Message
                        para_St.rtbErrInfo.ScrollToCaret();
                    }
                    return true;
                }
                else {
                    para_St.rtbErrInfo.AppendText(comFunLib.GetCurrentDataTime() + ":" + ec + " " + USB_STATE_ENUM.USB_WRITE_FAIL + "\n");   //全部写入error Message
                    para_St.rtbErrInfo.ScrollToCaret();
                    return false;
                }
            }
            else {
                para_St.rtbErrInfo.AppendText(comFunLib.GetCurrentDataTime() + ":" + USB_STATE_ENUM.USB_DEVICE_NOT_FOUND + "\n");
                para_St.rtbErrInfo.ScrollToCaret();
                return false;
            }
        }
        #endregion

        #region 5. 读寄存器---方法实现
        /// <summary>
        /// 读寄存器操作封装实现
        /// </summary>
        /// <param name="delay"></param>
        public void UsbReadReg(int delay = 200) {
            UsbWriteReg();
            comFunLib.DelayTimeMs(delay);
            writeReadFrontData(OPT_TYPE_WR.READ);
            if (UsbReadOpt()) {
                UsbReadDataOpt(readBuffer, optRegLength);
            }
            for (int i = 0; i < bytesRead; i++) {
                string insert = (i == bytesRead - 1)? "\n" : " ";
                para_St.rtbDataStreamMonitor.AppendText(readBuffer[i].ToString("X2") + insert);
                para_St.rtbDataStreamMonitor.ScrollToCaret();
            }
        }
        /// <summary>
        /// 对读取的USB命令包进行对应reg地址，数值的提取
        /// </summary>
        public void UsbReadDataOpt(byte[] data, byte readLength = 01) {
            for (int i = 0; i < readLength; i++) {
                para_St.rtbReadData.AppendText(data[bytesRead - 2 - readLength + i].ToString("X2") + " "); //-1:最后一个地址值；-2：除去2个校验和的值；-readLength:从起始读取值开始
            }
        }
        /// <summary>
        /// 读寄存器操作具体实现
        /// </summary>
        /// <returns></returns>
        public bool UsbReadOpt() {
            ErrorCode ec = ErrorCode.None;
            byte readLength = (byte)(20 + optRegLength);   //读取的数据流：固定长度为20 + 读取的个数
            readBuffer = new byte[readLength];
            if (para_St.cmbUsbPortPidList.Text != "" && para_St.cmbUsbPortVidList.Text != "" && para_St.cmbUsbPortInfoList.Text != "") {
                // If the device hasn't sent data in the last 100 milliseconds, a timeout error (ec = IoTimedOut) will occur. 
                if (UsbRWCommonInfo()) {
                    try {
                        int cnt = 0;
                        do {
                            ec = reader.Read(readBuffer, optDelayMs, out bytesRead);
                            cnt++;
                        } while (bytesRead != readLength && cnt < 5);
                    }
                    catch (Exception ex) {
                        para_St.rtbErrInfo.AppendText((ec != ErrorCode.None ? ec + ":" : String.Empty) + ex.Message + "\n");    //全部写入error Message
                        para_St.rtbErrInfo.ScrollToCaret();
                    }
                }
                if (bytesRead == readLength) {
                    switch (ec) {
                        case 0:  //None\OK\Success
                            para_St.rtbOptState.AppendText(comFunLib.GetCurrentDataTime() + ":" + USB_STATE_ENUM.USB_READ_SUCCESS + "\n");
                            para_St.rtbOptState.ScrollToCaret();
                            break;
                        default:
                            para_St.rtbErrInfo.AppendText(comFunLib.GetCurrentDataTime() + ":" + ec + "\n");    //全部写入error Message
                            para_St.rtbErrInfo.ScrollToCaret();
                            break;
                    }
                    return true;
                }
                else {
                    para_St.rtbErrInfo.AppendText(comFunLib.GetCurrentDataTime() + ":" + USB_STATE_ENUM.USB_READ_NO_MORE_BYTES + "\n");   //全部写入error Message
                    para_St.rtbErrInfo.ScrollToCaret();
                    return false;
                }
            }
            else {
                para_St.rtbErrInfo.AppendText(comFunLib.GetCurrentDataTime() + ":" + USB_STATE_ENUM.USB_DEVICE_NOT_FOUND + "\n");
                para_St.rtbErrInfo.ScrollToCaret();
                return false;
            }
        }
        #endregion
    }
}

