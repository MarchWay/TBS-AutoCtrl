using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ivi.Visa;
using NationalInstruments.Visa;
using System.Windows.Forms;
using AutoCtrl.InstCommonCtrl;

namespace AutoCtrl.InstCommandCtrl {
    public class InstCommandLib {

        public InstCommonCtrlLib instCmnlLib = new InstCommonCtrlLib();

        #region 1. Common 枚举
        public enum POWER_TYPE_EN {
            E36234A,
            ITECH6333A
        }
        public enum MULTI_TYPE_EN {
            E34465A,
            E34XXXA
        }
        public enum POWER_CH_EN {
            CH1 = 1,
            CH2,
            CH3,
            CH4
        }
        public enum SIGNAL_SOURCE_CH_EN {
            C1,
            C2
        }
        public enum SIGNAL_SOURCE_CH_LOAD {
            R50,
            HZ
        }
        public enum SIGNAL_SOURCE_CH_WAVE {
            SINE = 0,     //正弦/方波/三角波/伪随机码/脉冲/
            SQUARE,
            RAMP,
            PRBS,
            PULSE,
            ARB,
            DC
        }
        public enum REMOTE_INTERFACE {
            LAN = 1,
            USB,
            GPIB,
            RS232
        }
        public enum POWER_CTRL_EN {
            POWER_INITIAL,
            POWER_OUTPUT_CH_CTRL,
            POWER_ALL_OUTPUT,
            READ_KEY_POWER_DATA,
            READ_ITECH_POWER_ALL,
            READ_ITECH_POWER_CH,
            ITECH_POWER_REMOTE_EN,
            SET_INIT_VOLT_LIMIT_CURR,
            SET_ITECH_POWER_VOLT,
            SET_ITECH_POWER_CURR,
            SET_SLEW_RATE,
            SET_LEVEL_OVP,
            SET_DELAY_TIME_OCP,
            SET_DELAY_MODE_OCP,
            SET_TRACING_MODE,
            OUTPUT_LINK_MODE,
            OUTPUT_COUPLING,
            OUTPUT_ON_OFF_DELAY,
            RECOVER_MAX_SLEW_RATE,
            LOCK_PANEL_MODE,
            CLEAR_PROTECT,
            ENABLE_OCP,      //over current protection
            ENABLE_OVP       //over voltage protection
        }
        public enum MULTI_CTRL_EN {
            MULTI_INITIAL,
            READ_DATA,
            SET_NPLC,             //设置响应时间，经典值 0.02
            SET_HIGH_Z,           //设置高阻模式，测量电压
            SET_MEAS_MODE,        //设置测量模式电压、电流、直流、交流
            SET_AUTO_ZERO_MEAS    //设置自动调零测量
        }
        public enum READ_TYPE_EN {
            CURR,
            VOLT,
            POWE
        }
        public enum STATE_EN {
            ON,
            OFF
        }
        public enum INST_CTRL_MODE {
            REMote,
            LOCal
        }
        #endregion

        #region 2. POWER E36234 枚举
        public enum SLEW_RATE_EN {
            RIS,            //输出上升沿速率
            FALL,           //关闭下降沿速率
        }
        public enum DELAY_EN {
            RISE,           //输出开启延时
            FALL,           //输出关闭延时
            OFF
        }
        public enum OUTPUT_LINK_EN {
            INDEPEND,       //CH1,CH2独立输出， 各60V/10A
            SERies,         //CH1,CH2串联输出， (CH1+  CH2-)120V/10A
            PARallel,       //CH1,CH2并联输出， 输出端口CH1 60V/20A
            TRACKING        //CH1,CH2独立输出,  仅volt设置全局化
        }
        public enum LOCK_PANEL_EN {
            RWL,            //锁定所有的前面板按键，包括Lock|Unlock 键
            REM,            //锁定除Lock|Unlock 键之外的所有前面板按键
            LOC,            //解锁前面板
            LOCAL           //返回到本地状,也可以用作解锁
        }
        public enum OCP_DELAY_MODE {
            SET,            //输出1 的过电流保护延迟计时器启动条件设为更改设置，Setting Change 为 default 值
            CCTR            //输出1 的过电流保护延迟计时器启动条件设为CC转换，启用OCP后，如果输出电流达到电流限制设置，CV模式会转换为CC模式，因此，电源将禁用输
        }
        #endregion

        #region 3. MULTI E34465A 枚举
        public enum MEASURE_MODE_EN {
            DC,
            AC
        }
        #endregion

        #region 4. Struct AND ParaInit
        public struct Var_ST {
            public string chIndex;
            //KeySight Power E36234
            public double setVolt;
            public double limitCurr;
            public double readCurr;
            public double readData;
            public double levelOVP;
            public double delayOCP;
            public double slewRateRatio;   //上升速率 V/S 默认启用最大值 9.9E37
            public double onDelay;
            public double offDelay;
            public double nplc;
            public bool outCoupleAll;
            //GuWei Power GPP-4323
            public double[,] voltCurr;
            public double[] readGuWeiData;
            //Ietch Power I6333A
            public double[] setItechVolt;
            public double[] setItechCurr;
            public double[] readIetchData;
            //KeySight Multi 34465A
            public string dataUnit;
            //Common enum
            public STATE_EN state;
            public DELAY_EN delay;
            public POWER_CH_EN power_ch;
            public SLEW_RATE_EN slewRateMode;
            public READ_TYPE_EN readType;
            public LOCK_PANEL_EN panelLock;
            public INST_CTRL_MODE ctrlMode;
            public OCP_DELAY_MODE ocpDelayMode;
            public OUTPUT_LINK_EN outputLinkMode;
            public MEASURE_MODE_EN measureMode;
        }

        public Var_ST var_st = new Var_ST();

