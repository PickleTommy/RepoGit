Imports MySql.Data.MySqlClient

Public Class Form1
    Public Shared UsuarioActual As Usuario ' Instancia compartida para almacenar el usuario actual

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Try
            ' Conexión a la base de datos
            Using conexion As New MySqlConnection("Server=LocalHost;Uid=root;Pwd=;database=bdproyectoprog")
                conexion.Open()

                ' Consulta para verificar el usuario y obtener el idintegrante
                Dim cmdUsuario As String = "SELECT idintegrante FROM usuarios WHERE NombreUsuario = @usuario AND Contraseña = @contraseña"
                Dim comandoUsuario As New MySqlCommand(cmdUsuario, conexion)
                comandoUsuario.Parameters.AddWithValue("@usuario", txtUsuario.Text)
                comandoUsuario.Parameters.AddWithValue("@contraseña", txtContraseña.Text)

                Dim result As Object = comandoUsuario.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    Dim idIntegrante As Integer = Convert.ToInt32(result)

                    ' Consulta para obtener el rol del integrante
                    Dim cmdRol As String = "SELECT nombre, apellido, rol FROM integrantes WHERE idintegrantes = @idintegrantes"
                    Dim comandoRol As New MySqlCommand(cmdRol, conexion)
                    comandoRol.Parameters.AddWithValue("@idintegrantes", idIntegrante)

                    Dim reader As MySqlDataReader = comandoRol.ExecuteReader()
                    If reader.Read() Then
                        ' Crear una instancia de Usuario con los datos obtenidos
                        UsuarioActual = New Usuario(
                            idIntegrante:=idIntegrante,
                            nombre:=reader("nombre").ToString(),
                            apellido:=reader("apellido").ToString(),
                            rol:=reader("rol").ToString()
                        )

                        ' Mostrar el menú principal
                        Dim menu As New Menu()
                        menu.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("No se pudo obtener el rol del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    reader.Close()
                Else
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al iniciar sesión: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class



