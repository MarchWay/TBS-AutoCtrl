
namespace AutoCtrl.CommonForm {
    partial class TestItemCommonForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestItemCommonForm));
            this.rtbLoadExcel = new System.Windows.Forms.RichTextBox();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnLoadExcel = new System.Windows.Forms.Button();
            this.nudSheetNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudRegColIndex = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRegName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudRegValue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfigReg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSheetNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegColIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegValue)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbLoadExcel
            // 
            this.rtbLoadExcel.Location = new System.Drawing.Point(145, 217);
            this.rtbLoadExcel.Name = "rtbLoadExcel";
            this.rtbLoadExcel.Size = new System.Drawing.Size(650, 389);
            this.rtbLoadExcel.TabIndex = 0;
            this.rtbLoadExcel.Text = "";
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(233, 40);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(650, 21);
            this.tbFilePath.TabIndex = 1;
            this.tbFilePath.Text = "E:\\mazewei\\LearningFile\\VS_Project\\ChipAutoCtrl\\AutoCtrl\\bin\\Debug\\Source\\Registe" +
    "r\\Register_Table.xlsx";
            // 
            // btnLoadExcel
            // 
            this.btnLoadExcel.Location = new System.Drawing.Point(41, 38);
            this.btnLoadExcel.Name = "btnLoadExcel";
            this.btnLoadExcel.Size = new System.Drawing.Size(75, 58);
            this.btnLoadExcel.TabIndex = 2;
            this.btnLoadExcel.Text = "Load";
            this.btnLoadExcel.UseVisualStyleBackColor = true;
            this.btnLoadExcel.Click += new System.EventHandler(this.btnLoadExcel_Click);
            // 
            // nudSheetNum
            // 
            this.nudSheetNum.Location = new System.Drawing.Point(233, 82);
            this.nudSheetNum.Name = "nudSheetNum";
            this.nudSheetNum.Size = new System.Drawing.Size(71, 21);
            this.nudSheetNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "sheetNum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "FilePath:";
            // 
            // nudRegColIndex
            // 
            this.nudRegColIndex.Location = new System.Drawing.Point(233, 109);
            this.nudRegColIndex.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudRegColIndex.Name = "nudRegColIndex";
            this.nudRegColIndex.Size = new System.Drawing.Size(71, 21);
            this.nudRegColIndex.TabIndex = 6;
            this.nudRegColIndex.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "sheetNum:";
            // 
            // tbRegName
            // 
            this.tbRegName.Location = new System.Drawing.Point(468, 108);
            this.tbRegName.Name = "tbRegName";
            this.tbRegName.Size = new System.Drawing.Size(207, 21);
            this.tbRegName.TabIndex = 8;
            this.tbRegName.Text = "REG_DELAY_CTRL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "regName:";
            // 
            // nudRegValue
            // 
            this.nudRegValue.Location = new System.Drawing.Point(468, 146);
            this.nudRegValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudRegValue.Name = "nudRegValue";
            this.nudRegValue.Size = new System.Drawing.Size(71, 21);
            this.nudRegValue.TabIndex = 10;
            this.nudRegValue.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "regCfg:";
            // 
            // btnConfigReg
            // 
            this.btnConfigReg.Location = new System.Drawing.Point(720, 108);
            this.btnConfigReg.Name = "btnConfigReg";
            this.btnConfigReg.Size = new System.Drawing.Size(75, 58);
            this.btnConfigReg.TabIndex = 12;
            this.btnConfigReg.Text = "SetReg";
            this.btnConfigReg.UseVisualStyleBackColor = true;
            this.btnConfigReg.Click += new System.EventHandler(this.btnConfigReg_Click);
            // 
            // TestItemCommonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 627);
            this.Controls.Add(this.btnConfigReg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudRegValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbRegName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudRegColIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudSheetNum);
            this.Controls.Add(this.btnLoadExcel);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.rtbLoadExcel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestItemCommonForm";
            this.Text = "TestItemCommonForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudSheetNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegColIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbLoadExcel;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnLoadExcel;
        private System.Windows.Forms.NumericUpDown nudSheetNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudRegColIndex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRegName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudRegValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfigReg;
    }
}