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
    public partial class Tape_cond : Form
    {
        static Dictionary<string, string> Compliance = new Dictionary<string, string>()
        {
            ["A"] = "± 0.05%",
            ["B/Ж"] = "± 0.1%",
            ["С/У"] = "± 0.25%",
            ["D/Д"] = "± 0.5%",
            ["F/P"] = "± 1%",
            ["G/Л"] = "± 2%",
            ["H"] = "± 2.5%",
            ["L/И"] = "± 5%",
            ["K/C"] = "± 10%",
            ["L"] = "± 15%",
            ["M/B"] = "± 20%",
            ["N/Ф"] = "± 30%",                      
            ["S"] = "± 22%"          
        };
        public Tape_cond()
        {
            InitializeComponent();
        }
        string[] Keys = Compliance.Keys.ToArray();
        string[] Values = Compliance.Values.ToArray();
        private void Tape_cond_Load(object sender, EventArgs e)
        {
            accuracy_literal.Items.AddRange(Keys);
            accuracy_percent.Items.AddRange(Values);
        }

        private void Count_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text = new Ceramic().DefineParameters(code.Text) + Compliance[accuracy_literal.SelectedItem.ToString()];
            }
            catch (Exception)
            {
                MessageBox.Show("Введіть всі параметри");
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

        private void enterCopacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            string text = enterCopacity.Text;

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

        private void submit_Click(object sender, EventArgs e)
        {
            string text = enterCopacity.Text;
            try
            {
                if (text.CompareTo("0") != 0)
                {
                    code.Text = new Ceramic().GetCode(text);
                    accuracy_literal.Text = Keys[accuracy_percent.SelectedIndex];
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Введіть коректні значення!");
            }
        }
    }
}
