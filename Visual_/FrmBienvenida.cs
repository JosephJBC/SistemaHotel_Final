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
    public partial class FrmBienvenida : Form
    {
        public FrmBienvenida(string nombre)
        {
            InitializeComponent();
            this.Text += " "+nombre;
            lblBienvenida.Text = "Bienvenido al sistema " + nombre;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            FrmSistema frmSistema = new FrmSistema();
            this.Visible = false;
            frmSistema.ShowDialog();
        }
    }
}
