using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CSTOMYSQL
{
    class DBmanager
    {
        private static DBmanager instance;

        private MySqlConnection con;

        private DBmanager() 
        {
            string cs = @"server=data.khuhacker.com;userid=serverstudy;password=serverstudy!@#;database=serverstudy;charset=utf8";
            con = new MySqlConnection(cs);
            con.Open();
        }

        public static DBmanager getInstance()
        {
            if (instance == null)
                instance = new DBmanager();
            return instance;
        }

        public MySqlConnection getDBConnection()
        {
            return con;
        }
    }
}
