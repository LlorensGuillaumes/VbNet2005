<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factures
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DgFactures = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BuscarTotes = New System.Windows.Forms.RadioButton
        Me.BuscarNoCobrades = New System.Windows.Forms.RadioButton
        Me.BtnFiltrar = New System.Windows.Forms.Button
        Me.LlistatBuscar = New System.Windows.Forms.ComboBox
        Me.EtEntreB = New System.Windows.Forms.Label
        Me.EtEntreA = New System.Windows.Forms.Label
        Me.EntreB = New System.Windows.Forms.TextBox
        Me.EntreA = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BuscarDetall = New System.Windows.Forms.RadioButton
        Me.BuscarClient = New System.Windows.Forms.RadioButton
        Me.BuscarDataEmisio = New System.Windows.Forms.RadioButton
        Me.BuscarNumFactura = New System.Windows.Forms.RadioButton
        Me.BtnSortir = New System.Windows.Forms.Button
        Me.BtnLlitatFactures = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.RbDetall = New System.Windows.Forms.RadioButton
        Me.RbLlistat = New System.Windows.Forms.RadioButton
        CType(Me.DgFactures, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgFactures
        '
        Me.DgFactures.BackgroundColor = System.Drawing.Color.Beige
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgFactures.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgFactures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgFactures.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgFactures.Location = New System.Drawing.Point(146, 265)
        Me.DgFactures.Name = "DgFactures"
        Me.DgFactures.Size = New System.Drawing.Size(919, 506)
        Me.DgFactures.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BuscarTotes)
        Me.Panel1.Controls.Add(Me.BuscarNoCobrades)
        Me.Panel1.Controls.Add(Me.BtnFiltrar)
        Me.Panel1.Controls.Add(Me.LlistatBuscar)
        Me.Panel1.Controls.Add(Me.EtEntreB)
        Me.Panel1.Controls.Add(Me.EtEntreA)
        Me.Panel1.Controls.Add(Me.EntreB)
        Me.Panel1.Controls.Add(Me.EntreA)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BuscarDetall)
        Me.Panel1.Controls.Add(Me.BuscarClient)
        Me.Panel1.Controls.Add(Me.BuscarDataEmisio)
        Me.Panel1.Controls.Add(Me.BuscarNumFactura)
        Me.Panel1.Location = New System.Drawing.Point(352, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(499, 247)
        Me.Panel1.TabIndex = 1
        '
        'BuscarTotes
        '
        Me.BuscarTotes.AutoSize = True
        Me.BuscarTotes.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarTotes.Location = New System.Drawing.Point(14, 213)
        Me.BuscarTotes.Name = "BuscarTotes"
        Me.BuscarTotes.Size = New System.Drawing.Size(62, 20)
        Me.BuscarTotes.TabIndex = 12
        Me.BuscarTotes.TabStop = True
        Me.BuscarTotes.Text = "Totes"
        Me.BuscarTotes.UseVisualStyleBackColor = True
        '
        'BuscarNoCobrades
        '
        Me.BuscarNoCobrades.AutoSize = True
        Me.BuscarNoCobrades.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarNoCobrades.Location = New System.Drawing.Point(14, 187)
        Me.BuscarNoCobrades.Name = "BuscarNoCobrades"
        Me.BuscarNoCobrades.Size = New System.Drawing.Size(107, 20)
        Me.BuscarNoCobrades.TabIndex = 11
        Me.BuscarNoCobrades.TabStop = True
        Me.BuscarNoCobrades.Text = "No Cobrades"
        Me.BuscarNoCobrades.UseVisualStyleBackColor = True
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFiltrar.Location = New System.Drawing.Point(391, 81)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(80, 28)
        Me.BtnFiltrar.TabIndex = 10
        Me.BtnFiltrar.Text = "FILTRAR"
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'LlistatBuscar
        '
        Me.LlistatBuscar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LlistatBuscar.FormattingEnabled = True
        Me.LlistatBuscar.Location = New System.Drawing.Point(146, 136)
        Me.LlistatBuscar.Name = "LlistatBuscar"
        Me.LlistatBuscar.Size = New System.Drawing.Size(325, 24)
        Me.LlistatBuscar.TabIndex = 9
        '
        'EtEntreB
        '
        Me.EtEntreB.AutoSize = True
        Me.EtEntreB.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtEntreB.Location = New System.Drawing.Point(284, 56)
        Me.EtEntreB.Name = "EtEntreB"
        Me.EtEntreB.Size = New System.Drawing.Size(22, 18)
        Me.EtEntreB.TabIndex = 8
        Me.EtEntreB.Text = "Fí"
        '
        'EtEntreA
        '
        Me.EtEntreA.AutoSize = True
        Me.EtEntreA.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtEntreA.Location = New System.Drawing.Point(172, 56)
        Me.EtEntreA.Name = "EtEntreA"
        Me.EtEntreA.Size = New System.Drawing.Size(42, 18)
        Me.EtEntreA.TabIndex = 7
        Me.EtEntreA.Text = "Inici"
        '
        'EntreB
        '
        Me.EntreB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntreB.Location = New System.Drawing.Point(249, 84)
        Me.EntreB.Name = "EntreB"
        Me.EntreB.Size = New System.Drawing.Size(97, 23)
        Me.EntreB.TabIndex = 6
        '
        'EntreA
        '
        Me.EntreA.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntreA.Location = New System.Drawing.Point(146, 84)
        Me.EntreA.Name = "EntreA"
        Me.EntreA.Size = New System.Drawing.Size(97, 23)
        Me.EntreA.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "FILTRAR FACTURES"
        '
        'BuscarDetall
        '
        Me.BuscarDetall.AutoSize = True
        Me.BuscarDetall.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarDetall.Location = New System.Drawing.Point(14, 161)
        Me.BuscarDetall.Name = "BuscarDetall"
        Me.BuscarDetall.Size = New System.Drawing.Size(63, 20)
        Me.BuscarDetall.TabIndex = 3
        Me.BuscarDetall.TabStop = True
        Me.BuscarDetall.Text = "Detall"
        Me.BuscarDetall.UseVisualStyleBackColor = True
        '
        'BuscarClient
        '
        Me.BuscarClient.AutoSize = True
        Me.BuscarClient.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarClient.Location = New System.Drawing.Point(14, 135)
        Me.BuscarClient.Name = "BuscarClient"
        Me.BuscarClient.Size = New System.Drawing.Size(62, 20)
        Me.BuscarClient.TabIndex = 2
        Me.BuscarClient.TabStop = True
        Me.BuscarClient.Text = "Client"
        Me.BuscarClient.UseVisualStyleBackColor = True
        '
        'BuscarDataEmisio
        '
        Me.BuscarDataEmisio.AutoSize = True
        Me.BuscarDataEmisio.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarDataEmisio.Location = New System.Drawing.Point(14, 109)
        Me.BuscarDataEmisio.Name = "BuscarDataEmisio"
        Me.BuscarDataEmisio.Size = New System.Drawing.Size(100, 20)
        Me.BuscarDataEmisio.TabIndex = 1
        Me.BuscarDataEmisio.TabStop = True
        Me.BuscarDataEmisio.Text = "Data Emisió"
        Me.BuscarDataEmisio.UseVisualStyleBackColor = True
        '
        'BuscarNumFactura
        '
        Me.BuscarNumFactura.AutoSize = True
        Me.BuscarNumFactura.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarNumFactura.Location = New System.Drawing.Point(14, 83)
        Me.BuscarNumFactura.Name = "BuscarNumFactura"
        Me.BuscarNumFactura.Size = New System.Drawing.Size(110, 20)
        Me.BuscarNumFactura.TabIndex = 0
        Me.BuscarNumFactura.TabStop = True
        Me.BuscarNumFactura.Text = "Núm. Factura"
        Me.BuscarNumFactura.UseVisualStyleBackColor = True
        '
        'BtnSortir
        '
        Me.BtnSortir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSortir.Location = New System.Drawing.Point(960, 203)
        Me.BtnSortir.Name = "BtnSortir"
        Me.BtnSortir.Size = New System.Drawing.Size(105, 42)
        Me.BtnSortir.TabIndex = 2
        Me.BtnSortir.Text = "SORTIR"
        Me.BtnSortir.UseVisualStyleBackColor = True
        '
        'BtnLlitatFactures
        '
        Me.BtnLlitatFactures.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLlitatFactures.Location = New System.Drawing.Point(103, 10)
        Me.BtnLlitatFactures.Name = "BtnLlitatFactures"
        Me.BtnLlitatFactures.Size = New System.Drawing.Size(123, 56)
        Me.BtnLlitatFactures.TabIndex = 3
        Me.BtnLlitatFactures.Text = "IMPRIMIR FACTURES"
        Me.BtnLlitatFactures.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RbDetall)
        Me.Panel2.Controls.Add(Me.BtnLlitatFactures)
        Me.Panel2.Controls.Add(Me.RbLlistat)
        Me.Panel2.Location = New System.Drawing.Point(889, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(244, 74)
        Me.Panel2.TabIndex = 4
        '
        'RbDetall
        '
        Me.RbDetall.AutoSize = True
        Me.RbDetall.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbDetall.Location = New System.Drawing.Point(37, 42)
        Me.RbDetall.Name = "RbDetall"
        Me.RbDetall.Size = New System.Drawing.Size(60, 18)
        Me.RbDetall.TabIndex = 1
        Me.RbDetall.TabStop = True
        Me.RbDetall.Text = "Detall"
        Me.RbDetall.UseVisualStyleBackColor = True
        '
        'RbLlistat
        '
        Me.RbLlistat.AutoSize = True
        Me.RbLlistat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbLlistat.Location = New System.Drawing.Point(37, 19)
        Me.RbLlistat.Name = "RbLlistat"
        Me.RbLlistat.Size = New System.Drawing.Size(63, 18)
        Me.RbLlistat.TabIndex = 0
        Me.RbLlistat.TabStop = True
        Me.RbLlistat.Text = "Llistat"
        Me.RbLlistat.UseVisualStyleBackColor = True
        '
        'Factures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1215, 752)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtnSortir)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DgFactures)
        Me.Name = "Factures"
        Me.Text = "LLISTAT DE FACTURES"
        CType(Me.DgFactures, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgFactures As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BuscarDetall As System.Windows.Forms.RadioButton
    Friend WithEvents BuscarClient As System.Windows.Forms.RadioButton
    Friend WithEvents BuscarDataEmisio As System.Windows.Forms.RadioButton
    Friend WithEvents BuscarNumFactura As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EntreB As System.Windows.Forms.TextBox
    Friend WithEvents EntreA As System.Windows.Forms.TextBox
    Friend WithEvents EtEntreB As System.Windows.Forms.Label
    Friend WithEvents EtEntreA As System.Windows.Forms.Label
    Friend WithEvents LlistatBuscar As System.Windows.Forms.ComboBox
    Friend WithEvents BtnFiltrar As System.Windows.Forms.Button
    Friend WithEvents BuscarNoCobrades As System.Windows.Forms.RadioButton
    Friend WithEvents BuscarTotes As System.Windows.Forms.RadioButton
    Friend WithEvents BtnSortir As System.Windows.Forms.Button
    Friend WithEvents BtnLlitatFactures As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RbDetall As System.Windows.Forms.RadioButton
    Friend WithEvents RbLlistat As System.Windows.Forms.RadioButton
End Class
