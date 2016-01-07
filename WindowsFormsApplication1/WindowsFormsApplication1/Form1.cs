using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private ClassLibrary1.Calculator cal = new ClassLibrary1.Calculator();
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void concatNum(int num)
        {
            if (one.ForeColor == Color.Crimson)
                one.Text += num;
            else if (two.ForeColor == Color.Crimson)
                two.Text += num; 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            concatNum(0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            concatNum(1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            concatNum(2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            concatNum(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            concatNum(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            concatNum(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            concatNum(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            concatNum(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            concatNum(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            concatNum(9);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operatorLabel.Text = "-";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            operatorLabel.Text = "*";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operatorLabel.Text = "/";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            one.Text = "0";
            two.Text = "0";
            answer.Text = null;
            one.ForeColor = Color.Crimson;
            two.ForeColor = Color.Black;
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            cal.getInput(one.Text, two.Text, operatorLabel.Text, new Logging("WindowForm"));
            answer.Text = cal.calculate();

        }

        private void one_Click(object sender, EventArgs e)
        {
            one.ForeColor = Color.Crimson;
            two.ForeColor = Color.Black;
        }

        private void two_Click(object sender, EventArgs e)
        {
            two.ForeColor = Color.Crimson;
            one.ForeColor = Color.Black;
        }

        private void add_Click(object sender, EventArgs e)
        {
            operatorLabel.Text = "+";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (one.ForeColor == Color.Crimson)
            { if (one.Text.IndexOf(".") == -1) one.Text += "."; }
            if (two.ForeColor == Color.Crimson)
            { if (two.Text.IndexOf(".") == -1) two.Text += "."; }

        }
    }
}
