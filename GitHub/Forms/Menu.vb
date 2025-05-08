Imports System.IO
Public Class Menu
    Private Sub btnIntegrantes_Click(sender As Object, e As EventArgs) Handles btnIntegrantes.Click
        abmIntegrantes.Show()
    End Sub

    Private Sub btnGastos_Click(sender As Object, e As EventArgs) Handles btnGastos.Click
        abmGastos.Show()
    End Sub

    Private Sub btnIngresos_Click(sender As Object, e As EventArgs) Handles btnIngresos.Click
        abmIngresos.Show()
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Calculos.Show()
    End Sub

End Class

