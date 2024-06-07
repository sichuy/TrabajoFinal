using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    internal class BDcine
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDCine2;Data Source=LAPTOP-YISUS\\ESCUELA");
            conn.Open();
            return conn;
        }
    }
}
