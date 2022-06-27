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
            comboBox1.Items.AddRange(Compliance.Keys.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                double diam = Convert.ToDouble(textBox1.Text, CultureInfo.InvariantCulture);
                if (diam >= 0.02 && diam <= 0.2)
                {
                    amperage.Text = ((diam - 0.005) / Compliance[comboBox1.SelectedItem.ToString()]).ToString();
                }
                else
                    MessageBox.Show("Діаметр знаходиться за межами інтервалу 0.02-0.2 мм");
            
        }
    }
}
