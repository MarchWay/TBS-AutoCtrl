
namespace AutoCtrl.CommonForm {
    partial class USB_PortForm {
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
            this.rtbUsbReadData = new System.Windows.Forms.RichTextBox();
            this.btnGetUsbPort = new System.Windows.Forms.Button();
            this.cmbUsbDeviceInfoList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUsbPortInfo = new System.Windows.Forms.GroupBox();
            this.cbDebugEn = new System.Windows.Forms.CheckBox();
            this.btnStopEn = new System.Windows.Forms.Button();
            this.gbUsbReadWriteOpt = new System.Windows.Forms.GroupBox();
            this.rtbUsbWriteData = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.gbReadWriteDataStreamMonitor = new System.Windows.Forms.GroupBox();
            this.rtbUsbReadWriteDataStreamMonitor = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClearAllRtb = new System.Windows.Forms.Button();
            this.gbUsbOptStatePrint = new System.Windows.Forms.GroupBox();
            this.rtbUsbErrInfo = new System.Windows.Forms.RichTextBox();
            this.rtbUsbOptState = new System.Windows.Forms.RichTextBox();
            this.gbRegOpt = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudOptDelayMs = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudNetPortNum = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbRegOptLength = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUsbOtpType = new System.Windows.Forms.ComboBox();
            this.tbRegAddr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbUsbDeviceType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDebug = new System.Windows.Forms.Button();
            this.gbUsbLookUp = new System.Windows.Forms.GroupBox();
            this.cmbUsbDevicePidList = new System.Windows.Forms.ComboBox();
            this.cmbUsbDeviceVidList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReadUsbDevice = new System.Windows.Forms.Button();
            this.btnWriteUsbDevice = new System.Windows.Forms.Button();
            this.btnCloseDevice = new System.Windows.Forms.Button();
            this.btnOpenDevice = new System.Windows.Forms.Button();
            this.gbTestItem = new System.Windows.Forms.GroupBox();
            this.gbCommonPart = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbVoltCaseSel = new System.Windows.Forms.ComboBox();
            this.lbTemp = new System.Windows.Forms.Label();
            this.cmbTempCaseSel = new System.Windows.Forms.ComboBox();
            this.lbVolt = new System.Windows.Forms.Label();
            this.cmbChipCorner = new System.Windows.Forms.ComboBox();
            this.lbChipCorner = new System.Windows.Forms.Label();
            this.lbNote = new System.Windows.Forms.Label();
            this.gbPwrCHNSel = new System.Windows.Forms.GroupBox();
            this.cbPwrType = new System.Windows.Forms.CheckBox();
            this.cbEnPwrCH4 = new System.Windows.Forms.CheckBox();
            this.cbEnPwrCH3 = new System.Windows.Forms.CheckBox();
            this.cbEnPwrCH1 = new System.Windows.Forms.CheckBox();
            this.cbEnPwrCH2 = new System.Windows.Forms.CheckBox();
            this.label32 = new System.Windows.Forms.Label();
            this.cbMultiSelEn1 = new System.Windows.Forms.CheckBox();
            this.tbInstMultiAddr1 = new System.Windows.Forms.TextBox();
            this.cbMultiSelEn = new System.Windows.Forms.CheckBox();
            this.cbPowerSelEn = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tbInstMultiAddr = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tbInstPowerAddr = new System.Windows.Forms.TextBox();
            this.tbChipID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTestMessage = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tcTest = new System.Windows.Forms.TabControl();
            this.tbpDriverIc = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cbDriverRedChipEn = new System.Windows.Forms.CheckBox();
            this.cbDriverGreenChipEn = new System.Windows.Forms.CheckBox();
            this.cbDriverBlueChipEn = new System.Windows.Forms.CheckBox();
            this.gbRegConfig = new System.Windows.Forms.GroupBox();
            this.btnManualConfig = new System.Windows.Forms.Button();
            this.tbVbgSet = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbDriverRegValue = new System.Windows.Forms.TextBox();
            this.btnRegWrite = new System.Windows.Forms.Button();
            this.tbDriverRegAddr = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tbAtbResult = new System.Windows.Forms.TextBox();
            this.rtbDispaly = new System.Windows.Forms.RichTextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.btnAtbRead = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.cbTestCase = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.cbProjectItems = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cmbAtbNodeName = new System.Windows.Forms.ComboBox();
            this.tbpInterfaceIC = new System.Windows.Forms.TabPage();
            this.gbChipLocationSel = new System.Windows.Forms.GroupBox();
            this.cbEnChip0 = new System.Windows.Forms.CheckBox();
            this.cbEnChip1 = new System.Windows.Forms.CheckBox();
            this.btnInterChipStop = new System.Windows.Forms.Button();
            this.btnInterChipStart = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.cbInterChipTestCase = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.cbInterChipProjectItems = new System.Windows.Forms.ComboBox();
            this.rtbInterChipDisPlay = new System.Windows.Forms.RichTextBox();
            this.tbInterChipAtbResult = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.btnInterChipAtbRead = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.cmbInterChipAtbName = new System.Windows.Forms.ComboBox();
            this.gbInterChipConfig = new System.Windows.Forms.GroupBox();
            this.btnInterChipVbgConfig = new System.Windows.Forms.Button();
            this.tbInterChipVbgValue = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbInterChipRegValue = new System.Windows.Forms.TextBox();
            this.btnInterChipRegWrite = new System.Windows.Forms.Button();
            this.tbInterChipRegAddr = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.tbpControlIC = new System.Windows.Forms.TabPage();
            this.gbUsbPortInfo.SuspendLayout();
            this.gbUsbReadWriteOpt.SuspendLayout();
            this.gbReadWriteDataStreamMonitor.SuspendLayout();
            this.gbUsbOptStatePrint.SuspendLayout();
            this.gbRegOpt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOptDelayMs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNetPortNum)).BeginInit();
            this.gbUsbLookUp.SuspendLayout();
            this.gbTestItem.SuspendLayout();
            this.gbCommonPart.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbPwrCHNSel.SuspendLayout();
            this.tcTest.SuspendLayout();
            this.tbpDriverIc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbRegConfig.SuspendLayout();
            this.tbpInterfaceIC.SuspendLayout();
            this.gbChipLocationSel.SuspendLayout();
            this.gbInterChipConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbUsbReadData
            // 
            this.rtbUsbReadData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbUsbReadData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtbUsbReadData.Location = new System.Drawing.Point(2, 79);
            this.rtbUsbReadData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbUsbReadData.Name = "rtbUsbReadData";
            this.rtbUsbReadData.Size = new System.Drawing.Size(483, 63);
            this.rtbUsbReadData.TabIndex = 0;
            this.rtbUsbReadData.Text = "接收数据显示区";
            // 
            // btnGetUsbPort
            // 
            this.btnGetUsbPort.Font = new System.Drawing.Font("Courier New", 9F);
            this.btnGetUsbPort.Location = new System.Drawing.Point(368, 36);
            this.btnGetUsbPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetUsbPort.Name = "btnGetUsbPort";
            this.btnGetUsbPort.Size = new System.Drawing.Size(92, 25);
            this.btnGetUsbPort.TabIndex = 1;
            this.btnGetUsbPort.Text = "查询USB设备";
            this.btnGetUsbPort.UseVisualStyleBackColor = true;
            this.btnGetUsbPort.Click += new System.EventHandler(this.btnGetUsbPort_Click);
            // 
            // cmbUsbDeviceInfoList
            // 
            this.cmbUsbDeviceInfoList.BackColor = System.Drawing.SystemColors.Control;
            this.cmbUsbDeviceInfoList.Font = new System.Drawing.Font("Courier New", 9F);
            this.cmbUsbDeviceInfoList.FormattingEnabled = true;
            this.cmbUsbDeviceInfoList.Location = new System.Drawing.Point(75, 37);
            this.cmbUsbDeviceInfoList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbUsbDeviceInfoList.Name = "cmbUsbDeviceInfoList";
            this.cmbUsbDeviceInfoList.Size = new System.Drawing.Size(153, 23);
            this.cmbUsbDeviceInfoList.TabIndex = 2;
            this.cmbUsbDeviceInfoList.SelectedIndexChanged += new System.EventHandler(this.cmbUsbDeviceInfoList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F);
            this.label1.Location = new System.Drawing.Point(5, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "设备列表:";
            // 
            // gbUsbPortInfo
            // 
            this.gbUsbPortInfo.Controls.Add(this.cbDebugEn);
            this.gbUsbPortInfo.Controls.Add(this.btnStopEn);
            this.gbUsbPortInfo.Controls.Add(this.gbUsbReadWriteOpt);
            this.gbUsbPortInfo.Controls.Add(this.gbReadWriteDataStreamMonitor);
            this.gbUsbPortInfo.Controls.Add(this.btnClearAllRtb);
            this.gbUsbPortInfo.Controls.Add(this.gbUsbOptStatePrint);
            this.gbUsbPortInfo.Controls.Add(this.gbRegOpt);
            this.gbUsbPortInfo.Controls.Add(this.btnDebug);
            this.gbUsbPortInfo.Controls.Add(this.gbUsbLookUp);
            this.gbUsbPortInfo.Controls.Add(this.btnReadUsbDevice);
            this.gbUsbPortInfo.Controls.Add(this.btnWriteUsbDevice);
            this.gbUsbPortInfo.Controls.Add(this.btnCloseDevice);
            this.gbUsbPortInfo.Controls.Add(this.btnOpenDevice);
            this.gbUsbPortInfo.Location = new System.Drawing.Point(5, 12);
            this.gbUsbPortInfo.Name = "gbUsbPortInfo";
            this.gbUsbPortInfo.Size = new System.Drawing.Size(574, 620);
            this.gbUsbPortInfo.TabIndex = 4;
            this.gbUsbPortInfo.TabStop = false;
            this.gbUsbPortInfo.Text = "USB设备操作";
            // 
            // cbDebugEn
            // 
            this.cbDebugEn.AutoSize = true;
            this.cbDebugEn.Location = new System.Drawing.Point(550, 140);
            this.cbDebugEn.Name = "cbDebugEn";
            this.cbDebugEn.Size = new System.Drawing.Size(15, 14);
            this.cbDebugEn.TabIndex = 24;
            this.cbDebugEn.UseVisualStyleBackColor = true;
            this.cbDebugEn.CheckedChanged += new System.EventHandler(this.cbDebugEn_CheckedChanged);
            // 
            // btnStopEn
            // 
            this.btnStopEn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStopEn.Font = new System.Drawing.Font("Courier New", 9F);
            this.btnStopEn.Location = new System.Drawing.Point(502, 454);
            this.btnStopEn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStopEn.Name = "btnStopEn";
            this.btnStopEn.Size = new System.Drawing.Size(57, 25);
            this.btnStopEn.TabIndex = 23;
            this.btnStopEn.Text = "Stop";
            this.btnStopEn.UseVisualStyleBackColor = false;
            this.btnStopEn.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // gbUsbReadWriteOpt
            // 
            this.gbUsbReadWriteOpt.BackColor = System.Drawing.Color.Silver;
            this.gbUsbReadWriteOpt.Controls.Add(this.rtbUsbReadData);
            this.gbUsbReadWriteOpt.Controls.Add(this.rtbUsbWriteData);
            this.gbUsbReadWriteOpt.Controls.Add(this.label17);
            this.gbUsbReadWriteOpt.Location = new System.Drawing.Point(6, 192);
            this.gbUsbReadWriteOpt.Name = "gbUsbReadWriteOpt";
            this.gbUsbReadWriteOpt.Size = new System.Drawing.Size(487, 145);
            this.gbUsbReadWriteOpt.TabIndex = 0;
            this.gbUsbReadWriteOpt.TabStop = false;
            this.gbUsbReadWriteOpt.Text = "W/R数据配置/显示";
            // 
            // rtbUsbWriteData
            // 
            this.rtbUsbWriteData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbUsbWriteData.Location = new System.Drawing.Point(2, 39);
            this.rtbUsbWriteData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbUsbWriteData.Name = "rtbUsbWriteData";
            this.rtbUsbWriteData.Size = new System.Drawing.Size(483, 41);
            this.rtbUsbWriteData.TabIndex = 24;
            this.rtbUsbWriteData.Text = "写寄存器约束：十六进制，值之间使用空格隔开 。例：25 ff DE ...（不区分大小写）";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(1, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(483, 15);
            this.label17.TabIndex = 25;
            this.label17.Text = "00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F 10 11 12 13 14 15 16";
            // 
            // gbReadWriteDataStreamMonitor
            // 
            this.gbReadWriteDataStreamMonitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbReadWriteDataStreamMonitor.Controls.Add(this.rtbUsbReadWriteDataStreamMonitor);
            this.gbReadWriteDataStreamMonitor.Controls.Add(this.label13);
            this.gbReadWriteDataStreamMonitor.Location = new System.Drawing.Point(6, 340);
            this.gbReadWriteDataStreamMonitor.Name = "gbReadWriteDataStreamMonitor";
            this.gbReadWriteDataStreamMonitor.Size = new System.Drawing.Size(487, 113);
            this.gbReadWriteDataStreamMonitor.TabIndex = 22;
            this.gbReadWriteDataStreamMonitor.TabStop = false;
            this.gbReadWriteDataStreamMonitor.Text = "W/R数据流监控";
            // 
            // rtbUsbReadWriteDataStreamMonitor
            // 
            this.rtbUsbReadWriteDataStreamMonitor.BackColor = System.Drawing.SystemColors.Control;
            this.rtbUsbReadWriteDataStreamMonitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rtbUsbReadWriteDataStreamMonitor.Location = new System.Drawing.Point(2, 35);
            this.rtbUsbReadWriteDataStreamMonitor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbUsbReadWriteDataStreamMonitor.Name = "rtbUsbReadWriteDataStreamMonitor";
            this.rtbUsbReadWriteDataStreamMonitor.Size = new System.Drawing.Size(484, 75);
            this.rtbUsbReadWriteDataStreamMonitor.TabIndex = 13;
            this.rtbUsbReadWriteDataStreamMonitor.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(2, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(483, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F 10 11 12 13 14 15 16";
            // 
            // btnClearAllRtb
            // 
            this.btnClearAllRtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnClearAllRtb.Font = new System.Drawing.Font("Courier New", 9F);
            this.btnClearAllRtb.Location = new System.Drawing.Point(502, 559);
            this.btnClearAllRtb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearAllRtb.Name = "btnClearAllRtb";
            this.btnClearAllRtb.Size = new System.Drawing.Size(57, 25);
            this.btnClearAllRtb.TabIndex = 19;
            this.btnClearAllRtb.Text = "Clear";
            this.btnClearAllRtb.UseVisualStyleBackColor = false;
            this.btnClearAllRtb.Click += new System.EventHandler(this.btnClearAllRtb_Click);
            // 
            // gbUsbOptStatePrint
            // 
            this.gbUsbOptStatePrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbUsbOptStatePrint.Controls.Add(this.rtbUsbErrInfo);
            this.gbUsbOptStatePrint.Controls.Add(this.rtbUsbOptState);
            this.gbUsbOptStatePrint.Enabled = false;
            this.gbUsbOptStatePrint.Location = new System.Drawing.Point(6, 454);
            this.gbUsbOptStatePrint.Name = "gbUsbOptStatePrint";
            this.gbUsbOptStatePrint.Size = new System.Drawing.Size(487, 162);
            this.gbUsbOptStatePrint.TabIndex = 5;
            this.gbUsbOptStatePrint.TabStop = false;
            this.gbUsbOptStatePrint.Text = "USB状态/异常打印";
            // 
            // rtbUsbErrInfo
            // 
            this.rtbUsbErrInfo.BackColor = System.Drawing.SystemColors.Control;
            this.rtbUsbErrInfo.ForeColor = System.Drawing.Color.Red;
            this.rtbUsbErrInfo.Location = new System.Drawing.Point(4, 17);
            this.rtbUsbErrInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbUsbErrInfo.Name = "rtbUsbErrInfo";
            this.rtbUsbErrInfo.Size = new System.Drawing.Size(481, 67);
            this.rtbUsbErrInfo.TabIndex = 14;
            this.rtbUsbErrInfo.Text = "显示USB操作---异常状态\n";
            // 
            // rtbUsbOptState
            // 
            this.rtbUsbOptState.BackColor = System.Drawing.SystemColors.Control;
            this.rtbUsbOptState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rtbUsbOptState.Location = new System.Drawing.Point(4, 92);
            this.rtbUsbOptState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbUsbOptState.Name = "rtbUsbOptState";
            this.rtbUsbOptState.Size = new System.Drawing.Size(481, 70);
            this.rtbUsbOptState.TabIndex = 15;
            this.rtbUsbOptState.Text = "显示USB操作过程中的---无异常状态\n";
            // 
            // gbRegOpt
            // 
            this.gbRegOpt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbRegOpt.Controls.Add(this.label18);
            this.gbRegOpt.Controls.Add(this.label9);
            this.gbRegOpt.Controls.Add(this.nudOptDelayMs);
            this.gbRegOpt.Controls.Add(this.label6);
            this.gbRegOpt.Controls.Add(this.nudNetPortNum);
            this.gbRegOpt.Controls.Add(this.label15);
            this.gbRegOpt.Controls.Add(this.label16);
            this.gbRegOpt.Controls.Add(this.tbRegOptLength);
            this.gbRegOpt.Controls.Add(this.label14);
            this.gbRegOpt.Controls.Add(this.label5);
            this.gbRegOpt.Controls.Add(this.cmbUsbOtpType);
            this.gbRegOpt.Controls.Add(this.tbRegAddr);
            this.gbRegOpt.Controls.Add(this.label8);
            this.gbRegOpt.Controls.Add(this.cmbUsbDeviceType);
            this.gbRegOpt.Controls.Add(this.label7);
            this.gbRegOpt.Location = new System.Drawing.Point(6, 93);
            this.gbRegOpt.Name = "gbRegOpt";
            this.gbRegOpt.Size = new System.Drawing.Size(487, 97);
            this.gbRegOpt.TabIndex = 0;
            this.gbRegOpt.TabStop = false;
            this.gbRegOpt.Text = "寄存器操作";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Courier New", 9F);
            this.label18.Location = new System.Drawing.Point(356, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 15);
            this.label18.TabIndex = 33;
            this.label18.Text = "(ms)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 9F);
            this.label9.Location = new System.Drawing.Point(196, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "操作延时:";
            // 
            // nudOptDelayMs
            // 
            this.nudOptDelayMs.Enabled = false;
            this.nudOptDelayMs.Location = new System.Drawing.Point(273, 59);
            this.nudOptDelayMs.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudOptDelayMs.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudOptDelayMs.Name = "nudOptDelayMs";
            this.nudOptDelayMs.Size = new System.Drawing.Size(80, 21);
            this.nudOptDelayMs.TabIndex = 31;
            this.nudOptDelayMs.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 9F);
            this.label6.Location = new System.Drawing.Point(12, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "网口编号:";
            // 
            // nudNetPortNum
            // 
            this.nudNetPortNum.Enabled = false;
            this.nudNetPortNum.Location = new System.Drawing.Point(89, 62);
            this.nudNetPortNum.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nudNetPortNum.Name = "nudNetPortNum";
            this.nudNetPortNum.Size = new System.Drawing.Size(80, 21);
            this.nudNetPortNum.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Courier New", 9F);
            this.label15.Location = new System.Drawing.Point(196, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 15);
            this.label15.TabIndex = 27;
            this.label15.Text = "操作长度 :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Courier New", 9F);
            this.label16.Location = new System.Drawing.Point(359, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 15);
            this.label16.TabIndex = 28;
            this.label16.Text = "Hex";
            // 
            // tbRegOptLength
            // 
            this.tbRegOptLength.BackColor = System.Drawing.SystemColors.Control;
            this.tbRegOptLength.Location = new System.Drawing.Point(273, 38);
            this.tbRegOptLength.Name = "tbRegOptLength";
            this.tbRegOptLength.Size = new System.Drawing.Size(80, 21);
            this.tbRegOptLength.TabIndex = 26;
            this.tbRegOptLength.Text = "01";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Courier New", 9F);
            this.label14.Location = new System.Drawing.Point(12, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 15);
            this.label14.TabIndex = 25;
            this.label14.Text = "操作类型:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 9F);
            this.label5.Location = new System.Drawing.Point(196, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Reg首地址:";
            // 
            // cmbUsbOtpType
            // 
            this.cmbUsbOtpType.BackColor = System.Drawing.SystemColors.Control;
            this.cmbUsbOtpType.Enabled = false;
            this.cmbUsbOtpType.FormattingEnabled = true;
            this.cmbUsbOtpType.Items.AddRange(new object[] {
            "读操作",
            "写操作"});
            this.cmbUsbOtpType.Location = new System.Drawing.Point(89, 39);
            this.cmbUsbOtpType.Name = "cmbUsbOtpType";
            this.cmbUsbOtpType.Size = new System.Drawing.Size(80, 23);
            this.cmbUsbOtpType.TabIndex = 24;
            this.cmbUsbOtpType.Text = "写操作";
            // 
            // tbRegAddr
            // 
            this.tbRegAddr.BackColor = System.Drawing.SystemColors.Control;
            this.tbRegAddr.Location = new System.Drawing.Point(273, 17);
            this.tbRegAddr.Name = "tbRegAddr";
            this.tbRegAddr.Size = new System.Drawing.Size(80, 21);
            this.tbRegAddr.TabIndex = 14;
            this.tbRegAddr.Text = "02000023";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 9F);
            this.label8.Location = new System.Drawing.Point(359, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Hex";
            // 
            // cmbUsbDeviceType
            // 
            this.cmbUsbDeviceType.BackColor = System.Drawing.SystemColors.Control;
            this.cmbUsbDeviceType.Enabled = false;
            this.cmbUsbDeviceType.FormattingEnabled = true;
            this.cmbUsbDeviceType.Items.AddRange(new object[] {
            "发送卡",
            "接收卡",
            "多功能卡"});
            this.cmbUsbDeviceType.Location = new System.Drawing.Point(89, 17);
            this.cmbUsbDeviceType.Name = "cmbUsbDeviceType";
            this.cmbUsbDeviceType.Size = new System.Drawing.Size(80, 23);
            this.cmbUsbDeviceType.TabIndex = 19;
            this.cmbUsbDeviceType.Text = "接收卡";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 9F);
            this.label7.Location = new System.Drawing.Point(12, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "设备类型:";
            // 
            // btnDebug
            // 
            this.btnDebug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDebug.Enabled = false;
            this.btnDebug.Font = new System.Drawing.Font("Courier New", 9F);
            this.btnDebug.Location = new System.Drawing.Point(499, 114);
            this.btnDebug.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(66, 25);
            this.btnDebug.TabIndex = 20;
            this.btnDebug.Text = "Reg调试";
            this.btnDebug.UseVisualStyleBackColor = false;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // gbUsbLookUp
            // 
            this.gbUsbLookUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbUsbLookUp.Controls.Add(this.btnGetUsbPort);
            this.gbUsbLookUp.Controls.Add(this.cmbUsbDeviceInfoList);
            this.gbUsbLookUp.Controls.Add(this.label1);
            this.gbUsbLookUp.Controls.Add(this.cmbUsbDevicePidList);
            this.gbUsbLookUp.Controls.Add(this.cmbUsbDeviceVidList);
            this.gbUsbLookUp.Controls.Add(this.label2);
            this.gbUsbLookUp.Controls.Add(this.label4);
            this.gbUsbLookUp.Controls.Add(this.label3);
            this.gbUsbLookUp.Location = new System.Drawing.Point(6, 20);
            this.gbUsbLookUp.Name = "gbUsbLookUp";
            this.gbUsbLookUp.Size = new System.Drawing.Size(487, 72);
            this.gbUsbLookUp.TabIndex = 0;
            this.gbUsbLookUp.TabStop = false;
            this.gbUsbLookUp.Text = "USB设备搜索";
            // 
            // cmbUsbDevicePidList
            // 
            this.cmbUsbDevicePidList.BackColor = System.Drawing.SystemColors.Control;
            this.cmbUsbDevicePidList.Font = new System.Drawing.Font("Courier New", 9F);
            this.cmbUsbDevicePidList.FormattingEnabled = true;
            this.cmbUsbDevicePidList.Location = new System.Drawing.Point(230, 37);
            this.cmbUsbDevicePidList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbUsbDevicePidList.Name = "cmbUsbDevicePidList";
            this.cmbUsbDevicePidList.Size = new System.Drawing.Size(65, 23);
            this.cmbUsbDevicePidList.TabIndex = 4;
            this.cmbUsbDevicePidList.SelectedIndexChanged += new System.EventHandler(this.cmbUsbDevicePidList_SelectedIndexChanged);
            // 
            // cmbUsbDeviceVidList
            // 
            this.cmbUsbDeviceVidList.BackColor = System.Drawing.SystemColors.Control;
            this.cmbUsbDeviceVidList.Font = new System.Drawing.Font("Courier New", 9F);
            this.cmbUsbDeviceVidList.FormattingEnabled = true;
            this.cmbUsbDeviceVidList.Location = new System.Drawing.Point(297, 37);
            this.cmbUsbDeviceVidList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbUsbDeviceVidList.Name = "cmbUsbDeviceVidList";
            this.cmbUsbDeviceVidList.Size = new System.Drawing.Size(65, 23);
            this.cmbUsbDeviceVidList.TabIndex = 5;
            this.cmbUsbDeviceVidList.SelectedIndexChanged += new System.EventHandler(this.cmbUsbDeviceVidList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F);
            this.label2.Location = new System.Drawing.Point(115, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "设备信息";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("等线", 9F);
            this.label4.Location = new System.Drawing.Point(304, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "设备VID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "设备PID";
            // 
            // btnReadUsbDevice
            // 
            this.btnReadUsbDevice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReadUsbDevice.Enabled = false;
            this.btnReadUsbDevice.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadUsbDevice.Location = new System.Drawing.Point(500, 309);
            this.btnReadUsbDevice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReadUsbDevice.Name = "btnReadUsbDevice";
            this.btnReadUsbDevice.Size = new System.Drawing.Size(66, 25);
            this.btnReadUsbDevice.TabIndex = 11;
            this.btnReadUsbDevice.Text = "Read";
            this.btnReadUsbDevice.UseVisualStyleBackColor = false;
            this.btnReadUsbDevice.Click += new System.EventHandler(this.btnReadUsbDevice_Click);
            // 
            // btnWriteUsbDevice
            // 
            this.btnWriteUsbDevice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWriteUsbDevice.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteUsbDevice.Location = new System.Drawing.Point(500, 247);
            this.btnWriteUsbDevice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWriteUsbDevice.Name = "btnWriteUsbDevice";
            this.btnWriteUsbDevice.Size = new System.Drawing.Size(66, 25);
            this.btnWriteUsbDevice.TabIndex = 12;
            this.btnWriteUsbDevice.Text = "Write";
            this.btnWriteUsbDevice.UseVisualStyleBackColor = false;
            this.btnWriteUsbDevice.Click += new System.EventHandler(this.btnWriteUsbDevice_Click);
            // 
            // btnCloseDevice
            // 
            this.btnCloseDevice.Font = new System.Drawing.Font("Courier New", 9F);
            this.btnCloseDevice.Location = new System.Drawing.Point(499, 67);
            this.btnCloseDevice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCloseDevice.Name = "btnCloseDevice";
            this.btnCloseDevice.Size = new System.Drawing.Size(66, 25);
            this.btnCloseDevice.TabIndex = 9;
            this.btnCloseDevice.Text = "关闭USB";
            this.btnCloseDevice.UseVisualStyleBackColor = true;
            this.btnCloseDevice.Click += new System.EventHandler(this.btnCloseDevice_Click);
            // 
            // btnOpenDevice
            // 
            this.btnOpenDevice.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenDevice.Location = new System.Drawing.Point(499, 28);
            this.btnOpenDevice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenDevice.Name = "btnOpenDevice";
            this.btnOpenDevice.Size = new System.Drawing.Size(66, 25);
            this.btnOpenDevice.TabIndex = 10;
            this.btnOpenDevice.Text = "打开USB";
            this.btnOpenDevice.UseVisualStyleBackColor = true;
            this.btnOpenDevice.Click += new System.EventHandler(this.btnOpenDevice_Click);
            // 
            // gbTestItem
            // 
            this.gbTestItem.Controls.Add(this.gbCommonPart);
            this.gbTestItem.Controls.Add(this.tcTest);
            this.gbTestItem.Location = new System.Drawing.Point(585, 12);
            this.gbTestItem.Name = "gbTestItem";
            this.gbTestItem.Size = new System.Drawing.Size(707, 620);
            this.gbTestItem.TabIndex = 5;
            this.gbTestItem.TabStop = false;
            this.gbTestItem.Text = "接口/驱动/控制---自动化集";
            // 
            // gbCommonPart
            // 
            this.gbCommonPart.Controls.Add(this.groupBox2);
            this.gbCommonPart.Controls.Add(this.cmbChipCorner);
            this.gbCommonPart.Controls.Add(this.lbChipCorner);
            this.gbCommonPart.Controls.Add(this.lbNote);
            this.gbCommonPart.Controls.Add(this.gbPwrCHNSel);
            this.gbCommonPart.Controls.Add(this.label32);
            this.gbCommonPart.Controls.Add(this.cbMultiSelEn1);
            this.gbCommonPart.Controls.Add(this.tbInstMultiAddr1);
            this.gbCommonPart.Controls.Add(this.cbMultiSelEn);
            this.gbCommonPart.Controls.Add(this.cbPowerSelEn);
            this.gbCommonPart.Controls.Add(this.label28);
            this.gbCommonPart.Controls.Add(this.tbInstMultiAddr);
            this.gbCommonPart.Controls.Add(this.label27);
            this.gbCommonPart.Controls.Add(this.tbInstPowerAddr);
            this.gbCommonPart.Controls.Add(this.tbChipID);
            this.gbCommonPart.Controls.Add(this.label12);
            this.gbCommonPart.Controls.Add(this.label11);
            this.gbCommonPart.Controls.Add(this.tbTestMessage);
            this.gbCommonPart.Controls.Add(this.label10);
            this.gbCommonPart.Controls.Add(this.textBox1);
            this.gbCommonPart.Location = new System.Drawing.Point(10, 20);
            this.gbCommonPart.Name = "gbCommonPart";
            this.gbCommonPart.Size = new System.Drawing.Size(691, 178);
            this.gbCommonPart.TabIndex = 1;
            this.gbCommonPart.TabStop = false;
            this.gbCommonPart.Text = "公共配置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbVoltCaseSel);
            this.groupBox2.Controls.Add(this.lbTemp);
            this.groupBox2.Controls.Add(this.cmbTempCaseSel);
            this.groupBox2.Controls.Add(this.lbVolt);
            this.groupBox2.Location = new System.Drawing.Point(379, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 52);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Volt-TempCaseSel";
            // 
            // cmbVoltCaseSel
            // 
            this.cmbVoltCaseSel.BackColor = System.Drawing.SystemColors.Control;
            this.cmbVoltCaseSel.FormattingEnabled = true;
            this.cmbVoltCaseSel.Items.AddRange(new object[] {
            "LV",
            "NV",
            "HV"});
            this.cmbVoltCaseSel.Location = new System.Drawing.Point(206, 23);
            this.cmbVoltCaseSel.Name = "cmbVoltCaseSel";
            this.cmbVoltCaseSel.Size = new System.Drawing.Size(76, 23);
            this.cmbVoltCaseSel.TabIndex = 80;
            this.cmbVoltCaseSel.Text = "NV";
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemp.Location = new System.Drawing.Point(161, 26);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(49, 15);
            this.lbTemp.TabIndex = 81;
            this.lbTemp.Text = "Volt：";
            // 
            // cmbTempCaseSel
            // 
            this.cmbTempCaseSel.BackColor = System.Drawing.SystemColors.Control;
            this.cmbTempCaseSel.FormattingEnabled = true;
            this.cmbTempCaseSel.Items.AddRange(new object[] {
            "LT",
            "NT",
            "HT"});
            this.cmbTempCaseSel.Location = new System.Drawing.Point(52, 23);
            this.cmbTempCaseSel.Name = "cmbTempCaseSel";
            this.cmbTempCaseSel.Size = new System.Drawing.Size(74, 23);
            this.cmbTempCaseSel.TabIndex = 78;
            this.cmbTempCaseSel.Text = "NT";
            // 
            // lbVolt
            // 
            this.lbVolt.AutoSize = true;
            this.lbVolt.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVolt.Location = new System.Drawing.Point(7, 26);
            this.lbVolt.Name = "lbVolt";
            this.lbVolt.Size = new System.Drawing.Size(49, 15);
            this.lbVolt.TabIndex = 79;
            this.lbVolt.Text = "Temp：";
            // 
            // cmbChipCorner
            // 
            this.cmbChipCorner.BackColor = System.Drawing.SystemColors.Control;
            this.cmbChipCorner.FormattingEnabled = true;
            this.cmbChipCorner.Items.AddRange(new object[] {
            "TT",
            "FF",
            "SS",
            "FS",
            "SF",
            "SSS",
            "FFF"});
            this.cmbChipCorner.Location = new System.Drawing.Point(460, 44);
            this.cmbChipCorner.Name = "cmbChipCorner";
            this.cmbChipCorner.Size = new System.Drawing.Size(57, 23);
            this.cmbChipCorner.TabIndex = 47;
            this.cmbChipCorner.Text = "TT";
            // 
            // lbChipCorner
            // 
            this.lbChipCorner.AutoSize = true;
            this.lbChipCorner.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChipCorner.Location = new System.Drawing.Point(376, 47);
            this.lbChipCorner.Name = "lbChipCorner";
            this.lbChipCorner.Size = new System.Drawing.Size(91, 15);
            this.lbChipCorner.TabIndex = 74;
            this.lbChipCorner.Text = "ChipCorner：";
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.ForeColor = System.Drawing.Color.IndianRed;
            this.lbNote.Location = new System.Drawing.Point(27, 155);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(245, 15);
            this.lbNote.TabIndex = 73;
            this.lbNote.Text = "Notes:与电流相关的测试,需2个万用表";
            // 
            // gbPwrCHNSel
            // 
            this.gbPwrCHNSel.Controls.Add(this.cbPwrType);
            this.gbPwrCHNSel.Controls.Add(this.cbEnPwrCH4);
            this.gbPwrCHNSel.Controls.Add(this.cbEnPwrCH3);
            this.gbPwrCHNSel.Controls.Add(this.cbEnPwrCH1);
            this.gbPwrCHNSel.Controls.Add(this.cbEnPwrCH2);
            this.gbPwrCHNSel.Location = new System.Drawing.Point(379, 70);
            this.gbPwrCHNSel.Name = "gbPwrCHNSel";
            this.gbPwrCHNSel.Size = new System.Drawing.Size(301, 42);
            this.gbPwrCHNSel.TabIndex = 72;
            this.gbPwrCHNSel.TabStop = false;
            this.gbPwrCHNSel.Text = "PwrTypeAndChnSel";
            // 
            // cbPwrType
            // 
            this.cbPwrType.AutoSize = true;
            this.cbPwrType.Location = new System.Drawing.Point(210, 17);
            this.cbPwrType.Name = "cbPwrType";
            this.cbPwrType.Size = new System.Drawing.Size(82, 19);
            this.cbPwrType.TabIndex = 76;
            this.cbPwrType.Text = "Keysight";
            this.cbPwrType.UseVisualStyleBackColor = true;
            // 
            // cbEnPwrCH4
            // 
            this.cbEnPwrCH4.AutoSize = true;
            this.cbEnPwrCH4.Location = new System.Drawing.Point(157, 17);
            this.cbEnPwrCH4.Name = "cbEnPwrCH4";
            this.cbEnPwrCH4.Size = new System.Drawing.Size(47, 19);
            this.cbEnPwrCH4.TabIndex = 75;
            this.cbEnPwrCH4.Text = "CH4";
            this.cbEnPwrCH4.UseVisualStyleBackColor = true;
            // 
            // cbEnPwrCH3
            // 
            this.cbEnPwrCH3.AutoSize = true;
            this.cbEnPwrCH3.Location = new System.Drawing.Point(104, 17);
            this.cbEnPwrCH3.Name = "cbEnPwrCH3";
            this.cbEnPwrCH3.Size = new System.Drawing.Size(47, 19);
            this.cbEnPwrCH3.TabIndex = 74;
            this.cbEnPwrCH3.Text = "CH3";
            this.cbEnPwrCH3.UseVisualStyleBackColor = true;
            // 
            // cbEnPwrCH1
            // 
            this.cbEnPwrCH1.AutoSize = true;
            this.cbEnPwrCH1.Checked = true;
            this.cbEnPwrCH1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEnPwrCH1.Location = new System.Drawing.Point(6, 17);
            this.cbEnPwrCH1.Name = "cbEnPwrCH1";
            this.cbEnPwrCH1.Size = new System.Drawing.Size(47, 19);
            this.cbEnPwrCH1.TabIndex = 73;
            this.cbEnPwrCH1.Text = "CH1";
            this.cbEnPwrCH1.UseVisualStyleBackColor = true;
            // 
            // cbEnPwrCH2
            // 
            this.cbEnPwrCH2.AutoSize = true;
            this.cbEnPwrCH2.Location = new System.Drawing.Point(55, 17);
            this.cbEnPwrCH2.Name = "cbEnPwrCH2";
            this.cbEnPwrCH2.Size = new System.Drawing.Size(47, 19);
            this.cbEnPwrCH2.TabIndex = 72;
            this.cbEnPwrCH2.Text = "CH2";
            this.cbEnPwrCH2.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(27, 129);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(91, 15);
            this.label32.TabIndex = 70;
            this.label32.Text = "万用表Addr1:";
            // 
            // cbMultiSelEn1
            // 
            this.cbMultiSelEn1.AutoSize = true;
            this.cbMultiSelEn1.Location = new System.Drawing.Point(337, 130);
            this.cbMultiSelEn1.Name = "cbMultiSelEn1";
            this.cbMultiSelEn1.Size = new System.Drawing.Size(15, 14);
            this.cbMultiSelEn1.TabIndex = 69;
            this.cbMultiSelEn1.UseVisualStyleBackColor = true;
            this.cbMultiSelEn1.CheckedChanged += new System.EventHandler(this.cbMultiSelEn_CheckedChanged);
            // 
            // tbInstMultiAddr1
            // 
            this.tbInstMultiAddr1.BackColor = System.Drawing.SystemColors.Control;
            this.tbInstMultiAddr1.Enabled = false;
            this.tbInstMultiAddr1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInstMultiAddr1.ForeColor = System.Drawing.Color.Black;
            this.tbInstMultiAddr1.Location = new System.Drawing.Point(131, 125);
            this.tbInstMultiAddr1.Name = "tbInstMultiAddr1";
            this.tbInstMultiAddr1.Size = new System.Drawing.Size(203, 21);
            this.tbInstMultiAddr1.TabIndex = 68;
            this.tbInstMultiAddr1.Text = "请输入万用表地址";
            // 
            // cbMultiSelEn
            // 
            this.cbMultiSelEn.AutoSize = true;
            this.cbMultiSelEn.Checked = true;
            this.cbMultiSelEn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMultiSelEn.Location = new System.Drawing.Point(337, 103);
            this.cbMultiSelEn.Name = "cbMultiSelEn";
            this.cbMultiSelEn.Size = new System.Drawing.Size(15, 14);
            this.cbMultiSelEn.TabIndex = 67;
            this.cbMultiSelEn.UseVisualStyleBackColor = true;
            this.cbMultiSelEn.CheckedChanged += new System.EventHandler(this.cbMultiSelEn_CheckedChanged);
            // 
            // cbPowerSelEn
            // 
            this.cbPowerSelEn.AutoSize = true;
            this.cbPowerSelEn.Checked = true;
            this.cbPowerSelEn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPowerSelEn.Location = new System.Drawing.Point(337, 77);
            this.cbPowerSelEn.Name = "cbPowerSelEn";
            this.cbPowerSelEn.Size = new System.Drawing.Size(15, 14);
            this.cbPowerSelEn.TabIndex = 66;
            this.cbPowerSelEn.UseVisualStyleBackColor = true;
            this.cbPowerSelEn.CheckedChanged += new System.EventHandler(this.cbMultiSelEn_CheckedChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(27, 100);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(91, 15);
            this.label28.TabIndex = 65;
            this.label28.Text = "万用表Addr0:";
            // 
            // tbInstMultiAddr
            // 
            this.tbInstMultiAddr.BackColor = System.Drawing.SystemColors.Control;
            this.tbInstMultiAddr.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInstMultiAddr.ForeColor = System.Drawing.Color.Black;
            this.tbInstMultiAddr.Location = new System.Drawing.Point(131, 98);
            this.tbInstMultiAddr.Name = "tbInstMultiAddr";
            this.tbInstMultiAddr.Size = new System.Drawing.Size(203, 21);
            this.tbInstMultiAddr.TabIndex = 64;
            this.tbInstMultiAddr.Text = "USB0::0x2A8D::0x0301::MY60010884::INSTR";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(48, 72);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(70, 15);
            this.label27.TabIndex = 63;
            this.label27.Text = "电源地址:";
            // 
            // tbInstPowerAddr
            // 
            this.tbInstPowerAddr.BackColor = System.Drawing.SystemColors.Control;
            this.tbInstPowerAddr.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInstPowerAddr.ForeColor = System.Drawing.Color.Black;
            this.tbInstPowerAddr.Location = new System.Drawing.Point(131, 70);
            this.tbInstPowerAddr.Name = "tbInstPowerAddr";
            this.tbInstPowerAddr.Size = new System.Drawing.Size(203, 21);
            this.tbInstPowerAddr.TabIndex = 62;
            this.tbInstPowerAddr.Text = "ASRL4::INSTR";
            // 
            // tbChipID
            // 
            this.tbChipID.BackColor = System.Drawing.SystemColors.Control;
            this.tbChipID.Font = new System.Drawing.Font("Courier New", 9F);
            this.tbChipID.ForeColor = System.Drawing.Color.Black;
            this.tbChipID.Location = new System.Drawing.Point(595, 44);
            this.tbChipID.Name = "tbChipID";
            this.tbChipID.Size = new System.Drawing.Size(85, 21);
            this.tbChipID.TabIndex = 61;
            this.tbChipID.Text = "N001";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(519, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 15);
            this.label12.TabIndex = 60;
            this.label12.Text = "芯片编号:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(48, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 59;
            this.label11.Text = "测试信息:";
            // 
            // tbTestMessage
            // 
            this.tbTestMessage.BackColor = System.Drawing.SystemColors.Control;
            this.tbTestMessage.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTestMessage.ForeColor = System.Drawing.Color.Black;
            this.tbTestMessage.Location = new System.Drawing.Point(131, 44);
            this.tbTestMessage.Name = "tbTestMessage";
            this.tbTestMessage.Size = new System.Drawing.Size(203, 21);
            this.tbTestMessage.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 9F);
            this.label10.Location = new System.Drawing.Point(6, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "寄存器表单路径:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(131, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(549, 21);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "E:\\mazewei\\LearningFile\\VS_Project\\ChipAutoCtrl\\AutoCtrl\\bin\\Debug\\Source\\Registe" +
    "r\\Register_Table.xlsx";
            // 
            // tcTest
            // 
            this.tcTest.Controls.Add(this.tbpDriverIc);
            this.tcTest.Controls.Add(this.tbpInterfaceIC);
            this.tcTest.Controls.Add(this.tbpControlIC);
            this.tcTest.Location = new System.Drawing.Point(6, 204);
            this.tcTest.Name = "tcTest";
            this.tcTest.SelectedIndex = 0;
            this.tcTest.Size = new System.Drawing.Size(707, 416);
            this.tcTest.TabIndex = 0;
            this.tcTest.Tag = "";
            // 
            // tbpDriverIc
            // 
            this.tbpDriverIc.BackColor = System.Drawing.SystemColors.Control;
            this.tbpDriverIc.Controls.Add(this.groupBox1);
            this.tbpDriverIc.Controls.Add(this.gbRegConfig);
            this.tbpDriverIc.Controls.Add(this.tbAtbResult);
            this.tbpDriverIc.Controls.Add(this.rtbDispaly);
            this.tbpDriverIc.Controls.Add(this.label31);
            this.tbpDriverIc.Controls.Add(this.btnAtbRead);
            this.tbpDriverIc.Controls.Add(this.btnStop);
            this.tbpDriverIc.Controls.Add(this.btnStart);
            this.tbpDriverIc.Controls.Add(this.label30);
            this.tbpDriverIc.Controls.Add(this.cbTestCase);
            this.tbpDriverIc.Controls.Add(this.label29);
            this.tbpDriverIc.Controls.Add(this.cbProjectItems);
            this.tbpDriverIc.Controls.Add(this.label24);
            this.tbpDriverIc.Controls.Add(this.cmbAtbNodeName);
            this.tbpDriverIc.Location = new System.Drawing.Point(4, 24);
            this.tbpDriverIc.Name = "tbpDriverIc";
            this.tbpDriverIc.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDriverIc.Size = new System.Drawing.Size(699, 388);
            this.tbpDriverIc.TabIndex = 0;
            this.tbpDriverIc.Text = "驱动";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.cbDriverRedChipEn);
            this.groupBox1.Controls.Add(this.cbDriverGreenChipEn);
            this.groupBox1.Controls.Add(this.cbDriverBlueChipEn);
            this.groupBox1.Location = new System.Drawing.Point(6, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 41);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ChipTypeSel";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(8, 19);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(70, 15);
            this.label25.TabIndex = 32;
            this.label25.Text = "配置选择:";
            // 
            // cbDriverRedChipEn
            // 
            this.cbDriverRedChipEn.AutoSize = true;
            this.cbDriverRedChipEn.Checked = true;
            this.cbDriverRedChipEn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDriverRedChipEn.Location = new System.Drawing.Point(86, 18);
            this.cbDriverRedChipEn.Name = "cbDriverRedChipEn";
            this.cbDriverRedChipEn.Size = new System.Drawing.Size(33, 19);
            this.cbDriverRedChipEn.TabIndex = 25;
            this.cbDriverRedChipEn.Text = "R";
            this.cbDriverRedChipEn.UseVisualStyleBackColor = true;
            // 
            // cbDriverGreenChipEn
            // 
            this.cbDriverGreenChipEn.AutoSize = true;
            this.cbDriverGreenChipEn.Checked = true;
            this.cbDriverGreenChipEn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDriverGreenChipEn.Location = new System.Drawing.Point(119, 18);
            this.cbDriverGreenChipEn.Name = "cbDriverGreenChipEn";
            this.cbDriverGreenChipEn.Size = new System.Drawing.Size(33, 19);
            this.cbDriverGreenChipEn.TabIndex = 26;
            this.cbDriverGreenChipEn.Text = "G";
            this.cbDriverGreenChipEn.UseVisualStyleBackColor = true;
            // 
            // cbDriverBlueChipEn
            // 
            this.cbDriverBlueChipEn.AutoSize = true;
            this.cbDriverBlueChipEn.Checked = true;
            this.cbDriverBlueChipEn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDriverBlueChipEn.Location = new System.Drawing.Point(154, 18);
            this.cbDriverBlueChipEn.Name = "cbDriverBlueChipEn";
            this.cbDriverBlueChipEn.Size = new System.Drawing.Size(33, 19);
            this.cbDriverBlueChipEn.TabIndex = 27;
            this.cbDriverBlueChipEn.Text = "B";
            this.cbDriverBlueChipEn.UseVisualStyleBackColor = true;
            // 
            // gbRegConfig
            // 
            this.gbRegConfig.BackColor = System.Drawing.Color.LightCyan;
            this.gbRegConfig.Controls.Add(this.btnManualConfig);
            this.gbRegConfig.Controls.Add(this.tbVbgSet);
            this.gbRegConfig.Controls.Add(this.label21);
            this.gbRegConfig.Controls.Add(this.tbDriverRegValue);
            this.gbRegConfig.Controls.Add(this.btnRegWrite);
            this.gbRegConfig.Controls.Add(this.tbDriverRegAddr);
            this.gbRegConfig.Controls.Add(this.label20);
            this.gbRegConfig.Controls.Add(this.label22);
            this.gbRegConfig.Location = new System.Drawing.Point(6, 6);
            this.gbRegConfig.Name = "gbRegConfig";
            this.gbRegConfig.Size = new System.Drawing.Size(234, 125);
            this.gbRegConfig.TabIndex = 46;
            this.gbRegConfig.TabStop = false;
            this.gbRegConfig.Text = "RegManualConfig(hex)";
            // 
            // btnManualConfig
            // 
            this.btnManualConfig.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnManualConfig.Location = new System.Drawing.Point(148, 78);
            this.btnManualConfig.Name = "btnManualConfig";
            this.btnManualConfig.Size = new System.Drawing.Size(58, 31);
            this.btnManualConfig.TabIndex = 50;
            this.btnManualConfig.Text = "Config";
            this.btnManualConfig.UseVisualStyleBackColor = false;
            this.btnManualConfig.Click += new System.EventHandler(this.btnManualConfig_Click);
            // 
            // tbVbgSet
            // 
            this.tbVbgSet.BackColor = System.Drawing.SystemColors.Control;
            this.tbVbgSet.Location = new System.Drawing.Point(54, 83);
            this.tbVbgSet.Name = "tbVbgSet";
            this.tbVbgSet.Size = new System.Drawing.Size(77, 21);
            this.tbVbgSet.TabIndex = 46;
            this.tbVbgSet.Text = "1.200";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Courier New", 9F);
            this.label21.Location = new System.Drawing.Point(19, 86);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 15);
            this.label21.TabIndex = 47;
            this.label21.Text = "VBG:";
            // 
            // tbDriverRegValue
            // 
            this.tbDriverRegValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbDriverRegValue.Location = new System.Drawing.Point(54, 45);
            this.tbDriverRegValue.Name = "tbDriverRegValue";
            this.tbDriverRegValue.Size = new System.Drawing.Size(77, 21);
            this.tbDriverRegValue.TabIndex = 28;
            this.tbDriverRegValue.Text = "0001";
            // 
            // btnRegWrite
            // 
            this.btnRegWrite.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnRegWrite.Location = new System.Drawing.Point(148, 27);
            this.btnRegWrite.Name = "btnRegWrite";
            this.btnRegWrite.Size = new System.Drawing.Size(58, 31);
            this.btnRegWrite.TabIndex = 45;
            this.btnRegWrite.Text = "Write";
            this.btnRegWrite.UseVisualStyleBackColor = false;
            this.btnRegWrite.Click += new System.EventHandler(this.btnRegWrite_Click);
            // 
            // tbDriverRegAddr
            // 
            this.tbDriverRegAddr.BackColor = System.Drawing.SystemColors.Control;
            this.tbDriverRegAddr.Location = new System.Drawing.Point(54, 24);
            this.tbDriverRegAddr.Name = "tbDriverRegAddr";
            this.tbDriverRegAddr.Size = new System.Drawing.Size(77, 21);
            this.tbDriverRegAddr.TabIndex = 22;
            this.tbDriverRegAddr.Text = "1F";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Courier New", 9F);
            this.label20.Location = new System.Drawing.Point(15, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 15);
            this.label20.TabIndex = 23;
            this.label20.Text = "Addr:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Courier New", 9F);
            this.label22.Location = new System.Drawing.Point(8, 48);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 15);
            this.label22.TabIndex = 29;
            this.label22.Text = "Value:";
            // 
            // tbAtbResult
            // 
            this.tbAtbResult.Location = new System.Drawing.Point(455, 46);
            this.tbAtbResult.Name = "tbAtbResult";
            this.tbAtbResult.Size = new System.Drawing.Size(128, 21);
            this.tbAtbResult.TabIndex = 44;
            // 
            // rtbDispaly
            // 
            this.rtbDispaly.Location = new System.Drawing.Point(287, 75);
            this.rtbDispaly.Name = "rtbDispaly";
            this.rtbDispaly.Size = new System.Drawing.Size(410, 313);
            this.rtbDispaly.TabIndex = 40;
            this.rtbDispaly.Text = "";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(393, 49);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(56, 15);
            this.label31.TabIndex = 42;
            this.label31.Text = "Result:";
            // 
            // btnAtbRead
            // 
            this.btnAtbRead.Location = new System.Drawing.Point(611, 46);
            this.btnAtbRead.Name = "btnAtbRead";
            this.btnAtbRead.Size = new System.Drawing.Size(60, 23);
            this.btnAtbRead.TabIndex = 41;
            this.btnAtbRead.Text = "Read";
            this.btnAtbRead.UseVisualStyleBackColor = true;
            this.btnAtbRead.Click += new System.EventHandler(this.btnAtbRead_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(149, 273);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(76, 35);
            this.btnStop.TabIndex = 39;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(17, 273);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(76, 35);
            this.btnStart.TabIndex = 38;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(31, 229);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(70, 15);
            this.label30.TabIndex = 37;
            this.label30.Text = "TestCase:";
            // 
            // cbTestCase
            // 
            this.cbTestCase.FormattingEnabled = true;
            this.cbTestCase.Items.AddRange(new object[] {
            "ATB_Scan",
            "VBG_Trim",
            "GCC_IFIX",
            "PreDrv",
            "Drv_PAM",
            "Regulator_Trim",
            "VBG_Vmin",
            "Bias400u_Vmin",
            "Regulator_Vmin"});
            this.cbTestCase.Location = new System.Drawing.Point(107, 226);
            this.cbTestCase.Name = "cbTestCase";
            this.cbTestCase.Size = new System.Drawing.Size(133, 23);
            this.cbTestCase.TabIndex = 36;
            this.cbTestCase.Text = "ATB_Scan";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(3, 197);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(98, 15);
            this.label29.TabIndex = 35;
            this.label29.Text = "ProjectItems:";
            // 
            // cbProjectItems
            // 
            this.cbProjectItems.FormattingEnabled = true;
            this.cbProjectItems.Items.AddRange(new object[] {
            "P2218_V20X",
            "P2318_V100",
            "P2318R_V100",
            "P2218R_V100",
            "P2216R_V100",
            "P2316R_V100",
            "P3268_V300",
            "P3288_V100",
            "P1287_V10X"});
            this.cbProjectItems.Location = new System.Drawing.Point(107, 194);
            this.cbProjectItems.Name = "cbProjectItems";
            this.cbProjectItems.Size = new System.Drawing.Size(133, 23);
            this.cbProjectItems.TabIndex = 34;
            this.cbProjectItems.Text = "P2318R_V100";
            this.cbProjectItems.SelectedIndexChanged += new System.EventHandler(this.cbProjectItems_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(386, 18);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(63, 15);
            this.label24.TabIndex = 31;
            this.label24.Text = "ATB选择:";
            // 
            // cmbAtbNodeName
            // 
            this.cmbAtbNodeName.BackColor = System.Drawing.SystemColors.Window;
            this.cmbAtbNodeName.FormattingEnabled = true;
            this.cmbAtbNodeName.Location = new System.Drawing.Point(455, 16);
            this.cmbAtbNodeName.Name = "cmbAtbNodeName";
            this.cmbAtbNodeName.Size = new System.Drawing.Size(216, 23);
            this.cmbAtbNodeName.TabIndex = 6;
            this.cmbAtbNodeName.SelectedIndexChanged += new System.EventHandler(this.cmbAtbNodeName_SelectedIndexChanged);
            // 
            // tbpInterfaceIC
            // 
            this.tbpInterfaceIC.BackColor = System.Drawing.SystemColors.Control;
            this.tbpInterfaceIC.Controls.Add(this.gbChipLocationSel);
            this.tbpInterfaceIC.Controls.Add(this.btnInterChipStop);
            this.tbpInterfaceIC.Controls.Add(this.btnInterChipStart);
            this.tbpInterfaceIC.Controls.Add(this.label36);
            this.tbpInterfaceIC.Controls.Add(this.cbInterChipTestCase);
            this.tbpInterfaceIC.Controls.Add(this.label37);
            this.tbpInterfaceIC.Controls.Add(this.cbInterChipProjectItems);
            this.tbpInterfaceIC.Controls.Add(this.rtbInterChipDisPlay);
            this.tbpInterfaceIC.Controls.Add(this.tbInterChipAtbResult);
            this.tbpInterfaceIC.Controls.Add(this.label34);
            this.tbpInterfaceIC.Controls.Add(this.btnInterChipAtbRead);
            this.tbpInterfaceIC.Controls.Add(this.label35);
            this.tbpInterfaceIC.Controls.Add(this.cmbInterChipAtbName);
            this.tbpInterfaceIC.Controls.Add(this.gbInterChipConfig);
            this.tbpInterfaceIC.Location = new System.Drawing.Point(4, 24);
            this.tbpInterfaceIC.Name = "tbpInterfaceIC";
            this.tbpInterfaceIC.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInterfaceIC.Size = new System.Drawing.Size(699, 388);
            this.tbpInterfaceIC.TabIndex = 1;
            this.tbpInterfaceIC.Text = "接口";
            // 
            // gbChipLocationSel
            // 
            this.gbChipLocationSel.Controls.Add(this.cbEnChip0);
            this.gbChipLocationSel.Controls.Add(this.cbEnChip1);
            this.gbChipLocationSel.Location = new System.Drawing.Point(6, 137);
            this.gbChipLocationSel.Name = "gbChipLocationSel";
            this.gbChipLocationSel.Size = new System.Drawing.Size(234, 38);
            this.gbChipLocationSel.TabIndex = 77;
            this.gbChipLocationSel.TabStop = false;
            this.gbChipLocationSel.Text = "ChipLocationSel";
            // 
            // cbEnChip0
            // 
            this.cbEnChip0.AutoSize = true;
            this.cbEnChip0.Checked = true;
            this.cbEnChip0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEnChip0.Location = new System.Drawing.Point(6, 17);
            this.cbEnChip0.Name = "cbEnChip0";
            this.cbEnChip0.Size = new System.Drawing.Size(61, 19);
            this.cbEnChip0.TabIndex = 73;
            this.cbEnChip0.Text = "CHIP1";
            this.cbEnChip0.UseVisualStyleBackColor = true;
            this.cbEnChip0.CheckedChanged += new System.EventHandler(this.cbEnChip0_CheckedChanged);
            // 
            // cbEnChip1
            // 
            this.cbEnChip1.AutoSize = true;
            this.cbEnChip1.Location = new System.Drawing.Point(73, 17);
            this.cbEnChip1.Name = "cbEnChip1";
            this.cbEnChip1.Size = new System.Drawing.Size(61, 19);
            this.cbEnChip1.TabIndex = 72;
            this.cbEnChip1.Text = "CHIP2";
            this.cbEnChip1.UseVisualStyleBackColor = true;
            this.cbEnChip1.CheckedChanged += new System.EventHandler(this.cbEnChip1_CheckedChanged);
            // 
            // btnInterChipStop
            // 
            this.btnInterChipStop.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterChipStop.Location = new System.Drawing.Point(149, 272);
            this.btnInterChipStop.Name = "btnInterChipStop";
            this.btnInterChipStop.Size = new System.Drawing.Size(76, 35);
            this.btnInterChipStop.TabIndex = 59;
            this.btnInterChipStop.Text = "Stop";
            this.btnInterChipStop.UseVisualStyleBackColor = true;
            this.btnInterChipStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnInterChipStart
            // 
            this.btnInterChipStart.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterChipStart.Location = new System.Drawing.Point(17, 272);
            this.btnInterChipStart.Name = "btnInterChipStart";
            this.btnInterChipStart.Size = new System.Drawing.Size(76, 35);
            this.btnInterChipStart.TabIndex = 58;
            this.btnInterChipStart.Text = "Start";
            this.btnInterChipStart.UseVisualStyleBackColor = true;
            this.btnInterChipStart.Click += new System.EventHandler(this.btnInterChipStart_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(31, 228);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(70, 15);
            this.label36.TabIndex = 57;
            this.label36.Text = "TestCase:";
            // 
            // cbInterChipTestCase
            // 
            this.cbInterChipTestCase.FormattingEnabled = true;
            this.cbInterChipTestCase.Items.AddRange(new object[] {
            "ATB_Scan",
            "VREF_Trim",
            "Regulator_Trim",
            "IBIAS100u_Trim",
            "PowerDissipation"});
            this.cbInterChipTestCase.Location = new System.Drawing.Point(107, 225);
            this.cbInterChipTestCase.Name = "cbInterChipTestCase";
            this.cbInterChipTestCase.Size = new System.Drawing.Size(133, 23);
            this.cbInterChipTestCase.TabIndex = 56;
            this.cbInterChipTestCase.Text = "ATB_Scan";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(3, 196);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(98, 15);
            this.label37.TabIndex = 55;
            this.label37.Text = "ProjectItems:";
            // 
            // cbInterChipProjectItems
            // 
            this.cbInterChipProjectItems.FormattingEnabled = true;
            this.cbInterChipProjectItems.Items.AddRange(new object[] {
            "TBS614",
            "TBS614V102",
            "TBS615"});
            this.cbInterChipProjectItems.Location = new System.Drawing.Point(107, 193);
            this.cbInterChipProjectItems.Name = "cbInterChipProjectItems";
            this.cbInterChipProjectItems.Size = new System.Drawing.Size(133, 23);
            this.cbInterChipProjectItems.TabIndex = 54;
            this.cbInterChipProjectItems.Text = "TBS614V102";
            this.cbInterChipProjectItems.SelectedIndexChanged += new System.EventHandler(this.cbProjectItems_SelectedIndexChanged);
            // 
            // rtbInterChipDisPlay
            // 
            this.rtbInterChipDisPlay.Location = new System.Drawing.Point(287, 75);
            this.rtbInterChipDisPlay.Name = "rtbInterChipDisPlay";
            this.rtbInterChipDisPlay.Size = new System.Drawing.Size(410, 313);
            this.rtbInterChipDisPlay.TabIndex = 53;
            this.rtbInterChipDisPlay.Text = "";
            // 
            // tbInterChipAtbResult
            // 
            this.tbInterChipAtbResult.Location = new System.Drawing.Point(455, 46);
            this.tbInterChipAtbResult.Name = "tbInterChipAtbResult";
            this.tbInterChipAtbResult.Size = new System.Drawing.Size(128, 21);
            this.tbInterChipAtbResult.TabIndex = 52;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(393, 49);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(56, 15);
            this.label34.TabIndex = 51;
            this.label34.Text = "Result:";
            // 
            // btnInterChipAtbRead
            // 
            this.btnInterChipAtbRead.Location = new System.Drawing.Point(611, 46);
            this.btnInterChipAtbRead.Name = "btnInterChipAtbRead";
            this.btnInterChipAtbRead.Size = new System.Drawing.Size(60, 23);
            this.btnInterChipAtbRead.TabIndex = 50;
            this.btnInterChipAtbRead.Text = "Read";
            this.btnInterChipAtbRead.UseVisualStyleBackColor = true;
            this.btnInterChipAtbRead.Click += new System.EventHandler(this.btnAtbRead_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(386, 18);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(63, 15);
            this.label35.TabIndex = 49;
            this.label35.Text = "ATB选择:";
            // 
            // cmbInterChipAtbName
            // 
            this.cmbInterChipAtbName.BackColor = System.Drawing.SystemColors.Window;
            this.cmbInterChipAtbName.FormattingEnabled = true;
            this.cmbInterChipAtbName.Location = new System.Drawing.Point(455, 16);
            this.cmbInterChipAtbName.Name = "cmbInterChipAtbName";
            this.cmbInterChipAtbName.Size = new System.Drawing.Size(216, 23);
            this.cmbInterChipAtbName.TabIndex = 48;
            this.cmbInterChipAtbName.SelectedIndexChanged += new System.EventHandler(this.cmbAtbNodeName_SelectedIndexChanged);
            // 
            // gbInterChipConfig
            // 
            this.gbInterChipConfig.BackColor = System.Drawing.Color.LightCyan;
            this.gbInterChipConfig.Controls.Add(this.btnInterChipVbgConfig);
            this.gbInterChipConfig.Controls.Add(this.tbInterChipVbgValue);
            this.gbInterChipConfig.Controls.Add(this.label23);
            this.gbInterChipConfig.Controls.Add(this.tbInterChipRegValue);
            this.gbInterChipConfig.Controls.Add(this.btnInterChipRegWrite);
            this.gbInterChipConfig.Controls.Add(this.tbInterChipRegAddr);
            this.gbInterChipConfig.Controls.Add(this.label26);
            this.gbInterChipConfig.Controls.Add(this.label33);
            this.gbInterChipConfig.Location = new System.Drawing.Point(6, 6);
            this.gbInterChipConfig.Name = "gbInterChipConfig";
            this.gbInterChipConfig.Size = new System.Drawing.Size(234, 125);
            this.gbInterChipConfig.TabIndex = 47;
            this.gbInterChipConfig.TabStop = false;
            this.gbInterChipConfig.Text = "RegManualConfig(hex)";
            // 
            // btnInterChipVbgConfig
            // 
            this.btnInterChipVbgConfig.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnInterChipVbgConfig.Location = new System.Drawing.Point(148, 78);
            this.btnInterChipVbgConfig.Name = "btnInterChipVbgConfig";
            this.btnInterChipVbgConfig.Size = new System.Drawing.Size(58, 31);
            this.btnInterChipVbgConfig.TabIndex = 50;
            this.btnInterChipVbgConfig.Text = "Config";
            this.btnInterChipVbgConfig.UseVisualStyleBackColor = false;
            this.btnInterChipVbgConfig.Click += new System.EventHandler(this.btnManualConfig_Click);
            // 
            // tbInterChipVbgValue
            // 
            this.tbInterChipVbgValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbInterChipVbgValue.Location = new System.Drawing.Point(54, 83);
            this.tbInterChipVbgValue.Name = "tbInterChipVbgValue";
            this.tbInterChipVbgValue.Size = new System.Drawing.Size(77, 21);
            this.tbInterChipVbgValue.TabIndex = 46;
            this.tbInterChipVbgValue.Text = "1.200";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Courier New", 9F);
            this.label23.Location = new System.Drawing.Point(19, 86);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 15);
            this.label23.TabIndex = 47;
            this.label23.Text = "VBG:";
            // 
            // tbInterChipRegValue
            // 
            this.tbInterChipRegValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbInterChipRegValue.Location = new System.Drawing.Point(54, 45);
            this.tbInterChipRegValue.Name = "tbInterChipRegValue";
            this.tbInterChipRegValue.Size = new System.Drawing.Size(77, 21);
            this.tbInterChipRegValue.TabIndex = 28;
            this.tbInterChipRegValue.Text = "001F";
            // 
            // btnInterChipRegWrite
            // 
            this.btnInterChipRegWrite.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnInterChipRegWrite.Location = new System.Drawing.Point(148, 27);
            this.btnInterChipRegWrite.Name = "btnInterChipRegWrite";
            this.btnInterChipRegWrite.Size = new System.Drawing.Size(58, 31);
            this.btnInterChipRegWrite.TabIndex = 45;
            this.btnInterChipRegWrite.Text = "Write";
            this.btnInterChipRegWrite.UseVisualStyleBackColor = false;
            this.btnInterChipRegWrite.Click += new System.EventHandler(this.btnInterChipRegWrite_Click);
            // 
            // tbInterChipRegAddr
            // 
            this.tbInterChipRegAddr.BackColor = System.Drawing.SystemColors.Control;
            this.tbInterChipRegAddr.Location = new System.Drawing.Point(54, 24);
            this.tbInterChipRegAddr.Name = "tbInterChipRegAddr";
            this.tbInterChipRegAddr.Size = new System.Drawing.Size(77, 21);
            this.tbInterChipRegAddr.TabIndex = 22;
            this.tbInterChipRegAddr.Text = "06";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Courier New", 9F);
            this.label26.Location = new System.Drawing.Point(15, 27);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(42, 15);
            this.label26.TabIndex = 23;
            this.label26.Text = "Addr:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Courier New", 9F);
            this.label33.Location = new System.Drawing.Point(8, 48);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(49, 15);
            this.label33.TabIndex = 29;
            this.label33.Text = "Value:";
            // 
            // tbpControlIC
            // 
            this.tbpControlIC.BackColor = System.Drawing.SystemColors.Control;
            this.tbpControlIC.Location = new System.Drawing.Point(4, 24);
            this.tbpControlIC.Name = "tbpControlIC";
            this.tbpControlIC.Padding = new System.Windows.Forms.Padding(3);
            this.tbpControlIC.Size = new System.Drawing.Size(699, 388);
            this.tbpControlIC.TabIndex = 2;
            this.tbpControlIC.Text = "控制";
            // 
            // USB_PortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 633);
            this.Controls.Add(this.gbTestItem);
            this.Controls.Add(this.gbUsbPortInfo);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "USB_PortForm";
            this.Text = "USB_Port";
            this.gbUsbPortInfo.ResumeLayout(false);
            this.gbUsbPortInfo.PerformLayout();
            this.gbUsbReadWriteOpt.ResumeLayout(false);
            this.gbUsbReadWriteOpt.PerformLayout();
            this.gbReadWriteDataStreamMonitor.ResumeLayout(false);
            this.gbReadWriteDataStreamMonitor.PerformLayout();
            this.gbUsbOptStatePrint.ResumeLayout(false);
            this.gbRegOpt.ResumeLayout(false);
            this.gbRegOpt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOptDelayMs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNetPortNum)).EndInit();
            this.gbUsbLookUp.ResumeLayout(false);
            this.gbUsbLookUp.PerformLayout();
            this.gbTestItem.ResumeLayout(false);
            this.gbCommonPart.ResumeLayout(false);
            this.gbCommonPart.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbPwrCHNSel.ResumeLayout(false);
            this.gbPwrCHNSel.PerformLayout();
            this.tcTest.ResumeLayout(false);
            this.tbpDriverIc.ResumeLayout(false);
            this.tbpDriverIc.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbRegConfig.ResumeLayout(false);
            this.gbRegConfig.PerformLayout();
            this.tbpInterfaceIC.ResumeLayout(false);
            this.tbpInterfaceIC.PerformLayout();
            this.gbChipLocationSel.ResumeLayout(false);
            this.gbChipLocationSel.PerformLayout();
            this.gbInterChipConfig.ResumeLayout(false);
            this.gbInterChipConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbUsbReadData;
        private System.Windows.Forms.Button btnGetUsbPort;
        private System.Windows.Forms.ComboBox cmbUsbDeviceInfoList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbUsbPortInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUsbDeviceVidList;
        private System.Windows.Forms.ComboBox cmbUsbDevicePidList;
        private System.Windows.Forms.Button btnOpenDevice;
        private System.Windows.Forms.Button btnCloseDevice;
        private System.Windows.Forms.Button btnReadUsbDevice;
        private System.Windows.Forms.Button btnWriteUsbDevice;
        private System.Windows.Forms.RichTextBox rtbUsbReadWriteDataStreamMonitor;
        private System.Windows.Forms.GroupBox gbUsbOptStatePrint;
        private System.Windows.Forms.RichTextBox rtbUsbErrInfo;
        private System.Windows.Forms.RichTextBox rtbUsbOptState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRegAddr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbUsbDeviceType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClearAllRtb;
        private System.Windows.Forms.GroupBox gbTestItem;
        private System.Windows.Forms.GroupBox gbCommonPart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbChipID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTestMessage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbUsbLookUp;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbUsbOtpType;
        private System.Windows.Forms.GroupBox gbRegOpt;
        private System.Windows.Forms.GroupBox gbReadWriteDataStreamMonitor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbRegOptLength;
        private System.Windows.Forms.RichTextBox rtbUsbWriteData;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox gbUsbReadWriteOpt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudOptDelayMs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudNetPortNum;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbInstPowerAddr;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbInstMultiAddr;
        private System.Windows.Forms.CheckBox cbMultiSelEn;
        private System.Windows.Forms.CheckBox cbPowerSelEn;
        private System.Windows.Forms.Button btnStopEn;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.CheckBox cbMultiSelEn1;
        private System.Windows.Forms.TextBox tbInstMultiAddr1;
        private System.Windows.Forms.CheckBox cbDebugEn;
        private System.Windows.Forms.GroupBox gbPwrCHNSel;
        private System.Windows.Forms.CheckBox cbEnPwrCH4;
        private System.Windows.Forms.CheckBox cbEnPwrCH3;
        private System.Windows.Forms.CheckBox cbEnPwrCH1;
        private System.Windows.Forms.CheckBox cbEnPwrCH2;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.ComboBox cmbChipCorner;
        private System.Windows.Forms.Label lbChipCorner;
        private System.Windows.Forms.CheckBox cbPwrType;
        private System.Windows.Forms.TabControl tcTest;
        private System.Windows.Forms.TabPage tbpDriverIc;
        private System.Windows.Forms.GroupBox gbRegConfig;
        private System.Windows.Forms.Button btnManualConfig;
        private System.Windows.Forms.TextBox tbVbgSet;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbDriverRegValue;
        private System.Windows.Forms.Button btnRegWrite;
        private System.Windows.Forms.TextBox tbDriverRegAddr;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbAtbResult;
        private System.Windows.Forms.RichTextBox rtbDispaly;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button btnAtbRead;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox cbTestCase;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cbProjectItems;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.CheckBox cbDriverBlueChipEn;
        private System.Windows.Forms.CheckBox cbDriverGreenChipEn;
        private System.Windows.Forms.CheckBox cbDriverRedChipEn;
        private System.Windows.Forms.ComboBox cmbAtbNodeName;
        private System.Windows.Forms.TabPage tbpInterfaceIC;
        private System.Windows.Forms.TabPage tbpControlIC;
        private System.Windows.Forms.Button btnInterChipStop;
        private System.Windows.Forms.Button btnInterChipStart;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ComboBox cbInterChipTestCase;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.ComboBox cbInterChipProjectItems;
        private System.Windows.Forms.RichTextBox rtbInterChipDisPlay;
        private System.Windows.Forms.TextBox tbInterChipAtbResult;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button btnInterChipAtbRead;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox cmbInterChipAtbName;
        private System.Windows.Forms.GroupBox gbInterChipConfig;
        private System.Windows.Forms.Button btnInterChipVbgConfig;
        private System.Windows.Forms.TextBox tbInterChipVbgValue;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbInterChipRegValue;
        private System.Windows.Forms.Button btnInterChipRegWrite;
        private System.Windows.Forms.TextBox tbInterChipRegAddr;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox gbChipLocationSel;
        private System.Windows.Forms.CheckBox cbEnChip0;
        private System.Windows.Forms.CheckBox cbEnChip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbVoltCaseSel;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.ComboBox cmbTempCaseSel;
        private System.Windows.Forms.Label lbVolt;
    }
}