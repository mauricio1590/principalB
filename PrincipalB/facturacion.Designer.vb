<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class facturacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(facturacion))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarPorIdDeLaRemisionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lstItems = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fdesde = New System.Windows.Forms.DateTimePicker()
        Me.fhasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.btnRegistre = New System.Windows.Forms.Button()
        Me.lblFormulario = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1232, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarPorIdDeLaRemisionToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'BuscarPorIdDeLaRemisionToolStripMenuItem
        '
        Me.BuscarPorIdDeLaRemisionToolStripMenuItem.Name = "BuscarPorIdDeLaRemisionToolStripMenuItem"
        Me.BuscarPorIdDeLaRemisionToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.BuscarPorIdDeLaRemisionToolStripMenuItem.Text = "Buscar por Id de la Remision"
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
        Me.btnCerrar.Location = New System.Drawing.Point(1206, 0)
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
        Me.Label1.Location = New System.Drawing.Point(536, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Facturar Remiones"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1232, 30)
        Me.Panel1.TabIndex = 34
        '
        'lstItems
        '
        Me.lstItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16})
        Me.lstItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItems.FullRowSelect = True
        Me.lstItems.GridLines = True
        Me.lstItems.HideSelection = False
        Me.lstItems.Location = New System.Drawing.Point(40, 318)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(1180, 166)
        Me.lstItems.TabIndex = 86
        Me.lstItems.UseCompatibleStateImageBehavior = False
        Me.lstItems.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Item"
        Me.ColumnHeader9.Width = 196
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Descripcion"
        Me.ColumnHeader10.Width = 308
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Cant"
        Me.ColumnHeader11.Width = 99
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Bultos"
        Me.ColumnHeader12.Width = 107
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Pb"
        Me.ColumnHeader13.Width = 93
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Pn"
        Me.ColumnHeader14.Width = 103
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "V Unitario"
        Me.ColumnHeader15.Width = 111
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "V total"
        Me.ColumnHeader16.Width = 83
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(566, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "Hasta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(394, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Desde:"
        '
        'fdesde
        '
        Me.fdesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fdesde.Location = New System.Drawing.Point(398, 112)
        Me.fdesde.Margin = New System.Windows.Forms.Padding(4)
        Me.fdesde.Name = "fdesde"
        Me.fdesde.Size = New System.Drawing.Size(136, 26)
        Me.fdesde.TabIndex = 106
        '
        'fhasta
        '
        Me.fhasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fhasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fhasta.Location = New System.Drawing.Point(570, 112)
        Me.fhasta.Margin = New System.Windows.Forms.Padding(4)
        Me.fhasta.Name = "fhasta"
        Me.fhasta.Size = New System.Drawing.Size(136, 26)
        Me.fhasta.TabIndex = 107
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(171, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 20)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Rango de Facturacion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(171, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Cliente:"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(394, 180)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(62, 20)
        Me.lblCliente.TabIndex = 111
        Me.lblCliente.Text = "Cliente:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(171, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 20)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "Observaciones:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(398, 225)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(308, 60)
        Me.txtObservaciones.TabIndex = 113
        '
        'btnRegistre
        '
        Me.btnRegistre.Location = New System.Drawing.Point(827, 117)
        Me.btnRegistre.Name = "btnRegistre"
        Me.btnRegistre.Size = New System.Drawing.Size(129, 23)
        Me.btnRegistre.TabIndex = 114
        Me.btnRegistre.Text = "Registrar"
        Me.btnRegistre.UseVisualStyleBackColor = True
        '
        'lblFormulario
        '
        Me.lblFormulario.AutoSize = True
        Me.lblFormulario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormulario.Location = New System.Drawing.Point(171, 69)
        Me.lblFormulario.Name = "lblFormulario"
        Me.lblFormulario.Size = New System.Drawing.Size(0, 20)
        Me.lblFormulario.TabIndex = 115
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(827, 156)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(129, 23)
        Me.btnLimpiar.TabIndex = 116
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1232, 771)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lblFormulario)
        Me.Controls.Add(Me.btnRegistre)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fdesde)
        Me.Controls.Add(Me.fhasta)
        Me.Controls.Add(Me.lstItems)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "facturacion"
        Me.Text = "facturacion"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarPorIdDeLaRemisionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lstItems As ListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents fdesde As DateTimePicker
    Friend WithEvents fhasta As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents btnRegistre As Button
    Friend WithEvents lblFormulario As Label
    Friend WithEvents btnLimpiar As Button
End Class
