<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClubsEsportius
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
        Me.BtnSortir = New System.Windows.Forms.Button
        Me.DgClubsEsportius = New System.Windows.Forms.DataGridView
        Me.Nom = New System.Windows.Forms.TextBox
        Me.Adreça = New System.Windows.Forms.TextBox
        Me.Poblacio = New System.Windows.Forms.TextBox
        Me.Telefon = New System.Windows.Forms.TextBox
        Me.Fax = New System.Windows.Forms.TextBox
        Me.Ae = New System.Windows.Forms.TextBox
        Me.Contacte = New System.Windows.Forms.TextBox
        Me.Notes = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnNouClub = New System.Windows.Forms.Button
        Me.BtnOk = New System.Windows.Forms.Button
        Me.ModCif = New System.Windows.Forms.TextBox
        Me.ModNom = New System.Windows.Forms.TextBox
        Me.ModCP = New System.Windows.Forms.TextBox
        Me.ModPoblacio = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        CType(Me.DgClubsEsportius, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSortir
        '
        Me.BtnSortir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSortir.Location = New System.Drawing.Point(825, 226)
        Me.BtnSortir.Name = "BtnSortir"
        Me.BtnSortir.Size = New System.Drawing.Size(122, 47)
        Me.BtnSortir.TabIndex = 0
        Me.BtnSortir.Text = "SORTIR"
        Me.BtnSortir.UseVisualStyleBackColor = True
        '
        'DgClubsEsportius
        '
        Me.DgClubsEsportius.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgClubsEsportius.Location = New System.Drawing.Point(30, 52)
        Me.DgClubsEsportius.Name = "DgClubsEsportius"
        Me.DgClubsEsportius.Size = New System.Drawing.Size(318, 465)
        Me.DgClubsEsportius.TabIndex = 0
        Me.DgClubsEsportius.TabStop = False
        '
        'Nom
        '
        Me.Nom.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Nom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Nom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Nom.Enabled = False
        Me.Nom.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom.Location = New System.Drawing.Point(392, 52)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(513, 19)
        Me.Nom.TabIndex = 2
        '
        'Adreça
        '
        Me.Adreça.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Adreça.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Adreça.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Adreça.Enabled = False
        Me.Adreça.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Adreça.Location = New System.Drawing.Point(392, 98)
        Me.Adreça.Name = "Adreça"
        Me.Adreça.Size = New System.Drawing.Size(513, 19)
        Me.Adreça.TabIndex = 3
        '
        'Poblacio
        '
        Me.Poblacio.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Poblacio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Poblacio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Poblacio.Enabled = False
        Me.Poblacio.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Poblacio.Location = New System.Drawing.Point(392, 143)
        Me.Poblacio.Name = "Poblacio"
        Me.Poblacio.Size = New System.Drawing.Size(513, 19)
        Me.Poblacio.TabIndex = 5
        '
        'Telefon
        '
        Me.Telefon.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Telefon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Telefon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Telefon.Enabled = False
        Me.Telefon.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telefon.Location = New System.Drawing.Point(392, 194)
        Me.Telefon.Name = "Telefon"
        Me.Telefon.Size = New System.Drawing.Size(144, 19)
        Me.Telefon.TabIndex = 6
        '
        'Fax
        '
        Me.Fax.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Fax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Fax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fax.Enabled = False
        Me.Fax.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fax.Location = New System.Drawing.Point(542, 194)
        Me.Fax.Name = "Fax"
        Me.Fax.Size = New System.Drawing.Size(144, 19)
        Me.Fax.TabIndex = 7
        '
        'Ae
        '
        Me.Ae.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Ae.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Ae.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.Ae.Enabled = False
        Me.Ae.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ae.Location = New System.Drawing.Point(392, 243)
        Me.Ae.Name = "Ae"
        Me.Ae.Size = New System.Drawing.Size(290, 19)
        Me.Ae.TabIndex = 8
        '
        'Contacte
        '
        Me.Contacte.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Contacte.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Contacte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Contacte.Enabled = False
        Me.Contacte.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contacte.Location = New System.Drawing.Point(392, 292)
        Me.Contacte.Name = "Contacte"
        Me.Contacte.Size = New System.Drawing.Size(290, 19)
        Me.Contacte.TabIndex = 9
        '
        'Notes
        '
        Me.Notes.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Notes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Notes.Enabled = False
        Me.Notes.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Notes.Location = New System.Drawing.Point(392, 341)
        Me.Notes.Multiline = True
        Me.Notes.Name = "Notes"
        Me.Notes.Size = New System.Drawing.Size(555, 181)
        Me.Notes.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Location = New System.Drawing.Point(389, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Telèfon"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label2.Location = New System.Drawing.Point(539, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Fax"
        '
        'BtnNouClub
        '
        Me.BtnNouClub.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNouClub.Location = New System.Drawing.Point(825, 173)
        Me.BtnNouClub.Name = "BtnNouClub"
        Me.BtnNouClub.Size = New System.Drawing.Size(122, 47)
        Me.BtnNouClub.TabIndex = 13
        Me.BtnNouClub.Text = "NOU CLUB"
        Me.BtnNouClub.UseVisualStyleBackColor = True
        '
        'BtnOk
        '
        Me.BtnOk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.Location = New System.Drawing.Point(887, 528)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(60, 50)
        Me.BtnOk.TabIndex = 11
        Me.BtnOk.Text = "OK"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'ModCif
        '
        Me.ModCif.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ModCif.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModCif.Location = New System.Drawing.Point(762, 51)
        Me.ModCif.Name = "ModCif"
        Me.ModCif.Size = New System.Drawing.Size(142, 26)
        Me.ModCif.TabIndex = 2
        '
        'ModNom
        '
        Me.ModNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ModNom.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModNom.Location = New System.Drawing.Point(392, 51)
        Me.ModNom.Name = "ModNom"
        Me.ModNom.Size = New System.Drawing.Size(364, 26)
        Me.ModNom.TabIndex = 1
        '
        'ModCP
        '
        Me.ModCP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ModCP.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModCP.Location = New System.Drawing.Point(392, 143)
        Me.ModCP.Name = "ModCP"
        Me.ModCP.Size = New System.Drawing.Size(142, 26)
        Me.ModCP.TabIndex = 4
        '
        'ModPoblacio
        '
        Me.ModPoblacio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ModPoblacio.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModPoblacio.Location = New System.Drawing.Point(540, 143)
        Me.ModPoblacio.Name = "ModPoblacio"
        Me.ModPoblacio.Size = New System.Drawing.Size(365, 26)
        Me.ModPoblacio.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label3.Location = New System.Drawing.Point(759, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "CIF"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Location = New System.Drawing.Point(389, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "NOM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label5.Location = New System.Drawing.Point(389, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "CP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label6.Location = New System.Drawing.Point(539, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "POBLACIÓ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label7.Location = New System.Drawing.Point(389, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "ADREÇA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label8.Location = New System.Drawing.Point(392, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 16)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "AE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label9.Location = New System.Drawing.Point(392, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "PERSONA DE CONTACTE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Enabled = False
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label10.Location = New System.Drawing.Point(392, 320)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "OBSERVACIONS"
        '
        'ClubsEsportius
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(972, 615)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ModPoblacio)
        Me.Controls.Add(Me.ModCP)
        Me.Controls.Add(Me.ModNom)
        Me.Controls.Add(Me.ModCif)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.BtnNouClub)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Notes)
        Me.Controls.Add(Me.Contacte)
        Me.Controls.Add(Me.Ae)
        Me.Controls.Add(Me.Fax)
        Me.Controls.Add(Me.Telefon)
        Me.Controls.Add(Me.Poblacio)
        Me.Controls.Add(Me.Adreça)
        Me.Controls.Add(Me.Nom)
        Me.Controls.Add(Me.DgClubsEsportius)
        Me.Controls.Add(Me.BtnSortir)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ClubsEsportius"
        Me.Text = "CLUBS ESPORTIUS"
        CType(Me.DgClubsEsportius, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSortir As System.Windows.Forms.Button
    Friend WithEvents DgClubsEsportius As System.Windows.Forms.DataGridView
    Friend WithEvents Nom As System.Windows.Forms.TextBox
    Friend WithEvents Adreça As System.Windows.Forms.TextBox
    Friend WithEvents Poblacio As System.Windows.Forms.TextBox
    Friend WithEvents Telefon As System.Windows.Forms.TextBox
    Friend WithEvents Fax As System.Windows.Forms.TextBox
    Friend WithEvents Ae As System.Windows.Forms.TextBox
    Friend WithEvents Contacte As System.Windows.Forms.TextBox
    Friend WithEvents Notes As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnNouClub As System.Windows.Forms.Button
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents ModCif As System.Windows.Forms.TextBox
    Friend WithEvents ModNom As System.Windows.Forms.TextBox
    Friend WithEvents ModCP As System.Windows.Forms.TextBox
    Friend WithEvents ModPoblacio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
