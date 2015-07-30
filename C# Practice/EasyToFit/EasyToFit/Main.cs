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
    public partial class Main : Form
    {
        DBmanager DB = DBmanager.getInstance();
        public Main(string strName)
        {
            InitializeComponent();
            this.User_Name.Text = strName;
        }

        private void User_Name_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
                this.Owner.Show();
                this.Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
                this.Owner.Show();
                this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void Modify_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Client_info c1 = new Client_info(this);
            c1.Owner = this;
            c1.Show();
        }

        private void Front_trapizius_Click(object sender, EventArgs e)
        {
            String query = "select `PATH` from `train_image` where `IMAGENAME` like\"%trapizius%\";";
            MySqlCommand mc = new MySqlCommand(query, DB.getDBConnection());
            MySqlDataReader reader = mc.ExecuteReader();
            if (reader.Read())
            {
                String Location =reader.GetString("PATH");
                Train_method.ImageLocation = Location;
                Train_Text.Text = @"○손바닥을 몸쪽으로 향하여 그립을 30cm 정도 간격으로 바벨을 잡는다."+'\n' +'\n'+"○몸은 곧게 세우고, 팔꿈치를 들어올려 바벨을 목까지 들어올려준다.";
            } 
            reader.Close();
        }

        private void Front_deltoid1_Click(object sender, EventArgs e)
        {
            String query = "select `PATH` from `train_image` where `IMAGENAME` like\"%deltoid%\";";
            MySqlCommand mc = new MySqlCommand(query, DB.getDBConnection());
            MySqlDataReader reader = mc.ExecuteReader();
            if (reader.Read())
            {
                String Location = reader.GetString("PATH");
                Train_method.ImageLocation = Location;
                Train_Text.Text = @"○덤벨을 어깨 레벨까지 내린다." + '\n' + '\n' + "○등은 곧은 자세를 유지한다." + '\n' + '\n' + "○바벨을 들어올렸을 때, 팔은 양쪽 귀에 닿을 정도로 한다." + '\n' + '\n' + "○서서 해도 되나, 앉아서 할 때 허리에 부담이 덜하다." + '\n' + '\n' + "※덤벨끼리 서로 닿거나 부딪혀서 소리가 나지 않도록 주의하자.";
            }
            reader.Close();
        }
        private void Front_deltoid2_Click(object sender, EventArgs e)
        {
            Front_deltoid1_Click(sender,e);
        }

        private void Front_pectoral_Click(object sender, EventArgs e)
        {
            String query = "select `PATH` from `train_image` where `IMAGENAME` like\"%pectoral%\";";
            MySqlCommand mc = new MySqlCommand(query, DB.getDBConnection());
            MySqlDataReader reader = mc.ExecuteReader();
            if (reader.Read())
            {
                String Location = reader.GetString("PATH");
                Train_method.ImageLocation = Location;
                Train_Text.Text = @"○양쪽의 균형을 맞춰서 위아래로 들었다가 내린다." + '\n' + '\n' + "○운동중에 엉덩이를 들지 않도록 주의한다." + '\n' + '\n' + "○팔꿈치는 몸통에서멀리 떨어지게 일직선이 되도록 한다." + '\n' + '\n' + "○바벨을 내렸을 때 반동을 이용하지 않도록 한다." + '\n' + '\n' + "○어깨보다 넓게 잡도록 한다.";
            }
            reader.Close();
        }

        private void Front_ab_Click(object sender, EventArgs e)
        {
            String query = "select `PATH` from `train_image` where `IMAGENAME` like\"%ab%\";";
            MySqlCommand mc = new MySqlCommand(query, DB.getDBConnection());
            MySqlDataReader reader = mc.ExecuteReader();
            if (reader.Read())
            {
                String Location = reader.GetString("PATH");
                Train_method.ImageLocation = Location;
                Train_Text.Text = @"○시선은 무릎 위 몇센티미터 떨어진 지점에 고정시킨다." + '\n' + '\n' + "○몸을 일으킬때 어깨, 등 윗부분, 목이 가능한 일직선을 이루도록 한다." + '\n' + '\n' + "○손은 가볍게 귀에 대거나 가슴 위에 팔짱을 낀 채로 한다." + '\n' + '\n' + "○몸을 완전히 일으키지 말고, 살짝 들어올려 복근에 자극을 주도록 한다.";
            }
            reader.Close();
        }

        private void Front_quadriceps_Click(object sender, EventArgs e)
        {
            String query = "select `PATH` from `train_image` where `IMAGENAME` like\"%quadriceps%\";";
            MySqlCommand mc = new MySqlCommand(query, DB.getDBConnection());
            MySqlDataReader reader = mc.ExecuteReader();
            if (reader.Read())
            {
                String Location = reader.GetString("PATH");
                Train_method.ImageLocation = Location;
                Train_Text.Text = @"○바벨을 목 뒤에 위치시키고 바를 잡는다." + '\n' + '\n' + "○양 발은 어깨넓이만큼 벌린다." + '\n' + '\n' + "○엉덩이를 뒤로 빼면서 앉으며, 등과 목은 곧게 편 상대를 유지하여, 무릎의 각도가 90도에 가깝게 한다." + '\n' + '\n' + "○앉았을 때 무릎의 위치가 발끝을 넘기지 않도록 한다. 양발이 앞쪽으로 가서 발 뒤꿈치에 힘이 실리도록 한다." + '\n' + '\n' + "○앉을때 가슴을 쭉 펴서 등이 아치형을 그리도록 한다." + '\n' + '\n' + "※동작이 쉽지 않고 자칫하면 허리부상의 위험이 있으니 가벼운 무게부터 시작해서 허리에 부담이 가지 않도록 해준다.";
            }
            reader.Close();
        }

        private void Front_calves1_Click(object sender, EventArgs e)
        {
            String query = "select `PATH` from `train_image` where `IMAGENAME` like\"%calves%\";";
            MySqlCommand mc = new MySqlCommand(query, DB.getDBConnection());
            MySqlDataReader reader = mc.ExecuteReader();
            if (reader.Read())
            {
                String Location = reader.GetString("PATH");
                Train_method.ImageLocation = Location;
                Train_Text.Text = @"○양 발을 나란히 하고 앞꿈치만 바닥을 딛는다. 이 때 바닥은 기존의 바닥보다 한칸 높은, 계단과 같은 지형이어야 한다." + '\n' + '\n' + "○뒤꿈치를 최대한 위쪽으로 들어올리며 숨을 내쉰다." + '\n' + '\n' + "○다시 원 위치로 돌아오며 숨을 들이쉰다.";
            }
            reader.Close();
        }

        private void Front_calves2_Click(object sender, EventArgs e)
        {
            Front_calves1_Click(sender, e);
        }
        private void Front_calves3_Click(object sender, EventArgs e)
        {
            Front_calves1_Click(sender, e);
        }
        private void Front_calves4_Click(object sender, EventArgs e)
        {
            Front_calves1_Click(sender, e);
        }

        private void Front_biceps1_Click(object sender, EventArgs e)
        {
            String query = "select `PATH` from `train_image` where `IMAGENAME` like\"%biceps%\";";
            MySqlCommand mc = new MySqlCommand(query, DB.getDBConnection());
            MySqlDataReader reader = mc.ExecuteReader();
            if (reader.Read())
            {
                String Location = reader.GetString("PATH");
                Train_method.ImageLocation = Location;
                Train_Text.Text = @"○다리는 어깨넓이보다 조금 넓게 벌린다." + '\n' + '\n' + "○팔꿈치는 몸통 옆에 최대한 고정되어야 한다." + '\n' + '\n' + "○턱까지 바벨을 들어올리고, 내릴때는 팔이 펴지도록 내린다. 이 때 손목까지는 펴지지 않도록 한다." + '\n' + '\n' + "○";
            }
            reader.Close();
        }

        private void Front_biceps2_Click(object sender, EventArgs e)
        {
            Front_biceps1_Click(sender, e);
        }

        private void Front_triceps_Click(object sender, EventArgs e)
        {
            String query = "select `PATH` from `train_image` where `IMAGENAME` like\"%triceps%\";";
            MySqlCommand mc = new MySqlCommand(query, DB.getDBConnection());
            MySqlDataReader reader = mc.ExecuteReader();
            if (reader.Read())
            {
                String Location = reader.GetString("PATH");
                Train_method.ImageLocation = Location;
                Train_Text.Text = @"○두 발은 모으고, 무릎은 조금 굽힌 상태에서 등은 곧게 세운다." + '\n' + '\n' + "○팔꿈치는 몸통 옆에 최대한 붙여 위치가 고정되어야 한다." + '\n' + '\n' + "○팔을 쭉 펼때까지 기구를 당긴다." + '\n' + '\n' + "○반동은 사용하지 않는다.";
            }
            reader.Close();
        }

        private void Front_triceps2_Click(object sender, EventArgs e)
        {
            Front_triceps_Click(sender, e);
        }

        private void Front_forearm1_Click(object sender, EventArgs e)
        {
            String query = "select `PATH` from `train_image` where `IMAGENAME` like\"%forearm%\";";
            MySqlCommand mc = new MySqlCommand(query, DB.getDBConnection());
            MySqlDataReader reader = mc.ExecuteReader();
            if (reader.Read())
            {
                String Location = reader.GetString("PATH");
                Train_method.ImageLocation = Location;
                Train_Text.Text = @"○20cm 내외의 간격으로 바벨을 손바닥이 위로하게하여 잡는다." + '\n' + '\n' + "○손목을 바닥쪽으로 젖혀서 바벨을 내린다." + '\n' + '\n' + "○잠시 멈춘 다음 손목을 위로 올려 바벨을 들어올린다.";
            }
            reader.Close();
        }

        private void Front_forearm2_Click(object sender, EventArgs e)
        {
            Front_forearm1_Click(sender, e);
        }


    }
}
