Imports MySql.Data.MySqlClient

Public Class Funciones
    Dim gestor1 As New Soltec.Gestor
    Public conexion As New MySqlConnection
    Public Sub ponerFoto(logo As String, picFoto As PictureBox)
        If My.Computer.FileSystem.FileExists(logo) Then
            Dim Imagen As New Bitmap(Principal.logo)
            picFoto.Image = Imagen

        End If
    End Sub

    Public Function registreDatos(consulta As String) As Boolean
        Dim booRegistrado As Boolean = False
        Try
            Dim conectar As New MySqlConnection(Principal.cadenadeconexion)
            Dim cmd As New MySqlCommand(consulta, conectar)
            cmd.CommandText = consulta
            conectar.Open()
            If cmd.ExecuteNonQuery() = 1 Then
                booRegistrado = True
            End If
            conectar.Close()
            conectar.Dispose()
        Catch ex As Exception
            booRegistrado = False
            MessageBox.Show("Error al Registrar " & vbCrLf & ex.Message, "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return booRegistrado
    End Function
    Public Sub mostrarTasas(lstTarifas As ListView)
        Dim arlCoincidencias = gestor1.DatosDeConsulta("SELECT id,valor,left(fecha,10) as fecha FROM tasadecambio order by id desc limit 30", , Principal.cadenadeconexion)
        If Not arlCoincidencias.Count = 0 Then lstTarifas.Visible = True
        lstTarifas.Items.Clear()
        lstTarifas.BeginUpdate()
        For Each Encontrado As ArrayList In arlCoincidencias
            Dim lviEncontrado As New ListViewItem
            lviEncontrado.Tag = Encontrado(0)
            lviEncontrado.Text = Encontrado(0)
            lviEncontrado.SubItems.Add(Encontrado(1))
            lviEncontrado.SubItems.Add(Encontrado(2))
            lstTarifas.Items.Add(lviEncontrado)
        Next
        lstTarifas.EndUpdate()

    End Sub

    Public Sub mostrarTipoDocumento(lstTarifas As ListView)
        Dim arlCoincidencias = gestor1.DatosDeConsulta("SELECT id,no,ab FROM documento order by id limit 30", , Principal.cadenadeconexion)
        If Not arlCoincidencias.Count = 0 Then lstTarifas.Visible = True
        lstTarifas.Items.Clear()
        lstTarifas.BeginUpdate()
        For Each Encontrado As ArrayList In arlCoincidencias
            Dim lviEncontrado As New ListViewItem
            lviEncontrado.Tag = Encontrado(0)
            lviEncontrado.Text = Encontrado(1)
            lviEncontrado.SubItems.Add(Encontrado(2))
            lstTarifas.Items.Add(lviEncontrado)
        Next
        lstTarifas.EndUpdate()

    End Sub
    Public Sub mostrarTipoAlmacenamiento(lstTarifas As ListView)

        Dim arlCoincidencias = gestor1.DatosDeConsulta("SELECT id,no,ab FROM tipoalmacenamiento order by id limit 30", , Principal.cadenadeconexion)
        If Not arlCoincidencias.Count = 0 Then lstTarifas.Visible = True
        lstTarifas.Items.Clear()
        lstTarifas.BeginUpdate()
        For Each Encontrado As ArrayList In arlCoincidencias
            Dim lviEncontrado As New ListViewItem
            lviEncontrado.Tag = Encontrado(0)
            lviEncontrado.Text = Encontrado(1)
            lviEncontrado.SubItems.Add(Encontrado(2))
            lstTarifas.Items.Add(lviEncontrado)
        Next
        lstTarifas.EndUpdate()
    End Sub

    Public Sub mostrarEmbalaje(lstTarifas As ListView)

        Dim arlCoincidencias = gestor1.DatosDeConsulta("SELECT id,no,ab FROM embalaje order by id limit 30", , Principal.cadenadeconexion)
        If Not arlCoincidencias.Count = 0 Then lstTarifas.Visible = True
        lstTarifas.Items.Clear()
        lstTarifas.BeginUpdate()
        For Each Encontrado As ArrayList In arlCoincidencias
            Dim lviEncontrado As New ListViewItem
            lviEncontrado.Tag = Encontrado(0)
            lviEncontrado.Text = Encontrado(1)
            lviEncontrado.SubItems.Add(Encontrado(2))
            lstTarifas.Items.Add(lviEncontrado)
        Next
        lstTarifas.EndUpdate()
    End Sub
    Public Function saberingreso(nit As String, Optional tabla As String = "cliente") As Boolean
        Dim boosaber As Boolean = False
        Try
            conexion.ConnectionString = Principal.cadenadeconexion
            conexion.Open()
            Dim cadena As String
            cadena = "SELECT id FROM " & tabla & " WHERE nit='" & nit & "'"
            Dim cmd As New MySqlCommand(cadena, conexion)
            Using leerdato As MySqlDataReader = cmd.ExecuteReader()
                While leerdato.Read()
                    boosaber = True
                End While
            End Using
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return boosaber

    End Function

    Public Function ExtraerConsecutvo(idTipoDocumento As Integer) As String
        Dim strConsecutivo As String = "1"
        Try
            conexion.ConnectionString = Principal.cadenadeconexion
            conexion.Open()
            Dim cadena As String
            cadena = "SELECT IFNULL(id,0)+1 as numero FROM remisiones WHERE iddocumento='" & idTipoDocumento & "'"
            Dim cmd As New MySqlCommand(cadena, conexion)
            Using leerdato As MySqlDataReader = cmd.ExecuteReader()
                While leerdato.Read()
                    strConsecutivo = leerdato("numero")
                End While
            End Using

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return strConsecutivo

    End Function

    Public Function extraerNitById(idTercero As String, campo As String) As String
        Dim strNit As String = "1"
        Try
            conexion.ConnectionString = Principal.cadenadeconexion
            conexion.Open()
            Dim cadena As String
            cadena = "SELECT  " & campo & " FROM cliente WHERE id='" & idTercero & "'"
            Dim cmd As New MySqlCommand(cadena, conexion)
            Using leerdato As MySqlDataReader = cmd.ExecuteReader()
                While leerdato.Read()
                    strNit = leerdato(campo)
                End While
            End Using

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return strNit

    End Function

    Public Function extraerAB(id As String, tabla As String) As String
        Dim strAb As String = "1"
        Try
            conexion.ConnectionString = Principal.cadenadeconexion
            conexion.Open()
            Dim cadena As String
            cadena = "SELECT  UPPER('ab')  as ab FROM " & tabla & " WHERE id='" & id & "'"
            Dim cmd As New MySqlCommand(cadena, conexion)
            Using leerdato As MySqlDataReader = cmd.ExecuteReader()
                While leerdato.Read()
                    strAb = leerdato("ab")
                End While
            End Using

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return strAb

    End Function

    Public Function extraerTasa() As String
        Dim strTasa As String = "1"
        Try
            conexion.ConnectionString = Principal.cadenadeconexion
            conexion.Open()
            Dim cadena As String
            cadena = "SELECT  valor FROM tasadecambio order by id desc limit 1"
            Dim cmd As New MySqlCommand(cadena, conexion)
            Using leerdato As MySqlDataReader = cmd.ExecuteReader()
                While leerdato.Read()
                    strTasa = leerdato("valor")
                End While
            End Using

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return strTasa

    End Function

    Public Function Alimentar(txtNit As TextBox, nit As String, nom As TextBox, telefono As TextBox, direccion As TextBox, email As TextBox, ByRef intmodificado As Integer, tipoBusqueda As Integer) As Boolean
        Dim booClienteEncontrado As Boolean = False
        Try
            conexion.ConnectionString = Principal.cadenadeconexion
            conexion.Open()
            Dim cadena As String = ""
            Select Case tipoBusqueda
                Case 1
                    cadena = "SELECT id,nit,no,ifnull(telefono,'NADA') AS TELEFONO,ifnull(direccion,'') as direccion, correo,fechaingreso FROM cliente WHERE nit='" & nit & "'"
                Case 2
                    cadena = "SELECT id,nit,no,ifnull(telefono,'NADA') AS TELEFONO,ifnull(direccion,'') as direccion, correo,fechaingreso FROM cliente WHERE id='" & nit & "'"
            End Select
            Dim cmd As New MySqlCommand(cadena, conexion)
            Using leerdato As MySqlDataReader = cmd.ExecuteReader()
                While leerdato.Read()
                    txtNit.Text = leerdato.GetString("nit")
                    nom.Text = leerdato.GetString("no")
                    intmodificado = leerdato.GetInt32("id")
                    telefono.Text = leerdato.GetString("telefono")
                    direccion.Text = leerdato.GetString("direccion")
                    email.Text = leerdato.GetString("correo")
                    booClienteEncontrado = True
                End While
            End Using
            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return booClienteEncontrado
    End Function


End Class
