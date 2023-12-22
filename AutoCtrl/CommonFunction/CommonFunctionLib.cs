using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel;
using OfficeOpenXml;
using EPPlus;
using System.ComponentModel.DataAnnotations;

namespace AutoCtrl.CommonFunction {
    public class CommonFunctionLib {

        #region 0. 结构体变量、枚举、实例化
        public struct Para_St {
            public string fileName;
            public string folderName;
            public string filePath;
            public string fileFullPath;
        }
        public enum WRITE_DATA_METHORD {
            STREAM_WRITER,
            FILE_APPEND,
        }

        public Para_St para_st = new Para_St();
        #endregion

        #region 1. Get System Data Time & Delay Function
        /// <summary>
        /// 获取系统当前时间
        /// </summary>
        /// <returns></returns>
        public string GetCurrentDataTime() {
            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString();
            string day = DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString();
            string hour = DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString();
            string minute = DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString();
            string second = DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString();
            return year + month + day + "_" + hour + minute + second;
        }
        public string GetDateTimeNow() {
            return DateTime.Now.ToLocalTime().ToString();   // 2022-01-01 12:00:00
        }

        /// <summary>
        /// 系统延时，单位毫秒, 不建议使用，睡眠导致UI不可用
        /// </summary>
        /// <param name="delay"></param>
        public void DelayTime(double delay) {
            for (double i = 0; i < delay; i++) {
                System.Threading.Thread.Sleep(1);   //单位 ms
                Application.DoEvents();
            }
        }

        /// 延时函数
        /// </summary>
        /// <param name="delayTime">需要延时多少秒</param>
        /// <returns></returns>
        public bool DelayTimeMs(double delayTime) {
            if (delayTime != 0) {
                DateTime now = DateTime.Now;
                double s;
                do {
                    TimeSpan spand = DateTime.Now - now;
                    s = spand.TotalMilliseconds;
                    Application.DoEvents();
                }
                while (s < delayTime);
            }
            return true;
        }

        #endregion

        #region 2. Test Data TXT Save
        /// <summary>
        /// 创建文件路径
        /// </summary>
        /// <param name="folderName"></param>
        /// <param name="fileName"></param>
        public void CreatFilePath(string folderName) {
            para_st.filePath = Application.StartupPath + @"\" + folderName + @"\";
            if (!Directory.Exists(para_st.filePath)) {
                Directory.CreateDirectory(para_st.filePath);
            }
        }

        /// <summary>
        /// TXT写入数据
        /// </summary>
        /// <param name="list"></param>
        /// <param name="writeMethord"></param>
        public void WriteTxt(List<string> list, WRITE_DATA_METHORD writeMethord) {
            string temp = "";
            if (list.Count != 0) {
                for (int i = 0; i < list.Count; i++) {
                    temp += list[i] + "\t";
                }
                if (writeMethord == WRITE_DATA_METHORD.STREAM_WRITER) {
                    StreamWriter sw = new StreamWriter(para_st.fileFullPath, true, Encoding.Default);  //中间变量应为true:可以追加写入，否则覆盖
                    sw.WriteLine(temp);
                    sw.Close();
                }
                if (writeMethord == WRITE_DATA_METHORD.FILE_APPEND) {
                    File.AppendAllText(para_st.fileFullPath, temp + "\r\n"); //此种方法很简单
                }
            }
        }

        /// <summary>
        /// TXT写入数据Title
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="title"></param>
        /// <param name="writeMethord"></param>
        public void WriteResultsTitle(string fileName, List<string> title, WRITE_DATA_METHORD writeMethord = WRITE_DATA_METHORD.FILE_APPEND) {
            para_st.fileFullPath = para_st.filePath + fileName + ".txt";
            if (!System.IO.File.Exists(para_st.fileFullPath)) {
                WriteTxt(title, writeMethord);
            }
        }

