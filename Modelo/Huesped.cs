using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Huesped
    {
        //PROPIEDADES
        public int Id_Huesped { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Nacionalidad { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        //CONSTRUCTOR
        public Huesped()
        {
            Id_Huesped = 0;
            Cedula = "";
            Nombres = "";
            Nacionalidad = "";
            Correo = "";
            Celular = "";


        }
    }
}
