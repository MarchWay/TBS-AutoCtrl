using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoCtrl.CommonFunction;
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
        public string dataStream = "";
        public int cnt;
        public List<string> dataList = new List<string>();
        public struct P3268_PARA_ST {
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
        public struct SP3268_OPT_ST {
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


        public string[] singleOneKeyLed = new string[]
        {
            "55 AA A2 01 FF 05 16 01 01 40 25 92 63 00 01 01 FE",  //PLL_SEL
            "55 AA A2 01 FF 05 CF 01 01 00 00 00 00 00 01 01 FE",  //CURR_MODE
            "55 AA A2 01 FF 05 1A 01 01 00 00 00 00 00 01 01 FE"   //OUT_EN
        };
        public string[] linkOneKeyLed = new string[]
        {
            "55 AA AE 00 00 FF 00 03 00 01 FE",    //级联个数配置
            "55 AA A4 00 01 00 00 03 00 01 FE",    //排序包命令
            "55 AA A2 01 FF 05 01 03 01 10 00 30 E0 00 13 01 FE",  //行共用
            "55 AA A2 01 01 05 16 03 01 40 25 92 63 00 01 01 FE",  //GCLK配置
            "55 AA A2 04 01 05 1A 03 01 00 00 00 00 00 01 01 FE"   //通道使能
        };
        public string[] efuseDo = new string[]
        {
            "55 AA A2 01 FF 05 C8 01 01 00 00 00 00 84 2C 01 FE"   //EFUSE
            //"55 AA A8 00 FF 00 00 03 00 01 FE", //切换24BIT送数命令
        };
        public string[] ldoSysTrim = new string[]
        {
            "55 AA A2 01 FF 05 16 01 01 40 25 92 63 00 01 01 FE",
            "55 AA A2 01 FF 05 C9 01 01 A3 B2 C6 D8 03 6C 01 FE",
            "55 AA A2 01 FF 05 DF 01 01 00 00 00 00 00 02 01 FE",
            "55 AA A2 01 FF 05 D1 01 01 02 40 03 80 00 00 01 FE",
            "55 AA A2 01 FF 05 D1 01 01 01 C7 00 00 00 00 01 FE"     //LDO_SYS
        };
        public string[] gccIfixTrim = new string[]
        {
            "55 AA A2 01 FF 05 00 01 01 10 02 00 07 00 00 01 FE",    //PAM_EN&DRV_GAIN_1
            "55 AA A2 01 FF 05 06 01 01 00 00 00 06 D8 03 01 FE",    //GCC_RANGE_GAIN_1
            "55 AA A2 01 FF 05 07 01 01 10 04 90 00 10 FF 01 FE",    //GCC_TOP_1
            "55 AA A2 01 FF 05 08 01 01 00 00 00 41 26 30 01 FE",    //LOWKNEE_SEL_11
            "55 AA A2 01 FF 05 C9 01 01 A3 B2 C6 D8 07 EC 01 FE"     //GCC_IFIX_TRIM
        };
        public string[] displayColor = new string[]
        {
             "55 AA AA 00 00 F6 16 FF 00 FF FF FF FF FF FF 01 FE",  //白色&灰度
             "55 AA AA 00 00 F6 16 FF 00 FF FF 00 00 00 00 01 FE",  //红色&灰度
             "55 AA AA 00 00 F6 16 FF 00 00 00 FF FF 00 00 01 FE",  //绿色&灰度
             "55 AA AA 00 00 F6 16 FF 00 00 00 00 00 FF FF 01 FE",  //蓝色&灰度
             "55 AA AA 00 00 F6 16 FF 00 FF FF FF FF 00 00 01 FE",  //黄色&灰度
             "55 AA AA 00 00 F6 16 FF 00 00 00 FF FF FF FF 01 FE",  //青色&灰度
             "55 AA AA 00 00 F6 16 FF 00 FF FF 00 00 FF FF 01 FE"   //紫色&灰度
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
            int value = Convert.ToInt16(data, 16);
            //Step2: 生成-寄存器配置值-数据流  (此处支持单一寄存器值&多地址序列值)
            int dataLen = 6;
            for (int i = 0; i < dataLen; i++) {
                byte temp = (byte)((value >> (dataLen - 1 - i) * 8) & 0xff);
                sp3268_opt_st.regValue.Add(temp);
            }
        }
        public void DataPackageInit(string regAddr, string data) {
            writePackage.Clear();
            sp3268_opt_st.headPke = new List<byte> { 0xAA, 0x55 };
            sp3268_opt_st.cmdType = new List<byte> { (byte)p3268_para_st.cmbCmdType.SelectedIndex };
            sp3268_opt_st.fillBit = new List<byte> { 0x00 };
            sp3268_opt_st.vsAll = new List<byte> { 0x01 };
            sp3268_opt_st.chipID = new List<byte> { 0x00 };
            sp3268_opt_st.regAddr = new List<byte> { };
            sp3268_opt_st.dataLength = new List<byte> { 0x00 };
            sp3268_opt_st.regValue = new List<byte> { };
            sp3268_opt_st.stopPke = new List<byte> { 0x55, 0xAA };
            RegAddrDataGenerator(regAddr, data);
            writePackage.AddRange(sp3268_opt_st.headPke);
            writePackage.AddRange(sp3268_opt_st.cmdType);
            writePackage.AddRange(sp3268_opt_st.fillBit);
            writePackage.AddRange(sp3268_opt_st.vsAll);
            writePackage.AddRange(sp3268_opt_st.chipID);
            writePackage.AddRange(sp3268_opt_st.regAddr);
            writePackage.AddRange(sp3268_opt_st.dataLength);
            writePackage.AddRange(sp3268_opt_st.regValue);
            writePackage.AddRange(sp3268_opt_st.stopPke);
        }

        #region 3. 一键筛片

        #endregion

        #region 4. 通道电流PAM线性度结果 | VBG_TRIM结果 | GCC_IFIX结果

        #endregion

        #region 5. VBG_TRIM | LDO_TRIM | GCC_IFIX_TRIM

        #endregion
    }
}