        /// <summary>
        /// 写数据外围函数
        /// </summary>
        /// <param name="dataList"></param>
        /// <param name="writeMethord"></param>
        public void WriteDataToTxt(List<string> dataList, WRITE_DATA_METHORD writeMethord = WRITE_DATA_METHORD.FILE_APPEND) {
            WriteTxt(dataList, writeMethord);
        }

        public void CreatFileWriteTitle(string filePath, string fileName, List<string> result, string title) {
            result.Add(title);
            CreatFilePath(filePath);  //若没有明确的地址路径，则可执行文件在哪里放置，则在相应的位置自动创建结果文档
            WriteResultsTitle(fileName + "_" + GetCurrentDataTime(), result);
            result.Clear();           //清除掉title，为数据缓存做准备
        }
        #endregion

        #region Load Excel And Read Data

        /// <summary>
        /// EPPlus 读取EXCEL, 注意: sheetNum Default is 1 for (.Net 3.5 and .Net 4) and 0 for (.Net Core)
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="table"></param>
        /// <param name="sheetNum"></param>
        public void LoadExcelData(string filePath, ref List<List<string>> table, int startRow = 1, int startCol = 1, int sheetNum = 0) {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;     //如果你是一家商业企业，并且已经购买了商业许可证，请使用ExcelPackage类的静态属性LicenseContext:
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;  //如果您在非商业环境中根据Polyform非商业许可使用EPPlus
            FileInfo fileInfo = new FileInfo(filePath);                  //获取Excel的信息
            if (!fileInfo.Exists) {
                MessageBox.Show("Excel not found !!!");
            }
            table.Clear();
            using (ExcelPackage excelPackage = new ExcelPackage(fileInfo)) {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[sheetNum];  //取得Excel中的第一张表
                string[,] data = new string[worksheet.Dimension.End.Row + 1 - startRow, worksheet.Dimension.End.Column + 1 - startCol];
                for (int row = 0; row < data.GetLength(0); row++) {
                    List<string> tableRow = new List<string>();
                    for (int col = 0; col < data.GetLength(1); col++) {
                        data[row, col] = worksheet.Cells[row + startRow, col + startCol].Value == null ? "*" : worksheet.Cells[row + startRow, col + startCol].Value.ToString().Replace(" ", "");
                        tableRow.Add(data[row, col]);
                        if (col == data.GetLength(1) - 1) {
                            table.Add(tableRow);
                        }
                    }
                }
                excelPackage.Stream.Close();
            }
        }
        /// <summary>
        /// 查找寄存器地址
        /// </summary>
        /// <param name="table"></param>
        /// <param name="regName"></param>
        /// <param name="addrOffset"></param>
        /// <returns></returns>
        public void RegLookUpAddr(ref int addr, ref int defaultValue, ref int bitWidth, ref int startBit, List<List<string>> table, string regName, int addrOffset = 3) {
            bool isBreak = false;
            for (int i = 0; i < table.Count; i++) {
                string log = string.Empty;
                for (int j = 0; j < table[0].Count; j++) {
                    if (regName == table[i][j]) {
                        isBreak = true;
                        addr = int.Parse(table[i][j - addrOffset].Replace("0x", ""), System.Globalization.NumberStyles.HexNumber);
                        defaultValue = int.Parse(table[i][j - addrOffset + 2].Replace("0x", ""), System.Globalization.NumberStyles.HexNumber);
                        bitWidth = int.Parse(table[i][j - addrOffset + 5]);
                        startBit = int.Parse(table[i][j - addrOffset + 4]);
                        break;
                    }
                }
                if (isBreak) {
                    break;
                }
            }
        }
        public int ReadRegAddrValue(int regAddr) {
            int value=0;
            return value;
        }
        public int WriteRegValue(int writeValue, int bitWidth, int startBit, int defaultValue) {
            int maxValue = (int)Math.Pow(2, bitWidth) - 1;
            if (writeValue > maxValue) {
                writeValue = writeValue % maxValue;
            }
            else {
                writeValue = writeValue << startBit;
            }
            return defaultValue | writeValue;
        }


        #endregion
    }
}

