using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace EscolarProject.Models
{
    public class Materia
    {
        public int matId { get; set; }
        public string matCodigo { get; set; }
        public string matNombre { get; set; }
        public DateTime matFechaCR { get; set; } 


        public int insert(Materia item)
        {

            string sqlComando = "insert into materias (matCodigo, matNombre) values(@matCodigo, @matNombre)";
            SqlCommand cmd = new SqlCommand(sqlComando, Conexion.getConexion());
            cmd.Parameters.AddWithValue("@matCodigo", item.matCodigo);
            cmd.Parameters.AddWithValue("@matNombre", item.matNombre);
            cmd.ExecuteNonQuery();
            if(cmd.Connection.State == System.Data.ConnectionState.Open){
                cmd.Connection.Close();
            }

            return 1;
        }
        public List<Materia> select()
        {
            try
            {
                List<Materia> listado = new List<Materia>();
                string sqlComando = "select matId, matCodigo, matNombre, matFechaCR from Materias";
                SqlCommand cmd = new SqlCommand(sqlComando, Conexion.getConexion());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (cmd.Connection.State == System.Data.ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }

                if (dt!= null && dt.Rows .Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        Materia materia = new Materia
                        {
                            matId = (int)r["matId"],
                            matCodigo = r["matCodigo"].ToString(),
                            matNombre = r["matNombre"].ToString(),
                            matFechaCR = (DateTime)r["matFechaCR"]
                        };
                        listado.Add(materia);
                    }
                }
                return listado;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
