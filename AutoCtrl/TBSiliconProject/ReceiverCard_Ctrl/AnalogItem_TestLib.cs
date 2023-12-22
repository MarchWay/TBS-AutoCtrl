using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalInstruments.Visa;
using AutoCtrl.InstCommonCtrl;
using AutoCtrl.InstCommandCtrl;
using AutoCtrl.CommonFunction;
using AutoCtrl.CommunicationProtocol;
using AutoCtrl.TBSiliconProject.DriverCommonTestItem;

namespace AutoCtrl.TBSiliconProject.DriverCommonTestItem {
    public class AnalogItem_TestLib {
        public USB_PortLib usbAnalog = new USB_PortLib();
        public CommonFunctionLib comFunLib = new CommonFunctionLib();
        public InstCommandLib instCmdLib = new InstCommandLib();
        public InstCommonCtrlLib instCommLib = new InstCommonCtrlLib();
        public MessageBasedSession mbsPower, mbsMulti;

        #region 0. 公共函数：仪器连接|获取项目名称|...
        /// <summary>
        /// 获取和仪器连接的通信接口
        /// </summary>
        /// <param name="dChipComFunLib"></param>
        public void GetInstHandle(DriverChipCommonFunctionLib dChipComFunLib) {
            if (dChipComFunLib.para_St.cbMultiSelEn.Checked) {
                instCommLib.InstrumentLink(ref mbsMulti, dChipComFunLib.para_St.tbInstMultiAddr.Text.Trim());
            }
            if (dChipComFunLib.para_St.cbPowerSelEn.Checked) {
                instCommLib.InstrumentLink(ref mbsPower, dChipComFunLib.para_St.tbInstPowerAddr.Text.Trim());
            }
        }
        /// <summary>
        /// 根据所选择的项目名称,初始化对应测试的参数
        /// </summary>
        /// <param name="dChipComFunLib"></param>
        public void GetProjectName(DriverChipCommonFunctionLib dChipComFunLib) {
            switch (dChipComFunLib.para_St.cmbProjectName.Text) {
                case "P2218_V20X":
                    dChipComFunLib.para_St.atbScan = atbTable_2218_V20X;
                    dChipComFunLib.para_St.VbgTrim = vbgTrim_2218_V20X;
                    dChipComFunLib.para_St.preDrv = preDrv_2218_V20X;
                    break;
                case "P2318_V100":
                    dChipComFunLib.para_St.atbScan = atbTable_2318_V100;
                    dChipComFunLib.para_St.VbgTrim = vbgTrim_2318_V100;
                    dChipComFunLib.para_St.preDrv = preDrv_2318_V100;
                    break;
                case "P2318R_V100":
                    dChipComFunLib.para_St.atbScan = atbTable_2318R_V100;
                    dChipComFunLib.para_St.VbgTrim = vbgTrim_2318_V100;
                    dChipComFunLib.para_St.preDrv = preDrv_2318_V100;
                    break;
                case "P2218R_V100":
                    dChipComFunLib.para_St.atbScan = atbTable_2218R_V100;
                    dChipComFunLib.para_St.VbgTrim = vbgTrim_2218R_V100;
                    dChipComFunLib.para_St.preDrv = preDrv_2218R_V100;
                    break;
                case "P2216R_V100":
                    break;
                case "P2316R_V100":
                    break;
                case "P3268_V300":
                    break;
                case "P3288_V100":
                    break;
                case "P1287_V10X":
                    break;
                default: break;
            }
        }
       /// <summary>
       /// 使用在对应项目的 ATB table 中查表法进行VBG的配置, 输入参数为ATB表格
       /// </summary>
       /// <param name="atbTable"></param>
       /// <returns></returns>
        public int LookUpVbg(string[,] atbTable) {
            int vbgID = 0;
            for (int i = 0; i < atbTable.GetLength(0); i++) {
                if (atbTable[i, 4].Contains("QS_VBG_1200M")) {
                    vbgID = i;
                    break;
                }
            }
            return vbgID;
        }
        /// <summary>
        /// 读取当前芯片的VBG电压 (所有测试项的结果中必须要有VBG电压数据)
        /// </summary>
        /// <param name="dChipComFunLib"></param>
        /// <param name="usbLib"></param>
        /// <returns></returns>
        public double GetVbgVolt(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib) {
            double volt = 0;
            int vbgID = LookUpVbg(dChipComFunLib.para_St.atbScan);
            string data0 = dChipComFunLib.DriverDataGen(6, dChipComFunLib.para_St.atbScan[vbgID, 3] + dChipComFunLib.para_St.atbScan[vbgID, 3] + dChipComFunLib.para_St.atbScan[vbgID, 3]);
            dChipComFunLib.DriverChipWriteReg(usbLib, dChipComFunLib.DriverChipRegAddrGen(dChipComFunLib.para_St.atbScan[vbgID, 2]), data0);
            comFunLib.DelayTimeMs(1000);
            if (dChipComFunLib.para_St.cbMultiSelEn.Checked) {
                instCmdLib.ReadMulti(mbsMulti, ref volt);  //读取电压
            }
            return volt;
        }
        /// <summary>
        /// 仪器初始化 & 创建文件写入title
        /// </summary>
        /// <param name="dChipComFunLib"></param>
        /// <param name="title"></param>
        public void CommonInstAndTxtInit(DriverChipCommonFunctionLib dChipComFunLib, string title) {
            comFunLib.CreatFileWriteTitle(dChipComFunLib.para_St.cmbProjectName.Text, dChipComFunLib.para_St.tbTestMessage.Text, dChipComFunLib.dataList, title);
            GetInstHandle(dChipComFunLib);
            GetProjectName(dChipComFunLib);
            dChipComFunLib.para_St.addrOfst = 0;
            dChipComFunLib.para_St.tbregOptLength.Text = "06";
        }
        public void GetPowerChEn(DriverChipCommonFunctionLib dChipComFunLib) {
            dChipComFunLib.para_St.CH = new List<int> { };
            for (int i = 0; i < dChipComFunLib.para_St.chEn.Length; i++) {
                if (dChipComFunLib.para_St.chEn[i]) {
                    dChipComFunLib.para_St.CH.Add(i + 1);   //通道ID 从1开始
                }
            }
        }
        #endregion

