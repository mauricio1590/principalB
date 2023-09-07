Imports System.Runtime.InteropServices
Imports iTextSharp.text
Imports iTextSharp.text.html.simpleparser
Imports MySql.Data.MySqlClient
Public Class Principal
    Dim pdf As New Report()
    Dim fun As New Funciones
    Public logo As String = ""
    Dim strUnidad As String = "D"
    Public intIdUsuario As Integer = 0
    Public servidor As String = "localhost"
    Public usuario As String = "root"
    Public password As String = "90271516"
    Public database As String = "frontier"
    Public cadenadeconexion As String = "Server=" & servidor & ";Uid=root;Pwd=" & password & ";Database=" & database & ""



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
    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

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

    Private Sub AbrirFormPanel(ByRef Formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then Me.PanelContenedor.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        AbrirFormPanel(New Clientes)
    End Sub

    Private Sub btnTasaCambio_Click(sender As Object, e As EventArgs) Handles btnTasaCambio.Click
        AbrirFormPanel(New Tasadecambio)
    End Sub

    Private Sub TipoDeDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TipoDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDocumentoToolStripMenuItem.Click
        AbrirFormPanel(New tipoDocumento)
    End Sub

    Private Sub TipoEmbalajeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoEmbalajeToolStripMenuItem.Click
        AbrirFormPanel(New TipoEmbalaje)
    End Sub

    Private Sub TipoAlmacenamientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoAlmacenamientoToolStripMenuItem.Click
        AbrirFormPanel(New tipoAlmacenamiento)
    End Sub

    Private Sub btnEntrada_Click(sender As Object, e As EventArgs) Handles btnEntrada.Click
        AbrirFormPanel(New Remisiones)
    End Sub

    Private Sub PanelContenedor_Paint(sender As Object, e As PaintEventArgs) Handles PanelContenedor.Paint

    End Sub

    Private Sub btnSalida_Click(sender As Object, e As EventArgs) Handles btnSalida.Click
        AbrirFormPanel(New salidas)
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        AbrirFormPanel(New reportes)
    End Sub

    Private Sub OpcionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpcionesToolStripMenuItem.Click

    End Sub
End Class
