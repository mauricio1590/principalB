<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.tmMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.btnSalida = New System.Windows.Forms.Button()
        Me.btnEntrada = New System.Windows.Forms.Button()
        Me.btnTasaCambio = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.panelCabecera = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.picLogo2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDocumentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoEmbalajeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoAlmacenamientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.timerLog = New System.Windows.Forms.Timer(Me.components)
        Me.btnFacturacion = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.panelMenu.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCabecera.SuspendLayout()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.picLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmMostrarMenu
        '
        Me.tmMostrarMenu.Interval = 15
        '
        'tmOcultarMenu
        '
        Me.tmOcultarMenu.Interval = 15
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 177)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 50)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 237)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 50)
        Me.Panel2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 297)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 50)
        Me.Panel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 357)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 50)
        Me.Panel4.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(0, 417)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 50)
        Me.Panel5.TabIndex = 3
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.Panel6)
        Me.panelMenu.Controls.Add(Me.Panel5)
        Me.panelMenu.Controls.Add(Me.Panel4)
        Me.panelMenu.Controls.Add(Me.Panel3)
        Me.panelMenu.Controls.Add(Me.Panel2)
        Me.panelMenu.Controls.Add(Me.Panel1)
        Me.panelMenu.Controls.Add(Me.picLogo)
        Me.panelMenu.Controls.Add(Me.btnFacturacion)
        Me.panelMenu.Controls.Add(Me.btnReporte)
        Me.panelMenu.Controls.Add(Me.btnSalida)
        Me.panelMenu.Controls.Add(Me.btnEntrada)
        Me.panelMenu.Controls.Add(Me.btnTasaCambio)
        Me.panelMenu.Controls.Add(Me.btnCliente)
        Me.panelMenu.Controls.Add(Me.btnMenu)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 64)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(220, 706)
        Me.panelMenu.TabIndex = 1
        '
        'picLogo
        '
        Me.picLogo.Location = New System.Drawing.Point(-8, 52)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(220, 60)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 1
        Me.picLogo.TabStop = False
        '
        'btnReporte
        '
        Me.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReporte.FlatAppearance.BorderSize = 0
        Me.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporte.Font = New System.Drawing.Font("Georgia", 9.0!)
        Me.btnReporte.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), System.Drawing.Image)
        Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporte.Location = New System.Drawing.Point(0, 417)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(220, 50)
        Me.btnReporte.TabIndex = 0
        Me.btnReporte.Text = "Reportes"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'btnSalida
        '
        Me.btnSalida.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalida.FlatAppearance.BorderSize = 0
        Me.btnSalida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalida.Font = New System.Drawing.Font("Georgia", 9.0!)
        Me.btnSalida.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSalida.Image = CType(resources.GetObject("btnSalida.Image"), System.Drawing.Image)
        Me.btnSalida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalida.Location = New System.Drawing.Point(0, 357)
        Me.btnSalida.Name = "btnSalida"
        Me.btnSalida.Size = New System.Drawing.Size(220, 50)
        Me.btnSalida.TabIndex = 0
        Me.btnSalida.Text = "Salidas"
        Me.btnSalida.UseVisualStyleBackColor = True
        '
        'btnEntrada
        '
        Me.btnEntrada.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEntrada.FlatAppearance.BorderSize = 0
        Me.btnEntrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntrada.Font = New System.Drawing.Font("Georgia", 9.0!)
        Me.btnEntrada.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEntrada.Image = CType(resources.GetObject("btnEntrada.Image"), System.Drawing.Image)
        Me.btnEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEntrada.Location = New System.Drawing.Point(0, 297)
        Me.btnEntrada.Name = "btnEntrada"
        Me.btnEntrada.Size = New System.Drawing.Size(220, 50)
        Me.btnEntrada.TabIndex = 0
        Me.btnEntrada.Text = "Entradas"
        Me.btnEntrada.UseVisualStyleBackColor = True
        '
        'btnTasaCambio
        '
        Me.btnTasaCambio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTasaCambio.FlatAppearance.BorderSize = 0
        Me.btnTasaCambio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTasaCambio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnTasaCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTasaCambio.Font = New System.Drawing.Font("Georgia", 9.0!)
        Me.btnTasaCambio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTasaCambio.Image = CType(resources.GetObject("btnTasaCambio.Image"), System.Drawing.Image)
        Me.btnTasaCambio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTasaCambio.Location = New System.Drawing.Point(0, 237)
        Me.btnTasaCambio.Name = "btnTasaCambio"
        Me.btnTasaCambio.Size = New System.Drawing.Size(220, 50)
        Me.btnTasaCambio.TabIndex = 0
        Me.btnTasaCambio.Text = "Tasa de Cambio"
        Me.btnTasaCambio.UseVisualStyleBackColor = True
        '
        'btnCliente
        '
        Me.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCliente.FlatAppearance.BorderSize = 0
        Me.btnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCliente.Font = New System.Drawing.Font("Georgia", 9.0!)
        Me.btnCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCliente.Image = CType(resources.GetObject("btnCliente.Image"), System.Drawing.Image)
        Me.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCliente.Location = New System.Drawing.Point(0, 177)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(220, 50)
        Me.btnCliente.TabIndex = 0
        Me.btnCliente.Text = "Clientes"
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.Location = New System.Drawing.Point(178, 0)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(42, 32)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.TabStop = False
        '
        'panelCabecera
        '
        Me.panelCabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.panelCabecera.Controls.Add(Me.btnRestaurar)
        Me.panelCabecera.Controls.Add(Me.btnMinimizar)
        Me.panelCabecera.Controls.Add(Me.btnMaximizar)
        Me.panelCabecera.Controls.Add(Me.btnCerrar)
        Me.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelCabecera.ForeColor = System.Drawing.Color.White
        Me.panelCabecera.Location = New System.Drawing.Point(0, 24)
        Me.panelCabecera.Name = "panelCabecera"
        Me.panelCabecera.Size = New System.Drawing.Size(1386, 40)
        Me.panelCabecera.TabIndex = 0
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Image = CType(resources.GetObject("btnRestaurar.Image"), System.Drawing.Image)
        Me.btnRestaurar.Location = New System.Drawing.Point(1299, 1)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(40, 40)
        Me.btnRestaurar.TabIndex = 0
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(1253, 1)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 0
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), System.Drawing.Image)
        Me.btnMaximizar.Location = New System.Drawing.Point(1299, 1)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMaximizar.TabIndex = 0
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1345, 1)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.picLogo2)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(220, 64)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1166, 706)
        Me.PanelContenedor.TabIndex = 2
        '
        'picLogo2
        '
        Me.picLogo2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picLogo2.Location = New System.Drawing.Point(167, 142)
        Me.picLogo2.Name = "picLogo2"
        Me.picLogo2.Size = New System.Drawing.Size(882, 396)
        Me.picLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo2.TabIndex = 2
        Me.picLogo2.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1386, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoDocumentoToolStripMenuItem, Me.TipoEmbalajeToolStripMenuItem, Me.TipoAlmacenamientoToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'TipoDocumentoToolStripMenuItem
        '
        Me.TipoDocumentoToolStripMenuItem.Name = "TipoDocumentoToolStripMenuItem"
        Me.TipoDocumentoToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.TipoDocumentoToolStripMenuItem.Text = "Tipo Documento"
        '
        'TipoEmbalajeToolStripMenuItem
        '
        Me.TipoEmbalajeToolStripMenuItem.Name = "TipoEmbalajeToolStripMenuItem"
        Me.TipoEmbalajeToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.TipoEmbalajeToolStripMenuItem.Text = "Tipo Embalaje"
        '
        'TipoAlmacenamientoToolStripMenuItem
        '
        Me.TipoAlmacenamientoToolStripMenuItem.Name = "TipoAlmacenamientoToolStripMenuItem"
        Me.TipoAlmacenamientoToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.TipoAlmacenamientoToolStripMenuItem.Text = "Tipo Almacenamiento"
        '
        'timerLog
        '
        Me.timerLog.Interval = 500
        '
        'btnFacturacion
        '
        Me.btnFacturacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFacturacion.FlatAppearance.BorderSize = 0
        Me.btnFacturacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacturacion.Font = New System.Drawing.Font("Georgia", 9.0!)
        Me.btnFacturacion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnFacturacion.Image = CType(resources.GetObject("btnFacturacion.Image"), System.Drawing.Image)
        Me.btnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFacturacion.Location = New System.Drawing.Point(-1, 473)
        Me.btnFacturacion.Name = "btnFacturacion"
        Me.btnFacturacion.Size = New System.Drawing.Size(220, 50)
        Me.btnFacturacion.TabIndex = 0
        Me.btnFacturacion.Text = "Facturación"
        Me.btnFacturacion.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(-1, 473)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 50)
        Me.Panel6.TabIndex = 3
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 770)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.panelCabecera)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = " bn"
        Me.panelMenu.ResumeLayout(False)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCabecera.ResumeLayout(False)
        Me.PanelContenedor.ResumeLayout(False)
        CType(Me.picLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmMostrarMenu As Timer
    Friend WithEvents tmOcultarMenu As Timer
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents btnCliente As Button
    Friend WithEvents btnTasaCambio As Button
    Friend WithEvents btnEntrada As Button
    Friend WithEvents btnSalida As Button
    Friend WithEvents btnReporte As Button
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents panelMenu As Panel
    Friend WithEvents picLogo2 As PictureBox
    Friend WithEvents panelCabecera As Panel
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoDocumentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoEmbalajeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoAlmacenamientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents timerLog As Timer
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnFacturacion As Button
End Class
