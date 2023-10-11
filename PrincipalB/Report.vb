Imports iTextSharp.text.Table
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Runtime.InteropServices
'Imports WebSupergoo.ABCpdf11.Elements
Imports Element = iTextSharp.text.Element
Imports Org.BouncyCastle.Utilities

'Imports System.Net.Mime.MediaTypeNames

Public Class Report

    Dim rutaDirectorio As String = "D:\\FRONTIER\\Documentos"
    Dim nombreArchivo As String = ""
    Dim docPDF As New Document()
    Dim fotoPDF As iTextSharp.text.Image
    Dim dc As PdfContentByte
    Dim tbl As PdfTable()
    Dim pdfw As iTextSharp.text.pdf.PdfWriter
    Dim ruta As String = ""
    Dim x, y As Integer


    Public Sub crearPDF(Imagen As Bitmap, Datos As EntradaVO)
        crearDirectorio()
        If docPDF.IsOpen Then
            docPDF.Close()
        End If
        ruta = rutaDirectorio & "\\" & Datos.NoRemision1 & ".pdf"
        'If (Not verificarDocumento("Prueba")) Then
        ' MessageBox.Show("entro")
        If Not File.Exists(ruta) Then
            pdfw = PdfWriter.GetInstance(docPDF, New FileStream(ruta, FileMode.Create))
        End If

        docPDF.SetPageSize(PageSize.A4.Rotate())
        'docPDF.SetPageSize(New Rectangle(612.0F, 792.0F).Rotate) 'tamaño de la página
        docPDF.SetMargins(28.34F, 28.34F, 28.34F, 28.34F) 'CONVERTIR CM A PUNTOS

        docPDF.Open()



        'LOGO
        fotoPDF = iTextSharp.text.Image.GetInstance(Imagen, BaseColor.White)
        fotoPDF.ScaleAbsolute(380, 80)

        'y -= 150
        Dim fuente As New iTextSharp.text.Font(FontFactory.GetFont(FontFactory.TIMES, 9, iTextSharp.text.Font.BOLD).BaseFont, 9)
        Dim fuente2 As New iTextSharp.text.Font(FontFactory.GetFont(FontFactory.TIMES, 11, iTextSharp.text.Font.BOLD).BaseFont, 11)
        Dim fuenteTexto As New iTextSharp.text.Font(FontFactory.GetFont(FontFactory.TIMES, 9).BaseFont, 9)
        'Dim textoRojo As New iTextSharp.text.Font(FontFactory.GetFont(FontFactory.TIMES, 9, New BaseColor(255, 0, 0)).BaseFont, 9)
        Dim textoRojo = FontFactory.GetFont(FontFactory.TIMES_BOLD, 9, BaseColor.Red)

        'TABLA
        Dim tabla As New PdfPTable(New Single() {50.0F, 50.0F})
        tabla.WidthPercentage = 100.0F
        Dim cell As New PdfPCell(fotoPDF)
        cell.Rowspan = 7
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        tabla.AddCell(cell)
        Dim contenido As New PdfPCell(New Phrase("INTERNATIONAL FRONTIER S.A.S.", fuente))
        'contenido.Border = 1
        contenido.BorderWidthBottom = 0
        'contenido.BorderWidthRight = 1
        contenido.BorderWidthLeft = 0
        contenido.HorizontalAlignment = Element.ALIGN_CENTER
        tabla.AddCell(contenido)
        contenido = New PdfPCell(New Phrase("NIT: 804.017.832-2", fuente))
        contenido.BorderWidthBottom = 0
        contenido.BorderWidthTop = 0
        contenido.HorizontalAlignment = Element.ALIGN_CENTER
        tabla.AddCell(contenido)
        contenido = New PdfPCell(New Phrase("DIRECCIÓN: AV. LIBERTADORES ENTRE CALLE 3 Y 5 FRENTE AL RELOJ DE SOL", fuente))
        contenido.BorderWidthBottom = 0
        contenido.BorderWidthTop = 0
        contenido.HorizontalAlignment = Element.ALIGN_CENTER
        tabla.AddCell(contenido)
        contenido = New PdfPCell(New Phrase("USUARIO COMERCIAL DE LA ZONA FRANCA CÚCUTA", fuente))
        contenido.BorderWidthBottom = 0
        contenido.BorderWidthTop = 0
        contenido.HorizontalAlignment = Element.ALIGN_CENTER
        tabla.AddCell(contenido)
        contenido = New PdfPCell(New Phrase("BODEGA M1", fuente))
        contenido.BorderWidthBottom = 0
        contenido.BorderWidthTop = 0
        contenido.HorizontalAlignment = Element.ALIGN_CENTER
        tabla.AddCell(contenido)
        contenido = New PdfPCell(New Phrase("CELULAR: 3208333483", fuente))
        contenido.BorderWidthBottom = 0
        contenido.BorderWidthTop = 0
        contenido.HorizontalAlignment = Element.ALIGN_CENTER
        tabla.AddCell(contenido)
        contenido = New PdfPCell(New Phrase("E-mail: inter.frontier.2007@gmail.com", fuente))
        contenido.BorderWidthTop = 0
        contenido.HorizontalAlignment = Element.ALIGN_CENTER
        tabla.AddCell(contenido)
        docPDF.Add(tabla)

        docPDF.Add(New Phrase(" "))
        docPDF.Add(New Phrase(" "))

        'DATOS DEL CLIENTE
        tabla = New PdfPTable(New Single() {30.0F, 15.0F, 30.0F, 10.0F, 15.0F})
        tabla.WidthPercentage = 100.0F
        cell = New PdfPCell(New Phrase("CLIENTE: " & Datos.Cliente1, fuente))
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        tabla.AddCell(cell)
        cell = New PdfPCell(New Phrase("NIT: " & Datos.NitCliente1, fuente))
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        tabla.AddCell(cell)
        cell = New PdfPCell(New Phrase("DIRECCIÓN: " & Datos.DirCliente1, fuente))
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        tabla.AddCell(cell)
        cell = New PdfPCell(New Phrase("FECHA: " & Datos.FechaGeneracion1, fuente))
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        tabla.AddCell(cell)
        cell = New PdfPCell(New Phrase("REMISION " & Datos.NoRemision1, fuente))
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        tabla.AddCell(cell)
        docPDF.Add(tabla)

        docPDF.Add(New Phrase(" "))

        'CONTENIDO
        tabla = New PdfPTable(New Single() {12.0F, 12.0F, 20.0F, 8.0F, 8.0F, 8.0F, 8.0F, 8.0F, 8.0F, 8.0F})
        tabla.WidthPercentage = 100.0F

        cell = New PdfPCell(New Phrase("SUBPARTIDA ARANCELARIA", fuente))
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        cell.BackgroundColor = New BaseColor(191, 191, 191)
        tabla.AddCell(cell)

        cell = New PdfPCell(New Phrase("ÍTEM", fuente))
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        cell.BackgroundColor = New BaseColor(191, 191, 191)
        tabla.AddCell(cell)

        cell = New PdfPCell(New Phrase("DESCRIPCIÓN", fuente))
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        cell.BackgroundColor = New BaseColor(191, 191, 191)
        tabla.AddCell(cell)

        cell = New PdfPCell(New Phrase("EMBALAJE", fuente))
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        cell.BackgroundColor = New BaseColor(191, 191, 191)
        tabla.AddCell(cell)

        cell = New PdfPCell(New Phrase("CANTIDAD", fuente))
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        cell.BackgroundColor = New BaseColor(191, 191, 191)
        tabla.AddCell(cell)

        cell = New PdfPCell(New Phrase("BULTOS", fuente))
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        cell.BackgroundColor = New BaseColor(191, 191, 191)
        tabla.AddCell(cell)

        cell = New PdfPCell(New Phrase("PESO BRUTO TOTAL (KG)", fuente))
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        cell.BackgroundColor = New BaseColor(191, 191, 191)
        tabla.AddCell(cell)

        cell = New PdfPCell(New Phrase("PESO NETO TOTAL (KG)", fuente))
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        cell.BackgroundColor = New BaseColor(191, 191, 191)
        tabla.AddCell(cell)

        cell = New PdfPCell(New Phrase("VALOR UNITARIO", fuente))
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        cell.BackgroundColor = New BaseColor(191, 191, 191)
        tabla.AddCell(cell)

        cell = New PdfPCell(New Phrase("VALOR TOTAL USD", fuente))
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        cell.BackgroundColor = New BaseColor(191, 191, 191)
        tabla.AddCell(cell)

        'FILA 2 ITEMS

        'Dim items As List(Of ItemVO)

        For Each item As ItemVO In Datos.Items1

            'SUBPARTIDA - SIEMPRE ES LA MISMA PARA TODOS
            cell = New PdfPCell(New Phrase(Datos.Subpartida1, fuenteTexto))
            cell.VerticalAlignment = Element.ALIGN_MIDDLE
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            tabla.AddCell(cell)

            'ITEM
            cell = New PdfPCell(New Phrase(item.Item, fuenteTexto))
            cell.VerticalAlignment = Element.ALIGN_MIDDLE
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            tabla.AddCell(cell)

            'DESCRIPCION
            cell = New PdfPCell(New Phrase(item.DescripcionItem, fuenteTexto))
            cell.VerticalAlignment = Element.ALIGN_MIDDLE
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            tabla.AddCell(cell)

            'TIPO EMBALAJE - SIEMPRE ES EL MISMO PARA TODOS
            cell = New PdfPCell(New Phrase(Datos.TipoEmbalaje1, fuenteTexto))
            cell.VerticalAlignment = Element.ALIGN_MIDDLE
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            tabla.AddCell(cell)

            'CANTIDAD
            cell = New PdfPCell(New Phrase(item.Cantidad, fuenteTexto))
            cell.VerticalAlignment = Element.ALIGN_MIDDLE
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            tabla.AddCell(cell)

            'BULTOS
            cell = New PdfPCell(New Phrase(item.Bultos, fuenteTexto))
            cell.VerticalAlignment = Element.ALIGN_MIDDLE
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            tabla.AddCell(cell)

            'PESO BRUTO
            cell = New PdfPCell(New Phrase(item.PesoBruto, fuenteTexto))
            cell.VerticalAlignment = Element.ALIGN_MIDDLE
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            tabla.AddCell(cell)

            'PESO NETO
            cell = New PdfPCell(New Phrase(item.PesoNeto, fuenteTexto))
            cell.VerticalAlignment = Element.ALIGN_MIDDLE
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            tabla.AddCell(cell)

            'VALOR UNITARIO
            cell = New PdfPCell(New Phrase(item.ValorUnitario, fuenteTexto))
            cell.VerticalAlignment = Element.ALIGN_MIDDLE
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            tabla.AddCell(cell)

            'VALOR TOTAL
            cell = New PdfPCell(New Phrase(item.ValorTotal, fuenteTexto))
            cell.VerticalAlignment = Element.ALIGN_MIDDLE
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            tabla.AddCell(cell)

        Next

        'FILA 3 DATOS DE LAS SUBPARTIDAS
        For Each item As String In Datos.Subpartidas1
            cell = New PdfPCell(New Phrase("", fuenteTexto))
            cell.VerticalAlignment = Element.ALIGN_MIDDLE
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            tabla.AddCell(cell)

            cell = New PdfPCell(New Phrase("", fuenteTexto))
            cell.VerticalAlignment = Element.ALIGN_MIDDLE
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            tabla.AddCell(cell)

            cell = New PdfPCell(New Phrase(item, fuenteTexto))
            cell.VerticalAlignment = Element.ALIGN_MIDDLE
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            tabla.AddCell(cell)

            cell = New PdfPCell(New Phrase("", fuenteTexto))
            cell.VerticalAlignment = Element.ALIGN_MIDDLE
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            tabla.AddCell(cell)

            cell = New PdfPCell(New Phrase("", fuenteTexto))
            cell.VerticalAlignment = Element.ALIGN_MIDDLE
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            tabla.AddCell(cell)

            cell = New PdfPCell(New Phrase("", fuenteTexto))
            cell.VerticalAlignment = Element.ALIGN_MIDDLE
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            tabla.AddCell(cell)

            cell = New PdfPCell(New Phrase("", fuenteTexto))
            cell.VerticalAlignment = Element.ALIGN_MIDDLE
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            tabla.AddCell(cell)

            cell = New PdfPCell(New Phrase("", fuenteTexto))
            cell.VerticalAlignment = Element.ALIGN_MIDDLE
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            tabla.AddCell(cell)

            cell = New PdfPCell(New Phrase("", fuenteTexto))
            cell.VerticalAlignment = Element.ALIGN_MIDDLE
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            tabla.AddCell(cell)

            cell = New PdfPCell(New Phrase("", fuenteTexto))
            cell.VerticalAlignment = Element.ALIGN_MIDDLE
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            tabla.AddCell(cell)
        Next
        docPDF.Add(tabla)

        'TABLA TOTAL
        tabla = New PdfPTable(New Single() {44.0F, 8.0F, 8.0F, 8.0F, 8.0F, 8.0F, 8.0F, 8.0F})
        tabla.WidthPercentage = 100.0F

        cell = New PdfPCell(New Phrase("OBSERVACIONES: VALORES PARA EFECTOS ADUANEROS Y ALMACENAMIENTO DE MERCANCIA EN LIBRE DISPOSICIÓN - BODEGA M1", textoRojo))
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        cell.BackgroundColor = New BaseColor(191, 191, 191)
        cell.Padding = 10
        tabla.AddCell(cell)

        cell = New PdfPCell(New Phrase("TOTAL:", fuente))
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        cell.BackgroundColor = New BaseColor(191, 191, 191)
        tabla.AddCell(cell)

        cell = New PdfPCell(New Phrase(Datos.TotalCantidad1, fuente))
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        cell.BackgroundColor = New BaseColor(191, 191, 191)
        tabla.AddCell(cell)

        cell = New PdfPCell(New Phrase(Datos.TotalBultos1, fuente))
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        cell.BackgroundColor = New BaseColor(191, 191, 191)
        tabla.AddCell(cell)

        cell = New PdfPCell(New Phrase(Datos.TotalPesoBruto1, fuente))
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        cell.BackgroundColor = New BaseColor(191, 191, 191)
        tabla.AddCell(cell)

        cell = New PdfPCell(New Phrase(Datos.TotalPesoNeto1, fuente))
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        cell.BackgroundColor = New BaseColor(191, 191, 191)
        tabla.AddCell(cell)

        cell = New PdfPCell(New Phrase(Datos.TotalValorUnitario1, fuente))
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        cell.BackgroundColor = New BaseColor(191, 191, 191)
        tabla.AddCell(cell)

        cell = New PdfPCell(New Phrase(Datos.TotalTotal1, fuente))
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        cell.BackgroundColor = New BaseColor(191, 191, 191)
        tabla.AddCell(cell)

        docPDF.Add(tabla)

        docPDF.Add(New Phrase(" "))
        docPDF.Add(New Phrase(" "))

        'TASA DE CAMBIO
        docPDF.Add(New Phrase("TASA DE CAMBIO: " & Datos.TasaDeCambio1, fuente2))

        'TABLA PLACAS
        tabla = New PdfPTable(New Single() {10.0F})
        tabla.WidthPercentage = 10.0F
        tabla.HorizontalAlignment = Element.ALIGN_RIGHT

        cell = New PdfPCell(New Phrase("PLACAS", fuente))
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        cell.BackgroundColor = New BaseColor(191, 191, 191)
        tabla.AddCell(cell)

        If (Datos.Placas1.Count <> 0 And Datos.Placas1 IsNot Nothing) Then
            For Each item As String In Datos.Placas1
                cell = New PdfPCell(New Phrase(item, fuenteTexto))
                cell.VerticalAlignment = Element.ALIGN_MIDDLE
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                tabla.AddCell(cell)
            Next
        End If

        docPDF.Add(tabla)
        docPDF.Close()
        MessageBox.Show("El Documento Se Generó de Forma Exitosa", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Dim Proc As New System.Diagnostics.Process
        Proc.StartInfo.FileName = ruta
        Proc.Start()
        'Else
        'MessageBox.Show("NO ENTRO")
        'End If
        If docPDF IsNot Nothing Then
            docPDF.Close()
            docPDF = New Document()
        End If
    End Sub


    Public Sub CrearAutorizacion(Imagen As Bitmap, Firma As Bitmap, Footer As Bitmap, Autorizar As AutorizacionVO)
        crearDirectorio()
        ruta = rutaDirectorio & "\\" & Autorizar.NRemision1 & ".pdf"
        'If (Not verificarDocumento("Prueba")) Then
        If Not File.Exists(ruta) Then
            pdfw = PdfWriter.GetInstance(docPDF, New FileStream(ruta, FileMode.Create))
        End If

        docPDF.SetPageSize(PageSize.A4)
        docPDF.SetMargins(70.8661F, 70.8661F, 85.0394F, 85.0394F)
        'docPDF.SetPageSize(New Rectangle(612.0F, 792.0F).Rotate) 'tamaño de la página
        docPDF.SetMargins(28.34F, 28.34F, 28.34F, 28.34F) 'CONVERTIR CM A PUNTOS
        docPDF.Open()

        'LOGO
        fotoPDF = iTextSharp.text.Image.GetInstance(Imagen, BaseColor.White)
        fotoPDF.ScaleAbsolute(430, 80)

        'y -= 150
        Dim fuente As New iTextSharp.text.Font(FontFactory.GetFont(FontFactory.TIMES, 9, iTextSharp.text.Font.BOLD).BaseFont, 9)
        Dim fuente2 As New iTextSharp.text.Font(FontFactory.GetFont(FontFactory.TIMES_BOLDITALIC, 12, iTextSharp.text.Font.BOLD).BaseFont, 12)
        Dim fuenteTexto As New iTextSharp.text.Font(FontFactory.GetFont(FontFactory.TIMES_ITALIC, 12).BaseFont, 12)
        'Dim textoRojo As New iTextSharp.text.Font(FontFactory.GetFont(FontFactory.TIMES, 9, New BaseColor(255, 0, 0)).BaseFont, 9)
        Dim textoRojo = FontFactory.GetFont(FontFactory.TIMES_BOLD, 9, BaseColor.Red)

        'TABLA
        Dim tabla As New PdfPTable(New Single() {100.0F})
        'tabla.WidthPercentage = 100.0F
        Dim cell As New PdfPCell(fotoPDF)
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        tabla.AddCell(cell)
        docPDF.Add(tabla)

        docPDF.Add(New Phrase(" "))
        docPDF.Add(New Phrase(" "))

        'FECHA
        tabla = New PdfPTable(New Single() {100.0F})
        cell = New PdfPCell(New Phrase("San José de Cúcuta, " & Autorizar.Fecha1, fuenteTexto))
        cell.HorizontalAlignment = Element.ALIGN_LEFT
        cell.Border = 0
        tabla.AddCell(cell)
        docPDF.Add(tabla)

        docPDF.Add(New Phrase(" "))
        docPDF.Add(New Phrase(" "))


        'SEÑORES:
        tabla = New PdfPTable(New Single() {100.0F})
        Dim contenido As New PdfPCell(New Phrase("SEÑORES:", fuente2))
        contenido.BorderWidth = 0
        contenido.Padding = 0
        contenido.HorizontalAlignment = Element.ALIGN_LEFT
        'contenido.Rowspan = 4
        tabla.AddCell(contenido)
        contenido = New PdfPCell(New Phrase("ZONA FRANCA SANTANDER S.A. BIC", fuente2))
        contenido.BorderWidth = 0
        contenido.Padding = 0
        contenido.HorizontalAlignment = Element.ALIGN_LEFT
        tabla.AddCell(contenido)
        contenido = New PdfPCell(New Phrase("USUARIO OPERADOR", fuente2))
        contenido.BorderWidth = 0
        contenido.Padding = 0
        contenido.HorizontalAlignment = Element.ALIGN_LEFT
        tabla.AddCell(contenido)
        contenido = New PdfPCell(New Phrase("CÚCUTA", fuente2))
        contenido.BorderWidth = 0
        contenido.Padding = 0
        contenido.HorizontalAlignment = Element.ALIGN_LEFT
        tabla.AddCell(contenido)

        docPDF.Add(tabla)

        docPDF.Add(New Phrase(" "))
        docPDF.Add(New Phrase(" "))

        'ASUNTO
        tabla = New PdfPTable(New Single() {100.0F})
        contenido = New PdfPCell(New Phrase("ASUNTO: AUTORIZACIÓN SOBRE VEHÍCULO (PLACA N° " & Autorizar.Placa1 & ")", fuente2))
        contenido.BorderWidth = 0
        contenido.HorizontalAlignment = Element.ALIGN_LEFT
        tabla.AddCell(contenido)

        docPDF.Add(tabla)

        'CONTENIDO
        tabla = New PdfPTable(New Single() {100.0F})
        contenido = New PdfPCell(New Paragraph("Por medio del presente solicitamos ante ustedes la autorización para realizar nacionalización sobre vehículo que contiene la mercancía amparada:", fuenteTexto))
        contenido.BorderWidth = 0
        contenido.HorizontalAlignment = Element.ALIGN_JUSTIFIED
        tabla.AddCell(contenido)

        'SALTO DE LINEA
        contenido = New PdfPCell(New Paragraph(" ", fuenteTexto))
        contenido.BorderWidth = 0
        tabla.AddCell(contenido)

        contenido = New PdfPCell(New Phrase("- FMM INGRESO N° " & Autorizar.FormularioIngreso1, fuenteTexto))
        contenido.BorderWidth = 0
        contenido.PaddingLeft = 20
        contenido.HorizontalAlignment = Element.ALIGN_LEFT
        tabla.AddCell(contenido)

        contenido = New PdfPCell(New Phrase("- REMISION " & Autorizar.NRemision1, fuenteTexto))
        contenido.BorderWidth = 0
        contenido.PaddingLeft = 20
        contenido.HorizontalAlignment = Element.ALIGN_LEFT
        tabla.AddCell(contenido)

        contenido = New PdfPCell(New Phrase("- PESO DE MERCANCIA: " & Autorizar.Peso1 & " KG", fuenteTexto))
        contenido.BorderWidth = 0
        contenido.PaddingLeft = 20
        contenido.HorizontalAlignment = Element.ALIGN_LEFT
        tabla.AddCell(contenido)

        contenido = New PdfPCell(New Phrase("- MERCANCIA: " & Autorizar.Descripcion1, fuenteTexto))
        contenido.BorderWidth = 0
        contenido.PaddingLeft = 20
        contenido.HorizontalAlignment = Element.ALIGN_LEFT
        tabla.AddCell(contenido)

        'SALTO DE LINEA
        contenido = New PdfPCell(New Paragraph(" ", fuenteTexto))
        contenido.BorderWidth = 0
        tabla.AddCell(contenido)

        contenido = New PdfPCell(New Paragraph("Debido que es una mercancía a granel y abundante, es muy riesgoso el descargue por ende se presentara la verificación y totalidad de dicho producto.", fuenteTexto))
        contenido.BorderWidth = 0
        contenido.HorizontalAlignment = Element.ALIGN_JUSTIFIED
        tabla.AddCell(contenido)

        'SALTO DE LINEA
        contenido = New PdfPCell(New Paragraph(" ", fuenteTexto))
        contenido.BorderWidth = 0
        tabla.AddCell(contenido)

        contenido = New PdfPCell(New Paragraph("Gracias por su atención prestada, espero su agradable colaboración.", fuenteTexto))
        contenido.BorderWidth = 0
        contenido.HorizontalAlignment = Element.ALIGN_JUSTIFIED
        tabla.AddCell(contenido)

        docPDF.Add(tabla)

        'SALTO DE LINEA
        docPDF.Add(New Chunk(" "))
        'SALTO DE LINEA
        docPDF.Add(New Chunk(" "))

        'FIRMA
        fotoPDF = iTextSharp.text.Image.GetInstance(Firma, BaseColor.White)
        fotoPDF.ScaleAbsolute(228, 158)

        tabla = New PdfPTable(New Single() {100.0F})
        'tabla.WidthPercentage = 100.0F
        cell = New PdfPCell(fotoPDF)
        cell.BorderWidth = 0
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        tabla.AddCell(cell)
        docPDF.Add(tabla)

        'SALTO DE LINEA
        docPDF.Add(New Chunk(" "))

        'FIRMA
        fotoPDF = iTextSharp.text.Image.GetInstance(Footer, BaseColor.White)
        fotoPDF.ScaleAbsolute(430, 70.0F)

        tabla = New PdfPTable(New Single() {100.0F})
        'tabla.WidthPercentage = 100.0F
        cell = New PdfPCell(fotoPDF)
        cell.BorderWidth = 0
        cell.VerticalAlignment = Element.ALIGN_MIDDLE
        cell.HorizontalAlignment = Element.ALIGN_CENTER
        tabla.AddCell(cell)
        docPDF.Add(tabla)

        docPDF.Close()
        Dim Proc As New System.Diagnostics.Process
        Proc.StartInfo.FileName = ruta
        Proc.Start()
    End Sub

    Private Sub crearDirectorio()
        If (Not Directory.Exists(rutaDirectorio)) Then
            Directory.CreateDirectory(rutaDirectorio)
        End If

    End Sub

    Private Function verificarDocumento(nombreArchivo As String) As Boolean
        If (File.Exists(rutaDirectorio & "\\" & nombreArchivo & ".pdf")) Then
            Return True
        End If
        Return False
    End Function
End Class
