
Imports MySql.Data.MySqlClient
Public Class ListarProductos

    Dim ex, ey As Integer

    Dim arrastre As Boolean

    Sub BuscarNombre()
        Try

            Call conectar()
            conexion.Open()

            Dim Comando As New MySqlCommand

            Comando.Connection = conexion

            Comando.CommandType = CommandType.Text

            Comando.CommandText = "select * from productos where nombreproducto = '" & TextBoxNomb.Text & "' ;"

            Dim DReader As MySqlDataReader

            DReader = Comando.ExecuteReader

            If DReader.HasRows Then

                DReader.Read()
                TextBoxCod.Text = DReader("codigo_producto")
                TextBoxDes.Text = DReader("nombreproducto")
                TextBoxPre.Text = DReader("precio_venta")

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
    Sub CargarListView()

        'Dim estado As Char

        Try

            Call conectar()
            conexion.Open()

            Dim Comando As New MySqlCommand

            Comando.Connection = conexion

            Comando.CommandType = CommandType.Text

            Comando.CommandText = "select * from productos where estado_producto = 'activo' order by nombreproducto;"

            Dim DReader As MySqlDataReader

            DReader = Comando.ExecuteReader

            If DReader.HasRows Then

                
                LVProVen.Items.Clear()

                Dim LV As New ListViewItem

                Do While DReader.Read
                    LV = LVProVen.Items.Add(DReader("codigo_producto"))
                    LV.SubItems.Add(DReader("nombreproducto"))
                    LV.SubItems.Add(DReader("precio_venta"))
                    LV.SubItems.Add(DReader("stock"))
                    'LV.SubItems.Add(DReader("estado_producto"))
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
    Private Sub ListarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargarListView()
    End Sub

   

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BntSelec_Click(sender As Object, e As EventArgs)
        'If TextBCodLV.Text <> "" Then

        'Portada.TextBox1.Text = TextBCodLV.Text

        'Me.Close()
        'Else
        'MsgBox("Seleccione un Producto", MsgBoxStyle.Information)
        'End If
    End Sub

    Private Sub LVProVen_DoubleClick(sender As Object, e As EventArgs) Handles LVProVen.DoubleClick
        Dim frm As Ventas = CType(Owner, Ventas)
        frm.TxtBCodigoP.Text = LVProVen.SelectedItems(0).Text
        Me.Close()
    End Sub

    Private Sub ListarProductos_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X

        ey = e.Y

        arrastre = True
    End Sub

    Private Sub ListarProductos_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        arrastre = False
    End Sub

    Private Sub ListarProductos_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If arrastre Then Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - ex, Control.MousePosition.Y - Me.Location.Y - ey))
    End Sub

    Private Sub BtnCloseList_Click(sender As Object, e As EventArgs) Handles BtnCloseList.Click
        Me.Close()
    End Sub

    Private Sub BntBusc_Click(sender As Object, e As EventArgs) Handles BntBusc.Click
        Call BuscarNombre()
    End Sub

    Private Sub BntSelec_Click_1(sender As Object, e As EventArgs) Handles BntSelec.Click
        Dim frm As Ventas = CType(Owner, Ventas)
        frm.TxtBCodigoP.Text = TextBoxCod.Text
        Me.Close()
    End Sub
End Class