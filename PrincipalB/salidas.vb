Public Class salidas
    Dim gestor1 As New Soltec.Gestor
    Private Sub salidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub alimentarTabla(_idtabla As Integer, _item As String, _desc As String, _cant As String, _bultos As String, _bruto As String, _neto As String, _total As String, _unitario As String)
        Dim lviEncontrado As New ListViewItem
        lviEncontrado.Tag = _idtabla
        lviEncontrado.Text = _item
        lviEncontrado.SubItems.Add(_desc)
        lviEncontrado.SubItems.Add(_cant)
        lviEncontrado.SubItems.Add(_bultos)
        lviEncontrado.SubItems.Add(_bruto)
        lviEncontrado.SubItems.Add(_neto)
        lviEncontrado.SubItems.Add(_total)
        lviEncontrado.SubItems.Add(_unitario)
        lstItems.Items.Add(lviEncontrado)
    End Sub

    Function alimenteItem(idformualrioIngreso As String)
        Dim arlCoincidencias As ArrayList = gestor1.DatosDeConsulta("SELECT i.*,1 FROM item i,remisiones re WHERE re.id=i.idremision AND re.idformularioingreso='" & idformualrioIngreso & "'",, Principal.cadenadeconexion)
        If Not arlCoincidencias.Count = 0 Then
            For Each item As ArrayList In arlCoincidencias
                alimentarTabla(item(0), item(4), item(5), item(6), item(7), item(8), item(9), item(11), item(10))
            Next
        Else
            MessageBox.Show("No existen Items", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Function

    Private Sub FiltrarPorNumeroDeFormularioDeIngresoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FiltrarPorNumeroDeFormularioDeIngresoToolStripMenuItem.Click
        Dim idformualario As String = InputBox("Escriba el Formulario de Ingreso", "Mensaje del Sitema")
        If idformualario.Equals("") Then : MessageBox.Show("Invalido", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error) : End If
        alimenteItem(idformualario)
    End Sub
End Class