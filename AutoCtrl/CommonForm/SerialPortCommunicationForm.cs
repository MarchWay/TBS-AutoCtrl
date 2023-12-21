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
using AutoCtrl.InstCommandCtrl;
using AutoCtrl.CommunicationProtocol;
using NationalInstruments.Visa;
using AutoCtrl.InstCommonCtrl;
using AutoCtrl.TBSiliconProject.MCU_Ctrl;

namespace AutoCtrl.CommonForm {
    public partial class SerialPortCommunicationForm : Form {
        public SerialPortCommunicationForm() {
            InitializeComponent();
            PublicParaLoad();
        }
        public StringBuilder sb = new StringBuilder();               //为了避免在接收处理函数中反复调用，依然声明为一个全局变量
        public SerialPortLib serPortLib = new SerialPortLib();
        public InstCommonCtrlLib instCtrlLib = new InstCommonCtrlLib();
        public InstCommandLib instCmdLib = new InstCommandLib();
        public CommonFunctionLib comFunLib = new CommonFunctionLib();
        public P3268_CommondLib p3268cmd = new P3268_CommondLib();
        public P1040_CommondLib p1040cmd = new P1040_CommondLib();
        private Para_St para_St = new Para_St();
        public List<string> list = new List<string>();

        #region 0. 公共配置与参数集成
        private struct Para_St {
            public string[] baud;
            public string[] stop;
            public string[] verify;
            public int txCnt;
            public int rxCnt;
            public int readByteNum;
            public byte[] received_buf;
        }
        private void ParaInitial() {
            para_St.baud = new string[] { "43000", "56000", "57600", "115200", "128000", "230400", "256000", "460800" };
            para_St.stop = new string[] { "1", "1.5", "2" };
            para_St.verify = new string[] { "Odd", "Even", "None" };
            cmbComPortSel.Text = "COM1";
            cmbBaudRateSet.Text = "115200";
            cmbDataWidthSet.Text = "8";
            cmbVerifyBitSet.Text = "None";
            cmbStopBitSet.Text = "1";
            para_St.txCnt = 0;
            para_St.rxCnt = 0;
            timer.Interval = (int)nudTimeInterval.Value;
            PannelEnable(false);
        }
        private void ParaTransfer() {
            serPortLib.para_st.lbRxCnt = lbRxCnt;
            serPortLib.para_st.lbTxCnt = lbTxCnt;
            serPortLib.para_st.rtbRx = rtbReceive;
            serPortLib.para_st.rtbTx = rtbSend;
            serPortLib.para_st.timeViewEn = cbReceiveTimeDisplay.Checked;
            serPortLib.para_st.rbRxHex = rbReceiveHex;
            serPortLib.para_st.rbTxHex = rbSendHex;
            serPortLib.para_st.serialPort = serialPort;
            serPortLib.para_st.cbSendNewLine = cbSendNewLine;
            serPortLib.para_st.serialPort = serialPort;
            serPortLib.para_st.rtbRx = rtbReceive;
            serPortLib.para_st.sb = sb;
            //------------ P1040 参数初始化 ----------------------------
            p1040cmd.p1040_para_st.stop = false;
            p1040cmd.p1040_para_st.chipCnt = ((int)nudChipCnt_1040.Value - 1).ToString("X2");
            p1040cmd.p1040_para_st.cmbCmdType = cmbCmdType;
            p1040cmd.p1040_para_st.cmbAutoTestItem = cmbAutoTestItem_1040;
            p1040cmd.p1040_para_st.cmbAtbTable = cmbAtbSel_1040;
            p1040cmd.p1040_para_st.cmbFastCmd = cmbFastCmd;
            p1040cmd.p1040_para_st.cmbOscDivCmd = cmbOscDivCmd;
            p1040cmd.p1040_para_st.tbP1040_RegAddr = tbP1040RegAddr;
            p1040cmd.p1040_para_st.tbP1040_ValueCfg = tbP1040RegValue;
            p1040cmd.p1040_para_st.nudGccCode = nudGccTrim_1040;
            p1040cmd.p1040_para_st.rbKeyPwrEn = rbPwrKeyEn;
            p1040cmd.p1040_para_st.rbGppPwrEn = rbPwrGppEn;
            p1040cmd.p1040_para_st.rbItechPwrEn = rbPwrItechEn;
            p1040cmd.p1040_para_st.cbPowerEn = cbEnPower;
            p1040cmd.p1040_para_st.cbMulti0En = cbEnMulti0;
            p1040cmd.p1040_para_st.cbMulti1En = cbEnMulti1;
            p1040cmd.p1040_para_st.nudReadInstDelay = nudReadInstDelay;
            p1040cmd.p1040_para_st.testCnt = (int)nudTestCnt.Value;
            p1040cmd.p1040_para_st.pwrCh = new bool[] { cbCh1En.Checked, cbCh2En.Checked, cbCh3En.Checked, cbCh4En.Checked };
            //------------ P3268V300 参数初始化 ------------------------
        }
        private void PannelEnable(bool enable) {
            gbReceiveSet.Enabled = enable;
            gbSendSet.Enabled = enable;
            btnSendStart.Enabled = enable;
            gbSerialPortSet.Enabled = !enable;
            gbStatus.Enabled = enable;
        }
        private void PublicParaLoad() {
            ParaTransfer();
            ParaInitial();
            cmbBaudRateSet.Items.AddRange(para_St.baud);
            cmbStopBitSet.Items.AddRange(para_St.stop);
            cmbVerifyBitSet.Items.AddRange(para_St.verify);
            cmbComPortSel.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
        }
        #endregion

