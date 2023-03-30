<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NovaEntradaCaixa
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
        Me.Data = New System.Windows.Forms.MaskedTextBox
        Me.CbTerapeuta = New System.Windows.Forms.ComboBox
        Me.Pacient = New System.Windows.Forms.TextBox
        Me.Descripcio = New System.Windows.Forms.TextBox
        Me.CbPrivat = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Import = New System.Windows.Forms.TextBox
        Me.BtnOk = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Data
        '
        Me.Data.Location = New System.Drawing.Point(12, 22)
        Me.Data.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Data.Name = "Data"
        Me.Data.Size = New System.Drawing.Size(98, 23)
        Me.Data.TabIndex = 0
        Me.Data.TabStop = False
        '
        'CbTerapeuta
        '
        Me.CbTerapeuta.FormattingEnabled = True
        Me.CbTerapeuta.Location = New System.Drawing.Point(116, 22)
        Me.CbTerapeuta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CbTerapeuta.Name = "CbTerapeuta"
        Me.CbTerapeuta.Size = New System.Drawing.Size(153, 24)
        Me.CbTerapeuta.TabIndex = 1
        '
        'Pacient
        '
        Me.Pacient.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Pacient.Location = New System.Drawing.Point(12, 68)
        Me.Pacient.Name = "Pacient"
        Me.Pacient.Size = New System.Drawing.Size(319, 23)
        Me.Pacient.TabIndex = 2
        '
        'Descripcio
        '
        Me.Descripcio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Descripcio.Location = New System.Drawing.Point(12, 113)
        Me.Descripcio.Name = "Descripcio"
        Me.Descripcio.Size = New System.Drawing.Size(319, 23)
        Me.Descripcio.TabIndex = 3
        '
        'CbPrivat
        '
        Me.CbPrivat.AutoSize = True
        Me.CbPrivat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbPrivat.Location = New System.Drawing.Point(15, 187)
        Me.CbPrivat.Name = "CbPrivat"
        Me.CbPrivat.Size = New System.Drawing.Size(66, 20)
        Me.CbPrivat.TabIndex = 5
        Me.CbPrivat.Text = "Privat"
        Me.CbPrivat.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Pacient"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Descripció"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Import"
        '
        'Import
        '
        Me.Import.Location = New System.Drawing.Point(15, 158)
        Me.Import.Name = "Import"
        Me.Import.Size = New System.Drawing.Size(97, 23)
        Me.Import.TabIndex = 4
        '
        'BtnOk
        '
        Me.BtnOk.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.Location = New System.Drawing.Point(385, 65)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(103, 35)
        Me.BtnOk.TabIndex = 9
        Me.BtnOk.Text = "OK"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(385, 106)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(103, 35)
        Me.BtnCancelar.TabIndex = 10
        Me.BtnCancelar.Text = "CANCELAR"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'NovaEntradaCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(513, 222)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.Import)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbPrivat)
        Me.Controls.Add(Me.Descripcio)
        Me.Controls.Add(Me.Pacient)
        Me.Controls.Add(Me.CbTerapeuta)
        Me.Controls.Add(Me.Data)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "NovaEntradaCaixa"
        Me.Text = "ENTRADA CAIXA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Data As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CbTerapeuta As System.Windows.Forms.ComboBox
    Friend WithEvents Pacient As System.Windows.Forms.TextBox
    Friend WithEvents Descripcio As System.Windows.Forms.TextBox
    Friend WithEvents CbPrivat As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Import As System.Windows.Forms.TextBox
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
End Class
