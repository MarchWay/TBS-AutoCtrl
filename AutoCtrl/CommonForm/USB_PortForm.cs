using System;
using System.Drawing;
using System.Windows.Forms;
using AutoCtrl.CommonFunction;
using AutoCtrl.CommunicationProtocol;
using AutoCtrl.TBSiliconProject.DriverCommonTestItem;
using AutoCtrl.TBSiliconProject.InterFaceCommonTestItem;

namespace AutoCtrl.CommonForm
{
    public partial class USB_PortForm : Form
    {
        public USB_PortForm()
        {
            InitializeComponent();
            usbDeviceInitial();
            usb.GetUSBInfo();
            GetAtbTable();
            GetAtbNodeTable();
        }
        public USB_PortLib usb = new USB_PortLib();
        public CommonFunctionLib comFunLib = new CommonFunctionLib();
        public DriverChipCommonFunctionLib dChipComFunLib = new DriverChipCommonFunctionLib();
        public InterChipCommLib inChipComFunLib = new InterChipCommLib();
        public TestItems_TestLib testItems = new TestItems_TestLib();
        public InterChip_TestLib inChipTestItems = new InterChip_TestLib();
        public bool enable = true;
        public bool Enflag = true;

        #region 0. 初始化相参数
        /// <summary>
        /// 参数初始化：包括设备PID、VID、界面、窗口打印信息清除等
        /// </summary>
        /// <param name="isClear"></param>
        public void usbDeviceInitial(bool isClear = true)
        {
            usb.para_St.rtbReadData = dChipComFunLib.para_St.rtbUsbReadData = inChipComFunLib.para_St.rtbUsbReadData = rtbUsbReadData;
            usb.para_St.rtbWriteData = dChipComFunLib.para_St.rtbUsbWriteData = inChipComFunLib.para_St.rtbUsbWriteData = rtbUsbWriteData;
            usb.para_St.rtbErrInfo = rtbUsbErrInfo;
            usb.para_St.rtbOptState = rtbUsbOptState;
            usb.para_St.rtbDataStreamMonitor = rtbUsbReadWriteDataStreamMonitor;
            usb.para_St.cmbUsbPortInfoList = cmbUsbDeviceInfoList;
            usb.para_St.cmbUsbPortPidList = cmbUsbDevicePidList;
            usb.para_St.cmbUsbPortVidList = cmbUsbDeviceVidList;
            usb.para_St.cmbDeviceType = cmbUsbDeviceType;
            usb.para_St.cmbOptType = cmbUsbOtpType;
            dChipComFunLib.para_St.cmbAtbNodeName = cmbAtbNodeName;
            inChipComFunLib.para_St.cmbAtbNodeName = cmbInterChipAtbName;
            dChipComFunLib.para_St.cbProjectItems = cbProjectItems;
            inChipComFunLib.para_St.cbProjectItems = cbInterChipProjectItems;
            dChipComFunLib.para_St.cbRedChip = cbDriverRedChipEn;
            dChipComFunLib.para_St.cbGreenChip = cbDriverGreenChipEn;
            dChipComFunLib.para_St.cbBlueChip = cbDriverBlueChipEn;
            dChipComFunLib.para_St.cbPowerSelEn = inChipComFunLib.para_St.cbPowerSelEn = cbPowerSelEn;
            dChipComFunLib.para_St.cbMultiSelEn = inChipComFunLib.para_St.cbMultiSelEn = cbMultiSelEn;
            dChipComFunLib.para_St.cbMultiSelEn1 = inChipComFunLib.para_St.cbMultiSelEn1 = cbMultiSelEn1;
            dChipComFunLib.para_St.tbDriverRegAddr = tbDriverRegAddr;
            dChipComFunLib.para_St.tbregOptLength = inChipComFunLib.para_St.tbregOptLength = tbRegOptLength;
            dChipComFunLib.para_St.tbDriverRegValue = tbDriverRegValue;
            testItems.vbgTarget = double.Parse(tbVbgSet.Text.Trim());
            inChipTestItems.vbgTarget = double.Parse(tbInterChipVbgValue.Text.Trim());
            dChipComFunLib.para_St.tbregOptLength = inChipComFunLib.para_St.tbregOptLength = tbRegOptLength;
            dChipComFunLib.para_St.tbChipID = inChipComFunLib.para_St.tbChipID = tbChipID;
            dChipComFunLib.para_St.cmbChipCorner = inChipComFunLib.para_St.cmbChipCorner = cmbChipCorner;
            dChipComFunLib.para_St.tbTestMessage = inChipComFunLib.para_St.tbTestMessage = tbTestMessage;
            dChipComFunLib.para_St.tbInstPowerAddr = inChipComFunLib.para_St.tbInstPowerAddr = tbInstPowerAddr;
            dChipComFunLib.para_St.tbInstMultiAddr = inChipComFunLib.para_St.tbInstMultiAddr = tbInstMultiAddr;
            dChipComFunLib.para_St.tbInstMultiAddr1 = inChipComFunLib.para_St.tbInstMultiAddr1 = tbInstMultiAddr1;
            dChipComFunLib.para_St.cbEnPwrCH1 = inChipComFunLib.para_St.cbEnPwrCH1 = cbEnPwrCH1;
            dChipComFunLib.para_St.cbEnPwrCH2 = inChipComFunLib.para_St.cbEnPwrCH2 = cbEnPwrCH2;
            dChipComFunLib.para_St.cbEnPwrCH3 = inChipComFunLib.para_St.cbEnPwrCH3 = cbEnPwrCH3;
            dChipComFunLib.para_St.cbEnPwrCH4 = inChipComFunLib.para_St.cbEnPwrCH4 = cbEnPwrCH4;
            dChipComFunLib.para_St.cbPwrType = inChipComFunLib.para_St.cbPwrType = cbPwrType;
            dChipComFunLib.para_St.cmbTempCaseSel = inChipComFunLib.para_St.cmbTempCaseSel = cmbTempCaseSel;
            dChipComFunLib.para_St.cmbVoltCaseSel = inChipComFunLib.para_St.cmbVoltCaseSel = cmbVoltCaseSel;
            dChipComFunLib.para_St.stop = false;
            usb.optDelayMs = (int)nudOptDelayMs.Value;
            usb.netPortNum = (byte)nudNetPortNum.Value;
            int length = Convert.ToInt32(tbRegOptLength.Text.Trim(), 16);
            tbRegOptLength.Text = (length > 0xff) ? "FF" : length.ToString("X2");
            usb.optRegLength = Convert.ToByte(tbRegOptLength.Text.Trim(), 16);
            if (isClear)
            {
                rtbUsbReadData.Clear();
                cmbUsbDeviceInfoList.Items.Clear();
                cmbUsbDevicePidList.Items.Clear();
                cmbUsbDeviceVidList.Items.Clear();

            }
        }
        /// <summary>
        /// 界面初始化、读写寄存器数据包初始化
        /// </summary>
        public void usbWriteReadOptInit(USB_PortLib.OPT_TYPE otpType)
        {
            usbDeviceInitial(!enable);
            usb.DataPackageInit(tbRegAddr.Text.Trim(), rtbUsbWriteData.Text.Trim(), (USB_PortLib.DEVICE_TYPE)cmbUsbDeviceType.SelectedIndex, otpType);
        }
        #endregion

