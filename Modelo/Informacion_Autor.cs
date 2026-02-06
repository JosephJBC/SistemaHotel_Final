using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Informacion_Autor
    {
        public string Nombre_Sistema { get; set; }
        public string Duenio { get; set; }
        public string Descripcion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Ruta_Foto { get; set; }
        public Informacion_Autor(string nombre_Sistema, string duenio, string descripcion, string correo, string telefono, string ruta_Foto)
        {
            Nombre_Sistema = nombre_Sistema;
            Duenio = duenio;
            Descripcion = descripcion;
            Correo = correo;
            Telefono = telefono;
            Ruta_Foto = ruta_Foto;

        }
    } 
}
