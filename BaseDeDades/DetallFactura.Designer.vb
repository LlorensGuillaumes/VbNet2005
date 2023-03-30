<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetallFactura
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DetNumFactura = New System.Windows.Forms.TextBox
        Me.DetDataEmisio = New System.Windows.Forms.TextBox
        Me.DetClient = New System.Windows.Forms.TextBox
        Me.DetCif = New System.Windows.Forms.TextBox
        Me.DetAdreça = New System.Windows.Forms.TextBox
        Me.DetCP = New System.Windows.Forms.TextBox
        Me.DetPoblacio = New System.Windows.Forms.TextBox
        Me.DetProvincia = New System.Windows.Forms.TextBox
        Me.DgConceptes = New System.Windows.Forms.DataGridView
        Me.DetTotal = New System.Windows.Forms.TextBox
        Me.DetRetencio = New System.Windows.Forms.TextBox
        Me.DetRetencioImport = New System.Windows.Forms.TextBox
        Me.DetImport = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnSortir = New System.Windows.Forms.Button
        Me.BtnImprimir = New System.Windows.Forms.Button
        Me.BtnModificar = New System.Windows.Forms.Button
        CType(Me.DgConceptes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DetNumFactura
        '
        Me.DetNumFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DetNumFactura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetNumFactura.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetNumFactura.ForeColor = System.Drawing.Color.Gray
        Me.DetNumFactura.Location = New System.Drawing.Point(12, 15)
        Me.DetNumFactura.Name = "DetNumFactura"
        Me.DetNumFactura.ReadOnly = True
        Me.DetNumFactura.Size = New System.Drawing.Size(91, 16)
        Me.DetNumFactura.TabIndex = 0
        Me.DetNumFactura.TabStop = False
        '
        'DetDataEmisio
        '
        Me.DetDataEmisio.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DetDataEmisio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetDataEmisio.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetDataEmisio.ForeColor = System.Drawing.Color.Gray
        Me.DetDataEmisio.Location = New System.Drawing.Point(12, 44)
        Me.DetDataEmisio.Name = "DetDataEmisio"
        Me.DetDataEmisio.ReadOnly = True
        Me.DetDataEmisio.Size = New System.Drawing.Size(91, 16)
        Me.DetDataEmisio.TabIndex = 1
        Me.DetDataEmisio.TabStop = False
        '
        'DetClient
        '
        Me.DetClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DetClient.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetClient.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetClient.ForeColor = System.Drawing.Color.Gray
        Me.DetClient.Location = New System.Drawing.Point(109, 15)
        Me.DetClient.Name = "DetClient"
        Me.DetClient.ReadOnly = True
        Me.DetClient.Size = New System.Drawing.Size(419, 16)
        Me.DetClient.TabIndex = 2
        Me.DetClient.TabStop = False
        '
        'DetCif
        '
        Me.DetCif.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DetCif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetCif.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetCif.ForeColor = System.Drawing.Color.Gray
        Me.DetCif.Location = New System.Drawing.Point(534, 15)
        Me.DetCif.Name = "DetCif"
        Me.DetCif.ReadOnly = True
        Me.DetCif.Size = New System.Drawing.Size(179, 16)
        Me.DetCif.TabIndex = 3
        Me.DetCif.TabStop = False
        '
        'DetAdreça
        '
        Me.DetAdreça.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DetAdreça.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetAdreça.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetAdreça.ForeColor = System.Drawing.Color.Gray
        Me.DetAdreça.Location = New System.Drawing.Point(109, 44)
        Me.DetAdreça.Name = "DetAdreça"
        Me.DetAdreça.ReadOnly = True
        Me.DetAdreça.Size = New System.Drawing.Size(419, 16)
        Me.DetAdreça.TabIndex = 4
        Me.DetAdreça.TabStop = False
        '
        'DetCP
        '
        Me.DetCP.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DetCP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetCP.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetCP.ForeColor = System.Drawing.Color.Gray
        Me.DetCP.Location = New System.Drawing.Point(109, 73)
        Me.DetCP.Name = "DetCP"
        Me.DetCP.ReadOnly = True
        Me.DetCP.Size = New System.Drawing.Size(63, 16)
        Me.DetCP.TabIndex = 5
        Me.DetCP.TabStop = False
        '
        'DetPoblacio
        '
        Me.DetPoblacio.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DetPoblacio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetPoblacio.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetPoblacio.ForeColor = System.Drawing.Color.Gray
        Me.DetPoblacio.Location = New System.Drawing.Point(178, 73)
        Me.DetPoblacio.Name = "DetPoblacio"
        Me.DetPoblacio.ReadOnly = True
        Me.DetPoblacio.Size = New System.Drawing.Size(350, 16)
        Me.DetPoblacio.TabIndex = 6
        Me.DetPoblacio.TabStop = False
        '
        'DetProvincia
        '
        Me.DetProvincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DetProvincia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetProvincia.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetProvincia.ForeColor = System.Drawing.Color.Gray
        Me.DetProvincia.Location = New System.Drawing.Point(109, 102)
        Me.DetProvincia.Name = "DetProvincia"
        Me.DetProvincia.ReadOnly = True
        Me.DetProvincia.Size = New System.Drawing.Size(419, 16)
        Me.DetProvincia.TabIndex = 7
        Me.DetProvincia.TabStop = False
        '
        'DgConceptes
        '
        Me.DgConceptes.AllowDrop = True
        Me.DgConceptes.BackgroundColor = System.Drawing.Color.Beige
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgConceptes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgConceptes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgConceptes.DefaultCellStyle = DataGridViewCellStyle6
        Me.DgConceptes.Location = New System.Drawing.Point(12, 151)
        Me.DgConceptes.Name = "DgConceptes"
        Me.DgConceptes.Size = New System.Drawing.Size(894, 195)
        Me.DgConceptes.TabIndex = 8
        '
        'DetTotal
        '
        Me.DetTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DetTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetTotal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetTotal.Location = New System.Drawing.Point(813, 473)
        Me.DetTotal.Name = "DetTotal"
        Me.DetTotal.ReadOnly = True
        Me.DetTotal.Size = New System.Drawing.Size(93, 15)
        Me.DetTotal.TabIndex = 9
        Me.DetTotal.TabStop = False
        '
        'DetRetencio
        '
        Me.DetRetencio.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DetRetencio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetRetencio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetRetencio.Location = New System.Drawing.Point(813, 417)
        Me.DetRetencio.Name = "DetRetencio"
        Me.DetRetencio.ReadOnly = True
        Me.DetRetencio.Size = New System.Drawing.Size(93, 15)
        Me.DetRetencio.TabIndex = 10
        Me.DetRetencio.TabStop = False
        '
        'DetRetencioImport
        '
        Me.DetRetencioImport.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DetRetencioImport.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetRetencioImport.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetRetencioImport.Location = New System.Drawing.Point(813, 445)
        Me.DetRetencioImport.Name = "DetRetencioImport"
        Me.DetRetencioImport.ReadOnly = True
        Me.DetRetencioImport.Size = New System.Drawing.Size(93, 15)
        Me.DetRetencioImport.TabIndex = 11
        Me.DetRetencioImport.TabStop = False
        '
        'DetImport
        '
        Me.DetImport.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DetImport.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetImport.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetImport.Location = New System.Drawing.Point(813, 389)
        Me.DetImport.Name = "DetImport"
        Me.DetImport.ReadOnly = True
        Me.DetImport.Size = New System.Drawing.Size(93, 15)
        Me.DetImport.TabIndex = 12
        Me.DetImport.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(765, 389)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 14)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(750, 417)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 14)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "% IRPF:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(756, 445)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 14)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "€ IRPF:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(715, 473)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 14)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Total a pagar:"
        '
        'BtnSortir
        '
        Me.BtnSortir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSortir.Location = New System.Drawing.Point(616, 94)
        Me.BtnSortir.Name = "BtnSortir"
        Me.BtnSortir.Size = New System.Drawing.Size(97, 45)
        Me.BtnSortir.TabIndex = 17
        Me.BtnSortir.Text = "SORTIR"
        Me.BtnSortir.UseVisualStyleBackColor = True
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimir.Location = New System.Drawing.Point(709, 513)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(98, 33)
        Me.BtnImprimir.TabIndex = 18
        Me.BtnImprimir.Text = "IMPRIMIR"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Location = New System.Drawing.Point(616, 43)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(97, 45)
        Me.BtnModificar.TabIndex = 19
        Me.BtnModificar.Text = "MODIFICAR"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'DetallFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(919, 646)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.BtnSortir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DetImport)
        Me.Controls.Add(Me.DetRetencioImport)
        Me.Controls.Add(Me.DetRetencio)
        Me.Controls.Add(Me.DetTotal)
        Me.Controls.Add(Me.DgConceptes)
        Me.Controls.Add(Me.DetProvincia)
        Me.Controls.Add(Me.DetPoblacio)
        Me.Controls.Add(Me.DetCP)
        Me.Controls.Add(Me.DetAdreça)
        Me.Controls.Add(Me.DetCif)
        Me.Controls.Add(Me.DetClient)
        Me.Controls.Add(Me.DetDataEmisio)
        Me.Controls.Add(Me.DetNumFactura)
        Me.Name = "DetallFactura"
        Me.Text = "DETALL FACTURA"
        CType(Me.DgConceptes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DetNumFactura As System.Windows.Forms.TextBox
    Friend WithEvents DetDataEmisio As System.Windows.Forms.TextBox
    Friend WithEvents DetClient As System.Windows.Forms.TextBox
    Friend WithEvents DetCif As System.Windows.Forms.TextBox
    Friend WithEvents DetAdreça As System.Windows.Forms.TextBox
    Friend WithEvents DetCP As System.Windows.Forms.TextBox
    Friend WithEvents DetPoblacio As System.Windows.Forms.TextBox
    Friend WithEvents DetProvincia As System.Windows.Forms.TextBox
    Friend WithEvents DgConceptes As System.Windows.Forms.DataGridView
    Friend WithEvents DetTotal As System.Windows.Forms.TextBox
    Friend WithEvents DetRetencio As System.Windows.Forms.TextBox
    Friend WithEvents DetRetencioImport As System.Windows.Forms.TextBox
    Friend WithEvents DetImport As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnSortir As System.Windows.Forms.Button
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
End Class
