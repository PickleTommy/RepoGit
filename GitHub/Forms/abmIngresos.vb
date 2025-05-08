Imports MySql.Data.MySqlClient
Public Class abmIngresos
    ' Variables para la conexión, el DataAdapter y el DataSet
    Private miConexion As MySqlConnection
    Private ingresosDA As MySqlDataAdapter
    Private ingresosDS As DataSet
    'Variable para crear o editar registro con el botón Guardar
    Private esNuevo As Boolean
    Private idSeleccionado As Integer ' Variable para almacenar el idingreso del registro seleccionado

    Private Sub calculosMonto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Iniciamos la conexión a la BD
            miConexion = New MySqlConnection("Server=LocalHost;Uid=root;Pwd=;database=bdproyectoprog")

            ' Creamos el DataAdapter para la tabla Ingresos
            ingresosDA = New MySqlDataAdapter()
            ingresosDA.SelectCommand = New MySqlCommand("SELECT * FROM ingresos", miConexion)

            ' Creamos el DataSet y llenamos la tabla
            ingresosDS = New DataSet()
            ingresosDS.Tables.Add("Ingresos")
            ingresosDA.Fill(ingresosDS.Tables("Ingresos"))

            ' Vinculamos el DataGridView
            DGVcalculos.DataSource = ingresosDS.Tables("Ingresos")

            ' Bloqueamos las TextBox con la siguiente función
            BloquearTextBox()

            ' Verificar el rol del usuario actual
            If Form1.UsuarioActual.Rol.ToLower() = "no tutor" Then
                btnNuevo.Enabled = False
                btnEliminar.Enabled = False
                btnEditar.Enabled = False
                btnGuardar.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Función para guardar un nuevo registro o actualizar uno existente
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            ' Verificar que los campos estén completos
            If Not ValidarCampos() Then Return

            ' Verificar si la conexión está abierta, y si no, la abrimos
            If miConexion.State = ConnectionState.Closed Then
                miConexion.Open()
            End If

            If esNuevo Then
                ' Código para guardar un nuevo registro
                Dim cmd As String = "INSERT INTO ingresos (idintegrante, monto, fuente, fecha) VALUES (@idint, @mon, @font, @date)"
                Dim comandoInsertar As New MySqlCommand(cmd, miConexion)
                comandoInsertar.Parameters.AddWithValue("@idint", Integer.Parse(tbIntegrante.Text))
                comandoInsertar.Parameters.AddWithValue("@mon", Decimal.Parse(tbMonto.Text))
                comandoInsertar.Parameters.AddWithValue("@font", tbFuente.Text)
                comandoInsertar.Parameters.AddWithValue("@date", DateTimePicker1.Value)
                comandoInsertar.ExecuteNonQuery()
                esNuevo = False
            Else
                ' Código para actualizar un registro existente
                Dim cmd As String = "UPDATE ingresos SET idintegrante = @idint, monto = @mon, fuente = @font, fecha = @date WHERE idingreso = @idSeleccionado"
                Dim comandoActualizar As New MySqlCommand(cmd, miConexion)
                comandoActualizar.Parameters.AddWithValue("@idint", Integer.Parse(tbIntegrante.Text))
                comandoActualizar.Parameters.AddWithValue("@mon", Decimal.Parse(tbMonto.Text))
                comandoActualizar.Parameters.AddWithValue("@font", tbFuente.Text)
                comandoActualizar.Parameters.AddWithValue("@date", DateTimePicker1.Value)
                comandoActualizar.Parameters.AddWithValue("@idSeleccionado", idSeleccionado)
                comandoActualizar.ExecuteNonQuery()
            End If

            ' Actualizar el DataGridView
            ActualizarDataGridView()

            MessageBox.Show("Operación realizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BloquearTextBox()
        Catch ex As Exception
            MessageBox.Show("Error al guardar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If miConexion.State = ConnectionState.Open Then
                miConexion.Close()
            End If
        End Try
    End Sub

    ' Función para eliminar registros
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            'Verificar que haya un registro seleccionado para eliminar
            If DGVcalculos.SelectedRows.Count = 0 Then
                MessageBox.Show("Por favor, seleccione un registro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            'ID del registro a eliminar y confirmación
            Dim confirmacion As DialogResult = MessageBox.Show($"¿Está seguro de que desea eliminar el registro con ID {idSeleccionado}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmacion = DialogResult.No Then
                Return
            End If

            'Abre la conexión en caso de que esté cerrada
            If miConexion.State = ConnectionState.Closed Then
                miConexion.Open()
            End If

            'Comando SQL para eliminar registros
            Dim cmd As String = "DELETE FROM ingresos WHERE idingreso = @id"
            Dim comandoEliminar As New MySqlCommand(cmd, miConexion)
            comandoEliminar.Parameters.AddWithValue("@id", idSeleccionado)
            comandoEliminar.ExecuteNonQuery()

            ' Actualizar el DataGridView
            ActualizarDataGridView()

            MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If miConexion.State = ConnectionState.Open Then
                miConexion.Close()
            End If
        End Try
    End Sub

    ' Función para editar registros
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            ' Verificar que haya un registro seleccionado en el DataGridView
            If DGVcalculos.SelectedRows.Count = 0 Then
                MessageBox.Show("Por favor, seleccione un registro para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Obtener el ID del registro seleccionado desde el DataGridView
            Dim filaSeleccionada As DataGridViewRow = DGVcalculos.SelectedRows(0)
            idSeleccionado = Convert.ToInt32(filaSeleccionada.Cells("idingreso").Value)

            ' Cargar los datos del registro seleccionado en las TextBox
            tbMonto.Text = filaSeleccionada.Cells("monto").Value.ToString()
            tbFuente.Text = filaSeleccionada.Cells("fuente").Value.ToString()
            tbIntegrante.Text = filaSeleccionada.Cells("idintegrante").Value.ToString()
            DateTimePicker1.Value = Convert.ToDateTime(filaSeleccionada.Cells("fecha").Value)

            ' Habilitar las TextBox para la edición
            DesbloquearTextBox()

            ' Indicar que no es un nuevo registro
            esNuevo = False
        Catch ex As Exception
            MessageBox.Show("Error al habilitar la edición: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Función para actualizar el DataGridView
    Private Sub ActualizarDataGridView()
        Try
            ' Limpiar la tabla del DataSet
            If ingresosDS.Tables.Contains("Ingresos") Then
                ingresosDS.Tables("Ingresos").Clear()
            End If

            ' Rellenar la tabla con los datos actualizados desde la base de datos
            ingresosDA.Fill(ingresosDS.Tables("Ingresos"))

            ' Vincular el DataGridView al DataSet actualizado
            DGVcalculos.DataSource = ingresosDS.Tables("Ingresos")
        Catch ex As MySqlException
            MessageBox.Show("Error al actualizar la tabla: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Función para bloquear las TextBox
    Private Sub BloquearTextBox()
        tbMonto.Enabled = False
        tbFuente.Enabled = False
        tbIntegrante.Enabled = False
        DateTimePicker1.Enabled = False
    End Sub

    ' Función para desbloquear las TextBox
    Private Sub DesbloquearTextBox()
        tbMonto.Enabled = True
        tbFuente.Enabled = True
        tbIntegrante.Enabled = True
        DateTimePicker1.Enabled = True
    End Sub

    ' Función para limpiar las TextBox
    Private Sub LimpiarTextBox()
        tbMonto.Text = ""
        tbFuente.Text = ""
        tbIntegrante.Text = ""
        DateTimePicker1.Value = DateTime.Now
    End Sub

    ' Función para validar campos cargados correctamente
    Private Function ValidarCampos() As Boolean
        'Verificar que los campos no estén vacíos
        If String.IsNullOrWhiteSpace(tbMonto.Text) OrElse
           String.IsNullOrWhiteSpace(tbFuente.Text) OrElse
           String.IsNullOrWhiteSpace(tbIntegrante.Text) Then
            MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        'Verifica que Monto sea un número válido
        If Not Decimal.TryParse(tbMonto.Text, Nothing) Then
            MessageBox.Show("El monto debe ser un número válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        'Verifica que la fecha no sea futura
        If DateTimePicker1.Value > DateTime.Now Then
            MessageBox.Show("La fecha no puede ser una fecha futura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        'Si toda la validación es correcta devuelve un True
        Return True
    End Function

    ' Evento para seleccionar las celdas al hacer clic en el DataGridView
    Private Sub DGVcalculos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVcalculos.CellClick
        Try
            ' Verificar que la fila seleccionada sea válida
            If e.RowIndex >= 0 Then
                ' Seleccionar la fila completa
                DGVcalculos.Rows(e.RowIndex).Selected = True

                ' Cargar los datos de la fila seleccionada en las TextBox
                Dim filaSeleccionada As DataGridViewRow = DGVcalculos.Rows(e.RowIndex)
                tbMonto.Text = filaSeleccionada.Cells("monto").Value.ToString()
                tbFuente.Text = filaSeleccionada.Cells("fuente").Value.ToString()
                tbIntegrante.Text = filaSeleccionada.Cells("idintegrante").Value.ToString()
                DateTimePicker1.Value = Convert.ToDateTime(filaSeleccionada.Cells("fecha").Value)

                ' Guardar el ID del registro seleccionado
                idSeleccionado = Integer.Parse(filaSeleccionada.Cells("idingreso").Value)

                ' Indicar que no es un nuevo registro
                esNuevo = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos del registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            ' Limpiar las TextBox
            LimpiarTextBox()

            ' Desbloquear las TextBox para ingresar datos
            DesbloquearTextBox()

            ' Indicar que se está creando un nuevo registro
            esNuevo = True
        Catch ex As Exception
            MessageBox.Show("Error al preparar el formulario para un nuevo registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function VerificarIntegrante(idIntegrante As Integer) As Boolean

        'Abre la conexión si está cerrada
        Try
            If miConexion.State = ConnectionState.Closed Then
                miConexion.Open()
            End If

            ' Verificar si el ID del integrante existe en la base de datos
            Dim cmd As String = "SELECT COUNT(*) FROM integrantes WHERE idintegrantes = @idint"
            Dim comando As New MySqlCommand(cmd, miConexion)
            comando.Parameters.AddWithValue("@idint", idIntegrante)

            'Verifica si el integrante existe
            Dim existe As Integer = Convert.ToInt32(comando.ExecuteScalar())
            Return existe > 0
        Catch ex As Exception
            MessageBox.Show("Error al verificar el integrante: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If miConexion.State = ConnectionState.Open Then
                miConexion.Close()
            End If
        End Try
    End Function

End Class


