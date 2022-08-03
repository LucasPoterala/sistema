<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBNombreP = New System.Windows.Forms.TextBox()
        Me.TextBDescripcion = New System.Windows.Forms.TextBox()
        Me.TextBCodigoP = New System.Windows.Forms.TextBox()
        Me.TextBReferencia = New System.Windows.Forms.TextBox()
        Me.TextBStockMin = New System.Windows.Forms.TextBox()
        Me.TextBPrecioCom = New System.Windows.Forms.TextBox()
        Me.TextBPrecioVen = New System.Windows.Forms.TextBox()
        Me.ComBMedida = New System.Windows.Forms.ComboBox()
        Me.TextBStock = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBImg = New System.Windows.Forms.TextBox()
        Me.TextBCantidad = New System.Windows.Forms.TextBox()
        Me.PictBoxFoto = New System.Windows.Forms.PictureBox()
        Me.BntEntrada = New System.Windows.Forms.Button()
        Me.BntSalida = New System.Windows.Forms.Button()
        Me.BntAgregar = New System.Windows.Forms.Button()
        Me.BntModificar = New System.Windows.Forms.Button()
        Me.BntEliminar = New System.Windows.Forms.Button()
        Me.BntInsertarF = New System.Windows.Forms.Button()
        Me.BntEliminarF = New System.Windows.Forms.Button()
        Me.TextBBuscar = New System.Windows.Forms.TextBox()
        Me.BntLimpiar = New System.Windows.Forms.Button()
        Me.BntBuscar = New System.Windows.Forms.Button()
        Me.BntListar = New System.Windows.Forms.Button()
        Me.BntClear = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtPathImg = New System.Windows.Forms.TextBox()
        Me.LVProductos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.PictBoxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-1, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Codigo de Barra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripcion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(288, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio de Compra"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(305, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Precio de Venta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(285, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Únidad de Medida"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Stock Minimo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Stock Actual"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(41, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 18)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Referencia"
        '
        'TextBNombreP
        '
        Me.TextBNombreP.Location = New System.Drawing.Point(136, 5)
        Me.TextBNombreP.Name = "TextBNombreP"
        Me.TextBNombreP.Size = New System.Drawing.Size(455, 20)
        Me.TextBNombreP.TabIndex = 1
        '
        'TextBDescripcion
        '
        Me.TextBDescripcion.Location = New System.Drawing.Point(136, 31)
        Me.TextBDescripcion.Name = "TextBDescripcion"
        Me.TextBDescripcion.Size = New System.Drawing.Size(455, 20)
        Me.TextBDescripcion.TabIndex = 2
        '
        'TextBCodigoP
        '
        Me.TextBCodigoP.Location = New System.Drawing.Point(136, 60)
        Me.TextBCodigoP.Name = "TextBCodigoP"
        Me.TextBCodigoP.Size = New System.Drawing.Size(152, 20)
        Me.TextBCodigoP.TabIndex = 3
        '
        'TextBReferencia
        '
        Me.TextBReferencia.Location = New System.Drawing.Point(136, 86)
        Me.TextBReferencia.Name = "TextBReferencia"
        Me.TextBReferencia.Size = New System.Drawing.Size(152, 20)
        Me.TextBReferencia.TabIndex = 4
        '
        'TextBStockMin
        '
        Me.TextBStockMin.Location = New System.Drawing.Point(136, 136)
        Me.TextBStockMin.Name = "TextBStockMin"
        Me.TextBStockMin.Size = New System.Drawing.Size(152, 20)
        Me.TextBStockMin.TabIndex = 6
        '
        'TextBPrecioCom
        '
        Me.TextBPrecioCom.Location = New System.Drawing.Point(439, 60)
        Me.TextBPrecioCom.Name = "TextBPrecioCom"
        Me.TextBPrecioCom.Size = New System.Drawing.Size(152, 20)
        Me.TextBPrecioCom.TabIndex = 7
        '
        'TextBPrecioVen
        '
        Me.TextBPrecioVen.Location = New System.Drawing.Point(439, 86)
        Me.TextBPrecioVen.Name = "TextBPrecioVen"
        Me.TextBPrecioVen.Size = New System.Drawing.Size(152, 20)
        Me.TextBPrecioVen.TabIndex = 8
        '
        'ComBMedida
        '
        Me.ComBMedida.FormattingEnabled = True
        Me.ComBMedida.Items.AddRange(New Object() {"Kilogramos", "Litros", "Unidad"})
        Me.ComBMedida.Location = New System.Drawing.Point(439, 112)
        Me.ComBMedida.Name = "ComBMedida"
        Me.ComBMedida.Size = New System.Drawing.Size(151, 21)
        Me.ComBMedida.TabIndex = 9
        '
        'TextBStock
        '
        Me.TextBStock.Location = New System.Drawing.Point(136, 112)
        Me.TextBStock.Name = "TextBStock"
        Me.TextBStock.Size = New System.Drawing.Size(152, 20)
        Me.TextBStock.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(74, 430)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 18)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Imagen"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(354, 433)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 18)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Cantidad"
        '
        'TextBImg
        '
        Me.TextBImg.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.TextBImg.Enabled = False
        Me.TextBImg.Location = New System.Drawing.Point(140, 430)
        Me.TextBImg.Name = "TextBImg"
        Me.TextBImg.Size = New System.Drawing.Size(58, 20)
        Me.TextBImg.TabIndex = 23
        '
        'TextBCantidad
        '
        Me.TextBCantidad.Location = New System.Drawing.Point(444, 431)
        Me.TextBCantidad.Name = "TextBCantidad"
        Me.TextBCantidad.Size = New System.Drawing.Size(152, 20)
        Me.TextBCantidad.TabIndex = 24
        '
        'PictBoxFoto
        '
        Me.PictBoxFoto.Location = New System.Drawing.Point(24, 215)
        Me.PictBoxFoto.Name = "PictBoxFoto"
        Me.PictBoxFoto.Size = New System.Drawing.Size(264, 207)
        Me.PictBoxFoto.TabIndex = 25
        Me.PictBoxFoto.TabStop = False
        '
        'BntEntrada
        '
        Me.BntEntrada.BackColor = System.Drawing.Color.Lime
        Me.BntEntrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.BntEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BntEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BntEntrada.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BntEntrada.Location = New System.Drawing.Point(354, 467)
        Me.BntEntrada.Name = "BntEntrada"
        Me.BntEntrada.Size = New System.Drawing.Size(110, 30)
        Me.BntEntrada.TabIndex = 26
        Me.BntEntrada.Text = "+Entrada"
        Me.BntEntrada.UseVisualStyleBackColor = False
        '
        'BntSalida
        '
        Me.BntSalida.BackColor = System.Drawing.Color.Red
        Me.BntSalida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BntSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.BntSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BntSalida.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BntSalida.Location = New System.Drawing.Point(486, 467)
        Me.BntSalida.Name = "BntSalida"
        Me.BntSalida.Size = New System.Drawing.Size(110, 30)
        Me.BntSalida.TabIndex = 27
        Me.BntSalida.Text = "-Salida"
        Me.BntSalida.UseVisualStyleBackColor = False
        '
        'BntAgregar
        '
        Me.BntAgregar.BackColor = System.Drawing.Color.RoyalBlue
        Me.BntAgregar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BntAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue
        Me.BntAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.BntAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BntAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BntAgregar.Location = New System.Drawing.Point(435, 195)
        Me.BntAgregar.Name = "BntAgregar"
        Me.BntAgregar.Size = New System.Drawing.Size(156, 31)
        Me.BntAgregar.TabIndex = 29
        Me.BntAgregar.Text = "Agregar"
        Me.BntAgregar.UseVisualStyleBackColor = False
        '
        'BntModificar
        '
        Me.BntModificar.BackColor = System.Drawing.Color.RoyalBlue
        Me.BntModificar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BntModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue
        Me.BntModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.BntModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BntModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BntModificar.Location = New System.Drawing.Point(435, 232)
        Me.BntModificar.Name = "BntModificar"
        Me.BntModificar.Size = New System.Drawing.Size(156, 31)
        Me.BntModificar.TabIndex = 30
        Me.BntModificar.Text = "Modificar"
        Me.BntModificar.UseVisualStyleBackColor = False
        '
        'BntEliminar
        '
        Me.BntEliminar.BackColor = System.Drawing.Color.RoyalBlue
        Me.BntEliminar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BntEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue
        Me.BntEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.BntEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BntEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BntEliminar.Location = New System.Drawing.Point(435, 269)
        Me.BntEliminar.Name = "BntEliminar"
        Me.BntEliminar.Size = New System.Drawing.Size(156, 31)
        Me.BntEliminar.TabIndex = 31
        Me.BntEliminar.Text = "Eliminar"
        Me.BntEliminar.UseVisualStyleBackColor = False
        '
        'BntInsertarF
        '
        Me.BntInsertarF.BackColor = System.Drawing.Color.RoyalBlue
        Me.BntInsertarF.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BntInsertarF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue
        Me.BntInsertarF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.BntInsertarF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BntInsertarF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BntInsertarF.Location = New System.Drawing.Point(301, 216)
        Me.BntInsertarF.Name = "BntInsertarF"
        Me.BntInsertarF.Size = New System.Drawing.Size(82, 31)
        Me.BntInsertarF.TabIndex = 10
        Me.BntInsertarF.Text = "Insertar Foto"
        Me.BntInsertarF.UseVisualStyleBackColor = False
        '
        'BntEliminarF
        '
        Me.BntEliminarF.BackColor = System.Drawing.Color.RoyalBlue
        Me.BntEliminarF.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BntEliminarF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue
        Me.BntEliminarF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.BntEliminarF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BntEliminarF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BntEliminarF.Location = New System.Drawing.Point(301, 253)
        Me.BntEliminarF.Name = "BntEliminarF"
        Me.BntEliminarF.Size = New System.Drawing.Size(82, 31)
        Me.BntEliminarF.TabIndex = 33
        Me.BntEliminarF.Text = "Quitar Foto"
        Me.BntEliminarF.UseVisualStyleBackColor = False
        '
        'TextBBuscar
        '
        Me.TextBBuscar.Location = New System.Drawing.Point(678, 19)
        Me.TextBBuscar.Name = "TextBBuscar"
        Me.TextBBuscar.Size = New System.Drawing.Size(247, 20)
        Me.TextBBuscar.TabIndex = 34
        '
        'BntLimpiar
        '
        Me.BntLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.BntLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BntLimpiar.Location = New System.Drawing.Point(923, 19)
        Me.BntLimpiar.Name = "BntLimpiar"
        Me.BntLimpiar.Size = New System.Drawing.Size(31, 20)
        Me.BntLimpiar.TabIndex = 35
        Me.BntLimpiar.Text = "X"
        Me.BntLimpiar.UseVisualStyleBackColor = True
        '
        'BntBuscar
        '
        Me.BntBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BntBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.BntBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BntBuscar.Image = CType(resources.GetObject("BntBuscar.Image"), System.Drawing.Image)
        Me.BntBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BntBuscar.Location = New System.Drawing.Point(982, 3)
        Me.BntBuscar.Name = "BntBuscar"
        Me.BntBuscar.Size = New System.Drawing.Size(43, 40)
        Me.BntBuscar.TabIndex = 36
        Me.BntBuscar.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BntBuscar.UseVisualStyleBackColor = True
        '
        'BntListar
        '
        Me.BntListar.BackColor = System.Drawing.Color.RoyalBlue
        Me.BntListar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BntListar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue
        Me.BntListar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.BntListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BntListar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BntListar.Location = New System.Drawing.Point(678, 417)
        Me.BntListar.Name = "BntListar"
        Me.BntListar.Size = New System.Drawing.Size(156, 31)
        Me.BntListar.TabIndex = 37
        Me.BntListar.Text = "Listar Todo"
        Me.BntListar.UseVisualStyleBackColor = False
        '
        'BntClear
        '
        Me.BntClear.BackColor = System.Drawing.Color.RoyalBlue
        Me.BntClear.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BntClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue
        Me.BntClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.BntClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BntClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BntClear.Location = New System.Drawing.Point(435, 306)
        Me.BntClear.Name = "BntClear"
        Me.BntClear.Size = New System.Drawing.Size(156, 31)
        Me.BntClear.TabIndex = 38
        Me.BntClear.Text = "Limpiar"
        Me.BntClear.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(982, 402)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 46)
        Me.Button1.TabIndex = 39
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtPathImg
        '
        Me.TxtPathImg.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.TxtPathImg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPathImg.Enabled = False
        Me.TxtPathImg.Location = New System.Drawing.Point(24, 179)
        Me.TxtPathImg.Name = "TxtPathImg"
        Me.TxtPathImg.Size = New System.Drawing.Size(405, 13)
        Me.TxtPathImg.TabIndex = 40
        '
        'LVProductos
        '
        Me.LVProductos.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.LVProductos.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.LVProductos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.LVProductos.FullRowSelect = True
        Me.LVProductos.GridLines = True
        Me.LVProductos.Location = New System.Drawing.Point(678, 60)
        Me.LVProductos.Name = "LVProductos"
        Me.LVProductos.Size = New System.Drawing.Size(347, 336)
        Me.LVProductos.TabIndex = 41
        Me.LVProductos.UseCompatibleStateImageBehavior = False
        Me.LVProductos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Codigo"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descripcion"
        Me.ColumnHeader2.Width = 104
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Precio"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Stock"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Estado"
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1049, 549)
        Me.Controls.Add(Me.LVProductos)
        Me.Controls.Add(Me.TxtPathImg)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BntClear)
        Me.Controls.Add(Me.BntListar)
        Me.Controls.Add(Me.BntBuscar)
        Me.Controls.Add(Me.BntLimpiar)
        Me.Controls.Add(Me.TextBBuscar)
        Me.Controls.Add(Me.BntEliminarF)
        Me.Controls.Add(Me.BntInsertarF)
        Me.Controls.Add(Me.BntEliminar)
        Me.Controls.Add(Me.BntModificar)
        Me.Controls.Add(Me.BntAgregar)
        Me.Controls.Add(Me.BntSalida)
        Me.Controls.Add(Me.BntEntrada)
        Me.Controls.Add(Me.PictBoxFoto)
        Me.Controls.Add(Me.TextBCantidad)
        Me.Controls.Add(Me.TextBImg)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBStock)
        Me.Controls.Add(Me.ComBMedida)
        Me.Controls.Add(Me.TextBPrecioVen)
        Me.Controls.Add(Me.TextBPrecioCom)
        Me.Controls.Add(Me.TextBStockMin)
        Me.Controls.Add(Me.TextBReferencia)
        Me.Controls.Add(Me.TextBCodigoP)
        Me.Controls.Add(Me.TextBDescripcion)
        Me.Controls.Add(Me.TextBNombreP)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Productos"
        Me.Text = " "
        CType(Me.PictBoxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBNombreP As System.Windows.Forms.TextBox
    Friend WithEvents TextBDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents TextBCodigoP As System.Windows.Forms.TextBox
    Friend WithEvents TextBReferencia As System.Windows.Forms.TextBox
    Friend WithEvents TextBStockMin As System.Windows.Forms.TextBox
    Friend WithEvents TextBPrecioCom As System.Windows.Forms.TextBox
    Friend WithEvents TextBPrecioVen As System.Windows.Forms.TextBox
    Friend WithEvents ComBMedida As System.Windows.Forms.ComboBox
    Friend WithEvents TextBStock As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBImg As System.Windows.Forms.TextBox
    Friend WithEvents TextBCantidad As System.Windows.Forms.TextBox
    Friend WithEvents PictBoxFoto As System.Windows.Forms.PictureBox
    Friend WithEvents BntEntrada As System.Windows.Forms.Button
    Friend WithEvents BntSalida As System.Windows.Forms.Button
    Friend WithEvents BntAgregar As System.Windows.Forms.Button
    Friend WithEvents BntModificar As System.Windows.Forms.Button
    Friend WithEvents BntEliminar As System.Windows.Forms.Button
    Friend WithEvents BntInsertarF As System.Windows.Forms.Button
    Friend WithEvents BntEliminarF As System.Windows.Forms.Button
    Friend WithEvents TextBBuscar As System.Windows.Forms.TextBox
    Friend WithEvents BntLimpiar As System.Windows.Forms.Button
    Friend WithEvents BntBuscar As System.Windows.Forms.Button
    Friend WithEvents BntListar As System.Windows.Forms.Button
    Friend WithEvents BntClear As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtPathImg As System.Windows.Forms.TextBox
    Friend WithEvents LVProductos As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
End Class
