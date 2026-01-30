using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class InformacionAutor
    {
        public string Nombre_Sistema { get; set; }
        public string Duenio { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Ruta_Foto { get; set; }
        public InformacionAutor(string nombre_Sistema, string duenio, string direccion, string correo, string telefono, string ruta_Foto)
        {
            Nombre_Sistema = nombre_Sistema;
            Duenio = duenio;
            Direccion = direccion;
            Correo = correo;
            Telefono = telefono;
            Ruta_Foto = ruta_Foto;

        }
    } 
}
