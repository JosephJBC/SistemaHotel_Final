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
    public partial class FrmListaReserva : Form
    {
        Adm_Reserva admRes = new Adm_Reserva();
        public FrmListaReserva()
        {
            InitializeComponent();
            admRes.LlenarTabla(dgvReserva);
        }
    }
}
