using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using AutoCtrl.CommonFunction;

namespace AutoCtrl.CommonForm {
    public partial class RandomDataForm : Form {
        public RandomDataForm() {
            InitializeComponent();
        }
        public struct ParaInit_ST {
            public int stopValue;
            public int startValue;
            public int averGroup;
            public int dataCnt;
            public int rowCnt;
            public int columnCnt;
            public string appendText;
        }
        List<int> dataList = new List<int> { };
        public int[] dataArrayComp;
        public CommonFunctionLib comFunLib = new CommonFunctionLib();
        public ParaInit_ST paraInit_st = new ParaInit_ST();
        public Random random = new Random(unchecked((int)DateTime.Now.Ticks));
        private void ParaInit() {
            rtbRandom.Clear();
            paraInit_st.appendText = string.Empty;
            paraInit_st.stopValue = (int)nudStopNum.Value;
            paraInit_st.startValue = (int)nudStartNum.Value;
            paraInit_st.averGroup = (int)nudAverGroup.Value;
            paraInit_st.dataCnt = paraInit_st.stopValue + 1 - paraInit_st.startValue;
            dataArrayComp = new int[paraInit_st.dataCnt];
        }
        private void RtbText(string text = "", bool isWarning = false) {
            rtbRandom.ForeColor = isWarning ? Color.Red : Color.Blue;
            rtbRandom.AppendText(text + "\n");
        }
        private void btnRandom_Click(object sender, EventArgs e) {
            btnRandom.BackColor = Color.Gold;
            btnRandom.Enabled = false;
            ParaInit();
            if (paraInit_st.dataCnt % paraInit_st.averGroup == 0) {
                paraInit_st.rowCnt = paraInit_st.averGroup;
                paraInit_st.columnCnt = paraInit_st.dataCnt / paraInit_st.averGroup;
                RtbText(comFunLib.GetDateTimeNow(), false);
                RandomAction();
                RtbText(comFunLib.GetDateTimeNow(), false);
            }
            else {
                paraInit_st.appendText = "Data Range Can't be Divided,Please Change Group Count !!!";
                RtbText(paraInit_st.appendText, true);
            }
            btnRandom.BackColor = SystemColors.Control;
            btnRandom.Enabled = true;
        }
        private void RandomAction() {
            List<string> list = new List<string> { };
            int[,] dataArray = new int[paraInit_st.rowCnt, paraInit_st.columnCnt];
            list.Add(comFunLib.GetDateTimeNow() + " *** 随机数结果 *** ");
            comFunLib.CreatFilePath("RandomData");
            comFunLib.WriteResultsTitle("randomData_" + comFunLib.GetCurrentDataTime(), list, CommonFunctionLib.WRITE_DATA_METHORD.FILE_APPEND);
            list.Clear();
            for (int rowIndex = 0; rowIndex < paraInit_st.rowCnt; rowIndex++) {
                string rowText = string.Empty;
                for (int columnCnt = 0; columnCnt < paraInit_st.columnCnt; columnCnt++) {
                    int dataCompIndex = rowIndex * paraInit_st.columnCnt + columnCnt;   //此处 注意 Index 的计算
                    dataArray[rowIndex, columnCnt] = random.Next(paraInit_st.startValue, paraInit_st.stopValue + 1);
                    dataArrayComp[dataCompIndex] = dataArray[rowIndex, columnCnt];            //不使用 dataIndex++，因为有重复的做判断后可能会溢出
                    for (int compIndex = 0; compIndex < dataCompIndex; compIndex++) {
                        while (dataArray[rowIndex, columnCnt] == dataArrayComp[compIndex]) {
                            dataArray[rowIndex, columnCnt] = random.Next(paraInit_st.startValue, paraInit_st.stopValue + 1);
                            dataArrayComp[dataCompIndex] = dataArray[rowIndex, columnCnt];  //重新赋值
                            compIndex = 0;  //每随机一次，都要从新开始比较
                        }
                    }
                    rowText += dataArray[rowIndex, columnCnt].ToString() + ", ";
                    list.Add(dataArray[rowIndex, columnCnt].ToString());
                }
                string rowInfor = "第 " + (rowIndex + 1) + " 组" + ": ";
                RtbText(rowInfor + rowText, false);
                list.Insert(0, rowInfor);
                comFunLib.WriteDataToTxt(list, CommonFunctionLib.WRITE_DATA_METHORD.FILE_APPEND);
                list.Clear();
            }
        }

        private void btnDebug_Click(object sender, EventArgs e) {
            comFunLib.CreatFilePath("RandomData");
            List<string> list = new List<string> { "Gui", "Corner", "Temp", "Volt", "Error", "VBG" };
            comFunLib.WriteResultsTitle("mazewei", list);
        }
    }
}
