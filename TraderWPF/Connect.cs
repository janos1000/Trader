using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraderWPF
{
    internal class Connect
    {
        public MySqlConnection _connection;

        private string _host;
        private string _db;
        private string _user;
        private string _password;

        private string _connectionString;

        public Connect()
        {
            _host = "localhost";
            _db = "trader";
            _user = "root";
            _password = "";

            _connectionString = $"server={_host};database={_db};UID={_user};password={_password}";

            _connection = new MySqlConnection(_connectionString);
        }
    }
}
