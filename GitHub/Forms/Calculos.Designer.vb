<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculos
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
        Calcular = New Button()
        Resumen = New Button()
        tbAhorro = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Calcular
        ' 
        Calcular.Location = New Point(483, 46)
        Calcular.Name = "Calcular"
        Calcular.Size = New Size(199, 114)
        Calcular.TabIndex = 0
        Calcular.Text = "Calcular Gastos"
        Calcular.UseVisualStyleBackColor = True
        ' 
        ' Resumen
        ' 
        Resumen.Location = New Point(483, 243)
        Resumen.Name = "Resumen"
        Resumen.Size = New Size(199, 114)
        Resumen.TabIndex = 0
        Resumen.Text = "Generar Resúmen"
        Resumen.UseVisualStyleBackColor = True
        ' 
        ' tbAhorro
        ' 
        tbAhorro.Location = New Point(194, 198)
        tbAhorro.Name = "tbAhorro"
        tbAhorro.Size = New Size(162, 23)
        tbAhorro.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(141, 201)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 2
        Label1.Text = "Ahorro:"
        ' 
        ' Calculos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(tbAhorro)
        Controls.Add(Resumen)
        Controls.Add(Calcular)
        Name = "Calculos"
        Text = "Calculos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Calcular As Button
    Friend WithEvents Resumen As Button
    Friend WithEvents tbAhorro As TextBox
    Friend WithEvents Label1 As Label
End Class
