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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abmGastos))
        DGVgastos = New DataGridView()
        btnEditar = New Button()
        btnEliminar = New Button()
        btnGuardar = New Button()
        btnNuevo = New Button()
        tbGastos = New TextBox()
        Label6 = New Label()
        GroupBox1 = New GroupBox()
        DateTimePicker1 = New DateTimePicker()
        tbAhorro = New TextBox()
        tbCuotas = New TextBox()
        tbDescripcion = New TextBox()
        tbFormaPago = New TextBox()
        tbIntegrante = New TextBox()
        tbMonto = New TextBox()
        tbTipoGasto = New TextBox()
        Label7 = New Label()
        Label9 = New Label()
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
        DGVgastos.BackgroundColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        DGVgastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVgastos.Location = New Point(27, 370)
        DGVgastos.Name = "DGVgastos"
        DGVgastos.Size = New Size(896, 245)
        DGVgastos.TabIndex = 13
        ' 
        ' btnEditar
        ' 
        btnEditar.BackColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        btnEditar.FlatStyle = FlatStyle.Flat
        btnEditar.Font = New Font("Segoe UI", 11F)
        btnEditar.ForeColor = Color.FromArgb(CByte(16), CByte(176), CByte(253))
        btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), Image)
        btnEditar.ImageAlign = ContentAlignment.MiddleRight
        btnEditar.Location = New Point(658, 191)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(119, 61)
        btnEditar.TabIndex = 8
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Segoe UI", 11F)
        btnEliminar.ForeColor = Color.FromArgb(CByte(16), CByte(176), CByte(253))
        btnEliminar.Image = My.Resources.Resources.remove
        btnEliminar.ImageAlign = ContentAlignment.MiddleRight
        btnEliminar.Location = New Point(658, 107)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(119, 61)
        btnEliminar.TabIndex = 9
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.Font = New Font("Segoe UI", 11F)
        btnGuardar.ForeColor = Color.FromArgb(CByte(16), CByte(176), CByte(253))
        btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), Image)
        btnGuardar.ImageAlign = ContentAlignment.MiddleRight
        btnGuardar.Location = New Point(521, 191)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(119, 61)
        btnGuardar.TabIndex = 11
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnNuevo
        ' 
        btnNuevo.BackColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        btnNuevo.FlatStyle = FlatStyle.Flat
        btnNuevo.Font = New Font("Segoe UI", 11F)
        btnNuevo.ForeColor = Color.FromArgb(CByte(16), CByte(176), CByte(253))
        btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), Image)
        btnNuevo.ImageAlign = ContentAlignment.MiddleRight
        btnNuevo.Location = New Point(521, 107)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(119, 61)
        btnNuevo.TabIndex = 12
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' tbGastos
        ' 
        tbGastos.Location = New Point(99, 341)
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
        GroupBox1.BackColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(tbAhorro)
        GroupBox1.Controls.Add(tbCuotas)
        GroupBox1.Controls.Add(tbDescripcion)
        GroupBox1.Controls.Add(tbFormaPago)
        GroupBox1.Controls.Add(tbIntegrante)
        GroupBox1.Controls.Add(tbMonto)
        GroupBox1.Controls.Add(tbTipoGasto)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.ForeColor = Color.FromArgb(CByte(16), CByte(176), CByte(253))
        GroupBox1.Location = New Point(37, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(311, 271)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Gasto"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(149, 231)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(136, 23)
        DateTimePicker1.TabIndex = 2
        ' 
        ' tbAhorro
        ' 
        tbAhorro.Location = New Point(149, 200)
        tbAhorro.Name = "tbAhorro"
        tbAhorro.Size = New Size(136, 23)
        tbAhorro.TabIndex = 1
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
        Label7.Location = New Point(17, 231)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 21)
        Label7.TabIndex = 0
        Label7.Text = "Fecha:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F)
        Label9.Location = New Point(16, 198)
        Label9.Name = "Label9"
        Label9.Size = New Size(62, 21)
        Label9.TabIndex = 0
        Label9.Text = "Ahorro:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(17, 169)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 21)
        Label5.TabIndex = 0
        Label5.Text = "Cuotas:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F)
        Label8.Location = New Point(15, 19)
        Label8.Name = "Label8"
        Label8.Size = New Size(88, 21)
        Label8.TabIndex = 0
        Label8.Text = "Integrante: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(15, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 21)
        Label1.TabIndex = 0
        Label1.Text = "Monto: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(15, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 21)
        Label2.TabIndex = 0
        Label2.Text = "Descripción: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(15, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 21)
        Label3.TabIndex = 0
        Label3.Text = "Forma de pago: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(15, 137)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 21)
        Label4.TabIndex = 0
        Label4.Text = "Tipo de Gasto:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        PictureBox1.Image = My.Resources.Resources.find
        PictureBox1.Location = New Point(54, 330)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(35, 34)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' abmGastos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(951, 637)
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
    Friend WithEvents tbAhorro As TextBox
    Friend WithEvents Label9 As Label
End Class