        #region 1. ATB 扫描测试
        //1. ATB 扫描测试--------------------------------------------------
        //2、VDD供电4.2V，使用万用表连接顶层ATB(CHN15)，点屏
        //3.0x11改0001,即关闭低功耗模式1，同时通道不使能，0x1E改0x0000，防止反复拉VBG容易触发误烧写；
        //4.顶层ATB使能，并且将VREB_GEN_ATB连接至顶层ATB，配置寄存器TOP_ATB_EN、TOP_ATB_CTRL(Addr：0x2D) = 0x0110；
        //5.顶层ATB通路选择，配置寄存器TOP_ATB_CTRL(Addr:0x2D，bit[2:0])，具体配置如下：
        //eg：VBG电压读取配置：
        //Ø TOP_ATB_CTRL、VREF_GEN_ATB(Addr：0x2D) = 0x1D10；
        //---------------------------------------------------------------
        public string[,] atbTable_2318_V100 = new[,] {
            //TOP_ATB地址    目标ATB地址      目标ATB名称      
            { "2D","0190",  "2D","0190",    "TOP_QS_OSVD_VREF" },
            { "2D","01A0",  "2D","01A0",    "TOP_QS_CHN_PREDRV_VREF"},
            { "2D","01B0",  "2D","01B0",    "TOP_QS_CHN_DEG_VREF"   },
            { "2D","01C0",  "2D","01C0",    "TOP_QS_CHN_CLAMP_VREF"},
            { "2D","01D0",  "2D","01D0",    "TOP_CPBOOST_BUF_ATB_OUT"},
            { "0E","0800",  "2D","01E0",    "TOP_PUMP_TEST"},
            { "2D","01F0",  "2D","01F0",    "TOP_TIEH"},
            { "2D","0510",  "2D","0510",    "VREF_QS_OVD_VREFA"},
            { "2D","0910",  "2D","0910",    "VREF_QS_VREF_LOWKNEE_A"},
            { "2D","0D10",  "2D","0D10",    "VREF_V2I_LOOP"},
            { "2D","1110",  "2D","1110",    "VREF_VBE3"},
            { "2D","1510",  "2D","1510",    "VREF_VBE2"},
            { "2D","1910",  "2D","1910",    "VREF_VBE1"},
            { "2D","1D10",  "2D","1D10",    "VREF_QS_VBG_1200M"},
            { "2D","0340",  "2D","0340",    "CPPLL_VCTRL"},
            { "2D","0120",  "2C","0100",    "GCC_LOOP2_FBI"},
            { "2D","0120",  "2C","0200",    "GCC_V_GATE"},
            { "2D","0120",  "2C","0300",    "GCC_LOOP1_FBI"},
            { "2D","0120",  "2C","0400",    "GCC_ILEDA_LOOP"},
            { "2D","0120",  "2C","0500",    "GCC_QS_GCC_CUR_VREF"},
            { "2D","0120",  "2C","0600",    "GCC_QS_VREFLK_A"},
            { "2D","0120",  "2C","0700",    "GCC_QS_VREF_LOWKHEE_A"},
            { "2D","0130",  "2C","0000",    "DRV_CELL_CH0"},
            { "2D","0130",  "2C","1000",    "DRV_CELL_CH8"},
            { "2D","0160",  "2C","0010",    "SYS_QS_LDO_VREF_IN"},
            { "2D","0160",  "2C","0020",    "SYS_VFBI"},
            { "2D","0160",  "2C","0030",    "SYS_LDO_OUT"},
            { "2D","0160",  "2C","0040",    "SYS_TIEL1"},
            { "2D","0160",  "2C","0050",    "SYS_TIEH1"},
            { "2D","0160",  "2C","0060",    "SYS_TIEL2"},
            { "2D","0160",  "2C","0070",    "SYS_TIEH2"},
            { "2D","0170",  "2C","0001",    "CPLL_QS_LDO_VREF_IN"},
            { "2D","0170",  "2C","0002",    "CPLL_VFBI"},
            { "2D","0170",  "2C","0003",    "CPLL_LDO_OUT"},
            { "2D","0170",  "2C","0004",    "CPLL_TIEL1"},
            { "2D","0170",  "2C","0005",    "CPLL_TIEH1"},
            { "2D","0170",  "2C","0006",    "CPLL_TIEL2"},
            { "2D","0170",  "2C","0007",    "CPLL_TIEH2"},
            { "2D","01D0",  "0E","0100",    "MSC_QS_LDO_VREF_IN"},
            { "2D","01D0",  "0E","0200",    "MSC_VFBI"},
            { "2D","01D0",  "0E","0300",    "MSC_LDO_OUT"},
            { "2D","01D0",  "0E","0400",    "MSC_TIEL1"},
            { "2D","01D0",  "0E","0500",    "MSC_TIEH1"},
            { "2D","01D0",  "0E","0600",    "MSC_TIEL2"},
            { "2D","01D0",  "0E","0700",    "MSC_TIEH2"},
        };
        public string[,] atbTable_2218_V20X = new[,] {
            { "2F","0190",  "2F","0190",    "TOP_QS_OSVD_VREF" },
            { "2F","01A0",  "2F","01A0",    "TOP_QS_CHN_PREDRV_VREF"},
            { "2F","01B0",  "2F","01B0",    "TOP_QS_CHN_DEG_VREF"   },
            { "2F","01C0",  "2F","01C0",    "TOP_QS_CHN_CLAMP_VREF"},
            { "2F","01D0",  "2F","01D0",    "TOP_CPBOOST_BUF_ATB_OUT"},
            { "30","0008",  "2F","01E0",    "TOP_PUMP_TEST"},
            { "2F","01F0",  "2F","01F0",    "TOP_TIEH"},
            { "2F","0510",  "2F","0510",    "VREF_QS_OVD_VREFA"},
            { "2F","0910",  "2F","0910",    "VREF_QS_VREF_LOWKNEE_A"},
            { "2F","0D10",  "2F","0D10",    "VREF_V2I_LOOP"},
            { "2F","01D0",  "2F","1110",    "VREF_VBE3"},
            { "2F","01E0",  "2F","1510",    "VREF_VBE2"},
            { "2F","01F0",  "2F","1910",    "VREF_VBE1"},
            { "2F","1D10",  "2F","1D10",    "VREF_QS_VBG_1200M"},
            { "2F","0340",  "2F","0340",    "CPPLL_VCTRL"},
            { "2F","0120",  "2E","0100",    "GCC_QS_VBGROP6"},
            { "2F","0120",  "2E","0200",    "GCC_LOOP1_FBI"},
            { "2F","0120",  "2E","0300",    "GCC_QS_GCC_CUR_VREF"},
            { "2F","0120",  "2E","0400",    "GCC_LOOP2_FBO"},
            { "2F","0120",  "2E","0500",    "GCC_QS_VREF_LOWKHEE_A"},
            { "2F","0120",  "2E","0600",    "GCC_LOOP3_FBO"},
            { "2F","0120",  "2E","0700",    "GCC_QS_VREFH_A"},
            { "2F","0130",  "2E","0000",    "DRV_CELL_CH0"},   //增加2D 配置0001
            { "2F","0130",  "2E","1000",    "DRV_CELL_CH8"},   //
            { "2F","0160",  "2E","0010",    "SYS_QS_LDO_VREF_IN"},
            { "2F","0160",  "2E","0020",    "SYS_VFBI"},
            { "2F","0160",  "2E","0030",    "SYS_LDO_OUT"},
            { "2F","0160",  "2E","0040",    "SYS_TIEL1"},
            { "2F","0160",  "2E","0050",    "SYS_TIEH1"},
            { "2F","0160",  "2E","0060",    "SYS_TIEL2"},
            { "2F","0160",  "2E","0070",    "SYS_TIEH2"},
            { "2F","0170",  "2E","0001",    "CPLL_QS_LDO_VREF_IN"},
            { "2F","0170",  "2E","0002",    "CPLL_VFBI"},
            { "2F","0170",  "2E","0003",    "CPLL_LDO_OUT"},
            { "2F","0170",  "2E","0004",    "CPLL_TIEL1"},
            { "2F","0170",  "2E","0005",    "CPLL_TIEH1"},
            { "2F","0170",  "2E","0006",    "CPLL_TIEL2"},
            { "2F","0170",  "2E","0007",    "CPLL_TIEH2"},
            { "2F","0150",  "2F","2150",    "CPBOOST_QS_VREF_1250M"},
            { "2F","0150",  "2F","4150",    "CPBOOST_VFBI"},
            { "2F","0150",  "2F","6150",    "CPBOOST_LDO_OUT"},
            { "2F","0150",  "2F","8150",    "CPBOOST_TIEL1"},
            { "2F","0150",  "2F","A150",    "CPBOOST_TIEH1"},
            { "2F","0150",  "2F","C150",    "CPBOOST_TIEL2"},
            { "2F","0150",  "2F","E150",    "CPBOOST_TIEH2"},
        };
        public string[,] atbTable_2218R_V100 = new string[,] {};
        public string[,] atbTable_2318R_V100 = new[,] {
            { "2D","0150",  "2D","0150",    "TOP_EFUSE_ATB" },
            { "2D","0160",  "2D","0160",    "TOP_TIEL"},
            { "2D","0190",  "2D","0190",    "TOP_QS_OSVD_VREF"   },
            { "2D","01A0",  "2D","01A0",    "TOP_QS_CHN_PREDRV_VREF"},
            { "2D","01B0",  "2D","01B0",    "TOP_QS_CHN_DEG_VREF"},
            { "2D","01C0",  "2D","01C0",    "TOP_QS_CHN_CLAMP_VREF"},
            { "2D","01D0",  "2D","01D0",    "TOP_TIEL1"},
            { "2D","01E0",  "2D","01E0",    "TOP_TIEL2"},
            { "2D","01F0",  "2D","01F0",    "TOP_TIEL3"},
            { "2D","0510",  "2D","0510",    "VREF_QS_OVD_VREFA"},
            { "2D","0910",  "2D","0910",    "VREF_QS_VREF_LOWKNEE_A"},
            { "2D","0D10",  "2D","0D10",    "VREF_V2I_LOOP"},
            { "2D","1110",  "2D","1110",    "VREF_VBE3"},
            { "2D","1510",  "2D","1510",    "VREF_VBE2"},
            { "2D","1910",  "2D","1910",    "VREF_VBE1"},
            { "2D","1D10",  "2D","1D10",    "VREF_QS_VBG_1200M"},
            { "2D","0120",  "2C","0100",    "GCC_LOOP2_FBI"},
            { "2D","0120",  "2C","0200",    "GCC_V_GATE"},
            { "2D","0120",  "2C","0300",    "GCC_LOOP1_FBI"},
            { "2D","0120",  "2C","0400",    "GCC_ILEDA_LOOP"},
            { "2D","0120",  "2C","0500",    "GCC_QS_GCC_CUR_VREF"},
            { "2D","0120",  "2C","0600",    "GCC_QS_VREFLK_A"},
            { "2D","0120",  "2C","0700",    "GCC_QS_VREF_LOWKHEE_A"},
            { "2D","0130",  "2C","0000",    "DRV_CELL_CH0"},
            { "2D","0130",  "2C","1000",    "DRV_CELL_CH8"},
            { "2D","0340",  "2D","0340",    "CPPLL_VCTRL"},
            { "2D","0170",  "2C","0001",    "LDO_CPLL_LDO_OUT"},
            { "2D","0170",  "2C","0002",    "LDO_CPLL_QS_VREF1250M"},
            { "2D","0170",  "2C","0003",    "LDO_CPLL_VGATE"},
            { "2D","0170",  "2C","0004",    "LDO_CPLL_VFBI"},
            { "2D","0170",  "2C","0005",    "LDO_CPLL_TIEH"},
            { "2D","0170",  "2C","0006",    "LDO_CPLL_VBP"},
            { "2D","0170",  "2C","0007",    "LDO_CPLL_VBN"},
        };
        