        #region 1. 仪器连接与配置
        private void btnSearch_Click(object sender, EventArgs e) {
            cmbInstrumentMulti0.Items.Clear();
            cmbInstrumentPower.Items.Clear();
            using (var rmSession = new ResourceManager()) {
                var resources = rmSession.Find("(ASRL|GPIB|TCPIP|USB)?*");
                foreach (string s in resources) {
                    cmbInstrumentMulti0.Items.Add(s);
                    cmbInstrumentMulti1.Items.Add(s);
                    cmbInstrumentPower.Items.Add(s);
                }
            }
        }

        private void btnLinkSel_Click(object sender, EventArgs e) {
            bool enable = true;
            bool isLink = true;
            if (cbEnMulti0.Checked || cbEnMulti1.Checked || cbEnPower.Checked) {
                if (cbEnMulti0.Checked) {
                    isLink &= instCtrlLib.InstrumentLink(ref instCtrlLib.mbsMulti0, cmbInstrumentMulti0.Text.Trim());
                    instCtrlLib.mbsMulti0.TimeoutMilliseconds = 5000;
                    instCtrlLib.mbsMulti0.TerminationCharacterEnabled = true;
                }
                if (cbEnMulti1.Checked) {
                    isLink &= instCtrlLib.InstrumentLink(ref instCtrlLib.mbsMulti1, cmbInstrumentMulti1.Text.Trim());
                    instCtrlLib.mbsMulti1.TimeoutMilliseconds = 5000;
                    instCtrlLib.mbsMulti1.TerminationCharacterEnabled = true;
                }
                if (cbEnPower.Checked) {
                    isLink &= instCtrlLib.InstrumentLink(ref instCtrlLib.mbsPower, cmbInstrumentPower.Text.Trim());
                    instCtrlLib.mbsPower.TimeoutMilliseconds = 5000;
                    instCtrlLib.mbsPower.TerminationCharacterEnabled = true;
                    instCtrlLib.mbsPowerItech = instCtrlLib.mbsPower;   //待改进 todo
                    instCtrlLib.mbsPowerGuwei = instCtrlLib.mbsPower;
                    instCtrlLib.mbsPowerKey = instCtrlLib.mbsPower;
                }
                if (isLink) {
                    btnLinkSel.Enabled = !enable;
                    btnReleaseSel.Enabled = enable;
                    btnLinkSel.BackColor = Color.Green;
                    btnReleaseSel.Text = "Release";
                    cmbInstrumentMulti0.Enabled = !enable;
                    cmbInstrumentMulti1.Enabled = !enable;
                    cmbInstrumentPower.Enabled = !enable;
                    cbEnMulti0.Enabled = !enable;
                    cbEnMulti1.Enabled = !enable;
                    cbEnPower.Enabled = !enable;
                }
                else {
                    btnLinkSel.Enabled = enable;
                    btnLinkSel.BackColor = SystemColors.Control;
                    btnReleaseSel.Enabled = !enable;
                    btnReleaseSel.Text = "Link Fail";
                    cmbInstrumentMulti0.Enabled = enable;
                    cmbInstrumentMulti1.Enabled = enable;
                    cmbInstrumentPower.Enabled = enable;
                    cbEnMulti0.Enabled = enable;
                    cbEnMulti1.Enabled = enable;
                    cbEnPower.Enabled = enable;
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
            if (cbEnMulti0.Checked) {
                instCtrlLib.mbsMulti0.Dispose();
            }
            if (cbEnMulti1.Checked) {
                instCtrlLib.mbsMulti1.Dispose();
            }
            if (cbEnPower.Checked) {
                instCtrlLib.mbsPower.Dispose();
            }
            btnLinkSel.Enabled = enable;
            cmbInstrumentMulti0.Enabled = enable;
            cmbInstrumentMulti1.Enabled = enable;
            cmbInstrumentPower.Enabled = enable;
            cbEnMulti0.Enabled = enable;
            cbEnMulti1.Enabled = enable;
            cbEnPower.Enabled = enable;
            btnSearch.Enabled = enable;
            btnLinkSel.BackColor = SystemColors.Control;
        }
        private void btnStopEn_Click(object sender, EventArgs e) {
            p1040cmd.p1040_para_st.stop = true;
        }
        #endregion

        #region 2. CheckedChanged 事件
        private void cbEnable_CheckedChanged(object sender, EventArgs e) {
            cmbInstrumentPower.Enabled = cbEnPower.Checked;
            cmbInstrumentMulti0.Enabled = cbEnMulti0.Checked;
            cmbInstrumentMulti1.Enabled = cbEnMulti1.Checked;
        }
        #endregion

        #region 3. 串口通用界面函数(发送|接收|显示|设置)
        /// <summary>
        /// 打开串口/关闭串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSerialPortOnOff_Click(object sender, EventArgs e) {
            try {
                //将可能产生异常的代码放置在try块中, 根据当前串口属性来判断是否打开
                if (serialPort.IsOpen) {
                    serialPort.Close();    //串口已经处于打开状态, 关闭串口
                    btnSerialPortOnOff.Text = "OpenPort";
                    btnSerialPortOnOff.BackColor = SystemColors.Control;
                    lbSendByte.ForeColor = lbReceiveByte.ForeColor = lbRxCnt.ForeColor = lbTxCnt.ForeColor = lbSpState.ForeColor = Color.DarkGray;
                    lbSpState.Text = "串口已关闭";
                    lbTxCnt.Text = "0";
                    lbRxCnt.Text = "0";
                }
                else {
                    lbSendByte.ForeColor = lbReceiveByte.ForeColor = lbRxCnt.ForeColor = lbTxCnt.ForeColor = lbSpState.ForeColor = Color.Green;
                    lbSpState.Text = "串口已打开";
                    //串口已经处于关闭状态，则设置好串口属性后打开
                    serialPort.PortName = cmbComPortSel.Text;
                    serialPort.BaudRate = Convert.ToInt32(cmbBaudRateSet.Text);
                    serialPort.DataBits = Convert.ToInt16(cmbDataWidthSet.Text);

                    if (cmbVerifyBitSet.Text.Equals("None"))
                        serialPort.Parity = System.IO.Ports.Parity.None;
                    else if (cmbVerifyBitSet.Text.Equals("Odd"))
                        serialPort.Parity = System.IO.Ports.Parity.Odd;
                    else if (cmbVerifyBitSet.Text.Equals("Even"))
                        serialPort.Parity = System.IO.Ports.Parity.Even;
                    else if (cmbVerifyBitSet.Text.Equals("Mark"))
                        serialPort.Parity = System.IO.Ports.Parity.Mark;
                    else if (cmbVerifyBitSet.Text.Equals("Space"))
                        serialPort.Parity = System.IO.Ports.Parity.Space;

                    if (cmbStopBitSet.Text.Equals("1"))
                        serialPort.StopBits = System.IO.Ports.StopBits.One;
                    else if (cmbStopBitSet.Text.Equals("1.5"))
                        serialPort.StopBits = System.IO.Ports.StopBits.OnePointFive;
                    else if (cmbStopBitSet.Text.Equals("2"))
                        serialPort.StopBits = System.IO.Ports.StopBits.Two;
                    serialPort.Open();     //打开串口
                    btnSerialPortOnOff.Text = "ClosePort";
                    btnSerialPortOnOff.BackColor = Color.GreenYellow;
                }
                PannelEnable(serialPort.IsOpen);
            }
            catch (Exception ex) {
                //捕获可能发生的异常并进行处理; 捕获到异常,创建一个新的对象,之前的不可以再用
                serialPort = new System.IO.Ports.SerialPort();
                //刷新COM口选项
                cmbComPortSel.Items.Clear();
                cmbComPortSel.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                //响铃并显示异常给用户
                System.Media.SystemSounds.Beep.Play();
                btnSerialPortOnOff.Text = "OpenPort";
                btnSerialPortOnOff.BackColor = SystemColors.Control;
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSendStart_Click(object sender, EventArgs e) {
            if (rtbSend.Text == "") {
                MessageBox.Show("发送窗口不能为空!!!");
            }
            else {
                serPortLib.SerialPort_DataSend(rtbSend.Text);
            }
        }
        private void ReadBuffer() {
            comFunLib.DelayTimeMs(20);                                //等待接收完成数据
            para_St.readByteNum = serialPort.BytesToRead;             //获取接收缓冲区中的字节数
            para_St.received_buf = new byte[para_St.readByteNum];     //声明一个大小为num的字节数据用于存放读出的byte型数据
            para_St.rxCnt += para_St.readByteNum;                     //接收字节计数变量增加nun
            serialPort.Read(para_St.received_buf, 0, para_St.readByteNum);   //读取接收缓冲区中num个字节到byte数组中
        }
        /// <summary>
        /// 串口接收函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e) {
            //Part1:串口接收读取
            ReadBuffer();
            //Part2:遍历数组进行字符串转化及拼接
            sb.Clear();     //防止出错,首先清空字符串构造器
            foreach (byte b in para_St.received_buf) {
                if (rbReceiveHex.Checked)
                    sb.Append(b.ToString("X2") + " ");
                else
                    sb.Append(b.ToString() + " ");
            }
            try {
                Invoke((EventHandler)delegate {
                    if (cbReceiveTimeDisplay.Checked) {
                        rtbReceive.AppendText("[" + System.DateTime.Now.ToString("HH:mm:ss") + "][RX]◀▷:" + sb.ToString() + "\n");
                    }
                    else {
                        rtbReceive.AppendText("[RX]◀▷:" + sb.ToString() + "\n");
                    }
                    rtbReceive.ScrollToCaret();
                    lbRxCnt.Text = para_St.rxCnt.ToString();
                });
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbAutoSend_CheckedChanged(object sender, EventArgs e) {
            if (rtbSend.Text != "") {
                if (cbAutoSend.Checked) {
                    nudTimeInterval.Enabled = false;
                    timer.Interval = (int)nudTimeInterval.Value;
                    timer.Start();
                    lbSpState.Text = "串口自动发送中...";
                    btnSendStart.Enabled = rtbReceive.Enabled = rtbSend.Enabled = gbReceiveSet.Enabled = false;
                }
                else {
                    nudTimeInterval.Enabled = true;
                    timer.Stop();
                    lbSpState.Text = "串口已打开";
                    btnSendStart.Enabled = rtbReceive.Enabled = rtbSend.Enabled = gbReceiveSet.Enabled = true;
                }
            }
            else {
                cbAutoSend.Checked = false;
                MessageBox.Show("发送窗口不能为空!!!");
            }
        }
        private void timer_Tick(object sender, EventArgs e) {
            btnSendStart_Click(btnSendStart, new EventArgs());    //循环发送指令,调用发送按钮回调函数
        }
        private void timer1_Tick(object sender, EventArgs e) {
            btnSendStart_Click(btnSendStart, new EventArgs());    //多条指令发送，调用发送按钮回调函数
        }
        private void btnClearReceive_Click(object sender, EventArgs e) {
            rtbReceive.Clear();
            lbRxCnt.Text = "0";
            lbTxCnt.Text = "0";
            para_St.rxCnt = 0;
            para_St.txCnt = 0;
            serPortLib.para_st.txCnt = 0;
            serPortLib.para_st.rxCnt = 0;
        }
        #endregion

        #region 一、P3268V300 测试集成

        #endregion

        #region 二、P1040V100 测试集成
        private void btnP1040RegCfg_Click(object sender, EventArgs e) {
            ParaTransfer();
            btnP1040RegCfg.Enabled = false;
            btnP1040RegCfg.BackColor = Color.Gold;
            p1040cmd.WriteReg(serPortLib, tbP1040RegAddr.Text.Trim(), tbP1040RegValue.Text.Trim());
            btnP1040RegCfg.BackColor = SystemColors.Control;
            btnP1040RegCfg.Enabled = true;
        }
        private void cbLoadTable_CheckedChanged(object sender, EventArgs e) {
            if (cbLoadTable.Checked) {
                cbLoadTable.Enabled = false;
                cbLoadTable.BackColor = Color.Gold;
                p1040cmd.loadTable();
                cbLoadTable.BackColor = SystemColors.Control;
                cbLoadTable.Enabled = true;
                cbLoadTable.Checked = false;
            }
        }
        private void trimEn_CheckChanged(object sender, EventArgs e) {
            nudChipCnt_1040.Enabled = cbChipCnt.Checked;
            nudVbgCfg_1040.Enabled = cbVbgTrimEn.Checked;
            nudLdoCfg_1040.Enabled = cbLdoTrimEn.Checked;
            nudGccTrim_1040.Enabled = cbGccTrimEn.Checked;
            nudOscTrim_1040.Enabled = cbOscTrimEn.Checked;
        }
        private void cmbAtbSel_1040_SelectedIndexChanged(object sender, EventArgs e) {
            ParaTransfer();
            p1040cmd.AtbDebug(serPortLib);
        }
        private void nudVbgCfg_1040_ValueChanged(object sender, EventArgs e) {
            ParaTransfer();
            int data = (int)nudVbgCfg_1040.Value;
            p1040cmd.TrimCode(serPortLib, 0, data.ToString("X4"));
        }

        private void nudLdoCfg_1040_ValueChanged(object sender, EventArgs e) {
            ParaTransfer();
            int data = (int)nudLdoCfg_1040.Value;
            int temp = 0x0145 + 8 * data;  //不能改变默认值;
            p1040cmd.TrimCode(serPortLib, 1, temp.ToString("X4"));
        }
        private void nudGccTrim_1040_ValueChanged(object sender, EventArgs e) {
            ParaTransfer();
            int data = (int)nudGccTrim_1040.Value;
            int temp = 0x7F00 + data;     //不能改变OSC默认值;
            p1040cmd.TrimCode(serPortLib, 2, temp.ToString("X4")); 
        }
        private void nudOscTrim_1040_ValueChanged(object sender, EventArgs e) {
            ParaTransfer();
            int data = (int)nudOscTrim_1040.Value;
            int temp = (int)nudGccTrim_1040.Value + 0x100 * data;  //不能改GCC的Trim，同一个地址0x20
            p1040cmd.TrimCode(serPortLib, 3, temp.ToString("X4")); 
        }
        private void cmbFastCmd_SelectedIndexChanged(object sender, EventArgs e) {
            ParaTransfer();
            p1040cmd.FastCmdCfg(serPortLib, cmbFastCmd.SelectedIndex);
        }
        private void cmbOscDiv_SelectedIndexChanged(object sender, EventArgs e) {
            ParaTransfer();
            p1040cmd.OscDivCfg(serPortLib, cmbOscDivCmd.SelectedIndex);
        }
        private void btnOneKeyLed_Click(object sender, EventArgs e) {
            ParaTransfer();
            btnOneKeyLed.Enabled = false;
            btnOneKeyLed.BackColor = Color.Gold;
            p1040cmd.OneKeyLed(serPortLib, instCtrlLib.mbsPower,((int)nudChipCnt_1040.Value - 1).ToString("X2"));
            btnOneKeyLed.BackColor = SystemColors.Control;
            btnOneKeyLed.Enabled = true;

        }
        private void btnRunTest_1040_Click(object sender, EventArgs e) {
            ParaTransfer();
            btnRunTest_1040.Enabled = false;
            tpTestConfig.Enabled = false;
            btnRunTest_1040.BackColor = Color.Gold;
            p1040cmd.RunTest(serPortLib, instCtrlLib.mbsMulti0, cmbAutoTestItem_1040.SelectedIndex);
            btnRunTest_1040.BackColor = SystemColors.Control;
            tpTestConfig.Enabled = true;
            btnRunTest_1040.Enabled = true;
        }
        #endregion

    }
}
