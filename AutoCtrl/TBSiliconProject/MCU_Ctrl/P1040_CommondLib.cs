using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using NationalInstruments.Visa;
using AutoCtrl.CommonFunction;
using AutoCtrl.InstCommonCtrl;
using AutoCtrl.InstCommandCtrl;
using AutoCtrl.CommunicationProtocol;

namespace AutoCtrl.TBSiliconProject.MCU_Ctrl {
    public class P1040_CommondLib {
        //*************** 指令类型列表 ****************************
        /*CMD_TYPE        指令描述*/
        //  0x00	      广播写模式
        //  0x01	      非广播写模式
        //  0x02	      写数据模式
        //  0x03	      排序模式
        //  0x04	      广播读模式
        //  0x05	      非广播读模式
        //  0x06	      帧同步模式
        //  0x07	      CRC错误值使能位，用于人为下发错误CRC 
        //  0x08	      错误命令指令
        //  0x09	      级联芯片个数配置指令
        //  0x0A	      FB_1040使能，配置FB_1040时需先下此指令
        //  0x0B	      Normal_1040使能，切回普通1040需下此指令
        //  0x0C	      FB调节模块开关及配置指令
        //  0x0D	      帧频调节指令

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
        public SP1040_OPT_ST sp1040_opt_st = new SP1040_OPT_ST();
        public P1040_PARA_ST p1040_para_st = new P1040_PARA_ST();
        public CommonFunctionLib comFunLib = new CommonFunctionLib();
        public InstCommandLib instCmdLib = new InstCommandLib();
        public InstCommonCtrlLib instCtrlLib = new InstCommonCtrlLib();
        public string dataStream = "";
        public int cnt;
        public List<string> dataList = new List<string>();
        public struct P1040_PARA_ST {
            public ComboBox cmbCmdType;
            public ComboBox cmbAtbTable;
            public ComboBox cmbFastCmd;
            public ComboBox cmbOscDivCmd;
            public ComboBox cmbAutoTestItem;
            public TextBox tbP1040_RegAddr;
            public TextBox tbP1040_ValueCfg;
            public RadioButton rbKeyPwrEn;
            public RadioButton rbGppPwrEn;
            public RadioButton rbItechPwrEn;
            public CheckBox cbPowerEn;
            public CheckBox cbMulti0En;
            public CheckBox cbMulti1En;
            public NumericUpDown nudGccCode;
            public NumericUpDown nudReadInstDelay;
            public string chipCnt;
            public double data;
            public bool stop;
            public bool[] pwrCh;
            public int CH;
            public int testCnt;
        }
        public struct SP1040_OPT_ST {
            public List<byte> headPke;         //包头2*8bit：AA、55
            public List<byte> cmdType;         //命令类型：0x00~0x0C, 见上表
            public List<byte> fillBit;         //填充位：0x00~0x05
            public List<byte> vsAll;           //VS模式：用于选择是否每个Vsync周期都发指令, 0xFF为每个周期都发, 0x01为只发一次
            public List<byte> chipID;          //芯片ID: 非广播模式下的芯片ID
            public List<byte> regAddr;         //起始地址：0x00~0x3F, 寄存器起始地址
            public List<byte> dataLength;      //数据长度：0x00~0x3F, 写入数据的长度
            public List<byte> regValue;        //数据位：[15:0] 16bit为一数据
            public List<byte> stopPke;         //包尾2*8bit：55、AA
        }

        public string[,] testItem_CircuitLevel = new string[,] {
            {"电路级-ATB_Test","ATB_Name\tVolt"},
            {"电路级-VBG_Trim","VBG_code\tVolt"},
            {"电路级-LDO_Trim","LDO_Code\tVolt"},
            {"电路级-GCC_Trim","GCC_Code\tCurr"},
            {"电路级-OSC_Trim","OSC_Code\tFreq"},
            {"可靠性-OSC使能",""},
            {"可靠性-OUT使能",""},
            {"可靠性-SLEEP使能",""},
            {"可靠性-TOP_ATB使能",""},
            {"可靠性-VBG_OUT使能",""},
            {"可靠性-CHN合并",""},
            {"可靠性-PAM突变",""},
            {"可靠性-VBG突变",""},
            {"可靠性-GCC突变",""},
            {"可靠性-LDO突变",""},
            {"可靠性-OSC突变",""},
        };

