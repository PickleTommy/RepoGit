Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Printing

Public Class Calculos
    Private miConexion As MySqlConnection
    Private calculosDA As MySqlDataAdapter
    Private calculosDS As DataSet

    Private Sub Calculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Inicializar la conexión a la base de datos
            miConexion = New MySqlConnection("Server=LocalHost;Uid=root;Pwd=;database=bdproyectoprog")

            ' Inicializar el DataAdapter y DataSet
            calculosDA = New MySqlDataAdapter()
            calculosDA.SelectCommand = New MySqlCommand("SELECT * FROM calculos", miConexion)

            calculosDS = New DataSet()
            calculosDS.Tables.Add("Calculos")

            calculosDA.Fill(calculosDS.Tables("Calculos"))
        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Try
            ' Verificar si la conexión está abierta, y si no, la abrimos
            If miConexion.State = ConnectionState.Closed Then
                miConexion.Open()
            End If

            ' Variables para almacenar los cálculos
            Dim totalIngresos As Decimal = 0
            Dim totalGB As Decimal = 0
            Dim totalGD As Decimal = 0
            Dim totalGE As Decimal = 0
            Dim ahorroMonto As Decimal = 0
            Dim porcentajeAhorro As Decimal = 0.2D ' 20% por defecto
            Dim saldoDisponible As Decimal = 0

            ' Sumar todos los montos de la tabla ingresos
            Dim cmdIngresos As String = "SELECT SUM(monto) FROM ingresos"
            Dim comandoIngresos As New MySqlCommand(cmdIngresos, miConexion)
            totalIngresos = If(IsDBNull(comandoIngresos.ExecuteScalar()), 0, Convert.ToDecimal(comandoIngresos.ExecuteScalar()))

            ' Sumar todos los gastos básicos
            Dim cmdGB As String = "SELECT SUM(monto) FROM gastos WHERE tipo_gasto = 'basico'"
            Dim comandoGB As New MySqlCommand(cmdGB, miConexion)
            totalGB = If(IsDBNull(comandoGB.ExecuteScalar()), 0, Convert.ToDecimal(comandoGB.ExecuteScalar()))

            ' Sumar todos los gastos discrecionales
            Dim cmdGD As String = "SELECT SUM(monto) FROM gastos WHERE tipo_gasto = 'discrecional'"
            Dim comandoGD As New MySqlCommand(cmdGD, miConexion)
            totalGD = If(IsDBNull(comandoGD.ExecuteScalar()), 0, Convert.ToDecimal(comandoGD.ExecuteScalar()))

            ' Sumar todos los gastos extraordinarios
            Dim cmdGE As String = "SELECT SUM(monto) FROM gastos WHERE tipo_gasto = 'extraordinario'"
            Dim comandoGE As New MySqlCommand(cmdGE, miConexion)
            totalGE = If(IsDBNull(comandoGE.ExecuteScalar()), 0, Convert.ToDecimal(comandoGE.ExecuteScalar()))

            ' Validar el valor de la TextBox tbAhorro
            If Not Decimal.TryParse(tbAhorro.Text, porcentajeAhorro) OrElse porcentajeAhorro <= 0 Then
                porcentajeAhorro = 0.2D ' Asignar 20% por defecto si el valor no es válido
            Else
                porcentajeAhorro /= 100 ' Convertir el porcentaje ingresado a decimal
            End If

            ' Calcular el monto de ahorro
            ahorroMonto = totalIngresos * porcentajeAhorro

            ' Calcular el saldo disponible
            saldoDisponible = totalIngresos - ahorroMonto
            saldoDisponible -= totalGB
            saldoDisponible -= totalGD
            saldoDisponible -= totalGE

            ' Almacenar los datos en la base de datos 'calculos' (sobrescribir si ya existe)
            Dim cmdInsertOrUpdate As String = "
            INSERT INTO calculos (idcalculos, totalingreso, totalgb, totalgd, totalge, ahorromonto, saldodisponible)
            VALUES (@id, @ingreso, @gb, @gd, @ge, @ahorro, @saldo)
            ON DUPLICATE KEY UPDATE 
                totalingreso = VALUES(totalingreso),
                totalgb = VALUES(totalgb),
                totalgd = VALUES(totalgd),
                totalge = VALUES(totalge),
                ahorromonto = VALUES(ahorromonto),
                saldodisponible = VALUES(saldodisponible)"
            Dim comandoInsertarActualizar As New MySqlCommand(cmdInsertOrUpdate, miConexion)

            ' Asignar valores a los parámetros
            comandoInsertarActualizar.Parameters.AddWithValue("@id", 1) ' ID fijo o dinámico según tu lógica
            comandoInsertarActualizar.Parameters.AddWithValue("@ingreso", totalIngresos)
            comandoInsertarActualizar.Parameters.AddWithValue("@gb", totalGB)
            comandoInsertarActualizar.Parameters.AddWithValue("@gd", totalGD)
            comandoInsertarActualizar.Parameters.AddWithValue("@ge", totalGE)
            comandoInsertarActualizar.Parameters.AddWithValue("@ahorro", ahorroMonto)
            comandoInsertarActualizar.Parameters.AddWithValue("@saldo", saldoDisponible)

            ' Ejecutar la consulta
            comandoInsertarActualizar.ExecuteNonQuery()

            ' Mostrar un mensaje de éxito
            MessageBox.Show("Cálculos realizados y almacenados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al realizar los cálculos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Asegurarse de cerrar la conexión
            If miConexion.State = ConnectionState.Open Then
                miConexion.Close()
            End If
        End Try
    End Sub

    Private Sub Resumen_Click(sender As Object, e As EventArgs) Handles Resumen.Click
        Try
            ' Generar el PDF
            GenerarPDF()
        Catch ex As Exception
            MessageBox.Show("Error al generar el resumen: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GenerarPDF()
        Try
            ' Configurar el documento para imprimir
            Dim printDoc As New PrintDocument()
            AddHandler printDoc.PrintPage, AddressOf PrintPageHandler

            ' Configurar el diálogo para guardar el PDF
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Archivos PDF (*.pdf)|*.pdf"
            saveDialog.Title = "Guardar Resumen como PDF"
            saveDialog.FileName = "ResumenCalculos.pdf"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                ' Configurar la impresora virtual de PDF
                Dim printerSettings As New PrinterSettings()
                printerSettings.PrinterName = "Microsoft Print to PDF"
                printerSettings.PrintToFile = True
                printerSettings.PrintFileName = saveDialog.FileName

                printDoc.PrinterSettings = printerSettings
                printDoc.Print()

                MessageBox.Show("El PDF se ha generado correctamente en: " & saveDialog.FileName, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al generar el PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs)
        ' Configurar el contenido del PDF
        Dim font As New Font("Arial", 12)
        Dim y As Integer = 20

        e.Graphics.DrawString("Resumen de Cálculos", New Font("Arial", 16, FontStyle.Bold), Brushes.Black, 20, y)
        y += 40

        ' Aquí puedes agregar los datos que deseas incluir en el PDF
        e.Graphics.DrawString("Total Ingresos: 1000.00", font, Brushes.Black, 20, y)
        y += 20
        e.Graphics.DrawString("Gastos Básicos: 500.00", font, Brushes.Black, 20, y)
        y += 20
        e.Graphics.DrawString("Gastos Discrecionales: 200.00", font, Brushes.Black, 20, y)
        y += 20
        e.Graphics.DrawString("Gastos Extraordinarios: 100.00", font, Brushes.Black, 20, y)
        y += 20
        e.Graphics.DrawString("Monto Ahorro: 200.00", font, Brushes.Black, 20, y)
        y += 20
        e.Graphics.DrawString("Saldo Disponible: 0.00", font, Brushes.Black, 20, y)
    End Sub
End Class