        public void InitPara() {
            var_st.chIndex = "(@" + (int)var_st.power_ch + ")";
            //KeySight Power E36234
            var_st.levelOVP = 66;     //单位V, 默认为最大值 
            var_st.delayOCP = 0.050;  //单位S，默认值为0.050
            var_st.slewRateRatio = 9.9e37;
            var_st.onDelay = 0;
            var_st.offDelay = 0;
            var_st.outCoupleAll = false;
            //Ietch Power I6333A
            var_st.setItechVolt = new double[3] { 0, 0, 0 };
            var_st.setItechCurr = new double[3] { 1, 1, 1 };
            var_st.readIetchData = new double[3] { 0, 0, 0 };
            var_st.voltCurr = new double[,] { { 3.300, 1.000 }, { 5.000, 1.000 }, { 5.000, 1.000 }, { 3.300, 1.000 } };
            //KeySight Multi 34465A
            var_st.nplc = 10;
            //Common enum
            var_st.state = STATE_EN.ON;
            var_st.delay = DELAY_EN.OFF;
            var_st.readType = READ_TYPE_EN.VOLT;
            var_st.power_ch = POWER_CH_EN.CH1;
            var_st.ctrlMode = INST_CTRL_MODE.REMote;
            var_st.slewRateMode = SLEW_RATE_EN.FALL;
            var_st.panelLock = LOCK_PANEL_EN.LOCAL;
            var_st.ocpDelayMode = OCP_DELAY_MODE.SET;
            var_st.outputLinkMode = OUTPUT_LINK_EN.INDEPEND;
            var_st.measureMode = MEASURE_MODE_EN.DC;
        }
        #endregion

        #region 5. KeySight Power E36234 Operation

        /// <summary>
        /// 电源控制总体函数
        /// </summary>
        /// <param name="powerCtrl"></param>
        /// <returns></returns>
        public bool PowerCtrl(POWER_CTRL_EN powerCtrl) {
            switch (powerCtrl) {
                case POWER_CTRL_EN.POWER_INITIAL:
                    return InstrumentInitial(instCmnlLib.mbsPowerKey);
                case POWER_CTRL_EN.POWER_OUTPUT_CH_CTRL:
                    return KeyPowerOutPutChEn(instCmnlLib.mbsPowerKey, var_st.power_ch, var_st.state);
                case POWER_CTRL_EN.POWER_ALL_OUTPUT:
                    return KeyPowerOutPutAllEn(instCmnlLib.mbsPowerKey, var_st.state);
                case POWER_CTRL_EN.READ_KEY_POWER_DATA:
                    return ReadKeyPower(instCmnlLib.mbsPowerKey, var_st.power_ch, var_st.readType, ref var_st.readData);
                case POWER_CTRL_EN.SET_INIT_VOLT_LIMIT_CURR:
                    return SetVoltAndCurr(instCmnlLib.mbsPowerKey, var_st.power_ch, var_st.setVolt, var_st.limitCurr);
                case POWER_CTRL_EN.SET_SLEW_RATE:
                    return SetVoltSlewRate(instCmnlLib.mbsPowerKey, var_st.power_ch, var_st.slewRateMode, var_st.slewRateRatio);
                case POWER_CTRL_EN.OUTPUT_COUPLING:
                    return SetOutputCouple(instCmnlLib.mbsPowerKey, var_st.outCoupleAll, var_st.power_ch);
                case POWER_CTRL_EN.OUTPUT_LINK_MODE:
                    return SetOutLinkMode(instCmnlLib.mbsPowerKey, var_st.outputLinkMode);
                case POWER_CTRL_EN.OUTPUT_ON_OFF_DELAY:
                    return SetOutputOnOffDelay(instCmnlLib.mbsPowerKey, var_st.power_ch, var_st.onDelay, var_st.offDelay);
                case POWER_CTRL_EN.SET_TRACING_MODE:
                    return SetTraceMode(instCmnlLib.mbsPowerKey, var_st.state);
                case POWER_CTRL_EN.CLEAR_PROTECT:
                    return ClearProtect(instCmnlLib.mbsPowerKey, var_st.power_ch);
                case POWER_CTRL_EN.RECOVER_MAX_SLEW_RATE:
                    return RecoverMaxSlewRate(instCmnlLib.mbsPowerKey, var_st.power_ch, var_st.slewRateMode);
                case POWER_CTRL_EN.ENABLE_OCP:
                    return SetEnOCP(instCmnlLib.mbsPowerKey, var_st.power_ch, var_st.state);
                case POWER_CTRL_EN.ENABLE_OVP:
                    return SetEnOVP(instCmnlLib.mbsPowerKey, var_st.power_ch, var_st.state);
                case POWER_CTRL_EN.SET_DELAY_MODE_OCP:
                    return SetDelayModeOCP(instCmnlLib.mbsPowerKey, var_st.power_ch, var_st.ocpDelayMode);
                case POWER_CTRL_EN.SET_DELAY_TIME_OCP:
                    return SetDelayTimeOCP(instCmnlLib.mbsPowerKey, var_st.power_ch, var_st.delayOCP);
                case POWER_CTRL_EN.SET_LEVEL_OVP:
                    return SetLevelOVP(instCmnlLib.mbsPowerKey, var_st.power_ch, var_st.levelOVP);
                case POWER_CTRL_EN.LOCK_PANEL_MODE:
                    return SetPanelLock(instCmnlLib.mbsPowerKey, var_st.panelLock);
                default:
                    break;
            }
            return true;
        }

