Public Class Gasto
    ' Campos privados
    Private _Id As Integer
    Private _IntegranteId As Integer ' Foreign key
    Private _Monto As Decimal
    Private _Fecha As DateTime
    Private _Descripcion As String
    Private _Tipo As TipoGasto

    ' Propiedades públicas
    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Public Property IntegranteId As Integer
        Get
            Return _IntegranteId
        End Get
        Set(value As Integer)
            _IntegranteId = value
        End Set
    End Property

    Public Property Monto As Decimal
        Get
            Return _Monto
        End Get
        Set(value As Decimal)
            If value < 0 Then
                Throw New ArgumentException("El monto no puede ser negativo.")
            End If
            _Monto = value
        End Set
    End Property

    Public Property Fecha As DateTime
        Get
            Return _Fecha
        End Get
        Set(value As DateTime)
            _Fecha = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) Then
                Throw New ArgumentException("La descripción no puede estar vacía.")
            End If
            _Descripcion = value
        End Set
    End Property

    Public Property Tipo As TipoGasto
        Get
            Return _Tipo
        End Get
        Set(value As TipoGasto)
            _Tipo = value
        End Set
    End Property

    ' Constructor
    Public Sub New(id As Integer, integranteId As Integer, monto As Decimal, fecha As Date, descripcion As String, tipo As TipoGasto)
        Me._Id = id
        Me._IntegranteId = integranteId
        Me.Monto = monto
        Me.Fecha = fecha
        Me.Descripcion = descripcion
        Me.Tipo = tipo
    End Sub

    ' Enum para tipos de gasto
    Public Enum TipoGasto
        Basico
        Discrecional
        Extraordinario
    End Enum
End Class