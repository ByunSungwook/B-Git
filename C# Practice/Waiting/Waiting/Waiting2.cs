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
    public partial class Waiting2 : Form
    {
        public Waiting2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(Waiting_num.Text);
            num -= 1;
            Waiting_num.Text = Convert.ToString(num);
        }

        private void Waiting2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