        /// <summary>
        /// 仪器初始化, 清除原始设置
        /// </summary>
        /// <param name="mbs"></param>
        /// <returns></returns>
        public bool InstrumentInitial(MessageBasedSession mbs) {
            try {
                return instCmnlLib.Write(mbs, "*CLS\n")
                       & instCmnlLib.Write(mbs, "*RST\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.INST_INIT_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 控制电源通道输出使能 CHx:ON/OFF
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="ch"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public bool KeyPowerOutPutChEn(MessageBasedSession mbs, POWER_CH_EN power_ch, STATE_EN state) {
            try {
                return instCmnlLib.Write(mbs, "OUTP " + state + "," + Channel(power_ch) + "\n");
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.INST_OUTPUT_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 控制ALL CH 输出: ON/OFF
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public bool KeyPowerOutPutAllEn(MessageBasedSession mbs, STATE_EN state) {
            try {
                return instCmnlLib.Write(mbs, "OUTP " + state + ",(@1,2,3)" + "\n");
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.INST_OUTPUT_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 通道选择
        /// </summary>
        /// <param name="CH"></param>
        /// <returns></returns>
        public string Channel(POWER_CH_EN CH) {
            return "(@" + (int)CH + ")";
        }

        /// <summary>
        /// 读取电源电压和电流，电压默认为 mV，电流默认为 mA
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="power_ch"></param>
        /// <returns></returns>
        public bool ReadKeyPower(MessageBasedSession mbs, POWER_CH_EN power_ch, READ_TYPE_EN readType, ref double data) {
            try {
                data = double.Parse(instCmnlLib.Query(mbs, ":MEAS:" + readType + "? " + Channel(power_ch) + "\n").Replace("\n", "")); //注意：有一空格
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.READ_DATA_FAIL.ToString();
            }
            return true;
        }

        /// <summary>
        /// 根据不同的需求操作电源：注意输入单位为 V/A； 例如参数输入 1.666V/1.235A
        /// </summary>
        /// <param name="powerCtrl"></param>
        /// <param name="mbs"></param>
        /// <param name="power_ch"></param>
        /// <returns></returns>
        public bool SetVoltAndCurr(MessageBasedSession mbs, POWER_CH_EN power_ch, double volt, double curr = 1.000) {
            try {
                return instCmnlLib.Write(mbs, ":APPL " + power_ch + "," + volt + "," + curr + "\n");
                       //& instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.SET_POWER_FAIL.ToString();
                return false;
            }
        }

        /// <summary>
        /// 设置通道输出开启和关闭的速率 V/S
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="power_ch"></param>
        /// <param name="slewMode"></param>
        /// <param name="slewRate"></param>
        /// <returns></returns>
        public bool SetVoltSlewRate(MessageBasedSession mbs, POWER_CH_EN power_ch, SLEW_RATE_EN slewMode, double slewRate) {
            try {
                return instCmnlLib.Write(mbs, "VOLT:SLEW:" + slewMode + " " + slewRate + "," + Channel(power_ch) + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.SET_SLEW_RATE_FAIL.ToString();
                return false;
            }
        }

        /// <summary>
        /// 恢复通道的默认 SlewRate 为 MAX
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="power_ch"></param>
        /// <param name="slewMode"></param>
        /// <returns></returns>
        public bool RecoverMaxSlewRate(MessageBasedSession mbs, POWER_CH_EN power_ch, SLEW_RATE_EN slewMode) {
            try {
                return instCmnlLib.Write(mbs, "VOLT:SLEW:" + slewMode + " MAX," + Channel(power_ch) + "\n")   //默认启用最大Slew Rate
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.RECOVER_MAX_SLEW_RATE_FAIL.ToString();
                return false;
            }
        }

        /// <summary>
        /// 设置通道过流保护使能
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="power_ch"></param>
        /// <param name="enOCP"></param>
        /// <returns></returns>
        public bool SetEnOCP(MessageBasedSession mbs, POWER_CH_EN power_ch, STATE_EN state) {
            try {
                return instCmnlLib.Write(mbs, ":CURR:PROT:STAT " + state + Channel(power_ch) + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.SET_OCP_FAIL.ToString();
                return false;
            }
        }


        /// <summary>
        /// 设置通道过压保护使能
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="power_ch"></param>
        /// <param name="enOVP"></param>
        /// <returns></returns>
        public bool SetEnOVP(MessageBasedSession mbs, POWER_CH_EN power_ch, STATE_EN state) {
            try {
                return instCmnlLib.Write(mbs, ":VOLT:PROT:STAT " + state + Channel(power_ch) + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.SET_OVP_FAIL.ToString();
                return false;
            }
        }

        /// <summary>
        /// 设置通道过压保护阈值
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="power_ch"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        public bool SetLevelOVP(MessageBasedSession mbs, POWER_CH_EN power_ch, double level = 66) {
            try {
                return instCmnlLib.Write(mbs, ":VOLT:PROT " + level + "," + Channel(power_ch) + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.SET_OVP_LEVEL_FAIL.ToString();
                return false;
            }
        }

        /// <summary>
        /// 设置通道过流保护延时模式
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="power_ch"></param>
        /// <param name="delayMode"></param>
        /// <returns></returns>
        public bool SetDelayModeOCP(MessageBasedSession mbs, POWER_CH_EN power_ch, OCP_DELAY_MODE delayMode) {
            try {
                return instCmnlLib.Write(mbs, ":CURR:PROT:DEL:STAR " + delayMode + "," + Channel(power_ch) + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.SET_DELAY_MODE_OCP_FAIL.ToString();
                return false;
            }
        }

        /// <summary>
        /// 设置通道过流保护延时
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="power_ch"></param>
        /// <param name="delay"></param>
        /// <returns></returns>
        public bool SetDelayTimeOCP(MessageBasedSession mbs, POWER_CH_EN power_ch, double delay = 0.050) {
            try {
                return instCmnlLib.Write(mbs, ":CURR:PROT:DEL " + delay + "," + Channel(power_ch) + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.SET_DELAY_TIME_OCP_FAIL.ToString();
                return false;
            }
        }

        /// <summary>
        /// 清除通道保护
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="power_ch"></param>
        /// <returns></returns>
        public bool ClearProtect(MessageBasedSession mbs, POWER_CH_EN power_ch) {
            try {
                return instCmnlLib.Write(mbs, ":OUTP:PROT:CLE " + Channel(power_ch) + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.CLEAR_PROTECT_FAIL.ToString();
                return false;
            }
        }

        /// <summary>
        /// 设置通道输出开启和关闭的延时
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="power_ch"></param>
        /// <param name="onDelay"></param>
        /// <param name="offDelay"></param>
        /// <returns></returns>
        public bool SetOutputOnOffDelay(MessageBasedSession mbs, POWER_CH_EN power_ch, double onDelay, double offDelay) {
            try {
                return instCmnlLib.Write(mbs, ":OUTP:DEL:RISE " + onDelay + "," + Channel(power_ch) + "\n")
                       & instCmnlLib.Write(mbs, ":OUTP:DEL:FALL " + offDelay + "," + Channel(power_ch) + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.SET_ON_OFF_DELAY_FAIL.ToString();
                return false;
            }
        }

        /// <summary>
        /// 启用跟踪模式后，仅适用设置电压的时候同步设置所有通道。电流限值为每个输出独立设置，且不受跟踪模式影响。
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public bool SetTraceMode(MessageBasedSession mbs, STATE_EN state) {
            try {
                return instCmnlLib.Write(mbs, ":OUTP:TRAC " + state + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.SET_TRACE_MODE_FAIL.ToString();
                return false;
            }
        }

        /// <summary>
        /// 设置通道耦合模式，都开启后使能任意CH输出都全局化输出
        /// </summary>
        /// <param name="mbs"></param>
        /// <returns></returns>
        public bool SetOutputCouple(MessageBasedSession mbs, bool all, POWER_CH_EN power_ch) {
            try {
                if (all) {
                    return instCmnlLib.Write(mbs, ":OUTP:COUP:CHAN CH1,CH2" + "\n")
                           & instCmnlLib.WaitOpc(mbs);
                }
                else {
                    return instCmnlLib.Write(mbs, ":OUTP:COUP:CHAN " + power_ch + "\n")
                           & instCmnlLib.WaitOpc(mbs);
                }
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.SET_OUT_COUPLE_FAIL.ToString();
                return false;
            }
        }

        /// <summary>
        /// 设置通道(并联、串联、跟踪、独立)输出模式
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public bool SetOutLinkMode(MessageBasedSession mbs, OUTPUT_LINK_EN mode) {
            try {
                if (mode == OUTPUT_LINK_EN.INDEPEND) {
                    return SetTraceMode(mbs, STATE_EN.OFF);
                }
                if (mode == OUTPUT_LINK_EN.PARallel) {
                    return instCmnlLib.Write(mbs, "OUTP:PAIR PAR" + "\n");
                }
                if (mode == OUTPUT_LINK_EN.SERies) {
                    return instCmnlLib.Write(mbs, ":OUTP:PAIR SER" + "\n");
                }
                if (mode == OUTPUT_LINK_EN.TRACKING) {
                    return SetTraceMode(mbs, STATE_EN.ON);
                }
                instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.SET_OUT_LINK_MODE_FAIL.ToString();
                return false;
            }
            return true;
        }

        /// <summary>
        /// 前面板按钮锁定与解锁
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="panelLock"></param>
        /// <returns></returns>
        public bool SetPanelLock(MessageBasedSession mbs, LOCK_PANEL_EN panelLock) {
            try {
                return instCmnlLib.Write(mbs, ":SYST:" + panelLock + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.SET_PANEL_LOCK_FAIL.ToString();
                return false;
            }
        }

        #endregion

        #region 6. KeySight Multi E34465A Operation
        public bool MultiCtrl(MULTI_CTRL_EN multiCtrl) {
            switch (multiCtrl) {
                case MULTI_CTRL_EN.MULTI_INITIAL:
                    return InstrumentInitial(instCmnlLib.mbsMulti);
                case MULTI_CTRL_EN.READ_DATA:
                    return ReadMulti(instCmnlLib.mbsMulti, ref var_st.readData);
                case MULTI_CTRL_EN.SET_MEAS_MODE:
                    return SetMultiMeasMode(instCmnlLib.mbsMulti, var_st.readType, var_st.measureMode);
                case MULTI_CTRL_EN.SET_HIGH_Z:
                    return SetMultiHighZ(instCmnlLib.mbsMulti);
                case MULTI_CTRL_EN.SET_NPLC:
                    return SetMultiNPLC(instCmnlLib.mbsMulti, var_st.readType);
                case MULTI_CTRL_EN.SET_AUTO_ZERO_MEAS:
                    return SetAutoZeroMeas(instCmnlLib.mbsMulti, var_st.readType, var_st.state);
            }
            return true;
        }
        /// <summary>
        /// 开启远程控制模式 or 启用本地操控模式; 注意必须要设置远程控制模式, 后续命令才可生效
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="ctrlMode"></param>
        /// <returns></returns>
        public bool MultiLocalModeCtrl(MessageBasedSession mbs) {
            try {
                return instCmnlLib.Write(mbs, "SYST:LOCal\n");
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.INST_CTRL_MODE_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 读取万用表数据, 注意如果结果中需要添加数据单位, 则需要将 var_st.dataUnit 与数据实时绑定
        /// </summary>
        /// <param name="mbs"></param>
        /// <returns></returns>
        public bool ReadMulti(MessageBasedSession mbs, ref double data) {
            bool isOk = true;
            string type = instCmnlLib.Query(mbs, "CONF?\n").Replace("\n", "");  //获取当前测量的类型 电流 or 电压
            try {
                string buff = string.Empty;
                string baseNun = string.Empty;
                buff = instCmnlLib.Query(mbs, "READ?\n").Replace("\n", "");
                baseNun = buff.Split('E')[1];
                switch (baseNun) {
                    case "-12":
                    case "-11":
                    case "-10":
                        data = 1000000000000.00000 * double.Parse(buff);
                        var_st.dataUnit = type.Contains("VOLT") ? "pV" : (type.Contains("CURR") ? "pA" : "");
                        break;
                    case "-09":
                    case "-08":
                    case "-07":
                        data = 1000000000.00000 * double.Parse(buff);
                        var_st.dataUnit = type.Contains("VOLT") ? "nV" : (type.Contains("CURR") ? "nA" : "");
                        break;
                    case "-06":
                    case "-05":
                    case "-04":
                        data = 1000000.00000 * double.Parse(buff);
                        var_st.dataUnit = type.Contains("VOLT") ? "uV" : (type.Contains("CURR") ? "uA" : "");
                        break;
                    case "-03":
                    case "-02":
                    case "-01":
                        data = 1000.00000 * double.Parse(buff);
                        var_st.dataUnit = type.Contains("VOLT") ? "mV" : (type.Contains("CURR") ? "mA" : "");
                        break;
                    case "+00":
                    case "+01":
                    case "+02":
                        data = double.Parse(buff);
                        var_st.dataUnit = type.Contains("VOLT") ? "V" : (type.Contains("CURR") ? "A" : "");
                        break;
                    default:
                        break;
                }
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.READ_DATA_FAIL.ToString();
                isOk &= false;
            }
            return isOk;
        }

        /// <summary>
        /// 设置万用表测量类型 VOLT, CURR,测量模式 DC/AC, 并启用自动量程
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="readType"></param>
        /// <param name="measMode"></param>
        /// <returns></returns>
        public bool SetMultiMeasMode(MessageBasedSession mbs, READ_TYPE_EN readType, MEASURE_MODE_EN measMode) {
            try {
                return instCmnlLib.Write(mbs, ":CONF:" + readType + ":" + measMode + " AUTO\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.SET_MEASURE_MODE_FAIL.ToString();
                return false;
            }
        }

        /// <summary>
        /// 针对DC测量,设置NPLC, NPLC越大,测量速率越低,测值越准; NPLC = Number of power line cycles
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="readType"></param>
        /// <param name="nplc"></param>
        /// <param name="measMode"></param>
        /// <returns></returns>
        public bool SetMultiNPLC(MessageBasedSession mbs, READ_TYPE_EN readType, double nplc = 10) {
            try {
                return instCmnlLib.Write(mbs, ":" + readType + ":DC:NPLC " + nplc + "\n")          //default mode is DC, NPLC = 0.02;  NPLC = Number of power line cycles, 100 NPLC = 1.6 seconds
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.SET_NPLC_FAIL.ToString();
                return false;
            }
        }

        /// <summary>
        /// 自动调零:仪器内部在每次测量后断开输入信号，并进行零测量。然后从之前的测量中减去零的测量值。这可以防止仪器输入电路上的偏置电压影响测量精度。
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="readType"></param>
        /// <param name="state"></param>
        /// <param name="measMode"></param>
        /// <returns></returns>
        public bool SetAutoZeroMeas(MessageBasedSession mbs, READ_TYPE_EN readType, STATE_EN state = STATE_EN.ON) {
            try {
                return instCmnlLib.Write(mbs, ":" + readType + ":DC:ZERO:AUTO " + state + "\n")   //default mode is DC, NPLC = 0.02;  NPLC = Number of power line cycles, 100 NPLC = 1.6 seconds
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.SET_NPLC_FAIL.ToString();
                return false;
            }
        }

        /// <summary>
        /// 测量电压时，需要将万用表设置为高阻模式, "OFF": 10M input impedance setting, "ON": sets >10G ohm
        /// </summary>
        /// <param name="mbs"></param>
        /// <returns></returns>
        public bool SetMultiHighZ(MessageBasedSession mbs, STATE_EN state = STATE_EN.ON) {
            try {
                return instCmnlLib.Write(mbs, "VOLT:IMP:AUTO " + state + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.SET_HIGH_Z_FAIL.ToString();
                return false;
            }
        }
        #endregion

        #region 7. IETCH Power I6333A Operation

        public bool IetchPowerCtrl(POWER_CTRL_EN powerCtrl) {
            switch (powerCtrl) {
                case POWER_CTRL_EN.ITECH_POWER_REMOTE_EN:
                    return ItechRemoteModeCtrl(instCmnlLib.mbsPowerItech, var_st.ctrlMode);
                case POWER_CTRL_EN.POWER_INITIAL:
                    return InstrumentInitial(instCmnlLib.mbsPowerItech);
                case POWER_CTRL_EN.POWER_ALL_OUTPUT:
                    return ItechPowerOutputAllEn(instCmnlLib.mbsPowerItech, var_st.state);
                case POWER_CTRL_EN.POWER_OUTPUT_CH_CTRL:
                    return ItechPowerOutputEn(instCmnlLib.mbsPowerItech, var_st.power_ch, var_st.state);
                case POWER_CTRL_EN.SET_INIT_VOLT_LIMIT_CURR:
                    return InitSetIetchPower(instCmnlLib.mbsPowerItech, var_st.setItechVolt, var_st.setItechCurr);
                case POWER_CTRL_EN.SET_ITECH_POWER_VOLT:
                    return SetIetchPowerVolt(instCmnlLib.mbsPowerItech, var_st.power_ch, var_st.setVolt);
                case POWER_CTRL_EN.SET_ITECH_POWER_CURR:
                    return SetIetchPowerCurr(instCmnlLib.mbsPowerItech, var_st.power_ch, var_st.limitCurr);
                case POWER_CTRL_EN.READ_ITECH_POWER_ALL:
                    return ReadItechPowerAll(instCmnlLib.mbsPowerItech, var_st.readType, ref var_st.readIetchData);
                case POWER_CTRL_EN.READ_ITECH_POWER_CH:
                    return ReadItechPowerCh(instCmnlLib.mbsPowerItech, var_st.power_ch, var_st.readType, ref var_st.readData);
                default:
                    break;
            }
            return true;
        }
        /// <summary>
        /// 初始化设置电源 使能远程控制、设置各通道电压电流
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="volt"></param>
        /// <param name="curr"></param>
        /// <returns></returns>
        public bool InitSetIetchPower(MessageBasedSession mbs, double[] volt, double[] curr) {
            try {
                return ItechRemoteModeCtrl(mbs)
                       & instCmnlLib.Write(mbs, ":APP:VOLT " + volt[0] + "," + volt[1] + "," + volt[2] + "\n")
                       & instCmnlLib.Write(mbs, ":APP:CURR " + curr[0] + "," + curr[1] + "," + curr[2] + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.INST_INIT_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 设置电源电源，注意单位为V，输入的参数精确到 1mv: 1.666
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="ch"></param>
        /// <param name="volt"></param>
        /// <returns></returns>
        public bool SetIetchPowerVolt(MessageBasedSession mbs, POWER_CH_EN ch, double volt) {
            try {
                return instCmnlLib.Write(mbs, ":INST:SEL " + ch + "\n")
                       & instCmnlLib.Write(mbs, ":VOLT " + volt + "V\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.SET_POWER_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 设置电源限流，注意单位为A，输入的参数精确到 1mA: 1.666
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="ch"></param>
        /// <param name="curr"></param>
        /// <returns></returns>
        public bool SetIetchPowerCurr(MessageBasedSession mbs, POWER_CH_EN ch, double curr) {
            try {
                return instCmnlLib.Write(mbs, ":INST:SEL " + ch + "\n")
                       & instCmnlLib.Write(mbs, ":CURR " + curr + "A\n")
                        & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.SET_POWER_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 设置电源电压、限流，注意单位为V、A，输入的参数精确到 1mV\1mA: 1.666V/1.235A
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="ch"></param>
        /// <param name="volt"></param>
        /// <param name="curr"></param>
        /// <returns></returns>
        public bool SetItechPowerVoltCurr(MessageBasedSession mbs, POWER_CH_EN ch, double volt, double curr = 1.000) {
            try {
                return instCmnlLib.Write(mbs, ":INST:SEL " + ch + "\n")
                     & instCmnlLib.Write(mbs, ":VOLT " + volt + "V\n")
                     & instCmnlLib.Write(mbs, ":CURR " + curr + "A\n");
                     //& instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.SET_POWER_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 读取当前通道的电压 or 电流
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="ch"></param>
        /// <param name="type"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool ReadItechPowerCh(MessageBasedSession mbs, POWER_CH_EN ch, READ_TYPE_EN type, ref double data) {
            try {
                instCmnlLib.Write(mbs, ":INST:SEL " + ch + "\n");
                data = double.Parse(instCmnlLib.Query(mbs, ":MEAS:" + type + "?\n").Replace("\n", ""));
                instCmnlLib.WaitOpc(mbs);
                return true;
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.READ_DATA_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 读取所有通道的电压 or 电流, 注意原始输出的是以逗号隔开的字符串（0, 0, 0\n)
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="ch"></param>
        /// <param name="type"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool ReadItechPowerAll(MessageBasedSession mbs, READ_TYPE_EN type, ref double[] data) {
            try {
                string dataString = instCmnlLib.Query(mbs, ":MEAS:" + type + ":ALL?\n").Replace("\n", "");
                instCmnlLib.WaitOpc(mbs);
                data[0] = double.Parse(dataString.Split(',')[0]);
                data[1] = double.Parse(dataString.Split(',')[1]);
                data[2] = double.Parse(dataString.Split(',')[2]);
                return true;
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.READ_DATA_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 当前CH输出使能设置
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="ch"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public bool ItechPowerOutputEn(MessageBasedSession mbs, POWER_CH_EN ch, STATE_EN state) {
            try {
                return instCmnlLib.Write(mbs, ":INST:SEL " + ch + "\n")
                       & instCmnlLib.Write(mbs, ":CHAN:OUTP:STAT " + state + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.INST_OUTPUT_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 全部CH输出使能, 等效于 ALL ON/OFF
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public bool ItechPowerOutputAllEn(MessageBasedSession mbs, STATE_EN state) {
            try {
                return instCmnlLib.Write(mbs, ":OUTP:STAT " + state + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.INST_OUTPUT_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 开启远程控制模式 or 启用本地操控模式; 注意必须要设置远程控制模式, 后续命令才可生效
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="ctrlMode"></param>
        /// <returns></returns>
        public bool ItechRemoteModeCtrl(MessageBasedSession mbs, INST_CTRL_MODE ctrlMode = INST_CTRL_MODE.REMote) {
            try {
                return instCmnlLib.Write(mbs, "SYSTem:" + ctrlMode + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.INST_CTRL_MODE_FAIL.ToString();
                return false;
            }
        }

        #endregion

        #region 8. GuWei Power GPP-4323 Operation

        public bool GuWeiPowerCtrl(POWER_CTRL_EN powerCtrl) {
            switch (powerCtrl) {
                case POWER_CTRL_EN.ITECH_POWER_REMOTE_EN:
                    return GuWeiRemoteModeCtrl(instCmnlLib.mbsPowerGuwei, var_st.ctrlMode);
                case POWER_CTRL_EN.POWER_INITIAL:
                    return InstrumentInitial(instCmnlLib.mbsPowerGuwei);
                case POWER_CTRL_EN.POWER_ALL_OUTPUT:
                    return GuWeiPowerOutputAllEn(instCmnlLib.mbsPowerGuwei, var_st.state);
                case POWER_CTRL_EN.POWER_OUTPUT_CH_CTRL:
                    return GuWeiPowerOutputChEn(instCmnlLib.mbsPowerGuwei, var_st.power_ch, var_st.state);
                case POWER_CTRL_EN.SET_INIT_VOLT_LIMIT_CURR:
                    return InitSetGuWeiPower(instCmnlLib.mbsPowerGuwei, var_st.power_ch, var_st.voltCurr);
                case POWER_CTRL_EN.SET_ITECH_POWER_VOLT:
                    return SetGuWeiPowerVolt(instCmnlLib.mbsPowerGuwei, var_st.power_ch, var_st.setVolt);
                case POWER_CTRL_EN.SET_ITECH_POWER_CURR:
                    return SetGuWeiPowerCurr(instCmnlLib.mbsPowerGuwei, var_st.power_ch, var_st.limitCurr);
                case POWER_CTRL_EN.READ_ITECH_POWER_ALL:
                    return ReadGuWeiPowerAll(instCmnlLib.mbsPowerGuwei, var_st.readType, ref var_st.readGuWeiData);
                case POWER_CTRL_EN.READ_ITECH_POWER_CH:
                    return ReadGuWeiPowerCh(instCmnlLib.mbsPowerGuwei, var_st.power_ch, var_st.readType, ref var_st.readData);
                default:
                    break;
            }
            return true;
        }
        /// <summary>
        /// 初始化设置电源 使能远程控制、设置各通道电压电流
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="volt"></param>
        /// <param name="curr"></param>
        /// <returns></returns>
        public bool InitSetGuWeiPower(MessageBasedSession mbs, POWER_CH_EN ch, double[,] voltCurr) {
            try {
                return GuWeiRemoteModeCtrl(mbs) & GuWeiSetBuzzer(mbs)
                       & instCmnlLib.Write(mbs, ":DISPlay:BRIGhtness High\n")   //显示亮度的调节 High|Middle|Low
                       & SetGuWeiPowerCurrArray(mbs, ch, voltCurr)
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.INST_INIT_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 对电源单通道的电压、电流初始化设置; voltCurr的初始化格式为{3.300,1.000} 单位分别为：V,A
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="ch"></param>
        /// <param name="voltCurr"></param>
        /// <returns></returns>
        public bool SetGuWeiPowerCurrArray(MessageBasedSession mbs, POWER_CH_EN ch, double[,] voltCurr) {
            try {
                return instCmnlLib.Write(mbs, ":SOUR" + (int)ch + ":VOLT " + voltCurr[(int)(ch - 1), 0] + "\n")
                     & instCmnlLib.Write(mbs, ":SOUR" + (int)ch + ":CURR " + voltCurr[(int)(ch - 1), 1] + "\n")
                     & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.SET_POWER_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 设置限流，注意单位为A，输入的参数精确到 1mA: 1.666
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="ch"></param>
        /// <param name="curr"></param>
        /// <returns></returns>
        public bool SetGuWeiPowerCurr(MessageBasedSession mbs, POWER_CH_EN ch, double curr) {
            try {
                return instCmnlLib.Write(mbs, ":SOUR" + (int)ch + ":CURR " + curr + "\n")
                     & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.SET_POWER_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 设置电源电压,注意单位为V，输入的参数精确到 1mV/1mA: 1.666V/1.235A
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="ch"></param>
        /// <param name="volt"></param>
        /// <returns></returns>
        public bool SetGuWeiPowerVolt(MessageBasedSession mbs, POWER_CH_EN ch, double volt) {
            try {
                return instCmnlLib.Write(mbs, ":SOUR" + (int)ch + ":VOLT " + volt + "\n");
                     //& instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.SET_POWER_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 读取当前通道的电压 or 电流
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="ch"></param>
        /// <param name="type"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool ReadGuWeiPowerCh(MessageBasedSession mbs, POWER_CH_EN ch, READ_TYPE_EN type, ref double data) {
            try {
                data = double.Parse(instCmnlLib.Query(mbs, ":MEAS" + (int)ch + ":" + type + "?\n").Replace("\n", ""));
                instCmnlLib.WaitOpc(mbs);
                return true;
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.READ_DATA_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 读取所有通道的电压,电流,功率; 注意原始输出的是以逗号隔开的字符串（0, 0, 0, 0\n)
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="ch"></param>
        /// <param name="type"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool ReadGuWeiPowerAll(MessageBasedSession mbs, READ_TYPE_EN type, ref double[] data) {
            try {
                string dataString = instCmnlLib.Query(mbs, ":MEAS:" + type + ":ALL?\n").Replace("\n", "");
                instCmnlLib.WaitOpc(mbs);
                data[0] = double.Parse(dataString.Split(',')[0]);
                data[1] = double.Parse(dataString.Split(',')[1]);
                data[2] = double.Parse(dataString.Split(',')[2]);
                data[3] = double.Parse(dataString.Split(',')[3]);
                return true;
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.READ_DATA_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 当前CH输出使能设置, :OUTP1 ON
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="ch"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public bool GuWeiPowerOutputChEn(MessageBasedSession mbs, POWER_CH_EN ch, STATE_EN state) {
            try {
                return instCmnlLib.Write(mbs, ":OUTP" + (int)ch + " " + state + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.INST_OUTPUT_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 全部CH输出使能, 等效于 ALL ON/OFF
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public bool GuWeiPowerOutputAllEn(MessageBasedSession mbs, STATE_EN state) {
            try {
                return instCmnlLib.Write(mbs, ":ALLOUT" + state + "\n")  //注意没有空格
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.INST_OUTPUT_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 设置CH1 & CH2为串联 or 并联模式
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="ctrlMode"></param>
        /// <returns></returns>
        public bool GuWeiSetOutLinkMode(MessageBasedSession mbs, OUTPUT_LINK_EN linkMode, STATE_EN state = STATE_EN.OFF) {
            try {
                return instCmnlLib.Write(mbs, "OUTP:" + linkMode + " " + state + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.SET_OUT_LINK_MODE_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 开启远程控制模式 or 启用本地操控模式; 注意必须要设置远程控制模式, 后续命令才可生效
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="ctrlMode"></param>
        /// <returns></returns>
        public bool GuWeiRemoteModeCtrl(MessageBasedSession mbs, INST_CTRL_MODE ctrlMode = INST_CTRL_MODE.REMote) {
            try {
                return instCmnlLib.Write(mbs, "SYSTem:" + ctrlMode + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.INST_CTRL_MODE_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 蜂鸣器设置, 默认关闭
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public bool GuWeiSetBuzzer(MessageBasedSession mbs, STATE_EN state = STATE_EN.OFF) {
            try {
                return instCmnlLib.Write(mbs, "SYSTem:BEEP:STAT " + state + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.INST_CTRL_MODE_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 设置远程控制接口类型[USB|RS232|GPIB|LAN]
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public bool GuWeiSetInerfaceMode(MessageBasedSession mbs, REMOTE_INTERFACE ctrlMode = REMOTE_INTERFACE.LAN) {
            try {
                return instCmnlLib.Write(mbs, "SYSTem:INTerface " + ctrlMode + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.INST_CTRL_MODE_FAIL.ToString();
                return false;
            }
        }

        #endregion

        #region 9. SIGLENT 信号源SDG6052X
        /// <summary>
        /// 信号源---输出状态设置(ON/OFF)
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="ch"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public bool OutPutEn(MessageBasedSession mbs, SIGNAL_SOURCE_CH_EN ch, STATE_EN state) {
            try {
                return instCmnlLib.Write(mbs, ch + ":OUTP " + state + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.INST_INIT_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 信号源---通道输出端接阻抗设置(50ohm/HiZ)
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="ch"></param>
        /// <param name="load"></param>
        /// <returns></returns>
        public bool ChLoadSet(MessageBasedSession mbs, SIGNAL_SOURCE_CH_EN ch, SIGNAL_SOURCE_CH_LOAD load) {
            string loading = "50";
            if (SIGNAL_SOURCE_CH_LOAD.R50 == load) loading = SIGNAL_SOURCE_CH_LOAD.R50.ToString().Replace("R", "");
            if (SIGNAL_SOURCE_CH_LOAD.HZ == load) loading = load.ToString();
            try {
                return instCmnlLib.Write(mbs, ch + ":OUTP LOAD," + loading + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.INST_INIT_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 信号源---通道输出波形设置(正弦/方波/PRBS/三角波...)
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="ch"></param>
        /// <param name="wave"></param>
        /// <returns></returns>
        public bool ChWaveSet(MessageBasedSession mbs, SIGNAL_SOURCE_CH_EN ch, SIGNAL_SOURCE_CH_WAVE wave) {
            try {
                return instCmnlLib.Write(mbs, ch + ":BSWV WVTP," + wave + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.INST_INIT_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 信号源---2个通道波形同步设置
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="ch"></param>
        /// <param name="wave"></param>
        /// <returns></returns>
        public bool AllChWaveSet(MessageBasedSession mbs, SIGNAL_SOURCE_CH_WAVE wave) {
            try {
                return instCmnlLib.Write(mbs, "C1:BSWV WVTP," + wave + "\n")
                       & instCmnlLib.Write(mbs, "C2:BSWV WVTP," + wave + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.INST_INIT_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 信号源---2个通道波形频率同步设置(eg: freq=20e6)
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="freq"></param>
        /// <returns></returns>
        public bool AllChWaveFreq(MessageBasedSession mbs, double freq) {
            try {
                return instCmnlLib.Write(mbs, "C1:BSWV FRQ," + freq + "\n")
                       & instCmnlLib.Write(mbs, "C2:BSWV FRQ," + freq + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.INST_INIT_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 信号源---单一通道波形频率设置(eg: freq=20e6)
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="ch"></param>
        /// <param name="freq"></param>
        /// <returns></returns>
        public bool ChWaveFreq(MessageBasedSession mbs, SIGNAL_SOURCE_CH_EN ch, double freq) {
            try {
                return instCmnlLib.Write(mbs, ch + ":BSWV FRQ," + freq + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.INST_INIT_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 信号源---2个通道波形幅度同步设置(eg: ampl=2.5)
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="ampl"></param>
        /// <returns></returns>
        public bool AllChWaveAmpl(MessageBasedSession mbs, double ampl) {
            try {
                return instCmnlLib.Write(mbs, "C1:BSWV AMP," + ampl + "\n")
                       & instCmnlLib.Write(mbs, "C2:BSWV AMP," + ampl + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.INST_INIT_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 信号源---单一通道波形幅度设置(eg: ampl=2.5)
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="ch"></param>
        /// <param name="ampl"></param>
        /// <returns></returns>
        public bool ChWaveAmpl(MessageBasedSession mbs, SIGNAL_SOURCE_CH_EN ch, double ampl) {
            try {
                return instCmnlLib.Write(mbs, ch + ":BSWV AMP," + ampl + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.INST_INIT_FAIL.ToString();
                return false;
            }
        }
        /// <summary>
        /// 信号源---2通道PRBS码型同步设置(eg: length=3)
        /// </summary>
        /// <param name="mbs"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public bool AllChPrbsLengthSet(MessageBasedSession mbs, int length = 3) {
            try {
                return instCmnlLib.Write(mbs, "C1:BSWV LENGTH," + length + "\n")
                       & instCmnlLib.Write(mbs, "C2:BSWV LENGTH," + length + "\n")
                       & instCmnlLib.WaitOpc(mbs);
            }
            catch {
                instCmnlLib.inst_st.errorMessage = InstCommonCtrlLib.ERROR_EN.INST_INIT_FAIL.ToString();
                return false;
            }
        }
        #endregion

        #region 10. 鼎阳示波器 SIGLENT SDS6104H10Pro

        #endregion

        #region 11. Tektronix MSO54

        #endregion
    }
}
