using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Modelo;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Datos
{
    public class Datos_PDF
    {
        // NUEVO METODO PARA GENERAR PDF DE RECIBO
        public void GenerarPDFRecibo(string rutaPdf, string contenidoRecibo)
        {
            PdfWriter writer = null;
            PdfDocument pdf = null;
            Document document = null;

            try
            {
                writer = new PdfWriter(rutaPdf);
                pdf = new PdfDocument(writer);
                document = new Document(pdf, iText.Kernel.Geom.PageSize.A4);

                PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                PdfFont normalFont = PdfFontFactory.CreateFont(StandardFonts.COURIER);

                document.Add(new Paragraph("RECIBO DE RESERVA")
                    .SetFont(boldFont)
                    .SetFontColor(ColorConstants.BLUE)
                    .SetFontSize(18)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));

                document.Add(new Paragraph("\n"));

                //Agregar contenido del recibo con formato
                document.Add(new Paragraph(contenidoRecibo)
                    .SetFont(normalFont)
                    .SetFontSize(10));
            }
            finally
            {
                if (document != null)
                {
                    document.Close();
                }
                if (pdf != null)
                {
                    pdf.Close();
                }
                if (writer != null)
                {
                    writer.Close();
                    writer.Dispose();
                }
            }
        }

        // NUEVO METODO PARA GENERAR PDF DE LISTA DE RESERVAS
        public void GenerarPDFDesdeDataGridView(string rutaPdf, DataGridView dgv)
        {
            PdfWriter writer = null;
            PdfDocument pdf = null;
            Document document = null;

            try
            {
                writer = new PdfWriter(rutaPdf);
                pdf = new PdfDocument(writer);
                document = new Document(pdf, iText.Kernel.Geom.PageSize.A4.Rotate());

                PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                PdfFont normalFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                document.Add(new Paragraph("LISTA DE RESERVAS")
                    .SetFont(boldFont)
                    .SetFontColor(ColorConstants.DARK_GRAY)
                    .SetFontSize(16)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));

                document.Add(new Paragraph("\n"));

                // Crear tabla con el número de columnas del DataGridView
                Table table = new Table(dgv.Columns.Count).UseAllAvailableWidth();

                // Agregar encabezados desde el DataGridView
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    table.AddHeaderCell(new Cell().Add(new Paragraph(col.HeaderText).SetFont(boldFont)));
                }

                // Agregar filas desde el DataGridView
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            string valor = cell.Value?.ToString() ?? "";
                            table.AddCell(new Cell().Add(new Paragraph(valor).SetFont(normalFont)));
                        }
                    }
                }

                document.Add(table);

                document.Add(new Paragraph("\nTotal de registros: " + dgv.Rows.Count)
                    .SetFont(boldFont)
                    .SetFontSize(12));
            }
            finally
            {
                if (document != null) document.Close();
                if (pdf != null) pdf.Close();
                if (writer != null) { writer.Close(); writer.Dispose(); }
            }
        }
    }
}
