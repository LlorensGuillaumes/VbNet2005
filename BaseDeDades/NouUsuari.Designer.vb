<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NouUsuari
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
        Me.IntroNouUsuari = New System.Windows.Forms.TextBox
        Me.IntroNovaContrasenya = New System.Windows.Forms.TextBox
        Me.BtnOK = New System.Windows.Forms.Button
        Me.CbAdministrador = New System.Windows.Forms.CheckBox
        Me.CbSanitari = New System.Windows.Forms.CheckBox
        Me.CbAdministratiu = New System.Windows.Forms.CheckBox
        Me.CbPrivilegis = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.NomUsuari = New System.Windows.Forms.TextBox
        Me.DniUsuari = New System.Windows.Forms.TextBox
        Me.Nom = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IntroNouUsuari
        '
        Me.IntroNouUsuari.Location = New System.Drawing.Point(106, 169)
        Me.IntroNouUsuari.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IntroNouUsuari.Name = "IntroNouUsuari"
        Me.IntroNouUsuari.Size = New System.Drawing.Size(223, 23)
        Me.IntroNouUsuari.TabIndex = 2
        '
        'IntroNovaContrasenya
        '
        Me.IntroNovaContrasenya.Location = New System.Drawing.Point(106, 200)
        Me.IntroNovaContrasenya.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IntroNovaContrasenya.Name = "IntroNovaContrasenya"
        Me.IntroNovaContrasenya.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.IntroNovaContrasenya.Size = New System.Drawing.Size(223, 23)
        Me.IntroNovaContrasenya.TabIndex = 3
        Me.IntroNovaContrasenya.UseSystemPasswordChar = True
        '
        'BtnOK
        '
        Me.BtnOK.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.Location = New System.Drawing.Point(292, 258)
        Me.BtnOK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(89, 30)
        Me.BtnOK.TabIndex = 5
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'CbAdministrador
        '
        Me.CbAdministrador.AutoSize = True
        Me.CbAdministrador.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbAdministrador.Location = New System.Drawing.Point(22, 41)
        Me.CbAdministrador.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CbAdministrador.Name = "CbAdministrador"
        Me.CbAdministrador.Size = New System.Drawing.Size(119, 20)
        Me.CbAdministrador.TabIndex = 0
        Me.CbAdministrador.Text = "Administrador"
        Me.CbAdministrador.UseVisualStyleBackColor = True
        '
        'CbSanitari
        '
        Me.CbSanitari.AutoSize = True
        Me.CbSanitari.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbSanitari.Location = New System.Drawing.Point(22, 69)
        Me.CbSanitari.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CbSanitari.Name = "CbSanitari"
        Me.CbSanitari.Size = New System.Drawing.Size(77, 20)
        Me.CbSanitari.TabIndex = 1
        Me.CbSanitari.Text = "Sanitari"
        Me.CbSanitari.UseVisualStyleBackColor = True
        '
        'CbAdministratiu
        '
        Me.CbAdministratiu.AutoSize = True
        Me.CbAdministratiu.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbAdministratiu.Location = New System.Drawing.Point(22, 98)
        Me.CbAdministratiu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CbAdministratiu.Name = "CbAdministratiu"
        Me.CbAdministratiu.Size = New System.Drawing.Size(114, 20)
        Me.CbAdministratiu.TabIndex = 2
        Me.CbAdministratiu.Text = "Administratiu"
        Me.CbAdministratiu.UseVisualStyleBackColor = True
        '
        'CbPrivilegis
        '
        Me.CbPrivilegis.AutoSize = True
        Me.CbPrivilegis.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbPrivilegis.Location = New System.Drawing.Point(22, 126)
        Me.CbPrivilegis.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CbPrivilegis.Name = "CbPrivilegis"
        Me.CbPrivilegis.Size = New System.Drawing.Size(84, 20)
        Me.CbPrivilegis.TabIndex = 3
        Me.CbPrivilegis.Text = "Privilegis"
        Me.CbPrivilegis.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(292, 296)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 30)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "CANCELAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Usuari:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Contrasenya:"
        '
        'NomUsuari
        '
        Me.NomUsuari.Location = New System.Drawing.Point(106, 57)
        Me.NomUsuari.Name = "NomUsuari"
        Me.NomUsuari.Size = New System.Drawing.Size(231, 23)
        Me.NomUsuari.TabIndex = 0
        '
        'DniUsuari
        '
        Me.DniUsuari.Location = New System.Drawing.Point(106, 86)
        Me.DniUsuari.Name = "DniUsuari"
        Me.DniUsuari.Size = New System.Drawing.Size(142, 23)
        Me.DniUsuari.TabIndex = 1
        '
        'Nom
        '
        Me.Nom.AutoSize = True
        Me.Nom.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom.Location = New System.Drawing.Point(60, 60)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(40, 16)
        Me.Nom.TabIndex = 12
        Me.Nom.Text = "Nom:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(65, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "DNI:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 18)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Grup de treball"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CbPrivilegis)
        Me.Panel1.Controls.Add(Me.CbAdministratiu)
        Me.Panel1.Controls.Add(Me.CbSanitari)
        Me.Panel1.Controls.Add(Me.CbAdministrador)
        Me.Panel1.Location = New System.Drawing.Point(106, 258)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(151, 163)
        Me.Panel1.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(45, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(324, 23)
        Me.TextBox1.TabIndex = 16
        '
        'NouUsuari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(407, 467)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Nom)
        Me.Controls.Add(Me.DniUsuari)
        Me.Controls.Add(Me.NomUsuari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.IntroNovaContrasenya)
        Me.Controls.Add(Me.IntroNouUsuari)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "NouUsuari"
        Me.Text = "ALTA USUARI"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IntroNouUsuari As System.Windows.Forms.TextBox
    Friend WithEvents IntroNovaContrasenya As System.Windows.Forms.TextBox
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents CbAdministrador As System.Windows.Forms.CheckBox
    Friend WithEvents CbSanitari As System.Windows.Forms.CheckBox
    Friend WithEvents CbAdministratiu As System.Windows.Forms.CheckBox
    Friend WithEvents CbPrivilegis As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NomUsuari As System.Windows.Forms.TextBox
    Friend WithEvents DniUsuari As System.Windows.Forms.TextBox
    Friend WithEvents Nom As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
