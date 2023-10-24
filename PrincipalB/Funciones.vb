Imports MySql.Data.MySqlClient

Public Class Funciones
    Dim gestor1 As New Soltec.Gestor
    Public bytDecimales As Byte = 0
    Public conexion As New MySqlConnection
    Public Sub ponerFoto(logo As String, picFoto As PictureBox)
        If My.Computer.FileSystem.FileExists(logo) Then
            Dim Imagen As New Bitmap(Principal.logo)
            picFoto.Image = Imagen

        End If
    End Sub

    Public Sub cambiarEstadoRemision(estado As String, idremision As Integer)
        Dim strCadena As String = "UPDATE remisiones set estado='" & estado & "',fechasalida=current_date where id='" & idremision & "'"
        Try
            registreDatos(strCadena)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function CantidadsalienteItem(iditem As Integer) As Integer
        Dim total As Integer = 0
        Try
            conexion.ConnectionString = Principal.cadenadeconexion
            conexion.Open()
            Dim cadena As String
            cadena = "SELECT  ifnull(sum(cantidad),0) as cantidad FROM salidas WHERE iditem='" & iditem & "'"
            Dim cmd As New MySqlCommand(cadena, conexion)
            Using leerdato As MySqlDataReader = cmd.ExecuteReader()
                While leerdato.Read()
                    total = leerdato("cantidad")
                End While
            End Using

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return total
    End Function

    Public Function estadoRemision(idformularioIngreso As String) As Boolean
        Dim estado As Boolean = False
        Try
            conexion.ConnectionString = Principal.cadenadeconexion
            conexion.Open()
            Dim cadena As String
            cadena = "SELECT  estado FROM remisiones WHERE idformularioingreso='" & idformularioIngreso & "'"
            Dim cmd As New MySqlCommand(cadena, conexion)
            Using leerdato As MySqlDataReader = cmd.ExecuteReader()
                While leerdato.Read()
                    If leerdato("estado") = "terminado" Then
                        estado = True
                    End If
                End While
            End Using

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return estado
    End Function
    Public Function extraerIdremision(iditem As Integer) As Integer
        Dim idremision As Integer = 0
        Try
            conexion.ConnectionString = Principal.cadenadeconexion
            conexion.Open()
            Dim cadena As String
            cadena = "SELECT  idremision FROM item WHERE id='" & iditem & "'"
            Dim cmd As New MySqlCommand(cadena, conexion)
            Using leerdato As MySqlDataReader = cmd.ExecuteReader()
                While leerdato.Read()
                    idremision = leerdato("idremision")
                End While
            End Using

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return idremision
    End Function
    Public Function extraerFormularioIngreso(idremision As Integer) As String
        Dim strFormulario As String = "0"
        Try
            conexion.ConnectionString = Principal.cadenadeconexion
            conexion.Open()
            Dim cadena As String
            cadena = "SELECT  idformularioingreso FROM remisiones WHERE id='" & idremision & "'"
            Dim cmd As New MySqlCommand(cadena, conexion)
            Using leerdato As MySqlDataReader = cmd.ExecuteReader()
                While leerdato.Read()
                    strFormulario = leerdato("idformularioingreso")
                End While
            End Using

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return strFormulario
    End Function
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
        Dim arlCoincidencias = gestor1.DatosDeConsulta("Select id, valor, Left(fecha, 10) As fecha FROM tasadecambio order by id desc limit 30", , Principal.cadenadeconexion)
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
        Dim arlCoincidencias = gestor1.DatosDeConsulta("Select id, no, ab FROM documento order by id limit 30", , Principal.cadenadeconexion)
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

        Dim arlCoincidencias = gestor1.DatosDeConsulta("Select id, no, ab FROM tipoalmacenamiento order by id limit 30", , Principal.cadenadeconexion)
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
    Function elimineItemdeBase(idItem As Integer)
        Try
            registreDatos("DELETE FROM item WHERE id=" & idItem & "")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return True
    End Function
    Public Sub mostrarEmbalaje(lstTarifas As ListView)

        Dim arlCoincidencias = gestor1.DatosDeConsulta("Select id, no, ab FROM embalaje order by id limit 30", , Principal.cadenadeconexion)
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
    Public Function ExtraerConsecutvo(intIdDocumento As Integer, intConsecutivo As Integer) As String
        Dim intId As Integer = 0
        Try
            conexion.ConnectionString = Principal.cadenadeconexion
            conexion.Open()
            Dim cadena As String
            cadena = "SELECT id  FROM remisiones WHERE iddocumento='" & intIdDocumento & "' AND consecutivodocumento=" & intConsecutivo & ""
            Dim cmd As New MySqlCommand(cadena, conexion)
            Using leerdato As MySqlDataReader = cmd.ExecuteReader()
                While leerdato.Read()
                    intId = leerdato("id")
                End While
            End Using

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return intId
    End Function
    Public Function ExtraerConsecutvo(idTipoDocumento As Integer) As String
        Dim strConsecutivo As String = "1"
        Try
            conexion.ConnectionString = Principal.cadenadeconexion
            conexion.Open()
            Dim cadena As String
            cadena = "SELECT IFNULL(consecutivodocumento,0)+1 as numero FROM remisiones WHERE iddocumento='" & idTipoDocumento & "' order by id desc limit 1"
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
            cadena = "SELECT  UPPER(ab)  as ab FROM " & tabla & " WHERE id='" & id & "'"
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
    ''''''''''''''''''''''''''''''INICIO DE INFORMES 

    Public Sub buscarDatos(lstreporte As ListView, idreporte As Integer, fdesde As Date, fhasta As Date, totales As TextBox, Optional ByVal estado As String = "pendiente")
        Dim Consulta As String = ""
        Dim ColumnasEsNumero() As Boolean = Nothing
        Dim ColumnasJustificaciones() As Integer = Nothing
        Dim FilasEtiquetas() As Integer = Nothing
        Dim ColumnasAmplitudes() As Integer = Nothing
        Dim booPromediar As Boolean = True
        Dim total As Integer = 0

        Select Case idreporte
            Case 1   '' INFORME DE REMISIONES 

                Consulta = "SELECT re.id,CONCAT(do.ab,'-',re.consecutivodocumento,'(',it.item,')') AS proceso,cl.no AS Cliente,CONCAT(re.idformularioingreso,'-',em.no,' N.',it.cantidad) AS 'Formulario Ingreso',tp.no as Almacenamiento,
                             LEFT(re.fechaingreso,10) AS 'Fecha Ingreso',
                            IFNULL((SELECT GROUP_CONCAT( sal.idformulariosalida ,'-', sal.cantidad,'-',sal.fechasalida) AS 'idformulariosalida'
                            from salidas sal where sal.idformularioingreso=re.idformularioingreso),'Sin SALIDAS') AS 'Formulario Salida',
                            re.estado,re.fechasalida AS 'Fecha Salida',re.placas,
                           IFNULL(CASE (it.cantidad-(SELECT sum(sal.cantidad)  from salidas sal where sal.idformularioingreso=re.idformularioingreso)) 
                            WHEN 0 THEN (it.cantidad-(SELECT sum(sal.cantidad)  from salidas sal where sal.idformularioingreso=re.idformularioingreso)) 
                            ELSE  CONCAT('SALDO',' ',em.no,' ',(it.cantidad-(SELECT sum(sal.cantidad)  from salidas sal where sal.idformularioingreso=re.idformularioingreso)))
                            END,it.cantidad)
                            AS 'Saldo de Bultos'
                            FROM cliente cl,remisiones re,embalaje em,
                            (SELECT ite.idremision,ite.id,GROUP_CONCAT(ite.item) AS item ,sum(ite.cantidad) AS cantidad
                            FROM remisiones rem,item ite
                            WHERE rem.id=ite.idremision  GROUP by ite.idremision ) AS it,documento AS do,tipoalmacenamiento as tp
                            WHERE cl.id=re.idcliente
                            AND re.idembalaje=em.id
                            AND re.id=it.idremision
                            AND re.iddocumento=do.id
                            AND re.idalmacenamiento = tp.id
                            AND re.idembalaje=em.id
                            AND re.fechaingreso >= STR_TO_DATE('" & fdesde & "','%d/%m/%Y') AND re.fechaingreso <=  STR_TO_DATE('" & fhasta & "','%d/%m/%Y') 
                            "

                FilasEtiquetas = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
                ColumnasEsNumero = {True, False, False, False, False, False, False, False, False, False, False}
                ColumnasJustificaciones = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
                ColumnasAmplitudes = {80, 200, 200, 200, 200, 80, 80, 80, 80, 80, 80}
                Dim arlDatos1 As ArrayList = gestor1.DatosDeConsulta(Consulta, True, Principal.cadenadeconexion)
                Dim douSaldoEx As Double = 0
                booPromediar = False
                reporteListview(lstreporte, arlDatos1, True, FilasEtiquetas, True, ColumnasAmplitudes, ColumnasJustificaciones, ColumnasEsNumero, True, booPromediar)
                Exit Sub

            Case 2   '' INFORME DE REMISIONES DISCRIMINADAS POR ESTADO 
                Consulta = "SELECT re.id,CONCAT(do.ab,'-',re.consecutivodocumento,'(',it.item,')') AS proceso,cl.no AS Cliente,CONCAT(re.idformularioingreso,'-',em.no,' N.',it.cantidad) AS 'Formulario Ingreso',tp.no as Almacenamiento,
                             LEFT(re.fechaingreso,10) AS 'Fecha Ingreso',
                            IFNULL((SELECT GROUP_CONCAT( sal.idformulariosalida ,'-', sal.cantidad,'-',sal.fechasalida) AS 'idformulariosalida'
                            from salidas sal where sal.idformularioingreso=re.idformularioingreso),'Sin SALIDAS') AS 'Formulario Salida',
                            re.estado,re.fechasalida AS 'Fecha Salida',re.placas,
                           IFNULL(CASE (it.cantidad-(SELECT sum(sal.cantidad)  from salidas sal where sal.idformularioingreso=re.idformularioingreso)) 
                            WHEN 0 THEN (it.cantidad-(SELECT sum(sal.cantidad)  from salidas sal where sal.idformularioingreso=re.idformularioingreso)) 
                            ELSE  CONCAT('SALDO',' ',em.no,' ',(it.cantidad-(SELECT sum(sal.cantidad)  from salidas sal where sal.idformularioingreso=re.idformularioingreso)))
                            END,it.cantidad)
                            AS 'Saldo de Bultos'
                            FROM cliente cl,remisiones re,embalaje em,
                            (SELECT ite.idremision,ite.id,GROUP_CONCAT(ite.item) AS item ,sum(ite.cantidad) AS cantidad
                            FROM remisiones rem,item ite
                            WHERE rem.id=ite.idremision  GROUP by ite.idremision ) AS it,documento AS do,tipoalmacenamiento as tp
                            WHERE cl.id=re.idcliente
                            AND re.idembalaje=em.id
                            AND re.id=it.idremision
                            AND re.iddocumento=do.id
                            AND re.idalmacenamiento = tp.id
                            AND re.idembalaje=em.id
                            AND re.fechaingreso >= STR_TO_DATE('" & fdesde & "','%d/%m/%Y') AND re.fechaingreso <=  STR_TO_DATE('" & fhasta & "','%d/%m/%Y') 
                            AND re.estado='pendiente'                          "

                FilasEtiquetas = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
                ColumnasEsNumero = {True, False, False, False, False, False, False, False, False, False, False}
                ColumnasJustificaciones = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
                ColumnasAmplitudes = {80, 200, 200, 200, 200, 80, 80, 80, 80, 80, 80}
                Dim arlDatos1 As ArrayList = gestor1.DatosDeConsulta(Consulta, True, Principal.cadenadeconexion)
                Dim douSaldoEx As Double = 0
                booPromediar = False
                reporteListview(lstreporte, arlDatos1, True, FilasEtiquetas, True, ColumnasAmplitudes, ColumnasJustificaciones, ColumnasEsNumero, True, booPromediar)
                Exit Sub
            Case 3  '' INFORME DE REMISIONES DISCRIMINADAS POR ESTADO 

                Consulta = "SELECT re.id,CONCAT(do.ab,'-',re.consecutivodocumento,'(',it.item,')') AS proceso,cl.no AS Cliente,CONCAT(re.idformularioingreso,'-',em.no,' N.',it.cantidad) AS 'Formulario Ingreso',tp.no as Almacenamiento,
                             LEFT(re.fechaingreso,10) AS 'Fecha Ingreso',
                            IFNULL((SELECT GROUP_CONCAT( sal.idformulariosalida ,'-', sal.cantidad,'-',sal.fechasalida) AS 'idformulariosalida'
                            from salidas sal where sal.idformularioingreso=re.idformularioingreso),'Sin SALIDAS') AS 'Formulario Salida',
                            re.estado,re.fechasalida AS 'Fecha Salida',re.placas,
                           IFNULL(CASE (it.cantidad-(SELECT sum(sal.cantidad)  from salidas sal where sal.idformularioingreso=re.idformularioingreso)) 
                            WHEN 0 THEN (it.cantidad-(SELECT sum(sal.cantidad)  from salidas sal where sal.idformularioingreso=re.idformularioingreso)) 
                            ELSE  CONCAT('SALDO',' ',em.no,' ',(it.cantidad-(SELECT sum(sal.cantidad)  from salidas sal where sal.idformularioingreso=re.idformularioingreso)))
                            END,it.cantidad)
                            AS 'Saldo de Bultos'
                            FROM cliente cl,remisiones re,embalaje em,
                            (SELECT ite.idremision,ite.id,GROUP_CONCAT(ite.item) AS item ,sum(ite.cantidad) AS cantidad
                            FROM remisiones rem,item ite
                            WHERE rem.id=ite.idremision  GROUP by ite.idremision ) AS it,documento AS do,tipoalmacenamiento as tp
                            WHERE cl.id=re.idcliente
                            AND re.idembalaje=em.id
                            AND re.id=it.idremision
                            AND re.iddocumento=do.id
                            AND re.idalmacenamiento = tp.id
                            AND re.idembalaje=em.id
                            AND re.fechaingreso >= STR_TO_DATE('" & fdesde & "','%d/%m/%Y') AND re.fechaingreso <=  STR_TO_DATE('" & fhasta & "','%d/%m/%Y') 
                            AND re.estado='terminado'                          "

                FilasEtiquetas = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
                ColumnasEsNumero = {True, False, False, False, False, False, False, False, False, False, False}
                ColumnasJustificaciones = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
                ColumnasAmplitudes = {80, 200, 200, 200, 200, 80, 80, 80, 80, 80, 80}
                Dim arlDatos1 As ArrayList = gestor1.DatosDeConsulta(Consulta, True, Principal.cadenadeconexion)
                Dim douSaldoEx As Double = 0
                booPromediar = False
                reporteListview(lstreporte, arlDatos1, True, FilasEtiquetas, True, ColumnasAmplitudes, ColumnasJustificaciones, ColumnasEsNumero, True, booPromediar)
                Exit Sub
            Case 4   '' INFORME DE REMISIONES facturadas

                Consulta = "SELECT re.id,CONCAT(do.ab,'-',re.consecutivodocumento,'(',it.item,')') AS proceso,cl.no AS Cliente,CONCAT(re.idformularioingreso,'-',em.no,' N.',it.cantidad) AS 'Formulario Ingreso',tp.no as Almacenamiento,
                             LEFT(re.fechaingreso,10) AS 'Fecha Ingreso',
                            IFNULL((SELECT GROUP_CONCAT( sal.idformulariosalida ,'-', sal.cantidad,'-',sal.fechasalida) AS 'idformulariosalida'
                            from salidas sal where sal.idformularioingreso=re.idformularioingreso),'Sin SALIDAS') AS 'Formulario Salida',
                            re.estado,re.fechasalida AS 'Fecha Salida',re.placas,
                           IFNULL(CASE (it.cantidad-(SELECT sum(sal.cantidad)  from salidas sal where sal.idformularioingreso=re.idformularioingreso)) 
                            WHEN 0 THEN (it.cantidad-(SELECT sum(sal.cantidad)  from salidas sal where sal.idformularioingreso=re.idformularioingreso)) 
                            ELSE  CONCAT('SALDO',' ',em.no,' ',(it.cantidad-(SELECT sum(sal.cantidad)  from salidas sal where sal.idformularioingreso=re.idformularioingreso)))
                            END,it.cantidad)
                            AS 'Saldo de Bultos',
                            CASE re.facturado
                            WHEN 1 THEN 'Pendiente'
                            WHEN 2 THEN 'Facturado'
                            END AS ESTADO,
                            IFNULL((SELECT GROUP_CONCAT( fac.fdesde ,' Hasta ', fac.fdesde,' ', fac.obs ,'\t') AS 'Facturacion'
                            from facturacion fac where fac.idformularioingreso=re.idformularioingreso),'SIN FACTURACION') AS 'Facturacion'
                            FROM cliente cl,remisiones re,embalaje em,
                            (SELECT ite.idremision,ite.id,GROUP_CONCAT(ite.item) AS item ,sum(ite.cantidad) AS cantidad
                            FROM remisiones rem,item ite
                            WHERE rem.id=ite.idremision  GROUP by ite.idremision ) AS it,documento AS do,tipoalmacenamiento as tp
                            WHERE cl.id=re.idcliente
                            AND re.idembalaje=em.id
                            AND re.id=it.idremision
                            AND re.iddocumento=do.id
                            AND re.idalmacenamiento = tp.id
                            AND re.idembalaje=em.id
                            AND re.fechaingreso >= STR_TO_DATE('" & fdesde & "','%d/%m/%Y') AND re.fechaingreso <=  STR_TO_DATE('" & fhasta & "','%d/%m/%Y') 
                            "

                FilasEtiquetas = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}
                ColumnasEsNumero = {True, False, False, False, False, False, False, False, False, False, False, False, False}
                ColumnasJustificaciones = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
                ColumnasAmplitudes = {80, 200, 200, 200, 200, 80, 80, 80, 80, 80, 80, 80, 100}
                Dim arlDatos1 As ArrayList = gestor1.DatosDeConsulta(Consulta, True, Principal.cadenadeconexion)
                Dim douSaldoEx As Double = 0
                booPromediar = False
                reporteListview(lstreporte, arlDatos1, True, FilasEtiquetas, True, ColumnasAmplitudes, ColumnasJustificaciones, ColumnasEsNumero, True, booPromediar)
                Exit Sub
            Case 100
                Consulta = "SELECT re.id,CONCAT(do.ab,'-',re.consecutivodocumento,'(',it.item,')') AS proceso,cl.no AS Cliente,CONCAT(re.idformularioingreso,'-',em.no,' N.',it.cantidad) AS 'Formulario Ingreso',tp.no as Almacenamiento,
                             LEFT(re.fechaingreso,10) AS 'Fecha Ingreso',
                            IFNULL((SELECT GROUP_CONCAT( sal.idformulariosalida ,'-', sal.cantidad,'-',sal.fechasalida) AS 'idformulariosalida'
                            from salidas sal where sal.idformularioingreso=re.idformularioingreso),'Sin SALIDAS') AS 'Formulario Salida',
                            re.estado,re.fechasalida AS 'Fecha Salida',re.placas,
                           IFNULL(CASE (it.cantidad-(SELECT sum(sal.cantidad)  from salidas sal where sal.idformularioingreso=re.idformularioingreso)) 
                            WHEN 0 THEN (it.cantidad-(SELECT sum(sal.cantidad)  from salidas sal where sal.idformularioingreso=re.idformularioingreso)) 
                            ELSE  CONCAT('SALDO',' ',em.no,' ',(it.cantidad-(SELECT sum(sal.cantidad)  from salidas sal where sal.idformularioingreso=re.idformularioingreso)))
                            END,it.cantidad)
                            AS 'Saldo de Bultos'
                            FROM cliente cl,remisiones re,embalaje em,
                            (SELECT ite.idremision,ite.id,GROUP_CONCAT(ite.item) AS item ,sum(ite.cantidad) AS cantidad
                            FROM remisiones rem,item ite
                            WHERE rem.id=ite.idremision  GROUP by ite.idremision ) AS it,documento AS do,tipoalmacenamiento as tp
                            WHERE cl.id=re.idcliente
                            AND re.idembalaje=em.id
                            AND re.id=it.idremision
                            AND re.iddocumento=do.id
                            AND re.idalmacenamiento = tp.id
                            AND re.idembalaje=em.id
                            AND re.fechaingreso >= STR_TO_DATE('" & fdesde & "','%d/%m/%Y') AND re.fechaingreso <=  STR_TO_DATE('" & fhasta & "','%d/%m/%Y') 
                            "

                FilasEtiquetas = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
                ColumnasEsNumero = {True, False, False, False, False, False, False, False, False, False, False}
                ColumnasJustificaciones = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
                ColumnasAmplitudes = {80, 200, 200, 200, 200, 80, 80, 80, 80, 80, 80}
                Dim arlDatos1 As ArrayList = gestor1.DatosDeConsulta(Consulta, True, Principal.cadenadeconexion)
                Dim douSaldoEx As Double = 0
                booPromediar = False
                reporteListview(lstreporte, arlDatos1, True, FilasEtiquetas, True, ColumnasAmplitudes, ColumnasJustificaciones, ColumnasEsNumero, True, booPromediar)
                Exit Sub

        End Select
    End Sub

    Public Sub reporteListview(Lista As ListView, arl As ArrayList, Optional EncabezadosIncluidos As Boolean = False, Optional FilasEtiquetas() As Integer = Nothing, Optional AutoFit As Boolean = False, Optional ColumnasAmplitudes() As Integer = Nothing, Optional ColumnasJustificaciones() As Integer = Nothing, Optional ColumnasEsNumero() As Boolean = Nothing, Optional Totalizar As Boolean = False, Optional Promediar As Boolean = False)

        Lista.BeginUpdate()
        Lista.Items.Clear()
        Lista.Columns.Clear()
        Lista.Groups.Clear()
        Dim arlTotales As New ArrayList
        Dim arlPromedios As New ArrayList
        For i As Integer = 0 To arl.Count - 1
            Dim booCreeFila As Boolean = True
            If i = 0 Then
                If EncabezadosIncluidos Then booCreeFila = False
                For l As Integer = 0 To arl(0).Count - 1
                    arlTotales.Add(0)
                    arlPromedios.Add(0)
                Next
            End If
            If booCreeFila Then
                Dim Fila As New ListViewItem
                If Not IsNothing(FilasEtiquetas) Then
                    Dim strEtiqueta As String = arl(i)(FilasEtiquetas(0))
                    For n As Integer = 1 To FilasEtiquetas.Count - 1
                        strEtiqueta += "|" & arl(i)(FilasEtiquetas(n))
                    Next
                    Fila.Tag = strEtiqueta
                End If
                Dim arlFila As ArrayList = arl(i)
                For k = 0 To arlFila.Count - 1
                    If Not IsNothing(ColumnasEsNumero) Then
                        If ColumnasEsNumero(k) Then
                            Dim douValor As Double = ProceseValor(arlFila(k).ToString)
                            If Totalizar Then arlTotales(k) += douValor
                            arlFila(k) = FormatNumber(douValor, bytDecimales)
                        End If
                    End If
                    If k = 0 Then
                        Fila.Text = arlFila(k)
                    Else
                        Fila.SubItems.Add(arlFila(k).ToString)
                    End If
                Next
                Lista.Items.Add(Fila)
            End If
        Next
        If Not arl.Count = 0 Then
            If Totalizar Then
                Dim lviTotales As New ListViewItem
                lviTotales.Text = "Totales (" & Lista.Items.Count & ")"
                For s As Integer = 1 To arl(0).Count - 1
                    lviTotales.SubItems.Add("")
                    If Not IsNothing(ColumnasEsNumero) Then
                        If ColumnasEsNumero(s) Then lviTotales.SubItems(s).Text = FormatNumber(arlTotales(s), bytDecimales)
                    End If
                Next
                Lista.Items.Add(lviTotales)
            End If
            If Promediar Then
                Dim lviPromedios As New ListViewItem
                lviPromedios.Text = "Promedios"
                For s As Integer = 1 To arl(0).Count - 1
                    lviPromedios.SubItems.Add("")
                    If Not IsNothing(ColumnasEsNumero) Then
                        If ColumnasEsNumero(s) Then lviPromedios.SubItems(s).Text = FormatNumber(arlTotales(s) / (Lista.Items.Count - 1), bytDecimales)
                    End If
                Next
                Lista.Items.Add(lviPromedios)
            End If
        End If
        If Not Lista.Items.Count = 0 Then
            Lista.Items(Lista.Items.Count - 1).Selected = True
            Lista.Items(Lista.Items.Count - 1).EnsureVisible()
        End If
        If Not arl.Count = 0 Then
            Dim CuentaColumnas As ArrayList = arl(0)
            For j = 0 To CuentaColumnas.Count - 1
                Lista.Columns.Add(CuentaColumnas(j).ToString, 120)
                If Not IsNothing(ColumnasAmplitudes) Then
                    If Not IsNothing(ColumnasAmplitudes) Then Lista.Columns(j).Width = ColumnasAmplitudes(j)
                Else
                    Lista.Columns(j).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
                End If
                If Not IsNothing(ColumnasJustificaciones) Then Lista.Columns(j).TextAlign = ColumnasJustificaciones(j)
            Next
        End If
        Lista.EndUpdate()
    End Sub
    Public Function ProceseValor(strValor As String) As Double
        If IsNothing(strValor) Then Return 0
        If Not IsNumeric(strValor) Then Return 0
        Dim ii As Byte
        For ii = 1 To Len(strValor)
            If Mid(strValor, ii, 1) = "," Then Mid(strValor, ii, 1) = "."
        Next
        Return Val(strValor)
    End Function

    Public Function validarContraseña(texto As String, Optional nivel As Integer = 1) As Boolean
        Dim boosaber As Boolean = False
        Dim arlCoincidencias As ArrayList

        If nivel = 1 Then
            Dim strcadena As String = "SELECT usuario,nivel,id FROM usuarios WHERE  contraseña= '" & texto & "' "
            arlCoincidencias = gestor1.DatosDeConsulta(strcadena, , Principal.cadenadeconexion)
        Else
            arlCoincidencias = gestor1.DatosDeConsulta("SELECT usuario,nivel,id FROM usuarios WHERE nivel='" & nivel & "' AND contraseña= '" & texto & "' ", , Principal.cadenadeconexion)
        End If

        If Not arlCoincidencias.Count = 0 Then

            Principal.intidNivelUsuario = arlCoincidencias(0)(1)
            Principal.strUsuario = arlCoincidencias(0)(0)
            Principal.intIdUsuario = arlCoincidencias(0)(2)
            boosaber = True
        End If
        Return boosaber
    End Function

End Class
