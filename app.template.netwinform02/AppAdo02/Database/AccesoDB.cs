using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaDatos.Database
{
    public class AccesoDB
    {
        public static SqlConnection getConnection()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Neptuno"].ConnectionString);
            return cn;
        }
    }
}
