using System;
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
     
        private void enterCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            string text = enterCapacity.Text;


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

        private void code_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = code.Text;
            char ch = e.KeyChar;
            if (ch != 8)
            {
                if (!Char.IsDigit(ch) || text.Length > 2 || text.CompareTo("") == 0 && ch == '0')
                {
                    e.Handled = true;
                }
            }
        }

        private void Count_Click(object sender, EventArgs e)
        {
            result.Text = new Ceramic().DefineParameters(code.Text);
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string text = enterCapacity.Text;
            if (text.CompareTo("0") != 0 && text.CompareTo("") != 0)
            { code.Text = new Ceramic().GetCode(text); }
            else
                MessageBox.Show("Введіть коректні значення!");
        }
    }
}
