Public Class MostrarFamiliar
    Private integrante As Integrante

    ' Constructor para recibir el integrante
    Public Sub New(integrante As Integrante)
        InitializeComponent()
        Me.integrante = integrante
    End Sub

    ' Evento que se ejecuta al cargar el formulario
    Private Sub MostrarFamiliar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Construir el mensaje con los datos del integrante
        Dim mensaje As String = $"Nombre: {integrante.Nombre}" & vbCrLf &
                                $"Apellido: {integrante.Apellido}" & vbCrLf &
                                $"Edad: {integrante.Edad}" & vbCrLf &
                                $"Rol: {integrante.Rol}"

        ' Mostrar el mensaje en un MsgBox
        MessageBox.Show(mensaje, "Datos del Integrante", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Cerrar el formulario automáticamente después de mostrar el mensaje
        Me.Close()
    End Sub
End Class
