﻿
namespace AutoCtrl.CommonForm {
    partial class SerialPortCommunicationForm {
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
            this.palPortSetArea = new System.Windows.Forms.Panel();
            this.gbSerialPortSet = new System.Windows.Forms.GroupBox();
            this.cmbStopBitSet = new System.Windows.Forms.ComboBox();
            this.cmbComPortSel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVerifyBitSet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDataWidthSet = new System.Windows.Forms.ComboBox();
            this.cmbBaudRateSet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSerialPortOnOff = new System.Windows.Forms.Button();
            this.palReciveArea = new System.Windows.Forms.Panel();
            this.rtbReceive = new System.Windows.Forms.RichTextBox();
            this.palReceiveSetArea = new System.Windows.Forms.Panel();
            this.gbReceiveSet = new System.Windows.Forms.GroupBox();
            this.cbReceiveTimeDisplay = new System.Windows.Forms.CheckBox();
            this.btnClearReceive = new System.Windows.Forms.Button();
            this.rbReceiveHex = new System.Windows.Forms.RadioButton();
            this.rbReceiveAscii = new System.Windows.Forms.RadioButton();
            this.palSendSetArea = new System.Windows.Forms.Panel();
            this.gbSendSet = new System.Windows.Forms.GroupBox();
            this.nudTimeInterval = new System.Windows.Forms.NumericUpDown();
            this.cbAutoSend = new System.Windows.Forms.CheckBox();
            this.cbSendNewLine = new System.Windows.Forms.CheckBox();
            this.rbSendHex = new System.Windows.Forms.RadioButton();
            this.rbSendAscii = new System.Windows.Forms.RadioButton();
            this.palSendArea = new System.Windows.Forms.Panel();
            this.rtbSend = new System.Windows.Forms.RichTextBox();
            this.palSerialPortStatusArea = new System.Windows.Forms.Panel();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.lbRxCnt = new System.Windows.Forms.Label();
            this.lbTxCnt = new System.Windows.Forms.Label();
            this.lbReceiveByte = new System.Windows.Forms.Label();
            this.lbSendByte = new System.Windows.Forms.Label();
            this.lbSpState = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.btnSendStart = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gbChipSelSet = new System.Windows.Forms.GroupBox();
            this.cbCh4En = new System.Windows.Forms.CheckBox();
            this.cbCh3En = new System.Windows.Forms.CheckBox();
            this.cbCh2En = new System.Windows.Forms.CheckBox();
            this.cbCh1En = new System.Windows.Forms.CheckBox();
            this.cmbInstrumentMulti1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbEnMulti1 = new System.Windows.Forms.CheckBox();
            this.rbPwrItechEn = new System.Windows.Forms.RadioButton();
            this.cmbInstrumentPower = new System.Windows.Forms.ComboBox();
            this.rbPwrGppEn = new System.Windows.Forms.RadioButton();
            this.btnLinkSel = new System.Windows.Forms.Button();
            this.rbPwrKeyEn = new System.Windows.Forms.RadioButton();
            this.cmbInstrumentMulti0 = new System.Windows.Forms.ComboBox();
            this.btnReleaseSel = new System.Windows.Forms.Button();
            this.cbEnPower = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEnMulti0 = new System.Windows.Forms.CheckBox();
            this.lbPowerAddr = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rtbLogPrint = new System.Windows.Forms.RichTextBox();
            this.tpTestConfig = new System.Windows.Forms.TabControl();
            this.tbpP1040Test = new System.Windows.Forms.TabPage();
            this.label34 = new System.Windows.Forms.Label();
            this.cbOscTrimEn = new System.Windows.Forms.CheckBox();
            this.cbGccTrimEn = new System.Windows.Forms.CheckBox();
            this.cbChipCnt = new System.Windows.Forms.CheckBox();
            this.cbLdoTrimEn = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbVbgTrimEn = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudChipCnt_1040 = new System.Windows.Forms.NumericUpDown();
            this.nudGccTrim_1040 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudOscTrim_1040 = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbOscDivCmd_1040 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.nudLdoCfg_1040 = new System.Windows.Forms.NumericUpDown();
            this.cmbFastCmd_1040 = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cmbAtbSel_1040 = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbCmdType = new System.Windows.Forms.ComboBox();
            this.nudVbgCfg_1040 = new System.Windows.Forms.NumericUpDown();
            this.tbp3268Test = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.cmbMonitor_3268 = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.cmbFastCmd_3268 = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.cmbAtbSel_3268 = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nudTestCnt = new System.Windows.Forms.NumericUpDown();
            this.nudReadInstDelay = new System.Windows.Forms.NumericUpDown();
            this.btnOneKeyLed = new System.Windows.Forms.Button();
            this.cbLoadTable = new System.Windows.Forms.CheckBox();
            this.btnRunTest_1040 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbAutoTestItem_1040 = new System.Windows.Forms.ComboBox();
            this.btnP1040RegCfg = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.tbP1040RegAddr = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbP1040RegValue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTestMessage = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbChipID = new System.Windows.Forms.TextBox();
            this.btnStopEn = new System.Windows.Forms.Button();
            this.gbProjectTest = new System.Windows.Forms.GroupBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.cmbProjectSel = new System.Windows.Forms.ComboBox();
            this.palPortSetArea.SuspendLayout();
            this.gbSerialPortSet.SuspendLayout();
            this.palReciveArea.SuspendLayout();
            this.palReceiveSetArea.SuspendLayout();
            this.gbReceiveSet.SuspendLayout();
            this.palSendSetArea.SuspendLayout();
            this.gbSendSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeInterval)).BeginInit();
            this.palSendArea.SuspendLayout();
            this.palSerialPortStatusArea.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbChipSelSet.SuspendLayout();
            this.tpTestConfig.SuspendLayout();
            this.tbpP1040Test.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChipCnt_1040)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGccTrim_1040)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOscTrim_1040)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLdoCfg_1040)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVbgCfg_1040)).BeginInit();
            this.tbp3268Test.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTestCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReadInstDelay)).BeginInit();
            this.gbProjectTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // palPortSetArea
            // 
            this.palPortSetArea.Controls.Add(this.gbSerialPortSet);
            this.palPortSetArea.Controls.Add(this.btnSerialPortOnOff);
            this.palPortSetArea.Location = new System.Drawing.Point(12, 21);
            this.palPortSetArea.Name = "palPortSetArea";
            this.palPortSetArea.Size = new System.Drawing.Size(200, 276);
            this.palPortSetArea.TabIndex = 0;
            // 
            // gbSerialPortSet
            // 
            this.gbSerialPortSet.Controls.Add(this.cmbStopBitSet);
            this.gbSerialPortSet.Controls.Add(this.cmbComPortSel);
            this.gbSerialPortSet.Controls.Add(this.label5);
            this.gbSerialPortSet.Controls.Add(this.label1);
            this.gbSerialPortSet.Controls.Add(this.cmbVerifyBitSet);
            this.gbSerialPortSet.Controls.Add(this.label4);
            this.gbSerialPortSet.Controls.Add(this.label2);
            this.gbSerialPortSet.Controls.Add(this.cmbDataWidthSet);
            this.gbSerialPortSet.Controls.Add(this.cmbBaudRateSet);
            this.gbSerialPortSet.Controls.Add(this.label3);
            this.gbSerialPortSet.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbSerialPortSet.Location = new System.Drawing.Point(3, 3);
            this.gbSerialPortSet.Name = "gbSerialPortSet";
            this.gbSerialPortSet.Size = new System.Drawing.Size(197, 218);
            this.gbSerialPortSet.TabIndex = 0;
            this.gbSerialPortSet.TabStop = false;
            this.gbSerialPortSet.Text = "串口设置";
            // 
            // cmbStopBitSet
            // 
            this.cmbStopBitSet.BackColor = System.Drawing.SystemColors.Control;
            this.cmbStopBitSet.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbStopBitSet.FormattingEnabled = true;
            this.cmbStopBitSet.Location = new System.Drawing.Point(78, 179);
            this.cmbStopBitSet.Name = "cmbStopBitSet";
            this.cmbStopBitSet.Size = new System.Drawing.Size(106, 28);
            this.cmbStopBitSet.TabIndex = 18;
            // 
            // cmbComPortSel
            // 
            this.cmbComPortSel.BackColor = System.Drawing.SystemColors.Control;
            this.cmbComPortSel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbComPortSel.FormattingEnabled = true;
            this.cmbComPortSel.Location = new System.Drawing.Point(78, 43);
            this.cmbComPortSel.Name = "cmbComPortSel";
            this.cmbComPortSel.Size = new System.Drawing.Size(106, 28);
            this.cmbComPortSel.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(20, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "停止位";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "串   口";
            // 
            // cmbVerifyBitSet
            // 
            this.cmbVerifyBitSet.BackColor = System.Drawing.SystemColors.Control;
            this.cmbVerifyBitSet.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbVerifyBitSet.FormattingEnabled = true;
            this.cmbVerifyBitSet.Location = new System.Drawing.Point(78, 145);
            this.cmbVerifyBitSet.Name = "cmbVerifyBitSet";
            this.cmbVerifyBitSet.Size = new System.Drawing.Size(106, 28);
            this.cmbVerifyBitSet.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(20, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "校验位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "波特率";
            // 
            // cmbDataWidthSet
            // 
            this.cmbDataWidthSet.BackColor = System.Drawing.SystemColors.Control;
            this.cmbDataWidthSet.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbDataWidthSet.FormattingEnabled = true;
            this.cmbDataWidthSet.Location = new System.Drawing.Point(78, 111);
            this.cmbDataWidthSet.Name = "cmbDataWidthSet";
            this.cmbDataWidthSet.Size = new System.Drawing.Size(106, 28);
            this.cmbDataWidthSet.TabIndex = 14;
            // 
            // cmbBaudRateSet
            // 
            this.cmbBaudRateSet.BackColor = System.Drawing.SystemColors.Control;
            this.cmbBaudRateSet.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbBaudRateSet.FormattingEnabled = true;
            this.cmbBaudRateSet.Location = new System.Drawing.Point(78, 77);
            this.cmbBaudRateSet.Name = "cmbBaudRateSet";
            this.cmbBaudRateSet.Size = new System.Drawing.Size(106, 28);
            this.cmbBaudRateSet.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(20, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "数据位";
            // 
            // btnSerialPortOnOff
            // 
            this.btnSerialPortOnOff.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSerialPortOnOff.Location = new System.Drawing.Point(25, 227);
            this.btnSerialPortOnOff.Name = "btnSerialPortOnOff";
            this.btnSerialPortOnOff.Size = new System.Drawing.Size(162, 36);
            this.btnSerialPortOnOff.TabIndex = 10;
            this.btnSerialPortOnOff.Text = "Open";
            this.btnSerialPortOnOff.UseVisualStyleBackColor = true;
            this.btnSerialPortOnOff.Click += new System.EventHandler(this.btnSerialPortOnOff_Click);
            // 
            // palReciveArea
            // 
            this.palReciveArea.Controls.Add(this.rtbReceive);
            this.palReciveArea.Location = new System.Drawing.Point(218, 21);
            this.palReciveArea.Name = "palReciveArea";
            this.palReciveArea.Size = new System.Drawing.Size(532, 308);
            this.palReciveArea.TabIndex = 1;
            // 
            // rtbReceive
            // 
            this.rtbReceive.BackColor = System.Drawing.SystemColors.Control;
            this.rtbReceive.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbReceive.Location = new System.Drawing.Point(3, 3);
            this.rtbReceive.Name = "rtbReceive";
            this.rtbReceive.Size = new System.Drawing.Size(523, 302);
            this.rtbReceive.TabIndex = 1;
            this.rtbReceive.Text = "";
            // 
            // palReceiveSetArea
            // 
            this.palReceiveSetArea.Controls.Add(this.gbReceiveSet);
            this.palReceiveSetArea.Location = new System.Drawing.Point(12, 303);
            this.palReceiveSetArea.Name = "palReceiveSetArea";
            this.palReceiveSetArea.Size = new System.Drawing.Size(200, 143);
            this.palReceiveSetArea.TabIndex = 1;
            // 
            // gbReceiveSet
            // 
            this.gbReceiveSet.Controls.Add(this.cbReceiveTimeDisplay);
            this.gbReceiveSet.Controls.Add(this.btnClearReceive);
            this.gbReceiveSet.Controls.Add(this.rbReceiveHex);
            this.gbReceiveSet.Controls.Add(this.rbReceiveAscii);
            this.gbReceiveSet.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbReceiveSet.Location = new System.Drawing.Point(3, 4);
            this.gbReceiveSet.Name = "gbReceiveSet";
            this.gbReceiveSet.Size = new System.Drawing.Size(197, 135);
            this.gbReceiveSet.TabIndex = 1;
            this.gbReceiveSet.TabStop = false;
            this.gbReceiveSet.Text = "接收设置";
            // 
            // cbReceiveTimeDisplay
            // 
            this.cbReceiveTimeDisplay.AutoSize = true;
            this.cbReceiveTimeDisplay.Checked = true;
            this.cbReceiveTimeDisplay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbReceiveTimeDisplay.Location = new System.Drawing.Point(18, 57);
            this.cbReceiveTimeDisplay.Name = "cbReceiveTimeDisplay";
            this.cbReceiveTimeDisplay.Size = new System.Drawing.Size(157, 25);
            this.cbReceiveTimeDisplay.TabIndex = 13;
            this.cbReceiveTimeDisplay.Text = "显示接收数据时间";
            this.cbReceiveTimeDisplay.UseVisualStyleBackColor = true;
            // 
            // btnClearReceive
            // 
            this.btnClearReceive.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearReceive.Location = new System.Drawing.Point(18, 88);
            this.btnClearReceive.Name = "btnClearReceive";
            this.btnClearReceive.Size = new System.Drawing.Size(147, 36);
            this.btnClearReceive.TabIndex = 12;
            this.btnClearReceive.Text = "Clear";
            this.btnClearReceive.UseVisualStyleBackColor = true;
            this.btnClearReceive.Click += new System.EventHandler(this.btnClearReceive_Click);
            // 
            // rbReceiveHex
            // 
            this.rbReceiveHex.AutoSize = true;
            this.rbReceiveHex.Checked = true;
            this.rbReceiveHex.Location = new System.Drawing.Point(106, 26);
            this.rbReceiveHex.Name = "rbReceiveHex";
            this.rbReceiveHex.Size = new System.Drawing.Size(59, 25);
            this.rbReceiveHex.TabIndex = 1;
            this.rbReceiveHex.TabStop = true;
            this.rbReceiveHex.Text = "HEX";
            this.rbReceiveHex.UseVisualStyleBackColor = true;
            // 
            // rbReceiveAscii
            // 
            this.rbReceiveAscii.AutoSize = true;
            this.rbReceiveAscii.Enabled = false;
            this.rbReceiveAscii.Location = new System.Drawing.Point(18, 26);
            this.rbReceiveAscii.Name = "rbReceiveAscii";
            this.rbReceiveAscii.Size = new System.Drawing.Size(69, 25);
            this.rbReceiveAscii.TabIndex = 0;
            this.rbReceiveAscii.Text = "ASCII";
            this.rbReceiveAscii.UseVisualStyleBackColor = true;
            // 
            // palSendSetArea
            // 
            this.palSendSetArea.Controls.Add(this.gbSendSet);
            this.palSendSetArea.Location = new System.Drawing.Point(12, 452);
            this.palSendSetArea.Name = "palSendSetArea";
            this.palSendSetArea.Size = new System.Drawing.Size(200, 141);
            this.palSendSetArea.TabIndex = 2;
            // 
            // gbSendSet
            // 
            this.gbSendSet.Controls.Add(this.nudTimeInterval);
            this.gbSendSet.Controls.Add(this.cbAutoSend);
            this.gbSendSet.Controls.Add(this.cbSendNewLine);
            this.gbSendSet.Controls.Add(this.rbSendHex);
            this.gbSendSet.Controls.Add(this.rbSendAscii);
            this.gbSendSet.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbSendSet.Location = new System.Drawing.Point(3, 3);
            this.gbSendSet.Name = "gbSendSet";
            this.gbSendSet.Size = new System.Drawing.Size(197, 135);
            this.gbSendSet.TabIndex = 2;
            this.gbSendSet.TabStop = false;
            this.gbSendSet.Text = "发送设置";
            // 
            // nudTimeInterval
            // 
            this.nudTimeInterval.Location = new System.Drawing.Point(117, 84);
            this.nudTimeInterval.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudTimeInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimeInterval.Name = "nudTimeInterval";
            this.nudTimeInterval.Size = new System.Drawing.Size(73, 29);
            this.nudTimeInterval.TabIndex = 15;
            this.nudTimeInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // cbAutoSend
            // 
            this.cbAutoSend.AutoSize = true;
            this.cbAutoSend.Location = new System.Drawing.Point(18, 88);
            this.cbAutoSend.Name = "cbAutoSend";
            this.cbAutoSend.Size = new System.Drawing.Size(93, 25);
            this.cbAutoSend.TabIndex = 14;
            this.cbAutoSend.Text = "自动发送";
            this.cbAutoSend.UseVisualStyleBackColor = true;
            this.cbAutoSend.CheckedChanged += new System.EventHandler(this.cbAutoSend_CheckedChanged);
            // 
            // cbSendNewLine
            // 
            this.cbSendNewLine.AutoSize = true;
            this.cbSendNewLine.Location = new System.Drawing.Point(18, 57);
            this.cbSendNewLine.Name = "cbSendNewLine";
            this.cbSendNewLine.Size = new System.Drawing.Size(93, 25);
            this.cbSendNewLine.TabIndex = 13;
            this.cbSendNewLine.Text = "发送新行";
            this.cbSendNewLine.UseVisualStyleBackColor = true;
            // 
            // rbSendHex
            // 
            this.rbSendHex.AutoSize = true;
            this.rbSendHex.Checked = true;
            this.rbSendHex.Location = new System.Drawing.Point(106, 26);
            this.rbSendHex.Name = "rbSendHex";
            this.rbSendHex.Size = new System.Drawing.Size(59, 25);
            this.rbSendHex.TabIndex = 1;
            this.rbSendHex.TabStop = true;
            this.rbSendHex.Text = "HEX";
            this.rbSendHex.UseVisualStyleBackColor = true;
            // 
            // rbSendAscii
            // 
            this.rbSendAscii.AutoSize = true;
            this.rbSendAscii.Enabled = false;
            this.rbSendAscii.Location = new System.Drawing.Point(18, 26);
            this.rbSendAscii.Name = "rbSendAscii";
            this.rbSendAscii.Size = new System.Drawing.Size(69, 25);
            this.rbSendAscii.TabIndex = 0;
            this.rbSendAscii.Text = "ASCII";
            this.rbSendAscii.UseVisualStyleBackColor = true;
            // 
            // palSendArea
            // 
            this.palSendArea.Controls.Add(this.rtbSend);
            this.palSendArea.Location = new System.Drawing.Point(218, 335);
            this.palSendArea.Name = "palSendArea";
            this.palSendArea.Size = new System.Drawing.Size(532, 217);
            this.palSendArea.TabIndex = 2;
            // 
            // rtbSend
            // 
            this.rtbSend.BackColor = System.Drawing.SystemColors.Control;
            this.rtbSend.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSend.Location = new System.Drawing.Point(3, 4);
            this.rtbSend.Name = "rtbSend";
            this.rtbSend.Size = new System.Drawing.Size(523, 210);
            this.rtbSend.TabIndex = 0;
            this.rtbSend.Text = "";
            // 
            // palSerialPortStatusArea
            // 
            this.palSerialPortStatusArea.Controls.Add(this.gbStatus);
            this.palSerialPortStatusArea.Location = new System.Drawing.Point(12, 599);
            this.palSerialPortStatusArea.Name = "palSerialPortStatusArea";
            this.palSerialPortStatusArea.Size = new System.Drawing.Size(738, 50);
            this.palSerialPortStatusArea.TabIndex = 2;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.lbRxCnt);
            this.gbStatus.Controls.Add(this.lbTxCnt);
            this.gbStatus.Controls.Add(this.lbReceiveByte);
            this.gbStatus.Controls.Add(this.lbSendByte);
            this.gbStatus.Controls.Add(this.lbSpState);
            this.gbStatus.Location = new System.Drawing.Point(3, 4);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(729, 40);
            this.gbStatus.TabIndex = 12;
            this.gbStatus.TabStop = false;
            // 
            // lbRxCnt
            // 
            this.lbRxCnt.AutoSize = true;
            this.lbRxCnt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRxCnt.Location = new System.Drawing.Point(515, 16);
            this.lbRxCnt.Name = "lbRxCnt";
            this.lbRxCnt.Size = new System.Drawing.Size(19, 21);
            this.lbRxCnt.TabIndex = 22;
            this.lbRxCnt.Text = "0";
            // 
            // lbTxCnt
            // 
            this.lbTxCnt.AutoSize = true;
            this.lbTxCnt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTxCnt.Location = new System.Drawing.Point(325, 16);
            this.lbTxCnt.Name = "lbTxCnt";
            this.lbTxCnt.Size = new System.Drawing.Size(19, 21);
            this.lbTxCnt.TabIndex = 21;
            this.lbTxCnt.Text = "0";
            // 
            // lbReceiveByte
            // 
            this.lbReceiveByte.AutoSize = true;
            this.lbReceiveByte.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbReceiveByte.Location = new System.Drawing.Point(432, 13);
            this.lbReceiveByte.Name = "lbReceiveByte";
            this.lbReceiveByte.Size = new System.Drawing.Size(77, 21);
            this.lbReceiveByte.TabIndex = 20;
            this.lbReceiveByte.Text = "RX(Byte):";
            // 
            // lbSendByte
            // 
            this.lbSendByte.AutoSize = true;
            this.lbSendByte.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSendByte.Location = new System.Drawing.Point(243, 16);
            this.lbSendByte.Name = "lbSendByte";
            this.lbSendByte.Size = new System.Drawing.Size(76, 21);
            this.lbSendByte.TabIndex = 19;
            this.lbSendByte.Text = "TX(Byte):";
            // 
            // lbSpState
            // 
            this.lbSpState.AutoSize = true;
            this.lbSpState.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSpState.Location = new System.Drawing.Point(6, 13);
            this.lbSpState.Name = "lbSpState";
            this.lbSpState.Size = new System.Drawing.Size(90, 21);
            this.lbSpState.TabIndex = 18;
            this.lbSpState.Text = "串口已关闭";
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // btnSendStart
            // 
            this.btnSendStart.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSendStart.Location = new System.Drawing.Point(659, 557);
            this.btnSendStart.Name = "btnSendStart";
            this.btnSendStart.Size = new System.Drawing.Size(91, 36);
            this.btnSendStart.TabIndex = 11;
            this.btnSendStart.Text = "Send";
            this.btnSendStart.UseVisualStyleBackColor = true;
            this.btnSendStart.Click += new System.EventHandler(this.btnSendStart_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // gbChipSelSet
            // 
            this.gbChipSelSet.Controls.Add(this.cbCh4En);
            this.gbChipSelSet.Controls.Add(this.cbCh3En);
            this.gbChipSelSet.Controls.Add(this.cbCh2En);
            this.gbChipSelSet.Controls.Add(this.cbCh1En);
            this.gbChipSelSet.Controls.Add(this.cmbInstrumentMulti1);
            this.gbChipSelSet.Controls.Add(this.label8);
            this.gbChipSelSet.Controls.Add(this.cbEnMulti1);
            this.gbChipSelSet.Controls.Add(this.rbPwrItechEn);
            this.gbChipSelSet.Controls.Add(this.cmbInstrumentPower);
            this.gbChipSelSet.Controls.Add(this.rbPwrGppEn);
            this.gbChipSelSet.Controls.Add(this.btnLinkSel);
            this.gbChipSelSet.Controls.Add(this.rbPwrKeyEn);
            this.gbChipSelSet.Controls.Add(this.cmbInstrumentMulti0);
            this.gbChipSelSet.Controls.Add(this.btnReleaseSel);
            this.gbChipSelSet.Controls.Add(this.cbEnPower);
            this.gbChipSelSet.Controls.Add(this.label6);
            this.gbChipSelSet.Controls.Add(this.cbEnMulti0);
            this.gbChipSelSet.Controls.Add(this.lbPowerAddr);
            this.gbChipSelSet.Controls.Add(this.btnSearch);
            this.gbChipSelSet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbChipSelSet.Location = new System.Drawing.Point(758, 11);
            this.gbChipSelSet.Name = "gbChipSelSet";
            this.gbChipSelSet.Size = new System.Drawing.Size(507, 148);
            this.gbChipSelSet.TabIndex = 0;
            this.gbChipSelSet.TabStop = false;
            this.gbChipSelSet.Text = "筛片配置";
            // 
            // cbCh4En
            // 
            this.cbCh4En.AutoSize = true;
            this.cbCh4En.Location = new System.Drawing.Point(268, 37);
            this.cbCh4En.Name = "cbCh4En";
            this.cbCh4En.Size = new System.Drawing.Size(51, 21);
            this.cbCh4En.TabIndex = 50;
            this.cbCh4En.Text = "CH4";
            this.cbCh4En.UseVisualStyleBackColor = true;
            // 
            // cbCh3En
            // 
            this.cbCh3En.AutoSize = true;
            this.cbCh3En.Location = new System.Drawing.Point(211, 37);
            this.cbCh3En.Name = "cbCh3En";
            this.cbCh3En.Size = new System.Drawing.Size(51, 21);
            this.cbCh3En.TabIndex = 49;
            this.cbCh3En.Text = "CH3";
            this.cbCh3En.UseVisualStyleBackColor = true;
            // 
            // cbCh2En
            // 
            this.cbCh2En.AutoSize = true;
            this.cbCh2En.Location = new System.Drawing.Point(154, 37);
            this.cbCh2En.Name = "cbCh2En";
            this.cbCh2En.Size = new System.Drawing.Size(51, 21);
            this.cbCh2En.TabIndex = 48;
            this.cbCh2En.Text = "CH2";
            this.cbCh2En.UseVisualStyleBackColor = true;
            // 
            // cbCh1En
            // 
            this.cbCh1En.AutoSize = true;
            this.cbCh1En.Location = new System.Drawing.Point(97, 37);
            this.cbCh1En.Name = "cbCh1En";
            this.cbCh1En.Size = new System.Drawing.Size(51, 21);
            this.cbCh1En.TabIndex = 47;
            this.cbCh1En.Text = "CH1";
            this.cbCh1En.UseVisualStyleBackColor = true;
            // 
            // cmbInstrumentMulti1
            // 
            this.cmbInstrumentMulti1.BackColor = System.Drawing.SystemColors.Control;
            this.cmbInstrumentMulti1.Enabled = false;
            this.cmbInstrumentMulti1.FormattingEnabled = true;
            this.cmbInstrumentMulti1.Items.AddRange(new object[] {
            "TCPIP0::172.18.191.27::1026::SOCKET",
            "TCPIP0::172.18.191.68::inst0::INSTR"});
            this.cmbInstrumentMulti1.Location = new System.Drawing.Point(92, 117);
            this.cmbInstrumentMulti1.Name = "cmbInstrumentMulti1";
            this.cmbInstrumentMulti1.Size = new System.Drawing.Size(267, 25);
            this.cmbInstrumentMulti1.TabIndex = 44;
            this.cmbInstrumentMulti1.Text = "TCPIP0::172.18.191.27::1026::SOCKET";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "万 用 表 01:";
            // 
            // cbEnMulti1
            // 
            this.cbEnMulti1.AutoSize = true;
            this.cbEnMulti1.Location = new System.Drawing.Point(360, 128);
            this.cbEnMulti1.Name = "cbEnMulti1";
            this.cbEnMulti1.Size = new System.Drawing.Size(15, 14);
            this.cbEnMulti1.TabIndex = 45;
            this.cbEnMulti1.UseVisualStyleBackColor = true;
            this.cbEnMulti1.CheckedChanged += new System.EventHandler(this.cbEnable_CheckedChanged);
            // 
            // rbPwrItechEn
            // 
            this.rbPwrItechEn.AutoSize = true;
            this.rbPwrItechEn.Location = new System.Drawing.Point(270, 12);
            this.rbPwrItechEn.Name = "rbPwrItechEn";
            this.rbPwrItechEn.Size = new System.Drawing.Size(89, 21);
            this.rbPwrItechEn.TabIndex = 43;
            this.rbPwrItechEn.Text = "PwrItechEn";
            this.rbPwrItechEn.UseVisualStyleBackColor = true;
            // 
            // cmbInstrumentPower
            // 
            this.cmbInstrumentPower.BackColor = System.Drawing.SystemColors.Control;
            this.cmbInstrumentPower.Enabled = false;
            this.cmbInstrumentPower.FormattingEnabled = true;
            this.cmbInstrumentPower.Items.AddRange(new object[] {
            "TCPIP0::172.18.191.27::1026::SOCKET",
            "TCPIP0::172.18.191.68::inst0::INSTR"});
            this.cmbInstrumentPower.Location = new System.Drawing.Point(92, 63);
            this.cmbInstrumentPower.Name = "cmbInstrumentPower";
            this.cmbInstrumentPower.Size = new System.Drawing.Size(267, 25);
            this.cmbInstrumentPower.TabIndex = 30;
            this.cmbInstrumentPower.Text = "TCPIP0::172.18.191.27::1026::SOCKET";
            // 
            // rbPwrGppEn
            // 
            this.rbPwrGppEn.AutoSize = true;
            this.rbPwrGppEn.Location = new System.Drawing.Point(182, 12);
            this.rbPwrGppEn.Name = "rbPwrGppEn";
            this.rbPwrGppEn.Size = new System.Drawing.Size(86, 21);
            this.rbPwrGppEn.TabIndex = 42;
            this.rbPwrGppEn.Text = "PwrGppEn";
            this.rbPwrGppEn.UseVisualStyleBackColor = true;
            // 
            // btnLinkSel
            // 
            this.btnLinkSel.BackColor = System.Drawing.SystemColors.Control;
            this.btnLinkSel.Location = new System.Drawing.Point(400, 55);
            this.btnLinkSel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLinkSel.Name = "btnLinkSel";
            this.btnLinkSel.Size = new System.Drawing.Size(84, 25);
            this.btnLinkSel.TabIndex = 29;
            this.btnLinkSel.Text = "Link";
            this.btnLinkSel.UseVisualStyleBackColor = false;
            this.btnLinkSel.Click += new System.EventHandler(this.btnLinkSel_Click);
            // 
            // rbPwrKeyEn
            // 
            this.rbPwrKeyEn.AutoSize = true;
            this.rbPwrKeyEn.Checked = true;
            this.rbPwrKeyEn.Location = new System.Drawing.Point(94, 12);
            this.rbPwrKeyEn.Name = "rbPwrKeyEn";
            this.rbPwrKeyEn.Size = new System.Drawing.Size(82, 21);
            this.rbPwrKeyEn.TabIndex = 41;
            this.rbPwrKeyEn.TabStop = true;
            this.rbPwrKeyEn.Text = "PwrKeyEn";
            this.rbPwrKeyEn.UseVisualStyleBackColor = true;
            // 
            // cmbInstrumentMulti0
            // 
            this.cmbInstrumentMulti0.BackColor = System.Drawing.SystemColors.Control;
            this.cmbInstrumentMulti0.Enabled = false;
            this.cmbInstrumentMulti0.FormattingEnabled = true;
            this.cmbInstrumentMulti0.Items.AddRange(new object[] {
            "TCPIP0::172.18.191.27::1026::SOCKET",
            "TCPIP0::172.18.191.68::inst0::INSTR"});
            this.cmbInstrumentMulti0.Location = new System.Drawing.Point(92, 90);
            this.cmbInstrumentMulti0.Name = "cmbInstrumentMulti0";
            this.cmbInstrumentMulti0.Size = new System.Drawing.Size(267, 25);
            this.cmbInstrumentMulti0.TabIndex = 31;
            this.cmbInstrumentMulti0.Text = "TCPIP0::172.18.191.27::1026::SOCKET";
            // 
            // btnReleaseSel
            // 
            this.btnReleaseSel.Enabled = false;
            this.btnReleaseSel.Location = new System.Drawing.Point(400, 93);
            this.btnReleaseSel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReleaseSel.Name = "btnReleaseSel";
            this.btnReleaseSel.Size = new System.Drawing.Size(84, 27);
            this.btnReleaseSel.TabIndex = 37;
            this.btnReleaseSel.Text = "Release";
            this.btnReleaseSel.UseVisualStyleBackColor = true;
            this.btnReleaseSel.Click += new System.EventHandler(this.btnReleaseSel_Click);
            // 
            // cbEnPower
            // 
            this.cbEnPower.AutoSize = true;
            this.cbEnPower.Location = new System.Drawing.Point(360, 74);
            this.cbEnPower.Name = "cbEnPower";
            this.cbEnPower.Size = new System.Drawing.Size(15, 14);
            this.cbEnPower.TabIndex = 32;
            this.cbEnPower.UseVisualStyleBackColor = true;
            this.cbEnPower.CheckedChanged += new System.EventHandler(this.cbEnable_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "万 用 表 00:";
            // 
            // cbEnMulti0
            // 
            this.cbEnMulti0.AutoSize = true;
            this.cbEnMulti0.Location = new System.Drawing.Point(360, 101);
            this.cbEnMulti0.Name = "cbEnMulti0";
            this.cbEnMulti0.Size = new System.Drawing.Size(15, 14);
            this.cbEnMulti0.TabIndex = 33;
            this.cbEnMulti0.UseVisualStyleBackColor = true;
            this.cbEnMulti0.CheckedChanged += new System.EventHandler(this.cbEnable_CheckedChanged);
            // 
            // lbPowerAddr
            // 
            this.lbPowerAddr.AutoSize = true;
            this.lbPowerAddr.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPowerAddr.Location = new System.Drawing.Point(9, 65);
            this.lbPowerAddr.Name = "lbPowerAddr";
            this.lbPowerAddr.Size = new System.Drawing.Size(80, 20);
            this.lbPowerAddr.TabIndex = 35;
            this.lbPowerAddr.Text = "电 源 地 址:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.Location = new System.Drawing.Point(400, 24);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 25);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rtbLogPrint
            // 
            this.rtbLogPrint.BackColor = System.Drawing.SystemColors.Control;
            this.rtbLogPrint.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLogPrint.Location = new System.Drawing.Point(756, 558);
            this.rtbLogPrint.Name = "rtbLogPrint";
            this.rtbLogPrint.Size = new System.Drawing.Size(509, 91);
            this.rtbLogPrint.TabIndex = 2;
            this.rtbLogPrint.Text = "";
            // 
            // tpTestConfig
            // 
            this.tpTestConfig.Controls.Add(this.tbpP1040Test);
            this.tpTestConfig.Controls.Add(this.tbp3268Test);
            this.tpTestConfig.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tpTestConfig.Location = new System.Drawing.Point(6, 194);
            this.tpTestConfig.Name = "tpTestConfig";
            this.tpTestConfig.SelectedIndex = 0;
            this.tpTestConfig.Size = new System.Drawing.Size(499, 152);
            this.tpTestConfig.TabIndex = 17;
            // 
            // tbpP1040Test
            // 
            this.tbpP1040Test.Controls.Add(this.label34);
            this.tbpP1040Test.Controls.Add(this.cbOscTrimEn);
            this.tbpP1040Test.Controls.Add(this.cbGccTrimEn);
            this.tbpP1040Test.Controls.Add(this.cbChipCnt);
            this.tbpP1040Test.Controls.Add(this.cbLdoTrimEn);
            this.tbpP1040Test.Controls.Add(this.label10);
            this.tbpP1040Test.Controls.Add(this.cbVbgTrimEn);
            this.tbpP1040Test.Controls.Add(this.label9);
            this.tbpP1040Test.Controls.Add(this.nudChipCnt_1040);
            this.tbpP1040Test.Controls.Add(this.nudGccTrim_1040);
            this.tbpP1040Test.Controls.Add(this.label7);
            this.tbpP1040Test.Controls.Add(this.nudOscTrim_1040);
            this.tbpP1040Test.Controls.Add(this.label22);
            this.tbpP1040Test.Controls.Add(this.cmbOscDivCmd_1040);
            this.tbpP1040Test.Controls.Add(this.label19);
            this.tbpP1040Test.Controls.Add(this.label21);
            this.tbpP1040Test.Controls.Add(this.nudLdoCfg_1040);
            this.tbpP1040Test.Controls.Add(this.cmbFastCmd_1040);
            this.tbpP1040Test.Controls.Add(this.label24);
            this.tbpP1040Test.Controls.Add(this.cmbAtbSel_1040);
            this.tbpP1040Test.Controls.Add(this.label23);
            this.tbpP1040Test.Controls.Add(this.label20);
            this.tbpP1040Test.Controls.Add(this.cmbCmdType);
            this.tbpP1040Test.Controls.Add(this.nudVbgCfg_1040);
            this.tbpP1040Test.Location = new System.Drawing.Point(4, 26);
            this.tbpP1040Test.Name = "tbpP1040Test";
            this.tbpP1040Test.Padding = new System.Windows.Forms.Padding(3);
            this.tbpP1040Test.Size = new System.Drawing.Size(491, 122);
            this.tbpP1040Test.TabIndex = 2;
            this.tbpP1040Test.Text = "P1040 Test";
            this.tbpP1040Test.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.SystemColors.Window;
            this.label34.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label34.Location = new System.Drawing.Point(388, 3);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(74, 17);
            this.label34.TabIndex = 94;
            this.label34.Text = "Trim 选择：";
            // 
            // cbOscTrimEn
            // 
            this.cbOscTrimEn.AutoSize = true;
            this.cbOscTrimEn.Location = new System.Drawing.Point(472, 101);
            this.cbOscTrimEn.Name = "cbOscTrimEn";
            this.cbOscTrimEn.Size = new System.Drawing.Size(15, 14);
            this.cbOscTrimEn.TabIndex = 89;
            this.cbOscTrimEn.UseVisualStyleBackColor = true;
            this.cbOscTrimEn.CheckedChanged += new System.EventHandler(this.trimEn_CheckChanged);
            // 
            // cbGccTrimEn
            // 
            this.cbGccTrimEn.AutoSize = true;
            this.cbGccTrimEn.Location = new System.Drawing.Point(472, 80);
            this.cbGccTrimEn.Name = "cbGccTrimEn";
            this.cbGccTrimEn.Size = new System.Drawing.Size(15, 14);
            this.cbGccTrimEn.TabIndex = 88;
            this.cbGccTrimEn.UseVisualStyleBackColor = true;
            this.cbGccTrimEn.CheckedChanged += new System.EventHandler(this.trimEn_CheckChanged);
            // 
            // cbChipCnt
            // 
            this.cbChipCnt.AutoSize = true;
            this.cbChipCnt.Location = new System.Drawing.Point(314, 17);
            this.cbChipCnt.Name = "cbChipCnt";
            this.cbChipCnt.Size = new System.Drawing.Size(15, 14);
            this.cbChipCnt.TabIndex = 93;
            this.cbChipCnt.UseVisualStyleBackColor = true;
            this.cbChipCnt.CheckedChanged += new System.EventHandler(this.trimEn_CheckChanged);
            // 
            // cbLdoTrimEn
            // 
            this.cbLdoTrimEn.AutoSize = true;
            this.cbLdoTrimEn.Location = new System.Drawing.Point(472, 56);
            this.cbLdoTrimEn.Name = "cbLdoTrimEn";
            this.cbLdoTrimEn.Size = new System.Drawing.Size(15, 14);
            this.cbLdoTrimEn.TabIndex = 87;
            this.cbLdoTrimEn.UseVisualStyleBackColor = true;
            this.cbLdoTrimEn.CheckedChanged += new System.EventHandler(this.trimEn_CheckChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(205, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 92;
            this.label10.Text = "级联个数:";
            // 
            // cbVbgTrimEn
            // 
            this.cbVbgTrimEn.AutoSize = true;
            this.cbVbgTrimEn.Location = new System.Drawing.Point(472, 34);
            this.cbVbgTrimEn.Name = "cbVbgTrimEn";
            this.cbVbgTrimEn.Size = new System.Drawing.Size(15, 14);
            this.cbVbgTrimEn.TabIndex = 86;
            this.cbVbgTrimEn.UseVisualStyleBackColor = true;
            this.cbVbgTrimEn.CheckedChanged += new System.EventHandler(this.trimEn_CheckChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(368, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 85;
            this.label9.Text = "3-GCC:";
            // 
            // nudChipCnt_1040
            // 
            this.nudChipCnt_1040.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nudChipCnt_1040.Enabled = false;
            this.nudChipCnt_1040.ForeColor = System.Drawing.Color.Black;
            this.nudChipCnt_1040.Location = new System.Drawing.Point(274, 8);
            this.nudChipCnt_1040.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.nudChipCnt_1040.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudChipCnt_1040.Name = "nudChipCnt_1040";
            this.nudChipCnt_1040.Size = new System.Drawing.Size(37, 23);
            this.nudChipCnt_1040.TabIndex = 91;
            this.nudChipCnt_1040.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nudGccTrim_1040
            // 
            this.nudGccTrim_1040.BackColor = System.Drawing.SystemColors.Control;
            this.nudGccTrim_1040.Enabled = false;
            this.nudGccTrim_1040.Location = new System.Drawing.Point(424, 71);
            this.nudGccTrim_1040.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudGccTrim_1040.Name = "nudGccTrim_1040";
            this.nudGccTrim_1040.Size = new System.Drawing.Size(44, 23);
            this.nudGccTrim_1040.TabIndex = 84;
            this.nudGccTrim_1040.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudGccTrim_1040.ValueChanged += new System.EventHandler(this.nudGccTrim_1040_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(368, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 83;
            this.label7.Text = "4-OSC:";
            // 
            // nudOscTrim_1040
            // 
            this.nudOscTrim_1040.BackColor = System.Drawing.SystemColors.Control;
            this.nudOscTrim_1040.Enabled = false;
            this.nudOscTrim_1040.Location = new System.Drawing.Point(424, 94);
            this.nudOscTrim_1040.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudOscTrim_1040.Name = "nudOscTrim_1040";
            this.nudOscTrim_1040.Size = new System.Drawing.Size(44, 23);
            this.nudOscTrim_1040.TabIndex = 82;
            this.nudOscTrim_1040.Value = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.nudOscTrim_1040.ValueChanged += new System.EventHandler(this.nudOscTrim_1040_ValueChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.Window;
            this.label22.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(12, 92);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 20);
            this.label22.TabIndex = 81;
            this.label22.Text = "OSC分频:";
            // 
            // cmbOscDivCmd_1040
            // 
            this.cmbOscDivCmd_1040.BackColor = System.Drawing.SystemColors.Control;
            this.cmbOscDivCmd_1040.FormattingEnabled = true;
            this.cmbOscDivCmd_1040.Location = new System.Drawing.Point(80, 89);
            this.cmbOscDivCmd_1040.Name = "cmbOscDivCmd_1040";
            this.cmbOscDivCmd_1040.Size = new System.Drawing.Size(168, 25);
            this.cmbOscDivCmd_1040.TabIndex = 80;
            this.cmbOscDivCmd_1040.Text = "下拉框选择：OSC分频系数";
            this.cmbOscDivCmd_1040.SelectedIndexChanged += new System.EventHandler(this.cmbOscDiv_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.Window;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 20);
            this.label19.TabIndex = 79;
            this.label19.Text = "快速指令:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.Window;
            this.label21.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(368, 49);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 20);
            this.label21.TabIndex = 77;
            this.label21.Text = "2-LDO:";
            // 
            // nudLdoCfg_1040
            // 
            this.nudLdoCfg_1040.BackColor = System.Drawing.SystemColors.Control;
            this.nudLdoCfg_1040.Enabled = false;
            this.nudLdoCfg_1040.Location = new System.Drawing.Point(424, 48);
            this.nudLdoCfg_1040.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudLdoCfg_1040.Name = "nudLdoCfg_1040";
            this.nudLdoCfg_1040.Size = new System.Drawing.Size(44, 23);
            this.nudLdoCfg_1040.TabIndex = 76;
            this.nudLdoCfg_1040.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudLdoCfg_1040.ValueChanged += new System.EventHandler(this.nudLdoCfg_1040_ValueChanged);
            // 
            // cmbFastCmd_1040
            // 
            this.cmbFastCmd_1040.BackColor = System.Drawing.SystemColors.Control;
            this.cmbFastCmd_1040.FormattingEnabled = true;
            this.cmbFastCmd_1040.Location = new System.Drawing.Point(80, 64);
            this.cmbFastCmd_1040.Name = "cmbFastCmd_1040";
            this.cmbFastCmd_1040.Size = new System.Drawing.Size(168, 25);
            this.cmbFastCmd_1040.TabIndex = 78;
            this.cmbFastCmd_1040.Text = "下拉框选择：快速命令行";
            this.cmbFastCmd_1040.SelectedIndexChanged += new System.EventHandler(this.cmbFastCmd_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.SystemColors.Window;
            this.label24.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(12, 42);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 20);
            this.label24.TabIndex = 74;
            this.label24.Text = "ATB选择:";
            // 
            // cmbAtbSel_1040
            // 
            this.cmbAtbSel_1040.BackColor = System.Drawing.SystemColors.Control;
            this.cmbAtbSel_1040.FormattingEnabled = true;
            this.cmbAtbSel_1040.Location = new System.Drawing.Point(80, 39);
            this.cmbAtbSel_1040.Name = "cmbAtbSel_1040";
            this.cmbAtbSel_1040.Size = new System.Drawing.Size(168, 25);
            this.cmbAtbSel_1040.TabIndex = 73;
            this.cmbAtbSel_1040.Text = "下拉框选择：ATB名称";
            this.cmbAtbSel_1040.SelectedIndexChanged += new System.EventHandler(this.cmbAtbSel_1040_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label23.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(6, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 20);
            this.label23.TabIndex = 66;
            this.label23.Text = "命令类型:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.Window;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(368, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 20);
            this.label20.TabIndex = 71;
            this.label20.Text = "1-VBG:";
            // 
            // cmbCmdType
            // 
            this.cmbCmdType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbCmdType.Enabled = false;
            this.cmbCmdType.ForeColor = System.Drawing.Color.Black;
            this.cmbCmdType.FormattingEnabled = true;
            this.cmbCmdType.Items.AddRange(new object[] {
            "广播写",
            "非广播写",
            "写数据模式",
            "排序模式",
            "广播读",
            "非广播读",
            "帧同步模式",
            "CRC错误",
            "错误命令",
            "级联个数配置",
            "FB_1040使能",
            "Normal_1040使能",
            "FB调节模块开关",
            "帧频调节"});
            this.cmbCmdType.Location = new System.Drawing.Point(75, 7);
            this.cmbCmdType.Name = "cmbCmdType";
            this.cmbCmdType.Size = new System.Drawing.Size(116, 25);
            this.cmbCmdType.TabIndex = 47;
            this.cmbCmdType.Text = "广播写";
            // 
            // nudVbgCfg_1040
            // 
            this.nudVbgCfg_1040.BackColor = System.Drawing.SystemColors.Control;
            this.nudVbgCfg_1040.Enabled = false;
            this.nudVbgCfg_1040.Location = new System.Drawing.Point(424, 25);
            this.nudVbgCfg_1040.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudVbgCfg_1040.Name = "nudVbgCfg_1040";
            this.nudVbgCfg_1040.Size = new System.Drawing.Size(44, 23);
            this.nudVbgCfg_1040.TabIndex = 68;
            this.nudVbgCfg_1040.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudVbgCfg_1040.ValueChanged += new System.EventHandler(this.nudVbgCfg_1040_ValueChanged);
            // 
            // tbp3268Test
            // 
            this.tbp3268Test.Controls.Add(this.checkBox1);
            this.tbp3268Test.Controls.Add(this.checkBox2);
            this.tbp3268Test.Controls.Add(this.checkBox3);
            this.tbp3268Test.Controls.Add(this.checkBox4);
            this.tbp3268Test.Controls.Add(this.label16);
            this.tbp3268Test.Controls.Add(this.numericUpDown1);
            this.tbp3268Test.Controls.Add(this.label25);
            this.tbp3268Test.Controls.Add(this.numericUpDown2);
            this.tbp3268Test.Controls.Add(this.label26);
            this.tbp3268Test.Controls.Add(this.cmbMonitor_3268);
            this.tbp3268Test.Controls.Add(this.label27);
            this.tbp3268Test.Controls.Add(this.label28);
            this.tbp3268Test.Controls.Add(this.numericUpDown3);
            this.tbp3268Test.Controls.Add(this.cmbFastCmd_3268);
            this.tbp3268Test.Controls.Add(this.label29);
            this.tbp3268Test.Controls.Add(this.cmbAtbSel_3268);
            this.tbp3268Test.Controls.Add(this.label30);
            this.tbp3268Test.Controls.Add(this.numericUpDown4);
            this.tbp3268Test.Location = new System.Drawing.Point(4, 26);
            this.tbp3268Test.Name = "tbp3268Test";
            this.tbp3268Test.Padding = new System.Windows.Forms.Padding(3);
            this.tbp3268Test.Size = new System.Drawing.Size(491, 122);
            this.tbp3268Test.TabIndex = 3;
            this.tbp3268Test.Text = "P3268 Test";
            this.tbp3268Test.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(119, 89);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 107;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(119, 68);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 106;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(119, 44);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 105;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(119, 22);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 104;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label16.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 20);
            this.label16.TabIndex = 103;
            this.label16.Text = "3-GCC:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(71, 59);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 23);
            this.numericUpDown1.TabIndex = 102;
            this.numericUpDown1.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label25.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(15, 84);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(54, 20);
            this.label25.TabIndex = 101;
            this.label25.Text = "4-OSC:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Location = new System.Drawing.Point(71, 82);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(44, 23);
            this.numericUpDown2.TabIndex = 100;
            this.numericUpDown2.Value = new decimal(new int[] {
            127,
            0,
            0,
            0});
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label26.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(249, 65);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(67, 20);
            this.label26.TabIndex = 99;
            this.label26.Text = "Monitor:";
            // 
            // cmbMonitor_3268
            // 
            this.cmbMonitor_3268.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmbMonitor_3268.FormattingEnabled = true;
            this.cmbMonitor_3268.Location = new System.Drawing.Point(317, 62);
            this.cmbMonitor_3268.Name = "cmbMonitor_3268";
            this.cmbMonitor_3268.Size = new System.Drawing.Size(168, 25);
            this.cmbMonitor_3268.TabIndex = 98;
            this.cmbMonitor_3268.Text = "下拉框选择：OSC分频系数";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label27.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(249, 39);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(68, 20);
            this.label27.TabIndex = 97;
            this.label27.Text = "快速指令:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label28.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(15, 37);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(55, 20);
            this.label28.TabIndex = 95;
            this.label28.Text = "2-LDO:";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numericUpDown3.Enabled = false;
            this.numericUpDown3.Location = new System.Drawing.Point(71, 36);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(44, 23);
            this.numericUpDown3.TabIndex = 94;
            this.numericUpDown3.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // cmbFastCmd_3268
            // 
            this.cmbFastCmd_3268.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmbFastCmd_3268.FormattingEnabled = true;
            this.cmbFastCmd_3268.Location = new System.Drawing.Point(317, 37);
            this.cmbFastCmd_3268.Name = "cmbFastCmd_3268";
            this.cmbFastCmd_3268.Size = new System.Drawing.Size(168, 25);
            this.cmbFastCmd_3268.TabIndex = 96;
            this.cmbFastCmd_3268.Text = "下拉框选择：快速命令行";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label29.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(249, 15);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(67, 20);
            this.label29.TabIndex = 93;
            this.label29.Text = "ATB选择:";
            // 
            // cmbAtbSel_3268
            // 
            this.cmbAtbSel_3268.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmbAtbSel_3268.FormattingEnabled = true;
            this.cmbAtbSel_3268.Location = new System.Drawing.Point(317, 12);
            this.cmbAtbSel_3268.Name = "cmbAtbSel_3268";
            this.cmbAtbSel_3268.Size = new System.Drawing.Size(168, 25);
            this.cmbAtbSel_3268.TabIndex = 92;
            this.cmbAtbSel_3268.Text = "下拉框选择：ATB名称";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label30.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(15, 14);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(54, 20);
            this.label30.TabIndex = 91;
            this.label30.Text = "1-VBG:";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numericUpDown4.Enabled = false;
            this.numericUpDown4.Location = new System.Drawing.Point(71, 13);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(44, 23);
            this.numericUpDown4.TabIndex = 90;
            this.numericUpDown4.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 160);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 20);
            this.label15.TabIndex = 97;
            this.label15.Text = "循环次数:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 95;
            this.label14.Text = "延时(ms):";
            // 
            // nudTestCnt
            // 
            this.nudTestCnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nudTestCnt.Location = new System.Drawing.Point(92, 158);
            this.nudTestCnt.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudTestCnt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTestCnt.Name = "nudTestCnt";
            this.nudTestCnt.Size = new System.Drawing.Size(57, 23);
            this.nudTestCnt.TabIndex = 96;
            this.nudTestCnt.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudReadInstDelay
            // 
            this.nudReadInstDelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nudReadInstDelay.Location = new System.Drawing.Point(92, 135);
            this.nudReadInstDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudReadInstDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudReadInstDelay.Name = "nudReadInstDelay";
            this.nudReadInstDelay.Size = new System.Drawing.Size(57, 23);
            this.nudReadInstDelay.TabIndex = 94;
            this.nudReadInstDelay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnOneKeyLed
            // 
            this.btnOneKeyLed.BackColor = System.Drawing.SystemColors.Control;
            this.btnOneKeyLed.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOneKeyLed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOneKeyLed.Location = new System.Drawing.Point(195, 136);
            this.btnOneKeyLed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOneKeyLed.Name = "btnOneKeyLed";
            this.btnOneKeyLed.Size = new System.Drawing.Size(61, 49);
            this.btnOneKeyLed.TabIndex = 90;
            this.btnOneKeyLed.Text = "一键 点屏";
            this.btnOneKeyLed.UseVisualStyleBackColor = false;
            this.btnOneKeyLed.Click += new System.EventHandler(this.btnOneKeyLed_Click);
            // 
            // cbLoadTable
            // 
            this.cbLoadTable.AutoSize = true;
            this.cbLoadTable.Location = new System.Drawing.Point(92, 54);
            this.cbLoadTable.Name = "cbLoadTable";
            this.cbLoadTable.Size = new System.Drawing.Size(15, 14);
            this.cbLoadTable.TabIndex = 75;
            this.cbLoadTable.UseVisualStyleBackColor = true;
            this.cbLoadTable.CheckedChanged += new System.EventHandler(this.cbLoadTable_CheckedChanged);
            // 
            // btnRunTest_1040
            // 
            this.btnRunTest_1040.BackColor = System.Drawing.SystemColors.Control;
            this.btnRunTest_1040.Font = new System.Drawing.Font("幼圆", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRunTest_1040.ForeColor = System.Drawing.Color.Blue;
            this.btnRunTest_1040.Location = new System.Drawing.Point(419, 77);
            this.btnRunTest_1040.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRunTest_1040.Name = "btnRunTest_1040";
            this.btnRunTest_1040.Size = new System.Drawing.Size(82, 58);
            this.btnRunTest_1040.TabIndex = 94;
            this.btnRunTest_1040.Text = "Run";
            this.btnRunTest_1040.UseVisualStyleBackColor = false;
            this.btnRunTest_1040.Click += new System.EventHandler(this.btnRunTest_1040_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(313, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 20);
            this.label13.TabIndex = 94;
            this.label13.Text = "测试选择:";
            // 
            // cmbAutoTestItem_1040
            // 
            this.cmbAutoTestItem_1040.BackColor = System.Drawing.SystemColors.Control;
            this.cmbAutoTestItem_1040.FormattingEnabled = true;
            this.cmbAutoTestItem_1040.Location = new System.Drawing.Point(317, 45);
            this.cmbAutoTestItem_1040.Name = "cmbAutoTestItem_1040";
            this.cmbAutoTestItem_1040.Size = new System.Drawing.Size(184, 25);
            this.cmbAutoTestItem_1040.TabIndex = 81;
            this.cmbAutoTestItem_1040.Text = "下拉框选择：测试项";
            // 
            // btnP1040RegCfg
            // 
            this.btnP1040RegCfg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnP1040RegCfg.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnP1040RegCfg.Location = new System.Drawing.Point(195, 78);
            this.btnP1040RegCfg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnP1040RegCfg.Name = "btnP1040RegCfg";
            this.btnP1040RegCfg.Size = new System.Drawing.Size(61, 49);
            this.btnP1040RegCfg.TabIndex = 58;
            this.btnP1040RegCfg.Text = "配置 寄存器";
            this.btnP1040RegCfg.UseVisualStyleBackColor = false;
            this.btnP1040RegCfg.Click += new System.EventHandler(this.btnP1040RegCfg_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Control;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(15, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 20);
            this.label17.TabIndex = 55;
            this.label17.Text = "地址(Hex):";
            // 
            // tbP1040RegAddr
            // 
            this.tbP1040RegAddr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbP1040RegAddr.Location = new System.Drawing.Point(92, 80);
            this.tbP1040RegAddr.Name = "tbP1040RegAddr";
            this.tbP1040RegAddr.Size = new System.Drawing.Size(100, 23);
            this.tbP1040RegAddr.TabIndex = 54;
            this.tbP1040RegAddr.Text = "17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.Control;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(15, 103);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 20);
            this.label18.TabIndex = 53;
            this.label18.Text = "配置(Hex):";
            // 
            // tbP1040RegValue
            // 
            this.tbP1040RegValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbP1040RegValue.Location = new System.Drawing.Point(92, 103);
            this.tbP1040RegValue.Name = "tbP1040RegValue";
            this.tbP1040RegValue.Size = new System.Drawing.Size(100, 23);
            this.tbP1040RegValue.TabIndex = 52;
            this.tbP1040RegValue.Text = "ABCD000F999D";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(762, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 55;
            this.label11.Text = "测试信息:";
            // 
            // tbTestMessage
            // 
            this.tbTestMessage.BackColor = System.Drawing.SystemColors.Control;
            this.tbTestMessage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTestMessage.ForeColor = System.Drawing.Color.Black;
            this.tbTestMessage.Location = new System.Drawing.Point(822, 166);
            this.tbTestMessage.Name = "tbTestMessage";
            this.tbTestMessage.Size = new System.Drawing.Size(203, 23);
            this.tbTestMessage.TabIndex = 54;
            this.tbTestMessage.Text = "P1040_CHNCurr@AVDD";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1041, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 56;
            this.label12.Text = "芯片编号:";
            // 
            // tbChipID
            // 
            this.tbChipID.BackColor = System.Drawing.SystemColors.Control;
            this.tbChipID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbChipID.ForeColor = System.Drawing.Color.Black;
            this.tbChipID.Location = new System.Drawing.Point(1097, 167);
            this.tbChipID.Name = "tbChipID";
            this.tbChipID.Size = new System.Drawing.Size(62, 23);
            this.tbChipID.TabIndex = 57;
            this.tbChipID.Text = "#001";
            // 
            // btnStopEn
            // 
            this.btnStopEn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStopEn.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStopEn.Location = new System.Drawing.Point(221, 557);
            this.btnStopEn.Name = "btnStopEn";
            this.btnStopEn.Size = new System.Drawing.Size(91, 36);
            this.btnStopEn.TabIndex = 58;
            this.btnStopEn.Text = "STOP";
            this.btnStopEn.UseVisualStyleBackColor = false;
            this.btnStopEn.Click += new System.EventHandler(this.btnStopEn_Click);
            // 
            // gbProjectTest
            // 
            this.gbProjectTest.Controls.Add(this.label33);
            this.gbProjectTest.Controls.Add(this.label32);
            this.gbProjectTest.Controls.Add(this.btnRunTest_1040);
            this.gbProjectTest.Controls.Add(this.label31);
            this.gbProjectTest.Controls.Add(this.label13);
            this.gbProjectTest.Controls.Add(this.cmbProjectSel);
            this.gbProjectTest.Controls.Add(this.label15);
            this.gbProjectTest.Controls.Add(this.cmbAutoTestItem_1040);
            this.gbProjectTest.Controls.Add(this.tpTestConfig);
            this.gbProjectTest.Controls.Add(this.label14);
            this.gbProjectTest.Controls.Add(this.btnP1040RegCfg);
            this.gbProjectTest.Controls.Add(this.nudTestCnt);
            this.gbProjectTest.Controls.Add(this.tbP1040RegValue);
            this.gbProjectTest.Controls.Add(this.nudReadInstDelay);
            this.gbProjectTest.Controls.Add(this.label18);
            this.gbProjectTest.Controls.Add(this.tbP1040RegAddr);
            this.gbProjectTest.Controls.Add(this.label17);
            this.gbProjectTest.Controls.Add(this.btnOneKeyLed);
            this.gbProjectTest.Controls.Add(this.cbLoadTable);
            this.gbProjectTest.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbProjectTest.Location = new System.Drawing.Point(756, 196);
            this.gbProjectTest.Name = "gbProjectTest";
            this.gbProjectTest.Size = new System.Drawing.Size(509, 356);
            this.gbProjectTest.TabIndex = 59;
            this.gbProjectTest.TabStop = false;
            this.gbProjectTest.Text = "测试项目";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.SystemColors.Control;
            this.label33.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label33.Location = new System.Drawing.Point(110, 52);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(151, 16);
            this.label33.TabIndex = 100;
            this.label33.Text = "(先选择项目，再check刷新配置)";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.SystemColors.Control;
            this.label32.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(16, 47);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(68, 20);
            this.label32.TabIndex = 99;
            this.label32.Text = "刷新配置:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.SystemColors.Control;
            this.label31.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(16, 26);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(68, 20);
            this.label31.TabIndex = 90;
            this.label31.Text = "项目选择:";
            // 
            // cmbProjectSel
            // 
            this.cmbProjectSel.BackColor = System.Drawing.SystemColors.Control;
            this.cmbProjectSel.FormattingEnabled = true;
            this.cmbProjectSel.Items.AddRange(new object[] {
            "P1040",
            "P3268"});
            this.cmbProjectSel.Location = new System.Drawing.Point(92, 25);
            this.cmbProjectSel.Name = "cmbProjectSel";
            this.cmbProjectSel.Size = new System.Drawing.Size(164, 25);
            this.cmbProjectSel.TabIndex = 98;
            this.cmbProjectSel.Text = "下拉框选择：项目";
            // 
            // SerialPortCommunicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 655);
            this.Controls.Add(this.gbProjectTest);
            this.Controls.Add(this.rtbLogPrint);
            this.Controls.Add(this.btnStopEn);
            this.Controls.Add(this.tbChipID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbTestMessage);
            this.Controls.Add(this.gbChipSelSet);
            this.Controls.Add(this.btnSendStart);
            this.Controls.Add(this.palSerialPortStatusArea);
            this.Controls.Add(this.palSendArea);
            this.Controls.Add(this.palSendSetArea);
            this.Controls.Add(this.palReceiveSetArea);
            this.Controls.Add(this.palReciveArea);
            this.Controls.Add(this.palPortSetArea);
            this.Name = "SerialPortCommunicationForm";
            this.Text = "SerialPortCommunication";
            this.palPortSetArea.ResumeLayout(false);
            this.gbSerialPortSet.ResumeLayout(false);
            this.gbSerialPortSet.PerformLayout();
            this.palReciveArea.ResumeLayout(false);
            this.palReceiveSetArea.ResumeLayout(false);
            this.gbReceiveSet.ResumeLayout(false);
            this.gbReceiveSet.PerformLayout();
            this.palSendSetArea.ResumeLayout(false);
            this.gbSendSet.ResumeLayout(false);
            this.gbSendSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeInterval)).EndInit();
            this.palSendArea.ResumeLayout(false);
            this.palSerialPortStatusArea.ResumeLayout(false);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbChipSelSet.ResumeLayout(false);
            this.gbChipSelSet.PerformLayout();
            this.tpTestConfig.ResumeLayout(false);
            this.tbpP1040Test.ResumeLayout(false);
            this.tbpP1040Test.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChipCnt_1040)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGccTrim_1040)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOscTrim_1040)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLdoCfg_1040)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVbgCfg_1040)).EndInit();
            this.tbp3268Test.ResumeLayout(false);
            this.tbp3268Test.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTestCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReadInstDelay)).EndInit();
            this.gbProjectTest.ResumeLayout(false);
            this.gbProjectTest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel palPortSetArea;
        private System.Windows.Forms.Panel palReciveArea;
        private System.Windows.Forms.Panel palReceiveSetArea;
        private System.Windows.Forms.Panel palSendSetArea;
        private System.Windows.Forms.Panel palSendArea;
        private System.Windows.Forms.Panel palSerialPortStatusArea;
        private System.Windows.Forms.ComboBox cmbStopBitSet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbVerifyBitSet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDataWidthSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBaudRateSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSerialPortOnOff;
        private System.Windows.Forms.ComboBox cmbComPortSel;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.GroupBox gbSerialPortSet;
        private System.Windows.Forms.Button btnSendStart;
        private System.Windows.Forms.Button btnClearReceive;
        private System.Windows.Forms.RadioButton rbReceiveAscii;
        private System.Windows.Forms.GroupBox gbReceiveSet;
        private System.Windows.Forms.RadioButton rbReceiveHex;
        private System.Windows.Forms.CheckBox cbReceiveTimeDisplay;
        private System.Windows.Forms.GroupBox gbSendSet;
        private System.Windows.Forms.CheckBox cbSendNewLine;
        private System.Windows.Forms.RadioButton rbSendHex;
        private System.Windows.Forms.RadioButton rbSendAscii;
        private System.Windows.Forms.NumericUpDown nudTimeInterval;
        private System.Windows.Forms.CheckBox cbAutoSend;
        private System.Windows.Forms.Label lbSpState;
        private System.Windows.Forms.RichTextBox rtbReceive;
        private System.Windows.Forms.RichTextBox rtbSend;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.Label lbSendByte;
        private System.Windows.Forms.Label lbReceiveByte;
        private System.Windows.Forms.Label lbRxCnt;
        private System.Windows.Forms.Label lbTxCnt;
        private System.Windows.Forms.TabControl tpTestConfig;
        private System.Windows.Forms.Button btnLinkSel;
        private System.Windows.Forms.ComboBox cmbInstrumentMulti0;
        private System.Windows.Forms.ComboBox cmbInstrumentPower;
        private System.Windows.Forms.CheckBox cbEnMulti0;
        private System.Windows.Forms.CheckBox cbEnPower;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPowerAddr;
        private System.Windows.Forms.Button btnReleaseSel;
        private System.Windows.Forms.RadioButton rbPwrItechEn;
        private System.Windows.Forms.RadioButton rbPwrGppEn;
        private System.Windows.Forms.RadioButton rbPwrKeyEn;
        private System.Windows.Forms.GroupBox gbChipSelSet;
        private System.Windows.Forms.RichTextBox rtbLogPrint;
        private System.Windows.Forms.ComboBox cmbInstrumentMulti1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbEnMulti1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTestMessage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbChipID;
        private System.Windows.Forms.TabPage tbpP1040Test;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown nudVbgCfg_1040;
        private System.Windows.Forms.Button btnP1040RegCfg;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbP1040RegAddr;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbP1040RegValue;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmbCmdType;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cmbAtbSel_1040;
        private System.Windows.Forms.CheckBox cbLoadTable;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown nudLdoCfg_1040;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbFastCmd_1040;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbOscDivCmd_1040;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudOscTrim_1040;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudGccTrim_1040;
        private System.Windows.Forms.CheckBox cbOscTrimEn;
        private System.Windows.Forms.CheckBox cbGccTrimEn;
        private System.Windows.Forms.CheckBox cbLdoTrimEn;
        private System.Windows.Forms.CheckBox cbVbgTrimEn;
        private System.Windows.Forms.Button btnOneKeyLed;
        private System.Windows.Forms.CheckBox cbChipCnt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudChipCnt_1040;
        private System.Windows.Forms.Button btnRunTest_1040;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbAutoTestItem_1040;
        private System.Windows.Forms.Button btnStopEn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudReadInstDelay;
        private System.Windows.Forms.CheckBox cbCh4En;
        private System.Windows.Forms.CheckBox cbCh3En;
        private System.Windows.Forms.CheckBox cbCh2En;
        private System.Windows.Forms.CheckBox cbCh1En;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudTestCnt;
        private System.Windows.Forms.TabPage tbp3268Test;
        private System.Windows.Forms.GroupBox gbProjectTest;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cmbMonitor_3268;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.ComboBox cmbFastCmd_3268;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cmbAtbSel_3268;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox cmbProjectSel;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label34;
    }
}