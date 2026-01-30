using Datos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    public class control_Dinamico
    {
        conexion con = null;
        DatosInformacionAutor datosInfo = null;

        public void LlenarInformacionAutor(TextBox txtNombreSistema, TextBox txtDuenio, TextBox txtDireccion, TextBox txtCorreo, TextBox txtTelefono, PictureBox picFoto)
        {
            con = new conexion();
            string res = con.conectar();
            datosInfo = new DatosInformacionAutor();

            if (res[0] == '1')
            {
                try
                {
                    InformacionAutor info = datosInfo.ConsultarInformacion(con.Cn);

                    if (info != null)
                    {
                        txtNombreSistema.Text = info.Nombre_Sistema;
                        txtDuenio.Text = info.Duenio;
                        txtDireccion.Text = info.Direccion;
                        txtCorreo.Text = info.Correo;
                        txtTelefono.Text = info.Telefono;
                        if (!string.IsNullOrEmpty(info.Ruta_Foto) && File.Exists(info.Ruta_Foto))
                        {
                            picFoto.Image = Image.FromFile(info.Ruta_Foto);
                            picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (res[0] == '0')
            {
                MessageBox.Show("Error de conexión: " + res.Substring(1),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
