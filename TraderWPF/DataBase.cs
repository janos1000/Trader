using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraderWPF
{
    internal class DataBase
    {
        Connect conn = new Connect();

        public object AddNewUser(object user)
        {
            conn._connection.Open();

            string sql = "INSERT INTO `users`(`Username`, `FullName`, `Password`, `Salt`, `Email`) VALUES (@username,@fullname,@password,@salt,@email)";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn._connection);

            cmd.Parameters.AddWithValue("@username", user);
            cmd.Parameters.AddWithValue("@fullname", user);
            cmd.Parameters.AddWithValue("@password", user);
            cmd.Parameters.AddWithValue("@salr", user);
            cmd.Parameters.AddWithValue("@email", user);

            cmd.ExecuteNonQuery();

            conn._connection.Close();

            return null;
        }
    }
}
