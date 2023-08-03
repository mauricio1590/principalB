Public Class Tasadecambio
    Dim fun As New Funciones
    Dim strtag As String = 0
    Private Sub Tasadecambio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnModificar.Enabled = False
        fun.mostrarTasas(lstTarifas)
    End Sub

    Private Sub txtguardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not txtValor.Text.ToString.Equals("") Then
            Dim cadena As String = "INSERT INTO tasadecambio (valor)values(" & txtValor.Text & ")"
            If fun.registreDatos(cadena) Then
                MessageBox.Show("Tasa Registrada", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                limpiar()
            End If
        Else
            MessageBox.Show("Ingrese un Valor", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub limpiar()
        txtValor.Text = ""
        fun.mostrarTasas(lstTarifas)
        btnGuardar.Enabled = True
        btnModificar.Enabled = False

        strtag = 0
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub lstTarifas_MouseClick(sender As Object, e As MouseEventArgs) Handles lstTarifas.MouseClick
        If lstTarifas.SelectedItems.Count = 0 Then Exit Sub
        strtag = lstTarifas.SelectedItems(0).Tag
        txtValor.Text = lstTarifas.SelectedItems(0).SubItems(1).Text

        btnModificar.Enabled = True
        btnGuardar.Enabled = False
        txtValor.Focus()
    End Sub

    Private Sub txtModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If Not txtValor.Text.ToString.Equals("") Then
            Dim cadena As String = "UPDATE tasadecambio set valor=" & txtValor.Text & " WHERE id=" & strtag & ""
            If fun.registreDatos(cadena) Then
                MessageBox.Show("Tasa Actualizada", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                limpiar()
            End If
        Else
            MessageBox.Show("Ingrese un Valor", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub txtEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Not txtValor.Text.ToString.Equals("") Then
            Dim cadena As String = "DELETE FROM tasadecambio WHERE id=" & strtag & ""
            If fun.registreDatos(cadena) Then
                MessageBox.Show("Tasa Eliminada", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                limpiar()
            End If
        Else
            MessageBox.Show("Seleccione un registro para eliminar", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If btnGuardar.Enabled Then
                btnGuardar.PerformClick()
            Else : btnModificar.PerformClick()
            End If
        End If
    End Sub
End Class