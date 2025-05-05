Imports iText.Kernel.Pdf
Imports iText.Kernel.Font
Imports iText.IO.Font.Constants
Imports iText.Layout
Imports iText.Layout.Element
Imports iText.Layout.Properties
Imports System.IO
Public Class Menu
    Private Sub btnIntegrantes_Click(sender As Object, e As EventArgs) Handles btnIntegrantes.Click
        abmIntegrantes.Show()
    End Sub

    Private Sub btnGastos_Click(sender As Object, e As EventArgs) Handles btnGastos.Click
        abmGastos.Show()
    End Sub

    Private Sub AddMonto_Click(sender As Object, e As EventArgs) Handles AddMonto.Click
        calculosMonto.Show()
    End Sub

    Private Sub Resumen_Click(sender As Object, e As EventArgs) Handles Resumen.Click
        Try
            ' Verificar si los cálculos están disponibles
            If CalculosCompartidos.TotalIngresos = 0 Then
                MessageBox.Show("No hay cálculos disponibles para generar el resumen.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Mostrar el cuadro de diálogo para guardar el archivo
            Using saveFileDialog As New SaveFileDialog() With {
                .Filter = "Archivos de Texto (*.txt)|*.txt",
                .Title = "Guardar Resumen",
                .FileName = "Resumen.txt"
            }
                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    ' Crear el archivo de texto con los datos de CalculosCompartidos
                    Using writer As New StreamWriter(saveFileDialog.FileName)
                        writer.WriteLine("Resumen de Ingresos y Gastos")
                        writer.WriteLine($"Total Ingresos: {CalculosCompartidos.TotalIngresos:C2}")
                        writer.WriteLine($"Ahorro: {CalculosCompartidos.MontoAhorro:C2}")
                        writer.WriteLine($"Gastos Básicos: {CalculosCompartidos.TotalBasicos:C2}")
                        writer.WriteLine($"Gastos Discrecionales: {CalculosCompartidos.TotalDiscrecionales:C2}")
                        writer.WriteLine($"Gastos Extraordinarios: {CalculosCompartidos.TotalExtraordinarios:C2}")
                        writer.WriteLine($"Ingresos Disponibles: {CalculosCompartidos.IngresosRestantes:C2}")
                    End Using

                    ' Mostrar mensaje de éxito
                    MessageBox.Show("El resumen se ha generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            ' Manejar errores
            MessageBox.Show("Error al generar el resumen: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class

