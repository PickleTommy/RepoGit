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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        btnIngresos = New Button()
        btnIntegrantes = New Button()
        btnGastos = New Button()
        Calcular = New Button()
        SuspendLayout()
        ' 
        ' btnIngresos
        ' 
        btnIngresos.BackColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        btnIngresos.FlatStyle = FlatStyle.Flat
        btnIngresos.Font = New Font("Segoe UI", 12F)
        btnIngresos.ForeColor = Color.FromArgb(CByte(16), CByte(176), CByte(253))
        btnIngresos.Location = New Point(243, 137)
        btnIngresos.Name = "btnIngresos"
        btnIngresos.Size = New Size(267, 78)
        btnIngresos.TabIndex = 2
        btnIngresos.Text = "Monto"
        btnIngresos.UseVisualStyleBackColor = False
        ' 
        ' btnIntegrantes
        ' 
        btnIntegrantes.BackColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        btnIntegrantes.FlatStyle = FlatStyle.Flat
        btnIntegrantes.Font = New Font("Segoe UI", 12F)
        btnIntegrantes.ForeColor = Color.FromArgb(CByte(16), CByte(176), CByte(253))
        btnIntegrantes.Location = New Point(243, 34)
        btnIntegrantes.Name = "btnIntegrantes"
        btnIntegrantes.Size = New Size(267, 78)
        btnIntegrantes.TabIndex = 2
        btnIntegrantes.Text = "Integrantes"
        btnIntegrantes.UseVisualStyleBackColor = False
        ' 
        ' btnGastos
        ' 
        btnGastos.BackColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        btnGastos.FlatStyle = FlatStyle.Flat
        btnGastos.Font = New Font("Segoe UI", 12F)
        btnGastos.ForeColor = Color.FromArgb(CByte(16), CByte(176), CByte(253))
        btnGastos.Location = New Point(243, 235)
        btnGastos.Name = "btnGastos"
        btnGastos.Size = New Size(267, 78)
        btnGastos.TabIndex = 2
        btnGastos.Text = "Gastos"
        btnGastos.UseVisualStyleBackColor = False
        ' 
        ' Calcular
        ' 
        Calcular.BackColor = Color.FromArgb(CByte(9), CByte(33), CByte(40))
        Calcular.FlatStyle = FlatStyle.Flat
        Calcular.Font = New Font("Segoe UI", 12F)
        Calcular.ForeColor = Color.FromArgb(CByte(16), CByte(176), CByte(253))
        Calcular.Location = New Point(243, 335)
        Calcular.Name = "Calcular"
        Calcular.Size = New Size(267, 78)
        Calcular.TabIndex = 2
        Calcular.Text = "Cálculos"
        Calcular.UseVisualStyleBackColor = False
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
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
