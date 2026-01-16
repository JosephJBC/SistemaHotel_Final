using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Visual_
{
    public partial class frmReserv : Form
    {
        Adm_Reserva admReserva = new Adm_Reserva();
        Adm_Detalle_De_Reserva adm_Detalle_De_Reserva = new Adm_Detalle_De_Reserva();
        double precioHabitacionActual = 0;
        double precioServicioActual = 0;
        public frmReserv()
        {
            InitializeComponent();
            admReserva.LlenarComboHabitacion(cmbHabitacion);
            adm_Detalle_De_Reserva.LlenarComboServicio(cmbServicios);

            dtpLlegada.MinDate = DateTime.Today;
            dtpSalida.MinDate = dtpLlegada.Value.AddDays(1);
            if (cmbHabitacion.Items.Count > 0) cmbHabitacion.SelectedIndex = 0;
            if (cmbServicios.Items.Count > 0) cmbServicios.SelectedIndex = 0;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nombres = txtNombre.Text.Trim(), ci = txtCi.Text.Trim(), telefono = txtTelefono.Text.Trim(), correo = txtCorreo.Text.Trim(),
                nacionalidad = txtNacionalidad.Text.Trim();
            if (cmbHabitacion.SelectedItem == null || cmbServicios.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una habitacion y un servicio.");
                return;
            }
            string Habitaciones = cmbHabitacion.SelectedItem.ToString(), Servicios = cmbServicios.SelectedItem.ToString();
            DateTime fechaLlegada = dtpLlegada.Value, fechaSalida = dtpSalida.Value;
            int adultos = (int)numAdultos.Value, ninos = (int)numNinos.Value;

            if (admReserva.ValidadDatos(nombres, ci, telefono, correo, nacionalidad))
            {
                //Calcular precios antes de registrar
                ActualizarTotalesVisuales();
                int indexHab = cmbHabitacion.SelectedIndex;
                int indexServ = cmbServicios.SelectedIndex;
                //Registrar
                string recibo = admReserva.Registrar(nombres, ci, telefono, correo, nacionalidad, DateTime.Now, 
                    fechaLlegada, fechaSalida, adultos, ninos, precioHabitacionActual, 
                    precioServicioActual, indexHab, indexServ); 
                txtContenido.Text = recibo;
                MessageBox.Show("Reserva realizada con exito");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            // Si no es letra, no es espacio y no es tecla de control borrar se bloquea.
            if (!char.IsLetter(c) && c != ' ' && !char.IsControl(c))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCi_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            // Si no es dígito y no es borrar se bloquea.
            if (!char.IsDigit(c) && !char.IsControl(c))
            {
                e.Handled = true;
                return;
            }
        }

        private void dtpLlegada_ValueChanged(object sender, EventArgs e)
        {
            dtpSalida.MinDate = dtpLlegada.Value.AddDays(1);
            if (dtpSalida.Value.Date <= dtpLlegada.Value.Date)
            {
                dtpSalida.Value = dtpLlegada.Value.AddDays(1);
            }
            ActualizarTotalesVisuales();
        }

        private void dtpSalida_ValueChanged(object sender, EventArgs e)
        {
            ActualizarTotalesVisuales();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTotalesVisuales();
        }

        private void cmbServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTotalesVisuales();
        }
        private void ActualizarTotalesVisuales()
        {
            int indexHab = cmbHabitacion.SelectedIndex;
            int indexServ = cmbServicios.SelectedIndex;
            // Calcular Días
            TimeSpan diferencia = dtpSalida.Value.Date - dtpLlegada.Value.Date;
            int dias = diferencia.Days;
            if (dias < 1) dias = 1;

            // Obtener precios de habitacion y servios
            precioHabitacionActual = admReserva.ObtenerPrecioHabitacion(indexHab);
            precioServicioActual = adm_Detalle_De_Reserva.ObtenerPrecioServicioPorIndice(indexServ);

            // Calcular subtotal,iva y total
            double subTotal = (precioHabitacionActual * dias) + precioServicioActual;
            double iva = subTotal * 0.12;
            double total = subTotal + iva;
        }
    }
}
