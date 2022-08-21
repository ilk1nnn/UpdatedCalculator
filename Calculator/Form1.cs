using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.Designer;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double val = 0;
        string op = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void seven_btn_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "7";

        }

        private void one_btn_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "1";
        }

        private void zero_btn_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "0";

        }

        private void two_btn_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "2";

        }

        private void three_btn_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "3";

        }

        private void four_btn_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "4";

        }

        private void five_btn_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "5";

        }

        private void six_btn_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "6";

        }

        private void eigth_btn_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "8";

        }

        private void nine_btn_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "9";
        }

        private void AC_btn_Click(object sender, EventArgs e)
        {
            result.Text = string.Empty;
        }

        private void operator_click(object sender, EventArgs e)
        {
            double digit = double.Parse(result.Text);
            result.Text = "";
            op = "+";
            val = digit;
            operation_pressed = true;
        }

        private void equalbtn_Click(object sender, EventArgs e)
        {
            switch(op)
            {
                case "+":
                    result.Text = (val + double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (val - double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (val * double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    if(double.Parse(result.Text) == 0)
                    {
                        result.Text = "Error";
                        break;
                    }
                    result.Text = (val / double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
                    operation_pressed=false;
            }
        }

        private void minusbtn_Click(object sender, EventArgs e)
        {
            double digit = double.Parse(result.Text);
            result.Text = "";
            op = "-";
            val = digit;
            operation_pressed = true;
        }

        private void multbtn_Click(object sender, EventArgs e)
        {
            double digit = double.Parse(result.Text);
            result.Text = "";
            op = "*";
            val = digit;
            operation_pressed = true;
        }

        private void dividebtn_Click(object sender, EventArgs e)
        {
            double digit = double.Parse(result.Text);
            result.Text = "";
            op = "/";
            val = digit;
            operation_pressed = true;
        }
    }
}
