
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
            this.cbDebugEn = new System.Windows.Forms.CheckBox();
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
            this.cbCh4En = new System.Windows.Forms.CheckBox();
            this.cbCh3En = new System.Windows.Forms.CheckBox();
            this.cbCh2En = new System.Windows.Forms.CheckBox();
            this.cbCh1En = new System.Windows.Forms.CheckBox();
            this.btnMultiInit = new System.Windows.Forms.Button();
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
            this.lbViewCnt = new System.Windows.Forms.Label();
            this.nudLoopCnt = new System.Windows.Forms.NumericUpDown();
            this.cbAteLoopEn = new System.Windows.Forms.CheckBox();
            this.btnAteLoopTest = new System.Windows.Forms.Button();
            this.cbPreDrivEn = new System.Windows.Forms.CheckBox();
            this.btnPreDriverVoltTest = new System.Windows.Forms.Button();
            this.cbIfixTestEn = new System.Windows.Forms.CheckBox();
            this.cbHysTestEn = new System.Windows.Forms.CheckBox();
            this.cbLdoTestEn = new System.Windows.Forms.CheckBox();
            this.cbVcoTestEn = new System.Windows.Forms.CheckBox();
            this.cbAtbTestEn = new System.Windows.Forms.CheckBox();
            this.cbVbgTestEn = new System.Windows.Forms.CheckBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tbDriverRegValue = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cbDriverBlueChipEn = new System.Windows.Forms.CheckBox();
            this.cbDriverGreenChipEn = new System.Windows.Forms.CheckBox();
            this.cbDriverRedChipEn = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbDriverRegAddr = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbProjectNameEn = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbProjectName = new System.Windows.Forms.ComboBox();
            this.cmbAtbNodeName = new System.Windows.Forms.ComboBox();
            this.tcDriverTest = new System.Windows.Forms.TabControl();
            this.tbpP2218V200 = new System.Windows.Forms.TabPage();
            this.tbpP2318V100 = new System.Windows.Forms.TabPage();
            this.tbpP3268V300 = new System.Windows.Forms.TabPage();
            this.tbpP3288V100 = new System.Windows.Forms.TabPage();
            this.tbpP2216RV100 = new System.Windows.Forms.TabPage();
            this.tbpP2316RV100 = new System.Windows.Forms.TabPage();
            this.tbpP5662V100 = new System.Windows.Forms.TabPage();
            this.tbpP1287V104 = new System.Windows.Forms.TabPage();
            this.btnLdoRegulator = new System.Windows.Forms.Button();
            this.btnAtbScan = new System.Windows.Forms.Button();
            this.btnVcoRegulator = new System.Windows.Forms.Button();
            this.btnIfixRegulator = new System.Windows.Forms.Button();
            this.btnVbgRegulator = new System.Windows.Forms.Button();
            this.btnHysteresisRegulator = new System.Windows.Forms.Button();
            this.tbpInterfaceIC = new System.Windows.Forms.TabPage();
            this.tcInterfaceTest = new System.Windows.Forms.TabControl();
            this.tbpP614V102 = new System.Windows.Forms.TabPage();
            this.tbpP615V100 = new System.Windows.Forms.TabPage();
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
            this.tcTest.SuspendLayout();
            this.tbpDriverIc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoopCnt)).BeginInit();
            this.tcDriverTest.SuspendLayout();
            this.tbpInterfaceIC.SuspendLayout();
            this.tcInterfaceTest.SuspendLayout();
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
            this.gbUsbPortInfo.Controls.Add(this.btnStopEn);
            this.gbUsbPortInfo.Controls.Add(this.gbUsbReadWriteOpt);
            this.gbUsbPortInfo.Controls.Add(this.gbReadWriteDataStreamMonitor);
            this.gbUsbPortInfo.Controls.Add(this.btnClearAllRtb);
            this.gbUsbPortInfo.Controls.Add(this.gbUsbOptStatePrint);
            this.gbUsbPortInfo.Controls.Add(this.gbRegOpt);
            this.gbUsbPortInfo.Controls.Add(this.cbDebugEn);
            this.gbUsbPortInfo.Controls.Add(this.btnDebug);
            this.gbUsbPortInfo.Controls.Add(this.gbUsbLookUp);
            this.gbUsbPortInfo.Controls.Add(this.btnReadUsbDevice);
            this.gbUsbPortInfo.Controls.Add(this.btnWriteUsbDevice);
            this.gbUsbPortInfo.Controls.Add(this.btnCloseDevice);
            this.gbUsbPortInfo.Controls.Add(this.btnOpenDevice);
            this.gbUsbPortInfo.Location = new System.Drawing.Point(5, 12);
            this.gbUsbPortInfo.Name = "gbUsbPortInfo";
            this.gbUsbPortInfo.Size = new System.Drawing.Size(574, 593);
            this.gbUsbPortInfo.TabIndex = 4;
            this.gbUsbPortInfo.TabStop = false;
            this.gbUsbPortInfo.Text = "USB设备操作";
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
            this.btnStopEn.Click += new System.EventHandler(this.btnStopEn_Click);
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
            this.gbUsbOptStatePrint.Size = new System.Drawing.Size(487, 140);
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
            this.rtbUsbErrInfo.Size = new System.Drawing.Size(481, 57);
            this.rtbUsbErrInfo.TabIndex = 14;
            this.rtbUsbErrInfo.Text = "显示USB操作---异常状态\n";
            // 
            // rtbUsbOptState
            // 
            this.rtbUsbOptState.BackColor = System.Drawing.SystemColors.Control;
            this.rtbUsbOptState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rtbUsbOptState.Location = new System.Drawing.Point(4, 73);
            this.rtbUsbOptState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbUsbOptState.Name = "rtbUsbOptState";
            this.rtbUsbOptState.Size = new System.Drawing.Size(481, 65);
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
            // cbDebugEn
            // 
            this.cbDebugEn.AutoSize = true;
            this.cbDebugEn.Location = new System.Drawing.Point(551, 139);
            this.cbDebugEn.Name = "cbDebugEn";
            this.cbDebugEn.Size = new System.Drawing.Size(15, 14);
            this.cbDebugEn.TabIndex = 21;
            this.cbDebugEn.UseVisualStyleBackColor = true;
            this.cbDebugEn.CheckedChanged += new System.EventHandler(this.cbDebugEn_CheckedChanged);
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
            this.gbTestItem.Size = new System.Drawing.Size(707, 593);
            this.gbTestItem.TabIndex = 5;
            this.gbTestItem.TabStop = false;
            this.gbTestItem.Text = "接口/驱动/控制---自动化集";
            // 
            // gbCommonPart
            // 
            this.gbCommonPart.Controls.Add(this.cbCh4En);
            this.gbCommonPart.Controls.Add(this.cbCh3En);
            this.gbCommonPart.Controls.Add(this.cbCh2En);
            this.gbCommonPart.Controls.Add(this.cbCh1En);
            this.gbCommonPart.Controls.Add(this.btnMultiInit);
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
            this.gbCommonPart.Size = new System.Drawing.Size(691, 166);
            this.gbCommonPart.TabIndex = 1;
            this.gbCommonPart.TabStop = false;
            this.gbCommonPart.Text = "公共配置";
            // 
            // cbCh4En
            // 
            this.cbCh4En.AutoSize = true;
            this.cbCh4En.Enabled = false;
            this.cbCh4En.Location = new System.Drawing.Point(294, 93);
            this.cbCh4En.Name = "cbCh4En";
            this.cbCh4En.Size = new System.Drawing.Size(47, 19);
            this.cbCh4En.TabIndex = 71;
            this.cbCh4En.Text = "CH4";
            this.cbCh4En.UseVisualStyleBackColor = true;
            // 
            // cbCh3En
            // 
            this.cbCh3En.AutoSize = true;
            this.cbCh3En.Enabled = false;
            this.cbCh3En.Location = new System.Drawing.Point(244, 93);
            this.cbCh3En.Name = "cbCh3En";
            this.cbCh3En.Size = new System.Drawing.Size(47, 19);
            this.cbCh3En.TabIndex = 70;
            this.cbCh3En.Text = "CH3";
            this.cbCh3En.UseVisualStyleBackColor = true;
            // 
            // cbCh2En
            // 
            this.cbCh2En.AutoSize = true;
            this.cbCh2En.Enabled = false;
            this.cbCh2En.Location = new System.Drawing.Point(189, 93);
            this.cbCh2En.Name = "cbCh2En";
            this.cbCh2En.Size = new System.Drawing.Size(47, 19);
            this.cbCh2En.TabIndex = 69;
            this.cbCh2En.Text = "CH2";
            this.cbCh2En.UseVisualStyleBackColor = true;
            // 
            // cbCh1En
            // 
            this.cbCh1En.AutoSize = true;
            this.cbCh1En.Enabled = false;
            this.cbCh1En.Location = new System.Drawing.Point(131, 93);
            this.cbCh1En.Name = "cbCh1En";
            this.cbCh1En.Size = new System.Drawing.Size(47, 19);
            this.cbCh1En.TabIndex = 45;
            this.cbCh1En.Text = "CH1";
            this.cbCh1En.UseVisualStyleBackColor = true;
            // 
            // btnMultiInit
            // 
            this.btnMultiInit.Location = new System.Drawing.Point(367, 121);
            this.btnMultiInit.Name = "btnMultiInit";
            this.btnMultiInit.Size = new System.Drawing.Size(153, 21);
            this.btnMultiInit.TabIndex = 68;
            this.btnMultiInit.Text = "万用表DV模式初始化";
            this.btnMultiInit.UseVisualStyleBackColor = true;
            this.btnMultiInit.Click += new System.EventHandler(this.btnMultiInit_Click);
            // 
            // cbMultiSelEn
            // 
            this.cbMultiSelEn.AutoSize = true;
            this.cbMultiSelEn.Location = new System.Drawing.Point(337, 130);
            this.cbMultiSelEn.Name = "cbMultiSelEn";
            this.cbMultiSelEn.Size = new System.Drawing.Size(15, 14);
            this.cbMultiSelEn.TabIndex = 67;
            this.cbMultiSelEn.UseVisualStyleBackColor = true;
            this.cbMultiSelEn.CheckedChanged += new System.EventHandler(this.cbTestEn_CheckedChanged);
            // 
            // cbPowerSelEn
            // 
            this.cbPowerSelEn.AutoSize = true;
            this.cbPowerSelEn.Location = new System.Drawing.Point(337, 77);
            this.cbPowerSelEn.Name = "cbPowerSelEn";
            this.cbPowerSelEn.Size = new System.Drawing.Size(15, 14);
            this.cbPowerSelEn.TabIndex = 66;
            this.cbPowerSelEn.UseVisualStyleBackColor = true;
            this.cbPowerSelEn.CheckedChanged += new System.EventHandler(this.cbTestEn_CheckedChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(34, 124);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(84, 15);
            this.label28.TabIndex = 65;
            this.label28.Text = "万用表Addr:";
            // 
            // tbInstMultiAddr
            // 
            this.tbInstMultiAddr.BackColor = System.Drawing.SystemColors.Control;
            this.tbInstMultiAddr.Enabled = false;
            this.tbInstMultiAddr.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInstMultiAddr.ForeColor = System.Drawing.Color.Black;
            this.tbInstMultiAddr.Location = new System.Drawing.Point(131, 122);
            this.tbInstMultiAddr.Name = "tbInstMultiAddr";
            this.tbInstMultiAddr.Size = new System.Drawing.Size(203, 21);
            this.tbInstMultiAddr.TabIndex = 64;
            this.tbInstMultiAddr.Text = "请填入万用表地址";
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
            this.tbInstPowerAddr.Enabled = false;
            this.tbInstPowerAddr.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInstPowerAddr.ForeColor = System.Drawing.Color.Black;
            this.tbInstPowerAddr.Location = new System.Drawing.Point(131, 70);
            this.tbInstPowerAddr.Name = "tbInstPowerAddr";
            this.tbInstPowerAddr.Size = new System.Drawing.Size(203, 21);
            this.tbInstPowerAddr.TabIndex = 62;
            this.tbInstPowerAddr.Text = "请填入电源地址";
            // 
            // tbChipID
            // 
            this.tbChipID.BackColor = System.Drawing.SystemColors.Control;
            this.tbChipID.Font = new System.Drawing.Font("Courier New", 9F);
            this.tbChipID.ForeColor = System.Drawing.Color.Black;
            this.tbChipID.Location = new System.Drawing.Point(419, 44);
            this.tbChipID.Name = "tbChipID";
            this.tbChipID.Size = new System.Drawing.Size(62, 21);
            this.tbChipID.TabIndex = 61;
            this.tbChipID.Text = "#001";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(350, 46);
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
            this.tbTestMessage.Text = "P2318R_V100_ATB";
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
            this.tcTest.Location = new System.Drawing.Point(6, 192);
            this.tcTest.Name = "tcTest";
            this.tcTest.SelectedIndex = 0;
            this.tcTest.Size = new System.Drawing.Size(707, 396);
            this.tcTest.TabIndex = 0;
            // 
            // tbpDriverIc
            // 
            this.tbpDriverIc.BackColor = System.Drawing.SystemColors.Control;
            this.tbpDriverIc.Controls.Add(this.lbViewCnt);
            this.tbpDriverIc.Controls.Add(this.nudLoopCnt);
            this.tbpDriverIc.Controls.Add(this.cbAteLoopEn);
            this.tbpDriverIc.Controls.Add(this.btnAteLoopTest);
            this.tbpDriverIc.Controls.Add(this.cbPreDrivEn);
            this.tbpDriverIc.Controls.Add(this.btnPreDriverVoltTest);
            this.tbpDriverIc.Controls.Add(this.cbIfixTestEn);
            this.tbpDriverIc.Controls.Add(this.cbHysTestEn);
            this.tbpDriverIc.Controls.Add(this.cbLdoTestEn);
            this.tbpDriverIc.Controls.Add(this.cbVcoTestEn);
            this.tbpDriverIc.Controls.Add(this.cbAtbTestEn);
            this.tbpDriverIc.Controls.Add(this.cbVbgTestEn);
            this.tbpDriverIc.Controls.Add(this.label26);
            this.tbpDriverIc.Controls.Add(this.label25);
            this.tbpDriverIc.Controls.Add(this.label24);
            this.tbpDriverIc.Controls.Add(this.label22);
            this.tbpDriverIc.Controls.Add(this.tbDriverRegValue);
            this.tbpDriverIc.Controls.Add(this.label23);
            this.tbpDriverIc.Controls.Add(this.cbDriverBlueChipEn);
            this.tbpDriverIc.Controls.Add(this.cbDriverGreenChipEn);
            this.tbpDriverIc.Controls.Add(this.cbDriverRedChipEn);
            this.tbpDriverIc.Controls.Add(this.label20);
            this.tbpDriverIc.Controls.Add(this.tbDriverRegAddr);
            this.tbpDriverIc.Controls.Add(this.label21);
            this.tbpDriverIc.Controls.Add(this.cbProjectNameEn);
            this.tbpDriverIc.Controls.Add(this.label19);
            this.tbpDriverIc.Controls.Add(this.cmbProjectName);
            this.tbpDriverIc.Controls.Add(this.cmbAtbNodeName);
            this.tbpDriverIc.Controls.Add(this.tcDriverTest);
            this.tbpDriverIc.Controls.Add(this.btnLdoRegulator);
            this.tbpDriverIc.Controls.Add(this.btnAtbScan);
            this.tbpDriverIc.Controls.Add(this.btnVcoRegulator);
            this.tbpDriverIc.Controls.Add(this.btnIfixRegulator);
            this.tbpDriverIc.Controls.Add(this.btnVbgRegulator);
            this.tbpDriverIc.Controls.Add(this.btnHysteresisRegulator);
            this.tbpDriverIc.Location = new System.Drawing.Point(4, 24);
            this.tbpDriverIc.Name = "tbpDriverIc";
            this.tbpDriverIc.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDriverIc.Size = new System.Drawing.Size(699, 368);
            this.tbpDriverIc.TabIndex = 0;
            this.tbpDriverIc.Text = "驱动";
            // 
            // lbViewCnt
            // 
            this.lbViewCnt.AutoSize = true;
            this.lbViewCnt.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViewCnt.ForeColor = System.Drawing.Color.Red;
            this.lbViewCnt.Location = new System.Drawing.Point(281, 65);
            this.lbViewCnt.Name = "lbViewCnt";
            this.lbViewCnt.Size = new System.Drawing.Size(205, 36);
            this.lbViewCnt.TabIndex = 44;
            this.lbViewCnt.Text = "测试次数：";
            // 
            // nudLoopCnt
            // 
            this.nudLoopCnt.Location = new System.Drawing.Point(420, 140);
            this.nudLoopCnt.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudLoopCnt.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudLoopCnt.Name = "nudLoopCnt";
            this.nudLoopCnt.Size = new System.Drawing.Size(56, 21);
            this.nudLoopCnt.TabIndex = 34;
            this.nudLoopCnt.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // cbAteLoopEn
            // 
            this.cbAteLoopEn.AutoSize = true;
            this.cbAteLoopEn.Location = new System.Drawing.Point(525, 181);
            this.cbAteLoopEn.Name = "cbAteLoopEn";
            this.cbAteLoopEn.Size = new System.Drawing.Size(15, 14);
            this.cbAteLoopEn.TabIndex = 43;
            this.cbAteLoopEn.UseVisualStyleBackColor = true;
            this.cbAteLoopEn.CheckedChanged += new System.EventHandler(this.cbTestEn_CheckedChanged);
            // 
            // btnAteLoopTest
            // 
            this.btnAteLoopTest.Enabled = false;
            this.btnAteLoopTest.Location = new System.Drawing.Point(419, 160);
            this.btnAteLoopTest.Name = "btnAteLoopTest";
            this.btnAteLoopTest.Size = new System.Drawing.Size(101, 35);
            this.btnAteLoopTest.TabIndex = 42;
            this.btnAteLoopTest.Text = "AteLoop";
            this.btnAteLoopTest.UseVisualStyleBackColor = true;
            this.btnAteLoopTest.Click += new System.EventHandler(this.btnAteLoopTest_Click);
            // 
            // cbPreDrivEn
            // 
            this.cbPreDrivEn.AutoSize = true;
            this.cbPreDrivEn.Location = new System.Drawing.Point(525, 224);
            this.cbPreDrivEn.Name = "cbPreDrivEn";
            this.cbPreDrivEn.Size = new System.Drawing.Size(15, 14);
            this.cbPreDrivEn.TabIndex = 41;
            this.cbPreDrivEn.UseVisualStyleBackColor = true;
            this.cbPreDrivEn.CheckedChanged += new System.EventHandler(this.cbTestEn_CheckedChanged);
            // 
            // btnPreDriverVoltTest
            // 
            this.btnPreDriverVoltTest.Enabled = false;
            this.btnPreDriverVoltTest.Location = new System.Drawing.Point(419, 204);
            this.btnPreDriverVoltTest.Name = "btnPreDriverVoltTest";
            this.btnPreDriverVoltTest.Size = new System.Drawing.Size(101, 35);
            this.btnPreDriverVoltTest.TabIndex = 40;
            this.btnPreDriverVoltTest.Text = "PreDrvVolt";
            this.btnPreDriverVoltTest.UseVisualStyleBackColor = true;
            this.btnPreDriverVoltTest.Click += new System.EventHandler(this.btnPreDriverVoltTest_Click);
            // 
            // cbIfixTestEn
            // 
            this.cbIfixTestEn.AutoSize = true;
            this.cbIfixTestEn.Location = new System.Drawing.Point(122, 225);
            this.cbIfixTestEn.Name = "cbIfixTestEn";
            this.cbIfixTestEn.Size = new System.Drawing.Size(15, 14);
            this.cbIfixTestEn.TabIndex = 39;
            this.cbIfixTestEn.UseVisualStyleBackColor = true;
            this.cbIfixTestEn.CheckedChanged += new System.EventHandler(this.cbTestEn_CheckedChanged);
            // 
            // cbHysTestEn
            // 
            this.cbHysTestEn.AutoSize = true;
            this.cbHysTestEn.Location = new System.Drawing.Point(259, 224);
            this.cbHysTestEn.Name = "cbHysTestEn";
            this.cbHysTestEn.Size = new System.Drawing.Size(15, 14);
            this.cbHysTestEn.TabIndex = 38;
            this.cbHysTestEn.UseVisualStyleBackColor = true;
            this.cbHysTestEn.CheckedChanged += new System.EventHandler(this.cbTestEn_CheckedChanged);
            // 
            // cbLdoTestEn
            // 
            this.cbLdoTestEn.AutoSize = true;
            this.cbLdoTestEn.Location = new System.Drawing.Point(259, 181);
            this.cbLdoTestEn.Name = "cbLdoTestEn";
            this.cbLdoTestEn.Size = new System.Drawing.Size(15, 14);
            this.cbLdoTestEn.TabIndex = 37;
            this.cbLdoTestEn.UseVisualStyleBackColor = true;
            this.cbLdoTestEn.CheckedChanged += new System.EventHandler(this.cbTestEn_CheckedChanged);
            // 
            // cbVcoTestEn
            // 
            this.cbVcoTestEn.AutoSize = true;
            this.cbVcoTestEn.Location = new System.Drawing.Point(393, 182);
            this.cbVcoTestEn.Name = "cbVcoTestEn";
            this.cbVcoTestEn.Size = new System.Drawing.Size(15, 14);
            this.cbVcoTestEn.TabIndex = 36;
            this.cbVcoTestEn.UseVisualStyleBackColor = true;
            this.cbVcoTestEn.CheckedChanged += new System.EventHandler(this.cbTestEn_CheckedChanged);
            // 
            // cbAtbTestEn
            // 
            this.cbAtbTestEn.AutoSize = true;
            this.cbAtbTestEn.Location = new System.Drawing.Point(393, 224);
            this.cbAtbTestEn.Name = "cbAtbTestEn";
            this.cbAtbTestEn.Size = new System.Drawing.Size(15, 14);
            this.cbAtbTestEn.TabIndex = 35;
            this.cbAtbTestEn.UseVisualStyleBackColor = true;
            this.cbAtbTestEn.CheckedChanged += new System.EventHandler(this.cbTestEn_CheckedChanged);
            // 
            // cbVbgTestEn
            // 
            this.cbVbgTestEn.AutoSize = true;
            this.cbVbgTestEn.Location = new System.Drawing.Point(123, 181);
            this.cbVbgTestEn.Name = "cbVbgTestEn";
            this.cbVbgTestEn.Size = new System.Drawing.Size(15, 14);
            this.cbVbgTestEn.TabIndex = 34;
            this.cbVbgTestEn.UseVisualStyleBackColor = true;
            this.cbVbgTestEn.CheckedChanged += new System.EventHandler(this.cbTestEn_CheckedChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(24, 78);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(70, 15);
            this.label26.TabIndex = 33;
            this.label26.Text = "Reg 配置:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(23, 37);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(70, 15);
            this.label25.TabIndex = 32;
            this.label25.Text = "配置选择:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(284, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(63, 15);
            this.label24.TabIndex = 31;
            this.label24.Text = "ATB选择:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Courier New", 9F);
            this.label22.Location = new System.Drawing.Point(93, 86);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 15);
            this.label22.TabIndex = 29;
            this.label22.Text = "写值:";
            // 
            // tbDriverRegValue
            // 
            this.tbDriverRegValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbDriverRegValue.Enabled = false;
            this.tbDriverRegValue.Location = new System.Drawing.Point(136, 83);
            this.tbDriverRegValue.Name = "tbDriverRegValue";
            this.tbDriverRegValue.Size = new System.Drawing.Size(77, 21);
            this.tbDriverRegValue.TabIndex = 28;
            this.tbDriverRegValue.Text = "0001";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Courier New", 9F);
            this.label23.Location = new System.Drawing.Point(219, 86);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(28, 15);
            this.label23.TabIndex = 30;
            this.label23.Text = "Hex";
            // 
            // cbDriverBlueChipEn
            // 
            this.cbDriverBlueChipEn.AutoSize = true;
            this.cbDriverBlueChipEn.Checked = true;
            this.cbDriverBlueChipEn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDriverBlueChipEn.Enabled = false;
            this.cbDriverBlueChipEn.Location = new System.Drawing.Point(169, 36);
            this.cbDriverBlueChipEn.Name = "cbDriverBlueChipEn";
            this.cbDriverBlueChipEn.Size = new System.Drawing.Size(33, 19);
            this.cbDriverBlueChipEn.TabIndex = 27;
            this.cbDriverBlueChipEn.Text = "B";
            this.cbDriverBlueChipEn.UseVisualStyleBackColor = true;
            // 
            // cbDriverGreenChipEn
            // 
            this.cbDriverGreenChipEn.AutoSize = true;
            this.cbDriverGreenChipEn.Checked = true;
            this.cbDriverGreenChipEn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDriverGreenChipEn.Enabled = false;
            this.cbDriverGreenChipEn.Location = new System.Drawing.Point(134, 36);
            this.cbDriverGreenChipEn.Name = "cbDriverGreenChipEn";
            this.cbDriverGreenChipEn.Size = new System.Drawing.Size(33, 19);
            this.cbDriverGreenChipEn.TabIndex = 26;
            this.cbDriverGreenChipEn.Text = "G";
            this.cbDriverGreenChipEn.UseVisualStyleBackColor = true;
            // 
            // cbDriverRedChipEn
            // 
            this.cbDriverRedChipEn.AutoSize = true;
            this.cbDriverRedChipEn.Checked = true;
            this.cbDriverRedChipEn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDriverRedChipEn.Enabled = false;
            this.cbDriverRedChipEn.Location = new System.Drawing.Point(101, 36);
            this.cbDriverRedChipEn.Name = "cbDriverRedChipEn";
            this.cbDriverRedChipEn.Size = new System.Drawing.Size(33, 19);
            this.cbDriverRedChipEn.TabIndex = 25;
            this.cbDriverRedChipEn.Text = "R";
            this.cbDriverRedChipEn.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Courier New", 9F);
            this.label20.Location = new System.Drawing.Point(93, 65);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 15);
            this.label20.TabIndex = 23;
            this.label20.Text = "地址:";
            // 
            // tbDriverRegAddr
            // 
            this.tbDriverRegAddr.BackColor = System.Drawing.SystemColors.Control;
            this.tbDriverRegAddr.Enabled = false;
            this.tbDriverRegAddr.Location = new System.Drawing.Point(136, 62);
            this.tbDriverRegAddr.Name = "tbDriverRegAddr";
            this.tbDriverRegAddr.Size = new System.Drawing.Size(77, 21);
            this.tbDriverRegAddr.TabIndex = 22;
            this.tbDriverRegAddr.Text = "1F";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Courier New", 9F);
            this.label21.Location = new System.Drawing.Point(219, 62);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(28, 15);
            this.label21.TabIndex = 24;
            this.label21.Text = "Hex";
            // 
            // cbProjectNameEn
            // 
            this.cbProjectNameEn.AutoSize = true;
            this.cbProjectNameEn.Location = new System.Drawing.Point(232, 10);
            this.cbProjectNameEn.Name = "cbProjectNameEn";
            this.cbProjectNameEn.Size = new System.Drawing.Size(40, 19);
            this.cbProjectNameEn.TabIndex = 9;
            this.cbProjectNameEn.Text = "En";
            this.cbProjectNameEn.UseVisualStyleBackColor = true;
            this.cbProjectNameEn.CheckedChanged += new System.EventHandler(this.cbProjectNameEn_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 15);
            this.label19.TabIndex = 8;
            this.label19.Text = "项目选择:";
            // 
            // cmbProjectName
            // 
            this.cmbProjectName.FormattingEnabled = true;
            this.cmbProjectName.Items.AddRange(new object[] {
            "P2218_V20X",
            "P2318_V100",
            "P2318R_V100",
            "P2218R_V100",
            "P2216R_V100",
            "P2316R_V100",
            "P3268_V300",
            "P3288_V100",
            "P1287_V10X"});
            this.cmbProjectName.Location = new System.Drawing.Point(96, 7);
            this.cmbProjectName.Name = "cmbProjectName";
            this.cmbProjectName.Size = new System.Drawing.Size(133, 23);
            this.cmbProjectName.TabIndex = 7;
            this.cmbProjectName.SelectedIndexChanged += new System.EventHandler(this.cmbProjectName_SelectedIndexChanged);
            // 
            // cmbAtbNodeName
            // 
            this.cmbAtbNodeName.BackColor = System.Drawing.SystemColors.Window;
            this.cmbAtbNodeName.FormattingEnabled = true;
            this.cmbAtbNodeName.Location = new System.Drawing.Point(353, 7);
            this.cmbAtbNodeName.Name = "cmbAtbNodeName";
            this.cmbAtbNodeName.Size = new System.Drawing.Size(299, 23);
            this.cmbAtbNodeName.TabIndex = 6;
            this.cmbAtbNodeName.SelectedIndexChanged += new System.EventHandler(this.cmbAtbNodeName_SelectedIndexChanged);
            // 
            // tcDriverTest
            // 
            this.tcDriverTest.Controls.Add(this.tbpP2218V200);
            this.tcDriverTest.Controls.Add(this.tbpP2318V100);
            this.tcDriverTest.Controls.Add(this.tbpP3268V300);
            this.tcDriverTest.Controls.Add(this.tbpP3288V100);
            this.tcDriverTest.Controls.Add(this.tbpP2216RV100);
            this.tcDriverTest.Controls.Add(this.tbpP2316RV100);
            this.tcDriverTest.Controls.Add(this.tbpP5662V100);
            this.tcDriverTest.Controls.Add(this.tbpP1287V104);
            this.tcDriverTest.Location = new System.Drawing.Point(9, 245);
            this.tcDriverTest.Name = "tcDriverTest";
            this.tcDriverTest.SelectedIndex = 0;
            this.tcDriverTest.Size = new System.Drawing.Size(687, 117);
            this.tcDriverTest.TabIndex = 0;
            // 
            // tbpP2218V200
            // 
            this.tbpP2218V200.Location = new System.Drawing.Point(4, 24);
            this.tbpP2218V200.Name = "tbpP2218V200";
            this.tbpP2218V200.Padding = new System.Windows.Forms.Padding(3);
            this.tbpP2218V200.Size = new System.Drawing.Size(679, 157);
            this.tbpP2218V200.TabIndex = 0;
            this.tbpP2218V200.Text = "P2218V200";
            this.tbpP2218V200.UseVisualStyleBackColor = true;
            // 
            // tbpP2318V100
            // 
            this.tbpP2318V100.Location = new System.Drawing.Point(4, 24);
            this.tbpP2318V100.Name = "tbpP2318V100";
            this.tbpP2318V100.Padding = new System.Windows.Forms.Padding(3);
            this.tbpP2318V100.Size = new System.Drawing.Size(679, 89);
            this.tbpP2318V100.TabIndex = 1;
            this.tbpP2318V100.Text = "P2318V100";
            this.tbpP2318V100.UseVisualStyleBackColor = true;
            // 
            // tbpP3268V300
            // 
            this.tbpP3268V300.Location = new System.Drawing.Point(4, 24);
            this.tbpP3268V300.Name = "tbpP3268V300";
            this.tbpP3268V300.Padding = new System.Windows.Forms.Padding(3);
            this.tbpP3268V300.Size = new System.Drawing.Size(679, 157);
            this.tbpP3268V300.TabIndex = 2;
            this.tbpP3268V300.Text = "P3268V300";
            this.tbpP3268V300.UseVisualStyleBackColor = true;
            // 
            // tbpP3288V100
            // 
            this.tbpP3288V100.Location = new System.Drawing.Point(4, 24);
            this.tbpP3288V100.Name = "tbpP3288V100";
            this.tbpP3288V100.Padding = new System.Windows.Forms.Padding(3);
            this.tbpP3288V100.Size = new System.Drawing.Size(679, 157);
            this.tbpP3288V100.TabIndex = 3;
            this.tbpP3288V100.Text = "P3288V100";
            this.tbpP3288V100.UseVisualStyleBackColor = true;
            // 
            // tbpP2216RV100
            // 
            this.tbpP2216RV100.Location = new System.Drawing.Point(4, 24);
            this.tbpP2216RV100.Name = "tbpP2216RV100";
            this.tbpP2216RV100.Padding = new System.Windows.Forms.Padding(3);
            this.tbpP2216RV100.Size = new System.Drawing.Size(679, 157);
            this.tbpP2216RV100.TabIndex = 4;
            this.tbpP2216RV100.Text = "P2216RV100";
            this.tbpP2216RV100.UseVisualStyleBackColor = true;
            // 
            // tbpP2316RV100
            // 
            this.tbpP2316RV100.Location = new System.Drawing.Point(4, 24);
            this.tbpP2316RV100.Name = "tbpP2316RV100";
            this.tbpP2316RV100.Padding = new System.Windows.Forms.Padding(3);
            this.tbpP2316RV100.Size = new System.Drawing.Size(679, 157);
            this.tbpP2316RV100.TabIndex = 5;
            this.tbpP2316RV100.Text = "P2316RV100";
            this.tbpP2316RV100.UseVisualStyleBackColor = true;
            // 
            // tbpP5662V100
            // 
            this.tbpP5662V100.Location = new System.Drawing.Point(4, 24);
            this.tbpP5662V100.Name = "tbpP5662V100";
            this.tbpP5662V100.Padding = new System.Windows.Forms.Padding(3);
            this.tbpP5662V100.Size = new System.Drawing.Size(679, 157);
            this.tbpP5662V100.TabIndex = 6;
            this.tbpP5662V100.Text = "P5662V100";
            this.tbpP5662V100.UseVisualStyleBackColor = true;
            // 
            // tbpP1287V104
            // 
            this.tbpP1287V104.Location = new System.Drawing.Point(4, 24);
            this.tbpP1287V104.Name = "tbpP1287V104";
            this.tbpP1287V104.Padding = new System.Windows.Forms.Padding(3);
            this.tbpP1287V104.Size = new System.Drawing.Size(679, 157);
            this.tbpP1287V104.TabIndex = 7;
            this.tbpP1287V104.Text = "P1287V104";
            this.tbpP1287V104.UseVisualStyleBackColor = true;
            // 
            // btnLdoRegulator
            // 
            this.btnLdoRegulator.Enabled = false;
            this.btnLdoRegulator.Location = new System.Drawing.Point(156, 161);
            this.btnLdoRegulator.Name = "btnLdoRegulator";
            this.btnLdoRegulator.Size = new System.Drawing.Size(101, 35);
            this.btnLdoRegulator.TabIndex = 5;
            this.btnLdoRegulator.Text = "LdoTrim";
            this.btnLdoRegulator.UseVisualStyleBackColor = true;
            // 
            // btnAtbScan
            // 
            this.btnAtbScan.Enabled = false;
            this.btnAtbScan.Location = new System.Drawing.Point(287, 204);
            this.btnAtbScan.Name = "btnAtbScan";
            this.btnAtbScan.Size = new System.Drawing.Size(101, 35);
            this.btnAtbScan.TabIndex = 4;
            this.btnAtbScan.Text = "AtbScan";
            this.btnAtbScan.UseVisualStyleBackColor = true;
            this.btnAtbScan.Click += new System.EventHandler(this.btnAtbScan_Click);
            // 
            // btnVcoRegulator
            // 
            this.btnVcoRegulator.Enabled = false;
            this.btnVcoRegulator.Location = new System.Drawing.Point(287, 161);
            this.btnVcoRegulator.Name = "btnVcoRegulator";
            this.btnVcoRegulator.Size = new System.Drawing.Size(101, 35);
            this.btnVcoRegulator.TabIndex = 2;
            this.btnVcoRegulator.Text = "VcoTrim";
            this.btnVcoRegulator.UseVisualStyleBackColor = true;
            // 
            // btnIfixRegulator
            // 
            this.btnIfixRegulator.Enabled = false;
            this.btnIfixRegulator.Location = new System.Drawing.Point(19, 204);
            this.btnIfixRegulator.Name = "btnIfixRegulator";
            this.btnIfixRegulator.Size = new System.Drawing.Size(101, 35);
            this.btnIfixRegulator.TabIndex = 1;
            this.btnIfixRegulator.Text = "IfixTrim";
            this.btnIfixRegulator.UseVisualStyleBackColor = true;
            // 
            // btnVbgRegulator
            // 
            this.btnVbgRegulator.Enabled = false;
            this.btnVbgRegulator.Location = new System.Drawing.Point(19, 161);
            this.btnVbgRegulator.Name = "btnVbgRegulator";
            this.btnVbgRegulator.Size = new System.Drawing.Size(101, 35);
            this.btnVbgRegulator.TabIndex = 0;
            this.btnVbgRegulator.Text = "VbgTrim";
            this.btnVbgRegulator.UseVisualStyleBackColor = true;
            this.btnVbgRegulator.Click += new System.EventHandler(this.btnVbgRegulator_Click);
            // 
            // btnHysteresisRegulator
            // 
            this.btnHysteresisRegulator.Enabled = false;
            this.btnHysteresisRegulator.Location = new System.Drawing.Point(156, 204);
            this.btnHysteresisRegulator.Name = "btnHysteresisRegulator";
            this.btnHysteresisRegulator.Size = new System.Drawing.Size(101, 35);
            this.btnHysteresisRegulator.TabIndex = 3;
            this.btnHysteresisRegulator.Text = "HysTest";
            this.btnHysteresisRegulator.UseVisualStyleBackColor = true;
            // 
            // tbpInterfaceIC
            // 
            this.tbpInterfaceIC.BackColor = System.Drawing.SystemColors.Control;
            this.tbpInterfaceIC.Controls.Add(this.tcInterfaceTest);
            this.tbpInterfaceIC.Location = new System.Drawing.Point(4, 24);
            this.tbpInterfaceIC.Name = "tbpInterfaceIC";
            this.tbpInterfaceIC.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInterfaceIC.Size = new System.Drawing.Size(699, 368);
            this.tbpInterfaceIC.TabIndex = 1;
            this.tbpInterfaceIC.Text = "接口";
            // 
            // tcInterfaceTest
            // 
            this.tcInterfaceTest.Controls.Add(this.tbpP614V102);
            this.tcInterfaceTest.Controls.Add(this.tbpP615V100);
            this.tcInterfaceTest.Location = new System.Drawing.Point(6, 8);
            this.tcInterfaceTest.Name = "tcInterfaceTest";
            this.tcInterfaceTest.SelectedIndex = 0;
            this.tcInterfaceTest.Size = new System.Drawing.Size(687, 420);
            this.tcInterfaceTest.TabIndex = 1;
            // 
            // tbpP614V102
            // 
            this.tbpP614V102.Location = new System.Drawing.Point(4, 24);
            this.tbpP614V102.Name = "tbpP614V102";
            this.tbpP614V102.Padding = new System.Windows.Forms.Padding(3);
            this.tbpP614V102.Size = new System.Drawing.Size(679, 392);
            this.tbpP614V102.TabIndex = 4;
            this.tbpP614V102.Text = "P614V102";
            this.tbpP614V102.UseVisualStyleBackColor = true;
            // 
            // tbpP615V100
            // 
            this.tbpP615V100.Location = new System.Drawing.Point(4, 24);
            this.tbpP615V100.Name = "tbpP615V100";
            this.tbpP615V100.Padding = new System.Windows.Forms.Padding(3);
            this.tbpP615V100.Size = new System.Drawing.Size(679, 392);
            this.tbpP615V100.TabIndex = 5;
            this.tbpP615V100.Text = "P615V100";
            this.tbpP615V100.UseVisualStyleBackColor = true;
            // 
            // tbpControlIC
            // 
            this.tbpControlIC.BackColor = System.Drawing.SystemColors.Control;
            this.tbpControlIC.Location = new System.Drawing.Point(4, 24);
            this.tbpControlIC.Name = "tbpControlIC";
            this.tbpControlIC.Padding = new System.Windows.Forms.Padding(3);
            this.tbpControlIC.Size = new System.Drawing.Size(699, 368);
            this.tbpControlIC.TabIndex = 2;
            this.tbpControlIC.Text = "控制";
            // 
            // USB_PortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 609);
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
            this.tcTest.ResumeLayout(false);
            this.tbpDriverIc.ResumeLayout(false);
            this.tbpDriverIc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoopCnt)).EndInit();
            this.tcDriverTest.ResumeLayout(false);
            this.tbpInterfaceIC.ResumeLayout(false);
            this.tcInterfaceTest.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tcTest;
        private System.Windows.Forms.TabPage tbpDriverIc;
        private System.Windows.Forms.TabPage tbpInterfaceIC;
        private System.Windows.Forms.TabPage tbpControlIC;
        private System.Windows.Forms.TextBox tbChipID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTestMessage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbUsbLookUp;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbUsbOtpType;
        private System.Windows.Forms.CheckBox cbDebugEn;
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
        private System.Windows.Forms.Button btnLdoRegulator;
        private System.Windows.Forms.Button btnAtbScan;
        private System.Windows.Forms.Button btnHysteresisRegulator;
        private System.Windows.Forms.Button btnVcoRegulator;
        private System.Windows.Forms.Button btnIfixRegulator;
        private System.Windows.Forms.Button btnVbgRegulator;
        private System.Windows.Forms.TabControl tcDriverTest;
        private System.Windows.Forms.TabPage tbpP2218V200;
        private System.Windows.Forms.TabPage tbpP2318V100;
        private System.Windows.Forms.TabPage tbpP3268V300;
        private System.Windows.Forms.TabPage tbpP3288V100;
        private System.Windows.Forms.TabPage tbpP2216RV100;
        private System.Windows.Forms.TabPage tbpP2316RV100;
        private System.Windows.Forms.TabPage tbpP5662V100;
        private System.Windows.Forms.TabPage tbpP1287V104;
        private System.Windows.Forms.TabControl tcInterfaceTest;
        private System.Windows.Forms.TabPage tbpP614V102;
        private System.Windows.Forms.TabPage tbpP615V100;
        private System.Windows.Forms.ComboBox cmbAtbNodeName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbProjectName;
        private System.Windows.Forms.CheckBox cbProjectNameEn;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbDriverRegAddr;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox cbDriverBlueChipEn;
        private System.Windows.Forms.CheckBox cbDriverGreenChipEn;
        private System.Windows.Forms.CheckBox cbDriverRedChipEn;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbDriverRegValue;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tbInstPowerAddr;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox cbIfixTestEn;
        private System.Windows.Forms.CheckBox cbHysTestEn;
        private System.Windows.Forms.CheckBox cbLdoTestEn;
        private System.Windows.Forms.CheckBox cbVcoTestEn;
        private System.Windows.Forms.CheckBox cbAtbTestEn;
        private System.Windows.Forms.CheckBox cbVbgTestEn;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbInstMultiAddr;
        private System.Windows.Forms.CheckBox cbMultiSelEn;
        private System.Windows.Forms.CheckBox cbPowerSelEn;
        private System.Windows.Forms.CheckBox cbPreDrivEn;
        private System.Windows.Forms.Button btnPreDriverVoltTest;
        private System.Windows.Forms.Button btnStopEn;
        private System.Windows.Forms.Button btnMultiInit;
        private System.Windows.Forms.CheckBox cbAteLoopEn;
        private System.Windows.Forms.Button btnAteLoopTest;
        private System.Windows.Forms.NumericUpDown nudLoopCnt;
        private System.Windows.Forms.Label lbViewCnt;
        private System.Windows.Forms.CheckBox cbCh4En;
        private System.Windows.Forms.CheckBox cbCh3En;
        private System.Windows.Forms.CheckBox cbCh2En;
        private System.Windows.Forms.CheckBox cbCh1En;
    }
}