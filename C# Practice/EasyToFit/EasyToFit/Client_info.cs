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
    public partial class Client_info : Form
    {
        DBmanager DB = DBmanager.getInstance();
        public Main m1;
        public Client_info(Main m)
        {
            InitializeComponent();
            String ID =m.User_Name.Text;
            String query = "select `NAME`, `TALL`, `WEIGHT`, `BMI` from `account_client` where `ID`=\"" + ID + "\";";
            MySqlCommand mc = new MySqlCommand(query, DB.getDBConnection());
            MySqlDataReader reader = mc.ExecuteReader();
            while (reader.Read())
            {
                string user_name = reader.GetString("NAME");
                double user_tall = reader.GetDouble("TALL");
                double user_weight = reader.GetDouble("WEIGHT");
                double user_bmi = reader.GetDouble("BMI");
                string bmi_text = user_bmi.ToString("###.###");
                User_ID.Text = m.User_Name.Text;
                User_Name.Text = user_name;
                User_Tall.Text = Convert.ToString(Convert.ToDouble(User_Tall.Text) + user_tall);
                User_Weight.Text = Convert.ToString(Convert.ToDouble(User_Weight.Text) + user_weight);
                User_Bmi.Text = Convert.ToString(Convert.ToDouble(User_Bmi.Text) + bmi_text);
            }
            reader.Close();
        }

        private void Client_info_Load(object sender, EventArgs e)
        {
        }

        private void Modify_name_Click(object sender, EventArgs e)
        {
            String ID = User_ID.Text;
            String Name = Mod_Name.Text;
            String query2 = "update `account_client` set `NAME`=@name where `ID`=\"" + ID + "\";";
            MySqlCommand mc2 = new MySqlCommand();
            mc2.Connection = DB.getDBConnection();
            mc2.CommandText = query2;
            mc2.Prepare();

            mc2.Parameters.AddWithValue("@name", Name);
            mc2.ExecuteNonQuery();
            MessageBox.Show("정상적으로 수정되었습니다.");
            Mod_Name.Clear();
        }
        private void Modify_tall_Click(object sender, EventArgs e)
        {
            String ID = User_ID.Text;
            Double Tall =Convert.ToDouble(Mod_Tall.Text);
            double Weight = Convert.ToDouble(User_Weight.Text);
            double Tall2 = Tall / 100;
            Double Bmi = Weight / (Tall2 * Tall2);
            String query2 = "update `account_client` set `TALL`=@tall , `BMI`=@bmi where `ID`=\"" + ID + "\";";
            MySqlCommand mc2 = new MySqlCommand();
            mc2.Connection = DB.getDBConnection();
            mc2.CommandText = query2;
            mc2.Prepare();

            mc2.Parameters.AddWithValue("@tall", Tall);
            mc2.Parameters.AddWithValue("@bmi", Bmi);
            mc2.ExecuteNonQuery();
            MessageBox.Show("정상적으로 수정되었습니다.");
            Mod_Tall.Clear();
        }
        private void Modify_weight_Click(object sender, EventArgs e)
        {
            String ID = User_ID.Text;
            double Weight = Convert.ToDouble(Mod_Weight.Text);
            double Tall = Convert.ToDouble(User_Tall.Text);
            double Tall2 = Tall / 100;
            double Bmi = Weight / (Tall2 * Tall2);
            String query3 = "update `account_client` set `WEIGHT`=@weight, `BMI`=@bmi where `ID`=\"" + ID + "\";";
            MySqlCommand mc3 = new MySqlCommand();
            mc3.Connection = DB.getDBConnection();
            mc3.CommandText = query3;
            mc3.Prepare();

            mc3.Parameters.AddWithValue("@weight", Weight);
            mc3.Parameters.AddWithValue("@bmi", Bmi);
            mc3.ExecuteNonQuery();
            MessageBox.Show("정상적으로 수정되었습니다.");
            Mod_Weight.Clear();
        }
    }
}
