<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarConcepteFactura
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
        Me.NumFactura = New System.Windows.Forms.TextBox
        Me.Pacient = New System.Windows.Forms.TextBox
        Me.Polissa = New System.Windows.Forms.TextBox
        Me.Autoritzacio = New System.Windows.Forms.TextBox
        Me.Concepte = New System.Windows.Forms.TextBox
        Me.Sessions = New System.Windows.Forms.TextBox
        Me.PreuSessio = New System.Windows.Forms.TextBox
        Me.RetIRPF = New System.Windows.Forms.TextBox
        Me.ImpIRPF = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.BtnOk = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'NumFactura
        '
        Me.NumFactura.Location = New System.Drawing.Point(98, 32)
        Me.NumFactura.Name = "NumFactura"
        Me.NumFactura.Size = New System.Drawing.Size(100, 23)
        Me.NumFactura.TabIndex = 0
        Me.NumFactura.TabStop = False
        '
        'Pacient
        '
        Me.Pacient.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Pacient.Location = New System.Drawing.Point(98, 122)
        Me.Pacient.Name = "Pacient"
        Me.Pacient.Size = New System.Drawing.Size(369, 23)
        Me.Pacient.TabIndex = 2
        '
        'Polissa
        '
        Me.Polissa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Polissa.Location = New System.Drawing.Point(98, 151)
        Me.Polissa.Name = "Polissa"
        Me.Polissa.Size = New System.Drawing.Size(369, 23)
        Me.Polissa.TabIndex = 3
        '
        'Autoritzacio
        '
        Me.Autoritzacio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Autoritzacio.Location = New System.Drawing.Point(98, 180)
        Me.Autoritzacio.Name = "Autoritzacio"
        Me.Autoritzacio.Size = New System.Drawing.Size(369, 23)
        Me.Autoritzacio.TabIndex = 4
        '
        'Concepte
        '
        Me.Concepte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Concepte.Location = New System.Drawing.Point(98, 93)
        Me.Concepte.Name = "Concepte"
        Me.Concepte.Size = New System.Drawing.Size(369, 23)
        Me.Concepte.TabIndex = 1
        '
        'Sessions
        '
        Me.Sessions.Location = New System.Drawing.Point(98, 209)
        Me.Sessions.Name = "Sessions"
        Me.Sessions.Size = New System.Drawing.Size(70, 23)
        Me.Sessions.TabIndex = 5
        Me.Sessions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PreuSessio
        '
        Me.PreuSessio.Location = New System.Drawing.Point(98, 238)
        Me.PreuSessio.Name = "PreuSessio"
        Me.PreuSessio.Size = New System.Drawing.Size(70, 23)
        Me.PreuSessio.TabIndex = 6
        Me.PreuSessio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RetIRPF
        '
        Me.RetIRPF.Location = New System.Drawing.Point(98, 267)
        Me.RetIRPF.Name = "RetIRPF"
        Me.RetIRPF.Size = New System.Drawing.Size(70, 23)
        Me.RetIRPF.TabIndex = 7
        Me.RetIRPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ImpIRPF
        '
        Me.ImpIRPF.Location = New System.Drawing.Point(98, 296)
        Me.ImpIRPF.Name = "ImpIRPF"
        Me.ImpIRPF.Size = New System.Drawing.Size(70, 23)
        Me.ImpIRPF.TabIndex = 8
        Me.ImpIRPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(175, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Sessions"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "% IRPF"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(175, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "€/sessió"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(175, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "€ IRPF"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Pol·lissa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Autorització"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Pacient"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(95, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Núm Factura"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Concepte"
        '
        'BtnOk
        '
        Me.BtnOk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.Location = New System.Drawing.Point(535, 93)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(94, 42)
        Me.BtnOk.TabIndex = 19
        Me.BtnOk.Text = "OK"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(535, 141)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(94, 42)
        Me.BtnCancelar.TabIndex = 20
        Me.BtnCancelar.Text = "CANCELAR"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'ModificarConcepteFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(681, 325)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ImpIRPF)
        Me.Controls.Add(Me.RetIRPF)
        Me.Controls.Add(Me.PreuSessio)
        Me.Controls.Add(Me.Sessions)
        Me.Controls.Add(Me.Concepte)
        Me.Controls.Add(Me.Autoritzacio)
        Me.Controls.Add(Me.Polissa)
        Me.Controls.Add(Me.Pacient)
        Me.Controls.Add(Me.NumFactura)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ModificarConcepteFactura"
        Me.Text = "MODIFICAR CONCEPTE FACTURA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NumFactura As System.Windows.Forms.TextBox
    Friend WithEvents Pacient As System.Windows.Forms.TextBox
    Friend WithEvents Polissa As System.Windows.Forms.TextBox
    Friend WithEvents Autoritzacio As System.Windows.Forms.TextBox
    Friend WithEvents Concepte As System.Windows.Forms.TextBox
    Friend WithEvents Sessions As System.Windows.Forms.TextBox
    Friend WithEvents PreuSessio As System.Windows.Forms.TextBox
    Friend WithEvents RetIRPF As System.Windows.Forms.TextBox
    Friend WithEvents ImpIRPF As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
End Class
