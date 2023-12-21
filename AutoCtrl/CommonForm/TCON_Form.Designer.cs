
namespace AutoCtrl.CommonForm {
    partial class TCON_Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.gbSerialPort = new System.Windows.Forms.GroupBox();
            this.groupBox_port = new System.Windows.Forms.GroupBox();
            this.Button_serialSwitch = new System.Windows.Forms.Button();
            this.label_portName = new System.Windows.Forms.Label();
            this.comboBox_portName = new System.Windows.Forms.ComboBox();
            this.label_baudRate = new System.Windows.Forms.Label();
            this.label_parity = new System.Windows.Forms.Label();
            this.comboBox_parity = new System.Windows.Forms.ComboBox();
            this.comboBox_baudRate = new System.Windows.Forms.ComboBox();
            this.label_dataBit = new System.Windows.Forms.Label();
            this.label_stopBit = new System.Windows.Forms.Label();
            this.comboBox_stopBit = new System.Windows.Forms.ComboBox();
            this.comboBox_dataBit = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Button_StopSend = new System.Windows.Forms.Button();
            this.Button_ReCaculate = new System.Windows.Forms.Button();
            this.Button_ClearWin = new System.Windows.Forms.Button();
            this.Button_ToFlash = new System.Windows.Forms.Button();
            this.Button_FromFlash = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_row15 = new System.Windows.Forms.Label();
            this.label_row14 = new System.Windows.Forms.Label();
            this.label_row13 = new System.Windows.Forms.Label();
            this.label_row12 = new System.Windows.Forms.Label();
            this.label_row11 = new System.Windows.Forms.Label();
            this.label_row10 = new System.Windows.Forms.Label();
            this.label_row9 = new System.Windows.Forms.Label();
            this.label_row8 = new System.Windows.Forms.Label();
            this.label_row7 = new System.Windows.Forms.Label();
            this.label_row6 = new System.Windows.Forms.Label();
            this.label_row5 = new System.Windows.Forms.Label();
            this.label_row4 = new System.Windows.Forms.Label();
            this.label_row3 = new System.Windows.Forms.Label();
            this.label_row2 = new System.Windows.Forms.Label();
            this.label_row1 = new System.Windows.Forms.Label();
            this.label_row0 = new System.Windows.Forms.Label();
            this.progressBar_Comm = new System.Windows.Forms.ProgressBar();
            this.Button_loadTxtFile = new System.Windows.Forms.Button();
            this.Button_flash = new System.Windows.Forms.Button();
            this.Button_DebugEn = new System.Windows.Forms.Button();
            this.richTextBox_readData = new System.Windows.Forms.RichTextBox();
            this.Button_loadBinaryFile = new System.Windows.Forms.Button();
            this.label_totalLinesCount = new System.Windows.Forms.Label();
            this.richTextBox_paras = new System.Windows.Forms.RichTextBox();
            this.Button_writeParas = new System.Windows.Forms.Button();
            this.Button_readParas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Button_SelfDefine = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_addrLL = new System.Windows.Forms.TextBox();
            this.textBox_addrLH = new System.Windows.Forms.TextBox();
            this.textBox_addrHL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_dataLength = new System.Windows.Forms.TextBox();
            this.label_dataLength = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_type = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_timeout = new System.Windows.Forms.Label();
            this.textBox_timeout = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_addr = new System.Windows.Forms.Label();
            this.textBox_addrHH = new System.Windows.Forms.TextBox();
            this.label_length = new System.Windows.Forms.Label();
            this.textBox_length = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RadioButton_StepTest = new System.Windows.Forms.RadioButton();
            this.RadioButton_Test = new System.Windows.Forms.RadioButton();
            this.RadioButton_Iram = new System.Windows.Forms.RadioButton();
            this.RadioButton_cmd = new System.Windows.Forms.RadioButton();
            this.RadioButton_flash = new System.Windows.Forms.RadioButton();
            this.RadioButton_inter = new System.Windows.Forms.RadioButton();
            this.gb6330Test = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpLvdsBertTest = new System.Windows.Forms.TabPage();
            this.btnPllLock = new System.Windows.Forms.Button();
            this.cbVcoFreqHigh = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.btnOpenErrSwitch = new System.Windows.Forms.Button();
            this.btnReadDefault = new System.Windows.Forms.Button();
            this.btnLvdsBert = new System.Windows.Forms.Button();
            this.btnClrAndReadErr = new System.Windows.Forms.Button();
            this.btnWriteDefault = new System.Windows.Forms.Button();
            this.btnFreqCfg = new System.Windows.Forms.Button();
            this.cmbFreqSel = new System.Windows.Forms.ComboBox();
            this.gbRxClk = new System.Windows.Forms.GroupBox();
            this.label72 = new System.Windows.Forms.Label();
            this.tbVcoFreqCfg04 = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.tbVcoFreqCfg03 = new System.Windows.Forms.TextBox();
            this.tbDataClkPhase = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.tbVcoFreqCfg08 = new System.Windows.Forms.TextBox();
            this.tbRxClkPhase = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tbRxClkPhaseCfg = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.gbRxPhase = new System.Windows.Forms.GroupBox();
            this.tbRxDataPhase = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.tbRxDataPhaseCfg_2 = new System.Windows.Forms.TextBox();
            this.tbRxDataPhaseCfg_3 = new System.Windows.Forms.TextBox();
            this.tbRxDataPhaseCfg_1 = new System.Windows.Forms.TextBox();
            this.cbAllCaseSweep = new System.Windows.Forms.CheckBox();
            this.nudReadErrDelay = new System.Windows.Forms.NumericUpDown();
            this.cbStepDebugEn = new System.Windows.Forms.CheckBox();
            this.label39 = new System.Windows.Forms.Label();
            this.tbpSdramDllTrim = new System.Windows.Forms.TabPage();
            this.btnSdramDllTest3 = new System.Windows.Forms.Button();
            this.btnSdramDllTest2 = new System.Windows.Forms.Button();
            this.cmbSelfTestPattern = new System.Windows.Forms.ComboBox();
            this.label73 = new System.Windows.Forms.Label();
            this.btnSelfTestPattern = new System.Windows.Forms.Button();
            this.cbWriteChange = new System.Windows.Forms.CheckBox();
            this.nudIntervalDelay = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.btnSdramDllTest1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbOeRam = new System.Windows.Forms.CheckBox();
            this.cbGroupRamEn = new System.Windows.Forms.CheckBox();
            this.cbDotDetectEn = new System.Windows.Forms.CheckBox();
            this.cbCfgregRamEn = new System.Windows.Forms.CheckBox();
            this.btnCpuConflict = new System.Windows.Forms.Button();
            this.tbpPhaseTest = new System.Windows.Forms.TabPage();
            this.lbViewCnt = new System.Windows.Forms.Label();
            this.gbTestModeSel = new System.Windows.Forms.GroupBox();
            this.rbLogicCheckMode = new System.Windows.Forms.RadioButton();
            this.rbPhaseSequenceOptMode = new System.Windows.Forms.RadioButton();
            this.gbPowerSel = new System.Windows.Forms.GroupBox();
            this.rbGuweiPwrEn = new System.Windows.Forms.RadioButton();
            this.rbKeyPowerEn = new System.Windows.Forms.RadioButton();
            this.btnPhaseTest = new System.Windows.Forms.Button();
            this.cbCh4En = new System.Windows.Forms.CheckBox();
            this.cbCh3En = new System.Windows.Forms.CheckBox();
            this.cbCh2En = new System.Windows.Forms.CheckBox();
            this.cbCh1En = new System.Windows.Forms.CheckBox();
            this.cbPowerSelEn = new System.Windows.Forms.CheckBox();
            this.label77 = new System.Windows.Forms.Label();
            this.tbInstPowerAddr = new System.Windows.Forms.TextBox();
            this.gbCommCfg = new System.Windows.Forms.GroupBox();
            this.label74 = new System.Windows.Forms.Label();
            this.nudStart = new System.Windows.Forms.NumericUpDown();
            this.label75 = new System.Windows.Forms.Label();
            this.nudEnd = new System.Windows.Forms.NumericUpDown();
            this.lbEndTime = new System.Windows.Forms.Label();
            this.nudLoopCnt = new System.Windows.Forms.NumericUpDown();
            this.label78 = new System.Windows.Forms.Label();
            this.lbStartTime = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.nudWRDelay = new System.Windows.Forms.NumericUpDown();
            this.lbETime = new System.Windows.Forms.Label();
            this.lbSTime = new System.Windows.Forms.Label();
            this.nudStep = new System.Windows.Forms.NumericUpDown();
            this.label76 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.rtbLogPrint1 = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.rtbLogPrint = new System.Windows.Forms.RichTextBox();
            this.gbSerialPort.SuspendLayout();
            this.groupBox_port.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gb6330Test.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpLvdsBertTest.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbRxClk.SuspendLayout();
            this.gbRxPhase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReadErrDelay)).BeginInit();
            this.tbpSdramDllTrim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalDelay)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tbpPhaseTest.SuspendLayout();
            this.gbTestModeSel.SuspendLayout();
            this.gbPowerSel.SuspendLayout();
            this.gbCommCfg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoopCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWRDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStep)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSerialPort
            // 
            this.gbSerialPort.BackColor = System.Drawing.Color.White;
            this.gbSerialPort.Controls.Add(this.groupBox_port);
            this.gbSerialPort.Controls.Add(this.groupBox2);
            this.gbSerialPort.Controls.Add(this.groupBox1);
            this.gbSerialPort.Controls.Add(this.groupBox3);
            this.gbSerialPort.Location = new System.Drawing.Point(14, 15);
            this.gbSerialPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSerialPort.Name = "gbSerialPort";
            this.gbSerialPort.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSerialPort.Size = new System.Drawing.Size(661, 704);
            this.gbSerialPort.TabIndex = 29;
            this.gbSerialPort.TabStop = false;
            this.gbSerialPort.Text = "串口信息";
            // 
            // groupBox_port
            // 
            this.groupBox_port.Controls.Add(this.Button_serialSwitch);
            this.groupBox_port.Controls.Add(this.label_portName);
            this.groupBox_port.Controls.Add(this.comboBox_portName);
            this.groupBox_port.Controls.Add(this.label_baudRate);
            this.groupBox_port.Controls.Add(this.label_parity);
            this.groupBox_port.Controls.Add(this.comboBox_parity);
            this.groupBox_port.Controls.Add(this.comboBox_baudRate);
            this.groupBox_port.Controls.Add(this.label_dataBit);
            this.groupBox_port.Controls.Add(this.label_stopBit);
            this.groupBox_port.Controls.Add(this.comboBox_stopBit);
            this.groupBox_port.Controls.Add(this.comboBox_dataBit);
            this.groupBox_port.Location = new System.Drawing.Point(13, 23);
            this.groupBox_port.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox_port.Name = "groupBox_port";
            this.groupBox_port.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox_port.Size = new System.Drawing.Size(630, 101);
            this.groupBox_port.TabIndex = 23;
            this.groupBox_port.TabStop = false;
            this.groupBox_port.Text = "串口设置";
            // 
            // Button_serialSwitch
            // 
            this.Button_serialSwitch.Location = new System.Drawing.Point(423, 56);
            this.Button_serialSwitch.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Button_serialSwitch.Name = "Button_serialSwitch";
            this.Button_serialSwitch.Size = new System.Drawing.Size(97, 26);
            this.Button_serialSwitch.TabIndex = 3;
            this.Button_serialSwitch.Text = "打开串口";
            this.Button_serialSwitch.UseVisualStyleBackColor = true;
            // 
            // label_portName
            // 
            this.label_portName.AutoSize = true;
            this.label_portName.Location = new System.Drawing.Point(5, 28);
            this.label_portName.Name = "label_portName";
            this.label_portName.Size = new System.Drawing.Size(77, 15);
            this.label_portName.TabIndex = 1;
            this.label_portName.Text = "串口名称：";
            // 
            // comboBox_portName
            // 
            this.comboBox_portName.FormattingEnabled = true;
            this.comboBox_portName.Location = new System.Drawing.Point(82, 24);
            this.comboBox_portName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboBox_portName.Name = "comboBox_portName";
            this.comboBox_portName.Size = new System.Drawing.Size(96, 23);
            this.comboBox_portName.TabIndex = 0;
            // 
            // label_baudRate
            // 
            this.label_baudRate.AutoSize = true;
            this.label_baudRate.Location = new System.Drawing.Point(5, 62);
            this.label_baudRate.Name = "label_baudRate";
            this.label_baudRate.Size = new System.Drawing.Size(77, 15);
            this.label_baudRate.TabIndex = 3;
            this.label_baudRate.Text = "波 特 率：";
            // 
            // label_parity
            // 
            this.label_parity.AutoSize = true;
            this.label_parity.Location = new System.Drawing.Point(361, 28);
            this.label_parity.Name = "label_parity";
            this.label_parity.Size = new System.Drawing.Size(63, 15);
            this.label_parity.TabIndex = 9;
            this.label_parity.Text = "奇偶位：";
            // 
            // comboBox_parity
            // 
            this.comboBox_parity.FormattingEnabled = true;
            this.comboBox_parity.Location = new System.Drawing.Point(424, 25);
            this.comboBox_parity.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboBox_parity.Name = "comboBox_parity";
            this.comboBox_parity.Size = new System.Drawing.Size(96, 23);
            this.comboBox_parity.TabIndex = 6;
            // 
            // comboBox_baudRate
            // 
            this.comboBox_baudRate.FormattingEnabled = true;
            this.comboBox_baudRate.Location = new System.Drawing.Point(82, 60);
            this.comboBox_baudRate.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboBox_baudRate.Name = "comboBox_baudRate";
            this.comboBox_baudRate.Size = new System.Drawing.Size(96, 23);
            this.comboBox_baudRate.TabIndex = 1;
            // 
            // label_dataBit
            // 
            this.label_dataBit.AutoSize = true;
            this.label_dataBit.Location = new System.Drawing.Point(188, 28);
            this.label_dataBit.Name = "label_dataBit";
            this.label_dataBit.Size = new System.Drawing.Size(63, 15);
            this.label_dataBit.TabIndex = 5;
            this.label_dataBit.Text = "数据位：";
            // 
            // label_stopBit
            // 
            this.label_stopBit.AutoSize = true;
            this.label_stopBit.Location = new System.Drawing.Point(188, 64);
            this.label_stopBit.Name = "label_stopBit";
            this.label_stopBit.Size = new System.Drawing.Size(63, 15);
            this.label_stopBit.TabIndex = 7;
            this.label_stopBit.Text = "停止位：";
            // 
            // comboBox_stopBit
            // 
            this.comboBox_stopBit.FormattingEnabled = true;
            this.comboBox_stopBit.Location = new System.Drawing.Point(251, 60);
            this.comboBox_stopBit.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboBox_stopBit.Name = "comboBox_stopBit";
            this.comboBox_stopBit.Size = new System.Drawing.Size(96, 23);
            this.comboBox_stopBit.TabIndex = 5;
            // 
            // comboBox_dataBit
            // 
            this.comboBox_dataBit.FormattingEnabled = true;
            this.comboBox_dataBit.Location = new System.Drawing.Point(251, 25);
            this.comboBox_dataBit.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboBox_dataBit.Name = "comboBox_dataBit";
            this.comboBox_dataBit.Size = new System.Drawing.Size(96, 23);
            this.comboBox_dataBit.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Button_StopSend);
            this.groupBox2.Controls.Add(this.Button_ReCaculate);
            this.groupBox2.Controls.Add(this.Button_ClearWin);
            this.groupBox2.Controls.Add(this.Button_ToFlash);
            this.groupBox2.Controls.Add(this.Button_FromFlash);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label_row15);
            this.groupBox2.Controls.Add(this.label_row14);
            this.groupBox2.Controls.Add(this.label_row13);
            this.groupBox2.Controls.Add(this.label_row12);
            this.groupBox2.Controls.Add(this.label_row11);
            this.groupBox2.Controls.Add(this.label_row10);
            this.groupBox2.Controls.Add(this.label_row9);
            this.groupBox2.Controls.Add(this.label_row8);
            this.groupBox2.Controls.Add(this.label_row7);
            this.groupBox2.Controls.Add(this.label_row6);
            this.groupBox2.Controls.Add(this.label_row5);
            this.groupBox2.Controls.Add(this.label_row4);
            this.groupBox2.Controls.Add(this.label_row3);
            this.groupBox2.Controls.Add(this.label_row2);
            this.groupBox2.Controls.Add(this.label_row1);
            this.groupBox2.Controls.Add(this.label_row0);
            this.groupBox2.Controls.Add(this.progressBar_Comm);
            this.groupBox2.Controls.Add(this.Button_loadTxtFile);
            this.groupBox2.Controls.Add(this.Button_flash);
            this.groupBox2.Controls.Add(this.Button_DebugEn);
            this.groupBox2.Controls.Add(this.richTextBox_readData);
            this.groupBox2.Controls.Add(this.Button_loadBinaryFile);
            this.groupBox2.Controls.Add(this.label_totalLinesCount);
            this.groupBox2.Controls.Add(this.richTextBox_paras);
            this.groupBox2.Controls.Add(this.Button_writeParas);
            this.groupBox2.Controls.Add(this.Button_readParas);
            this.groupBox2.Location = new System.Drawing.Point(13, 288);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox2.Size = new System.Drawing.Size(630, 409);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据操作";
            // 
            // Button_StopSend
            // 
            this.Button_StopSend.Font = new System.Drawing.Font("Courier New", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_StopSend.Location = new System.Drawing.Point(10, 304);
            this.Button_StopSend.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Button_StopSend.Name = "Button_StopSend";
            this.Button_StopSend.Size = new System.Drawing.Size(74, 35);
            this.Button_StopSend.TabIndex = 59;
            this.Button_StopSend.Text = "停止";
            this.Button_StopSend.UseVisualStyleBackColor = true;
            this.Button_StopSend.Visible = false;
            // 
            // Button_ReCaculate
            // 
            this.Button_ReCaculate.Location = new System.Drawing.Point(377, 347);
            this.Button_ReCaculate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Button_ReCaculate.Name = "Button_ReCaculate";
            this.Button_ReCaculate.Size = new System.Drawing.Size(83, 28);
            this.Button_ReCaculate.TabIndex = 24;
            this.Button_ReCaculate.Text = "重算大表";
            this.Button_ReCaculate.UseVisualStyleBackColor = true;
            // 
            // Button_ClearWin
            // 
            this.Button_ClearWin.Location = new System.Drawing.Point(528, 347);
            this.Button_ClearWin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Button_ClearWin.Name = "Button_ClearWin";
            this.Button_ClearWin.Size = new System.Drawing.Size(86, 28);
            this.Button_ClearWin.TabIndex = 25;
            this.Button_ClearWin.Text = "清除窗口";
            this.Button_ClearWin.UseVisualStyleBackColor = true;
            // 
            // Button_ToFlash
            // 
            this.Button_ToFlash.Location = new System.Drawing.Point(202, 347);
            this.Button_ToFlash.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Button_ToFlash.Name = "Button_ToFlash";
            this.Button_ToFlash.Size = new System.Drawing.Size(83, 28);
            this.Button_ToFlash.TabIndex = 23;
            this.Button_ToFlash.Text = "参数固化";
            this.Button_ToFlash.UseVisualStyleBackColor = true;
            // 
            // Button_FromFlash
            // 
            this.Button_FromFlash.Location = new System.Drawing.Point(288, 347);
            this.Button_FromFlash.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Button_FromFlash.Name = "Button_FromFlash";
            this.Button_FromFlash.Size = new System.Drawing.Size(85, 28);
            this.Button_FromFlash.TabIndex = 22;
            this.Button_FromFlash.Text = "参数回读";
            this.Button_FromFlash.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(546, 15);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 15);
            this.label18.TabIndex = 58;
            this.label18.Text = "0E";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(373, 15);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 15);
            this.label14.TabIndex = 51;
            this.label14.Text = "07";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(521, 15);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 15);
            this.label19.TabIndex = 57;
            this.label19.Text = "0D";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(349, 15);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 15);
            this.label15.TabIndex = 50;
            this.label15.Text = "06";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(497, 15);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 15);
            this.label20.TabIndex = 56;
            this.label20.Text = "0C";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(324, 15);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 15);
            this.label16.TabIndex = 49;
            this.label16.Text = "05";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(471, 15);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(21, 15);
            this.label21.TabIndex = 55;
            this.label21.Text = "0B";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(298, 15);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 15);
            this.label17.TabIndex = 48;
            this.label17.Text = "04";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(445, 15);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(21, 15);
            this.label22.TabIndex = 54;
            this.label22.Text = "0A";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(275, 15);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 15);
            this.label13.TabIndex = 47;
            this.label13.Text = "03";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(422, 15);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(21, 15);
            this.label23.TabIndex = 53;
            this.label23.Text = "09";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(398, 15);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(21, 15);
            this.label24.TabIndex = 52;
            this.label24.Text = "08";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(571, 15);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 15);
            this.label12.TabIndex = 46;
            this.label12.Text = "0F";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(249, 15);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 15);
            this.label11.TabIndex = 45;
            this.label11.Text = "02";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(226, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 15);
            this.label10.TabIndex = 44;
            this.label10.Text = "01";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 15);
            this.label9.TabIndex = 43;
            this.label9.Text = "00";
            // 
            // label_row15
            // 
            this.label_row15.AutoSize = true;
            this.label_row15.Location = new System.Drawing.Point(138, 324);
            this.label_row15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_row15.Name = "label_row15";
            this.label_row15.Size = new System.Drawing.Size(14, 15);
            this.label_row15.TabIndex = 42;
            this.label_row15.Text = "F";
            // 
            // label_row14
            // 
            this.label_row14.AutoSize = true;
            this.label_row14.Location = new System.Drawing.Point(138, 305);
            this.label_row14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_row14.Name = "label_row14";
            this.label_row14.Size = new System.Drawing.Size(14, 15);
            this.label_row14.TabIndex = 41;
            this.label_row14.Text = "E";
            // 
            // label_row13
            // 
            this.label_row13.AutoSize = true;
            this.label_row13.Location = new System.Drawing.Point(138, 286);
            this.label_row13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_row13.Name = "label_row13";
            this.label_row13.Size = new System.Drawing.Size(14, 15);
            this.label_row13.TabIndex = 40;
            this.label_row13.Text = "D";
            // 
            // label_row12
            // 
            this.label_row12.AutoSize = true;
            this.label_row12.Location = new System.Drawing.Point(138, 268);
            this.label_row12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_row12.Name = "label_row12";
            this.label_row12.Size = new System.Drawing.Size(14, 15);
            this.label_row12.TabIndex = 39;
            this.label_row12.Text = "C";
            // 
            // label_row11
            // 
            this.label_row11.AutoSize = true;
            this.label_row11.Location = new System.Drawing.Point(138, 250);
            this.label_row11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_row11.Name = "label_row11";
            this.label_row11.Size = new System.Drawing.Size(14, 15);
            this.label_row11.TabIndex = 38;
            this.label_row11.Text = "B";
            // 
            // label_row10
            // 
            this.label_row10.AutoSize = true;
            this.label_row10.Location = new System.Drawing.Point(138, 230);
            this.label_row10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_row10.Name = "label_row10";
            this.label_row10.Size = new System.Drawing.Size(14, 15);
            this.label_row10.TabIndex = 37;
            this.label_row10.Text = "A";
            // 
            // label_row9
            // 
            this.label_row9.AutoSize = true;
            this.label_row9.Location = new System.Drawing.Point(138, 211);
            this.label_row9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_row9.Name = "label_row9";
            this.label_row9.Size = new System.Drawing.Size(14, 15);
            this.label_row9.TabIndex = 36;
            this.label_row9.Text = "9";
            // 
            // label_row8
            // 
            this.label_row8.AutoSize = true;
            this.label_row8.Location = new System.Drawing.Point(138, 192);
            this.label_row8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_row8.Name = "label_row8";
            this.label_row8.Size = new System.Drawing.Size(14, 15);
            this.label_row8.TabIndex = 35;
            this.label_row8.Text = "8";
            // 
            // label_row7
            // 
            this.label_row7.AutoSize = true;
            this.label_row7.Location = new System.Drawing.Point(138, 174);
            this.label_row7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_row7.Name = "label_row7";
            this.label_row7.Size = new System.Drawing.Size(14, 15);
            this.label_row7.TabIndex = 34;
            this.label_row7.Text = "7";
            // 
            // label_row6
            // 
            this.label_row6.AutoSize = true;
            this.label_row6.Location = new System.Drawing.Point(138, 155);
            this.label_row6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_row6.Name = "label_row6";
            this.label_row6.Size = new System.Drawing.Size(14, 15);
            this.label_row6.TabIndex = 33;
            this.label_row6.Text = "6";
            // 
            // label_row5
            // 
            this.label_row5.AutoSize = true;
            this.label_row5.Location = new System.Drawing.Point(138, 135);
            this.label_row5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_row5.Name = "label_row5";
            this.label_row5.Size = new System.Drawing.Size(14, 15);
            this.label_row5.TabIndex = 32;
            this.label_row5.Text = "5";
            // 
            // label_row4
            // 
            this.label_row4.AutoSize = true;
            this.label_row4.Location = new System.Drawing.Point(138, 116);
            this.label_row4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_row4.Name = "label_row4";
            this.label_row4.Size = new System.Drawing.Size(14, 15);
            this.label_row4.TabIndex = 31;
            this.label_row4.Text = "4";
            // 
            // label_row3
            // 
            this.label_row3.AutoSize = true;
            this.label_row3.Location = new System.Drawing.Point(138, 98);
            this.label_row3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_row3.Name = "label_row3";
            this.label_row3.Size = new System.Drawing.Size(14, 15);
            this.label_row3.TabIndex = 30;
            this.label_row3.Text = "3";
            // 
            // label_row2
            // 
            this.label_row2.AutoSize = true;
            this.label_row2.Location = new System.Drawing.Point(138, 79);
            this.label_row2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_row2.Name = "label_row2";
            this.label_row2.Size = new System.Drawing.Size(14, 15);
            this.label_row2.TabIndex = 29;
            this.label_row2.Text = "2";
            // 
            // label_row1
            // 
            this.label_row1.AutoSize = true;
            this.label_row1.Location = new System.Drawing.Point(138, 61);
            this.label_row1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_row1.Name = "label_row1";
            this.label_row1.Size = new System.Drawing.Size(14, 15);
            this.label_row1.TabIndex = 28;
            this.label_row1.Text = "1";
            // 
            // label_row0
            // 
            this.label_row0.AutoSize = true;
            this.label_row0.Location = new System.Drawing.Point(138, 42);
            this.label_row0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_row0.Name = "label_row0";
            this.label_row0.Size = new System.Drawing.Size(14, 15);
            this.label_row0.TabIndex = 27;
            this.label_row0.Text = "0";
            // 
            // progressBar_Comm
            // 
            this.progressBar_Comm.Location = new System.Drawing.Point(10, 22);
            this.progressBar_Comm.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.progressBar_Comm.Name = "progressBar_Comm";
            this.progressBar_Comm.Size = new System.Drawing.Size(61, 14);
            this.progressBar_Comm.TabIndex = 26;
            this.progressBar_Comm.Visible = false;
            // 
            // Button_loadTxtFile
            // 
            this.Button_loadTxtFile.Font = new System.Drawing.Font("Courier New", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_loadTxtFile.Location = new System.Drawing.Point(10, 242);
            this.Button_loadTxtFile.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Button_loadTxtFile.Name = "Button_loadTxtFile";
            this.Button_loadTxtFile.Size = new System.Drawing.Size(74, 41);
            this.Button_loadTxtFile.TabIndex = 20;
            this.Button_loadTxtFile.Text = "载入TXT文件";
            this.Button_loadTxtFile.UseVisualStyleBackColor = true;
            // 
            // Button_flash
            // 
            this.Button_flash.Font = new System.Drawing.Font("Courier New", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_flash.Location = new System.Drawing.Point(9, 142);
            this.Button_flash.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Button_flash.Name = "Button_flash";
            this.Button_flash.Size = new System.Drawing.Size(74, 28);
            this.Button_flash.TabIndex = 18;
            this.Button_flash.Text = "擦除flash";
            this.Button_flash.UseVisualStyleBackColor = true;
            // 
            // Button_DebugEn
            // 
            this.Button_DebugEn.Font = new System.Drawing.Font("Courier New", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_DebugEn.Location = new System.Drawing.Point(10, 347);
            this.Button_DebugEn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Button_DebugEn.Name = "Button_DebugEn";
            this.Button_DebugEn.Size = new System.Drawing.Size(74, 36);
            this.Button_DebugEn.TabIndex = 21;
            this.Button_DebugEn.Text = "打印信息 开关";
            this.Button_DebugEn.UseVisualStyleBackColor = true;
            // 
            // richTextBox_readData
            // 
            this.richTextBox_readData.Location = new System.Drawing.Point(202, 39);
            this.richTextBox_readData.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.richTextBox_readData.Name = "richTextBox_readData";
            this.richTextBox_readData.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_readData.Size = new System.Drawing.Size(412, 305);
            this.richTextBox_readData.TabIndex = 27;
            this.richTextBox_readData.Text = "";
            // 
            // Button_loadBinaryFile
            // 
            this.Button_loadBinaryFile.Font = new System.Drawing.Font("Courier New", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_loadBinaryFile.Location = new System.Drawing.Point(10, 196);
            this.Button_loadBinaryFile.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Button_loadBinaryFile.Name = "Button_loadBinaryFile";
            this.Button_loadBinaryFile.Size = new System.Drawing.Size(74, 41);
            this.Button_loadBinaryFile.TabIndex = 19;
            this.Button_loadBinaryFile.Text = "载入HEX文件";
            this.Button_loadBinaryFile.UseVisualStyleBackColor = true;
            // 
            // label_totalLinesCount
            // 
            this.label_totalLinesCount.AutoSize = true;
            this.label_totalLinesCount.Font = new System.Drawing.Font("Courier New", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalLinesCount.Location = new System.Drawing.Point(88, 18);
            this.label_totalLinesCount.Name = "label_totalLinesCount";
            this.label_totalLinesCount.Size = new System.Drawing.Size(35, 12);
            this.label_totalLinesCount.TabIndex = 19;
            this.label_totalLinesCount.Text = "共0行";
            // 
            // richTextBox_paras
            // 
            this.richTextBox_paras.Location = new System.Drawing.Point(93, 39);
            this.richTextBox_paras.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.richTextBox_paras.Name = "richTextBox_paras";
            this.richTextBox_paras.Size = new System.Drawing.Size(38, 344);
            this.richTextBox_paras.TabIndex = 26;
            this.richTextBox_paras.Text = "";
            // 
            // Button_writeParas
            // 
            this.Button_writeParas.Enabled = false;
            this.Button_writeParas.Font = new System.Drawing.Font("Courier New", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_writeParas.Location = new System.Drawing.Point(8, 84);
            this.Button_writeParas.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Button_writeParas.Name = "Button_writeParas";
            this.Button_writeParas.Size = new System.Drawing.Size(74, 28);
            this.Button_writeParas.TabIndex = 17;
            this.Button_writeParas.Text = "写-数据";
            this.Button_writeParas.UseVisualStyleBackColor = true;
            // 
            // Button_readParas
            // 
            this.Button_readParas.Enabled = false;
            this.Button_readParas.Font = new System.Drawing.Font("Courier New", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_readParas.Location = new System.Drawing.Point(8, 48);
            this.Button_readParas.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Button_readParas.Name = "Button_readParas";
            this.Button_readParas.Size = new System.Drawing.Size(74, 28);
            this.Button_readParas.TabIndex = 16;
            this.Button_readParas.Text = "读-数据";
            this.Button_readParas.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Button_SelfDefine);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_addrLL);
            this.groupBox1.Controls.Add(this.textBox_addrLH);
            this.groupBox1.Controls.Add(this.textBox_addrHL);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_dataLength);
            this.groupBox1.Controls.Add(this.label_dataLength);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_type);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_timeout);
            this.groupBox1.Controls.Add(this.textBox_timeout);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_addr);
            this.groupBox1.Controls.Add(this.textBox_addrHH);
            this.groupBox1.Controls.Add(this.label_length);
            this.groupBox1.Controls.Add(this.textBox_length);
            this.groupBox1.Location = new System.Drawing.Point(13, 129);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox1.Size = new System.Drawing.Size(630, 94);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作信息";
            // 
            // Button_SelfDefine
            // 
            this.Button_SelfDefine.Enabled = false;
            this.Button_SelfDefine.Location = new System.Drawing.Point(553, 16);
            this.Button_SelfDefine.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Button_SelfDefine.Name = "Button_SelfDefine";
            this.Button_SelfDefine.Size = new System.Drawing.Size(66, 63);
            this.Button_SelfDefine.TabIndex = 15;
            this.Button_SelfDefine.Text = "自定义";
            this.Button_SelfDefine.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 15);
            this.label8.TabIndex = 34;
            this.label8.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "-";
            // 
            // textBox_addrLL
            // 
            this.textBox_addrLL.Location = new System.Drawing.Point(232, 25);
            this.textBox_addrLL.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox_addrLL.Name = "textBox_addrLL";
            this.textBox_addrLL.Size = new System.Drawing.Size(31, 21);
            this.textBox_addrLL.TabIndex = 10;
            this.textBox_addrLL.Text = "00";
            // 
            // textBox_addrLH
            // 
            this.textBox_addrLH.Location = new System.Drawing.Point(183, 25);
            this.textBox_addrLH.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox_addrLH.Name = "textBox_addrLH";
            this.textBox_addrLH.Size = new System.Drawing.Size(31, 21);
            this.textBox_addrLH.TabIndex = 9;
            this.textBox_addrLH.Text = "00";
            // 
            // textBox_addrHL
            // 
            this.textBox_addrHL.Location = new System.Drawing.Point(132, 25);
            this.textBox_addrHL.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox_addrHL.Name = "textBox_addrHL";
            this.textBox_addrHL.Size = new System.Drawing.Size(31, 21);
            this.textBox_addrHL.TabIndex = 8;
            this.textBox_addrHL.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "(Hex)";
            // 
            // textBox_dataLength
            // 
            this.textBox_dataLength.Location = new System.Drawing.Point(82, 56);
            this.textBox_dataLength.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox_dataLength.Name = "textBox_dataLength";
            this.textBox_dataLength.Size = new System.Drawing.Size(69, 21);
            this.textBox_dataLength.TabIndex = 11;
            this.textBox_dataLength.Text = "1";
            // 
            // label_dataLength
            // 
            this.label_dataLength.AutoSize = true;
            this.label_dataLength.Location = new System.Drawing.Point(5, 60);
            this.label_dataLength.Name = "label_dataLength";
            this.label_dataLength.Size = new System.Drawing.Size(77, 15);
            this.label_dataLength.TabIndex = 26;
            this.label_dataLength.Text = "数据长度：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "(Hex)";
            // 
            // textBox_type
            // 
            this.textBox_type.Location = new System.Drawing.Point(279, 56);
            this.textBox_type.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox_type.Name = "textBox_type";
            this.textBox_type.Size = new System.Drawing.Size(69, 21);
            this.textBox_type.TabIndex = 12;
            this.textBox_type.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "(Hex)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "ms";
            // 
            // label_timeout
            // 
            this.label_timeout.AutoSize = true;
            this.label_timeout.Location = new System.Drawing.Point(334, 28);
            this.label_timeout.Name = "label_timeout";
            this.label_timeout.Size = new System.Drawing.Size(63, 15);
            this.label_timeout.TabIndex = 20;
            this.label_timeout.Text = "包间隔：";
            // 
            // textBox_timeout
            // 
            this.textBox_timeout.Location = new System.Drawing.Point(397, 26);
            this.textBox_timeout.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox_timeout.Name = "textBox_timeout";
            this.textBox_timeout.Size = new System.Drawing.Size(52, 21);
            this.textBox_timeout.TabIndex = 13;
            this.textBox_timeout.Text = "2000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "操作方式：";
            // 
            // label_addr
            // 
            this.label_addr.AutoSize = true;
            this.label_addr.Location = new System.Drawing.Point(7, 28);
            this.label_addr.Name = "label_addr";
            this.label_addr.Size = new System.Drawing.Size(77, 15);
            this.label_addr.TabIndex = 13;
            this.label_addr.Text = "起始地址：";
            // 
            // textBox_addrHH
            // 
            this.textBox_addrHH.Location = new System.Drawing.Point(84, 25);
            this.textBox_addrHH.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox_addrHH.Name = "textBox_addrHH";
            this.textBox_addrHH.Size = new System.Drawing.Size(31, 21);
            this.textBox_addrHH.TabIndex = 7;
            this.textBox_addrHH.Text = "00";
            // 
            // label_length
            // 
            this.label_length.AutoSize = true;
            this.label_length.Location = new System.Drawing.Point(404, 60);
            this.label_length.Name = "label_length";
            this.label_length.Size = new System.Drawing.Size(77, 15);
            this.label_length.TabIndex = 11;
            this.label_length.Text = "单包长度：";
            // 
            // textBox_length
            // 
            this.textBox_length.Location = new System.Drawing.Point(481, 56);
            this.textBox_length.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox_length.Name = "textBox_length";
            this.textBox_length.Size = new System.Drawing.Size(52, 21);
            this.textBox_length.TabIndex = 14;
            this.textBox_length.Text = "256";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RadioButton_StepTest);
            this.groupBox3.Controls.Add(this.RadioButton_Test);
            this.groupBox3.Controls.Add(this.RadioButton_Iram);
            this.groupBox3.Controls.Add(this.RadioButton_cmd);
            this.groupBox3.Controls.Add(this.RadioButton_flash);
            this.groupBox3.Controls.Add(this.RadioButton_inter);
            this.groupBox3.Location = new System.Drawing.Point(13, 233);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Size = new System.Drawing.Size(630, 49);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作类型";
            // 
            // RadioButton_StepTest
            // 
            this.RadioButton_StepTest.AutoSize = true;
            this.RadioButton_StepTest.Location = new System.Drawing.Point(537, 19);
            this.RadioButton_StepTest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RadioButton_StepTest.Name = "RadioButton_StepTest";
            this.RadioButton_StepTest.Size = new System.Drawing.Size(81, 19);
            this.RadioButton_StepTest.TabIndex = 5;
            this.RadioButton_StepTest.TabStop = true;
            this.RadioButton_StepTest.Text = "单步调试";
            this.RadioButton_StepTest.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Test
            // 
            this.RadioButton_Test.AutoSize = true;
            this.RadioButton_Test.Location = new System.Drawing.Point(423, 19);
            this.RadioButton_Test.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RadioButton_Test.Name = "RadioButton_Test";
            this.RadioButton_Test.Size = new System.Drawing.Size(81, 19);
            this.RadioButton_Test.TabIndex = 4;
            this.RadioButton_Test.TabStop = true;
            this.RadioButton_Test.Text = "点屏测试";
            this.RadioButton_Test.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Iram
            // 
            this.RadioButton_Iram.AutoSize = true;
            this.RadioButton_Iram.Location = new System.Drawing.Point(216, 19);
            this.RadioButton_Iram.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RadioButton_Iram.Name = "RadioButton_Iram";
            this.RadioButton_Iram.Size = new System.Drawing.Size(53, 19);
            this.RadioButton_Iram.TabIndex = 3;
            this.RadioButton_Iram.TabStop = true;
            this.RadioButton_Iram.Text = "IRAM";
            this.RadioButton_Iram.UseVisualStyleBackColor = true;
            // 
            // RadioButton_cmd
            // 
            this.RadioButton_cmd.AutoSize = true;
            this.RadioButton_cmd.Location = new System.Drawing.Point(297, 19);
            this.RadioButton_cmd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RadioButton_cmd.Name = "RadioButton_cmd";
            this.RadioButton_cmd.Size = new System.Drawing.Size(95, 19);
            this.RadioButton_cmd.TabIndex = 2;
            this.RadioButton_cmd.Text = "自定义命令";
            this.RadioButton_cmd.UseVisualStyleBackColor = true;
            // 
            // RadioButton_flash
            // 
            this.RadioButton_flash.AutoSize = true;
            this.RadioButton_flash.Location = new System.Drawing.Point(121, 19);
            this.RadioButton_flash.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RadioButton_flash.Name = "RadioButton_flash";
            this.RadioButton_flash.Size = new System.Drawing.Size(60, 19);
            this.RadioButton_flash.TabIndex = 1;
            this.RadioButton_flash.Text = "flash";
            this.RadioButton_flash.UseVisualStyleBackColor = true;
            // 
            // RadioButton_inter
            // 
            this.RadioButton_inter.AutoSize = true;
            this.RadioButton_inter.Checked = true;
            this.RadioButton_inter.Location = new System.Drawing.Point(9, 19);
            this.RadioButton_inter.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RadioButton_inter.Name = "RadioButton_inter";
            this.RadioButton_inter.Size = new System.Drawing.Size(81, 19);
            this.RadioButton_inter.TabIndex = 0;
            this.RadioButton_inter.TabStop = true;
            this.RadioButton_inter.Text = "内存空间";
            this.RadioButton_inter.UseVisualStyleBackColor = true;
            // 
            // gb6330Test
            // 
            this.gb6330Test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gb6330Test.Controls.Add(this.tabControl1);
            this.gb6330Test.Controls.Add(this.gbCommCfg);
            this.gb6330Test.Controls.Add(this.label42);
            this.gb6330Test.Controls.Add(this.rtbLogPrint1);
            this.gb6330Test.Controls.Add(this.btnClear);
            this.gb6330Test.Controls.Add(this.btnStop);
            this.gb6330Test.Controls.Add(this.rtbLogPrint);
            this.gb6330Test.Location = new System.Drawing.Point(681, 15);
            this.gb6330Test.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gb6330Test.Name = "gb6330Test";
            this.gb6330Test.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gb6330Test.Size = new System.Drawing.Size(682, 704);
            this.gb6330Test.TabIndex = 30;
            this.gb6330Test.TabStop = false;
            this.gb6330Test.Text = "P6330V200 Test";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpLvdsBertTest);
            this.tabControl1.Controls.Add(this.tbpSdramDllTrim);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tbpPhaseTest);
            this.tabControl1.Location = new System.Drawing.Point(7, 22);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(671, 390);
            this.tabControl1.TabIndex = 99;
            // 
            // tbpLvdsBertTest
            // 
            this.tbpLvdsBertTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbpLvdsBertTest.Controls.Add(this.btnPllLock);
            this.tbpLvdsBertTest.Controls.Add(this.cbVcoFreqHigh);
            this.tbpLvdsBertTest.Controls.Add(this.groupBox4);
            this.tbpLvdsBertTest.Controls.Add(this.btnOpenErrSwitch);
            this.tbpLvdsBertTest.Controls.Add(this.btnReadDefault);
            this.tbpLvdsBertTest.Controls.Add(this.btnLvdsBert);
            this.tbpLvdsBertTest.Controls.Add(this.btnClrAndReadErr);
            this.tbpLvdsBertTest.Controls.Add(this.btnWriteDefault);
            this.tbpLvdsBertTest.Controls.Add(this.btnFreqCfg);
            this.tbpLvdsBertTest.Controls.Add(this.cmbFreqSel);
            this.tbpLvdsBertTest.Controls.Add(this.gbRxClk);
            this.tbpLvdsBertTest.Controls.Add(this.label43);
            this.tbpLvdsBertTest.Controls.Add(this.gbRxPhase);
            this.tbpLvdsBertTest.Controls.Add(this.cbAllCaseSweep);
            this.tbpLvdsBertTest.Controls.Add(this.nudReadErrDelay);
            this.tbpLvdsBertTest.Controls.Add(this.cbStepDebugEn);
            this.tbpLvdsBertTest.Controls.Add(this.label39);
            this.tbpLvdsBertTest.Location = new System.Drawing.Point(4, 24);
            this.tbpLvdsBertTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpLvdsBertTest.Name = "tbpLvdsBertTest";
            this.tbpLvdsBertTest.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpLvdsBertTest.Size = new System.Drawing.Size(663, 362);
            this.tbpLvdsBertTest.TabIndex = 0;
            this.tbpLvdsBertTest.Text = "LVDS级联测试";
            // 
            // btnPllLock
            // 
            this.btnPllLock.BackColor = System.Drawing.SystemColors.Control;
            this.btnPllLock.ForeColor = System.Drawing.Color.Black;
            this.btnPllLock.Location = new System.Drawing.Point(596, 292);
            this.btnPllLock.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPllLock.Name = "btnPllLock";
            this.btnPllLock.Size = new System.Drawing.Size(52, 50);
            this.btnPllLock.TabIndex = 101;
            this.btnPllLock.Text = "PLL状态";
            this.btnPllLock.UseVisualStyleBackColor = false;
            // 
            // cbVcoFreqHigh
            // 
            this.cbVcoFreqHigh.AutoSize = true;
            this.cbVcoFreqHigh.Location = new System.Drawing.Point(416, 199);
            this.cbVcoFreqHigh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbVcoFreqHigh.Name = "cbVcoFreqHigh";
            this.cbVcoFreqHigh.Size = new System.Drawing.Size(82, 19);
            this.cbVcoFreqHigh.TabIndex = 100;
            this.cbVcoFreqHigh.Text = " VCO高频";
            this.cbVcoFreqHigh.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox4.Controls.Add(this.label41);
            this.groupBox4.Controls.Add(this.label40);
            this.groupBox4.Controls.Add(this.label46);
            this.groupBox4.Controls.Add(this.label66);
            this.groupBox4.Controls.Add(this.label44);
            this.groupBox4.Controls.Add(this.label67);
            this.groupBox4.Controls.Add(this.label45);
            this.groupBox4.Controls.Add(this.label68);
            this.groupBox4.Controls.Add(this.label47);
            this.groupBox4.Controls.Add(this.label69);
            this.groupBox4.Controls.Add(this.label48);
            this.groupBox4.Controls.Add(this.label56);
            this.groupBox4.Controls.Add(this.label49);
            this.groupBox4.Controls.Add(this.label57);
            this.groupBox4.Controls.Add(this.label50);
            this.groupBox4.Controls.Add(this.label58);
            this.groupBox4.Controls.Add(this.label53);
            this.groupBox4.Controls.Add(this.label59);
            this.groupBox4.Controls.Add(this.label52);
            this.groupBox4.Controls.Add(this.label60);
            this.groupBox4.Controls.Add(this.label51);
            this.groupBox4.Controls.Add(this.label61);
            this.groupBox4.Controls.Add(this.label54);
            this.groupBox4.Controls.Add(this.label62);
            this.groupBox4.Controls.Add(this.label55);
            this.groupBox4.Controls.Add(this.label63);
            this.groupBox4.Controls.Add(this.label65);
            this.groupBox4.Controls.Add(this.label64);
            this.groupBox4.Location = new System.Drawing.Point(7, 166);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(402, 182);
            this.groupBox4.TabIndex = 99;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "相位对照表";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.ForeColor = System.Drawing.Color.Gray;
            this.label41.Location = new System.Drawing.Point(139, 21);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(91, 15);
            this.label41.TabIndex = 64;
            this.label41.Text = "RX时钟相位：";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.ForeColor = System.Drawing.Color.Gray;
            this.label40.Location = new System.Drawing.Point(7, 21);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(105, 15);
            this.label40.TabIndex = 63;
            this.label40.Text = "数据采样时钟：";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.ForeColor = System.Drawing.Color.Gray;
            this.label46.Location = new System.Drawing.Point(139, 89);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(70, 15);
            this.label46.TabIndex = 69;
            this.label46.Text = "0x92-135°";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.ForeColor = System.Drawing.Color.Gray;
            this.label66.Location = new System.Drawing.Point(10, 119);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(112, 15);
            this.label66.TabIndex = 95;
            this.label66.Text = "Addr:0x8E03/4/8";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.ForeColor = System.Drawing.Color.Gray;
            this.label44.Location = new System.Drawing.Point(139, 59);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(63, 15);
            this.label44.TabIndex = 67;
            this.label44.Text = "0x82-45°";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.ForeColor = System.Drawing.Color.Gray;
            this.label67.Location = new System.Drawing.Point(10, 156);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(98, 15);
            this.label67.TabIndex = 94;
            this.label67.Text = "高:0x03/54/4B";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.ForeColor = System.Drawing.Color.Gray;
            this.label45.Location = new System.Drawing.Point(139, 74);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(63, 15);
            this.label45.TabIndex = 68;
            this.label45.Text = "0x8A-90°";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.ForeColor = System.Drawing.Color.Blue;
            this.label68.Location = new System.Drawing.Point(10, 140);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(98, 15);
            this.label68.TabIndex = 93;
            this.label68.Text = "低:0x03/2A/49";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.ForeColor = System.Drawing.Color.Gray;
            this.label47.Location = new System.Drawing.Point(139, 104);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(70, 15);
            this.label47.TabIndex = 70;
            this.label47.Text = "0x9A-180°";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.ForeColor = System.Drawing.Color.Gray;
            this.label69.Location = new System.Drawing.Point(7, 99);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(70, 15);
            this.label69.TabIndex = 92;
            this.label69.Text = "VCO频率：";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.ForeColor = System.Drawing.Color.Blue;
            this.label48.Location = new System.Drawing.Point(139, 119);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(70, 15);
            this.label48.TabIndex = 71;
            this.label48.Text = "0xA2-225°";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.ForeColor = System.Drawing.Color.Gray;
            this.label56.Location = new System.Drawing.Point(253, 40);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(126, 15);
            this.label56.TabIndex = 88;
            this.label56.Text = "Addr:0x8E0F/10/11";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.ForeColor = System.Drawing.Color.Gray;
            this.label49.Location = new System.Drawing.Point(10, 58);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(56, 15);
            this.label49.TabIndex = 72;
            this.label49.Text = "0x49-0°";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.ForeColor = System.Drawing.Color.Blue;
            this.label57.Location = new System.Drawing.Point(253, 162);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(119, 15);
            this.label57.TabIndex = 87;
            this.label57.Text = "0x2F/3F/E0-420ps";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.ForeColor = System.Drawing.Color.Gray;
            this.label50.Location = new System.Drawing.Point(10, 74);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(70, 15);
            this.label50.TabIndex = 73;
            this.label50.Text = "0x48-180°";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.ForeColor = System.Drawing.Color.Blue;
            this.label58.Location = new System.Drawing.Point(253, 148);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(119, 15);
            this.label58.TabIndex = 86;
            this.label58.Text = "0x2E/36/C0-360ps";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.ForeColor = System.Drawing.Color.Blue;
            this.label53.Location = new System.Drawing.Point(139, 134);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(70, 15);
            this.label53.TabIndex = 74;
            this.label53.Text = "0xAA-270°";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.ForeColor = System.Drawing.Color.Blue;
            this.label59.Location = new System.Drawing.Point(253, 132);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(119, 15);
            this.label59.TabIndex = 85;
            this.label59.Text = "0x2D/2D/A0-300ps";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.ForeColor = System.Drawing.Color.Blue;
            this.label52.Location = new System.Drawing.Point(139, 149);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(70, 15);
            this.label52.TabIndex = 75;
            this.label52.Text = "0xB2-315°";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.ForeColor = System.Drawing.Color.Blue;
            this.label60.Location = new System.Drawing.Point(253, 118);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(119, 15);
            this.label60.TabIndex = 84;
            this.label60.Text = "0x2C/24/80-240ps";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.ForeColor = System.Drawing.Color.Blue;
            this.label51.Location = new System.Drawing.Point(139, 164);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(70, 15);
            this.label51.TabIndex = 76;
            this.label51.Text = "0xBA-360°";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.ForeColor = System.Drawing.Color.Blue;
            this.label61.Location = new System.Drawing.Point(253, 102);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(119, 15);
            this.label61.TabIndex = 83;
            this.label61.Text = "0x2B/1B/60-180ps";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.ForeColor = System.Drawing.Color.Gray;
            this.label54.Location = new System.Drawing.Point(10, 41);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(84, 15);
            this.label54.TabIndex = 77;
            this.label54.Text = "Addr:0x8E08";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.ForeColor = System.Drawing.Color.Blue;
            this.label62.Location = new System.Drawing.Point(253, 88);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(119, 15);
            this.label62.TabIndex = 82;
            this.label62.Text = "0x2A/12/40-120ps";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.ForeColor = System.Drawing.Color.Gray;
            this.label55.Location = new System.Drawing.Point(139, 41);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(84, 15);
            this.label55.TabIndex = 78;
            this.label55.Text = "Addr:0x8E02";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.ForeColor = System.Drawing.Color.Blue;
            this.label63.Location = new System.Drawing.Point(253, 72);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(112, 15);
            this.label63.TabIndex = 81;
            this.label63.Text = "0x29/09/20-60ps";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.ForeColor = System.Drawing.Color.Gray;
            this.label65.Location = new System.Drawing.Point(253, 20);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(91, 15);
            this.label65.TabIndex = 79;
            this.label65.Text = "RX数据相位：";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.ForeColor = System.Drawing.Color.Blue;
            this.label64.Location = new System.Drawing.Point(253, 58);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(105, 15);
            this.label64.TabIndex = 80;
            this.label64.Text = "0x28/00/00-0ps";
            // 
            // btnOpenErrSwitch
            // 
            this.btnOpenErrSwitch.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenErrSwitch.ForeColor = System.Drawing.Color.Black;
            this.btnOpenErrSwitch.Location = new System.Drawing.Point(555, 4);
            this.btnOpenErrSwitch.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnOpenErrSwitch.Name = "btnOpenErrSwitch";
            this.btnOpenErrSwitch.Size = new System.Drawing.Size(52, 50);
            this.btnOpenErrSwitch.TabIndex = 97;
            this.btnOpenErrSwitch.Text = "误码开关";
            this.btnOpenErrSwitch.UseVisualStyleBackColor = false;
            // 
            // btnReadDefault
            // 
            this.btnReadDefault.BackColor = System.Drawing.SystemColors.Control;
            this.btnReadDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReadDefault.Location = new System.Drawing.Point(498, 4);
            this.btnReadDefault.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnReadDefault.Name = "btnReadDefault";
            this.btnReadDefault.Size = new System.Drawing.Size(52, 50);
            this.btnReadDefault.TabIndex = 57;
            this.btnReadDefault.Text = "一键读取";
            this.btnReadDefault.UseVisualStyleBackColor = false;
            // 
            // btnLvdsBert
            // 
            this.btnLvdsBert.Font = new System.Drawing.Font("Courier New", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvdsBert.Location = new System.Drawing.Point(416, 280);
            this.btnLvdsBert.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnLvdsBert.Name = "btnLvdsBert";
            this.btnLvdsBert.Size = new System.Drawing.Size(138, 68);
            this.btnLvdsBert.TabIndex = 22;
            this.btnLvdsBert.Text = "LVDS级联测试";
            this.btnLvdsBert.UseVisualStyleBackColor = true;
            // 
            // btnClrAndReadErr
            // 
            this.btnClrAndReadErr.BackColor = System.Drawing.SystemColors.Control;
            this.btnClrAndReadErr.ForeColor = System.Drawing.Color.Black;
            this.btnClrAndReadErr.Location = new System.Drawing.Point(555, 59);
            this.btnClrAndReadErr.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnClrAndReadErr.Name = "btnClrAndReadErr";
            this.btnClrAndReadErr.Size = new System.Drawing.Size(52, 50);
            this.btnClrAndReadErr.TabIndex = 96;
            this.btnClrAndReadErr.Text = "读取误码";
            this.btnClrAndReadErr.UseVisualStyleBackColor = false;
            // 
            // btnWriteDefault
            // 
            this.btnWriteDefault.BackColor = System.Drawing.SystemColors.Control;
            this.btnWriteDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnWriteDefault.Location = new System.Drawing.Point(498, 59);
            this.btnWriteDefault.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnWriteDefault.Name = "btnWriteDefault";
            this.btnWriteDefault.Size = new System.Drawing.Size(52, 50);
            this.btnWriteDefault.TabIndex = 58;
            this.btnWriteDefault.Text = "一键配置";
            this.btnWriteDefault.UseVisualStyleBackColor = false;
            // 
            // btnFreqCfg
            // 
            this.btnFreqCfg.BackColor = System.Drawing.SystemColors.Control;
            this.btnFreqCfg.ForeColor = System.Drawing.Color.Green;
            this.btnFreqCfg.Location = new System.Drawing.Point(597, 111);
            this.btnFreqCfg.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnFreqCfg.Name = "btnFreqCfg";
            this.btnFreqCfg.Size = new System.Drawing.Size(52, 50);
            this.btnFreqCfg.TabIndex = 91;
            this.btnFreqCfg.Text = "配置频率";
            this.btnFreqCfg.UseVisualStyleBackColor = false;
            // 
            // cmbFreqSel
            // 
            this.cmbFreqSel.FormattingEnabled = true;
            this.cmbFreqSel.Items.AddRange(new object[] {
            "50",
            "100",
            "125",
            "148.5",
            "150",
            "155",
            "160",
            "164.9",
            "165.0",
            "165.06",
            "165.1",
            "166",
            "171"});
            this.cmbFreqSel.Location = new System.Drawing.Point(504, 132);
            this.cmbFreqSel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFreqSel.Name = "cmbFreqSel";
            this.cmbFreqSel.Size = new System.Drawing.Size(82, 23);
            this.cmbFreqSel.TabIndex = 89;
            this.cmbFreqSel.Text = "165.0";
            // 
            // gbRxClk
            // 
            this.gbRxClk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbRxClk.Controls.Add(this.label72);
            this.gbRxClk.Controls.Add(this.tbVcoFreqCfg04);
            this.gbRxClk.Controls.Add(this.label70);
            this.gbRxClk.Controls.Add(this.label71);
            this.gbRxClk.Controls.Add(this.tbVcoFreqCfg03);
            this.gbRxClk.Controls.Add(this.tbDataClkPhase);
            this.gbRxClk.Controls.Add(this.label37);
            this.gbRxClk.Controls.Add(this.label36);
            this.gbRxClk.Controls.Add(this.label26);
            this.gbRxClk.Controls.Add(this.label27);
            this.gbRxClk.Controls.Add(this.tbVcoFreqCfg08);
            this.gbRxClk.Controls.Add(this.tbRxClkPhase);
            this.gbRxClk.Controls.Add(this.label35);
            this.gbRxClk.Controls.Add(this.label28);
            this.gbRxClk.Controls.Add(this.tbRxClkPhaseCfg);
            this.gbRxClk.Location = new System.Drawing.Point(7, 6);
            this.gbRxClk.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbRxClk.Name = "gbRxClk";
            this.gbRxClk.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbRxClk.Size = new System.Drawing.Size(273, 155);
            this.gbRxClk.TabIndex = 53;
            this.gbRxClk.TabStop = false;
            this.gbRxClk.Text = "采样时钟/RX时钟相位";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(98, 98);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(49, 15);
            this.label72.TabIndex = 60;
            this.label72.Text = "0x8e04";
            // 
            // tbVcoFreqCfg04
            // 
            this.tbVcoFreqCfg04.Location = new System.Drawing.Point(160, 94);
            this.tbVcoFreqCfg04.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbVcoFreqCfg04.Name = "tbVcoFreqCfg04";
            this.tbVcoFreqCfg04.Size = new System.Drawing.Size(46, 21);
            this.tbVcoFreqCfg04.TabIndex = 57;
            this.tbVcoFreqCfg04.Text = "0x2A";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(98, 69);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(49, 15);
            this.label70.TabIndex = 56;
            this.label70.Text = "0x8e03";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(8, 70);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(70, 15);
            this.label71.TabIndex = 54;
            this.label71.Text = "VCO频率：";
            // 
            // tbVcoFreqCfg03
            // 
            this.tbVcoFreqCfg03.Location = new System.Drawing.Point(160, 65);
            this.tbVcoFreqCfg03.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbVcoFreqCfg03.Name = "tbVcoFreqCfg03";
            this.tbVcoFreqCfg03.Size = new System.Drawing.Size(46, 21);
            this.tbVcoFreqCfg03.TabIndex = 53;
            this.tbVcoFreqCfg03.Text = "0x03";
            // 
            // tbDataClkPhase
            // 
            this.tbDataClkPhase.Location = new System.Drawing.Point(217, 122);
            this.tbDataClkPhase.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbDataClkPhase.Name = "tbDataClkPhase";
            this.tbDataClkPhase.Size = new System.Drawing.Size(46, 21);
            this.tbDataClkPhase.TabIndex = 32;
            this.tbDataClkPhase.Text = "0°";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(107, 18);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(35, 15);
            this.label37.TabIndex = 51;
            this.label37.Text = "地址";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(98, 40);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(49, 15);
            this.label36.TabIndex = 52;
            this.label36.Text = "0x8e02";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(154, 16);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(49, 15);
            this.label26.TabIndex = 34;
            this.label26.Text = "配置值";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(211, 16);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(49, 15);
            this.label27.TabIndex = 35;
            this.label27.Text = "相位值";
            // 
            // tbVcoFreqCfg08
            // 
            this.tbVcoFreqCfg08.Location = new System.Drawing.Point(160, 122);
            this.tbVcoFreqCfg08.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbVcoFreqCfg08.Name = "tbVcoFreqCfg08";
            this.tbVcoFreqCfg08.Size = new System.Drawing.Size(46, 21);
            this.tbVcoFreqCfg08.TabIndex = 30;
            this.tbVcoFreqCfg08.Text = "0x49";
            // 
            // tbRxClkPhase
            // 
            this.tbRxClkPhase.Location = new System.Drawing.Point(217, 36);
            this.tbRxClkPhase.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbRxClkPhase.Name = "tbRxClkPhase";
            this.tbRxClkPhase.Size = new System.Drawing.Size(46, 21);
            this.tbRxClkPhase.TabIndex = 38;
            this.tbRxClkPhase.Text = "45°";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(98, 126);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(49, 15);
            this.label35.TabIndex = 51;
            this.label35.Text = "0x8e08";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(8, 41);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(70, 15);
            this.label28.TabIndex = 37;
            this.label28.Text = "RXC相位：";
            // 
            // tbRxClkPhaseCfg
            // 
            this.tbRxClkPhaseCfg.Location = new System.Drawing.Point(160, 36);
            this.tbRxClkPhaseCfg.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbRxClkPhaseCfg.Name = "tbRxClkPhaseCfg";
            this.tbRxClkPhaseCfg.Size = new System.Drawing.Size(46, 21);
            this.tbRxClkPhaseCfg.TabIndex = 36;
            this.tbRxClkPhaseCfg.Text = "0xA2";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(503, 110);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(56, 15);
            this.label43.TabIndex = 90;
            this.label43.Text = "F(MHz):";
            // 
            // gbRxPhase
            // 
            this.gbRxPhase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbRxPhase.Controls.Add(this.tbRxDataPhase);
            this.gbRxPhase.Controls.Add(this.label34);
            this.gbRxPhase.Controls.Add(this.label33);
            this.gbRxPhase.Controls.Add(this.label32);
            this.gbRxPhase.Controls.Add(this.label31);
            this.gbRxPhase.Controls.Add(this.label30);
            this.gbRxPhase.Controls.Add(this.label29);
            this.gbRxPhase.Controls.Add(this.tbRxDataPhaseCfg_2);
            this.gbRxPhase.Controls.Add(this.tbRxDataPhaseCfg_3);
            this.gbRxPhase.Controls.Add(this.tbRxDataPhaseCfg_1);
            this.gbRxPhase.Location = new System.Drawing.Point(282, 6);
            this.gbRxPhase.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbRxPhase.Name = "gbRxPhase";
            this.gbRxPhase.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gbRxPhase.Size = new System.Drawing.Size(213, 155);
            this.gbRxPhase.TabIndex = 45;
            this.gbRxPhase.TabStop = false;
            this.gbRxPhase.Text = "RX数据相位";
            // 
            // tbRxDataPhase
            // 
            this.tbRxDataPhase.Location = new System.Drawing.Point(136, 82);
            this.tbRxDataPhase.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbRxDataPhase.Name = "tbRxDataPhase";
            this.tbRxDataPhase.Size = new System.Drawing.Size(59, 21);
            this.tbRxDataPhase.TabIndex = 50;
            this.tbRxDataPhase.Text = "100ps";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(135, 26);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(49, 15);
            this.label34.TabIndex = 49;
            this.label34.Text = "相位值";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(66, 26);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(49, 15);
            this.label33.TabIndex = 48;
            this.label33.Text = "配置值";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(15, 26);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(35, 15);
            this.label32.TabIndex = 46;
            this.label32.Text = "地址";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(9, 118);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(49, 15);
            this.label31.TabIndex = 47;
            this.label31.Text = "0x8e11";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(9, 86);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(49, 15);
            this.label30.TabIndex = 46;
            this.label30.Text = "0x8e10";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(9, 56);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(49, 15);
            this.label29.TabIndex = 45;
            this.label29.Text = "0x8e0f";
            // 
            // tbRxDataPhaseCfg_2
            // 
            this.tbRxDataPhaseCfg_2.Location = new System.Drawing.Point(71, 82);
            this.tbRxDataPhaseCfg_2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbRxDataPhaseCfg_2.Name = "tbRxDataPhaseCfg_2";
            this.tbRxDataPhaseCfg_2.Size = new System.Drawing.Size(46, 21);
            this.tbRxDataPhaseCfg_2.TabIndex = 42;
            this.tbRxDataPhaseCfg_2.Text = "0x00";
            // 
            // tbRxDataPhaseCfg_3
            // 
            this.tbRxDataPhaseCfg_3.Location = new System.Drawing.Point(71, 114);
            this.tbRxDataPhaseCfg_3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbRxDataPhaseCfg_3.Name = "tbRxDataPhaseCfg_3";
            this.tbRxDataPhaseCfg_3.Size = new System.Drawing.Size(46, 21);
            this.tbRxDataPhaseCfg_3.TabIndex = 44;
            this.tbRxDataPhaseCfg_3.Text = "0x00";
            // 
            // tbRxDataPhaseCfg_1
            // 
            this.tbRxDataPhaseCfg_1.Location = new System.Drawing.Point(71, 52);
            this.tbRxDataPhaseCfg_1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbRxDataPhaseCfg_1.Name = "tbRxDataPhaseCfg_1";
            this.tbRxDataPhaseCfg_1.Size = new System.Drawing.Size(46, 21);
            this.tbRxDataPhaseCfg_1.TabIndex = 40;
            this.tbRxDataPhaseCfg_1.Text = "0x28";
            // 
            // cbAllCaseSweep
            // 
            this.cbAllCaseSweep.AutoSize = true;
            this.cbAllCaseSweep.Checked = true;
            this.cbAllCaseSweep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAllCaseSweep.Enabled = false;
            this.cbAllCaseSweep.Location = new System.Drawing.Point(416, 224);
            this.cbAllCaseSweep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAllCaseSweep.Name = "cbAllCaseSweep";
            this.cbAllCaseSweep.Size = new System.Drawing.Size(96, 19);
            this.cbAllCaseSweep.TabIndex = 62;
            this.cbAllCaseSweep.Text = "全配置扫描";
            this.cbAllCaseSweep.UseVisualStyleBackColor = true;
            // 
            // nudReadErrDelay
            // 
            this.nudReadErrDelay.Location = new System.Drawing.Point(582, 171);
            this.nudReadErrDelay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudReadErrDelay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudReadErrDelay.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudReadErrDelay.Name = "nudReadErrDelay";
            this.nudReadErrDelay.Size = new System.Drawing.Size(66, 21);
            this.nudReadErrDelay.TabIndex = 60;
            this.nudReadErrDelay.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // cbStepDebugEn
            // 
            this.cbStepDebugEn.AutoSize = true;
            this.cbStepDebugEn.Enabled = false;
            this.cbStepDebugEn.Location = new System.Drawing.Point(416, 174);
            this.cbStepDebugEn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbStepDebugEn.Name = "cbStepDebugEn";
            this.cbStepDebugEn.Size = new System.Drawing.Size(82, 19);
            this.cbStepDebugEn.TabIndex = 56;
            this.cbStepDebugEn.Text = "单步使能";
            this.cbStepDebugEn.UseVisualStyleBackColor = true;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(516, 176);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(56, 15);
            this.label39.TabIndex = 59;
            this.label39.Text = "读误码:";
            // 
            // tbpSdramDllTrim
            // 
            this.tbpSdramDllTrim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbpSdramDllTrim.Controls.Add(this.btnSdramDllTest3);
            this.tbpSdramDllTrim.Controls.Add(this.btnSdramDllTest2);
            this.tbpSdramDllTrim.Controls.Add(this.cmbSelfTestPattern);
            this.tbpSdramDllTrim.Controls.Add(this.label73);
            this.tbpSdramDllTrim.Controls.Add(this.btnSelfTestPattern);
            this.tbpSdramDllTrim.Controls.Add(this.cbWriteChange);
            this.tbpSdramDllTrim.Controls.Add(this.nudIntervalDelay);
            this.tbpSdramDllTrim.Controls.Add(this.label25);
            this.tbpSdramDllTrim.Controls.Add(this.btnSdramDllTest1);
            this.tbpSdramDllTrim.Location = new System.Drawing.Point(4, 24);
            this.tbpSdramDllTrim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpSdramDllTrim.Name = "tbpSdramDllTrim";
            this.tbpSdramDllTrim.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpSdramDllTrim.Size = new System.Drawing.Size(663, 362);
            this.tbpSdramDllTrim.TabIndex = 1;
            this.tbpSdramDllTrim.Text = "SDRAM DLL";
            // 
            // btnSdramDllTest3
            // 
            this.btnSdramDllTest3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSdramDllTest3.Font = new System.Drawing.Font("Courier New", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSdramDllTest3.Location = new System.Drawing.Point(19, 164);
            this.btnSdramDllTest3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSdramDllTest3.Name = "btnSdramDllTest3";
            this.btnSdramDllTest3.Size = new System.Drawing.Size(105, 60);
            this.btnSdramDllTest3.TabIndex = 92;
            this.btnSdramDllTest3.Text = "DLL测试3 步长调节";
            this.btnSdramDllTest3.UseVisualStyleBackColor = false;
            // 
            // btnSdramDllTest2
            // 
            this.btnSdramDllTest2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSdramDllTest2.Font = new System.Drawing.Font("Courier New", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSdramDllTest2.Location = new System.Drawing.Point(19, 92);
            this.btnSdramDllTest2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSdramDllTest2.Name = "btnSdramDllTest2";
            this.btnSdramDllTest2.Size = new System.Drawing.Size(105, 60);
            this.btnSdramDllTest2.TabIndex = 91;
            this.btnSdramDllTest2.Text = "DLL测试2 自检扫描";
            this.btnSdramDllTest2.UseVisualStyleBackColor = false;
            // 
            // cmbSelfTestPattern
            // 
            this.cmbSelfTestPattern.FormattingEnabled = true;
            this.cmbSelfTestPattern.Items.AddRange(new object[] {
            "00-正常",
            "80-红",
            "81-绿",
            "82-蓝",
            "83-白",
            "84-横",
            "85-竖",
            "86-斜",
            "87-白渐",
            "88-棋盘",
            "89-红渐",
            "8A-绿渐",
            "8B-蓝渐",
            "8C-黑",
            "8D-黄",
            "8E-紫",
            "8F-打屏"});
            this.cmbSelfTestPattern.Location = new System.Drawing.Point(134, 272);
            this.cmbSelfTestPattern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSelfTestPattern.Name = "cmbSelfTestPattern";
            this.cmbSelfTestPattern.Size = new System.Drawing.Size(82, 23);
            this.cmbSelfTestPattern.TabIndex = 90;
            this.cmbSelfTestPattern.Text = "00-正常";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(131, 249);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(70, 15);
            this.label73.TabIndex = 80;
            this.label73.Text = "自测调节:";
            // 
            // btnSelfTestPattern
            // 
            this.btnSelfTestPattern.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSelfTestPattern.Font = new System.Drawing.Font("Courier New", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelfTestPattern.Location = new System.Drawing.Point(19, 245);
            this.btnSelfTestPattern.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSelfTestPattern.Name = "btnSelfTestPattern";
            this.btnSelfTestPattern.Size = new System.Drawing.Size(105, 60);
            this.btnSelfTestPattern.TabIndex = 79;
            this.btnSelfTestPattern.Text = "REG控制自测试画面";
            this.btnSelfTestPattern.UseVisualStyleBackColor = false;
            // 
            // cbWriteChange
            // 
            this.cbWriteChange.AutoSize = true;
            this.cbWriteChange.Location = new System.Drawing.Point(129, 25);
            this.cbWriteChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbWriteChange.Name = "cbWriteChange";
            this.cbWriteChange.Size = new System.Drawing.Size(75, 19);
            this.cbWriteChange.TabIndex = 76;
            this.cbWriteChange.Text = "写-变化";
            this.cbWriteChange.UseVisualStyleBackColor = true;
            // 
            // nudIntervalDelay
            // 
            this.nudIntervalDelay.Location = new System.Drawing.Point(174, 52);
            this.nudIntervalDelay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudIntervalDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudIntervalDelay.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudIntervalDelay.Name = "nudIntervalDelay";
            this.nudIntervalDelay.Size = new System.Drawing.Size(58, 21);
            this.nudIntervalDelay.TabIndex = 78;
            this.nudIntervalDelay.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(125, 55);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(42, 15);
            this.label25.TabIndex = 77;
            this.label25.Text = "间隔:";
            // 
            // btnSdramDllTest1
            // 
            this.btnSdramDllTest1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSdramDllTest1.Font = new System.Drawing.Font("Courier New", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSdramDllTest1.Location = new System.Drawing.Point(19, 21);
            this.btnSdramDllTest1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSdramDllTest1.Name = "btnSdramDllTest1";
            this.btnSdramDllTest1.Size = new System.Drawing.Size(105, 60);
            this.btnSdramDllTest1.TabIndex = 23;
            this.btnSdramDllTest1.Text = "DLL测试1 写操作";
            this.btnSdramDllTest1.UseVisualStyleBackColor = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbOeRam);
            this.tabPage1.Controls.Add(this.cbGroupRamEn);
            this.tabPage1.Controls.Add(this.cbDotDetectEn);
            this.tabPage1.Controls.Add(this.cbCfgregRamEn);
            this.tabPage1.Controls.Add(this.btnCpuConflict);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(663, 362);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "CPU&RAM冲突";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbOeRam
            // 
            this.cbOeRam.AutoSize = true;
            this.cbOeRam.Location = new System.Drawing.Point(51, 120);
            this.cbOeRam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbOeRam.Name = "cbOeRam";
            this.cbOeRam.Size = new System.Drawing.Size(68, 19);
            this.cbOeRam.TabIndex = 28;
            this.cbOeRam.Text = "OE_Ram";
            this.cbOeRam.UseVisualStyleBackColor = true;
            // 
            // cbGroupRamEn
            // 
            this.cbGroupRamEn.AutoSize = true;
            this.cbGroupRamEn.Location = new System.Drawing.Point(51, 74);
            this.cbGroupRamEn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbGroupRamEn.Name = "cbGroupRamEn";
            this.cbGroupRamEn.Size = new System.Drawing.Size(89, 19);
            this.cbGroupRamEn.TabIndex = 27;
            this.cbGroupRamEn.Text = "Group_Ram";
            this.cbGroupRamEn.UseVisualStyleBackColor = true;
            // 
            // cbDotDetectEn
            // 
            this.cbDotDetectEn.AutoSize = true;
            this.cbDotDetectEn.Location = new System.Drawing.Point(51, 96);
            this.cbDotDetectEn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDotDetectEn.Name = "cbDotDetectEn";
            this.cbDotDetectEn.Size = new System.Drawing.Size(117, 19);
            this.cbDotDetectEn.TabIndex = 26;
            this.cbDotDetectEn.Text = "DotDetect_Ram";
            this.cbDotDetectEn.UseVisualStyleBackColor = true;
            // 
            // cbCfgregRamEn
            // 
            this.cbCfgregRamEn.AutoSize = true;
            this.cbCfgregRamEn.Location = new System.Drawing.Point(51, 50);
            this.cbCfgregRamEn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCfgregRamEn.Name = "cbCfgregRamEn";
            this.cbCfgregRamEn.Size = new System.Drawing.Size(96, 19);
            this.cbCfgregRamEn.TabIndex = 25;
            this.cbCfgregRamEn.Text = "CfgReg_Ram";
            this.cbCfgregRamEn.UseVisualStyleBackColor = true;
            // 
            // btnCpuConflict
            // 
            this.btnCpuConflict.Font = new System.Drawing.Font("Courier New", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCpuConflict.Location = new System.Drawing.Point(271, 55);
            this.btnCpuConflict.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCpuConflict.Name = "btnCpuConflict";
            this.btnCpuConflict.Size = new System.Drawing.Size(138, 68);
            this.btnCpuConflict.TabIndex = 24;
            this.btnCpuConflict.Text = "CPU访问冲突";
            this.btnCpuConflict.UseVisualStyleBackColor = true;
            // 
            // tbpPhaseTest
            // 
            this.tbpPhaseTest.Controls.Add(this.lbViewCnt);
            this.tbpPhaseTest.Controls.Add(this.gbTestModeSel);
            this.tbpPhaseTest.Controls.Add(this.gbPowerSel);
            this.tbpPhaseTest.Controls.Add(this.btnPhaseTest);
            this.tbpPhaseTest.Controls.Add(this.cbCh4En);
            this.tbpPhaseTest.Controls.Add(this.cbCh3En);
            this.tbpPhaseTest.Controls.Add(this.cbCh2En);
            this.tbpPhaseTest.Controls.Add(this.cbCh1En);
            this.tbpPhaseTest.Controls.Add(this.cbPowerSelEn);
            this.tbpPhaseTest.Controls.Add(this.label77);
            this.tbpPhaseTest.Controls.Add(this.tbInstPowerAddr);
            this.tbpPhaseTest.Location = new System.Drawing.Point(4, 24);
            this.tbpPhaseTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpPhaseTest.Name = "tbpPhaseTest";
            this.tbpPhaseTest.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpPhaseTest.Size = new System.Drawing.Size(663, 362);
            this.tbpPhaseTest.TabIndex = 3;
            this.tbpPhaseTest.Text = "相位翻转测试";
            this.tbpPhaseTest.UseVisualStyleBackColor = true;
            // 
            // lbViewCnt
            // 
            this.lbViewCnt.AutoSize = true;
            this.lbViewCnt.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViewCnt.ForeColor = System.Drawing.Color.Red;
            this.lbViewCnt.Location = new System.Drawing.Point(51, 239);
            this.lbViewCnt.Name = "lbViewCnt";
            this.lbViewCnt.Size = new System.Drawing.Size(205, 36);
            this.lbViewCnt.TabIndex = 86;
            this.lbViewCnt.Text = "测试次数：";
            // 
            // gbTestModeSel
            // 
            this.gbTestModeSel.Controls.Add(this.rbLogicCheckMode);
            this.gbTestModeSel.Controls.Add(this.rbPhaseSequenceOptMode);
            this.gbTestModeSel.Location = new System.Drawing.Point(236, 11);
            this.gbTestModeSel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTestModeSel.Name = "gbTestModeSel";
            this.gbTestModeSel.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTestModeSel.Size = new System.Drawing.Size(194, 100);
            this.gbTestModeSel.TabIndex = 85;
            this.gbTestModeSel.TabStop = false;
            this.gbTestModeSel.Text = "测试模式选择";
            // 
            // rbLogicCheckMode
            // 
            this.rbLogicCheckMode.AutoSize = true;
            this.rbLogicCheckMode.Location = new System.Drawing.Point(23, 30);
            this.rbLogicCheckMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbLogicCheckMode.Name = "rbLogicCheckMode";
            this.rbLogicCheckMode.Size = new System.Drawing.Size(130, 19);
            this.rbLogicCheckMode.TabIndex = 82;
            this.rbLogicCheckMode.Text = "相位---逻辑判断";
            this.rbLogicCheckMode.UseVisualStyleBackColor = true;
            // 
            // rbPhaseSequenceOptMode
            // 
            this.rbPhaseSequenceOptMode.AutoSize = true;
            this.rbPhaseSequenceOptMode.Checked = true;
            this.rbPhaseSequenceOptMode.Location = new System.Drawing.Point(23, 62);
            this.rbPhaseSequenceOptMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbPhaseSequenceOptMode.Name = "rbPhaseSequenceOptMode";
            this.rbPhaseSequenceOptMode.Size = new System.Drawing.Size(130, 19);
            this.rbPhaseSequenceOptMode.TabIndex = 83;
            this.rbPhaseSequenceOptMode.TabStop = true;
            this.rbPhaseSequenceOptMode.Text = "相位---顺序执行";
            this.rbPhaseSequenceOptMode.UseVisualStyleBackColor = true;
            // 
            // gbPowerSel
            // 
            this.gbPowerSel.Controls.Add(this.rbGuweiPwrEn);
            this.gbPowerSel.Controls.Add(this.rbKeyPowerEn);
            this.gbPowerSel.Location = new System.Drawing.Point(33, 11);
            this.gbPowerSel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPowerSel.Name = "gbPowerSel";
            this.gbPowerSel.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPowerSel.Size = new System.Drawing.Size(194, 100);
            this.gbPowerSel.TabIndex = 84;
            this.gbPowerSel.TabStop = false;
            this.gbPowerSel.Text = "电源选择";
            // 
            // rbGuweiPwrEn
            // 
            this.rbGuweiPwrEn.AutoSize = true;
            this.rbGuweiPwrEn.Location = new System.Drawing.Point(20, 59);
            this.rbGuweiPwrEn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbGuweiPwrEn.Name = "rbGuweiPwrEn";
            this.rbGuweiPwrEn.Size = new System.Drawing.Size(81, 19);
            this.rbGuweiPwrEn.TabIndex = 81;
            this.rbGuweiPwrEn.Text = "GPP-4323";
            this.rbGuweiPwrEn.UseVisualStyleBackColor = true;
            // 
            // rbKeyPowerEn
            // 
            this.rbKeyPowerEn.AutoSize = true;
            this.rbKeyPowerEn.Checked = true;
            this.rbKeyPowerEn.Location = new System.Drawing.Point(20, 30);
            this.rbKeyPowerEn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbKeyPowerEn.Name = "rbKeyPowerEn";
            this.rbKeyPowerEn.Size = new System.Drawing.Size(102, 19);
            this.rbKeyPowerEn.TabIndex = 80;
            this.rbKeyPowerEn.TabStop = true;
            this.rbKeyPowerEn.Text = "KeySightPwr";
            this.rbKeyPowerEn.UseVisualStyleBackColor = true;
            // 
            // btnPhaseTest
            // 
            this.btnPhaseTest.Font = new System.Drawing.Font("Courier New", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhaseTest.Location = new System.Drawing.Point(493, 30);
            this.btnPhaseTest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPhaseTest.Name = "btnPhaseTest";
            this.btnPhaseTest.Size = new System.Drawing.Size(138, 68);
            this.btnPhaseTest.TabIndex = 79;
            this.btnPhaseTest.Text = "相位翻转测试";
            this.btnPhaseTest.UseVisualStyleBackColor = true;
            // 
            // cbCh4En
            // 
            this.cbCh4En.AutoSize = true;
            this.cbCh4En.Enabled = false;
            this.cbCh4En.Location = new System.Drawing.Point(294, 152);
            this.cbCh4En.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCh4En.Name = "cbCh4En";
            this.cbCh4En.Size = new System.Drawing.Size(47, 19);
            this.cbCh4En.TabIndex = 78;
            this.cbCh4En.Text = "CH4";
            this.cbCh4En.UseVisualStyleBackColor = true;
            // 
            // cbCh3En
            // 
            this.cbCh3En.AutoSize = true;
            this.cbCh3En.Enabled = false;
            this.cbCh3En.Location = new System.Drawing.Point(236, 152);
            this.cbCh3En.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCh3En.Name = "cbCh3En";
            this.cbCh3En.Size = new System.Drawing.Size(47, 19);
            this.cbCh3En.TabIndex = 77;
            this.cbCh3En.Text = "CH3";
            this.cbCh3En.UseVisualStyleBackColor = true;
            // 
            // cbCh2En
            // 
            this.cbCh2En.AutoSize = true;
            this.cbCh2En.Enabled = false;
            this.cbCh2En.Location = new System.Drawing.Point(171, 152);
            this.cbCh2En.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCh2En.Name = "cbCh2En";
            this.cbCh2En.Size = new System.Drawing.Size(47, 19);
            this.cbCh2En.TabIndex = 76;
            this.cbCh2En.Text = "CH2";
            this.cbCh2En.UseVisualStyleBackColor = true;
            // 
            // cbCh1En
            // 
            this.cbCh1En.AutoSize = true;
            this.cbCh1En.Checked = true;
            this.cbCh1En.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCh1En.Enabled = false;
            this.cbCh1En.Location = new System.Drawing.Point(104, 152);
            this.cbCh1En.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCh1En.Name = "cbCh1En";
            this.cbCh1En.Size = new System.Drawing.Size(47, 19);
            this.cbCh1En.TabIndex = 72;
            this.cbCh1En.Text = "CH1";
            this.cbCh1En.UseVisualStyleBackColor = true;
            // 
            // cbPowerSelEn
            // 
            this.cbPowerSelEn.AutoSize = true;
            this.cbPowerSelEn.Location = new System.Drawing.Point(344, 132);
            this.cbPowerSelEn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPowerSelEn.Name = "cbPowerSelEn";
            this.cbPowerSelEn.Size = new System.Drawing.Size(15, 14);
            this.cbPowerSelEn.TabIndex = 75;
            this.cbPowerSelEn.UseVisualStyleBackColor = true;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(7, 126);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(70, 15);
            this.label77.TabIndex = 74;
            this.label77.Text = "电源地址:";
            // 
            // tbInstPowerAddr
            // 
            this.tbInstPowerAddr.BackColor = System.Drawing.SystemColors.Control;
            this.tbInstPowerAddr.Enabled = false;
            this.tbInstPowerAddr.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInstPowerAddr.ForeColor = System.Drawing.Color.Black;
            this.tbInstPowerAddr.Location = new System.Drawing.Point(104, 124);
            this.tbInstPowerAddr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbInstPowerAddr.Name = "tbInstPowerAddr";
            this.tbInstPowerAddr.Size = new System.Drawing.Size(236, 21);
            this.tbInstPowerAddr.TabIndex = 73;
            this.tbInstPowerAddr.Text = "USB0::0x2A8D::0x1202::MY61003304::INSTR";
            // 
            // gbCommCfg
            // 
            this.gbCommCfg.Controls.Add(this.label74);
            this.gbCommCfg.Controls.Add(this.nudStart);
            this.gbCommCfg.Controls.Add(this.label75);
            this.gbCommCfg.Controls.Add(this.nudEnd);
            this.gbCommCfg.Controls.Add(this.lbEndTime);
            this.gbCommCfg.Controls.Add(this.nudLoopCnt);
            this.gbCommCfg.Controls.Add(this.label78);
            this.gbCommCfg.Controls.Add(this.lbStartTime);
            this.gbCommCfg.Controls.Add(this.label38);
            this.gbCommCfg.Controls.Add(this.nudWRDelay);
            this.gbCommCfg.Controls.Add(this.lbETime);
            this.gbCommCfg.Controls.Add(this.lbSTime);
            this.gbCommCfg.Controls.Add(this.nudStep);
            this.gbCommCfg.Controls.Add(this.label76);
            this.gbCommCfg.Location = new System.Drawing.Point(491, 412);
            this.gbCommCfg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCommCfg.Name = "gbCommCfg";
            this.gbCommCfg.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCommCfg.Size = new System.Drawing.Size(180, 279);
            this.gbCommCfg.TabIndex = 98;
            this.gbCommCfg.TabStop = false;
            this.gbCommCfg.Text = "公共操作";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(12, 28);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(42, 15);
            this.label74.TabIndex = 96;
            this.label74.Text = "区间:";
            // 
            // nudStart
            // 
            this.nudStart.Location = new System.Drawing.Point(63, 25);
            this.nudStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudStart.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudStart.Name = "nudStart";
            this.nudStart.Size = new System.Drawing.Size(49, 21);
            this.nudStart.TabIndex = 95;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Enabled = false;
            this.label75.Location = new System.Drawing.Point(110, 28);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(14, 15);
            this.label75.TabIndex = 97;
            this.label75.Text = "-";
            // 
            // nudEnd
            // 
            this.nudEnd.Location = new System.Drawing.Point(126, 25);
            this.nudEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudEnd.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEnd.Name = "nudEnd";
            this.nudEnd.Size = new System.Drawing.Size(49, 21);
            this.nudEnd.TabIndex = 97;
            this.nudEnd.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // lbEndTime
            // 
            this.lbEndTime.AutoSize = true;
            this.lbEndTime.Enabled = false;
            this.lbEndTime.Location = new System.Drawing.Point(12, 250);
            this.lbEndTime.Name = "lbEndTime";
            this.lbEndTime.Size = new System.Drawing.Size(28, 15);
            this.lbEndTime.TabIndex = 82;
            this.lbEndTime.Text = "...";
            // 
            // nudLoopCnt
            // 
            this.nudLoopCnt.Location = new System.Drawing.Point(101, 85);
            this.nudLoopCnt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudLoopCnt.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudLoopCnt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLoopCnt.Name = "nudLoopCnt";
            this.nudLoopCnt.Size = new System.Drawing.Size(66, 21);
            this.nudLoopCnt.TabIndex = 74;
            this.nudLoopCnt.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(12, 89);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(70, 15);
            this.label78.TabIndex = 75;
            this.label78.Text = "循环次数:";
            // 
            // lbStartTime
            // 
            this.lbStartTime.AutoSize = true;
            this.lbStartTime.Enabled = false;
            this.lbStartTime.Location = new System.Drawing.Point(10, 205);
            this.lbStartTime.Name = "lbStartTime";
            this.lbStartTime.Size = new System.Drawing.Size(28, 15);
            this.lbStartTime.TabIndex = 81;
            this.lbStartTime.Text = "...";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(12, 118);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(70, 15);
            this.label38.TabIndex = 51;
            this.label38.Text = "上电等待:";
            // 
            // nudWRDelay
            // 
            this.nudWRDelay.Location = new System.Drawing.Point(101, 114);
            this.nudWRDelay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudWRDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudWRDelay.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudWRDelay.Name = "nudWRDelay";
            this.nudWRDelay.Size = new System.Drawing.Size(66, 21);
            this.nudWRDelay.TabIndex = 55;
            this.nudWRDelay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lbETime
            // 
            this.lbETime.AutoSize = true;
            this.lbETime.Enabled = false;
            this.lbETime.ForeColor = System.Drawing.Color.Blue;
            this.lbETime.Location = new System.Drawing.Point(14, 230);
            this.lbETime.Name = "lbETime";
            this.lbETime.Size = new System.Drawing.Size(70, 15);
            this.lbETime.TabIndex = 80;
            this.lbETime.Text = "结束时间:";
            // 
            // lbSTime
            // 
            this.lbSTime.AutoSize = true;
            this.lbSTime.Enabled = false;
            this.lbSTime.ForeColor = System.Drawing.Color.Blue;
            this.lbSTime.Location = new System.Drawing.Point(14, 185);
            this.lbSTime.Name = "lbSTime";
            this.lbSTime.Size = new System.Drawing.Size(70, 15);
            this.lbSTime.TabIndex = 79;
            this.lbSTime.Text = "开始时间:";
            // 
            // nudStep
            // 
            this.nudStep.Location = new System.Drawing.Point(101, 56);
            this.nudStep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStep.Name = "nudStep";
            this.nudStep.Size = new System.Drawing.Size(66, 21);
            this.nudStep.TabIndex = 73;
            this.nudStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(12, 60);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(70, 15);
            this.label76.TabIndex = 72;
            this.label76.Text = "调节步进:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(112, 604);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(0, 15);
            this.label42.TabIndex = 65;
            // 
            // rtbLogPrint1
            // 
            this.rtbLogPrint1.Enabled = false;
            this.rtbLogPrint1.Location = new System.Drawing.Point(7, 513);
            this.rtbLogPrint1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.rtbLogPrint1.Name = "rtbLogPrint1";
            this.rtbLogPrint1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbLogPrint1.Size = new System.Drawing.Size(476, 143);
            this.rtbLogPrint1.TabIndex = 61;
            this.rtbLogPrint1.Text = "无误码的所有配置：";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnClear.Location = new System.Drawing.Point(7, 660);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(58, 31);
            this.btnClear.TabIndex = 54;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStop.Location = new System.Drawing.Point(426, 660);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(58, 31);
            this.btnStop.TabIndex = 29;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // rtbLogPrint
            // 
            this.rtbLogPrint.Location = new System.Drawing.Point(7, 412);
            this.rtbLogPrint.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.rtbLogPrint.Name = "rtbLogPrint";
            this.rtbLogPrint.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbLogPrint.Size = new System.Drawing.Size(476, 102);
            this.rtbLogPrint.TabIndex = 28;
            this.rtbLogPrint.Text = "请从第1级开始测试...";
            // 
            // TCON_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 730);
            this.Controls.Add(this.gb6330Test);
            this.Controls.Add(this.gbSerialPort);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TCON_Form";
            this.Text = "Debug Tool";
            this.gbSerialPort.ResumeLayout(false);
            this.groupBox_port.ResumeLayout(false);
            this.groupBox_port.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gb6330Test.ResumeLayout(false);
            this.gb6330Test.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbpLvdsBertTest.ResumeLayout(false);
            this.tbpLvdsBertTest.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbRxClk.ResumeLayout(false);
            this.gbRxClk.PerformLayout();
            this.gbRxPhase.ResumeLayout(false);
            this.gbRxPhase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReadErrDelay)).EndInit();
            this.tbpSdramDllTrim.ResumeLayout(false);
            this.tbpSdramDllTrim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalDelay)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tbpPhaseTest.ResumeLayout(false);
            this.tbpPhaseTest.PerformLayout();
            this.gbTestModeSel.ResumeLayout(false);
            this.gbTestModeSel.PerformLayout();
            this.gbPowerSel.ResumeLayout(false);
            this.gbPowerSel.PerformLayout();
            this.gbCommCfg.ResumeLayout(false);
            this.gbCommCfg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoopCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWRDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox gbSerialPort;
        private System.Windows.Forms.GroupBox groupBox_port;
        private System.Windows.Forms.Button Button_serialSwitch;
        private System.Windows.Forms.Label label_portName;
        private System.Windows.Forms.ComboBox comboBox_portName;
        private System.Windows.Forms.Label label_baudRate;
        private System.Windows.Forms.Label label_parity;
        private System.Windows.Forms.ComboBox comboBox_parity;
        private System.Windows.Forms.ComboBox comboBox_baudRate;
        private System.Windows.Forms.Label label_dataBit;
        private System.Windows.Forms.Label label_stopBit;
        private System.Windows.Forms.ComboBox comboBox_stopBit;
        private System.Windows.Forms.ComboBox comboBox_dataBit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Button_StopSend;
        private System.Windows.Forms.Button Button_ReCaculate;
        private System.Windows.Forms.Button Button_ClearWin;
        private System.Windows.Forms.Button Button_ToFlash;
        private System.Windows.Forms.Button Button_FromFlash;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_row15;
        private System.Windows.Forms.Label label_row14;
        private System.Windows.Forms.Label label_row13;
        private System.Windows.Forms.Label label_row12;
        private System.Windows.Forms.Label label_row11;
        private System.Windows.Forms.Label label_row10;
        private System.Windows.Forms.Label label_row9;
        private System.Windows.Forms.Label label_row8;
        private System.Windows.Forms.Label label_row7;
        private System.Windows.Forms.Label label_row6;
        private System.Windows.Forms.Label label_row5;
        private System.Windows.Forms.Label label_row4;
        private System.Windows.Forms.Label label_row3;
        private System.Windows.Forms.Label label_row2;
        private System.Windows.Forms.Label label_row1;
        private System.Windows.Forms.Label label_row0;
        private System.Windows.Forms.ProgressBar progressBar_Comm;
        private System.Windows.Forms.Button Button_loadTxtFile;
        private System.Windows.Forms.Button Button_flash;
        private System.Windows.Forms.Button Button_DebugEn;
        private System.Windows.Forms.RichTextBox richTextBox_readData;
        private System.Windows.Forms.Button Button_loadBinaryFile;
        private System.Windows.Forms.Label label_totalLinesCount;
        private System.Windows.Forms.RichTextBox richTextBox_paras;
        private System.Windows.Forms.Button Button_writeParas;
        private System.Windows.Forms.Button Button_readParas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Button_SelfDefine;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_addrLL;
        private System.Windows.Forms.TextBox textBox_addrLH;
        private System.Windows.Forms.TextBox textBox_addrHL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_dataLength;
        private System.Windows.Forms.Label label_dataLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_timeout;
        private System.Windows.Forms.TextBox textBox_timeout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_addr;
        private System.Windows.Forms.TextBox textBox_addrHH;
        private System.Windows.Forms.Label label_length;
        private System.Windows.Forms.TextBox textBox_length;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RadioButton_StepTest;
        private System.Windows.Forms.RadioButton RadioButton_Test;
        private System.Windows.Forms.RadioButton RadioButton_Iram;
        private System.Windows.Forms.RadioButton RadioButton_cmd;
        private System.Windows.Forms.RadioButton RadioButton_flash;
        private System.Windows.Forms.RadioButton RadioButton_inter;
        private System.Windows.Forms.GroupBox gb6330Test;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpLvdsBertTest;
        private System.Windows.Forms.Button btnPllLock;
        private System.Windows.Forms.CheckBox cbVcoFreqHigh;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Button btnOpenErrSwitch;
        private System.Windows.Forms.Button btnReadDefault;
        private System.Windows.Forms.Button btnLvdsBert;
        private System.Windows.Forms.Button btnClrAndReadErr;
        private System.Windows.Forms.Button btnWriteDefault;
        private System.Windows.Forms.Button btnFreqCfg;
        private System.Windows.Forms.ComboBox cmbFreqSel;
        private System.Windows.Forms.GroupBox gbRxClk;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.TextBox tbVcoFreqCfg04;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.TextBox tbVcoFreqCfg03;
        private System.Windows.Forms.TextBox tbDataClkPhase;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tbVcoFreqCfg08;
        private System.Windows.Forms.TextBox tbRxClkPhase;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbRxClkPhaseCfg;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.GroupBox gbRxPhase;
        private System.Windows.Forms.TextBox tbRxDataPhase;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tbRxDataPhaseCfg_2;
        private System.Windows.Forms.TextBox tbRxDataPhaseCfg_3;
        private System.Windows.Forms.TextBox tbRxDataPhaseCfg_1;
        private System.Windows.Forms.CheckBox cbAllCaseSweep;
        private System.Windows.Forms.NumericUpDown nudReadErrDelay;
        private System.Windows.Forms.CheckBox cbStepDebugEn;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TabPage tbpSdramDllTrim;
        private System.Windows.Forms.Button btnSdramDllTest3;
        private System.Windows.Forms.Button btnSdramDllTest2;
        private System.Windows.Forms.ComboBox cmbSelfTestPattern;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Button btnSelfTestPattern;
        private System.Windows.Forms.CheckBox cbWriteChange;
        private System.Windows.Forms.NumericUpDown nudIntervalDelay;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnSdramDllTest1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox cbOeRam;
        private System.Windows.Forms.CheckBox cbGroupRamEn;
        private System.Windows.Forms.CheckBox cbDotDetectEn;
        private System.Windows.Forms.CheckBox cbCfgregRamEn;
        private System.Windows.Forms.Button btnCpuConflict;
        private System.Windows.Forms.TabPage tbpPhaseTest;
        private System.Windows.Forms.Label lbViewCnt;
        private System.Windows.Forms.GroupBox gbTestModeSel;
        private System.Windows.Forms.RadioButton rbLogicCheckMode;
        private System.Windows.Forms.RadioButton rbPhaseSequenceOptMode;
        private System.Windows.Forms.GroupBox gbPowerSel;
        private System.Windows.Forms.RadioButton rbGuweiPwrEn;
        private System.Windows.Forms.RadioButton rbKeyPowerEn;
        private System.Windows.Forms.Button btnPhaseTest;
        private System.Windows.Forms.CheckBox cbCh4En;
        private System.Windows.Forms.CheckBox cbCh3En;
        private System.Windows.Forms.CheckBox cbCh2En;
        private System.Windows.Forms.CheckBox cbCh1En;
        private System.Windows.Forms.CheckBox cbPowerSelEn;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.TextBox tbInstPowerAddr;
        private System.Windows.Forms.GroupBox gbCommCfg;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.NumericUpDown nudStart;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.NumericUpDown nudEnd;
        private System.Windows.Forms.Label lbEndTime;
        private System.Windows.Forms.NumericUpDown nudLoopCnt;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label lbStartTime;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.NumericUpDown nudWRDelay;
        private System.Windows.Forms.Label lbETime;
        private System.Windows.Forms.Label lbSTime;
        private System.Windows.Forms.NumericUpDown nudStep;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.RichTextBox rtbLogPrint1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RichTextBox rtbLogPrint;
    }
}