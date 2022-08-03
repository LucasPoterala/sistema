<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtBDireccion = New System.Windows.Forms.TextBox()
        Me.MTxtBTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.MTxtBCUIT = New System.Windows.Forms.MaskedTextBox()
        Me.BntBuscar = New System.Windows.Forms.Button()
        Me.TxtBNombre = New System.Windows.Forms.TextBox()
        Me.TxtBNCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComBoxTipo = New System.Windows.Forms.ComboBox()
        Me.ComBoxFPago = New System.Windows.Forms.ComboBox()
        Me.TxtBNFactura = New System.Windows.Forms.TextBox()
        Me.MTxtBFecha = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtBPagoCon = New System.Windows.Forms.TextBox()
        Me.TxtBDevolver = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtBNeto = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtBTotal = New System.Windows.Forms.TextBox()
        Me.TxtBDesc = New System.Windows.Forms.TextBox()
        Me.BntGuardar = New System.Windows.Forms.Button()
        Me.TxtBCodigoP = New System.Windows.Forms.TextBox()
        Me.BntImprimir = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BntBorrar = New System.Windows.Forms.Button()
        Me.LVDetalles = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtBCantidad = New System.Windows.Forms.TextBox()
        Me.BntProductos = New System.Windows.Forms.Button()
        Me.BntCargar = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintVistaPrevia = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDImpFac = New System.Drawing.Printing.PrintDocument()
        Me.BntEliminar = New System.Windows.Forms.Button()
        Me.Lblidven = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtBDireccion)
        Me.GroupBox1.Controls.Add(Me.MTxtBTelefono)
        Me.GroupBox1.Controls.Add(Me.MTxtBCUIT)
        Me.GroupBox1.Controls.Add(Me.BntBuscar)
        Me.GroupBox1.Controls.Add(Me.TxtBNombre)
        Me.GroupBox1.Controls.Add(Me.TxtBNCliente)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 180)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'TxtBDireccion
        '
        Me.TxtBDireccion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBDireccion.Location = New System.Drawing.Point(91, 141)
        Me.TxtBDireccion.Name = "TxtBDireccion"
        Me.TxtBDireccion.Size = New System.Drawing.Size(257, 22)
        Me.TxtBDireccion.TabIndex = 9
        '
        'MTxtBTelefono
        '
        Me.MTxtBTelefono.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTxtBTelefono.Location = New System.Drawing.Point(91, 112)
        Me.MTxtBTelefono.Mask = "(999)000-00000"
        Me.MTxtBTelefono.Name = "MTxtBTelefono"
        Me.MTxtBTelefono.Size = New System.Drawing.Size(257, 22)
        Me.MTxtBTelefono.TabIndex = 8
        '
        'MTxtBCUIT
        '
        Me.MTxtBCUIT.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTxtBCUIT.Location = New System.Drawing.Point(91, 84)
        Me.MTxtBCUIT.Mask = "00-00000000-0"
        Me.MTxtBCUIT.Name = "MTxtBCUIT"
        Me.MTxtBCUIT.Size = New System.Drawing.Size(257, 22)
        Me.MTxtBCUIT.TabIndex = 7
        '
        'BntBuscar
        '
        Me.BntBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BntBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BntBuscar.FlatAppearance.BorderSize = 0
        Me.BntBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.BntBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BntBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BntBuscar.Image = CType(resources.GetObject("BntBuscar.Image"), System.Drawing.Image)
        Me.BntBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BntBuscar.Location = New System.Drawing.Point(382, 10)
        Me.BntBuscar.Name = "BntBuscar"
        Me.BntBuscar.Size = New System.Drawing.Size(41, 40)
        Me.BntBuscar.TabIndex = 21
        Me.BntBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BntBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BntBuscar.UseVisualStyleBackColor = True
        '
        'TxtBNombre
        '
        Me.TxtBNombre.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBNombre.Location = New System.Drawing.Point(91, 56)
        Me.TxtBNombre.Name = "TxtBNombre"
        Me.TxtBNombre.Size = New System.Drawing.Size(257, 22)
        Me.TxtBNombre.TabIndex = 6
        '
        'TxtBNCliente
        '
        Me.TxtBNCliente.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBNCliente.Location = New System.Drawing.Point(91, 28)
        Me.TxtBNCliente.Name = "TxtBNCliente"
        Me.TxtBNCliente.Size = New System.Drawing.Size(257, 22)
        Me.TxtBNCliente.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Dirección:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CUIT / CUIL:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Telefono:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro Cliente:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComBoxTipo)
        Me.GroupBox2.Controls.Add(Me.ComBoxFPago)
        Me.GroupBox2.Controls.Add(Me.TxtBNFactura)
        Me.GroupBox2.Controls.Add(Me.MTxtBFecha)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(483, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(313, 179)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Factura "
        '
        'ComBoxTipo
        '
        Me.ComBoxTipo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComBoxTipo.FormattingEnabled = True
        Me.ComBoxTipo.Items.AddRange(New Object() {"B"})
        Me.ComBoxTipo.Location = New System.Drawing.Point(161, 108)
        Me.ComBoxTipo.Name = "ComBoxTipo"
        Me.ComBoxTipo.Size = New System.Drawing.Size(130, 24)
        Me.ComBoxTipo.TabIndex = 11
        '
        'ComBoxFPago
        '
        Me.ComBoxFPago.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComBoxFPago.FormattingEnabled = True
        Me.ComBoxFPago.Items.AddRange(New Object() {"EFECTIVO", "DEBITO", "CREDITO", "MERCADOPAGO", "CHEQUE"})
        Me.ComBoxFPago.Location = New System.Drawing.Point(161, 78)
        Me.ComBoxFPago.Name = "ComBoxFPago"
        Me.ComBoxFPago.Size = New System.Drawing.Size(130, 24)
        Me.ComBoxFPago.TabIndex = 10
        '
        'TxtBNFactura
        '
        Me.TxtBNFactura.Enabled = False
        Me.TxtBNFactura.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBNFactura.Location = New System.Drawing.Point(161, 48)
        Me.TxtBNFactura.Name = "TxtBNFactura"
        Me.TxtBNFactura.Size = New System.Drawing.Size(131, 22)
        Me.TxtBNFactura.TabIndex = 9
        '
        'MTxtBFecha
        '
        Me.MTxtBFecha.Enabled = False
        Me.MTxtBFecha.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTxtBFecha.Location = New System.Drawing.Point(161, 17)
        Me.MTxtBFecha.Mask = "00/00/0000"
        Me.MTxtBFecha.Name = "MTxtBFecha"
        Me.MTxtBFecha.Size = New System.Drawing.Size(97, 22)
        Me.MTxtBFecha.TabIndex = 8
        Me.MTxtBFecha.ValidatingType = GetType(Date)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Tipo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Forma de Pago:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Nro de Factura:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Fecha:"
        '
        'TxtBPagoCon
        '
        Me.TxtBPagoCon.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TxtBPagoCon.ForeColor = System.Drawing.Color.Lime
        Me.TxtBPagoCon.Location = New System.Drawing.Point(93, 12)
        Me.TxtBPagoCon.Name = "TxtBPagoCon"
        Me.TxtBPagoCon.Size = New System.Drawing.Size(101, 20)
        Me.TxtBPagoCon.TabIndex = 6
        '
        'TxtBDevolver
        '
        Me.TxtBDevolver.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TxtBDevolver.ForeColor = System.Drawing.Color.Lime
        Me.TxtBDevolver.Location = New System.Drawing.Point(93, 38)
        Me.TxtBDevolver.Name = "TxtBDevolver"
        Me.TxtBDevolver.Size = New System.Drawing.Size(101, 20)
        Me.TxtBDevolver.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 15)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Pago con:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 15)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Devolver:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(350, 250)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 15)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Detalle"
        '
        'TxtBNeto
        '
        Me.TxtBNeto.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TxtBNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBNeto.ForeColor = System.Drawing.Color.Lime
        Me.TxtBNeto.Location = New System.Drawing.Point(89, 207)
        Me.TxtBNeto.Name = "TxtBNeto"
        Me.TxtBNeto.Size = New System.Drawing.Size(101, 29)
        Me.TxtBNeto.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(2, 221)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 15)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Neto a pagar:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(2, 189)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 15)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Descuento:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(2, 158)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 15)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Total:"
        '
        'TxtBTotal
        '
        Me.TxtBTotal.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TxtBTotal.ForeColor = System.Drawing.Color.Lime
        Me.TxtBTotal.Location = New System.Drawing.Point(89, 158)
        Me.TxtBTotal.Name = "TxtBTotal"
        Me.TxtBTotal.Size = New System.Drawing.Size(101, 20)
        Me.TxtBTotal.TabIndex = 15
        '
        'TxtBDesc
        '
        Me.TxtBDesc.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TxtBDesc.ForeColor = System.Drawing.Color.Lime
        Me.TxtBDesc.Location = New System.Drawing.Point(89, 184)
        Me.TxtBDesc.Name = "TxtBDesc"
        Me.TxtBDesc.Size = New System.Drawing.Size(101, 20)
        Me.TxtBDesc.TabIndex = 16
        '
        'BntGuardar
        '
        Me.BntGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BntGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BntGuardar.FlatAppearance.BorderSize = 0
        Me.BntGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.BntGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BntGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BntGuardar.Image = CType(resources.GetObject("BntGuardar.Image"), System.Drawing.Image)
        Me.BntGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BntGuardar.Location = New System.Drawing.Point(286, 418)
        Me.BntGuardar.Name = "BntGuardar"
        Me.BntGuardar.Size = New System.Drawing.Size(87, 40)
        Me.BntGuardar.TabIndex = 18
        Me.BntGuardar.Text = "Guardar"
        Me.BntGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BntGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BntGuardar.UseVisualStyleBackColor = True
        '
        'TxtBCodigoP
        '
        Me.TxtBCodigoP.Location = New System.Drawing.Point(77, 15)
        Me.TxtBCodigoP.Name = "TxtBCodigoP"
        Me.TxtBCodigoP.Size = New System.Drawing.Size(153, 20)
        Me.TxtBCodigoP.TabIndex = 19
        '
        'BntImprimir
        '
        Me.BntImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BntImprimir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BntImprimir.FlatAppearance.BorderSize = 0
        Me.BntImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.BntImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BntImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BntImprimir.Image = CType(resources.GetObject("BntImprimir.Image"), System.Drawing.Image)
        Me.BntImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BntImprimir.Location = New System.Drawing.Point(25, 414)
        Me.BntImprimir.Name = "BntImprimir"
        Me.BntImprimir.Size = New System.Drawing.Size(83, 40)
        Me.BntImprimir.TabIndex = 20
        Me.BntImprimir.Text = "Imprimir"
        Me.BntImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BntImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BntImprimir.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 16)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Codigo:"
        '
        'BntBorrar
        '
        Me.BntBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BntBorrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BntBorrar.FlatAppearance.BorderSize = 0
        Me.BntBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.BntBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BntBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BntBorrar.Image = CType(resources.GetObject("BntBorrar.Image"), System.Drawing.Image)
        Me.BntBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BntBorrar.Location = New System.Drawing.Point(149, 418)
        Me.BntBorrar.Name = "BntBorrar"
        Me.BntBorrar.Size = New System.Drawing.Size(83, 40)
        Me.BntBorrar.TabIndex = 25
        Me.BntBorrar.Text = "Borrar"
        Me.BntBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BntBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BntBorrar.UseVisualStyleBackColor = True
        '
        'LVDetalles
        '
        Me.LVDetalles.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.LVDetalles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.LVDetalles.FullRowSelect = True
        Me.LVDetalles.Location = New System.Drawing.Point(12, 264)
        Me.LVDetalles.Name = "LVDetalles"
        Me.LVDetalles.Size = New System.Drawing.Size(782, 144)
        Me.LVDetalles.TabIndex = 26
        Me.LVDetalles.UseCompatibleStateImageBehavior = False
        Me.LVDetalles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Codigo"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descripción"
        Me.ColumnHeader2.Width = 367
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Cantidad"
        Me.ColumnHeader3.Width = 83
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Precio"
        Me.ColumnHeader4.Width = 79
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Descuento"
        Me.ColumnHeader5.Width = 87
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Total"
        Me.ColumnHeader6.Width = 101
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtBCantidad)
        Me.GroupBox3.Controls.Add(Me.BntProductos)
        Me.GroupBox3.Controls.Add(Me.BntCargar)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.TxtBCodigoP)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 198)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(707, 54)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        '
        'TxtBCantidad
        '
        Me.TxtBCantidad.Location = New System.Drawing.Point(347, 16)
        Me.TxtBCantidad.Name = "TxtBCantidad"
        Me.TxtBCantidad.Size = New System.Drawing.Size(76, 20)
        Me.TxtBCantidad.TabIndex = 28
        '
        'BntProductos
        '
        Me.BntProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.BntProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.BntProductos.Location = New System.Drawing.Point(581, 14)
        Me.BntProductos.Name = "BntProductos"
        Me.BntProductos.Size = New System.Drawing.Size(79, 32)
        Me.BntProductos.TabIndex = 27
        Me.BntProductos.Text = "PRODUCTO"
        Me.BntProductos.UseVisualStyleBackColor = True
        '
        'BntCargar
        '
        Me.BntCargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.BntCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.BntCargar.Location = New System.Drawing.Point(474, 14)
        Me.BntCargar.Name = "BntCargar"
        Me.BntCargar.Size = New System.Drawing.Size(89, 32)
        Me.BntCargar.TabIndex = 26
        Me.BntCargar.Text = "CARGAR"
        Me.BntCargar.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(267, 15)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 16)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Cantidad:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtBTotal)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.TxtBDesc)
        Me.GroupBox4.Controls.Add(Me.TxtBPagoCon)
        Me.GroupBox4.Controls.Add(Me.TxtBNeto)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.TxtBDevolver)
        Me.GroupBox4.Location = New System.Drawing.Point(800, 200)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(217, 258)
        Me.GroupBox4.TabIndex = 28
        Me.GroupBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(815, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 172)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'PrintVistaPrevia
        '
        Me.PrintVistaPrevia.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintVistaPrevia.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintVistaPrevia.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintVistaPrevia.Enabled = True
        Me.PrintVistaPrevia.Icon = CType(resources.GetObject("PrintVistaPrevia.Icon"), System.Drawing.Icon)
        Me.PrintVistaPrevia.Name = "PrintVistaPrevia"
        Me.PrintVistaPrevia.Visible = False
        '
        'PrintDImpFac
        '
        '
        'BntEliminar
        '
        Me.BntEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BntEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BntEliminar.FlatAppearance.BorderSize = 0
        Me.BntEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.BntEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BntEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BntEliminar.Image = CType(resources.GetObject("BntEliminar.Image"), System.Drawing.Image)
        Me.BntEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BntEliminar.Location = New System.Drawing.Point(409, 421)
        Me.BntEliminar.Name = "BntEliminar"
        Me.BntEliminar.Size = New System.Drawing.Size(87, 40)
        Me.BntEliminar.TabIndex = 30
        Me.BntEliminar.Text = "Eliminar"
        Me.BntEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BntEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BntEliminar.UseVisualStyleBackColor = True
        '
        'Lblidven
        '
        Me.Lblidven.AutoSize = True
        Me.Lblidven.Location = New System.Drawing.Point(912, 500)
        Me.Lblidven.Name = "Lblidven"
        Me.Lblidven.Size = New System.Drawing.Size(0, 13)
        Me.Lblidven.TabIndex = 31
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1055, 549)
        Me.Controls.Add(Me.Lblidven)
        Me.Controls.Add(Me.BntEliminar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.LVDetalles)
        Me.Controls.Add(Me.BntBorrar)
        Me.Controls.Add(Me.BntImprimir)
        Me.Controls.Add(Me.BntGuardar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MTxtBCUIT As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtBNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtBNCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtBDireccion As System.Windows.Forms.TextBox
    Friend WithEvents MTxtBTelefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComBoxTipo As System.Windows.Forms.ComboBox
    Friend WithEvents ComBoxFPago As System.Windows.Forms.ComboBox
    Friend WithEvents TxtBNFactura As System.Windows.Forms.TextBox
    Friend WithEvents MTxtBFecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtBPagoCon As System.Windows.Forms.TextBox
    Friend WithEvents TxtBDevolver As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtBNeto As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtBTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtBDesc As System.Windows.Forms.TextBox
    Friend WithEvents BntGuardar As System.Windows.Forms.Button
    Friend WithEvents BntImprimir As System.Windows.Forms.Button
    Friend WithEvents BntBuscar As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents BntBorrar As System.Windows.Forms.Button
    Friend WithEvents LVDetalles As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents BntCargar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BntProductos As System.Windows.Forms.Button
    Friend WithEvents TxtBCantidad As System.Windows.Forms.TextBox
    Friend WithEvents PrintVistaPrevia As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDImpFac As System.Drawing.Printing.PrintDocument
    Friend WithEvents BntEliminar As System.Windows.Forms.Button
    Public WithEvents TxtBCodigoP As System.Windows.Forms.TextBox
    Friend WithEvents Lblidven As System.Windows.Forms.Label
End Class
