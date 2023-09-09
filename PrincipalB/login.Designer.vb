<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.pnTitulo = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtContra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkRecordar = New System.Windows.Forms.CheckBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.lblLines = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.pnTitulo.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnTitulo
        '
        Me.pnTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.pnTitulo.Controls.Add(Me.btnMinimizar)
        Me.pnTitulo.Controls.Add(Me.btnCerrar)
        Me.pnTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnTitulo.Name = "pnTitulo"
        Me.pnTitulo.Size = New System.Drawing.Size(322, 49)
        Me.pnTitulo.TabIndex = 1
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(245, 7)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(31, 31)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimizar.TabIndex = 0
        Me.btnMinimizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(282, 7)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(28, 31)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 469)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 15)
        Me.Panel1.TabIndex = 2
        '
        'txtContra
        '
        Me.txtContra.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.txtContra.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContra.Location = New System.Drawing.Point(41, 186)
        Me.txtContra.Name = "txtContra"
        Me.txtContra.Size = New System.Drawing.Size(211, 27)
        Me.txtContra.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(37, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Contraseña:"
        '
        'chkRecordar
        '
        Me.chkRecordar.AutoSize = True
        Me.chkRecordar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRecordar.ForeColor = System.Drawing.SystemColors.Control
        Me.chkRecordar.Location = New System.Drawing.Point(41, 232)
        Me.chkRecordar.Name = "chkRecordar"
        Me.chkRecordar.Size = New System.Drawing.Size(117, 20)
        Me.chkRecordar.TabIndex = 5
        Me.chkRecordar.Text = "Recordar usuario"
        Me.chkRecordar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresar.FlatAppearance.BorderSize = 0
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.ForeColor = System.Drawing.Color.White
        Me.btnIngresar.Location = New System.Drawing.Point(41, 273)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(211, 41)
        Me.btnIngresar.TabIndex = 6
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'lblLines
        '
        Me.lblLines.AutoSize = True
        Me.lblLines.ForeColor = System.Drawing.Color.Silver
        Me.lblLines.Location = New System.Drawing.Point(54, 412)
        Me.lblLines.Name = "lblLines"
        Me.lblLines.Size = New System.Drawing.Size(223, 13)
        Me.lblLines.TabIndex = 8
        Me.lblLines.Text = "____________________________________"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.ForeColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(98, 440)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(114, 13)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Recuperar Contraseña"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(322, 484)
        Me.Controls.Add(Me.lblLines)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.chkRecordar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtContra)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.Opacity = 0.85R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        Me.pnTitulo.ResumeLayout(False)
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnTitulo As Panel
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents txtContra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkRecordar As CheckBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents lblLines As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
