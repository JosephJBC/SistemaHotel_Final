using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class DatosReserva 
    {
        SqlCommand cmd = null;
        public List<Reserva> ConsultarReserva(SqlConnection cn)
        {
            List<Reserva> lista = new List<Reserva>();
            Reserva reserva = null;
            String comando = @"SELECT 
                r.Id_Reserva, r.Fecha_Llegada, r.Fecha_Salida, r.Fecha_De_Reserva,
                r.Cantidad_Adulto, r.Cantidad_Ninios, r.Sub_Total, r.Iva, r.Total,
                r.Id_Huesped, r.Id_Habitacion, r.Id_Servicio,
                h.Cedula, h.Nombres, h.Nacionalidad, h.Correo, h.Telefono,
                hab.Num_Habitacion, hab.Num_Piso, hab.Tipo_Habitacion, 
                hab.Cant_Camas, hab.Cant_Baños, hab.Precio,
                s.Nombre_Servicio, s.Precio AS Precio
                FROM Reserva r
                LEFT JOIN Huesped h ON r.Id_Huesped = h.Id_Huesped
                LEFT JOIN Habitacion hab ON r.Id_Habitacion = hab.Id_Habitacion
                LEFT JOIN Servicio s ON r.Id_Servicio = s.Id_Servicio
                WHERE r.Estado = 'A'"; 
            // se intento implementar el "SELECT * FROM reserva WHERE estado= 'A' pero no recogia todo la informacion en la tabla del formulario
            // y tube que implementar un join" 
            cmd = new SqlCommand();
            SqlDataReader tablaVirtual = null;
            try
            {
                cmd.Connection = cn;
                cmd.CommandText = comando;
                tablaVirtual = cmd.ExecuteReader();
                while(tablaVirtual.Read()){ 
                    reserva = new Reserva(DateTime.Now, DateTime.Now, DateTime.Now, 0, 0);
                    reserva.IdReserva = Convert.ToInt32(tablaVirtual["Id_Reserva"]);
                    reserva.Fecha_Llegada = Convert.ToDateTime(tablaVirtual["Fecha_Llegada"]);
                    reserva.Fecha_Salida = Convert.ToDateTime(tablaVirtual["Fecha_Salida"]);
                    reserva.Fecha_De_Reserva = Convert.ToDateTime(tablaVirtual["Fecha_De_Reserva"]);
                    reserva.Cantidad_Adulto = Convert.ToInt32(tablaVirtual["Cantidad_Adulto"]);
                    reserva.Cantidad_Ninios = Convert.ToInt32(tablaVirtual["Cantidad_Ninios"]);
                    reserva.Sub_Total = Convert.ToDouble(tablaVirtual["Sub_Total"]);
                    reserva.Iva = Convert.ToDouble(tablaVirtual["Iva"]);
                    reserva.Total = Convert.ToDouble(tablaVirtual["Total"]);
                    reserva.Huesped = new Huesped
                    {
                        Id_Huesped = Convert.ToInt64(tablaVirtual["Id_Huesped"]),
                        Cedula = tablaVirtual["Cedula"].ToString(),
                        Nombres = tablaVirtual["Nombres"].ToString(),
                        Nacionalidad = tablaVirtual["Nacionalidad"].ToString(),
                        Correo = tablaVirtual["Correo"].ToString(),
                        Celular = tablaVirtual["Telefono"].ToString()
                    };
                    reserva.Habitacion = new Habitacion 
                    {
                        Id_Habitacion = Convert.ToInt64(tablaVirtual["Id_Habitacion"]),
                        Num_Habitacion = tablaVirtual["Num_Habitacion"].ToString(),
                        Num_Piso = Convert.ToInt32(tablaVirtual["Num_Piso"]),
                        Tipo_Habitacion = tablaVirtual["Tipo_Habitacion"].ToString(),
                        Cant_Camas = Convert.ToInt32(tablaVirtual["Cant_Camas"]),
                        Cant_Baños = Convert.ToInt32(tablaVirtual["Cant_Baños"]),
                        Precio = Convert.ToDouble(tablaVirtual["Precio"])
                    };
                    if (tablaVirtual["Id_Servicio"] != DBNull.Value)
                    {
                        Servicio servicio = new Servicio
                        {
                            Id_Servicio = Convert.ToInt64(tablaVirtual["Id_Servicio"]),
                            Tipo_Servicio = tablaVirtual["Nombre_Servicio"].ToString(),
                            Precio = Convert.ToDouble(tablaVirtual["Precio"])
                        };

                        Detalle_De_Reserva detalle = new Detalle_De_Reserva
                        {
                            Servicio = servicio,
                            Descripcion = servicio.Tipo_Servicio,
                            Precio_Unitario = servicio.Precio,
                            Cantidad = 1
                        };
                        detalle.Calcular_Importe();

                        reserva.detalles_Reserva.Add(detalle);
                    }
                    lista.Add(reserva);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (tablaVirtual != null && !tablaVirtual.IsClosed)
                {
                    tablaVirtual.Close();
                }
            }
            return lista;
        }

        public string RegistrarReserva(Reserva nuevaReserva, SqlConnection cn)
        {
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
                cmd.Parameters.AddWithValue("@Estado", 'A');

                object idHuesped = cmd.ExecuteScalar();

                if (idHuesped == null)
                {
                    return "0:Error al insertar huesped";
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
                cmd.Parameters.AddWithValue("@Estado", 'A');
                cmd.Parameters.AddWithValue("@Id_Huesped", Convert.ToInt32(idHuesped));
                cmd.Parameters.AddWithValue("@Id_Habitacion", nuevaReserva.Habitacion.Id_Habitacion);

                // INSERTAR EL ID DEL SERVICIO SOLO SI EXISTE
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
                    msj = "1:Reserva registrada exitosamente";
                }
                else
                {
                    msj = "0:No se pudo registrar la reserva";
                }
            }
            catch (Exception ex)
            {
                msj = "0:Error: " + ex.Message;
            }

            return msj;
        }
    }
}

