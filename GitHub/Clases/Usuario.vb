Public Class Usuario
    Public Property IdIntegrante As Integer
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Rol As String

    Public Sub New(idIntegrante As Integer, nombre As String, apellido As String, rol As String)
        Me.IdIntegrante = idIntegrante
        Me.Nombre = nombre
        Me.Apellido = apellido
        Me.Rol = rol
    End Sub
End Class