using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Modelo
{
    public class Habitacion
    {
        //PROPIEDADES
        public int Id_Habitacion { get; set; }
        public string Num_Habitacion { get; set; }
        public int Num_Piso { get; set; }
        public string Tipo_Habitacion { get; set; }
        public int Cant_Camas { get; set; }
        public int Cant_Baños { get; set; }
        public double Precio { get; set; }
        //CONSTRUCTOR
        public Habitacion()
        {
            Id_Habitacion = 0;
            Num_Habitacion = "";
            Num_Piso = 0;
            Tipo_Habitacion = "";
            Cant_Camas = 0;
            Cant_Baños = 0;
            Precio = 0.0;

        }
    }
}
