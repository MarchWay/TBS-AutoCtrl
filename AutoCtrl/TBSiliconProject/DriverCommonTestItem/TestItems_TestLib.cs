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
using System.Windows.Forms;

namespace AutoCtrl.TBSiliconProject.DriverCommonTestItem
{
    public class TestItems_TestLib
    {
        public USB_PortLib usbAnalog = new USB_PortLib();
        public CommonFunctionLib comFunLib = new CommonFunctionLib();
        public InstCommandLib instCmdLib = new InstCommandLib();
        public InstCommonCtrlLib instCommLib = new InstCommonCtrlLib();
        public MessageBasedSession mbsPower, mbsMulti, mbsMulti1;
        public RichTextBox rtbDisPlay;
        public TextBox tbAtbResult;
        public double volt = 0;
        public double vbgTarget = 1.200;
        public int voltCase;
        public string CommTitle = "ChipType\tChipCorner\tChipNum\tTemp\tVoltage\t";

        #region 0. 公共函数：仪器连接|获取项目名称|...
        /// <summary>
        /// 获取和仪器连接的通信接口
        /// </summary>
        /// <param name="dChipComFunLib"></param>
        public void GetInstHandle(DriverChipCommonFunctionLib dChipComFunLib)
        {

            bool EnableStatus = dChipComFunLib.para_St.cbMultiSelEn.Checked || dChipComFunLib.para_St.cbMultiSelEn1.Checked || dChipComFunLib.para_St.cbPowerSelEn.Checked;
            bool AddrStatus = dChipComFunLib.para_St.tbInstMultiAddr.Text == null || dChipComFunLib.para_St.tbInstMultiAddr1.Text == null
                || dChipComFunLib.para_St.tbInstPowerAddr.Text == null;
            if (dChipComFunLib.para_St.cbMultiSelEn.Checked)
            {
                instCommLib.InstrumentLink(ref mbsMulti, dChipComFunLib.para_St.tbInstMultiAddr.Text.Trim());
            }
            if (dChipComFunLib.para_St.cbMultiSelEn1.Checked)
            {
                instCommLib.InstrumentLink(ref mbsMulti1, dChipComFunLib.para_St.tbInstMultiAddr1.Text.Trim());
            }
            if (dChipComFunLib.para_St.cbPowerSelEn.Checked)
            {
                instCommLib.InstrumentLink(ref mbsPower, dChipComFunLib.para_St.tbInstPowerAddr.Text.Trim());
            }
            if (EnableStatus)
            {
                if (AddrStatus)
                {
                    MessageBox.Show("请确认输入的仪器地址是否正确." + "\n" +
                    "1、电压测试时，万用表Addr0需填写仪器地址，且选择尾部方框" + "\n" +
                    "2、电流测试时，万用表Addr0和Addr1都需填写仪器地址，且选择尾部方框" + "\n");
                    dChipComFunLib.para_St.stop = true;
                }

            }
            else
            {
                MessageBox.Show("请选择测试需要仪器，并输入地址.");
                dChipComFunLib.para_St.stop = true;
            }
        }
        /// <summary>
        /// 根据所选择的项目名称,初始化对应测试的参数
        /// </summary>
        /// <param name="dChipComFunLib"></param>
        public void GetProjectName(DriverChipCommonFunctionLib dChipComFunLib)
        {
            switch (dChipComFunLib.para_St.cbProjectItems.Text)
            {
                case "P2218_V20X":
                    dChipComFunLib.para_St.atbScan = atbTable_2218_V20X;
                    dChipComFunLib.para_St.VbgTrim = vbgTrim_2218_V20X;
                    dChipComFunLib.para_St.GccIfix = GccIfix_2218_V20X;
                    dChipComFunLib.para_St.preDrv = preDrv_2218_V20X;
                    dChipComFunLib.para_St.DrvPAM = DrvPAM_2218_V20X;
                    dChipComFunLib.para_St.GccGain = GCCGain_2218_V20x;
                    dChipComFunLib.para_St.Regulator = Regulator_2218_V20X;
                    break;
                case "P2318_V100":
                    dChipComFunLib.para_St.atbScan = atbTable_2318_V100;
                    dChipComFunLib.para_St.VbgTrim = vbgTrim_2318_V100;
                    dChipComFunLib.para_St.GccIfix = GccIfix_2318_V100;
                    dChipComFunLib.para_St.preDrv = preDrv_2318_V100;
                    dChipComFunLib.para_St.DrvPAM = DrvPAM_2318_V100;
                    dChipComFunLib.para_St.GccGain = GCCGain_2318_V100;
                    dChipComFunLib.para_St.Regulator = Regulator_2318_V100;
                    break;
                case "P2318R_V100":
                    dChipComFunLib.para_St.atbScan = atbTable_2318R_V100;
                    dChipComFunLib.para_St.VbgTrim = vbgTrim_2318_V100;
                    dChipComFunLib.para_St.GccIfix = GccIfix_2318_V100;
                    dChipComFunLib.para_St.preDrv = preDrv_2318_V100;
                    dChipComFunLib.para_St.DrvPAM = DrvPAM_2318_V100;
                    dChipComFunLib.para_St.GccGain = GCCGain_2318_V100;
                    dChipComFunLib.para_St.Regulator = Regulator_2318R_V100;
                    break;
                case "P2218R_V100":
                    dChipComFunLib.para_St.atbScan = atbTable_2218R_V100;
                    dChipComFunLib.para_St.VbgTrim = vbgTrim_2218_V20X;
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
        public int LookUpVbg(string[,] atbTable)
        {
            int vbgID = 0;
            for (int i = 0; i < atbTable.GetLength(0); i++)
            {
                if (atbTable[i, 4].Contains("QS_VBG_1200M"))
                {
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
        public double GetVbgVolt(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib)
        {
            double volt = 0;
            int vbgID = LookUpVbg(dChipComFunLib.para_St.atbScan);
            dChipComFunLib.WriteReg(usbLib, dChipComFunLib.para_St.atbScan[vbgID, 2], dChipComFunLib.para_St.atbScan[vbgID, 3]);
            comFunLib.DelayTimeMs(1000);
            if (dChipComFunLib.para_St.cbMultiSelEn.Checked)
            {
                instCmdLib.SetMultiMeasMode(mbsMulti, InstCommandLib.READ_TYPE_EN.VOLT, InstCommandLib.MEASURE_MODE_EN.DC);//设置万用表为电压模式
                instCmdLib.ReadMulti(mbsMulti, ref volt);  //读取电压
            }
            return volt;
        }
        /// <summary>
        /// 校准Vbg电压(将vbg电压校准至设定值configValue)
        /// </summary>
        /// <param name="dChipComFunLib"></param>
        /// <param name="usbLib"></param>
        /// <param name="configValue"></param>
        /// <returns></returns>
        public double VbgConfig(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib, double configValue)
        {
            int code = 10;
            double volt = GetVbgVolt(dChipComFunLib, usbLib);
            string regCode = "10" + code.ToString("X2");
            dChipComFunLib.WriteReg(usbLib, dChipComFunLib.para_St.VbgTrim[3, 0], regCode);
            comFunLib.DelayTimeMs(300);
            while (Math.Abs(volt - configValue) > 0.008)
            {
                if (dChipComFunLib.para_St.stop)
                {
                    dChipComFunLib.para_St.stop = false;
                    break;
                }
                code = (volt - configValue) > 0 ? --code : ++code;
                if (code < 0 || code > 15)
                    break;
                regCode = "10" + code.ToString("X2");
                dChipComFunLib.WriteReg(usbLib, dChipComFunLib.para_St.VbgTrim[3, 0], regCode);
                comFunLib.DelayTimeMs(300);
                volt = GetVbgVolt(dChipComFunLib, usbLib);
            }
            return volt;
        }
        /// <summary>
        /// 结果title公共部分
        /// </summary>
        /// <param name="dChipComFunLib"></param>
        public void ResultTitleSave(DriverChipCommonFunctionLib dChipComFunLib)
        {
            dChipComFunLib.dataList.Add(dChipComFunLib.para_St.cbProjectItems.Text);
            dChipComFunLib.dataList.Add(dChipComFunLib.para_St.cmbChipCorner.Text);
            dChipComFunLib.dataList.Add(dChipComFunLib.para_St.tbChipID.Text);
            dChipComFunLib.dataList.Add(dChipComFunLib.para_St.cmbTempCaseSel.Text);
            dChipComFunLib.dataList.Add(dChipComFunLib.para_St.cmbVoltCaseSel.Text);
        }
        /// <summary>
        /// 控制不同电源通道上下电
        /// </summary>
        /// <param name="dChipComFunLib"></param>
        public void PowerOnOffControl(DriverChipCommonFunctionLib dChipComFunLib)
        {
            int delayCount = 0;
            string pwrType = dChipComFunLib.para_St.cbPwrType.Checked ? "KeySight" : "GuWei";
            bool[] EnPwrCh = new bool[]{ dChipComFunLib.para_St.cbEnPwrCH1.Checked, dChipComFunLib.para_St.cbEnPwrCH2.Checked,
                    dChipComFunLib.para_St.cbEnPwrCH3.Checked, dChipComFunLib.para_St.cbEnPwrCH4.Checked };
            //电源初始化设置
            if (dChipComFunLib.para_St.cbPowerSelEn.Checked)
            {
                for (int ch = 0; ch < EnPwrCh.Length; ch++)
                {
                    if (EnPwrCh[ch])
                    {
                        switch (pwrType)
                        {
                            case "GuWei":
                                instCmdLib.GuWeiPowerOutputChEn(mbsPower, (InstCommandLib.POWER_CH_EN)(ch + 1), InstCommandLib.STATE_EN.OFF);
                                comFunLib.DelayTimeMs(2000);
                                instCmdLib.GuWeiPowerOutputChEn(mbsPower, (InstCommandLib.POWER_CH_EN)(ch + 1), InstCommandLib.STATE_EN.ON);
                                break;
                            case "KeySight":
                                instCmdLib.KeyPowerOutPutChEn(mbsPower, (InstCommandLib.POWER_CH_EN)(ch + 1), InstCommandLib.STATE_EN.OFF);
                                comFunLib.DelayTimeMs(2000);
                                instCmdLib.KeyPowerOutPutChEn(mbsPower, (InstCommandLib.POWER_CH_EN)(ch + 1), InstCommandLib.STATE_EN.ON);
                                break;
                            default:
                                break;
                        }

                    }
                }
                while (delayCount < 7)
                {
                    comFunLib.DelayTimeMs(1000);
                    delayCount++;
                }
            }
        }
        /// <summary>
        /// 电源电压设置，pwrType——电源类型，pwrCH——电源通道，volt——设置电压值，exeModule——执行类型"设置电压"or"读取电压"
        /// </summary>
        /// <param name="dChipComFunLib"></param>
        /// <param name="pwrType"></param>
        /// <param name="pwrCH"></param>
        /// <param name="volt"></param>
        /// <param name="exeModule"></param>
        /// <returns></returns>
        string[] exCommand = new string[] { "Set", "Read" };
        public double PwrVoltSetOrRead(DriverChipCommonFunctionLib dChipComFunLib, int pwrCH, string exeModule, double volt = 3.8) {
            string pwrType = dChipComFunLib.para_St.cbPwrType.Checked ? "KeySight" : "GuWei";
            bool[] EnPwrCh = new bool[]{ dChipComFunLib.para_St.cbEnPwrCH1.Checked, dChipComFunLib.para_St.cbEnPwrCH2.Checked,
                    dChipComFunLib.para_St.cbEnPwrCH3.Checked, dChipComFunLib.para_St.cbEnPwrCH4.Checked };

            if (EnPwrCh[pwrCH - 1]) {
                switch (pwrType) {
                    case "GuWei":
                        if (exeModule == "Set") {
                            instCmdLib.SetGuWeiPowerVolt(mbsPower, (InstCommandLib.POWER_CH_EN)pwrCH, volt);
                        }
                        else {
                            instCmdLib.ReadGuWeiPowerCh(mbsPower, (InstCommandLib.POWER_CH_EN)pwrCH, InstCommandLib.READ_TYPE_EN.VOLT, ref volt);
                        }
                        break;
                    case "KeySight":
                        if (exeModule == "Set") {
                            instCmdLib.SetKeyVoltAndCurr(mbsPower, (InstCommandLib.POWER_CH_EN)pwrCH, volt, 2.00);
                        }
                        else {
                            instCmdLib.ReadKeyPower(mbsPower, (InstCommandLib.POWER_CH_EN)pwrCH, InstCommandLib.READ_TYPE_EN.VOLT, ref volt);
                        }
                        break;
                    default:
                        break;
                }
            }

            return volt;
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

        #region atbNode Table 所有项目的atb地址、名称在此处更新

        public string[,] atbTable_2318_V100 = new[,] {
            //TOP_ATB地址    目标ATB地址      目标ATB名称
            { "2D","0190",  "2D","0190",    "TOP_QS_OSVD_VREF" },
            { "2D","01A0",  "2D","01A0",    "TOP_QS_CHN_PREDRV_VREF"},
            { "2D","01B0",  "2D","01B0",    "TOP_QS_CHN_DEG_VREF"},
            { "2D","01C0",  "2D","01C0",    "TOP_QS_CHN_CLAMP_VREF"},
            { "2D","01D0",  "2D","01D0",    "TOP_CPBOOST_BUF_ATB_OUT"},
            { "0E","0800",  "2D","01E0",    "TOP_PUMP_TEST"},//需配置寄存器PUMP_EN，addr：0x0E = 0800
            { "2D","01F0",  "2D","01F0",    "TOP_TIEH"},
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
            { "2D","0130",  "2C","2000",    "DRV_CELL_CH0"},
            { "2D","0130",  "2C","3000",    "DRV_CELL_CH8"},//需配置DRV_CELL_ATB_EN，addr: 0x2C = 0x1000
            { "13","0001",  "2D","0340",    "CPPLL_VCTRL"},//需配置OUT_EN，addr：0x1F = 0x0000
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
            { "2D","01D0",  "0E","0300",    "MSC_VREF2200M"},
            { "2D","01D0",  "0E","0400",    "MSC_TIEL1"},
            { "2D","01D0",  "0E","0500",    "MSC_TIEH1"},
            { "2D","01D0",  "0E","0600",    "MSC_TIEL2"},
            { "2D","01D0",  "0E","0700",    "MSC_TIEH2"},
        };
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
            { "2D","0130",  "2C","2000",    "DRV_CELL_CH0"},
            { "2D","0130",  "2C","3000",    "DRV_CELL_CH8"},//需配置DRV_CELL_ATB_EN，addr: 0x2C = 0x1000
            { "11","0001",  "2D","0340",    "CPPLL_VCTRL"},//需配置OUT_EN，addr：0x1F = 0x0000
            { "2D","0170",  "2C","0001",    "LDO_CPLL_LDO_OUT"},
            { "2D","0170",  "2C","0002",    "LDO_CPLL_QS_VREF1250M"},
            { "2D","0170",  "2C","0003",    "LDO_CPLL_VGATE"},
            { "2D","0170",  "2C","0004",    "LDO_CPLL_VFBI"},
            { "2D","0170",  "2C","0005",    "LDO_CPLL_TIEH"},
            { "2D","0170",  "2C","0006",    "LDO_CPLL_VBP"},
            { "2D","0170",  "2C","0007",    "LDO_CPLL_VBN"},
        };
        public string[,] atbTable_2218_V20X = new[,] {
            //TOP_ATB地址    目标ATB地址      目标ATB名称
            { "2F","0190",  "2F","0190",    "TOP_QS_OSVD_VREF" },
            { "2F","01A0",  "2F","01A0",    "TOP_QS_CHN_PREDRV_VREF"},
            { "2F","01B0",  "2F","01B0",    "TOP_QS_CHN_DEG_VREF"   },
            { "2F","01C0",  "2F","01C0",    "TOP_QS_CHN_CLAMP_VREF"},
            { "2F","01D0",  "2F","01D0",    "TOP_TIEH"},
            { "30","0008",  "2F","01E0",    "TOP_PUMP_TEST"},
            { "2F","01F0",  "2F","01F0",    "TOP_EFUSE"},
            { "2F","0110",  "2F","0510",    "VREF_QS_OVD_VREFA"},
            { "2F","0110",  "2F","0910",    "VREF_QS_VREF_LOWKNEE_A"},
            { "2F","0110",  "2F","0D10",    "VREF_V2I_LOOP"},
            { "2F","0110",  "2F","1110",    "VREF_VBE3"},
            { "2F","0110",  "2F","1510",    "VREF_VBE2"},
            { "2F","0110",  "2F","1910",    "VREF_VBE1"},
            { "2F","0110",  "2F","1D10",    "VREF_QS_VBG_1200M"},
            { "2F","0120",  "2E","0100",    "GCC_QS_VBGROP6"},
            { "2F","0120",  "2E","0200",    "GCC_LOOP1_FBI"},
            { "2F","0120",  "2E","0300",    "GCC_QS_GCC_CUR_VREF"},
            { "2F","0120",  "2E","0400",    "GCC_LOOP2_FBO"},
            { "2F","0120",  "2E","0500",    "GCC_QS_VREF_LOWKHEE_A"},
            { "2F","0120",  "2E","0600",    "GCC_LOOP3_FBO"},
            { "2F","0120",  "2E","0700",    "GCC_QS_VREFH_A"},
            { "2F","0130",  "2E","0000",    "DRV_CELL_CH0"},
            { "2F","0130",  "2E","1000",    "DRV_CELL_CH8"},//需配置DRV_CELL_ATB_EN，addr: 0x2D = 0x0001
            { "13","0009",  "2F","0340",    "CPLL_VCTRL"},//需配置OUT_EN，addr：0x21 = 0x0000
            { "2F","0150",  "2F","2150",    "CPBOOST_QS_VREF_1250M"},
            { "2F","0150",  "2F","4150",    "CPBOOST_VFBI"},
            { "2F","0150",  "2F","6150",    "CPBOOST_LDO_OUT"},
            { "2F","0150",  "2F","8150",    "CPBOOST_TIEL1"},
            { "2F","0150",  "2F","A150",    "CPBOOST_TIEH1"},
            { "2F","0150",  "2F","C150",    "CPBOOST_TIEL2"},
            { "2F","0150",  "2F","E150",    "CPBOOST_TIEH2"},
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
        };
        public string[,] atbTable_2218_V100 = new[,] { 
            //TOP_ATB地址    目标ATB地址      目标ATB名称
            { "2F","0190",  "2F","0190",    "TOP_QS_OSVD_VREF" },
            { "2F","01A0",  "2F","01A0",    "TOP_QS_CHN_PREDRV_VREF"},
            { "2F","01B0",  "2F","01B0",    "TOP_QS_CHN_DEG_VREF"   },
            { "2F","01C0",  "2F","01C0",    "TOP_QS_CHN_CLAMP_VREF"},
            { "2F","01D0",  "2F","01D0",    "TOP_TIEH"},
            { "30","0008",  "2F","01E0",    "TOP_PUMP_TEST"},
            { "2F","01F0",  "2F","01F0",    "TOP_EFUSE"},
            { "2F","0110",  "2F","0510",    "VREF_QS_OVD_VREFA"},
            { "2F","0110",  "2F","0910",    "VREF_QS_VREF_LOWKNEE_A"},
            { "2F","0110",  "2F","0D10",    "VREF_V2I_LOOP"},
            { "2F","0110",  "2F","1110",    "VREF_VBE3"},
            { "2F","0110",  "2F","1510",    "VREF_VBE2"},
            { "2F","0110",  "2F","1910",    "VREF_VBE1"},
            { "2F","0110",  "2F","1D10",    "VREF_QS_VBG_1200M"},
            { "2F","0120",  "2E","0100",    "GCC_QS_VBGROP6"},
            { "2F","0120",  "2E","0200",    "GCC_LOOP1_FBI"},
            { "2F","0120",  "2E","0300",    "GCC_QS_GCC_CUR_VREF"},
            { "2F","0120",  "2E","0400",    "GCC_LOOP2_FBO"},
            { "2F","0120",  "2E","0500",    "GCC_QS_VREF_LOWKHEE_A"},
            { "2F","0120",  "2E","0600",    "GCC_LOOP3_FBO"},
            { "2F","0120",  "2E","0700",    "GCC_QS_VREFH_A"},
            { "2F","0130",  "2E","0000",    "DRV_CELL_CH0"},
            { "2F","0130",  "2E","1000",    "DRV_CELL_CH8"},//需配置DRV_CELL_ATB_EN，addr: 0x2D = 0x0001
            { "13","0009",  "2F","0340",    "CPLL_VCTRL"},//需配置OUT_EN，addr：0x21 = 0x0000
            { "2F","0150",  "2F","2150",    "CPBOOST_QS_VREF_1250M"},
            { "2F","0150",  "2F","4150",    "CPBOOST_VFBI"},
            { "2F","0150",  "2F","6150",    "CPBOOST_LDO_OUT"},
            { "2F","0150",  "2F","8150",    "CPBOOST_TIEL1"},
            { "2F","0150",  "2F","A150",    "CPBOOST_TIEH1"},
            { "2F","0150",  "2F","C150",    "CPBOOST_TIEL2"},
            { "2F","0150",  "2F","E150",    "CPBOOST_TIEH2"},
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
        };
        public string[,] atbTable_2218R_V100 = new string[,] { };

        #endregion

        #region 个别atb配置第三个寄存器，才能生效参数
        public string[,] atbAidReg = new[,]
        {
            { "2D", "0001"},//2218 DRV_CELL_ATB_EN
            { "1F", "0000"},//OUT_EN disable
        };
        #endregion
        public void AtbNodeRegCfg(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib, int index)
        {
            dChipComFunLib.para_St.addrOfst = 0;
            dChipComFunLib.para_St.tbregOptLength.Text = "06";
            dChipComFunLib.WriteReg(usbLib, dChipComFunLib.para_St.atbScan[index, 0], dChipComFunLib.para_St.atbScan[index, 1]);
            if (dChipComFunLib.para_St.atbScan[index, 2] != dChipComFunLib.para_St.atbScan[index, 0])
            {
                comFunLib.DelayTimeMs(300);
                dChipComFunLib.WriteReg(usbLib, dChipComFunLib.para_St.atbScan[index, 3], dChipComFunLib.para_St.atbScan[index, 2]);
            }
            //个别atb需要配置第三个寄存器
            if (dChipComFunLib.para_St.atbScan[index, 1] == "0130")
            {
                dChipComFunLib.WriteReg(usbLib, atbAidReg[0, 0], atbAidReg[0, 1]);
            }
            if (dChipComFunLib.para_St.atbScan[index, 4] == "CPPLL_VCTRL")
            {
                dChipComFunLib.WriteReg(usbLib, atbAidReg[1, 0], atbAidReg[1, 1]);
            }
        }
        public void AtbDebugTest(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib)
        {
            GetInstHandle(dChipComFunLib);
            tbAtbResult.Clear();
            AtbNodeRegCfg(dChipComFunLib, usbLib, dChipComFunLib.para_St.cmbAtbNodeName.SelectedIndex);
            comFunLib.DelayTimeMs(500);
            if (dChipComFunLib.para_St.cbMultiSelEn.Checked)
            {
                instCmdLib.SetMultiMeasMode(mbsMulti, InstCommandLib.READ_TYPE_EN.VOLT, InstCommandLib.MEASURE_MODE_EN.DC);//设置万用表为电压模式
                instCmdLib.ReadMulti(mbsMulti, ref volt);  //读取电压
            }
            tbAtbResult.AppendText(volt.ToString("F6") + "  " + instCmdLib.var_st.dataUnit);
        }
        public void AtbAutoSweep(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib)
        {
            string title = CommTitle + "TOP_Atb(Addr)\tTOP_Atb(Cfg)\tATB_Ctrl(Addr)\tATB_Ctrl(Cfg)\tATB_Name\tValue\tunit";
            comFunLib.CreatFileWriteTitle(dChipComFunLib.para_St.cbProjectItems.Text, dChipComFunLib.para_St.tbTestMessage.Text, dChipComFunLib.dataList, title);

            double volt = 0;
            for (int i = 0; i < dChipComFunLib.para_St.cmbAtbNodeName.Items.Count; i++)
            {
                AtbNodeRegCfg(dChipComFunLib, usbLib, i);
                comFunLib.DelayTimeMs(1000);
                ResultTitleSave(dChipComFunLib);
                dChipComFunLib.dataList.Add(dChipComFunLib.para_St.atbScan[i, 0]);
                dChipComFunLib.dataList.Add(dChipComFunLib.para_St.atbScan[i, 1]);
                dChipComFunLib.dataList.Add(dChipComFunLib.para_St.atbScan[i, 2]);
                dChipComFunLib.dataList.Add(dChipComFunLib.para_St.atbScan[i, 3]);
                dChipComFunLib.dataList.Add(dChipComFunLib.para_St.atbScan[i, 4]);
                if (dChipComFunLib.para_St.cbMultiSelEn.Checked)
                {
                    instCmdLib.SetMultiMeasMode(mbsMulti, InstCommandLib.READ_TYPE_EN.VOLT, InstCommandLib.MEASURE_MODE_EN.DC);//设置万用表为电压模式
                    instCmdLib.ReadMulti(mbsMulti, ref volt);  //读取电压
                }
                dChipComFunLib.dataList.Add(volt.ToString("F4"));
                dChipComFunLib.dataList.Add(instCmdLib.var_st.dataUnit);
                comFunLib.WriteDataToTxt(dChipComFunLib.dataList);
                dChipComFunLib.dataList.Clear();
                rtbDisPlay.AppendText(dChipComFunLib.para_St.atbScan[i, 4] + "\t" + volt.ToString("F4") + "\t" + instCmdLib.var_st.dataUnit + "\n");   //显示实时测量信息
                rtbDisPlay.ScrollToCaret();
                if (dChipComFunLib.para_St.stop)
                {
                    dChipComFunLib.para_St.stop = false;
                    break;
                }

            }
        }
        #endregion

        #region 2. VBG Trim Test
        string[,] vbgTrim_2218_V20X = new string[,] {
                {"21","0000" },  //通道关闭
                {"2F","1D10" },  //ATB输出VBG
                {"28","00D8" },  //VBG trim 使能
                {"27","1010" },  //code 调节
        };
        string[,] vbgTrim_2318_V100 = new string[,] {
                {"1F","0000" },  //通道关闭
                {"2D","1D10" },  //ATB输出VBG
                {"26","00D8" },  //VBG trim 使能
                {"25","1010" },  //code 调节
        };
        string[,] vbgTrim_2218R_V100 = new string[,] {
        };
        public void VbgAutoTrim(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib)
        {
            string title = CommTitle + "VbgCode\tValue(v)";
            comFunLib.CreatFileWriteTitle(dChipComFunLib.para_St.cbProjectItems.Text, dChipComFunLib.para_St.tbTestMessage.Text, dChipComFunLib.dataList, title);
            rtbDisPlay.AppendText("Reg Addr" + "\t" + "Reg配置值" + "\t" + "Vbg电压值" + "\n");

            for (int i = 0; i < dChipComFunLib.para_St.VbgTrim.GetLength(0); i++)
            {
                dChipComFunLib.WriteReg(usbLib, dChipComFunLib.para_St.VbgTrim[i, 0], dChipComFunLib.para_St.VbgTrim[i, 1]);
                comFunLib.DelayTimeMs(200);
            }
            double volt = 0;
            for (int code = 0; code < 32; code++)
            {
                string vbgTrimCode = "10" + code.ToString("X2");
                dChipComFunLib.WriteReg(usbLib, dChipComFunLib.para_St.VbgTrim[3, 0], vbgTrimCode);
                ResultTitleSave(dChipComFunLib);
                dChipComFunLib.dataList.Add(vbgTrimCode);
                comFunLib.DelayTimeMs(500);
                if (dChipComFunLib.para_St.cbMultiSelEn.Checked)
                {
                    instCmdLib.SetMultiMeasMode(mbsMulti, InstCommandLib.READ_TYPE_EN.VOLT, InstCommandLib.MEASURE_MODE_EN.DC);
                    instCmdLib.ReadMulti(mbsMulti, ref volt);  //读取电压
                }
                dChipComFunLib.dataList.Add(volt.ToString("F4"));
                comFunLib.WriteDataToTxt(dChipComFunLib.dataList);
                dChipComFunLib.dataList.Clear();
                rtbDisPlay.AppendText(dChipComFunLib.para_St.VbgTrim[3, 0] + "\t" + vbgTrimCode + "\t" + volt.ToString("F4") + "\t" + instCmdLib.var_st.dataUnit + "\n");   //显示实时测量信息
                rtbDisPlay.ScrollToCaret();
                if (dChipComFunLib.para_St.stop)
                {
                    dChipComFunLib.para_St.stop = false;
                    break;
                }
            }
        }
        #endregion

        #region 3. Pre Driver Volt Test
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
        #region preDrv_Table
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
        public string[,] preDrv_2318R_V100 = new string[,] {
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
        #endregion

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
        public void PreDrvResults(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib, double vbg, int bit5, int cell, string addr, double volt)
        {
            for (int i = 0x0000; i < (bit5 == 0 ? 0x1F1 : 0x3F1); i += 16)
            {
                dChipComFunLib.WriteReg(usbLib, addr, i.ToString("X4"));
                comFunLib.DelayTimeMs(1000);
                dChipComFunLib.dataList.Add(dChipComFunLib.para_St.cbProjectItems.Text);
                dChipComFunLib.dataList.Add(dChipComFunLib.para_St.tbChipID.Text);
                dChipComFunLib.dataList.Add(vbg.ToString("F4"));
                dChipComFunLib.dataList.Add(cell == 1 || i > 0x1F0 ? "1" : "0");
                dChipComFunLib.dataList.Add(i.ToString("X4"));
                if (dChipComFunLib.para_St.cbMultiSelEn.Checked)
                {
                    instCmdLib.SetMultiMeasMode(mbsMulti, InstCommandLib.READ_TYPE_EN.VOLT, InstCommandLib.MEASURE_MODE_EN.DC);//设置万用表为电压模式
                    instCmdLib.ReadMulti(mbsMulti, ref volt);  //读取电压
                }
                dChipComFunLib.dataList.Add(volt.ToString("F4"));
                comFunLib.WriteDataToTxt(dChipComFunLib.dataList);
                dChipComFunLib.dataList.Clear();
                rtbDisPlay.AppendText(addr + "\t" + (i.ToString("x4")).ToUpper() + "\t" + volt.ToString("F4") + "\t" + instCmdLib.var_st.dataUnit + "\n");   //显示实时测量信息
                rtbDisPlay.ScrollToCaret();
                if (dChipComFunLib.para_St.stop)
                {
                    dChipComFunLib.para_St.stop = false;
                    break;
                }
            }
        }
        public void PreDriver(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib)
        {
            string title = CommTitle + "VBG(V)\tCoarseReg\tCode\tFineReg\tCode\tVolt(V)";
            comFunLib.CreatFileWriteTitle(dChipComFunLib.para_St.cbProjectItems.Text, dChipComFunLib.para_St.tbTestMessage.Text, dChipComFunLib.dataList, title);
            rtbDisPlay.AppendText("CoarseReg Addr" + "\t" + "Reg配置值" + "\t" + "FineReg Addr" + "\t" + "Reg配置值" + "\t" + "PreDrv电压值" + "\n");

            string regValue;
            bool tuneFlag = true;
            bool ResFlag = false;
            double volt = 0;
            double vbg = VbgConfig(dChipComFunLib, usbLib, vbgTarget);
            //关闭通道输出、预驱动使能、ATB输出预驱动电压
            for (int i = 0; i < dChipComFunLib.para_St.preDrv.GetLength(0) - 2; i++)
            {
                dChipComFunLib.WriteReg(usbLib, dChipComFunLib.para_St.preDrv[i, 0], dChipComFunLib.para_St.preDrv[i, 1]);
                comFunLib.DelayTimeMs(500);
            }

            for (int i = 0; i < 64; i++)
            {
                int tuneLevel = 1;
                if (dChipComFunLib.para_St.cbProjectItems.Text.Contains("2218"))
                {
                    regValue = i.ToString("X3") + "0";
                    tuneLevel = i < 32 ? 1 : 0;
                }
                else
                {
                    if (i >= 32 && tuneFlag)
                    {
                        regValue = "1000";
                        dChipComFunLib.WriteReg(usbLib, dChipComFunLib.para_St.preDrv[4, 0], regValue);
                        tuneFlag = false;
                        ResFlag = true;
                    }
                    regValue = i < 32 ? i.ToString("X3") + "0" : (i - 32).ToString("X3") + "0";

                }
                dChipComFunLib.WriteReg(usbLib, dChipComFunLib.para_St.preDrv[tuneLevel + 4, 0], regValue);
                ResultTitleSave(dChipComFunLib);
                dChipComFunLib.dataList.Add(vbg.ToString("F4"));
                dChipComFunLib.dataList.Add(dChipComFunLib.para_St.preDrv[4, 0]);
                if (dChipComFunLib.para_St.cbProjectItems.Text.Contains("2318"))
                {
                    dChipComFunLib.dataList.Add(tuneFlag ? "0000" : "1000");
                }
                else
                {
                    dChipComFunLib.dataList.Add(regValue);
                }
                dChipComFunLib.dataList.Add(dChipComFunLib.para_St.preDrv[5, 0]);
                dChipComFunLib.dataList.Add(regValue);
                comFunLib.DelayTimeMs(500);
                if (dChipComFunLib.para_St.cbMultiSelEn.Checked)
                {
                    instCmdLib.SetMultiMeasMode(mbsMulti, InstCommandLib.READ_TYPE_EN.VOLT, InstCommandLib.MEASURE_MODE_EN.DC);
                    instCmdLib.ReadMulti(mbsMulti, ref volt);
                }
                dChipComFunLib.dataList.Add(volt.ToString("F4"));
                comFunLib.WriteDataToTxt(dChipComFunLib.dataList);
                dChipComFunLib.dataList.Clear();
                rtbDisPlay.AppendText(dChipComFunLib.para_St.preDrv[4, 0] + "\t" + (tuneFlag ? (ResFlag ? regValue : "0000") : "1000") + "\t" + dChipComFunLib.para_St.preDrv[5, 0] + "\t" + regValue + "\t" + volt.ToString("F4") + "\t" + instCmdLib.var_st.dataUnit + "\n");   //显示实时测量信息
                rtbDisPlay.ScrollToCaret();
                if (dChipComFunLib.para_St.stop)
                {
                    dChipComFunLib.para_St.stop = false;
                    break;
                }
            }
        }
        #endregion

        #region 4. GCC_IFIX Trim Test

        string[,] GccIfix_2218_V20X = new string[,] {
                {"21","0001" },  //OUT_EN
                {"28","00D8" },  //VBG trim 使能
                {"27","100A" },  //Vbg电压调节至1.2V附近
                {"2C","0001" },  //电流模式
                {"02","0004" },  //PAM设置为2
                {"18","0244" },  //LowKnee电压设置为150mV
                {"17","0007" },  //顶层GCC设置为1
        };
        string[,] GccIfix_2318_V100 = new string[,] {
                {"1F","0001" },  //OUT_EN
                {"26","00D8" },  //VBG trim 使能
                {"25","1008" },  //Vbg电压调节至1.2V附近
                {"2A","0001" },  //电流模式
                {"02","0001" },  //PAM设置为4
                {"15","0024" },  //LowKnee电压设置为150mV
                {"14","001F" },  //顶层GCC设置为1
        };
        string[,] GccIfix_2218R_V100 = new string[,] {
        };

        public void GccIfixTrim(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib)
        {
            string title = CommTitle + "VBG(V)\tGccIfixCode\tValue(uA)";
            comFunLib.CreatFileWriteTitle(dChipComFunLib.para_St.cbProjectItems.Text, dChipComFunLib.para_St.tbTestMessage.Text, dChipComFunLib.dataList, title);
            rtbDisPlay.AppendText("Reg Addr" + "\t" + "Reg配置值" + "\t" + "GCCIfix电流值" + "\n");

            double Curr = 0;
            double vbg = VbgConfig(dChipComFunLib, usbLib, vbgTarget);
            for (int i = 0; i < dChipComFunLib.para_St.GccIfix.GetLength(0); i++)
            {
                dChipComFunLib.WriteReg(usbLib, dChipComFunLib.para_St.GccIfix[i, 0], dChipComFunLib.para_St.GccIfix[i, 1]);
                comFunLib.DelayTimeMs(500);
            }
            for (int i = 0; i < 32; i++)
            {
                string GccRegValue = i.ToString("X2") + dChipComFunLib.para_St.GccIfix[2, 1].Substring(2, 2);
                dChipComFunLib.WriteReg(usbLib, dChipComFunLib.para_St.GccIfix[2, 0], GccRegValue);
                ResultTitleSave(dChipComFunLib);
                dChipComFunLib.dataList.Add(vbg.ToString("F4"));
                dChipComFunLib.dataList.Add(GccRegValue);
                comFunLib.DelayTimeMs(500);
                if (dChipComFunLib.para_St.cbMultiSelEn1.Checked)
                {
                    instCmdLib.SetMultiMeasMode(mbsMulti1, InstCommandLib.READ_TYPE_EN.CURR, InstCommandLib.MEASURE_MODE_EN.DC);//设置万用表为电流模式
                    instCmdLib.ReadMulti(mbsMulti1, ref Curr);  //读取电流
                }
                dChipComFunLib.dataList.Add(Curr.ToString("F4"));
                comFunLib.WriteDataToTxt(dChipComFunLib.dataList);
                dChipComFunLib.dataList.Clear();
                rtbDisPlay.AppendText(dChipComFunLib.para_St.GccIfix[2, 0] + "\t" + GccRegValue + "\t" + Curr.ToString("F4") + "\t" + instCmdLib.var_st.dataUnit + "\n");   //显示实时测量信息
                rtbDisPlay.ScrollToCaret();
                if (dChipComFunLib.para_St.stop)
                {
                    dChipComFunLib.para_St.stop = false;
                    break;
                }
            }
        }
        #endregion

        #region 5. Driver PAM Trim Test

        string[,] DrvPAM_2218_V20X = new string[,] {
                {"21","0001" },  //OUT_EN
                {"28","00D8" },  //VBG trim 使能
                {"27","100B" },  //Vbg电压调节至1.2V附近
                {"2C","0001" },  //电流模式
                {"02","0004" },  //PAM设置为2
                {"18","0244" },  //LowKnee电压设置为150mV
        };
        string[,] DrvPAM_2318_V100 = new string[,] {
                {"1F","0001" },  //OUT_EN
                {"26","00D8" },  //VBG trim 使能
                {"25","1008" },  //Vbg电压调节至1.2V附近
                {"2A","0001" },  //电流模式
                {"02","0001" },  //PAM设置为4
                {"15","0024" },  //LowKnee电压设置为150mV
        };
        string[,] GCCGain_2218_V20x = new string[,]{
                //GCCbase   addr   寄存器配置值   
                {"100uA","17","0007" },
                {"200uA","17","004F" },
                {"400uA","17","009F" },
                {"800uA","17","00F4" },
        };
        string[,] GCCGain_2318_V100 = new string[,]{
                //GCCbase   addr   寄存器配置值   
                //{"100uA","14","0007" },
                //{"200uA","14","003F" },
                //{"400uA","14","0080" },
                {"800uA","14","00FF" },
        };
        public void DrvPAMTrim(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib)
        {
            string title = CommTitle + "VBG(V)\tGCCGain\tPAMAddr\tPAMCode\tValue(mA)";
            comFunLib.CreatFileWriteTitle(dChipComFunLib.para_St.cbProjectItems.Text, dChipComFunLib.para_St.tbTestMessage.Text, dChipComFunLib.dataList, title);
            rtbDisPlay.AppendText("GCCout" + "\t" + "PAM_Reg Addr" + "\t" + "Reg配置值" + "\t" + "DrvPAM电流值" + "\n");

            int GainFlag = 0;
            double Curr = 0;
            double vbg = VbgConfig(dChipComFunLib, usbLib, vbgTarget);
            for (int i = 0; i < dChipComFunLib.para_St.DrvPAM.GetLength(0); i++)
            {
                dChipComFunLib.WriteReg(usbLib, dChipComFunLib.para_St.DrvPAM[i, 0], dChipComFunLib.para_St.DrvPAM[i, 1]);
                comFunLib.DelayTimeMs(500);
            }
            while (GainFlag < dChipComFunLib.para_St.GccGain.GetLength(0))
            {
                dChipComFunLib.WriteReg(usbLib, dChipComFunLib.para_St.GccGain[GainFlag, 1], dChipComFunLib.para_St.GccGain[GainFlag, 2]);
                comFunLib.DelayTimeMs(500);
                for (int i = 0; i < 16; i++)
                {
                    string PAMregValue = "10" + i.ToString("X2");
                    dChipComFunLib.WriteReg(usbLib, dChipComFunLib.para_St.DrvPAM[4, 0], PAMregValue);
                    ResultTitleSave(dChipComFunLib);
                    dChipComFunLib.dataList.Add(vbg.ToString("F4"));
                    dChipComFunLib.dataList.Add(dChipComFunLib.para_St.GccGain[GainFlag, 0]);
                    dChipComFunLib.dataList.Add(dChipComFunLib.para_St.DrvPAM[4, 0]);
                    dChipComFunLib.dataList.Add(PAMregValue);
                    comFunLib.DelayTimeMs(500);
                    if (dChipComFunLib.para_St.cbMultiSelEn1.Checked)
                    {
                        instCmdLib.SetMultiMeasMode(mbsMulti1, InstCommandLib.READ_TYPE_EN.CURR, InstCommandLib.MEASURE_MODE_EN.DC);//设置万用表为电流模式
                        instCmdLib.ReadMulti(mbsMulti1, ref Curr);  //读取电流
                    }
                    dChipComFunLib.dataList.Add(Curr.ToString("F4"));
                    comFunLib.WriteDataToTxt(dChipComFunLib.dataList);
                    dChipComFunLib.dataList.Clear();
                    rtbDisPlay.AppendText(dChipComFunLib.para_St.GccGain[GainFlag, 0] + "\t" + dChipComFunLib.para_St.DrvPAM[4, 0] + "\t" + PAMregValue + "\t" + Curr.ToString("F4") + "\t" + instCmdLib.var_st.dataUnit + "\n");   //显示实时测量信息
                    rtbDisPlay.ScrollToCaret();
                    if (dChipComFunLib.para_St.stop)
                    {
                        dChipComFunLib.para_St.stop = false;
                        break;
                    }
                }
                GainFlag++;
            }

        }
        #endregion

        #region 6. Regulator Trim Test

        string[,] Regulator_2218_V20X = new string[,] {
                {"LDO_SYS","LDO_CPPLL" },  //LDO Name
                {"28","00D8" },  //VBG trim 使能
                {"27","100A" },  //Vbg电压调节至1.2V附近
                {"2F","0160" },  //LDO_SYS_TOP_ATB_EN
                {"2E","0030" },  //LDO_SYS_OUT
                {"19","0048" },  //LDO_VREF_TRIM
        };
        string[,] Regulator_2318_V100 = new string[,] {
                {"LDO_SYS","LDO_CPPLL" },  //LDO Name
                {"26","00D8" },  //VBG trim 使能
                {"25","1008" },  //Vbg电压调节至1.2V附近
                {"2D","0160" },  //LDO_SYS_TOP_ATB_EN
                {"2C","0030" },  //LDO_SYS_OUT
                {"17","0180" },  //LDO_VREF_TRIM
        };
        string[,] Regulator_2318R_V100 = new string[,] {
                {"LDO_SYS","LDO_CPPLL" },  //LDO Name
                {"26","00D8" },  //VBG trim 使能
                {"25","1008" },  //Vbg电压调节至1.2V附近
                {"2D","0170" },  //LDO_CPPLL_TOP_ATB_EN
                {"2C","0001" },  //LDO_CPPLL_OUT
                {"17","0180" },  //LDO_VREF_TRIM
        };
        public void RegulatorTrim(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib)
        {
            int LDOCase = 1;
            string regValue;
            string title = CommTitle + "VBG(V)\tLDO Name\tLDO_VREF_Trim Code\tValue(V)";
            comFunLib.CreatFileWriteTitle(dChipComFunLib.para_St.cbProjectItems.Text, dChipComFunLib.para_St.tbTestMessage.Text, dChipComFunLib.dataList, title);
            rtbDisPlay.AppendText("LDO Name：" + dChipComFunLib.para_St.Regulator[0, LDOCase] + "\n" + "Reg Addr" + "\t" + "Reg配置值" + "\t" + "LDO电压值" + "\n");

            double volt = 0;
            double vbg = VbgConfig(dChipComFunLib, usbLib, vbgTarget);

            for (int i = 1; i < dChipComFunLib.para_St.Regulator.GetLength(0); i++)
            {
                dChipComFunLib.WriteReg(usbLib, dChipComFunLib.para_St.Regulator[i, 0], dChipComFunLib.para_St.Regulator[i, 1]);
                comFunLib.DelayTimeMs(500);
            }

            for (int i = 0; i < 8; i++)
            {
                if (dChipComFunLib.para_St.cbProjectItems.Text.Contains("2318"))
                {
                    regValue = dChipComFunLib.para_St.Regulator[5, 1].Substring(0, 2) + (8 + i).ToString("X1") + dChipComFunLib.para_St.Regulator[5, 1].Substring(3, 1);
                }
                else
                {
                    regValue = dChipComFunLib.para_St.Regulator[5, 1].Substring(0, 3) + (8 + i).ToString("X1");
                }
                dChipComFunLib.WriteReg(usbLib, dChipComFunLib.para_St.Regulator[5, 0], regValue);
                ResultTitleSave(dChipComFunLib);
                dChipComFunLib.dataList.Add(vbg.ToString("F4"));
                dChipComFunLib.dataList.Add(regValue);
                comFunLib.DelayTimeMs(500);
                if (dChipComFunLib.para_St.cbMultiSelEn.Checked)
                {
                    instCmdLib.SetMultiMeasMode(mbsMulti, InstCommandLib.READ_TYPE_EN.VOLT, InstCommandLib.MEASURE_MODE_EN.DC);
                    instCmdLib.ReadMulti(mbsMulti, ref volt);
                }
                dChipComFunLib.dataList.Add(volt.ToString("F4"));
                comFunLib.WriteDataToTxt(dChipComFunLib.dataList);
                dChipComFunLib.dataList.Clear();
                rtbDisPlay.AppendText(dChipComFunLib.para_St.Regulator[5, 0] + "\t" + regValue + "\t" + volt.ToString("F4") + "\t" + instCmdLib.var_st.dataUnit + "\n");   //显示实时测量信息
                rtbDisPlay.ScrollToCaret();
                if (dChipComFunLib.para_St.stop)
                {
                    dChipComFunLib.para_St.stop = false;
                    break;
                }
            }

        }

        #endregion

        #region 7. VBG_Vmin

        public void VbgVmin(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib)
        {
            string title = CommTitle + "SourceVolt(v)\tVbg(v)";
            comFunLib.CreatFileWriteTitle(dChipComFunLib.para_St.cbProjectItems.Text, dChipComFunLib.para_St.tbTestMessage.Text, dChipComFunLib.dataList, title);
            rtbDisPlay.AppendText("SourceVolt/V" + "\t" + "Vbg电压值" + "\n");

            double Vbg;
            double initialVolt = PwrVoltSetOrRead(dChipComFunLib, 2, exCommand[1]);
            for (double startVolt = initialVolt; startVolt >= 2.0; startVolt -= 0.1)
            {
                PwrVoltSetOrRead(dChipComFunLib, 2, exCommand[0], startVolt);
                comFunLib.DelayTimeMs(500);
                startVolt = PwrVoltSetOrRead(dChipComFunLib, 2, exCommand[1]);
                Vbg = GetVbgVolt(dChipComFunLib, usbLib);
                ResultTitleSave(dChipComFunLib);
                dChipComFunLib.dataList.Add(startVolt.ToString("F4"));
                dChipComFunLib.dataList.Add(Vbg.ToString("F4"));
                comFunLib.WriteDataToTxt(dChipComFunLib.dataList);
                dChipComFunLib.dataList.Clear();
                rtbDisPlay.AppendText(startVolt.ToString("F4") + "\t" + Vbg.ToString("F4") + "  " + instCmdLib.var_st.dataUnit + "\n");
                rtbDisPlay.ScrollToCaret();
                if (dChipComFunLib.para_St.stop)
                {
                    dChipComFunLib.para_St.stop = false;
                    break;
                }
            }
            comFunLib.DelayTimeMs(500);
            PwrVoltSetOrRead(dChipComFunLib, 2, exCommand[0], initialVolt);
        }
        #endregion

        #region 8. Bias_Vmin

        public void BiasVmin(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib)
        {
            string title = CommTitle + "Vbg(v)\tSourceVolt(v)\tBias400(uA)";
            comFunLib.CreatFileWriteTitle(dChipComFunLib.para_St.cbProjectItems.Text, dChipComFunLib.para_St.tbTestMessage.Text, dChipComFunLib.dataList, title);
            rtbDisPlay.AppendText("SourceVolt/V" + "\t" + "Bias400/uA" + "\n");

            double Curr = 0;
            double vbg = VbgConfig(dChipComFunLib, usbLib, vbgTarget);
            for (int i = 0; i < dChipComFunLib.para_St.GccIfix.GetLength(0); i++)
            {
                dChipComFunLib.WriteReg(usbLib, dChipComFunLib.para_St.GccIfix[i, 0], dChipComFunLib.para_St.GccIfix[i, 1]);
                comFunLib.DelayTimeMs(500);
            }
            double beginVolt = PwrVoltSetOrRead(dChipComFunLib, 2, exCommand[1]);
            for (double startVolt = beginVolt; startVolt > 2.0; startVolt -= 0.1)
            {
                PwrVoltSetOrRead(dChipComFunLib, 2, exCommand[0], startVolt);
                comFunLib.DelayTimeMs(500);
                startVolt = PwrVoltSetOrRead(dChipComFunLib, 2, exCommand[1]);
                if (dChipComFunLib.para_St.cbMultiSelEn1.Checked)
                {
                    instCmdLib.SetMultiMeasMode(mbsMulti1, InstCommandLib.READ_TYPE_EN.CURR, InstCommandLib.MEASURE_MODE_EN.DC);
                    instCmdLib.ReadMulti(mbsMulti1, ref Curr);  //读取电流
                }
                ResultTitleSave(dChipComFunLib);
                dChipComFunLib.dataList.Add(vbg.ToString("F4"));
                dChipComFunLib.dataList.Add(startVolt.ToString("F4"));
                dChipComFunLib.dataList.Add(Curr.ToString("F4"));
                comFunLib.WriteDataToTxt(dChipComFunLib.dataList);
                dChipComFunLib.dataList.Clear();
                rtbDisPlay.AppendText(startVolt.ToString("F4") + "  " + "\t" + Curr.ToString("F4") + "  " + instCmdLib.var_st.dataUnit + "\n");
                rtbDisPlay.ScrollToCaret();
                if (dChipComFunLib.para_St.stop)
                {
                    dChipComFunLib.para_St.stop = false;
                    break;
                }
            }
            comFunLib.DelayTimeMs(500);
            PwrVoltSetOrRead(dChipComFunLib, 2, exCommand[1], beginVolt);
        }
        #endregion

        #region 9. Regulator_Vmin

        public void LDOVmin(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib)
        {
            string title = CommTitle + "Vbg(v)\tSourceVolt(v)\tVldo(v)";
            comFunLib.CreatFileWriteTitle(dChipComFunLib.para_St.cbProjectItems.Text, dChipComFunLib.para_St.tbTestMessage.Text, dChipComFunLib.dataList, title);
            rtbDisPlay.AppendText("SourceVolt/V" + "\t" + "Vbg/V" + "\t" + "Vldo/V" + "\n");

            double Vldo = 0;
            double initialVolt = PwrVoltSetOrRead(dChipComFunLib, 2, exCommand[1]);
            VbgConfig(dChipComFunLib, usbLib, vbgTarget);

            for (double startVolt = initialVolt; startVolt >= 2.0; startVolt -= 0.1)
            {
                PwrVoltSetOrRead(dChipComFunLib, 2, exCommand[0], startVolt);
                comFunLib.DelayTimeMs(300);
                startVolt = PwrVoltSetOrRead(dChipComFunLib, 2, exCommand[1]);
                double Vbg = GetVbgVolt(dChipComFunLib, usbLib);
                for (int i = 1; i < dChipComFunLib.para_St.Regulator.GetLength(0); i++)
                {
                    dChipComFunLib.WriteReg(usbLib, dChipComFunLib.para_St.Regulator[i, 0], dChipComFunLib.para_St.Regulator[i, 1]);
                    comFunLib.DelayTimeMs(200);
                }
                if (dChipComFunLib.para_St.cbMultiSelEn.Checked)
                {
                    instCmdLib.SetMultiMeasMode(mbsMulti, InstCommandLib.READ_TYPE_EN.VOLT, InstCommandLib.MEASURE_MODE_EN.DC);
                    instCmdLib.ReadMulti(mbsMulti, ref Vldo);
                }
                ResultTitleSave(dChipComFunLib);
                dChipComFunLib.dataList.Add(Vbg.ToString("F4"));
                dChipComFunLib.dataList.Add(startVolt.ToString("F4"));
                dChipComFunLib.dataList.Add(Vldo.ToString("F4"));
                comFunLib.WriteDataToTxt(dChipComFunLib.dataList);
                dChipComFunLib.dataList.Clear();
                rtbDisPlay.AppendText(startVolt.ToString("F4") + "\t" + Vbg.ToString("F4") + "\t" + Vldo.ToString("F4") + "  " + instCmdLib.var_st.dataUnit + "\n");
                rtbDisPlay.ScrollToCaret();
                if (dChipComFunLib.para_St.stop)
                {
                    dChipComFunLib.para_St.stop = false;
                    break;
                }
            }
            comFunLib.DelayTimeMs(500);
            PwrVoltSetOrRead(dChipComFunLib, 2, exCommand[0], initialVolt);

        }
        #endregion

        #region 10. LowKnee

        public void LowKnee(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib)
        {
            string title = CommTitle + "Vbg(v)\tSourceVolt(v)\tChannelCurr(mA)";
            comFunLib.CreatFileWriteTitle(dChipComFunLib.para_St.cbProjectItems.Text, dChipComFunLib.para_St.tbTestMessage.Text, dChipComFunLib.dataList, title);
            rtbDisPlay.AppendText("SourceVolt/V" + "\t" + "ChannelCurr(mA)" + "\n");

            double ChannelCurr = 0;
            double Vbg = VbgConfig(dChipComFunLib, usbLib, vbgTarget);
            double initialVolt = PwrVoltSetOrRead(dChipComFunLib, 2, exCommand[1]);
            for (double startVolt = initialVolt; startVolt >= 2.0; startVolt -= 0.1)
            {
                PwrVoltSetOrRead(dChipComFunLib, 2, exCommand[0], startVolt);
                comFunLib.DelayTimeMs(500);
                startVolt = PwrVoltSetOrRead(dChipComFunLib, 2, exCommand[1]);
                if (dChipComFunLib.para_St.cbMultiSelEn1.Checked)
                {
                    instCmdLib.SetMultiMeasMode(mbsMulti1, InstCommandLib.READ_TYPE_EN.CURR, InstCommandLib.MEASURE_MODE_EN.DC);
                    instCmdLib.ReadMulti(mbsMulti1, ref ChannelCurr);  //读取电流
                }
                ResultTitleSave(dChipComFunLib);
                dChipComFunLib.dataList.Add(Vbg.ToString("F4"));
                dChipComFunLib.dataList.Add(startVolt.ToString("F4"));
                comFunLib.WriteDataToTxt(dChipComFunLib.dataList);
                dChipComFunLib.dataList.Clear();
                rtbDisPlay.AppendText(startVolt.ToString("F4") + "\t" + Vbg.ToString("F4") + "  " + instCmdLib.var_st.dataUnit + "\n");
                rtbDisPlay.ScrollToCaret();
                if (dChipComFunLib.para_St.stop)
                {
                    dChipComFunLib.para_St.stop = false;
                    break;
                }
            }
            comFunLib.DelayTimeMs(500);
            PwrVoltSetOrRead(dChipComFunLib, 2, exCommand[0], initialVolt);

        }
        #endregion

        #region 11. CPPLL Tuning Range Trim Test  todo...

        public void VcoTunningRange(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib)
        {

        }
        #endregion

        #region AutoTest Main 在此增加自动化测试项
        public bool AutoTest(DriverChipCommonFunctionLib dChipComFunLib, USB_PortLib usbLib, string testItem)
        {
            GetInstHandle(dChipComFunLib);
            GetProjectName(dChipComFunLib);
            PowerOnOffControl(dChipComFunLib);

            dChipComFunLib.para_St.addrOfst = 0;
            dChipComFunLib.para_St.tbregOptLength.Text = "06";
            rtbDisPlay.AppendText(dChipComFunLib.para_St.tbTestMessage.Text + "\n\n");    //显示项目测试信息  
            Application.DoEvents();
            if (dChipComFunLib.para_St.stop) return false;

            switch (testItem)
            {
                case "ATB_Scan":
                    AtbAutoSweep(dChipComFunLib, usbLib);
                    break;
                case "VBG_Trim":
                    VbgAutoTrim(dChipComFunLib, usbLib);
                    break;
                case "GCC_IFIX":
                    GccIfixTrim(dChipComFunLib, usbLib);
                    break;
                case "PreDrv":
                    PreDriver(dChipComFunLib, usbLib);
                    break;
                case "Drv_PAM":
                    DrvPAMTrim(dChipComFunLib, usbLib);
                    break;
                case "Regulator_Trim":
                    RegulatorTrim(dChipComFunLib, usbLib);
                    break;
                case "VBG_Vmin":
                    VbgVmin(dChipComFunLib, usbLib);
                    break;
                case "Bias400u_Vmin":
                    BiasVmin(dChipComFunLib, usbLib);
                    break;
                case "Regulator_Vmin":
                    LDOVmin(dChipComFunLib, usbLib);
                    break;
                case "LowKnee":
                    LowKnee(dChipComFunLib, usbLib);
                    break;
                case "VcoTunningRange":
                    VcoTunningRange(dChipComFunLib, usbLib);
                    break;

                default:
                    break;
            }
            return false;
        }
        #endregion
    }
}

