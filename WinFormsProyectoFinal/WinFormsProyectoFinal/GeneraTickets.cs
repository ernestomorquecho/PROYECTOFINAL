﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using WinFormsProyectoFinal;
using System;
using System.Diagnostics;
using System.IO;
using Font = iTextSharp.text.Font;

public class GeneradorDeTickets
{
    //Metodo GenerarPDF, que recibe la lista de productos de la compra, una ruta de archivo para guardarse y el usuario que compra
    public static void GenerarPDF(List<ProductosCompra> productos, string usuario)
    {
        try
        {
            //Carpeta donde se guardan los Tickets
            string carpetaTickets = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tickets");
            if (!Directory.Exists(carpetaTickets))
            {
                Directory.CreateDirectory(carpetaTickets);
            }
            string nombreArchivo = "ticket_venta.pdf";
            string rutaPDF = Path.Combine(carpetaTickets, nombreArchivo);
            //Creamos un documento PDF
            Document documento = new Document(PageSize.B6, 10, 10, 10, 10); // Tamaño B6 es un tamaño similar al de un ticket, para no utilizar una hoja de maquina o algo parecido
            PdfWriter.GetInstance(documento, new FileStream(rutaPDF, FileMode.Create));

            // Abrimos el documento para escribir en él
            documento.Open();

            // Definimos estilos de letra y las fuentes a ocupar
            Font tituloFont = FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD);
            Font textoFont = FontFactory.GetFont("Arial", 10, Font.NORMAL);
            Font negritaFont = FontFactory.GetFont("Arial", 10, Font.BOLD);

            // Aquí empezamos a escribir en el documento en encabezado del ticket
            documento.Add(new Paragraph("OFFICETEMAS", tituloFont) { Alignment = Element.ALIGN_CENTER });//Nombre de la empresa
            documento.Add(new Paragraph("Con officetemas, tus ideas no tienen dilema", tituloFont) { Alignment = Element.ALIGN_CENTER });//eslogan
            documento.Add(new Paragraph($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}", textoFont));//Fecha
            documento.Add(new Paragraph($"Compra hecha por: {usuario}", textoFont));
            documento.Add(new Paragraph("=====================================", textoFont));

            // Inicializamos tabla para el desgloce de la compra
            PdfPTable tabla = new PdfPTable(4); // 4 columnas: Cantidad, Producto, Precio, Total
            tabla.WidthPercentage = 100;
            tabla.SetWidths(new float[] { 1, 3, 2, 2 }); // Ajuste de tamaño de columnas

            // Encabezados de tabla
            tabla.AddCell(new PdfPCell(new Phrase("Cant", negritaFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
            tabla.AddCell(new PdfPCell(new Phrase("Producto", negritaFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
            tabla.AddCell(new PdfPCell(new Phrase("Precio", negritaFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
            tabla.AddCell(new PdfPCell(new Phrase("Total", negritaFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER });

            // Llenamos la tabla con productos
            int totalAPagar = 0;
            foreach (var prod in productos)
            {
                int subtotal = prod.Cantidad * prod.Precio;
                totalAPagar += subtotal;

                tabla.AddCell(new PdfPCell(new Phrase(prod.Cantidad.ToString(), textoFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                tabla.AddCell(new PdfPCell(new Phrase(prod.Producto, textoFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                tabla.AddCell(new PdfPCell(new Phrase($"${prod.Precio}", textoFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                tabla.AddCell(new PdfPCell(new Phrase($"${subtotal}", textoFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
            }

            documento.Add(tabla);

            // Total a pagar
            float interes= (float)(totalAPagar*.06);
            float PagoFinal;
            documento.Add(new Paragraph("=====================================", textoFont));
            documento.Add(new Paragraph($"TOTAL: ${totalAPagar}", tituloFont) { Alignment = Element.ALIGN_RIGHT });
            documento.Add(new Paragraph($"INTERESES (6%): ${interes}", tituloFont) { Alignment = Element.ALIGN_RIGHT });
            PagoFinal = (float)(totalAPagar + interes);
            documento.Add(new Paragraph($"TOTAL A PAGAR: ${totalAPagar}", tituloFont) { Alignment = Element.ALIGN_RIGHT });

            // Un mensaje de despedida para que se vea bonito
            documento.Add(new Paragraph("\nGracias por su compra!", textoFont) { Alignment = Element.ALIGN_CENTER });

            // Cerramos el ticket
            if (File.Exists(rutaPDF))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = rutaPDF,
                    UseShellExecute = true // Permite usar la aplicación predeterminada del sistema
                });
            }
            documento.Close();

            Console.WriteLine("Ticket generado correctamente.");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al generar el ticket: {ex.Message}");
        }
    }
}