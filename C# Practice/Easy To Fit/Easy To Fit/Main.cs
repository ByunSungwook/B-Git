using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_To_Fit
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Tall_TextChanged(object sender ,EventArgs e)
        {

        }

        private void Weight_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Calculate(object sender, EventArgs e)
        {
           
            
            double tall = Convert.ToDouble(Tall.Text);
            double weight = Convert.ToDouble(Weight.Text);
            double stweight = (tall - 100) * 0.9;
            tall /= 100;
            double bmi = weight / (tall * tall);
            Bmi.Text = Convert.ToString(bmi);
            Stdweight.Text = Convert.ToString(stweight);
        }

        private void Bmi_TextChanged(object sender, EventArgs e)
        {

        }

        private void DailyT_TextChanged(object sender, EventArgs e)
        {
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tall.Clear();
            Weight.Clear();
            Bmi.Clear();
            Stdweight.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToInt32(Keys.Back) || e.KeyChar == '\r')
            {
                if (Weight.Text != null && e.KeyChar == '\r')
                {
                    Calculate(sender, e);
                }
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("숫자만 입력하실 수 있습니다.");
            }
        }

        private void Tall_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToInt32(Keys.Back) || e.KeyChar == '\t')
            { }
            else
            {
                e.Handled = true;
                MessageBox.Show("숫자만 입력하실 수 있습니다.");
            }
        }
    }
}
