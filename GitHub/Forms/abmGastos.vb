
Imports MySql.Data.MySqlClient
Public Class abmGastos
    'Variables para la conexión, el DataAdapter y el DataSet
    Private miConexion As MySqlConnection
    Private gastosDA As MySqlDataAdapter
    Private proyectoDS As DataSet
    Private esNuevo As Boolean
    Private idgastoSeleccionado As Integer ' Variable para almacenar el idgasto seleccionado

    Private Sub abmGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Conexión existente a la tabla 'gastos'
            miConexion = New MySqlConnection("Server=LocalHost;Uid=root;Pwd=;database=bdproyectoprog")
            gastosDA = New MySqlDataAdapter()
            gastosDA.SelectCommand = New MySqlCommand("SELECT * FROM gastos", miConexion)
            proyectoDS = New DataSet()
            proyectoDS.Tables.Add("Gastos")
            gastosDA.Fill(proyectoDS.Tables("Gastos"))
            DGVgastos.DataSource = proyectoDS.Tables("Gastos")

            ' Bloquear las TextBox
            BloquearTextBox()

            ' Verificar el rol del usuario actual
            If Form1.UsuarioActual.Rol.ToLower() = "no tutor" Then
                btnNuevo.Enabled = False
                btnEliminar.Enabled = False
                btnEditar.Enabled = False
                btnGuardar.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error al conectar con las bases de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            ' Verificamos que los campos estén completos
            If Not ValidarCampos() Then Return

            ' Verificar si la conexión está abierta, y si no, la abrimos
            If miConexion.State = ConnectionState.Closed Then
                miConexion.Open()
            End If

            If esNuevo Then
                ' Código para guardar un nuevo registro
                Dim cmd = "INSERT INTO gastos (idintegrante, monto, descripcion, forma_pago, tipo_gasto, cuotas, fecha) VALUES (@idint, @mon, @des, @fp, @tg, @cuo, @date)"
                Dim comandoInsertar As New MySqlCommand(cmd, miConexion)
                comandoInsertar.Parameters.AddWithValue("@idint", Integer.Parse(tbIntegrante.Text))
                comandoInsertar.Parameters.AddWithValue("@mon", Decimal.Parse(tbMonto.Text))
                comandoInsertar.Parameters.AddWithValue("@des", tbDescripcion.Text)
                comandoInsertar.Parameters.AddWithValue("@fp", tbFormaPago.Text)
                comandoInsertar.Parameters.AddWithValue("@tg", tbTipoGasto.Text)
                comandoInsertar.Parameters.AddWithValue("@cuo", Integer.Parse(tbCuotas.Text))
                comandoInsertar.Parameters.AddWithValue("@date", DateTimePicker1.Value)
                comandoInsertar.ExecuteNonQuery()
                esNuevo = False
            Else
                ' Código para actualizar un registro existente
                Dim cmd = "UPDATE gastos SET idintegrante = @idint, monto = @mon, descripcion = @des, forma_pago = @fp, tipo_gasto = @tg, cuotas = @cuo, fecha = @date WHERE idgasto = @idgasto"
                Dim comandoActualizar As New MySqlCommand(cmd, miConexion)
                comandoActualizar.Parameters.AddWithValue("@idgasto", idgastoSeleccionado)
                comandoActualizar.Parameters.AddWithValue("@idint", Integer.Parse(tbIntegrante.Text))
                comandoActualizar.Parameters.AddWithValue("@mon", Decimal.Parse(tbMonto.Text))
                comandoActualizar.Parameters.AddWithValue("@des", tbDescripcion.Text)
                comandoActualizar.Parameters.AddWithValue("@fp", tbFormaPago.Text)
                comandoActualizar.Parameters.AddWithValue("@tg", tbTipoGasto.Text)
                comandoActualizar.Parameters.AddWithValue("@cuo", Integer.Parse(tbCuotas.Text))
                comandoActualizar.Parameters.AddWithValue("@date", DateTimePicker1.Value)
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

    'Función para editar registros
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            ' Verificar que haya datos cargados en las TextBox
            If String.IsNullOrWhiteSpace(tbIntegrante.Text) Then
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

    'Función para eliminar registros
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If DGVgastos.SelectedRows.Count = 0 Then
                MessageBox.Show("Por favor, seleccione un registro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim confirmacion As DialogResult = MessageBox.Show($"¿Está seguro de que desea eliminar el registro con ID {idgastoSeleccionado}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmacion = DialogResult.No Then
                Return
            End If

            If miConexion.State = ConnectionState.Closed Then
                miConexion.Open()
            End If

            Dim cmd As String = "DELETE FROM gastos WHERE idgasto = @idgasto"
            Dim comandoEliminar As New MySqlCommand(cmd, miConexion)
            comandoEliminar.Parameters.AddWithValue("@idgasto", idgastoSeleccionado)
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

    'Funcion que bloquea las textbox
    Private Sub BloquearTextBox()
        tbIntegrante.Enabled = False
        tbMonto.Enabled = False
        tbDescripcion.Enabled = False
        tbFormaPago.Enabled = False
        tbTipoGasto.Enabled = False
        tbCuotas.Enabled = False
        DateTimePicker1.Enabled = False
    End Sub

    'Funcion que desbloquea las textbox
    Private Sub DesbloquearTextBox()
        tbIntegrante.Enabled = True
        tbMonto.Enabled = True
        tbDescripcion.Enabled = True
        tbFormaPago.Enabled = True
        tbTipoGasto.Enabled = True
        tbCuotas.Enabled = True
        DateTimePicker1.Enabled = True
    End Sub

    'Función que limpia las textbox
    Private Sub LimpiarTextBox()
        tbIntegrante.Text = ""
        tbMonto.Text = ""
        tbDescripcion.Text = ""
        tbFormaPago.Text = ""
        tbTipoGasto.Text = ""
        tbCuotas.Text = ""
        DateTimePicker1.Value = DateTime.Now
    End Sub

    'Función para validar campos cargados correctamente
    Private Function ValidarCampos() As Boolean
        If String.IsNullOrWhiteSpace(tbDescripcion.Text) OrElse
       String.IsNullOrWhiteSpace(tbFormaPago.Text) OrElse
       String.IsNullOrWhiteSpace(tbTipoGasto.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If Not Integer.TryParse(tbIntegrante.Text, Nothing) Then
            MessageBox.Show("El id del integrante debe ser un número válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If Not Integer.TryParse(tbMonto.Text, Nothing) Then
            MessageBox.Show("El monto debe ser un número válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If Not Integer.TryParse(tbCuotas.Text, Nothing) Then
            MessageBox.Show("Las cuotas deben ser un número válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If DateTimePicker1.Value > DateTime.Now Then
            MessageBox.Show("La fecha no puede ser una fecha futura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    'Evento para seleccionar las celdas al clickearlas en el DGV y cargar los datos en las textbox
    Private Sub DGVgastos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVgastos.CellClick
        Try
            ' Verificar que la fila seleccionada sea válida
            If e.RowIndex >= 0 Then
                ' Seleccionar la fila completa
                DGVgastos.Rows(e.RowIndex).Selected = True

                ' Cargar los datos de la fila seleccionada en las TextBox
                Dim filaSeleccionada As DataGridViewRow = DGVgastos.Rows(e.RowIndex)
                idgastoSeleccionado = Convert.ToInt32(filaSeleccionada.Cells("idgasto").Value) ' Guardar el idgasto
                tbIntegrante.Text = filaSeleccionada.Cells("idintegrante").Value.ToString()
                tbMonto.Text = filaSeleccionada.Cells("monto").Value.ToString()
                tbDescripcion.Text = filaSeleccionada.Cells("descripcion").Value.ToString()
                tbFormaPago.Text = filaSeleccionada.Cells("forma_pago").Value.ToString()
                tbTipoGasto.Text = filaSeleccionada.Cells("tipo_gasto").Value.ToString()
                tbCuotas.Text = filaSeleccionada.Cells("cuotas").Value.ToString()
                DateTimePicker1.Value = Convert.ToDateTime(filaSeleccionada.Cells("fecha").Value)

                ' Indicar que no es un nuevo registro
                esNuevo = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos del registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Función para actualizar el DGV
    Private Sub ActualizarDataGridView()
        Try
            proyectoDS.Tables("Gastos").Clear()
            gastosDA.Fill(proyectoDS.Tables("Gastos"))
            DGVgastos.DataSource = proyectoDS.Tables("Gastos")
        Catch ex As MySqlException
            MessageBox.Show("Error al actualizar la tabla: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tbGastos_TextChanged(sender As Object, e As EventArgs) Handles tbGastos.TextChanged
        Try
            ' Verificar si el DataTable existe
            If proyectoDS.Tables.Contains("Gastos") Then
                ' Crear un DataView a partir del DataTable
                Dim vista As New DataView(proyectoDS.Tables("Gastos"))

                ' Aplicar el filtro por la descripción
                vista.RowFilter = $"descripcion LIKE '%{tbGastos.Text}%'"

                ' Vincular el DataView filtrado al DataGridView
                DGVgastos.DataSource = vista
            End If
        Catch ex As Exception
            MessageBox.Show("Error al filtrar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Cerrar la conexión al cerrar el formulario
    Private Sub abmGastos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If miConexion IsNot Nothing AndAlso miConexion.State = ConnectionState.Open Then
            miConexion.Close()
        End If
    End Sub
End Class
