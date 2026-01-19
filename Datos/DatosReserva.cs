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

            try
            {
                // HUESPED
                string comandoHuesped = "INSERT INTO Huesped (Cedula, Nombres, Nacionalidad, Correo, Telefono, Estado) " +
                                       "VALUES (@Cedula, @Nombres, @Nacionalidad, @Correo, @Telefono, @Estado); " +
                                       "SELECT SCOPE_IDENTITY();";

                cmd = new SqlCommand(comandoHuesped, cn);
                cmd.Parameters.AddWithValue("@Cedula", nuevaReserva.Huesped.Cedula);
                cmd.Parameters.AddWithValue("@Nombres", nuevaReserva.Huesped.Nombres);
                cmd.Parameters.AddWithValue("@Nacionalidad", nuevaReserva.Huesped.Nacionalidad);
                cmd.Parameters.AddWithValue("@Correo", nuevaReserva.Huesped.Correo);
                cmd.Parameters.AddWithValue("@Telefono", nuevaReserva.Huesped.Celular);
                cmd.Parameters.AddWithValue("@Estado", nuevaReserva.Huesped.Estado);

                object idHuesped = cmd.ExecuteScalar();

                if (idHuesped == null)
                {
                    return "Error al insertar huesped";
                }

                // INSERTAR RESERVA CON EL ID DE HUESPED, HABITACION Y SERVICIO
                string comandoReserva = "INSERT INTO Reserva (Fecha_Llegada, Fecha_Salida, Fecha_De_Reserva, Cantidad_Adulto, Cantidad_Ninios, " +
                                       "Sub_Total, Iva, Total, Estado, Id_Huesped, Id_Habitacion, Id_Servicio) " +
                                       "VALUES (@Fecha_Llegada, @Fecha_Salida, @Fecha_De_Reserva, @Cantidad_Adulto, @Cantidad_Ninios, " +
                                       "@Sub_Total, @Iva, @Total, @Estado, @Id_Huesped, @Id_Habitacion, @Id_Servicio)";

                cmd = new SqlCommand(comandoReserva, cn);
                cmd.Parameters.AddWithValue("@Fecha_Llegada", nuevaReserva.Fecha_Llegada);
                cmd.Parameters.AddWithValue("@Fecha_Salida", nuevaReserva.Fecha_Salida);
                cmd.Parameters.AddWithValue("@Fecha_De_Reserva", nuevaReserva.Fecha_De_Reserva);
                cmd.Parameters.AddWithValue("@Cantidad_Adulto", nuevaReserva.Cantidad_Adulto);
                cmd.Parameters.AddWithValue("@Cantidad_Ninios", nuevaReserva.Cantidad_Ninios);
                cmd.Parameters.AddWithValue("@Sub_Total", nuevaReserva.Sub_Total);
                cmd.Parameters.AddWithValue("@Iva", nuevaReserva.Iva);
                cmd.Parameters.AddWithValue("@Total", nuevaReserva.Total);
                cmd.Parameters.AddWithValue("@Estado", nuevaReserva.Estado);
                cmd.Parameters.AddWithValue("@Id_Huesped", Convert.ToInt32(idHuesped));
                cmd.Parameters.AddWithValue("@Id_Habitacion", nuevaReserva.Habitacion.Id_Habitacion);

                // Insertar Id_Servicio si existe un servicio válido
                if (nuevaReserva.detalles_Reserva != null && nuevaReserva.detalles_Reserva.Count > 0
                    && nuevaReserva.detalles_Reserva[0].Servicio.Id_Servicio > 0)
                {
                    cmd.Parameters.AddWithValue("@Id_Servicio", nuevaReserva.detalles_Reserva[0].Servicio.Id_Servicio);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Id_Servicio", DBNull.Value);
                }

                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    msj = "Reserva registrada exitosamente";
                }
                else
                {
                    msj = "No se pudo registrar la reserva";
                }
            }
            catch (Exception ex)
            {
                msj = "Error: " + ex.Message;
            }

            return msj;
        }
    }
}

