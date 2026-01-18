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
        DatosReserva datosR = null;   
        public int GetcantidadLista()
        {
            return reservas.Count;
        }

        public bool ValidadDatos(string nombres, string ci, string telefono, string correo, string nacionalidad)
        {
            if (string.IsNullOrEmpty(nombres) || string.IsNullOrEmpty(ci) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(correo)
                || string.IsNullOrEmpty(nacionalidad))
            {
                MessageBox.Show("ERROR: Se necesitan todos los campos llenos", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
            else 
            {
                if (!EsCorreo(correo))
                {
                    MessageBox.Show("El correo no tiene un formato correcto", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            RegistarReseraBDD(nuevaReserva);
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
        // METODO PARA LLENAR TABLA Y TAMBIEN EDITAR Y BUSCAR
        private void LlenarFilaReserva(DataGridView dgvReserva, Reserva r, int numeroFila)
        {
            int indice = dgvReserva.Rows.Add();
            dgvReserva.Rows[indice].Cells["colNro"].Value = numeroFila;
            dgvReserva.Rows[indice].Cells["colNombres"].Value = r.Huesped.Nombres;
            dgvReserva.Rows[indice].Cells["colCi"].Value = r.Huesped.Cedula;
            dgvReserva.Rows[indice].Cells["colTelefono"].Value = r.Huesped.Celular;
            dgvReserva.Rows[indice].Cells["colCorreo"].Value = r.Huesped.Correo;
            dgvReserva.Rows[indice].Cells["colNacionalidad"].Value = r.Huesped.Nacionalidad;

            if (r.Habitacion != null)
            {
                dgvReserva.Rows[indice].Cells["colHabitacion"].Value = r.Habitacion.Num_Habitacion + " (" + r.Habitacion.Tipo_Habitacion + ")";
            }
            else
            {
                dgvReserva.Rows[indice].Cells["colHabitacion"].Value = "Sin asignar";
            }

            dgvReserva.Rows[indice].Cells["colReserva"].Value = r.Fecha_De_Reserva.ToShortDateString();
            dgvReserva.Rows[indice].Cells["colLlegada"].Value = r.Fecha_Llegada.ToShortDateString();
            dgvReserva.Rows[indice].Cells["colSalida"].Value = r.Fecha_Salida.ToShortDateString();
            dgvReserva.Rows[indice].Cells["colAdultos"].Value = r.Cantidad_Adulto;
            dgvReserva.Rows[indice].Cells["colNinos"].Value = r.Cantidad_Ninios;

            if (r.detalles_Reserva != null && r.detalles_Reserva.Count > 0)
            {
                dgvReserva.Rows[indice].Cells["collServicios"].Value = r.detalles_Reserva[0].Descripcion;
            }
            else
            {
                dgvReserva.Rows[indice].Cells["collServicios"].Value = "Ninguno";
            }

            dgvReserva.Rows[indice].Cells["colSubTotal"].Value = r.Sub_Total.ToString("C2");
            dgvReserva.Rows[indice].Cells["ColIva"].Value = r.Iva.ToString("C2");
            dgvReserva.Rows[indice].Cells["colTotal"].Value = r.Total.ToString("C2");
        }

        //LLENAR TABLA 
        public void LlenarTabla(DataGridView dgvReserva)
        {
            dgvReserva.Rows.Clear();
            int numeroFila = 0;
            if (reservas.Count > 0)
            {
                foreach (Reserva r in reservas)
                {
                    numeroFila++;
                    LlenarFilaReserva(dgvReserva, r, numeroFila);
                }
            }
        }
        //
        public void LlenarComboTiposHabitacion(ComboBox cmbHabitacion)
        {
            cmbHabitacion.Items.Clear();
            cmbHabitacion.Items.Add("Todos");
            cmbHabitacion.Items.Add("Matrimonial");
            cmbHabitacion.Items.Add("Simple");
            cmbHabitacion.Items.Add("Doble");
            cmbHabitacion.Items.Add("Suite");
            cmbHabitacion.Items.Add("Familiar");
            cmbHabitacion.SelectedIndex = 0;
        }
        // Filtrar por tipo de habitación
        public int FiltrarPorTipoHabitacion(string tipoHabitacion, DataGridView dgvReserva)
        {
            dgvReserva.Rows.Clear();
            int numeroFila = 1;

            foreach (Reserva r in reservas)
            {
                if (tipoHabitacion == "Todos" ||
                    (r.Habitacion != null && r.Habitacion.Tipo_Habitacion == tipoHabitacion))
                {
                    LlenarFilaReserva(dgvReserva, r, numeroFila);
                    numeroFila++;
                }
            }
            return numeroFila - 1; // Retorna cantidad de resultados
        }

        // Filtrar por nacionalidad
        public int FiltrarPorNacionalidad(string nacionalidad, DataGridView dgvReserva)
        {
            dgvReserva.Rows.Clear();
            int numeroFila = 1;

            foreach (Reserva r in reservas)
            {
                if (r.Huesped != null &&
                    r.Huesped.Nacionalidad.ToLower().Contains(nacionalidad.ToLower()))
                {
                    LlenarFilaReserva(dgvReserva, r, numeroFila);
                    numeroFila++;
                }
            }
            return numeroFila - 1;
        }

        public void EliminarReserva(int indice, DataGridView dgvReserva)
        {
            string cedula = dgvReserva.Rows[indice].Cells["colCi"].Value.ToString();

            DialogResult result = MessageBox.Show("¿Desea eliminar la reserva?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dgvReserva.Rows.RemoveAt(indice);
                reservas.RemoveAll(r => r.Huesped.Cedula == cedula);

                MessageBox.Show("Registro eliminado. La reserva de " + cedula + " se elimino correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //METODO PARA BUSCAR POR NOMBRO EN EDITAR RESERVA
        public int BuscarPorNombre(string nombre, DataGridView dgvReserva)
        {
            dgvReserva.Rows.Clear();
            int contador = 0;

            foreach (Reserva r in reservas)
            {
                if (r.Huesped != null && r.Huesped.Nombres.ToLower().Contains(nombre.ToLower()))
                {
                    contador++;
                    LlenarFilaReserva(dgvReserva, r, contador);
                }
            }
            return contador;
        }

        //METODO PARA BUSCAR POR CEDULA EN EDITAR RESERVA
        public bool BuscarPorCedula(string cedula, DataGridView dgvReserva)
        {
            dgvReserva.Rows.Clear();

            foreach (Reserva r in reservas)
            {
                if (r.Huesped != null && r.Huesped.Cedula == cedula)
                {
                    LlenarFilaReserva(dgvReserva, r, 1);
                    return true;
                }
            }
            return false;
        }

        //
        public bool CargarDatosReserva(string cedula, TextBox txtNombres, TextBox txtCi, TextBox txtTelefono,
            TextBox txtCorreo, TextBox txtNacionalidad, DateTimePicker dtpLlegada, DateTimePicker dtpSalida,
            NumericUpDown numAdultos, NumericUpDown numNinos)
        {
            foreach (Reserva r in reservas)
            {
                if (r.Huesped != null && r.Huesped.Cedula == cedula)
                {
                    txtNombres.Text = r.Huesped.Nombres;
                    txtCi.Text = r.Huesped.Cedula;
                    txtTelefono.Text = r.Huesped.Celular;
                    txtCorreo.Text = r.Huesped.Correo;
                    txtNacionalidad.Text = r.Huesped.Nacionalidad;

                    dtpLlegada.Value = r.Fecha_Llegada;
                    dtpSalida.Value = r.Fecha_Salida;

                    numAdultos.Value = r.Cantidad_Adulto;
                    numNinos.Value = r.Cantidad_Ninios;

                    return true;
                }
            }
            return false;
        }

        //
        public bool ActualizarReserva(string cedulaOriginal, string nombres, string ci, string telefono,
            string correo, string nacionalidad, DateTime fechaLlegada, DateTime fechaSalida,
            int adultos, int ninos)
        {
            Reserva reservaExistente = null;
            foreach (Reserva r in reservas)
            {
                if (r.Huesped != null && r.Huesped.Cedula == cedulaOriginal)
                {
                    reservaExistente = r;
                    break;
                }
            }

            if (reservaExistente == null)
            {
                MessageBox.Show("No se encontro la reserva a actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            reservaExistente.Huesped.Nombres = nombres;
            reservaExistente.Huesped.Cedula = ci;
            reservaExistente.Huesped.Celular = telefono;
            reservaExistente.Huesped.Correo = correo;
            reservaExistente.Huesped.Nacionalidad = nacionalidad;

            reservaExistente.Fecha_Llegada = fechaLlegada;
            reservaExistente.Fecha_Salida = fechaSalida;
            reservaExistente.Cantidad_Adulto = adultos;
            reservaExistente.Cantidad_Ninios = ninos;

            reservaExistente.Calcular_Totales();

            return true;
        }

        public void conexion()
        {
            con = new conexion(); 
            string res = con.conectar();
            if (res[0] == '1')
            {
                MessageBox.Show("Conexion exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.cerrar(); 
            }
            else if (res[0] == '0')
            {
                MessageBox.Show("Error de conexion: " + res, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistarReseraBDD(Reserva nuevaReserva)
        {
            con = new conexion();
            string res = con.conectar();
            datosR = new DatosReserva();
            string resp = "";
            if (res[0] == '1')
            {
                resp = datosR.RegistrarReserva(nuevaReserva, con.Cn);
                if(resp[0] == '1')
                {
                    MessageBox.Show("Reserva registrada en la base de datos", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al registrar la reserva en la base de datos: " + resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.cerrar();
            }
            else if (res[0] == '0')
            {
                MessageBox.Show("Error de conexion: " + res, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}