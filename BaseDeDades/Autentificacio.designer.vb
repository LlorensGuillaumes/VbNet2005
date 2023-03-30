<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Autentificacio
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Usuari = New System.Windows.Forms.TextBox
        Me.Contrasenya = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.OrigenDadesPred = New System.Windows.Forms.TextBox
        Me.PredeterminatSiNo = New System.Windows.Forms.CheckBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(28, 15)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 43)
        Me.Button1.TabIndex = 0
        Me.Button1.TabStop = False
        Me.Button1.Text = "Canviar Origen de dades"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Usuari
        '
        Me.Usuari.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuari.Location = New System.Drawing.Point(28, 161)
        Me.Usuari.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Usuari.Name = "Usuari"
        Me.Usuari.Size = New System.Drawing.Size(160, 22)
        Me.Usuari.TabIndex = 0
        '
        'Contrasenya
        '
        Me.Contrasenya.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Contrasenya.Location = New System.Drawing.Point(28, 207)
        Me.Contrasenya.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Contrasenya.Name = "Contrasenya"
        Me.Contrasenya.Size = New System.Drawing.Size(158, 22)
        Me.Contrasenya.TabIndex = 1
        Me.Contrasenya.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuari"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contrasenya"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(194, 177)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 52)
        Me.Button2.TabIndex = 5
        Me.Button2.TabStop = False
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OrigenDadesPred
        '
        Me.OrigenDadesPred.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.OrigenDadesPred.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OrigenDadesPred.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.OrigenDadesPred.Location = New System.Drawing.Point(28, 78)
        Me.OrigenDadesPred.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OrigenDadesPred.Name = "OrigenDadesPred"
        Me.OrigenDadesPred.ReadOnly = True
        Me.OrigenDadesPred.Size = New System.Drawing.Size(320, 15)
        Me.OrigenDadesPred.TabIndex = 6
        Me.OrigenDadesPred.TabStop = False
        '
        'PredeterminatSiNo
        '
        Me.PredeterminatSiNo.AutoSize = True
        Me.PredeterminatSiNo.Location = New System.Drawing.Point(28, 103)
        Me.PredeterminatSiNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PredeterminatSiNo.Name = "PredeterminatSiNo"
        Me.PredeterminatSiNo.Size = New System.Drawing.Size(234, 20)
        Me.PredeterminatSiNo.TabIndex = 7
        Me.PredeterminatSiNo.TabStop = False
        Me.PredeterminatSiNo.Text = "Guardar ruta com a predeterminada"
        Me.PredeterminatSiNo.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(273, 271)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 43)
        Me.Button3.TabIndex = 8
        Me.Button3.TabStop = False
        Me.Button3.Text = "SORTIR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Autentificacio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(397, 327)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PredeterminatSiNo)
        Me.Controls.Add(Me.OrigenDadesPred)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Contrasenya)
        Me.Controls.Add(Me.Usuari)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Autentificacio"
        Me.Text = "CONTROL D'USUARI I DADES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Usuari As System.Windows.Forms.TextBox
    Friend WithEvents Contrasenya As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OrigenDadesPred As System.Windows.Forms.TextBox
    Friend WithEvents PredeterminatSiNo As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
