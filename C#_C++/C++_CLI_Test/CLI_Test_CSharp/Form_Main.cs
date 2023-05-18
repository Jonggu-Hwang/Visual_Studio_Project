using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLI_Test_Cpp;

namespace CLI_Test_CSharp
{
    public partial class Form_Main : Form
    {
        ArithmeticClass arithmeticClass = new ArithmeticClass();
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Sum_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox_Sum1.Text);
            double b = double.Parse(textBox_Sum2.Text);
            textBox_Sum3.Text = arithmeticClass.Sum(a, b).ToString();
        }

        private void button_Sub_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox_Sub1.Text);
            double b = double.Parse(textBox_Sub2.Text);
            textBox_Sub3.Text = arithmeticClass.Substract(a, b).ToString();
        }

        private void button_Mul_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox_Mul1.Text);
            double b = double.Parse(textBox_Mul2.Text);
            textBox_Mul3.Text = arithmeticClass.Multiply(a, b).ToString();
        }

        private void button_Div_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox_Div1.Text);
            double b = double.Parse(textBox_Div2.Text);
            textBox_Div3.Text = arithmeticClass.Divide(a, b).ToString();
        }
    }
}
