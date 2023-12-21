using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ivi.Visa;
using NationalInstruments.Visa;
using System.Windows.Forms;


namespace AutoCtrl.InstCommonCtrl {
    public class InstCommonCtrlLib {
        public enum ERROR_EN {
            //Common Message
            INST_LINK_FAIL,
            INST_INIT_FAIL,
            INST_OUTPUT_FAIL,
            INST_CTRL_MODE_FAIL,
            WAIT_OPC_NO_ACK,
            READ_DATA_FAIL,
            //Power Message
            SET_POWER_FAIL,
            SET_OCP_FAIL,
            SET_OVP_FAIL,
            SET_SLEW_RATE_FAIL,
            SET_OVP_LEVEL_FAIL,
            SET_TRACE_MODE_FAIL,
            SET_OUT_COUPLE_FAIL,
            SET_PANEL_LOCK_FAIL,
            SET_ON_OFF_DELAY_FAIL,
            SET_OUT_LINK_MODE_FAIL,
            SET_DELAY_MODE_OCP_FAIL,
            SET_DELAY_TIME_OCP_FAIL,
            CLEAR_PROTECT_FAIL,
            RECOVER_MAX_SLEW_RATE_FAIL,
            //Multi Message
            SET_MEASURE_MODE_FAIL,
            SET_NPLC_FAIL,
            SET_HIGH_Z_FAIL,
        }
        public struct Inst_ST {
            public string addrPower;
            public string addrMulti;         //万用表
            public string addrOscilloscope;  //示波器
            public string errorMessage;
        }
        public Inst_ST inst_st;
        public MessageBasedSession mbSession, mbsPower, mbsPower0, mbsPower1, mbsCommonInst, mbsMulti, mbsMulti0, mbsMulti1, mbsPowerKey, mbsPowerItech, mbsPowerGuwei;
        public bool InstrumentLink(ref MessageBasedSession mbs, string instAddr) {
            bool flag = true;
            try {
                var rmSession = new ResourceManager();
                mbs = (MessageBasedSession)rmSession.Open(instAddr);
            }
            catch {
                flag = false;
                inst_st.errorMessage = ERROR_EN.INST_LINK_FAIL.ToString();
            }
            return flag;
        }

        public string Query(MessageBasedSession mbs, string command) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                mbs.RawIO.Write(command);
                return mbs.RawIO.ReadString();
            }
            catch (Exception exp) {
                return exp.Message;
            }
            finally {
                Cursor.Current = Cursors.Default;
            }
        }
        public bool Write(MessageBasedSession mbs, string command) {
            bool isOk = true;
            try {
                mbs.RawIO.Write(command);
            }
            catch (Exception exp) {
                isOk &= false;
                inst_st.errorMessage = exp.Message;
            }
            return isOk;
        }

        public bool WaitOpc(MessageBasedSession mbs) {
            string read = "0";
            int cnt = 0;
            try {
                do {
                    mbs.RawIO.Write("*OPC?\n");
                    System.Threading.Thread.Sleep(1);
                    read = mbs.RawIO.ReadString().Replace("\n", "");
                    cnt++;
                } while (1 == double.Parse(read) && cnt > 2);
                return true;
            }
            catch {
                inst_st.errorMessage = ERROR_EN.WAIT_OPC_NO_ACK.ToString();
                return false;
            }
        }
    }
}
