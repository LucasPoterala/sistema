Imports MySql.Data.MySqlClient
Module Module1


    Friend conexion As MySqlConnection

    Sub conectar()
        Try

            conexion = New MySqlConnection()

            Dim cadena As String

            cadena = "server=localhost; user id=root; password=123456; database=superpoter; port=3306"

            conexion.ConnectionString = cadena

            conexion.Open()

            conexion.Close()


        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")

        End Try
    End Sub
End Module
