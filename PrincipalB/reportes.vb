Imports System.IO
Imports System.Text

Public Class reportes
    Dim gestor1 As New Soltec.Gestor
    Dim fun As New Funciones
    Dim idReporte As Integer = 0
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub txtReporte_TextChanged(sender As Object, e As EventArgs) Handles txtReporte.TextChanged
        If txtReporte.Text = "" Then : Exit Sub : End If
        lstReporte.Visible = True
        Dim arlCoincidencias = gestor1.DatosDeConsulta("SELECT id,no FROM reporte WHERE no LIKE '%" & txtReporte.Text & "%' ORDER BY no LIMIT 30", , Principal.cadenadeconexion)
        If Not arlCoincidencias.Count = 0 Then lstReporte.Visible = True
        lstReporte.Items.Clear()
        lstReporte.BeginUpdate()
        For Each Encontrado As ArrayList In arlCoincidencias
            Dim lviEncontrado As New ListViewItem
            lviEncontrado.Tag = Encontrado(0)
            lviEncontrado.Text = Encontrado(1)
            lstReporte.Items.Add(lviEncontrado)
        Next
        lstReporte.EndUpdate()
    End Sub

    Private Sub txtReporte_KeyDown(sender As Object, e As KeyEventArgs) Handles txtReporte.KeyDown
        Dim intMovimiento As Integer = 0
        If e.KeyCode = Keys.Down Then intMovimiento = 1
        If e.KeyCode = Keys.Up Then intMovimiento = -1
        lstReporte.BringToFront()
        If intMovimiento = 0 Then
            If e.KeyCode = Keys.End Then
                If lstReporte.Visible Then
                    SeñaleItemListView(lstReporte, lstReporte.Items.Count - 1, False)
                    Exit Sub
                End If
            End If
            Exit Sub
        End If
        If lstReporte.Visible Then
            SeñaleItemListView(lstReporte, intMovimiento)
            Exit Sub
        End If
        txtReporte.Select(txtReporte.Text.Length + 1, 0)
    End Sub

    Public Sub buscarDatos()

        Dim fecha1 As Date = fdesde.Value.Date
        Dim fecha2 As Date = fhasta.Value.Date

        If Not lstReporte.SelectedItems.Count = 0 Then
            fun.buscarDatos(lstDatos, lstReporte.SelectedItems(0).Tag, Format(fecha1, "yyyy-MM-dd"), Format(fecha2, "yyyy-MM-dd"), txtTotales, "pendiente")
        Else : MessageBox.Show("Seleecione un reporte", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error) : txtReporte.Focus()
        End If
    End Sub

    Private Sub txtReporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReporte.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If lstReporte.SelectedItems.Count = 0 Then Exit Sub

            idReporte = lstReporte.SelectedItems(0).Tag
            txtReporte.Text = lstReporte.SelectedItems(0).Text

            buscarDatos()

        End If
    End Sub

    Private Sub lstReporte_MouseClick(sender As Object, e As MouseEventArgs) Handles lstReporte.MouseClick
        If lstReporte.SelectedItems.Count = 0 Then Exit Sub

        idReporte = lstReporte.SelectedItems(0).Tag
        txtReporte.Text = lstReporte.SelectedItems(0).Text
        buscarDatos()

    End Sub

    Sub ponerFecha()
        fdesde.CustomFormat = Now.Date.ToString
        fhasta.CustomFormat = Now.Date.ToString
    End Sub

    Private Sub reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ponerFecha()
    End Sub
    Public Sub GuardeEnArchivo(strTexto As String, Archivo As String, Muestre As Boolean)
        Using sw As New StreamWriter(Archivo, False, Encoding.Default)
            sw.WriteLine(strTexto)
            sw.Close()
        End Using
        If Muestre Then
            Dim pr As New Process()
            Try
                pr.StartInfo.FileName = Archivo
                pr.Start()
            Catch
            End Try
        End If
    End Sub
    Public Function ListViewACsv(Lista As ListView, Optional TitulosIncluidos As Boolean = True) As String
        Dim strHTML As String = ""
        If Not Lista.Groups.Count = 0 Then
            For i As Integer = 0 To Lista.Groups.Count - 1
                If Lista.Groups(i).Items.Count > 0 Then
                    For k As Integer = 0 To Lista.Columns.Count - 1
                        If Not Lista.Columns(i).Width = 0 Then strHTML += Chr(34) & Lista.Columns(k).Text & Chr(34) & ";"
                    Next
                    strHTML += vbCrLf
                    For Each Total As ListViewItem In Lista.Groups(i).Items
                        For k As Integer = 0 To Lista.Columns.Count - 1
                            If Not Lista.Columns(k).Width = 0 Then
                                strHTML += Chr(34) & Total.SubItems(k).Text & Chr(34) & ";"
                            End If
                        Next
                        strHTML += vbCrLf
                    Next
                End If
            Next
        Else
            For k As Integer = 0 To Lista.Columns.Count - 1
                If Not Lista.Columns(k).Width = 0 Then strHTML += Chr(34) & Lista.Columns(k).Text & Chr(34) & ";"
            Next
            strHTML += vbCrLf
            For Each Total As ListViewItem In Lista.Items
                For k As Integer = 0 To Lista.Columns.Count - 1
                    If Not Lista.Columns(k).Width = 0 Then
                        strHTML += Chr(34) & Total.SubItems(k).Text & Chr(34) & ";"
                    End If
                Next
                strHTML += vbCrLf
            Next
        End If
        Return strHTML
    End Function
    Private Sub txtExportar_Click(sender As Object, e As EventArgs) Handles txtExportar.Click
        Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
        SaveFileDialog1.DefaultExt = "*.csv"
        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Filter = "Archivos CSV de Excel (*.csv|*.csv"
        SaveFileDialog1.ShowDialog()
        GuardeEnArchivo(ListViewACsv(lstDatos, True), SaveFileDialog1.FileName, True)
    End Sub
End Class