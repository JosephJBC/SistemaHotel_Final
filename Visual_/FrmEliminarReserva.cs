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
    public partial class FrmEliminarReserva : Form
    {
        Adm_Reserva admRes = new Adm_Reserva();
        public FrmEliminarReserva()
        {
            InitializeComponent();
            admRes.LlenarTabla(dgvReserva);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = 0;
            string cedulaB = "";
            if (dgvReserva.SelectedRows.Count == 1)
            {
                indice = dgvReserva.SelectedRows[0].Index;
                cedulaB = dgvReserva.SelectedRows[0].Cells["colCi"].Value?.ToString();
                DialogResult result = MessageBox.Show("¿Desea eliminar la reserva del huésped con cédula " + cedulaB + "?",
                           "Confirmación",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    admRes.EliminarReserva(cedulaB, dgvReserva);
                    dgvReserva.Rows.RemoveAt(indice);
                    MessageBox.Show("Reserva eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
