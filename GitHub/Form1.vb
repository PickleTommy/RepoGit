Public Class Form1
    Private integrantes As New List(Of Integrante)()

    Private Sub AgregarIntegrante(sender As Object, e As EventArgs) Handles AddIntegrante.Click
        ' Crear una instancia del formulario AgregarFamiliar
        Dim agregarFamiliarForm As New AgregarFamiliar(integrantes)

        ' Mostrar el formulario
        agregarFamiliarForm.ShowDialog()

        ' Actualizar la lista de integrantes después de cerrar el formulario
        integrantes = agregarFamiliarForm.ObtenerIntegrantes()

        ' Confirmar al usuario que ha regresado al menú principal
        MessageBox.Show("Has regresado al menú principal.", "Información")
    End Sub

    Private Sub MostrarIntegrante(sender As Object, e As EventArgs) Handles Button1.Click
        ' Verificar si hay integrantes en la lista
        If integrantes.Count = 0 Then
            MessageBox.Show("No hay integrantes para mostrar.", "Error")
            Return
        End If

        ' Obtener el último integrante agregado
        Dim ultimoIntegrante As Integrante = integrantes.Last()

        ' Crear una instancia del formulario MostrarFamiliar
        Dim mostrarFamiliarForm As New MostrarFamiliar(ultimoIntegrante)

        ' Mostrar el formulario
        mostrarFamiliarForm.ShowDialog()
    End Sub

    Private Sub IngresarMonto(sender As Object, e As EventArgs) Handles AddMonto.Click
        ' Verificar si hay integrantes en la lista
        If integrantes.Count = 0 Then
            MessageBox.Show("No hay integrantes para asignar un monto.", "Error")
            Return
        End If

        ' Obtener el último integrante agregado (o selecciona uno específico si es necesario)
        Dim ultimoIntegrante As Integrante = integrantes.Last()

        ' Crear una instancia del formulario AgregarIngresos
        Dim agregarIngresosForm As New AgregarIngresos(ultimoIntegrante)

        ' Mostrar el formulario
        agregarIngresosForm.ShowDialog()
    End Sub
End Class

