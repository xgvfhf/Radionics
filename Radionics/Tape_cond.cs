﻿using System;
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
            comboBox1.Items.AddRange(Keys);
            comboBox2.Items.AddRange(Values);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = textBox1.Text;
            char ch = e.KeyChar;
            if (ch != 8)
            {
                if (!Char.IsDigit(ch) || text.Length > 2 || text.CompareTo("") == 0 && ch == '0')
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
            try
            {
              
                label2.Text = new Ceramic().DefineParameters(textBox1.Text) + Compliance[comboBox1.SelectedItem.ToString()];
            }
            catch (Exception)
            {
                MessageBox.Show("Введіть всі параметри");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            try
            {
                if (text.CompareTo("0")!=0)
                {
                    textBox1.Text = new Ceramic().GetCode(text);
                    comboBox1.Text = Keys[comboBox2.SelectedIndex];
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Введіть коректні значення!");
            }
        }       
    }
}
