using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoCtrl.InstCommonCtrl;
using AutoCtrl.InstCommandCtrl;
using AutoCtrl.CommonFunction;
using AutoCtrl.CommunicationProtocol;
using AutoCtrl.TBSiliconProject.DriverCommonTestItem;

namespace AutoCtrl.CommonForm {
    public partial class USB_PortForm : Form {
        public USB_PortForm() {
            InitializeComponent();
            usbDeviceInitial();
            usb.GetUSBInfo();
        }
        public USB_PortLib usb = new USB_PortLib();
        public CommonFunctionLib comFunLib = new CommonFunctionLib();
        public DriverChipCommonFunctionLib dChipComFunLib = new DriverChipCommonFunctionLib();
        public AnalogItem_TestLib AnaLib = new AnalogItem_TestLib();
        public DigitalItem_TestLib DigLib = new DigitalItem_TestLib();
        public InstCommandLib instCtrlLib = new InstCommandLib();
        public InstCommonCtrlLib instComCtrl = new InstCommonCtrlLib();
        public bool enable = true;

        #region 0. 初始化相参数
        /// <summary>
        /// 参数初始化：包括设备PID、VID、界面、窗口打印信息清除等
        /// </summary>
        /// <param name="isClear"></param>
        public void usbDeviceInitial(bool isClear = true) {
            usb.para_St.rtbReadData = dChipComFunLib.para_St.rtbUsbReadData = rtbUsbReadData;
            usb.para_St.rtbWriteData = dChipComFunLib.para_St.rtbUsbWriteData = rtbUsbWriteData;
            usb.para_St.rtbErrInfo = rtbUsbErrInfo;
            usb.para_St.rtbOptState = rtbUsbOptState;
            usb.para_St.rtbDataStreamMonitor = rtbUsbReadWriteDataStreamMonitor;
            usb.para_St.cmbUsbPortInfoList = cmbUsbDeviceInfoList;
            usb.para_St.cmbUsbPortPidList = cmbUsbDevicePidList;
            usb.para_St.cmbUsbPortVidList = cmbUsbDeviceVidList;
            usb.para_St.cmbDeviceType = cmbUsbDeviceType;
            usb.para_St.cmbOptType = cmbUsbOtpType;
            dChipComFunLib.para_St.cmbAtbNodeNane = cmbAtbNodeName;
            dChipComFunLib.para_St.cmbProjectName = cmbProjectName;
            dChipComFunLib.para_St.cbRedChip = cbDriverRedChipEn;
            dChipComFunLib.para_St.cbGreenChip = cbDriverGreenChipEn;
            dChipComFunLib.para_St.cbBlueChip = cbDriverBlueChipEn;
            dChipComFunLib.para_St.cbPowerSelEn = cbPowerSelEn;
            dChipComFunLib.para_St.cbMultiSelEn = cbMultiSelEn;
            dChipComFunLib.para_St.tbDriverRegAddr = tbDriverRegAddr;
            dChipComFunLib.para_St.tbregOptLength = tbRegOptLength;
            dChipComFunLib.para_St.tbDriverRegValue = tbDriverRegValue;
            dChipComFunLib.para_St.tbChipID = tbChipID;
            dChipComFunLib.para_St.tbTestMessage = tbTestMessage;
            dChipComFunLib.para_St.tbInstPowerAddr = tbInstPowerAddr;
            dChipComFunLib.para_St.tbInstMultiAddr = tbInstMultiAddr;
            dChipComFunLib.para_St.stop = false;
            usb.optDelayMs = (int)nudOptDelayMs.Value;
            usb.netPortNum = (byte)nudNetPortNum.Value;
            dChipComFunLib.para_St.nudLoopCnt = (int)nudLoopCnt.Value;
            dChipComFunLib.para_St.lbView = lbViewCnt;
            dChipComFunLib.para_St.chEn = new bool[] { cbCh1En.Checked, cbCh2En.Checked, cbCh3En.Checked, cbCh4En.Checked };
            int length = Convert.ToInt32(tbRegOptLength.Text.Trim(), 16);
            tbRegOptLength.Text = (length > 0xff) ? "FF" : length.ToString("X2");
            usb.optRegLength = Convert.ToByte(tbRegOptLength.Text.Trim(), 16);
            if (isClear) {
                rtbUsbReadData.Clear();
                cmbUsbDeviceInfoList.Items.Clear();
                cmbUsbDevicePidList.Items.Clear();
                cmbUsbDeviceVidList.Items.Clear();
            }
        }
        /// <summary>
        /// 界面初始化、读写寄存器数据包初始化
        /// </summary>
        public void usbWriteReadOptInit(USB_PortLib.OPT_TYPE otpType) {
            usbDeviceInitial(!enable);
            usb.DataPackageInit(tbRegAddr.Text.Trim(), rtbUsbWriteData.Text.Trim(), (USB_PortLib.DEVICE_TYPE)cmbUsbDeviceType.SelectedIndex, otpType);
        }
        #endregion

