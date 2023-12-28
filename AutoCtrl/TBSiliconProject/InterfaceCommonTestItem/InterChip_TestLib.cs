using System;
using NationalInstruments.Visa;
using AutoCtrl.InstCommonCtrl;
using AutoCtrl.InstCommandCtrl;
using AutoCtrl.CommonFunction;
using AutoCtrl.CommunicationProtocol;
using System.Windows.Forms;

namespace AutoCtrl.TBSiliconProject.InterFaceCommonTestItem
{
    public class InterChip_TestLib
    {
        public USB_PortLib usbAnalog = new USB_PortLib();
        public CommonFunctionLib comFunLib = new CommonFunctionLib();
        public InstCommandLib instCmdLib = new InstCommandLib();
        public InstCommonCtrlLib instCommLib = new InstCommonCtrlLib();
        public MessageBasedSession mbsPower, mbsMulti, mbsMulti1;
        public RichTextBox rtbInterChipDisPlay;
        public TextBox tbAtbResult;
        public int chipLocSelect = 0;
        public double volt = 0;

        #region 0. 公共函数：仪器连接|获取项目名称|...
        /// <summary>
        /// 获取和仪器连接的通信接口
        /// </summary>
        /// <param name="interChipComFunLib"></param>
        public void GetInstHandle(InterChipCommLib interChipComFunLib)
        {

            bool EnableStatus = interChipComFunLib.para_St.cbMultiSelEn.Checked || interChipComFunLib.para_St.cbMultiSelEn1.Checked || interChipComFunLib.para_St.cbPowerSelEn.Checked;
            bool AddrStatus = interChipComFunLib.para_St.tbInstMultiAddr.Text == null || interChipComFunLib.para_St.tbInstMultiAddr1.Text == null
                || interChipComFunLib.para_St.tbInstPowerAddr.Text == null;
            if (interChipComFunLib.para_St.cbMultiSelEn.Checked)
            {
                instCommLib.InstrumentLink(ref mbsMulti, interChipComFunLib.para_St.tbInstMultiAddr.Text.Trim());
            }
            if (interChipComFunLib.para_St.cbMultiSelEn1.Checked)
            {
                instCommLib.InstrumentLink(ref mbsMulti1, interChipComFunLib.para_St.tbInstMultiAddr1.Text.Trim());
            }
            if (interChipComFunLib.para_St.cbPowerSelEn.Checked)
            {
                instCommLib.InstrumentLink(ref mbsPower, interChipComFunLib.para_St.tbInstPowerAddr.Text.Trim());
            }
            if (EnableStatus)
            {
                if (AddrStatus)
                {
                    MessageBox.Show("请确认输入的仪器地址是否正确." + "\n" +
                    "1、电压测试时，万用表Addr0需填写仪器地址，且选择尾部方框" + "\n" +
                    "2、电流测试时，万用表Addr0和Addr1都需填写仪器地址，且选择尾部方框" + "\n");
                    interChipComFunLib.para_St.stop = true;
                }

            }
            else
            {
                MessageBox.Show("请选择测试需要仪器，并输入地址.");
                interChipComFunLib.para_St.stop = true;
            }
        }
        /// <summary>
        /// 根据所选择的项目名称,初始化对应测试的参数
        /// </summary>
        /// <param name="interChipComFunLib"></param>
        public void GetProjectName(InterChipCommLib interChipComFunLib)
        {
            switch (interChipComFunLib.para_St.cbProjectItems.Text)
            {
                case "P614":
                case "TBS614V102":
                    interChipComFunLib.para_St.atbScan = atbTable_TBS614;
                    interChipComFunLib.para_St.VbgTrim = vbgTrim_TBS614;
                    break;
                case "P615":

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
                if (atbTable[i, 4].Contains("QS_VREF_1200M"))
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
        /// <param name="interChipComFunLib"></param>
        /// <param name="usbLib"></param>
        /// <returns></returns>
        public double GetVbgVolt(InterChipCommLib interChipComFunLib, USB_PortLib usbLib)
        {
            double volt = 0;
            int vbgID = LookUpVbg(interChipComFunLib.para_St.atbScan);
            interChipComFunLib.WriteReg(usbLib, chipLocSelect, interChipComFunLib.para_St.atbScan[vbgID, 2], interChipComFunLib.para_St.atbScan[vbgID, 3]);
            comFunLib.DelayTimeMs(1000);
            if (interChipComFunLib.para_St.cbMultiSelEn.Checked)
            {
                instCmdLib.SetMultiMeasMode(mbsMulti, InstCommandLib.READ_TYPE_EN.VOLT, InstCommandLib.MEASURE_MODE_EN.DC);//设置万用表为电压模式
                instCmdLib.ReadMulti(mbsMulti, ref volt);  //读取电压
            }
            return volt;
        }
        /// <summary>
        /// 校准Vbg电压(将vbg电压校准至设定值configValue)
        /// </summary>
        /// <param name="interChipComFunLib"></param>
        /// <param name="usbLib"></param>
        /// <param name="configValue"></param>
        /// <returns></returns>
        public double VbgConfig(InterChipCommLib interChipComFunLib, USB_PortLib usbLib, double configValue)
        {
            int code = 10;
            string regCode = "10" + code.ToString("X2");
            interChipComFunLib.WriteReg(usbLib, chipLocSelect, interChipComFunLib.para_St.VbgTrim[3, 0], regCode);
            comFunLib.DelayTimeMs(300);
            double volt = GetVbgVolt(interChipComFunLib, usbLib);
            while (Math.Abs(volt - configValue) > 0.008)
            {
                if (interChipComFunLib.para_St.stop) break;
                code = (volt - configValue) > 0 ? ++code : --code;
                if (code < 0 || code > 15)
                    break;
                regCode = "10" + code.ToString("X2");
                interChipComFunLib.WriteReg(usbLib, chipLocSelect, interChipComFunLib.para_St.VbgTrim[3, 0], regCode);
                comFunLib.DelayTimeMs(300);
                volt = GetVbgVolt(interChipComFunLib, usbLib);
            }
            return volt;
        }
        /// <summary>
        /// 结果title公共部分
        /// </summary>
        /// <param name="interChipComFunLib"></param>
        public void ResultTitleSave(InterChipCommLib interChipComFunLib)
        {
            interChipComFunLib.dataList.Add(interChipComFunLib.para_St.cbProjectItems.Text);
            interChipComFunLib.dataList.Add(interChipComFunLib.para_St.cmbChipCorner.Text);
            interChipComFunLib.dataList.Add(interChipComFunLib.para_St.tbChipID.Text);
        }
        #region 电源控制
        /// <summary>
        /// 电源电压设置，pwrType——电源类型，pwrCH——电源通道，volt——设置电压值，exeModule——执行类型"设置电压"or"读取电压"
        /// </summary>
        /// <param name="interChipComFunLib"></param>
        /// <param name="pwrType"></param>
        /// <param name="pwrCH"></param>
        /// <param name="volt"></param>
        /// <param name="exeModule"></param>
        /// <returns></returns>
        string[] exCommand = new string[] { "Set", "Read" };
        public double PwrVoltSetOrRead(InterChipCommLib interChipComFunLib, int pwrCH, string exeModule, double volt = 3.8)
        {
            string pwrType = interChipComFunLib.para_St.cbPwrType.Checked ? "KeySight" : "GuWei";
            bool[] EnPwrCh = new bool[]{ interChipComFunLib.para_St.cbEnPwrCH1.Checked, interChipComFunLib.para_St.cbEnPwrCH2.Checked,
                    interChipComFunLib.para_St.cbEnPwrCH3.Checked, interChipComFunLib.para_St.cbEnPwrCH4.Checked };

            if (EnPwrCh[pwrCH - 1])
            {
                switch (pwrType)
                {
                    case "GuWei":
                        if (exeModule == "Set")
                        {
                            instCmdLib.SetGuWeiPowerVolt(mbsPower, (InstCommandLib.POWER_CH_EN)pwrCH, volt);
                        }
                        else
                        {
                            instCmdLib.ReadGuWeiPowerCh(mbsPower, (InstCommandLib.POWER_CH_EN)pwrCH, InstCommandLib.READ_TYPE_EN.VOLT, ref volt);
                        }
                        break;
                    case "KeySight":
                        if (exeModule == "Set")
                        {
                            instCmdLib.SetVoltAndCurr(mbsPower, (InstCommandLib.POWER_CH_EN)pwrCH, volt, 2.00);
                        }
                        else
                        {
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
        #endregion

        #region 1. ATB 扫描测试
        //1. ATB 扫描测试--------------------------------------------------
        //2、AVDD&VDD供电3.3V，使用万用表连接顶层ADC_IN
        //3.0x11改0001,即关闭低功耗模式1，同时通道不使能，0x1E改0x0000，防止反复拉VBG容易触发误烧写；
        //4.顶层ATB使能，并且将VREB_GEN_ATB连接至顶层ATB，配置寄存器TOP_ATB_EN、TOP_ATB_CTRL(Addr：0x2D) = 0x0110；
        //5.顶层ATB通路选择，配置寄存器TOP_ATB_CTRL(Addr:0x2D，bit[2:0])，具体配置如下：
        //eg：VBG电压读取配置：
        //Ø TOP_ATB_CTRL、VREF_GEN_ATB(Addr：0x2D) = 0x1D10；
        //---------------------------------------------------------------

        #region atbNode Table 所有项目的atb地址、名称在此处更新

        public string[,] atbTable_TBS614 = new[,] {
            //TOP_ATB地址    目标ATB地址      目标ATB名称
            { "22","0007",  "24","0518",    "VREF_AVSS50"},
            { "22","0007",  "24","0528",    "VREF_QS_VREF_1200M"},
            { "22","0007",  "24","0538",    "VREF_VBE2"},
            { "22","0007",  "24","0548",    "VREF_VBE2"},
            { "22","0007",  "24","0558",    "VREF_VBE1"},
            { "22","0007",  "24","0568",    "VREF_V2I_FBVI"},
            { "22","0007",  "24","0578",    "VREF_QS_VBG_1200M"},
            { "22","0004",  "20","001B",    "LDO_SYS_VBN"},
            { "22","0004",  "20","002B",    "LDO_SYS_VBP"},
            { "22","0004",  "20","003B",    "LDO_SYS_TIEH"},
            { "22","0004",  "20","004B",    "LDO_SYS_VFBI"},
            { "22","0004",  "20","005B",    "LDO_SYS_VGATE"},
            { "22","0004",  "20","006B",    "LDO_SYS_VREF_OUT"},
            { "22","0004",  "20","007B",    "LDO_SYS_LDO_OUT"},
            { "22","0002",  "37","00D9",    "LDO_LVDS_VBN"},
            { "22","0002",  "37","00DA",    "LDO_LVDS_VBP"},
            { "22","0002",  "37","00DB",    "LDO_LVDS_TIEH"},
            { "22","0002",  "37","00DC",    "LDO_LVDS_VFBI"},
            { "22","0002",  "37","00DD",    "LDO_LVDS_VGATE"},
            { "22","0002",  "37","00DE",    "LDO_LVDS_VREF_OUT"},
            { "22","0002",  "37","00DF",    "LDO_LVDS_LDO_OUT"},
            { "22","0003",  "38","00D9",    "LDO_RXVCO_VBN"},
            { "22","0003",  "38","00DA",    "LDO_RXVCO_VBP"},
            { "22","0003",  "38","00DB",    "LDO_RXVCO_TIEH"},
            { "22","0003",  "38","00DC",    "LDO_RXVCO_VFBI"},
            { "22","0003",  "38","00DD",    "LDO_RXVCO_VGATE"},
            { "22","0003",  "38","00DE",    "LDO_RXVCO_VREF_OUT"},
            { "22","0003",  "38","00DF",    "LDO_RXVCO_LDO_OUT"},
            { "36","0000",  "22","0005",    "TOP_IB10U_PI_TEST"},
            { "36","0000",  "22","0006",    "TOP_IB100U_PI_TEST"},

            //{ "22","0001",  "22","0001",    "TOP_TSENSOR_ATB"},
            //{ "22","0002",  "22","0002",    "TOP_LDO_LVDS_ATB_OUT" },
            //{ "22","0003",  "22","0003",    "TOP_LDO_RXVCO_ATB_OUT"},
            //{ "22","0004",  "22","0004",    "TOP_LDO_SYS_OUT_OUT"},
            //{ "22","0007",  "22","0007",    "TOP_VERF_GEN_ATB"},
        };

        #endregion

        public void AtbNodeRegCfg(InterChipCommLib interChipComFunLib, USB_PortLib usbLib, int index)
        {
            bool TopAtbEnFlag = true;
            GetProjectName(interChipComFunLib);
            interChipComFunLib.para_St.addrOfst = 0;
            interChipComFunLib.para_St.tbregOptLength.Text = "04";

            if (TopAtbEnFlag)
            {
                interChipComFunLib.WriteReg(usbLib, chipLocSelect, "06", "001F");
                TopAtbEnFlag = false;
            }
            comFunLib.DelayTimeMs(100);
            interChipComFunLib.WriteReg(usbLib, chipLocSelect, interChipComFunLib.para_St.atbScan[index, 0], interChipComFunLib.para_St.atbScan[index, 1]);
            comFunLib.DelayTimeMs(100);
            interChipComFunLib.WriteReg(usbLib, chipLocSelect, interChipComFunLib.para_St.atbScan[index, 2], interChipComFunLib.para_St.atbScan[index, 3]);
        }
        public void AtbDebugTest(InterChipCommLib interChipComFunLib, USB_PortLib usbLib)
        {
            GetInstHandle(interChipComFunLib);
            tbAtbResult.Clear();
            AtbNodeRegCfg(interChipComFunLib, usbLib, interChipComFunLib.para_St.cmbAtbNodeName.SelectedIndex);
            comFunLib.DelayTimeMs(500);
            if (interChipComFunLib.para_St.cbMultiSelEn.Checked)
            {
                instCmdLib.SetMultiMeasMode(mbsMulti, InstCommandLib.READ_TYPE_EN.VOLT, InstCommandLib.MEASURE_MODE_EN.DC);//设置万用表为电压模式
                if (interChipComFunLib.para_St.atbScan[interChipComFunLib.para_St.cmbAtbNodeName.SelectedIndex, 4].Contains("PI_TEST"))
                    instCmdLib.SetMultiMeasMode(mbsMulti, InstCommandLib.READ_TYPE_EN.CURR, InstCommandLib.MEASURE_MODE_EN.DC);//设置万用表为电流模式
                comFunLib.DelayTimeMs(100);
                instCmdLib.ReadMulti(mbsMulti, ref volt);  //读取电压
            }
            tbAtbResult.AppendText(volt.ToString("F6") + "  " + instCmdLib.var_st.dataUnit);
        }
        public void AtbAutoSweep(InterChipCommLib interChipComFunLib, USB_PortLib usbLib)
        {
            string title = "ChipType\tChipCorner\tChipNum\tTOP_Atb(Addr)\tTOP_Atb(Cfg)\tATB_Ctrl(Addr)\tATB_Ctrl(Cfg)\tATB_Name\tValue\tunit";
            comFunLib.CreatFileWriteTitle(interChipComFunLib.para_St.cbProjectItems.Text, interChipComFunLib.para_St.tbTestMessage.Text, interChipComFunLib.dataList, title);

            double volt = 0;
            for (int i = 0; i < interChipComFunLib.para_St.cmbAtbNodeName.Items.Count - 2; i++)
            {
                AtbNodeRegCfg(interChipComFunLib, usbLib, i);
                comFunLib.DelayTimeMs(1000);
                ResultTitleSave(interChipComFunLib);
                interChipComFunLib.dataList.Add(interChipComFunLib.para_St.atbScan[i, 0]);
                interChipComFunLib.dataList.Add(interChipComFunLib.para_St.atbScan[i, 1]);
                interChipComFunLib.dataList.Add(interChipComFunLib.para_St.atbScan[i, 2]);
                interChipComFunLib.dataList.Add(interChipComFunLib.para_St.atbScan[i, 3]);
                interChipComFunLib.dataList.Add(interChipComFunLib.para_St.atbScan[i, 4]);
                if (interChipComFunLib.para_St.cbMultiSelEn.Checked)
                {
                    instCmdLib.SetMultiMeasMode(mbsMulti, InstCommandLib.READ_TYPE_EN.VOLT, InstCommandLib.MEASURE_MODE_EN.DC);//设置万用表为电压模式
                    instCmdLib.ReadMulti(mbsMulti, ref volt);  //读取电压
                }
                interChipComFunLib.dataList.Add(volt.ToString("F4"));
                interChipComFunLib.dataList.Add(instCmdLib.var_st.dataUnit);
                comFunLib.WriteDataToTxt(interChipComFunLib.dataList);
                interChipComFunLib.dataList.Clear();
                rtbInterChipDisPlay.AppendText(interChipComFunLib.para_St.atbScan[i, 4] + "\t" + volt.ToString("F4") + "\t" + instCmdLib.var_st.dataUnit + "\n");   //显示实时测量信息
                rtbInterChipDisPlay.ScrollToCaret();
                if (interChipComFunLib.para_St.stop) break;
            }
        }
        #endregion

        #region 2. VBG Trim Test
        string[,] vbgTrim_TBS614 = new string[,] {
                {"06","001F" },  //TOP_ATB_EN
                {"22","0007" },  //ATB输出VBG_ATB
                {"24","0528"},  //输出VBG电压
        };
        public void VbgAutoTrim(InterChipCommLib interChipComFunLib, USB_PortLib usbLib)
        {
            string title = "ChipType\tChipCorner\tChipNum\tCHOP_ON/OFF\tregConfig\tVbgCode\tValue(v)";
            comFunLib.CreatFileWriteTitle(interChipComFunLib.para_St.cbProjectItems.Text, interChipComFunLib.para_St.tbTestMessage.Text, interChipComFunLib.dataList, title);
            rtbInterChipDisPlay.AppendText("CHOP_ON/OFF" + "\t" + "Reg Addr" + "\t" + "Reg配置值" + "\t" + "Vbg电压值" + "\n");

            for (int i = 0; i < interChipComFunLib.para_St.VbgTrim.GetLength(0); i++)
            {
                interChipComFunLib.WriteReg(usbLib, chipLocSelect, interChipComFunLib.para_St.VbgTrim[i, 0], interChipComFunLib.para_St.VbgTrim[i, 1]);
                comFunLib.DelayTimeMs(200);
            }
            double volt = 0;
            string[] chopFlag = { "00000", "00001" };
            for (int i = 0; i < 2; i++)  //Chop_ON/OFF遍历
            {
                for (int code = 0; code < 16; code++)
                {
                    int temp = Convert.ToInt32(chopFlag[i] + Convert.ToString(code, 2) + "0101000", 2);  //二进制字符串转10进制数
                    string vbgTrimCode = temp.ToString("X4");   //10进制数转16进制数字符串
                    interChipComFunLib.WriteReg(usbLib, chipLocSelect, interChipComFunLib.para_St.VbgTrim[2, 0], vbgTrimCode);
                    ResultTitleSave(interChipComFunLib);
                    interChipComFunLib.dataList.Add(i.ToString());
                    interChipComFunLib.dataList.Add(vbgTrimCode);
                    interChipComFunLib.dataList.Add(code.ToString());
                    comFunLib.DelayTimeMs(500);
                    if (interChipComFunLib.para_St.cbMultiSelEn.Checked)
                    {
                        instCmdLib.SetMultiMeasMode(mbsMulti, InstCommandLib.READ_TYPE_EN.VOLT, InstCommandLib.MEASURE_MODE_EN.DC);
                        instCmdLib.ReadMulti(mbsMulti, ref volt);  //读取电压
                    }
                    interChipComFunLib.dataList.Add(volt.ToString("F4"));
                    comFunLib.WriteDataToTxt(interChipComFunLib.dataList);
                    interChipComFunLib.dataList.Clear();
                    rtbInterChipDisPlay.AppendText(i.ToString("X1") + "\t" + interChipComFunLib.para_St.VbgTrim[2, 0] + "\t" + vbgTrimCode + "\t" + code + "\t" + volt.ToString("F4") + "\t" + instCmdLib.var_st.dataUnit + "\n");   //显示实时测量信息
                    rtbInterChipDisPlay.ScrollToCaret();
                    if (interChipComFunLib.para_St.stop) break;
                }
            }
        }
        #endregion

        #region 3.Regulator_Trim
        public void RegulatorTrim(InterChipCommLib interChipComFunLib, USB_PortLib usbLib)
        {
            string title = "ChipType\tChipCorner\tChipNum\tCHOP_ON/OFF\tVbgCode\tValue(v)";
            comFunLib.CreatFileWriteTitle(interChipComFunLib.para_St.cbProjectItems.Text, interChipComFunLib.para_St.tbTestMessage.Text, interChipComFunLib.dataList, title);
            rtbInterChipDisPlay.AppendText("CHOP_ON/OFF" + "\t" + "Reg Addr" + "\t" + "Reg配置值" + "\t" + "Vbg电压值" + "\n");

            for (int i = 0; i < interChipComFunLib.para_St.VbgTrim.GetLength(0); i++)
            {
                interChipComFunLib.WriteReg(usbLib, chipLocSelect, interChipComFunLib.para_St.VbgTrim[i, 0], interChipComFunLib.para_St.VbgTrim[i, 1]);
                comFunLib.DelayTimeMs(200);
            }
            double volt = 0;
            string[] chopFlag = { "00000", "00001" };
            for (int i = 0; i < 2; i++)  //Chop_ON/OFF遍历
            {
                for (int code = 0; code < 16; code++)
                {
                    int temp = Convert.ToInt32(chopFlag[i] + Convert.ToString(code, 2) + "0101000", 2);  //二进制字符串转10进制数
                    string vbgTrimCode = temp.ToString("X4");   //10进制数转16进制数字符串
                    interChipComFunLib.WriteReg(usbLib, chipLocSelect, interChipComFunLib.para_St.VbgTrim[2, 0], vbgTrimCode);
                    ResultTitleSave(interChipComFunLib);
                    interChipComFunLib.dataList.Add(i.ToString());
                    interChipComFunLib.dataList.Add(vbgTrimCode);
                    comFunLib.DelayTimeMs(500);
                    if (interChipComFunLib.para_St.cbMultiSelEn.Checked)
                    {
                        instCmdLib.SetMultiMeasMode(mbsMulti, InstCommandLib.READ_TYPE_EN.VOLT, InstCommandLib.MEASURE_MODE_EN.DC);
                        instCmdLib.ReadMulti(mbsMulti, ref volt);  //读取电压
                    }
                    interChipComFunLib.dataList.Add(volt.ToString("F4"));
                    comFunLib.WriteDataToTxt(interChipComFunLib.dataList);
                    interChipComFunLib.dataList.Clear();
                    rtbInterChipDisPlay.AppendText(i.ToString("X1") + "\t" + interChipComFunLib.para_St.VbgTrim[2, 0] + "\t" + vbgTrimCode + "\t" + volt.ToString("F4") + "\t" + instCmdLib.var_st.dataUnit + "\n");   //显示实时测量信息
                    rtbInterChipDisPlay.ScrollToCaret();
                    if (interChipComFunLib.para_St.stop) break;
                }
            }
        }
        #endregion

        #region AutoTest Main 在此增加自动化测试项
        public bool AutoTest(InterChipCommLib interChipComFunLib, USB_PortLib usbLib, string testItem)
        {
            GetInstHandle(interChipComFunLib);
            GetProjectName(interChipComFunLib);
            //int delayCount = 0;
            //string pwrType = interChipComFunLib.para_St.cbPwrType.Checked ? "KeySight" : "GuWei";
            //bool[] EnPwrCh = new bool[]{ interChipComFunLib.para_St.cbEnPwrCH1.Checked, interChipComFunLib.para_St.cbEnPwrCH2.Checked,
            //        interChipComFunLib.para_St.cbEnPwrCH3.Checked, interChipComFunLib.para_St.cbEnPwrCH4.Checked };
            //电源初始化设置
            #region

            //if (interChipComFunLib.para_St.cbPowerSelEn.Checked)
            //{
            //    for (int ch = 0; ch < EnPwrCh.Length; ch++)
            //    {
            //        if (EnPwrCh[ch])
            //        {
            //            switch (pwrType)
            //            {
            //                case "GuWei":
            //                    instCmdLib.GuWeiPowerOutputChEn(mbsPower, (InstCommandLib.POWER_CH_EN)(ch + 1), InstCommandLib.STATE_EN.OFF);
            //                    comFunLib.DelayTimeMs(2000);
            //                    instCmdLib.GuWeiPowerOutputChEn(mbsPower, (InstCommandLib.POWER_CH_EN)(ch + 1), InstCommandLib.STATE_EN.ON);
            //                    break;
            //                case "KeySight":
            //                    instCmdLib.KeyPowerOutPutChEn(mbsPower, (InstCommandLib.POWER_CH_EN)(ch + 1), InstCommandLib.STATE_EN.OFF);
            //                    comFunLib.DelayTimeMs(2000);
            //                    instCmdLib.KeyPowerOutPutChEn(mbsPower, (InstCommandLib.POWER_CH_EN)(ch + 1), InstCommandLib.STATE_EN.ON);
            //                    break;
            //                default:
            //                    break;
            //            }

            //        }
            //    }
            //    while (delayCount < 7)
            //    {
            //        comFunLib.DelayTimeMs(1000);
            //        delayCount++;
            //    }
            //}
            #endregion
            interChipComFunLib.para_St.tbregOptLength.Text = "01";
            interChipComFunLib.interChipWriteReg(usbLib, "0x02000229", "A6");
            comFunLib.DelayTimeMs(300);
            interChipComFunLib.interChipWriteReg(usbLib, "0x02000230", "01");
            comFunLib.DelayTimeMs(100);

            interChipComFunLib.para_St.addrOfst = 0;
            interChipComFunLib.para_St.tbregOptLength.Text = "04";
            rtbInterChipDisPlay.AppendText(interChipComFunLib.para_St.tbTestMessage.Text + "\n\n");    //显示项目测试信息  
            Application.DoEvents();
            if (interChipComFunLib.para_St.stop) return false;

            switch (testItem)
            {
                case "ATB_Scan":
                    AtbAutoSweep(interChipComFunLib, usbLib);
                    break;
                case "VREF_Trim":
                    VbgAutoTrim(interChipComFunLib, usbLib);
                    break;
                case "Regulator_Trim":
                    RegulatorTrim(interChipComFunLib, usbLib);
                    break;

                default:
                    break;
            }
            return false;
        }
        #endregion
    }
}