        public void AtbNodeRegCfg(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib, int index) {
            string data0 = dChipComFunLib.DriverDataGen(6, dChipComFunLib.para_St.atbScan[index, 1] + dChipComFunLib.para_St.atbScan[index, 1] + dChipComFunLib.para_St.atbScan[index, 1]);
            dChipComFunLib.DriverChipWriteReg(usbLib, dChipComFunLib.DriverChipRegAddrGen(dChipComFunLib.para_St.atbScan[index, 0]), data0);
            if (dChipComFunLib.para_St.atbScan[index, 2] != dChipComFunLib.para_St.atbScan[index, 0]) {
                comFunLib.DelayTimeMs(1000);
                string data1 = dChipComFunLib.DriverDataGen(6, dChipComFunLib.para_St.atbScan[index, 3] + dChipComFunLib.para_St.atbScan[index, 3] + dChipComFunLib.para_St.atbScan[index, 3]);
                dChipComFunLib.DriverChipWriteReg(usbLib, dChipComFunLib.DriverChipRegAddrGen(dChipComFunLib.para_St.atbScan[index, 2]), data1);
            }
        }
        public void AtbDebugTest(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib) {
            AtbNodeRegCfg(dChipComFunLib, usbLib, dChipComFunLib.para_St.cmbAtbNodeNane.SelectedIndex);
            comFunLib.DelayTimeMs(1000);
        }
        public void AtbAutoSweep(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib) {
            string title = "ChipType\tChipNum\tTOP_Atb(Addr)\tTOP_Atb(Cfg)\tATB_Ctrl(Addr)\tATB_Ctrl(Cfg)\tATB_Name\tValue\tunit";
            CommonInstAndTxtInit(dChipComFunLib, title);
            double volt = 0;
            for (int i = 0; i < dChipComFunLib.para_St.cmbAtbNodeNane.Items.Count; i++) {
                AtbNodeRegCfg(dChipComFunLib, usbLib, i);
                comFunLib.DelayTimeMs(2000);
                dChipComFunLib.dataList.Add(dChipComFunLib.para_St.cmbProjectName.Text);
                dChipComFunLib.dataList.Add(dChipComFunLib.para_St.tbChipID.Text);
                dChipComFunLib.dataList.Add(dChipComFunLib.para_St.atbScan[i, 0]);
                dChipComFunLib.dataList.Add(dChipComFunLib.para_St.atbScan[i, 1]);
                dChipComFunLib.dataList.Add(dChipComFunLib.para_St.atbScan[i, 2]);
                dChipComFunLib.dataList.Add(dChipComFunLib.para_St.atbScan[i, 3]);
                dChipComFunLib.dataList.Add(dChipComFunLib.para_St.atbScan[i, 4]);
                if (dChipComFunLib.para_St.cbMultiSelEn.Checked) {
                    instCmdLib.ReadMulti(mbsMulti, ref volt);  //读取电压
                }
                dChipComFunLib.dataList.Add(volt.ToString("F3"));
                dChipComFunLib.dataList.Add(instCmdLib.var_st.dataUnit);
                comFunLib.WriteDataToTxt(dChipComFunLib.dataList);
                dChipComFunLib.dataList.Clear();
                if (dChipComFunLib.para_St.stop) break;
            }
        }
        #endregion

