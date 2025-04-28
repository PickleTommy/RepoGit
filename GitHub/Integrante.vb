Public Class Integrante
    Private Property _Id As Integer
    Private Property _Nombre As String
    Private Property _Apellido As String
    Private Property _Ingreso As Decimal
    Private Property _Edad As Integer
    Private Property _AhorroPorcentaje As Decimal = 0.2D '20% de ahorro por defecto
    Private Property _Gastos As List(Of Gasto) = New List(Of Gasto)()
    Private Property _Rol As String 'Puede ser tutor o no tutor

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
    Public Property Apellido As String
        Get
            Return _Apellido
        End Get
        Set(value As String)
            _Apellido = value
        End Set
    End Property

    Public Property Ingreso As Decimal
        Get
            Return _Ingreso
        End Get
        Set(value As Decimal)
            _Ingreso = value
        End Set
    End Property
    Public Property Edad As Integer
        Get
            Return _Edad
        End Get
        Set(value As Integer)
            _Edad = value
        End Set
    End Property
    Public Property AhorroPorcentaje As Decimal
        Get
            Return _AhorroPorcentaje
        End Get
        Set(value As Decimal)
            _AhorroPorcentaje = value
        End Set
    End Property
    Public Property Gastos As List(Of Gasto)
        Get
            Return _Gastos
        End Get
        Set(value As List(Of Gasto))
            _Gastos = value
        End Set
    End Property
    Public Property Rol As String
        Get
            Return _Rol
        End Get
        Set(value As String)
            If value.ToLower() = "tutor" OrElse value.ToLower() = "no tutor" Then
                _Rol = value
            Else
                ' Asignar un valor predeterminado si el valor no es válido
                _Rol = "no tutor"
            End If
        End Set
    End Property

    Public Sub New(id As Integer, nombre As String, apellido As String, ingreso As Decimal, edad As Integer, ahorroPorcentaje As Decimal, gastos As List(Of Gasto), rol As String)
        Me.Id = id
        Me.Nombre = nombre
        Me.Apellido = apellido
        Me.Ingreso = ingreso
        Me.Edad = edad
        Me.AhorroPorcentaje = ahorroPorcentaje
        Me.Gastos = gastos
        Me.Rol = rol
    End Sub

    Public Function CalcularAhorro() As Decimal
        Return Ingreso * AhorroPorcentaje
    End Function

    Public Function CalcularSaldoDisponible() As Decimal
        Dim totalGastos As Decimal = Gastos.Sum(Function(g) g.Monto)
        Return Ingreso - CalcularAhorro() - totalGastos
    End Function

End Class
