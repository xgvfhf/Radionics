using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Radionics
{
    public partial class Induct : Form
    {
        string ValueOfLine1, ValueOfLine2, ValueOfLine3, ValueOfLine4, result;
        enum ColorsNamesLine { Silver = -2, Gold, Black, Brown, Red, Orange, Yellow, Green, Blue, Violet, Gray, White };

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                string text = enterIndct.Text;

                List<char> arr = new List<char>();
                if (text.CompareTo("0") != 0)
                {

                    if (text.Contains("."))
                    {
                        for (int i = 0; i < text.Length; i++)
                        {
                            if (text[i].CompareTo('0') != 0 && text[i].CompareTo('.') != 0)
                            {
                                arr.Add(text[i]);
                            }
                        }
                        arr.Add('0');
                        ValueOfLine1 = arr[0].ToString();
                        ValueOfLine2 = arr[1].ToString();
                        ValueOfLine3 = Math.Log10(Convert.ToDouble(text, CultureInfo.InvariantCulture) / (Convert.ToDouble(ValueOfLine1 + ValueOfLine2))).ToString();
                        SetColor(Convert.ToInt32(ValueOfLine1), Convert.ToInt32(ValueOfLine2), Convert.ToInt32(ValueOfLine3));
                    }
                    else if (text.Length == 1)
                        SetColor(Convert.ToInt32(text), 0, -1);

                    else
                        SetColor(Convert.ToInt32(text[0].ToString()), Convert.ToInt32(text[0].ToString()), Convert.ToInt32(text.Length - 2));
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Введіть усі параметри!");
            }
        }

        void SetColor(int value1, int value2, int value3)
        {
            line1.BackColor = (Color)Compliance[((ColorsNamesLine)value1).ToString()][1];
            line2.BackColor = (Color)Compliance[((ColorsNamesLine)value2).ToString()][1];
            line3.BackColor = (Color)Compliance[((ColorsNamesLine)value3).ToString()][1];
        }

        private void ColorOfLine1_DrawItem(object sender, DrawItemEventArgs e)
        {
            var combobox = sender as ComboBox;
            SolidBrush brush = new SolidBrush((Color)Compliance[(combobox.Items[e.Index]).ToString()][1]);
            e.Graphics.FillRectangle(brush, e.Bounds);
            e.Graphics.DrawString((string)combobox.Items[e.Index], e.Font, Brushes.Black, e.Bounds);
            switch (combobox.Name)
            {
                case "ColorOfLine1":
                    line1.BackColor = brush.Color;
                    ValueOfLine1 = Compliance[(string)combobox.Items[e.Index]][0].ToString();
                    return;

                case "ColorOfLine2":
                    line2.BackColor = brush.Color;
                    ValueOfLine2 = Compliance[(string)combobox.Items[e.Index]][0].ToString();
                    return;

                case "ColorOfLine3":
                    line3.BackColor = brush.Color;
                    ValueOfLine3 = Compliance[(string)combobox.Items[e.Index]][0].ToString();
                    return;

                case "ColorOfLine4":
                    line4.BackColor = brush.Color;

                    if (line4.BackColor == Color.Gold)
                        ValueOfLine4 = " ± 5% ";
                    else if (line4.BackColor == Color.Silver)
                        ValueOfLine4 = " ± 10% ";
                    else
                        ValueOfLine4 = " ± 20% ";
                    return;
            }
        }

        private void Count_Click(object sender, EventArgs e)
        {
            if (ValueOfLine1 != null && ValueOfLine2 != null && ValueOfLine3 != null && ValueOfLine4 != null)
            {
                result = (Convert.ToDouble(ValueOfLine1 + ValueOfLine2) * Math.Pow(10, Convert.ToDouble(ValueOfLine3))).ToString();
                my_result.Text = result + " мкГн" + ValueOfLine4;
            }
        }

        private void enterIndct_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            string text = enterIndct.Text;

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

                if (!cr.startsWithNull && cr.containsComa && cr.moreThenTwoDigitBeforeOrAfterComa || text.Length > 10)
                {
                    e.Handled = true;
                }
            }
        }

        private void accuracy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accuracy.SelectedIndex == 0)
                line4.BackColor = Color.Gold;

            else if (accuracy.SelectedIndex == 1)
                line4.BackColor = Color.Silver;
            else
                line4.BackColor = Color.Black;
        }

        static Dictionary<string, object[]> Compliance = new Dictionary<string, object[]>()
        {
            ["Silver"] = new object[] { -2, Color.Silver },
            ["Gold"] = new object[] { -1, Color.Gold },
            ["Black"] = new object[] { 0, Color.Black },
            ["Brown"] = new object[] { 1, Color.Brown },
            ["Red"] = new object[] { 2, Color.Red },
            ["Orange"] = new object[] { 3, Color.Orange },
            ["Yellow"] = new object[] { 4, Color.Yellow },
            ["Green"] = new object[] { 5, Color.Green },
            ["Blue"] = new object[] { 6, Color.Blue },
            ["Violet"] = new object[] { 7, Color.Violet },
            ["Gray"] = new object[] { 8, Color.Gray },
            ["White"] = new object[] { 9, Color.White }

        };
        string[] names = Compliance.Keys.ToArray();
        public Induct()
        {
            InitializeComponent();
        }

        private void Induct_Load(object sender, EventArgs e)
        {
            ColorOfLine1.Items.AddRange(names.Skip(3).Take(11).ToArray());
            ColorOfLine2.Items.AddRange(names.Skip(2).Take(11).ToArray());
            ColorOfLine3.Items.AddRange(names.Skip(2).Take(4).ToArray());
            ColorOfLine4.Items.AddRange(names.Skip(0).Take(3).ToArray());
            accuracy.Items.AddRange(new string[] { "± 5%", " ± 10%" , "± 20%" });
        }
    }
}