        #region 2. VBG Trim Test
        string[,] vbgTrim_2218_V20X = new string[,] {
                {"21","0000" },  //通道关闭
                {"2F","1D10" },  //ATB输出VBG
                {"28","00D8" },  //VBG trim 使能
                {"27","bit[4:0]" },  //code 调节
        };
        string[,] vbgTrim_2318_V100 = new string[,] {
                {"1F","0000" },  //通道关闭
                {"2D","1D10" },  //ATB输出VBG
                {"26","00D8" },  //VBG trim 使能
                {"25","bit[4:0]" },  //code 调节
        };
        string[,] vbgTrim_2218R_V100 = new string[,] {
        };
        public void VbgAutoTrim(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib) {
            string title = "ChipType\tChipNum\tVbgCode\tValue(v)";
            CommonInstAndTxtInit(dChipComFunLib, title);
            double volt = 0;
            for (int i = 0; i < dChipComFunLib.para_St.VbgTrim.GetLength(0) - 1; i++) {
                if (dChipComFunLib.para_St.stop) break;
                string data0 = dChipComFunLib.DriverDataGen(6, dChipComFunLib.para_St.VbgTrim[i, 1] + dChipComFunLib.para_St.VbgTrim[i, 1] + dChipComFunLib.para_St.VbgTrim[i, 1]);
                dChipComFunLib.DriverChipWriteReg(usbLib, dChipComFunLib.DriverChipRegAddrGen(dChipComFunLib.para_St.VbgTrim[i, 0]), data0);
                comFunLib.DelayTimeMs(500);
            }
            for (int i = 0; i < 32; i++) {
                string data0 = dChipComFunLib.DriverDataGen(6, i.ToString("X4") + i.ToString("X4") + i.ToString("X4"));
                dChipComFunLib.DriverChipWriteReg(usbLib, dChipComFunLib.DriverChipRegAddrGen(dChipComFunLib.para_St.VbgTrim[3, 0]), data0);
                comFunLib.DelayTimeMs(1000);
                dChipComFunLib.dataList.Add(dChipComFunLib.para_St.cmbProjectName.Text);
                dChipComFunLib.dataList.Add(dChipComFunLib.para_St.tbChipID.Text);
                dChipComFunLib.dataList.Add(i.ToString("X4"));
                if (dChipComFunLib.para_St.cbMultiSelEn.Checked) {
                    instCmdLib.ReadMulti(mbsMulti, ref volt);  //读取电压
                }
                dChipComFunLib.dataList.Add(volt.ToString("F3"));
                comFunLib.WriteDataToTxt(dChipComFunLib.dataList);
                dChipComFunLib.dataList.Clear();
                if (dChipComFunLib.para_St.stop) break;
            }
        }
        #endregion

