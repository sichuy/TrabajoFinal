using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    internal class Operacion_pelicula
    {
        public static int Insertar(CamposPelicula camposPelicula)
        {
            int retornar = 0;
            using (SqlConnection conn = BDcine.ObtenerConexion())
            {
                string query = "insert into pelicula (Num_de_ejemplar_P,Titulo,Nacionalidad,productor,conservacion,clave_director) values ('"+camposPelicula.Num_de_ejemplar + "','"+camposPelicula.Titulo+"','"+camposPelicula.Nacionalidad+"','"+camposPelicula.Productor+"','"+camposPelicula.Conservacion+"','"+camposPelicula.Clave_Director+"')";
                SqlCommand cmd = new SqlCommand(query, conn);
                retornar = cmd.ExecuteNonQuery();
            }
            return (retornar);
        }
        public static List<CamposPelicula> VisualizarContacto()
        {
            List<CamposPelicula> lista = new List<CamposPelicula>();
            using (SqlConnection conn = BDcine.ObtenerConexion())
            {

                String querry = "select * from pelicula";
                SqlCommand cnd = new SqlCommand(querry, conn);
                SqlDataReader reader = cnd.ExecuteReader();
                while (reader.Read())
                {

                    CamposPelicula campos2 = new CamposPelicula();
                    campos2.Num_de_ejemplar = reader.GetInt32(0);
                    campos2.Titulo = reader.GetString(1);
                    campos2.Nacionalidad = reader.GetString(2);
                    campos2.Productor = reader.GetString(3);
                    campos2.Conservacion = reader.GetString(4);
                    campos2.Clave_Director = reader.GetInt32(5);
                    lista.Add(campos2);

                }
                conn.Close();
                return lista;

            }
        }
        public static int Update(CamposPelicula camposPelicula)
        {
            int retorna = 0;
            using (SqlConnection conn = BDcine.ObtenerConexion())
            {
                 string query = " update pelicula set Num_de_ejemplar_P= " + camposPelicula.Num_de_ejemplar + ", Titulo='"+camposPelicula.Titulo + "',Nacionalidad= '" + camposPelicula.Nacionalidad + "', productor= '" + camposPelicula.Productor + "',clave_director='"+ camposPelicula.Clave_Director + "'where Num_de_ejemplar_P='" + camposPelicula.Num_de_ejemplar + "'";
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
