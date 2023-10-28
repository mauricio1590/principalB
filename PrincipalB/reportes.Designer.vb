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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(1083, 30)
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
        Me.btnCerrar.Location = New System.Drawing.Point(1057, 0)
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
        Me.Label1.Location = New System.Drawing.Point(488, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reportes"
        '
        'txtReporte
        '
        Me.txtReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReporte.Location = New System.Drawing.Point(168, 92)
        Me.txtReporte.Name = "txtReporte"
        Me.txtReporte.Size = New System.Drawing.Size(426, 26)
        Me.txtReporte.TabIndex = 39
        '
        'lstReporte
        '
        Me.lstReporte.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lstReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstReporte.FullRowSelect = True
        Me.lstReporte.GridLines = True
        Me.lstReporte.HideSelection = False
        Me.lstReporte.Location = New System.Drawing.Point(168, 117)
        Me.lstReporte.Name = "lstReporte"
        Me.lstReporte.Size = New System.Drawing.Size(426, 92)
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
        Me.fhasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fhasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fhasta.Location = New System.Drawing.Point(809, 90)
        Me.fhasta.Margin = New System.Windows.Forms.Padding(4)
        Me.fhasta.Name = "fhasta"
        Me.fhasta.Size = New System.Drawing.Size(136, 26)
        Me.fhasta.TabIndex = 42
        '
        'fdesde
        '
        Me.fdesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fdesde.Location = New System.Drawing.Point(637, 90)
        Me.fdesde.Margin = New System.Windows.Forms.Padding(4)
        Me.fdesde.Name = "fdesde"
        Me.fdesde.Size = New System.Drawing.Size(136, 26)
        Me.fdesde.TabIndex = 41
        '
        'txtTotales
        '
        Me.txtTotales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotales.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotales.Location = New System.Drawing.Point(839, 542)
        Me.txtTotales.Name = "txtTotales"
        Me.txtTotales.Size = New System.Drawing.Size(204, 31)
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
        Me.lstDatos.Location = New System.Drawing.Point(20, 145)
        Me.lstDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.lstDatos.Name = "lstDatos"
        Me.lstDatos.Size = New System.Drawing.Size(1023, 390)
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
        Me.txtExportar.FlatAppearance.BorderSize = 0
        Me.txtExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.txtExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.txtExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtExportar.Image = CType(resources.GetObject("txtExportar.Image"), System.Drawing.Image)
        Me.txtExportar.Location = New System.Drawing.Point(992, 81)
        Me.txtExportar.Margin = New System.Windows.Forms.Padding(0)
        Me.txtExportar.Name = "txtExportar"
        Me.txtExportar.Size = New System.Drawing.Size(51, 51)
        Me.txtExportar.TabIndex = 45
        Me.txtExportar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.txtReporte)
        Me.Panel2.Controls.Add(Me.txtTotales)
        Me.Panel2.Controls.Add(Me.txtExportar)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.lstReporte)
        Me.Panel2.Controls.Add(Me.fdesde)
        Me.Panel2.Controls.Add(Me.lstDatos)
        Me.Panel2.Controls.Add(Me.fhasta)
        Me.Panel2.Location = New System.Drawing.Point(12, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1059, 583)
        Me.Panel2.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(805, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "Hasta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(633, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Desde:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(771, 546)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 24)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(164, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Reporte:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1058, 39)
        Me.Panel3.TabIndex = 101
        '
        'reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1083, 642)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reportes"
        Me.Text = "reportes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
