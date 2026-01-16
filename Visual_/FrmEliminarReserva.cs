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
            // Verificar que haya una fila seleccionada
            if (dgvReserva.SelectedRows.Count == 1)
            {
                indice = dgvReserva.SelectedRows[0].Index;
                // Llamar al método del controlador para eliminar
                admRes.EliminarReserva(indice, dgvReserva);
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar");
            }
        }
    }
}
