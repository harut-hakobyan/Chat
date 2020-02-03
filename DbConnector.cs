using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AllChat
{
    public static class DbConnector
    {
        public static string serverName = "remotemysql.com";
        public static string userName = "Lvgd1EnRkT";
        public static string dbName = "Lvgd1EnRkT";
        public static string port = "3306";
        public static string password = "TT2tAPqEGs";
        public static string connStr = "server=" + serverName +
            ";user=" + userName +
            ";database=" + dbName +
            ";port=" + port +
            ";password=" + password + ";";
        public static MySqlConnection conn = new MySqlConnection(connStr);
        public static MySqlConnection connSelector = new MySqlConnection(connStr);
    }
}