        #region 一、公共函数：WriteReg|数据生成|加载指令表|电源初始化
        /// <summary>
        /// 生成：寄存器&数据 数据流
        /// </summary>
        public void RegAddrDataGenerator(string regAddr, string data) {
            //Step1: 转换寄存器地址模式
            byte reg = Convert.ToByte(regAddr, 16);
            sp1040_opt_st.regAddr.Add(reg);
            int value = Convert.ToInt16(data, 16);
            //Step2: 生成-寄存器配置值-数据流  (此处支持单一寄存器值&多地址序列值)
            int dataLen = 2;
            for (int i = 0; i < dataLen; i++) {
                byte temp = (byte)((value >> (dataLen - 1 - i) * 8) & 0xff);
                sp1040_opt_st.regValue.Add(temp);
            }
        }
        /// <summary>
        /// 生成串口协议：非广播写-操作, 命令数据流
        /// </summary>
        /// <param name="regAddr"></param>
        /// <param name="data"></param>
        public void DataPackageInit(string regAddr, string data) {
            writePackage.Clear();
            sp1040_opt_st.headPke = new List<byte> { 0xAA, 0x55 };
            sp1040_opt_st.cmdType = new List<byte> { (byte)p1040_para_st.cmbCmdType.SelectedIndex };
            sp1040_opt_st.fillBit = new List<byte> { 0x00 };
            sp1040_opt_st.vsAll = new List<byte> { 0x01 };
            sp1040_opt_st.chipID = new List<byte> { 0x00 };
            sp1040_opt_st.regAddr = new List<byte> { };
            sp1040_opt_st.dataLength = new List<byte> { 0x00 };
            sp1040_opt_st.regValue = new List<byte> { };
            sp1040_opt_st.stopPke = new List<byte> { 0x55, 0xAA };
            RegAddrDataGenerator(regAddr, data);
            writePackage.AddRange(sp1040_opt_st.headPke);
            writePackage.AddRange(sp1040_opt_st.cmdType);
            writePackage.AddRange(sp1040_opt_st.fillBit);
            writePackage.AddRange(sp1040_opt_st.vsAll);
            writePackage.AddRange(sp1040_opt_st.chipID);
            writePackage.AddRange(sp1040_opt_st.regAddr);
            writePackage.AddRange(sp1040_opt_st.dataLength);
            writePackage.AddRange(sp1040_opt_st.regValue);
            writePackage.AddRange(sp1040_opt_st.stopPke);
        }

        /// <summary>
        /// 生成串口协议：字符串命令
        /// </summary>
        /// <param name="strList"></param>
        /// <param name="data"></param>
        public void SeriPort_DataStream_Gen(List<byte> strList, ref string data) {
            data = "";
            for (int i = 0; i < strList.Count; i++) {
                data += strList[i].ToString("X2") + (i < (strList.Count - 1) ? " " : "");
            }
        }

        /// <summary>
        /// 界面操作：配置寄存器函数
        /// </summary>
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
            p1040_para_st.cmbAtbTable.Items.Clear();
            p1040_para_st.cmbFastCmd.Items.Clear();
            p1040_para_st.cmbOscDivCmd.Items.Clear();
            p1040_para_st.cmbAutoTestItem.Items.Clear();

            //...
            //Step2: 加载 表格、指令表，依次按照新顺序添加
            for (int i = 0; i < p1040Atb_table.GetLength(0); i++) {
                p1040_para_st.cmbAtbTable.Items.Add(p1040Atb_table[i, 4]);    //ATB
            }
            for (int i = 0; i < p1040FastCmd_Array.GetLength(0); i++) {
                p1040_para_st.cmbFastCmd.Items.Add(p1040FastCmd_Array[i, 0]); //FAST指令表
            }
            for (int i = 0; i < p1040OscDiv_Array.GetLength(0); i++) {
                p1040_para_st.cmbOscDivCmd.Items.Add(p1040OscDiv_Array[i, 0]);  //OSC指令表
            }
            for (int i = 0; i < testItem_CircuitLevel.GetLength(0); i++) {
                p1040_para_st.cmbAutoTestItem.Items.Add(testItem_CircuitLevel[i, 0]);  //自动化测试项列表
            }
            //...
        }
        /// <summary>
        /// 电源通道Check: 根据界面选择的电源类型、通道ID，进行参数初始化
        /// </summary>
        private void PwrChInitPara() {
            for (int i = 0; i < p1040_para_st.pwrCh.Length; i++) {
                if (p1040_para_st.pwrCh[i]) p1040_para_st.CH = i + 1;
            }
        }
        #endregion

