Public Class tipoAlmacenamiento
    Dim fun As New Funciones
    Dim strtag As String = 0
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not txtNombre.Text.Equals("") AndAlso Not txtab.Text.Equals("") Then
            Dim cad As String = "INSERT INTO tipoalmacenamiento (no,ab)VALUES('" & txtNombre.Text & "','" & txtab.Text & "')"
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
            Dim cad As String = "DELETE FROM tipoalmacenamiento  WHERE id ='" & strtag & "'"
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
        fun.mostrarTipoAlmacenamiento(lstTipos)
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        txtNombre.Focus()
        strtag = 0
    End Sub

    Private Sub lstEmbalajes_MouseClick(sender As Object, e As MouseEventArgs) Handles lstTipos.MouseClick
        If lstTipos.SelectedItems.Count = 0 Then Exit Sub
        strtag = lstTipos.SelectedItems(0).Tag
        txtNombre.Text = lstTipos.SelectedItems(0).Text
        txtab.Text = lstTipos.SelectedItems(0).SubItems(1).Text

        btnModificar.Enabled = True
        btnGuardar.Enabled = False
        txtNombre.Focus()
    End Sub

    Private Sub tipoDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnModificar.Enabled = False
        fun.mostrarTipoAlmacenamiento(lstTipos)
        txtNombre.Focus()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If Not txtNombre.Text.Equals("") AndAlso Not txtab.Text.Equals("") Then
            Dim cad As String = "UPDATE tipoalmacenamiento set no='" & txtNombre.Text & "',ab='" & txtab.Text & "' WHERE id ='" & strtag & "'"
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
End Class