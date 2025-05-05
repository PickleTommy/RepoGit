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
        btnGastos = New Button()
        Resumen = New Button()
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
        ' btnGastos
        ' 
        btnGastos.Location = New Point(243, 235)
        btnGastos.Name = "btnGastos"
        btnGastos.Size = New Size(267, 78)
        btnGastos.TabIndex = 2
        btnGastos.Text = "Gastos"
        btnGastos.UseVisualStyleBackColor = True
        ' 
        ' Resumen
        ' 
        Resumen.Location = New Point(243, 335)
        Resumen.Name = "Resumen"
        Resumen.Size = New Size(267, 78)
        Resumen.TabIndex = 2
        Resumen.Text = "Resúmen"
        Resumen.UseVisualStyleBackColor = True
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnIntegrantes)
        Controls.Add(Resumen)
        Controls.Add(btnGastos)
        Controls.Add(AddMonto)
        Name = "Menu"
        Text = "Form1"
        ResumeLayout(False)
    End Sub
    Friend WithEvents AddMonto As Button
    Friend WithEvents btnIntegrantes As Button
    Friend WithEvents btnGastos As Button
    Friend WithEvents Resumen As Button

End Class