        #region 二、自动化测试 Run
        /// <summary>
        /// 自动化测试：根据选择的 TestItem 进行对应的测试
        /// </summary>
        /// <param name="serPortLib"></param>
        /// <param name="mbs"></param>
        /// <param name="ID"></param>
        public void RunTest(SerialPortLib serPortLib, MessageBasedSession mbs, int ID) {
            dataList.Clear();
            comFunLib.CreatFileWriteTitle("P1040_V100", "P1040_V100_" + testItem_CircuitLevel[ID, 0], dataList, testItem_CircuitLevel[ID, 1]);
            dataList.Clear();
            switch (ID) {
                case 0:
                    AtbScanTest(serPortLib, mbs);
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                    TrimTest(serPortLib, mbs, ID - 1);
                    break;
                default:
                    ReliabilityTest(serPortLib, ID - 5);
                    break;
            }
        }
        #endregion

        #region 三、测试项条例：快速指令|ATB|TRIM|CURR

        #region 0. 快速命令
        string[,] p1040FastCmd_Array = new string[,] {
            { "解锁寄存器",  "AA 55 00 00 01 00 00 00 55 01 55 AA" },
            { "级联N颗",    "AA 55 09 03 55 AA"},      //已在OneKeyLed函数中做修正,对界面实际级联的颗数进行更新
            { "撤销ATB",    "AA 55 00 00 01 00 26 01 00 00 00 00 55 AA"},
            { "帧同步模式",  "AA 55 00 00 01 00 04 00 00 02 55 AA"},
            { "帧同步命令",  "AA 55 06 01 FF 00 00 00 AA 55 55 AA"},
            { "灰度减半",   "AA 55 00 02 FF 00 30 07 01 00 01 00 01 00 01 00 01 00 01 00 01 00 01 00 55 AA"},
            { "OUT_EN",    "AA 55 00 00 01 00 17 00 00 01 55 AA"},
            { "Trim使能",   "AA 55 00 03 FF 00 21 00 00 D8 55 AA"},
            { "Moni_OSC",  "AA 55 00 00 01 00 25 00 00 01 55 AA" },
        };
        string[,] p1040OscDiv_Array = new string[,] {
            { "OSC_16分频", "AA 55 01 00 01 00 06 00 00 07 55 AA"},
            { "OSC_14分频", "AA 55 01 00 01 00 06 00 00 06 55 AA"},
            { "OSC_12分频", "AA 55 01 00 01 00 06 00 00 05 55 AA"},
            { "OSC_10分频", "AA 55 01 00 01 00 06 00 00 04 55 AA"},
            { "OSC_8分频",  "AA 55 01 00 01 00 06 00 00 03 55 AA"},
            { "OSC_6分频",  "AA 55 01 00 01 00 06 00 00 02 55 AA"},
            { "OSC_4分频",  "AA 55 01 00 01 00 06 00 00 01 55 AA"},
            { "OSC_2分频",  "AA 55 01 00 01 00 06 00 00 00 55 AA"},
            { "CKI不倍频",  "AA 55 01 00 01 00 0A 00 80 35 55 AA"},
            { "CKI倍频",   "AA 55 01 00 01 00 0A 00 80 37 55 AA"},
        };
        public void FastCmdCfg(SerialPortLib serPortLib, int ID) {
            if (ID == 1) {
                p1040FastCmd_Array[ID, 1] = "AA 55 09 " + p1040_para_st.chipCnt + " 55 AA";
            }
            serPortLib.SerialPort_DataSend(p1040FastCmd_Array[ID, 1]);
            comFunLib.DelayTimeMs(500);
        }
        public void OscDivCfg(SerialPortLib serPortLib, int ID) {
            serPortLib.SerialPort_DataSend(p1040OscDiv_Array[ID, 1]);
            comFunLib.DelayTimeMs(500);
        }
        public void PowerOnOffCtrl(MessageBasedSession mbs, InstCommandLib.STATE_EN state) {  //InstCommandLib.STATE_EN.ON
            if (p1040_para_st.cbPowerEn.Checked) {
                if (p1040_para_st.rbKeyPwrEn.Checked) {
                    instCmdLib.KeyPowerOutPutChEn(mbs, (InstCommandLib.POWER_CH_EN)p1040_para_st.CH, state);
                }
                if (p1040_para_st.rbGppPwrEn.Checked) {
                    instCmdLib.GuWeiPowerOutputChEn(mbs, (InstCommandLib.POWER_CH_EN)p1040_para_st.CH, state);
                }
                if (p1040_para_st.rbItechPwrEn.Checked) {
                    instCmdLib.ItechPowerOutputEn(mbs, (InstCommandLib.POWER_CH_EN)p1040_para_st.CH, state);
                }
                comFunLib.DelayTimeMs((double)(2 * p1040_para_st.nudReadInstDelay.Value));
            }
        }
        public void OneKeyLed(SerialPortLib serPortLib, MessageBasedSession mbs, string chipCnt) {
            PwrChInitPara();
            PowerOnOffCtrl(mbs, InstCommandLib.STATE_EN.ON);
            for (int i = 0; i < p1040FastCmd_Array.GetLength(0) - 2; i++) {
                if (i == 1) {
                    p1040FastCmd_Array[i, 1] = "AA 55 09 " + chipCnt + " 55 AA";
                }
                serPortLib.SerialPort_DataSend(p1040FastCmd_Array[i, 1]);
                comFunLib.DelayTimeMs(700);
            }
            PowerOnOffCtrl(mbs, InstCommandLib.STATE_EN.OFF);
        }

