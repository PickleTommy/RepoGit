Imports MySql.Data.MySqlClient

Public Class CalculosCompartidos
    ' Propiedades compartidas para almacenar los cálculos
    Public Shared TotalIngresos As Decimal
    Public Shared MontoAhorro As Decimal
    Public Shared IngresosRestantes As Decimal
    Public Shared TotalBasicos As Decimal
    Public Shared TotalDiscrecionales As Decimal
    Public Shared TotalExtraordinarios As Decimal

    ' Método para realizar los cálculos
    Public Shared Sub RealizarCalculos(porcentajeAhorro As Decimal)
        ' Usar 20% como valor por defecto si el porcentaje proporcionado es 0 o negativo
        If porcentajeAhorro <= 0 Then
            porcentajeAhorro = 0.2D ' 20% por defecto
        End If

        ' Conexión a la base de datos
        Using miConexion As New MySqlConnection("Server=LocalHost;Uid=root;Pwd=;database=bdproyectoprog")
            miConexion.Open()

            ' Obtener el monto total de ingresos
            Dim cmdIngresos As String = "SELECT SUM(monto) FROM ingresos"
            Dim comandoIngresos As New MySqlCommand(cmdIngresos, miConexion)
            TotalIngresos = If(IsDBNull(comandoIngresos.ExecuteScalar()), 0, Convert.ToDecimal(comandoIngresos.ExecuteScalar()))

            ' Calcular el ahorro
            MontoAhorro = TotalIngresos * porcentajeAhorro
            IngresosRestantes = TotalIngresos - MontoAhorro

            ' Obtener los gastos básicos
            Dim cmdBasicos As String = "SELECT SUM(monto) FROM gastos WHERE tipo_gasto = 'basico'"
            Dim comandoBasicos As New MySqlCommand(cmdBasicos, miConexion)
            TotalBasicos = If(IsDBNull(comandoBasicos.ExecuteScalar()), 0, Convert.ToDecimal(comandoBasicos.ExecuteScalar()))
            IngresosRestantes -= TotalBasicos

            ' Obtener los gastos discrecionales
            Dim cmdDiscrecionales As String = "SELECT SUM(monto) FROM gastos WHERE tipo_gasto = 'discrecional'"
            Dim comandoDiscrecionales As New MySqlCommand(cmdDiscrecionales, miConexion)
            TotalDiscrecionales = If(IsDBNull(comandoDiscrecionales.ExecuteScalar()), 0, Convert.ToDecimal(comandoDiscrecionales.ExecuteScalar()))
            IngresosRestantes -= TotalDiscrecionales

            ' Obtener los gastos extraordinarios
            Dim cmdExtraordinarios As String = "SELECT SUM(monto) FROM gastos WHERE tipo_gasto = 'extraordinario'"
            Dim comandoExtraordinarios As New MySqlCommand(cmdExtraordinarios, miConexion)
            TotalExtraordinarios = If(IsDBNull(comandoExtraordinarios.ExecuteScalar()), 0, Convert.ToDecimal(comandoExtraordinarios.ExecuteScalar()))
            IngresosRestantes -= TotalExtraordinarios
        End Using
    End Sub

End Class
