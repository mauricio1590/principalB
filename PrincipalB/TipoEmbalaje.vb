Public Class TipoEmbalaje
    Dim fun As New Funciones
    Dim strtag As String = 0
    Dim controlMenu As Integer = 0
    Dim rutaImagen As String
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not txtNombre.Text.Equals("") AndAlso Not txtab.Text.Equals("") Then
            Dim cad As String = "INSERT INTO embalaje (no,ab)VALUES('" & txtNombre.Text & "','" & txtab.Text & "')"
            If fun.registreDatos(cad) Then
                MessageBox.Show("Registro Guardado", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                limpiar()
            End If
        Else
            MessageBox.Show("Debe Alimentar los Campos", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Not txtNombre.Text.Equals("") AndAlso Not txtab.Text.Equals("") Then
            Dim cad As String = "DELETE FROM embalaje  WHERE id ='" & strtag & "'"
            If fun.registreDatos(cad) Then
                MessageBox.Show("Registro Eliminado", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                limpiar()
            End If
        Else
            MessageBox.Show("Debe Alimentar los Campos", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub limpiar()
        txtNombre.Text = ""
        txtab.Text = ""
        fun.mostrarEmbalaje(lstEmbalajes)
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        txtNombre.Focus()
        strtag = 0
    End Sub

    Private Sub lstEmbalajes_MouseClick(sender As Object, e As MouseEventArgs) Handles lstEmbalajes.MouseClick
        If lstEmbalajes.SelectedItems.Count = 0 Then Exit Sub
        strtag = lstEmbalajes.SelectedItems(0).Tag
        txtNombre.Text = lstEmbalajes.SelectedItems(0).Text
        txtab.Text = lstEmbalajes.SelectedItems(0).SubItems(1).Text

        btnModificar.Enabled = True
        btnGuardar.Enabled = False
        txtNombre.Focus()
    End Sub

    Private Sub tipoDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnModificar.Enabled = False
        fun.mostrarEmbalaje(lstEmbalajes)
        txtNombre.Focus()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If Not txtNombre.Text.Equals("") AndAlso Not txtab.Text.Equals("") Then
            Dim cad As String = "UPDATE embalaje set no='" & txtNombre.Text & "',ab='" & txtab.Text & "' WHERE id ='" & strtag & "'"
            If fun.registreDatos(cad) Then
                MessageBox.Show("Registro Actualizado", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                limpiar()
            End If
        Else
            MessageBox.Show("Debe Alimentar los Campos", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtab.Focus()
        End If
    End Sub

    Private Sub txtab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtab.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If btnGuardar.Enabled Then
                btnGuardar.PerformClick()
            Else : btnModificar.PerformClick()
            End If
        End If
    End Sub

    Private Sub tm_MenuMostrar_Tick(sender As Object, e As EventArgs) Handles tm_MenuMostrar.Tick
        If controlMenu < 180 Then
            pnl_herramientas.Location = New System.Drawing.Point(pnl_herramientas.Location.X - 10, pnl_herramientas.Location.Y)
            controlMenu += 10
        Else
            Me.tm_MenuMostrar.Enabled = False
        End If
    End Sub

    Private Sub tm_MenuOcultar_Tick(sender As Object, e As EventArgs) Handles tm_MenuOcultar.Tick
        If controlMenu > 0 Then
            pnl_herramientas.Location = New System.Drawing.Point(pnl_herramientas.Location.X + 10, pnl_herramientas.Location.Y)
            controlMenu -= 10
        Else
            Me.tm_MenuMostrar.Enabled = False
        End If
    End Sub

    Private Sub btnGuardar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnGuardar.MouseMove
        tm_MenuMostrar.Enabled = True
        tm_MenuOcultar.Enabled = False
        rutaImagen = "D:\FRONTIER\Imagenes\btn_guardar-3_.png"
        btnGuardar.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub btnGuardar_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardar.MouseLeave
        rutaImagen = "D:\FRONTIER\Imagenes\btn_guardar-3.png"
        btnGuardar.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub btnEliminar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnEliminar.MouseMove
        tm_MenuMostrar.Enabled = True
        tm_MenuOcultar.Enabled = False
        rutaImagen = "D:\FRONTIER\Imagenes\btn_eliminar-3_.png"
        btnEliminar.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub btnEliminar_MouseLeave(sender As Object, e As EventArgs) Handles btnEliminar.MouseLeave
        rutaImagen = "D:\FRONTIER\Imagenes\btn_eliminar-3.png"
        btnEliminar.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub btnModificar_MouseLeave(sender As Object, e As EventArgs) Handles btnModificar.MouseLeave
        rutaImagen = "D:\FRONTIER\Imagenes\btn_editar-3.png"
        btnModificar.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub btnModificar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnModificar.MouseMove
        tm_MenuMostrar.Enabled = True
        tm_MenuOcultar.Enabled = False
        rutaImagen = "D:\FRONTIER\Imagenes\btn_editar-3_.png"
        btnModificar.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub btnLimpiar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnLimpiar.MouseMove
        tm_MenuMostrar.Enabled = True
        tm_MenuOcultar.Enabled = False
        rutaImagen = "D:\FRONTIER\Imagenes\btn_limpiar-3_.png"
        btnLimpiar.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub btnLimpiar_MouseLeave(sender As Object, e As EventArgs) Handles btnLimpiar.MouseLeave
        rutaImagen = "D:\FRONTIER\Imagenes\btn_limpiar-3.png"
        btnLimpiar.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub TipoEmbalaje_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        tm_MenuOcultar.Enabled = True
        tm_MenuMostrar.Enabled = False
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        tm_MenuOcultar.Enabled = True
        tm_MenuMostrar.Enabled = False
    End Sub
End Class