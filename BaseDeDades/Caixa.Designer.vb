<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Caixa
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
        Me.DgCaixa = New System.Windows.Forms.DataGridView
        Me.BtnSortir = New System.Windows.Forms.Button
        Me.TotalCaixa = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RbFiltrar = New System.Windows.Forms.RadioButton
        Me.RbTotes = New System.Windows.Forms.RadioButton
        Me.PaOpcions = New System.Windows.Forms.Panel
        Me.BtnFiltar = New System.Windows.Forms.Button
        Me.Descripcio = New System.Windows.Forms.TextBox
        Me.CbDescripcio = New System.Windows.Forms.CheckBox
        Me.Pacient = New System.Windows.Forms.TextBox
        Me.CbPacient = New System.Windows.Forms.CheckBox
        Me.Terapeuta = New System.Windows.Forms.TextBox
        Me.CbTerapeuta = New System.Windows.Forms.CheckBox
        Me.BtnNovaEntrada = New System.Windows.Forms.Button
        CType(Me.DgCaixa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PaOpcions.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgCaixa
        '
        Me.DgCaixa.BackgroundColor = System.Drawing.Color.Beige
        Me.DgCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgCaixa.Location = New System.Drawing.Point(12, 134)
        Me.DgCaixa.Name = "DgCaixa"
        Me.DgCaixa.Size = New System.Drawing.Size(993, 536)
        Me.DgCaixa.TabIndex = 0
        '
        'BtnSortir
        '
        Me.BtnSortir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSortir.Location = New System.Drawing.Point(891, 26)
        Me.BtnSortir.Name = "BtnSortir"
        Me.BtnSortir.Size = New System.Drawing.Size(114, 37)
        Me.BtnSortir.TabIndex = 1
        Me.BtnSortir.Text = "SORTIR"
        Me.BtnSortir.UseVisualStyleBackColor = True
        '
        'TotalCaixa
        '
        Me.TotalCaixa.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TotalCaixa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TotalCaixa.Enabled = False
        Me.TotalCaixa.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCaixa.Location = New System.Drawing.Point(875, 95)
        Me.TotalCaixa.Name = "TotalCaixa"
        Me.TotalCaixa.Size = New System.Drawing.Size(130, 23)
        Me.TotalCaixa.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Location = New System.Drawing.Point(800, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Caixa:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label2.Location = New System.Drawing.Point(187, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "MOVIMENTS DE CAIXA"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RbFiltrar)
        Me.Panel1.Controls.Add(Me.RbTotes)
        Me.Panel1.Location = New System.Drawing.Point(1011, 134)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(228, 37)
        Me.Panel1.TabIndex = 5
        '
        'RbFiltrar
        '
        Me.RbFiltrar.AutoSize = True
        Me.RbFiltrar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbFiltrar.Location = New System.Drawing.Point(71, 10)
        Me.RbFiltrar.Name = "RbFiltrar"
        Me.RbFiltrar.Size = New System.Drawing.Size(58, 20)
        Me.RbFiltrar.TabIndex = 1
        Me.RbFiltrar.TabStop = True
        Me.RbFiltrar.Text = "Filtar"
        Me.RbFiltrar.UseVisualStyleBackColor = True
        '
        'RbTotes
        '
        Me.RbTotes.AutoSize = True
        Me.RbTotes.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbTotes.Location = New System.Drawing.Point(3, 10)
        Me.RbTotes.Name = "RbTotes"
        Me.RbTotes.Size = New System.Drawing.Size(62, 20)
        Me.RbTotes.TabIndex = 0
        Me.RbTotes.TabStop = True
        Me.RbTotes.Text = "Totes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RbTotes.UseVisualStyleBackColor = True
        '
        'PaOpcions
        '
        Me.PaOpcions.Controls.Add(Me.BtnFiltar)
        Me.PaOpcions.Controls.Add(Me.Descripcio)
        Me.PaOpcions.Controls.Add(Me.CbDescripcio)
        Me.PaOpcions.Controls.Add(Me.Pacient)
        Me.PaOpcions.Controls.Add(Me.CbPacient)
        Me.PaOpcions.Controls.Add(Me.Terapeuta)
        Me.PaOpcions.Controls.Add(Me.CbTerapeuta)
        Me.PaOpcions.Location = New System.Drawing.Point(1011, 177)
        Me.PaOpcions.Name = "PaOpcions"
        Me.PaOpcions.Size = New System.Drawing.Size(228, 213)
        Me.PaOpcions.TabIndex = 6
        '
        'BtnFiltar
        '
        Me.BtnFiltar.Location = New System.Drawing.Point(18, 179)
        Me.BtnFiltar.Name = "BtnFiltar"
        Me.BtnFiltar.Size = New System.Drawing.Size(128, 26)
        Me.BtnFiltar.TabIndex = 12
        Me.BtnFiltar.Text = "OK"
        Me.BtnFiltar.UseVisualStyleBackColor = True
        '
        'Descripcio
        '
        Me.Descripcio.Location = New System.Drawing.Point(3, 141)
        Me.Descripcio.Name = "Descripcio"
        Me.Descripcio.Size = New System.Drawing.Size(193, 23)
        Me.Descripcio.TabIndex = 11
        '
        'CbDescripcio
        '
        Me.CbDescripcio.AutoSize = True
        Me.CbDescripcio.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbDescripcio.Location = New System.Drawing.Point(3, 115)
        Me.CbDescripcio.Name = "CbDescripcio"
        Me.CbDescripcio.Size = New System.Drawing.Size(93, 20)
        Me.CbDescripcio.TabIndex = 10
        Me.CbDescripcio.Text = "Descripció"
        Me.CbDescripcio.UseVisualStyleBackColor = True
        '
        'Pacient
        '
        Me.Pacient.Location = New System.Drawing.Point(3, 86)
        Me.Pacient.Name = "Pacient"
        Me.Pacient.Size = New System.Drawing.Size(193, 23)
        Me.Pacient.TabIndex = 9
        '
        'CbPacient
        '
        Me.CbPacient.AutoSize = True
        Me.CbPacient.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbPacient.Location = New System.Drawing.Point(3, 60)
        Me.CbPacient.Name = "CbPacient"
        Me.CbPacient.Size = New System.Drawing.Size(75, 20)
        Me.CbPacient.TabIndex = 8
        Me.CbPacient.Text = "Pacient"
        Me.CbPacient.UseVisualStyleBackColor = True
        '
        'Terapeuta
        '
        Me.Terapeuta.Location = New System.Drawing.Point(3, 31)
        Me.Terapeuta.Name = "Terapeuta"
        Me.Terapeuta.Size = New System.Drawing.Size(193, 23)
        Me.Terapeuta.TabIndex = 7
        '
        'CbTerapeuta
        '
        Me.CbTerapeuta.AutoSize = True
        Me.CbTerapeuta.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTerapeuta.Location = New System.Drawing.Point(3, 5)
        Me.CbTerapeuta.Name = "CbTerapeuta"
        Me.CbTerapeuta.Size = New System.Drawing.Size(94, 20)
        Me.CbTerapeuta.TabIndex = 6
        Me.CbTerapeuta.Text = "Terapeuta"
        Me.CbTerapeuta.UseVisualStyleBackColor = True
        '
        'BtnNovaEntrada
        '
        Me.BtnNovaEntrada.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNovaEntrada.Location = New System.Drawing.Point(1011, 396)
        Me.BtnNovaEntrada.Name = "BtnNovaEntrada"
        Me.BtnNovaEntrada.Size = New System.Drawing.Size(114, 37)
        Me.BtnNovaEntrada.TabIndex = 7
        Me.BtnNovaEntrada.Text = "Nova entrada"
        Me.BtnNovaEntrada.UseVisualStyleBackColor = True
        '
        'Caixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1275, 732)
        Me.Controls.Add(Me.BtnNovaEntrada)
        Me.Controls.Add(Me.PaOpcions)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TotalCaixa)
        Me.Controls.Add(Me.BtnSortir)
        Me.Controls.Add(Me.DgCaixa)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Caixa"
        Me.Text = "CAIXA"
        CType(Me.DgCaixa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PaOpcions.ResumeLayout(False)
        Me.PaOpcions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgCaixa As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSortir As System.Windows.Forms.Button
    Friend WithEvents TotalCaixa As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RbFiltrar As System.Windows.Forms.RadioButton
    Friend WithEvents RbTotes As System.Windows.Forms.RadioButton
    Friend WithEvents PaOpcions As System.Windows.Forms.Panel
    Friend WithEvents CbTerapeuta As System.Windows.Forms.CheckBox
    Friend WithEvents Descripcio As System.Windows.Forms.TextBox
    Friend WithEvents CbDescripcio As System.Windows.Forms.CheckBox
    Friend WithEvents Pacient As System.Windows.Forms.TextBox
    Friend WithEvents CbPacient As System.Windows.Forms.CheckBox
    Friend WithEvents Terapeuta As System.Windows.Forms.TextBox
    Friend WithEvents BtnFiltar As System.Windows.Forms.Button
    Friend WithEvents BtnNovaEntrada As System.Windows.Forms.Button
End Class
