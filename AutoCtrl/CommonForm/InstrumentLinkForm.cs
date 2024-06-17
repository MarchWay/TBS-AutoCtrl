using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NationalInstruments.Visa;
using AutoCtrl.CommonFunction;
using AutoCtrl.InstCommonCtrl;
using AutoCtrl.InstCommandCtrl;

namespace AutoCtrl.CommonForm {
    public partial class InstrumentLinkForm : Form {
        public InstrumentLinkForm() {
            InitializeComponent();
        }
        public InstCommonCtrlLib instCmnLib = new InstCommonCtrlLib();
        public RichTextBox rtb = new RichTextBox();
        public InstCommandLib instCmdLib = new InstCommandLib();
        public CommonFunctionLib comFunLib = new CommonFunctionLib();
        public bool POWER_ON = true;
        public bool POWER_OFF = false;
        public double startVolt;
        public double stopVolt;
        public double stepVolt;
        public double[] readVolt;
        public double[] multiData;
        public double multiData1;
        public double delay;
        public string testMess;
        public string[] currUnit;
        public bool stopEn;
        public int cnt;
        public bool enKeyPower;
        public bool enGppPower;
        public bool enItechPower;
        public bool[] chEn;
        public double[] targetVolt;
        public double[] overShootVolt;
        public double[] risingStep;
        public double[] fallingStep;

        #region 0.0 Instrument-Debug: 句法|调用|实现
        public void InitialPara() {
            instCmnLib.inst_st.addrMulti = cmbInstrumentList.Text.Trim();         //清除空白字符
            instCmnLib.inst_st.addrPower = cmbInstrumentList.Text.Trim();         //清除空白字符
            instCmnLib.inst_st.addrOscilloscope = cmbInstrumentList.Text.Trim();  //清除空白字符
            rtb = rtbInstrument;
            gbInstCtrl.Enabled = true;
        }

        public void EnablePanel(bool enable) {
            rtb.ForeColor = enable ? Color.Blue : Color.Red;
            rtb.AppendText(enable ? "" : instCmnLib.inst_st.errorMessage);
            gbInstCtrl.Enabled = enable;       //若链接失败,禁用命令控制控件
            btnLink.Enabled = !enable;
            btnDispose.Enabled = enable;
            cmbInstrumentList.Enabled = !enable;
            btnSearch.Enabled = !enable;
            btnLink.BackColor = enable ? Color.Green : SystemColors.Control; //若链接成功,Link按钮背景色变绿
        }

        private void btnLink_Click(object sender, EventArgs e) {
            rtb.Clear();
            InitialPara();
            EnablePanel(instCmnLib.InstrumentLink(ref instCmnLib.mbSession, cmbInstrumentList.Text.Trim()));
            instCmnLib.mbSession.TimeoutMilliseconds = 5000;
            instCmnLib.mbSession.TerminationCharacterEnabled = true;
        }

