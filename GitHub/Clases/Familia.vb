Public Class Familia
    Private Property _Id As Integer
    Private Property _Nombre As String
    Private Property _Integrantes As List(Of Integrante) = New List(Of Integrante)()

    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Integrantes As List(Of Integrante)
        Get
            Return _Integrantes
        End Get
        Set(value As List(Of Integrante))
            _Integrantes = value
        End Set
    End Property

    Public Sub New(id As Integer, nombre As String, integrantes As List(Of Integrante))
        Me.Id = id
        Me.Nombre = nombre
        Me.Integrantes = integrantes
    End Sub

End Class
