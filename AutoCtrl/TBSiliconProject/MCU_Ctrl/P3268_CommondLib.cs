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
    public class P3268_CommondLib {

        //级联个数、排序包
        //*************** 串口基础协议 ****************************
        //  Bit     Definition        Value       Function
        // [7:0]      头1	          0xAA	       协议包头
        // [7:0]      头2	          0x55	       协议包头
        // [7:0]      CMD_TYPE	    0x00-0x0C	   命令类型
        // [7:0]      填充位	        0x00-0x05	   填充位,每个周期都下发的指令需单独占一个填充位
        // [7:0]      Vsync_ALL	    0x01-0xFF	   用于选择是否每个Vsync周期都发指令, 0xFF为每个周期都发, 0x01为只发一次, 其他数值为发送特定周期数
        // [7:0]      芯片ID	        0x00-0x3E	   非广播模式下的芯片ID
        // [7:0]      起始地址	    0x00-0x3F	   寄存器的起始地址
        // [7:0]      数据长度	    0x00-0x3F	   写入数据的长度
        // [15:0]     数据位         0x00-0xFF      数据位
        public List<byte> writePackage = new List<byte>();
        public SP3268_OPT_ST sp3268_opt_st = new SP3268_OPT_ST();
        public P3268_PARA_ST p3268_para_st = new P3268_PARA_ST();
        public CommonFunctionLib comFunLib = new CommonFunctionLib();
        public InstCommandLib instCmdLib = new InstCommandLib();
        public InstCommonCtrlLib instCtrlLib = new InstCommonCtrlLib();
        public DriveChCurrVoltTestLib chCurrVoltCmd = new DriveChCurrVoltTestLib();
        public string dataStream = "";
        public int cnt;
        public List<string> dataList = new List<string>();
        public struct P3268_PARA_ST {
            public ComboBox cmbCmdType;
            public ComboBox cmbAtbTable;
            public ComboBox cmbFastCmd;
            public ComboBox cmbDisplayCmd;
            public ComboBox cmbAutoTestItem;
            public TextBox tbRegAddr;
            public TextBox tbValueCfg;
            public RadioButton rbKeyPwrEn;
            public RadioButton rbGppPwrEn;
            public RadioButton rbItechPwrEn;
            public CheckBox cbPowerEn;
            public CheckBox cbMulti0En;
            public CheckBox cbMulti1En;
            public NumericUpDown nudGccCode;
            public NumericUpDown nudReadInstDelay;
            public RichTextBox rtbLog;
            public string chipCnt;
            public double data;
            public bool stop;
            public bool[] pwrCh;
            public int CH;
            public int testCnt;
        }
        public struct SP3268_OPT_ST {
            public List<byte> headPke;         //包头2*8bit：55、AA
            public List<byte> cmdType;         //命令类型：0xA0~0xAE
            public List<byte> fillBit;         //填充位：0x01~0x06
            public List<byte> vsAll;           //发送模式：0xFF为每帧发送, 其他值代表总的发送次数
            public List<byte> delayCycle;      //延时周期：0x00~0xFF
            public List<byte> regAddr;         //起始地址：0x00~0x3F, 寄存器起始地址
            public List<byte> linkCnt;         //级联个数：0x00~0x03, 默认级联3颗
            public List<byte> dataLength;      //数据长度：如果只写1个地址，则长度为0x01, 如果写2个连续的地址，则长度为0x02
            public List<byte> dataValue;       //写入数据：48bit...
            public List<byte> endPke;          //尾包：2*8bit：01、FE   
        }
        public string[,] testItem_CircuitLevel = new string[,] {
            {"48通道一致性测试", "CH_Num\tCurr||Volt"},
            {"8bit_PAM_扫描","PAM_Code\tCURR(mA)"},
            //{"电路级-ATB_Test","ATB_Name\tVolt"},
            //{"电路级-VBG_Trim","VBG_code\tVolt"},
            //{"电路级-LDO_Trim","LDO_Code\tVolt"},
            //{"电路级-GCC_Trim","GCC_Code\tCurr"},
        };

        public string[] testMode = new string[]
        {
            //倒数第3字节，mode占3bit，00~07(正常/电流/列消隐电压/预驱动功能/行消隐功能/行电压钳位功能/通道电压钳位功能/保留)
            "55 AA A2 01 FF 05 CF 01 01 00 00 00 00 00 00 01 FE",
            "55 AA A2 01 FF 05 CF 01 01 00 00 00 00 00 01 01 FE",
            "55 AA A2 01 FF 05 CF 01 01 00 00 00 00 00 02 01 FE",
            "55 AA A2 01 FF 05 CF 01 01 00 00 00 00 00 03 01 FE",
            "55 AA A2 01 FF 05 CF 01 01 00 00 00 00 00 04 01 FE",
            "55 AA A2 01 FF 05 CF 01 01 00 00 00 00 00 05 01 FE",
            "55 AA A2 01 FF 05 CF 01 01 00 00 00 00 00 06 01 FE"
        };
        public string[] lowKneePathSel = new string[]
        {
            //RGB LowKnee & PathSel分别对应0x08,0x0A,0x0C
            //default: lowKnee---2'b10;
            //GCC path Sel---调节电流过流能力(对应全局电流增益)：
            //00(1/256~16/256),01(17/256~64/256), default = 10(65/256~128/256), 配置 = 11(129/256~256/256)
            "55 AA A2 01 FF 05 08 01 01 00 00 00 41 26 30 01 FE"    //地址(0x07\09\0B)RGB GCC配置最大  0xFF
        };
        public string[] gccGlobalCurrGain = new string[]
        {
            //地址(0x07\09\0B)RGB GCC默认配置  0x80
            "55 AA A2 01 FF 05 07 01 01 10 04 90 00 10 80 01 FE",
            "55 AA A2 01 FF 05 09 01 01 10 04 90 00 10 80 01 FE",
            "55 AA A2 01 FF 05 0B 01 01 10 04 90 00 10 80 01 FE"
        };
        public string[] vbgTrimAtbCfg = new string[]
        {
            "55 AA A2 01 FF 05 16 01 01 40 25 91 63 00 01 01 FE",
            "55 AA A2 01 FF 05 DF 01 01 00 00 00 00 00 02 01 FE",   //顶层ATB使能 bit[1]=1'b1
            "55 AA A2 01 FF 05 D1 01 01 02 40 03 80 00 00 01 FE",   //VBG_ATB选通, bit[25:23]=3’b111
        };
        public string[] chopOnOff = new string[]
        {
            "55 AA A2 01 FF 05 06 01 01 00 00 00 06 D8 01 01 FE",   //CHOP_ON, bit[25]=1'b0
            "55 AA A2 01 FF 05 06 01 01 00 00 02 06 D8 01 01 FE",   //CHOP_OFF, bit[25]=1'b1
        };
        public string[] ldoRegulatorTrimCfg = new string[]
        {
            "55 AA A2 01 FF 05 16 01 01 40 25 91 63 00 01 01 FE",
            "55 AA A2 01 FF 05 DF 01 01 00 00 00 00 00 02 01 FE",   //顶层ATB使能 bit[1]=1'b1
            "55 AA A2 01 FF 05 D1 01 01 01 C7 00 00 00 00 01 FE",   //LDO_SYS_ATB选通, bit[41:38]=4’b0111
            "55 AA A2 01 FF 05 D1 01 01 01 80 E0 00 00 00 01 FE"    //LDO_CPLL_ATB选通, bit[41:38]=4’b0111
        };
        public string[] ldoSysTrimCode = new string[]
        { "80","88","90","98","A0","A8","B0","B8","C0","C8","D0","D8","E0","E8","F0","F8"};
        public string[] ldoCpllTrimCode = new string[]
        { "20","22","24","26","28","2A","2C","2E","30","32","34","36","38","3A","3C","3E"};
        public string[] gccIfixTrimCfg = new string[]  //红色通道
        {
            "55 AA A2 01 FF 05 16 01 01 40 25 91 63 00 01 01 FE",
            "55 AA A2 01 FF 05 1A 01 01 00 00 00 00 00 01 01 FE",   //通道输出使能 bit[0]=1'b1
            "55 AA A2 01 FF 05 CF 01 01 00 00 00 00 00 01 01 FE",   //选择电流工作模式, bit[2:0]=3’b001
            "55 AA A2 01 FF 05 00 01 01 10 02 00 07 00 00 01 FE",   //PAM_EN&CURR_DATA：PAM使能&增益为1, bit[33]=1’b1 & bit[23:16]=8’b00000111
            "55 AA A2 01 FF 05 07 01 01 10 04 90 00 10 FF 01 FE",   //GCC_TOP=0xFF, bit[7:0]=8’b11111111
            "55 AA A2 01 FF 05 06 01 01 00 00 00 06 D8 03 01 FE",   //GCC_GAIN_CTRL：GCC范围增益为1, bit[1:0]=2’b11
            "55 AA A2 01 FF 05 08 01 01 00 00 00 41 26 30 01 FE",   //Path_sel和LowKnee_sel配置为0x3, bit[10:9]=2’b11 & bit[6:4]=3’b011
        };
        public void RegAddrDataGenerator(string regAddr, string data) {
            //Step1: 转换寄存器地址模式
            byte reg = Convert.ToByte(regAddr, 16);
            sp3268_opt_st.regAddr.Add(reg);
            Int64 value = Convert.ToInt64(data, 16);
            //Step2: 生成-寄存器配置值-数据流  (此处支持单一寄存器值&多地址序列值)
            int dataLen = 6;
            for (int i = 0; i < dataLen; i++) {
                byte temp = (byte)((value >> (dataLen - 1 - i) * 8) & 0xff);
                sp3268_opt_st.dataValue.Add(temp);
            }
        }
        public void DataPackageInit(string regAddr, string data) {
            writePackage.Clear();
            sp3268_opt_st.headPke = new List<byte> { 0x55, 0xAA };
            sp3268_opt_st.cmdType = new List<byte> { 0xA2 };
            sp3268_opt_st.fillBit = new List<byte> { 0x01 };
            sp3268_opt_st.vsAll = new List<byte> { 0x01 };
            sp3268_opt_st.delayCycle = new List<byte> { 0x10 };
            sp3268_opt_st.regAddr = new List<byte> { };
            sp3268_opt_st.linkCnt = new List<byte> { 0x03 };
            sp3268_opt_st.dataLength = new List<byte> { 0x01 };
            sp3268_opt_st.dataValue = new List<byte> { };
            sp3268_opt_st.endPke = new List<byte> { 0x01, 0xFE };
            RegAddrDataGenerator(regAddr, data);
            writePackage.AddRange(sp3268_opt_st.headPke);
            writePackage.AddRange(sp3268_opt_st.cmdType);
            writePackage.AddRange(sp3268_opt_st.fillBit);
            writePackage.AddRange(sp3268_opt_st.vsAll);
            writePackage.AddRange(sp3268_opt_st.delayCycle);
            writePackage.AddRange(sp3268_opt_st.regAddr);
            writePackage.AddRange(sp3268_opt_st.linkCnt);
            writePackage.AddRange(sp3268_opt_st.dataLength);
            writePackage.AddRange(sp3268_opt_st.dataValue);
            writePackage.AddRange(sp3268_opt_st.endPke);
        }
        public void SeriPort_DataStream_Gen(List<byte> strList, ref string data) {
            data = "";
            for (int i = 0; i < strList.Count; i++) {
                data += strList[i].ToString("X2") + (i < (strList.Count - 1) ? " " : "");
            }
        }
        /// <param name="str"></param>
        public void WriteReg(SerialPortLib serPortLib, string regAddr, string data) {
            dataStream = "";
            DataPackageInit(regAddr, data);
            SeriPort_DataStream_Gen(writePackage, ref dataStream);
            serPortLib.SerialPort_DataSend(dataStream);
        }
        /// <summary>
        /// 加载指令表：ATB表格、指令表、测试项集、OSC分频...
        /// </summary>
        public void loadTable() {
            //Step1: 清除 指令表、table等
            p3268_para_st.cmbAtbTable.Items.Clear();
            p3268_para_st.cmbFastCmd.Items.Clear();
            p3268_para_st.cmbDisplayCmd.Items.Clear();
            p3268_para_st.cmbAutoTestItem.Items.Clear();

            //...
            //Step2: 加载 表格、指令表，依次按照新顺序添加
            for (int i = 0; i < p3268Atb_table.GetLength(0); i++) {
                p3268_para_st.cmbAtbTable.Items.Add(p3268Atb_table[i, 4]);    //ATB
            }
            for (int i = 0; i < p3268FastCmd_Array.GetLength(0); i++) {
                p3268_para_st.cmbFastCmd.Items.Add(p3268FastCmd_Array[i, 0]); //FAST指令表
            }
            for (int i = 0; i < p3268_DisplayColor.GetLength(0); i++) {
                p3268_para_st.cmbDisplayCmd.Items.Add(p3268_DisplayColor[i, 0]); //FAST指令表
            }
            for (int i = 0; i < testItem_CircuitLevel.GetLength(0); i++) {
                p3268_para_st.cmbAutoTestItem.Items.Add(testItem_CircuitLevel[i, 0]);  //自动化测试项列表
            }
            //...
        }
        /// <summary>
        /// 电源通道Check: 根据界面选择的电源类型、通道ID，进行参数初始化
        /// </summary>
        private void PwrChInitPara() {
            for (int i = 0; i < p3268_para_st.pwrCh.Length; i++) {
                if (p3268_para_st.pwrCh[i]) p3268_para_st.CH = i + 1;
            }
        }

        public void OneKeyLed(SerialPortLib serPortLib, MessageBasedSession mbs) {
            PwrChInitPara();
            PowerOnOffCtrl(mbs, InstCommandLib.STATE_EN.ON);
            for (int i = 0; i < 5; i++) {
                serPortLib.SerialPort_DataSend(p3268FastCmd_Array[i, 1]);
                comFunLib.DelayTimeMs(700);
            }
            PowerOnOffCtrl(mbs, InstCommandLib.STATE_EN.OFF);
        }
        #region 二、自动化测试 Run
        /// <summary>
        /// 自动化测试：根据选择的 TestItem 进行对应的测试
        /// </summary>
        /// <param name="serPortLib"></param>
        /// <param name="mbs"></param>
        /// <param name="ID"></param>
        public void RunTest(SerialPortLib serPortLib, MessageBasedSession mbsPower, MessageBasedSession mbsCurr, int ID) {
            dataList.Clear();
            comFunLib.CreatFileWriteTitle("P3268_V300", "P3268_V300_" + testItem_CircuitLevel[ID, 0], dataList, testItem_CircuitLevel[ID, 1]);
            dataList.Clear();
            switch (ID) {
                case 0:
                    chCurrVoltCmd.chCurrTest(serPortLib, mbsCurr, comFunLib, p3268_para_st.rtbLog, p3268_para_st.cbMulti0En, (int)p3268_para_st.nudReadInstDelay.Value);
                    break;
                case 1:
                    Pam_SweepTest(serPortLib); break;   //AtbScanTest(serPortLib, mbs);
                case 2:
                case 3:
                case 4:
                    TrimTest(serPortLib, mbsPower, ID - 1);
                    break;
                default:
                    ReliabilityTest(serPortLib, ID - 5);
                    break;
            }
        }
        #endregion

        #region 三、测试项条例：快速指令|ATB|TRIM|VBG|LDO|预驱动电压|行钳位电压|列钳位电压|PLL调节范围

        #region 0. 快速命令
        string[,] p3268FastCmd_Array = new string[,] {
            { "级联3颗",    "55 AA AE 00 00 FF 00 03 00 01 FE"},
            { "行共用使能",  "55 AA A2 01 01 05 01 03 01 10 00 30 E0 00 13 01 FE" },
            { "排序包",      "55 AA A4 00 01 00 00 03 00 01 FE"},
            { "OUT_EN",     "55 AA A2 01 01 05 1A 03 01 00 00 00 00 00 01 01 FE"}, 
            { "启动工作",    "55 AA B6 00 FF 00 00 FF 00 01 FE"},
            { "拉出VBG",    "55 AA A2 01 01 05 D1 03 02 02 40 03 80 00 00 00 00 00 00 00 02 01 FE"},
            { "撤销ATB",    "55 AA A2 01 01 05 D1 03 02 00 00 00 00 00 00 00 00 00 00 00 00 01 FE"},  //顶层、CTRL均不使能
            { "电流模式",    "55 AA A2 01 01 05 CF 03 01 00 00 00 00 00 01 01 FE"},
            { "配置1扫",    "55 AA A2 01 01 05 01 03 01 10 00 30 C0 00 01 01 FE"},
            { "0P8mA配置",   "55 AA A2 01 01 05 07 03 06 10 04 10 00 20 1F 00 00 04 82 26 10 10 04 10 00 20 1F 00 00 04 82 26 10 10 04 10 00 20 1F 00 00 04 82 26 10 01 FE"},
            { "1P6mA配置",   "55 AA A2 01 01 05 07 03 06 10 04 10 00 20 3F 00 00 04 82 26 10 10 04 10 00 20 3F 00 00 04 82 26 10 10 04 10 00 20 3F 00 00 04 82 26 10 01 FE"},
            { "3P2mA配置",   "55 AA A2 01 01 05 07 03 06 10 04 10 00 20 7F 00 00 04 82 26 20 10 04 10 00 20 7F 00 00 04 82 26 20 10 04 10 00 20 7F 00 00 04 82 26 20 01 FE"},
            { "6P4mA配置",   "55 AA A2 01 01 05 07 03 06 10 04 10 00 20 FF 00 00 04 82 26 40 10 04 10 00 20 FF 00 00 04 82 26 40 10 04 10 00 20 FF 00 00 04 82 26 40 01 FE"},
            { "12P8mA配置",  "55 AA A2 01 01 05 07 03 06 10 04 10 00 20 FF 00 00 04 82 26 40 10 04 10 00 20 FF 00 00 04 82 26 40 10 04 10 00 20 FF 00 00 04 82 26 40 01 FE"},
            { "PAM_127",    "55 AA A2 01 01 05 00 03 01 10 00 00 7F 00 00 01 FE"},
            { "PAM_256",    "55 AA A2 01 01 05 00 03 01 10 00 00 FF 00 00 01 FE"},

        };
        string[,] p3268_DisplayColor = new string[,]
        {
            { "红色","55 AA AA 80 00 F1 16 03 00 01 FE" },
            { "绿色","55 AA AA 80 00 F2 16 03 00 01 FE" },
            { "蓝色","55 AA AA 80 00 F3 16 03 00 01 FE" },
            { "白色","55 AA AA FF FF F4 16 03 00 01 FE" }
        };
        string[] p3268_1P6mA = new string[]
        {
            "55 AA A2 01 01 05 07 03 01 10 04 10 00 20 3E 01 FE",

        };

        public void FastCmdCfg(SerialPortLib serPortLib, int ID) {
            serPortLib.SerialPort_DataSend(p3268FastCmd_Array[ID, 1]);
            comFunLib.DelayTimeMs(500);
        }
        public void DisplayColourCfg(SerialPortLib serPortLib, int ID) {
            serPortLib.SerialPort_DataSend(p3268_DisplayColor[ID, 1]);
            comFunLib.DelayTimeMs(500);
        }
        public void PowerOnOffCtrl(MessageBasedSession mbs, InstCommandLib.STATE_EN state) {  //InstCommandLib.STATE_EN.ON
            if (p3268_para_st.cbPowerEn.Checked) {
                if (p3268_para_st.rbKeyPwrEn.Checked) {
                    instCmdLib.KeyPowerOutPutChEn(mbs, (InstCommandLib.POWER_CH_EN)p3268_para_st.CH, state);
                }
                if (p3268_para_st.rbGppPwrEn.Checked) {
                    instCmdLib.GuWeiPowerOutputChEn(mbs, (InstCommandLib.POWER_CH_EN)p3268_para_st.CH, state);
                }
                if (p3268_para_st.rbItechPwrEn.Checked) {
                    instCmdLib.ItechPowerOutputEn(mbs, (InstCommandLib.POWER_CH_EN)p3268_para_st.CH, state);
                }
                comFunLib.DelayTimeMs((double)(2 * p3268_para_st.nudReadInstDelay.Value));
            }
        }
        #endregion

        #region 1. ATB test
        string[,] p3268Atb_table = new string[,] {
            //TOP_ATB地址    目标ATB地址      目标ATB名称      
            { "27","0013",  "27","0013",    "LDO_OUT"},
            { "27","0023",  "27","0023",    "LDO_TIEL1"},
            { "27","0033",  "27","0033",    "LDO_TIEL2"},
            { "27","0043",  "27","0043",    "LDO_VFBI"},
            { "27","0053",  "27","0053",    "LDO_TIEL3"},
            { "27","0063",  "27","0063",    "LDO_VREF"},
            { "27","0073",  "27","0073",    "LDO_TIEL4"},
            { "27","0005",  "26","0008",    "OSC_AI_2U_Voltage"},
            { "27","0005",  "26","0010",    "OSC_Fosc_OUT"},
            { "27","0005",  "26","0018",    "OSC_VCOMP2"},
            { "27","0005",  "26","0020",    "OSC_VCOMP1"},
            { "27","0005",  "26","0028",    "OSC_VRAMP2"},
            { "27","0005",  "26","0030",    "OSC_VRAMP1"},
            { "27","0005",  "26","0038",    "OSC_VREF_OSC"},
            { "27","0007",  "27","0007",    "EFU_HIGH_Z"},
            { "27","0087",  "27","0087",    "EFU_EFUSE0"},
            { "27","0507",  "27","0507",    "EFU_EFUSE9"},
            { "27","0987",  "27","0987",    "EFU_EFUSE18"},
            { "27","0009",  "0C","8208",    "DRV_TIEL"},
            { "27","0009",  "0C","8210",    "DRV_STB_LOOP"},
            { "27","0009",  "0C","8218",    "DRV_MISSION_LOOP"},
            { "27","0009",  "0C","8220",    "DRV_LDMOS_GATE"},
            { "27","0009",  "0C","8228",    "DRV_QS_VGATE"},
            { "27","0009",  "0C","8230",    "DRV_QS_VGATE1"},
            { "27","0009",  "0C","8238",    "DRV_QS_VGATE3"},
            { "27","000B",  "26","0001",    "GCC_TIEL"},
            { "27","000B",  "26","0002",    "GCC_LOWKNEE_VREF"},
            { "27","000B",  "26","0003",    "GCC_PAM_OP_OUT"},
            { "27","000B",  "26","0004",    "GCC_GCC_VBIASP"},
            { "27","000B",  "26","0005",    "GCC_LOOP3"},
            { "27","000B",  "26","0006",    "GCC_LOOP2"},
            { "27","000B",  "26","0007",    "GCC_LOOP1"},
            { "27","000F",  "26","0200",    "BG_VBG12"},
            { "27","000F",  "26","0400",    "BG_VREF_FBH"},
            { "27","000F",  "26","0600",    "BG_OVD_VREF"},
            { "27","000F",  "26","0800",    "BG_VREF_FBL"},
            { "27","000F",  "26","0A00",    "BG_IPAT1p5u"},
            { "27","000F",  "26","0C00",    "BG_VBP"},
            { "27","000F",  "26","0E00",    "BG_VBE3"},
        };

        public void AtbDebug(SerialPortLib serPortLib) {
            WriteReg(serPortLib, p3268Atb_table[p3268_para_st.cmbAtbTable.SelectedIndex, 0], p3268Atb_table[p3268_para_st.cmbAtbTable.SelectedIndex, 1]);
            comFunLib.DelayTimeMs(1000);
            WriteReg(serPortLib, p3268Atb_table[p3268_para_st.cmbAtbTable.SelectedIndex, 2], p3268Atb_table[p3268_para_st.cmbAtbTable.SelectedIndex, 3]);
        }
        public void AtbScanTest(SerialPortLib serPortLib, MessageBasedSession mbs) {
            for (int i = 0; i < p3268Atb_table.GetLength(0); i++) {
                if (p3268_para_st.stop) break;
                WriteReg(serPortLib, p3268Atb_table[i, 0], p3268Atb_table[i, 1]);
                comFunLib.DelayTimeMs((double)p3268_para_st.nudReadInstDelay.Value);
                WriteReg(serPortLib, p3268Atb_table[i, 2], p3268Atb_table[i, 3]);
                comFunLib.DelayTimeMs((double)(2 * p3268_para_st.nudReadInstDelay.Value));
                if (p3268_para_st.cbMulti0En.Checked) {
                    instCmdLib.ReadMulti(mbs, ref p3268_para_st.data);
                }
                dataList.Add(p3268Atb_table[i, 4]);
                dataList.Add(p3268_para_st.data.ToString("F3"));
                comFunLib.WriteDataToTxt(dataList);
                dataList.Clear();
            };
        }
        #endregion

        #region 2. Trim |VBG|LDO
        string[,] trimCfg = new string[,] {
            { "VBG","1F" },
            { "LDO","0E" },  //默认值为：0165，bit[5:3]=000~111;   0145~017D: step: 0x0008
            { "GCC","20" },
            { "OSC","20" },
        };
        public void TrimCode(SerialPortLib serPortLib, int ID, string data) {
            //Step1: 调节 code
            WriteReg(serPortLib, trimCfg[ID, 1], data);
            comFunLib.DelayTimeMs(100);
            //Step2: Trim 使能
            //WriteReg(serPortLib, "21", "00D8"); //trim 值每变化一次，都需要配置生效，这样会比较安全，防止误配置
        }
        public int GetTrimTemp(int ID, int code) {
            int temp = 0;
            switch (ID) {
                case 0:
                    cnt = 32;
                    temp = 0 + 1 * code;
                    break;
                case 1:
                    cnt = 8;
                    temp = 0x0145 + 8 * code;
                    break;
                case 2:
                    cnt = 32;
                    temp = 0x7F00 + 1 * code;
                    break;
                case 3:
                    cnt = 256;
                    temp = (int)p3268_para_st.nudGccCode.Value + 0x100 * code;
                    break;
                default: break;
            }
            return temp;
        }
        public void TrimTest(SerialPortLib serPortLib, MessageBasedSession mbs, int ID) {
            //Step1: 获取调节的范围
            GetTrimTemp(ID, 0);
            //Step2: code 调节
            for (int i = 0; i < cnt; i++) {
                if (p3268_para_st.stop) break;
                WriteReg(serPortLib, trimCfg[ID, 1], GetTrimTemp(ID, i).ToString("X2"));
                comFunLib.DelayTimeMs((double)p3268_para_st.nudReadInstDelay.Value);
                dataList.Add(i.ToString());
                if (p3268_para_st.cbMulti0En.Checked) {
                    comFunLib.DelayTimeMs((double)(2 * p3268_para_st.nudReadInstDelay.Value));
                    instCmdLib.ReadMulti(mbs, ref p3268_para_st.data);
                }
                dataList.Add(p3268_para_st.data.ToString("F3"));
                comFunLib.WriteDataToTxt(dataList);
                dataList.Clear();
            };
        }

        public void Pam_SweepTest(SerialPortLib serPortLib) {
            //Step1: code 调节, 8bit扫描, 地址0x00, 从1000_0000_0000~1000_00FF_0000
            string code = "100000000000";
            UInt64 init = 0x100000000000;
            for (UInt64 i = init; i <= 0x100000FF0000; i += 0x10000) {
                if (p3268_para_st.stop) break;
                code = i.ToString("X12");
                WriteReg(serPortLib, "00", code);
                comFunLib.DelayTimeMs((double)p3268_para_st.nudReadInstDelay.Value);
                dataList.Add(i.ToString());
                comFunLib.WriteDataToTxt(dataList);
                dataList.Clear();
            }
        }
        #endregion

        #endregion

        #region 四、可靠性测试条例：反复上下电|反复切换开关|...
        public string[,] reliArray = new string[,] {
            //测试项       地址  打开  关闭
            {"可靠性-OSC使能","0A","8031","8030"},
            {"可靠性-OUT使能","17","0001","0000"},
            {"可靠性-SLEEP使能","0A","8039","8031"},
            {"可靠性-TOP_ATB使能","27","000F","0000"},
            {"可靠性-VBG_OUT使能","26","0200","0000"},
            {"可靠性-CHN合并","01","00A8","0128"},     //通道合并：bit[8:7]=0, 不合并; =01, 2通道合并; 其他,4通道合并; 在2&4合并中反复切换
            {"可靠性-PAM突变","","",""},
            {"可靠性-VBG突变","1F","001A","000A"},     //VBG从默认值 16code,  向下跳变到10code(1.135V),向上跳变到26code(1.305V) LDO=1.68~1.94V
            {"可靠性-GCC突变","20","7F10","7F18"},     //GCC从默认值 16code,  向上跳变到24code
            {"可靠性-LDO突变","0E","014D","017D"},     //LDO从默认值 4code,   向上跳变到7code(最大值1.9V),向下跳变到1code(最小值1.65V)
            {"可靠性-OSC突变","20","FF10","2010"},     //OSC从默认值 127code, 向下跳变到32code, 向上跳到255code  显示亮度随频率成反比
        };

        public void ReliabilityTest(SerialPortLib serPortLib, int ID) {
            WriteReg(serPortLib, "00", "0001");
            for (int i = 0; i < p3268_para_st.testCnt; i++) {
                if (p3268_para_st.stop) break;
                comFunLib.DelayTimeMs((double)p3268_para_st.nudReadInstDelay.Value);
                WriteReg(serPortLib, reliArray[ID, 1], reliArray[ID, 2]);
                comFunLib.DelayTimeMs((double)p3268_para_st.nudReadInstDelay.Value);
                WriteReg(serPortLib, reliArray[ID, 1], reliArray[ID, 3]);
                dataList.Add(reliArray[ID, 0]);
                dataList.Add((i + 1).ToString());
                dataList.Add("PASS");
                comFunLib.WriteDataToTxt(dataList);
                dataList.Clear();
            }
        }
        #endregion

    }
}