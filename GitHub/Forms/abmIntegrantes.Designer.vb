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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abmIntegrantes))
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
        tbBusqueda = New TextBox()
        GroupBox1 = New GroupBox()
        DateTimePicker1 = New DateTimePicker()
        tbDNI = New TextBox()
        Label7 = New Label()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnEliminar = New Button()
        DGVintegrantes = New DataGridView()
        btnEditar = New Button()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(DGVintegrantes, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(11, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 21)
        Label1.TabIndex = 0
        Label1.Text = "Nombre:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(11, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 21)
        Label2.TabIndex = 0
        Label2.Text = "Apellido: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(11, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 21)
        Label3.TabIndex = 0
        Label3.Text = "Edad: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(11, 110)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 21)
        Label4.TabIndex = 0
        Label4.Text = "Rol:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(11, 145)
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
        ' tbBusqueda
        ' 
        tbBusqueda.Font = New Font("Segoe UI", 12F)
        tbBusqueda.Location = New Point(62, 261)
        tbBusqueda.Name = "tbBusqueda"
        tbBusqueda.Size = New Size(166, 29)
        tbBusqueda.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
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
        GroupBox1.ForeColor = Color.FromArgb(CByte(16), CByte(176), CByte(253))
        GroupBox1.Location = New Point(21, 22)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(307, 219)
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
        Label7.Location = New Point(11, 177)
        Label7.Name = "Label7"
        Label7.Size = New Size(141, 21)
        Label7.TabIndex = 0
        Label7.Text = "Fecha Nacimiento: "
        ' 
        ' btnNuevo
        ' 
        btnNuevo.BackColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        btnNuevo.FlatStyle = FlatStyle.Flat
        btnNuevo.Font = New Font("Segoe UI", 12F)
        btnNuevo.ForeColor = Color.FromArgb(CByte(16), CByte(176), CByte(253))
        btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), Image)
        btnNuevo.ImageAlign = ContentAlignment.MiddleRight
        btnNuevo.Location = New Point(466, 78)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(123, 57)
        btnNuevo.TabIndex = 3
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.Font = New Font("Segoe UI", 12F)
        btnGuardar.ForeColor = Color.FromArgb(CByte(16), CByte(176), CByte(253))
        btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), Image)
        btnGuardar.ImageAlign = ContentAlignment.MiddleRight
        btnGuardar.Location = New Point(466, 147)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(123, 57)
        btnGuardar.TabIndex = 3
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Segoe UI", 12F)
        btnEliminar.ForeColor = Color.FromArgb(CByte(16), CByte(176), CByte(253))
        btnEliminar.Image = My.Resources.Resources.remove
        btnEliminar.ImageAlign = ContentAlignment.MiddleRight
        btnEliminar.Location = New Point(617, 78)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(121, 57)
        btnEliminar.TabIndex = 3
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' DGVintegrantes
        ' 
        DGVintegrantes.BackgroundColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        DGVintegrantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVintegrantes.Location = New Point(21, 296)
        DGVintegrantes.Name = "DGVintegrantes"
        DGVintegrantes.Size = New Size(822, 255)
        DGVintegrantes.TabIndex = 4
        ' 
        ' btnEditar
        ' 
        btnEditar.BackColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        btnEditar.FlatStyle = FlatStyle.Flat
        btnEditar.Font = New Font("Segoe UI", 12F)
        btnEditar.ForeColor = Color.FromArgb(CByte(16), CByte(176), CByte(253))
        btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), Image)
        btnEditar.ImageAlign = ContentAlignment.MiddleRight
        btnEditar.Location = New Point(618, 149)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(120, 56)
        btnEditar.TabIndex = 3
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        PictureBox1.Image = My.Resources.Resources.find
        PictureBox1.Location = New Point(21, 257)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(35, 33)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' abmIntegrantes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(866, 572)
        Controls.Add(PictureBox1)
        Controls.Add(DGVintegrantes)
        Controls.Add(btnEditar)
        Controls.Add(btnEliminar)
        Controls.Add(btnGuardar)
        Controls.Add(btnNuevo)
        Controls.Add(tbBusqueda)
        Controls.Add(Label6)
        Controls.Add(GroupBox1)
        Name = "abmIntegrantes"
        Text = "abmIntegrantes"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DGVintegrantes, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents tbBusqueda As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents DGVintegrantes As DataGridView
    Friend WithEvents tbDNI As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnEditar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
