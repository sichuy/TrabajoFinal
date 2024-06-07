using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    internal class CamposAlquiler
    {
        public CamposAlquiler() 
        {
        }
        public CamposAlquiler(int id_alquiler, DateTime fecha_alquiler,DateTime fecha_devolucion,int dni_cliente, string num_de_ejemplar)
        {
            Fecha_Alquiler = fecha_alquiler;
            Fecha_Devolucion= fecha_devolucion;
            Dni_cliente = dni_cliente;
            Num_de_ejemplar=num_de_ejemplar;
        }
        public string Id_Alquiler { get; set; }
        public DateTime Fecha_Alquiler { get; set; }
        public DateTime Fecha_Devolucion { get; set; }
        public int Dni_cliente { get; set; }
        public string Num_de_ejemplar { get; set; }
    }
}
