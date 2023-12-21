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

namespace AutoCtrl.CommonForm {
    public partial class TestItemCommonForm : Form {
        public TestItemCommonForm() {
            InitializeComponent();
        }
        public CommonFunctionLib comFunLib = new CommonFunctionLib();
        List<List<string>> table = new List<List<string>>();
        private void btnLoadExcel_Click(object sender, EventArgs e) {
            string filePath = tbFilePath.Text;
            int sheetNum = (int)nudSheetNum.Value;
            rtbLoadExcel.Clear();
            comFunLib.LoadExcelData(filePath, ref table);
            for (int i = 0; i < table.Count; i++) {
                string log = string.Empty;
                for (int j = 0; j < table[0].Count; j++) {
                    log += (table[i][j] + "\t");
                    if (j == table[0].Count - 1) {
                        log += "\n";
                        //rtbLoadExcel.AppendText(log);
                    }
                }
            }
        }
        interface ICompute {
            int Id { get; set; }
            string Name { get; set; }
            void Total();
            void Avg();
        }
        private void btnConfigReg_Click(object sender, EventArgs e) {
            int addr = 0, defaultvalue = 0, bitwidth = 0, bitstart = 0, writeValue = 0;
            comFunLib.RegLookUpAddr(ref addr, ref defaultvalue, ref bitwidth, ref bitstart, table, tbRegName.Text);
            rtbLoadExcel.AppendText(
                 "0x" + Convert.ToString(addr, 16).ToUpper() + "\t"
                + "0x" + Convert.ToString(defaultvalue, 16).ToUpper() + "\t"
                + bitwidth.ToString() + "\t"
                + bitstart.ToString() + "\n"
                );
            writeValue = comFunLib.WriteRegValue((int)nudRegValue.Value, bitwidth, bitstart, defaultvalue);
            rtbLoadExcel.AppendText(
               "0x" + Convert.ToString(addr, 16).ToUpper() + "\t"
               + "0x" + Convert.ToString(writeValue, 16).ToUpper() + "\t"
               + bitwidth.ToString() + "\t"
               + bitstart.ToString() + "\n"
               );
            //comFunLib.WriteRegValue();
            //Program11 mathMajor = new Program11();
            //mathMajor.Main("MarchWay");
            //MathMajor ex = new MathMajor();
            //ex.Id = 1;
            //ex.English = 90;
            //ex.Math = 105;
            //ex.Total();
        }
    }
}
    abstract class ExamResult {
        public int Id { get; set; }
        public double Math { get; set; }
        public double English { get; set; }
        public abstract void Total();
    }
    class MathMajor : ExamResult {
        public override void Total() {
            double total = Math * 0.6 + English * 0.4;
            Console.WriteLine("学号为" + Id + "数学专业学生的成绩为：" + total);
        }
    }
    class EnglishMajor : ExamResult {
        public override void Total() {
            double total = Math * 0.4 + English * 0.6;
            Console.WriteLine("学号为" + Id + "英语专业学生的成绩为：" + total);
        }
    }

class Program11 {
     public void Main(string args) {
        B b = new B(args);
    }
}
class A {
    public A() {
        Console.WriteLine("A类的构造器");
    }
    public A(string name) {
        Console.WriteLine("A类的构造器，传入的值为：" + name);
    }
}
class B : A {
    //public B() {
    //    Console.WriteLine("B类的构造器");
    //}
    public B(string name) {
        Console.WriteLine("B类中带参数的构造器，传入的值为：" + name);
    }
}

