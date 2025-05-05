<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Usuario = New Label()
        txtUsuario = New TextBox()
        Label1 = New Label()
        txtContraseña = New TextBox()
        GroupBox1 = New GroupBox()
        Log = New Button()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Usuario
        ' 
        Usuario.AutoSize = True
        Usuario.Location = New Point(54, 28)
        Usuario.Name = "Usuario"
        Usuario.Size = New Size(50, 15)
        Usuario.TabIndex = 0
        Usuario.Text = "Usuario:"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(110, 25)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(174, 23)
        txtUsuario.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 15)
        Label1.TabIndex = 0
        Label1.Text = "Contraseña:"
        ' 
        ' txtContraseña
        ' 
        txtContraseña.Location = New Point(110, 54)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.Size = New Size(174, 23)
        txtContraseña.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Log)
        GroupBox1.Controls.Add(txtContraseña)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtUsuario)
        GroupBox1.Controls.Add(Usuario)
        GroupBox1.Location = New Point(206, 305)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(375, 143)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Login de usuario"
        ' 
        ' Log
        ' 
        Log.Location = New Point(133, 97)
        Log.Name = "Log"
        Log.Size = New Size(100, 29)
        Log.TabIndex = 2
        Log.Text = "Iniciar Sesión"
        Log.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(104, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(586, 287)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(804, 472)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Login"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Usuario As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Log As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
