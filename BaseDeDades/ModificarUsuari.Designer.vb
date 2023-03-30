<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarUsuari
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.CbPrivilegis = New System.Windows.Forms.CheckBox
        Me.CbAdministratiu = New System.Windows.Forms.CheckBox
        Me.CbSanitari = New System.Windows.Forms.CheckBox
        Me.CbAdministrador = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Nom = New System.Windows.Forms.Label
        Me.DniUsuari = New System.Windows.Forms.TextBox
        Me.NomUsuari = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnOK = New System.Windows.Forms.Button
        Me.IntroNovaContrasenya = New System.Windows.Forms.TextBox
        Me.IntroNouUsuari = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CbPrivilegis)
        Me.Panel1.Controls.Add(Me.CbAdministratiu)
        Me.Panel1.Controls.Add(Me.CbSanitari)
        Me.Panel1.Controls.Add(Me.CbAdministrador)
        Me.Panel1.Location = New System.Drawing.Point(122, 230)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(176, 200)
        Me.Panel1.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 18)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Grup de treball"
        '
        'CbPrivilegis
        '
        Me.CbPrivilegis.AutoSize = True
        Me.CbPrivilegis.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbPrivilegis.Location = New System.Drawing.Point(26, 155)
        Me.CbPrivilegis.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.CbPrivilegis.Name = "CbPrivilegis"
        Me.CbPrivilegis.Size = New System.Drawing.Size(84, 20)
        Me.CbPrivilegis.TabIndex = 6
        Me.CbPrivilegis.Text = "Privilegis"
        Me.CbPrivilegis.UseVisualStyleBackColor = True
        '
        'CbAdministratiu
        '
        Me.CbAdministratiu.AutoSize = True
        Me.CbAdministratiu.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbAdministratiu.Location = New System.Drawing.Point(26, 121)
        Me.CbAdministratiu.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.CbAdministratiu.Name = "CbAdministratiu"
        Me.CbAdministratiu.Size = New System.Drawing.Size(114, 20)
        Me.CbAdministratiu.TabIndex = 5
        Me.CbAdministratiu.Text = "Administratiu"
        Me.CbAdministratiu.UseVisualStyleBackColor = True
        '
        'CbSanitari
        '
        Me.CbSanitari.AutoSize = True
        Me.CbSanitari.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbSanitari.Location = New System.Drawing.Point(26, 85)
        Me.CbSanitari.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.CbSanitari.Name = "CbSanitari"
        Me.CbSanitari.Size = New System.Drawing.Size(77, 20)
        Me.CbSanitari.TabIndex = 4
        Me.CbSanitari.Text = "Sanitari"
        Me.CbSanitari.UseVisualStyleBackColor = True
        '
        'CbAdministrador
        '
        Me.CbAdministrador.AutoSize = True
        Me.CbAdministrador.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbAdministrador.Location = New System.Drawing.Point(26, 50)
        Me.CbAdministrador.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.CbAdministrador.Name = "CbAdministrador"
        Me.CbAdministrador.Size = New System.Drawing.Size(119, 20)
        Me.CbAdministrador.TabIndex = 3
        Me.CbAdministrador.Text = "Administrador"
        Me.CbAdministrador.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(75, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "DNI:"
        '
        'Nom
        '
        Me.Nom.AutoSize = True
        Me.Nom.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom.Location = New System.Drawing.Point(69, 58)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(40, 16)
        Me.Nom.TabIndex = 24
        Me.Nom.Text = "Nom:"
        '
        'DniUsuari
        '
        Me.DniUsuari.Location = New System.Drawing.Point(122, 90)
        Me.DniUsuari.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DniUsuari.Name = "DniUsuari"
        Me.DniUsuari.Size = New System.Drawing.Size(165, 23)
        Me.DniUsuari.TabIndex = 23
        '
        'NomUsuari
        '
        Me.NomUsuari.Location = New System.Drawing.Point(122, 54)
        Me.NomUsuari.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NomUsuari.Name = "NomUsuari"
        Me.NomUsuari.Size = New System.Drawing.Size(269, 23)
        Me.NomUsuari.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Contrasenya:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Usuari:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(339, 277)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 37)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "CANCELAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.Location = New System.Drawing.Point(339, 230)
        Me.BtnOK.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(104, 37)
        Me.BtnOK.TabIndex = 18
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'IntroNovaContrasenya
        '
        Me.IntroNovaContrasenya.Location = New System.Drawing.Point(122, 180)
        Me.IntroNovaContrasenya.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.IntroNovaContrasenya.Name = "IntroNovaContrasenya"
        Me.IntroNovaContrasenya.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.IntroNovaContrasenya.Size = New System.Drawing.Size(259, 23)
        Me.IntroNovaContrasenya.TabIndex = 17
        Me.IntroNovaContrasenya.UseSystemPasswordChar = True
        '
        'IntroNouUsuari
        '
        Me.IntroNouUsuari.Location = New System.Drawing.Point(122, 142)
        Me.IntroNouUsuari.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.IntroNouUsuari.Name = "IntroNouUsuari"
        Me.IntroNouUsuari.Size = New System.Drawing.Size(259, 23)
        Me.IntroNouUsuari.TabIndex = 16
        '
        'ModificarUsuari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(477, 459)
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
        Me.Name = "ModificarUsuari"
        Me.Text = "MODIFICAR USUARI"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbPrivilegis As System.Windows.Forms.CheckBox
    Friend WithEvents CbAdministratiu As System.Windows.Forms.CheckBox
    Friend WithEvents CbSanitari As System.Windows.Forms.CheckBox
    Friend WithEvents CbAdministrador As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Nom As System.Windows.Forms.Label
    Friend WithEvents DniUsuari As System.Windows.Forms.TextBox
    Friend WithEvents NomUsuari As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents IntroNovaContrasenya As System.Windows.Forms.TextBox
    Friend WithEvents IntroNouUsuari As System.Windows.Forms.TextBox
End Class
