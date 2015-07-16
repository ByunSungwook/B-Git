using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CSTO
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs = @"server=data.khuhacker.com;userid=serverstudy;password=serverstudy!@#;database=serverstudy;charset=utf8";
            MySqlConnection con = new MySqlConnection(cs);      // link to database
            con.Open();

            System.Console.Write("새로운 사용자 이름 : ");
            String nm = System.Console.ReadLine();
            System.Console.Write("새로운 사용자 학번 : ");
            String snm = System.Console.ReadLine();
            System.Console.Write("새로운 사용자 성별 : ");
            int s = Int32.Parse(System.Console.ReadLine());

            String inq = "insert into sw_users (studentnum, name, sex) values (@studentnum, @name, @sex)";
            MySqlCommand mc = new MySqlCommand();
            mc.Connection = con;    
            mc.CommandText = inq;
            mc.Prepare();       //send query

            mc.Parameters.AddWithValue("@studentnum", nm);
            mc.Parameters.AddWithValue("@name", snm);
            mc.Parameters.AddWithValue("@sex", s);
            mc.ExecuteNonQuery();

            string query = "select * from sw_users";    //searching query
            MySqlCommand command = new MySqlCommand(query, con);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())   //reading database in query
            {
                String stuno = reader.GetString("studentnum");
                String name = reader.GetString("name");
                int sex = reader.GetInt32("sex");
                String dt = reader.GetDateTime("created").ToString();

                System.Console.WriteLine("------------------------------");
                System.Console.WriteLine("이름 : " + name);
                System.Console.WriteLine("학번 : " + stuno);
                System.Console.WriteLine("성별 : " + ((sex==0)?"남":"여"));
                System.Console.WriteLine("생성시간 : " + dt);
                System.Console.WriteLine("------------------------------");

            }

            con.Close();
        }
    }
}
