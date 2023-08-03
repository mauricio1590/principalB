Public Class tipoDocumento
    Dim fun As New Funciones
    Dim strTag As String = 0
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not txtNombre.Text.Equals("") AndAlso Not txtab.Text.Equals("") Then
            Dim cad As String = "INSERT INTO documento (no,ab)VALUES('" & txtNombre.Text & "','" & txtab.Text & "')"
            If fun.registreDatos(cad) Then
                MessageBox.Show("Documento Guardado", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                limpiar()
            End If
        Else
                MessageBox.Show("Debe Alimentar los Campos", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Not txtNombre.Text.Equals("") AndAlso Not txtab.Text.Equals("") Then
            Dim cad As String = "DELETE FROM documento  WHERE id ='" & strTag & "'"
            If fun.registreDatos(cad) Then
                MessageBox.Show("Documento Eliminado", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                limpiar()
            End If
        Else
            MessageBox.Show("Debe Alimentar los Campos", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub limpiar()
        txtNombre.Text = ""
        txtab.Text = ""
        fun.mostrarTipoDocumento(lstDocumentos)
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        txtNombre.Focus()
        strTag = 0
    End Sub

    Private Sub lstDocumentos_MouseClick(sender As Object, e As MouseEventArgs) Handles lstDocumentos.MouseClick
        If lstDocumentos.SelectedItems.Count = 0 Then Exit Sub
        strTag = lstDocumentos.SelectedItems(0).Tag
        txtNombre.Text = lstDocumentos.SelectedItems(0).Text
        txtab.Text = lstDocumentos.SelectedItems(0).SubItems(1).Text

        btnModificar.Enabled = True
        btnGuardar.Enabled = False
        txtNombre.Focus()
    End Sub

    Private Sub tipoDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnModificar.Enabled = False
        fun.mostrarTipoDocumento(lstDocumentos)
        txtNombre.Focus()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If Not txtNombre.Text.Equals("") AndAlso Not txtab.Text.Equals("") Then
            Dim cad As String = "UPDATE documento set no='" & txtNombre.Text & "',ab='" & txtab.Text & "' WHERE id ='" & strTag & "'"
            If fun.registreDatos(cad) Then
                MessageBox.Show("Documento Actualizado", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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