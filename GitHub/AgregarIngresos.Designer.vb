<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarIngresos
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
        txtIngreso = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(138, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' txtIngreso
        ' 
        txtIngreso.Location = New Point(285, 189)
        txtIngreso.Name = "txtIngreso"
        txtIngreso.Size = New Size(172, 23)
        txtIngreso.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(311, 240)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 42)
        Button1.TabIndex = 2
        Button1.Text = "Guardar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' AgregarIngresos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(txtIngreso)
        Controls.Add(Label1)
        Name = "AgregarIngresos"
        Text = "AgregarIngresos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIngreso As TextBox
    Friend WithEvents Button1 As Button
End Class
