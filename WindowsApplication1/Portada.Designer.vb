<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Portada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Portada))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.BtnVentas = New System.Windows.Forms.Button()
        Me.BtnProveedor = New System.Windows.Forms.Button()
        Me.BtnProductos = New System.Windows.Forms.Button()
        Me.BtnCliente = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panelcontenedor = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblNombreUs = New System.Windows.Forms.Label()
        Me.LblNombreRol = New System.Windows.Forms.Label()
        Me.LblID = New System.Windows.Forms.Label()
        Me.PanelMenu.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panelcontenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.LblID)
        Me.PanelMenu.Controls.Add(Me.LblNombreRol)
        Me.PanelMenu.Controls.Add(Me.BtnVentas)
        Me.PanelMenu.Controls.Add(Me.BtnProveedor)
        Me.PanelMenu.Controls.Add(Me.BtnProductos)
        Me.PanelMenu.Controls.Add(Me.BtnCliente)
        Me.PanelMenu.Controls.Add(Me.Panel3)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(154, 549)
        Me.PanelMenu.TabIndex = 0
        '
        'BtnVentas
        '
        Me.BtnVentas.BackgroundImage = CType(resources.GetObject("BtnVentas.BackgroundImage"), System.Drawing.Image)
        Me.BtnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnVentas.FlatAppearance.BorderSize = 0
        Me.BtnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVentas.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentas.Location = New System.Drawing.Point(0, 266)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Size = New System.Drawing.Size(154, 46)
        Me.BtnVentas.TabIndex = 4
        Me.BtnVentas.Text = "Ventas"
        Me.BtnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVentas.UseVisualStyleBackColor = True
        '
        'BtnProveedor
        '
        Me.BtnProveedor.BackgroundImage = CType(resources.GetObject("BtnProveedor.BackgroundImage"), System.Drawing.Image)
        Me.BtnProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnProveedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnProveedor.FlatAppearance.BorderSize = 0
        Me.BtnProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProveedor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProveedor.Location = New System.Drawing.Point(0, 220)
        Me.BtnProveedor.Name = "BtnProveedor"
        Me.BtnProveedor.Size = New System.Drawing.Size(154, 46)
        Me.BtnProveedor.TabIndex = 3
        Me.BtnProveedor.Text = "Proveedores"
        Me.BtnProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnProveedor.UseVisualStyleBackColor = True
        '
        'BtnProductos
        '
        Me.BtnProductos.BackgroundImage = CType(resources.GetObject("BtnProductos.BackgroundImage"), System.Drawing.Image)
        Me.BtnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnProductos.FlatAppearance.BorderSize = 0
        Me.BtnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProductos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductos.Location = New System.Drawing.Point(0, 174)
        Me.BtnProductos.Name = "BtnProductos"
        Me.BtnProductos.Size = New System.Drawing.Size(154, 46)
        Me.BtnProductos.TabIndex = 2
        Me.BtnProductos.Text = "Productos"
        Me.BtnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnProductos.UseVisualStyleBackColor = True
        '
        'BtnCliente
        '
        Me.BtnCliente.BackgroundImage = CType(resources.GetObject("BtnCliente.BackgroundImage"), System.Drawing.Image)
        Me.BtnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCliente.FlatAppearance.BorderSize = 0
        Me.BtnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCliente.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCliente.Location = New System.Drawing.Point(0, 128)
        Me.BtnCliente.Name = "BtnCliente"
        Me.BtnCliente.Size = New System.Drawing.Size(154, 46)
        Me.BtnCliente.TabIndex = 1
        Me.BtnCliente.Text = "Clientes"
        Me.BtnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCliente.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_05_07_at_12_281
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel3.Controls.Add(Me.LblNombreUs)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(154, 128)
        Me.Panel3.TabIndex = 0
        '
        'Panelcontenedor
        '
        Me.Panelcontenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Panelcontenedor.Controls.Add(Me.Panel1)
        Me.Panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panelcontenedor.Location = New System.Drawing.Point(154, 0)
        Me.Panelcontenedor.Name = "Panelcontenedor"
        Me.Panelcontenedor.Size = New System.Drawing.Size(1049, 549)
        Me.Panelcontenedor.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1049, 24)
        Me.Panel1.TabIndex = 0
        '
        'LblNombreUs
        '
        Me.LblNombreUs.AutoSize = True
        Me.LblNombreUs.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreUs.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblNombreUs.Location = New System.Drawing.Point(29, 4)
        Me.LblNombreUs.Name = "LblNombreUs"
        Me.LblNombreUs.Size = New System.Drawing.Size(0, 16)
        Me.LblNombreUs.TabIndex = 0
        '
        'LblNombreRol
        '
        Me.LblNombreRol.AutoSize = True
        Me.LblNombreRol.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreRol.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblNombreRol.Location = New System.Drawing.Point(27, 528)
        Me.LblNombreRol.Name = "LblNombreRol"
        Me.LblNombreRol.Size = New System.Drawing.Size(0, 16)
        Me.LblNombreRol.TabIndex = 1
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblID.Location = New System.Drawing.Point(142, 527)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(0, 16)
        Me.LblID.TabIndex = 5
        '
        'Portada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1203, 549)
        Me.Controls.Add(Me.Panelcontenedor)
        Me.Controls.Add(Me.PanelMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(25, 25)
        Me.Name = "Portada"
        Me.Text = "Portada"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panelcontenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMenu As System.Windows.Forms.Panel
    Friend WithEvents BtnCliente As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panelcontenedor As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnVentas As System.Windows.Forms.Button
    Friend WithEvents BtnProveedor As System.Windows.Forms.Button
    Friend WithEvents BtnProductos As System.Windows.Forms.Button
    Friend WithEvents LblNombreUs As System.Windows.Forms.Label
    Friend WithEvents LblNombreRol As System.Windows.Forms.Label
    Friend WithEvents LblID As System.Windows.Forms.Label
End Class
