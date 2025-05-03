Imports MySql.Data.MySqlClient

Public Class Form1
    Private miConexion As MySqlConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        miConexion = New MySqlConnection("Server=LocalHost;Database=bdproyectoprog;Uid=root;Pwd=;")
        ' No es necesario abrir la conexión aquí
    End Sub

    Private Sub Log_Click(sender As Object, e As EventArgs) Handles Log.Click
        Try

            ' Consulta SQL con parámetros
            Dim consulta As String = "SELECT * FROM usuarios WHERE NombreUsuario= @Usuario AND Contraseña = @Contraseña"
            Dim adaptador As New MySqlDataAdapter(consulta, miConexion)
            adaptador.SelectCommand.Parameters.AddWithValue("@Usuario", txtUsuario.Text.Trim())
            adaptador.SelectCommand.Parameters.AddWithValue("@Contraseña", txtContraseña.Text.Trim())

            Dim datos As New DataSet
            adaptador.Fill(datos, "usuarios")

            ' Verificar si las credenciales son correctas
            If datos.Tables("usuarios").Rows.Count > 0 Then
                MsgBox("Bienvenido", MsgBoxStyle.Information, "Éxito")
                Menu.Show()
            Else
                MsgBox("Usuario o contraseña incorrectos. Inténtelo de nuevo.", MsgBoxStyle.Critical, "Error")
            End If
        Catch ex As Exception
            MsgBox("Error al ejecutar la consulta: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If miConexion.State = ConnectionState.Open Then
            miConexion.Close()
        End If
    End Sub
End Class
