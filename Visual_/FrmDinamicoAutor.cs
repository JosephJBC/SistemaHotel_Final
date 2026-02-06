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
    public partial class FrmDinamicoAutor : Form
    {
        private Label lblTitulo;
        private Label lblNombreSistema;
        private TextBox txtNombreSistema;
        private Label lblDuenio;
        private TextBox txtDuenio;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private PictureBox picFoto;
        private Label lblFoto;

        Control_Dinamico_Autor ctlDinm = new Control_Dinamico_Autor();
        public FrmDinamicoAutor()
        {
            InitializeComponent();
            CrearControlesDinamicamente();
            CargarDatos();
        }

        private void CrearControlesDinamicamente()
        {
            int x = 40;
            int y = 30;
            int espacioY = 55;
            int anchoLbl = 160;
            int anchoTxt = 380;

            //TIT
            lblTitulo = new Label();
            lblTitulo.Text = "Informacon del Sistema y Autor";
            lblTitulo.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTitulo.Location = new Point(x, y);
            lblTitulo.Size = new Size(550, 40);
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(lblTitulo);
            y += 60;
            //NOMBRE DEL SIS
            lblNombreSistema = new Label();
            lblNombreSistema.Text = "Nombre del Sistema:";
            lblNombreSistema.Location = new Point(x, y);
            lblNombreSistema.Size = new Size(anchoLbl, 28);
            this.Controls.Add(lblNombreSistema);
            txtNombreSistema = new TextBox();
            txtNombreSistema.Location = new Point(x + anchoLbl + 10, y);
            txtNombreSistema.Size = new Size(anchoTxt, 28);
            txtNombreSistema.ReadOnly = true;
            txtNombreSistema.BackColor = Color.White;
            this.Controls.Add(txtNombreSistema);
            y += espacioY;
            //DUEÑ
            lblDuenio = new Label();
            lblDuenio.Text = "Dueño:";
            lblDuenio.Location = new Point(x, y);
            lblDuenio.Size = new Size(anchoLbl, 28);
            this.Controls.Add(lblDuenio);
            txtDuenio = new TextBox();
            txtDuenio.Location = new Point(x + anchoLbl + 10, y);
            txtDuenio.Size = new Size(anchoTxt, 28);
            txtDuenio.ReadOnly = true;
            txtDuenio.BackColor = Color.White;
            this.Controls.Add(txtDuenio);
            y += espacioY;
            //DIREC
            lblDireccion = new Label();
            lblDireccion.Text = "Descripcion:";
            lblDireccion.Location = new Point(x, y);
            lblDireccion.Size = new Size(anchoLbl, 28);
            this.Controls.Add(lblDireccion);
            txtDireccion = new TextBox();
            txtDireccion.Location = new Point(x + anchoLbl + 10, y);
            txtDireccion.Size = new Size(anchoTxt, 28);
            txtDireccion.ReadOnly = true;
            txtDireccion.BackColor = Color.White;
            this.Controls.Add(txtDireccion);
            y += espacioY;
            //CORR
            lblCorreo = new Label();
            lblCorreo.Text = "Correo Electronico:";
            lblCorreo.Location = new Point(x, y);
            lblCorreo.Size = new Size(anchoLbl, 28);
            this.Controls.Add(lblCorreo);
            txtCorreo = new TextBox();
            txtCorreo.Location = new Point(x + anchoLbl + 10, y);
            txtCorreo.Size = new Size(anchoTxt, 28);
            txtCorreo.ReadOnly = true;
            txtCorreo.BackColor = Color.White;
            this.Controls.Add(txtCorreo);
            y += espacioY;
            //TEL
            lblTelefono = new Label();
            lblTelefono.Text = "Telefono:";
            lblTelefono.Location = new Point(x, y);
            lblTelefono.Size = new Size(anchoLbl, 28);
            this.Controls.Add(lblTelefono);
            txtTelefono = new TextBox();
            txtTelefono.Location = new Point(x + anchoLbl + 10, y);
            txtTelefono.Size = new Size(anchoTxt, 28);
            txtTelefono.ReadOnly = true;
            txtTelefono.BackColor = Color.White;
            this.Controls.Add(txtTelefono);
            y += espacioY + 20;
            //FOT
            lblFoto = new Label();
            lblFoto.Text = "Fotografia:";
            lblFoto.Location = new Point(x, y);
            lblFoto.Size = new Size(anchoLbl, 28);
            this.Controls.Add(lblFoto);
            picFoto = new PictureBox();
            picFoto.Location = new Point(x + 180, y);
            picFoto.Size = new Size(200, 160);
            picFoto.BorderStyle = BorderStyle.FixedSingle;
            picFoto.BackColor = Color.LightGray;
            this.Controls.Add(picFoto);
            y += 180;
        }

        private void CargarDatos()
        {
            ctlDinm.LlenarInformacionAutor(txtNombreSistema, txtDuenio, txtDireccion, txtCorreo, txtTelefono, picFoto);
        }
    }
}
