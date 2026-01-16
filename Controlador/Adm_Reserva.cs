using Modelo;
using System;
using Datos;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Controlador
{
    public class Adm_Reserva
    {
        static List<Reserva> reservas = new List<Reserva>();
        List<Habitacion> listaHabitaciones = new List<Habitacion>();
        public object llenarTablar;
        conexion con = null;
        public int GetcantidadLista()
        {
            return reservas.Count;
        }

        public bool ValidadDatos(string nombres, string ci, string telefono, string correo, string nacionalidad)
        {
            if (string.IsNullOrEmpty(nombres) || string.IsNullOrEmpty(ci) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(correo)
                || string.IsNullOrEmpty(nacionalidad))
            {
                MessageBox.Show("ERROR: Se necesitan todos los campos llenos");
                return false; 
            }
            else 
            {
                if (!EsCorreo(correo))
                {
                    MessageBox.Show("El correo no tiene un formato correcto");
                    return false; 
                }
            }
            return true;
        }

        private bool EsCorreo(string correo)
        {
            bool bandera = true;

            for (int i = 0; i < correo.Length && bandera; i++)
            {
                if (!char.IsLetterOrDigit(correo[i]) && correo[i] != '@' && correo[i] != '.')
                {
                    bandera = false;
                }
            }
            if (bandera && !correo.ToLower().Contains("@gmail."))
            {
                bandera = false;
            }
            return bandera;
        }

        public string Registrar(string nombres, string ci, string telefono, string correo, string nacionalidad, DateTime fechaReserva, DateTime fechaLlegada, 
            DateTime fechaSalida, decimal adultos, decimal ninos, double precioHabitacion, double precioServicio, int indexHabitacion, int indexServicio)
        {
            Huesped huesped = new Huesped
            {
                Nombres = nombres,
                Cedula = ci,
                Celular = telefono,
                Correo = correo,
                Nacionalidad = nacionalidad
            };
            //Crear la Reserva
            Reserva nuevaReserva = new Reserva(fechaLlegada, fechaSalida, fechaReserva, (int)adultos, (int)ninos);
            nuevaReserva.Huesped = huesped;
            if (listaHabitaciones.Count == 0) llenarHabitacion();
            if (indexHabitacion >= 0 && indexHabitacion < listaHabitaciones.Count)
            {
                nuevaReserva.Habitacion = listaHabitaciones[indexHabitacion];
            }
            Adm_Detalle_De_Reserva admDetalles = new Adm_Detalle_De_Reserva();
            Servicio servicioEncontrado = admDetalles.ObtenerServicio(indexServicio);

            if (servicioEncontrado != null)
            {
                Detalle_De_Reserva detalle = new Detalle_De_Reserva();
                detalle.Servicio = servicioEncontrado;
                detalle.Descripcion = servicioEncontrado.Tipo_Servicio;
                detalle.Precio_Unitario = servicioEncontrado.Precio;
                detalle.Cantidad = 1;
                detalle.Calcular_Importe();

                nuevaReserva.detalles_Reserva.Add(detalle);
            }
            nuevaReserva.Calcular_Totales();
            //Guardar en la lista
            reservas.Add(nuevaReserva);
            return nuevaReserva.ToString();
        }

        public void LlenarComboHabitacion(System.Windows.Forms.ComboBox cmbHabitacion)
        {
            cmbHabitacion.Items.Clear();
            llenarHabitacion();
            foreach (Habitacion habitacion in listaHabitaciones)
            {
                cmbHabitacion.Items.Add("Numero de Habitacion :" +habitacion.Num_Habitacion+ ", Tipo de habitacion: "+habitacion.Tipo_Habitacion +", Precio: "+ 
                    habitacion.Precio);
            }
        }
        private void llenarHabitacion()
        {
            listaHabitaciones.Clear();
            listaHabitaciones.Add(new Habitacion
            {
                Id_Habitacion = 1234567890,
                Num_Habitacion = "101",
                Num_Piso = 1,
                Tipo_Habitacion = "Matrimonial",
                Cant_Camas = 1,
                Cant_Baños = 1,
                Precio = 50
            });
            listaHabitaciones.Add(new Habitacion
            {
                Id_Habitacion = 1234567891,
                Num_Habitacion = "102",
                Num_Piso = 1,
                Tipo_Habitacion = "Simple",
                Cant_Camas = 1,
                Cant_Baños = 1,
                Precio = 35
            });
            listaHabitaciones.Add(new Habitacion
            {
                Id_Habitacion = 1234567892,
                Num_Habitacion = "201",
                Num_Piso = 2,
                Tipo_Habitacion = "Doble",
                Cant_Camas = 2,
                Cant_Baños = 1,
                Precio = 65
            });
            listaHabitaciones.Add(new Habitacion
            {
                Id_Habitacion = 1234567893,
                Num_Habitacion = "202",
                Num_Piso = 2,
                Tipo_Habitacion = "Suite",
                Cant_Camas = 2,
                Cant_Baños = 2,
                Precio = 100
            });
            listaHabitaciones.Add(new Habitacion
            {
                Id_Habitacion = 1234567894,
                Num_Habitacion = "301",
                Num_Piso = 3,
                Tipo_Habitacion = "Familiar",
                Cant_Camas = 3,
                Cant_Baños = 2,
                Precio = 120
            });
        }
        public double ObtenerPrecioHabitacion(int indice)
        {
            if (indice >= 0 && indice < listaHabitaciones.Count)
            {
                return listaHabitaciones[indice].Precio;
            }
            return 0; 
        }

        public void LlenarTabla(DataGridView dgvReserva)
        {
            dgvReserva.Rows.Clear();
            int indice = 0;
            if (reservas.Count > 0)
            {
                foreach (Reserva r in reservas) 
                {
                    indice = dgvReserva.Rows.Add();
                    dgvReserva.Rows[indice].Cells["colNro"].Value = indice+1;
                    dgvReserva.Rows[indice].Cells["colNombres"].Value = r.Huesped.Nombres;
                    dgvReserva.Rows[indice].Cells["colCi"].Value = r.Huesped.Cedula;
                    dgvReserva.Rows[indice].Cells["colTelefono"].Value = r.Huesped.Celular;
                    dgvReserva.Rows[indice].Cells["colCorreo"].Value = r.Huesped.Correo;
                    dgvReserva.Rows[indice].Cells["colNacionalidad"].Value = r.Huesped.Nacionalidad;
                    //DATOS DE LA HABITACIÓN
                    if (r.Habitacion != null)
                    {
                        dgvReserva.Rows[indice].Cells["colHabitacion"].Value = r.Habitacion.Num_Habitacion + " (" + r.Habitacion.Tipo_Habitacion + ")";
                    }
                    else
                    {
                        dgvReserva.Rows[indice].Cells["colHabitacion"].Value = "Sin asignar";
                    }
                    //FECHAS Y CANTIDADES
                    dgvReserva.Rows[indice].Cells["colReserva"].Value = r.Fecha_De_Reserva.ToShortDateString();
                    dgvReserva.Rows[indice].Cells["colLlegada"].Value = r.Fecha_Llegada.ToShortDateString();
                    dgvReserva.Rows[indice].Cells["colSalida"].Value = r.Fecha_Salida.ToShortDateString();
                    dgvReserva.Rows[indice].Cells["colAdultos"].Value = r.Cantidad_Adulto;
                    dgvReserva.Rows[indice].Cells["colNinos"].Value = r.Cantidad_Ninios;
                    // Servicios
                    dgvReserva.Rows[indice].Cells["collServicios"].Value = "Ver detalle";
                    if (r.detalles_Reserva != null && r.detalles_Reserva.Count > 0)
                    {
                        dgvReserva.Rows[indice].Cells["collServicios"].Value = r.detalles_Reserva[0].Descripcion;
                    }
                    else
                    {
                        dgvReserva.Rows[indice].Cells["collServicios"].Value = "Ninguno";
                    }
                    //MONTOS
                    dgvReserva.Rows[indice].Cells["colSubTotal"].Value = r.Sub_Total.ToString("C2"); // C2 le pone formato de moneda ($)
                    dgvReserva.Rows[indice].Cells["ColIva"].Value = r.Iva.ToString("C2");
                    dgvReserva.Rows[indice].Cells["colTotal"].Value = r.Total.ToString("C2");
                }
            }
        }

        public void EliminarReserva(int indice, DataGridView dgvReserva)
        {
            string cedula = dgvReserva.Rows[indice].Cells["colCi"].Value.ToString();

            DialogResult result = MessageBox.Show("¿Desea eliminar la reserva?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dgvReserva.Rows.RemoveAt(indice);
                reservas.RemoveAll(r => r.Huesped.Cedula == cedula);

                MessageBox.Show("Registro eliminado. La reserva de " + cedula + " se eliminó correctamente!");
            }
        }

        public List<Reserva> BuscarReservaPorNombre(string nombre)
        {
            return reservas.Where(r => r.Huesped.Nombres.ToLower().Contains(nombre.ToLower())).ToList();
        }
        public void LlenarTablaPorNombre(DataGridView dgvReserva, string nombre)
        {
            dgvReserva.Rows.Clear();
            var resultados = BuscarReservaPorNombre(nombre);
        }
        public List<Reserva> BuscarReservaPorCI(string ci)
        {
            return reservas.Where(r => r.Huesped.Cedula.Contains(ci)).ToList();
        }
        public void LlenarTablaPorCI(DataGridView dgvReserva, string ci)
        {
            dgvReserva.Rows.Clear();
            var resultados = BuscarReservaPorCI(ci);
        }

        public bool ActualizarReserva(string ciOriginal, string nombres, string ci, string telefono, string correo,
            string nacionalidad, DateTime fechaLlegada, DateTime fechaSalida, int adultos, int ninos)
        {
            Reserva reservaExistente = reservas.FirstOrDefault(r => r.Huesped.Cedula == ciOriginal);

            if (reservaExistente == null)
            {
                MessageBox.Show("No se encontró la reserva a actualizar");
                return false;
            }

            // Actualizar datos del huésped
            reservaExistente.Huesped.Nombres = nombres;
            reservaExistente.Huesped.Cedula = ci;
            reservaExistente.Huesped.Celular = telefono;
            reservaExistente.Huesped.Correo = correo;
            reservaExistente.Huesped.Nacionalidad = nacionalidad;

            // Actualizar datos de la reserva
            reservaExistente.Fecha_Llegada = fechaLlegada;
            reservaExistente.Fecha_Salida = fechaSalida;
            reservaExistente.Cantidad_Adulto = adultos;
            reservaExistente.Cantidad_Ninios = ninos;

            // Recalcular totales
            reservaExistente.Calcular_Totales();

            return true;
        }

        public void conexion()
        {
            con = new conexion(); 
            string res = con.conectar();
            if (res[0] == '1')
            {
                MessageBox.Show("Conexión exitosa");
                con.cerrar(); 
            }
            else if (res[0] == '0')
            {
                MessageBox.Show("Error de conexión: " + res);
            }
        }
    }
}