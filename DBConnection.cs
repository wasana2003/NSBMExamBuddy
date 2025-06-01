using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSBMExamBuddy
{
    internal class DBConnection
    {
        private static string connectionString = "Data Source=localhost;Initial Catalog=NSBMExamBuddy;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }   
    }

}