        #region 1. USB设备查询信息
        private void btnGetUsbPort_Click(object sender, EventArgs e)
        {
            usbDeviceInitial();
            usb.GetUSBInfo();
        }
        private void cmbUsbDeviceInfoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            usbDeviceInitial(!enable);
            usb.SelectUsbInfoDevice();
        }
        private void cmbUsbDevicePidList_SelectedIndexChanged(object sender, EventArgs e)
        {
            usbDeviceInitial(!enable);
            usb.SelectUsbPidDevice();
        }
        private void cmbUsbDeviceVidList_SelectedIndexChanged(object sender, EventArgs e)
        {
            usbDeviceInitial(!enable);
            usb.SelectUsbVidDevice();
        }
        private void btnOpenDevice_Click(object sender, EventArgs e)
        {
            usbDeviceInitial(!enable);
            if (usb.usbDeviceOpen(enable))
            {
                btnOpenDevice.Enabled = !enable;
                gbUsbLookUp.Enabled = !enable;
            }
            else
            {
                btnOpenDevice.Enabled = enable;
                gbUsbLookUp.Enabled = enable;
            }
        }
        private void btnCloseDevice_Click(object sender, EventArgs e)
        {
            usbDeviceInitial(!enable);
            usb.usbDeviceOpen(!enable);
            btnOpenDevice.Enabled = enable;
            gbUsbLookUp.Enabled = enable;
        }
        #endregion

