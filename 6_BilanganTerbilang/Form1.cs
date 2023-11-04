using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_BilanganTerbilang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static bool isEnglish = false;

        private static string[] englishMegas = { "", "thousand", "million", "billion", "trillion", "quadrillion", "quintillion", "sextillion", "septillion", "octillion", "nonillion", "decillion", "undecillion", "duodecillion", "tredecillion", "quattuordecillion" };
        private static string[] englishUnits = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private static string[] englishTens = { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        private static string[] englishTeens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

        private static string[] indonesiaMegas = { "", "ribu", "juta", "milyar", "triliun", "kuadriliun", "kuantiliun", "sekstiliun", "septiliun", "oktiliun", "noniliun", "desiliun", "undesiliun", "duodesiliun", "tredesiliun", "kuatuordesiliun" };
        private static string[] indonesiaUnits = { "", "satu", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan" };
        private static string[] indonesiaTens = { "", "sepuluh", "dua puluh", "tiga puluh", "empat puluh", "lima puluh", "enam puluh", "tujuh puluh", "delapan puluh", "sembilan puluh" };
        private static string[] indonesiaTeens = { "sepuluh", "sebelas", "dua belas", "tiga belas", "empat belas", "lima belas", "enam belas", "tujuh belas", "delapan belas", "sembilan belas" };

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                isEnglish = false;
                textBox1_TextChanged(sender, e);
            }
            else
            {
                checkBox2.Checked = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                isEnglish = true;
                textBox1_TextChanged(sender, e);
            }
            else
            {
                checkBox1.Checked = true;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox2.Text = "";
                return;
            }

            if (textBox1.Text.Contains(","))
            {
                string[] split = textBox1.Text.Split(',');

                if (split.Length != 2 || !long.TryParse(split[0], out long beforeComma) || !long.TryParse(split[1], out long afterComma))
                {
                    textBox2.Text = "Input must be an integer";
                    return;
                }

                if (isEnglish) textBox2.Text = $"{LongToEnUs(beforeComma)} point {LongToEnUs(afterComma)}";
                if (!isEnglish) textBox2.Text = $"{LongToID(beforeComma)} koma {LongToID(afterComma)}";
                return;
            }

            if (!long.TryParse(textBox1.Text, out long input))
            {
                textBox2.Text = "Input must be an integer";
                return;
            }
            if (isEnglish) textBox2.Text = LongToEnUs(input);
            if (!isEnglish) textBox2.Text = LongToID(input);
        }

        private static string LongToEnUs(long input)
        {
            List<string> words = new List<string>();

            if (input < 0)
            {
                words.Add("minus");
                input *= -1;
            }

            List<long> triplets = LongToTriplets(input);

            if (triplets.Count == 0)
            {
                return "zero";
            }

            for (int idx = triplets.Count - 1; idx >= 0; idx--)
            {
                long triplet = triplets[idx];

                if (triplet == 0)
                {
                    continue;
                }

                long hundreds = triplet / 100 % 10;
                long tens = triplet / 10 % 10;
                long units = triplet % 10;

                if (hundreds > 0)
                {
                    words.Add(englishUnits[hundreds]);
                    words.Add("hundred");
                }

                if (tens == 0 && units == 0)
                {
                    goto tripletEnd;
                }

                switch (tens)
                {
                    case 0:
                        words.Add(englishUnits[units]);
                        break;
                    case 1:
                        words.Add(englishTeens[units]);
                        break;
                    default:
                        if (units > 0)
                        {
                            string word = $"{englishTens[tens]}-{englishUnits[units]}";
                            words.Add(word);
                        }
                        else
                        {
                            words.Add(englishTens[tens]);
                        }
                        break;
                }

            tripletEnd:
                if (!string.IsNullOrEmpty(englishMegas[idx]))
                {
                    words.Add(englishMegas[idx]);
                }

                if ((idx > 0 && triplets[idx - 1] > 0) && (triplet > 0 && triplet < 100))
                {
                    words.Add("and");
                }
            }

            return string.Join(" ", words);
        }

        private static string LongToID (long input)
        {
            List<string> words = new List<string>();

            if (input < 0)
            {
                words.Add("minus");
                input *= -1;
            }

            List<long> triplets = LongToTriplets(input);

            if (triplets.Count == 0)
            {
                return "nol";
            }

            for (int idx = triplets.Count - 1; idx >= 0; idx--)
            {
                long triplet = triplets[idx];

                if (triplet == 0)
                {
                    continue;
                }

                long hundreds = triplet / 100 % 10;
                long tens = triplet / 10 % 10;
                long units = triplet % 10;

                if (hundreds == 1)
                {
                    words.Add("seratus");
                }
                else if (hundreds > 0)
                {
                    words.Add(indonesiaUnits[hundreds]);
                    words.Add("ratus");
                }

                if (tens == 0 && units == 0)
                {
                    goto tripletEnd;
                }

                switch (tens)
                {
                    case 0:
                        words.Add(indonesiaUnits[units]);
                        break;
                    case 1:
                        words.Add(indonesiaTeens[units]);
                        break;
                    default:
                        if (units > 0)
                        {
                            string word = $"{indonesiaTens[tens]} {indonesiaUnits[units]}";
                            words.Add(word);
                        }
                        else
                        {
                            words.Add(indonesiaTens[tens]);
                        }
                        break;
                }

                tripletEnd:
                if (!string.IsNullOrEmpty(indonesiaMegas[idx]))
                {
                    // exception for 1000
                    if (idx == 1 && triplet == 1)
                    {
                        words.RemoveAt(words.Count - 1);
                        words.Add("seribu");
                    }
                    else
                    {
                        words.Add(indonesiaMegas[idx]);
                    }
                }
            }

            return string.Join(" ", words);
        }

        private static List<long> LongToTriplets(long input)
        {
            List<long> triplets = new List<long>();

            while (input > 0)
            {
                triplets.Add(input % 1000);
                input /= 1000;
            }

            return triplets;
        }
    }
}
