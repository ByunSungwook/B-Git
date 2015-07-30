using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EasyToFit
{
    class DBmanager
    {
        private static DBmanager instance;

        private MySqlConnection con;

        private DBmanager()
        {
            string cs = @"server=127.0.0.1;userid=root;password=apmsetup;database=etf_account;charset=utf8";
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
