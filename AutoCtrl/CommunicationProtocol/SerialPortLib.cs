using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoCtrl.CommonFunction;

namespace AutoCtrl.CommunicationProtocol {
    public class SerialPortLib {
        public struct Para_St {
            public string[] baud;
            public string[] stop;
            public string[] verify;
            public int txCnt;
            public int rxCnt;
            public int readByteNum;
            public byte[] received_buf;
            public string strTemp;
            public bool timeViewEn;
            public System.IO.Ports.SerialPort serialPort;
            public RadioButton rbTxHex;
            public RadioButton rbRxHex;
            public CheckBox cbSendNewLine;
            public RichTextBox rtbRx;
            public RichTextBox rtbTx;
            public Label lbTxCnt;
            public Label lbRxCnt;
            public StringBuilder sb;     //为了避免在接收处理函数中反复调用，依然声明为一个全局变量
        }
        public Para_St para_st = new Para_St();
        public void DisplayFunction(string str) {
            if (para_st.timeViewEn) {
                para_st.rtbRx.AppendText("[" + System.DateTime.Now.ToString("HH:mm:ss") + "][TX]◁▶:" + str.ToString() + "\n");
            }
            else {
                para_st.rtbRx.AppendText("[TX]◁▶:" + str + "\n");
            }
            para_st.rtbRx.ScrollToCaret();
        }
        public void SerialPort_DataSend(string str) {
            DisplayFunction(str);
            string strSend = str;
            string sendBuf = strSend;            //发送缓冲
            string sendnoNull = sendBuf.Trim();  //去除前后空白字符
            string sendnoCommaE = sendnoNull.Replace(',', ' ');      //去掉英文逗号
            string sendnoCommaC = sendnoCommaE.Replace('，', ' ');   //去掉中文逗号
            string sendnoStr1 = sendnoCommaC.Replace("0x", "");
            string sendnoStr2 = sendnoStr1.Replace("0X", "");
            string[] strArray = sendnoStr2.Split(' ');
            int byteBufferLength = strArray.Length;
            byte[] byteBuffer = new byte[byteBufferLength]; //定义除去空字符后的新发送缓冲数组
            //发送模式判断                                               
            if (para_st.rbTxHex.Checked) {
                for (int i = 0; i < strArray.Length; i++)   //去掉数组中的空字符元素
                {
                    if (strArray[i] == "") {
                        byteBufferLength--;
                    }
                }
                int ii = 0;
                for (int i = 0; i < strArray.Length; i++) {
                    Byte[] bytesOfStr = Encoding.Default.GetBytes(strArray[i]); //将每个字符元素编码为一个字节
                    int decNum = 0;
                    if (strArray[i] == "") {
                        continue;
                    }
                    else {
                        decNum = Convert.ToInt32(strArray[i], 16);         //将空字符以外的字符元素转换成32位有符号整形
                    }
                    try         //保证发送文本框中只能输入一个字节的字符即eb 90等
                    {
                        byteBuffer[ii] = Convert.ToByte(decNum);
                    }
                    catch (System.Exception) {
                        MessageBox.Show("字节越界，请逐个字节输入！", "Error");
                        return;
                    }
                    ii++;
                }
                para_st.serialPort.Write(byteBuffer, 0, byteBuffer.Length);
                if (para_st.cbSendNewLine.Checked) {
                    para_st.serialPort.Write("");
                }
            }
            else {
                para_st.serialPort.WriteLine(para_st.rtbTx.Text);
            }
            para_st.txCnt += byteBuffer.Length;
            para_st.lbTxCnt.Text = para_st.txCnt.ToString();
        }

        /// <summary>
        /// 初步考验此函数不成功 20220630
        /// </summary>
        public void SerialPort_DataReceive() {
            //Part1:串口接收读取
            ReadBuffer();
            //Part2:遍历数组进行字符串转化及拼接
            para_st.sb.Clear();     //防止出错,首先清空字符串构造器
            foreach (byte b in para_st.received_buf) {
                if (para_st.rbRxHex.Checked)
                    para_st.sb.Append(b.ToString("X2") + " ");
                else
                    para_st.sb.Append(b.ToString() + " ");
            }
            try {
                if (para_st.timeViewEn) {
                    para_st.rtbRx.AppendText("[" + System.DateTime.Now.ToString("HH:mm:ss") + "][RX]◀▷:" + para_st.sb.ToString() + "\n");
                }
                else {
                    para_st.rtbRx.AppendText("[RX]◀▷:" + para_st.sb.ToString() + "\n");
                }
                para_st.rtbRx.ScrollToCaret();
                para_st.lbRxCnt.Text = para_st.rxCnt.ToString();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 初步考验此函数不成功 20220630
        /// </summary>
        public void SerialPort_DataReceived() {
            if (para_st.serialPort.IsOpen)     //此处可能没有必要判断是否打开串口，但为了严谨性，我还是加上了
            {
                byte[] byteRead = new byte[para_st.serialPort.BytesToRead];    //BytesToRead:sp1接收的字符个数
                if (para_st.rbTxHex.Checked)                          //'发送字符串'单选按钮
                {
                    para_st.rtbRx.Text += para_st.serialPort.ReadLine() + "\r\n"; //注意：回车换行必须这样写，单独使用"\r"和"\n"都不会有效果
                    para_st.serialPort.DiscardInBuffer();                      //清空SerialPort控件的Buffer 
                }
                else                                            //'发送16进制按钮'
                {
                    try {
                        Byte[] receivedData = new Byte[para_st.serialPort.BytesToRead];        //创建接收字节数组
                        para_st.serialPort.Read(receivedData, 0, receivedData.Length);         //读取数据                       
                        para_st.serialPort.DiscardInBuffer();                                  //清空SerialPort控件的Buffer
                        string strRcv = null;

                        for (int i = 0; i < receivedData.Length; i++) //窗体显示
                        {

                            strRcv += receivedData[i].ToString("X2");  //16进制显示
                        }
                        para_st.rtbRx.Text += strRcv + "\r\n";
                    }
                    catch (System.Exception ex) {
                        MessageBox.Show(ex.Message, "出错提示");
                        para_st.rtbTx.Text = "";
                    }
                }
            }
            else {
                MessageBox.Show("请打开某个串口", "错误提示");
            }
        }

        public void ReadBuffer() {
            System.Threading.Thread.Sleep(10);                        //等待接收完成数据
            para_st.readByteNum = para_st.serialPort.BytesToRead;     //获取接收缓冲区中的字节数
            para_st.received_buf = new byte[para_st.readByteNum];     //声明一个大小为num的字节数据用于存放读出的byte型数据
            para_st.rxCnt += para_st.readByteNum;                     //接收字节计数变量增加nun
            para_st.serialPort.Read(para_st.received_buf, 0, para_st.readByteNum);   //读取接收缓冲区中num个字节到byte数组中
        }
    }
}