        #endregion

        #region 1. ATB test
        string[,] p1040Atb_table = new string[,] {
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
            WriteReg(serPortLib, p1040Atb_table[p1040_para_st.cmbAtbTable.SelectedIndex, 0], p1040Atb_table[p1040_para_st.cmbAtbTable.SelectedIndex, 1]);
            comFunLib.DelayTimeMs(1000);
            WriteReg(serPortLib, p1040Atb_table[p1040_para_st.cmbAtbTable.SelectedIndex, 2], p1040Atb_table[p1040_para_st.cmbAtbTable.SelectedIndex, 3]);
        }
        public void AtbScanTest(SerialPortLib serPortLib, MessageBasedSession mbs) {
            for (int i = 0; i < p1040Atb_table.GetLength(0); i++) {
                if (p1040_para_st.stop) break;
                WriteReg(serPortLib, p1040Atb_table[i, 0], p1040Atb_table[i, 1]);
                comFunLib.DelayTimeMs((double)p1040_para_st.nudReadInstDelay.Value);
                WriteReg(serPortLib, p1040Atb_table[i, 2], p1040Atb_table[i, 3]);
                comFunLib.DelayTimeMs((double)(2 * p1040_para_st.nudReadInstDelay.Value));
                if (p1040_para_st.cbMulti0En.Checked) {
                    instCmdLib.ReadMulti(mbs, ref p1040_para_st.data);
                }
                dataList.Add(p1040Atb_table[i, 4]);
                dataList.Add(p1040_para_st.data.ToString("F3"));
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
                    temp = (int)p1040_para_st.nudGccCode.Value + 0x100 * code;
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
                if (p1040_para_st.stop) break;
                WriteReg(serPortLib, trimCfg[ID, 1], GetTrimTemp(ID, i).ToString("X2"));
                comFunLib.DelayTimeMs((double)p1040_para_st.nudReadInstDelay.Value);
                dataList.Add(i.ToString());
                if (p1040_para_st.cbMulti0En.Checked) {
                    comFunLib.DelayTimeMs((double)(2 * p1040_para_st.nudReadInstDelay.Value));
                    instCmdLib.ReadMulti(mbs, ref p1040_para_st.data);
                }
                dataList.Add(p1040_para_st.data.ToString("F3"));
                comFunLib.WriteDataToTxt(dataList);
                dataList.Clear();
            };
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
            for (int i = 0; i < p1040_para_st.testCnt; i++) {
                if (p1040_para_st.stop) break;
                comFunLib.DelayTimeMs((double)p1040_para_st.nudReadInstDelay.Value);
                WriteReg(serPortLib, reliArray[ID, 1], reliArray[ID, 2]);
                comFunLib.DelayTimeMs((double)p1040_para_st.nudReadInstDelay.Value);
                WriteReg(serPortLib, reliArray[ID, 1], reliArray[ID, 3]);
                dataList.Add(reliArray[ID, 0]);
                dataList.Add((i+1).ToString());
                dataList.Add("PASS");
                comFunLib.WriteDataToTxt(dataList);
                dataList.Clear();
            }
        }
        #endregion
    }
}
