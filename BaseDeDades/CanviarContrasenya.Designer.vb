<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CanviarContrasenya
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
        Me.Usuari = New System.Windows.Forms.TextBox
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.BtnOK = New System.Windows.Forms.Button
        Me.ContrasenyaVella = New System.Windows.Forms.TextBox
        Me.ContrasenyaNova1 = New System.Windows.Forms.TextBox
        Me.ContrasenyaNova2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Usuari
        '
        Me.Usuari.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Usuari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Usuari.Enabled = False
        Me.Usuari.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuari.Location = New System.Drawing.Point(158, 72)
        Me.Usuari.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Usuari.Name = "Usuari"
        Me.Usuari.Size = New System.Drawing.Size(170, 16)
        Me.Usuari.TabIndex = 0
        Me.Usuari.TabStop = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(207, 225)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(121, 39)
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.Text = "CANCELAR"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.Location = New System.Drawing.Point(79, 225)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(121, 39)
        Me.BtnOK.TabIndex = 3
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'ContrasenyaVella
        '
        Me.ContrasenyaVella.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContrasenyaVella.Location = New System.Drawing.Point(158, 103)
        Me.ContrasenyaVella.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ContrasenyaVella.Name = "ContrasenyaVella"
        Me.ContrasenyaVella.Size = New System.Drawing.Size(170, 23)
        Me.ContrasenyaVella.TabIndex = 0
        '
        'ContrasenyaNova1
        '
        Me.ContrasenyaNova1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContrasenyaNova1.Location = New System.Drawing.Point(158, 134)
        Me.ContrasenyaNova1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ContrasenyaNova1.Name = "ContrasenyaNova1"
        Me.ContrasenyaNova1.Size = New System.Drawing.Size(170, 23)
        Me.ContrasenyaNova1.TabIndex = 1
        '
        'ContrasenyaNova2
        '
        Me.ContrasenyaNova2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContrasenyaNova2.Location = New System.Drawing.Point(158, 165)
        Me.ContrasenyaNova2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ContrasenyaNova2.Name = "ContrasenyaNova2"
        Me.ContrasenyaNova2.Size = New System.Drawing.Size(170, 23)
        Me.ContrasenyaNova2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Contrasenya actual:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nova contrasenya:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Confirmar:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(99, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Usuari:"
        '
        'CanviarContrasenya
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(460, 325)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ContrasenyaNova2)
        Me.Controls.Add(Me.ContrasenyaNova1)
        Me.Controls.Add(Me.ContrasenyaVella)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.Usuari)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CanviarContrasenya"
        Me.Text = "CANVIAR CONTRASENYA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Usuari As System.Windows.Forms.TextBox
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents ContrasenyaVella As System.Windows.Forms.TextBox
    Friend WithEvents ContrasenyaNova1 As System.Windows.Forms.TextBox
    Friend WithEvents ContrasenyaNova2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
