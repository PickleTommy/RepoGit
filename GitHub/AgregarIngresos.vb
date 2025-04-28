Public Class AgregarIngresos
    Private integrante As Integrante

    ' Constructor para recibir el objeto Integrante
    Public Sub New(integrante As Integrante)
        InitializeComponent()
        Me.integrante = integrante
    End Sub

    Private Sub Guardar(sender As Object, e As EventArgs) Handles Button1.Click
        ' Validar que el ingreso sea un número válido
        Dim ingreso As Decimal
        If Not Decimal.TryParse(txtIngreso.Text, ingreso) OrElse ingreso <= 0 Then
            MessageBox.Show("Por favor, ingrese un monto válido.", "Error")
            Return
        End If

        ' Asignar el ingreso al integrante
        integrante.Ingreso = ingreso

        ' Calcular el 20% de ahorro
        Dim ahorro As Decimal = integrante.CalcularAhorro()

        ' Calcular el ingreso disponible
        Dim ingresoDisponible As Decimal = integrante.CalcularSaldoDisponible()

        ' Mostrar los resultados en un MsgBox
        MessageBox.Show($"Ingreso: {ingreso:C}" & vbCrLf &
                        $"Ahorro (20%): {ahorro:C}" & vbCrLf &
                        $"Ingreso Disponible: {ingresoDisponible:C}", "Resultados")

        ' Cerrar el formulario
        Me.Close()
    End Sub
End Class