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

        private void mniRegistrar_Click(object sender, EventArgs e)
        {
            frmReserv reserva = new frmReserv();
            reserva.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (admRes.GetcantidadLista() > 0)
            {
                FrmListaReserva frmlisRes = new FrmListaReserva();
                frmlisRes.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay reservas registradas");
            }   
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void auotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe ventanaAutor = new FrmAcercaDe();
            ventanaAutor.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarReserva frmElmRes = new FrmEliminarReserva();
            frmElmRes.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditarReserva frmEdiRes = new FrmEditarReserva();
            frmEdiRes.ShowDialog();
        }

        private void conexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admRes.conexion();
        }
    }
}
