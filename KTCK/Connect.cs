using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KTCK
{
    class Connect
    {
        public static SqlConnection ConnectDB()
        {
            String connString = "Data Source=DESKTOP-39RP96K; Database=QLNhanSu;Integrated Security = True";
            SqlConnection con = new SqlConnection(connString);
            return con;
        }

    }
}
