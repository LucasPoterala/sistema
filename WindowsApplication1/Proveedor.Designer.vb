<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proveedor))
        Me.TextBRazon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBNumEnte = New System.Windows.Forms.TextBox()
        Me.TextBCUIT = New System.Windows.Forms.TextBox()
        Me.CmBTipo = New System.Windows.Forms.ComboBox()
        Me.CmBRubro = New System.Windows.Forms.ComboBox()
        Me.CmBPais = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBTel = New System.Windows.Forms.TextBox()
        Me.TextBDireccion = New System.Windows.Forms.TextBox()
        Me.CmBProvincia = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ListVProveedor = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BntBuscar = New System.Windows.Forms.Button()
        Me.BntEliminar = New System.Windows.Forms.Button()
        Me.BntModificar = New System.Windows.Forms.Button()
        Me.BntAgregar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblID = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBRazon
        '
        Me.TextBRazon.Location = New System.Drawing.Point(12, 79)
        Me.TextBRazon.Name = "TextBRazon"
        Me.TextBRazon.Size = New System.Drawing.Size(227, 20)
        Me.TextBRazon.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(407, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PROVEEDORES"
        '
        'TextBNumEnte
        '
        Me.TextBNumEnte.Location = New System.Drawing.Point(572, 79)
        Me.TextBNumEnte.Name = "TextBNumEnte"
        Me.TextBNumEnte.Size = New System.Drawing.Size(227, 20)
        Me.TextBNumEnte.TabIndex = 2
        '
        'TextBCUIT
        '
        Me.TextBCUIT.Location = New System.Drawing.Point(295, 79)
        Me.TextBCUIT.Name = "TextBCUIT"
        Me.TextBCUIT.Size = New System.Drawing.Size(227, 20)
        Me.TextBCUIT.TabIndex = 3
        '
        'CmBTipo
        '
        Me.CmBTipo.FormattingEnabled = True
        Me.CmBTipo.Items.AddRange(New Object() {"Persona Fisica", "Sociedad de Hecho", "Cooperativas", "Union Transitoria de Empresas", "Talleres Protegidos", "Sociedad Anonima", "Sociedad de Responsabilidad Limitada", "Otras Formas Societarias", "Persona Fisica Extranjera no residente en el Pais", "Persona Fisica Extranjera Sin Sucursal en el Pais", "Organismo Público", "Otros"})
        Me.CmBTipo.Location = New System.Drawing.Point(13, 134)
        Me.CmBTipo.Name = "CmBTipo"
        Me.CmBTipo.Size = New System.Drawing.Size(226, 21)
        Me.CmBTipo.TabIndex = 4
        '
        'CmBRubro
        '
        Me.CmBRubro.FormattingEnabled = True
        Me.CmBRubro.Items.AddRange(New Object() {"ALIMENTOS", "AGRIC. GANADERIA, CAZA, SILVICULT", "ARTICULOS DEL HOGAR", "BAZAR MENAJE", "CARPINTERIA", "CERRAJERIA", "COMBUSTIBLES Y LUBRICANTES", "CONSTRUCCION", "ELECTRICIDAD", "ELEMENTOS DE LIMPIEZA", "EQUIPOS DE OFICINA", "INFORMATICA ", "LIBRERIA", "REPUESTOS AUT", "OTROS"})
        Me.CmBRubro.Location = New System.Drawing.Point(295, 134)
        Me.CmBRubro.Name = "CmBRubro"
        Me.CmBRubro.Size = New System.Drawing.Size(226, 21)
        Me.CmBRubro.TabIndex = 5
        '
        'CmBPais
        '
        Me.CmBPais.FormattingEnabled = True
        Me.CmBPais.Items.AddRange(New Object() {"Argentina"})
        Me.CmBPais.Location = New System.Drawing.Point(572, 134)
        Me.CmBPais.Name = "CmBPais"
        Me.CmBPais.Size = New System.Drawing.Size(226, 21)
        Me.CmBPais.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(13, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Razon Social / Nombre y Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(297, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "CUIL / CUIT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(575, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Numero Ente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(13, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tipo de Proveedor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(297, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Rubro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(569, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Provincia"
        '
        'TextBTel
        '
        Me.TextBTel.Location = New System.Drawing.Point(12, 186)
        Me.TextBTel.Name = "TextBTel"
        Me.TextBTel.Size = New System.Drawing.Size(227, 20)
        Me.TextBTel.TabIndex = 13
        '
        'TextBDireccion
        '
        Me.TextBDireccion.Location = New System.Drawing.Point(294, 186)
        Me.TextBDireccion.Name = "TextBDireccion"
        Me.TextBDireccion.Size = New System.Drawing.Size(227, 20)
        Me.TextBDireccion.TabIndex = 14
        '
        'CmBProvincia
        '
        Me.CmBProvincia.FormattingEnabled = True
        Me.CmBProvincia.Items.AddRange(New Object() {"Buenos Aires", "Catamarca", "Chaco", "Chubut", "Córdoba", "Corrientes", "Entre Ríos", "Formosa", "Jujuy", "La Pampa", "La Rioja", "Mendoza", "Misiones", "Neuquén", "Río Negro", "Salta", "San Juan", "San Luis", "Santa Cruz", "Santa Fe", "Santiago del Estero", "Tierra del Fuego, Antártida e Islas del Atlántico Sur", "Tucumán"})
        Me.CmBProvincia.Location = New System.Drawing.Point(572, 185)
        Me.CmBProvincia.Name = "CmBProvincia"
        Me.CmBProvincia.Size = New System.Drawing.Size(226, 21)
        Me.CmBProvincia.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(569, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Pais"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(13, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Telefono"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(297, 167)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Direccion / Domicilio"
        '
        'ListVProveedor
        '
        Me.ListVProveedor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListVProveedor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListVProveedor.GridLines = True
        Me.ListVProveedor.Location = New System.Drawing.Point(16, 240)
        Me.ListVProveedor.Name = "ListVProveedor"
        Me.ListVProveedor.Size = New System.Drawing.Size(783, 261)
        Me.ListVProveedor.TabIndex = 19
        Me.ListVProveedor.UseCompatibleStateImageBehavior = False
        Me.ListVProveedor.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CUIT/CUIL"
        Me.ColumnHeader1.Width = 118
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nro Ente"
        Me.ColumnHeader2.Width = 90
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Razon Social"
        Me.ColumnHeader3.Width = 360
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Tipo"
        Me.ColumnHeader4.Width = 125
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BntBuscar)
        Me.GroupBox1.Controls.Add(Me.BntEliminar)
        Me.GroupBox1.Controls.Add(Me.BntModificar)
        Me.GroupBox1.Controls.Add(Me.BntAgregar)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(825, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 433)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Control"
        '
        'BntBuscar
        '
        Me.BntBuscar.BackColor = System.Drawing.Color.Navy
        Me.BntBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BntBuscar.FlatAppearance.BorderSize = 0
        Me.BntBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.BntBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BntBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BntBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BntBuscar.Image = CType(resources.GetObject("BntBuscar.Image"), System.Drawing.Image)
        Me.BntBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BntBuscar.Location = New System.Drawing.Point(18, 261)
        Me.BntBuscar.Name = "BntBuscar"
        Me.BntBuscar.Size = New System.Drawing.Size(164, 52)
        Me.BntBuscar.TabIndex = 3
        Me.BntBuscar.Text = "BUSCAR"
        Me.BntBuscar.UseVisualStyleBackColor = False
        '
        'BntEliminar
        '
        Me.BntEliminar.BackColor = System.Drawing.Color.Navy
        Me.BntEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BntEliminar.FlatAppearance.BorderSize = 0
        Me.BntEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.BntEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BntEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BntEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BntEliminar.Image = CType(resources.GetObject("BntEliminar.Image"), System.Drawing.Image)
        Me.BntEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BntEliminar.Location = New System.Drawing.Point(18, 190)
        Me.BntEliminar.Name = "BntEliminar"
        Me.BntEliminar.Size = New System.Drawing.Size(164, 52)
        Me.BntEliminar.TabIndex = 2
        Me.BntEliminar.Text = "ELIMINAR"
        Me.BntEliminar.UseVisualStyleBackColor = False
        '
        'BntModificar
        '
        Me.BntModificar.BackColor = System.Drawing.Color.Navy
        Me.BntModificar.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BntModificar.FlatAppearance.BorderSize = 0
        Me.BntModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.BntModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BntModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BntModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BntModificar.Image = CType(resources.GetObject("BntModificar.Image"), System.Drawing.Image)
        Me.BntModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BntModificar.Location = New System.Drawing.Point(18, 119)
        Me.BntModificar.Name = "BntModificar"
        Me.BntModificar.Size = New System.Drawing.Size(164, 52)
        Me.BntModificar.TabIndex = 1
        Me.BntModificar.Text = "MODIFICAR"
        Me.BntModificar.UseVisualStyleBackColor = False
        '
        'BntAgregar
        '
        Me.BntAgregar.BackColor = System.Drawing.Color.Navy
        Me.BntAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BntAgregar.FlatAppearance.BorderSize = 0
        Me.BntAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.BntAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BntAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BntAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BntAgregar.Image = CType(resources.GetObject("BntAgregar.Image"), System.Drawing.Image)
        Me.BntAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BntAgregar.Location = New System.Drawing.Point(18, 48)
        Me.BntAgregar.Name = "BntAgregar"
        Me.BntAgregar.Size = New System.Drawing.Size(164, 52)
        Me.BntAgregar.TabIndex = 0
        Me.BntAgregar.Text = "AGREGAR"
        Me.BntAgregar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(821, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 23)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "ID"
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblID.Location = New System.Drawing.Point(884, 23)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(0, 23)
        Me.LblID.TabIndex = 22
        '
        'Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1049, 549)
        Me.Controls.Add(Me.LblID)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListVProveedor)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CmBProvincia)
        Me.Controls.Add(Me.TextBDireccion)
        Me.Controls.Add(Me.TextBTel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmBPais)
        Me.Controls.Add(Me.CmBRubro)
        Me.Controls.Add(Me.CmBTipo)
        Me.Controls.Add(Me.TextBCUIT)
        Me.Controls.Add(Me.TextBNumEnte)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBRazon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Proveedor"
        Me.Text = "Proveedor"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBRazon As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBNumEnte As System.Windows.Forms.TextBox
    Friend WithEvents TextBCUIT As System.Windows.Forms.TextBox
    Friend WithEvents CmBTipo As System.Windows.Forms.ComboBox
    Friend WithEvents CmBRubro As System.Windows.Forms.ComboBox
    Friend WithEvents CmBPais As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBTel As System.Windows.Forms.TextBox
    Friend WithEvents TextBDireccion As System.Windows.Forms.TextBox
    Friend WithEvents CmBProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ListVProveedor As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BntAgregar As System.Windows.Forms.Button
    Friend WithEvents BntBuscar As System.Windows.Forms.Button
    Friend WithEvents BntEliminar As System.Windows.Forms.Button
    Friend WithEvents BntModificar As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LblID As System.Windows.Forms.Label
End Class
