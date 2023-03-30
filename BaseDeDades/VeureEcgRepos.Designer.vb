<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VeureEcgRepos
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
        Me.BtnSortir = New System.Windows.Forms.Button
        CType(Me.Ecg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ecg
        '
        Me.Ecg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ecg.Location = New System.Drawing.Point(0, 1)
        Me.Ecg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Ecg.Name = "Ecg"
        Me.Ecg.Size = New System.Drawing.Size(1032, 674)
        Me.Ecg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Ecg.TabIndex = 0
        Me.Ecg.TabStop = False
        '
        'BtnSortir
        '
        Me.BtnSortir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSortir.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSortir.Location = New System.Drawing.Point(1038, 30)
        Me.BtnSortir.Name = "BtnSortir"
        Me.BtnSortir.Size = New System.Drawing.Size(87, 42)
        Me.BtnSortir.TabIndex = 1
        Me.BtnSortir.Text = "Sortir"
        Me.BtnSortir.UseVisualStyleBackColor = True
        '
        'VeureEcgRepos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1148, 676)
        Me.Controls.Add(Me.BtnSortir)
        Me.Controls.Add(Me.Ecg)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "VeureEcgRepos"
        Me.Text = "ECG REPÒS"
        CType(Me.Ecg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ecg As System.Windows.Forms.PictureBox
    Friend WithEvents BtnSortir As System.Windows.Forms.Button
End Class
