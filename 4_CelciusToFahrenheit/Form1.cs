using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_CelciusToFahrenheit
{
    public partial class CelciusToFahrenheit : Form
    {
        private bool celciusChanged = false;
        public CelciusToFahrenheit()
        {
            InitializeComponent();
        }

        private void Fahrenheit_TextChanged(object sender, EventArgs e)
        {
            celciusChanged = false;
        }

        private void Celcius_TextChanged(object sender, EventArgs e)
        {
            celciusChanged = true;
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if ( celciusChanged ) {
                Fahrenheit.Text = (int.Parse(Celcius.Text) * 9 / 5 + 32).ToString();
            }

            else
            {
                Celcius.Text = ((int.Parse(Fahrenheit.Text) - 32) * 5 / 9).ToString();
            }
        }

        private void CelciusToFahrenheit_Load(object sender, EventArgs e)
        {
            this.AcceptButton = ConvertButton;
        }
    }
}
