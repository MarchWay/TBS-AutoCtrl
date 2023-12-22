using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoCtrl.CommonFunction;
using AutoCtrl.CommunicationProtocol;

namespace AutoCtrl.TBSiliconProject.DriverCommonTestItem {
    public class DriverChipCommonFunctionLib {
        public USB_PortLib usbDriver = new USB_PortLib();
        public CommonFunctionLib comFunLib = new CommonFunctionLib();
        public bool[] rgbArray;
        public List<string> dataList = new List<string>();
        public struct Para_St {
            public CheckBox cbRedChip;
            public CheckBox cbGreenChip;
            public CheckBox cbBlueChip;
            public CheckBox cbPowerSelEn;
            public CheckBox cbMultiSelEn;
            public TextBox tbregOptLength;
            public TextBox tbDriverRegAddr;
            public TextBox tbDriverRegValue;
            public TextBox tbChipID;
            public TextBox tbTestMessage;
            public TextBox tbInstPowerAddr;
            public TextBox tbInstMultiAddr;
            public RichTextBox rtbUsbWriteData;
            public RichTextBox rtbUsbReadData;
            public ComboBox cmbAtbNodeNane;
            public ComboBox cmbProjectName;
            public Label lbView;
            public string[,] atbScan;
            public string[,] VbgTrim;
            public string[,] preDrv;
            public UInt32 addrActual;
            public UInt32 addrOfst;
            public string addr;
            public int rgbCheck;
            public int nudLoopCnt;
            public double vbg;
            public bool stop;
            public bool[] chEn;
            public List<int> CH;
        }
        /// <summary>
        /// 不同的驱动芯片，寄存器位数：比如P2X18寄存器宽度为16bit(2 Byte);P3268的寄存器宽度为48bit(6 Byte)
        /// </summary>
        public enum DRIVER_REG_BYTE_LENGTH : int {
            LIST_DRIVER = 2,
            ROW_LIST_DRIVER = 6,
        }
        public Para_St para_St = new Para_St();
        public USB_PortLib.DEVICE_TYPE deviceType = USB_PortLib.DEVICE_TYPE.RECEIVE_CARD;
        public USB_PortLib.OPT_TYPE otpType = USB_PortLib.OPT_TYPE.WRITE;

        /// <summary>
        /// 针对 直显驱动芯片，使用LCT扩展属性进行寄存器写入时，需要将REG地址进行映射转化
        /// </summary>
        /// <param name="addr"></param>
        /// <returns></returns>
        public string DriverChipRegAddrGen(string addr) {
            para_St.addrActual = 0x1B000000 + Convert.ToUInt32(addr, 16) * 0x8 + para_St.addrOfst;  //0x1B000000 + REG*8 , 若只操作单色：0x1B000000 + REG*8 + (0，2，4)
            para_St.addr = para_St.addrActual.ToString("X8");
            return para_St.addr;
        }

