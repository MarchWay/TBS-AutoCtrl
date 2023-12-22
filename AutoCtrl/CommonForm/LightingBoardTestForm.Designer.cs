
namespace AutoCtrl.CommonForm {
    partial class LightingBoardTestForm {
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
            this.gbBackColorTest = new System.Windows.Forms.GroupBox();
            this.btnRunBackColor = new System.Windows.Forms.Button();
            this.btnStopBackColor = new System.Windows.Forms.Button();
            this.nudLoopCntBackColor = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbStateCnt = new System.Windows.Forms.Label();
            this.nudIntervalTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoopCntBackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalTime)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBackColorTest
            // 
            this.gbBackColorTest.BackColor = System.Drawing.Color.White;
            this.gbBackColorTest.Location = new System.Drawing.Point(79, 42);
            this.gbBackColorTest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBackColorTest.Name = "gbBackColorTest";
            this.gbBackColorTest.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBackColorTest.Size = new System.Drawing.Size(800, 800);
            this.gbBackColorTest.TabIndex = 0;
            this.gbBackColorTest.TabStop = false;
            // 
            // btnRunBackColor
            // 
            this.btnRunBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRunBackColor.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRunBackColor.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRunBackColor.Location = new System.Drawing.Point(914, 138);
            this.btnRunBackColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRunBackColor.Name = "btnRunBackColor";
            this.btnRunBackColor.Size = new System.Drawing.Size(182, 57);
            this.btnRunBackColor.TabIndex = 1;
            this.btnRunBackColor.Text = "RUN";
            this.btnRunBackColor.UseVisualStyleBackColor = false;
            this.btnRunBackColor.Click += new System.EventHandler(this.btnRunBackColor_Click);
            // 
            // btnStopBackColor
            // 
            this.btnStopBackColor.BackColor = System.Drawing.Color.Silver;
            this.btnStopBackColor.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStopBackColor.ForeColor = System.Drawing.Color.Red;
            this.btnStopBackColor.Location = new System.Drawing.Point(1026, 205);
            this.btnStopBackColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStopBackColor.Name = "btnStopBackColor";
            this.btnStopBackColor.Size = new System.Drawing.Size(59, 38);
            this.btnStopBackColor.TabIndex = 2;
            this.btnStopBackColor.Text = "STOP";
            this.btnStopBackColor.UseVisualStyleBackColor = false;
            this.btnStopBackColor.Click += new System.EventHandler(this.btnStopBackColor_Click);
            // 
            // nudLoopCntBackColor
            // 
            this.nudLoopCntBackColor.Location = new System.Drawing.Point(995, 75);
            this.nudLoopCntBackColor.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudLoopCntBackColor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLoopCntBackColor.Name = "nudLoopCntBackColor";
            this.nudLoopCntBackColor.Size = new System.Drawing.Size(67, 26);
            this.nudLoopCntBackColor.TabIndex = 3;
            this.nudLoopCntBackColor.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(910, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "循环总数：";
            // 
            // lbStateCnt
            // 
            this.lbStateCnt.AutoSize = true;
            this.lbStateCnt.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbStateCnt.ForeColor = System.Drawing.Color.Blue;
            this.lbStateCnt.Location = new System.Drawing.Point(934, 318);
            this.lbStateCnt.Name = "lbStateCnt";
            this.lbStateCnt.Size = new System.Drawing.Size(104, 27);
            this.lbStateCnt.TabIndex = 5;
            this.lbStateCnt.Text = "Not Start";
            // 
            // nudIntervalTime
            // 
            this.nudIntervalTime.Location = new System.Drawing.Point(995, 107);
            this.nudIntervalTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudIntervalTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIntervalTime.Name = "nudIntervalTime";
            this.nudIntervalTime.Size = new System.Drawing.Size(67, 26);
            this.nudIntervalTime.TabIndex = 6;
            this.nudIntervalTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(910, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "切换间隔：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1064, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "ms";
            // 
            // LightingBoardTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 878);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudIntervalTime);
            this.Controls.Add(this.lbStateCnt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudLoopCntBackColor);
            this.Controls.Add(this.btnStopBackColor);
            this.Controls.Add(this.btnRunBackColor);
            this.Controls.Add(this.gbBackColorTest);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LightingBoardTest";
            this.Text = "LightingBoardTest";
            ((System.ComponentModel.ISupportInitialize)(this.nudLoopCntBackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBackColorTest;
        private System.Windows.Forms.Button btnRunBackColor;
        private System.Windows.Forms.Button btnStopBackColor;
        private System.Windows.Forms.NumericUpDown nudLoopCntBackColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbStateCnt;
        private System.Windows.Forms.NumericUpDown nudIntervalTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}