using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    internal class OperacionCliente
    {


        public static int Insertar(CamposCliente camposClientes)
        {
            int retornar = 0;
            using (SqlConnection conn = BDcine.ObtenerConexion())
            {
                string query = "insert into cliente (Dni_cliente,Nombre,Direccion,Telefono,Dni_socio) values ('" + camposClientes.Dni_cliente + "', " + camposClientes.Nombre + ", '" + camposClientes.Direccion + "','" + camposClientes.Telefono + "','" + camposClientes.Dni_socio + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                retornar = cmd.ExecuteNonQuery();
            }
            return (retornar);
        }
        public static List<CamposCliente> VisualizarContacto()
        {
            List<CamposCliente> lista = new List<CamposCliente>();
            using (SqlConnection conn = BDcine.ObtenerConexion())
            {

                String querry = "select * from cliente";
                SqlCommand cnd = new SqlCommand(querry, conn);
                SqlDataReader reader = cnd.ExecuteReader();
                while (reader.Read())
                {

                    CamposCliente campos1 = new CamposCliente();
                    campos1.Dni_cliente = reader.GetInt32(0);
                    campos1.Nombre = reader.GetString(1);
                    campos1.Direccion = reader.GetString(2);
                    campos1.Telefono = reader.GetString(3);
                    campos1.Dni_socio = reader.GetString(4);
                    lista.Add(campos1);

                }
                conn.Close();
                return lista;

            }
        }
        public static int Update(CamposCliente camposClientes)
        {
            int retorna = 0;
            using (SqlConnection conn = BDcine.ObtenerConexion())
            {
                string query = " update cliente set Nombre= " + camposClientes.Nombre + ", Direccion='" + camposClientes.Direccion + "',Telefono= '" + camposClientes.Telefono + "', Dni_socio= '" + camposClientes.Dni_socio + "' where Dni_cliente='" + camposClientes.Dni_cliente + "'";
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
                string query = " delete from cliente where Dni_cliente =" + Id + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                retorna = cmd.ExecuteNonQuery();
                conn.Close();
            }

            return retorna;
        }
    }
}

