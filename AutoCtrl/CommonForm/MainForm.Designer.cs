
namespace AutoCtrl.CommonForm {
    partial class MainForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnRandomData = new System.Windows.Forms.Button();
            this.btnInstrumentLink = new System.Windows.Forms.Button();
            this.btnSerialPortCom = new System.Windows.Forms.Button();
            this.btnTestCommonForm = new System.Windows.Forms.Button();
            this.btnLightBackTest = new System.Windows.Forms.Button();
            this.btnUsbPort = new System.Windows.Forms.Button();
            this.btnTconPort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRandomData
            // 
            this.btnRandomData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRandomData.Location = new System.Drawing.Point(14, 13);
            this.btnRandomData.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRandomData.Name = "btnRandomData";
            this.btnRandomData.Size = new System.Drawing.Size(147, 65);
            this.btnRandomData.TabIndex = 0;
            this.btnRandomData.Text = "RandomData";
            this.btnRandomData.UseVisualStyleBackColor = false;
            this.btnRandomData.Click += new System.EventHandler(this.btnRandomData_Click);
            // 
            // btnInstrumentLink
            // 
            this.btnInstrumentLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnInstrumentLink.Location = new System.Drawing.Point(188, 13);
            this.btnInstrumentLink.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnInstrumentLink.Name = "btnInstrumentLink";
            this.btnInstrumentLink.Size = new System.Drawing.Size(147, 65);
            this.btnInstrumentLink.TabIndex = 1;
            this.btnInstrumentLink.Text = "Instrument Link";
            this.btnInstrumentLink.UseVisualStyleBackColor = false;
            this.btnInstrumentLink.Click += new System.EventHandler(this.btnInstrumentLink_Click);
            // 
            // btnSerialPortCom
            // 
            this.btnSerialPortCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSerialPortCom.Location = new System.Drawing.Point(14, 103);
            this.btnSerialPortCom.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSerialPortCom.Name = "btnSerialPortCom";
            this.btnSerialPortCom.Size = new System.Drawing.Size(147, 65);
            this.btnSerialPortCom.TabIndex = 2;
            this.btnSerialPortCom.Text = "--MCU串口-- 测试自动化";
            this.btnSerialPortCom.UseVisualStyleBackColor = false;
            this.btnSerialPortCom.Click += new System.EventHandler(this.btnSerialPortCom_Click);
            // 
            // btnTestCommonForm
            // 
            this.btnTestCommonForm.BackColor = System.Drawing.SystemColors.Control;
            this.btnTestCommonForm.Enabled = false;
            this.btnTestCommonForm.Location = new System.Drawing.Point(366, 13);
            this.btnTestCommonForm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTestCommonForm.Name = "btnTestCommonForm";
            this.btnTestCommonForm.Size = new System.Drawing.Size(147, 65);
            this.btnTestCommonForm.TabIndex = 3;
            this.btnTestCommonForm.Text = "Test Common Form";
            this.btnTestCommonForm.UseVisualStyleBackColor = false;
            this.btnTestCommonForm.Click += new System.EventHandler(this.btnTestCommonForm_Click);
            // 
            // btnLightBackTest
            // 
            this.btnLightBackTest.BackColor = System.Drawing.Color.Silver;
            this.btnLightBackTest.Enabled = false;
            this.btnLightBackTest.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLightBackTest.ForeColor = System.Drawing.Color.Blue;
            this.btnLightBackTest.Location = new System.Drawing.Point(14, 189);
            this.btnLightBackTest.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnLightBackTest.Name = "btnLightBackTest";
            this.btnLightBackTest.Size = new System.Drawing.Size(147, 65);
            this.btnLightBackTest.TabIndex = 4;
            this.btnLightBackTest.Text = "-高亮-全黑- 切换测试";
            this.btnLightBackTest.UseVisualStyleBackColor = false;
            this.btnLightBackTest.Click += new System.EventHandler(this.btnLightBackTest_Click);
            // 
            // btnUsbPort
            // 
            this.btnUsbPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUsbPort.Location = new System.Drawing.Point(188, 103);
            this.btnUsbPort.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnUsbPort.Name = "btnUsbPort";
            this.btnUsbPort.Size = new System.Drawing.Size(147, 65);
            this.btnUsbPort.TabIndex = 5;
            this.btnUsbPort.Text = "--USB接口-- 测试自动化";
            this.btnUsbPort.UseVisualStyleBackColor = false;
            this.btnUsbPort.Click += new System.EventHandler(this.btnUsbPort_Click);
            // 
            // btnTconPort
            // 
            this.btnTconPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTconPort.Location = new System.Drawing.Point(366, 103);
            this.btnTconPort.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTconPort.Name = "btnTconPort";
            this.btnTconPort.Size = new System.Drawing.Size(147, 65);
            this.btnTconPort.TabIndex = 6;
            this.btnTconPort.Text = "--UART接口-- 测试自动化";
            this.btnTconPort.UseVisualStyleBackColor = false;
            this.btnTconPort.Click += new System.EventHandler(this.btnTconPort_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 407);
            this.Controls.Add(this.btnTconPort);
            this.Controls.Add(this.btnUsbPort);
            this.Controls.Add(this.btnLightBackTest);
            this.Controls.Add(this.btnTestCommonForm);
            this.Controls.Add(this.btnSerialPortCom);
            this.Controls.Add(this.btnInstrumentLink);
            this.Controls.Add(this.btnRandomData);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRandomData;
        private System.Windows.Forms.Button btnInstrumentLink;
        private System.Windows.Forms.Button btnSerialPortCom;
        private System.Windows.Forms.Button btnTestCommonForm;
        private System.Windows.Forms.Button btnLightBackTest;
        private System.Windows.Forms.Button btnUsbPort;
        private System.Windows.Forms.Button btnTconPort;
    }
}