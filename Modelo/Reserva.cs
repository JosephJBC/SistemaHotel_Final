using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Modelo
{
    public class Reserva
    {
        //PROPIEDADES
        public int IdReserva { get; set; }
        public DateTime Fecha_Llegada { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public DateTime Fecha_De_Reserva { get; set; }
        public int Cantidad_Adulto { get; set; }
        public int Cantidad_Ninios { get; set; }
        public double Sub_Total { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }
        //RELACIONES
        public Huesped Huesped { get; set; }
        public Habitacion Habitacion { get; set; }
        // RELACION DE COMPOSICION CON detalle_De_Reserva
        public List<Detalle_De_Reserva> detalles_Reserva { get; set; } = new List<Detalle_De_Reserva>();
        //CONSTRUCTOR PARA INICIALIZAR LAS PROPIEDADES
        public Reserva(DateTime fecha_Llegada, DateTime fecha_Salida,
            DateTime fecha_De_Reserva, int cantidad_Adulto, int cantidad_Ninios)
        {
            Fecha_Llegada = fecha_Llegada;
            Fecha_Salida = fecha_Salida;
            Fecha_De_Reserva = fecha_De_Reserva;
            Cantidad_Adulto = cantidad_Adulto;
            Cantidad_Ninios = cantidad_Ninios;

            Sub_Total = 0;
            Iva = 0;
            Total = 0;
        }
        //METODO PARA CALCUALR EL SUB TOTAL ENTRE HABITACION Y DETALLE DE RESERVA
        public double Calcular_Sub_Total()
        {
            Sub_Total = 0;

            // 1. Calculamos los días aquí adentro
            TimeSpan diferencia = Fecha_Salida.Date - Fecha_Llegada.Date;
            int dias = diferencia.Days;
            if (dias < 1) dias = 1; // Mínimo 1 día

            if (Habitacion != null)
            {
                // 2. Multiplicamos el precio por los días
                Sub_Total += (Habitacion.Precio * dias);
            }

            for (int i = 0; i < detalles_Reserva.Count; i++)
            {
                Detalle_De_Reserva detalle = detalles_Reserva[i];
                double importe = detalle.Calcular_Importe();
                detalle.Importe = importe;
                Sub_Total += importe;
            }
            return Sub_Total;
        }
        //METODO PARA CALCULAR EL IVA
        public double Calcular_Iva()
        {
            Iva = Sub_Total * 0.12;
            return Iva;
        }
        //METODO PARA CALCULAR EL TOTAL 
        public double Calcular_Total()
        {
            Total = Sub_Total + Iva;
            return Total;
        }
        //METODO PARA LLAMAR A LOS METODOS SUB TOTAL, IVA Y CALCULAR TOTAL
        public void Calcular_Totales()
        {
            Calcular_Sub_Total();
            Calcular_Iva();
            Calcular_Total();
        }
        //METODO TOSTRING PARA MOSTRAR LAS PROPIEDADES
        public override string ToString()
        {
            string nombreCl = (Huesped != null) ? Huesped.Nombres : "Sin asignar";
            return "RECIBO DE RESERVA\r\n" +
           "\r\n" +
           "Cliente: " + nombreCl + "\r\n" +
           "Fecha de reserva:     " + Fecha_De_Reserva.ToString() + "\r\n" +
           "Entrada: " + Fecha_Llegada.ToShortDateString() + "\r\n" +
           "Salida:  " + Fecha_Salida.ToShortDateString() + "\r\n" +
           "Huéspedes: " + Cantidad_Adulto + " Adultos, " + Cantidad_Ninios + " Niños\r\n" +
           "\r\n" +
           "Subtotal:  " + Sub_Total.ToString("C2") + "\r\n" +
           "IVA (12%): " + Iva.ToString("C2") + "\r\n" +
           "TOTAL:     " + Total.ToString("C2");
        }
    }
}

