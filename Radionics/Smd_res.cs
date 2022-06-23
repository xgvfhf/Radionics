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
            string text = textBox1.Text;
            if (text.Length == 3)
            {
                string value1;
                string value2 = text[2].ToString();
                if (text.StartsWith("0"))
                    value1 = text[1].ToString();

                else
                    value1 = text.Substring(0, 2);
                label2.Text = (Convert.ToInt32(value1) * Math.Pow(10, Convert.ToInt32(value2))).ToString() + " Oм";
            }
            else
                MessageBox.Show("Потрібно 3 числа!");
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
            if (textBox2.Text.Length >= 2)
            {
                string value1 = textBox2.Text[0].ToString();
                string value2 = textBox2.Text[1].ToString();
                string value3 = Math.Log10(Convert.ToInt32(textBox2.Text) / Convert.ToDouble(value1 + value2)).ToString();
                textBox1.Text = value1 + value2 + value3;
            }
            else
                textBox1.Text = "0" + textBox2.Text + "0";
            
            
        }
    }
}
