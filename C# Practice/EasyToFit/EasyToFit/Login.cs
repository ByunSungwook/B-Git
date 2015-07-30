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
    public partial class Login : Form
    {
        DBmanager DB = DBmanager.getInstance();
        public Login()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            //search ID
            String id = ID_input.Text;
            String pw = Pw_input.Text;
            String query = "select ID from `account_client` where `ID`=\""+id+"\";";
            MySqlCommand mc = new MySqlCommand(query, DB.getDBConnection());
            MySqlDataReader reader = mc.ExecuteReader();
            if (!reader.Read())
            {
                MessageBox.Show("아이디를 다시 한번 확인해주세요.");
                reader.Close();
            }

            else if (reader.GetString("id") == "admin")
            {
                reader.Close();
                //search Password
                String query2 = "select PW from `account_client` where  `PW` =\"" + pw + "\";";
                MySqlCommand mc2 = new MySqlCommand(query2, DB.getDBConnection());
                MySqlDataReader reader2 = mc2.ExecuteReader();
                if (!reader2.Read())
                {
                    MessageBox.Show("비밀번호를 다시 한번 확인해주세요.");
                    reader2.Close();
                }
                else
                {
                    //admin mode
                    this.Visible = false;
                    Main_admin ma1 = new Main_admin();
                    ma1.Owner = this;
                    ma1.Show();
                    reader2.Close();
                }
            }
            else
            {
                reader.Close();
                //search Password
                String query3 = "select PW from `account_client` where  `PW` =\"" + pw + "\";";
                MySqlCommand mc3 = new MySqlCommand(query3, DB.getDBConnection());
                MySqlDataReader reader3 = mc3.ExecuteReader();
                if (!reader3.Read())
                {
                    MessageBox.Show("비밀번호를 다시 한번 확인해주세요.");
                    reader3.Close();
                }
                else
                {
                    this.Visible = false;
                    Main m1 = new Main(ID_input.Text);
                    m1.Owner = this;
                    m1.Show();
                    reader3.Close();
                }
            }            
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료합니다.", "Quit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Join_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Signup s1 = new Signup();
            s1.Owner = this;
            s1.Show();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
        
        private void Pw_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Pw_input.Text != null && e.KeyChar == '\r')
            {
                Enter_Click(sender, e);
            }
        }
    }
}
