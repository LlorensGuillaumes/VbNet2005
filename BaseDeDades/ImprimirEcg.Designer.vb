<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprimirEcg
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
        Me.Ecg = New System.Windows.Forms.PictureBox
        Me.DgEcg = New System.Windows.Forms.DataGridView
        Me.BtnImprimir = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        CType(Me.Ecg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgEcg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ecg
        '
        Me.Ecg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ecg.BackColor = System.Drawing.Color.White
        Me.Ecg.Location = New System.Drawing.Point(250, 4)
        Me.Ecg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Ecg.Name = "Ecg"
        Me.Ecg.Size = New System.Drawing.Size(887, 636)
        Me.Ecg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Ecg.TabIndex = 0
        Me.Ecg.TabStop = False
        '
        'DgEcg
        '
        Me.DgEcg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgEcg.Location = New System.Drawing.Point(12, 52)
        Me.DgEcg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DgEcg.Name = "DgEcg"
        Me.DgEcg.Size = New System.Drawing.Size(220, 170)
        Me.DgEcg.TabIndex = 1
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimir.Location = New System.Drawing.Point(12, 229)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(129, 34)
        Me.BtnImprimir.TabIndex = 2
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 40)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "SORTIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'ImprimirEcg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1140, 644)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.DgEcg)
        Me.Controls.Add(Me.Ecg)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ImprimirEcg"
        Me.Text = "IMPRIMIR ECG"
        CType(Me.Ecg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgEcg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ecg As System.Windows.Forms.PictureBox
    Friend WithEvents DgEcg As System.Windows.Forms.DataGridView
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
