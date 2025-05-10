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
        btnLog = New Button()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Usuario
        ' 
        Usuario.AutoSize = True
        Usuario.Font = New Font("Segoe UI", 10F)
        Usuario.Location = New Point(22, 26)
        Usuario.Name = "Usuario"
        Usuario.Size = New Size(59, 19)
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
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.Location = New Point(22, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 19)
        Label1.TabIndex = 0
        Label1.Text = "Contraseña:"
        ' 
        ' txtContraseña
        ' 
        txtContraseña.HideSelection = False
        txtContraseña.Location = New Point(110, 54)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.PasswordChar = "*"c
        txtContraseña.Size = New Size(174, 23)
        txtContraseña.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        GroupBox1.Controls.Add(btnLog)
        GroupBox1.Controls.Add(txtContraseña)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtUsuario)
        GroupBox1.Controls.Add(Usuario)
        GroupBox1.Font = New Font("Segoe UI", 9F)
        GroupBox1.ForeColor = Color.FromArgb(CByte(16), CByte(176), CByte(253))
        GroupBox1.Location = New Point(223, 298)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(375, 143)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Login de usuario"
        ' 
        ' btnLog
        ' 
        btnLog.BackColor = Color.FromArgb(CByte(19), CByte(56), CByte(66))
        btnLog.FlatStyle = FlatStyle.Flat
        btnLog.Location = New Point(133, 97)
        btnLog.Name = "btnLog"
        btnLog.Size = New Size(100, 29)
        btnLog.TabIndex = 2
        btnLog.Text = "Iniciar Sesión"
        btnLog.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-59, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(933, 486)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(804, 472)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
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
    Friend WithEvents btnLog As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
