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
    public partial class Tightns : Form
    {
        static Dictionary<string, string> mechanich = new Dictionary<string, string>()
        {
            ["0"] = "Без захисту",
            ["1"] = "Захист від зовнішніх предметів діаметром більше рівне 50мм",
            ["2"] = "Захист від зовнішніх предметів діаметром більше рівне 12.5мм",
            ["3"] = "Захист від зовнішніх предметів діаметром більше рівне 2.5мм",
            ["4"] = "Захист від зовнішніх предметів діаметром більше рівне 1мм",
            ["5"] = "Пилезахищено",
            ["6"] = "Пиленепроницаємо",
        };
        static Dictionary<string, string> voda2 = new Dictionary<string, string>()
        {
            ["0"] = "Без захисту",
            ["1"] = "Захист від вертикальних капель",
            ["2"] = "Захист від вертикальних капель при нахилі корпусу 15' ",
            ["3"] = "Захист від дощу",
            ["4"] = "Захист від повного оббризгування",
            ["5"] = "Захист від водяних струй",
            ["6"] = "Захист від сильних водяних струй",
            ["6K"] = "Захист від сильних водяних струй під напором",
            ["7"] = "Захист від короткого перебування у воді",
            ["8"] = "Захист від довгого перебування у воді",
            ["9(K)"] = "Захист від струй високої темпратури та під сильним тиском"
        };

        public Tightns()
        {
            InitializeComponent();
        }
        string[] mech_keys = mechanich.Keys.ToArray();
        string[] voda_keys = voda2.Keys.ToArray();
        private void Tightns_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(mechanich.Keys.ToArray());
            comboBox2.Items.AddRange(voda2.Keys.ToArray());
            comboBox3.Items.AddRange(mechanich.Values.ToArray());
            comboBox4.Items.AddRange(voda2.Values.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmbbx = sender as ComboBox;
            switch (cmbbx.Name)
            {
                case "comboBox1":
                    mechanichni.Text = mechanich[cmbbx.SelectedItem.ToString()];
                    break;
                case "comboBox2":
                    voda1.Text = voda2[cmbbx.SelectedItem.ToString()];
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string value1 = mech_keys[comboBox3.SelectedIndex];
                string value2 = voda_keys[comboBox4.SelectedIndex];
                result.Text = value1 + value2;
            }
            catch (Exception)
            {
                MessageBox.Show("Введіть всі дані!");
            }
            
        }
    }
}
