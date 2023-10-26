Imports System.Runtime.InteropServices
Public Class login
    Dim fun As New Funciones
#Region "Form behaviors"
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
        Principal.btnMinimizar.PerformClick()
    End Sub

#End Region

#Region "Drag Form"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

    End Sub

    Private Sub pnTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles pnTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF128&, 0)
    End Sub

    Private Sub login_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF128&, 0)
    End Sub


#End Region


#Region "Customize Controls - Personalizar Controles"
    Private Sub CustomizeComponents()
        'txtUser
        'txtPass
        txtContra.AutoSize = False
        txtContra.Size = New Size(224, 38)
        txtContra.UseSystemPasswordChar = True
    End Sub
    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs)
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnIngresar.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnIngresar.Region = New Region(buttonPath)
    End Sub
#End Region


    'Constructor
    Public Sub New()
        InitializeComponent()
        CustomizeComponents()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim validado As Boolean = False
        If fun.validarContraseña(txtContra.Text) Then
            Principal.validado = True
            validado = True
        End If
        If Not validado Then
            MessageBox.Show("Contraseña incorrectaaaaaa", "Informacion Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        End If
        Me.Close()


    End Sub

    Private Sub InicioSecion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub txtContra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContra.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnIngresar.PerformClick()
        End If
    End Sub
End Class