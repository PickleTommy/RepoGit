<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abmIngresos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abmIngresos))
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
        btnGuardar = New Button()
        btnNuevo = New Button()
        CType(DGVcalculos, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DGVcalculos
        ' 
        DGVcalculos.BackgroundColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        DGVcalculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVcalculos.Location = New Point(23, 298)
        DGVcalculos.Name = "DGVcalculos"
        DGVcalculos.Size = New Size(779, 202)
        DGVcalculos.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(14, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 21)
        Label1.TabIndex = 0
        Label1.Text = "Integrante: "
        ' 
        ' tbIntegrante
        ' 
        tbIntegrante.Font = New Font("Segoe UI", 12F)
        tbIntegrante.Location = New Point(108, 33)
        tbIntegrante.Name = "tbIntegrante"
        tbIntegrante.Size = New Size(219, 29)
        tbIntegrante.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(14, 71)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 21)
        Label3.TabIndex = 0
        Label3.Text = "Monto: "
        ' 
        ' tbMonto
        ' 
        tbMonto.Font = New Font("Segoe UI", 12F)
        tbMonto.Location = New Point(108, 68)
        tbMonto.Name = "tbMonto"
        tbMonto.Size = New Size(219, 29)
        tbMonto.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(14, 110)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 21)
        Label4.TabIndex = 0
        Label4.Text = "Fuente: "
        ' 
        ' tbFuente
        ' 
        tbFuente.Font = New Font("Segoe UI", 12F)
        tbFuente.Location = New Point(108, 107)
        tbFuente.Name = "tbFuente"
        tbFuente.Size = New Size(219, 29)
        tbFuente.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(14, 152)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 21)
        Label5.TabIndex = 0
        Label5.Text = "Fecha:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Segoe UI", 12F)
        DateTimePicker1.Font = New Font("Segoe UI", 12F)
        DateTimePicker1.Location = New Point(108, 146)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(219, 29)
        DateTimePicker1.TabIndex = 4
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        GroupBox1.Controls.Add(tbMonto)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(tbFuente)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(tbIntegrante)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.ForeColor = Color.FromArgb(CByte(16), CByte(176), CByte(253))
        GroupBox1.Location = New Point(23, 23)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(349, 203)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Ingresos"
        ' 
        ' btnEditar
        ' 
        btnEditar.BackColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        btnEditar.FlatStyle = FlatStyle.Flat
        btnEditar.Font = New Font("Segoe UI", 12F)
        btnEditar.ForeColor = Color.FromArgb(CByte(16), CByte(176), CByte(253))
        btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), Image)
        btnEditar.ImageAlign = ContentAlignment.MiddleRight
        btnEditar.Location = New Point(617, 157)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(120, 56)
        btnEditar.TabIndex = 7
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Segoe UI", 12F)
        btnEliminar.ForeColor = Color.FromArgb(CByte(16), CByte(176), CByte(253))
        btnEliminar.Image = My.Resources.Resources.remove
        btnEliminar.ImageAlign = ContentAlignment.MiddleRight
        btnEliminar.Location = New Point(616, 86)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(121, 57)
        btnEliminar.TabIndex = 8
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.Font = New Font("Segoe UI", 12F)
        btnGuardar.ForeColor = Color.FromArgb(CByte(16), CByte(176), CByte(253))
        btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), Image)
        btnGuardar.ImageAlign = ContentAlignment.MiddleRight
        btnGuardar.Location = New Point(465, 155)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(123, 57)
        btnGuardar.TabIndex = 10
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnNuevo
        ' 
        btnNuevo.BackColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        btnNuevo.FlatStyle = FlatStyle.Flat
        btnNuevo.Font = New Font("Segoe UI", 12F)
        btnNuevo.ForeColor = Color.FromArgb(CByte(16), CByte(176), CByte(253))
        btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), Image)
        btnNuevo.ImageAlign = ContentAlignment.MiddleRight
        btnNuevo.Location = New Point(465, 86)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(123, 57)
        btnNuevo.TabIndex = 11
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' abmIngresos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(825, 520)
        Controls.Add(btnEditar)
        Controls.Add(btnEliminar)
        Controls.Add(btnGuardar)
        Controls.Add(btnNuevo)
        Controls.Add(DGVcalculos)
        Controls.Add(GroupBox1)
        Name = "abmIngresos"
        Text = "calculosMonto"
        CType(DGVcalculos, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub
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
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
End Class
