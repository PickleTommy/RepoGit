Imports MySql.Data.MySqlClient

Public Class abmIntegrantes
    'Variables para la conexión, el DataAdapter y el DataSet
    Private miConexion As MySqlConnection
    Private integrantesDA As MySqlDataAdapter
    Private proyectoDS As DataSet
    Private esNuevo As Boolean

    Private Sub abmIntegrantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Uso opcional del try en caso de que la conexión falle o no se pueda establecer
        Try
            'Iniciamos la conexión a la BD
            miConexion = New MySqlConnection("Server=LocalHost;Uid=root;Pwd=;database=bdproyectoprog")
            'Creamos el DataAdapter para la tabla Integrantes
            'En este caso primero definimos el DataAdapter y luego el comando, pero se puede hacer en el mismo renglón
            integrantesDA = New MySqlDataAdapter()
            integrantesDA.SelectCommand = New MySqlCommand("SELECT * FROM integrantes", miConexion)
            'Lo creamos igual que al DataAdapter y llenamos la tabla
            proyectoDS = New DataSet()
            proyectoDS.Tables.Add("Integrantes")
            integrantesDA.Fill(proyectoDS.Tables("Integrantes"))
            'Vinculamos el DataGridView
            DGVintegrantes.DataSource = proyectoDS.Tables("Integrantes")
            'Bloqueamos las TextBox con la siguiente funcion
            BloquearTextBox()
        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            'Verificamos que los campos estén completos
            If Not ValidarCampos() Then Return
            ' Verificar si la conexión está abierta, y si no, la abrimos
            If miConexion.State = ConnectionState.Closed Then
                miConexion.Open()
            End If

            ' Verificar si el registro ya existe en la base de datos
            Dim consultaExiste As String = "SELECT COUNT(*) FROM integrantes WHERE dni = @dni"
            Dim comandoExiste As New MySqlCommand(consultaExiste, miConexion)
            comandoExiste.Parameters.AddWithValue("@dni", tbDNI.Text)

            Dim existe As Integer = Convert.ToInt32(comandoExiste.ExecuteScalar())
            If existe > 0 Then
                MessageBox.Show("El registro con el DNI ingresado ya existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If esNuevo Then
                ' Código para guardar un nuevo registro
                'Comando SQL para insertar un nuevo registro
                Dim cmd As String = "INSERT INTO integrantes (dni, nombre, apellido, edad, rol, nacimiento) VALUES (@dni, @nom, @ape, @ed, @rol, @nac)"
                Dim comandoInsertar As New MySqlCommand(cmd, miConexion)
                'Parametrizamos el comando
                comandoInsertar.Parameters.AddWithValue("@dni", tbDNI.Text)
                comandoInsertar.Parameters.AddWithValue("@nom", tbNombre.Text)
                comandoInsertar.Parameters.AddWithValue("@ape", tbApellido.Text)
                comandoInsertar.Parameters.AddWithValue("@ed", Integer.Parse(tbEdad.Text))
                comandoInsertar.Parameters.AddWithValue("@rol", tbRol.Text)
                comandoInsertar.Parameters.AddWithValue("@nac", DateTimePicker1.Value)
                ' Ejecutar el comando
                comandoInsertar.ExecuteNonQuery()
                ' Actualizar el DataSet y el DataGridView
                esNuevo = False
            Else
                ' Código para actualizar un registro existente
                'Comando SQL para actualizar un registro existente
                Dim cmd As String = "UPDATE integrantes SET nombre = @nom, apellido = @ape, edad = @ed, rol = @rol, nacimiento = @nac WHERE dni = @dni"
                Dim comandoActualizar As New MySqlCommand(cmd, miConexion)
                'Parametrizamos el comando
                comandoActualizar.Parameters.AddWithValue("@dni", tbDNI.Text)
                comandoActualizar.Parameters.AddWithValue("@nom", tbNombre.Text)
                comandoActualizar.Parameters.AddWithValue("@ape", tbApellido.Text)
                comandoActualizar.Parameters.AddWithValue("@ed", Integer.Parse(tbEdad.Text))
                comandoActualizar.Parameters.AddWithValue("@rol", tbRol.Text)
                comandoActualizar.Parameters.AddWithValue("@nac", DateTimePicker1.Value)
                ' Ejecutar el comando
                comandoActualizar.ExecuteNonQuery()
            End If

            ' Actualizar el DataGridView
            ActualizarDataGridView()

            MessageBox.Show("Operación realizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BloquearTextBox()
        Catch ex As Exception
            ' En caso de error, mostramos un mensaje
            MessageBox.Show("Error al guardar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Aseguramos que la conexión se cierre
            If miConexion.State = ConnectionState.Open Then
                miConexion.Close()
            End If
        End Try
    End Sub

    'Funcion que bloquea las textbox
    Private Sub BloquearTextBox()
        tbNombre.Enabled = False
        tbApellido.Enabled = False
        tbEdad.Enabled = False
        tbRol.Enabled = False
        tbDNI.Enabled = False
        DateTimePicker1.Enabled = False
    End Sub

    'Funcion del botón Nuevo
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'Desbloqueamos las textbox
        DesbloquearTextBox()
        'Limpiamos las textbox
        LimpiarTextBox()
        'Indicamos que creamos un nuevo registro
        esNuevo = True
    End Sub

    'Funcion que desbloquea las textbox
    Private Sub DesbloquearTextBox()
        tbNombre.Enabled = True
        tbApellido.Enabled = True
        tbEdad.Enabled = True
        tbRol.Enabled = True
        tbDNI.Enabled = True
        DateTimePicker1.Enabled = True
    End Sub

    'Funcion que limpia las textbox
    Private Sub LimpiarTextBox()
        tbNombre.Text = ""
        tbApellido.Text = ""
        tbEdad.Text = ""
        tbRol.Text = ""
        tbDNI.Text = ""
        DateTimePicker1.Value = DateTime.Now
    End Sub

    'Función para validar campos cargados correctamente
    Private Function ValidarCampos() As Boolean
        If String.IsNullOrWhiteSpace(tbNombre.Text) OrElse
       String.IsNullOrWhiteSpace(tbApellido.Text) OrElse
       String.IsNullOrWhiteSpace(tbEdad.Text) OrElse
       String.IsNullOrWhiteSpace(tbRol.Text) OrElse
       String.IsNullOrWhiteSpace(tbDNI.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If Not Integer.TryParse(tbEdad.Text, Nothing) Then
            MessageBox.Show("La edad debe ser un número válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function
    'Evento para seleccionar las celdas al clickearlas en el DGV y cargar los datos en las textbox
    Private Sub DGVintegrantes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVintegrantes.CellClick
        Try
            ' Verificar que la fila seleccionada sea válida
            If e.RowIndex >= 0 Then
                ' Seleccionar la fila completa
                DGVintegrantes.Rows(e.RowIndex).Selected = True

                ' Cargar los datos de la fila seleccionada en las TextBox
                Dim filaSeleccionada As DataGridViewRow = DGVintegrantes.Rows(e.RowIndex)
                tbNombre.Text = filaSeleccionada.Cells("nombre").Value.ToString()
                tbApellido.Text = filaSeleccionada.Cells("apellido").Value.ToString()
                tbEdad.Text = filaSeleccionada.Cells("edad").Value.ToString()
                tbRol.Text = filaSeleccionada.Cells("rol").Value.ToString()
                tbDNI.Text = filaSeleccionada.Cells("dni").Value.ToString()
                DateTimePicker1.Value = Convert.ToDateTime(filaSeleccionada.Cells("nacimiento").Value)

                ' Indicar que no es un nuevo registro
                esNuevo = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos del registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            ' Verificar que haya una fila seleccionada en el DataGridView
            If DGVintegrantes.SelectedRows.Count = 0 Then
                MessageBox.Show("Por favor, seleccione un registro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Obtener el valor del DNI del registro seleccionado
            Dim filaSeleccionada As DataGridViewRow = DGVintegrantes.SelectedRows(0)
            Dim dni As String = filaSeleccionada.Cells("dni").Value.ToString()

            ' Confirmar la eliminación
            Dim confirmacion As DialogResult = MessageBox.Show($"¿Está seguro de que desea eliminar el registro con DNI {dni}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmacion = DialogResult.No Then
                Return
            End If

            ' Abrir la conexión si está cerrada
            If miConexion.State = ConnectionState.Closed Then
                miConexion.Open()
            End If

            'Comando SQL para eliminar registros
            Dim cmd As String = "DELETE FROM integrantes WHERE dni = @dni"
            Dim comandoEliminar As New MySqlCommand(cmd, miConexion)
            comandoEliminar.Parameters.AddWithValue("@dni", dni)
            comandoEliminar.ExecuteNonQuery()

            ' Actualizar el DataGridView
            ActualizarDataGridView()

            MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Asegurarse de cerrar la conexión
            If miConexion.State = ConnectionState.Open Then
                miConexion.Close()
            End If
        End Try
    End Sub

    'Función para editar registros
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            ' Verificar que haya datos cargados en las TextBox
            If String.IsNullOrWhiteSpace(tbDNI.Text) Then
                MessageBox.Show("Por favor, seleccione un registro del DataGridView antes de editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Habilitar las TextBox para la edición
            DesbloquearTextBox()

            ' Indicar que no es un nuevo registro
            esNuevo = False
        Catch ex As Exception
            MessageBox.Show("Error al habilitar la edición: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Try
            ' Crear una instancia del formulario Menu
            Dim menuForm As New Menu()

            ' Mostrar el formulario Menu
            menuForm.Show()

            ' Cerrar el formulario actual
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error al regresar al menú: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Función para actualizar el DGV
    Private Sub ActualizarDataGridView()
        Try
            ' Limpiar la tabla del DataSet
            proyectoDS.Tables("Integrantes").Clear()

            ' Rellenar la tabla con los datos actualizados desde la base de datos
            integrantesDA.Fill(proyectoDS.Tables("Integrantes"))

            ' Vincular el DataGridView al DataSet actualizado
            DGVintegrantes.DataSource = proyectoDS.Tables("Integrantes")
        Catch ex As Exception
            MessageBox.Show("Error al actualizar la tabla: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class