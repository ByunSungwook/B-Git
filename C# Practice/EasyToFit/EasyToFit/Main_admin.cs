using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EasyToFit
{
    public partial class Main_admin : Form
    {
        DBmanager DB = DBmanager.getInstance();
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

        private void Search_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenF = new OpenFileDialog();
            OpenF.DefaultExt = "jpg";
            OpenF.Filter = "Image Files(*.jpg; *jpeg; *gif; *bmp; *png;)| *.jpg; *jpeg; *gif; *bmp; *png";
            OpenF.ShowDialog();
            if (OpenF.FileNames.Length > 0)
            {
                String fullname = OpenF.FileName;
                Picture_preview.ImageLocation = fullname;
            }
        }

        private void Upload_Click(object sender, EventArgs e)
        {

        }
    }
}
