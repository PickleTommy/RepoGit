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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculos))
        Calcular = New Button()
        Resumen = New Button()
        tbAhorro = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Calcular
        ' 
        Calcular.FlatStyle = FlatStyle.Flat
        Calcular.Font = New Font("Segoe UI", 13F)
        Calcular.ForeColor = Color.FromArgb(CByte(16), CByte(176), CByte(253))
        Calcular.Location = New Point(168, 243)
        Calcular.Name = "Calcular"
        Calcular.Size = New Size(199, 114)
        Calcular.TabIndex = 0
        Calcular.Text = "Calcular Gastos"
        Calcular.UseVisualStyleBackColor = True
        ' 
        ' Resumen
        ' 
        Resumen.FlatStyle = FlatStyle.Flat
        Resumen.Font = New Font("Segoe UI", 13F)
        Resumen.ForeColor = Color.FromArgb(CByte(16), CByte(176), CByte(253))
        Resumen.Location = New Point(449, 243)
        Resumen.Name = "Resumen"
        Resumen.Size = New Size(199, 114)
        Resumen.TabIndex = 0
        Resumen.Text = "Generar Resúmen"
        Resumen.UseVisualStyleBackColor = True
        ' 
        ' tbAhorro
        ' 
        tbAhorro.Location = New Point(337, 102)
        tbAhorro.Name = "tbAhorro"
        tbAhorro.Size = New Size(179, 23)
        tbAhorro.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        Label1.ForeColor = Color.FromArgb(CByte(16), CByte(176), CByte(253))
        Label1.Location = New Point(259, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 23)
        Label1.TabIndex = 2
        Label1.Text = "Ahorro:"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Calculos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
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
