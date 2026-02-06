using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_
{
    public partial class FrmListaReserva : Form
    {
        Adm_Reserva admRes = new Adm_Reserva();
        private Control_Pdf ctrlPdfLista = new Control_Pdf(); 
        private string rutaPdfLista = "Lista_Reservas.pdf"; 
        public FrmListaReserva()
        {
            InitializeComponent();
            admRes.LlenarComboTiposHabitacion(cmbHabitacion);
            admRes.LlenarTabla(dgvReserva);
        }

        private void btnNacionalidad_Click(object sender, EventArgs e)
        {
            string nacionalidad = txtNacionalidad.Text.Trim();

            if (string.IsNullOrEmpty(nacionalidad))
            {
                MessageBox.Show("Ingrese una nacionalidad para buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int resultados = admRes.FiltrarPorNacionalidad(nacionalidad, dgvReserva);

            if (resultados == 0)
            {
                MessageBox.Show("No se encontraron reservas con esa nacionalidad", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Se encontro " + resultados + " reserva(s)", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHabitacion_Click(object sender, EventArgs e)
        {
            if (cmbHabitacion.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un tipo de habitacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tipoSeleccionado = cmbHabitacion.SelectedItem.ToString();
            int resultados = admRes.FiltrarPorTipoHabitacion(tipoSeleccionado, dgvReserva);

            if (resultados == 0)
            {
                MessageBox.Show("No se encontraron reservas con ese tipo de habitacion", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Se encontraron " + resultados + " reserva(s)", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGenerarPdf_Click(object sender, EventArgs e)
        {
            if (dgvReserva.Rows.Count == 0)
            {
                MessageBox.Show("No hay reservas para imprimir", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ctrlPdfLista.GenerarPDFDesdeGrid(rutaPdfLista, dgvReserva);

                MessageBox.Show("PDF generado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = rutaPdfLista;
                psi.UseShellExecute = true;
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
