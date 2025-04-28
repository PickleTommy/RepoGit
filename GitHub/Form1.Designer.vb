<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        AddIntegrante = New Button()
        ABMGastos = New Button()
        AddMonto = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' AddIntegrante
        ' 
        AddIntegrante.Location = New Point(176, 25)
        AddIntegrante.Name = "AddIntegrante"
        AddIntegrante.Size = New Size(346, 78)
        AddIntegrante.TabIndex = 0
        AddIntegrante.Text = "Agregar Integrante"
        AddIntegrante.UseVisualStyleBackColor = True
        ' 
        ' ABMGastos
        ' 
        ABMGastos.Location = New Point(176, 119)
        ABMGastos.Name = "ABMGastos"
        ABMGastos.Size = New Size(346, 84)
        ABMGastos.TabIndex = 1
        ABMGastos.Text = "Modificar Gastos"
        ABMGastos.UseVisualStyleBackColor = True
        ' 
        ' AddMonto
        ' 
        AddMonto.Location = New Point(176, 221)
        AddMonto.Name = "AddMonto"
        AddMonto.Size = New Size(346, 84)
        AddMonto.TabIndex = 2
        AddMonto.Text = "Ingresar Monto"
        AddMonto.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(176, 325)
        Button1.Name = "Button1"
        Button1.Size = New Size(346, 84)
        Button1.TabIndex = 3
        Button1.Text = "Mostrar Integrante"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(AddMonto)
        Controls.Add(ABMGastos)
        Controls.Add(AddIntegrante)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents AddIntegrante As Button
    Friend WithEvents ABMGastos As Button
    Friend WithEvents AddMonto As Button
    Friend WithEvents Button1 As Button

End Class
