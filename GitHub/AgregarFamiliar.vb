Public Class AgregarFamiliar
    Private integrantes As List(Of Integrante)

    ' Constructor para recibir la lista de integrantes
    Public Sub New(listaIntegrantes As List(Of Integrante))
        InitializeComponent()
        integrantes = listaIntegrantes
    End Sub

    ' Evento que se ejecuta al cerrar el formulario
    Private Sub AgregarFamiliar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Crear una nueva instancia de Integrante
        Dim nuevoIntegrante As New Integrante(0, "", "", 0, 0, 0.2D, New List(Of Gasto)(), "")

        ' Leer los datos desde las TextBox
        nuevoIntegrante.Nombre = txtNombre.Text
        nuevoIntegrante.Apellido = txtApellido.Text
        nuevoIntegrante.Edad = If(String.IsNullOrEmpty(txtEdad.Text), 0, Integer.Parse(txtEdad.Text))
        nuevoIntegrante.Rol = txtRol.Text

        ' Validar los datos antes de agregar el integrante
        If String.IsNullOrEmpty(nuevoIntegrante.Nombre) OrElse String.IsNullOrEmpty(nuevoIntegrante.Apellido) Then
            MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia")
            e.Cancel = True ' Cancelar el cierre del formulario
            Return
        End If

        ' Agregar el nuevo integrante a la lista
        integrantes.Add(nuevoIntegrante)

        ' Confirmar al usuario
        MessageBox.Show($"Integrante {nuevoIntegrante.Nombre} {nuevoIntegrante.Apellido} agregado correctamente.", "Éxito")
    End Sub

    ' Método para devolver la lista actualizada de integrantes
    Public Function ObtenerIntegrantes() As List(Of Integrante)
        Return integrantes
    End Function
End Class


