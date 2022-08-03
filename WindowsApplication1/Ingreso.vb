'Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class Ingreso
    Dim ex, ey As Integer

    Dim arrastre As Boolean


    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Application.Exit()
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub Ingreso_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X

        ey = e.Y

        arrastre = True
    End Sub

    Private Sub Ingreso_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        arrastre = False

    End Sub

    Private Sub Ingreso_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If arrastre Then Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - ex, Control.MousePosition.Y - Me.Location.Y - ey))
    End Sub

    Private Sub TxtContraseña_TextChanged(sender As Object, e As EventArgs) Handles TxtContraseña.TextChanged

    End Sub

    Private Sub Ingreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxtUsuario.TextChanged

    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click, BtnIngresar.Enter



        Try
            Call conectar()
            conexion.Open()

            Dim comando As New MySqlCommand

            comando.Connection = conexion

            comando.CommandType = CommandType.Text

            comando.CommandText = "select u.*, r.clientes, r.proveedores, r.ventas, r.nombre as nombre_rol from usuarios u JOIN roles r on r.id_roles = u.id_rol where usuario = '" & TxtUsuario.Text & "' and contraseña = '" & TxtContraseña.Text & "';"

            'obtengo los datos y los devuelvo a un objeto DataReader 
            Dim DReader As MySqlDataReader

            'el metodo ExecuteReader trae los datos de la BD
            DReader = comando.ExecuteReader
            'consulto si trajo registros
            If DReader.HasRows Then
                'utilizo el DataReader para "mostrar" los datos 
                DReader.Read()
                Dim principal As New Portada(DReader("usuario"), DReader("id_usuario"), DReader("clientes"), DReader("proveedores"), DReader("ventas"))
                principal.LblNombreUs.Text = DReader("nombre")
                principal.LblNombreRol.Text = DReader("nombre_rol")
                principal.LblID.Text = DReader("id_usuario")
                id = DReader("id_usuario")
                Call principal.Show()
                Me.Hide()
                TxtContraseña.Text = ""
                TxtUsuario.Text = ""

            Else
                MsgBox("Usuaro o clave incorrecta")
            End If
        Catch ex As Exception
            'Si hay un error muestro el mensaje
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub

       
End Class