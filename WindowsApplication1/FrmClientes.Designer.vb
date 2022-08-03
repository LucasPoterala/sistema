<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClientes))
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComBoxCategoria = New System.Windows.Forms.ComboBox()
        Me.ListVClientes = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TextBNombre = New System.Windows.Forms.TextBox()
        Me.TextBCUIT = New System.Windows.Forms.TextBox()
        Me.TextBTelefono = New System.Windows.Forms.TextBox()
        Me.TextBFax = New System.Windows.Forms.TextBox()
        Me.TextBEmail = New System.Windows.Forms.TextBox()
        Me.TextBDomicilio = New System.Windows.Forms.TextBox()
        Me.TextBLocalidad = New System.Windows.Forms.TextBox()
        Me.TextBProvincia = New System.Windows.Forms.TextBox()
        Me.TextBCodigoPostal = New System.Windows.Forms.TextBox()
        Me.Lblidcli = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.PicBoxCliente = New System.Windows.Forms.PictureBox()
        Me.BntRefresh = New System.Windows.Forms.Button()
        Me.BntModif = New System.Windows.Forms.Button()
        CType(Me.PicBoxCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.LblNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ForeColor = System.Drawing.Color.Black
        Me.LblNombre.Location = New System.Drawing.Point(39, 41)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(73, 19)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Categoria "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(70, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CUIT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(38, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(75, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fax"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(60, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(30, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Domicilio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(24, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 19)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Localidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(31, 298)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Provincia"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(-3, 330)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 19)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Codigo Postal"
        '
        'ComBoxCategoria
        '
        Me.ComBoxCategoria.FormattingEnabled = True
        Me.ComBoxCategoria.Location = New System.Drawing.Point(127, 103)
        Me.ComBoxCategoria.Name = "ComBoxCategoria"
        Me.ComBoxCategoria.Size = New System.Drawing.Size(305, 21)
        Me.ComBoxCategoria.TabIndex = 21
        '
        'ListVClientes
        '
        Me.ListVClientes.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListVClientes.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ListVClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListVClientes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListVClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListVClientes.FullRowSelect = True
        Me.ListVClientes.GridLines = True
        Me.ListVClientes.Location = New System.Drawing.Point(571, 43)
        Me.ListVClientes.Name = "ListVClientes"
        Me.ListVClientes.Size = New System.Drawing.Size(429, 351)
        Me.ListVClientes.TabIndex = 25
        Me.ListVClientes.UseCompatibleStateImageBehavior = False
        Me.ListVClientes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nro Cliente"
        Me.ColumnHeader1.Width = 78
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre Cliente"
        Me.ColumnHeader2.Width = 143
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "CUIT / CUIL"
        Me.ColumnHeader3.Width = 104
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Localidad"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 98
        '
        'TextBNombre
        '
        Me.TextBNombre.Location = New System.Drawing.Point(128, 43)
        Me.TextBNombre.Name = "TextBNombre"
        Me.TextBNombre.Size = New System.Drawing.Size(305, 20)
        Me.TextBNombre.TabIndex = 26
        '
        'TextBCUIT
        '
        Me.TextBCUIT.Location = New System.Drawing.Point(128, 73)
        Me.TextBCUIT.Name = "TextBCUIT"
        Me.TextBCUIT.Size = New System.Drawing.Size(305, 20)
        Me.TextBCUIT.TabIndex = 27
        '
        'TextBTelefono
        '
        Me.TextBTelefono.Location = New System.Drawing.Point(128, 137)
        Me.TextBTelefono.Name = "TextBTelefono"
        Me.TextBTelefono.Size = New System.Drawing.Size(305, 20)
        Me.TextBTelefono.TabIndex = 28
        '
        'TextBFax
        '
        Me.TextBFax.Location = New System.Drawing.Point(128, 168)
        Me.TextBFax.Name = "TextBFax"
        Me.TextBFax.Size = New System.Drawing.Size(305, 20)
        Me.TextBFax.TabIndex = 29
        '
        'TextBEmail
        '
        Me.TextBEmail.Location = New System.Drawing.Point(128, 203)
        Me.TextBEmail.Name = "TextBEmail"
        Me.TextBEmail.Size = New System.Drawing.Size(305, 20)
        Me.TextBEmail.TabIndex = 30
        '
        'TextBDomicilio
        '
        Me.TextBDomicilio.Location = New System.Drawing.Point(127, 235)
        Me.TextBDomicilio.Name = "TextBDomicilio"
        Me.TextBDomicilio.Size = New System.Drawing.Size(305, 20)
        Me.TextBDomicilio.TabIndex = 31
        '
        'TextBLocalidad
        '
        Me.TextBLocalidad.Location = New System.Drawing.Point(128, 267)
        Me.TextBLocalidad.Name = "TextBLocalidad"
        Me.TextBLocalidad.Size = New System.Drawing.Size(305, 20)
        Me.TextBLocalidad.TabIndex = 32
        '
        'TextBProvincia
        '
        Me.TextBProvincia.Location = New System.Drawing.Point(128, 300)
        Me.TextBProvincia.Name = "TextBProvincia"
        Me.TextBProvincia.Size = New System.Drawing.Size(305, 20)
        Me.TextBProvincia.TabIndex = 33
        '
        'TextBCodigoPostal
        '
        Me.TextBCodigoPostal.Location = New System.Drawing.Point(128, 329)
        Me.TextBCodigoPostal.Name = "TextBCodigoPostal"
        Me.TextBCodigoPostal.Size = New System.Drawing.Size(305, 20)
        Me.TextBCodigoPostal.TabIndex = 34
        '
        'Lblidcli
        '
        Me.Lblidcli.AutoSize = True
        Me.Lblidcli.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblidcli.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Lblidcli.Location = New System.Drawing.Point(478, 108)
        Me.Lblidcli.Name = "Lblidcli"
        Me.Lblidcli.Size = New System.Drawing.Size(0, 16)
        Me.Lblidcli.TabIndex = 35
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(450, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 16)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "ID"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiar.FlatAppearance.BorderSize = 0
        Me.BtnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Image = CType(resources.GetObject("BtnLimpiar.Image"), System.Drawing.Image)
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(453, 189)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(112, 49)
        Me.BtnLimpiar.TabIndex = 36
        Me.BtnLimpiar.Text = "BORRAR"
        Me.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.FlatAppearance.BorderSize = 0
        Me.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(453, 359)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(112, 41)
        Me.BtnSalir.TabIndex = 24
        Me.BtnSalir.Text = "SALIR"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.Location = New System.Drawing.Point(453, 245)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(112, 49)
        Me.BtnBuscar.TabIndex = 23
        Me.BtnBuscar.Text = "BUSCAR"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(453, 137)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnGuardar.Size = New System.Drawing.Size(112, 49)
        Me.BtnGuardar.TabIndex = 22
        Me.BtnGuardar.Text = "GUARDAR"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'PicBoxCliente
        '
        Me.PicBoxCliente.Location = New System.Drawing.Point(438, 3)
        Me.PicBoxCliente.Name = "PicBoxCliente"
        Me.PicBoxCliente.Size = New System.Drawing.Size(113, 101)
        Me.PicBoxCliente.TabIndex = 20
        Me.PicBoxCliente.TabStop = False
        '
        'BntRefresh
        '
        Me.BntRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BntRefresh.FlatAppearance.BorderSize = 0
        Me.BntRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BntRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BntRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BntRefresh.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BntRefresh.Image = CType(resources.GetObject("BntRefresh.Image"), System.Drawing.Image)
        Me.BntRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BntRefresh.Location = New System.Drawing.Point(732, 400)
        Me.BntRefresh.Name = "BntRefresh"
        Me.BntRefresh.Size = New System.Drawing.Size(112, 41)
        Me.BntRefresh.TabIndex = 38
        Me.BntRefresh.Text = "REFRESH"
        Me.BntRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BntRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BntRefresh.UseVisualStyleBackColor = True
        '
        'BntModif
        '
        Me.BntModif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BntModif.FlatAppearance.BorderSize = 0
        Me.BntModif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BntModif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BntModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BntModif.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BntModif.Image = CType(resources.GetObject("BntModif.Image"), System.Drawing.Image)
        Me.BntModif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BntModif.Location = New System.Drawing.Point(453, 304)
        Me.BntModif.Name = "BntModif"
        Me.BntModif.Size = New System.Drawing.Size(112, 41)
        Me.BntModif.TabIndex = 39
        Me.BntModif.Text = "EDITAR"
        Me.BntModif.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BntModif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BntModif.UseVisualStyleBackColor = True
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1049, 549)
        Me.Controls.Add(Me.BntModif)
        Me.Controls.Add(Me.BntRefresh)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.Lblidcli)
        Me.Controls.Add(Me.TextBCodigoPostal)
        Me.Controls.Add(Me.TextBProvincia)
        Me.Controls.Add(Me.TextBLocalidad)
        Me.Controls.Add(Me.TextBDomicilio)
        Me.Controls.Add(Me.TextBEmail)
        Me.Controls.Add(Me.TextBFax)
        Me.Controls.Add(Me.TextBTelefono)
        Me.Controls.Add(Me.TextBCUIT)
        Me.Controls.Add(Me.TextBNombre)
        Me.Controls.Add(Me.ListVClientes)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.ComBoxCategoria)
        Me.Controls.Add(Me.PicBoxCliente)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblNombre)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmClientes"
        Me.Text = "CLIENTES"
        CType(Me.PicBoxCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PicBoxCliente As System.Windows.Forms.PictureBox
    Friend WithEvents ComBoxCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents ListVClientes As System.Windows.Forms.ListView
    Friend WithEvents TextBNombre As System.Windows.Forms.TextBox
    Friend WithEvents TextBCUIT As System.Windows.Forms.TextBox
    Friend WithEvents TextBTelefono As System.Windows.Forms.TextBox
    Friend WithEvents TextBFax As System.Windows.Forms.TextBox
    Friend WithEvents TextBEmail As System.Windows.Forms.TextBox
    Friend WithEvents TextBDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents TextBLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents TextBProvincia As System.Windows.Forms.TextBox
    Friend WithEvents TextBCodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents Lblidcli As System.Windows.Forms.Label
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Public WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents BntRefresh As System.Windows.Forms.Button
    Friend WithEvents BntModif As System.Windows.Forms.Button
End Class
