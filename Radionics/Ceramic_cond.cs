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


            Ceramic cr = new Ceramic();
            cr.SetLimit(ch, text);

            if (ch != 8)
            {
                if (!cr.isDigit || cr.digitAfterNull)
                {
                    if (cr.doubleComma)
                    {

                        e.Handled = true;
                    }
                }

                if (cr.startsWithComa || cr.notNullAfterTwoDigits || cr.moreThenTwoDigitsAfterComa)
                {
                    e.Handled = true;
                }

                if (!cr.startsWithNull && cr.containsComa && cr.moreThenTwoDigitBeforeOrAfterComa || text.Length > 8)
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
