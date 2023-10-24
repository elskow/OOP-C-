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

namespace _5_FullyWorkingCalculator
{
    public partial class Calculator : Form
    {
        private bool anotherOperation = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private static string additionOperation(string eq1, string eq2)
        {
            // Addition
            double result = Convert.ToDouble(eq1) + Convert.ToDouble(eq2);
            return result.ToString();
        }

        private static string subtractionOperation(string eq1, string eq2)
        {
            // Subtraction
            double result = Convert.ToDouble(eq1) - Convert.ToDouble(eq2);
            return result.ToString();
        }

        private static string multiplicationOperation(string eq1, string eq2)
        {
            // Multiplication
            double result = Convert.ToDouble(eq1) * Convert.ToDouble(eq2);
            return result.ToString();
        }

        private static string divisionOperation(string eq1, string eq2)
        {
            // Division
            double result = Convert.ToDouble(eq1) / Convert.ToDouble(eq2);
            return result.ToString();
        }

        private static string modulusOperation(string eq1, string eq2)
        {
            // Modulus
            double result = Convert.ToDouble(eq1) % Convert.ToDouble(eq2);
            return result.ToString();
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {
            // Create when last character is an operator  or a number push resultBox.Text to resultBoxTemp.Text
            if (resultBox.Text.Length > 0)
            {
                if (resultBox.Text[resultBox.Text.Length - 1] == '+' || resultBox.Text[resultBox.Text.Length - 1] == '-' || resultBox.Text[resultBox.Text.Length - 1] == '×' || resultBox.Text[resultBox.Text.Length - 1] == '÷' || resultBox.Text[resultBox.Text.Length - 1] == '%')
                {
                    if (resultBoxTemp.Text.Length == 0)
                    {
                        resultBoxTemp.Text = resultBox.Text.Remove(resultBox.Text.Length - 1, 1) + " " + resultBox.Text[resultBox.Text.Length - 1];
                        resultBox.Text = "";
                    }
                    else
                    {
                        string operand = resultBoxTemp.Text[resultBoxTemp.Text.Length - 1].ToString();
                        string firstEquation = resultBoxTemp.Text.Remove(resultBoxTemp.Text.Length - 1, 1);
                        string secondEquation = resultBox.Text.Remove(resultBox.Text.Length - 1, 1);

                        string result = "";

                        switch (operand)
                        {
                            case "+":
                                result = additionOperation(firstEquation, secondEquation);
                                break;
                            case "-":
                                result = subtractionOperation(firstEquation, secondEquation);
                                break;
                            case "×":
                                result = multiplicationOperation(firstEquation, secondEquation);
                                break;
                            case "÷":
                                result = divisionOperation(firstEquation, secondEquation);
                                break;
                            case "%":
                                result = modulusOperation(firstEquation, secondEquation);
                                break;
                            default:
                                break;
                        }

                        resultBoxTemp.Text = result + " " + resultBox.Text[resultBox.Text.Length - 1];
                        resultBox.Text = "";
                    }
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            resultBox.Text += "+";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultBoxTemp.Text = "";
            resultBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (resultBox.Text.Length > 0)
            {
                resultBox.Text = resultBox.Text.Remove(resultBox.Text.Length - 1, 1);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resultBox.Text += "÷";
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

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

        private void button12_Click(object sender, EventArgs e)
        {
            resultBox.Text += "-";
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

        private void button16_Click(object sender, EventArgs e)
        {
            resultBox.Text += "×";
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

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (resultBox.Text.Length > 0)
            {
                resultBox.Text += "0";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (resultBox.Text.Length > 0 && !resultBox.Text.Contains("."))
            {
                resultBox.Text += ".";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void resultBox_VisibleChanged(object sender, EventArgs e)
        {
            // Seperate every 3 digits with a comma
            for (int i = resultBox.Text.Length - 3; i > 0; i -= 3)
            {
                if (i == 2)
                {
                    break;
                }
                resultBox.Text = resultBox.Text.Insert(i, ",");
            }
        }

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
                case '-':
                    button12_Click(sender, e);
                    break;
                case '*':
                    button16_Click(sender, e);
                    break;
                case '/':
                    button8_Click(sender, e);
                    break;
                case '%':
                    button3_Click_1(sender, e);
                    break;
                default:
                    break;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            resultBox.Text += "%";
        }

        private void resultBoxTemp_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
