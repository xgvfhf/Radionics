using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
namespace Radionics
{
    public partial class Small_diamtr : Form
    {
        static Dictionary<string, double> Compliance = new Dictionary<string, double>()
        {
            ["Залізо"] = 0.127,
            ["Константин"] = 0.07,
            ["Мідь"] = 0.034,
            ["Нікелін"] = 0.06
        };
        public Small_diamtr()
        {
            InitializeComponent();
        }

        private void Small_diamtr_Load(object sender, EventArgs e)
        {
            material1.Items.AddRange(Compliance.Keys.ToArray());
            material2.Items.AddRange(Compliance.Keys.ToArray());
        } 
        
        private void diam_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txtbx = sender as TextBox;
            char ch = e.KeyChar;
            string text = txtbx.Text;
            bool digitAfterNull = (text.StartsWith("0") && !text.Contains(".") && Char.IsDigit(ch));
            bool doubleComma = (ch != '.' || text.IndexOf(".") != -1);
            bool startsWithComa = (text == "" && ch == '.');
            if (ch != 8)
            {
                if (!Char.IsDigit(ch) || digitAfterNull)
                {

                    if (doubleComma || startsWithComa)
                    {
                        e.Handled = true;
                    }

                }

            }
        }

        private void Count_amper_Click(object sender, EventArgs e)
        {
            try
            {
                if (material1.SelectedItem != null)
                {
                    double diam = Convert.ToDouble(this.diam.Text, CultureInfo.InvariantCulture);
                    double amper = (diam - 0.005) / Compliance[material1.SelectedItem.ToString()];
                    if (diam >= 0.02 && diam <= 0.2)
                    {
                        amperage.Text = String.Format("{0:N2}", amper);
                    }
                    else
                        MessageBox.Show("Діаметр знаходиться за межами інтервалу 0.02-0.2 мм");
                }
                else
                    MessageBox.Show("Введіть всі дані");
            }
            catch (Exception)
            {

                MessageBox.Show("Введіть всі дані");
            }
        }

        private void Count_diam_Click(object sender, EventArgs e)
        {
            try
            {
                if (material2.SelectedItem != null)
                {
                    double amper = Convert.ToDouble(textBox2.Text, CultureInfo.InvariantCulture);
                    double diam = amper * Compliance[material2.SelectedItem.ToString()] + 0.005;
                    if (diam >= 0.02 && diam <= 0.2)
                    {
                        diametr.Text = String.Format("{0:N2}", diam);
                    }
                    else
                        MessageBox.Show("Таке значення сили струму недопутиме для даного типу проводу,спробуйте вид > 0.2mm");
                }
                else
                    MessageBox.Show("Введіть всі дані");

            }
            catch (Exception)
            {

                MessageBox.Show("Введіть всі дані");
            }
        }
    }
}
