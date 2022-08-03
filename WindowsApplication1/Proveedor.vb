Imports MySql.Data.MySqlClient
Public Class Proveedor
    Sub Limpiar()

        TextBRazon.Text = ""
        TextBCUIT.Text = ""
        TextBDireccion.Text = ""
        TextBNumEnte.Text = ""
        CmBPais.Text = ""
        CmBProvincia.Text = ""
        CmBRubro.Text = ""
        CmBTipo.Text = ""
        ListVProveedor.Items.Clear()
    End Sub
    Sub CargarList()

        'Dim est As String

        Try
            Call conectar()
            conexion.Open()

            Dim Comando As New MySqlCommand

            Comando.Connection = conexion

            Comando.CommandType = CommandType.Text

            Comando.CommandText = "select * from proveedor order by Nombre_pro asc;"

            Dim DReader As MySqlDataReader

            DReader = Comando.ExecuteReader

            If DReader.HasRows Then
                DReader.Read()

                'est = DReader("estado")
                'If est = "activo" Then
                ListVProveedor.Items.Clear()

                Dim LV As New ListViewItem

                Do While DReader.Read

                    LV = ListVProveedor.Items.Add(DReader("CUIT"))
                    LV.SubItems.Add(DReader("nro_ente"))
                    LV.SubItems.Add(DReader("Nombre_pro"))
                    LV.SubItems.Add(DReader("tipo_prov"))

                Loop
                'End If

            End If

            DReader.Close()

            conexion.Close()

        Catch ex As Exception

            MsgBox(ex.Message)
            conexion.Close()

        End Try


    End Sub


    Private Sub Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargarList()
    End Sub

    Private Sub BntAgregar_Click(sender As Object, e As EventArgs) Handles BntAgregar.Click
        If TextBCUIT.Text = "" And TextBDireccion.Text = "" And CmBPais.Text = "" And TextBNumEnte.Text = "" And TextBRazon.Text = "" And TextBTel.Text = "" And CmBProvincia.Text = "" And CmBRubro.Text = "" And CmBTipo.Text = "" Then
            MsgBox("INGRESE TODOS LOS DATOS", MsgBoxStyle.Critical)
            TextBRazon.Focus()
            Exit Sub
        End If
        Try
            Call conectar()
            conexion.Open()

            Dim Comando As New MySqlCommand

            Comando.Connection = conexion

            Comando.CommandType = CommandType.Text

            Comando.CommandText = "select * from proveedor where CUIT = '" & Trim(TextBCUIT.Text) & "';"

            Dim DReader As MySqlDataReader

            DReader = Comando.ExecuteReader
            'controlo si el registro ya existe
            If DReader.HasRows Then
                MsgBox("EL REGISTRO YA EXISTE", MsgBoxStyle.Critical)
                DReader.Close()

            Else
                DReader.Close()
                'inserto el registro
                Comando.CommandText = "insert into proveedor (Nombre_pro, CUIT, nro_ente, tipo_prov, rubro_prov, pais_prov, provincia_prov,  Telefono_pro, Direccion_pro, estado) VALUES ('" & TextBRazon.Text & "', '" & TextBCUIT.Text & "', '" & TextBNumEnte.Text & "' ,'" & CmBTipo.Text & "' ,'" & CmBRubro.Text & "' ,'" & CmBPais.Text & "' , '" & CmBProvincia.Text & "' , '" & TextBTel.Text & "' , '" & TextBDireccion.Text & "' , 'activo');"

                Dim resultado As Integer

                resultado = Comando.ExecuteNonQuery

                MsgBox("REGISTROS AGREGADOS: " & resultado)

                Call Limpiar()
                Call CargarList()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Sub

    Private Sub BntModificar_Click(sender As Object, e As EventArgs) Handles BntModificar.Click
        If TextBCUIT.Text = "" And TextBDireccion.Text = "" And CmBPais.Text = "" And TextBNumEnte.Text = "" And TextBRazon.Text = "" And TextBTel.Text = "" And CmBProvincia.Text = "" And CmBRubro.Text = "" And CmBTipo.Text = "" Then
            MsgBox("INGRESE TODOS LOS DATOS", MsgBoxStyle.Critical)
            TextBRazon.Focus()
            Exit Sub
        End If
        Try
            Call conectar()
            conexion.Open()

            Dim Comando As New MySqlCommand

            Comando.Connection = conexion

            Comando.CommandType = CommandType.Text

            Comando.CommandText = "select * from proveedor where CUIT = '" & Trim(TextBCUIT.Text) & "';"

            Dim DReader As MySqlDataReader

            DReader = Comando.ExecuteReader
            'controlo si el registro ya existe
            If DReader.HasRows Then
                DReader.Close()

                Comando.CommandText = "UPDATE proveedor set CUIT = '" & TextBCUIT.Text & "', Nombre_pro = '" & TextBRazon.Text & "', nro_ente = '" & TextBNumEnte.Text & "', tipo_prov = '" & CmBTipo.Text & "', rubro_prov = '" & CmBRubro.Text & "', pais_prov = '" & CmBPais.Text & "' , provincia_prov = '" & CmBProvincia.Text & "',  Telefono_pro = '" & TextBTel.Text & "', Direccion_pro = '" & TextBDireccion.Text & "' where Codigo_pro = '" & LblID.Text & "';"

                Dim resultado As Integer

                resultado = Comando.ExecuteNonQuery

                MsgBox("REGISTROS AGREGADOS: " & resultado)

                Call Limpiar()

            Else

                MsgBox("EL REGISTRO YA EXISTE", MsgBoxStyle.Critical)
                DReader.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Sub

    Private Sub ListVProveedor_MouseClick(sender As Object, e As MouseEventArgs) Handles ListVProveedor.MouseClick
        Try

            Call conectar()
            conexion.Open()

            Dim Comando As New MySqlCommand

            Comando.Connection = conexion

            Comando.CommandType = CommandType.Text

            Comando.CommandText = "select * from proveedor where CUIT like '" & ListVProveedor.SelectedItems(0).Text & "';"

            Dim DReader As MySqlDataReader

            DReader = Comando.ExecuteReader

            If DReader.HasRows Then
                Call Limpiar()
                DReader.Read()
                LblID.Text = DReader("Codigo_pro")
                TextBRazon.Text = DReader("Nombre_pro")
                TextBCUIT.Text = DReader("CUIT")
                TextBNumEnte.Text = DReader("nro_ente")
                TextBDireccion.Text = DReader("Direccion_pro")
                TextBTel.Text = DReader("Telefono_pro")
                CmBTipo.Text = DReader("tipo_prov")
                CmBRubro.Text = DReader("rubro_prov")
                CmBPais.Text = DReader("pais_prov")
                CmBProvincia.Text = DReader("provincia_prov")

            Else
                MsgBox("El Proveedor no existe")
            End If

            DReader.Close()

            conexion.Close()

        Catch ex As Exception

            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub
End Class