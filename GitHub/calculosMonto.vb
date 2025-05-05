Imports MySql.Data.MySqlClient
Public Class calculosMonto
    ' Variables para la conexión, el DataAdapter y el DataSet
    Private miConexion As MySqlConnection
    Private calculosDA As MySqlDataAdapter
    Private calculosDS As DataSet
    Private esNuevo As Boolean
    Private idSeleccionado As Integer ' Variable para almacenar el idingreso del registro seleccionado

    Private Sub calculosMonto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Iniciamos la conexión a la BD
            miConexion = New MySqlConnection("Server=LocalHost;Uid=root;Pwd=;database=bdproyectoprog")

            ' Creamos el DataAdapter para la tabla Ingresos
            calculosDA = New MySqlDataAdapter()
            calculosDA.SelectCommand = New MySqlCommand("SELECT * FROM ingresos", miConexion)

            ' Creamos el DataSet y llenamos la tabla
            calculosDS = New DataSet()
            calculosDS.Tables.Add("Ingresos")
            calculosDA.Fill(calculosDS.Tables("Ingresos"))

            ' Vinculamos el DataGridView
            DGVcalculos.DataSource = calculosDS.Tables("Ingresos")

            ' Bloqueamos las TextBox con la siguiente función
            BloquearTextBox()
        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Función para guardar un nuevo registro o actualizar uno existente
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            ' Verificar si la conexión está abierta, y si no, la abrimos
            If miConexion.State = ConnectionState.Closed Then
                miConexion.Open()
            End If

            ' Obtener el monto total de ingresos
            Dim cmdIngresos As String = "SELECT SUM(monto) FROM ingresos"
            Dim comandoIngresos As New MySqlCommand(cmdIngresos, miConexion)
            Dim totalIngresos As Decimal = If(IsDBNull(comandoIngresos.ExecuteScalar()), 0, Convert.ToDecimal(comandoIngresos.ExecuteScalar()))

            ' Restar el porcentaje de ahorro
            Dim porcentajeAhorro As Decimal = If(String.IsNullOrWhiteSpace(tbPorcentajeAhorro.Text), 0.2D, Decimal.Parse(tbPorcentajeAhorro.Text) / 100)
            Dim montoAhorro As Decimal = totalIngresos * porcentajeAhorro
            Dim ingresosRestantes As Decimal = totalIngresos - montoAhorro

            ' Obtener los gastos básicos
            Dim cmdBasicos As String = "SELECT SUM(monto) FROM gastos WHERE tipo_gasto = 'basico'"
            Dim comandoBasicos As New MySqlCommand(cmdBasicos, miConexion)
            Dim totalBasicos As Decimal = If(IsDBNull(comandoBasicos.ExecuteScalar()), 0, Convert.ToDecimal(comandoBasicos.ExecuteScalar()))
            ingresosRestantes -= totalBasicos

            ' Obtener los gastos discrecionales
            Dim cmdDiscrecionales As String = "SELECT SUM(monto) FROM gastos WHERE tipo_gasto = 'discrecional'"
            Dim comandoDiscrecionales As New MySqlCommand(cmdDiscrecionales, miConexion)
            Dim totalDiscrecionales As Decimal = If(IsDBNull(comandoDiscrecionales.ExecuteScalar()), 0, Convert.ToDecimal(comandoDiscrecionales.ExecuteScalar()))
            ingresosRestantes -= totalDiscrecionales

            ' Obtener los gastos extraordinarios
            Dim cmdExtraordinarios As String = "SELECT SUM(monto) FROM gastos WHERE tipo_gasto = 'extraordinario'"
            Dim comandoExtraordinarios As New MySqlCommand(cmdExtraordinarios, miConexion)
            Dim totalExtraordinarios As Decimal = If(IsDBNull(comandoExtraordinarios.ExecuteScalar()), 0, Convert.ToDecimal(comandoExtraordinarios.ExecuteScalar()))
            ingresosRestantes -= totalExtraordinarios

            ' Almacenar los cálculos en la clase compartida
            CalculosCompartidos.TotalIngresos = totalIngresos
            CalculosCompartidos.MontoAhorro = montoAhorro
            CalculosCompartidos.IngresosRestantes = ingresosRestantes
            CalculosCompartidos.TotalBasicos = totalBasicos
            CalculosCompartidos.TotalDiscrecionales = totalDiscrecionales
            CalculosCompartidos.TotalExtraordinarios = totalExtraordinarios

            ' Mostrar el resultado final
            Dim resultado As String = $"Total Ingresos: {totalIngresos:C2}" & vbCrLf &
                                   $"Ahorro ({porcentajeAhorro * 100}%): {montoAhorro:C2}" & vbCrLf &
                                   $"Gastos Básicos: {totalBasicos:C2}" & vbCrLf &
                                   $"Gastos Discrecionales: {totalDiscrecionales:C2}" & vbCrLf &
                                   $"Gastos Extraordinarios: {totalExtraordinarios:C2}" & vbCrLf &
                                   $"Ingresos Disponibles: {ingresosRestantes:C2}"

            MessageBox.Show(resultado, "Cálculos Realizados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al calcular los ingresos disponibles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Asegurarse de cerrar la conexión
            If miConexion.State = ConnectionState.Open Then
                miConexion.Close()
            End If
        End Try
    End Sub



    ' Función para eliminar registros
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If DGVcalculos.SelectedRows.Count = 0 Then
                MessageBox.Show("Por favor, seleccione un registro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim confirmacion As DialogResult = MessageBox.Show($"¿Está seguro de que desea eliminar el registro con ID {idSeleccionado}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmacion = DialogResult.No Then
                Return
            End If

            If miConexion.State = ConnectionState.Closed Then
                miConexion.Open()
            End If

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
            If calculosDS.Tables.Contains("Ingresos") Then
                calculosDS.Tables("Ingresos").Clear()
            End If

            ' Rellenar la tabla con los datos actualizados desde la base de datos
            calculosDA.Fill(calculosDS.Tables("Ingresos"))

            ' Vincular el DataGridView al DataSet actualizado
            DGVcalculos.DataSource = calculosDS.Tables("Ingresos")
        Catch ex As MySqlException
            MessageBox.Show("Error al actualizar la tabla: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Función para bloquear las TextBox
    Private Sub BloquearTextBox()
        tbMonto.Enabled = False
        tbFuente.Enabled = False
        tbPorcentajeAhorro.Enabled = False ' Este campo se utiliza solo para cálculos
        tbIntegrante.Enabled = False
        DateTimePicker1.Enabled = False
    End Sub

    ' Función para desbloquear las TextBox
    Private Sub DesbloquearTextBox()
        tbMonto.Enabled = True
        tbFuente.Enabled = True
        tbPorcentajeAhorro.Enabled = True ' Este campo se utiliza solo para cálculos
        tbIntegrante.Enabled = True
        DateTimePicker1.Enabled = True
    End Sub

    ' Función para limpiar las TextBox
    Private Sub LimpiarTextBox()
        tbMonto.Text = ""
        tbFuente.Text = ""
        tbPorcentajeAhorro.Text = "" ' Este campo se utiliza solo para cálculos
        tbIntegrante.Text = ""
        DateTimePicker1.Value = DateTime.Now
    End Sub

    ' Función para validar campos cargados correctamente
    Private Function ValidarCampos() As Boolean
        If String.IsNullOrWhiteSpace(tbMonto.Text) OrElse
       String.IsNullOrWhiteSpace(tbFuente.Text) OrElse
       String.IsNullOrWhiteSpace(tbIntegrante.Text) Then
            MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If Not Decimal.TryParse(tbMonto.Text, Nothing) Then
            MessageBox.Show("El monto debe ser un número válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If DateTimePicker1.Value > DateTime.Now Then
            MessageBox.Show("La fecha no puede ser una fecha futura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

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

    ' Lógica de cálculo de gastos
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Try
            ' Verificar si la conexión está abierta, y si no, la abrimos
            If miConexion.State = ConnectionState.Closed Then
                miConexion.Open()
            End If

            ' Obtener el monto total de ingresos
            Dim cmdIngresos As String = "SELECT SUM(monto) FROM ingresos"
            Dim comandoIngresos As New MySqlCommand(cmdIngresos, miConexion)
            Dim totalIngresos As Decimal = If(IsDBNull(comandoIngresos.ExecuteScalar()), 0, Convert.ToDecimal(comandoIngresos.ExecuteScalar()))

            ' Restar el porcentaje de ahorro
            Dim porcentajeAhorro As Decimal = If(String.IsNullOrWhiteSpace(tbPorcentajeAhorro.Text), 0.2D, Decimal.Parse(tbPorcentajeAhorro.Text) / 100)
            Dim montoAhorro As Decimal = totalIngresos * porcentajeAhorro
            Dim ingresosRestantes As Decimal = totalIngresos - montoAhorro

            ' Obtener los gastos básicos
            Dim cmdBasicos As String = "SELECT SUM(monto) FROM gastos WHERE tipo_gasto = 'basico'"
            Dim comandoBasicos As New MySqlCommand(cmdBasicos, miConexion)
            Dim totalBasicos As Decimal = If(IsDBNull(comandoBasicos.ExecuteScalar()), 0, Convert.ToDecimal(comandoBasicos.ExecuteScalar()))
            ingresosRestantes -= totalBasicos

            ' Obtener los gastos discrecionales
            Dim cmdDiscrecionales As String = "SELECT SUM(monto) FROM gastos WHERE tipo_gasto = 'discrecional'"
            Dim comandoDiscrecionales As New MySqlCommand(cmdDiscrecionales, miConexion)
            Dim totalDiscrecionales As Decimal = If(IsDBNull(comandoDiscrecionales.ExecuteScalar()), 0, Convert.ToDecimal(comandoDiscrecionales.ExecuteScalar()))
            ingresosRestantes -= totalDiscrecionales

            ' Obtener los gastos extraordinarios
            Dim cmdExtraordinarios As String = "SELECT SUM(monto) FROM gastos WHERE tipo_gasto = 'extraordinario'"
            Dim comandoExtraordinarios As New MySqlCommand(cmdExtraordinarios, miConexion)
            Dim totalExtraordinarios As Decimal = If(IsDBNull(comandoExtraordinarios.ExecuteScalar()), 0, Convert.ToDecimal(comandoExtraordinarios.ExecuteScalar()))
            ingresosRestantes -= totalExtraordinarios

            ' Obtener el porcentaje de ahorro ingresado por el usuario
            Dim percentAhorro As Decimal
            If Not Decimal.TryParse(tbPorcentajeAhorro.Text, percentAhorro) Then
                porcentajeAhorro = 0 ' Si no es válido, se usará el valor por defecto en CalculosCompartidos
            End If

            ' Almacenar los cálculos en la clase compartida
            CalculosCompartidos.TotalIngresos = totalIngresos
            CalculosCompartidos.MontoAhorro = montoAhorro
            CalculosCompartidos.IngresosRestantes = ingresosRestantes
            CalculosCompartidos.TotalBasicos = totalBasicos
            CalculosCompartidos.TotalDiscrecionales = totalDiscrecionales
            CalculosCompartidos.TotalExtraordinarios = totalExtraordinarios

            ' Mostrar el resultado final
            Dim resultado As String = $"Total Ingresos: {totalIngresos:C2}" & vbCrLf &
                                       $"Ahorro ({porcentajeAhorro * 100}%): {montoAhorro:C2}" & vbCrLf &
                                       $"Gastos Básicos: {totalBasicos:C2}" & vbCrLf &
                                       $"Gastos Discrecionales: {totalDiscrecionales:C2}" & vbCrLf &
                                       $"Gastos Extraordinarios: {totalExtraordinarios:C2}" & vbCrLf &
                                       $"Ingresos Disponibles: {ingresosRestantes:C2}"

            MessageBox.Show(resultado, "Cálculos Realizados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al calcular los ingresos disponibles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Asegurarse de cerrar la conexión
            If miConexion.State = ConnectionState.Open Then
                miConexion.Close()
            End If
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
        Try
            If miConexion.State = ConnectionState.Closed Then
                miConexion.Open()
            End If

            Dim cmd As String = "SELECT COUNT(*) FROM integrantes WHERE idintegrantes = @idint"
            Dim comando As New MySqlCommand(cmd, miConexion)
            comando.Parameters.AddWithValue("@idint", idIntegrante)

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


