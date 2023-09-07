Public Class salidas
    Dim fun As New Funciones
    Dim gestor1 As New Soltec.Gestor
    Private Sub salidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnModificar.Enabled = False
    End Sub

    Public Sub alimentarTabla(_idtabla As Integer, _item As String, _desc As String, _cant As String, _bultos As String, lista As ListView)
        Dim lviEncontrado As New ListViewItem
        lviEncontrado.Tag = _idtabla
        lviEncontrado.Text = _item
        Dim saliente As Integer = 0
        saliente = fun.CantidadsalienteItem(_idtabla)
        lviEncontrado.SubItems.Add(_desc)
        If saliente > 0 Then
            lviEncontrado.SubItems.Add(_cant - saliente)
            lviEncontrado.SubItems.Add(_bultos - saliente)
        Else
            lviEncontrado.SubItems.Add(_cant)
            lviEncontrado.SubItems.Add(_bultos)
        End If
        lviEncontrado.SubItems.Add(0)
        lista.Items.Add(lviEncontrado)
    End Sub

    Public Sub alimentarTablaregstro(_idtabla As Integer, _item As String, _desc As String, _cant As String, _bultos As String, lista As ListView)
        Dim lviEncontrado As New ListViewItem
        lviEncontrado.Tag = _idtabla
        lviEncontrado.Text = _item
        Dim saliente As Integer = 0
        saliente = fun.CantidadsalienteItem(_idtabla)
        lviEncontrado.SubItems.Add(_desc)
        lviEncontrado.SubItems.Add(_cant)
        lviEncontrado.SubItems.Add(_bultos)

        lviEncontrado.SubItems.Add(0)
        lista.Items.Add(lviEncontrado)
    End Sub

    Function alimenteItem(idformualrioIngreso As String)
        Dim arlCoincidencias As ArrayList = gestor1.DatosDeConsulta("SELECT i.*,1 FROM item i,remisiones re WHERE re.id=i.idremision AND re.idformularioingreso='" & idformualrioIngreso & "'",, Principal.cadenadeconexion)
        If Not arlCoincidencias.Count = 0 Then
            For Each item As ArrayList In arlCoincidencias
                alimentarTabla(item(0), item(4), item(5), item(6), item(7), lstItems)

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If lstItems.Items.Count > 0 Then
            Dim res = MessageBox.Show("Desea Agregar una Nueva Remision", "Informacion Del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If res = Windows.Forms.DialogResult.Yes Then
                lstItems.Items.Clear()
                Dim idformualario As String = InputBox("Escriba el Formulario de Ingreso", "Mensaje del Sitema")
                If fun.estadoRemision(idformualario) Then : MessageBox.Show("Esta remision ya fue terminada", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub : End If
                If idformualario.Equals("") Then : MessageBox.Show("Invalido", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub : End If
                    alimenteItem(idformualario)
                End If
            Else
            Dim idformualario As String = InputBox("Escriba el Formulario de Ingreso", "Mensaje del Sitema")

            If idformualario.Equals("") Then : MessageBox.Show("Invalido", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub : End If
            If fun.estadoRemision(idformualario) Then : MessageBox.Show("Esta remision ya fue terminada", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub : End If
            alimenteItem(idformualario)
        End If

    End Sub

    Private Sub lstItems_MouseClick(sender As Object, e As MouseEventArgs) Handles lstItems.MouseClick
        btnModificar.Enabled = True

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs)

    End Sub
    Function verificarItem(tagItem As Integer) As Boolean
        Dim booSaber As Boolean = False
        For i As Integer = 0 To lstItemConfirmado.Items.Count - 1
            Dim iditem As Integer = lstItemConfirmado.Items(i).Tag
            If iditem = tagItem Then
                booSaber = True
            End If
        Next
        Return booSaber
    End Function
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim item As Integer = lstItems.SelectedItems(0).Tag
        Dim index As Integer = lstItems.SelectedItems(0).Index
        Dim cantidadNueva As String = InputBox("Digite la cantidad", "Mensaje del Sitema")
        lstItems.Items(index).SubItems(4).Text = cantidadNueva

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        For i As Integer = 0 To lstItems.Items.Count - 1
            Dim iditem As Integer = lstItems.Items(i).Tag
            Dim item As String = lstItems.Items(i).Text
            Dim desc As String = lstItems.Items(i).SubItems(1).Text
            Dim cantidad As Double = lstItems.Items(i).SubItems(2).Text
            Dim saliente As Double = lstItems.Items(i).SubItems(4).Text

            'Dim pesoneto As Double = lstItems.Items(i).SubItems(5).Text
            'Dim unitatio As Double = lstItems.Items(i).SubItems(6).Text
            'Dim total As Double = lstItems.Items(i).SubItems(7).Text
            If Not verificarItem(iditem) Then
                alimentarTablaregstro(iditem, item, desc, cantidad, saliente, lstItemConfirmado)
            Else
                MessageBox.Show("El item que desea agregar ya existe Elimine primero el registro de la segunda tabla    ", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
            End If

        Next
        btnModificar.Enabled = False
    End Sub

    Private Sub lstItemConfirmado_MouseClick(sender As Object, e As MouseEventArgs) Handles lstItemConfirmado.MouseClick
        Dim iditem As Integer = lstItemConfirmado.SelectedItems(0).Tag
        MsgBox(iditem)
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim salidaTotal As Boolean = True
        Dim g As Integer = 0
        Dim idremision As String = ""
        If txtFormularioSalida.Text = "" Then : MessageBox.Show("Debe Escribir un formulario de salida", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub : End If
        For i As Integer = 0 To lstItemConfirmado.Items.Count - 1
            Dim iditem As Integer = lstItemConfirmado.Items(i).Tag
            Dim item As String = lstItemConfirmado.Items(i).Text
            Dim desc As String = lstItemConfirmado.Items(i).SubItems(1).Text
            Dim cantidad As Double = lstItemConfirmado.Items(i).SubItems(2).Text
            Dim saliente As Double = lstItemConfirmado.Items(i).SubItems(3).Text

            If cantidad > saliente Then
                salidaTotal = False
            End If
            If salidaTotal AndAlso g = 0 Then
                fun.cambiarEstadoRemision("terminado", fun.extraerIdremision(iditem))
            Else
                fun.cambiarEstadoRemision("pendiente", fun.extraerIdremision(iditem))
                g = g + 1
            End If
            Dim strCadena As String = "INSERT INTO salidas (idformularioingreso,idformulariosalida,iditem,cantidad,fechasalida)values('" & fun.extraerFormularioIngreso(fun.extraerIdremision(iditem)) & "'
                                            ,'" & txtFormularioSalida.Text & "','" & iditem & "','" & saliente & "',current_date)"
            If fun.registreDatos(strCadena) Then



            Else
                MessageBox.Show("Error en el registro    ", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
            End If

        Next

        MessageBox.Show("Registro Correcto   ", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        btnModificar.Enabled = False
        limpiar()
    End Sub
    Sub limpiar()
        txtFormularioSalida.Text = ""
        lstItemConfirmado.Items.Clear()
        lstItems.Items.Clear()

    End Sub

<<<<<<< HEAD
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

=======
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
>>>>>>> main
    End Sub
End Class