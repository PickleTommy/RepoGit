<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        AddMonto = New Button()
        btnIntegrantes = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' AddMonto
        ' 
        AddMonto.Location = New Point(243, 137)
        AddMonto.Name = "AddMonto"
        AddMonto.Size = New Size(267, 78)
        AddMonto.TabIndex = 2
        AddMonto.Text = "Ingresar Monto"
        AddMonto.UseVisualStyleBackColor = True
        ' 
        ' btnIntegrantes
        ' 
        btnIntegrantes.Location = New Point(243, 34)
        btnIntegrantes.Name = "btnIntegrantes"
        btnIntegrantes.Size = New Size(267, 78)
        btnIntegrantes.TabIndex = 2
        btnIntegrantes.Text = "Integrantes"
        btnIntegrantes.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(243, 235)
        Button2.Name = "Button2"
        Button2.Size = New Size(267, 78)
        Button2.TabIndex = 2
        Button2.Text = "Gastos"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(243, 335)
        Button3.Name = "Button3"
        Button3.Size = New Size(267, 78)
        Button3.TabIndex = 2
        Button3.Text = "Resúmen"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnIntegrantes)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(AddMonto)
        Name = "Menu"
        Text = "Form1"
        ResumeLayout(False)
    End Sub
    Friend WithEvents AddMonto As Button
    Friend WithEvents btnIntegrantes As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button

End Class