        #region 1. USB设备查询信息
        private void btnGetUsbPort_Click(object sender, EventArgs e) {
            usbDeviceInitial();
            usb.GetUSBInfo();
        }

        private void cmbUsbDeviceInfoList_SelectedIndexChanged(object sender, EventArgs e) {
            usbDeviceInitial(!enable);
            usb.SelectUsbInfoDevice();
        }

        private void cmbUsbDevicePidList_SelectedIndexChanged(object sender, EventArgs e) {
            usbDeviceInitial(!enable);
            usb.SelectUsbPidDevice();
        }

        private void cmbUsbDeviceVidList_SelectedIndexChanged(object sender, EventArgs e) {
            usbDeviceInitial(!enable);
            usb.SelectUsbVidDevice();
        }

        private void btnOpenDevice_Click(object sender, EventArgs e) {
            usbDeviceInitial(!enable);
            if (usb.usbDeviceOpen(enable)) {
                btnOpenDevice.Enabled = !enable;
                gbUsbLookUp.Enabled = !enable;
            }
            else {
                btnOpenDevice.Enabled = enable;
                gbUsbLookUp.Enabled = enable;
            }
        }

        private void btnCloseDevice_Click(object sender, EventArgs e) {
            usbDeviceInitial(!enable);
            usb.usbDeviceOpen(!enable);
            btnOpenDevice.Enabled = enable;
            gbUsbLookUp.Enabled = enable;
        }
        #endregion

