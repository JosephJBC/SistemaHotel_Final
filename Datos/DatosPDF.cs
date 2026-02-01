using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Modelo;
using System.Collections.Generic;
using System.IO;

namespace Datos
{
    public class DatosPDF
    {
        public void GenerarPDF(string rutaPdf, List<InformacionAutor> informacion)
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

                document.Add(new Paragraph("Informacion del Sistema Hotel")
                    .SetFont(boldFont)
                    .SetFontColor(ColorConstants.RED)
                    .SetFontSize(16));

                document.Add(new Paragraph("\n"));

                Table table = new Table(5).UseAllAvailableWidth();
                table.AddHeaderCell(new Cell().Add(new Paragraph("Sistema").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Dueño").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Dirección").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Correo").SetFont(boldFont)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Teléfono").SetFont(boldFont)));

                foreach (InformacionAutor info in informacion)
                {
                    table.AddCell(info.Nombre_Sistema);
                    table.AddCell(info.Duenio);
                    table.AddCell(info.Direccion);
                    table.AddCell(info.Correo);
                    table.AddCell(info.Telefono);
                }

                document.Add(table);
            }
            finally
            {
                if (document != null)
                    document.Close();
                else if (pdf != null)
                    pdf.Close();

                if (writer != null)
                    writer.Close();
            }
        }

        public bool ExisteArchivo(string rutaPdf)
        {
            return File.Exists(rutaPdf);
        }
    }
}