        #region 3. ATE CH Curr LOOP Test
        string[,] currCom_2318 = new string[,] {
                {"2A","0001" },     //电流模式
                {"14","00FF" },     //GCC配置FF
                {"15","0034" },     //lowKnee
                {"1F","0001" },     //通道使能
        };
        string[,] currValue_2318 = new string[,] {
                {"02","000F" },     //PAM-25.6
                {"02","0007" },     //PAM-12.8
        };
        public void ConfigCurrent(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib) {
            
        }
        public void AteLoopTest(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib) {
            string title = "ChipType\tChipNum\tCnt\tState";
            CommonInstAndTxtInit(dChipComFunLib, title);
            GetPowerChEn(dChipComFunLib);
            for (int i = 0; i < dChipComFunLib.para_St.nudLoopCnt; i++) {
                if (dChipComFunLib.para_St.cbPowerSelEn.Checked) {
                    instCmdLib.GuWeiPowerOutputChEn(mbsPower, (InstCommandLib.POWER_CH_EN)dChipComFunLib.para_St.CH[0], InstCommandLib.STATE_EN.ON);  //关闭电源
                    comFunLib.DelayTimeMs(500);
                    instCmdLib.GuWeiPowerOutputChEn(mbsPower, (InstCommandLib.POWER_CH_EN)dChipComFunLib.para_St.CH[1], InstCommandLib.STATE_EN.ON);  //关闭电源
                    comFunLib.DelayTimeMs(500);
                }
                //common
                for (int d = 0; d < currCom_2318.GetLength(0); d++) {
                    string data0 = dChipComFunLib.DriverDataGen(6, currCom_2318[d, 1] + currCom_2318[d, 1] + currCom_2318[d, 1]);
                    dChipComFunLib.DriverChipWriteReg(usbLib, dChipComFunLib.DriverChipRegAddrGen(currCom_2318[d, 0]), data0);
                    comFunLib.DelayTimeMs(500);
                }
                //
                for (int j = 0; j < currValue_2318.GetLength(0); j++) {
                    string data1 = dChipComFunLib.DriverDataGen(6, currValue_2318[j, 1] + currValue_2318[j, 1] + currValue_2318[j, 1]);
                    dChipComFunLib.DriverChipWriteReg(usbLib, dChipComFunLib.DriverChipRegAddrGen(currValue_2318[j, 0]), data1);
                    comFunLib.DelayTimeMs(1000);
                }
                dChipComFunLib.para_St.lbView.Text = "测试次数: " + i.ToString();
                dChipComFunLib.dataList.Add(dChipComFunLib.para_St.cmbProjectName.Text);
                dChipComFunLib.dataList.Add(dChipComFunLib.para_St.tbChipID.Text);
                dChipComFunLib.dataList.Add(i.ToString());
                dChipComFunLib.dataList.Add("PASS");
                if (dChipComFunLib.para_St.cbPowerSelEn.Checked) {
                    instCmdLib.GuWeiPowerOutputChEn(mbsPower, (InstCommandLib.POWER_CH_EN)dChipComFunLib.para_St.CH[1], InstCommandLib.STATE_EN.OFF);  //关闭电源
                    comFunLib.DelayTimeMs(500);
                    instCmdLib.GuWeiPowerOutputChEn(mbsPower, (InstCommandLib.POWER_CH_EN)dChipComFunLib.para_St.CH[0], InstCommandLib.STATE_EN.OFF);  //关闭电源
                    comFunLib.DelayTimeMs(500);
                }
                comFunLib.WriteDataToTxt(dChipComFunLib.dataList);
                dChipComFunLib.dataList.Clear();
                if (dChipComFunLib.para_St.stop) break;
            }
        }
        #endregion

