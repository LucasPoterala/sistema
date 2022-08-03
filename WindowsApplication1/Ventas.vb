Imports MySql.Data.MySqlClient
Public Class Ventas
    
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Lblidven.Text = id
        Try
            Call conectar()
            conexion.Open()
            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()
        End Try

        MTxtBFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")

        Try

            Call conectar()
            conexion.Open()

            Dim Comando As New MySqlCommand

            Comando.Connection = conexion

            Comando.CommandType = CommandType.Text

            Comando.CommandText = "select num_factura from detalle_factura order by num_factura desc limit 1"

            Dim DReader As MySqlDataReader

            DReader = Comando.ExecuteReader

            If DReader.HasRows Then

                DReader.Read()
                TxtBNFactura.Text = DReader("num_factura") + 1
            Else
                TxtBNFactura.Text = 1
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub
    Private Sub ClearForm()
        TxtBNCliente.Text = ""
        MTxtBCUIT.Text = ""
        MTxtBTelefono.Text = ""
        TxtBNombre.Text = ""
        TxtBDireccion.Text = ""
        ComBoxFPago.Text = ""
        ComBoxTipo.Text = ""
        TxtBCodigoP.Text = ""
        TxtBCantidad.Text = ""

    End Sub
    Private Sub Suma()
        Dim suma As Double
        Dim i As Integer
        suma = 0
        For i = 0 To LVDetalles.Items.Count - 1
            suma = suma + CDbl(LVDetalles.Items(i).SubItems(5).Text)
        Next
        TxtBTotal.Text = suma
    End Sub

    Private Sub TxtBCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBCantidad.KeyPress
        'If Not Char.IsNumber(e.KeyChar) Then

        'e.Handled = True

        'MessageBox.Show("Introduzca sólo valores númericos")

        'End If
    End Sub

    Private Sub BntBuscar_Click(sender As Object, e As EventArgs) Handles BntBuscar.Click
        If TxtBNCliente.Text = "" Then
            MsgBox("Ingrese el numero de Cliente", MsgBoxStyle.Exclamation)
        Else

            Try
                Call conectar()
                conexion.Open()

                Dim Comando As New MySqlCommand

                Comando.Connection = conexion

                Comando.CommandType = CommandType.Text

                Comando.CommandText = "select * from clientes where id_cliente like '" + TxtBNCliente.Text + "%' ;"

                Dim DReader As MySqlDataReader

                DReader = Comando.ExecuteReader

                If DReader.HasRows Then

                    DReader.Read()
                    MTxtBCUIT.Text = DReader("cuit_cli")
                    MTxtBTelefono.Text = DReader("tel_cli")
                    TxtBNombre.Text = DReader("rz_cli")
                    TxtBDireccion.Text = DReader("domi_cli")

                Else
                    MsgBox("El Cliente no esta registrado")
                    TxtBNCliente.Text = ""
                End If


                DReader.Close()

                conexion.Close()

            Catch ex As Exception

                MsgBox(ex.Message)
                conexion.Close()

            End Try
        End If
    End Sub

    Private Sub BntCargar_Click(sender As Object, e As EventArgs) Handles BntCargar.Click

        Dim Cod As String
        Dim desc As String
        Dim precio As String
        Dim Unidad As String
        Dim stock As Integer
        Dim cant As Integer

        If TxtBCodigoP.Text = "" And TxtBCantidad.Text = "" Then
            MsgBox("Ingrese el codigo de producto y la cantidad a vender", MsgBoxStyle.Exclamation)
        Else

            Try

                Call conectar()
                conexion.Open()

                Dim Comando As New MySqlCommand

                Comando.Connection = conexion

                Comando.CommandType = CommandType.Text

                Comando.CommandText = "select * from productos where codigo_producto = '" & TxtBCodigoP.Text & "' ;"

                Dim DReader As MySqlDataReader

                DReader = Comando.ExecuteReader

                If DReader.HasRows Then

                    DReader.Read()
                    Cod = DReader("codigo_producto")
                    desc = DReader("nombreproducto")
                    precio = DReader("precio_venta")
                    Unidad = DReader("unidad_medida")
                    stock = DReader("stock")

                    cant = TxtBCantidad.Text
                    stock = stock - cant

                    Dim LV As New ListViewItem


                    LV = LVDetalles.Items.Add(Cod)
                    LV.SubItems.Add(desc)
                    LV.SubItems.Add(TxtBCantidad.Text)
                    LV.SubItems.Add(FormatCurrency(precio))
                    LV.SubItems.Add("0")
                    LV.SubItems.Add(precio * TxtBCantidad.Text)

                    TxtBCodigoP.Text = ""
                    TxtBCantidad.Text = ""

                    Call Suma()
                    TxtBNeto.Text = TxtBTotal.Text

                    Comando.CommandText = " update productos set codigo_producto = '" & TxtBCodigoP.Text & "' where stock = '" & stock & "';"

                Else
                    MsgBox("El articulo no esta registrado")
                End If

                DReader.Close()

                conexion.Close()


            Catch ex As Exception

                MsgBox(ex.Message)
                conexion.Close()
            End Try
        End If
    End Sub

    Private Sub TxtBTotal_TextChanged(sender As Object, e As EventArgs) Handles TxtBTotal.TextChanged

    End Sub

    Private Sub BntImprimir_Click(sender As Object, e As EventArgs) Handles BntImprimir.Click
        PrintVistaPrevia.Document = PrintDImpFac

        PrintVistaPrevia.Show()
    End Sub

    Private Sub PrintDImpFac_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDImpFac.PrintPage
        If TxtBNFactura.Text = "" Or ComBoxFPago.Text = "" Or TxtBNombre.Text = "" Then
            MsgBox("INGRESE TODOS LOS DATOS", MsgBoxStyle.Critical)

        Else

            Dim i As Integer
            Dim codigo As Integer
            Dim descripcion As String
            Dim precioventa As Double
            Dim cant As Integer
            Dim subtotal As Integer


            Try
                Call conectar()

                conexion.Open()

                Dim Comando As New MySqlCommand

                Comando.Connection = conexion

                Comando.CommandType = CommandType.Text

                Comando.CommandText = "select * from detalle_factura where num_factura = '" & Trim(TxtBNFactura.Text) & "';"

                Dim DReader As MySqlDataReader

                DReader = Comando.ExecuteReader

                If DReader.HasRows Then

                    MsgBox("EL REGISTRO YA EXISTE", MsgBoxStyle.Critical)

                    DReader.Close()

                Else
                    DReader.Close()

                    Dim resultado As Integer

                    For i = 0 To LVDetalles.Items.Count - 1
                        codigo = LVDetalles.Items(i).SubItems(0).Text
                        descripcion = LVDetalles.Items(i).SubItems(1).Text
                        cant = LVDetalles.Items(i).SubItems(2).Text
                        precioventa = LVDetalles.Items(i).SubItems(3).Text
                        subtotal = LVDetalles.Items(i).SubItems(5).Text
                        'cargo la sentencia para agregar un registro
                        Comando.CommandText = "Insert into detalle_factura (Num_factura, Fecha, Tipo_F, Codigo_producto, Codigo_cli, Cantidad_pedido, f_pago, Precio_total, Precio_neto, usuario) values (" & TxtBNFactura.Text & ",'" & MTxtBFecha.Text & "','" & ComBoxTipo.Text & "','" & codigo & "','" & TxtBNCliente.Text & "','" & cant & "','" & ComBoxFPago.Text & "','" & precioventa & "','" & subtotal & "' , '" & id & "');"
                        'el metodo ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion 
                        resultado = Comando.ExecuteNonQuery


                        'cargo la sentencia para modificar un registro
                        Comando.CommandText = "UPDATE productos set stock = stock - " & cant & "  WHERE (codigo_producto = " & codigo & ");"
                        'el metodo ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion 
                        resultado = Comando.ExecuteNonQuery


                    Next


                    MsgBox("Registros Agregados: " & resultado)

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                conexion.Close()
            End Try

            Try

                Dim prFont As New Font("Arial", 30, FontStyle.Bold)


                e.Graphics.DrawString("B", prFont, Brushes.Black, 400, 50)
                prFont = New Font("Arial", 20, FontStyle.Bold)
                e.Graphics.DrawString("FACTURA", prFont, Brushes.Black, 450, 50)

                'fecha y hora
                prFont = New Font("Arial", 15, FontStyle.Bold)
                e.Graphics.DrawString("FECHA", prFont, Brushes.Black, 400, 150)

                prFont = New Font("Arial", 15, FontStyle.Bold)
                e.Graphics.DrawString(Date.Now.ToShortDateString.ToString & " " & _
                                    Date.Now.ToShortTimeString.ToString, prFont, Brushes.Black, 600, 150)

                'datos empresa
                prFont = New Font("Arial", 15, FontStyle.Bold)
                e.Graphics.DrawString("CUIT", prFont, Brushes.Black, 400, 175)
                e.Graphics.DrawString("27-34450886-6", prFont, Brushes.Black, 600, 175)
                e.Graphics.DrawString("Ing. Brutos N°", prFont, Brushes.Black, 400, 200)
                e.Graphics.DrawString("27-34450886-6", prFont, Brushes.Black, 600, 200)
                e.Graphics.DrawString("Inico de Actividades", prFont, Brushes.Black, 400, 225)
                e.Graphics.DrawString("01 / 01 / 2017", prFont, Brushes.Black, 600, 225)
                prFont = New Font("arial", 10, FontStyle.Bold)
                e.Graphics.DrawString("Numero Factura:  " & TxtBNFactura.Text, prFont, Brushes.Black, 70, 225)
                prFont = New Font("arial", 18, FontStyle.Bold)
                e.Graphics.DrawString("SUBTOTAL:  " & TxtBTotal.Text, prFont, Brushes.Black, 550, 950)
                e.Graphics.DrawString("DESCUENTO:  " & TxtBDesc.Text, prFont, Brushes.Black, 550, 975)
                e.Graphics.DrawString("TOTAL:  " & TxtBNeto.Text, prFont, Brushes.Black, 550, 1000)


                'logo
                'himg = Image.load("nito.ico")
                'Paint.brushes = Paint.image(himg, 50, 50)
                'e.Graphics.DrawImage("nito.ico")
                prFont = New Font("arial black", 72, FontStyle.Bold)
                'e.Graphics.DrawString("GUIAR", prFont, Brushes.Black, 20, 50)
                e.Graphics.DrawImage(Imagen.PictureBLogo.Image, 10, 100, 200, 200)
                prFont = New Font("arial black", 20, FontStyle.Bold)
                'e.Graphics.DrawString("DISTRIBUCIONES", prFont, Brushes.Black, 100, 170)


                'datos cliente
                prFont = New Font("Arial", 15, FontStyle.Bold)
                e.Graphics.DrawString("SEÑOR/ES:   " & TxtBNombre.Text.ToString, prFont, Brushes.Black, 50, 270)
                e.Graphics.DrawString("CUIT/CUIL:   " & MTxtBCUIT.Text.ToString, prFont, Brushes.Black, 50, 295)
                e.Graphics.DrawString("DOMICILIO:   " & TxtBDireccion.Text.ToString, prFont, Brushes.Black, 50, 320)

                prFont = New Font("Arial", 15, FontStyle.Bold)
                e.Graphics.DrawString("TELEFONO:      " & MTxtBTelefono.Text.ToString, prFont, Brushes.Black, 50, 375)
                'e.Graphics.DrawString("CUIT:      " & LblCuitCli.Text.ToString, prFont, Brushes.Black, 500, 375)

                'lineas
                prFont = New Font("Arial", 15, FontStyle.Bold)
                e.Graphics.DrawLine(Pens.Black, 10, 365, 1060, 365)
                e.Graphics.DrawLine(Pens.Black, 10, 250, 1060, 250)
                e.Graphics.DrawLine(Pens.Black, 400, 110, 1060, 110)
                e.Graphics.DrawLine(Pens.Black, 400, 5, 400, 250)
                e.Graphics.DrawLine(Pens.Black, 10, 410, 1060, 410)

                Dim H As Integer = 0
                H = 450

                For Each itm As ListViewItem In LVDetalles.Items
                    e.Graphics.DrawString(itm.Text, New Drawing.Font("arial", 12), Brushes.Black, 50, H)
                    e.Graphics.DrawString(itm.SubItems(1).Text, New Drawing.Font("arial", 12), Brushes.Black, 150, H)
                    e.Graphics.DrawString(itm.SubItems(2).Text, New Drawing.Font("arial", 12), Brushes.Black, 300, H)
                    e.Graphics.DrawString(itm.SubItems(3).Text, New Drawing.Font("arial", 12), Brushes.Black, 400, H)
                    e.Graphics.DrawString(itm.SubItems(4).Text, New Drawing.Font("arial", 12), Brushes.Black, 500, H)
                    e.Graphics.DrawString(itm.SubItems(5).Text, New Drawing.Font("arial", 12), Brushes.Black, 600, H)
                    H += 20
                Next

                e.HasMorePages = False

            Catch ex As Exception
                MessageBox.Show("ERROR: " & ex.Message, "Administrador", _
                                  MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BntBorrar_Click(sender As Object, e As EventArgs) Handles BntBorrar.Click
        Call ClearForm()
        LVDetalles.Items.Clear()
    End Sub

    Private Sub BntEliminar_Click(sender As Object, e As EventArgs) Handles BntEliminar.Click
        Dim lista As ListViewItem = New ListViewItem()

        For Each lista In LVDetalles.SelectedItems
            lista.Remove()
        Next
        TxtBTotal.Text = ""
        TxtBDesc.Text = ""
        TxtBNeto.Text = ""
    End Sub

    Private Sub BntProductos_Click(sender As Object, e As EventArgs) Handles BntProductos.Click
        Dim frm As New ListarProductos
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub TxtBCantidad_TextChanged(sender As Object, e As EventArgs) Handles TxtBCantidad.TextChanged

    End Sub
End Class