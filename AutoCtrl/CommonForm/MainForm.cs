using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCtrl.CommonForm {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }
        public RandomDataForm randomData = new RandomDataForm();
        public InstrumentLinkForm instrumentLink = new InstrumentLinkForm();
        public SerialPortCommunicationForm serialPort = new SerialPortCommunicationForm();
        public TestItemCommonForm testCommon = new TestItemCommonForm();
        public LightingBoardTestForm lightBack = new LightingBoardTestForm();
        public USB_PortForm usb = new USB_PortForm();
        public TCON_Form tcon = new TCON_Form();
        //**************************************************************
        //1.是否多窗体并行
        //show()方法显示窗体后，不影响该程序其他窗体的使用。
        //showDialog()方法显示窗体后，只能在此窗体上进行操作。
        //2.是否影响程序执行
        //show()方法显示窗体后，后面的代码仍会继续执行。
        //showDialog()方法显示窗体后，只有当此窗体关闭后，后面的代码才会继续执行。
        //3. 以下方法, 如果窗体已经打开并被最小化，则还原窗体；若窗体被关闭，则重新打开窗体
        //**************************************************************
        private void btnInstrumentLink_Click(object sender, EventArgs e) {
            foreach (Form from in Application.OpenForms) {
                if (from is InstrumentLinkForm) {
                    instrumentLink = (InstrumentLinkForm)from;
                    break;
                }
            }
            if (instrumentLink == null || instrumentLink.IsDisposed) {
                (new InstrumentLinkForm()).Show();
            }
            else {
                instrumentLink.WindowState = FormWindowState.Normal;
                instrumentLink.Show();
                instrumentLink.Activate();
            }
        }

        private void btnRandomData_Click(object sender, EventArgs e) {
            foreach (Form from in Application.OpenForms) {
                if (from is RandomDataForm) {
                    randomData = (RandomDataForm)from;
                    break;
                }
            }
            if (randomData == null || randomData.IsDisposed) {
                (new RandomDataForm()).Show();
            }
            else {
                randomData.WindowState = FormWindowState.Normal;
                randomData.Show();
                randomData.Activate();
            }

        }

        private void btnSerialPortCom_Click(object sender, EventArgs e) {
            foreach (Form from in Application.OpenForms) {
                if (from is SerialPortCommunicationForm) {
                    serialPort = (SerialPortCommunicationForm)from;
                    break;
                }
            }
            if (serialPort == null || serialPort.IsDisposed) {
                (new SerialPortCommunicationForm()).Show();
            }
            else {
                serialPort.WindowState = FormWindowState.Normal;
                serialPort.Show();
                serialPort.Activate();
            }
        }

        private void btnTestCommonForm_Click(object sender, EventArgs e) {
            foreach (Form from in Application.OpenForms) {
                if (from is TestItemCommonForm) {
                    testCommon = (TestItemCommonForm)from;
                    break;
                }
            }
            if (testCommon == null || testCommon.IsDisposed) {
                (new TestItemCommonForm()).Show();
            }
            else {
                testCommon.WindowState = FormWindowState.Normal;
                testCommon.Show();
                testCommon.Activate();
            }
        }

        private void btnLightBackTest_Click(object sender, EventArgs e) {
            foreach (Form from in Application.OpenForms) {
                if (from is LightingBoardTestForm) {
                    lightBack = (LightingBoardTestForm)from;
                    break;
                }
            }
            if (lightBack == null || lightBack.IsDisposed) {
                (new LightingBoardTestForm()).Show();
            }
            else {
                lightBack.WindowState = FormWindowState.Normal;
                lightBack.Show();
                lightBack.Activate();
            }
        }

        private void btnUsbPort_Click(object sender, EventArgs e) {
            foreach (Form from in Application.OpenForms) {
                if (from is USB_PortForm) {
                    usb = (USB_PortForm)from;
                    break;
                }
            }
            if (usb == null || usb.IsDisposed) {
                (new USB_PortForm()).Show();
            }
            else {
                usb.WindowState = FormWindowState.Normal;
                usb.Show();
                usb.Activate();
            }
        }

        private void btnTconPort_Click(object sender, EventArgs e) {
            foreach (Form from in Application.OpenForms) {
                if (from is TCON_Form) {
                    tcon = (TCON_Form)from;
                    break;
                }
            }
            if (tcon == null || tcon.IsDisposed) {
                (new TCON_Form()).Show();
            }
            else {
                tcon.WindowState = FormWindowState.Normal;
                tcon.Show();
                tcon.Activate();
            }
        }
    }
}
