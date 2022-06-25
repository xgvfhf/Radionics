using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radionics
{
    public partial class Ceramic_cond : Form
    {
        public Ceramic_cond()
        {
            InitializeComponent();
        }

        private void Ceramic_cond_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = textBox1.Text;
            char ch = e.KeyChar;
            if (ch != 8)
            {
                if (!Char.IsDigit(ch) || text.Length > 2 || text.CompareTo("")==0 && ch=='0')
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            string text = textBox2.Text;

            bool isDigit = (Char.IsDigit(ch));
            bool digitAfterNull = (text.StartsWith("0") && !text.Contains(".") && Char.IsDigit(ch));
            bool doubleComma = (ch != '.' || text.IndexOf(".") != -1);
            bool startsWithComa = (text == "" && ch == '.');
            bool moreThenTwoDigitsAfterComa = (text.StartsWith("0") && text.Contains(".") && (text.Length - text.IndexOf(".")) > 2);
            bool moreThenTwoDigitBeforeOrAfterComa = (text.IndexOf(".") > 1 || text.Length - text.IndexOf(".") > 1);
            bool containsComa = text.Contains(".");
            bool startsWithNull = text.Contains("0");
            bool notNullAfterTwoDigits = !text.Contains(".") && text.Length >= 2 && ch != '0';

            if (ch != 8)
            {
                if (!isDigit || digitAfterNull)
                {
                    if (doubleComma)
                    {

                        e.Handled = true;
                    }
                }

                if (startsWithComa || notNullAfterTwoDigits || moreThenTwoDigitsAfterComa)
                {
                    e.Handled = true;
                }

                if (!startsWithNull && containsComa && moreThenTwoDigitBeforeOrAfterComa || text.Length > 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = new Ceramic().DefineParameters(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            if (text.CompareTo("0") != 0 && text.CompareTo("") != 0)
            { textBox1.Text = new Ceramic().GetCode(text); }
            else
                MessageBox.Show("Введіть коректні значення!");
              
        }
    }
}
