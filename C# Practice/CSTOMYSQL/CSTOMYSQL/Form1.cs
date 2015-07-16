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

namespace CSTOMYSQL
{
    public partial class Form1 : Form
    {
        DBmanager m = DBmanager.getInstance();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String author = Text1.Text;
            String content = Text2.Text;
            String query = "insert into sw_twitter (author,content) values(@author,@content)";
            MySqlCommand mc = new MySqlCommand();
            mc.Connection = m.getDBConnection();
            mc.CommandText = query;
            mc.Prepare();

            mc.Parameters.AddWithValue("@author", author);
            mc.Parameters.AddWithValue("@content", content);
            mc.ExecuteNonQuery();
            


            string que = "select * from sw_twitter";    //searching query
            MySqlCommand command = new MySqlCommand(que, m.getDBConnection());
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())   //reading database in query
            {
                int ind = reader.GetInt32("index");
                String auth = reader.GetString("author");
                String cont = reader.GetString("content");
                dataGridView1.Rows.Add(ind, auth, cont);
            }
            reader.Close();
            Text1.Clear();
            Text2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Text1.Clear();
            Text2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
