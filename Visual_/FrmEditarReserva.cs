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

namespace Visual_
{
    public partial class FrmEditarReserva : Form
    {
        Adm_Reserva admRes = new Adm_Reserva();
        private string ciOriginal = ""; // Para guardar el CI original antes de editar
        private bool modoEdicion = false;

        public FrmEditarReserva()
        {
            InitializeComponent();
            DeshabilitarControles();
        }

        private void FrmRegistrarReserva_Load(object sender, EventArgs e)
        {
            // Configurar los RadioButtons
            radioButton1.Checked = true; // Por defecto buscar por nombre

            // Configurar las fechas
            dtpLlegada.MinDate = DateTime.Today;
            dtpSalida.MinDate = DateTime.Today.AddDays(1);
        }

        // Botón Buscar
        private void button1_Click(object sender, EventArgs e)
        {
            dgvReserva.Rows.Clear();

            if (radioButton1.Checked) // Buscar por Nombre
            {
                string nombre = txtNombre.Text.Trim();
                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("Ingrese un nombre para buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Usar el método del controlador para llenar la tabla con resultados filtrados
                admRes.LlenarTablaPorNombre(dgvReserva, nombre);

                if (dgvReserva.Rows.Count > 0)
                {
                    MessageBox.Show($"Se encontraron {dgvReserva.Rows.Count} reserva(s)", "Búsqueda exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontraron reservas con ese nombre", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (radioButton2.Checked) // Buscar por CI
            {
                string ci = txtCi.Text.Trim();
                if (string.IsNullOrEmpty(ci))
                {
                    MessageBox.Show("Ingrese un CI para buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Usar el método del controlador para llenar la tabla con resultados filtrados
                admRes.LlenarTablaPorCI(dgvReserva, ci);

                if (dgvReserva.Rows.Count > 0)
                {
                    MessageBox.Show($"Se encontraron {dgvReserva.Rows.Count} reserva(s)", "Búsqueda exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontraron reservas con ese CI", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un criterio de búsqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Botón Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvReserva.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva de la tabla para editar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener la fila seleccionada
            DataGridViewRow filaSeleccionada = dgvReserva.SelectedRows[0];
            string ci = filaSeleccionada.Cells["colCi"].Value.ToString();

            // Guardar el CI original
            ciOriginal = ci;

            // Cargar los datos desde la tabla (no desde el modelo directamente)
            textBox2.Text = filaSeleccionada.Cells["colNombres"].Value.ToString();
            textBox1.Text = filaSeleccionada.Cells["colCi"].Value.ToString();
            txtTelefono.Text = filaSeleccionada.Cells["colTelefono"].Value.ToString();
            txtCorreo.Text = filaSeleccionada.Cells["colCorreo"].Value.ToString();
            txtNacionalidad.Text = filaSeleccionada.Cells["colNacionalidad"].Value.ToString();

            // Fechas
            DateTime.TryParse(filaSeleccionada.Cells["colLlegada"].Value.ToString(), out DateTime fechaLlegada);
            DateTime.TryParse(filaSeleccionada.Cells["colSalida"].Value.ToString(), out DateTime fechaSalida);
            dtpLlegada.Value = fechaLlegada;
            dtpSalida.Value = fechaSalida;

            // Cantidades
            numAdultos.Value = Convert.ToInt32(filaSeleccionada.Cells["colAdultos"].Value);
            numNinos.Value = Convert.ToInt32(filaSeleccionada.Cells["colNinos"].Value);

            // Habilitar controles para edición
            HabilitarControles();
            modoEdicion = true;

            MessageBox.Show("Puede modificar los datos de la reserva y presionar CONFIRMAR para guardar los cambios", "Modo Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Botón Confirmar
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!modoEdicion)
            {
                MessageBox.Show("Primero debe seleccionar una reserva y presionar el botón EDITAR", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener los datos de los controles
            string nombres = textBox2.Text.Trim();
            string ci = textBox1.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string nacionalidad = txtNacionalidad.Text.Trim();
            DateTime fechaLlegada = dtpLlegada.Value;
            DateTime fechaSalida = dtpSalida.Value;
            int adultos = (int)numAdultos.Value;
            int ninos = (int)numNinos.Value;

            // Validar datos usando el controlador
            if (!admRes.ValidadDatos(nombres, ci, telefono, correo, nacionalidad))
            {
                return;
            }

            // Validar fechas
            if (fechaSalida <= fechaLlegada)
            {
                MessageBox.Show("La fecha de salida debe ser posterior a la fecha de llegada", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Actualizar la reserva usando el controlador
            bool exito = admRes.ActualizarReserva(ciOriginal, nombres, ci, telefono, correo, nacionalidad, fechaLlegada, fechaSalida, adultos, ninos);

            if (exito)
            {
                MessageBox.Show("La reserva se actualizó correctamente", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar y deshabilitar controles
                LimpiarControles();
                DeshabilitarControles();
                modoEdicion = false;
                ciOriginal = "";

                // Limpiar la tabla
                dgvReserva.Rows.Clear();
            }
        }

        private void HabilitarControles()
        {
            grpReserva.Enabled = true;
            textBox2.ReadOnly = false;
            textBox1.ReadOnly = false;
            txtTelefono.ReadOnly = false;
            txtCorreo.ReadOnly = false;
            txtNacionalidad.ReadOnly = false;
            dtpLlegada.Enabled = true;
            dtpSalida.Enabled = true;
            numAdultos.ReadOnly = false;
            numNinos.ReadOnly = false;
        }

        private void DeshabilitarControles()
        {
            grpReserva.Enabled = false;
            textBox2.ReadOnly = true;
            textBox1.ReadOnly = true;
            txtTelefono.ReadOnly = true;
            txtCorreo.ReadOnly = true;
            txtNacionalidad.ReadOnly = true;
            dtpLlegada.Enabled = false;
            dtpSalida.Enabled = false;
            numAdultos.ReadOnly = true;
            numNinos.ReadOnly = true;
        }

        private void LimpiarControles()
        {
            textBox2.Clear();
            textBox1.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtNacionalidad.Clear();
            numAdultos.Value = 1;
            numNinos.Value = 0;
            dtpLlegada.Value = DateTime.Today;
            dtpSalida.Value = DateTime.Today.AddDays(1);
        }
    }
}
