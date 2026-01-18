using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosReserva
    {
        public string RegistrarReserva(Reserva nuevaReserva, SqlConnection cn)
        {
            SqlCommand cmd = null;
            string msj = "";
            string comando = "INSERT INTO Reserva (Fecha_Llegada, Fecha_Salida, Fecha_De_Reserva, Cantidad_Adulto, Cantidad_Ninios, Sub_Total, Iva, Total, Id_Huesped, Id_Habitacion) " +
                             "VALUES (@Fecha_Llegada, @Fecha_Salida, @Fecha_De_Reserva, @Cantidad_Adulto, @Cantidad_Ninios, @Sub_Total, @Iva, @Total, @Id_Huesped, @Id_Habitacion)";
            cmd = new SqlCommand(comando, cn);
            cmd.Parameters.AddWithValue("@Fecha_Llegada", nuevaReserva.Fecha_Llegada);
            cmd.Parameters.AddWithValue("@Fecha_Salida", nuevaReserva.Fecha_Salida);
            cmd.Parameters.AddWithValue("@Fecha_De_Reserva", nuevaReserva.Fecha_De_Reserva);
            cmd.Parameters.AddWithValue("@Cantidad_Adulto", nuevaReserva.Cantidad_Adulto);
            cmd.Parameters.AddWithValue("@Cantidad_Ninios", nuevaReserva.Cantidad_Ninios);
            cmd.Parameters.AddWithValue("@Sub_Total", nuevaReserva.Sub_Total);
            cmd.Parameters.AddWithValue("@Iva", nuevaReserva.Iva);
            cmd.Parameters.AddWithValue("@Total", nuevaReserva.Total);
            return msj;
        }
    }
}
