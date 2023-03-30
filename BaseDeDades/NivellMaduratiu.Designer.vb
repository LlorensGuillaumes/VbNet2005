<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NivellMaduratiu
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
        Me.RbMasculi = New System.Windows.Forms.RadioButton
        Me.RbFemeni = New System.Windows.Forms.RadioButton
        Me.RbXSi = New System.Windows.Forms.RadioButton
        Me.RbXNo = New System.Windows.Forms.RadioButton
        Me.RbYSi = New System.Windows.Forms.RadioButton
        Me.RbYNo = New System.Windows.Forms.RadioButton
        Me.EtX = New System.Windows.Forms.Label
        Me.EtY = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnOK = New System.Windows.Forms.Button
        Me.BtnInfo = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'RbMasculi
        '
        Me.RbMasculi.AutoSize = True
        Me.RbMasculi.Location = New System.Drawing.Point(10, 3)
        Me.RbMasculi.Name = "RbMasculi"
        Me.RbMasculi.Size = New System.Drawing.Size(83, 22)
        Me.RbMasculi.TabIndex = 0
        Me.RbMasculi.TabStop = True
        Me.RbMasculi.Text = "Masculí"
        Me.RbMasculi.UseVisualStyleBackColor = True
        '
        'RbFemeni
        '
        Me.RbFemeni.AutoSize = True
        Me.RbFemeni.Location = New System.Drawing.Point(118, 3)
        Me.RbFemeni.Name = "RbFemeni"
        Me.RbFemeni.Size = New System.Drawing.Size(80, 22)
        Me.RbFemeni.TabIndex = 1
        Me.RbFemeni.TabStop = True
        Me.RbFemeni.Text = "Femení"
        Me.RbFemeni.UseVisualStyleBackColor = True
        '
        'RbXSi
        '
        Me.RbXSi.AutoSize = True
        Me.RbXSi.Location = New System.Drawing.Point(349, 3)
        Me.RbXSi.Name = "RbXSi"
        Me.RbXSi.Size = New System.Drawing.Size(41, 22)
        Me.RbXSi.TabIndex = 2
        Me.RbXSi.TabStop = True
        Me.RbXSi.Text = "Sí"
        Me.RbXSi.UseVisualStyleBackColor = True
        '
        'RbXNo
        '
        Me.RbXNo.AutoSize = True
        Me.RbXNo.Location = New System.Drawing.Point(457, 3)
        Me.RbXNo.Name = "RbXNo"
        Me.RbXNo.Size = New System.Drawing.Size(47, 22)
        Me.RbXNo.TabIndex = 3
        Me.RbXNo.TabStop = True
        Me.RbXNo.Text = "No"
        Me.RbXNo.UseVisualStyleBackColor = True
        '
        'RbYSi
        '
        Me.RbYSi.AutoSize = True
        Me.RbYSi.Location = New System.Drawing.Point(349, 3)
        Me.RbYSi.Name = "RbYSi"
        Me.RbYSi.Size = New System.Drawing.Size(41, 22)
        Me.RbYSi.TabIndex = 4
        Me.RbYSi.TabStop = True
        Me.RbYSi.Text = "Sí"
        Me.RbYSi.UseVisualStyleBackColor = True
        '
        'RbYNo
        '
        Me.RbYNo.AutoSize = True
        Me.RbYNo.Location = New System.Drawing.Point(457, 3)
        Me.RbYNo.Name = "RbYNo"
        Me.RbYNo.Size = New System.Drawing.Size(47, 22)
        Me.RbYNo.TabIndex = 5
        Me.RbYNo.TabStop = True
        Me.RbYNo.Text = "No"
        Me.RbYNo.UseVisualStyleBackColor = True
        '
        'EtX
        '
        Me.EtX.AutoSize = True
        Me.EtX.Location = New System.Drawing.Point(3, 5)
        Me.EtX.Name = "EtX"
        Me.EtX.Size = New System.Drawing.Size(59, 18)
        Me.EtX.TabIndex = 6
        Me.EtX.Text = "Label1"
        '
        'EtY
        '
        Me.EtY.AutoSize = True
        Me.EtY.Location = New System.Drawing.Point(3, 5)
        Me.EtY.Name = "EtY"
        Me.EtY.Size = New System.Drawing.Size(59, 18)
        Me.EtY.TabIndex = 7
        Me.EtY.Text = "Label1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RbFemeni)
        Me.Panel1.Controls.Add(Me.RbMasculi)
        Me.Panel1.Location = New System.Drawing.Point(351, 143)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(209, 29)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.EtX)
        Me.Panel2.Controls.Add(Me.RbXNo)
        Me.Panel2.Controls.Add(Me.RbXSi)
        Me.Panel2.Location = New System.Drawing.Point(12, 178)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(585, 30)
        Me.Panel2.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.EtY)
        Me.Panel3.Controls.Add(Me.RbYNo)
        Me.Panel3.Controls.Add(Me.RbYSi)
        Me.Panel3.Location = New System.Drawing.Point(12, 214)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(585, 36)
        Me.Panel3.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(218, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "CÀLCUL DEL NIVELL MADURATIU"
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(469, 272)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(74, 38)
        Me.BtnOK.TabIndex = 11
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'BtnInfo
        '
        Me.BtnInfo.Location = New System.Drawing.Point(12, 135)
        Me.BtnInfo.Name = "BtnInfo"
        Me.BtnInfo.Size = New System.Drawing.Size(115, 33)
        Me.BtnInfo.TabIndex = 12
        Me.BtnInfo.Text = "Informació"
        Me.BtnInfo.UseVisualStyleBackColor = True
        '
        'NivellMaduratiu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(772, 364)
        Me.Controls.Add(Me.BtnInfo)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "NivellMaduratiu"
        Me.Text = "NIVELL MADURATIU"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RbMasculi As System.Windows.Forms.RadioButton
    Friend WithEvents RbFemeni As System.Windows.Forms.RadioButton
    Friend WithEvents RbXSi As System.Windows.Forms.RadioButton
    Friend WithEvents RbXNo As System.Windows.Forms.RadioButton
    Friend WithEvents RbYSi As System.Windows.Forms.RadioButton
    Friend WithEvents RbYNo As System.Windows.Forms.RadioButton
    Friend WithEvents EtX As System.Windows.Forms.Label
    Friend WithEvents EtY As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents BtnInfo As System.Windows.Forms.Button
End Class
