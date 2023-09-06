<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reportes))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtReporte = New System.Windows.Forms.TextBox()
        Me.lstReporte = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fhasta = New System.Windows.Forms.DateTimePicker()
        Me.fdesde = New System.Windows.Forms.DateTimePicker()
        Me.txtTotales = New System.Windows.Forms.TextBox()
        Me.lstDatos = New System.Windows.Forms.ListView()
        Me.Cliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Descripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Valor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fechadepago = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtExportar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1062, 30)
        Me.Panel1.TabIndex = 34
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
        Me.btnCerrar.Location = New System.Drawing.Point(1036, 0)
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
        Me.Label1.Location = New System.Drawing.Point(451, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Entrada de Mercancia"
        '
        'txtReporte
        '
        Me.txtReporte.Location = New System.Drawing.Point(31, 50)
        Me.txtReporte.Name = "txtReporte"
        Me.txtReporte.Size = New System.Drawing.Size(241, 20)
        Me.txtReporte.TabIndex = 39
        '
        'lstReporte
        '
        Me.lstReporte.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lstReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstReporte.FullRowSelect = True
        Me.lstReporte.GridLines = True
        Me.lstReporte.HideSelection = False
        Me.lstReporte.Location = New System.Drawing.Point(31, 72)
        Me.lstReporte.Name = "lstReporte"
        Me.lstReporte.Size = New System.Drawing.Size(241, 92)
        Me.lstReporte.TabIndex = 40
        Me.lstReporte.UseCompatibleStateImageBehavior = False
        Me.lstReporte.View = System.Windows.Forms.View.Details
        Me.lstReporte.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Reporte"
        Me.ColumnHeader1.Width = 232
        '
        'fhasta
        '
        Me.fhasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fhasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fhasta.Location = New System.Drawing.Point(506, 50)
        Me.fhasta.Margin = New System.Windows.Forms.Padding(4)
        Me.fhasta.Name = "fhasta"
        Me.fhasta.Size = New System.Drawing.Size(136, 22)
        Me.fhasta.TabIndex = 42
        '
        'fdesde
        '
        Me.fdesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fdesde.Location = New System.Drawing.Point(344, 50)
        Me.fdesde.Margin = New System.Windows.Forms.Padding(4)
        Me.fdesde.Name = "fdesde"
        Me.fdesde.Size = New System.Drawing.Size(136, 22)
        Me.fdesde.TabIndex = 41
        '
        'txtTotales
        '
        Me.txtTotales.Location = New System.Drawing.Point(883, 593)
        Me.txtTotales.Name = "txtTotales"
        Me.txtTotales.Size = New System.Drawing.Size(131, 20)
        Me.txtTotales.TabIndex = 43
        '
        'lstDatos
        '
        Me.lstDatos.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lstDatos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Cliente, Me.Descripcion, Me.Valor, Me.Fechadepago})
        Me.lstDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDatos.FullRowSelect = True
        Me.lstDatos.GridLines = True
        Me.lstDatos.HideSelection = False
        Me.lstDatos.HoverSelection = True
        Me.lstDatos.Location = New System.Drawing.Point(13, 95)
        Me.lstDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.lstDatos.Name = "lstDatos"
        Me.lstDatos.Size = New System.Drawing.Size(1023, 475)
        Me.lstDatos.TabIndex = 44
        Me.lstDatos.UseCompatibleStateImageBehavior = False
        Me.lstDatos.View = System.Windows.Forms.View.Details
        '
        'Cliente
        '
        Me.Cliente.Text = "Cliente"
        Me.Cliente.Width = 185
        '
        'Descripcion
        '
        Me.Descripcion.Text = "Descripcion"
        Me.Descripcion.Width = 141
        '
        'Valor
        '
        Me.Valor.Text = "Valor"
        Me.Valor.Width = 161
        '
        'Fechadepago
        '
        Me.Fechadepago.Text = "Fecha  de pago"
        Me.Fechadepago.Width = 365
        '
        'txtExportar
        '
        Me.txtExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtExportar.Image = Global.PrincipalB.My.Resources.Resources.Download
        Me.txtExportar.Location = New System.Drawing.Point(802, 52)
        Me.txtExportar.Name = "txtExportar"
        Me.txtExportar.Size = New System.Drawing.Size(28, 23)
        Me.txtExportar.TabIndex = 45
        Me.txtExportar.UseVisualStyleBackColor = True
        '
        'reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 642)
        Me.Controls.Add(Me.txtExportar)
        Me.Controls.Add(Me.txtTotales)
        Me.Controls.Add(Me.fhasta)
        Me.Controls.Add(Me.fdesde)
        Me.Controls.Add(Me.txtReporte)
        Me.Controls.Add(Me.lstReporte)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lstDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reportes"
        Me.Text = "reportes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtReporte As TextBox
    Friend WithEvents lstReporte As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents fhasta As DateTimePicker
    Friend WithEvents fdesde As DateTimePicker
    Friend WithEvents txtTotales As TextBox
    Friend WithEvents lstDatos As ListView
    Private WithEvents Cliente As ColumnHeader
    Friend WithEvents Descripcion As ColumnHeader
    Friend WithEvents Valor As ColumnHeader
    Friend WithEvents Fechadepago As ColumnHeader
    Friend WithEvents txtExportar As Button
End Class
