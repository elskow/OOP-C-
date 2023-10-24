using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_2_Button_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button_1 Clicked !");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button_2 Clicked !");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label1.Text);
            MessageBox.Show("Identity Copied !");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            button1.BackColor = Color.GhostWhite;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            button2.BackColor = Color.GhostWhite;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            button2.BackColor = Color.FromKnownColor(KnownColor.Control);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            button1.BackColor = Color.FromKnownColor(KnownColor.Control);
        }
    }
}
