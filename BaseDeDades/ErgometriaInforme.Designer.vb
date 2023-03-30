<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErgometriaInforme
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ErgoInforme = New System.Windows.Forms.TextBox
        Me.Pacient = New System.Windows.Forms.TextBox
        Me.BtnSortir = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ErgoInforme
        '
        Me.ErgoInforme.Location = New System.Drawing.Point(12, 88)
        Me.ErgoInforme.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ErgoInforme.Multiline = True
        Me.ErgoInforme.Name = "ErgoInforme"
        Me.ErgoInforme.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ErgoInforme.Size = New System.Drawing.Size(687, 512)
        Me.ErgoInforme.TabIndex = 0
        '
        'Pacient
        '
        Me.Pacient.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Pacient.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Pacient.Enabled = False
        Me.Pacient.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pacient.Location = New System.Drawing.Point(16, 40)
        Me.Pacient.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pacient.Name = "Pacient"
        Me.Pacient.Size = New System.Drawing.Size(532, 19)
        Me.Pacient.TabIndex = 1
        '
        'BtnSortir
        '
        Me.BtnSortir.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSortir.Location = New System.Drawing.Point(594, 22)
        Me.BtnSortir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSortir.Name = "BtnSortir"
        Me.BtnSortir.Size = New System.Drawing.Size(105, 41)
        Me.BtnSortir.TabIndex = 2
        Me.BtnSortir.Text = "Sortir"
        Me.BtnSortir.UseVisualStyleBackColor = True
        '
        'ErgometriaInforme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(722, 635)
        Me.Controls.Add(Me.BtnSortir)
        Me.Controls.Add(Me.Pacient)
        Me.Controls.Add(Me.ErgoInforme)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ErgometriaInforme"
        Me.Text = "INFORME ERGOMETRIA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErgoInforme As System.Windows.Forms.TextBox
    Friend WithEvents Pacient As System.Windows.Forms.TextBox
    Friend WithEvents BtnSortir As System.Windows.Forms.Button
End Class
