Imports MySql.Data.MySqlClient
Public Class FrmClientes

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComBoxCategoria.Items.Add("Responsable Inscripto")
        ComBoxCategoria.Items.Add("Monotributista")
        ComBoxCategoria.Items.Add("Consumidor final")
        ComBoxCategoria.Items.Add("Exento")

        Call CargarList()
    End Sub
    Sub CargarList()
        Try
            Call conectar()
            conexion.Open()

            Dim Comando As New MySqlCommand

            Comando.Connection = conexion

            Comando.CommandType = CommandType.Text

            Comando.CommandText = "select * from clientes order by id_cliente asc;"

            Dim DReader As MySqlDataReader

            DReader = Comando.ExecuteReader

            If DReader.HasRows Then

                ListVClientes.Items.Clear()

                Dim LV As New ListViewItem

                Do While DReader.Read

                    LV = ListVClientes.Items.Add(DReader("id_cliente"))
                    LV.SubItems.Add(DReader("rz_cli"))
                    LV.SubItems.Add(DReader("cuit_cli"))
                    LV.SubItems.Add(DReader("loc_cli"))

                Loop


            End If

            DReader.Close()

            conexion.Close()

        Catch ex As Exception

            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Sub
    Sub LimpiarForm()
        TextBNombre.Text = ""
        TextBCUIT.Text = ""
        ComBoxCategoria.Text = ""
        TextBTelefono.Text = ""
        TextBFax.Text = ""
        TextBCodigoPostal.Text = ""
        TextBEmail.Text = ""
        TextBDomicilio.Text = ""
        TextBLocalidad.Text = ""
        TextBProvincia.Text = ""
        TextBNombre.Focus()

    End Sub
    Sub BuscarRZcli()
        Try
            Call conectar()
            conexion.Open()

            Dim Comando As New MySqlCommand

            Comando.Connection = conexion

            Comando.CommandType = CommandType.Text

            Comando.CommandText = "select * from clientes where rz_cli like '" + TextBNombre.Text + "%' ;"

            Dim DReader As MySqlDataReader

            DReader = Comando.ExecuteReader

            If DReader.HasRows Then

                DReader.Read()
                Lblidcli.Text = DReader("id_cliente")
                TextBNombre.Text = DReader("rz_cli")
                TextBCUIT.Text = DReader("cuit_cli")
                ComBoxCategoria.Text = DReader("cat_cli_iva")
                TextBTelefono.Text = DReader("tel_cli")
                TextBFax.Text = DReader("fax_cli")
                TextBCodigoPostal.Text = DReader("cod_pos_cli")
                TextBEmail.Text = DReader("email_cli")
                TextBDomicilio.Text = DReader("domi_cli")
                TextBLocalidad.Text = DReader("loc_cli")
                TextBProvincia.Text = DReader("prov_cli")
                'PicBoxCliente.Image = Image_Bytes("foto_cli")
            Else
                MsgBox("El socio no existe")
            End If

            If DReader.HasRows Then
                ListVClientes.Items.Clear()

                Dim LV As New ListViewItem

                Do While DReader.Read

                    LV = ListVClientes.Items.Add(DReader("id_cliente"))
                    LV.SubItems.Add(DReader("rz_cli"))
                    LV.SubItems.Add(DReader("cuit_cli"))
                    LV.SubItems.Add(DReader("loc_cli"))
                Loop
            End If


            DReader.Close()

            conexion.Close()

        Catch ex As Exception

            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Sub
    Sub BuscarCUIT()
        Try
            Call conectar()
            conexion.Open()

            Dim Comando As New MySqlCommand

            Comando.Connection = conexion

            Comando.CommandType = CommandType.Text

            Comando.CommandText = "select * from clientes where cuit_cli like '" + TextBCUIT.Text + "%' ;"

            Dim DReader As MySqlDataReader

            DReader = Comando.ExecuteReader

            If DReader.HasRows Then

                DReader.Read()
                Lblidcli.Text = DReader("id_cliente")
                TextBNombre.Text = DReader("rz_cli")
                TextBCUIT.Text = DReader("cuit_cli")
                ComBoxCategoria.Text = DReader("cat_cli_iva")
                TextBTelefono.Text = DReader("tel_cli")
                TextBFax.Text = DReader("fax_cli")
                TextBCodigoPostal.Text = DReader("cod_pos_cli")
                TextBEmail.Text = DReader("email_cli")
                TextBDomicilio.Text = DReader("domi_cli")
                TextBLocalidad.Text = DReader("loc_cli")
                TextBProvincia.Text = DReader("prov_cli")
            Else
                MsgBox("El socio no existe")
            End If

            If DReader.HasRows Then
                ListVClientes.Items.Clear()

                Dim LV As New ListViewItem

                Do While DReader.Read

                    LV = ListVClientes.Items.Add(DReader("id_cliente"))
                    LV.SubItems.Add(DReader("rz_cli"))
                    LV.SubItems.Add(DReader("cuit_cli"))
                    LV.SubItems.Add(DReader("loc_cli"))
                Loop
            End If

            DReader.Close()

            conexion.Close()

        Catch ex As Exception

            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If TextBNombre.Text <> "" Then
            Call BuscarRZcli()
        Else
            If TextBCUIT.Text <> "" Then
                Call BuscarRZcli()

            End If
        End If
    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If TextBNombre.Text = "" And TextBCUIT.Text = "" And ComBoxCategoria.Text = "" And TextBCodigoPostal.Text = "" And TextBDomicilio.Text = "" And TextBEmail.Text = "" And TextBFax.Text = "" And TextBTelefono.Text = "" And TextBLocalidad.Text = "" And TextBProvincia.Text = "" Then
            MsgBox("INGRESE TODOS LOS DATOS", MsgBoxStyle.Critical)
            TextBNombre.Focus()
            Exit Sub
        End If
        Try
            Call conectar()
            conexion.Open()

            Dim Comando As New MySqlCommand

            Comando.Connection = conexion

            Comando.CommandType = CommandType.Text

            Comando.CommandText = "select * from clientes where cuit_cli = '" & Trim(TextBCUIT.Text) & "';"

            Dim DReader As MySqlDataReader

            DReader = Comando.ExecuteReader

            If DReader.HasRows Then
                MsgBox("EL REGISTRO YA EXISTE", MsgBoxStyle.Critical)
                DReader.Close()

            Else
                DReader.Close()

                Comando.CommandText = "insert into clientes (rz_cli, cuit_cli, domi_cli, tel_cli, fax_cli, cat_cli_iva, cod_pos_cli,  loc_cli, prov_cli, email_cli) VALUES ('" & TextBNombre.Text & "', '" & TextBCUIT.Text & "', '" & TextBDomicilio.Text & "' ,'" & TextBTelefono.Text & "' ,'" & TextBFax.Text & "' ,'" & ComBoxCategoria.Text & "' , '" & TextBCodigoPostal.Text & "' , '" & TextBLocalidad.Text & "' , '" & TextBProvincia.Text & "','" & TextBEmail.Text & "');"



                Dim resultado As Integer

                resultado = Comando.ExecuteNonQuery

                MsgBox("REGISTROS AGREGADOS: " & resultado)

                Call LimpiarForm()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Call LimpiarForm()
    End Sub

   

    Private Sub ListVClientes_MouseClick(sender As Object, e As MouseEventArgs) Handles ListVClientes.MouseClick

        Try

            Call conectar()
            conexion.Open()

            Dim Comando As New MySqlCommand

            Comando.Connection = conexion

            Comando.CommandType = CommandType.Text

            Comando.CommandText = "select * from clientes where id_cliente like '" & ListVClientes.SelectedItems(0).Text & "';"

            Dim DReader As MySqlDataReader

            DReader = Comando.ExecuteReader

            If DReader.HasRows Then
                Call LimpiarForm()
                DReader.Read()
                Lblidcli.Text = DReader("id_cliente")
                TextBNombre.Text = DReader("rz_cli")
                TextBCUIT.Text = DReader("cuit_cli")
                TextBDomicilio.Text = DReader("domi_cli")
                TextBTelefono.Text = DReader("tel_cli")
                TextBFax.Text = DReader("fax_cli")
                ComBoxCategoria.Text = DReader("cat_cli_iva")
                TextBCodigoPostal.Text = DReader("cod_pos_cli")
                TextBLocalidad.Text = DReader("loc_cli")
                TextBProvincia.Text = DReader("prov_cli")
                TextBEmail.Text = DReader("email_cli")
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


    Private Sub BntRefresh_Click(sender As Object, e As EventArgs) Handles BntRefresh.Click
        ListVClientes.Items.Clear()
        Call CargarList()
    End Sub

    Private Sub BntModif_Click(sender As Object, e As EventArgs) Handles BntModif.Click
        If TextBNombre.Text = "" And TextBCUIT.Text = "" And ComBoxCategoria.Text = "" And TextBCodigoPostal.Text = "" And TextBDomicilio.Text = "" And TextBEmail.Text = "" And TextBFax.Text = "" And TextBTelefono.Text = "" And TextBLocalidad.Text = "" And TextBProvincia.Text = "" Then
            MsgBox("INGRESE TODOS LOS DATOS", MsgBoxStyle.Critical)
            TextBNombre.Focus()
            Exit Sub
        End If
        Try
            Call conectar()
            conexion.Open()

            Dim Comando As New MySqlCommand

            Comando.Connection = conexion

            Comando.CommandType = CommandType.Text

            Comando.CommandText = "select * from clientes where id_cliente = '" & Trim(Lblidcli.Text) & "';"

            Dim DReader As MySqlDataReader

            DReader = Comando.ExecuteReader

            If DReader.HasRows Then
               
                DReader.Close()

                Comando.CommandText = "UPDATE clientes set rz_cli = '" & TextBNombre.Text & "', cuit_cli = '" & TextBCUIT.Text & "', domi_cli = '" & TextBDomicilio.Text & "', tel_cli = '" & TextBTelefono.Text & "', fax_cli = '" & TextBFax.Text & "', cat_cli_iva = '" & ComBoxCategoria.Text & "' , cod_pos_cli = '" & TextBCodigoPostal.Text & "',  loc_cli = '" & TextBLocalidad.Text & "', prov_cli = '" & TextBProvincia.Text & "', email_cli = '" & TextBEmail.Text & "' where id_cliente = '" & Lblidcli.Text & "';"

                Dim resultado As Integer

                resultado = Comando.ExecuteNonQuery

                MsgBox("REGISTROS AGREGADOS: " & resultado)

                Call LimpiarForm()

            Else

                MsgBox("EL REGISTRO YA EXISTE", MsgBoxStyle.Critical)
                DReader.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Sub

    Private Sub TextBCUIT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBCUIT.KeyPress
        'e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        'If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
        '   MsgBox("Solo Puede Digitar Numeros")
        'End If
    End Sub
    Private Sub TextBNombre_TextChanged(sender As Object, e As EventArgs) Handles TextBNombre.TextChanged

    End Sub

    Private Sub ListVClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListVClientes.SelectedIndexChanged

    End Sub
End Class