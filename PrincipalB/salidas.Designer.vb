<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salidas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(salidas))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiltrarPorNumeroDeFormularioDeIngresoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lstItems = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtFormularioSalida = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstItemConfirmado = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1065, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FiltrarPorNumeroDeFormularioDeIngresoToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'FiltrarPorNumeroDeFormularioDeIngresoToolStripMenuItem
        '
        Me.FiltrarPorNumeroDeFormularioDeIngresoToolStripMenuItem.Name = "FiltrarPorNumeroDeFormularioDeIngresoToolStripMenuItem"
        Me.FiltrarPorNumeroDeFormularioDeIngresoToolStripMenuItem.Size = New System.Drawing.Size(303, 22)
        Me.FiltrarPorNumeroDeFormularioDeIngresoToolStripMenuItem.Text = "Filtrar por numero de formulario de ingreso"
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
        Me.btnCerrar.Location = New System.Drawing.Point(1039, 0)
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
        Me.Label1.Location = New System.Drawing.Point(452, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Salida de Mercancia"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1065, 30)
        Me.Panel1.TabIndex = 34
        '
        'lstItems
        '
        Me.lstItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.lstItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItems.FullRowSelect = True
        Me.lstItems.GridLines = True
        Me.lstItems.HideSelection = False
        Me.lstItems.Location = New System.Drawing.Point(31, 127)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(979, 137)
        Me.lstItems.TabIndex = 86
        Me.lstItems.UseCompatibleStateImageBehavior = False
        Me.lstItems.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Item"
        Me.ColumnHeader9.Width = 221
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Descripcion"
        Me.ColumnHeader10.Width = 413
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Cant"
        Me.ColumnHeader11.Width = 61
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Bultos"
        Me.ColumnHeader12.Width = 92
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Cantidad Saliente"
        Me.ColumnHeader13.Width = 187
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(348, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 32)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Items en esta remision"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(42, 56)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(242, 57)
        Me.Button1.TabIndex = 87
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtFormularioSalida
        '
        Me.txtFormularioSalida.Location = New System.Drawing.Point(684, 78)
        Me.txtFormularioSalida.Name = "txtFormularioSalida"
        Me.txtFormularioSalida.Size = New System.Drawing.Size(326, 26)
        Me.txtFormularioSalida.TabIndex = 93
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(680, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 21)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "# Formulario de Salida:"
        '
        'lstItemConfirmado
        '
        Me.lstItemConfirmado.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader14})
        Me.lstItemConfirmado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItemConfirmado.FullRowSelect = True
        Me.lstItemConfirmado.GridLines = True
        Me.lstItemConfirmado.HideSelection = False
        Me.lstItemConfirmado.Location = New System.Drawing.Point(31, 342)
        Me.lstItemConfirmado.Name = "lstItemConfirmado"
        Me.lstItemConfirmado.Size = New System.Drawing.Size(979, 137)
        Me.lstItemConfirmado.TabIndex = 95
        Me.lstItemConfirmado.UseCompatibleStateImageBehavior = False
        Me.lstItemConfirmado.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item"
        Me.ColumnHeader1.Width = 254
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descripcion"
        Me.ColumnHeader2.Width = 497
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Cant"
        Me.ColumnHeader3.Width = 89
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Cantidad Saliente"
        Me.ColumnHeader14.Width = 134
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(36, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 32)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Cantidad en Salida"
        '
        'btnAceptar
        '
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.Location = New System.Drawing.Point(503, 268)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(242, 57)
        Me.btnAceptar.TabIndex = 97
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(768, 268)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(242, 57)
        Me.btnModificar.TabIndex = 98
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.FlatAppearance.BorderSize = 0
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Image = CType(resources.GetObject("btnRegistrar.Image"), System.Drawing.Image)
        Me.btnRegistrar.Location = New System.Drawing.Point(768, 485)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(242, 57)
        Me.btnRegistrar.TabIndex = 99
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btnRegistrar)
        Me.Panel2.Controls.Add(Me.lstItems)
        Me.Panel2.Controls.Add(Me.btnModificar)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnAceptar)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lstItemConfirmado)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtFormularioSalida)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(9, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1045, 558)
        Me.Panel2.TabIndex = 100
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1044, 39)
        Me.Panel3.TabIndex = 100
        '
        'salidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1065, 634)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "salidas"
        Me.Text = "salidas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FiltrarPorNumeroDeFormularioDeIngresoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstItems As ListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtFormularioSalida As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lstItemConfirmado As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
