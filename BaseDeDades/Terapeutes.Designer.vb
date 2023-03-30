<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Terapeutes
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
        Me.DgTerapeutes = New System.Windows.Forms.DataGridView
        Me.BtnSortir = New System.Windows.Forms.Button
        Me.CbTerapeuta = New System.Windows.Forms.ComboBox
        Me.TbColegiat = New System.Windows.Forms.TextBox
        Me.RbModificar = New System.Windows.Forms.RadioButton
        Me.RbEliminar = New System.Windows.Forms.RadioButton
        Me.RbNou = New System.Windows.Forms.RadioButton
        Me.BtnOK = New System.Windows.Forms.Button
        Me.PanOpcions = New System.Windows.Forms.Panel
        Me.BtnOkGestio = New System.Windows.Forms.Button
        Me.PanGestio = New System.Windows.Forms.Panel
        Me.TbTerapeuta = New System.Windows.Forms.TextBox
        CType(Me.DgTerapeutes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanOpcions.SuspendLayout()
        Me.PanGestio.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgTerapeutes
        '
        Me.DgTerapeutes.BackgroundColor = System.Drawing.Color.Beige
        Me.DgTerapeutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgTerapeutes.Enabled = False
        Me.DgTerapeutes.Location = New System.Drawing.Point(34, 65)
        Me.DgTerapeutes.Name = "DgTerapeutes"
        Me.DgTerapeutes.Size = New System.Drawing.Size(333, 266)
        Me.DgTerapeutes.TabIndex = 0
        Me.DgTerapeutes.TabStop = False
        '
        'BtnSortir
        '
        Me.BtnSortir.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSortir.Location = New System.Drawing.Point(410, 299)
        Me.BtnSortir.Name = "BtnSortir"
        Me.BtnSortir.Size = New System.Drawing.Size(99, 32)
        Me.BtnSortir.TabIndex = 1
        Me.BtnSortir.Text = "Sortir"
        Me.BtnSortir.UseVisualStyleBackColor = True
        '
        'CbTerapeuta
        '
        Me.CbTerapeuta.FormattingEnabled = True
        Me.CbTerapeuta.Location = New System.Drawing.Point(2, 10)
        Me.CbTerapeuta.Name = "CbTerapeuta"
        Me.CbTerapeuta.Size = New System.Drawing.Size(271, 24)
        Me.CbTerapeuta.TabIndex = 2
        '
        'TbColegiat
        '
        Me.TbColegiat.Location = New System.Drawing.Point(2, 40)
        Me.TbColegiat.Name = "TbColegiat"
        Me.TbColegiat.Size = New System.Drawing.Size(136, 23)
        Me.TbColegiat.TabIndex = 1
        '
        'RbModificar
        '
        Me.RbModificar.AutoSize = True
        Me.RbModificar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbModificar.Location = New System.Drawing.Point(11, 7)
        Me.RbModificar.Name = "RbModificar"
        Me.RbModificar.Size = New System.Drawing.Size(85, 20)
        Me.RbModificar.TabIndex = 4
        Me.RbModificar.TabStop = True
        Me.RbModificar.Text = "Modificar"
        Me.RbModificar.UseVisualStyleBackColor = True
        '
        'RbEliminar
        '
        Me.RbEliminar.AutoSize = True
        Me.RbEliminar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbEliminar.Location = New System.Drawing.Point(11, 33)
        Me.RbEliminar.Name = "RbEliminar"
        Me.RbEliminar.Size = New System.Drawing.Size(75, 20)
        Me.RbEliminar.TabIndex = 5
        Me.RbEliminar.TabStop = True
        Me.RbEliminar.Text = "Eliminar"
        Me.RbEliminar.UseVisualStyleBackColor = True
        '
        'RbNou
        '
        Me.RbNou.AutoSize = True
        Me.RbNou.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNou.Location = New System.Drawing.Point(11, 59)
        Me.RbNou.Name = "RbNou"
        Me.RbNou.Size = New System.Drawing.Size(120, 20)
        Me.RbNou.TabIndex = 6
        Me.RbNou.TabStop = True
        Me.RbNou.Text = "Nou terapeuta"
        Me.RbNou.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.Location = New System.Drawing.Point(172, 18)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(55, 49)
        Me.BtnOK.TabIndex = 7
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'PanOpcions
        '
        Me.PanOpcions.Controls.Add(Me.RbNou)
        Me.PanOpcions.Controls.Add(Me.RbEliminar)
        Me.PanOpcions.Controls.Add(Me.BtnOK)
        Me.PanOpcions.Controls.Add(Me.RbModificar)
        Me.PanOpcions.Location = New System.Drawing.Point(377, 33)
        Me.PanOpcions.Name = "PanOpcions"
        Me.PanOpcions.Size = New System.Drawing.Size(267, 88)
        Me.PanOpcions.TabIndex = 8
        '
        'BtnOkGestio
        '
        Me.BtnOkGestio.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOkGestio.Location = New System.Drawing.Point(144, 40)
        Me.BtnOkGestio.Name = "BtnOkGestio"
        Me.BtnOkGestio.Size = New System.Drawing.Size(55, 49)
        Me.BtnOkGestio.TabIndex = 2
        Me.BtnOkGestio.Text = "OK"
        Me.BtnOkGestio.UseVisualStyleBackColor = True
        '
        'PanGestio
        '
        Me.PanGestio.Controls.Add(Me.TbTerapeuta)
        Me.PanGestio.Controls.Add(Me.BtnOkGestio)
        Me.PanGestio.Controls.Add(Me.TbColegiat)
        Me.PanGestio.Controls.Add(Me.CbTerapeuta)
        Me.PanGestio.Location = New System.Drawing.Point(371, 171)
        Me.PanGestio.Name = "PanGestio"
        Me.PanGestio.Size = New System.Drawing.Size(283, 99)
        Me.PanGestio.TabIndex = 0
        '
        'TbTerapeuta
        '
        Me.TbTerapeuta.Location = New System.Drawing.Point(3, 11)
        Me.TbTerapeuta.Name = "TbTerapeuta"
        Me.TbTerapeuta.Size = New System.Drawing.Size(269, 23)
        Me.TbTerapeuta.TabIndex = 0
        '
        'Terapeutes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(743, 402)
        Me.Controls.Add(Me.PanGestio)
        Me.Controls.Add(Me.PanOpcions)
        Me.Controls.Add(Me.BtnSortir)
        Me.Controls.Add(Me.DgTerapeutes)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Terapeutes"
        Me.Text = "TERAPEUTES"
        CType(Me.DgTerapeutes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanOpcions.ResumeLayout(False)
        Me.PanOpcions.PerformLayout()
        Me.PanGestio.ResumeLayout(False)
        Me.PanGestio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgTerapeutes As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSortir As System.Windows.Forms.Button
    Friend WithEvents CbTerapeuta As System.Windows.Forms.ComboBox
    Friend WithEvents TbColegiat As System.Windows.Forms.TextBox
    Friend WithEvents RbModificar As System.Windows.Forms.RadioButton
    Friend WithEvents RbEliminar As System.Windows.Forms.RadioButton
    Friend WithEvents RbNou As System.Windows.Forms.RadioButton
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents PanOpcions As System.Windows.Forms.Panel
    Friend WithEvents BtnOkGestio As System.Windows.Forms.Button
    Friend WithEvents PanGestio As System.Windows.Forms.Panel
    Friend WithEvents TbTerapeuta As System.Windows.Forms.TextBox
End Class
