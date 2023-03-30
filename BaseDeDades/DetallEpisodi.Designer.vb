<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetallEpisodi
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
        Me.Pacient = New System.Windows.Forms.TextBox
        Me.DetMutua = New System.Windows.Forms.TextBox
        Me.DetDataFi = New System.Windows.Forms.TextBox
        Me.DetDataInici = New System.Windows.Forms.TextBox
        Me.DetSesAutoritzades = New System.Windows.Forms.TextBox
        Me.DetNumAutoritzacio = New System.Windows.Forms.TextBox
        Me.DetNumTargeta = New System.Windows.Forms.TextBox
        Me.DetPreuSessio = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ModMutua = New System.Windows.Forms.ComboBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.DgAssistencia = New System.Windows.Forms.DataGridView
        Me.Button3 = New System.Windows.Forms.Button
        Me.Avui = New System.Windows.Forms.RadioButton
        Me.PosarData = New System.Windows.Forms.RadioButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.BtnBorrar = New System.Windows.Forms.Button
        Me.BtnAltaEpisodi = New System.Windows.Forms.Button
        Me.SesPorta = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnSeguirTractament = New System.Windows.Forms.Button
        Me.BtnFacturar = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.DgAssistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pacient
        '
        Me.Pacient.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Pacient.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Pacient.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pacient.ForeColor = System.Drawing.Color.Gray
        Me.Pacient.Location = New System.Drawing.Point(35, 46)
        Me.Pacient.Name = "Pacient"
        Me.Pacient.Size = New System.Drawing.Size(560, 20)
        Me.Pacient.TabIndex = 0
        Me.Pacient.TabStop = False
        '
        'DetMutua
        '
        Me.DetMutua.BackColor = System.Drawing.Color.Beige
        Me.DetMutua.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetMutua.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetMutua.Location = New System.Drawing.Point(149, 25)
        Me.DetMutua.Name = "DetMutua"
        Me.DetMutua.ReadOnly = True
        Me.DetMutua.Size = New System.Drawing.Size(436, 19)
        Me.DetMutua.TabIndex = 1
        Me.DetMutua.TabStop = False
        '
        'DetDataFi
        '
        Me.DetDataFi.BackColor = System.Drawing.Color.Beige
        Me.DetDataFi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetDataFi.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetDataFi.Location = New System.Drawing.Point(149, 210)
        Me.DetDataFi.Name = "DetDataFi"
        Me.DetDataFi.ReadOnly = True
        Me.DetDataFi.Size = New System.Drawing.Size(127, 19)
        Me.DetDataFi.TabIndex = 2
        Me.DetDataFi.TabStop = False
        '
        'DetDataInici
        '
        Me.DetDataInici.BackColor = System.Drawing.Color.Beige
        Me.DetDataInici.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetDataInici.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetDataInici.Location = New System.Drawing.Point(149, 173)
        Me.DetDataInici.Name = "DetDataInici"
        Me.DetDataInici.ReadOnly = True
        Me.DetDataInici.Size = New System.Drawing.Size(127, 19)
        Me.DetDataInici.TabIndex = 3
        Me.DetDataInici.TabStop = False
        '
        'DetSesAutoritzades
        '
        Me.DetSesAutoritzades.BackColor = System.Drawing.Color.Beige
        Me.DetSesAutoritzades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetSesAutoritzades.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetSesAutoritzades.Location = New System.Drawing.Point(149, 136)
        Me.DetSesAutoritzades.Name = "DetSesAutoritzades"
        Me.DetSesAutoritzades.ReadOnly = True
        Me.DetSesAutoritzades.Size = New System.Drawing.Size(127, 19)
        Me.DetSesAutoritzades.TabIndex = 4
        Me.DetSesAutoritzades.TabStop = False
        '
        'DetNumAutoritzacio
        '
        Me.DetNumAutoritzacio.BackColor = System.Drawing.Color.Beige
        Me.DetNumAutoritzacio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetNumAutoritzacio.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetNumAutoritzacio.Location = New System.Drawing.Point(149, 99)
        Me.DetNumAutoritzacio.Name = "DetNumAutoritzacio"
        Me.DetNumAutoritzacio.ReadOnly = True
        Me.DetNumAutoritzacio.Size = New System.Drawing.Size(436, 19)
        Me.DetNumAutoritzacio.TabIndex = 5
        Me.DetNumAutoritzacio.TabStop = False
        '
        'DetNumTargeta
        '
        Me.DetNumTargeta.BackColor = System.Drawing.Color.Beige
        Me.DetNumTargeta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetNumTargeta.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetNumTargeta.Location = New System.Drawing.Point(149, 62)
        Me.DetNumTargeta.Name = "DetNumTargeta"
        Me.DetNumTargeta.ReadOnly = True
        Me.DetNumTargeta.Size = New System.Drawing.Size(436, 19)
        Me.DetNumTargeta.TabIndex = 6
        Me.DetNumTargeta.TabStop = False
        '
        'DetPreuSessio
        '
        Me.DetPreuSessio.BackColor = System.Drawing.Color.Beige
        Me.DetPreuSessio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetPreuSessio.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetPreuSessio.Location = New System.Drawing.Point(149, 247)
        Me.DetPreuSessio.Name = "DetPreuSessio"
        Me.DetPreuSessio.ReadOnly = True
        Me.DetPreuSessio.Size = New System.Drawing.Size(127, 19)
        Me.DetPreuSessio.TabIndex = 7
        Me.DetPreuSessio.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Mútua:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Preu/Sessió:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(116, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Fí:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(96, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 18)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Inici:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(64, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 18)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Sessions:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(39, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 18)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Autorització:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(72, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 18)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Targeta:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Beige
        Me.Panel1.Controls.Add(Me.ModMutua)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
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
        Me.Panel1.Controls.Add(Me.DetMutua)
        Me.Panel1.Location = New System.Drawing.Point(35, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(614, 295)
        Me.Panel1.TabIndex = 18
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
        Me.Button2.Location = New System.Drawing.Point(458, 175)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 43)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(458, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 44)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Modificar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DgAssistencia
        '
        Me.DgAssistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgAssistencia.Location = New System.Drawing.Point(694, 114)
        Me.DgAssistencia.Name = "DgAssistencia"
        Me.DgAssistencia.Size = New System.Drawing.Size(226, 407)
        Me.DgAssistencia.TabIndex = 19
        Me.DgAssistencia.TabStop = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(694, 530)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 39)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Introduir Assistència"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Avui
        '
        Me.Avui.AutoSize = True
        Me.Avui.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Avui.Location = New System.Drawing.Point(3, 7)
        Me.Avui.Name = "Avui"
        Me.Avui.Size = New System.Drawing.Size(53, 17)
        Me.Avui.TabIndex = 21
        Me.Avui.TabStop = True
        Me.Avui.Text = "AVUI"
        Me.Avui.UseVisualStyleBackColor = True
        '
        'PosarData
        '
        Me.PosarData.AutoSize = True
        Me.PosarData.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PosarData.Location = New System.Drawing.Point(3, 30)
        Me.PosarData.Name = "PosarData"
        Me.PosarData.Size = New System.Drawing.Size(56, 17)
        Me.PosarData.TabIndex = 22
        Me.PosarData.TabStop = True
        Me.PosarData.Text = "DATA"
        Me.PosarData.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PosarData)
        Me.Panel2.Controls.Add(Me.Avui)
        Me.Panel2.Location = New System.Drawing.Point(784, 530)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(100, 50)
        Me.Panel2.TabIndex = 23
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBorrar.Location = New System.Drawing.Point(836, 67)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(84, 41)
        Me.BtnBorrar.TabIndex = 24
        Me.BtnBorrar.Text = "Borrar assistència"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnAltaEpisodi
        '
        Me.BtnAltaEpisodi.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnAltaEpisodi.Location = New System.Drawing.Point(184, 429)
        Me.BtnAltaEpisodi.Name = "BtnAltaEpisodi"
        Me.BtnAltaEpisodi.Size = New System.Drawing.Size(55, 37)
        Me.BtnAltaEpisodi.TabIndex = 25
        Me.BtnAltaEpisodi.Text = "Alta"
        Me.BtnAltaEpisodi.UseVisualStyleBackColor = True
        '
        'SesPorta
        '
        Me.SesPorta.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SesPorta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SesPorta.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SesPorta.Location = New System.Drawing.Point(858, 594)
        Me.SesPorta.Name = "SesPorta"
        Me.SesPorta.ReadOnly = True
        Me.SesPorta.Size = New System.Drawing.Size(62, 19)
        Me.SesPorta.TabIndex = 26
        Me.SesPorta.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(680, 594)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 18)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Recompte de sessions"
        '
        'BtnSeguirTractament
        '
        Me.BtnSeguirTractament.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSeguirTractament.Location = New System.Drawing.Point(184, 429)
        Me.BtnSeguirTractament.Name = "BtnSeguirTractament"
        Me.BtnSeguirTractament.Size = New System.Drawing.Size(85, 37)
        Me.BtnSeguirTractament.TabIndex = 28
        Me.BtnSeguirTractament.Text = "Seguir tractament"
        Me.BtnSeguirTractament.UseVisualStyleBackColor = True
        '
        'BtnFacturar
        '
        Me.BtnFacturar.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnFacturar.Location = New System.Drawing.Point(493, 429)
        Me.BtnFacturar.Name = "BtnFacturar"
        Me.BtnFacturar.Size = New System.Drawing.Size(127, 44)
        Me.BtnFacturar.TabIndex = 21
        Me.BtnFacturar.Text = "Facturar"
        Me.BtnFacturar.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.Location = New System.Drawing.Point(493, 479)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 44)
        Me.Button4.TabIndex = 29
        Me.Button4.Text = "SORTIR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DetallEpisodi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(955, 750)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.BtnFacturar)
        Me.Controls.Add(Me.BtnSeguirTractament)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SesPorta)
        Me.Controls.Add(Me.BtnAltaEpisodi)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DgAssistencia)
        Me.Controls.Add(Me.Pacient)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "DetallEpisodi"
        Me.Text = "DETALL EPISODI"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgAssistencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pacient As System.Windows.Forms.TextBox
    Friend WithEvents DetMutua As System.Windows.Forms.TextBox
    Friend WithEvents DetDataFi As System.Windows.Forms.TextBox
    Friend WithEvents DetDataInici As System.Windows.Forms.TextBox
    Friend WithEvents DetSesAutoritzades As System.Windows.Forms.TextBox
    Friend WithEvents DetNumAutoritzacio As System.Windows.Forms.TextBox
    Friend WithEvents DetNumTargeta As System.Windows.Forms.TextBox
    Friend WithEvents DetPreuSessio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ModMutua As System.Windows.Forms.ComboBox
    Friend WithEvents DgAssistencia As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Avui As System.Windows.Forms.RadioButton
    Friend WithEvents PosarData As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents BtnAltaEpisodi As System.Windows.Forms.Button
    Friend WithEvents SesPorta As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnSeguirTractament As System.Windows.Forms.Button
    Friend WithEvents BtnFacturar As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
