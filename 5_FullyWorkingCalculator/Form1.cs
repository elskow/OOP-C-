using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Import dependencies for the calculator
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;


namespace _5_FullyWorkingCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        protected bool haveCalculated = false;

        private void resultBox_TextChanged(object sender, EventArgs e)
        {
            if (resultBox.Text.Length == 0) return;

            if (haveCalculated)
            {
                resultBox.Text = "";
                haveCalculated = false;
                return;
            }

            char lastChar = resultBox.Text[resultBox.Text.Length - 1];

            if (IsOperator(lastChar) && !haveCalculated)
            {
                if (resultBoxTemp.Text.Length == 0)
                {
                    resultBoxTemp.Text += resultBox.Text.Remove(resultBox.Text.Length - 1, 1) + lastChar;
                    resultBox.Text = "";
                }
                else if (IsOperator(resultBoxTemp.Text[resultBoxTemp.Text.Length - 1]) && resultBox.Text.Length < 2)
                {
                    resultBoxTemp.Text = resultBoxTemp.Text.Remove(resultBoxTemp.Text.Length - 1, 1) + lastChar;
                    resultBox.Text = "";
                }
                else
                {
                    resultBoxTemp.Text += resultBox.Text.Remove(resultBox.Text.Length - 1, 1) + lastChar;
                    resultBox.Text = "";
                }
            }
        }

        private bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '×' || c == '÷' || c == '%';
        }

        private string PerformOperation(string equation)
        {
            if (resultBoxTemp.Text.Length == 0) return equation;

            DataTable dt = new DataTable();

            // If the equation ends with an operator, remove it
            if (IsOperator(equation[equation.Length - 1]))
            {
                equation = equation.Remove(equation.Length - 1, 1);
            }

            equation = equation.Replace('×', '*');
            equation = equation.Replace('÷', '/');


            return dt.Compute(equation, "").ToString();
        }


        /*
         * The following buttons are for the Operand
         */

        private void button20_Click(object sender, EventArgs e)
        {
            resultBox.Text += "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            resultBox.Text += "×";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            resultBox.Text += "-";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resultBox.Text += "÷";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            resultBox.Text += "%";
        }


        /*
         * The following buttons are for the numbers
         */

        private void button22_Click(object sender, EventArgs e)
        {
            if (resultBox.Text.Length > 0 || resultBoxTemp.Text.Length != 0)
            {
                resultBox.Text += "0";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            resultBox.Text += "1";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            resultBox.Text += "2";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            resultBox.Text += "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            resultBox.Text += "4";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            resultBox.Text += "5";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            resultBox.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            resultBox.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            resultBox.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            resultBox.Text += "9";
        }


        /*
         * The following buttons are for Clear, Clear Entry, Backspace, and Decimal
         */

        private void button1_Click(object sender, EventArgs e)
        {
            resultBoxTemp.Text = "";
            resultBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (resultBox.Text.Length > 0)
            {
                resultBox.Text = resultBox.Text.Remove(resultBox.Text.Length - 1, 1);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (resultBox.Text.Length > 0 && !resultBox.Text.Contains("."))
            {
                resultBox.Text += ".";
            }
        }


        /*
         *  The following buttons are for performing keyboard Press
         */
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                    button22_Click(sender, e);
                    break;
                case '1':
                    button17_Click(sender, e);
                    break;
                case '2':
                    button18_Click(sender, e);
                    break;
                case '3':
                    button19_Click(sender, e);
                    break;
                case '4':
                    button13_Click(sender, e);
                    break;
                case '5':
                    button14_Click(sender, e);
                    break;
                case '6':
                    button15_Click(sender, e);
                    break;
                case '7':
                    button9_Click(sender, e);
                    break;
                case '8':
                    button10_Click(sender, e);
                    break;
                case '9':
                    button11_Click(sender, e);
                    break;
                case '.':
                    button23_Click(sender, e);
                    break;
                case '\b':
                    button4_Click(sender, e);
                    break;
                case '+':
                    button20_Click(sender, e);
                    break;
                case '*':
                    button12_Click(sender, e);
                    break;
                case '-':
                    button16_Click(sender, e);
                    break;
                case '/':
                    button8_Click(sender, e);
                    break;
                case '%':
                    button3_Click_1(sender, e);
                    break;
                case '=':
                    button24_Click(sender, e);
                    break;
                case '\r':
                    button24_Click(sender, e);
                    break;
                default:
                    break;
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            // When the app load dont focus on any button
            this.ActiveControl = null;
            this.ActiveControl = button24;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (resultBox.Text.Length > 0)
            {
                resultBoxTemp.Text += resultBox.Text;
                resultBox.Text = "";
            }

            string equation = resultBoxTemp.Text;
            equation = PerformOperation(equation);

            resultBoxTemp.Text = "";
            resultBox.Text = equation;

            haveCalculated = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label1.Text);
            MessageBox.Show("Copied to clipboard");
        }
    }
}
