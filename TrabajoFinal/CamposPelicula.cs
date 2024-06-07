using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    internal class CamposPelicula
    {
        public CamposPelicula()
        { 
        }
        public CamposPelicula(int num_de_ejemplar, string titulo, string nacionalidad,string productor,string conservacion, int clave_director)
        {
            Num_de_ejemplar = num_de_ejemplar;
            Titulo = titulo;
            Nacionalidad = nacionalidad;
            Productor = productor;
            Conservacion = conservacion;
            Clave_Director = clave_director;
        }
        public int Num_de_ejemplar { get; set; }
        public string Titulo { get; set; }
        public string Nacionalidad { get; set; }
        public string Productor { get; set; }
        public string Conservacion { get; set; }
        public int Clave_Director { get; set; }

    }
}
