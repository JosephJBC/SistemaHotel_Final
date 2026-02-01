using Datos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControlPdf
    {
        DatosPDF datosPdf = new DatosPDF();
        DatosInformacionAutor datosInfo = new DatosInformacionAutor();
        conexion con = null;

        public void GenerarPDF(string rutaPdf)
        {
            List<InformacionAutor> listaInfo = new List<InformacionAutor>();

            con = new conexion();
            string res = con.conectar();

            if (res[0] == '11')
            {
                try
                {
                    InformacionAutor informacion = datosInfo.ConsultarInformacion(con.Cn);

                    if (informacion != null)
                    {
                        listaInfo.Add(informacion);
                    }

                    datosPdf.GenerarPDF(rutaPdf, listaInfo);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al generar PDF: " + ex.Message);
                }
                finally
                {
                    con.cerrar();
                }
            }
            else if (res[0] == '0')
            {
                throw new Exception("Error de conexión: " + res.Substring(1));
            }
        }
    }
}
