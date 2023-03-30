<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equips
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
        Me.Club = New System.Windows.Forms.ComboBox
        Me.DgEquips = New System.Windows.Forms.DataGridView
        Me.BtnSortir = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnNouEquip = New System.Windows.Forms.Button
        CType(Me.DgEquips, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Club
        '
        Me.Club.BackColor = System.Drawing.Color.Beige
        Me.Club.FormattingEnabled = True
        Me.Club.Location = New System.Drawing.Point(50, 117)
        Me.Club.Name = "Club"
        Me.Club.Size = New System.Drawing.Size(344, 24)
        Me.Club.TabIndex = 0
        '
        'DgEquips
        '
        Me.DgEquips.BackgroundColor = System.Drawing.Color.Beige
        Me.DgEquips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgEquips.Location = New System.Drawing.Point(50, 163)
        Me.DgEquips.Name = "DgEquips"
        Me.DgEquips.Size = New System.Drawing.Size(344, 389)
        Me.DgEquips.TabIndex = 1
        '
        'BtnSortir
        '
        Me.BtnSortir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSortir.Location = New System.Drawing.Point(422, 117)
        Me.BtnSortir.Name = "BtnSortir"
        Me.BtnSortir.Size = New System.Drawing.Size(87, 36)
        Me.BtnSortir.TabIndex = 2
        Me.BtnSortir.Text = "SORTIR"
        Me.BtnSortir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "LLISTATS D'EQUIPS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Club"
        '
        'BtnNouEquip
        '
        Me.BtnNouEquip.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNouEquip.Location = New System.Drawing.Point(422, 163)
        Me.BtnNouEquip.Name = "BtnNouEquip"
        Me.BtnNouEquip.Size = New System.Drawing.Size(87, 52)
        Me.BtnNouEquip.TabIndex = 5
        Me.BtnNouEquip.Text = "NOU EQUIP"
        Me.BtnNouEquip.UseVisualStyleBackColor = True
        '
        'Equips
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(541, 567)
        Me.Controls.Add(Me.BtnNouEquip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSortir)
        Me.Controls.Add(Me.DgEquips)
        Me.Controls.Add(Me.Club)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Equips"
        Me.Text = "EQUIPS"
        CType(Me.DgEquips, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Club As System.Windows.Forms.ComboBox
    Friend WithEvents DgEquips As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSortir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnNouEquip As System.Windows.Forms.Button
End Class
