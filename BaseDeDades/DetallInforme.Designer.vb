<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetallInforme
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
        Me.DetTitolInforme = New System.Windows.Forms.TextBox
        Me.DetNumColegiat = New System.Windows.Forms.TextBox
        Me.DetInforme = New System.Windows.Forms.TextBox
        Me.DetData = New System.Windows.Forms.TextBox
        Me.DetDiagnostic = New System.Windows.Forms.TextBox
        Me.DetTerapeuta = New System.Windows.Forms.TextBox
        Me.DetPacient = New System.Windows.Forms.TextBox
        Me.BtnSortir = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'DetTitolInforme
        '
        Me.DetTitolInforme.BackColor = System.Drawing.Color.Beige
        Me.DetTitolInforme.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetTitolInforme.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.DetTitolInforme.Location = New System.Drawing.Point(50, 38)
        Me.DetTitolInforme.Name = "DetTitolInforme"
        Me.DetTitolInforme.ReadOnly = True
        Me.DetTitolInforme.Size = New System.Drawing.Size(330, 17)
        Me.DetTitolInforme.TabIndex = 0
        Me.DetTitolInforme.TabStop = False
        '
        'DetNumColegiat
        '
        Me.DetNumColegiat.BackColor = System.Drawing.Color.Beige
        Me.DetNumColegiat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetNumColegiat.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.DetNumColegiat.Location = New System.Drawing.Point(50, 595)
        Me.DetNumColegiat.Name = "DetNumColegiat"
        Me.DetNumColegiat.ReadOnly = True
        Me.DetNumColegiat.Size = New System.Drawing.Size(127, 17)
        Me.DetNumColegiat.TabIndex = 1
        Me.DetNumColegiat.TabStop = False
        '
        'DetInforme
        '
        Me.DetInforme.BackColor = System.Drawing.Color.Beige
        Me.DetInforme.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetInforme.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.DetInforme.Location = New System.Drawing.Point(50, 92)
        Me.DetInforme.Multiline = True
        Me.DetInforme.Name = "DetInforme"
        Me.DetInforme.ReadOnly = True
        Me.DetInforme.Size = New System.Drawing.Size(772, 429)
        Me.DetInforme.TabIndex = 2
        Me.DetInforme.TabStop = False
        '
        'DetData
        '
        Me.DetData.BackColor = System.Drawing.Color.Beige
        Me.DetData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetData.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.DetData.Location = New System.Drawing.Point(50, 539)
        Me.DetData.Name = "DetData"
        Me.DetData.ReadOnly = True
        Me.DetData.Size = New System.Drawing.Size(772, 17)
        Me.DetData.TabIndex = 3
        Me.DetData.TabStop = False
        '
        'DetDiagnostic
        '
        Me.DetDiagnostic.BackColor = System.Drawing.Color.Beige
        Me.DetDiagnostic.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetDiagnostic.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.DetDiagnostic.Location = New System.Drawing.Point(50, 65)
        Me.DetDiagnostic.Name = "DetDiagnostic"
        Me.DetDiagnostic.ReadOnly = True
        Me.DetDiagnostic.Size = New System.Drawing.Size(330, 17)
        Me.DetDiagnostic.TabIndex = 5
        Me.DetDiagnostic.TabStop = False
        '
        'DetTerapeuta
        '
        Me.DetTerapeuta.BackColor = System.Drawing.Color.Beige
        Me.DetTerapeuta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetTerapeuta.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.DetTerapeuta.Location = New System.Drawing.Point(50, 568)
        Me.DetTerapeuta.Name = "DetTerapeuta"
        Me.DetTerapeuta.ReadOnly = True
        Me.DetTerapeuta.Size = New System.Drawing.Size(330, 17)
        Me.DetTerapeuta.TabIndex = 6
        Me.DetTerapeuta.TabStop = False
        '
        'DetPacient
        '
        Me.DetPacient.BackColor = System.Drawing.Color.Beige
        Me.DetPacient.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetPacient.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.DetPacient.Location = New System.Drawing.Point(50, 11)
        Me.DetPacient.Name = "DetPacient"
        Me.DetPacient.ReadOnly = True
        Me.DetPacient.Size = New System.Drawing.Size(679, 17)
        Me.DetPacient.TabIndex = 7
        Me.DetPacient.TabStop = False
        '
        'BtnSortir
        '
        Me.BtnSortir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSortir.Location = New System.Drawing.Point(699, 605)
        Me.BtnSortir.Name = "BtnSortir"
        Me.BtnSortir.Size = New System.Drawing.Size(123, 40)
        Me.BtnSortir.TabIndex = 8
        Me.BtnSortir.Text = "SORTIR"
        Me.BtnSortir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(699, 556)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 40)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "IMPRIMIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DetallInforme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(851, 657)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnSortir)
        Me.Controls.Add(Me.DetPacient)
        Me.Controls.Add(Me.DetTerapeuta)
        Me.Controls.Add(Me.DetDiagnostic)
        Me.Controls.Add(Me.DetData)
        Me.Controls.Add(Me.DetInforme)
        Me.Controls.Add(Me.DetNumColegiat)
        Me.Controls.Add(Me.DetTitolInforme)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Name = "DetallInforme"
        Me.Text = "DETALL INFORME"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DetTitolInforme As System.Windows.Forms.TextBox
    Friend WithEvents DetNumColegiat As System.Windows.Forms.TextBox
    Friend WithEvents DetInforme As System.Windows.Forms.TextBox
    Friend WithEvents DetData As System.Windows.Forms.TextBox
    Friend WithEvents DetDiagnostic As System.Windows.Forms.TextBox
    Friend WithEvents DetTerapeuta As System.Windows.Forms.TextBox
    Friend WithEvents DetPacient As System.Windows.Forms.TextBox
    Friend WithEvents BtnSortir As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
