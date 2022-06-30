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
    public partial class Big_diametr : Form
    {
        static Dictionary<string, double> Compliance = new Dictionary<string, double>()
        {
            ["Залізо"] = 59.2,
            ["Алюміній"] = 24.6,
            ["Мідь"] = 80,
            ["Нікелін"] = 40.8,
            ["Олово"] = 12.8
        };
        public Big_diametr()
        {
            InitializeComponent();
        }

        private void Big_diametr_Load(object sender, EventArgs e)
        {
            material1.Items.AddRange(Compliance.Keys.ToArray());
            material2.Items.AddRange(Compliance.Keys.ToArray());
        }
               
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (material2.SelectedItem != null)
                {
                    double amper = Convert.ToDouble(this.amper.Text, CultureInfo.InvariantCulture);
                    double diam = Math.Pow(amper / Compliance[material2.SelectedItem.ToString()], 2 / 3f);
                    if (diam > 0.2)
                        diametr.Text = String.Format("{0:N2}", diam);

                    else
                        MessageBox.Show("Таке значення сили струму недопутиме для даного типу проводу");
                }
                else
                    MessageBox.Show("Введіть всі дані");

            }
            catch (Exception)
            {

                MessageBox.Show("Введіть всі дані");
            }
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
                    double amper = Math.Pow(diam, 1.5f) * Compliance[material1.SelectedItem.ToString()];
                    if (diam >= 0.2)
                        amperage.Text = String.Format("{0:N2}", amper);

                    else
                        MessageBox.Show("Діаметр менше 0.2 мм");
                }
                else
                    MessageBox.Show("Введіть всі дані коректно");

            }
            catch (Exception)
            {

                MessageBox.Show("Введіть всі дані коректно");
            }
        }

        private void Count_diam_Click(object sender, EventArgs e)
        {
            try
            {
                if (material2.SelectedItem != null)
                {
                    double amper = Convert.ToDouble(this.amper.Text, CultureInfo.InvariantCulture);
                    double diam = Math.Pow(amper / Compliance[material2.SelectedItem.ToString()], 2 / 3f);
                    if (diam > 0.2)
                        diametr.Text = String.Format("{0:N2}", diam);

                    else
                        MessageBox.Show("Таке значення сили струму недопутиме для даного типу проводу");
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
