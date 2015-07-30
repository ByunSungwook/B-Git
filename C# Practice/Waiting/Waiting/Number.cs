using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waiting
{
    public partial class Number : Form
    {
        public Number()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(num_wait.Text);
            num+=1;
            num_wait.Text = Convert.ToString(num);
            foreach (Form w in Application.OpenForms)
            {
                if (w.Name == "Waiting" || w.Name =="Waiting2" || w.Name=="Main")
                {
                    w.Activate();
                    return;
                }
            }
            Waiting w1 = new Waiting(this);
            Waiting2 w2 = new Waiting2(this);
            Main m1 = new Main(this);
            w1.Show();
            w2.Show();
            m1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
