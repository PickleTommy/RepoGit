<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abmIntegrantes
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        tbNombre = New TextBox()
        tbApellido = New TextBox()
        tbEdad = New TextBox()
        tbRol = New TextBox()
        TextBox5 = New TextBox()
        GroupBox1 = New GroupBox()
        DateTimePicker1 = New DateTimePicker()
        tbDNI = New TextBox()
        Label7 = New Label()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnEliminar = New Button()
        DGVintegrantes = New DataGridView()
        btnVolver = New Button()
        btnEditar = New Button()
        GroupBox1.SuspendLayout()
        CType(DGVintegrantes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(71, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 21)
        Label1.TabIndex = 0
        Label1.Text = "Nombre:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(71, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 21)
        Label2.TabIndex = 0
        Label2.Text = "Apellido: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(94, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 21)
        Label3.TabIndex = 0
        Label3.Text = "Edad: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(106, 114)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 21)
        Label4.TabIndex = 0
        Label4.Text = "Rol:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(102, 145)
        Label5.Name = "Label5"
        Label5.Size = New Size(40, 21)
        Label5.TabIndex = 0
        Label5.Text = "DNI:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(83, 148)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 21)
        Label6.TabIndex = 0
        ' 
        ' tbNombre
        ' 
        tbNombre.Location = New Point(151, 21)
        tbNombre.Name = "tbNombre"
        tbNombre.Size = New Size(136, 23)
        tbNombre.TabIndex = 1
        ' 
        ' tbApellido
        ' 
        tbApellido.Location = New Point(151, 50)
        tbApellido.Name = "tbApellido"
        tbApellido.Size = New Size(136, 23)
        tbApellido.TabIndex = 1
        ' 
        ' tbEdad
        ' 
        tbEdad.Location = New Point(151, 79)
        tbEdad.Name = "tbEdad"
        tbEdad.Size = New Size(136, 23)
        tbEdad.TabIndex = 1
        ' 
        ' tbRol
        ' 
        tbRol.Location = New Point(151, 112)
        tbRol.Name = "tbRol"
        tbRol.Size = New Size(136, 23)
        tbRol.TabIndex = 1
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(21, 267)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(166, 23)
        TextBox5.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(tbDNI)
        GroupBox1.Controls.Add(tbApellido)
        GroupBox1.Controls.Add(tbEdad)
        GroupBox1.Controls.Add(tbNombre)
        GroupBox1.Controls.Add(tbRol)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Location = New Point(21, 22)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(293, 216)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Integrante"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(151, 177)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(136, 23)
        DateTimePicker1.TabIndex = 2
        ' 
        ' tbDNI
        ' 
        tbDNI.Location = New Point(151, 147)
        tbDNI.Name = "tbDNI"
        tbDNI.Size = New Size(136, 23)
        tbDNI.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.Location = New Point(6, 177)
        Label7.Name = "Label7"
        Label7.Size = New Size(141, 21)
        Label7.TabIndex = 0
        Label7.Text = "Fecha Nacimiento: "
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Font = New Font("Segoe UI", 12F)
        btnNuevo.Location = New Point(409, 31)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(123, 57)
        btnNuevo.TabIndex = 3
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Font = New Font("Segoe UI", 12F)
        btnGuardar.Location = New Point(409, 100)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(123, 57)
        btnGuardar.TabIndex = 3
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Font = New Font("Segoe UI", 12F)
        btnEliminar.Location = New Point(560, 31)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(121, 57)
        btnEliminar.TabIndex = 3
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' DGVintegrantes
        ' 
        DGVintegrantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVintegrantes.Location = New Point(21, 296)
        DGVintegrantes.Name = "DGVintegrantes"
        DGVintegrantes.Size = New Size(732, 255)
        DGVintegrantes.TabIndex = 4
        ' 
        ' btnVolver
        ' 
        btnVolver.Font = New Font("Segoe UI", 12F)
        btnVolver.Location = New Point(474, 169)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(120, 57)
        btnVolver.TabIndex = 3
        btnVolver.Text = "Volver"
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Font = New Font("Segoe UI", 12F)
        btnEditar.Location = New Point(561, 102)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(120, 56)
        btnEditar.TabIndex = 3
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' abmIntegrantes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(866, 572)
        Controls.Add(DGVintegrantes)
        Controls.Add(btnEditar)
        Controls.Add(btnEliminar)
        Controls.Add(btnVolver)
        Controls.Add(btnGuardar)
        Controls.Add(btnNuevo)
        Controls.Add(TextBox5)
        Controls.Add(Label6)
        Controls.Add(GroupBox1)
        Name = "abmIntegrantes"
        Text = "abmIntegrantes"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DGVintegrantes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbApellido As TextBox
    Friend WithEvents tbEdad As TextBox
    Friend WithEvents tbRol As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents DGVintegrantes As DataGridView
    Friend WithEvents tbDNI As TextBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnEditar As Button
End Class
