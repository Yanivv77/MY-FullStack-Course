using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;  
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        string input = string.Empty; // text box input
        string operator1 = string.Empty; //number 1
        string operator2 = string.Empty; //number 2
        char operation; // operation type
        double result; // operation result

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Num0_Click(object sender, EventArgs e)
        {
            this.Output.Text = "";
            input += "0";
            this.Output.Text += input;
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            this.Output.Text = "";
            input += "1";
            this.Output.Text += input;
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            this.Output.Text = "";
            input += "2";
            this.Output.Text += input;
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            this.Output.Text = "";
            input += "3";
            this.Output.Text += input;
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            this.Output.Text = "";
            input += "4";
            this.Output.Text += input;
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            this.Output.Text = "";
            input += "5";
            this.Output.Text += input;
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            this.Output.Text = "";
            input += "6";
            this.Output.Text += input;
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            this.Output.Text = "";
            input += "7";
            this.Output.Text += input;
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            this.Output.Text = "";
            input += "8";
            this.Output.Text += input;
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            this.Output.Text = "";
            input += "9";
            this.Output.Text += input;
        }

        private void Div_Click(object sender, EventArgs e)
        {
            operator1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            operator1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            operator1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            operator1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void Pow_Click(object sender, EventArgs e)
        {
            operator1 = input;
            operation = '^';
            input = string.Empty;
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            operator1 = input;
            operation = '&';
            input = string.Empty;
        }


        private void Clear_Click(object sender, EventArgs e)
        {
            this.Output.Text = "0";
            this.input = string.Empty;
            this.operator1 = string.Empty;
            this.operator2 = string.Empty;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            operator2 = input;
             
            double.TryParse(operator1, out double num1);
            double.TryParse(operator2, out double num2);

            if (operation == '+')
            {
                result = num1 + num2;
                Output.Text = result.ToString();
                this.input = string.Empty;
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                Output.Text = result.ToString();
                this.input = string.Empty;
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                Output.Text = result.ToString();
                this.input = string.Empty;
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Output.Text = result.ToString();
                    this.input = string.Empty;
                }
                else
                {
                    Output.Text = "DIV/Zero!";
                    this.input = string.Empty;
                }
                this.input = string.Empty;
            }

            else if (operation == '&')
            {
                if (num1 > 0)
                {
                    result = Math.Sqrt(num2);
                    Output.Text = result.ToString();
                   
                }
                else
                {
                    Output.Text = "Negative";
                   
                }  
            }
            else if (operation == '^')
            {
                
                    result = Math.Pow(num1, num2);
                    Output.Text = result.ToString();

               
            }

            
            this.input = string.Empty;
            this.operator1 = string.Empty;
            this.operator2 = string.Empty;
           



        }

        private void Output_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
