Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports Soltec.Gestor

Public Class Clientes
    Public vConn As MySqlConnection
    Dim fun As New Funciones
    Dim intbusqueda As Integer = 1
    Dim gestor1 As New Soltec.Gestor
    Public intidmodificado As Integer = 0
    Dim controlMenu As Integer = 0
    Dim strUnidad As String = "D"
    Dim rutaImagen As String
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validarCampos() Then

            Try

                Dim conexion As New MySqlConnection(Principal.cadenadeconexion)
                conexion.Open()
                Dim cmd As New MySqlCommand()
                cmd = conexion.CreateCommand()
                cmd.CommandText = "INSERT INTO cliente (nit,no,direccion,telefono,correo) VALUES (?,?,?,?,?)"
                cmd.Parameters.AddWithValue("nit", txtNit.Text.ToString())
                cmd.Parameters.AddWithValue("no", txtNombre.Text.ToString())
                cmd.Parameters.AddWithValue("direccion", txtDireccion.Text.ToString())
                cmd.Parameters.AddWithValue("telefono", txtTelefono.Text.ToString())
                cmd.Parameters.AddWithValue("correo", txtCorreo.Text.ToString())

                cmd.ExecuteNonQuery()
                cmd.Dispose()
                conexion.Close()
                conexion.Dispose()
                reiniciar()
                MessageBox.Show("El registro se hizo correctamente", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            Catch ex As Exception
                MessageBox.Show("Ocurrio un error durante el registro" & ex.Message, "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        Else : MessageBox.Show("Debe Alimentar Los Campos Minimos", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Function validarCampos() As Boolean
        If Not txtNit.Text.ToString.Equals("") Then
            If Not txtNombre.Text.ToString.Equals("") Then
                If Not txtTelefono.Text.ToString.Equals("") Then
                    Return True
                Else : Return False
                End If
            Else : Return False
            End If
        Else : Return False
        End If
    End Function

    Sub reiniciar()
        txtNombre.Text = ""
        txtNit.Text = ""
        txtDireccion.Text = ""
        txtCorreo.Text = ""
        txtTelefono.Text = ""
        btnmodificar.Enabled = False
        btnGuardar.Enabled = True
        'pararCaptura()
        txtNit.Focus()


    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim strNit As String = Nothing
        strNit = InputBox("Escriba un Documento", "Mensaje del Sistema")
        If Not strNit.Equals("") Then
            If fun.Alimentar(txtNit, strNit, txtNombre, txtTelefono, txtDireccion, txtCorreo, intidmodificado, 1) Then

                btnmodificar.Enabled = True
                btnGuardar.Enabled = False
            Else
                MessageBox.Show("EL documento ingresado no se encontro en la base de datos", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub txtNit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNit.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If fun.saberingreso(txtNit.Text) Then
                MessageBox.Show("EL documento ingresado ya fue registrado", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If Not txtNit.Text.ToString.Equals("") Then : My.Computer.Clipboard.SetText(txtNit.Text) : End If
                txtNombre.Focus()
            End If


        End If
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub

    Private Sub txtNit_TextChanged(sender As Object, e As EventArgs) Handles txtNit.TextChanged

    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        txtNit.Focus()
        btnmodificar.Enabled = False
        'controlMenu = pnl_herramientas.Location.X 'controla la posición del menú
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click

        If validarCampos() Then
            Dim conexion As New MySqlConnection(Principal.cadenadeconexion)
            conexion.Open()
            Dim cmd As New MySqlCommand()
            cmd = conexion.CreateCommand()
            cmd.CommandText = "UPDATE CLIENTE set NIT=?,no=?,telefono=?,direccion=?,correo=? WHERE id=" & intidmodificado
            cmd.Parameters.AddWithValue("nit", txtNit.Text.ToString())
            cmd.Parameters.AddWithValue("no", txtNombre.Text.ToString().ToUpper)
            cmd.Parameters.AddWithValue("telefono", txtTelefono.Text.ToString())
            cmd.Parameters.AddWithValue("direccion", txtDireccion.Text.ToString())
            cmd.Parameters.AddWithValue("correo", txtCorreo.Text.ToString())

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conexion.Close()
            conexion.Dispose()
            reiniciar()
            MessageBox.Show("El registro se actualizo correctamente", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else : MessageBox.Show("Debe Alimentar Los Campos Minimos", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub lstClientes_MouseClick(sender As Object, e As MouseEventArgs)
        If lstNombres.SelectedItems.Count = 0 Then Exit Sub
        Dim intIdDeLaPersona = lstNombres.SelectedItems(0).Tag

        If fun.Alimentar(txtNit, intIdDeLaPersona.ToString, txtNombre, txtTelefono, txtDireccion, txtCorreo, intidmodificado, 2) Then

            btnGuardar.Enabled = False
            btnmodificar.Enabled = True

        Else
            MessageBox.Show("EL documento ingresado no se encontro en la base de datos", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        lstNombres.Visible = False
    End Sub



    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
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
        txtNombre.Select(txtNombre.Text.Length + 1, 0)
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        Select Case intbusqueda
            Case 1
                If Asc(e.KeyChar) = 13 Then
                    txtTelefono.Focus()
                End If
                If Not Char.IsNumber(e.KeyChar) Then
                    e.Handled = False
                ElseIf Char.IsControl(e.KeyChar) Then
                    e.Handled = False
                Else : e.Handled = True
                End If
            Case 2
                If Asc(e.KeyChar) = 13 Then
                    If lstNombres.SelectedItems.Count = 0 Then Exit Sub
                    Dim intIdDeLaPersona = lstNombres.SelectedItems(0).Tag
                    intbusqueda = 2
                    If fun.Alimentar(txtNit, intIdDeLaPersona.ToString, txtNombre, txtTelefono, txtDireccion, txtCorreo, intidmodificado, intbusqueda) Then

                        btnGuardar.Enabled = False
                        btnmodificar.Enabled = True
                    Else
                        MessageBox.Show("EL documento ingresado no se encontro en la base de datos", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    lstNombres.Visible = False

                End If
        End Select
    End Sub

    Private Sub BuscarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarClienteToolStripMenuItem.Click
        Me.txtNombre.Focus()
        intbusqueda = 2
        Me.btnmodificar.Enabled = True
        Me.btnGuardar.Enabled = False
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        lbl_NomCliente.Text = Me.txtNombre.Text
        Select Case intbusqueda
            Case 1

            Case 2
                If txtNombre.Text = "" Then Exit Sub
                Dim arlCoincidencias = gestor1.DatosDeConsulta("SELECT id, nit,no FROM cliente WHERE no LIKE '%" & txtNombre.Text & "%' ORDER BY no LIMIT 30", , Principal.cadenadeconexion)
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

        End Select
    End Sub

    Private Sub lstNombres_MouseClick(sender As Object, e As MouseEventArgs)
        If lstNombres.SelectedItems.Count = 0 Then Exit Sub
        Dim intIdDeLaPersona = lstNombres.SelectedItems(0).Tag
        intbusqueda = 2
        If fun.Alimentar(txtNit, intIdDeLaPersona.ToString, txtNombre, txtTelefono, txtDireccion, txtCorreo, intidmodificado, intbusqueda) Then

        Else
            MessageBox.Show("EL documento ingresado no se encontro en la base de datos", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        lstNombres.Visible = False
    End Sub

    Private Sub lstNombres_MouseClick_1(sender As Object, e As MouseEventArgs) Handles lstNombres.MouseClick
        If lstNombres.SelectedItems.Count = 0 Then Exit Sub
        Dim intIdDeLaPersona = lstNombres.SelectedItems(0).Tag
        intbusqueda = 2
        If fun.Alimentar(txtNit, intIdDeLaPersona.ToString, txtNombre, txtTelefono, txtDireccion, txtCorreo, intidmodificado, intbusqueda) Then

            btnGuardar.Enabled = False
            btnmodificar.Enabled = True

        Else
            MessageBox.Show("EL documento ingresado no se encontro en la base de datos", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        lstNombres.Visible = False
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtDireccion.Focus()
        End If
    End Sub

    Private Sub txtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtCorreo.Focus()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        reiniciar()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub tm_Menu_Tick(sender As Object, e As EventArgs) Handles tm_MenuMostrar.Tick
        If controlMenu < 180 Then
            pnl_herramientas.Location = New System.Drawing.Point(pnl_herramientas.Location.X - 10, pnl_herramientas.Location.Y)
            controlMenu += 10
        Else
            Me.tm_MenuMostrar.Enabled = False
        End If

    End Sub

    Private Sub pnl_herramientas_Paint(sender As Object, e As PaintEventArgs) Handles pnl_herramientas.Paint

    End Sub

    Private Sub btnGuardar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnGuardar.MouseMove
        tm_MenuOcultar.Enabled = False
        tm_MenuMostrar.Enabled = True
        rutaImagen = strUnidad & ":\FRONTIER\Imagenes\btn_guardar-3_.png"
        btnGuardar.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub Clientes_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    End Sub

    Private Sub Clientes_Leave(sender As Object, e As EventArgs) Handles Me.Leave

    End Sub

    Private Sub tm_MenuOcultar_Tick(sender As Object, e As EventArgs) Handles tm_MenuOcultar.Tick
        If controlMenu > 0 Then
            pnl_herramientas.Location = New System.Drawing.Point(pnl_herramientas.Location.X + 10, pnl_herramientas.Location.Y)
            controlMenu -= 10
        Else
            Me.tm_MenuMostrar.Enabled = False
        End If
    End Sub

    Private Sub Clientes_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        tm_MenuOcultar.Enabled = True
        tm_MenuMostrar.Enabled = False
    End Sub

    Private Sub btnBuscar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnBuscar.MouseMove
        tm_MenuOcultar.Enabled = False
        tm_MenuMostrar.Enabled = True
        rutaImagen = strUnidad & ":\FRONTIER\Imagenes\btn_buscar-3_.png"
        btnBuscar.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub btnmodificar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnmodificar.MouseMove
        tm_MenuOcultar.Enabled = False
        tm_MenuMostrar.Enabled = True
        rutaImagen = strUnidad & ":\FRONTIER\Imagenes\btn_editar-3_.png"
        btnmodificar.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub Button4_MouseMove(sender As Object, e As MouseEventArgs) Handles Button4.MouseMove
        tm_MenuOcultar.Enabled = False
        tm_MenuMostrar.Enabled = True
        rutaImagen = strUnidad & ":\FRONTIER\Imagenes\btn_limpiar-3_.png"
        Button4.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        tm_MenuOcultar.Enabled = True
        tm_MenuMostrar.Enabled = False
    End Sub

    Private Sub btnGuardar_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardar.MouseLeave
        rutaImagen = strUnidad & ":\FRONTIER\Imagenes\btn_guardar-3.png"
        btnGuardar.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub btnBuscar_DragOver(sender As Object, e As DragEventArgs) Handles btnBuscar.DragOver
        rutaImagen = strUnidad & ":\FRONTIER\Imagenes\btn_buscar-3_.png"
        btnBuscar.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub btnBuscar_MouseLeave(sender As Object, e As EventArgs) Handles btnBuscar.MouseLeave
        rutaImagen = strUnidad & ":\FRONTIER\Imagenes\btn_buscar-3.png"
        btnBuscar.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub btnmodificar_MouseLeave(sender As Object, e As EventArgs) Handles btnmodificar.MouseLeave
        rutaImagen = strUnidad & ":\FRONTIER\Imagenes\btn_editar-3.png"
        btnmodificar.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        rutaImagen = strUnidad & ":\FRONTIER\Imagenes\btn_limpiar-3.png"
        Button4.Image = Image.FromFile(rutaImagen)
    End Sub
End Class