        #region 2. Read/Write/Debug/Clear
        private void btnReadUsbDevice_Click(object sender, EventArgs e) {
            btnReadUsbDevice.Enabled = false;
            rtbUsbReadData.Clear();
            usbDeviceInitial(!enable);
            cmbUsbOtpType.SelectedIndex = 0;
            if (cbProjectNameEn.Checked && tbDriverRegAddr.Enabled) {
                tbRegAddr.Text = dChipComFunLib.DriverChipRegAddrGen(tbDriverRegAddr.Text.Trim());
                if (cbDriverRedChipEn.Checked && cbDriverGreenChipEn.Checked && cbDriverBlueChipEn.Checked) {
                    tbRegOptLength.Text = "06";
                    usbWriteReadOptInit(USB_PortLib.OPT_TYPE.READ);
                    usb.UsbReadReg();
                }
            }
            else {
                usbWriteReadOptInit(USB_PortLib.OPT_TYPE.READ);
                cmbUsbOtpType.SelectedIndex = 0;  //"读操作"
                usb.UsbReadReg();
            }
            btnReadUsbDevice.Enabled = true;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool checkWriteLength() {
            string[] data = rtbUsbWriteData.Text.Trim().Split(' ');
            byte length = Convert.ToByte(tbRegOptLength.Text.Trim(), 16);
            if (data.Length != length) {
                rtbUsbErrInfo.AppendText(comFunLib.GetCurrentDataTime() + ": 写操作---长度不匹配！！！\n");
                rtbUsbErrInfo.ScrollToCaret();
                return false;
            }
            else {
                return true;
            }
        }
        private void btnWriteUsbDevice_Click(object sender, EventArgs e) {
            btnWriteUsbDevice.Enabled = false;
            usbDeviceInitial(!enable);
            cmbUsbOtpType.SelectedIndex = 1;
            if (cbProjectNameEn.Checked && tbDriverRegAddr.Enabled) {
                tbRegAddr.Text = dChipComFunLib.DriverChipRegAddrGen(tbDriverRegAddr.Text.Trim());
                if (cbDriverRedChipEn.Checked || cbDriverGreenChipEn.Checked || cbDriverBlueChipEn.Checked) {
                    dChipComFunLib.RgbChipWriteReg(usb);
                }
            }
            else if (checkWriteLength()) {
                usbWriteReadOptInit(USB_PortLib.OPT_TYPE.WRITE);
                cmbUsbOtpType.SelectedIndex = 1;  //"写操作"
                usb.UsbWriteReg();
                comFunLib.DelayTimeMs((double)nudOptDelayMs.Value);
            }
            btnWriteUsbDevice.Enabled = true;
        }

        private void btnClearAllRtb_Click(object sender, EventArgs e) {
            rtbUsbReadData.Clear();
            rtbUsbOptState.Clear();
            rtbUsbErrInfo.Clear();
            rtbUsbReadWriteDataStreamMonitor.Clear();
        }

        private void btnDebug_Click(object sender, EventArgs e) {
            rtbUsbReadData.Clear();
            usbDeviceInitial(!enable);
            usb.DataPackageInit(tbRegAddr.Text.Trim(), rtbUsbWriteData.Text.Trim(), (USB_PortLib.DEVICE_TYPE)cmbUsbDeviceType.SelectedIndex, (USB_PortLib.OPT_TYPE)cmbUsbOtpType.SelectedIndex);
            if (cmbUsbOtpType.SelectedItem.ToString() == "读操作") {
                usb.UsbReadReg();
            }
            if (cmbUsbOtpType.SelectedItem.ToString() == "写操作") {
                usb.UsbWriteReg();
            }
            //string regAddr0 = tbRegAddr.Text;  //0200_0023
            //ulong reg = Convert.ToUInt64(tbRegAddr.Text, 16);
            //string[] reg1 = new string[4];
            //for (int i = 0; i < 4; i++) {
            //    byte temp = (byte)((reg & ((ulong)(0xff << (i * 8)))) >> (i * 8));
            //    reg1[i] = temp.ToString("X2");  //自动补齐为2位
            //}
            //for (int i = 0; i < 4; i++) {
            //    rtbUsbReadInfo.AppendText(reg1[3 - i]);
            //}
        }

        private void cbDebugEn_CheckedChanged(object sender, EventArgs e) {
            btnDebug.Enabled = cbDebugEn.Checked;
            cmbUsbDeviceType.Enabled = cbDebugEn.Checked;
            cmbUsbOtpType.Enabled = cbDebugEn.Checked;
            nudOptDelayMs.Enabled = cbDebugEn.Checked;
            nudNetPortNum.Enabled = cbDebugEn.Checked;
        }
        #endregion

        #region 3. Project 参数初始化
        public void GetAtbTable() {

            switch (cmbProjectName.Text) {
                case "P2218_V20X":
                    for (int i = 0; i < AnaLib.atbTable_2218_V20X.GetLength(0); i++) {
                        cmbAtbNodeName.Items.Add(AnaLib.atbTable_2218_V20X[i, 4]);
                    }
                    break;
                case "P2218R_V100":
                    for (int i = 0; i < AnaLib.atbTable_2218R_V100.GetLength(0); i++) {
                        cmbAtbNodeName.Items.Add(AnaLib.atbTable_2218R_V100[i, 4]);
                    }
                    break;
                case "P2318_V100":
                    for (int i = 0; i < AnaLib.atbTable_2318_V100.GetLength(0); i++) {
                        cmbAtbNodeName.Items.Add(AnaLib.atbTable_2318_V100[i, 4]);
                    }
                    break;
                case "P2318R_V100":
                    for (int i = 0; i < AnaLib.atbTable_2318R_V100.GetLength(0); i++) {
                        cmbAtbNodeName.Items.Add(AnaLib.atbTable_2318R_V100[i, 4]);
                    }
                    break;
                case "P2216R_V100":
                    break;
                case "P2316R_V100":
                    break;
                case "P3268_V300":
                    break;
                case "P3288_V100":
                    break;
                case "P1287_V10X":
                    break;
                default: break;
            }
        }
        #endregion


        private void btnStopEn_Click(object sender, EventArgs e) {
            dChipComFunLib.para_St.stop = true;
        }
        private void cmbProjectName_SelectedIndexChanged(object sender, EventArgs e) {
            cmbAtbNodeName.Items.Clear();
            cmbAtbNodeName.Text = null;
            GetAtbTable();
        }

        private void cbProjectNameEn_CheckedChanged(object sender, EventArgs e) {
            cmbProjectName.Enabled = !cbProjectNameEn.Checked;
            tbDriverRegAddr.Enabled = tbDriverRegValue.Enabled = cbDriverRedChipEn.Enabled = cbDriverGreenChipEn.Enabled = cbDriverBlueChipEn.Enabled = cbProjectNameEn.Checked;
        }

        private void cmbAtbNodeName_SelectedIndexChanged(object sender, EventArgs e) {
            cmbAtbNodeName.Enabled = !enable;
            cmbAtbNodeName.BackColor = Color.Gold;
            usbDeviceInitial(!enable);
            MultiSet();
            dChipComFunLib.para_St.addrOfst = 0;
            dChipComFunLib.para_St.tbregOptLength.Text = "06";
            AnaLib.AtbDebugTest(dChipComFunLib, usb);
            cmbAtbNodeName.BackColor = SystemColors.Control;
            cmbAtbNodeName.Enabled = enable;
        }

        private void btnMultiInit_Click(object sender, EventArgs e) {
            MultiSet();
        }
        private void MultiSet() {
            if (cbMultiSelEn.Checked) {
                instComCtrl.InstrumentLink(ref instComCtrl.mbsMulti, dChipComFunLib.para_St.tbInstMultiAddr.Text.Trim());
                instCtrlLib.SetMultiHighZ(instComCtrl.mbsMulti, InstCommandLib.STATE_EN.ON);
                instCtrlLib.SetMultiNPLC(instComCtrl.mbsMulti, InstCommandLib.READ_TYPE_EN.VOLT, 1);
                instCtrlLib.MultiLocalModeCtrl(instComCtrl.mbsMulti);

            }
        }
        private void btnAtbScan_Click(object sender, EventArgs e) {
            btnAtbScan.Enabled = !enable;
            btnAtbScan.BackColor = Color.Gold;
            usbDeviceInitial(!enable);
            tbTestMessage.Text = cmbProjectName.SelectedItem.ToString() + "_" + btnAtbScan.Text;
            MultiSet();
            AnaLib.AtbAutoSweep(dChipComFunLib, usb);
            btnAtbScan.BackColor = SystemColors.Control;
            btnAtbScan.Enabled = enable;
        }

        private void cbTestEn_CheckedChanged(object sender, EventArgs e) {
            btnAtbScan.Enabled = cbAtbTestEn.Checked;
            btnHysteresisRegulator.Enabled = cbHysTestEn.Checked;
            btnIfixRegulator.Enabled = cbIfixTestEn.Checked;
            btnLdoRegulator.Enabled = cbLdoTestEn.Checked;
            btnVbgRegulator.Enabled = cbVbgTestEn.Checked;
            btnVcoRegulator.Enabled = cbVcoTestEn.Checked;
            btnPreDriverVoltTest.Enabled = cbPreDrivEn.Checked;
            btnAteLoopTest.Enabled = cbAteLoopEn.Checked;
            tbInstMultiAddr.Enabled = cbMultiSelEn.Checked;
            tbInstPowerAddr.Enabled = cbPowerSelEn.Checked;
            cbCh1En.Enabled = cbCh2En.Enabled = cbCh3En.Enabled = cbCh4En.Enabled = cbPowerSelEn.Checked;
        }

        private void btnPreDriverVoltTest_Click(object sender, EventArgs e) {
            btnPreDriverVoltTest.Enabled = !enable;
            btnPreDriverVoltTest.BackColor = Color.Gold;
            usbDeviceInitial(!enable);
            tbTestMessage.Text = cmbProjectName.SelectedItem.ToString() + "_" + btnPreDriverVoltTest.Text;
            AnaLib.PreDriverAutoTest(dChipComFunLib, usb);
            btnPreDriverVoltTest.BackColor = SystemColors.Control;
            btnPreDriverVoltTest.Enabled = enable;
        }

        private void btnVbgRegulator_Click(object sender, EventArgs e) {
            btnVbgRegulator.Enabled = !enable;
            btnVbgRegulator.BackColor = Color.Gold;
            usbDeviceInitial(!enable);
            tbTestMessage.Text = cmbProjectName.SelectedItem.ToString() + "_" + btnVbgRegulator.Text;
            AnaLib.VbgAutoTrim(dChipComFunLib, usb);
            btnVbgRegulator.BackColor = SystemColors.Control;
            btnVbgRegulator.Enabled = enable;
        }

        private void btnAteLoopTest_Click(object sender, EventArgs e) {
            btnAteLoopTest.Enabled = !enable;
            btnAteLoopTest.BackColor = Color.Gold;
            usbDeviceInitial(!enable);
            tbTestMessage.Text = cmbProjectName.SelectedItem.ToString() + "_" + btnAteLoopTest.Text;
            AnaLib.AteLoopTest(dChipComFunLib, usb);
            btnAteLoopTest.BackColor = SystemColors.Control;
            btnAteLoopTest.Enabled = enable;
        }
    }
}
