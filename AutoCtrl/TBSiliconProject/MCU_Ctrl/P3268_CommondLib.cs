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

        public string cfgStrHead = "55 AA A2 01 FF 05 ";  //{头1 头2 指令类型A2(写REG) 填充位 锁定标记(FF每帧发送/其他值为总发次数) 延时周期}
        public string cfgRegAddr = "C9";                  //Reg地址
        public string chipNum = " 03";                    //芯片级联个数 & 写入数据长度  默认都是1片，每次配置一个地址的值
        public string regNum = " 01 ";                    //芯片级联个数 & 写入数据长度  默认都是1片，每次配置一个地址的值
        public string cfgRegValue = "04 2C";              //按照48bit十六进制写入
        public string cfgStrEnd = " 01 FE";               //结束符
        public string cfgTrimCommon = "A3 B2 C6 D8 ";     //C9地址Trim公共格式
        public string cfgEfuseCommon = "00 00 00 00 ";
        //级联个数、排序包
        public string linkCntCfg = "55 AA AE 00 00 FF 00 03 00 01 FE"; //03代表当前的级联芯片数，其他所有命令的级联芯片位失效不使用
        public string sortCfg = "55 AA A4 00 01 00 00 03 00 01 FE";    //排序包命令
        public string vbgGccTrim = "55 AA A2 01 FF 05 C9 01 01 A3 B2 C6 D8 04 20 01 FE";  //GCC_VBG 04 20(0100-0010-1100)
        public string cfgEfuseDo = "55 AA A2 01 FF 05 C8 01 01 00 00 00 00 84 20 01 FE";  //GCC_VBG 04 20(0100-0010-1100)
        public double vbgCode = 0x2C;
        public double vbgGccCode = 0x420;
        public int delayTimeMs = 1000;
        public bool stop3268;
        public List<string> list = new List<string>();
        public P3268_ST p3268_st = new P3268_ST();
        public CommonFunctionLib comFunLib = new CommonFunctionLib();
        public InstCommandLib instCmdLib = new InstCommandLib();
        public InstCommonCtrlLib instCtrlLib = new InstCommonCtrlLib();
        public SerialPortLib serPortLib = new SerialPortLib();
        public struct P3268_ST {
            public string cfgReg;
            public string testMess;
            public double readData;
            public double[] vbgDefault;
            public double vbgTrim;
            public double[] chiSumDefault;
            public double chCurrent;
            public double chiSumTrim;
            public double vbgTarget;
            public double vbgAccuracy;
            public double chiTarget;
            public double chiAccuracy;
            public double delayTimeMs;
            public bool judjeStatus;
            public bool chopOnoff;
            public bool ldoSysCpll;
            public string testMessage;
            public string chipRegNum;
            public string chipID;
            public RichTextBox rtbChipSelOk;
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
        public void P3268_ParaInit() {
            p3268_st.cfgReg = "";
            p3268_st.readData = 0;
            p3268_st.vbgDefault = new double[3] { 0, 0, 0 };
            p3268_st.vbgTrim = 0;
            p3268_st.chiSumDefault = new double[3] { 0, 0, 0 };
            p3268_st.chiSumTrim = 0;
        }
        #region 3. 一键筛片
        public void RecordTrimResults(string efuseCode) {
            list.Add(p3268_st.testMessage.Split('_')[0]);  //chip type
            list.Add(p3268_st.chipID.Trim());              //chip num
            list.Add(p3268_st.vbgDefault[0].ToString("F3"));    //直接上电点屏读取的值
            list.Add(p3268_st.vbgDefault[1].ToString("F3"));    //配置默认值0420后读取的值
            list.Add(p3268_st.vbgTrim.ToString("F3"));          //Trim后读取的值
            list.Add(p3268_st.chiSumDefault[0].ToString("F3")); //直接上电点屏读取的值
            list.Add(p3268_st.chiSumDefault[1].ToString("F3")); //配置默认值0420后读取的值
            list.Add(p3268_st.chiSumTrim.ToString("F4"));       //Trim后读取的值
            list.Add(efuseCode);  //Efuse Code
            list.Add(p3268_st.vbgDefault[2].ToString("F3"));    //再次上电点屏后VBG结果
            list.Add(p3268_st.chiSumDefault[2].ToString("F3")); //再次上电点屏后CHI结果
            list.Add(p3268_st.judjeStatus ? "PASS" : "FAIL");           //筛片状态
            p3268_st.rtbChipSelOk.AppendText(
                p3268_st.chipID.Trim() + ", "
                + p3268_st.vbgDefault[1].ToString("F3") + ", "
                + p3268_st.vbgDefault[2].ToString("F3") + ", "
                + p3268_st.vbgTrim.ToString("F3") + ", "
                + p3268_st.chiSumDefault[1].ToString("F3") + ", "
                + p3268_st.chiSumDefault[2].ToString("F3") + ", "
                + p3268_st.chiSumTrim.ToString("F3") + ", "
                + efuseCode + ", "
                + (p3268_st.judjeStatus ? "PASS" : "FAIL") + "\n");
            p3268_st.rtbChipSelOk.ScrollToCaret();
        }
        public bool DefaultStateJudge() {
            //1、直接读取默认值VBG、CHI_SUM的值，进行逻辑判断，若不满足直接FAIL
            instCmdLib.ReadMulti(instCtrlLib.mbsMulti0, ref p3268_st.vbgDefault[0]);
            comFunLib.DelayTimeMs(1000);   //电流稳定需要一定的时间
            instCmdLib.ReadMulti(instCtrlLib.mbsMulti1, ref p3268_st.chiSumDefault[0]);
            bool state = ((p3268_st.vbgDefault[0] > p3268_st.vbgTarget + 0.05 || p3268_st.vbgDefault[0] < p3268_st.vbgTarget - 0.05) || (p3268_st.chiSumDefault[0] < p3268_st.chiTarget - 10 || p3268_st.chiSumDefault[0] > p3268_st.chiTarget + 5));
            return state;
        }
        public void TrimPwrUpStateJudge() {
            //Trim，并烧写完成之后，再次上电读取默认值进行判断
            instCmdLib.ReadMulti(instCtrlLib.mbsMulti0, ref p3268_st.vbgDefault[2]);
            comFunLib.DelayTimeMs(1000);   //电流稳定需要一定的时间
            instCmdLib.ReadMulti(instCtrlLib.mbsMulti1, ref p3268_st.chiSumDefault[2]);
        }

        public void AfterEfuseCheck(string efuseStr) {
            TrimPwrUpStateJudge();
            p3268_st.judjeStatus = ((p3268_st.vbgDefault[2] > (p3268_st.vbgTarget - p3268_st.vbgAccuracy * 2)) && (p3268_st.vbgDefault[2] < (p3268_st.vbgTarget + p3268_st.vbgAccuracy * 2))) || ((p3268_st.chiSumDefault[2] > (p3268_st.chiTarget - p3268_st.chiAccuracy * 2) && p3268_st.chiSumDefault[2] > (p3268_st.chiTarget + p3268_st.chiAccuracy * 2)));
            RecordTrimResults(efuseStr.Replace(" ", ""));
        }

        public void VbgGccAdjust(bool isVbgEn, bool isGccEn, int delayMs, ref string trimCode, ref string efuseCode) {
            int tempCode = 0x0420;
            comFunLib.DelayTimeMs(delayMs);
            instCmdLib.ReadMulti(instCtrlLib.mbsMulti0, ref p3268_st.vbgDefault[1]);  //读电压
            if (isVbgEn) {
                //2、首先配置默认值 0420读取VBG电压, 判断是否在精度区间 1.2375~1.2625V
                if (p3268_st.vbgDefault[1] > (p3268_st.vbgTarget - p3268_st.vbgAccuracy) && p3268_st.vbgDefault[1] < (p3268_st.vbgTarget + p3268_st.vbgAccuracy)) {
                    if (p3268_st.vbgDefault[1] > p3268_st.vbgTarget + 0.005 && p3268_st.vbgDefault[1] <= p3268_st.vbgTarget + 0.010) {
                        tempCode += 2;
                    }
                    if (p3268_st.vbgDefault[1] > p3268_st.vbgTarget + 0.000 && p3268_st.vbgDefault[1] <= p3268_st.vbgTarget + 0.005) {
                        tempCode += 1;
                    }
                    if (p3268_st.vbgDefault[1] > p3268_st.vbgTarget - 0.005 && p3268_st.vbgDefault[1] <= p3268_st.vbgTarget + 0.000) {
                        tempCode -= 1;
                    }
                    if (p3268_st.vbgDefault[1] > p3268_st.vbgTarget - 0.010 && p3268_st.vbgDefault[1] <= p3268_st.vbgTarget - 0.005) {
                        tempCode -= 2;
                    }
                }
            }
            if (isGccEn) {
                //3、校准GCC_IFIX
                instCmdLib.ReadMulti(instCtrlLib.mbsMulti1, ref p3268_st.chiSumDefault[1]);  //读取默认电流
                if (p3268_st.chiSumDefault[1] > p3268_st.chiTarget + 8 && p3268_st.chiSumDefault[1] <= p3268_st.chiTarget + 12) {
                    tempCode += 0xc0;    //增加3code 
                }
                if (p3268_st.chiSumDefault[1] > p3268_st.chiTarget + 4 && p3268_st.chiSumDefault[1] <= p3268_st.chiTarget + 8) {
                    tempCode += 0x80;    //增加2code 
                }
                if (p3268_st.chiSumDefault[1] > p3268_st.chiTarget + 0 && p3268_st.chiSumDefault[1] <= p3268_st.chiTarget + 4) {
                    tempCode += 0x40;    //增加1code
                }
                if (p3268_st.chiSumDefault[1] > p3268_st.chiTarget - 4 && p3268_st.chiSumDefault[1] <= p3268_st.chiTarget + 0) {
                    tempCode -= 0x40;    //减小1code;
                }
                if (p3268_st.chiSumDefault[1] > p3268_st.chiTarget - 8 && p3268_st.chiSumDefault[1] <= p3268_st.chiTarget - 4) {
                    tempCode -= 0x80;    //减小2code;
                }
                if (p3268_st.chiSumDefault[1] > p3268_st.chiTarget - 12 && p3268_st.chiSumDefault[1] <= p3268_st.chiTarget - 8) {
                    tempCode -= 0xc0;    //减小3code;
                }
            }
            //4、生成 Trim/Efuse Code
            trimCode = ("0" + tempCode.ToString("X")).Insert(2, " ");
            efuseCode = (tempCode | 0x8000).ToString("X").Insert(2, " ");
        }
        #endregion

        #region 4. 通道电流PAM线性度结果 | VBG_TRIM结果 | GCC_IFIX结果
        public void RecordCurrResults(string caseSel, int currCode, double curr) {
            list.Add(p3268_st.testMessage.Split('_')[0]);  //chip type
            list.Add(p3268_st.chipID.Trim());              //chip num
            list.Add("x.xxx");                             //直接上电点屏读取的值
            list.Add(caseSel);                                  //LowKnew Path Sel
            list.Add(currCode.ToString());                      //电流code
            list.Add(curr.ToString("F3"));                      //电流数据
            list.Add(instCmdLib.var_st.dataUnit);            //电流单位
            p3268_st.rtbChipSelOk.AppendText(
                p3268_st.chipID.Trim() + ", "
                + p3268_st.vbgDefault[0] + ", "
                + caseSel + ", "
                + currCode.ToString() + ", "
                + curr.ToString("F3") + ", "
                + instCmdLib.var_st.dataUnit + "\n");
            p3268_st.rtbChipSelOk.ScrollToCaret();
        }
        public void RecordVoltResult(double defaultVolt, int code, double trimVolt, string state) {
            list.Add(p3268_st.testMessage.Split('_')[0]);  //chip type
            list.Add(p3268_st.chipID.Trim());              //chip num
            list.Add(defaultVolt.ToString("F3"));          //读取电压默认值
            list.Add(state);          //CHOP STATE
            list.Add(code.ToString());                     //调节code
            list.Add(trimVolt.ToString("F3"));             //读取电压
            p3268_st.rtbChipSelOk.AppendText(
                p3268_st.chipID.Trim() + ", "
                + defaultVolt.ToString("F3") + ", "
                + code.ToString() + ", "
                + trimVolt.ToString("F3") + "\n");
            p3268_st.rtbChipSelOk.ScrollToCaret();
        }
        public void RecordGccIfixResult(double defaultCurr, int code, double trimCurr, string gccTop, string currData, string gccGain, string pathKnee) {
            list.Add(p3268_st.testMessage.Split('_')[0]);  //chip type
            list.Add(p3268_st.chipID.Trim());              //chip num
            list.Add(gccTop);
            list.Add(currData);
            list.Add(gccGain);
            list.Add(pathKnee);
            list.Add(defaultCurr.ToString("F3"));          //读取电流默认值
            list.Add(code.ToString());                     //调节code
            list.Add(trimCurr.ToString("F3"));             //读取电流
            p3268_st.rtbChipSelOk.AppendText(
                p3268_st.chipID.Trim() + ", "
                + defaultCurr.ToString("F3") + ", "
                + code.ToString() + ", "
                + trimCurr.ToString("F3") + "\n");
            p3268_st.rtbChipSelOk.ScrollToCaret();
        }
        #endregion

        #region 5. 创建结果路径并写入Title | 读取VBG | VBG_TRIM | LDO_TRIM | GCC_IFIX_TRIM
        public void CreatFileAndWriteTitle(string title) {
            stop3268 = false;   //初始化停止参数为 false
            //创建结果路径和文件名称
            list.Add(title);
            comFunLib.CreatFilePath(p3268_st.testMessage.Split('_')[0]);
            comFunLib.WriteResultsTitle(p3268_st.testMessage, list, CommonFunctionLib.WRITE_DATA_METHORD.FILE_APPEND);
            list.Clear();
        }

        public void ReadDefaultVbgVolt(ref double vbgDefault) {
            for (int cfgIndex = 0; cfgIndex < vbgTrimAtbCfg.Length; cfgIndex++) {
                serPortLib.SerialPort_DataSend(vbgTrimAtbCfg[cfgIndex]);
                comFunLib.DelayTimeMs(p3268_st.delayTimeMs);
            }
            //instCmdLib.ReadMulti(instCtrlLib.mbsMulti0, ref vbgDefault);  //读取VBG default电压
        }
        public void VbgTrimTest() {
            string value = "04 20";
            int CHOP_ON = 0;
            int CHOP_OFF = 1;
            string chopState = "";
            double vbgDefault = 0;
            double vbgTrim = 0;
            string title = "ChipType\tChipNum\tVBG_Default(V)\tCHOP_State\tVBG_Trim(Code)\tVBG_Volt(V)";
            CreatFileAndWriteTitle(title);
            //配置顶层ATB, VBG使能, CHOP_ON/OFF
            ReadDefaultVbgVolt(ref vbgDefault);
            if (p3268_st.chopOnoff) {
                serPortLib.SerialPort_DataSend(chopOnOff[CHOP_ON]);
                chopState = "CHOP_ON";
            }
            else {
                serPortLib.SerialPort_DataSend(chopOnOff[CHOP_OFF]);
                chopState = "CHOP_OFF";
            }
            //遍历VBG_Code, 读取VBG电压
            for (int vbgCode = 0; vbgCode <= 0x3f; vbgCode++) {
                if (stop3268) {
                    break;
                }
                string cfg = vbgCode < 16 ? "0" + vbgCode.ToString("X") : vbgCode.ToString("X");
                string cfg1 = value.Replace("20", cfg);
                p3268_st.cfgReg = cfgStrHead + "C9" + " " + p3268_st.chipRegNum + " " + cfgTrimCommon + cfg1 + cfgStrEnd;
                serPortLib.SerialPort_DataSend(p3268_st.cfgReg);
                comFunLib.DelayTimeMs(p3268_st.delayTimeMs);
                //instCmdLib.ReadMulti(instCtrlLib.mbsMulti0, ref vbgTrim);  //读取电压
                RecordVoltResult(vbgDefault, vbgCode, vbgTrim, chopState);
                comFunLib.WriteDataToTxt(list, CommonFunctionLib.WRITE_DATA_METHORD.FILE_APPEND);
                list.Clear();
            }
        }
        public void LdoRegulatorTest() {
            string valueReplace = p3268_st.ldoSysCpll ? "80" : "20";   //"F8 03"~"00 3E"
            string ldoType = p3268_st.ldoSysCpll ? "LDO_SYS" : "LDO_CPLL";
            double vbgDefault = 0;
            double ldoVolt = 0;
            string[] ldoCodeTrim = p3268_st.ldoSysCpll ? ldoSysTrimCode : ldoCpllTrimCode;
            string ldoCfg = p3268_st.ldoSysCpll ? "55 AA A2 01 FF 05 06 01 01 00 00 00 06 80 03 01 FE" : "55 AA A2 01 FF 05 17 01 01 00 00 00 00 00 20 01 FE";
            string title = "ChipType\tChipNum\tVBG_Default(V)\tLDO_Type\tLDO_Trim(Code)\tLDO_Volt(V)";
            CreatFileAndWriteTitle(title);
            //配置顶层ATB, VBG使能, 默认CHOP_ON下测试
            for (int code = 0; code < vbgTrimAtbCfg.Length; code++) {
                serPortLib.SerialPort_DataSend(vbgTrimAtbCfg[code]);
                comFunLib.DelayTimeMs(p3268_st.delayTimeMs);
            }
            instCmdLib.ReadMulti(instCtrlLib.mbsMulti0, ref vbgDefault);  //读取VBG default电压
            int length = (p3268_st.ldoSysCpll ? ldoRegulatorTrimCfg.Length - 1 : ldoRegulatorTrimCfg.Length);
            for (int cfgIndex = 0; cfgIndex < length; cfgIndex++) {
                if (!p3268_st.ldoSysCpll) {
                    if (2 == cfgIndex) { cfgIndex++; }
                }
                serPortLib.SerialPort_DataSend(ldoRegulatorTrimCfg[cfgIndex]);
                comFunLib.DelayTimeMs(p3268_st.delayTimeMs);
            }
            //遍历LDO_Code, 读取LDO电压
            for (int ldoCode = 0; ldoCode <= 0xF; ldoCode++) {
                if (stop3268) {
                    break;
                }
                serPortLib.SerialPort_DataSend(ldoCfg.Replace(valueReplace, ldoCodeTrim[ldoCode]));
                comFunLib.DelayTimeMs(p3268_st.delayTimeMs);
                instCmdLib.ReadMulti(instCtrlLib.mbsMulti0, ref ldoVolt);  //读取电压
                RecordVoltResult(vbgDefault, ldoCode, ldoVolt, ldoType);
                comFunLib.WriteDataToTxt(list, CommonFunctionLib.WRITE_DATA_METHORD.FILE_APPEND);
                list.Clear();
            }
        }
        public void GccIfixText() {
            double gccDefaultCurr = 0;
            double gccTrimCurr = 0;
            string title = "ChipType\tChipNum\tGCC_TOP_GAIN\tCURR_DATA\tGCC_GAIN\tPATH_KNEE_SEL\tGCC_Default(uA)\tGCC_Code\tGCC_Curr(uA)";
            CreatFileAndWriteTitle(title);
            for (int gccCfg = 0; gccCfg < gccIfixTrimCfg.Length; gccCfg++) {
                serPortLib.SerialPort_DataSend(gccIfixTrimCfg[gccCfg]);
                comFunLib.DelayTimeMs(p3268_st.delayTimeMs);
            }
            instCmdLib.ReadMulti(instCtrlLib.mbsMulti0, ref gccDefaultCurr);  //读取电流
            //遍历GCC_Code, 读取VBG电压
            for (int gccCode = 0; gccCode <= 0x1f; gccCode++) {
                if (stop3268) {
                    break;
                }
                int value = (gccCode << 6) | 0x0020;
                string cfg = (gccCode <= 3 ? "00" : "0") + value.ToString("X");
                string cfg1 = cfg.Insert(2, " ");
                p3268_st.cfgReg = cfgStrHead + "C9" + " " + p3268_st.chipRegNum + " " + cfgTrimCommon + cfg1 + cfgStrEnd;
                serPortLib.SerialPort_DataSend(p3268_st.cfgReg);
                comFunLib.DelayTimeMs(p3268_st.delayTimeMs);

                instCmdLib.ReadMulti(instCtrlLib.mbsMulti0, ref gccTrimCurr);  //读取电流
                RecordGccIfixResult(gccDefaultCurr, gccCode, gccTrimCurr, "0xFF", "0x07", "0x3", "0x3");
                comFunLib.WriteDataToTxt(list, CommonFunctionLib.WRITE_DATA_METHORD.FILE_APPEND);
                list.Clear();
            }
        }
        #endregion
    }
}