<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Episodis
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
        Me.components = New System.ComponentModel.Container
        Me.DgEpisodis = New System.Windows.Forms.DataGridView
        Me.Pacient = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.EpisodisEtiqueta = New System.Windows.Forms.TabPage
        Me.BtnBorrar = New System.Windows.Forms.Button
        Me.DadesPacientEtiqueta = New System.Windows.Forms.TabPage
        Me.ModificarDN = New System.Windows.Forms.TextBox
        Me.ModificarDni = New System.Windows.Forms.TextBox
        Me.MoficarPoblacio = New System.Windows.Forms.TextBox
        Me.ModificarCP = New System.Windows.Forms.TextBox
        Me.ModificarPorta = New System.Windows.Forms.TextBox
        Me.ModificarNumero = New System.Windows.Forms.TextBox
        Me.ModificarPis = New System.Windows.Forms.TextBox
        Me.ModificarCarrer = New System.Windows.Forms.TextBox
        Me.ModificarTipusCarrer = New System.Windows.Forms.ComboBox
        Me.BtnOK = New System.Windows.Forms.Button
        Me.ModificarPrimerCognom = New System.Windows.Forms.TextBox
        Me.ModificarSegonCognom = New System.Windows.Forms.TextBox
        Me.ModificarNom = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DetAe = New System.Windows.Forms.TextBox
        Me.DetTelMob = New System.Windows.Forms.TextBox
        Me.DetTelFeina = New System.Windows.Forms.TextBox
        Me.DetTelFix = New System.Windows.Forms.TextBox
        Me.DetDni = New System.Windows.Forms.TextBox
        Me.DetDn = New System.Windows.Forms.TextBox
        Me.DetPoblacio = New System.Windows.Forms.TextBox
        Me.DetAdreça = New System.Windows.Forms.TextBox
        Me.DetPacient = New System.Windows.Forms.TextBox
        Me.InformesEtiqueta = New System.Windows.Forms.TabPage
        Me.DgInformes = New System.Windows.Forms.DataGridView
        Me.Button2 = New System.Windows.Forms.Button
        Me.Edat = New System.Windows.Forms.TextBox
        Me.TtipusCarrerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DgEpisodis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.EpisodisEtiqueta.SuspendLayout()
        Me.DadesPacientEtiqueta.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.InformesEtiqueta.SuspendLayout()
        CType(Me.DgInformes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TtipusCarrerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgEpisodis
        '
        Me.DgEpisodis.AllowUserToAddRows = False
        Me.DgEpisodis.AllowUserToDeleteRows = False
        Me.DgEpisodis.AllowUserToResizeColumns = False
        Me.DgEpisodis.AllowUserToResizeRows = False
        Me.DgEpisodis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DgEpisodis.BackgroundColor = System.Drawing.Color.Beige
        Me.DgEpisodis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgEpisodis.Location = New System.Drawing.Point(0, 70)
        Me.DgEpisodis.Name = "DgEpisodis"
        Me.DgEpisodis.Size = New System.Drawing.Size(914, 413)
        Me.DgEpisodis.TabIndex = 2
        '
        'Pacient
        '
        Me.Pacient.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Pacient.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Pacient.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pacient.ForeColor = System.Drawing.Color.Gray
        Me.Pacient.Location = New System.Drawing.Point(12, 12)
        Me.Pacient.Name = "Pacient"
        Me.Pacient.ReadOnly = True
        Me.Pacient.Size = New System.Drawing.Size(478, 20)
        Me.Pacient.TabIndex = 3
        Me.Pacient.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(517, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 29)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Modificar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.EpisodisEtiqueta)
        Me.TabControl1.Controls.Add(Me.DadesPacientEtiqueta)
        Me.TabControl1.Controls.Add(Me.InformesEtiqueta)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 117)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(922, 512)
        Me.TabControl1.TabIndex = 5
        '
        'EpisodisEtiqueta
        '
        Me.EpisodisEtiqueta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.EpisodisEtiqueta.Controls.Add(Me.BtnBorrar)
        Me.EpisodisEtiqueta.Controls.Add(Me.DgEpisodis)
        Me.EpisodisEtiqueta.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EpisodisEtiqueta.Location = New System.Drawing.Point(4, 25)
        Me.EpisodisEtiqueta.Name = "EpisodisEtiqueta"
        Me.EpisodisEtiqueta.Padding = New System.Windows.Forms.Padding(3)
        Me.EpisodisEtiqueta.Size = New System.Drawing.Size(914, 483)
        Me.EpisodisEtiqueta.TabIndex = 0
        Me.EpisodisEtiqueta.Text = "Episodis"
        Me.EpisodisEtiqueta.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.Location = New System.Drawing.Point(787, 16)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(124, 28)
        Me.BtnBorrar.TabIndex = 4
        Me.BtnBorrar.Text = "Eliminar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'DadesPacientEtiqueta
        '
        Me.DadesPacientEtiqueta.BackColor = System.Drawing.Color.Beige
        Me.DadesPacientEtiqueta.Controls.Add(Me.ModificarDN)
        Me.DadesPacientEtiqueta.Controls.Add(Me.ModificarDni)
        Me.DadesPacientEtiqueta.Controls.Add(Me.Button1)
        Me.DadesPacientEtiqueta.Controls.Add(Me.MoficarPoblacio)
        Me.DadesPacientEtiqueta.Controls.Add(Me.ModificarCP)
        Me.DadesPacientEtiqueta.Controls.Add(Me.ModificarPorta)
        Me.DadesPacientEtiqueta.Controls.Add(Me.ModificarNumero)
        Me.DadesPacientEtiqueta.Controls.Add(Me.ModificarPis)
        Me.DadesPacientEtiqueta.Controls.Add(Me.ModificarCarrer)
        Me.DadesPacientEtiqueta.Controls.Add(Me.ModificarTipusCarrer)
        Me.DadesPacientEtiqueta.Controls.Add(Me.BtnOK)
        Me.DadesPacientEtiqueta.Controls.Add(Me.ModificarPrimerCognom)
        Me.DadesPacientEtiqueta.Controls.Add(Me.ModificarSegonCognom)
        Me.DadesPacientEtiqueta.Controls.Add(Me.ModificarNom)
        Me.DadesPacientEtiqueta.Controls.Add(Me.Panel1)
        Me.DadesPacientEtiqueta.Controls.Add(Me.DetDni)
        Me.DadesPacientEtiqueta.Controls.Add(Me.DetDn)
        Me.DadesPacientEtiqueta.Controls.Add(Me.DetPoblacio)
        Me.DadesPacientEtiqueta.Controls.Add(Me.DetAdreça)
        Me.DadesPacientEtiqueta.Controls.Add(Me.DetPacient)
        Me.DadesPacientEtiqueta.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DadesPacientEtiqueta.Location = New System.Drawing.Point(4, 25)
        Me.DadesPacientEtiqueta.Name = "DadesPacientEtiqueta"
        Me.DadesPacientEtiqueta.Padding = New System.Windows.Forms.Padding(3)
        Me.DadesPacientEtiqueta.Size = New System.Drawing.Size(914, 483)
        Me.DadesPacientEtiqueta.TabIndex = 1
        Me.DadesPacientEtiqueta.Text = "Dades personals"
        Me.DadesPacientEtiqueta.UseVisualStyleBackColor = True
        '
        'ModificarDN
        '
        Me.ModificarDN.Location = New System.Drawing.Point(491, 205)
        Me.ModificarDN.Name = "ModificarDN"
        Me.ModificarDN.Size = New System.Drawing.Size(109, 24)
        Me.ModificarDN.TabIndex = 27
        Me.ModificarDN.Visible = False
        '
        'ModificarDni
        '
        Me.ModificarDni.Location = New System.Drawing.Point(376, 205)
        Me.ModificarDni.Name = "ModificarDni"
        Me.ModificarDni.Size = New System.Drawing.Size(109, 24)
        Me.ModificarDni.TabIndex = 26
        Me.ModificarDni.Visible = False
        '
        'MoficarPoblacio
        '
        Me.MoficarPoblacio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MoficarPoblacio.Location = New System.Drawing.Point(446, 265)
        Me.MoficarPoblacio.Name = "MoficarPoblacio"
        Me.MoficarPoblacio.Size = New System.Drawing.Size(260, 24)
        Me.MoficarPoblacio.TabIndex = 25
        Me.MoficarPoblacio.Visible = False
        '
        'ModificarCP
        '
        Me.ModificarCP.Location = New System.Drawing.Point(376, 265)
        Me.ModificarCP.Name = "ModificarCP"
        Me.ModificarCP.Size = New System.Drawing.Size(64, 24)
        Me.ModificarCP.TabIndex = 24
        Me.ModificarCP.Visible = False
        '
        'ModificarPorta
        '
        Me.ModificarPorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ModificarPorta.Location = New System.Drawing.Point(844, 235)
        Me.ModificarPorta.Name = "ModificarPorta"
        Me.ModificarPorta.Size = New System.Drawing.Size(60, 24)
        Me.ModificarPorta.TabIndex = 23
        Me.ModificarPorta.Visible = False
        '
        'ModificarNumero
        '
        Me.ModificarNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ModificarNumero.Location = New System.Drawing.Point(712, 235)
        Me.ModificarNumero.Name = "ModificarNumero"
        Me.ModificarNumero.Size = New System.Drawing.Size(60, 24)
        Me.ModificarNumero.TabIndex = 22
        Me.ModificarNumero.Visible = False
        '
        'ModificarPis
        '
        Me.ModificarPis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ModificarPis.Location = New System.Drawing.Point(778, 235)
        Me.ModificarPis.Name = "ModificarPis"
        Me.ModificarPis.Size = New System.Drawing.Size(60, 24)
        Me.ModificarPis.TabIndex = 21
        Me.ModificarPis.Visible = False
        '
        'ModificarCarrer
        '
        Me.ModificarCarrer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ModificarCarrer.Location = New System.Drawing.Point(446, 235)
        Me.ModificarCarrer.Name = "ModificarCarrer"
        Me.ModificarCarrer.Size = New System.Drawing.Size(260, 24)
        Me.ModificarCarrer.TabIndex = 20
        Me.ModificarCarrer.Visible = False
        '
        'ModificarTipusCarrer
        '
        Me.ModificarTipusCarrer.FormattingEnabled = True
        Me.ModificarTipusCarrer.Location = New System.Drawing.Point(376, 235)
        Me.ModificarTipusCarrer.Name = "ModificarTipusCarrer"
        Me.ModificarTipusCarrer.Size = New System.Drawing.Size(64, 24)
        Me.ModificarTipusCarrer.TabIndex = 19
        Me.ModificarTipusCarrer.Visible = False
        '
        'BtnOK
        '
        Me.BtnOK.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.Location = New System.Drawing.Point(712, 322)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(46, 40)
        Me.BtnOK.TabIndex = 18
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        Me.BtnOK.Visible = False
        '
        'ModificarPrimerCognom
        '
        Me.ModificarPrimerCognom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ModificarPrimerCognom.Location = New System.Drawing.Point(544, 175)
        Me.ModificarPrimerCognom.Name = "ModificarPrimerCognom"
        Me.ModificarPrimerCognom.Size = New System.Drawing.Size(162, 24)
        Me.ModificarPrimerCognom.TabIndex = 17
        Me.ModificarPrimerCognom.Visible = False
        '
        'ModificarSegonCognom
        '
        Me.ModificarSegonCognom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ModificarSegonCognom.Location = New System.Drawing.Point(712, 175)
        Me.ModificarSegonCognom.Name = "ModificarSegonCognom"
        Me.ModificarSegonCognom.Size = New System.Drawing.Size(162, 24)
        Me.ModificarSegonCognom.TabIndex = 16
        Me.ModificarSegonCognom.Visible = False
        '
        'ModificarNom
        '
        Me.ModificarNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ModificarNom.Location = New System.Drawing.Point(376, 175)
        Me.ModificarNom.Name = "ModificarNom"
        Me.ModificarNom.Size = New System.Drawing.Size(162, 24)
        Me.ModificarNom.TabIndex = 15
        Me.ModificarNom.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DetAe)
        Me.Panel1.Controls.Add(Me.DetTelMob)
        Me.Panel1.Controls.Add(Me.DetTelFeina)
        Me.Panel1.Controls.Add(Me.DetTelFix)
        Me.Panel1.Location = New System.Drawing.Point(36, 175)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(331, 276)
        Me.Panel1.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(83, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "CONTACTE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Mail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Feina"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Móbil"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Fix"
        '
        'DetAe
        '
        Me.DetAe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetAe.Location = New System.Drawing.Point(28, 228)
        Me.DetAe.Name = "DetAe"
        Me.DetAe.ReadOnly = True
        Me.DetAe.Size = New System.Drawing.Size(273, 17)
        Me.DetAe.TabIndex = 6
        Me.DetAe.TabStop = False
        '
        'DetTelMob
        '
        Me.DetTelMob.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetTelMob.Location = New System.Drawing.Point(28, 119)
        Me.DetTelMob.Name = "DetTelMob"
        Me.DetTelMob.ReadOnly = True
        Me.DetTelMob.Size = New System.Drawing.Size(142, 17)
        Me.DetTelMob.TabIndex = 5
        Me.DetTelMob.TabStop = False
        '
        'DetTelFeina
        '
        Me.DetTelFeina.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetTelFeina.Location = New System.Drawing.Point(28, 166)
        Me.DetTelFeina.Name = "DetTelFeina"
        Me.DetTelFeina.ReadOnly = True
        Me.DetTelFeina.Size = New System.Drawing.Size(142, 17)
        Me.DetTelFeina.TabIndex = 4
        Me.DetTelFeina.TabStop = False
        '
        'DetTelFix
        '
        Me.DetTelFix.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetTelFix.Location = New System.Drawing.Point(28, 72)
        Me.DetTelFix.Name = "DetTelFix"
        Me.DetTelFix.ReadOnly = True
        Me.DetTelFix.Size = New System.Drawing.Size(142, 17)
        Me.DetTelFix.TabIndex = 3
        Me.DetTelFix.TabStop = False
        '
        'DetDni
        '
        Me.DetDni.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetDni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DetDni.HideSelection = False
        Me.DetDni.Location = New System.Drawing.Point(315, 42)
        Me.DetDni.Name = "DetDni"
        Me.DetDni.ReadOnly = True
        Me.DetDni.Size = New System.Drawing.Size(142, 17)
        Me.DetDni.TabIndex = 8
        Me.DetDni.TabStop = False
        '
        'DetDn
        '
        Me.DetDn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetDn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DetDn.HideSelection = False
        Me.DetDn.Location = New System.Drawing.Point(315, 72)
        Me.DetDn.Name = "DetDn"
        Me.DetDn.ReadOnly = True
        Me.DetDn.Size = New System.Drawing.Size(142, 17)
        Me.DetDn.TabIndex = 7
        Me.DetDn.TabStop = False
        '
        'DetPoblacio
        '
        Me.DetPoblacio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetPoblacio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DetPoblacio.Location = New System.Drawing.Point(36, 102)
        Me.DetPoblacio.Name = "DetPoblacio"
        Me.DetPoblacio.ReadOnly = True
        Me.DetPoblacio.Size = New System.Drawing.Size(273, 17)
        Me.DetPoblacio.TabIndex = 2
        Me.DetPoblacio.TabStop = False
        '
        'DetAdreça
        '
        Me.DetAdreça.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetAdreça.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DetAdreça.Location = New System.Drawing.Point(36, 72)
        Me.DetAdreça.Name = "DetAdreça"
        Me.DetAdreça.ReadOnly = True
        Me.DetAdreça.Size = New System.Drawing.Size(273, 17)
        Me.DetAdreça.TabIndex = 1
        Me.DetAdreça.TabStop = False
        '
        'DetPacient
        '
        Me.DetPacient.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetPacient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DetPacient.Location = New System.Drawing.Point(36, 42)
        Me.DetPacient.Name = "DetPacient"
        Me.DetPacient.ReadOnly = True
        Me.DetPacient.Size = New System.Drawing.Size(273, 17)
        Me.DetPacient.TabIndex = 0
        Me.DetPacient.TabStop = False
        '
        'InformesEtiqueta
        '
        Me.InformesEtiqueta.BackColor = System.Drawing.Color.Beige
        Me.InformesEtiqueta.Controls.Add(Me.DgInformes)
        Me.InformesEtiqueta.Location = New System.Drawing.Point(4, 25)
        Me.InformesEtiqueta.Name = "InformesEtiqueta"
        Me.InformesEtiqueta.Size = New System.Drawing.Size(914, 483)
        Me.InformesEtiqueta.TabIndex = 2
        Me.InformesEtiqueta.Text = "Informes"
        '
        'DgInformes
        '
        Me.DgInformes.BackgroundColor = System.Drawing.Color.Beige
        Me.DgInformes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgInformes.Location = New System.Drawing.Point(0, 70)
        Me.DgInformes.Name = "DgInformes"
        Me.DgInformes.Size = New System.Drawing.Size(914, 413)
        Me.DgInformes.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(821, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 38)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "SORTIR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Edat
        '
        Me.Edat.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Edat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Edat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Edat.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edat.ForeColor = System.Drawing.Color.Gray
        Me.Edat.HideSelection = False
        Me.Edat.Location = New System.Drawing.Point(12, 38)
        Me.Edat.Name = "Edat"
        Me.Edat.ReadOnly = True
        Me.Edat.Size = New System.Drawing.Size(65, 20)
        Me.Edat.TabIndex = 28
        Me.Edat.TabStop = False
        '
        'TtipusCarrerBindingSource
        '
        Me.TtipusCarrerBindingSource.DataMember = "TtipusCarrer"
        '
        'Episodis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(947, 641)
        Me.Controls.Add(Me.Edat)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Pacient)
        Me.Name = "Episodis"
        Me.Text = "DETALL PACIENT"
        CType(Me.DgEpisodis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.EpisodisEtiqueta.ResumeLayout(False)
        Me.DadesPacientEtiqueta.ResumeLayout(False)
        Me.DadesPacientEtiqueta.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.InformesEtiqueta.ResumeLayout(False)
        CType(Me.DgInformes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TtipusCarrerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgEpisodis As System.Windows.Forms.DataGridView
    Friend WithEvents Pacient As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents EpisodisEtiqueta As System.Windows.Forms.TabPage
    Friend WithEvents DadesPacientEtiqueta As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DetPoblacio As System.Windows.Forms.TextBox
    Friend WithEvents DetAdreça As System.Windows.Forms.TextBox
    Friend WithEvents DetPacient As System.Windows.Forms.TextBox
    Friend WithEvents DetTelMob As System.Windows.Forms.TextBox
    Friend WithEvents DetTelFeina As System.Windows.Forms.TextBox
    Friend WithEvents DetTelFix As System.Windows.Forms.TextBox
    Friend WithEvents DetAe As System.Windows.Forms.TextBox
    Friend WithEvents DetDni As System.Windows.Forms.TextBox
    Friend WithEvents DetDn As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ModificarPrimerCognom As System.Windows.Forms.TextBox
    Friend WithEvents ModificarSegonCognom As System.Windows.Forms.TextBox
    Friend WithEvents ModificarNom As System.Windows.Forms.TextBox
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents ModificarTipusCarrer As System.Windows.Forms.ComboBox
    Friend WithEvents TtipusCarrerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModificarNumero As System.Windows.Forms.TextBox
    Friend WithEvents ModificarPis As System.Windows.Forms.TextBox
    Friend WithEvents ModificarCarrer As System.Windows.Forms.TextBox
    Friend WithEvents ModificarDni As System.Windows.Forms.TextBox
    Friend WithEvents MoficarPoblacio As System.Windows.Forms.TextBox
    Friend WithEvents ModificarCP As System.Windows.Forms.TextBox
    Friend WithEvents ModificarPorta As System.Windows.Forms.TextBox
    Friend WithEvents ModificarDN As System.Windows.Forms.TextBox
    Friend WithEvents Edat As System.Windows.Forms.TextBox
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents InformesEtiqueta As System.Windows.Forms.TabPage
    Friend WithEvents DgInformes As System.Windows.Forms.DataGridView
End Class
