using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Calculator_Addition_Multiplication
{
    public partial class AdditionMultiplication : Form
    {
        private int a = 0;
        private int b = 0;
        private int resultAddition = 0;
        private int resultMultiplication = 0;

        private static int Addition(int a, int b)
        {
            return a + b;
        }

        private static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public AdditionMultiplication()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

            resultAddition = Addition(a, b);
            resultMultiplication = Multiplication(a, b);

            textBox3.Text = Convert.ToString(resultAddition);
            textBox4.Text = Convert.ToString(resultMultiplication);
        }
    }
}
