<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calculosMonto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label2 = New Label()
        tbPorcentajeAhorro = New TextBox()
        DGVcalculos = New DataGridView()
        Label1 = New Label()
        tbIntegrante = New TextBox()
        Label3 = New Label()
        tbMonto = New TextBox()
        Label4 = New Label()
        tbFuente = New TextBox()
        Label5 = New Label()
        DateTimePicker1 = New DateTimePicker()
        GroupBox1 = New GroupBox()
        btnEditar = New Button()
        btnEliminar = New Button()
        btnVolver = New Button()
        btnGuardar = New Button()
        btnNuevo = New Button()
        btnCalcular = New Button()
        CType(DGVcalculos, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(37, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(157, 21)
        Label2.TabIndex = 0
        Label2.Text = "Porcentaje de ahorro:"
        ' 
        ' tbPorcentajeAhorro
        ' 
        tbPorcentajeAhorro.Font = New Font("Segoe UI", 12F)
        tbPorcentajeAhorro.Location = New Point(200, 47)
        tbPorcentajeAhorro.Name = "tbPorcentajeAhorro"
        tbPorcentajeAhorro.Size = New Size(219, 29)
        tbPorcentajeAhorro.TabIndex = 1
        ' 
        ' DGVcalculos
        ' 
        DGVcalculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVcalculos.Location = New Point(56, 298)
        DGVcalculos.Name = "DGVcalculos"
        DGVcalculos.Size = New Size(693, 172)
        DGVcalculos.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(106, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 21)
        Label1.TabIndex = 0
        Label1.Text = "Integrante: "
        ' 
        ' tbIntegrante
        ' 
        tbIntegrante.Font = New Font("Segoe UI", 12F)
        tbIntegrante.Location = New Point(200, 89)
        tbIntegrante.Name = "tbIntegrante"
        tbIntegrante.Size = New Size(219, 29)
        tbIntegrante.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(131, 130)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 21)
        Label3.TabIndex = 0
        Label3.Text = "Monto: "
        ' 
        ' tbMonto
        ' 
        tbMonto.Font = New Font("Segoe UI", 12F)
        tbMonto.Location = New Point(168, 100)
        tbMonto.Name = "tbMonto"
        tbMonto.Size = New Size(219, 29)
        tbMonto.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(98, 142)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 21)
        Label4.TabIndex = 0
        Label4.Text = "Fuente: "
        ' 
        ' tbFuente
        ' 
        tbFuente.Font = New Font("Segoe UI", 12F)
        tbFuente.Location = New Point(168, 139)
        tbFuente.Name = "tbFuente"
        tbFuente.Size = New Size(219, 29)
        tbFuente.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(109, 178)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 21)
        Label5.TabIndex = 0
        Label5.Text = "Fecha:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Segoe UI", 12F)
        DateTimePicker1.Font = New Font("Segoe UI", 12F)
        DateTimePicker1.Location = New Point(168, 178)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(219, 29)
        DateTimePicker1.TabIndex = 4
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(tbMonto)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(tbFuente)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Location = New Point(32, 27)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(416, 238)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Ingresos"
        ' 
        ' btnEditar
        ' 
        btnEditar.Font = New Font("Segoe UI", 12F)
        btnEditar.Location = New Point(671, 120)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(120, 56)
        btnEditar.TabIndex = 7
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Font = New Font("Segoe UI", 12F)
        btnEliminar.Location = New Point(670, 49)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(121, 57)
        btnEliminar.TabIndex = 8
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnVolver
        ' 
        btnVolver.Font = New Font("Segoe UI", 12F)
        btnVolver.Location = New Point(522, 187)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(120, 57)
        btnVolver.TabIndex = 9
        btnVolver.Text = "Volver"
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Font = New Font("Segoe UI", 12F)
        btnGuardar.Location = New Point(519, 118)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(123, 57)
        btnGuardar.TabIndex = 10
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Font = New Font("Segoe UI", 12F)
        btnNuevo.Location = New Point(519, 49)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(123, 57)
        btnNuevo.TabIndex = 11
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Font = New Font("Segoe UI", 12F)
        btnCalcular.Location = New Point(670, 187)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(120, 57)
        btnCalcular.TabIndex = 9
        btnCalcular.Text = "Calcular Gastos"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' calculosMonto
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(825, 520)
        Controls.Add(btnEditar)
        Controls.Add(btnEliminar)
        Controls.Add(btnCalcular)
        Controls.Add(btnVolver)
        Controls.Add(btnGuardar)
        Controls.Add(btnNuevo)
        Controls.Add(DGVcalculos)
        Controls.Add(tbIntegrante)
        Controls.Add(tbPorcentajeAhorro)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(GroupBox1)
        Name = "calculosMonto"
        Text = "calculosMonto"
        CType(DGVcalculos, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents tbPorcentajeAhorro As TextBox
    Friend WithEvents DGVcalculos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents tbIntegrante As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbMonto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbFuente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCalcular As Button
End Class
