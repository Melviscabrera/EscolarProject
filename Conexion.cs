using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EscolarProject
{
    public class Conexion
    {
        public static SqlConnection  getConexion()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=OPTECNOLOGIA; Initial Catalog=DBESCOLAR; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();
                return con;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
