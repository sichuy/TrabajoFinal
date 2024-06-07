using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
   internal class OperacionAlquiler
   { 

      public static int Insertar(CamposAlquiler camposAlquiler)
      {
        int retornar = 0;
        using (SqlConnection conn = BDcine.ObtenerConexion())
        {
            string query = "insert into alquilada (id_alquiler,Fecha_Alquiler,Fecha_Devolucion,Dni_cliente,Num_de_ejemplar_P) values ('"+camposAlquiler.Id_Alquiler+"','" + camposAlquiler.Fecha_Alquiler + "','" + camposAlquiler.Fecha_Devolucion + "','" + camposAlquiler.Dni_cliente + "','"+camposAlquiler.Num_de_ejemplar+"')";
            SqlCommand cmd = new SqlCommand(query, conn);
            retornar = cmd.ExecuteNonQuery();
        }
        return (retornar);
      }
        public static List<CamposAlquiler> VisualizarContacto()
        {
            List<CamposAlquiler> lista = new List<CamposAlquiler>();
            using (SqlConnection conn = BDcine.ObtenerConexion())
            {

                String querry = "select * from alquilada";
                SqlCommand cnd = new SqlCommand(querry, conn);
                SqlDataReader reader = cnd.ExecuteReader();
                while (reader.Read())
                {

                    CamposAlquiler campos3 = new CamposAlquiler();
                    campos3.Id_Alquiler = reader.GetString(0);
                    campos3.Num_de_ejemplar = reader.GetString(4);
                    campos3.Fecha_Alquiler = reader.GetDateTime(1);
                    campos3.Fecha_Devolucion = reader.GetDateTime(2);
                    campos3.Dni_cliente = reader.GetInt32(3);
                    lista.Add(campos3);
                }
                conn.Close();
                return lista;

            }
        }
        public static int Update(CamposAlquiler camposAlquiler)
        {
            int retorna = 0;
            using (SqlConnection conn = BDcine.ObtenerConexion())
            {
                string query = " update alquilada set Fecha_Alquiler= " + camposAlquiler.Fecha_Alquiler + ", Fecha_Devolucion='" + camposAlquiler.Fecha_Devolucion + "',Dni_cliente= '" + camposAlquiler.Dni_cliente + "', Num_de_ejemplar_P= '" + camposAlquiler.Num_de_ejemplar + "' where id_alquiler='" + camposAlquiler.Id_Alquiler + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                retorna = cmd.ExecuteNonQuery();
                conn.Close();

            }
            return retorna;
        }
        public static int Delete(int Id)
        {
            int retorna = 0;
            using (SqlConnection conn = BDcine.ObtenerConexion())
            {
                string query = " delete from cliente where Num_de_ejemplar_P =" + Id + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                retorna = cmd.ExecuteNonQuery();
                conn.Close();
            }

            return retorna;
        }
    }
}
