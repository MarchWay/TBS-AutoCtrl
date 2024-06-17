using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoCtrl.CommonFunction;
using NationalInstruments.Visa;
using AutoCtrl.InstCommonCtrl;
using AutoCtrl.InstCommandCtrl;
using System.Threading.Tasks;
using AutoCtrl.CommunicationProtocol;

namespace AutoCtrl.TBSiliconProject.MCU_Ctrl {
    public class DriveChCurrVoltTestLib {
        public struct CHN_PARA_ST {
            public RichTextBox rtblog;
            public RadioButton rbKeyPwrEn;
            public RadioButton rbGppPwrEn;
            public RadioButton rbItechPwrEn;
            public CheckBox cbPowerEn;
            public CheckBox cbMulti0En;
            public CheckBox cbMulti1En;
            public double data;
            public bool stop;
        }
        public CHN_PARA_ST chn_para_st = new CHN_PARA_ST();
        public CommonFunctionLib comFunLib = new CommonFunctionLib();
        public InstCommandLib instCmdLib = new InstCommandLib();
        public InstCommonCtrlLib instCtrlLib = new InstCommonCtrlLib();
        public List<string> dataList = new List<string>();

        public void ChEnable(SerialPortLib serPortLib, int CH) {
            string dataStream = "AA 55 " + CH.ToString("X2") + " 55 AA";
            serPortLib.SerialPort_DataSend(dataStream);
        }
        public void ChDisable(SerialPortLib serPortLib) {
            string dataStream = "AA 55 FF 55 AA";
            serPortLib.SerialPort_DataSend(dataStream);
        }
        public void chCurrTest(SerialPortLib serPortLib, MessageBasedSession mbs, CommonFunctionLib comFunLib, RichTextBox rtbLog, CheckBox cbCheck, int delay) {
            for (int CHN = 0; CHN < 48; CHN++) {
                if (chn_para_st.stop) break;
                ChEnable(serPortLib, CHN);
                comFunLib.DelayTimeMs(delay);
                if (cbCheck.Checked) {
                    instCmdLib.ReadMulti(mbs, ref chn_para_st.data);
                }
                dataList.Add("CH" + CHN);
                dataList.Add(chn_para_st.data.ToString("F3"));
                dataList.Add(instCmdLib.var_st.dataUnit);
                comFunLib.WriteDataToTxt(dataList);
                dataList.Clear();
                rtbLog.AppendText("CH" + CHN + " " + chn_para_st.data + " " + instCmdLib.var_st.dataUnit + "\n");
                rtbLog.ScrollToCaret();
            }
            ChDisable(serPortLib);
        }
    }
}
