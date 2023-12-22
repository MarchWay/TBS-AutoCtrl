
namespace AutoCtrl.CommonForm {
    partial class RandomDataForm {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomDataForm));
            this.btnRandom = new System.Windows.Forms.Button();
            this.rtbRandom = new System.Windows.Forms.RichTextBox();
            this.lbCtn = new System.Windows.Forms.Label();
            this.nudStartNum = new System.Windows.Forms.NumericUpDown();
            this.nudStopNum = new System.Windows.Forms.NumericUpDown();
            this.nudAverGroup = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAverGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRandom.Location = new System.Drawing.Point(564, 22);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(165, 53);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Random Run";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // rtbRandom
            // 
            this.rtbRandom.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbRandom.Location = new System.Drawing.Point(14, 89);
            this.rtbRandom.Name = "rtbRandom";
            this.rtbRandom.Size = new System.Drawing.Size(715, 379);
            this.rtbRandom.TabIndex = 3;
            this.rtbRandom.Text = "";
            // 
            // lbCtn
            // 
            this.lbCtn.AutoSize = true;
            this.lbCtn.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCtn.Location = new System.Drawing.Point(81, 66);
            this.lbCtn.Name = "lbCtn";
            this.lbCtn.Size = new System.Drawing.Size(59, 12);
            this.lbCtn.TabIndex = 4;
            this.lbCtn.Text = "GroupCnt:";
            // 
            // nudStartNum
            // 
            this.nudStartNum.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudStartNum.Location = new System.Drawing.Point(60, 17);
            this.nudStartNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStartNum.Name = "nudStartNum";
            this.nudStartNum.Size = new System.Drawing.Size(59, 21);
            this.nudStartNum.TabIndex = 5;
            this.nudStartNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudStopNum
            // 
            this.nudStopNum.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudStopNum.Location = new System.Drawing.Point(145, 17);
            this.nudStopNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStopNum.Name = "nudStopNum";
            this.nudStopNum.Size = new System.Drawing.Size(59, 21);
            this.nudStopNum.TabIndex = 6;
            this.nudStopNum.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudAverGroup
            // 
            this.nudAverGroup.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudAverGroup.Location = new System.Drawing.Point(145, 62);
            this.nudAverGroup.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAverGroup.Name = "nudAverGroup";
            this.nudAverGroup.Size = new System.Drawing.Size(59, 21);
            this.nudAverGroup.TabIndex = 7;
            this.nudAverGroup.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Range:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(210, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "Please Input Random Range!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(210, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "Please Input Random Group Count!";
            // 
            // RandomData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 480);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudAverGroup);
            this.Controls.Add(this.nudStopNum);
            this.Controls.Add(this.nudStartNum);
            this.Controls.Add(this.lbCtn);
            this.Controls.Add(this.rtbRandom);
            this.Controls.Add(this.btnRandom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RandomData";
            this.Text = "RandomData";
            ((System.ComponentModel.ISupportInitialize)(this.nudStartNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAverGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.RichTextBox rtbRandom;
        private System.Windows.Forms.Label lbCtn;
        private System.Windows.Forms.NumericUpDown nudStartNum;
        private System.Windows.Forms.NumericUpDown nudStopNum;
        private System.Windows.Forms.NumericUpDown nudAverGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

