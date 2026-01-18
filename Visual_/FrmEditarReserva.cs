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
        Adm_Reserva admReserva = new Adm_Reserva();
        string cedulaOriginal = "";
        bool modoEdicion = false;

        public FrmEditarReserva()
        {
            InitializeComponent();

            HabilitarEdicion(false);
            btnConfirmar.Enabled = false;
            radioButton2.Checked = true;
            admReserva.LlenarTabla(dgvReserva);
        }

        private void FrmRegistrarReserva_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (radioButton1.Checked)
                {
                    string nombre = txtNombre.Text.Trim();
                    if (string.IsNullOrEmpty(nombre))
                    {
                        MessageBox.Show("Ingrese un nombre para buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int resultados = admReserva.BuscarPorNombre(nombre, dgvReserva);
                    if (resultados == 0)
                    {
                        MessageBox.Show("No se encontraron reservas con ese nombre", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    MessageBox.Show("Se encontraron " + resultados + " reserva(s)", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (radioButton2.Checked)
                {
                    string ci = txtCi.Text.Trim();
                    if (string.IsNullOrEmpty(ci))
                    {
                        MessageBox.Show("Ingrese una cedula para buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    bool encontrado = admReserva.BuscarPorCedula(ci, dgvReserva);
                    if (!encontrado)
                    {
                        MessageBox.Show("No se encontro ninguna reserva con esa cedula", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    MessageBox.Show("Reserva encontrada. Haga clic en 'Editar' para modificarla.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Seleccione un criterio de busqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvReserva.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva de la tabla para editar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int indiceSeleccionado = dgvReserva.SelectedRows[0].Index;
            string cedula = dgvReserva.Rows[indiceSeleccionado].Cells["colCi"].Value.ToString();

            cedulaOriginal = cedula;

            // Cargar datos sin habitación ni servicio
            bool cargado = admReserva.CargarDatosReserva(cedula, textBox2, textBox1, txtTelefono,
                txtCorreo, txtNacionalidad, dtpLlegada, dtpSalida, numAdultos, numNinos);

            if (!cargado)
            {
                MessageBox.Show("No se pudo cargar la reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HabilitarEdicion(true);
            btnConfirmar.Enabled = true;
            modoEdicion = true;

            MessageBox.Show("Puede editar los datos del huesped y fechas.\nLa habitación y servicio NO se pueden cambiar.", "Edicion habilitada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HabilitarEdicion(bool habilitar)
        {
            textBox2.ReadOnly = !habilitar;
            textBox1.ReadOnly = !habilitar;
            txtTelefono.ReadOnly = !habilitar;
            txtCorreo.ReadOnly = !habilitar;
            txtNacionalidad.ReadOnly = !habilitar;

            dtpLlegada.Enabled = habilitar;
            dtpSalida.Enabled = habilitar;

            numAdultos.ReadOnly = !habilitar;
            numNinos.ReadOnly = !habilitar;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!modoEdicion)
            {
                MessageBox.Show("No hay ninguna reserva seleccionada para editar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombres = textBox2.Text.Trim();
            string ci = textBox1.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string nacionalidad = txtNacionalidad.Text.Trim();

            if (!admReserva.ValidadDatos(nombres, ci, telefono, correo, nacionalidad))
            {
                return;
            }

            if (dtpSalida.Value.Date <= dtpLlegada.Value.Date)
            {
                MessageBox.Show("La fecha de salida debe ser posterior a la fecha de llegada", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Esta seguro de que desea guardar los cambios?\n\nNOTA: La habitación y servicio NO se modificarán.",
                "Confirmar edicion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                // Actualizar sin indices de habitacion ni servicio
                bool exito = admReserva.ActualizarReserva(
                    cedulaOriginal,
                    nombres,
                    ci,
                    telefono,
                    correo,
                    nacionalidad,
                    dtpLlegada.Value,
                    dtpSalida.Value,
                    (int)numAdultos.Value,
                    (int)numNinos.Value
                );

                if (exito)
                {
                    MessageBox.Show("Reserva actualizada exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    admReserva.LlenarTabla(dgvReserva);

                    HabilitarEdicion(false);
                    btnConfirmar.Enabled = false;
                    modoEdicion = false;
                    cedulaOriginal = "";

                    txtNombre.Clear();
                    txtCi.Clear();
                }
            } 
        }
    }
}
