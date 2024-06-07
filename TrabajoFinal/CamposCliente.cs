using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    internal class CamposCliente
    {
        public CamposCliente()
        {
        }
        public CamposCliente(int dni_cliente, string nombre, string direccion, string telefono, string dni_socio)
        {
            Dni_cliente = dni_cliente;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Dni_socio = dni_socio;
        }

        public int Dni_cliente { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Dni_socio { get; set; }

    }
}
