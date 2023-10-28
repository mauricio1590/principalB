Public Class facturacion
    Dim gestor1 As New Soltec.Gestor
    Dim intTipoDocumento As Integer = 0
    Dim arraItems As New ArrayList
    Dim fun As New Funciones
    Dim strUnidad As String = "D"
    Dim rutaImagen As String

    Private Sub BuscarPorIdDeLaRemisionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarPorIdDeLaRemisionToolStripMenuItem.Click
        Dim intTipo As String = InputBox("EscribA El Formulario de Ingreso", "Mensaje del Sitema")
        If intTipo.Equals("") Then : MessageBox.Show("Invalido", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub : End If
        lblFormulario.Text = intTipo
        alimentarCamposBusqueda(2, intTipo, intTipo)
        'btnGuardar.Enabled = False
        'btnModificar.Enabled = True
    End Sub

    Function alimentarCamposBusqueda(tipoBusqueda As Integer, strIndexBusqueda As String, tipoDocumento As Integer)
        Dim booEncontrado As Boolean = True
        Dim strCadena As String = ""
        Dim strremision As String = ""
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
                strremision = remision(2)
                'txtTipoDocumento.Text = remision(1) : lstTipoDocumentos.Visible = False
                'txtConsecutivo.Text = remision(2)
                'txtidformularioIngreso.Text = remision(3)
                'txtSubPartida.Text = remision(4)
                'intIdDeLaPersona = remision(5)
                lblCliente.Text = remision(6) ': lstNombres.Visible = False
                'intIdEmbalaje = remision(7)
                'txtEmbalaje.Text = remision(8) : lstEmbalajes.Visible = False
                'intIdPaisOrigen = remision(9)
                'txtPaisOrigen.Text = remision(10) : lstOrigen.Visible = False
                'intidPaisCompra = remision(11)
                'txtPaisCompra.Text = remision(12) : lstPaisCompra.Visible = False
                'intidPaisDestino = remision(13)
                'txtDestino.Text = remision(14) : lstDestino.Visible = False
                'intIdPaisProcedencia = remision(15)
                'txtProcedencia.Text = remision(16) : lstProcedencia.Visible = False
                'Dim fe As Date = remision(17)
                'dtFecha.Text = Format(fe, "dd-MM-yyyy")
                'lblEstado.Text = remision(18)
                'intidTipoAlmacenamiento = remision(19)
                'txtAlmacenamiento.Text = remision(20) : lstAlmacenamiento.Visible = False
                'txtPlacas.Text = remision(21)
                'intIdRemisionAModificar = remision(22)
                'lblTasa.Text = remision(23)

            Next
            alimenteItem(intTipoDocumento, strremision)
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
        ' existeItemenArray(4)
        Return True
    End Function

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

    Private Sub facturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRegistre_Click(sender As Object, e As EventArgs) Handles btnRegistre.Click
        Dim fechadesde As Date
        Dim fechahasta As Date
        fechadesde = fdesde.Value.Date
        fechahasta = fhasta.Value.Date
        Try
            Dim strCadena As String = "INSERT INTO facturacion (idformularioingreso,fdesde,fhasta,obs)values ('" & lblFormulario.Text & "','" & Format(fechadesde, "yyyy-MM-dd") & "','" & Format(fechahasta, "yyyy-MM-dd") & "','" & txtObservaciones.Text & "')"
            Dim cadena2 As String = "update remisiones set facturado=2 where idformularioingreso='" & lblFormulario.Text & "'"
            If fun.registreDatos(strCadena) AndAlso fun.registreDatos(cadena2) Then
                MessageBox.Show("Registro Correcto", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                limpar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub limpar()
        lblCliente.Text = ""
        'ponerFecha()
        fdesde.CustomFormat = Now.Date.ToString
        fhasta.CustomFormat = Now.Date.ToString
        lblFormulario.Text = ""
        lstItems.Items.Clear()
        txtObservaciones.Text = ""
    End Sub

    Sub ponerFecha()
        fdesde.CustomFormat = Now.Date.ToString
        fhasta.CustomFormat = Now.Date.ToString
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpar()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub lblFormulario_Click(sender As Object, e As EventArgs) Handles lblFormulario.Click

    End Sub

    Private Sub btnRegistre_MouseMove(sender As Object, e As MouseEventArgs) Handles btnRegistre.MouseMove
        rutaImagen = strUnidad & ":\FRONTIER\Imagenes\btn_guardar-3_.png"
        btnRegistre.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub btnRegistre_MouseLeave(sender As Object, e As EventArgs) Handles btnRegistre.MouseLeave
        rutaImagen = strUnidad & ":\FRONTIER\Imagenes\btn_guardar-3.png"
        btnRegistre.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub btnLimpiar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnLimpiar.MouseMove
        rutaImagen = strUnidad & ":\FRONTIER\Imagenes\btn_limpiar-3_.png"
        btnLimpiar.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub btnLimpiar_MouseLeave(sender As Object, e As EventArgs) Handles btnLimpiar.MouseLeave
        rutaImagen = strUnidad & ":\FRONTIER\Imagenes\btn_limpiar-3.png"
        btnLimpiar.Image = Image.FromFile(rutaImagen)
    End Sub
End Class