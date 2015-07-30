using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyToFit
{
    public partial class Main_admin : Form
    {
        public Main_admin()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 로그아웃 하시겠습니까?", "Log out", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Owner.Show();
                this.Close();
            }
        }

        private void Main_admin_Load(object sender, EventArgs e)
        {

        }
    }
}