        #region 2. Read/Write/Debug/Clear
        private void btnReadUsbDevice_Click(object sender, EventArgs e)
        {
            btnReadUsbDevice.Enabled = false;
            rtbUsbReadData.Clear();
            usbDeviceInitial(!enable);
            if (tbDriverRegAddr.Enabled)
            {
                tbRegAddr.Text = dChipComFunLib.DriverChipRegAddrGen(tbDriverRegAddr.Text.Trim());
                if (cbDriverRedChipEn.Checked && cbDriverGreenChipEn.Checked && cbDriverBlueChipEn.Checked)
                {
                    tbRegOptLength.Text = "06";
                    usbWriteReadOptInit(USB_PortLib.OPT_TYPE.READ);
                    usb.UsbReadReg();
                }
            }
            else
            {
                usbWriteReadOptInit(USB_PortLib.OPT_TYPE.READ);
                cmbUsbOtpType.SelectedIndex = 0;  //"读操作"
                usb.UsbReadReg();
            }
            btnReadUsbDevice.Enabled = true;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool checkWriteLength()
        {
            string[] data = rtbUsbWriteData.Text.Trim().Split(' ');
            byte length = Convert.ToByte(tbRegOptLength.Text.Trim(), 16);
            if (data.Length != length)
            {
                rtbUsbErrInfo.AppendText(comFunLib.GetCurrentDataTime() + ": 写操作---长度不匹配！！！\n");
                rtbUsbErrInfo.ScrollToCaret();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnWriteUsbDevice_Click(object sender, EventArgs e)
        {
            btnWriteUsbDevice.Enabled = false;
            usbDeviceInitial(!enable);
            if (tbDriverRegAddr.Enabled)
            {
                tbRegAddr.Text = dChipComFunLib.DriverChipRegAddrGen(tbDriverRegAddr.Text.Trim());
                if (cbDriverRedChipEn.Checked || cbDriverGreenChipEn.Checked || cbDriverBlueChipEn.Checked)
                {
                    dChipComFunLib.RgbChipWriteReg(usb);
                }
            }
            else if (checkWriteLength())
            {
                usbWriteReadOptInit(USB_PortLib.OPT_TYPE.WRITE);
                cmbUsbOtpType.SelectedIndex = 1;  //"写操作"
                usb.UsbWriteReg();
                comFunLib.DelayTimeMs((double)nudOptDelayMs.Value);
            }
            btnWriteUsbDevice.Enabled = true;
        }

        private void btnClearAllRtb_Click(object sender, EventArgs e)
        {
            rtbUsbReadData.Clear();
            rtbUsbOptState.Clear();
            rtbUsbErrInfo.Clear();
            rtbUsbReadWriteDataStreamMonitor.Clear();
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            usbDeviceInitial(!enable);
            usb.DataPackageInit(tbRegAddr.Text.Trim(), rtbUsbWriteData.Text.Trim(), (USB_PortLib.DEVICE_TYPE)cmbUsbDeviceType.SelectedIndex, (USB_PortLib.OPT_TYPE)cmbUsbOtpType.SelectedIndex);
            if (cmbUsbOtpType.SelectedItem.ToString() == "读操作")
            {
                usb.UsbReadReg();
            }
            if (cmbUsbOtpType.SelectedItem.ToString() == "写操作")
            {
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

        private void cbDebugEn_CheckedChanged(object sender, EventArgs e)
        {
            btnDebug.Enabled = cbDebugEn.Checked;
            cmbUsbDeviceType.Enabled = cbDebugEn.Checked;
            cmbUsbOtpType.Enabled = cbDebugEn.Checked;
            nudOptDelayMs.Enabled = cbDebugEn.Checked;
            nudNetPortNum.Enabled = cbDebugEn.Checked;
        }
        #endregion

        #region 3. Project 参数初始化
        public void GetAtbTable()
        {

            switch (cbProjectItems.Text)
            {
                case "P2218_V20X":
                    for (int i = 0; i < testItems.atbTable_2218_V20X.GetLength(0); i++)
                    {
                        cmbAtbNodeName.Items.Add(testItems.atbTable_2218_V20X[i, 4]);
                    }
                    break;
                case "P2218R_V100":
                    for (int i = 0; i < testItems.atbTable_2218R_V100.GetLength(0); i++)
                    {
                        cmbAtbNodeName.Items.Add(testItems.atbTable_2218R_V100[i, 4]);
                    }
                    break;
                case "P2318_V100":
                    for (int i = 0; i < testItems.atbTable_2318_V100.GetLength(0); i++)
                    {
                        cmbAtbNodeName.Items.Add(testItems.atbTable_2318_V100[i, 4]);
                    }
                    break;
                case "P2318R_V100":
                    for (int i = 0; i < testItems.atbTable_2318R_V100.GetLength(0); i++)
                    {
                        cmbAtbNodeName.Items.Add(testItems.atbTable_2318R_V100[i, 4]);
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
        public void GetAtbNodeTable()
        {
            switch (cbInterChipProjectItems.Text)
            {
                case "TBS614":
                case "TBS614V102":
                    for (int i = 0; i < inChipTestItems.atbTable_TBS614.GetLength(0); i++)
                    {
                        cmbInterChipAtbName.Items.Add(inChipTestItems.atbTable_TBS614[i, 4]);
                    }
                    break;
                default: break;
            }
        }
        #endregion

        #region 4. CommForm
        private void cbProjectItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            usbDeviceInitial(!enable);

            if (tcTest.SelectedTab == tcTest.TabPages[0])
            {
                cmbAtbNodeName.Items.Clear();
                cmbAtbNodeName.Text = null;
                GetAtbTable();
            }
            if (tcTest.SelectedTab == tcTest.TabPages[1])
            {
                cmbInterChipAtbName.Items.Clear();
                cmbInterChipAtbName.Text = null;
                GetAtbNodeTable();
            }
            if (tcTest.SelectedTab == tcTest.TabPages[2])
            {

            }

        }
        private void cmbAtbNodeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAtbNodeName.Enabled = !enable;
            cmbAtbNodeName.BackColor = Color.Gold;
            usbDeviceInitial(!enable);
            cmbAtbNodeName.BackColor = SystemColors.Control;
            cmbAtbNodeName.Enabled = enable;
        }
        private void cbMultiSelEn_CheckedChanged(object sender, EventArgs e)
        {
            string MultiTemp = "请输入万用表地址";
            string PwrTemp = "请输入电源地址";
            tbInstMultiAddr.Enabled = cbMultiSelEn.Checked;
            tbInstPowerAddr.Enabled = cbPowerSelEn.Checked;
            tbInstMultiAddr1.Enabled = cbMultiSelEn1.Checked;

            tbInstMultiAddr.Text = tbInstMultiAddr.Enabled ? null : MultiTemp;
            tbInstMultiAddr1.Text = tbInstMultiAddr1.Enabled ? null : MultiTemp;
            tbInstPowerAddr.Text = tbInstPowerAddr.Enabled ? null : PwrTemp;

        }
        private void PwrChSelInitial(int ChFlag)
        {
            switch (ChFlag)
            {
                case 0:
                    cbEnPwrCH1.Enabled = !cbEnPwrCH1.Checked;
                    cbEnPwrCH2.Enabled = !cbEnPwrCH2.Checked;
                    cbEnPwrCH3.Enabled = !cbEnPwrCH3.Checked;
                    cbEnPwrCH4.Enabled = !cbEnPwrCH4.Checked;
                    break;
                case 1:
                    cbEnPwrCH1.Enabled = cbEnPwrCH1.Enabled ? cbEnPwrCH1.Enabled : !cbEnPwrCH1.Enabled;
                    cbEnPwrCH2.Enabled = cbEnPwrCH2.Enabled ? cbEnPwrCH2.Enabled : !cbEnPwrCH2.Enabled;
                    cbEnPwrCH3.Enabled = cbEnPwrCH3.Enabled ? cbEnPwrCH3.Enabled : !cbEnPwrCH3.Enabled;
                    cbEnPwrCH4.Enabled = cbEnPwrCH4.Enabled ? cbEnPwrCH4.Enabled : !cbEnPwrCH4.Enabled;
                    break;
                default:
                    break;
            }

        }
        private void VoltCaseSet(string voltCase)
        {
            switch (voltCase)
            {
                case "LV":
                    testItems.voltCase = 0;
                    inChipTestItems.voltCase = 0;
                    break;
                case "NV":
                    testItems.voltCase = 1;
                    inChipTestItems.voltCase = 1;
                    break;
                case "HV":
                    testItems.voltCase = 2;
                    inChipTestItems.voltCase = 2;
                    break;
                default:
                    break;
            }
        }
        private void regWriteEn()
        {
            string[] regValue = { "02", "02", "02", "01" };
            inChipComFunLib.para_St.tbregOptLength.Text = "01";
            inChipComFunLib.interChipWriteReg(usb, "0x02000229", "A6");
            comFunLib.DelayTimeMs(300);
            inChipComFunLib.interChipWriteReg(usb, "0x02000230", "01");
            comFunLib.DelayTimeMs(100);
            for (int i = 0; i < 4; i++)
            {
                string addr = "020003e" + i.ToString("X1");
                inChipComFunLib.interChipWriteReg(usb, addr, regValue[i]);
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            dChipComFunLib.para_St.stop = true;
            inChipComFunLib.para_St.stop = true;
        }
        private void cbEnChip0_CheckedChanged(object sender, EventArgs e)
        {
            cbEnChip1.Checked = cbEnChip0.Checked ? false : true;
            inChipTestItems.chipLocSelect = cbEnChip0.Checked ? 0 : 1;
        }
        private void cbEnChip1_CheckedChanged(object sender, EventArgs e)
        {
            cbEnChip0.Checked = cbEnChip1.Checked ? false : true;
            inChipTestItems.chipLocSelect = cbEnChip0.Checked ? 0 : 1;
        }
        private void btnAtbRead_Click(object sender, EventArgs e)
        {
            if (tcTest.SelectedTab == tcTest.TabPages[0])
            {
                testItems.GetProjectName(dChipComFunLib);
                testItems.tbAtbResult = tbAtbResult;
                testItems.AtbDebugTest(dChipComFunLib, usb);
            }
            if (tcTest.SelectedTab == tcTest.TabPages[1])
            {
                if (Enflag)
                {
                    regWriteEn();
                    Enflag = false;
                }
                inChipTestItems.GetProjectName(inChipComFunLib);
                inChipTestItems.tbAtbResult = tbInterChipAtbResult;
                inChipTestItems.AtbDebugTest(inChipComFunLib, usb);
            }
            if (tcTest.SelectedTab == tcTest.TabPages[2])
            {

            }
        }
        private void btnRegWrite_Click(object sender, EventArgs e)
        {
            dChipComFunLib.para_St.addrOfst = 0;
            dChipComFunLib.para_St.tbregOptLength.Text = "06";

            btnRegWrite.Enabled = false;
            btnRegWrite.BackColor = Color.Coral;
            Application.DoEvents();
            dChipComFunLib.WriteReg(usb, tbDriverRegAddr.Text, tbDriverRegValue.Text);
            btnRegWrite.Enabled = true;
            btnRegWrite.BackColor = Color.PapayaWhip;
            Application.DoEvents();
        }
        private void btnInterChipRegWrite_Click(object sender, EventArgs e)
        {
            inChipComFunLib.para_St.addrOfst = 0;

            btnInterChipRegWrite.Enabled = false;
            btnInterChipRegWrite.BackColor = Color.Coral;
            Application.DoEvents();
            if (Enflag)
            {
                regWriteEn();
                Enflag = false;
            }
            inChipComFunLib.para_St.tbregOptLength.Text = "04";
            inChipComFunLib.WriteReg(usb, inChipTestItems.chipLocSelect, tbInterChipRegAddr.Text, tbInterChipRegValue.Text);
            btnInterChipRegWrite.Enabled = true;
            btnInterChipRegWrite.BackColor = Color.PapayaWhip;
            Application.DoEvents();
        }
        private void btnManualConfig_Click(object sender, EventArgs e)
        {
            dChipComFunLib.para_St.addrOfst = 0;
            
            if (tcTest.SelectedTab ==tcTest.TabPages[0])
            {
                testItems.GetInstHandle(dChipComFunLib);
                testItems.GetProjectName(dChipComFunLib);
                dChipComFunLib.para_St.tbregOptLength.Text = "06";
                testItems.VbgConfig(dChipComFunLib, usb, double.Parse(tbVbgSet.Text.Trim()));
            }
            if (tcTest.SelectedTab == tcTest.TabPages[1])
            {
                if (Enflag)
                {
                    regWriteEn();
                    Enflag = false;
                }
                inChipTestItems.GetInstHandle(inChipComFunLib);
                inChipTestItems.GetProjectName(inChipComFunLib);
                inChipComFunLib.para_St.tbregOptLength.Text = "04";
                inChipTestItems.VbgConfig(inChipComFunLib, usb, double.Parse(tbInterChipVbgValue.Text.Trim()));
            }
            if (tcTest.SelectedTab == tcTest.TabPages[2])
            {
                
            }

        }
        #endregion

        #region 5. Start
        private void btnStart_Click(object sender, EventArgs e)
        {
            rtbDispaly.Clear();
            testItems.rtbDisPlay = rtbDispaly;

            PwrChSelInitial(0);
            btnStart.Enabled = false;
            btnStart.BackColor = Color.Green;
            cbProjectItems.Enabled = false;
            cbTestCase.Enabled = false;
            Application.DoEvents();
            usbDeviceInitial(!enable);
            VoltCaseSet(dChipComFunLib.para_St.cmbVoltCaseSel.Text);
            tbTestMessage.Text = cbProjectItems.Text + "_" + cbTestCase.Text;
            testItems.AutoTest(dChipComFunLib, usb, cbTestCase.Text);
            PwrChSelInitial(1);
            btnStart.Enabled = true;
            btnStart.BackColor = SystemColors.Control;
            cbProjectItems.Enabled = true;
            cbTestCase.Enabled = true;
            Application.DoEvents();

        }
        private void btnInterChipStart_Click(object sender, EventArgs e)
        {
            rtbInterChipDisPlay.Clear();
            inChipTestItems.rtbInterChipDisPlay = rtbInterChipDisPlay;

            PwrChSelInitial(0);
            btnInterChipStart.Enabled = false;
            btnInterChipStart.BackColor = Color.Green;
            cbInterChipProjectItems.Enabled = false;
            cbInterChipTestCase.Enabled = false;
            Application.DoEvents();
            usbDeviceInitial(!enable);
            VoltCaseSet(inChipComFunLib.para_St.cmbVoltCaseSel.Text);
            tbTestMessage.Text = cbInterChipProjectItems.Text + "_" + cbInterChipTestCase.Text;
            inChipTestItems.AutoTest(inChipComFunLib, usb, cbInterChipTestCase.Text);
            PwrChSelInitial(1);
            btnInterChipStart.Enabled = true;
            btnInterChipStart.BackColor = SystemColors.Control;
            cbInterChipProjectItems.Enabled = true;
            cbInterChipTestCase.Enabled = true;
            Application.DoEvents();
        }
        #endregion
    }
}