        #region 4. Pre Driver Volt Test
        //------------测试步骤：------------------------------------------------------
        //1.关闭通道，配置寄存器OUT_EN(Addr：0x1F，bit[0:0]，1'b0) = 0x0000;
        //2.芯片工作在预驱动模式下，配置寄存器MODE(addr：0x2A，bit[2:0]，3'b011) = 0x0003;
        //3.预驱动使能，配置寄存器CHN_PRE_DRV_EN(addr：0x0C，bit[9]，1'b1) = 0x0100;
        //4.ATB输出QS_CHN_PREDRV_VREF，配置寄存器TOP_ATB_CTRL(Addr：0x2D，bit[7:4]，4'b1010) = 0x01A0;
        //5.粗调档位：0x0E，bit[12]，1'b0/1 = 0x0000~0x1000;
        //6.在每个粗调档位下，遍历细调档位：CHN_PRE_DRV_VREF_SEL(Addr：0x0D的bit[8:4]，5'b00000~11111) = 0x0010~0x01F0，万用表测量ATB输出电压;
        //备注：ATB电压测试时，ATB与万用表间加以Buff电路进行隔离。
        //预期计算公式：PREDRV: 967mV+42mV* code
        //--------------------------------------------------------------------------
        public string[,] preDrv_2218_V20X = new string[,] {
                {"21","0000" },  //通道关闭
                {"2C","0003" },  //预驱动模式
                {"10","0100" },  //预驱动使能
                {"2F","01A0" },  //ATB输出预驱动电压
                {"11","粗调" },  //粗调档位 bit[9]
                {"11","细调" }   //预驱动调节 bit[8:4]
        };
        public string[,] preDrv_2318_V100 = new string[,] {
                {"1F","0000" },  //通道关闭
                {"2A","0003" },  //预驱动模式
                {"0C","0100" },  //预驱动使能
                {"2D","01A0" },  //ATB输出预驱动电压
                {"0E","粗调" },  //粗调档位 bit[12]/  0x0E=0000/1000
                {"0D","细调" }   //预驱动调节 bit[8:4]
        };
        public string[,] preDrv_2218R_V100 = new string[,] {
                {" ","0000" },  //通道关闭
                {" ","0003" },  //预驱动模式
                {" ","0100" },  //预驱动使能
                {" ","01A0" },  //ATB输出预驱动电压
                {" ","粗调" },  //粗调档位
                {" ","细调" }   //预驱动调节 bit[8:4]
        };
        /// <summary>
        /// 预驱动电压调节(分为粗调档位bit[5], 细调档位bit[4:0],总计64档调节范围, 0.35mv~2.8V)
        /// </summary>
        /// <param name="dChipComFunLib"></param>
        /// <param name="usbLib"></param>
        /// <param name="vbg"></param>
        /// <param name="bit5"></param>
        /// <param name="cell"></param>
        /// <param name="addr"></param>
        /// <param name="volt"></param>
        public void PreDrvResults(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib, double vbg, int bit5, int cell, string addr, double volt) {
            for (int i = 0x0000; i < (bit5 == 0 ? 0x1f1 : 0x3f1); i += 16) {
                string data0 = dChipComFunLib.DriverDataGen(6, i.ToString("X4") + i.ToString("X4") + i.ToString("X4"));
                dChipComFunLib.DriverChipWriteReg(usbLib, dChipComFunLib.DriverChipRegAddrGen(addr), data0);
                comFunLib.DelayTimeMs(1000);
                dChipComFunLib.dataList.Add(dChipComFunLib.para_St.cmbProjectName.Text);
                dChipComFunLib.dataList.Add(dChipComFunLib.para_St.tbChipID.Text);
                dChipComFunLib.dataList.Add(vbg.ToString("F3"));
                dChipComFunLib.dataList.Add(cell == 1 || i > 0x1f0 ? "1" : "0");
                dChipComFunLib.dataList.Add(i.ToString("X4"));
                if (dChipComFunLib.para_St.cbMultiSelEn.Checked) {
                    instCmdLib.ReadMulti(mbsMulti, ref volt);  //读取电压
                }
                dChipComFunLib.dataList.Add(volt.ToString("F3"));
                comFunLib.WriteDataToTxt(dChipComFunLib.dataList);
                dChipComFunLib.dataList.Clear();
                if (dChipComFunLib.para_St.stop) break;
            }
        }
        public void PreDriverAutoTest(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib) {
            string title = "ChipType\tChipNum\tVBG(V)\tDRV_bit[5]\tCode\tVolt(V)";
            CommonInstAndTxtInit(dChipComFunLib, title);
            double volt = 0;
            double vbg = GetVbgVolt(dChipComFunLib, usbLib);
            //关闭通道输出、预驱动使能、ATB输出预驱动电压
            for (int i = 0; i < dChipComFunLib.para_St.preDrv.GetLength(0) - 2; i++) {
                if (dChipComFunLib.para_St.stop) break;
                string data0 = dChipComFunLib.DriverDataGen(6, dChipComFunLib.para_St.preDrv[i, 1] + dChipComFunLib.para_St.preDrv[i, 1] + dChipComFunLib.para_St.preDrv[i, 1]);
                dChipComFunLib.DriverChipWriteReg(usbLib, dChipComFunLib.DriverChipRegAddrGen(dChipComFunLib.para_St.preDrv[i, 0]), data0);
                comFunLib.DelayTimeMs(500);
            }
            //粗调档位 bit[5]=0/1，调节细调档位 bit[4:0]; 调节档位总计 6bit 
            if (dChipComFunLib.para_St.cmbProjectName.Text.Contains("2218_V20X")) {
                PreDrvResults(dChipComFunLib, usbLib, vbg, 1, 0, dChipComFunLib.para_St.preDrv[5, 0], volt);
            }
            if (dChipComFunLib.para_St.cmbProjectName.Text.Contains("2318")) {
                for (int cell = 0; cell < 2; cell++) {
                    if (dChipComFunLib.para_St.stop) break;
                    dChipComFunLib.DriverChipWriteReg(usbLib, dChipComFunLib.DriverChipRegAddrGen(dChipComFunLib.para_St.preDrv[4, 0]), dChipComFunLib.DriverDataGen(6, cell == 0 ? "000000000000" : "100010001000"));
                    PreDrvResults(dChipComFunLib, usbLib, vbg, 0, cell, dChipComFunLib.para_St.preDrv[5, 0], volt);
                }
            }
        }
        #endregion

        #region 5. IFIX Trim Test   todo...
        #endregion

        #region 6. CPPLL Tuning Range Trim Test  todo...
        #endregion
    }
}

