<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abmGastos
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
        DGVgastos = New DataGridView()
        btnEditar = New Button()
        btnEliminar = New Button()
        btnGuardar = New Button()
        btnNuevo = New Button()
        tbGastos = New TextBox()
        Label6 = New Label()
        GroupBox1 = New GroupBox()
        DateTimePicker1 = New DateTimePicker()
        tbCuotas = New TextBox()
        tbDescripcion = New TextBox()
        tbFormaPago = New TextBox()
        tbIntegrante = New TextBox()
        tbMonto = New TextBox()
        tbTipoGasto = New TextBox()
        Label7 = New Label()
        Label5 = New Label()
        Label8 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        CType(DGVgastos, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DGVgastos
        ' 
        DGVgastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVgastos.Location = New Point(12, 286)
        DGVgastos.Name = "DGVgastos"
        DGVgastos.Size = New Size(829, 255)
        DGVgastos.TabIndex = 13
        ' 
        ' btnEditar
        ' 
        btnEditar.Font = New Font("Segoe UI", 12F)
        btnEditar.Image = My.Resources.Resources.edit
        btnEditar.ImageAlign = ContentAlignment.MiddleRight
        btnEditar.Location = New Point(602, 139)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(120, 56)
        btnEditar.TabIndex = 8
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Font = New Font("Segoe UI", 12F)
        btnEliminar.Image = My.Resources.Resources.remove
        btnEliminar.ImageAlign = ContentAlignment.MiddleRight
        btnEliminar.Location = New Point(601, 68)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(121, 57)
        btnEliminar.TabIndex = 9
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Font = New Font("Segoe UI", 12F)
        btnGuardar.Image = My.Resources.Resources.save
        btnGuardar.ImageAlign = ContentAlignment.MiddleRight
        btnGuardar.Location = New Point(450, 137)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(123, 57)
        btnGuardar.TabIndex = 11
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Font = New Font("Segoe UI", 12F)
        btnNuevo.Image = My.Resources.Resources.add
        btnNuevo.ImageAlign = ContentAlignment.MiddleRight
        btnNuevo.Location = New Point(450, 68)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(123, 57)
        btnNuevo.TabIndex = 12
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' tbGastos
        ' 
        tbGastos.Location = New Point(58, 257)
        tbGastos.Name = "tbGastos"
        tbGastos.Size = New Size(166, 23)
        tbGastos.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(99, 138)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 21)
        Label6.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(tbCuotas)
        GroupBox1.Controls.Add(tbDescripcion)
        GroupBox1.Controls.Add(tbFormaPago)
        GroupBox1.Controls.Add(tbIntegrante)
        GroupBox1.Controls.Add(tbMonto)
        GroupBox1.Controls.Add(tbTipoGasto)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Location = New Point(37, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(300, 239)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Gasto"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(152, 203)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(136, 23)
        DateTimePicker1.TabIndex = 2
        ' 
        ' tbCuotas
        ' 
        tbCuotas.Location = New Point(149, 171)
        tbCuotas.Name = "tbCuotas"
        tbCuotas.Size = New Size(136, 23)
        tbCuotas.TabIndex = 1
        ' 
        ' tbDescripcion
        ' 
        tbDescripcion.Location = New Point(149, 76)
        tbDescripcion.Name = "tbDescripcion"
        tbDescripcion.Size = New Size(136, 23)
        tbDescripcion.TabIndex = 1
        ' 
        ' tbFormaPago
        ' 
        tbFormaPago.Location = New Point(149, 107)
        tbFormaPago.Name = "tbFormaPago"
        tbFormaPago.Size = New Size(136, 23)
        tbFormaPago.TabIndex = 1
        ' 
        ' tbIntegrante
        ' 
        tbIntegrante.Location = New Point(149, 17)
        tbIntegrante.Name = "tbIntegrante"
        tbIntegrante.Size = New Size(136, 23)
        tbIntegrante.TabIndex = 1
        ' 
        ' tbMonto
        ' 
        tbMonto.Location = New Point(149, 45)
        tbMonto.Name = "tbMonto"
        tbMonto.Size = New Size(136, 23)
        tbMonto.TabIndex = 1
        ' 
        ' tbTipoGasto
        ' 
        tbTipoGasto.Location = New Point(149, 139)
        tbTipoGasto.Name = "tbTipoGasto"
        tbTipoGasto.Size = New Size(136, 23)
        tbTipoGasto.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.Location = New Point(90, 203)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 21)
        Label7.TabIndex = 0
        Label7.Text = "Fecha:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(82, 173)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 21)
        Label5.TabIndex = 0
        Label5.Text = "Cuotas:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F)
        Label8.Location = New Point(55, 19)
        Label8.Name = "Label8"
        Label8.Size = New Size(88, 21)
        Label8.TabIndex = 0
        Label8.Text = "Integrante: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(80, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 21)
        Label1.TabIndex = 0
        Label1.Text = "Monto: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(45, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 21)
        Label2.TabIndex = 0
        Label2.Text = "Descripción: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(21, 107)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 21)
        Label3.TabIndex = 0
        Label3.Text = "Forma de pago: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(35, 141)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 21)
        Label4.TabIndex = 0
        Label4.Text = "Tipo de Gasto:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.find
        PictureBox1.Location = New Point(22, 258)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(30, 22)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' abmGastos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(864, 550)
        Controls.Add(PictureBox1)
        Controls.Add(DGVgastos)
        Controls.Add(btnEditar)
        Controls.Add(btnEliminar)
        Controls.Add(btnGuardar)
        Controls.Add(btnNuevo)
        Controls.Add(tbGastos)
        Controls.Add(Label6)
        Controls.Add(GroupBox1)
        Name = "abmGastos"
        Text = "abmGastos"
        CType(DGVgastos, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DGVgastos As DataGridView
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents tbGastos As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents tbCuotas As TextBox
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents tbFormaPago As TextBox
    Friend WithEvents tbMonto As TextBox
    Friend WithEvents tbTipoGasto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbIntegrante As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
