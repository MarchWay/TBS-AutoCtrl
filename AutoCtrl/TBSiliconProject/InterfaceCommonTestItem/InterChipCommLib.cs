using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AutoCtrl.CommonFunction;
using AutoCtrl.CommunicationProtocol;

namespace AutoCtrl.TBSiliconProject.InterFaceCommonTestItem
{
    public class InterChipCommLib
    {
        public USB_PortLib usbDriver = new USB_PortLib();
        public CommonFunctionLib comFunLib = new CommonFunctionLib();
        public bool[] rgbArray;
        public List<string> dataList = new List<string>();
        public struct Para_St
        {
            public CheckBox cbRedChip;
            public CheckBox cbGreenChip;
            public CheckBox cbBlueChip;
            public CheckBox cbPowerSelEn;
            public CheckBox cbMultiSelEn;
            public CheckBox cbMultiSelEn1;
            public CheckBox cbEnPwrCH1;
            public CheckBox cbEnPwrCH2;
            public CheckBox cbEnPwrCH3;
            public CheckBox cbEnPwrCH4;
            public CheckBox cbPwrType;
            public TextBox tbregOptLength;
            public TextBox tbDriverRegAddr;
            public TextBox tbDriverRegValue;
            public TextBox tbChipID;
            public TextBox tbTestMessage;
            public TextBox tbInstPowerAddr;
            public TextBox tbInstMultiAddr;
            public TextBox tbInstMultiAddr1;
            public RichTextBox rtbUsbWriteData;
            public RichTextBox rtbUsbReadData;
            public ComboBox cmbAtbNodeName;
            public ComboBox cmbProjectName;
            public ComboBox cbProjectItems;
            public ComboBox cmbChipCorner;
            public CheckBox cbEnChip0;
            public CheckBox cbEnChip1;
            public string[,] atbScan;
            public string[,] VbgTrim;
            public string[,] GccIfix;
            public string[,] preDrv;
            public string[,] DrvPAM;
            public string[,] GccGain;
            public string[,] Regulator;
            public UInt32 addrActual;
            public UInt32 addrOfst;
            public string addr;
            public int rgbCheck;
            public double vbg;
            public bool stop;
        }
        /// <summary>
        /// 不同的驱动芯片，寄存器位数：比如P2X18寄存器宽度为16bit(2 Byte);P3268的寄存器宽度为48bit(6 Byte)
        /// </summary>
        public enum DRIVER_REG_BYTE_LENGTH : int
        {
            LIST_DRIVER = 2,
            ROW_LIST_DRIVER = 6,
        }
        public Para_St para_St = new Para_St();
        public USB_PortLib.DEVICE_TYPE deviceType = USB_PortLib.DEVICE_TYPE.RECEIVE_CARD;
        public USB_PortLib.OPT_TYPE otpType = USB_PortLib.OPT_TYPE.WRITE;


        uint[] initialAddr = { 0x02000220, 0x02000250 };
        public string InterChipRegAddrGen(int Base)
        {
            para_St.addrActual = initialAddr[Base] + para_St.addrOfst;   //initialAddr[Base] + Convert.ToUInt32(addr, 16) * 0x8 + para_St.addrOfst;
            para_St.addr = para_St.addrActual.ToString("X8");
            return para_St.addr;
        }

        public void interChipWriteReg(USB_PortLib usbLib, string regAddr, string data)
        {
            usbLib.optRegLength = Convert.ToByte(para_St.tbregOptLength.Text.Trim(), 16);
            usbLib.UsbRWCommonInfo(); //初始化USB相关参数
            usbLib.DataPackageInit(regAddr, data, deviceType, otpType);
            usbLib.UsbWriteReg();
        }
        public string InterDataGen(int length, string data)
        {
            para_St.rtbUsbWriteData.Clear();
            string dataStream = "";
            UInt64 reg = Convert.ToUInt64(data.Trim(), 16);
            for (int i = 0; i < length; i++)
            {
                byte temp = (byte)((reg & (((UInt64)0xff << (i * 8)))) >> (i * 8));
                dataStream += temp.ToString("X2") + ((i == length - 1) ? "" : " ");
            }
            return dataStream;
        }
        public void WriteReg(USB_PortLib usbLib, int Base, string regAddr, string regValue)
        {
            string dataStream = InterDataGen(4, "A6" + regValue + regAddr);
            interChipWriteReg(usbLib, InterChipRegAddrGen(Base), dataStream);
        }
    }
}
