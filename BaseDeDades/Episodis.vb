Public Class Episodis
    Private BorrarMutua As String
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection

    'MENU
    Private MenuEpisodis As MenuItem

    WithEvents SubMenuNouEpisodi As MenuItem
    Private EvSubMenuNouEpisodi As System.EventHandler

    Private MenuInformes As MenuItem

    WithEvents SubMenuNouInforme As MenuItem
    Private EvSubMenuNouInforme As System.EventHandler

    Private Sub Episodis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarEpisodis()
        CarregarInformes()
        Me.Text = "DETALL PACIENT" + " " + StrOrigenDeDades

        MenuEpisodis = New MenuItem
        MenuEpisodis.Text = "Episodis"

        SubMenuNouEpisodi = New MenuItem
        SubMenuNouEpisodi.Text = "Nou episodi"
        AddHandler SubMenuNouEpisodi.Click, EvSubMenuNouEpisodi

        MenuInformes = New MenuItem
        MenuInformes.Text = "Informes"

        SubMenuNouInforme = New MenuItem
        SubMenuNouInforme.Text = "Nou informe"
        AddHandler SubMenuNouInforme.Click, EvSubMenuNouInforme

        MenuEpisodis.MenuItems.AddRange(New MenuItem() {SubMenuNouEpisodi})
        MenuInformes.MenuItems.AddRange(New MenuItem() {SubMenuNouInforme})

        Me.Menu = New MainMenu
        Me.Menu.MenuItems.Add(MenuEpisodis)
        Me.Menu.MenuItems.Add(MenuInformes)

    End Sub
    Private Sub Episodis_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        CarregarEpisodis()
        CarregarInformes()
        Me.ControlBox = False
        Me.StartPosition = FormStartPosition.CenterParent
    End Sub
    Private Sub CarregarInformes()

        StrCadenaConexio = ""

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT Informes.IdInforme, Informes.IdPacient, Informes.Data, Informes.Titol, Terapeutes.Terapeuta FROM Informes INNER JOIN Terapeutes ON" _
        + " Informes.NumColegiat = Terapeutes.NumColegiat WHERE IdPacient=" + StrIdPacient + " ORDER BY Informes.Data; "

        Try

            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)

            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Informes")
            oConexion.Close()

            Me.DgInformes.DataSource = oDataSet
            Me.DgInformes.DataMember = "Informes"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ConfiguarDgInformes()
    End Sub
    Private Sub ConfiguarDgInformes()
        With Me.DgInformes
            'COLOR
            .RowsDefaultCellStyle.BackColor = Color.Beige
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua

            'Només lectura i no es poden afegir registres
            .ReadOnly = True
            .AllowUserToAddRows = False

            'Columnes no visibles
            .Columns.Item(0).Visible = False
            .Columns.Item(1).Visible = False
            .RowHeadersVisible = False

            'Mides
            .Columns.Item(2).Width = CInt(Me.DgInformes.Width * 0.12)
            .Columns.Item(3).Width = CInt(Me.DgInformes.Width * 0.525)
            .Columns.Item(4).Width = CInt(Me.DgInformes.Width * 0.35)

            'Títols de columna
            .Columns.Item(2).HeaderText = "Data"
            .Columns.Item(3).HeaderText = "Informe"
            .Columns.Item(4).HeaderText = "Terapeuta"

            .Columns.Item(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter

            'No es poden canviar les mides de les files i columnes
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False

        End With

    End Sub
    Private Sub CarregarEpisodis()
        'StrIdEpisodi = ""
        StrInstruccioSQL = ""
        StrCadenaConexio = ""

        Me.ControlBox = False

        Dim oConexion As New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        Dim StrNom As String
        Dim StrAdresa As String

        StrNom = "DadesPacient.Nom & " + """ """ + "& DadesPacient.PrimerCognom &" + """ """ + "& DadesPacient.SegonCognom"
        StrAdresa = "TipusCarrer.TipusCarrer & " + """ """ + "& DadesPacient.Carrer &" + """, """ + "& DadesPacient.Numero &" + """ """ + "& DadesPacient.Pis &" + """ """ + "& DadesPacient.Porta"
        StrInstruccioSQL = "SELECT DadesPacient.IdPacient, DadesPacient.Dni," + StrNom + " AS Pacient," + StrAdresa + " AS Adreça, DadesPacient.CodiPostal &" + """ """ + "& DadesPacient.Poblacio AS Poblacio, DadesPacient.TelFix, DadesPacient.TelMob, DadesPacient.TelFeina, DadesPacient.DN, DadesPacient.CI, DadesPacient.AE" _
           + " FROM DadesPacient INNER JOIN TipusCarrer ON DadesPacient.TipusCarrer = TipusCarrer.IdCarrer" _
           + " WHERE DadesPacient.IdPacient=" + StrIdPacient + ";"

        Try
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)

            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "DadesPacient")
            oConexion.Close()

            Dim iPosicionActual As Integer
            iPosicionActual = 0
            Dim oDataRow As DataRow
            oDataRow = oDataSet.Tables("DadesPacient").Rows(iPosicionActual)

            If VarType(oDataRow("Pacient")) <> VariantType.Null Then
                Me.DetPacient.Text = oDataRow("Pacient")
                Me.Pacient.Text = oDataRow("Pacient")
            Else
            End If

            If VarType(oDataRow("Adreça")) <> VariantType.Null Then
                Me.DetAdreça.Text = oDataRow("Adreça")

            Else
            End If

            If VarType(oDataRow("dni")) <> VariantType.Null Then
                Me.DetDni.Text = oDataRow("Dni")
            Else
            End If

            If VarType(oDataRow("TelFix")) <> VariantType.Null Then
                Me.DetTelFix.Text = oDataRow("TelFix")
            Else
            End If

            If VarType(oDataRow("TelMob")) <> VariantType.Null Then
                Me.DetTelMob.Text = oDataRow("TelMob")
            Else
            End If

            If VarType(oDataRow("TelFeina")) <> VariantType.Null Then
                Me.DetTelFeina.Text = oDataRow("TelFeina")
            Else
            End If

            If VarType(oDataRow("DN")) <> VariantType.Null Then
                Me.DetDn.Text = oDataRow("DN")

                Dim DobEdad As Double

                DobEdad = DateDiff(DateInterval.Year, CDate(Me.DetDn.Text), Now)

                Me.Edat.Text = CStr(DobEdad) + " Anys"

            Else
            End If

            If VarType(oDataRow("Poblacio")) <> VariantType.Null Then
                Me.DetPoblacio.Text = oDataRow("Poblacio")
            Else
            End If

            If VarType(oDataRow("AE")) <> VariantType.Null Then
                Me.DetAe.Text = oDataRow("AE")
            Else
            End If

            Me.TabControl1.TabPages(1).BackColor = Color.Beige
            Me.TabControl1.TabPages(0).BackColor = Color.Beige

            Me.DetTelFix.BackColor = Color.Beige
            Me.DetTelMob.BackColor = Color.Beige
            Me.DetTelFeina.BackColor = Color.Beige
            Me.DetAe.BackColor = Color.Beige
            Me.DetPacient.BackColor = Color.Beige
            Me.DetAdreça.BackColor = Color.Beige
            Me.DetDn.BackColor = Color.Beige
            Me.DetPoblacio.BackColor = Color.Beige
            Me.DetDni.BackColor = Color.Beige

        Catch ex As Exception

            MsgBox(ex.Message)
        End Try

        StrInstruccioSQL = "SELECT Episodis.* FROM Episodis WHERE IdPacient=" + StrIdPacient _
        + " ORDER BY Episodis.DataInici DESC;"

        Try
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Episodis")
            oConexion.Close()

            Me.DgEpisodis.DataSource = oDataSet
            Me.DgEpisodis.DataMember = "Episodis"

            Me.Pacient.Enabled = True

            ConfigurarDgEpisodis()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FormatCondicional(ByVal Sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DgEpisodis.CellFormatting

        'Alta Sí, factura No
        If DgEpisodis.Rows(e.RowIndex).Cells("Alta").Value = True _
             And DgEpisodis.Rows(e.RowIndex).Cells("Factura").Value = False Then

            DgEpisodis.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red

            'Alta Sí, factura Sí
        ElseIf DgEpisodis.Rows(e.RowIndex).Cells("Alta").Value = True _
                    And DgEpisodis.Rows(e.RowIndex).Cells("Factura").Value = True Then

            DgEpisodis.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Gray

            'Alta No, factura Sí
        ElseIf DgEpisodis.Rows(e.RowIndex).Cells("Alta").Value = False _
        And DgEpisodis.Rows(e.RowIndex).Cells("Factura").Value = True Then

            DgEpisodis.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Green

            'Alta No, factura No
        ElseIf DgEpisodis.Rows(e.RowIndex).Cells("Alta").Value = False _
                And DgEpisodis.Rows(e.RowIndex).Cells("Factura").Value = False Then

            DgEpisodis.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Beige

        End If
    End Sub
    Private Sub ConfigurarDgEpisodis()

        With Me.DgEpisodis
            'COLOR
            .RowsDefaultCellStyle.BackColor = Color.Beige
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua

            'Només lectura i no es poden afegir registres
            .ReadOnly = True
            .AllowUserToAddRows = False

            'Número de decimals a la columna de preu
            .Columns.Item(10).DefaultCellStyle.Format = "C2"

            'Columnes no visibles
            .Columns.Item(0).Visible = False
            .Columns.Item(1).Visible = False
            .Columns.Item(3).Visible = False
            .Columns.Item(10).Visible = False
            .RowHeadersVisible = False

            'Mides
            .Columns.Item(2).Width = CInt(Me.DgEpisodis.Width * 0.4)
            .Columns.Item(4).Width = CInt(Me.DgEpisodis.Width * 0.15)
            .Columns.Item(5).Width = CInt(Me.DgEpisodis.Width * 0.08)
            .Columns.Item(8).Width = CInt(Me.DgEpisodis.Width * 0.073)
            .Columns.Item(9).Width = CInt(Me.DgEpisodis.Width * 0.073)

            'Títols de columna
            .Columns.Item(4).HeaderText = "Autorització"
            .Columns.Item(5).HeaderText = "Sessions"
            .Columns.Item(6).HeaderText = "Inici"
            .Columns.Item(7).HeaderText = "Fi"

            .Columns.Item(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter

        End With

    End Sub
    Private Sub BtnSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If Me.ModificarNom.Visible = True Then

            Dim i As Integer

            i = MsgBox("GUARDAR CANVIS?", 52, "Fisiomèdic")
            If i = vbYes Then

                GuardarCanvis()

            Else

                Me.ModificarNom.Visible = False
                Me.ModificarPrimerCognom.Visible = False
                Me.ModificarSegonCognom.Visible = False
                Me.ModificarDni.Visible = False
                Me.ModificarDN.Visible = False
                Me.ModificarTipusCarrer.Visible = False
                Me.ModificarCarrer.Visible = False
                Me.ModificarCP.Visible = False
                Me.MoficarPoblacio.Visible = False
                Me.ModificarNumero.Visible = False
                Me.ModificarPis.Visible = False
                Me.ModificarPorta.Visible = False

                Me.BtnOK.Visible = False
                Me.Button1.Visible = True

                Me.DetTelFix.ReadOnly = True
                Me.DetTelMob.ReadOnly = True
                Me.DetTelFeina.ReadOnly = True
                Me.DetAe.ReadOnly = True

                Me.DetTelFix.BackColor = Color.Beige
                Me.DetTelMob.BackColor = Color.Beige
                Me.DetTelFeina.BackColor = Color.Beige
                Me.DetAe.BackColor = Color.Beige

                Me.DetTelFix.BorderStyle = BorderStyle.None
                Me.DetTelMob.BorderStyle = BorderStyle.None
                Me.DetTelFeina.BorderStyle = BorderStyle.None
                Me.DetAe.BorderStyle = BorderStyle.None

            End If
        End If
        Me.Close()
    End Sub
    Private Sub BtnModificarDadesPersonals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        StrInstruccioSQL = ""
        StrCadenaConexio = ""


        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = "SELECT DadesPacient.IdPacient, DadesPacient.Dni, DadesPacient.Nom," _
            + " DadesPacient.PrimerCognom,DadesPacient.SegonCognom, TipusCarrer.TipusCarrer, DadesPacient.Carrer," _
            + " DadesPacient.Numero, DadesPacient.Pis," _
            + " DadesPacient.Porta, DadesPacient.CodiPostal, DadesPacient.Poblacio, DadesPacient.DN" _
            + " FROM DadesPacient INNER JOIN TipusCarrer ON DadesPacient.TipusCarrer = TipusCarrer.IdCarrer" _
            + " WHERE DadesPacient.IdPacient=" + StrIdPacient + ";"

        'Creo i dono valor a la instruccio SQL que farà falta per poder modificar el tipus carrer

        Dim StrInstruccioSQLtp As String
        StrInstruccioSQLtp = "SELECT TipusCarrer.* FROM TipusCarrer;"

        Try
            Dim oDataAdapterTp As New OleDb.OleDbDataAdapter(StrInstruccioSQLtp, oConexion)
            Dim oCbTp As OleDb.OleDbCommandBuilder = New OleDb.OleDbCommandBuilder(oDataAdapterTp)
            Dim oDataSetTp As New DataSet()

            oConexion.Open()
            oDataAdapterTp.Fill(oDataSetTp, "TipusCarrer")
            oConexion.Close()

            Me.ModificarTipusCarrer.DataSource = oDataSetTp.Tables("TipusCarrer")
            Me.ModificarTipusCarrer.DisplayMember = "TipusCarrer"
            Me.ModificarTipusCarrer.ValueMember = "TipusCarrer"

            Me.ModificarTipusCarrer.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.ModificarTipusCarrer.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Try
            Dim oDataAdapterDadesPacient = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapterDadesPacient)

            oDataSet = Nothing
            oDataSet = New DataSet()

            Me.ModificarNom.Visible = True
            Me.ModificarPrimerCognom.Visible = True
            Me.ModificarSegonCognom.Visible = True
            Me.ModificarDni.Visible = True
            Me.ModificarDN.Visible = True
            Me.ModificarTipusCarrer.Visible = True
            Me.ModificarCarrer.Visible = True
            Me.ModificarCP.Visible = True
            Me.MoficarPoblacio.Visible = True
            Me.ModificarNumero.Visible = True
            Me.ModificarPis.Visible = True
            Me.ModificarPorta.Visible = True

            Me.BtnOK.Visible = True

            Me.DetTelFix.ReadOnly = False
            Me.DetTelMob.ReadOnly = False
            Me.DetTelFeina.ReadOnly = False
            Me.DetAe.ReadOnly = False

            Me.DetTelFix.BackColor = Color.White
            Me.DetTelMob.BackColor = Color.White
            Me.DetTelFeina.BackColor = Color.White
            Me.DetAe.BackColor = Color.White

            Me.DetTelFix.BorderStyle = BorderStyle.Fixed3D
            Me.DetTelMob.BorderStyle = BorderStyle.Fixed3D
            Me.DetTelFeina.BorderStyle = BorderStyle.Fixed3D
            Me.DetAe.BorderStyle = BorderStyle.Fixed3D

            Me.Button1.Visible = False
            Me.Button2.Visible = False

            oConexion.Open()
            oDataAdapterDadesPacient.Fill(oDataSet, "DadesPacient")
            oConexion.Close()

            Dim iPosicionActual As Integer
            iPosicionActual = 0
            Dim oDataRow As DataRow
            oDataRow = oDataSet.Tables("DadesPacient").Rows(iPosicionActual)

            If VarType(oDataRow("Nom")) <> VariantType.Null Then
                Me.ModificarNom.Text = oDataRow("Nom")
            Else
            End If

            If VarType(oDataRow("PrimerCognom")) <> VariantType.Null Then
                Me.ModificarPrimerCognom.Text = oDataRow("PrimerCognom")
            Else
            End If

            If VarType(oDataRow("SegonCognom")) <> VariantType.Null Then
                Me.ModificarSegonCognom.Text = oDataRow("SegonCognom")
            Else
            End If

            If VarType(oDataRow("Dni")) <> VariantType.Null Then
                Me.ModificarDni.Text = oDataRow("Dni")

            End If

            If VarType(oDataRow("TipusCarrer")) <> VariantType.Null Then
                Me.ModificarTipusCarrer.Text = oDataRow("TipusCarrer")

            End If

            If VarType(oDataRow("Carrer")) <> VariantType.Null Then
                Me.ModificarCarrer.Text = oDataRow("Carrer")

            End If

            If VarType(oDataRow("Numero")) <> VariantType.Null Then
                Me.ModificarNumero.Text = oDataRow("Numero")

            End If

            If VarType(oDataRow("Pis")) <> VariantType.Null Then
                Me.ModificarPis.Text = oDataRow("Pis")

            End If

            If VarType(oDataRow("Porta")) <> VariantType.Null Then
                Me.ModificarPorta.Text = oDataRow("Porta")

            End If

            If VarType(oDataRow("CodiPostal")) <> VariantType.Null Then
                Me.ModificarCP.Text = oDataRow("CodiPostal")

            End If

            If VarType(oDataRow("Poblacio")) <> VariantType.Null Then
                Me.MoficarPoblacio.Text = oDataRow("Poblacio")

            End If

            If VarType(oDataRow("DN")) <> VariantType.Null Then
                Me.ModificarDN.Text = oDataRow("DN")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        GuardarCanvis()
        Me.Button2.Visible = True
    End Sub
    Private Sub GuardarCanvis()

        Dim StrValorTC As String

        StrInstruccioSQL = ""
        StrCadenaConexio = ""


        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        Dim StrInstruccioSQLtp As String
        StrInstruccioSQLtp = "SELECT TipusCarrer.* FROM TipusCarrer WHERE TipusCarrer.TipusCarrer=""" + Me.ModificarTipusCarrer.Text + """;"

        Try
            Dim oDataAdapterTp As New OleDb.OleDbDataAdapter(StrInstruccioSQLtp, oConexion)
            Dim oCbTp As OleDb.OleDbCommandBuilder = New OleDb.OleDbCommandBuilder(oDataAdapterTp)
            Dim oDataSetTp As New DataSet()

            oConexion.Open()
            oDataAdapterTp.Fill(oDataSetTp, "TipusCarrer")
            oConexion.Close()

            Dim iPosicionActual As Integer

            iPosicionActual = 0

            Dim oDataRow As DataRow

            oDataRow = oDataSetTp.Tables("TipusCarrer").Rows(iPosicionActual)

            StrValorTC = oDataRow("IdCarrer")

            StrInstruccioSQL = ""

            StrInstruccioSQL = "UPDATE DadesPacient SET DadesPacient.Dni = """ + Me.ModificarDni.Text _
            + """, DadesPacient.Nom = """ + Me.ModificarNom.Text + """, DadesPacient.PrimerCognom = """ + Me.ModificarPrimerCognom.Text _
            + """, DadesPacient.SegonCognom = """ + Me.ModificarSegonCognom.Text _
            + """, DadesPacient.TipusCarrer = " + StrValorTC + ", DadesPacient.Carrer = """ + Me.ModificarCarrer.Text _
            + """, DadesPacient.Numero = """ + Me.ModificarNumero.Text + """, DadesPacient.Pis = """ + Me.ModificarPis.Text _
            + """, DadesPacient.Porta = """ + Me.ModificarPorta.Text + """, DadesPacient.CodiPostal = """ + Me.ModificarCP.Text _
            + """, DadesPacient.Poblacio = """ + Me.MoficarPoblacio.Text + """, DadesPacient.TelFix = """ + Me.DetTelFix.Text _
            + """, DadesPacient.TelMob = """ + Me.DetTelMob.Text + """, DadesPacient.TelFeina = """ + Me.DetTelFeina.Text _
            + """, DadesPacient.DN = '" + Me.ModificarDN.Text + "', DadesPacient.AE = """ + Me.DetAe.Text _
            + """ WHERE DadesPacient.IdPacient=" + StrIdPacient + ";"


            ExecutarSql(StrInstruccioSQL)

            Me.ModificarNom.Visible = False
            Me.ModificarPrimerCognom.Visible = False
            Me.ModificarSegonCognom.Visible = False
            Me.ModificarDni.Visible = False
            Me.ModificarDN.Visible = False
            Me.ModificarTipusCarrer.Visible = False
            Me.ModificarCarrer.Visible = False
            Me.ModificarCP.Visible = False
            Me.MoficarPoblacio.Visible = False
            Me.ModificarNumero.Visible = False
            Me.ModificarPis.Visible = False
            Me.ModificarPorta.Visible = False

            Me.BtnOK.Visible = False
            Me.Button1.Visible = True

            Me.DetTelFix.ReadOnly = True
            Me.DetTelMob.ReadOnly = True
            Me.DetTelFeina.ReadOnly = True
            Me.DetAe.ReadOnly = True

            Me.DetTelFix.BackColor = Color.Beige
            Me.DetTelMob.BackColor = Color.Beige
            Me.DetTelFeina.BackColor = Color.Beige
            Me.DetAe.BackColor = Color.Beige

            Me.DetTelFix.BorderStyle = BorderStyle.None
            Me.DetTelMob.BorderStyle = BorderStyle.None
            Me.DetTelFeina.BorderStyle = BorderStyle.None
            Me.DetAe.BorderStyle = BorderStyle.None

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CarregarEpisodis()
    End Sub
    Private Sub DgEpisodis_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgEpisodis.CellContentDoubleClick

        StrIdEpisodi = ""
        StrIdEpisodi = Me.DgEpisodis.Rows(e.RowIndex).Cells(1).Value
        If Me.DgEpisodis.Rows(e.RowIndex).Cells(2).Value() = "RECONEIXEMENT MÈDIC" Then
            StrIdEpisodi = Me.DgEpisodis.Rows(e.RowIndex).Cells(1).Value

            ReconeixementMedic.ShowDialog()
        Else
            DetallEpisodi.ShowDialog()
        End If


    End Sub
    Private Sub CrearNouEpisodi(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuNouEpisodi.Click
        Dim Formulari As New NouEpisodi()
        Formulari.ShowDialog()
    End Sub
    Private Sub DgEpisodis_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgEpisodis.CellContentClick
        StrIdEpisodi = Me.DgEpisodis.Rows(e.RowIndex).Cells(1).Value
        BorrarMutua = Me.DgEpisodis.Rows(e.RowIndex).Cells(2).Value
        'BorrarMutua = "RECONEIXEMENT MÈDIC"
    End Sub
    Private Sub BtnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrar.Click

        If StrIdEpisodi = "" Then
            MsgBox("Selecciona un episodi", , "Fisiomèdic")
            Exit Sub
        End If

        Dim i As Integer
        i = MsgBox("Estas segur que vols eliminar l'episodi i l'assistència", MsgBoxStyle.YesNo, "Fisiomèdic")

        If i = vbNo Then
            Exit Sub

        Else

            If BorrarMutua = "RECONEIXEMENT MÈDIC" Then
                StrInstruccioSQL = ""

                StrInstruccioSQL = "DELETE Antropometria.*, Ebm.*, Estabilometria.*, Exploracio.*, ExploracioPostural.*, Proves.*, Reconeixements.*, RecoObservacions.*, ErgoInforme.*, Antropometria.IdReco, Ebm.IdReco, Estabilometria.IdReco, Exploracio.IdReco, ExploracioPostural.IdReco, Proves.IdReco, Reconeixements.IdReco, RecoObservacions.IdReco, ErgoInforme.IdReco" _
                + " FROM (((((((Antropometria INNER JOIN Ebm ON Antropometria.IdReco = Ebm.IdReco) INNER JOIN Estabilometria ON Antropometria.IdReco = Estabilometria.IdReco) INNER JOIN Exploracio ON Antropometria.IdReco = Exploracio.IdReco) INNER JOIN ExploracioPostural ON Antropometria.IdReco = ExploracioPostural.IdReco) INNER JOIN Proves ON Antropometria.IdReco = Proves.IdReco) INNER JOIN Reconeixements ON Antropometria.IdReco = Reconeixements.IdReco) INNER JOIN RecoObservacions ON Antropometria.IdReco = RecoObservacions.IdReco) INNER JOIN ErgoInforme ON Antropometria.IdReco = ErgoInforme.IdReco" _
                + " WHERE (((Antropometria.IdReco)=" + StrIdEpisodi + ") AND ((Ebm.IdReco)=" + StrIdEpisodi + ") AND ((Estabilometria.IdReco)=" + StrIdEpisodi + ") AND ((Exploracio.IdReco)=" + StrIdEpisodi + ") AND ((ExploracioPostural.IdReco)=" + StrIdEpisodi + ") AND ((Proves.IdReco)=" + StrIdEpisodi + ") AND ((Reconeixements.IdReco)=" + StrIdEpisodi + ") AND ((RecoObservacions.IdReco)=" + StrIdEpisodi + ") AND ((ErgoInforme.IdReco)=" + StrIdEpisodi + "));"
                ExecutarSql(StrInstruccioSQL)

                StrInstruccioSQL = ""
                StrInstruccioSQL = "DELETE Ergometria.* FROM Ergometria WHERE Ergometria.IdReco=" + StrIdEpisodi + ";"
                ExecutarSql(StrInstruccioSQL)

            End If
            StrInstruccioSQL = "DELETE Assistencia.* FROM Assistencia WHERE Assistencia.IdEpisodi =" + StrIdEpisodi + ";"
            ExecutarSql(StrInstruccioSQL)

            StrInstruccioSQL = "DELETE Episodis.* FROM Episodis WHERE Episodis.IdEpisodi=" + StrIdEpisodi + ";"
            ExecutarSql(StrInstruccioSQL)

            End If
            CarregarEpisodis()
    End Sub
    Private Sub DgInformes_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgInformes.CellContentDoubleClick
        StrIdInforme = Me.DgInformes.Rows(e.RowIndex).Cells(0).Value()

        Dim Formulari As New DetallInforme()
        Formulari.Show()
    End Sub
    Private Sub CrearNouInforme(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuNouInforme.Click
        Dim Formulari As New NouInforme
        Formulari.Show()
    End Sub
    Private Sub ModificarDni_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarDni.Leave
        If Me.ModificarDni.Text = "" Then
            Exit Sub
        Else
            Dim Validacio As Integer = 2
            Validacio = ValidacioDni(Me.ModificarDni.Text)
            If Validacio = 1 Then
                MsgBox("Aquest número no pertany a un DNI", , "Fisiomèdic")
                Me.ModificarDni.Focus()
                Exit Sub
            ElseIf Validacio = 0 Then
                Exit Sub
            Else
                MsgBox("Error en la validació del DNI" + Chr(13) + "posa't en contacte amb l'administrador", , "Fisiomèdic")
            End If
        End If
    End Sub
End Class