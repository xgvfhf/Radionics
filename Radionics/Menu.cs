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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resistor_Click(object sender, EventArgs e)
        {
            if (smd.Checked)
                new Smd_res().Show();
            else if (normal.Checked)
                new Normal_res().Show();
            else
                MessageBox.Show("Оберіть тип резистора!");

        }

        private void condenser_Click(object sender, EventArgs e)
        {
            if (ceramic.Checked)
                new Ceramic_cond().Show();
            else if (tape.Checked)
                new Tape_cond().Show();
            else
                MessageBox.Show("Оберіть тип конденсатора!");
        }

        private void fuse_Click(object sender, EventArgs e)
        {
            if (small_diam.Checked)
                new Small_diamtr().Show();
            else if (big_diam.Checked)
                new Big_diametr().Show();
            else
                MessageBox.Show("Оберіть тип запобіжника!");
        }

        private void inductance_Click(object sender, EventArgs e)
        {
            new Induct().Show();
        }

        private void tightness_Click(object sender, EventArgs e)
        {
            new Tightns().Show();
        }
    }
}
