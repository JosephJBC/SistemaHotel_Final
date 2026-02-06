using Datos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    public class Control_Pdf
    {
        Datos_PDF datosPdf = new Datos_PDF();
        public void GenerarPDFRecibo(string rutaPdf, string contenidoRecibo)
        {
            try
            {
                datosPdf.GenerarPDFRecibo(rutaPdf, contenidoRecibo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al generar PDF del recibo: " + ex.Message);
            }
        }
        public void GenerarPDFDesdeGrid(string rutaPdf, DataGridView dgv)
        {
            try
            {
                datosPdf.GenerarPDFDesdeDataGridView(rutaPdf, dgv);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al generar PDF: " + ex.Message);
            }
        }
    }
}