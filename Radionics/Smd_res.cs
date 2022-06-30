using System;
using System.Windows.Forms;

namespace Radionics
{
    public partial class Smd_res : Form
    {
        public Smd_res()
        {
            InitializeComponent();
        }

        private void Count_Click(object sender, EventArgs e)
        {
            resistance.Text = new Smd().DefineParameters(code.Text);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = enterResistance.Text;
            char ch = e.KeyChar;
            if (ch!=8)
            {
                if (!Char.IsDigit(ch) || text.Length > 10 )
                {
                    e.Handled = true;
                }
                if (text.CompareTo("")==0 && ch=='0' || text.Length > 1 && ch != 0)
                {
                    e.Handled = true;
                }
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (enterResistance.Text.CompareTo("") != 0)
            {
                if (enterResistance.Text.Length >= 2)
                    code.Text = new Smd().GetCode(enterResistance.Text);
                else
                    code.Text = "0" + enterResistance.Text + "0";
            }
            else
                MessageBox.Show("Введіть значення!");
        }

        private void code_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = code.Text;
            char ch = e.KeyChar;
            if (ch != 8)
            {
                if (!Char.IsDigit(ch) || text.Length > 2)
                {
                    e.Handled = true;
                }
            }
        }

        private void enterResistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = enterResistance.Text;
            char ch = e.KeyChar;
            if (ch != 8)
            {
                if (!Char.IsDigit(ch) || text.Length > 10)
                {
                    e.Handled = true;
                }
                if (text.CompareTo("") == 0 && ch == '0' || text.Length > 1 && ch != '0')
                {
                    e.Handled = true;
                }
            }
        }

        private void Smd_res_Load(object sender, EventArgs e)
        {

        }
    }
}
