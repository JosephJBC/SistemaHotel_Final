using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Servicio
    {
        //PROPIEDADES
        public long Id_Servicio {get; set; }
        public string Tipo_Servicio { get; set; }
        public double Precio { get; set; }
        //CONSTRUCTOR
        public Servicio()
        {
            Id_Servicio = 0;
            Tipo_Servicio = "";
            Precio = 0.0;
        }
    }
}
