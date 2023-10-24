Imports MySql.Data.MySqlClient
Public Class Remisiones
    Dim idRemisionModificar As Integer = 0
    Dim gestor1 As New Soltec.Gestor
    Dim fun As New Funciones
    Dim intTipoDocumento As Integer = 0
    Dim intIdDeLaPersona As Integer = 0
    Dim intIdEmbalaje As Integer = 0
    Dim intIdPaisOrigen As Integer = 0
    Dim intidPaisDestino As Integer = 0
    Dim intidTipoAlmacenamiento As Integer = 0
    Dim intIdAlmacenamiento As Integer = 0
    Dim intidPaisCompra As Integer = 0
    Dim intIdPaisProcedencia As Integer = 0
    Dim intIdRemisionAModificar As Integer = 0
    Dim intIdItemModificado As Integer = 0
    Dim arraItems As New ArrayList
    Dim rutaImagen As String

    Dim pdf As New Report()

    Private Sub lstTipoDocumentos_MouseClick(sender As Object, e As MouseEventArgs) Handles lstTipoDocumentos.MouseClick
        If lstTipoDocumentos.SelectedItems.Count = 0 Then Exit Sub
        intTipoDocumento = lstTipoDocumentos.SelectedItems(0).Tag
        txtTipoDocumento.Text = lstTipoDocumentos.SelectedItems(0).Text
        txtConsecutivo.Text = fun.ExtraerConsecutvo(intTipoDocumento)
        lstTipoDocumentos.Visible = False
        txtidformularioIngreso.Focus()
    End Sub

    Private Sub Remisiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTipoDocumento.Focus()
        btnModificar.Enabled = False
        lblTasa.Text = fun.extraerTasa
    End Sub

    Private Sub txtTipoDocumento_TextChanged(sender As Object, e As EventArgs) Handles txtTipoDocumento.TextChanged
        If txtTipoDocumento.Text = "" Then Exit Sub
        lstTipoDocumentos.Visible = True
        Dim arlCoincidencias = gestor1.DatosDeConsulta("SELECT id,no FROM documento WHERE no LIKE '%" & txtTipoDocumento.Text & "%' or ab LIKE '%" & txtTipoDocumento.Text & "%'  ORDER BY no LIMIT 30", , Principal.cadenadeconexion)
        If Not arlCoincidencias.Count = 0 Then lstTipoDocumentos.Visible = True
                                                     lstTipoDocumentos.Items.Clear()
                                                     lstTipoDocumentos.BeginUpdate()
                                                     For Each Encontrado As ArrayList In arlCoincidencias
                                                         Dim lviEncontrado As New ListViewItem
                                                         lviEncontrado.Tag = Encontrado(0)
                                                         lviEncontrado.Text = Encontrado(1)

                                                         lstTipoDocumentos.Items.Add(lviEncontrado)
                                                     Next
                                                     lstTipoDocumentos.EndUpdate()
                                                 End Sub

    Private Sub txtTipoDocumento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTipoDocumento.KeyDown
        Dim intMovimiento As Integer = 0
        If e.KeyCode = Keys.Down Then intMovimiento = 1
        If e.KeyCode = Keys.Up Then intMovimiento = -1
        lstTipoDocumentos.BringToFront()
        If intMovimiento = 0 Then
            If e.KeyCode = Keys.End Then
                If lstTipoDocumentos.Visible Then
                    SeñaleItemListView(lstTipoDocumentos, lstTipoDocumentos.Items.Count - 1, False)
                    Exit Sub
                End If
            End If
            Exit Sub
        End If
        If lstTipoDocumentos.Visible Then
            SeñaleItemListView(lstTipoDocumentos, intMovimiento)
            Exit Sub
        End If
        txtTipoDocumento.Select(txtTipoDocumento.Text.Length + 1, 0)
    End Sub

    Private Sub txtTipoDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipoDocumento.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If lstTipoDocumentos.SelectedItems.Count = 0 Then Exit Sub
            intTipoDocumento = lstTipoDocumentos.SelectedItems(0).Tag
            txtTipoDocumento.Text = lstTipoDocumentos.SelectedItems(0).Text
            txtConsecutivo.Text = fun.ExtraerConsecutvo(intTipoDocumento)
            lstTipoDocumentos.Visible = False
            txtidformularioIngreso.Focus()
        End If
    End Sub

    Private Sub lstNombres_MouseClick(sender As Object, e As MouseEventArgs) Handles lstNombres.MouseClick
        If lstNombres.SelectedItems.Count = 0 Then Exit Sub
        intIdDeLaPersona = lstNombres.SelectedItems(0).Tag

        txtCLiente.Text = lstNombres.SelectedItems(0).SubItems(1).Text
        lstNombres.Visible = False
    End Sub

    Private Sub txtCLiente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCLiente.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If lstNombres.SelectedItems.Count = 0 Then Exit Sub
            intIdDeLaPersona = lstNombres.SelectedItems(0).Tag
            txtCLiente.Text = lstNombres.SelectedItems(0).SubItems(1).Text
            lstNombres.Visible = False
            txtDescItem.Focus()

        End If
    End Sub

    Private Sub txtCLiente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCLiente.KeyDown
        Dim intMovimiento As Integer = 0
        If e.KeyCode = Keys.Down Then intMovimiento = 1
        If e.KeyCode = Keys.Up Then intMovimiento = -1
        lstNombres.BringToFront()
        If intMovimiento = 0 Then
            If e.KeyCode = Keys.End Then
                If lstNombres.Visible Then
                    SeñaleItemListView(lstNombres, lstNombres.Items.Count - 1, False)
                    Exit Sub
                End If
            End If
            Exit Sub
        End If
        If lstNombres.Visible Then
            SeñaleItemListView(lstNombres, intMovimiento)
            Exit Sub
        End If
        txtCLiente.Select(txtCLiente.Text.Length + 1, 0)
    End Sub

    Private Sub txtCLiente_TextChanged(sender As Object, e As EventArgs) Handles txtCLiente.TextChanged
        If txtCLiente.Text = "" Then Exit Sub
        Dim arlCoincidencias = gestor1.DatosDeConsulta("SELECT id, nit,no FROM cliente WHERE no LIKE '%" & txtCLiente.Text & "%' ORDER BY no LIMIT 30", , Principal.cadenadeconexion)
        If Not arlCoincidencias.Count = 0 Then lstNombres.Visible = True
        lstNombres.Items.Clear()
        lstNombres.BeginUpdate()
        For Each Encontrado As ArrayList In arlCoincidencias
            Dim lviEncontrado As New ListViewItem
            lviEncontrado.Tag = Encontrado(0)
            lviEncontrado.Text = Encontrado(1)
            lviEncontrado.SubItems.Add(Encontrado(2))
            lstNombres.Items.Add(lviEncontrado)
        Next
        lstNombres.EndUpdate()
    End Sub

    Private Sub txtItem_TextChanged(sender As Object, e As EventArgs) Handles txtItem.TextChanged
        Dim item As String = txtItem.Text
        If item.Length >= 25 Then
            MessageBox.Show("Limite de caracteres alcanzado", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub txtEmbalajes_MouseClick(sender As Object, e As MouseEventArgs) Handles lstEmbalajes.MouseClick
        If lstEmbalajes.SelectedItems.Count = 0 Then Exit Sub
        intIdEmbalaje = lstEmbalajes.SelectedItems(0).Tag
        txtEmbalaje.Text = lstEmbalajes.SelectedItems(0).Text
        lstEmbalajes.Visible = False
        txtCantidad.Focus()
    End Sub

    Private Sub txtEmbalaje_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmbalaje.KeyDown
        Dim intMovimiento As Integer = 0
        If e.KeyCode = Keys.Down Then intMovimiento = 1
        If e.KeyCode = Keys.Up Then intMovimiento = -1
        lstTipoDocumentos.BringToFront()
        If intMovimiento = 0 Then
            If e.KeyCode = Keys.End Then
                If lstEmbalajes.Visible Then
                    SeñaleItemListView(lstEmbalajes, lstEmbalajes.Items.Count - 1, False)
                    Exit Sub
                End If
            End If
            Exit Sub
        End If
        If lstEmbalajes.Visible Then
            SeñaleItemListView(lstEmbalajes, intMovimiento)
            Exit Sub
        End If
        txtEmbalaje.Select(txtEmbalaje.Text.Length + 1, 0)
    End Sub

    Private Sub txtEmbalaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmbalaje.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If lstEmbalajes.SelectedItems.Count = 0 Then Exit Sub
            intIdEmbalaje = lstEmbalajes.SelectedItems(0).Tag
            txtEmbalaje.Text = lstEmbalajes.SelectedItems(0).Text
            lstEmbalajes.Visible = False
            txtPaisOrigen.Focus()
        End If
    End Sub

    Private Sub txtEmbalaje_TextChanged(sender As Object, e As EventArgs) Handles txtEmbalaje.TextChanged
        If txtEmbalaje.Text = "" Then Exit Sub
        lstEmbalajes.Visible = True
        Dim arlCoincidencias = gestor1.DatosDeConsulta("SELECT id,no FROM embalaje WHERE no LIKE '%" & txtEmbalaje.Text & "%' or ab LIKE '%" & txtEmbalaje.Text & "%' ORDER BY no LIMIT 30", , Principal.cadenadeconexion)
        If Not arlCoincidencias.Count = 0 Then lstEmbalajes.Visible = True
        lstEmbalajes.Items.Clear()
        lstEmbalajes.BeginUpdate()
        For Each Encontrado As ArrayList In arlCoincidencias
            Dim lviEncontrado As New ListViewItem
            lviEncontrado.Tag = Encontrado(0)
            lviEncontrado.Text = Encontrado(1)

            lstEmbalajes.Items.Add(lviEncontrado)
        Next
        lstEmbalajes.EndUpdate()
    End Sub

    Private Sub txtPaisOrigen_TextChanged(sender As Object, e As EventArgs) Handles txtPaisOrigen.TextChanged
        If txtPaisOrigen.Text = "" Then Exit Sub
        lstOrigen.Visible = True
        Dim arlCoincidencias = gestor1.DatosDeConsulta("SELECT id,nombre FROM paises WHERE nombre LIKE '%" & txtPaisOrigen.Text & "%' ORDER BY nombre LIMIT 30", , Principal.cadenadeconexion)
        If Not arlCoincidencias.Count = 0 Then lstOrigen.Visible = True
        lstOrigen.Items.Clear()
        lstOrigen.BeginUpdate()
        For Each Encontrado As ArrayList In arlCoincidencias
            Dim lviEncontrado As New ListViewItem
            lviEncontrado.Tag = Encontrado(0)
            lviEncontrado.Text = Encontrado(1)

            lstOrigen.Items.Add(lviEncontrado)
        Next
        lstOrigen.EndUpdate()
    End Sub

    Private Sub txtPaisOrigen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPaisOrigen.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If lstOrigen.SelectedItems.Count = 0 Then Exit Sub
            intIdPaisOrigen = lstOrigen.SelectedItems(0).Tag
            txtPaisOrigen.Text = lstOrigen.SelectedItems(0).Text
            lstOrigen.Visible = False
            txtPaisCompra.Focus()
        End If
    End Sub

    Private Sub txtPaisOrigen_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPaisOrigen.KeyDown
        Dim intMovimiento As Integer = 0
        If e.KeyCode = Keys.Down Then intMovimiento = 1
        If e.KeyCode = Keys.Up Then intMovimiento = -1
        lstOrigen.BringToFront()
        If intMovimiento = 0 Then
            If e.KeyCode = Keys.End Then
                If lstOrigen.Visible Then
                    SeñaleItemListView(lstOrigen, lstOrigen.Items.Count - 1, False)
                    Exit Sub
                End If
            End If
            Exit Sub
        End If
        If lstOrigen.Visible Then
            SeñaleItemListView(lstOrigen, intMovimiento)
            Exit Sub
        End If
        txtPaisOrigen.Select(txtPaisOrigen.Text.Length + 1, 0)
    End Sub

    Private Sub lstOrigen_MouseClick(sender As Object, e As MouseEventArgs) Handles lstOrigen.MouseClick
        If lstOrigen.SelectedItems.Count = 0 Then Exit Sub
        intIdPaisOrigen = lstOrigen.SelectedItems(0).Tag
        txtPaisOrigen.Text = lstOrigen.SelectedItems(0).Text
        lstOrigen.Visible = False
        txtPaisCompra.Focus()
    End Sub

    Private Sub lstPaisCompra_MouseClick(sender As Object, e As MouseEventArgs) Handles lstPaisCompra.MouseClick
        If lstPaisCompra.SelectedItems.Count = 0 Then Exit Sub
        intidPaisCompra = lstPaisCompra.SelectedItems(0).Tag
        txtPaisCompra.Text = lstPaisCompra.SelectedItems(0).Text
        lstPaisCompra.Visible = False
        txtDestino.Focus()
    End Sub







    Private Sub txtDestino_TextChanged(sender As Object, e As EventArgs) Handles txtDestino.TextChanged
        If txtDestino.Text = "" Then Exit Sub
        lstDestino.Visible = True
        Dim arlCoincidencias = gestor1.DatosDeConsulta("SELECT id,nombre FROM paises WHERE nombre LIKE '%" & txtDestino.Text & "%' ORDER BY nombre LIMIT 30", , Principal.cadenadeconexion)
        If Not arlCoincidencias.Count = 0 Then lstDestino.Visible = True
        lstDestino.Items.Clear()
        lstDestino.BeginUpdate()
        For Each Encontrado As ArrayList In arlCoincidencias
            Dim lviEncontrado As New ListViewItem
            lviEncontrado.Tag = Encontrado(0)
            lviEncontrado.Text = Encontrado(1)

            lstDestino.Items.Add(lviEncontrado)
        Next
        lstDestino.EndUpdate()
    End Sub

    Private Sub txtDestino_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDestino.KeyDown
        Dim intMovimiento As Integer = 0
        If e.KeyCode = Keys.Down Then intMovimiento = 1
        If e.KeyCode = Keys.Up Then intMovimiento = -1
        lstDestino.BringToFront()
        If intMovimiento = 0 Then
            If e.KeyCode = Keys.End Then
                If lstDestino.Visible Then
                    SeñaleItemListView(lstDestino, lstDestino.Items.Count - 1, False)
                    Exit Sub
                End If
            End If
            Exit Sub
        End If
        If lstDestino.Visible Then
            SeñaleItemListView(lstDestino, intMovimiento)
            Exit Sub
        End If
        txtDestino.Select(txtDestino.Text.Length + 1, 0)
    End Sub

    Private Sub txtDestino_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDestino.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If lstDestino.SelectedItems.Count = 0 Then Exit Sub
            intidPaisDestino = lstDestino.SelectedItems(0).Tag
            txtDestino.Text = lstDestino.SelectedItems(0).Text
            lstDestino.Visible = False
            txtProcedencia.Focus()


        End If
    End Sub

    Private Sub lstDestino_MouseClick(sender As Object, e As MouseEventArgs) Handles lstDestino.MouseClick
        If lstDestino.SelectedItems.Count = 0 Then Exit Sub
        intidPaisDestino = lstDestino.SelectedItems(0).Tag
        txtDestino.Text = lstDestino.SelectedItems(0).Text
        lstDestino.Visible = False
        txtProcedencia.Focus()
    End Sub

    Private Sub lstAlmacenamiento_MouseClick(sender As Object, e As MouseEventArgs) Handles lstAlmacenamiento.MouseClick
        If lstAlmacenamiento.SelectedItems.Count = 0 Then Exit Sub
        intidTipoAlmacenamiento = lstAlmacenamiento.SelectedItems(0).Tag
        txtAlmacenamiento.Text = lstAlmacenamiento.SelectedItems(0).Text
        lstAlmacenamiento.Visible = False
        txtPlacas.Focus()
    End Sub

    Private Sub txtAlmacenamiento_TextChanged(sender As Object, e As EventArgs) Handles txtAlmacenamiento.TextChanged
        If txtAlmacenamiento.Text = "" Then Exit Sub
        lstAlmacenamiento.Visible = True
        Dim arlCoincidencias = gestor1.DatosDeConsulta("SELECT id,no FROM tipoalmacenamiento WHERE no LIKE '%" & txtAlmacenamiento.Text & "%' or ab LIKE '%" & txtAlmacenamiento.Text & "%' ORDER BY no LIMIT 30", , Principal.cadenadeconexion)
        If Not arlCoincidencias.Count = 0 Then lstAlmacenamiento.Visible = True
        lstAlmacenamiento.Items.Clear()
        lstAlmacenamiento.BeginUpdate()
        For Each Encontrado As ArrayList In arlCoincidencias
            Dim lviEncontrado As New ListViewItem
            lviEncontrado.Tag = Encontrado(0)
            lviEncontrado.Text = Encontrado(1)

            lstAlmacenamiento.Items.Add(lviEncontrado)
        Next
        lstAlmacenamiento.EndUpdate()
    End Sub

    Private Sub txtAlmacenamiento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAlmacenamiento.KeyDown
        Dim intMovimiento As Integer = 0
        If e.KeyCode = Keys.Down Then intMovimiento = 1
        If e.KeyCode = Keys.Up Then intMovimiento = -1
        lstAlmacenamiento.BringToFront()
        If intMovimiento = 0 Then
            If e.KeyCode = Keys.End Then
                If lstAlmacenamiento.Visible Then
                    SeñaleItemListView(lstAlmacenamiento, lstAlmacenamiento.Items.Count - 1, False)
                    Exit Sub
                End If
            End If
            Exit Sub
        End If
        If lstAlmacenamiento.Visible Then
            SeñaleItemListView(lstAlmacenamiento, intMovimiento)
            Exit Sub
        End If
        txtAlmacenamiento.Select(txtAlmacenamiento.Text.Length + 1, 0)
    End Sub

    Private Sub txtAlmacenamiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlmacenamiento.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If lstAlmacenamiento.SelectedItems.Count = 0 Then Exit Sub
            intidTipoAlmacenamiento = lstAlmacenamiento.SelectedItems(0).Tag
            txtAlmacenamiento.Text = lstAlmacenamiento.SelectedItems(0).Text
            lstAlmacenamiento.Visible = False
            txtPlacas.Focus()
        End If
    End Sub
    Sub registreItem()
        For i As Integer = 0 To lstItems.Items.Count - 1
            Dim item As String = lstItems.Items(i).Text
            Dim desc As String = lstItems.Items(i).SubItems(1).Text
            Dim cantidad As Double = lstItems.Items(i).SubItems(2).Text
            Dim bultos As Double = lstItems.Items(i).SubItems(3).Text
            Dim pesobruto As Double = lstItems.Items(i).SubItems(4).Text
            Dim pesoneto As Double = lstItems.Items(i).SubItems(5).Text
            Dim unitatio As Double = lstItems.Items(i).SubItems(6).Text
            Dim total As Double = lstItems.Items(i).SubItems(7).Text
            Dim strCadenaitem As String = "INSERT INTO item(idremision,iddocumento,consecutivodocumento,item,descripcion,cantidad,bultos,pesobruto,pesoneto,valorunitario,valortotal)values('" & fun.ExtraerConsecutvo(intTipoDocumento, txtConsecutivo.Text) & "','" & intTipoDocumento & "','" & txtConsecutivo.Text & "'," & vbCrLf &
                                 "'" & item & "','" & desc & "','" & cantidad & "','" & bultos & "','" & pesobruto & "','" & pesoneto & "','" & unitatio & "','" & total & "')"

            Try
                fun.registreDatos(strCadenaitem)
            Catch ex As Exception
                MessageBox.Show("Error en el Registro", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
            End Try
        Next
    End Sub
    Sub ActualiceItem()
        For i As Integer = 0 To lstItems.Items.Count - 1
            Dim iditem As Integer = lstItems.Items(i).Tag
            Dim item As String = lstItems.Items(i).Text
            Dim desc As String = lstItems.Items(i).SubItems(1).Text
            Dim cantidad As Double = lstItems.Items(i).SubItems(2).Text
            Dim bultos As Double = lstItems.Items(i).SubItems(3).Text
            Dim pesobruto As Double = lstItems.Items(i).SubItems(4).Text
            Dim pesoneto As Double = lstItems.Items(i).SubItems(5).Text
            Dim unitatio As Double = lstItems.Items(i).SubItems(6).Text
            Dim total As Double = lstItems.Items(i).SubItems(7).Text
            Dim strcadenaitem As String = ""
            If existeItemenArray(iditem) Then

                strcadenaitem = "UPDATE item set item='" & item & "', descripcion='" & desc & "',cantidad='" & cantidad & "',bultos='" & bultos & "',pesobruto='" & pesobruto & "',pesoneto='" & pesoneto & "',
                                       valorunitario='" & unitatio & "',valortotal='" & total & "'  WHERE id=" & iditem & ""
                '    Dim strCadenaitem As String = "INSERT INTO item(idremision,iddocumento,consecutivodocumento,item,descripcion,cantidad,bultos,pesobruto,pesoneto,valorunitario,valortotal)values('" & fun.ExtraerConsecutvo(intTipoDocumento, txtConsecutivo.Text) & "','" & intTipoDocumento & "','" & txtConsecutivo.Text & "'," & vbCrLf &
                '      "'" & item & "','" & desc & "','" & cantidad & "','" & bultos & "','" & pesobruto & "','" & pesoneto & "','" & unitatio & "','" & total & "')"
            Else
                strcadenaitem = "INSERT INTO item(idremision,iddocumento,consecutivodocumento,item,descripcion,cantidad,bultos,pesobruto,pesoneto,valorunitario,valortotal)values('" & fun.ExtraerConsecutvo(intTipoDocumento, txtConsecutivo.Text) & "','" & intTipoDocumento & "','" & txtConsecutivo.Text & "'," & vbCrLf &
                               "'" & item & "','" & desc & "','" & cantidad & "','" & bultos & "','" & pesobruto & "','" & pesoneto & "','" & unitatio & "','" & total & "')"
            End If


            Try
                fun.registreDatos(strcadenaitem)
            Catch ex As Exception
                MessageBox.Show("Error en la Actualizacion", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
            End Try
        Next
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        '  Dim dato As Double = Double.Parse(txtCantidad.Text.ToString.Replace(".", ","))
        If validarCamposremision() Then

            Dim strCadena As String = "INSERT INTO remisiones (iddocumento,consecutivodocumento,idformularioingreso,idcliente,idusuario,subpartida,idembalaje," & vbCrLf &
                                            "idpaisorigen,idpaiscompra,idpaisdestino,idpaisprocedencia,fechaingreso,estado,idalmacenamiento,placas,tasadecambio) values(" & vbCrLf &
                                             "" & intTipoDocumento & ",'" & txtConsecutivo.Text & "','" & txtidformularioIngreso.Text & "'," & intIdDeLaPersona & "," & Principal.intIdUsuario & ",'" & txtSubPartida.Text & "'" & vbCrLf &
                                             "," & intIdEmbalaje & "," & intIdPaisOrigen & "," & intidPaisCompra & "," & intidPaisDestino & ",'" & intIdPaisProcedencia & "','" & Format(dtFecha.Value, "yyyy-MM-dd") & "'," & vbCrLf &
                                              "'" & lblEstado.Text & "'," & intidTipoAlmacenamiento & ",'" & txtPlacas.Text & "','" & lblTasa.Text & "')"

            '    Dim strCadenaitem As String = "INSERT INTO item(iddocumento,consecutivodocumento,item,descripcion,cantidad,bultos,pesobruto,pesoneto,valorunitario,valortotal)values('" & intTipoDocumento & "','" & txtConsecutivo.Text & "'," & vbCrLf &
            '                                 "'" & txtItem.Text & "','" & txtDescItem.Text & "','" & txtCantidad.Text & "','" & txtBultos.Text & "','" & txtPesoBruto.Text & "','" & txtPesoNeto.Text & "','" & txtUnitario.Text & "','" & txtTotal.Text & "')"
            If fun.registreDatos(strCadena) Then
                registreItem()
                MessageBox.Show("Registro Correcto", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                limpiar()
            Else
                MessageBox.Show("Error en el Registro", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If



    End Sub
    Sub limpiarLista()
        lstItems.Items.Clear()
    End Sub

    Function validarCamposItem() As Boolean
        Dim booValide As Boolean = True
        If Not txtDescItem.Text.ToString.Equals("") Then
            If Not txtItem.Text.ToString.Equals("") Then
                If Not txtCantidad.Text.ToString.Equals("") Then
                    If Not txtBultos.Text.ToString.Equals("") Then
                        If Not txtPesoBruto.Text.ToString.Equals("") Then
                            If Not txtPesoNeto.Text.ToString.Equals("") Then
                                If Not txtUnitario.Text.ToString.Equals("") Then
                                    If Not txtTotal.Text.ToString.Equals("") Then
                                    Else
                                        booValide = False
                                        MessageBox.Show("Escriba Valor Total", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        txtTotal.Focus()
                                    End If
                                Else
                                    booValide = False
                                    MessageBox.Show("Escriba el Valor Unitario", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    txtUnitario.Focus()
                                End If
                            Else
                                booValide = False
                                MessageBox.Show("Escriba el Peso Neto", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                txtPesoNeto.Focus()
                            End If
                        Else
                            booValide = False
                            MessageBox.Show("Escriba el Peso Bruto", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtPesoBruto.Focus()
                        End If
                    Else
                        booValide = False
                        MessageBox.Show("Escriba la total Bultos", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtBultos.Focus()
                    End If
                Else
                    booValide = False
                    MessageBox.Show("Escriba la Cantidad", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtCantidad.Focus()
                End If
            Else
                booValide = False
                MessageBox.Show("Escriba el Nombre del Item", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtItem.Focus()
            End If
        Else
            booValide = False
            MessageBox.Show("Escriba el Descriocion del Item", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescItem.Focus()
        End If
        Return booValide
    End Function
    Function validarCamposremision() As Boolean

        Dim booValide As Boolean = True
        If Not intTipoDocumento = 0 Then
            If Not txtidformularioIngreso.Text.ToString.Equals("") Then
                If Not txtSubPartida.Text.ToString.Equals("") Then
                    If Not intIdDeLaPersona = 0 Then
                        If Not intIdEmbalaje = 0 Then

                            If Not intIdPaisOrigen = 0 Then
                                                        If Not intidPaisCompra = 0 Then
                                                            If Not intidPaisDestino = 0 Then
                                                                If Not intidTipoAlmacenamiento = 0 Then
                                                                    If Not txtPlacas.Text.ToString.Equals("") Then
                                                                    Else
                                                                        booValide = False
                                                                        MessageBox.Show("Escriba el Numero de Placas", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                                        txtPlacas.Focus()
                                                                    End If
                                                                Else
                                                                    booValide = False
                                                                    MessageBox.Show("Seleccione Tipo Almacenamiento", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                                    txtAlmacenamiento.Focus()
                                                                End If
                                                            Else
                                                                booValide = False
                                                                MessageBox.Show("Seleccione el Pais de Destino", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                                txtDestino.Focus()
                                                            End If
                                                        Else
                                                            booValide = False
                                                            MessageBox.Show("Seleccione el Pais de Procedencia", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                            txtPaisCompra.Focus()
                                                        End If
                                                    Else
                                                        booValide = False
                                                        MessageBox.Show("Seleccione el Pais de Origen", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                        txtPaisOrigen.Focus()
                                                    End If

                                                Else
                            booValide = False
                                    MessageBox.Show("Seleccione un tipo de Embalaje", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    txtEmbalaje.Focus()
                                End If

                            Else
                        MessageBox.Show("Seleccione Cliente", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtCLiente.Focus()
                    End If
                Else
                    booValide = False
                    MessageBox.Show("Escriba la Subpartida", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtSubPartida.Focus()
                End If
            Else
                booValide = False
                MessageBox.Show("Escriba el Formuario de Ingreso", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtidformularioIngreso.Focus()
            End If
        Else
            booValide = False
            MessageBox.Show("Seleccione un tipo de Documento", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTipoDocumento.Focus()
        End If
        Return booValide
    End Function
    Sub limpiar()
        intTipoDocumento = 0
        txtTipoDocumento.Text = ""
        txtConsecutivo.Text = ""
        txtidformularioIngreso.Text = ""
        txtSubPartida.Text = ""
        txtCLiente.Text = ""
        intIdDeLaPersona = 0
        txtItem.Text = ""
        txtDescItem.Text = ""
        txtEmbalaje.Text = ""
        intIdEmbalaje = 0
        txtCantidad.Text = ""
        txtBultos.Text = ""
        txtPesoBruto.Text = ""
        txtPesoNeto.Text = ""
        txtUnitario.Text = ""
        txtTotal.Text = ""
        txtPaisOrigen.Text = ""
        intIdPaisOrigen = 0
        txtPaisCompra.Text = ""
        intidPaisCompra = 0
        txtDestino.Text = ""
        intidPaisDestino = 0
        txtProcedencia.Text = ""
        lblEstado.Text = ""
        txtAlmacenamiento.Text = ""
        intidTipoAlmacenamiento = 0
        txtPlacas.Text = ""
        btnModificar.Enabled = False
        limpiarLista()
        btnGuardar.Enabled = True
    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub txtidformularioIngreso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidformularioIngreso.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtSubPartida.Focus()
        End If
    End Sub

    Private Sub txtSubPartida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubPartida.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtCLiente.Focus()
        End If
    End Sub

    Private Sub txtDescItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescItem.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtItem.Focus()
        End If
    End Sub

    Private Sub txtItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItem.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtCantidad.Focus()
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtBultos.Focus()
        End If
    End Sub

    Private Sub txtBultos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBultos.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPesoBruto.Focus()
        End If
    End Sub

    Private Sub txtPesoBruto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPesoBruto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPesoNeto.Focus()
        End If
    End Sub

    Private Sub txtPesoNeto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPesoNeto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtTotal.Focus()
        End If
    End Sub

    Private Sub txtUnitario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnitario.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If validarCamposItem() Then
                alimentarTabla(intIdItemModificado, txtItem.Text, txtDescItem.Text, txtCantidad.Text, txtBultos.Text, txtPesoBruto.Text, txtPesoNeto.Text, txtUnitario.Text, txtTotal.Text)
                limpiaritem()
                txtDescItem.Focus()
            End If


        End If
    End Sub

    Sub limpiaritem()
        txtItem.Text = ""
        txtDescItem.Text = ""
        txtCantidad.Text = ""
        txtBultos.Text = ""
        txtPesoBruto.Text = ""
        txtPesoNeto.Text = ""
        txtUnitario.Text = ""
        txtTotal.Text = ""
        intIdItemModificado = 0
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
    Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotal.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim unitario As Double = 0
            unitario = txtTotal.Text / txtCantidad.Text
            txtUnitario.Text = String.Format("{0:n8}", Double.Parse(unitario))
            '  txtUnitario.Text = unitario
            txtUnitario.Focus()
        End If

    End Sub

    Private Sub txtPaisCompra_TextChanged(sender As Object, e As EventArgs) Handles txtPaisCompra.TextChanged
        If txtPaisCompra.Text = "" Then Exit Sub
        lstPaisCompra.Visible = True
        Dim arlCoincidencias = gestor1.DatosDeConsulta("SELECT id,nombre FROM paises WHERE nombre LIKE '%" & txtPaisCompra.Text & "%' ORDER BY nombre LIMIT 30", , Principal.cadenadeconexion)
        If Not arlCoincidencias.Count = 0 Then lstPaisCompra.Visible = True
        lstPaisCompra.Items.Clear()
        lstPaisCompra.BeginUpdate()
        For Each Encontrado As ArrayList In arlCoincidencias
            Dim lviEncontrado As New ListViewItem
            lviEncontrado.Tag = Encontrado(0)
            lviEncontrado.Text = Encontrado(1)

            lstPaisCompra.Items.Add(lviEncontrado)
        Next
        lstPaisCompra.EndUpdate()
    End Sub

    Private Sub txtPaisCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPaisCompra.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If lstPaisCompra.SelectedItems.Count = 0 Then Exit Sub
            intidPaisCompra = lstPaisCompra.SelectedItems(0).Tag
            txtPaisCompra.Text = lstPaisCompra.SelectedItems(0).Text
            lstPaisCompra.Visible = False
            txtDestino.Focus()

        End If
    End Sub

    Private Sub txtPaisCompra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPaisCompra.KeyDown
        Dim intMovimiento As Integer = 0
        If e.KeyCode = Keys.Down Then intMovimiento = 1
        If e.KeyCode = Keys.Up Then intMovimiento = -1
        lstPaisCompra.BringToFront()
        If intMovimiento = 0 Then
            If e.KeyCode = Keys.End Then
                If lstPaisCompra.Visible Then
                    SeñaleItemListView(lstPaisCompra, lstPaisCompra.Items.Count - 1, False)
                    Exit Sub
                End If
            End If
            Exit Sub
        End If
        If lstPaisCompra.Visible Then
            SeñaleItemListView(lstPaisCompra, intMovimiento)
            Exit Sub
        End If
        txtPaisCompra.Select(txtPaisCompra.Text.Length + 1, 0)
    End Sub

    Private Sub txtProcedencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProcedencia.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If lstProcedencia.SelectedItems.Count = 0 Then Exit Sub
            intIdPaisProcedencia = lstProcedencia.SelectedItems(0).Tag

            txtProcedencia.Text = lstProcedencia.SelectedItems(0).Text
            lstProcedencia.Visible = False
            txtAlmacenamiento.Focus()


        End If
    End Sub

    Private Sub BuscarPorConsecutivoDeDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles buscarporFormularioIngreso.Click
        Dim intTipo As String = InputBox("EscribA El Formulario de Ingreso", "Mensaje del Sitema")
        If intTipo.Equals("") Then : MessageBox.Show("Invalido", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error) : End If

        alimentarCamposBusqueda(2, intTipo, intTipo)
        btnGuardar.Enabled = False
        btnModificar.Enabled = True
    End Sub

    Function alimentarCamposBusqueda(tipoBusqueda As Integer, strIndexBusqueda As String, tipoDocumento As Integer)
        Dim booEncontrado As Boolean = True
        Dim strCadena As String = ""
        Select Case tipoBusqueda

            Case 1
                strCadena = "SELECT re.iddocumento,do.no,re.consecutivodocumento,re.idformularioingreso,re.subpartida,re.idcliente,cl.no, " & vbCrLf &
                             "em.id,em.no,re.idpaisorigen,pa.nombre,re.idpaiscompra,pa2.nombre,re.idpaisdestino,pa3.nombre,re.idpaisprocedencia,pa4.nombre,re.fechaingreso,re.estado,re.idalmacenamiento,al.no,re.placas,re.id,re.tasadecambio " & vbCrLf &
                             "FROM remisiones re,documento Do,cliente cl,embalaje em,paises pa,paises pa2,paises pa3,paises pa4,tipoalmacenamiento al" & vbCrLf &
                             "WHERE re.iddocumento =do.id " & vbCrLf &
                             "AND re.iddocumento='" & tipoDocumento & "'" & vbCrLf &
                             "AND re.consecutivodocumento='" & strIndexBusqueda & "'" & vbCrLf &
                             "AND re.idcliente=cl.id" & vbCrLf &
                             "AND re.idembalaje=em.id" & vbCrLf &
                             "AND re.idpaisorigen = pa.id" & vbCrLf &
                              "AND re.idpaiscompra = pa2.id" & vbCrLf &
                               "AND re.idpaisdestino = pa3.id" & vbCrLf &
                               "AND re.idpaisprocedencia = pa4.id" & vbCrLf &
                             "AND re.idalmacenamiento=al.id"

            Case 2
                strCadena = "SELECT re.iddocumento,do.no,re.consecutivodocumento,re.idformularioingreso,re.subpartida,re.idcliente,cl.no, " & vbCrLf &
                          "em.id,em.no,re.idpaisorigen,pa.nombre,re.idpaiscompra,pa2.nombre,re.idpaisdestino,pa3.nombre,re.idpaisprocedencia,pa4.nombre,re.fechaingreso,re.estado,re.idalmacenamiento,al.no,re.placas,re.id,re.tasadecambio " & vbCrLf &
                          "FROM remisiones re,documento Do,cliente cl,embalaje em,paises pa,paises pa2,paises pa3,paises pa4,tipoalmacenamiento al" & vbCrLf &
                          "WHERE re.iddocumento =do.id " & vbCrLf &
                          "AND re.idformularioingreso='" & strIndexBusqueda & "'" & vbCrLf &
                          "AND re.idcliente=cl.id" & vbCrLf &
                          "AND re.idembalaje=em.id" & vbCrLf &
                          "AND re.idpaisorigen = pa.id" & vbCrLf &
                           "AND re.idpaiscompra = pa2.id" & vbCrLf &
                            "AND re.idpaisdestino = pa3.id" & vbCrLf &
                            "AND re.idpaisprocedencia = pa4.id" & vbCrLf &
                          "AND re.idalmacenamiento=al.id"

        End Select

        Dim arlCoincidencias As ArrayList = gestor1.DatosDeConsulta(strCadena,, Principal.cadenadeconexion)
        If Not arlCoincidencias.Count = 0 Then
            For Each remision As ArrayList In arlCoincidencias
                intTipoDocumento = remision(0)
                txtTipoDocumento.Text = remision(1) : lstTipoDocumentos.Visible = False
                txtConsecutivo.Text = remision(2)
                txtidformularioIngreso.Text = remision(3)
                txtSubPartida.Text = remision(4)
                intIdDeLaPersona = remision(5)
                txtCLiente.Text = remision(6) : lstNombres.Visible = False
                intIdEmbalaje = remision(7)
                txtEmbalaje.Text = remision(8) : lstEmbalajes.Visible = False
                intIdPaisOrigen = remision(9)
                txtPaisOrigen.Text = remision(10) : lstOrigen.Visible = False
                intidPaisCompra = remision(11)
                txtPaisCompra.Text = remision(12) : lstPaisCompra.Visible = False
                intidPaisDestino = remision(13)
                txtDestino.Text = remision(14) : lstDestino.Visible = False
                intIdPaisProcedencia = remision(15)
                txtProcedencia.Text = remision(16) : lstProcedencia.Visible = False
                Dim fe As Date = remision(17)
                dtFecha.Text = Format(fe, "dd-MM-yyyy")
                lblEstado.Text = remision(18)
                intidTipoAlmacenamiento = remision(19)
                txtAlmacenamiento.Text = remision(20) : lstAlmacenamiento.Visible = False
                txtPlacas.Text = remision(21)
                intIdRemisionAModificar = remision(22)
                lblTasa.Text = remision(23)

            Next
            alimenteItem(intTipoDocumento, txtConsecutivo.Text)
        Else
            MessageBox.Show("EL Numero de Documento no Existe", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return booEncontrado
    End Function
    Function alimenteItem(idTipoDocumento As String, intConsecutivo As String)
        Dim arlCoincidencias As ArrayList = gestor1.DatosDeConsulta("SELECT *,1 FROM item WHERE iddocumento='" & idTipoDocumento & "' AND consecutivodocumento='" & intConsecutivo & "'",, Principal.cadenadeconexion)
        If Not arlCoincidencias.Count = 0 Then
            arraItems = arlCoincidencias
            For Each item As ArrayList In arlCoincidencias
                alimentarTabla(item(0), item(4), item(5), item(6), item(7), item(8), item(9), item(10), item(11))
            Next
        Else
            MessageBox.Show("No existen Items", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        existeItemenArray(4)
        Return True
    End Function

    Private Sub GenerarPdfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarPdfToolStripMenuItem.Click
        Dim repor As New Report
        Dim placas As List(Of String) = Split(txtPlacas.Text.ToString, "-").ToList
        Dim items As New List(Of ItemVO) 'LLENAR LISTA DE ITEMS GUARDANDO OBJETOS TIPO ItemVO EN ESTA LISTA
        Dim cantotal As Double = 0
        Dim bultostotal As Double = 0
        Dim brutototal As Double = 0
        Dim netototal As Double = 0
        Dim unitariototal As Double = 0
        Dim totalfinal As Double = 0
        For i As Integer = 0 To lstItems.Items.Count - 1
            Dim iditem As Integer = lstItems.Items(i).Tag
            Dim item As String = lstItems.Items(i).Text
            Dim desc As String = lstItems.Items(i).SubItems(1).Text
            Dim cantidad As Double = lstItems.Items(i).SubItems(2).Text
            Dim bultos As Double = lstItems.Items(i).SubItems(3).Text
            Dim pesobruto As Double = lstItems.Items(i).SubItems(4).Text
            Dim pesoneto As Double = lstItems.Items(i).SubItems(5).Text
            Dim unitatio As Double = lstItems.Items(i).SubItems(6).Text
            Dim total As Double = lstItems.Items(i).SubItems(7).Text
            Dim dato As New ItemVO(item, desc, cantidad, bultos, pesobruto, pesoneto, unitatio, total)
            cantotal = cantotal + cantidad
            bultostotal = bultostotal + bultos
            brutototal = brutototal + pesobruto
            netototal = netototal + pesoneto
            unitariototal = unitariototal + unitatio
            totalfinal = totalfinal + total
            items.Add(dato)
        Next

        Dim lstSubpartida As New List(Of String)
        lstSubpartida.Add("FMM INGRESO N. " & txtidformularioIngreso.Text)
        Dim enradaVO As New EntradaVO(txtCLiente.Text,
                                      fun.extraerNitById(intIdDeLaPersona, "nit"),
                                      fun.extraerNitById(intIdDeLaPersona, "direccion"),
                                      dtFecha.Value, txtTipoDocumento.Text & "-" & txtConsecutivo.Text,
                                      txtSubPartida.Text,
                                      fun.extraerAB(intIdEmbalaje, "embalaje"),
                                      items,
                                      placas,
                                      lstSubpartida,
                                      cantotal,
                                      bultostotal,
                                      brutototal,
                                      netototal,
                                     unitariototal,
                                     totalfinal,
                                      fun.extraerTasa)

        pdf = New Report
        Dim img As Image = Image.FromFile(Principal.logo)
        pdf.crearPDF(img, enradaVO)
        'MessageBox.Show("Documento Generado", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub
    Function existeItemenArray(iditem As Integer) As Boolean
        Dim booSaber As Boolean = False
        For Each item As ArrayList In arraItems
            If item(0) = iditem Then
                booSaber = True
            End If
        Next
        Return booSaber
    End Function

    Function eliminardeArray(iditem As Integer)
        Dim i As Integer = 0

        For Each item As ArrayList In arraItems
            If item(0) = iditem Then
                arraItems.RemoveAt(i)
                i = i + 1
            End If
        Next
        Return 1
    End Function
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If validarCamposremision() Then
            Dim Builderconex As New MySqlConnectionStringBuilder()
            Builderconex.Server = Principal.servidor
            Builderconex.UserID = Principal.usuario
            Builderconex.Password = Principal.password
            Builderconex.Database = Principal.database
            Dim conexion As New MySqlConnection(Builderconex.ToString())
            conexion.Open()
            Dim cmd As New MySqlCommand()
            cmd = conexion.CreateCommand()
            cmd.CommandText = "UPDATE remisiones set iddocumento=?,consecutivodocumento=?,idformularioingreso=?,idcliente=?,subpartida=?,idembalaje=?,idpaisorigen=?,idpaiscompra=?,idpaisdestino=?,idpaisprocedencia=?, fechaingreso=?,idalmacenamiento=?,placas=? WHERE id=" & intIdRemisionAModificar
            cmd.Parameters.AddWithValue("iddocumento", intTipoDocumento)
            cmd.Parameters.AddWithValue("conseutivodocumento", txtConsecutivo.Text)
            cmd.Parameters.AddWithValue("idformularioingreso", txtidformularioIngreso.Text)
            cmd.Parameters.AddWithValue("idcliente", intIdDeLaPersona)
            cmd.Parameters.AddWithValue("subpartida", txtSubPartida.Text)
            cmd.Parameters.AddWithValue("idembalaje", intIdEmbalaje)
            cmd.Parameters.AddWithValue("idpaisorigen", intIdPaisOrigen)
            cmd.Parameters.AddWithValue("idpaiscompra", intidPaisCompra)
            cmd.Parameters.AddWithValue("idpaisdestino", intidPaisDestino)
            cmd.Parameters.AddWithValue("idpaisprocedencia", intIdPaisProcedencia)
            Dim fechan As Date
            fechan = dtFecha.Value.Date
            cmd.Parameters.AddWithValue("fechaingreso", fechan)
            cmd.Parameters.AddWithValue("idalmacenamiento", intidTipoAlmacenamiento)
            cmd.Parameters.AddWithValue("placas", txtPlacas.Text)
            cmd.ExecuteNonQuery()
            ActualiceItem()
            cmd.Dispose()
            conexion.Close()
            conexion.Dispose()
            limpiar()
            MessageBox.Show("El registro se actualizo correctamente", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub
    Function modifiqueItem()
        Dim Builderconex As New MySqlConnectionStringBuilder()
        Builderconex.Server = Principal.servidor
        Builderconex.UserID = Principal.usuario
        Builderconex.Password = Principal.password
        Builderconex.Database = Principal.database
        For i As Integer = 0 To lstItems.Items.Count - 1
            Dim item As String = lstItems.Items(i).Text
            Dim desc As String = lstItems.Items(i).SubItems(1).Text
            Dim cantidad As Double = lstItems.Items(i).SubItems(2).Text
            Dim bultos As Double = lstItems.Items(i).SubItems(3).Text
            Dim pesobruto As Double = lstItems.Items(i).SubItems(4).Text
            Dim pesoneto As Double = lstItems.Items(i).SubItems(5).Text
            Dim unitatio As Double = lstItems.Items(i).SubItems(6).Text
            Dim total As Double = lstItems.Items(i).SubItems(7).Text


            Dim conexion As New MySqlConnection(Builderconex.ToString())
            conexion.Open()
            Dim cmd As New MySqlCommand()
            cmd = conexion.CreateCommand()
            cmd.CommandText = "UPDATE item set iddocumento=?,consecutivodocumento=?,idformularioingreso=?,idcliente=?,subpartida=?,idembalaje=?,idpaisorigen=?,idpaiscompra=?,idpaisdestino=?,idpaisprocedencia=?, fechaingreso=?,idalmacenamiento=?,placas=? WHERE id=" & intIdRemisionAModificar
            cmd.Parameters.AddWithValue("iddocumento", intTipoDocumento)
            cmd.Parameters.AddWithValue("conseutivodocumento", txtConsecutivo.Text)
            cmd.Parameters.AddWithValue("idformularioingreso", txtidformularioIngreso.Text)
            cmd.Parameters.AddWithValue("idcliente", intIdDeLaPersona)
            cmd.Parameters.AddWithValue("subpartida", txtSubPartida.Text)
            cmd.Parameters.AddWithValue("idembalaje", intIdEmbalaje)
            cmd.Parameters.AddWithValue("idpaisorigen", intIdPaisOrigen)
            cmd.Parameters.AddWithValue("idpaiscompra", intidPaisCompra)
            cmd.Parameters.AddWithValue("idpaisdestino", intidPaisDestino)
            cmd.Parameters.AddWithValue("idpaisprocedencia", txtProcedencia.Text)
            Dim fechan As Date
            fechan = dtFecha.Value.Date
            cmd.Parameters.AddWithValue("fechaingreso", fechan)
            cmd.Parameters.AddWithValue("idalmacenamiento", intidTipoAlmacenamiento)
            cmd.Parameters.AddWithValue("placas", txtPlacas.Text)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conexion.Close()
            conexion.Dispose()
            limpiar()
            MessageBox.Show("El registro se actualizo correctamente", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Next
        Return True
    End Function

    Private Sub lstProcedencia_MouseClick(sender As Object, e As MouseEventArgs) Handles lstProcedencia.MouseClick
        If lstProcedencia.SelectedItems.Count = 0 Then Exit Sub
        intIdPaisProcedencia = lstProcedencia.SelectedItems(0).Tag
        txtProcedencia.Text = lstProcedencia.SelectedItems(0).Text
        lstProcedencia.Visible = False
        txtAlmacenamiento.Focus()
    End Sub

    Private Sub txtProcedencia_TextChanged(sender As Object, e As EventArgs) Handles txtProcedencia.TextChanged
        If txtProcedencia.Text = "" Then Exit Sub
        lstProcedencia.Visible = True
        Dim arlCoincidencias = gestor1.DatosDeConsulta("SELECT id,nombre FROM paises WHERE nombre LIKE '%" & txtProcedencia.Text & "%' ORDER BY nombre LIMIT 30", , Principal.cadenadeconexion)
        If Not arlCoincidencias.Count = 0 Then lstProcedencia.Visible = True
        lstProcedencia.Items.Clear()
        lstProcedencia.BeginUpdate()
        For Each Encontrado As ArrayList In arlCoincidencias
            Dim lviEncontrado As New ListViewItem
            lviEncontrado.Tag = Encontrado(0)
            lviEncontrado.Text = Encontrado(1)

            lstProcedencia.Items.Add(lviEncontrado)
        Next
        lstProcedencia.EndUpdate()
    End Sub

    Private Sub txtProcedencia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProcedencia.KeyDown
        Dim intMovimiento As Integer = 0
        If e.KeyCode = Keys.Down Then intMovimiento = 1
        If e.KeyCode = Keys.Up Then intMovimiento = -1
        lstProcedencia.BringToFront()
        If intMovimiento = 0 Then
            If e.KeyCode = Keys.End Then
                If lstProcedencia.Visible Then
                    SeñaleItemListView(lstProcedencia, lstProcedencia.Items.Count - 1, False)
                    Exit Sub
                    End If
                End If
            Exit Sub
        End If
        If lstProcedencia.Visible Then
            SeñaleItemListView(lstProcedencia, intMovimiento)
            Exit Sub
        End If
        txtProcedencia.Select(txtProcedencia.Text.Length + 1, 0)
    End Sub

    Private Sub lstItems_MouseClick(sender As Object, e As MouseEventArgs) Handles lstItems.MouseClick

        For Each item In lstItems.SelectedItems
            intIdItemModificado = lstItems.SelectedItems(0).Tag
            txtItem.Text = lstItems.SelectedItems(0).Text
            txtDescItem.Text = lstItems.SelectedItems(0).SubItems(1).Text
            txtCantidad.Text = lstItems.SelectedItems(0).SubItems(2).Text
            txtBultos.Text = lstItems.SelectedItems(0).SubItems(3).Text
            txtPesoBruto.Text = lstItems.SelectedItems(0).SubItems(4).Text
            txtPesoNeto.Text = lstItems.SelectedItems(0).SubItems(5).Text
            txtUnitario.Text = lstItems.SelectedItems(0).SubItems(6).Text
            txtTotal.Text = lstItems.SelectedItems(0).SubItems(7).Text


        Next
        lstItems.SelectedItems(0).Remove()


    End Sub
    Function saberpeso() As Integer
        Dim total As Double = 0
        For i As Integer = 0 To lstItems.Items.Count - 1

            total = total + lstItems.Items(i).SubItems(5).Text

        Next


        Return total
    End Function

    Function saberItems() As String
        Dim items As String = ""
        For i As Integer = 0 To lstItems.Items.Count - 1

            items = items & " - " & lstItems.Items(i).SubItems(1).Text

        Next


        Return items
    End Function

    Private Sub txtDescItem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescItem.KeyDown
        Dim intMovimiento As Integer = 0
        If e.KeyCode = Keys.Down Then intMovimiento = 1
        If e.KeyCode = Keys.Up Then intMovimiento = -1
        If e.KeyCode = Keys.Delete Then
            If lstItems.SelectedItems.Count > 0 Then
                fun.elimineItemdeBase(lstItems.SelectedItems(0).Tag)
                lstItems.SelectedItems(0).Remove()


            End If
        End If
        lstItems.BringToFront()
        If intMovimiento = 0 Then
            If e.KeyCode = Keys.End Then
                If lstItems.Visible Then
                    SeñaleItemListView(lstItems, lstItems.Items.Count - 1, False)
                    Exit Sub
                End If
            End If
            Exit Sub
        End If
        If lstItems.Visible Then
            SeñaleItemListView(lstItems, intMovimiento)
            Exit Sub
        End If
        txtDescItem.Select(txtDescItem.Text.Length + 1, 0)
    End Sub

    Private Sub GenerarAutorizacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarAutorizacionToolStripMenuItem.Click
        Dim img As Image = Image.FromFile(Principal.logo)
        Dim firma As Image = Image.FromFile("D:\FRONTIER\Imagenes\Firma_Autorizacion.png")
        Dim footer As Image = Image.FromFile("D:\FRONTIER\Imagenes\Footer_Autorizacion.png")
        Dim Autorizar As New AutorizacionVO(dtFecha.Value.ToString,
                                            txtCLiente.Text,
                                            Principal.strUsuario,
                                            txtPlacas.Text,
                                            txtidformularioIngreso.Text,
                                            txtConsecutivo.Text,
                                            saberpeso(), saberItems())
        pdf.CrearAutorizacion(img, firma, footer, Autorizar)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnGuardar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnGuardar.MouseMove
        rutaImagen = "D:\FRONTIER\Imagenes\btn_guardar-3_.png"
        btnGuardar.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub btnGuardar_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardar.MouseLeave
        rutaImagen = "D:\FRONTIER\Imagenes\btn_guardar-3.png"
        btnGuardar.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub btnModificar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnModificar.MouseMove
        rutaImagen = "D:\FRONTIER\Imagenes\btn_editar-3_.png"
        btnModificar.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub btnModificar_MouseLeave(sender As Object, e As EventArgs) Handles btnModificar.MouseLeave
        rutaImagen = "D:\FRONTIER\Imagenes\btn_editar-3.png"
        btnModificar.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub btnModificar_Layout(sender As Object, e As LayoutEventArgs) Handles btnModificar.Layout

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles tsmConsecutivoBusqueda.Click
        Dim intTipo As String = InputBox("Tipo Documento: 1-impo, 2-expo", "Mensaje del Sitema")
        If intTipo.Equals("") Then : MessageBox.Show("Invalido", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error) : End If
        Dim consecutivo As String = InputBox("Escriba el Consecutivo", "Mensaje del Sitema")
        If consecutivo.Equals("") Then : MessageBox.Show("Invalido", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error) : End If
        alimentarCamposBusqueda(1, consecutivo, intTipo)
        btnGuardar.Enabled = False
        btnModificar.Enabled = True
    End Sub
End Class