<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NouInforme
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
        Me.DetPacient = New System.Windows.Forms.TextBox
        Me.DetDiagnostic = New System.Windows.Forms.TextBox
        Me.DetDataStr = New System.Windows.Forms.TextBox
        Me.DetInforme = New System.Windows.Forms.TextBox
        Me.DetNumColegiat = New System.Windows.Forms.TextBox
        Me.DetTitolInforme = New System.Windows.Forms.TextBox
        Me.DetTerapeuta = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Calendari = New System.Windows.Forms.MonthCalendar
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.DetData = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'DetPacient
        '
        Me.DetPacient.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DetPacient.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetPacient.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetPacient.ForeColor = System.Drawing.Color.Gray
        Me.DetPacient.Location = New System.Drawing.Point(84, 17)
        Me.DetPacient.Margin = New System.Windows.Forms.Padding(4)
        Me.DetPacient.Name = "DetPacient"
        Me.DetPacient.ReadOnly = True
        Me.DetPacient.Size = New System.Drawing.Size(905, 19)
        Me.DetPacient.TabIndex = 14
        Me.DetPacient.TabStop = False
        '
        'DetDiagnostic
        '
        Me.DetDiagnostic.BackColor = System.Drawing.SystemColors.Control
        Me.DetDiagnostic.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DetDiagnostic.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetDiagnostic.Location = New System.Drawing.Point(84, 132)
        Me.DetDiagnostic.Margin = New System.Windows.Forms.Padding(4)
        Me.DetDiagnostic.Name = "DetDiagnostic"
        Me.DetDiagnostic.Size = New System.Drawing.Size(439, 26)
        Me.DetDiagnostic.TabIndex = 2
        '
        'DetDataStr
        '
        Me.DetDataStr.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DetDataStr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetDataStr.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetDataStr.ForeColor = System.Drawing.Color.Gray
        Me.DetDataStr.Location = New System.Drawing.Point(84, 751)
        Me.DetDataStr.Margin = New System.Windows.Forms.Padding(4)
        Me.DetDataStr.Name = "DetDataStr"
        Me.DetDataStr.ReadOnly = True
        Me.DetDataStr.Size = New System.Drawing.Size(246, 16)
        Me.DetDataStr.TabIndex = 11
        Me.DetDataStr.TabStop = False
        '
        'DetInforme
        '
        Me.DetInforme.BackColor = System.Drawing.SystemColors.Control
        Me.DetInforme.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetInforme.Location = New System.Drawing.Point(84, 188)
        Me.DetInforme.Margin = New System.Windows.Forms.Padding(4)
        Me.DetInforme.Multiline = True
        Me.DetInforme.Name = "DetInforme"
        Me.DetInforme.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DetInforme.Size = New System.Drawing.Size(1032, 471)
        Me.DetInforme.TabIndex = 3
        '
        'DetNumColegiat
        '
        Me.DetNumColegiat.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DetNumColegiat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetNumColegiat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetNumColegiat.ForeColor = System.Drawing.Color.Gray
        Me.DetNumColegiat.Location = New System.Drawing.Point(195, 717)
        Me.DetNumColegiat.Margin = New System.Windows.Forms.Padding(4)
        Me.DetNumColegiat.Name = "DetNumColegiat"
        Me.DetNumColegiat.ReadOnly = True
        Me.DetNumColegiat.Size = New System.Drawing.Size(188, 16)
        Me.DetNumColegiat.TabIndex = 9
        Me.DetNumColegiat.TabStop = False
        '
        'DetTitolInforme
        '
        Me.DetTitolInforme.BackColor = System.Drawing.SystemColors.Control
        Me.DetTitolInforme.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DetTitolInforme.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetTitolInforme.Location = New System.Drawing.Point(84, 78)
        Me.DetTitolInforme.Margin = New System.Windows.Forms.Padding(4)
        Me.DetTitolInforme.Name = "DetTitolInforme"
        Me.DetTitolInforme.Size = New System.Drawing.Size(439, 26)
        Me.DetTitolInforme.TabIndex = 1
        '
        'DetTerapeuta
        '
        Me.DetTerapeuta.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetTerapeuta.FormattingEnabled = True
        Me.DetTerapeuta.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.DetTerapeuta.Location = New System.Drawing.Point(84, 683)
        Me.DetTerapeuta.Margin = New System.Windows.Forms.Padding(4)
        Me.DetTerapeuta.Name = "DetTerapeuta"
        Me.DetTerapeuta.Size = New System.Drawing.Size(246, 26)
        Me.DetTerapeuta.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(84, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Descripció"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(82, 112)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Diagnòstic"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(84, 168)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Informe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(83, 663)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Terapeuta"
        '
        'Calendari
        '
        Me.Calendari.Location = New System.Drawing.Point(84, 587)
        Me.Calendari.Name = "Calendari"
        Me.Calendari.TabIndex = 20
        Me.Calendari.TabStop = False
        Me.Calendari.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(313, 751)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 36)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Calendari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(81, 717)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Núm. col·legiat:"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(989, 115)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 43)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DetData
        '
        Me.DetData.Location = New System.Drawing.Point(810, 762)
        Me.DetData.Name = "DetData"
        Me.DetData.Size = New System.Drawing.Size(145, 26)
        Me.DetData.TabIndex = 24
        Me.DetData.TabStop = False
        Me.DetData.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(660, 741)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(491, 18)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Aquest control, serveix per tenir la data seleccionada amb format de Data"
        Me.Label6.Visible = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(989, 66)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 43)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "SORTIR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'NouInforme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1198, 884)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DetData)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Calendari)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DetTerapeuta)
        Me.Controls.Add(Me.DetPacient)
        Me.Controls.Add(Me.DetDiagnostic)
        Me.Controls.Add(Me.DetDataStr)
        Me.Controls.Add(Me.DetInforme)
        Me.Controls.Add(Me.DetNumColegiat)
        Me.Controls.Add(Me.DetTitolInforme)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NouInforme"
        Me.Text = "NOU INFORME"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DetPacient As System.Windows.Forms.TextBox
    Friend WithEvents DetDiagnostic As System.Windows.Forms.TextBox
    Friend WithEvents DetDataStr As System.Windows.Forms.TextBox
    Friend WithEvents DetInforme As System.Windows.Forms.TextBox
    Friend WithEvents DetNumColegiat As System.Windows.Forms.TextBox
    Friend WithEvents DetTitolInforme As System.Windows.Forms.TextBox
    Friend WithEvents DetTerapeuta As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Calendari As System.Windows.Forms.MonthCalendar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DetData As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
