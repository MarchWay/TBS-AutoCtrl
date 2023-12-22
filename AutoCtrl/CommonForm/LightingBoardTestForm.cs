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

namespace AutoCtrl.CommonForm {
    public partial class LightingBoardTestForm : Form {
        public LightingBoardTestForm() {
            InitializeComponent();
        }
        public CommonFunctionLib comFunLib = new CommonFunctionLib();
        public bool stop = false;
        public int loop = 1;
        public int delay = 0;
        private void InitPara() {
            stop = false;
            loop = (int)nudLoopCntBackColor.Value;
            lbStateCnt.Text = "Not Start";
            delay = (int)nudIntervalTime.Value;
        }

        private void btnRunBackColor_Click(object sender, EventArgs e) {
            InitPara();
            int cnt = 1;
            do {
                gbBackColorTest.BackColor = Color.Black;
                comFunLib.DelayTimeMs(delay);
                gbBackColorTest.BackColor = Color.White;
                comFunLib.DelayTimeMs(delay);
                lbStateCnt.Text = "LOOP: " + cnt;
                cnt++;
            } while (cnt < loop && !stop);
        }

        private void btnStopBackColor_Click(object sender, EventArgs e) {
            stop = true;
        }
    }
}
