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
        btnIngresos = New Button()
        btnIntegrantes = New Button()
        btnGastos = New Button()
        Calcular = New Button()
        SuspendLayout()
        ' 
        ' btnIngresos
        ' 
        btnIngresos.Font = New Font("Segoe UI", 12F)
        btnIngresos.Location = New Point(243, 137)
        btnIngresos.Name = "btnIngresos"
        btnIngresos.Size = New Size(267, 78)
        btnIngresos.TabIndex = 2
        btnIngresos.Text = "Monto"
        btnIngresos.UseVisualStyleBackColor = True
        ' 
        ' btnIntegrantes
        ' 
        btnIntegrantes.Font = New Font("Segoe UI", 12F)
        btnIntegrantes.Location = New Point(243, 34)
        btnIntegrantes.Name = "btnIntegrantes"
        btnIntegrantes.Size = New Size(267, 78)
        btnIntegrantes.TabIndex = 2
        btnIntegrantes.Text = "Integrantes"
        btnIntegrantes.UseVisualStyleBackColor = True
        ' 
        ' btnGastos
        ' 
        btnGastos.Font = New Font("Segoe UI", 12F)
        btnGastos.Location = New Point(243, 235)
        btnGastos.Name = "btnGastos"
        btnGastos.Size = New Size(267, 78)
        btnGastos.TabIndex = 2
        btnGastos.Text = "Gastos"
        btnGastos.UseVisualStyleBackColor = True
        ' 
        ' Calcular
        ' 
        Calcular.Font = New Font("Segoe UI", 12F)
        Calcular.Location = New Point(243, 335)
        Calcular.Name = "Calcular"
        Calcular.Size = New Size(267, 78)
        Calcular.TabIndex = 2
        Calcular.Text = "Cálculos"
        Calcular.UseVisualStyleBackColor = True
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnIntegrantes)
        Controls.Add(Calcular)
        Controls.Add(btnGastos)
        Controls.Add(btnIngresos)
        Name = "Menu"
        Text = "Form1"
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnIngresos As Button
    Friend WithEvents btnIntegrantes As Button
    Friend WithEvents btnGastos As Button
    Friend WithEvents Calcular As Button

End Class
