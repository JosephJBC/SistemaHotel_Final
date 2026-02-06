using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Detalle_De_Reserva
    {
        //PROPIEDADES
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double Precio_Unitario { get; set; }  
        public double Importe { get; set; }
        public Servicio Servicio { get; set; }
        //cONSTRUCCTOR
        public Detalle_De_Reserva()
        {
            Cantidad = 0;
            Precio_Unitario = 0;
            Importe = 0;
            Descripcion = "";
        }

        public double Calcular_Importe() 
        {
            Importe = Cantidad * Precio_Unitario;
            return Importe;
        }
    }
}
