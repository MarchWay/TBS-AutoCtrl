using System;
using NationalInstruments.Visa;
using AutoCtrl.InstCommonCtrl;
using AutoCtrl.InstCommandCtrl;
using AutoCtrl.CommonFunction;
using AutoCtrl.CommunicationProtocol;
using System.Windows.Forms;
using AutoCtrl.TBSiliconProject.DriverCommonTestItem;

namespace AutoCtrl.TBSiliconProject.InterFaceCommonTestItem
{
    public class InterChip_TestLib
    {
        public USB_PortLib usbAnalog = new USB_PortLib();
        public CommonFunctionLib comFunLib = new CommonFunctionLib();
        public InstCommandLib instCmdLib = new InstCommandLib();
        public InstCommonCtrlLib instCommLib = new InstCommonCtrlLib();
        public DriverChipCommonFunctionLib dChipComFunLib = new DriverChipCommonFunctionLib();
        public TestItems_TestLib testItems = new TestItems_TestLib();
        public MessageBasedSession mbsPower, mbsMulti, mbsMulti1;
        public RichTextBox rtbInterChipDisPlay;
        public TextBox tbAtbResult;
        public int chipLocSelect = 0;
        public double volt = 0;
        public double vbgTarget = 1.200;
        public int voltCase;

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
                    interChipComFunLib.para_St.Regulator = regulatorTrim_TBS614;
                    interChipComFunLib.para_St.IbiasTrim = Ibias100uTrim_TBS614;
                    interChipComFunLib.para_St.PowerConsume = PowerConsume_TBS614;
                    break;
                case "P615":
                    break;

