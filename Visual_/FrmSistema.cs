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
    public partial class FrmSistema : Form
    {
        Adm_Reserva admRes = new Adm_Reserva();
        public FrmSistema()
        {
            InitializeComponent();
        }

        private void FrmSistema_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmReserv reserva = new frmReserv();
            reserva.ShowDialog();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (admRes.GetcantidadLista() > 0)
            {
                FrmListaReserva frmlisRes = new FrmListaReserva();
                frmlisRes.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay reservas registradas", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (admRes.GetcantidadLista() > 0)
            {
                FrmEliminarReserva frmElmRes = new FrmEliminarReserva();
                frmElmRes.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay reservas registradas", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (admRes.GetcantidadLista() > 0)
            {
                FrmEditarReserva frmEdiRes = new FrmEditarReserva();
                frmEdiRes.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay reservas registradas", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            FrmDinamicoAutor frmDin = new FrmDinamicoAutor();
            frmDin.ShowDialog();
        }


        private void btnConexion_Click(object sender, EventArgs e)
        {
            admRes.conexion();
        }

        private void btnAceraDe_Click(object sender, EventArgs e)
        {
            pnlSubMenu.Visible = !pnlSubMenu.Visible;
        }
    }
}
