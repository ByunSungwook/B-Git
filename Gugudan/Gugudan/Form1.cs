using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gugudan
{
    public partial class Gugudan : Form
    {
        public Gugudan()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem != null && comboBox3.SelectedItem != null)
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(comboBox1.SelectedItem) * Convert.ToInt32(comboBox3.SelectedItem));
            }

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox3.SelectedItem != null)
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(comboBox1.SelectedItem) * Convert.ToInt32(comboBox3.SelectedItem));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToInt32(comboBox1.SelectedItem) * Convert.ToInt32(comboBox3.SelectedItem));
        }

        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aaaaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Gugudan_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void print_Click(object sender, EventArgs e)
        {
            
        }
    }
}
