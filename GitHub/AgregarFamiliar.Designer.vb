<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarFamiliar
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
        Nombre = New Label()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        Label1 = New Label()
        txtEdad = New TextBox()
        Label2 = New Label()
        txtRol = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Nombre
        ' 
        Nombre.AutoSize = True
        Nombre.Location = New Point(78, 54)
        Nombre.Name = "Nombre"
        Nombre.Size = New Size(57, 15)
        Nombre.TabIndex = 0
        Nombre.Text = "Nombre: "
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(141, 51)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 1
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(141, 87)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(100, 23)
        txtApellido.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(78, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 15)
        Label1.TabIndex = 2
        Label1.Text = "Apellido:"
        ' 
        ' txtEdad
        ' 
        txtEdad.Location = New Point(141, 129)
        txtEdad.Name = "txtEdad"
        txtEdad.Size = New Size(100, 23)
        txtEdad.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(96, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 4
        Label2.Text = "Edad:"
        ' 
        ' txtRol
        ' 
        txtRol.Location = New Point(141, 169)
        txtRol.Name = "txtRol"
        txtRol.Size = New Size(100, 23)
        txtRol.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(105, 172)
        Label3.Name = "Label3"
        Label3.Size = New Size(27, 15)
        Label3.TabIndex = 6
        Label3.Text = "Rol:"
        ' 
        ' AgregarFamiliar
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtRol)
        Controls.Add(Label3)
        Controls.Add(txtEdad)
        Controls.Add(Label2)
        Controls.Add(txtApellido)
        Controls.Add(Label1)
        Controls.Add(txtNombre)
        Controls.Add(Nombre)
        Name = "AgregarFamiliar"
        Text = "AgregarFamiliar"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Nombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRol As TextBox
    Friend WithEvents Label3 As Label
End Class
