<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tipoDocumento
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tipoDocumento))
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtab = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lstDocumentos = New System.Windows.Forms.ListView()
        Me.Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Valor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnl_herramientas = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tm_MenuMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.tm_MenuOcultar = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.pnl_herramientas.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(836, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(26, 30)
        Me.btnCerrar.TabIndex = 13
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(387, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tasa De Cambio"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(862, 30)
        Me.Panel1.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(214, 74)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(247, 26)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(137, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(205, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Abreviatura:"
        '
        'txtab
        '
        Me.txtab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtab.Location = New System.Drawing.Point(305, 125)
        Me.txtab.Name = "txtab"
        Me.txtab.Size = New System.Drawing.Size(156, 26)
        Me.txtab.TabIndex = 2
        Me.txtab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.Location = New System.Drawing.Point(1, 64)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(248, 56)
        Me.btnEliminar.TabIndex = 19
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiar.Location = New System.Drawing.Point(1, 186)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(248, 56)
        Me.btnLimpiar.TabIndex = 18
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.Location = New System.Drawing.Point(1, 125)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(248, 56)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(1, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(248, 56)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lstDocumentos
        '
        Me.lstDocumentos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Id, Me.Valor})
        Me.lstDocumentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDocumentos.FullRowSelect = True
        Me.lstDocumentos.GridLines = True
        Me.lstDocumentos.HideSelection = False
        Me.lstDocumentos.Location = New System.Drawing.Point(42, 181)
        Me.lstDocumentos.Name = "lstDocumentos"
        Me.lstDocumentos.Size = New System.Drawing.Size(419, 213)
        Me.lstDocumentos.TabIndex = 20
        Me.lstDocumentos.UseCompatibleStateImageBehavior = False
        Me.lstDocumentos.View = System.Windows.Forms.View.Details
        '
        'Id
        '
        Me.Id.Text = "Nombre"
        Me.Id.Width = 277
        '
        'Valor
        '
        Me.Valor.Text = "Abreviatura"
        Me.Valor.Width = 224
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(862, 24)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'pnl_herramientas
        '
        Me.pnl_herramientas.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pnl_herramientas.Controls.Add(Me.btnGuardar)
        Me.pnl_herramientas.Controls.Add(Me.btnEliminar)
        Me.pnl_herramientas.Controls.Add(Me.btnModificar)
        Me.pnl_herramientas.Controls.Add(Me.btnLimpiar)
        Me.pnl_herramientas.Location = New System.Drawing.Point(801, 160)
        Me.pnl_herramientas.Name = "pnl_herramientas"
        Me.pnl_herramientas.Size = New System.Drawing.Size(251, 245)
        Me.pnl_herramientas.TabIndex = 45
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtNombre)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lstDocumentos)
        Me.Panel2.Controls.Add(Me.txtab)
        Me.Panel2.Location = New System.Drawing.Point(167, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(511, 426)
        Me.Panel2.TabIndex = 46
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(511, 39)
        Me.Panel3.TabIndex = 49
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(42, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'tm_MenuMostrar
        '
        Me.tm_MenuMostrar.Interval = 1
        '
        'tm_MenuOcultar
        '
        Me.tm_MenuOcultar.Interval = 1
        '
        'tipoDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(862, 526)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnl_herramientas)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "tipoDocumento"
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnl_herramientas.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtab As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lstDocumentos As ListView
    Friend WithEvents Id As ColumnHeader
    Friend WithEvents Valor As ColumnHeader
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnl_herramientas As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tm_MenuMostrar As Timer
    Friend WithEvents tm_MenuOcultar As Timer
End Class
