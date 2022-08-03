Option Strict Off


Imports MySql.Data.MySqlClient
Imports System.IO



Public Class Productos

    'Private eliminar_productos As Boolean

    Dim Img As Integer
    Dim IdImagen As Integer

    'Public Sub New(ByVal _eliminar_productos As Boolean)
    '  InitializeComponent()

    '  eliminar_productos = _eliminar_productos

    'End Sub



    Sub LimpiarForm()
        TextBBuscar.Text = ""
        TextBCantidad.Text = ""
        TextBCodigoP.Text = ""
        TextBDescripcion.Text = ""
        TextBNombreP.Text = ""
        TextBPrecioCom.Text = ""
        TextBReferencia.Text = ""
        TextBPrecioVen.Text = ""
        'TextBProveedor.Text = ""
        TextBStockMin.Text = ""
        TextBStock.Text = ""
        TextBImg.Text = ""
        ComBMedida.Text = ""
        TextBCantidad.Text = ""
        PictBoxFoto.Image = Nothing

    End Sub

    Public Function ConvertImageFiletoBytes(ByVal ImageFilePath As String) As Byte()
        'funcion convierte la imagen a binario para guardar en la BD
        Dim _tempByte() As Byte = Nothing
        If String.IsNullOrEmpty(ImageFilePath) = True Then
            Throw New ArgumentNullException("La imagen no puede estar vacia", "ImageFilePath")
            Return Nothing
        End If
        Try
            Dim _fileInfo As New IO.FileInfo(ImageFilePath)
            Dim _NumBytes As Long = _fileInfo.Length
            Dim _FStream As New IO.FileStream(ImageFilePath, IO.FileMode.Open, IO.FileAccess.Read)
            Dim _BinaryReader As New IO.BinaryReader(_FStream)
            _tempByte = _BinaryReader.ReadBytes(Convert.ToInt32(_NumBytes))
            _fileInfo = Nothing
            _NumBytes = 0
            _FStream.Close()
            _FStream.Dispose()
            _BinaryReader.Close()
            Return _tempByte
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ConvertBytesToMemoryStream(ByVal ImageData As Byte()) As IO.MemoryStream
        Try
            If IsNothing(ImageData) = True Then
                Return Nothing
                'Throw New ArgumentNullException("La imagen no puede estar vacia", "ImageData")
            End If
            Return New System.IO.MemoryStream(ImageData)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ConvertImageFiletoMemoryStream(ByVal ImageFilePath As String) As IO.MemoryStream
        If String.IsNullOrEmpty(ImageFilePath) = True Then
            Return Nothing
            'Throw New ArgumentNullException("La imagen no puede estar vacia", "ImageFilePath")
        End If
        Return ConvertBytesToMemoryStream(ConvertImageFiletoBytes(ImageFilePath))
    End Function


    Sub BuscarImagenBD(ByVal idImagen As Integer)
        Dim Conn As MySql.Data.MySqlClient.MySqlConnection
        Conn = New MySql.Data.MySqlClient.MySqlConnection

        Try
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.ConnectionString = "server=localhost; database=superpoter; user=root; password=123456;  port=3306;"
            Conn.Open()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Connect")
        End Try

        Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        adapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM imagenes WHERE id = " & TextBImg.Text & ";", Conn)

        Dim Data As New DataTable
        Dim commandbuild As New MySql.Data.MySqlClient.MySqlCommandBuilder(adapter)
        adapter.Fill(Data)

        If Data.Rows.Count > 0 Then
            'cargo la imagen
            Dim lb() As Byte = Data.Rows(Data.Rows.Count - 1).Item("foto")
            Dim lstr As New System.IO.MemoryStream(lb)
            'cargo la imagen en el picture
            PictBoxFoto.Image = Image.FromStream(lstr)
            PictBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage
            lstr.Close()
        Else
            MsgBox("NO HAY IMAGEN")
        End If
    End Sub

    Sub GuardarimagenBD()
        If TxtPathImg.Text <> "" Then

            'informo el path del archivo de imagen a la funcion
            Dim filename As String = TxtPathImg.Text
            Dim FileSize As UInt32

            Dim Conn As MySql.Data.MySqlClient.MySqlConnection
            Conn = New MySql.Data.MySqlClient.MySqlConnection

            Try
                If Conn.State = ConnectionState.Open Then Conn.Close()
                Conn.ConnectionString = "server=localhost; database=superpoter; user=root; password=123456;  port=3306;"
                Conn.Open()

            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Connect")
            End Try

            Dim mstream As System.IO.MemoryStream = ConvertImageFiletoMemoryStream(filename)

            Dim arrImage() As Byte = ConvertImageFiletoBytes(filename)

            FileSize = mstream.Length

            Dim sqlcmd As New MySql.Data.MySqlClient.MySqlCommand
            Dim sql As String
            mstream.Close()

            sql = "insert into imagenes (foto, tam_archivo, nom_archivo) VALUES(@Archi, @TamArchi, @nomArchi)"


            Try

                With sqlcmd
                    .CommandText = sql
                    .Connection = Conn
                    .Parameters.AddWithValue("@NomArchi", filename)
                    .Parameters.AddWithValue("@TamArchi", FileSize)
                    .Parameters.AddWithValue("@Archi", arrImage)
                    .ExecuteNonQuery()
                End With

                TxtPathImg.Text = ""
                PictBoxFoto.Image = Nothing


                Conn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub
    Sub CargarListView()

        Try

            Call conectar()
            conexion.Open()

            Dim Comando As New MySqlCommand

            Comando.Connection = conexion

            Comando.CommandType = CommandType.Text

            Comando.CommandText = "select * from productos order by nombreproducto;"

            Dim DReader As MySqlDataReader

            DReader = Comando.ExecuteReader

            If DReader.HasRows Then

                LVProductos.Items.Clear()

                Dim LV As New ListViewItem

                Do While DReader.Read
                    LV = LVProductos.Items.Add(DReader("codigo_producto"))
                    LV.SubItems.Add(DReader("nombreproducto"))
                    LV.SubItems.Add(DReader("precio_costo"))
                    LV.SubItems.Add(DReader("stock"))
                    LV.SubItems.Add(DReader("estado_producto"))
                Loop
            Else

            End If

            DReader.Close()

            conexion.Close()

        Catch ex As Exception

            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub
    Sub BuscarCodigo()
        Try

            Call conectar()
            conexion.Open()

            Dim Comando As New MySqlCommand

            Comando.Connection = conexion

            Comando.CommandType = CommandType.Text

            Comando.CommandText = "select * from productos where codigo_producto = '" & TextBBuscar.Text & "' ;"

            Dim DReader As MySqlDataReader

            DReader = Comando.ExecuteReader

            If DReader.HasRows Then

                DReader.Read()
                TextBCodigoP.Text = DReader("codigo_producto")
                TextBNombreP.Text = DReader("nombreproducto")
                TextBDescripcion.Text = DReader("descripcion")
                TextBReferencia.Text = DReader("referencia_producto")
                ComBMedida.Text = DReader("unidad_medida")
                TextBPrecioCom.Text = DReader("precio_costo")
                TextBPrecioVen.Text = DReader("precio_venta")
                TextBStockMin.Text = DReader("stock_minimo")
                TextBStock.Text = DReader("stock")


                If IsDBNull(DReader("imagen")) = False Then
                    TextBImg.Text = DReader("imagen")
                    Call BuscarImagenBD(TextBImg.Text)

                Else
                    MsgBox("Producto sin imagen", MsgBoxStyle.Exclamation)

                End If

            Else
                MsgBox("El Producto no existe")
            End If

            DReader.Close()

            conexion.Close()

        Catch ex As Exception

            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub
    Sub BuscarNombre()
        Try

            Call conectar()
            conexion.Open()

            Dim Comando As New MySqlCommand

            Comando.Connection = conexion

            Comando.CommandType = CommandType.Text

            Comando.CommandText = "select * from productos where nombreproducto = '" & TextBBuscar.Text & "' ;"

            Dim DReader As MySqlDataReader

            DReader = Comando.ExecuteReader

            If DReader.HasRows Then

                DReader.Read()
                TextBCodigoP.Text = DReader("codigo_producto")
                TextBNombreP.Text = DReader("nombreproducto")
                TextBDescripcion.Text = DReader("descripcion")
                TextBReferencia.Text = DReader("referencia_producto")
                ComBMedida.Text = DReader("unidad_medida")
                'TextBProveedor.Text = DReader("proveedor")
                TextBPrecioCom.Text = DReader("precio_costo")
                TextBPrecioVen.Text = DReader("precio_venta")
                TextBStockMin.Text = DReader("stock_minimo")
                TextBStock.Text = DReader("stock")

            Else
                MsgBox("El Producto no existe")
            End If

            DReader.Close()

            conexion.Close()

        Catch ex As Exception

            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BntEliminar.Enabled = eliminar_productos
    End Sub


    Private Sub BntBuscar_Click(sender As Object, e As EventArgs) Handles BntBuscar.Click
        If TextBBuscar.Text <> "" Then
            Call BuscarCodigo()
        End If

    End Sub

    Private Sub BntLimpiar_Click(sender As Object, e As EventArgs) Handles BntLimpiar.Click
        TextBBuscar.Text = ""
    End Sub



    Private Sub BntClear_Click(sender As Object, e As EventArgs) Handles BntClear.Click
        Call LimpiarForm()
    End Sub

    Private Sub TextBCodigoP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBCodigoP.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede Digitar Numeros")
        End If
    End Sub

    Private Sub ComBMedida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComBMedida.SelectedIndexChanged

    End Sub

    Private Sub BntAgregar_Click(sender As Object, e As EventArgs) Handles BntAgregar.Click
        If TextBCodigoP.Text = "" And TextBNombreP.Text = "" And TextBPrecioCom.Text = "" And TextBPrecioVen.Text = "" And TextBStock.Text = "" Then
            MsgBox("INGRESE TODOS LOS DATOS", MsgBoxStyle.Critical)
        Else

            Try
                Call conectar()

                conexion.Open()

                Dim Comando As New MySqlCommand

                Comando.Connection = conexion

                Comando.CommandType = CommandType.Text

                'Primero controlo que el registro exista
                Comando.CommandText = "select * from productos where codigo_producto = '" & TextBCodigoP.Text & "';"

                Dim DReader As MySqlDataReader

                'el metodo ExecuteReader trae los datos de la BD
                DReader = Comando.ExecuteReader

                If DReader.HasRows Then
                    MsgBox("El registro ya existe", MsgBoxStyle.Critical)
                    'cierro el Datareader
                    DReader.Close()

                Else
                    DReader.Close()

                    If TxtPathImg.Text <> "" Then

                        Call GuardarimagenBD()

                        Comando.CommandText = "select id from imagenes order by id desc limit 1;"
                        'el metodo ExecuteReader trae los datos de la BD
                        DReader = Comando.ExecuteReader
                        'consulto si trajo registros
                        If DReader.HasRows Then
                            'utilizo el DataReader para "mostrar" los datos 
                            DReader.Read()
                            IdImagen = DReader("id")
                            'cierro el Datareader
                            DReader.Close()

                        End If

                        'cargo la sentencia para agregar un registro
                        Comando.CommandText = "insert into productos (codigo_producto, nombreproducto, descripcion, referencia_producto, unidad_medida, precio_costo, precio_venta, stock_minimo, stock, estado_producto, imagen) values ('" & TextBCodigoP.Text & "','" & TextBNombreP.Text & "','" & TextBDescripcion.Text & "','" & TextBReferencia.Text & "', '" & ComBMedida.Text & "', '" & TextBPrecioCom.Text & "' , '" & TextBPrecioVen.Text & "' , '" & TextBStockMin.Text & "' , '" & TextBStock.Text & "' , 'activo' , '" & IdImagen & "' );"

                    Else
                        'cargo la sentencia para agregar un registro
                        Comando.CommandText = "insert into productos (codigo_producto, nombreproducto, descripcion, referencia_producto, unidad_medida, precio_costo, precio_venta, stock_minimo, stock, estado_producto) values ('" & TextBCodigoP.Text & "','" & TextBNombreP.Text & "','" & TextBDescripcion.Text & "','" & TextBReferencia.Text & "', '" & ComBMedida.Text & "', '" & TextBPrecioCom.Text & "' , '" & TextBPrecioVen.Text & "' , '" & TextBStockMin.Text & "' , '" & TextBStock.Text & "' , 'activo' );"
                    End If


                    'variable para recibir respuesta de ejecucion
                    Dim resultado As Integer
                    'el metodo ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion 
                    resultado = Comando.ExecuteNonQuery
                    MsgBox("Registros Agregados: " & resultado)


                End If
                'refresco el list 
                Call LimpiarForm()
                'limpio imagen
                TxtPathImg.Text = ""
                Call CargarListView()
                'BntInsertarF.Enabled = False



                'cierro la conexion
                conexion.Close()

            Catch ex As Exception
                'Si hay un error muestro el mensaje
                MsgBox(ex.Message)
                conexion.Close()
            End Try
        End If
    End Sub




    Private Sub BntInsertarF_Click(sender As Object, e As EventArgs) Handles BntInsertarF.Click
        'abro la ventana de busqueda 
        If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            'cargo en el text el Path de la Imagen
            TxtPathImg.Text = OpenFileDialog1.FileName
            'cargo la imagen en el picturebox 
            PictBoxFoto.ImageLocation = TxtPathImg.Text
            PictBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BntEliminarF_Click(sender As Object, e As EventArgs) Handles BntEliminarF.Click
        TxtPathImg.Text = ""
        PictBoxFoto.Image = Nothing
    End Sub


    Private Sub BntModificar_Click(sender As Object, e As EventArgs) Handles BntModificar.Click
        If TextBCodigoP.Text = "" And TextBNombreP.Text = "" And TextBPrecioCom.Text = "" And TextBPrecioVen.Text = "" And TextBStock.Text = "" Then
            MsgBox("INGRESE TODOS LOS DATOS", MsgBoxStyle.Critical)
        Else
            Try
                Call conectar()

                conexion.Open()

                Dim Comando As New MySqlCommand

                Comando.Connection = conexion

                Comando.CommandType = CommandType.Text

                'Primero controlo que el registro exista
                Comando.CommandText = "select * from productos where codigo_producto = '" & TextBCodigoP.Text & "';"

                Dim DReader As MySqlDataReader

                DReader = Comando.ExecuteReader

                Dim imag As Integer

                If DReader.HasRows Then

                    DReader.Read()

                    If IsDBNull(DReader("imagen")) = False Then
                        imag = DReader("imagen")

                    Else
                        imag = 0
                    End If

                    DReader.Close()

                    If TxtPathImg.Text <> "" Then

                        If imag > 0 Then

                            Comando.CommandText = "update productos set imagen = null where codigo_producto = '" & TextBCodigoP.Text & "';"
                            Comando.ExecuteNonQuery()

                            Comando.CommandText = "delete from imagenes where id = " & imag
                            Comando.ExecuteNonQuery()
                        End If


                        Call GuardarimagenBD()

                        Comando.CommandText = "select id from imagenes order by id desc limit 1;"
                        'el metodo ExecuteReader trae los datos de la BD
                        DReader = Comando.ExecuteReader
                        'consulto si trajo registros
                        If DReader.HasRows Then
                            'utilizo el DataReader para "mostrar" los datos 
                            DReader.Read()
                            IdImagen = DReader("id")
                            'cierro el Datareader
                            DReader.Close()
                        End If
                        'End If

                        'If TxtPathImg.Text <> "" Then
                        'Cargo la sentencia para modificar un registro
                        Comando.CommandText = "update productos set nombreproducto = '" & TextBNombreP.Text & "', descripcion = '" & TextBDescripcion.Text & "', referencia_producto = '" & TextBReferencia.Text & "', unidad_medida = '" & ComBMedida.Text & "', precio_costo = '" & TextBPrecioCom.Text & "', precio_venta = '" & TextBPrecioVen.Text & "', stock_minimo = '" & TextBStockMin.Text & "', stock = '" & TextBStock.Text & "', estado_producto = 'activo', imagen= '" & IdImagen & "' where codigo_producto = '" & TextBCodigoP.Text & "';"
                    Else
                        'Cargo la sentencia para modificar un registro
                        Comando.CommandText = "update productos set nombreproducto = '" & TextBNombreP.Text & "', descripcion = '" & TextBDescripcion.Text & "', referencia_producto = '" & TextBReferencia.Text & "', unidad_medida = '" & ComBMedida.Text & "', precio_costo = '" & TextBPrecioCom.Text & "', precio_venta = '" & TextBPrecioVen.Text & "', stock_minimo = '" & TextBStockMin.Text & "', stock = '" & TextBStock.Text & "', estado_producto = 'activo' where codigo_producto = '" & TextBCodigoP.Text & "';"
                    End If

                    'variable para recibir respuesta de ejecucion
                    Dim resultado As Integer
                    'el metodo ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion 
                    resultado = Comando.ExecuteNonQuery
                    MsgBox("Registros modificados: " & resultado)

                    'refresco el list 
                    'Call CargarGrilla("select * from productos order by id_productos;")
                    Call LimpiarForm()
                Else
                    MsgBox("El registro no existe", MsgBoxStyle.Critical)
                    'cierro el datareader
                    DReader.Close()
                End If
                'cierro la conexion
                conexion.Close()

                Call LimpiarForm()
                Call CargarListView()
                TxtPathImg.Text = ""

                conexion.Close()

            Catch ex As Exception
                'Si hay un error muestro el mensaje
                MsgBox(ex.Message)
                conexion.Close()
            End Try

        End If
    End Sub

    Private Sub BntEntrada_Click(sender As Object, e As EventArgs) Handles BntEntrada.Click
        If TextBCantidad.Text = "" Or TextBStock.Text = "" Then
            MsgBox("ingrese datos", MsgBoxStyle.Critical)
        End If

        Dim a As Integer
        Dim b As Integer

        a = TextBCantidad.Text
        b = TextBStock.Text
        TextBStock.Text = a + b
        TextBCantidad.Text = ""


        If TextBCodigoP.Text = "" And TextBNombreP.Text = "" Then
            MsgBox("INGRESE TODOS LOS DATOS", MsgBoxStyle.Critical)
        Else

            Try
                Call conectar()

                conexion.Open()

                Dim Comando As New MySqlCommand

                Comando.Connection = conexion

                Comando.CommandType = CommandType.Text

                'Primero controlo que el registro exista
                Comando.CommandText = "select * from productos where codigo_producto = '" & TextBCodigoP.Text & "';"

                Dim DReader As MySqlDataReader

                'el metodo ExecuteReader trae los datos de la BD
                DReader = Comando.ExecuteReader

                If DReader.HasRows Then

                    'cierro el Datareader
                    DReader.Close()


                End If

                If TextBStock.Text <> "" Then
                    'cargo la sentencia para agregar un registro
                    Comando.CommandText = "update productos set stock = '" & TextBStock.Text & "' where codigo_producto = '" & TextBCodigoP.Text & "';"
                Else
                    MsgBox("Sin Datos", MsgBoxStyle.Critical)
                End If


                'variable para recibir respuesta de ejecucion
                Dim resultado As Integer
                'el metodo ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion 
                resultado = Comando.ExecuteNonQuery
                MsgBox("Registros Agregados: " & resultado)

                'refresco el list 
                Call LimpiarForm()
                'limpio imagen
                TxtPathImg.Text = ""
                Call CargarListView()
                'BntInsertarF.Enabled = False



                'cierro la conexion
                conexion.Close()

            Catch ex As Exception
                'Si hay un error muestro el mensaje
                MsgBox(ex.Message)
                conexion.Close()
            End Try
        End If
    End Sub

    Private Sub BntSalida_Click(sender As Object, e As EventArgs) Handles BntSalida.Click
        If TextBCantidad.Text = "" Or TextBStock.Text = "" Then
            MsgBox("ingrese datos", MsgBoxStyle.Critical)
        End If

        Dim a As Integer
        Dim b As Integer

        a = TextBCantidad.Text
        b = TextBStock.Text
        TextBStock.Text = b - a
        TextBCantidad.Text = ""


        If TextBCodigoP.Text = "" And TextBNombreP.Text = "" Then
            MsgBox("INGRESE TODOS LOS DATOS", MsgBoxStyle.Critical)
        Else

            Try
                Call conectar()

                conexion.Open()

                Dim Comando As New MySqlCommand

                Comando.Connection = conexion

                Comando.CommandType = CommandType.Text

                'Primero controlo que el registro exista
                Comando.CommandText = "select * from productos where codigo_producto = '" & TextBCodigoP.Text & "';"

                Dim DReader As MySqlDataReader

                'el metodo ExecuteReader trae los datos de la BD
                DReader = Comando.ExecuteReader

                If DReader.HasRows Then

                    'cierro el Datareader
                    DReader.Close()


                End If

                If TextBStock.Text <> "" Then
                    'cargo la sentencia para agregar un registro
                    Comando.CommandText = "update productos set stock = '" & TextBStock.Text & "' where codigo_producto = '" & TextBCodigoP.Text & "';"
                Else
                    MsgBox("Sin Datos", MsgBoxStyle.Critical)
                End If


                'variable para recibir respuesta de ejecucion
                Dim resultado As Integer
                'el metodo ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion 
                resultado = Comando.ExecuteNonQuery
                MsgBox("Registros Agregados: " & resultado)

                'refresco el list 
                Call LimpiarForm()
                'limpio imagen
                TxtPathImg.Text = ""
                Call CargarListView()
                'BntInsertarF.Enabled = False



                'cierro la conexion
                conexion.Close()

            Catch ex As Exception
                'Si hay un error muestro el mensaje
                MsgBox(ex.Message)
                conexion.Close()
            End Try
        End If
    End Sub

    Private Sub BntListar_Click(sender As Object, e As EventArgs) Handles BntListar.Click

        Call CargarListView()
    End Sub

    Private Sub TextBDescripcion_TextChanged(sender As Object, e As EventArgs) Handles TextBDescripcion.TextChanged

    End Sub

    Private Sub BntEliminar_Click(sender As Object, e As EventArgs) Handles BntEliminar.Click

        Dim result As Integer

        Try
            Call conectar()

            conexion.Open()

            Dim Comando As New MySqlCommand

            Comando.Connection = conexion

            Comando.CommandType = CommandType.Text

            'Primero controlo que el registro exista
            Comando.CommandText = "select * from productos where codigo_producto = '" & TextBCodigoP.Text & "';"

            Dim DReader As MySqlDataReader

            DReader = Comando.ExecuteReader

            If DReader.HasRows Then

                'cierro el Datareader
                DReader.Close()
                'cargo la sentencia para modificar un registro
                Comando.CommandText = "UPDATE productos set estado_producto = ' No activo '  WHERE codigo_producto = '" & TextBCodigoP.Text & "';"

                'el metodo ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion 
                result = Comando.ExecuteNonQuery
                MsgBox("Registros Agregados: " & result)
            Else
                MsgBox("NO ENCONTRADO", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            'Si hay un error muestro el mensaje
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub

    Private Sub LVProductos_Click(sender As Object, e As EventArgs) Handles LVProductos.Click

    End Sub

    Private Sub LVProductos_MouseClick(sender As Object, e As MouseEventArgs) Handles LVProductos.MouseClick
        Try

            Call conectar()
            conexion.Open()

            Dim Comando As New MySqlCommand

            Comando.Connection = conexion

            Comando.CommandType = CommandType.Text

            Comando.CommandText = "select * from productos where codigo_producto like '" & LVProductos.SelectedItems(0).Text & "';"

            Dim DReader As MySqlDataReader

            DReader = Comando.ExecuteReader

            If DReader.HasRows Then
                'Call LimpiarForm()
                DReader.Read()
                TextBCodigoP.Text = DReader("codigo_producto")
                TextBNombreP.Text = DReader("nombreproducto")
                TextBDescripcion.Text = DReader("descripcion")
                TextBReferencia.Text = DReader("referencia_producto")
                ComBMedida.Text = DReader("unidad_medida")
                TextBPrecioCom.Text = DReader("precio_costo")
                TextBPrecioVen.Text = DReader("precio_venta")
                TextBStockMin.Text = DReader("stock_minimo")
                TextBStock.Text = DReader("stock")
            Else
                MsgBox("El Socio no existe")
            End If

            DReader.Close()

            conexion.Close()

        Catch ex As Exception

            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub

    Private Sub LVProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LVProductos.SelectedIndexChanged

    End Sub
End Class