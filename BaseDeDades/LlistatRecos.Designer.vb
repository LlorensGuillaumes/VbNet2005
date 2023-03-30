<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LlistatRecos
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
        Me.CbClub = New System.Windows.Forms.ComboBox
        Me.DgEquips = New System.Windows.Forms.DataGridView
        Me.BtnImprimir = New System.Windows.Forms.Button
        Me.DataInici = New System.Windows.Forms.MaskedTextBox
        Me.DataFi = New System.Windows.Forms.MaskedTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnSortir = New System.Windows.Forms.Button
        Me.RbAptitut = New System.Windows.Forms.RadioButton
        Me.RbLopd = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RbInformes = New System.Windows.Forms.RadioButton
        Me.RbLlista = New System.Windows.Forms.RadioButton
        Me.RbIndividual = New System.Windows.Forms.RadioButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        CType(Me.DgEquips, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CbClub
        '
        Me.CbClub.FormattingEnabled = True
        Me.CbClub.Location = New System.Drawing.Point(27, 30)
        Me.CbClub.Name = "CbClub"
        Me.CbClub.Size = New System.Drawing.Size(313, 24)
        Me.CbClub.TabIndex = 0
        '
        'DgEquips
        '
        Me.DgEquips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgEquips.Location = New System.Drawing.Point(362, 30)
        Me.DgEquips.Name = "DgEquips"
        Me.DgEquips.Size = New System.Drawing.Size(312, 288)
        Me.DgEquips.TabIndex = 1
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimir.Location = New System.Drawing.Point(228, 242)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(112, 34)
        Me.BtnImprimir.TabIndex = 2
        Me.BtnImprimir.Text = "IMPRIMIR"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'DataInici
        '
        Me.DataInici.Location = New System.Drawing.Point(88, 72)
        Me.DataInici.Name = "DataInici"
        Me.DataInici.Size = New System.Drawing.Size(93, 23)
        Me.DataInici.TabIndex = 1
        '
        'DataFi
        '
        Me.DataFi.Location = New System.Drawing.Point(204, 72)
        Me.DataFi.Name = "DataFi"
        Me.DataFi.Size = New System.Drawing.Size(93, 23)
        Me.DataFi.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Entre el"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(187, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "i"
        '
        'BtnSortir
        '
        Me.BtnSortir.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSortir.Location = New System.Drawing.Point(228, 282)
        Me.BtnSortir.Name = "BtnSortir"
        Me.BtnSortir.Size = New System.Drawing.Size(112, 35)
        Me.BtnSortir.TabIndex = 7
        Me.BtnSortir.Text = "SORTIR"
        Me.BtnSortir.UseVisualStyleBackColor = True
        '
        'RbAptitut
        '
        Me.RbAptitut.AutoSize = True
        Me.RbAptitut.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbAptitut.Location = New System.Drawing.Point(20, 10)
        Me.RbAptitut.Name = "RbAptitut"
        Me.RbAptitut.Size = New System.Drawing.Size(77, 22)
        Me.RbAptitut.TabIndex = 8
        Me.RbAptitut.TabStop = True
        Me.RbAptitut.Text = "Aptitut"
        Me.RbAptitut.UseVisualStyleBackColor = True
        '
        'RbLopd
        '
        Me.RbLopd.AutoSize = True
        Me.RbLopd.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbLopd.Location = New System.Drawing.Point(103, 10)
        Me.RbLopd.Name = "RbLopd"
        Me.RbLopd.Size = New System.Drawing.Size(68, 22)
        Me.RbLopd.TabIndex = 9
        Me.RbLopd.TabStop = True
        Me.RbLopd.Text = "LOPD"
        Me.RbLopd.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RbInformes)
        Me.Panel1.Controls.Add(Me.RbLopd)
        Me.Panel1.Controls.Add(Me.RbAptitut)
        Me.Panel1.Location = New System.Drawing.Point(12, 142)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 51)
        Me.Panel1.TabIndex = 10
        '
        'RbInformes
        '
        Me.RbInformes.AutoSize = True
        Me.RbInformes.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbInformes.Location = New System.Drawing.Point(177, 10)
        Me.RbInformes.Name = "RbInformes"
        Me.RbInformes.Size = New System.Drawing.Size(94, 22)
        Me.RbInformes.TabIndex = 10
        Me.RbInformes.TabStop = True
        Me.RbInformes.Text = "Informes"
        Me.RbInformes.UseVisualStyleBackColor = True
        '
        'RbLlista
        '
        Me.RbLlista.AutoSize = True
        Me.RbLlista.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbLlista.Location = New System.Drawing.Point(5, 4)
        Me.RbLlista.Name = "RbLlista"
        Me.RbLlista.Size = New System.Drawing.Size(68, 22)
        Me.RbLlista.TabIndex = 11
        Me.RbLlista.TabStop = True
        Me.RbLlista.Text = "Llista"
        Me.RbLlista.UseVisualStyleBackColor = True
        '
        'RbIndividual
        '
        Me.RbIndividual.AutoSize = True
        Me.RbIndividual.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbIndividual.Location = New System.Drawing.Point(5, 32)
        Me.RbIndividual.Name = "RbIndividual"
        Me.RbIndividual.Size = New System.Drawing.Size(102, 22)
        Me.RbIndividual.TabIndex = 12
        Me.RbIndividual.TabStop = True
        Me.RbIndividual.Text = "Individual"
        Me.RbIndividual.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RbLlista)
        Me.Panel2.Controls.Add(Me.RbIndividual)
        Me.Panel2.Location = New System.Drawing.Point(27, 176)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(110, 66)
        Me.Panel2.TabIndex = 13
        '
        'PrintDocument1
        '
        '
        'LlistatRecos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(853, 459)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnSortir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataFi)
        Me.Controls.Add(Me.DataInici)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.DgEquips)
        Me.Controls.Add(Me.CbClub)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "LlistatRecos"
        Me.Text = "LLISTATS DE RECONEXEMENTS"
        CType(Me.DgEquips, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbClub As System.Windows.Forms.ComboBox
    Friend WithEvents DgEquips As System.Windows.Forms.DataGridView
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents DataInici As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DataFi As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnSortir As System.Windows.Forms.Button
    Friend WithEvents RbAptitut As System.Windows.Forms.RadioButton
    Friend WithEvents RbLopd As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RbInformes As System.Windows.Forms.RadioButton
    Friend WithEvents RbLlista As System.Windows.Forms.RadioButton
    Friend WithEvents RbIndividual As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
