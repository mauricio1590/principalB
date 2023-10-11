Imports System.Runtime.InteropServices
Imports iTextSharp.text
Imports iTextSharp.text.html.simpleparser
Imports MySql.Data.MySqlClient
Public Class Principal
    Dim pdf As New Report()
    Dim fun As New Funciones
    Public logo As String = ""
    Public strUnidad As String = "D"
    Public intIdUsuario As Integer = 0
    Public intidNivelUsuario As Integer = 5
    Public strUsuario As String = ""
    Public validado As Boolean = False
    Public servidor As String = "localhost"
    Public usuario As String = "root"
    Public password As String = "bandband"
    Public database As String = "frontier"
    Public cadenadeconexion As String = "Server=" & servidor & ";Uid=root;Pwd=" & password & ";Database=" & database & ""

    'colores botonees
    Public botonlow1 As Integer = 46
    Public botonlow2 As Integer = 59
    Public botonlow3 As Integer = 104
    Public botonup1 As Integer = 128
    Public botonup2 As Integer = 128
    Public botonup3 As Integer = 128
    Public barra1 As Integer = 30
    Public barra2 As Integer = 37
    Public barra3 As Integer = 73
    Public cpanel1 As Integer = 44
    Public cpanel2 As Integer = 59
    Public cpanel3 As Integer = 107



    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logo = strUnidad & ":\FRONTIER\Imagenes\logo.jpg"
        fun.ponerFoto(logo, picLogo)
        fun.ponerFoto(logo, picLogo2)
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        '  colorPanel(panelMenu)
        timerLog.Start()
    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Function colorPanel(barra As Panel)
        barra.BackColor = System.Drawing.Color.FromArgb(cpanel1, cpanel2, cpanel3)
        Return True
    End Function
    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
        'nuevos cambios
    End Sub

    Private Sub panelCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles panelCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub tmMostrarMenu_Tick(sender As Object, e As EventArgs) Handles tmMostrarMenu.Tick
        If panelMenu.Width >= 220 Then
            Me.tmMostrarMenu.Enabled = False
        Else
            Me.panelMenu.Width = panelMenu.Width + 5

        End If
    End Sub

    Private Sub tmOcultarmenu_Tick(sender As Object, e As EventArgs) Handles tmOcultarMenu.Tick
        If panelMenu.Width <= 60 Then
            Me.tmOcultarMenu.Enabled = False
        Else
            Me.panelMenu.Width = panelMenu.Width - 5

        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click


        If panelMenu.Width = 220 Then
            tmOcultarMenu.Enabled = True
        ElseIf panelMenu.Width = 60 Then
            tmMostrarMenu.Enabled = True
        End If

    End Sub

    'Private Sub AbrirFormPanel(ByRef Formhijo As Object)
    '    If Me.PanelContenedor.Controls.Count > 0 Then Me.PanelContenedor.Controls.RemoveAt(0)
    '    Dim fh As Form = TryCast(Formhijo, Form)
    '    fh.TopLevel = False
    '    fh.FormBorderStyle = FormBorderStyle.None
    '    fh.Dock = DockStyle.Fill
    '    Me.PanelContenedor.Controls.Add(fh)
    '    Me.PanelContenedor.Tag = fh
    '    fh.Show()
    'End Sub
    Private Sub AbrirFormPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelContenedor.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion
        'Si form no fue econtrado/ no existe
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            PanelContenedor.Controls.Add(Formulario)
            PanelContenedor.Tag = Formulario
            AddHandler Formulario.FormClosed, AddressOf Me.cerrarFormulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If

    End Sub

    Private Sub cerrarFormulario(ByVal sender As Object, ByVal a As FormClosedEventArgs)


        'If (Application.OpenForms("Clientes") Is Nothing) Then
        '    btnCliente.BackColor = System.Drawing.Color.FromArgb(botonlow1, botonlow2, botonlow3)
        'End If
        'If (Application.OpenForms("Tasadecambio") Is Nothing) Then
        '    btnTasaCambio.BackColor = System.Drawing.Color.FromArgb(botonlow1, botonlow2, botonlow3)
        'End If
        'If (Application.OpenForms("Remisiones") Is Nothing) Then
        '    btnEntrada.BackColor = System.Drawing.Color.FromArgb(botonlow1, botonlow2, botonlow3)
        'End If
        'If (Application.OpenForms("salidas") Is Nothing) Then
        '    btnSalida.BackColor = System.Drawing.Color.FromArgb(botonlow1, botonlow2, botonlow3)
        'End If
        'If (Application.OpenForms("reportes") Is Nothing) Then
        '    btnReporte.BackColor = System.Drawing.Color.FromArgb(botonlow1, botonlow2, botonlow3)
        'End If


    End Sub
    Public Sub AbrirFormularios(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelContenedor.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion
        'Si form no fue econtrado/ no existe
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            PanelContenedor.Controls.Add(Formulario)
            PanelContenedor.Tag = Formulario
            AddHandler Formulario.FormClosed, AddressOf Me.cerrarFormulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If


    End Sub


    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        AbrirFormPanel(Of Clientes)()
    End Sub

    Private Sub btnTasaCambio_Click(sender As Object, e As EventArgs) Handles btnTasaCambio.Click
        AbrirFormPanel(Of Tasadecambio)()
    End Sub

    Private Sub TipoDeDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TipoDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDocumentoToolStripMenuItem.Click
        AbrirFormPanel(Of tipoDocumento)()
    End Sub

    Private Sub TipoEmbalajeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoEmbalajeToolStripMenuItem.Click
        AbrirFormPanel(Of TipoEmbalaje)()
    End Sub

    Private Sub TipoAlmacenamientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoAlmacenamientoToolStripMenuItem.Click
        AbrirFormPanel(Of tipoAlmacenamiento)()
    End Sub

    Private Sub btnEntrada_Click(sender As Object, e As EventArgs) Handles btnEntrada.Click
        AbrirFormPanel(Of Remisiones)()
    End Sub

    Private Sub PanelContenedor_Paint(sender As Object, e As PaintEventArgs) Handles PanelContenedor.Paint

    End Sub

    Private Sub btnSalida_Click(sender As Object, e As EventArgs) Handles btnSalida.Click
        AbrirFormPanel(Of salidas)()
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        AbrirFormPanel(Of reportes)()
    End Sub


    Private Sub OpcionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpcionesToolStripMenuItem.Click

    End Sub
    Private Sub timerLog_Tick(sender As Object, e As EventArgs) Handles timerLog.Tick
        timerLog.Stop()
        Dim log As New login
        log.ShowDialog()
        If Not validado Then
            Application.Exit()
        End If

    End Sub
End Class
