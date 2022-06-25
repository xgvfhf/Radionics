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
    public partial class Smd_res : Form
    {
        public Smd_res()
        {
            InitializeComponent();
        }

        private void Smd_res_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = textBox1.Text;
            char ch = e.KeyChar;
            if (ch != 8)
            {
                if (!Char.IsDigit(ch) || text.Length > 2)
                {
                    e.Handled = true;
                }
            }
            
        }

        private void Count_Click(object sender, EventArgs e)
        {
            label2.Text = new Smd().DefineParameters(textBox1.Text);

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = textBox2.Text;
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
            if (textBox2.Text.CompareTo("") != 0)
            {
                if (textBox2.Text.Length >= 2)
                    textBox1.Text = new Smd().GetCode(textBox2.Text);
                else
                    textBox1.Text = "0" + textBox2.Text + "0";
            }
            else
                MessageBox.Show("Введіть значення!");
        }
    }
}