        /// <summary>
        /// 驱动芯片R/G/B配置寄存器               
        /// </summary>
        /// <param name="usbLib"></param>
        public void RgbChipWriteReg(USB_PortLib usbLib) {     //TO do 需要考虑3268等寄存器位宽的兼容性16、48bit   
            rgbArray = new bool[] { para_St.cbBlueChip.Checked, para_St.cbGreenChip.Checked, para_St.cbRedChip.Checked };
            para_St.rgbCheck = 0x0;
            for (int i = 0; i < rgbArray.Length; i++) {
                if (rgbArray[i]) {
                    para_St.rgbCheck |=(0x1 << (rgbArray.Length - 1 - i));
                }
            }
            switch (para_St.rgbCheck) {
                case 1:   //R
                case 2:   //G
                case 4:   //B
                    para_St.tbregOptLength.Text = "02";
                    para_St.rtbUsbWriteData.Text = DriverDataGen(2, para_St.tbDriverRegValue.Text);  //生成反转后的data
                    if (para_St.rgbCheck == 1) para_St.addrOfst = 0;
                    if (para_St.rgbCheck == 2) para_St.addrOfst = 2;
                    if (para_St.rgbCheck == 4) para_St.addrOfst = 4;
                    DriverChipWriteReg(usbLib, DriverChipRegAddrGen(para_St.tbDriverRegAddr.Text), para_St.rtbUsbWriteData.Text);
                    break;
                case 3:
                case 5:
                case 6:
                    para_St.tbregOptLength.Text = "02";
                    para_St.rtbUsbWriteData.Text = DriverDataGen(2, para_St.tbDriverRegValue.Text);  //生成反转后的data
                    if (para_St.rgbCheck == 3) {
                        para_St.addrOfst = 0;  //配置R芯片
                        DriverChipWriteReg(usbLib, DriverChipRegAddrGen(para_St.tbDriverRegAddr.Text), para_St.rtbUsbWriteData.Text);
                        comFunLib.DelayTimeMs(1000);
                        para_St.addrOfst = 2;  //配置G芯片
                        DriverChipWriteReg(usbLib, DriverChipRegAddrGen(para_St.tbDriverRegAddr.Text), para_St.rtbUsbWriteData.Text);
                    }
                    if (para_St.rgbCheck == 5) {
                        para_St.addrOfst = 0; //配置R芯片
                        DriverChipWriteReg(usbLib, DriverChipRegAddrGen(para_St.tbDriverRegAddr.Text), para_St.rtbUsbWriteData.Text);
                        comFunLib.DelayTimeMs(1000);
                        para_St.addrOfst = 4; //配置B芯片
                        DriverChipWriteReg(usbLib, DriverChipRegAddrGen(para_St.tbDriverRegAddr.Text), para_St.rtbUsbWriteData.Text);
                    }
                    if (para_St.rgbCheck == 6) {
                        para_St.addrOfst = 2; //配置G芯片
                        DriverChipWriteReg(usbLib, DriverChipRegAddrGen(para_St.tbDriverRegAddr.Text), para_St.rtbUsbWriteData.Text);
                        comFunLib.DelayTimeMs(1000);
                        para_St.addrOfst = 4; //配置B芯片
                        DriverChipWriteReg(usbLib, DriverChipRegAddrGen(para_St.tbDriverRegAddr.Text), para_St.rtbUsbWriteData.Text);
                    }
                    break;
                case 7:
                    para_St.tbregOptLength.Text = "06";
                    para_St.addrOfst = 0;
                    string data = DriverDataGen(2, para_St.tbDriverRegValue.Text);
                    para_St.rtbUsbWriteData.Text = data + " " + data + " " + data;
                    DriverChipWriteReg(usbLib, DriverChipRegAddrGen(para_St.tbDriverRegAddr.Text), para_St.rtbUsbWriteData.Text);
                    break;
                default: break;
            }
        }

        /// <summary>
        /// 驱动芯片 单色配置REG
        /// </summary>
        /// <param name="usbLib"></param>
        /// <param name="regAddr"></param>
        /// <param name="data"></param>
        public void DriverChipWriteReg(USB_PortLib usbLib, string regAddr, string data) {
            usbLib.optRegLength = Convert.ToByte(para_St.tbregOptLength.Text.Trim(), 16);
            usbLib.UsbRWCommonInfo(); //初始化USB相关参数
            usbLib.DataPackageInit(regAddr, data, deviceType, otpType);
            usbLib.UsbWriteReg();
        }
        /// <summary>
        /// 根据R/G/B的配置需求，生成匹配操作长度的数据流：定义的变量类型，需要根据实际REG bit width去，目前已经定义为64bit宽度。
        /// </summary>
        /// <param name="length"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public string DriverDataGen(int length, string data) {
            para_St.rtbUsbWriteData.Clear();
            string dataStream = "";
            UInt64 reg = Convert.ToUInt64(data.Trim(), 16);
            for (int i = 0; i < length; i++) {
                byte temp = (byte)((reg & (((UInt64)0xff << (i * 8)))) >> (i * 8));
                dataStream += temp.ToString("X2") + ((i == length - 1) ? "" : " ");
            }
            return dataStream;
        }

        public void CreatFileWriteTitle(string[] title) {

        }
    }
}
