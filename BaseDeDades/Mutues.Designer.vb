<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mutues
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
        Me.DgMutues = New System.Windows.Forms.DataGridView
        Me.BtnSortir = New System.Windows.Forms.Button
        Me.BuscarMutua = New System.Windows.Forms.TextBox
        Me.BtnBuscar = New System.Windows.Forms.Button
        Me.BtnTotes = New System.Windows.Forms.Button
        CType(Me.DgMutues, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgMutues
        '
        Me.DgMutues.AllowUserToAddRows = False
        Me.DgMutues.AllowUserToDeleteRows = False
        Me.DgMutues.AllowUserToOrderColumns = True
        Me.DgMutues.AllowUserToResizeColumns = False
        Me.DgMutues.AllowUserToResizeRows = False
        Me.DgMutues.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgMutues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgMutues.Location = New System.Drawing.Point(54, 118)
        Me.DgMutues.Margin = New System.Windows.Forms.Padding(4)
        Me.DgMutues.Name = "DgMutues"
        Me.DgMutues.Size = New System.Drawing.Size(1284, 601)
        Me.DgMutues.TabIndex = 0
        '
        'BtnSortir
        '
        Me.BtnSortir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSortir.Location = New System.Drawing.Point(1220, 61)
        Me.BtnSortir.Name = "BtnSortir"
        Me.BtnSortir.Size = New System.Drawing.Size(118, 36)
        Me.BtnSortir.TabIndex = 1
        Me.BtnSortir.Text = "SORTIR"
        Me.BtnSortir.UseVisualStyleBackColor = True
        '
        'BuscarMutua
        '
        Me.BuscarMutua.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarMutua.Location = New System.Drawing.Point(54, 48)
        Me.BuscarMutua.Name = "BuscarMutua"
        Me.BuscarMutua.Size = New System.Drawing.Size(333, 23)
        Me.BuscarMutua.TabIndex = 2
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(393, 42)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(122, 32)
        Me.BtnBuscar.TabIndex = 3
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnTotes
        '
        Me.BtnTotes.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTotes.Location = New System.Drawing.Point(393, 79)
        Me.BtnTotes.Name = "BtnTotes"
        Me.BtnTotes.Size = New System.Drawing.Size(122, 32)
        Me.BtnTotes.TabIndex = 4
        Me.BtnTotes.Text = "Mostrar totes"
        Me.BtnTotes.UseVisualStyleBackColor = True
        '
        'Mutues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1410, 750)
        Me.Controls.Add(Me.BtnTotes)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BuscarMutua)
        Me.Controls.Add(Me.BtnSortir)
        Me.Controls.Add(Me.DgMutues)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Mutues"
        Me.Text = "MÚTUES"
        CType(Me.DgMutues, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgMutues As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSortir As System.Windows.Forms.Button
    Friend WithEvents BuscarMutua As System.Windows.Forms.TextBox
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnTotes As System.Windows.Forms.Button
End Class
