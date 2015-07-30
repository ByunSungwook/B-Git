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
using System.Text.RegularExpressions;

namespace EasyToFit
{
    public partial class Signup : Form
    {
        DBmanager DB = DBmanager.getInstance();
        public Signup()
        {
            InitializeComponent();
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Check_ID_Click(object sender, EventArgs e)
        {
            String ID = Sign_ID.Text;
            String query = "select  * from account_client where ID=\"" + ID + "\";";
            MySqlCommand mc = new MySqlCommand(query,DB.getDBConnection());
            MySqlDataReader reader = mc.ExecuteReader();
            if (!reader.Read() && IsValidStr(ID)==true)
            {
                reader.Close();
                MessageBox.Show("사용 가능한 아이디입니다.");
             }
            else  if (!reader.Read() && IsValidStr(ID)==false)
            {
                reader.Close();
                MessageBox.Show("유효한 아이디가 아닙니다. \n 사용가능한 아이디는 영문, 숫자가 조합된 6~12자 의 문자여야 합니다.");
            }
            else
            {
                reader.Close();
                MessageBox.Show("해당 아이디는 이미 있습니다. \n다른 아이디를 입력해주세요.");
                Sign_ID.Clear();
            }
        }

        public bool IsValidStr(string text)
        {
            String Pattern = @"^([a-zA-Z0-9]{6,12})$";
            return Regex.IsMatch(text, Pattern);
        }

        private void Check_PW_Click(object sender, EventArgs e)
        {
            String PW  = Sign_PW.Text;
            if (IsValidStr2(PW) == true)
            {
                MessageBox.Show("사용가능한 비밀번호입니다.");
            }
            else
            {
                MessageBox.Show("사용할 수 없는 비밀번호입니다. \n사용가능한 비밀번호는 영문, 숫자가 조합된 6~15자의 문자여야 합니다.");
            }
        }

        public bool IsValidStr2(string text2)
        {
            String Pattern2 = @"^([a-zA-Z0-9]{6,15})$";
            return Regex.IsMatch(text2, Pattern2);
        }

        private void BackToLogin_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            //set values
            String ID = Sign_ID.Text;
            String PW = Sign_PW.Text;
            String NAME = Name_input.Text;
            string var = Combo_year.Text;
            string var2 = Combo_month.Text;
            string var3 = Combo_Date.Text;
            String BIRTH = String.Concat(var,'-',var2,'-',var3);
            double tall = Convert.ToDouble(Sign_tall.Text);
            double weight = Convert.ToDouble(Sign_weight.Text);
            double trans_tall = tall / 100;
            double bmi = weight/(Math.Pow(trans_tall,2)) ;
            //Check Conditions
            if(Name_input.Text == null || Sign_tall.Text == null || Sign_weight.Text == null)
            {
                MessageBox.Show("필수입력사항을 입력하시지 않았습니다.");
            }
            else if(IsValidStr(ID)==false || IsValidStr2(PW)==false)
            {
                MessageBox.Show("유효하지 않은 아이디 / 비밀번호입니다. 다시 작성해주세요. ");
            }
            else
            {
                //set query and transfer
                String query = "insert into `account_client` (ID, PW, NAME, BIRTH, TALL,WEIGHT,BMI) values(@ID, @PW, @NAME, @BIRTH, @tall, @weight, @bmi);";
                MySqlCommand mc = new MySqlCommand();
                mc.Connection = DB.getDBConnection();
                mc.CommandText = query;
                mc.Prepare();
                //add  values in query
                mc.Parameters.AddWithValue("@ID", ID);
                mc.Parameters.AddWithValue("@PW", PW);
                mc.Parameters.AddWithValue("@NAME", NAME);
                mc.Parameters.AddWithValue("@BIRTH", BIRTH);
                mc.Parameters.AddWithValue("@tall", tall);
                mc.Parameters.AddWithValue("@weight", weight);
                mc.Parameters.AddWithValue("@bmi", bmi);
                mc.ExecuteNonQuery();

                //if Successed
                MessageBox.Show("회원가입이 정상적으로 처리되었습니다.\n가입하신 아이디로 로그인 해주세요.");
                this.Owner.Show();
                this.Close();
            }
        }

        private void Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}