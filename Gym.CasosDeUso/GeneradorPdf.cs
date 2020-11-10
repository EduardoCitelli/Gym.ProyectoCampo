namespace Gym.CasosDeUso
{
    using Gym.Domain;
    using iText.IO.Font;
    using iText.IO.Image;
    using iText.Kernel.Font;
    using iText.Kernel.Pdf;
    using iText.Layout;
    using iText.Layout.Borders;
    using iText.Layout.Element;
    using iText.Layout.Properties;
    using System;

    public class GeneradorPdf
    {
        public string GenerarComprobante(ComprobanteEmitido comprobante, Socios socio)
        {
            var filename = $"C:\\Users\\Eduvino\\source\\repos\\Gym\\Comprobantes\\Comprobante_{socio.soc_Apellido}_{comprobante.cem_NroTransaccion}.pdf";

            var writer = new PdfWriter(filename);

            var pdf = new PdfDocument(writer);
            
            var doc = new Document(pdf).SetBorder(new GrooveBorder(1));

            Paragraph newline = new Paragraph(new Text("\n"));

            this.AgregarTitulo(doc);
            doc.Add(newline);            

            this.AgregarLogo(doc);
            doc.Add(newline);

            this.AgregarSubTitulo(doc, socio);
            doc.Add(newline);

            this.AgregarTablaDatosTransaccion(comprobante, doc);
            doc.Add(newline);

            this.AgregarTablaDatosPago(comprobante, doc);
            doc.Add(newline);

            var tablaDatosVencimiento = this.AgregarTablaDatosVencimiento(comprobante);

            if (comprobante.cem_CantidadClases.HasValue)
                this.AgregarDatosClases(comprobante, tablaDatosVencimiento);

            doc.Add(tablaDatosVencimiento);

            doc.Close();
            writer.Close();

            return filename;
        }

        private void AgregarDatosClases(ComprobanteEmitido comprobante, Table tablaDatosVencimiento)
        {
            var tablaCantidadClases = new Table(2);

            tablaCantidadClases.AddCell("Cant. Clases");
            tablaCantidadClases.AddCell(comprobante.cem_CantidadClases.ToString());

            var cell4 = new Cell()
                .SetBorder(Border.NO_BORDER)
                .Add(tablaCantidadClases);

            tablaDatosVencimiento.AddCell(cell4);
        }

        private Table AgregarTablaDatosVencimiento(ComprobanteEmitido comprobante)
        {
            var tablaDatosVencimiento = new Table(1)
                            .SetHorizontalAlignment(HorizontalAlignment.CENTER);

            tablaDatosVencimiento.AddCell("Datos Vencimiento:");

            var tablaVencimiento = new Table(2);

            tablaVencimiento.AddCell("Vto. Membresia");
            tablaVencimiento.AddCell(comprobante.cem_FechaVencimiento.ToShortDateString());

            var cell3 = new Cell().SetBorder(Border.NO_BORDER).Add(tablaVencimiento);

            tablaDatosVencimiento.AddCell(cell3);
            return tablaDatosVencimiento;
        }

        private void AgregarTablaDatosPago(ComprobanteEmitido comprobante, Document doc)
        {
            var tablaDatosPago = new Table(1)
                            .SetHorizontalAlignment(HorizontalAlignment.CENTER);

            tablaDatosPago.AddCell("Datos Pago:");

            var tablaPago = new Table(2);

            tablaPago.AddCell("Pagó");
            tablaPago.AddCell($"$ {comprobante.cem_Precio}");
            tablaPago.AddCell("Forma de Pago");
            tablaPago.AddCell(comprobante.cem_FormaPago);

            var cell2 = new Cell().SetBorder(Border.NO_BORDER).Add(tablaPago);

            tablaDatosPago.AddCell(cell2);

            doc.Add(tablaDatosPago);
        }

        private void AgregarTablaDatosTransaccion(ComprobanteEmitido comprobante, Document doc)
        {
            var tablaDatosTransaccion = new Table(1)
                            .SetHorizontalAlignment(HorizontalAlignment.CENTER);

            tablaDatosTransaccion.AddCell("Datos Transacción:")
                .SetBorder(Border.NO_BORDER);

            var tablaHora = new Table(2);

            tablaHora.AddCell("Fecha");
            tablaHora.AddCell(comprobante.cem_FechaEmision.ToShortDateString());

            tablaHora.AddCell("Hora");
            tablaHora.AddCell(comprobante.cem_FechaEmision.ToLongTimeString());

            tablaHora.AddCell("Nro. Transacción");
            tablaHora.AddCell(comprobante.cem_NroTransaccion.ToString());

            var cell = new Cell()
                .SetBorder(Border.NO_BORDER)
                .Add(tablaHora);

            tablaDatosTransaccion.AddCell(cell);

            doc.Add(tablaDatosTransaccion);
        }

        private void AgregarLogo(Document doc)
        {
            Image Logo = new Image(ImageDataFactory
                            .Create("C:\\Users\\Eduvino\\source\\repos\\Gym\\Image\\Logo.png"))
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetBorder(Border.NO_BORDER)
                            .Scale(0.2f, 0.2f)
                            .SetHorizontalAlignment(HorizontalAlignment.CENTER);

            doc.Add(Logo);
        }

        private void AgregarSubTitulo(Document doc, Socios socio)
        {
            Paragraph SubTitulo = new Paragraph()
                            .SetFont(PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD))
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetItalic()
                            .SetFontSize(14);

            SubTitulo.Add($"Socio: {socio.soc_Apellido},{socio.soc_Nombre}");

            doc.Add(SubTitulo);
        }

        private void AgregarTitulo(Document doc)
        {
            Paragraph Titulo = new Paragraph()
                            .SetFont(PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD))
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(20);

            Titulo.Add("Comprobante de Pago");

            doc.Add(Titulo);
        }
    }
}
