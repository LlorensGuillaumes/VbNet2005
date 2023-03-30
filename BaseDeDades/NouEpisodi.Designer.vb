<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NouEpisodi
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.ModMutua = New System.Windows.Forms.ComboBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DetPreuSessio = New System.Windows.Forms.TextBox
        Me.DetNumTargeta = New System.Windows.Forms.TextBox
        Me.DetNumAutoritzacio = New System.Windows.Forms.TextBox
        Me.DetSesAutoritzades = New System.Windows.Forms.TextBox
        Me.DetDataInici = New System.Windows.Forms.TextBox
        Me.DetDataFi = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Beige
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.ModMutua)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DetPreuSessio)
        Me.Panel1.Controls.Add(Me.DetNumTargeta)
        Me.Panel1.Controls.Add(Me.DetNumAutoritzacio)
        Me.Panel1.Controls.Add(Me.DetSesAutoritzades)
        Me.Panel1.Controls.Add(Me.DetDataInici)
        Me.Panel1.Controls.Add(Me.DetDataFi)
        Me.Panel1.Location = New System.Drawing.Point(12, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(614, 295)
        Me.Panel1.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(456, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 43)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "CANCELAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ModMutua
        '
        Me.ModMutua.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.ModMutua.FormattingEnabled = True
        Me.ModMutua.Location = New System.Drawing.Point(149, 22)
        Me.ModMutua.Name = "ModMutua"
        Me.ModMutua.Size = New System.Drawing.Size(434, 26)
        Me.ModMutua.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(456, 156)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 43)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(59, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 18)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Targeta:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 18)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Autorització:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(50, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 18)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Sessions:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(87, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 18)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Inici:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(117, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Fí:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Preu/Sessió:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Mútua:"
        '
        'DetPreuSessio
        '
        Me.DetPreuSessio.BackColor = System.Drawing.Color.White
        Me.DetPreuSessio.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetPreuSessio.Location = New System.Drawing.Point(149, 247)
        Me.DetPreuSessio.Name = "DetPreuSessio"
        Me.DetPreuSessio.ReadOnly = True
        Me.DetPreuSessio.Size = New System.Drawing.Size(127, 26)
        Me.DetPreuSessio.TabIndex = 7
        '
        'DetNumTargeta
        '
        Me.DetNumTargeta.BackColor = System.Drawing.Color.White
        Me.DetNumTargeta.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetNumTargeta.Location = New System.Drawing.Point(149, 62)
        Me.DetNumTargeta.Name = "DetNumTargeta"
        Me.DetNumTargeta.ReadOnly = True
        Me.DetNumTargeta.Size = New System.Drawing.Size(434, 26)
        Me.DetNumTargeta.TabIndex = 6
        '
        'DetNumAutoritzacio
        '
        Me.DetNumAutoritzacio.BackColor = System.Drawing.Color.White
        Me.DetNumAutoritzacio.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetNumAutoritzacio.Location = New System.Drawing.Point(149, 99)
        Me.DetNumAutoritzacio.Name = "DetNumAutoritzacio"
        Me.DetNumAutoritzacio.ReadOnly = True
        Me.DetNumAutoritzacio.Size = New System.Drawing.Size(434, 26)
        Me.DetNumAutoritzacio.TabIndex = 5
        '
        'DetSesAutoritzades
        '
        Me.DetSesAutoritzades.BackColor = System.Drawing.Color.White
        Me.DetSesAutoritzades.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetSesAutoritzades.Location = New System.Drawing.Point(149, 136)
        Me.DetSesAutoritzades.Name = "DetSesAutoritzades"
        Me.DetSesAutoritzades.ReadOnly = True
        Me.DetSesAutoritzades.Size = New System.Drawing.Size(127, 26)
        Me.DetSesAutoritzades.TabIndex = 4
        '
        'DetDataInici
        '
        Me.DetDataInici.BackColor = System.Drawing.Color.White
        Me.DetDataInici.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetDataInici.Location = New System.Drawing.Point(149, 173)
        Me.DetDataInici.Name = "DetDataInici"
        Me.DetDataInici.ReadOnly = True
        Me.DetDataInici.Size = New System.Drawing.Size(127, 26)
        Me.DetDataInici.TabIndex = 3
        '
        'DetDataFi
        '
        Me.DetDataFi.BackColor = System.Drawing.Color.White
        Me.DetDataFi.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetDataFi.Location = New System.Drawing.Point(149, 210)
        Me.DetDataFi.Name = "DetDataFi"
        Me.DetDataFi.ReadOnly = True
        Me.DetDataFi.Size = New System.Drawing.Size(127, 26)
        Me.DetDataFi.TabIndex = 2
        '
        'NouEpisodi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(639, 471)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "NouEpisodi"
        Me.Text = "NOU EPISODI"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ModMutua As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DetPreuSessio As System.Windows.Forms.TextBox
    Friend WithEvents DetNumTargeta As System.Windows.Forms.TextBox
    Friend WithEvents DetNumAutoritzacio As System.Windows.Forms.TextBox
    Friend WithEvents DetSesAutoritzades As System.Windows.Forms.TextBox
    Friend WithEvents DetDataInici As System.Windows.Forms.TextBox
    Friend WithEvents DetDataFi As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