                default: break;
            }
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
            for (int i = 0; i < interChipComFunLib.para_St.VbgTrim.GetLength(0) - 1; i++)
            {
                interChipComFunLib.WriteReg(usbLib, chipLocSelect, interChipComFunLib.para_St.VbgTrim[i, 0], interChipComFunLib.para_St.VbgTrim[i, 1]);
                comFunLib.DelayTimeMs(200);
            }
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
            string regCode = Convert.ToInt32("00000000" + Convert.ToString(code, 2) + "0101000", 2).ToString("X4");
            interChipComFunLib.WriteReg(usbLib, chipLocSelect, interChipComFunLib.para_St.VbgTrim[2, 0], regCode);
            comFunLib.DelayTimeMs(300);
            double volt = GetVbgVolt(interChipComFunLib, usbLib);
            while (Math.Abs(volt - configValue) > 0.005)
            {
                if (interChipComFunLib.para_St.stop)
                {
                    interChipComFunLib.para_St.stop = false;
                    break;
                }
                code = (volt - configValue) > 0 ? --code : ++code;
                if (code < 0 || code > 15)
                    break;
                regCode = Convert.ToInt32("00000000" + Convert.ToString(code, 2) + "0101000", 2).ToString("X4");
                interChipComFunLib.WriteReg(usbLib, chipLocSelect, interChipComFunLib.para_St.VbgTrim[2, 0], regCode);
                comFunLib.DelayTimeMs(300);
                volt = GetVbgVolt(interChipComFunLib, usbLib);
            }
            return volt;
        }
        /// <summary>
        /// 芯片内部LDO电压调节
        /// </summary>
        /// <param name="interChipComFunLib"></param>
        /// <param name="usbLib"></param>
        /// <param name="targetValue"></param>：LDO默认值±10%分别为HV、LV
        /// <returns></returns>
        public double LdoAdjust(InterChipCommLib interChipComFunLib, USB_PortLib usbLib, int targetValue)
        {
            double[] percentValue = { -0.1, 0, 0.1 };
            double volt = 0;
            double temp;
            int voltCode = 10;
            //LDO调节
            interChipComFunLib.WriteReg(usbLib, chipLocSelect, interChipComFunLib.para_St.Regulator[0, 0], interChipComFunLib.para_St.Regulator[0, 1]);   //TOP_ATB_EN
            for (int i = 0; i < 3; i++)
            {
                int enCodeStep = 2 * i;
                for (int enCode = 1; enCode < 3; enCode++)
                {
                    interChipComFunLib.WriteReg(usbLib, chipLocSelect, interChipComFunLib.para_St.Regulator[enCode + enCodeStep, 0], interChipComFunLib.para_St.Regulator[enCode + enCodeStep, 1]);
                    comFunLib.DelayTimeMs(100);
                }
                if (interChipComFunLib.para_St.cbMultiSelEn.Checked)
                {
                    instCmdLib.SetMultiMeasMode(mbsMulti, InstCommandLib.READ_TYPE_EN.VOLT, InstCommandLib.MEASURE_MODE_EN.DC);
                    instCmdLib.ReadMulti(mbsMulti, ref volt);  //读取电压
                }
                temp = volt * (1 + percentValue[targetValue]);
                while (Math.Abs(volt - temp) > 0.005)
                {
                    if (interChipComFunLib.para_St.stop)
                    {
                        interChipComFunLib.para_St.stop = false;
                        break;
                    }
                    voltCode = (volt - temp) > 0 ? --voltCode : ++voltCode;
                    if (voltCode < 0 || voltCode > 15)
                        break;
                    string trimCode = " ";
                    if (i == 0)
                    {
                        trimCode = "007" + voltCode.ToString("X1");
                    }
                    else
                    {
                        int tempCode = Convert.ToInt32("00000000100" + Convert.ToString(voltCode, 2) + "111", 2);  //二进制字符串转10进制数
                        trimCode = tempCode.ToString("X4");   //10进制数转16进制数字符串
                    }
                    interChipComFunLib.WriteReg(usbLib, chipLocSelect, interChipComFunLib.para_St.Regulator[2 + enCodeStep, 0], trimCode);
                    comFunLib.DelayTimeMs(300);
                    if (interChipComFunLib.para_St.cbMultiSelEn.Checked)
                    {
                        instCmdLib.SetMultiMeasMode(mbsMulti, InstCommandLib.READ_TYPE_EN.VOLT, InstCommandLib.MEASURE_MODE_EN.DC);
                        instCmdLib.ReadMulti(mbsMulti, ref volt);  //读取电压
                    }
                    temp = volt;
                }
                interChipComFunLib.dataList.Add(volt.ToString("F4"));
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
            interChipComFunLib.dataList.Add(interChipComFunLib.para_St.cmbTempCaseSel.Text);
            interChipComFunLib.dataList.Add(interChipComFunLib.para_St.cmbVoltCaseSel.Text);
        }
        /// <summary>
        /// 十进制数准换成寄存器可写的十六进制数字符串
        /// </summary>
        /// <param name="decNum"></param>
        /// <param name="byteSize"></param>
        /// <returns></returns>
        public string DecTohexStr(int decNum, int byteSize, string headStr = null, string endStr = null)
        {
            string binStr = Convert.ToString(decNum, 2).PadLeft(byteSize, '0'); //十进制数转换为二进制字符串
            string hexStr = Convert.ToInt32(headStr + binStr + endStr, 2).ToString("X4");   //二进制字符串转换为十六进制字符串
            return hexStr;
        }
        #endregion

        #region 1.ATB 扫描测试
        //1. ATB 扫描测试--------------------------------------------------
        //2.AVDD&VDD供电3.3V，使用万用表连接顶层ADC_IN
        //3.顶层ATB使能，TOP_ATB_EN(Addr:0x06) = 0x001F;
        //4.顶层ATB通路选择，配置寄存器TOP_ATB_CTRL(Addr:0x22，bit[2:0])，具体配置如下：
        //eg：VBG电压读取配置：
        //Ø TOP_ATB_CTRL(Addr:0x22) = 0x0007、VREF_GEN_ATB(Addr：0x24) = 0x0528；
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
            interChipComFunLib.para_St.addrOfst = 0;
            interChipComFunLib.para_St.tbregOptLength.Text = "04";

            interChipComFunLib.WriteReg(usbLib, chipLocSelect, "06", "001F");
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
            string title = testItems.CommTitle + "TOP_Atb(Addr)\tTOP_Atb(Cfg)\tATB_Ctrl(Addr)\tATB_Ctrl(Cfg)\tATB_Name\tValue\tunit";
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
                if (interChipComFunLib.para_St.stop)
                {
                    interChipComFunLib.para_St.stop = false;
                    break;
                }
            }
        }
        #endregion

        #region 2.VBG Trim Test
        string[,] vbgTrim_TBS614 = new string[,] {
                {"06","001F" },  //TOP_ATB_EN
                {"22","0007" },  //ATB输出VBG_ATB
                {"24","0528"},  //输出VBG电压
        };
        public void VbgAutoTrim(InterChipCommLib interChipComFunLib, USB_PortLib usbLib)
        {
            string title = testItems.CommTitle + "CHOP_ON/OFF\tregConfig\ttrimCode\tValue(v)";
            comFunLib.CreatFileWriteTitle(interChipComFunLib.para_St.cbProjectItems.Text, interChipComFunLib.para_St.tbTestMessage.Text, interChipComFunLib.dataList, title);
            rtbInterChipDisPlay.AppendText("CHOP_ON/OFF" + "\t" + "Reg Addr" + "\t" + "Reg配置值" + "\t" + "code值" + "\t" + "Vbg电压值" + "\n");

            for (int i = 0; i < interChipComFunLib.para_St.VbgTrim.GetLength(0); i++)
            {
                interChipComFunLib.WriteReg(usbLib, chipLocSelect, interChipComFunLib.para_St.VbgTrim[i, 0], interChipComFunLib.para_St.VbgTrim[i, 1]);
                comFunLib.DelayTimeMs(200);
            }
            double volt = 0;
            string[] chopFlag = { "00000", "00001", "0101000" };
            for (int i = 0; i < 2; i++)  //Chop_ON/OFF遍历
            {
                for (int code = 0; code < 16; code++)
                {
                    string vbgTrimCode = DecTohexStr(code, 4, chopFlag[i], chopFlag[2]);
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
                    interChipComFunLib.dataList.Add(instCmdLib.var_st.dataUnit);
                    comFunLib.WriteDataToTxt(interChipComFunLib.dataList);
                    interChipComFunLib.dataList.Clear();
                    rtbInterChipDisPlay.AppendText(i.ToString("X1") + "\t" + interChipComFunLib.para_St.VbgTrim[2, 0] + "\t" + vbgTrimCode + "\t" + code + "\t" + volt.ToString("F4") + "\t" + instCmdLib.var_st.dataUnit + "\n");   //显示实时测量信息
                    rtbInterChipDisPlay.ScrollToCaret();
                    if (interChipComFunLib.para_St.stop)
                    {
                        interChipComFunLib.para_St.stop = false;
                        break;
                    }
                }
            }
        }
        #endregion

        #region 3.Regulator_Trim
        string[,] regulatorTrim_TBS614 = new string[,] {
                {"06","001F" },  //TOP_ATB_EN
                {"22","0004" },  //ATB输出LDO_SYS_ATB
                {"20","007B"},  //输出LDO电压
                {"22","0002" },  //ATB输出LDO_LVDS_ATB
                {"37","00DF"},  //输出LDO电压
                {"22","0003" },  //ATB输出LDO_RXVCO_ATB
                {"38","00DF"},  //输出LDO电压
        };
        string[] LDO_type = { "LDO_SYS", "LDO_LVDS", "LDO_RXVCO" };
        public void RegulatorTrim(InterChipCommLib interChipComFunLib, USB_PortLib usbLib)
        {
            string title = testItems.CommTitle + "Vbg(v)\tLDO_Type\tregConfig\ttrimCode\tValue(v)";
            comFunLib.CreatFileWriteTitle(interChipComFunLib.para_St.cbProjectItems.Text, interChipComFunLib.para_St.tbTestMessage.Text, interChipComFunLib.dataList, title);
            rtbInterChipDisPlay.AppendText("LDO_Type" + "\t" + "Reg Addr" + "\t" + "Reg配置值" + "\t" + "LDO电压值" + "\n");

            double volt = 0;
            double Vbg = VbgConfig(interChipComFunLib, usbLib, vbgTarget);

            interChipComFunLib.WriteReg(usbLib, chipLocSelect, interChipComFunLib.para_St.Regulator[0, 0], interChipComFunLib.para_St.Regulator[0, 1]);   //TOP_ATB_EN

            string[] regStr = { "000000000111", "000000001", "111" };
            for (int i = 0; i < 3; i++)  //LDO_Type遍历
            {
                int enCodeStep = 2 * i;
                for (int enCode = 1; enCode < 3; enCode++)
                {
                    interChipComFunLib.WriteReg(usbLib, chipLocSelect, interChipComFunLib.para_St.Regulator[enCode + enCodeStep, 0], interChipComFunLib.para_St.Regulator[enCode + enCodeStep, 1]);
                    comFunLib.DelayTimeMs(100);
                }
                for (int code = 0; code < 16; code++)
                {
                    string LDOtrimCode = (i == 0) ? DecTohexStr(code, 4, regStr[0], null) : DecTohexStr(code, 4, regStr[1], regStr[2]);
                    interChipComFunLib.WriteReg(usbLib, chipLocSelect, interChipComFunLib.para_St.Regulator[2 + enCodeStep, 0], LDOtrimCode);
                    ResultTitleSave(interChipComFunLib);
                    interChipComFunLib.dataList.Add(Vbg.ToString("F4"));
                    interChipComFunLib.dataList.Add(LDO_type[i]);
                    interChipComFunLib.dataList.Add(LDOtrimCode);
                    interChipComFunLib.dataList.Add(code.ToString());

                    comFunLib.DelayTimeMs(500);
                    if (interChipComFunLib.para_St.cbMultiSelEn.Checked)
                    {
                        instCmdLib.SetMultiMeasMode(mbsMulti, InstCommandLib.READ_TYPE_EN.VOLT, InstCommandLib.MEASURE_MODE_EN.DC);
                        instCmdLib.ReadMulti(mbsMulti, ref volt);  //读取电压
                    }
                    interChipComFunLib.dataList.Add(volt.ToString("F4"));
                    interChipComFunLib.dataList.Add(instCmdLib.var_st.dataUnit);
                    comFunLib.WriteDataToTxt(interChipComFunLib.dataList);
                    interChipComFunLib.dataList.Clear();
                    rtbInterChipDisPlay.AppendText(LDO_type[i] + "\t" + interChipComFunLib.para_St.VbgTrim[2, 0] + "\t" + LDOtrimCode + "\t" + volt.ToString("F4") + "\t" + instCmdLib.var_st.dataUnit + "\n");   //显示实时测量信息
                    rtbInterChipDisPlay.ScrollToCaret();
                    if (interChipComFunLib.para_St.stop)
                    {
                        interChipComFunLib.para_St.stop = false;
                        break;
                    }
                }
                interChipComFunLib.WriteReg(usbLib, chipLocSelect, interChipComFunLib.para_St.Regulator[2 + enCodeStep, 0], interChipComFunLib.para_St.Regulator[2 + enCodeStep, 1]);
            }
        }
        #endregion

        #region 4.IBIAS_100u_TXDRV0
        /// <summary>
        /// TXDRV驱动电流调节范围测试
        /// </summary>
        /// <param name="interChipComFunLib"></param>
        /// <param name="usbLib"></param>
        string[,] Ibias100uTrim_TBS614 = new string[,] {
                {"06","001F" },  //TOP_ATB_EN
                {"22","0006" },  //ATB输出IB_100U_PE_TEST
                {"36","0000"},  //关闭TX
                {"23","0886" },
        };
        public void IBIAS100u_Trim(InterChipCommLib interChipComFunLib, USB_PortLib usbLib)
        {
            double Curr = 0;
            string title = testItems.CommTitle + "Vbg(v)\tLDO_SYS(v)\tLDO_LVDS(v)\tLDO_RXVCO(v)\ttrimCode\tregConfig\tValue(uA)";
            comFunLib.CreatFileWriteTitle(interChipComFunLib.para_St.cbProjectItems.Text, interChipComFunLib.para_St.tbTestMessage.Text, interChipComFunLib.dataList, title);
            rtbInterChipDisPlay.AppendText("voltCase" + "\t" + "regAddr" + "\t" + "trimCode" + "\t" + "Reg配置值" + "\t" + "IBIAS100u电流值" + "\n");

            double Vbg = VbgConfig(interChipComFunLib, usbLib, vbgTarget);  //Vbg校准
            ResultTitleSave(interChipComFunLib);
            interChipComFunLib.dataList.Add(Vbg.ToString("F4"));
            volt = LdoAdjust(interChipComFunLib, usbLib, voltCase); //LDO电压设置
            for (int Code = 0; Code < 16; Code++)
            {
                for (int i = 0; i < interChipComFunLib.para_St.IbiasTrim.GetLength(0); i++)
                {
                    interChipComFunLib.WriteReg(usbLib, chipLocSelect, interChipComFunLib.para_St.IbiasTrim[i, 0], interChipComFunLib.para_St.IbiasTrim[i, 1]);
                    comFunLib.DelayTimeMs(100);
                }
                string IbiasCode = " ";
                int temp = Convert.ToInt32("00001000000" + Convert.ToString(Code, 2) + "0110", 2);  //二进制字符串转10进制数
                IbiasCode = temp.ToString("X4");   //10进制数转16进制数字符串
                interChipComFunLib.WriteReg(usbLib, chipLocSelect, interChipComFunLib.para_St.IbiasTrim[3, 0], IbiasCode);
                interChipComFunLib.dataList.Add(IbiasCode);
                interChipComFunLib.dataList.Add(Code.ToString());

                comFunLib.DelayTimeMs(500);
                if (interChipComFunLib.para_St.cbMultiSelEn1.Checked)
                {
                    instCmdLib.SetMultiMeasMode(mbsMulti1, InstCommandLib.READ_TYPE_EN.CURR, InstCommandLib.MEASURE_MODE_EN.DC);
                    instCmdLib.ReadMulti(mbsMulti1, ref Curr);  //读取电流
                }
                interChipComFunLib.dataList.Add(Curr.ToString("F4"));
                interChipComFunLib.dataList.Add(instCmdLib.var_st.dataUnit);
                comFunLib.WriteDataToTxt(interChipComFunLib.dataList);
                interChipComFunLib.dataList.Clear();
                rtbInterChipDisPlay.AppendText(interChipComFunLib.para_St.cmbVoltCaseSel.Text + "\t" + interChipComFunLib.para_St.IbiasTrim[3, 0] + "\t" + Code.ToString() + "\t" + IbiasCode + "\t" + Curr.ToString("F4") + "\t" + instCmdLib.var_st.dataUnit + "\n");   //显示实时测量信息
                rtbInterChipDisPlay.ScrollToCaret();
                if (interChipComFunLib.para_St.stop)
                {
                    interChipComFunLib.para_St.stop = false;
                    break;
                }
            }


        }
        #endregion

        #region 5.PowerDissipation

        /// <summary>
        /// 模块功耗测试
        /// </summary>
        /// <param name="interChipComFunLib"></param>
        /// <param name="usbLib"></param>

        string[,] PowerConsume_TBS614 = new string[,] {
                {"06","0000","ADC功耗" },  //ADC模块pwd
                {"1B","0000","LVDS数字功耗" },  //Digital模块软复位
                {"21","0015","GCLKBUF功耗"},  //GCLK模块pwd
                {"36","0007","TX功耗" },  //Tx模块pwd
                {"31","0008","RXVCO功耗" },  //RXVCO模块pwd
                {"38","0058","RXVCO_LDO功耗" },  //RXVCO_LDO模块pwd
                {"37","0058","LVDS_LDO功耗" },  //LVDS_LDO模块pwd
                {"31","007F","LVDS功耗" },  //LVDS模块pwd
        };
        public void PowerDissipation(InterChipCommLib interChipComFunLib, USB_PortLib usbLib)
        {
            double Curr = 0;
            string title = testItems.CommTitle + "Vbg(v)\tLDO_SYS(v)\tLDO_LVDS(v)\tLDO_RXVCO(v)\tregAddr\tregConfig\t模块\tTotalCurr(mA)\tConsumeCurr(mA)";
            comFunLib.CreatFileWriteTitle(interChipComFunLib.para_St.cbProjectItems.Text, interChipComFunLib.para_St.tbTestMessage.Text, interChipComFunLib.dataList, title);
            rtbInterChipDisPlay.AppendText("voltCase" + "\t" + "regAddr" + "\t" + "Reg配置值" + "\t" + "模块" + "\t" + "ConsumeCurr(mA)" + "\n");

            double Vbg = VbgConfig(interChipComFunLib, usbLib, vbgTarget);  //Vbg校准

            for (int i = 0; i < interChipComFunLib.para_St.PowerConsume.GetLength(0); i++)
            {
                ResultTitleSave(interChipComFunLib);
                interChipComFunLib.dataList.Add(Vbg.ToString("F4"));
                volt = LdoAdjust(interChipComFunLib, usbLib, voltCase); //LDO电压设置

                if (interChipComFunLib.para_St.cbMultiSelEn1.Checked)
                {
                    instCmdLib.SetMultiMeasMode(mbsMulti1, InstCommandLib.READ_TYPE_EN.CURR, InstCommandLib.MEASURE_MODE_EN.DC);
                    instCmdLib.ReadMulti(mbsMulti1, ref Curr);  //读取电流
                }
                double temp = Curr;
                interChipComFunLib.WriteReg(usbLib, chipLocSelect, interChipComFunLib.para_St.PowerConsume[i, 0], interChipComFunLib.para_St.PowerConsume[i, 1]);
                comFunLib.DelayTimeMs(1000);
                interChipComFunLib.dataList.Add(interChipComFunLib.para_St.PowerConsume[i, 0]);
                interChipComFunLib.dataList.Add(interChipComFunLib.para_St.PowerConsume[i, 1]);
                interChipComFunLib.dataList.Add(interChipComFunLib.para_St.PowerConsume[i, 2]);
                if (interChipComFunLib.para_St.cbMultiSelEn1.Checked)
                {
                    instCmdLib.SetMultiMeasMode(mbsMulti1, InstCommandLib.READ_TYPE_EN.CURR, InstCommandLib.MEASURE_MODE_EN.DC);
                    instCmdLib.ReadMulti(mbsMulti1, ref Curr);  //读取电流
                }
                interChipComFunLib.dataList.Add(temp.ToString("F4"));
                interChipComFunLib.dataList.Add((temp - Curr).ToString("F4"));
                interChipComFunLib.dataList.Add(instCmdLib.var_st.dataUnit);
                comFunLib.WriteDataToTxt(interChipComFunLib.dataList);
                interChipComFunLib.dataList.Clear();
                rtbInterChipDisPlay.AppendText(interChipComFunLib.para_St.cmbVoltCaseSel.Text + "\t" + interChipComFunLib.para_St.PowerConsume[i, 0] + "\t" + interChipComFunLib.para_St.PowerConsume[i, 1] + "\t" + interChipComFunLib.para_St.PowerConsume[i, 2] + "\t" + (temp - Curr).ToString("F4") + "\t" + instCmdLib.var_st.dataUnit + "\n");   //显示实时测量信息
                rtbInterChipDisPlay.ScrollToCaret();
                if (interChipComFunLib.para_St.stop)
                {
                    interChipComFunLib.para_St.stop = false;
                    break;
                }
            }
        }
        #endregion

        #region AutoTest Main 在此增加自动化测试项
        public bool AutoTest(InterChipCommLib interChipComFunLib, USB_PortLib usbLib, string testItem)
        {
            GetInstHandle(interChipComFunLib);
            GetProjectName(interChipComFunLib);
            //testItems.PowerOnOffControl(dChipComFunLib);

            interChipComFunLib.para_St.tbregOptLength.Text = "01";
            interChipComFunLib.interChipWriteReg(usbLib, "0x02000229", "A6");
            comFunLib.DelayTimeMs(300);
            interChipComFunLib.interChipWriteReg(usbLib, "0x02000230", "01");
            comFunLib.DelayTimeMs(500);

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
                case "IBIAS100u_Trim":
                    IBIAS100u_Trim(interChipComFunLib, usbLib);
                    break;
                case "PowerDissipation":
                    PowerDissipation(interChipComFunLib, usbLib);
                    break;

                default:
                    break;
            }
            return false;
        }
        #endregion
    }
}

