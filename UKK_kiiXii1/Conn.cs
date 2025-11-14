using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace UKK_kiiXii1
{
    internal class Conn
    {
        private const string ConnectionString = "Data Source=DESKTOP-MOUI7DH\\SQLEXPRESS;Initial Catalog=ukk_riki;Integrated Security=True;Trust Server Certificate=True";

        public SqlConnection GetConn()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
