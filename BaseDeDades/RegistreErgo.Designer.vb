<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistreErgo
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
        Me.Valoracio = New System.Windows.Forms.TextBox
        Me.MinProva = New System.Windows.Forms.TextBox
        Me.TA = New System.Windows.Forms.TextBox
        Me.Pacient = New System.Windows.Forms.TextBox
        Me.SPO2 = New System.Windows.Forms.TextBox
        Me.FC = New System.Windows.Forms.TextBox
        Me.Observacions = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.BtnOk = New System.Windows.Forms.Button
        CType(Me.Ecg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ecg
        '
        Me.Ecg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Ecg.BackColor = System.Drawing.Color.White
        Me.Ecg.Location = New System.Drawing.Point(0, 51)
        Me.Ecg.Name = "Ecg"
        Me.Ecg.Size = New System.Drawing.Size(1118, 657)
        Me.Ecg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Ecg.TabIndex = 0
        Me.Ecg.TabStop = False
        '
        'Valoracio
        '
        Me.Valoracio.Location = New System.Drawing.Point(1218, 51)
        Me.Valoracio.Name = "Valoracio"
        Me.Valoracio.Size = New System.Drawing.Size(106, 20)
        Me.Valoracio.TabIndex = 1
        '
        'MinProva
        '
        Me.MinProva.Location = New System.Drawing.Point(1218, 77)
        Me.MinProva.Name = "MinProva"
        Me.MinProva.Size = New System.Drawing.Size(32, 20)
        Me.MinProva.TabIndex = 2
        '
        'TA
        '
        Me.TA.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TA.Location = New System.Drawing.Point(1218, 103)
        Me.TA.Name = "TA"
        Me.TA.Size = New System.Drawing.Size(106, 22)
        Me.TA.TabIndex = 3
        '
        'Pacient
        '
        Me.Pacient.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Pacient.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Pacient.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pacient.ForeColor = System.Drawing.Color.Gray
        Me.Pacient.Location = New System.Drawing.Point(12, 12)
        Me.Pacient.Name = "Pacient"
        Me.Pacient.ReadOnly = True
        Me.Pacient.Size = New System.Drawing.Size(617, 23)
        Me.Pacient.TabIndex = 4
        Me.Pacient.TabStop = False
        '
        'SPO2
        '
        Me.SPO2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SPO2.Location = New System.Drawing.Point(1218, 159)
        Me.SPO2.Name = "SPO2"
        Me.SPO2.Size = New System.Drawing.Size(106, 22)
        Me.SPO2.TabIndex = 5
        '
        'FC
        '
        Me.FC.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FC.Location = New System.Drawing.Point(1218, 131)
        Me.FC.Name = "FC"
        Me.FC.Size = New System.Drawing.Size(106, 22)
        Me.FC.TabIndex = 6
        '
        'Observacions
        '
        Me.Observacions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Observacions.Location = New System.Drawing.Point(1139, 310)
        Me.Observacions.Multiline = True
        Me.Observacions.Name = "Observacions"
        Me.Observacions.Size = New System.Drawing.Size(221, 389)
        Me.Observacions.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1185, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 14)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "TA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1187, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 14)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "FC:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1168, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 14)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "SPO2:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1140, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 14)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Min prova:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1146, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 14)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Valoració:"
        '
        'BtnOk
        '
        Me.BtnOk.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.Location = New System.Drawing.Point(1218, 201)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(73, 37)
        Me.BtnOk.TabIndex = 13
        Me.BtnOk.Text = "OK"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'RegistreErgo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1372, 711)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Observacions)
        Me.Controls.Add(Me.FC)
        Me.Controls.Add(Me.SPO2)
        Me.Controls.Add(Me.Pacient)
        Me.Controls.Add(Me.TA)
        Me.Controls.Add(Me.MinProva)
        Me.Controls.Add(Me.Valoracio)
        Me.Controls.Add(Me.Ecg)
        Me.Name = "RegistreErgo"
        Me.Text = "REGISTRE ERGOMETRIA"
        CType(Me.Ecg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ecg As System.Windows.Forms.PictureBox
    Friend WithEvents Valoracio As System.Windows.Forms.TextBox
    Friend WithEvents MinProva As System.Windows.Forms.TextBox
    Friend WithEvents TA As System.Windows.Forms.TextBox
    Friend WithEvents Pacient As System.Windows.Forms.TextBox
    Friend WithEvents SPO2 As System.Windows.Forms.TextBox
    Friend WithEvents FC As System.Windows.Forms.TextBox
    Friend WithEvents Observacions As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnOk As System.Windows.Forms.Button
End Class