        private void btnQuery_Click(object sender, EventArgs e) {
            rtbInstrument.Text = String.Empty;
            Cursor.Current = Cursors.WaitCursor;
            try {
                instCmnLib.mbSession.RawIO.Write(cmbCommand.Text.Replace("\\n", "\n"));
                rtbInstrument.Text = instCmnLib.mbSession.RawIO.ReadString().Replace("\n", "");
            }
            catch (Exception exp) {
                MessageBox.Show(exp.Message);
            }
            finally {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnWrite_Click(object sender, EventArgs e) {
            try {
                instCmnLib.mbSession.RawIO.Write(cmbCommand.Text.Replace("\\n", "\n"));
            }
            catch (Exception exp) {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e) {
            rtbInstrument.Text = String.Empty;
            Cursor.Current = Cursors.WaitCursor;
            try {
                rtbInstrument.Text = instCmnLib.mbSession.RawIO.ReadString().Replace("\n", "");
            }
            catch (Exception exp) {
                MessageBox.Show(exp.Message);
            }
            finally {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            rtbInstrument.Text = String.Empty;
        }

        private void btnDispose_Click(object sender, EventArgs e) {
            bool enable = true;
            instCmnLib.mbSession.Dispose();
            gbInstCtrl.Enabled = enable;
            btnLink.Enabled = enable;
            cmbInstrumentList.Enabled = enable;
            btnSearch.Enabled = enable;
            btnLink.BackColor = SystemColors.Control;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            cmbInstrumentList.Items.Clear();
            cmbMulti0Addr.Items.Clear();
            cmbMulti1Addr.Items.Clear();
            cmbPower0Addr.Items.Clear();
            cmbCommonAddr.Items.Clear();
            using (var rmSession = new ResourceManager()) {
                var resources = rmSession.Find("(ASRL|GPIB|TCPIP|USB)?*");
                foreach (string s in resources) {
                    cmbInstrumentList.Items.Add(s);
                    cmbMulti0Addr.Items.Add(s);
                    cmbMulti1Addr.Items.Add(s);
                    cmbPower0Addr.Items.Add(s);
                    cmbCommonAddr.Items.Add(s);
                }
            }
        }
        #endregion

        #region 0.1 Common-Function: Link|Init|AutoTest...
        private void btnLinkSel_Click(object sender, EventArgs e) {
            bool enable = true;
            bool isLink = true;
            if (cbMulti0En.Checked || cbMulti1En.Checked || cbPower0En.Checked || cbPower1En.Checked || cbCommonInstEn.Checked) {
                if (cbMulti0En.Checked) {
                    isLink &= instCmnLib.InstrumentLink(ref instCmnLib.mbsMulti0, cmbMulti0Addr.Text.Trim());
                    instCmnLib.mbsMulti0.TimeoutMilliseconds = 5000;
                    instCmnLib.mbsMulti0.SendEndEnabled = true;
                    instCmnLib.mbsMulti0.TerminationCharacterEnabled = true;
                }
                if (cbMulti1En.Checked) {
                    isLink &= instCmnLib.InstrumentLink(ref instCmnLib.mbsMulti1, cmbMulti1Addr.Text.Trim());
                    instCmnLib.mbsMulti1.TimeoutMilliseconds = 5000;
                    instCmnLib.mbsMulti1.SendEndEnabled = true;
                    instCmnLib.mbsMulti1.TerminationCharacterEnabled = true;
                }
                if (cbPower0En.Checked) {
                    isLink &= instCmnLib.InstrumentLink(ref instCmnLib.mbsPower0, cmbPower0Addr.Text.Trim());
                    instCmnLib.mbsPower0.TimeoutMilliseconds = 5000;
                    instCmnLib.mbsPower0.SendEndEnabled = true;
                    instCmnLib.mbsPower0.TerminationCharacterEnabled = true;
                    instCmnLib.mbsPowerItech = instCmnLib.mbsPower0;   //待改进 todo
                    instCmnLib.mbsPowerGuwei = instCmnLib.mbsPower0;
                    instCmnLib.mbsPowerKey = instCmnLib.mbsPower0;
                }
                if (cbPower1En.Checked) {
                    isLink &= instCmnLib.InstrumentLink(ref instCmnLib.mbsPower1, cmbPower0Addr.Text.Trim());
                    instCmnLib.mbsPower1.TimeoutMilliseconds = 5000;
                    instCmnLib.mbsPower1.SendEndEnabled = true;
                    instCmnLib.mbsPower1.TerminationCharacterEnabled = true;
                    instCmnLib.mbsPowerItech = instCmnLib.mbsPower1;   //待改进 todo
                    instCmnLib.mbsPowerGuwei = instCmnLib.mbsPower1;
                    instCmnLib.mbsPowerKey = instCmnLib.mbsPower1;
                }
                if (cbCommonInstEn.Checked) {
                    isLink &= instCmnLib.InstrumentLink(ref instCmnLib.mbsCommonInst, cmbCommonAddr.Text.Trim());
                    instCmnLib.mbsCommonInst.TimeoutMilliseconds = 5000;
                    instCmnLib.mbsCommonInst.SendEndEnabled = true;
                    instCmnLib.mbsCommonInst.TerminationCharacterEnabled = true;
                }
                if (isLink) {
                    btnLinkSel.Enabled = !enable;
                    btnReleaseSel.Enabled = enable;
                    btnLinkSel.BackColor = Color.Green;
                    btnReleaseSel.Text = "Release";
                    cmbMulti0Addr.Enabled = !enable;
                    cmbMulti1Addr.Enabled = !enable;
                    cmbPower0Addr.Enabled = !enable;
                    cmbPower1Addr.Enabled = !enable;
                    cmbCommonAddr.Enabled = !enable;
                    cbPower0En.Enabled = !enable;
                    cbPower1En.Enabled = !enable;
                    cbMulti0En.Enabled = !enable;
                    cbMulti1En.Enabled = !enable;
                    cbCommonInstEn.Enabled = !enable;
                }
                else {
                    btnLinkSel.Enabled = enable;
                    btnLinkSel.BackColor = SystemColors.Control;
                    btnReleaseSel.Enabled = !enable;
                    btnReleaseSel.Text = "Link Fail";
                    cmbMulti0Addr.Enabled = enable;
                    cmbMulti1Addr.Enabled = enable;
                    cmbPower0Addr.Enabled = enable;
                    cmbPower1Addr.Enabled = enable;
                    cmbCommonAddr.Enabled = enable;
                    cbPower0En.Enabled = enable;
                    cbPower1En.Enabled = enable;
                    cbMulti0En.Enabled = enable;
                    cbMulti1En.Enabled = enable;
                    cbCommonInstEn.Enabled = enable;
                }
            }
            else {
                MessageBox.Show("Please Select Instrument !!!");
                btnLinkSel.BackColor = SystemColors.Control;
                btnLinkSel.Enabled = true;
            }
        }
        private void btnReleaseSel_Click(object sender, EventArgs e) {
            bool enable = true;
            if (cbMulti0En.Checked) {
                instCmnLib.mbsMulti0.Dispose();
            }
            if (cbMulti1En.Checked) {
                instCmnLib.mbsMulti1.Dispose();
            }
            if (cbPower0En.Checked) {
                instCmnLib.mbsPower0.Dispose();
            }
            if (cbPower1En.Checked) {
                instCmnLib.mbsPower1.Dispose();
            }
            if (cbCommonInstEn.Checked) {
                instCmnLib.mbsCommonInst.Dispose();
            }
            btnLinkSel.Enabled = enable;
            btnLinkSel.BackColor = SystemColors.Control;
            btnReleaseSel.Enabled = !enable;
            cmbMulti0Addr.Enabled = enable;
            cmbMulti1Addr.Enabled = enable;
            cmbPower0Addr.Enabled = enable;
            cmbPower1Addr.Enabled = enable;
            cmbCommonAddr.Enabled = enable;
            cbPower0En.Enabled = enable;
            cbMulti0En.Enabled = enable;
            cbPower1En.Enabled = enable;
            cbMulti1En.Enabled = enable;
            cbCommonInstEn.Enabled = enable;
        }
        private void cbInstrumentEn_CheckedChanged(object sender, EventArgs e) {
            cmbMulti0Addr.Enabled = cbMulti0En.Checked;
            cmbMulti1Addr.Enabled = cbMulti1En.Checked;
            cmbPower0Addr.Enabled = cbPower0En.Checked;
            cmbPower1Addr.Enabled = cbPower1En.Checked;
            cmbCommonAddr.Enabled = cbCommonInstEn.Checked;
        }
        private void cbAutoTestEn_CheckedChanged(object sender, EventArgs e) {
            gbSweepSet.Enabled = cbAutoTestEn.Checked;
            btnIVCurveTest.Enabled = cbAutoTestEn.Checked;
        }
        public void PowerSlewRateInit() {
            //************电源斜率控制变量*********************
            targetVolt = new double[] {
                double.Parse(tbCh1TargetValue.Text.Trim())*1000,
                double.Parse(tbCh2TargetValue.Text.Trim())*1000,
                double.Parse(tbCh3TargetValue.Text.Trim())*1000,
                double.Parse(tbCh4TargetValue.Text.Trim())*1000
            };
            overShootVolt = new double[] {
                double.Parse(tbCh1OverShoot.Text.Trim())*1000,
                double.Parse(tbCh2OverShoot.Text.Trim())*1000,
                double.Parse(tbCh3OverShoot.Text.Trim())*1000,
                double.Parse(tbCh4OverShoot.Text.Trim())*1000
            };
            risingStep = new double[] {
                double.Parse(tbCh1OnSR.Text.Trim())*1000,
                double.Parse(tbCh2OnSR.Text.Trim())*1000,
                double.Parse(tbCh3OnSR.Text.Trim())*1000,
                double.Parse(tbCh4OnSR.Text.Trim())*1000
            };
            fallingStep = new double[] {
                double.Parse(tbCh1OffSR.Text.Trim())*1000,
                double.Parse(tbCh2OffSR.Text.Trim())*1000,
                double.Parse(tbCh3OffSR.Text.Trim())*1000,
                double.Parse(tbCh4OffSR.Text.Trim())*1000
            };
            //**********************************************
        }
        private bool PowerParaInit() {
            startVolt = double.Parse(tbStartVolt.Text);
            stopVolt = double.Parse(tbStopVolt.Text);
            stepVolt = double.Parse(tbStepVolt.Text);
            delay = double.Parse(tbDelay.Text);
            PowerSlewRateInit();
            testMess = tbChipID.Text;
            stopEn = false;
            cnt = 0;
            readVolt = new double[3] { 0, 0, 0 };
            multiData = new double[2] { 0, 0 };
            currUnit = new string[] { "mA", "mA" };
            bool[] chEnItech = new bool[] { cbEnItechPowerCH1.Checked, cbEnItechPowerCH2.Checked, cbEnItechPowerCH3.Checked };
            bool[] chEnKey = new bool[] { cbEnKeyPowerCH1.Checked, cbEnKeyPowerCH2.Checked, cbEnKeyPowerCH3.Checked };
            bool[] chEnGpp = new bool[] { cbEnGppPowerCH1.Checked, cbEnGppPowerCH2.Checked, cbEnGppPowerCH3.Checked, cbEnGppPowerCH4.Checked };
            if (cbEnGppPowerCH1.Checked || cbEnGppPowerCH2.Checked || cbEnGppPowerCH3.Checked || cbEnGppPowerCH4.Checked) {
                chEn = chEnGpp;
                enGppPower = true;
            }
            else if (cbEnKeyPowerCH1.Checked || cbEnKeyPowerCH2.Checked || cbEnKeyPowerCH3.Checked) {
                chEn = chEnKey;
                enKeyPower = true;
            }
            else if (cbEnItechPowerCH1.Checked || cbEnItechPowerCH2.Checked || cbEnItechPowerCH3.Checked) {
                chEn = chEnItech;
                enItechPower = true;
            }
            else {
                stopEn = true;
                rtbTestLogPrint.AppendText("1、由于没有任何通道选择，需要操作的电源型号不明确!!!\n2、请在对应型号的电源上勾选至少1个通道，来标识操作对象!!!\n3、勾选AllOnOff，电源上下电执行的效果类似 '按键AllOn/Off'!!!");
            }
            if (enKeyPower || enGppPower || enItechPower) {
                return true;
            }
            else {
                return false;
            }
        }
        private void PowerMultiOperation(int chIndex, double volt) {
            if (enKeyPower) {
                instCmdLib.SetKeyVoltAndCurr(instCmnLib.mbsPowerKey, (InstCommandLib.POWER_CH_EN)chIndex, volt);
                comFunLib.DelayTimeMs(delay);
                instCmdLib.ReadKeyPower(instCmnLib.mbsPowerKey, (InstCommandLib.POWER_CH_EN)chIndex, InstCommandLib.READ_TYPE_EN.VOLT, ref readVolt[0]);
            }
            if (enItechPower) {
                instCmdLib.SetIetchPowerVolt(instCmnLib.mbsPowerItech, (InstCommandLib.POWER_CH_EN)chIndex, volt);
                comFunLib.DelayTimeMs(delay);
                instCmdLib.ReadItechPowerCh(instCmnLib.mbsPowerItech, (InstCommandLib.POWER_CH_EN)chIndex, InstCommandLib.READ_TYPE_EN.VOLT, ref readVolt[1]);
            }
            if (enGppPower) {
                instCmdLib.SetGuWeiPowerVolt(instCmnLib.mbsPowerGuwei, (InstCommandLib.POWER_CH_EN)chIndex, volt);
                comFunLib.DelayTimeMs(delay);
                instCmdLib.ReadGuWeiPowerCh(instCmnLib.mbsPowerGuwei, (InstCommandLib.POWER_CH_EN)chIndex, InstCommandLib.READ_TYPE_EN.VOLT, ref readVolt[2]);
            }
            if (cbMulti0En.Checked) {
                instCmdLib.ReadMulti(instCmnLib.mbsMulti0, ref multiData[0]);
                currUnit[0] = instCmdLib.var_st.dataUnit;
            }
            if (cbMulti1En.Checked) {
                instCmdLib.ReadMulti(instCmnLib.mbsMulti1, ref multiData[1]);
                currUnit[1] = instCmdLib.var_st.dataUnit;
            }
        }
        private void btnAutoTest_Click(object sender, EventArgs e) {
            rtbTestLogPrint.Clear();
            btnIVCurveTest.Enabled = false;
            btnClear.Enabled = false;
            btnIVCurveTest.BackColor = Color.Gold;
            if (PowerParaInit()) {
            int chEnCnt = 0;
            int chindex = 0;
            for (int ch = 0; ch < chEn.Length; ch++) {
                if (chEn[ch]) {
                    chEnCnt++;
                }
            }
            if (chEnCnt == 1) {
                for (int ch = 0; ch < chEn.Length; ch++) {
                    if (chEn[ch]) {
                        chindex = (ch + 1);
                    }
                }
                List<string> list = new List<string> { };
                list.Add(comFunLib.GetDateTimeNow() + " *** 测试结果 *** ");
                list.Add("\nSetVolt(V)\tVolt[0](V)\tVolt[1](V)\tVolt[2](V)\tCurr[0]\tUnit[0]\tCurr[1]\tUnit[1]\t");
                rtbTestLogPrint.ForeColor = Color.Blue;
                comFunLib.CreatFilePath(testMess.Split('_')[0]);
                comFunLib.WriteResultsTitle(testMess + "_" + comFunLib.GetCurrentDataTime(), list, CommonFunctionLib.WRITE_DATA_METHORD.FILE_APPEND);
                list.Clear();
                double volt = startVolt;
                stepVolt = (startVolt > stopVolt) ? -stepVolt : stepVolt;
                for (volt = startVolt; (startVolt > stopVolt) ? (volt >= stopVolt) : (volt <= stopVolt); volt += stepVolt) {
                    if (stopEn) break;
                    cnt++;
                    PowerMultiOperation(chindex, volt);
                    list.Add(volt.ToString("F4"));
                    list.Add(readVolt[0].ToString("F3"));   //keyPower
                    list.Add(readVolt[1].ToString("F3"));   //ItechPower
                    list.Add(readVolt[2].ToString("F3"));   //GppPower
                    list.Add(multiData[0].ToString("F4"));  //万用表0读数
                    list.Add(currUnit[0]);
                    list.Add(multiData[1].ToString("F4"));  //万用表1读数
                    list.Add(currUnit[1]);
                    rtbTestLogPrint.AppendText(cnt
                        + ". VOLT: "
                        + readVolt[0].ToString("F3") + ", "
                        + readVolt[1].ToString("F3") + ", "
                        + readVolt[2].ToString("F3") + ", "
                        + " CURR: "
                        + multiData[0].ToString("F4") + " " + currUnit[0] + ", "
                        + multiData[1].ToString("F4") + " " + currUnit[1] + "\n");
                    rtbTestLogPrint.ScrollToCaret();
                    comFunLib.WriteDataToTxt(list, CommonFunctionLib.WRITE_DATA_METHORD.FILE_APPEND);
                    list.Clear();
                }
            }
            else {
                rtbTestLogPrint.ForeColor = Color.Red;
                if (chEnCnt > 1) {
                    rtbTestLogPrint.AppendText("Checked CH_num > 1; Please Select 'only one' CH to fixed !!!\n");
                }
                else {
                    rtbTestLogPrint.AppendText("Checked CH_num = 0; Please Select 'only one' CH to fixed !!!\n");
                    }
                }
            }
            btnIVCurveTest.Enabled = true;
            btnClear.Enabled = true;
            btnIVCurveTest.BackColor = SystemColors.Control;
        }

        #endregion

        #region 1. Power E36234 Form Ctrl
        private void KeyPowerOnOffCommonPart(bool isPowerOn, bool isPowerChOnOff, bool isPowerAllOnOff) {
            bool[] chEn = new bool[] { cbEnKeyPowerCH1.Checked, cbEnKeyPowerCH2.Checked, cbEnKeyPowerCH3.Checked };
            if (!chEn[0] && !chEn[1] && !chEn[2]) {
                btnKeyPowerOn.BackColor = SystemColors.Control;
                btnKeyPowerOff.BackColor = SystemColors.Control;
                btnKeyPowerOff.Enabled = true;
                btnKeyPowerOn.Enabled = true;
                rtbTestLogPrint.ForeColor = Color.Red;
                rtbTestLogPrint.AppendText("Before Power Control, Please Select Channel !!!\n");
            }
            else {
                if (isPowerChOnOff) {
                    for (int ch = 0; ch < chEn.Length; ch++) {
                        if (chEn[ch]) {
                            instCmdLib.KeyPowerOutPutChEn(instCmnLib.mbsPower0, (InstCommandLib.POWER_CH_EN)(ch + 1), isPowerOn ? InstCommandLib.STATE_EN.ON : InstCommandLib.STATE_EN.OFF);
                        }
                    }
                }
                if (isPowerAllOnOff) {
                    instCmdLib.KeyPowerOutPutAllEn(instCmnLib.mbsPower0, isPowerOn ? InstCommandLib.STATE_EN.ON : InstCommandLib.STATE_EN.OFF);
                }
                if (isPowerOn) {
                    btnKeyPowerOn.Enabled = false;
                    btnKeyPowerOn.BackColor = Color.LightGreen;
                    btnKeyPowerOff.Enabled = true;
                    btnKeyPowerOff.BackColor = SystemColors.Control;
                }
                else {
                    btnKeyPowerOn.Enabled = true;
                    btnKeyPowerOn.BackColor = SystemColors.Control;
                    btnKeyPowerOff.Enabled = false;
                    btnKeyPowerOff.BackColor = Color.LightGreen;
                }
            }
        }
        private void btnKeyPowerOff_Click(object sender, EventArgs e) {
            KeyPowerOnOffCommonPart(false, true, false);  //参数说明：电源下电操作，电源按照勾选的通道进行上下电操作，不执行AllOnOff
        }
        private void btnKeyPowerOn_Click(object sender, EventArgs e) {
            KeyPowerOnOffCommonPart(true, true, false);   //参数说明：电源上电操作，电源按照勾选的通道进行上下电操作，不执行AllOnOff
        }
        private void btnSetKeyPower_Click(object sender, EventArgs e) {
            btnSetKeyPower.BackColor = Color.Goldenrod;
            btnSetKeyPower.Enabled = false;
            bool[] chEn = new bool[3] { cbEnKeyPowerCH1.Checked, cbEnKeyPowerCH2.Checked, cbEnKeyPowerCH3.Checked };
            double[,] setData = new double[,]
            {
                { double.Parse(tbSetKeyVoltCH1.Text), double.Parse(tbSetKeyCurrCH1.Text)},
                { double.Parse(tbSetKeyVoltCH2.Text), double.Parse(tbSetKeyCurrCH2.Text)},
                { double.Parse(tbSetKeyVoltCH3.Text), double.Parse(tbSetKeyCurrCH3.Text)},
            };
            for (int ch = 0; ch < chEn.Length; ch++) {
                if (chEn[ch]) {
                    instCmdLib.SetKeyVoltAndCurr(instCmnLib.mbsPower0, (InstCommandLib.POWER_CH_EN)(ch + 1), setData[ch, 0], setData[ch, 1]);
                }
            }
            btnSetKeyPower.BackColor = Color.PaleGreen;
            btnSetKeyPower.Enabled = true;
        }
        private void btnReadKeyPower_Click(object sender, EventArgs e) {
            btnReadKeyPower.BackColor = Color.Goldenrod;
            btnReadKeyPower.Enabled = false;
            double[,] readData = new double[3, 2];
            for (int ch = 0; ch < readData.GetLength(0); ch++) {
                instCmdLib.ReadKeyPower(instCmnLib.mbsPower0, (InstCommandLib.POWER_CH_EN)(ch + 1), InstCommandLib.READ_TYPE_EN.VOLT, ref readData[ch, 0]);
                instCmdLib.ReadKeyPower(instCmnLib.mbsPower0, (InstCommandLib.POWER_CH_EN)(ch + 1), InstCommandLib.READ_TYPE_EN.CURR, ref readData[ch, 1]);
            }
            tbSetKeyVoltCH1.Text = tbReadKeyVoltCH1.Text = readData[0, 0].ToString("F3");
            tbSetKeyVoltCH2.Text = tbReadKeyVoltCH2.Text = readData[1, 0].ToString("F3");
            tbSetKeyVoltCH3.Text = tbReadKeyVoltCH3.Text = readData[2, 0].ToString("F3");
            tbReadKeyCurrCH1.Text = readData[0, 1].ToString("F3");
            tbReadKeyCurrCH2.Text = readData[1, 1].ToString("F3");
            tbReadKeyCurrCH3.Text = readData[2, 1].ToString("F3");
            btnReadKeyPower.BackColor = Color.PaleGreen;
            btnReadKeyPower.Enabled = true;
        }
        private void SetAndReadKeyPowerEn() {
            if (cbEnKeyPowerCH1.Checked || cbEnKeyPowerCH2.Checked || cbEnKeyPowerCH3.Checked) {
                btnSetKeyPower.Enabled = btnReadKeyPower.Enabled = true;
            }
            else {
                btnSetKeyPower.Enabled = btnReadKeyPower.Enabled = false;
            }
        }
        private void cbEnKeyPowerCH_CheckedChanged(object sender, EventArgs e) {
            tbSetKeyVoltCH1.Enabled = cbEnKeyPowerCH1.Checked;
            tbSetKeyCurrCH1.Enabled = cbEnKeyPowerCH1.Checked;
            tbReadKeyVoltCH1.Enabled = cbEnKeyPowerCH1.Checked;
            tbReadKeyCurrCH1.Enabled = cbEnKeyPowerCH1.Checked;
            tbSetKeyVoltCH2.Enabled = cbEnKeyPowerCH2.Checked;
            tbSetKeyCurrCH2.Enabled = cbEnKeyPowerCH2.Checked;
            tbReadKeyVoltCH2.Enabled = cbEnKeyPowerCH2.Checked;
            tbReadKeyCurrCH2.Enabled = cbEnKeyPowerCH2.Checked;
            tbSetKeyVoltCH3.Enabled = cbEnKeyPowerCH3.Checked;
            tbSetKeyCurrCH3.Enabled = cbEnKeyPowerCH3.Checked;
            tbReadKeyVoltCH3.Enabled = cbEnKeyPowerCH3.Checked;
            tbReadKeyCurrCH3.Enabled = cbEnKeyPowerCH3.Checked;
            SetAndReadKeyPowerEn();
        }
        #endregion

        #region 2. Multi 34465A Form Ctrl
        private void MultiMbsJudge() {
            if (cbMulti0En.Checked) { instCmnLib.mbsMulti = instCmnLib.mbsMulti0; }
            if (cbMulti1En.Checked) { instCmnLib.mbsMulti = instCmnLib.mbsMulti1; }
        }
        private void btnReadMulti_Click(object sender, EventArgs e) {
            MultiMbsJudge();
            btnReadMulti.BackColor = Color.Goldenrod;
            btnReadMulti.Enabled = false;
            instCmdLib.ReadMulti(instCmnLib.mbsMulti, ref instCmdLib.var_st.readData);
            rtbTestLogPrint.AppendText(instCmdLib.var_st.readData.ToString("F6") + "\t" + instCmdLib.var_st.dataUnit + "\n");
            rtbTestLogPrint.ScrollToCaret();
            btnReadMulti.BackColor = Color.PaleGreen;
            btnReadMulti.Enabled = true;
        }
        private void btnCurrDcMode_Click(object sender, EventArgs e) {
            MultiMbsJudge();
            instCmdLib.SetMultiMeasMode(instCmnLib.mbsMulti, InstCommandLib.READ_TYPE_EN.CURR, InstCommandLib.MEASURE_MODE_EN.DC);
        }
        private void btnHighZ_Click(object sender, EventArgs e) {
            MultiMbsJudge();
            instCmdLib.SetMultiHighZ(instCmnLib.mbsMulti, InstCommandLib.STATE_EN.ON);
        }
        private void btnVoltDcMode_Click(object sender, EventArgs e) {
            MultiMbsJudge();
            instCmdLib.SetMultiMeasMode(instCmnLib.mbsMulti, InstCommandLib.READ_TYPE_EN.VOLT, InstCommandLib.MEASURE_MODE_EN.DC);
        }
        private void btnSetNplc_Click(object sender, EventArgs e) {
            MultiMbsJudge();
            InstCommandLib.READ_TYPE_EN readType;
            readType = rbCurrTest.Checked ? InstCommandLib.READ_TYPE_EN.CURR : InstCommandLib.READ_TYPE_EN.VOLT;
            instCmdLib.SetMultiNPLC(instCmnLib.mbsMulti, readType, double.Parse(tbNplc.Text));
        }
        private void btnVoltAcMode_Click(object sender, EventArgs e) {
            MultiMbsJudge();
            instCmdLib.SetMultiMeasMode(instCmnLib.mbsMulti, InstCommandLib.READ_TYPE_EN.VOLT, InstCommandLib.MEASURE_MODE_EN.AC);
        }
        private void btnCurrAcMode_Click(object sender, EventArgs e) {
            MultiMbsJudge();
            instCmdLib.SetMultiMeasMode(instCmnLib.mbsMulti, InstCommandLib.READ_TYPE_EN.CURR, InstCommandLib.MEASURE_MODE_EN.AC);
        }
        private void btnAutoZero_Click(object sender, EventArgs e) {
            MultiMbsJudge();
            if (btnAutoZero.Text.Contains("OFF")) {
                btnAutoZero.Text = "Auto Zero ON";
                btnAutoZero.BackColor = Color.Green;
            }
            else if (btnAutoZero.Text.Contains("ON")) {
                btnAutoZero.Text = "Auto Zero OFF";
                btnAutoZero.BackColor = SystemColors.Control;
            }
            InstCommandLib.READ_TYPE_EN readType;
            InstCommandLib.STATE_EN state;
            readType = rbCurrTest.Checked ? InstCommandLib.READ_TYPE_EN.CURR : InstCommandLib.READ_TYPE_EN.VOLT;
            state = btnAutoZero.Text.Contains("OFF") ? InstCommandLib.STATE_EN.ON : InstCommandLib.STATE_EN.OFF;
            instCmdLib.SetAutoZeroMeas(instCmnLib.mbsMulti, readType, state);
        }

        private void MultiCtrlSel(bool currAc, bool voltAc, bool currDc, bool voltDc, bool highZ, bool autoZero) {
            btnCurrAcMode.Enabled = currAc;
            btnVoltAcMode.Enabled = voltAc;
            btnCurrDcMode.Enabled = currDc;
            btnVoltDcMode.Enabled = voltDc;
            btnHighZ.Enabled = highZ;
            btnAutoZero.Enabled = autoZero;
        }
        private void rbTypeTest_CheckedChanged(object sender, EventArgs e) {
            bool enable = true;
            rbDcMode.Enabled = rbAcMode.Enabled = enable;
            if (rbAcMode.Checked && rbCurrTest.Checked) {
                MultiCtrlSel(enable, !enable, !enable, !enable, !enable, !enable);
            }
            if (rbAcMode.Checked && rbVoltTest.Checked) {
                MultiCtrlSel(!enable, enable, !enable, !enable, !enable, !enable);
            }
            if (rbDcMode.Checked && rbCurrTest.Checked) {
                MultiCtrlSel(!enable, !enable, enable, !enable, !enable, enable);
            }
            if (rbDcMode.Checked && rbVoltTest.Checked) {
                MultiCtrlSel(!enable, !enable, !enable, enable, enable, enable);
            }
        }
        private void rbMeasureMode_CheckedChanged(object sender, EventArgs e) {
            bool enable = true;
            if (rbAcMode.Checked) {
                if (rbCurrTest.Checked) {
                    btnCurrAcMode.Enabled = enable;
                }
                if (rbVoltTest.Checked) {
                    btnVoltAcMode.Enabled = enable;
                }
                btnAutoZero.Enabled = !enable;
                btnCurrDcMode.Enabled = !enable;
                btnVoltDcMode.Enabled = !enable;
                btnSetNplc.Enabled = !enable;
                btnHighZ.Enabled = !enable;
                tbNplc.Enabled = !enable;
            }
            if (rbDcMode.Checked) {
                if (rbCurrTest.Checked) {
                    btnCurrDcMode.Enabled = enable;
                    btnHighZ.Enabled = !enable;
                }
                if (rbVoltTest.Checked) {
                    btnVoltDcMode.Enabled = enable;
                    btnHighZ.Enabled = enable;
                }
                btnAutoZero.Enabled = enable;
                btnSetNplc.Enabled = enable;
                tbNplc.Enabled = enable;
                btnVoltAcMode.Enabled = !enable;
                btnCurrAcMode.Enabled = !enable;
            }
        }
        #endregion

        #region 3. ITECH Power I6333A Operation

        /// <summary>
        /// Keysight Power 输出使能
        /// </summary>
        /// <param name="isPowerOn"></param>
        private void ItechPowerOnoffCommonPart(bool isPowerOn, bool isPowerChOnOff, bool isPowerAllOnOff) {
            bool[] chEn = new bool[] { cbEnItechPowerCH1.Checked, cbEnItechPowerCH2.Checked, cbEnItechPowerCH3.Checked };
            if (!chEn[0] && !chEn[1] && !chEn[2]) {
                btnItechPowerOn.BackColor = SystemColors.Control;
                btnItechPowerOff.BackColor = SystemColors.Control;
                btnItechPowerOn.Enabled = true;
                btnItechPowerOff.Enabled = true;
                rtbTestLogPrint.ForeColor = Color.Red;
                rtbTestLogPrint.AppendText("Before Power Control, Please Select Channel !!!\n");
            }
            else {
                if (isPowerChOnOff) {
                    for (int ch = 0; ch < chEn.Length; ch++) {
                        if (chEn[ch]) {
                            instCmdLib.ItechPowerOutputEn(instCmnLib.mbsPowerItech, (InstCommandLib.POWER_CH_EN)(ch + 1), isPowerOn ? InstCommandLib.STATE_EN.ON : InstCommandLib.STATE_EN.OFF);
                        }
                    }
                }
                if (isPowerAllOnOff) {
                    instCmdLib.ItechPowerOutputAllEn(instCmnLib.mbsPowerItech, isPowerOn ? InstCommandLib.STATE_EN.ON : InstCommandLib.STATE_EN.OFF);
                }
                if (isPowerOn) {
                    btnItechPowerOn.Enabled = false;
                    btnItechPowerOn.BackColor = Color.LightGreen;
                    btnItechPowerOff.Enabled = true;
                    btnItechPowerOff.BackColor = SystemColors.Control;
                }
                else {
                    btnItechPowerOn.Enabled = true;
                    btnItechPowerOn.BackColor = SystemColors.Control;
                    btnItechPowerOff.Enabled = false;
                    btnItechPowerOff.BackColor = Color.LightGreen;
                }
            }
        }
        private void btnItechPowerOn_Click(object sender, EventArgs e) {
            ItechPowerOnoffCommonPart(true, !cbPowerAllOnOff.Checked, cbPowerAllOnOff.Checked);
        }
        private void btnItechPowerOff_Click(object sender, EventArgs e) {
            ItechPowerOnoffCommonPart(false, !cbPowerAllOnOff.Checked, cbPowerAllOnOff.Checked);
        }
        private void btnSetItechPower_Click(object sender, EventArgs e) {
            btnSetItechPower.BackColor = Color.Gold;
            btnSetItechPower.Enabled = false;
            bool[] chEn = new bool[] { cbEnItechPowerCH1.Checked, cbEnItechPowerCH2.Checked, cbEnItechPowerCH3.Checked };
            double[,] setData = new double[,]
                {
                    { double.Parse(tbSetItechVoltCH1.Text), double.Parse(tbSetItechCurrCH1.Text)},
                    { double.Parse(tbSetItechVoltCH2.Text), double.Parse(tbSetItechCurrCH2.Text)},
                    { double.Parse(tbSetItechVoltCH3.Text), double.Parse(tbSetItechCurrCH3.Text)}
                };
            for (int ch = 0; ch < chEn.Length; ch++) {
                if (chEn[ch]) {
                    instCmdLib.SetItechPowerVoltCurr(instCmnLib.mbsPowerItech, (InstCommandLib.POWER_CH_EN)(ch + 1), setData[ch, 0], setData[ch, 1]);
                }
            }
            btnSetItechPower.BackColor = Color.PaleGreen;
            btnSetItechPower.Enabled = true;
        }

        private void btnReadItechPower_Click(object sender, EventArgs e) {
            btnReadItechPower.BackColor = Color.Gold;
            btnReadItechPower.Enabled = false;
            double[] readVolt = new double[3];
            double[] readCurr = new double[3];
            instCmdLib.ReadItechPowerAll(instCmnLib.mbsPowerItech, InstCommandLib.READ_TYPE_EN.VOLT, ref readVolt);
            instCmdLib.ReadItechPowerAll(instCmnLib.mbsPowerItech, InstCommandLib.READ_TYPE_EN.CURR, ref readCurr);
            tbSetItechVoltCH1.Text = tbReadItechVoltCH1.Text = readVolt[0].ToString("F3");
            tbSetItechVoltCH2.Text = tbReadItechVoltCH2.Text = readVolt[1].ToString("F3");
            tbSetItechVoltCH3.Text = tbReadItechVoltCH3.Text = readVolt[2].ToString("F3");
            tbReadItechCurrCH1.Text = readCurr[0].ToString("F3");
            tbReadItechCurrCH2.Text = readCurr[1].ToString("F3");
            tbReadItechCurrCH3.Text = readCurr[2].ToString("F3");
            btnReadItechPower.BackColor = Color.PaleGreen;
            btnReadItechPower.Enabled = true;
        }

        private void SetAndReadItechPowerEn() {
            if (cbEnItechPowerCH1.Checked || cbEnItechPowerCH2.Checked || cbEnItechPowerCH3.Checked) {
                btnReadItechPower.Enabled = btnSetItechPower.Enabled = true;
            }
            else {
                btnReadItechPower.Enabled = btnSetItechPower.Enabled = false;
            }
        }
        private void cbEnItechPowerCH_CheckedChanged(object sender, EventArgs e) {
            tbSetItechVoltCH1.Enabled = cbEnItechPowerCH1.Checked;
            tbSetItechCurrCH1.Enabled = cbEnItechPowerCH1.Checked;
            tbReadItechVoltCH1.Enabled = cbEnItechPowerCH1.Checked;
            tbReadItechCurrCH1.Enabled = cbEnItechPowerCH1.Checked;
            tbSetItechVoltCH2.Enabled = cbEnItechPowerCH2.Checked;
            tbSetItechCurrCH2.Enabled = cbEnItechPowerCH2.Checked;
            tbReadItechVoltCH2.Enabled = cbEnItechPowerCH2.Checked;
            tbReadItechCurrCH2.Enabled = cbEnItechPowerCH2.Checked;
            tbSetItechVoltCH3.Enabled = cbEnItechPowerCH3.Checked;
            tbSetItechCurrCH3.Enabled = cbEnItechPowerCH3.Checked;
            tbReadItechVoltCH3.Enabled = cbEnItechPowerCH3.Checked;
            tbReadItechCurrCH3.Enabled = cbEnItechPowerCH3.Checked;
            SetAndReadItechPowerEn();
        }
        #endregion

        #region 4. GPP-4323 Power Operation
        /// <summary>
        /// Guwei 电源输出使能
        /// </summary>
        /// <param name="isPowerOn"></param>
        private void GppPowerOnoffCommonPart(bool isPowerOn, bool isPowerChOnOff, bool isPowerAllOnOff) {
            bool[] chEn = new bool[] { cbEnGppPowerCH1.Checked, cbEnGppPowerCH2.Checked, cbEnGppPowerCH3.Checked, cbEnGppPowerCH4.Checked };
            if (!chEn[0] && !chEn[1] && !chEn[2] && !chEn[3]) {
                btnGppPowerOn.BackColor = SystemColors.Control;
                btnGppPowerOff.BackColor = SystemColors.Control;
                btnGppPowerOn.Enabled = true;
                btnGppPowerOff.Enabled = true;
                rtbTestLogPrint.ForeColor = Color.Red;
                rtbTestLogPrint.AppendText("Before Power Control, Please Select Channel !!!\n");
            }
            else {
                if (isPowerChOnOff) {
                    for (int ch = 0; ch < chEn.Length; ch++) {
                        if (chEn[ch]) {
                            instCmdLib.GuWeiPowerOutputChEn(instCmnLib.mbsPowerGuwei, (InstCommandLib.POWER_CH_EN)(ch + 1), isPowerOn ? InstCommandLib.STATE_EN.ON : InstCommandLib.STATE_EN.OFF);
                        }
                    }
                }
                if (isPowerAllOnOff) {
                    instCmdLib.GuWeiPowerOutputAllEn(instCmnLib.mbsPowerGuwei, isPowerOn ? InstCommandLib.STATE_EN.ON : InstCommandLib.STATE_EN.OFF);
                }
                if (isPowerOn) {
                    btnGppPowerOn.Enabled = false;
                    btnGppPowerOn.BackColor = Color.LightGreen;
                    btnGppPowerOff.Enabled = true;
                    btnGppPowerOff.BackColor = SystemColors.Control;
                }
                else {
                    btnGppPowerOn.Enabled = true;
                    btnGppPowerOn.BackColor = SystemColors.Control;
                    btnGppPowerOff.Enabled = false;
                    btnGppPowerOff.BackColor = Color.LightGreen;
                }
            }
        }
        private void btnGppPowerOn_Click(object sender, EventArgs e) {
            GppPowerOnoffCommonPart(true, !cbPowerAllOnOff.Checked, cbPowerAllOnOff.Checked);
        }
        private void btnGppPowerOff_Click(object sender, EventArgs e) {
            GppPowerOnoffCommonPart(false, !cbPowerAllOnOff.Checked, cbPowerAllOnOff.Checked);
        }
        private void btnClearGppPowerText_Click(object sender, EventArgs e) {
            rtbTestLogPrint.Clear();
        }
        private void SetAndReadGppPowerEn() {
            bool checkValue = cbEnGppPowerCH1.Checked || cbEnGppPowerCH2.Checked || cbEnGppPowerCH3.Checked || cbEnGppPowerCH4.Checked;
            if (checkValue) {
                btnReadGppPower.Enabled = btnSetGppPower.Enabled = checkValue;
            }
            else {
                btnReadGppPower.Enabled = btnSetGppPower.Enabled = !checkValue;
            }
        }
        private void cbEnGppPowerCH_CheckedChanged(object sender, EventArgs e) {
            tbSetGppVoltCH1.Enabled = cbEnGppPowerCH1.Checked;
            tbSetGppCurrCH1.Enabled = cbEnGppPowerCH1.Checked;
            tbReadGppVoltCH1.Enabled = cbEnGppPowerCH1.Checked;
            tbReadGppCurrCH1.Enabled = cbEnGppPowerCH1.Checked;
            tbSetGppVoltCH2.Enabled = cbEnGppPowerCH2.Checked;
            tbSetGppCurrCH2.Enabled = cbEnGppPowerCH2.Checked;
            tbReadGppVoltCH2.Enabled = cbEnGppPowerCH2.Checked;
            tbReadGppCurrCH2.Enabled = cbEnGppPowerCH2.Checked;
            tbSetGppVoltCH3.Enabled = cbEnGppPowerCH3.Checked;
            tbSetGppCurrCH3.Enabled = cbEnGppPowerCH3.Checked;
            tbReadGppVoltCH3.Enabled = cbEnGppPowerCH3.Checked;
            tbReadGppCurrCH3.Enabled = cbEnGppPowerCH3.Checked;
            tbSetGppVoltCH4.Enabled = cbEnGppPowerCH4.Checked;
            tbSetGppCurrCH4.Enabled = cbEnGppPowerCH4.Checked;
            tbReadGppVoltCH4.Enabled = cbEnGppPowerCH4.Checked;
            tbReadGppCurrCH4.Enabled = cbEnGppPowerCH4.Checked;
            SetAndReadGppPowerEn();
        }
        private void btnSetGppPower_Click(object sender, EventArgs e) {
            btnSetGppPower.BackColor = Color.Gold;
            btnSetGppPower.Enabled = false;
            bool[] chEn = new bool[] { cbEnGppPowerCH1.Checked, cbEnGppPowerCH2.Checked, cbEnGppPowerCH3.Checked, cbEnGppPowerCH4.Checked };
            double[,] setData = new double[,]
                {
                    { double.Parse(tbSetGppVoltCH1.Text), double.Parse(tbSetGppCurrCH1.Text)},
                    { double.Parse(tbSetGppVoltCH2.Text), double.Parse(tbSetGppCurrCH2.Text)},
                    { double.Parse(tbSetGppVoltCH3.Text), double.Parse(tbSetGppCurrCH3.Text)},
                    { double.Parse(tbSetGppVoltCH4.Text), double.Parse(tbSetGppCurrCH4.Text)}
                };
            for (int ch = 0; ch < chEn.Length; ch++) {
                if (chEn[ch]) {
                    instCmdLib.SetGuWeiPowerVolt(instCmnLib.mbsPowerGuwei, (InstCommandLib.POWER_CH_EN)(ch + 1), setData[ch, 0]);
                    instCmdLib.SetGuWeiPowerCurr(instCmnLib.mbsPowerGuwei, (InstCommandLib.POWER_CH_EN)(ch + 1), setData[ch, 1]);
                }
            }
            btnSetGppPower.BackColor = Color.PaleGreen;
            btnSetGppPower.Enabled = true;
        }

        private void btnReadGppPower_Click(object sender, EventArgs e) {
            btnReadGppPower.BackColor = Color.Gold;
            btnReadGppPower.Enabled = false;
            double[] readVolt = new double[4];
            double[] readCurr = new double[4];     //数据读取不必区分通道
            instCmdLib.ReadGuWeiPowerAll(instCmnLib.mbsPowerGuwei, InstCommandLib.READ_TYPE_EN.VOLT, ref readVolt);
            instCmdLib.ReadGuWeiPowerAll(instCmnLib.mbsPowerGuwei, InstCommandLib.READ_TYPE_EN.CURR, ref readCurr);
            tbSetGppVoltCH1.Text = tbReadGppVoltCH1.Text = readVolt[0].ToString("F4");
            tbSetGppVoltCH2.Text = tbReadGppVoltCH2.Text = readVolt[1].ToString("F4");
            tbSetGppVoltCH3.Text = tbReadGppVoltCH3.Text = readVolt[2].ToString("F4");
            tbSetGppVoltCH4.Text = tbReadGppVoltCH4.Text = readVolt[3].ToString("F4");
            tbReadGppCurrCH1.Text = readCurr[0].ToString("F4");
            tbReadGppCurrCH2.Text = readCurr[1].ToString("F4");
            tbReadGppCurrCH3.Text = readCurr[2].ToString("F4");
            tbReadGppCurrCH4.Text = readCurr[3].ToString("F4");
            btnReadGppPower.BackColor = Color.PaleGreen;
            btnReadGppPower.Enabled = true;
        }
        #endregion

        #region 5. SDG6052X 信号源控制
        private void cbChState_CheckedChanged(object sender, EventArgs e) {
            cbCh1State.Text = cbCh1State.Checked ? "CH1-ON" : "CH1-OFF";
            cbCh2State.Text = cbCh2State.Checked ? "CH2-ON" : "CH2-OFF";
            instCmdLib.OutPutEn(instCmnLib.mbsCommonInst,
                InstCommandLib.SIGNAL_SOURCE_CH_EN.C1, cbCh1State.Checked ? InstCommandLib.STATE_EN.ON : InstCommandLib.STATE_EN.OFF);
            instCmdLib.OutPutEn(instCmnLib.mbsCommonInst,
                InstCommandLib.SIGNAL_SOURCE_CH_EN.C2, cbCh2State.Checked ? InstCommandLib.STATE_EN.ON : InstCommandLib.STATE_EN.OFF);
        }
        private void cmbWaveSel_SelectedIndexChanged(object sender, EventArgs e) {
            cmbPrbsLength.Enabled = cmbWaveSel.SelectedItem.ToString() == "PRBS";
            instCmdLib.AllChWaveSet(instCmnLib.mbsCommonInst, (InstCommandLib.SIGNAL_SOURCE_CH_WAVE)cmbWaveSel.SelectedIndex);
        }
        private void cmbPrbsLength_SelectedIndexChanged(object sender, EventArgs e) {
            instCmdLib.AllChPrbsLengthSet(instCmnLib.mbsCommonInst, (cmbPrbsLength.SelectedIndex + 3));
        }

        private void nudFreqSet_ValueChanged(object sender, EventArgs e) {
            instCmdLib.AllChWaveFreq(instCmnLib.mbsCommonInst, (double)nudFreqSet.Value);
        }

        private void nudAmplSet_ValueChanged(object sender, EventArgs e) {
            instCmdLib.AllChWaveAmpl(instCmnLib.mbsCommonInst, (double)nudAmplSet.Value / 1000.000);
        }
        #endregion

        #region 6. CommonFunction 电源类型判断&操作
        private void btnStopTest_Click(object sender, EventArgs e) {
            stopEn = true;
        }
        private void PowerOnOff(bool isPowerOn, bool isPowerChOnOff, bool isPowerAllOnOff) {
            if (enItechPower) {
                ItechPowerOnoffCommonPart(isPowerOn, isPowerChOnOff, isPowerAllOnOff);
            }
            else if (enKeyPower) {
                KeyPowerOnOffCommonPart(isPowerOn, isPowerChOnOff, isPowerAllOnOff);
            }
            else if (enGppPower) {
                GppPowerOnoffCommonPart(isPowerOn, isPowerChOnOff, isPowerAllOnOff);
            }
        }

        private void ReadPowerAllCh(ref double[] curr, ref double[] volt) {
            if (enItechPower) {
                instCmdLib.ReadItechPowerAll(instCmnLib.mbsPower0, InstCommandLib.READ_TYPE_EN.CURR, ref curr);
                instCmdLib.ReadItechPowerAll(instCmnLib.mbsPower0, InstCommandLib.READ_TYPE_EN.VOLT, ref volt);
            }
            if (enGppPower) {
                instCmdLib.ReadGuWeiPowerAll(instCmnLib.mbsPower0, InstCommandLib.READ_TYPE_EN.CURR, ref curr);
                instCmdLib.ReadGuWeiPowerAll(instCmnLib.mbsPower0, InstCommandLib.READ_TYPE_EN.VOLT, ref volt);
            }
            if (enKeyPower) {
                instCmdLib.ReadKeyPower(instCmnLib.mbsPower0, InstCommandLib.POWER_CH_EN.CH1, InstCommandLib.READ_TYPE_EN.VOLT, ref volt[0]);
                instCmdLib.ReadKeyPower(instCmnLib.mbsPower0, InstCommandLib.POWER_CH_EN.CH2, InstCommandLib.READ_TYPE_EN.VOLT, ref volt[1]);
                instCmdLib.ReadKeyPower(instCmnLib.mbsPower0, InstCommandLib.POWER_CH_EN.CH3, InstCommandLib.READ_TYPE_EN.VOLT, ref volt[2]);
                instCmdLib.ReadKeyPower(instCmnLib.mbsPower0, InstCommandLib.POWER_CH_EN.CH1, InstCommandLib.READ_TYPE_EN.CURR, ref curr[0]);
                instCmdLib.ReadKeyPower(instCmnLib.mbsPower0, InstCommandLib.POWER_CH_EN.CH2, InstCommandLib.READ_TYPE_EN.CURR, ref curr[1]);
                instCmdLib.ReadKeyPower(instCmnLib.mbsPower0, InstCommandLib.POWER_CH_EN.CH3, InstCommandLib.READ_TYPE_EN.CURR, ref curr[2]);
            }
        }
        private void PrintLogPwrMonitor(bool pwrOnoff, int cnt) {
            PowerOnOff(pwrOnoff, !cbPowerAllOnOff.Checked, cbPowerAllOnOff.Checked);
            if (pwrOnoff) {
                for (int i = 0; i <= nudPowerHoldTime.Value; i++) {
                    if (stopEn) { break; }
                    rtbTestLogPrint.Text = ("电源上电：第" + (cnt + 1) + "次，保持中...，倒计时 " + (nudPowerHoldTime.Value - i) + " S");
                    comFunLib.DelayTimeMs(1000);
                }
            }
            else {
                for (int j = 0; j <= nudPowerWaitTime.Value; j++) {
                    if (stopEn) { break; }
                    rtbTestLogPrint.Text = ("电源下电：第" + (cnt + 1) + "次，等待中...，倒计时 " + (nudPowerWaitTime.Value - j) + " S");
                    comFunLib.DelayTimeMs(1000);
                }
            }
        }
        private void btnPowerOnOffCycle_Click(object sender, EventArgs e) {
            stopEn = false;
            rtbTestLogPrint.Clear();
            btnPowerOnOffCycle.Enabled = false;
            btnPowerOnOffCycle.BackColor = Color.Gold;
            if (PowerParaInit()) {
            double[] curr = new double[4] { 0, 0, 0, 0 };
            double[] volt = new double[4] { 0, 0, 0, 0 };
            List<string> list = new List<string> { };
            list.Add(comFunLib.GetDateTimeNow() + " *** 测试结果 *** ");
            list.Add("\nCH1_Volt(V)\tCH1_Curr(A)\tCH2_Volt(V)\tCH2_Curr(A)\tCH3_Volt(V)\tCH3_Curr(A)\ttCH4_Volt(V)\tCH4_Curr(A)");
            rtbTestLogPrint.ForeColor = Color.Blue;
            comFunLib.CreatFilePath(testMess.Split('_')[0]);
            comFunLib.WriteResultsTitle(testMess + "_" + comFunLib.GetCurrentDataTime(), list, CommonFunctionLib.WRITE_DATA_METHORD.FILE_APPEND);
            list.Clear();
            for (int cnt = 0; cnt < nudCycleNum.Value; cnt++) {
                if (stopEn) { break; }
                PrintLogPwrMonitor(POWER_ON, cnt);
                ReadPowerAllCh(ref curr, ref volt);
                list.Add(volt[0].ToString("F3"));
                list.Add(curr[0].ToString("F4"));
                list.Add(volt[1].ToString("F3"));
                list.Add(curr[1].ToString("F4"));
                list.Add(volt[2].ToString("F3"));
                list.Add(curr[2].ToString("F4"));
                list.Add(volt[3].ToString("F3"));
                list.Add(curr[3].ToString("F4"));
                comFunLib.WriteDataToTxt(list, CommonFunctionLib.WRITE_DATA_METHORD.FILE_APPEND);
                list.Clear();
                PrintLogPwrMonitor(POWER_OFF, cnt);
                }
            }
            btnPowerOnOffCycle.BackColor = SystemColors.Control;
            btnPowerOnOffCycle.Enabled = true;
        }
        private void btnSetKeyPowerSquence_Click(object sender, EventArgs e) {
            double[] pwrOnSequence = new double[] {
                double.Parse(tbCh1OnDelay.Text.Trim()), double.Parse(tbCh2OnDelay.Text.Trim()), double.Parse(tbCh3OnDelay.Text.Trim())
            };
            double[] pwrOffSequence = new double[] {
                double.Parse(tbCh1OffDelay.Text.Trim()), double.Parse(tbCh2OffDelay.Text.Trim()), double.Parse(tbCh3OffDelay.Text.Trim())
            };
            double[,] squence = new double[2, 3] {
                { pwrOnSequence[0], pwrOnSequence[1], pwrOnSequence[2] },
                { pwrOffSequence[0], pwrOffSequence[1], pwrOffSequence[2]}
            };
            for (int ch = 0; ch < 3; ch++) {
                instCmdLib.SetKeyOutputOnOffDelay(instCmnLib.mbsPower0, (InstCommandLib.POWER_CH_EN)(ch + 1), squence[0, ch], squence[1, ch]);
            }
            //需要增加勾选封锁机制;
        }

        private void btnPwrSequenceStart_Click(object sender, EventArgs e) {
            btnPwrSequenceStart.Enabled = false;
            btnPwrSequenceStart.BackColor = Color.Gold;
            //PowerParaInit();
            stopEn = false;
            if (!stopEn) {
                if (cbPowerAllOnOff.Checked) {
                    btnSetKeyPowerSquence_Click(sender, e);
                    for (int cnt = 0; cnt < nudCycleNum.Value; cnt++) {
                        if (stopEn) { break; }
                        PrintLogPwrMonitor(POWER_ON, cnt);
                        PrintLogPwrMonitor(POWER_OFF, cnt);
                    }
                }
                else {
                    MessageBox.Show("1.此功能仅限于KeySight电源\n2.请勾选AllOnOff选框");
                }
            }
            btnPwrSequenceStart.Enabled = true;
            btnPwrSequenceStart.BackColor = SystemColors.Control;
            //是否需要添加 写结果的操作；
        }
        public void SetPowerVolt(int CH, double volt, double interal) {
            if (enKeyPower) {
                instCmdLib.SetKeyVoltAndCurr(instCmnLib.mbsPower0, (InstCommandLib.POWER_CH_EN)CH, volt);
            }
            else if (enItechPower) {
                instCmdLib.SetItechPowerVoltCurr(instCmnLib.mbsPower0, (InstCommandLib.POWER_CH_EN)CH, volt);
            }
            else if (enGppPower) {
                instCmdLib.SetGuWeiPowerVolt(instCmnLib.mbsPower0, (InstCommandLib.POWER_CH_EN)CH, volt);
            }
            comFunLib.DelayTimeMs(interal);
        }
        private void btnPwrSweep_Click(object sender, EventArgs e) {
            double highLimt = double.Parse(tbHighVolt.Text.Trim()) * 1000;
            double lowLimt = double.Parse(tbLowVolt.Text.Trim()) * 1000;
            double step = double.Parse(tbStepSweep.Text.Trim()) * 1000;
            double interal = double.Parse(tbVoltInteral.Text.Trim());
            int CH = 0;
            btnPwrSweep.Enabled = false;
            btnPwrSweep.BackColor = Color.Gold;
            if (PowerParaInit()) {
            for (int i = 0; i < chEn.Length; i++) {
                if (chEn[i]) CH = i + 1;
            }
            for (int cnt = 0; cnt < nudLoopCnt.Value; cnt++) {
                if (stopEn) { break; }
                rtbTestLogPrint.Text = "电源'UP to DOWN'扫描，第" + (cnt + 1) + "次进行中";
                for (double vH = highLimt; vH >= lowLimt; vH += -step) {
                    if (stopEn) { break; }
                    if (vH >= 500) {
                        SetPowerVolt(CH, vH / 1000.000, interal);
                    }
                    else{
                        SetPowerVolt(CH, vH / 1000.000, interal);
                        comFunLib.DelayTimeMs(90);
                    }
                }
                rtbTestLogPrint.Text = "电源'DOWN to UP'扫描，第" + (cnt + 1) + "次进行中";
                for (double vL = lowLimt; vL <= highLimt; vL += step) {
                    if (stopEn) { break; }
                    SetPowerVolt(CH, vL / 1000.000, interal);
                    }
                }
            }
            btnPwrSweep.Enabled = true;
            btnPwrSweep.BackColor = SystemColors.Control;
        }

        private void btnReadCurr_Click(object sender, EventArgs e) {
            int cnt = 0;
            int CH = 1;
            double readData = 0;
            double delay = double.Parse(tbDelay.Text.Trim());
            PowerParaInit();        //必须放在CH之前，因为里面有初始化chEn[]数组；
            for (int i = 0; i < chEn.Length; i++) {
                if (chEn[i]) {
                    CH += i;
                    break;
                }
            }
            btnReadCurr.Enabled = false;
            btnReadCurr.BackColor = Color.Gold;
            do {
                instCmdLib.ReadKeyPower(instCmnLib.mbsPower0, (InstCommandLib.POWER_CH_EN)CH, InstCommandLib.READ_TYPE_EN.CURR, ref readData);
                Application.DoEvents();
                cnt++;
                rtbTestLogPrint.AppendText(cnt + ".\t电流:\t" + readData.ToString("F3") + "\n");
                rtbTestLogPrint.ScrollToCaret();
            }
            while (!stopEn);
            if (stopEn) {
                btnReadCurr.Enabled = true;
                btnReadCurr.BackColor = SystemColors.Control;
            }
        }
        #endregion

        /// <summary>
        /// 模拟电源上下电 斜率, 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPowerSrOnOff_Click(object sender, EventArgs e) {
            PowerParaInit();

        }
    }
}
