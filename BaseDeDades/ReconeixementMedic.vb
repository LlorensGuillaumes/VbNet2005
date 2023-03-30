Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Text
Public Class ReconeixementMedic

    Friend StrECG As String
    Friend StrValoracio As String
    Friend StrMinutProva As String
    Friend StrTa As String
    Friend StrSpO2 As String
    Friend StrFc As String
    Friend StrObservacions As String

    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection
    Private oDataRow As DataRow
    Private iPosicionActual As Integer
    Private oDataAdapter As OleDb.OleDbDataAdapter

    'MENÚ
    Private MenuImprimir As MenuItem
    Private SubMenuEcg As MenuItem
    Private SubMenuAptitut As MenuItem

    WithEvents SubMenuDocuments As MenuItem
    Private EvSubMenuDocuments As System.EventHandler

    WithEvents SubMenuReconeixement As MenuItem
    Private EvSubMenuReconeixement As System.EventHandler

    WithEvents SubMenuNoOk As MenuItem
    Private EvSubMenuNoOk As System.EventHandler

    WithEvents SubMenuOk As MenuItem
    Private EvSubMenuOk As System.EventHandler

    WithEvents SubMenuEcgRepos As MenuItem
    Private EvSubMenuEcgRepos As System.EventHandler

    WithEvents SubMenuEcgErgo As MenuItem
    Private EvSubMenuEcgErgo As System.EventHandler

    Private Sub ReconeixementMedic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        CarregarDades()
        CarregarHerramientas()
        Me.ControlBox = False
        Me.Text = "RECONEIXEMENT MÈDIC" + " " + StrOrigenDeDades
        Dim pantalla() As Screen
        pantalla = Screen.AllScreens
        If pantalla.Length = 1 Then
            Me.BtnIntroEcg.Visible = False
        ElseIf pantalla.Length = 2 Then
            Me.BtnIntroEcg.Visible = True
        Else
            MsgBox("Existeixen masses pantalles instal·lades i pot donar error en la gravació d'ECGs", , "Fisiomèdic")
            Me.BtnIntroEcg.Visible = False
        End If
    End Sub
    Private Sub CarregarHerramientas()

        MenuImprimir = New MenuItem
        MenuImprimir.Text = "Imprimir"

        SubMenuEcg = New MenuItem
        SubMenuEcg.Text = "ECG"

        SubMenuAptitut = New MenuItem
        SubMenuAptitut.Text = "Aptitut"

        SubMenuDocuments = New MenuItem
        SubMenuDocuments.Text = "LOPD"
        AddHandler SubMenuDocuments.Click, EvSubMenuDocuments

        SubMenuReconeixement = New MenuItem
        SubMenuReconeixement.Text = "Reconeixement mèdic"
        AddHandler SubMenuReconeixement.Click, EvSubMenuReconeixement

        SubMenuNoOk = New MenuItem
        SubMenuNoOk.Text = "No apte"
        AddHandler SubMenuNoOk.Click, EvSubMenuNoOk

        SubMenuOk = New MenuItem
        SubMenuOk.Text = "Apte"
        AddHandler SubMenuOk.Click, EvSubMenuOk

        SubMenuEcgErgo = New MenuItem
        SubMenuEcgErgo.Text = "Ergometria"
        AddHandler SubMenuEcgErgo.Click, EvSubMenuEcgErgo

        SubMenuEcgRepos = New MenuItem
        SubMenuEcgRepos.Text = "Repòs"
        AddHandler SubMenuEcgRepos.Click, EvSubMenuEcgRepos

        SubMenuEcg.MenuItems.AddRange(New MenuItem() {SubMenuEcgRepos, SubMenuEcgErgo})
        SubMenuAptitut.MenuItems.AddRange(New MenuItem() {SubMenuOk, SubMenuNoOk})

        MenuImprimir.MenuItems.AddRange(New MenuItem() {SubMenuReconeixement, SubMenuEcg, SubMenuDocuments, SubMenuAptitut})

        Me.Menu = New MainMenu
        Me.Menu.MenuItems.Add(MenuImprimir)

    End Sub
    Private Sub ImprimirEcgRepos(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuEcgRepos.Click
        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT EcgRepos.ECG AS RegistgreEcg FROM EcgRepos WHERE EcgRepos.IdReco=" + StrIdEpisodi + ";"
        ImprimirEcg.ShowDialog()
    End Sub
    Private Sub ImprimirEcgErgo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuEcgErgo.Click
        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT Ergometria.ValEcg AS RegistreEcg FROM Ergometria WHERE Ergometria.IdReco=" + StrIdEpisodi + ";"
        ImprimirEcg.ShowDialog()

    End Sub
    Private Sub NoApte(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuNoOk.Click

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT DadesPacient.Dni, DadesPacient.Nom, DadesPacient.PrimerCognom, DadesPacient.SegonCognom, DadesPacient.DN FROM DadesPacient WHERE DadesPacient.idPacient=" + StrIdPacient + ";"
        Dim oDataAdapterDadesPacient As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT Reconeixements.Metge, Reconeixements.DataInici FROM Reconeixements WHERE Reconeixements.IdReco=" + StrIdEpisodi + ";"
        Dim oDataAdapterReconeixements As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT Terapeutes.NumColegiat FROM Terapeutes WHERE Terapeutes.Terapeuta=""" + Me.Metge.Text + """;"
        Dim oDataAdapterTerapeutes As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        Dim Informe As New InformeRecoNoConforme()
        oDataSet = Nothing
        oDataSet = New DataSet()

        oConexion.Open()
        oDataAdapterDadesPacient.Fill(oDataSet, "DadesPacient")
        oDataAdapterReconeixements.Fill(oDataSet, "Reconeixements")
        oDataAdapterTerapeutes.Fill(oDataSet, "Terapeutes")
        oConexion.Close()

        Informe.SetDataSource(oDataSet)

        oDataRow = Nothing
        oDataRow = oDataSet.Tables("DadesPacient").Rows(0)
        Dim Edad As String = DateDiff(DateInterval.Year, CDate(oDataRow("DN")), CDate(Me.DataInici.Text)).ToString

        ImprimirReco.CrvReco.ReportSource = Informe
        ImprimirReco.Show()
    End Sub
    Private Sub Apte(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuOk.Click

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT DadesPacient.Dni, DadesPacient.Nom, DadesPacient.PrimerCognom, DadesPacient.SegonCognom, DadesPacient.DN FROM DadesPacient WHERE DadesPacient.idPacient=" + StrIdPacient + ";"
        Dim oDataAdapterDadesPacient As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT Reconeixements.Metge, Reconeixements.DataInici FROM Reconeixements WHERE Reconeixements.IdReco=" + StrIdEpisodi + ";"
        Dim oDataAdapterReconeixements As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT Terapeutes.NumColegiat FROM Terapeutes WHERE Terapeutes.Terapeuta=""" + Me.Metge.Text + """;"
        Dim oDataAdapterTerapeutes As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        Dim Informe As New InformeApte()

        oDataSet = Nothing
        oDataSet = New DataSet()

        oConexion.Open()

        oDataAdapterDadesPacient.Fill(oDataSet, "DadesPacient")
        oDataAdapterReconeixements.Fill(oDataSet, "Reconeixements")
        oDataAdapterTerapeutes.Fill(oDataSet, "Terapeutes")

        oConexion.Close()

        Informe.SetDataSource(oDataSet)

        Try
            oDataRow = Nothing
            oDataRow = oDataSet.Tables("DadesPacient").Rows(0)
            Dim Edad As String = DateDiff(DateInterval.Year, CDate(oDataRow("DN")), CDate(Me.DataInici.Text)).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ImprimirReco.CrvReco.ReportSource = Informe
        ImprimirReco.Show()
    End Sub
    Private Sub DetAlçada_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DetAlçada.GotFocus, DetAlçadaAssegut.GotFocus, DetEnvergadura.GotFocus, DetPes.GotFocus
        With Me.DetAlçada
            .SelectionStart = 0
            .SelectionLength = 4
        End With

        With Me.DetAlçadaAssegut
            .SelectionStart = 0
            .SelectionLength = 4
        End With

        With Me.DetEnvergadura
            .SelectionStart = 0
            .SelectionLength = 4
        End With

        With Me.DetPes
            .SelectionStart = 0
            .SelectionLength = 4
        End With

    End Sub
    Friend Sub CarregarDades()

        Try
            Me.DetTA.Mask = "000/00"
            Me.DetAlçada.Mask = "#,##"
            Me.DetAlçadaAssegut.Mask = "#,##"
            Me.DetEnvergadura.Mask = "#,##"
            'Me.DetPes.Mask = "#,##"
            Me.DetPes.Mask = "##,#"
        Catch ex As Exception
            MsgBox(ex.Message + " Carregar dades Principi")
        End Try

        Me.WindowState = FormWindowState.Maximized

        Me.Nom.Text = Episodis.Pacient.Text
        Me.ModClub.Visible = False
        Me.ModEquip.Visible = False
        Me.ModProtocol.Visible = False
        Me.ModMetge.Visible = False

        Me.Club.Visible = True
        Me.Equip.Visible = True
        Me.Protocol.Visible = True
        Me.Metge.Visible = True
        Me.BtnModificarReco.Visible = True
        Me.BtnOK.Visible = False

        Me.Anamnesi.Enabled = False
        Me.Exploracio.Enabled = False
        Me.ECGrepos.Enabled = False
        Me.Espirometria.Enabled = False
        Me.AntropometriaBasica.Enabled = False
        Me.Ergometria.Enabled = False
        Me.Estabilometria.Enabled = False
        Me.ExploracioPostural.Enabled = False
        Me.EBM.Enabled = False
        Me.AntropometriaAvançada.Enabled = False
        Me.Protocol.Enabled = False
        Me.Club.Enabled = False
        Me.Equip.Enabled = False
        Me.DataInici.Enabled = False
        Me.Metge.Enabled = False

        Me.BtnCalendari.Visible = False
        Me.MonthCalendar1.Visible = False

        'Creo Cadena de Conexió i l'assigno a l'objecte oConexion
        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        'Creo i omplo els DataAdapter
        StrInstruccioSQL = "SELECT Reconeixements.* FROM Reconeixements WHERE Reconeixements.IdReco=" + StrIdEpisodi + ";"
        Dim oDataAdapterReconeixements = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = "SELECT Sexe.* FROM Sexe;"
        Dim oDataAdapterSexe = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = "SELECT Anamnesi.* FROM Anamnesi WHERE Anamnesi.Pacient=" + StrIdPacient + ";"
        Dim oDataAdapterAnamnesi = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = "SELECT Exploracio.* FROM Exploracio WHERE Exploracio.IdReco=" + StrIdEpisodi + ";"
        Dim oDataAdapterExploracio = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = "SELECT Proves.* FROM Proves WHERE Proves.IdReco=" + StrIdEpisodi + ";"
        Dim oDataAdapterProves = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = "SELECT Antropometria.* FROM Antropometria WHERE Antropometria.IdReco=" + StrIdEpisodi + ";"
        Dim oDataAdapterAntropometria = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = "SELECT Ergometria.* FROM Ergometria WHERE Ergometria.IdReco=" + StrIdEpisodi + ";"
        Dim oDataAdapterErgometria = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT ErgoValoracio.* FROM ErgoValoracio"
        Dim oDataAdapterErgoValoracio = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = "SELECT RecoObservacions.* FROM RecoObservacions WHERE RecoObservacions.IdReco=" + StrIdEpisodi + ";"
        Dim oDataAdapterRecoObservacions = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = "SELECT Ebm.* FROM Ebm WHERE Ebm.IdReco=" + StrIdEpisodi + ";"
        Dim oDataAdapterEbm = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = "SELECT ExploracioPostural.* FROM ExploracioPostural WHERE ExploracioPostural.IdReco=" + StrIdEpisodi + ";"
        Dim oDataAdapterExploracioPostural = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = "SELECT Estabilometria.* FROM Estabilometria WHERE Estabilometria.IdReco=" + StrIdEpisodi + ";"
        Dim oDataAdapterEstabilometria = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = "SELECT EcgRepos.ECG FROM EcgRepos WHERE EcgRepos.IdReco=" + StrIdEpisodi + " ORDER BY EcgRepos.ECG DESC;"
        Dim oDataAdapterEcgRepos As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        'Incialitzo, Creo i Omplo el DataSet
        oDataSet = Nothing
        oDataSet = New DataSet()

        oConexion.Open()

        oDataAdapterReconeixements.Fill(oDataSet, "Reconeixements")
        oDataAdapterSexe.Fill(oDataSet, "Sexe")
        oDataAdapterAnamnesi.Fill(oDataSet, "Anamnesi")
        oDataAdapterExploracio.Fill(oDataSet, "Exploracio")
        oDataAdapterProves.Fill(oDataSet, "Proves")
        oDataAdapterAntropometria.Fill(oDataSet, "Antropometria")
        oDataAdapterErgometria.Fill(oDataSet, "Ergometria")
        oDataAdapterErgoValoracio.Fill(oDataSet, "ErgoValoracio")
        oDataAdapterExploracioPostural.Fill(oDataSet, "ExploracioPostural")
        oDataAdapterRecoObservacions.Fill(oDataSet, "RecoObservacions")
        oDataAdapterEbm.Fill(oDataSet, "Ebm")
        oDataAdapterEstabilometria.Fill(oDataSet, "Estabilometria")
        oDataAdapterEcgRepos.Fill(oDataSet, "EcgRepos")

        oConexion.Close()

        'Creo les variables per omplir els camps i els omplo
        Dim iPosicionActual As Integer = 0
        Dim oDataRow As DataRow = Nothing

        'RECONEIXEMENTS
        If oDataSet.Tables("Reconeixements").Rows.Count > 0 Then
            Try
                oDataRow = oDataSet.Tables("Reconeixements").Rows(iPosicionActual)

                If oDataRow("Anamnesi") = True Then
                    Me.Anamnesi.Checked = True
                Else
                    Me.Anamnesi.Checked = False
                End If

                If oDataRow("EcgRepos") = True Then
                    Me.ECGrepos.Checked = True
                Else
                    Me.ECGrepos.Checked = False
                End If

                If oDataRow("Espirometria") = True Then
                    Me.Espirometria.Checked = True
                Else
                    Me.Espirometria.Checked = False
                End If

                If oDataRow("ExploracioMedica") = True Then
                    Me.Exploracio.Checked = True
                Else
                    Me.Exploracio.Checked = False
                End If

                If oDataRow("Ergometria") = True Then
                    Me.Ergometria.Checked = True
                Else
                    Me.Ergometria.Checked = False
                End If

                If oDataRow("ExploracioPostural") = True Then
                    Me.ExploracioPostural.Checked = True
                Else
                    Me.ExploracioPostural.Checked = False
                End If

                If oDataRow("EBM") = True Then
                    Me.EBM.Checked = True
                Else
                    Me.EBM.Checked = False
                End If

                If oDataRow("Estabilometria") = True Then
                    Me.Estabilometria.Checked = True
                Else
                    Me.Estabilometria.Checked = False
                End If

                If oDataRow("AntropometriaBasica") = True Then
                    Me.AntropometriaBasica.Checked = True
                Else
                    Me.AntropometriaBasica.Checked = False
                End If

                If oDataRow("AntropometriaAvançada") = True Then
                    Me.AntropometriaAvançada.Checked = True
                Else
                    Me.AntropometriaAvançada.Checked = False
                End If

                If VarType(oDataRow("Metge")) <> VariantType.Null Then
                    Me.Metge.Text = oDataRow("Metge")
                Else
                End If

                If VarType(oDataRow("DataInici")) <> VariantType.Null Then
                    Me.DataInici.Text = oDataRow("DataInici")
                Else
                End If

                If VarType(oDataRow("Club")) <> VariantType.Null Then
                    Me.Club.Text = oDataRow("Club")
                Else
                End If

                If VarType(oDataRow("Equip")) <> VariantType.Null Then
                    Me.Equip.Text = oDataRow("Equip")
                Else
                End If

                If VarType(oDataRow("Protocol")) <> VariantType.Null Then
                    Me.Protocol.Text = oDataRow("Protocol")
                Else
                End If

                If VarType(oDataRow("Aptitut")) <> VariantType.Null Then
                    Me.DetAptitut.Text = oDataRow("Aptitut")
                Else
                    Me.DetAptitut.Text = ""
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
        End If

        'SEXE
        Dim StrSexe As String = Me.Sexe.Text
        With Me.Sexe
            .DataSource = oDataSet.Tables("Sexe")
            .DisplayMember = "Sexe"
            .ValueMember = "Sexe"

            If VarType(oDataRow("Sexe")) <> VariantType.Null Then
                Me.Sexe.Text = oDataRow("Sexe")
            Else
                Me.DetObservacions.Text = ""
            End If

            .AutoCompleteSource = AutoCompleteSource.ListItems
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
        End With

        '''''''' OMPLIR LA PESTANYA ANAMNESI ''''''

        If oDataSet.Tables("Anamnesi").Rows.Count > 0 Then

            Try
                iPosicionActual = 0
                oDataRow = oDataSet.Tables("Anamnesi").Rows(iPosicionActual)

                If VarType(oDataRow("AP")) <> VariantType.Null Then
                    Me.DetAP.Text = oDataRow("AP")
                Else
                    Me.DetAP.Text = ""
                End If

                If VarType(oDataRow("AF")) <> VariantType.Null Then
                    Me.DetAF.Text = oDataRow("AF")
                Else
                    Me.DetAF.Text = ""
                End If

                If VarType(oDataRow("Medicacio")) <> VariantType.Null Then
                    Me.DetMedicacio.Text = oDataRow("Medicacio")
                Else
                    Me.DetMedicacio.Text = ""
                End If

                If VarType(oDataRow("Alergies")) <> VariantType.Null Then
                    Me.DetAlergies.Text = oDataRow("Alergies")
                Else
                    Me.DetAlergies.Text = ""
                End If

                If VarType(oDataRow("Tabac")) <> VariantType.Null Then
                    Me.DetTabac.Text = oDataRow("Tabac")
                Else
                    Me.DetTabac.Text = ""
                End If

                If VarType(oDataRow("Alcohol")) <> VariantType.Null Then
                    Me.DetAlcohol.Text = oDataRow("Alcohol")
                Else
                    Me.DetAlcohol.Text = ""
                End If

                If VarType(oDataRow("Vacunes")) <> VariantType.Null Then
                    Me.DetVacunes.Text = oDataRow("Vacunes")
                Else
                    Me.DetVacunes.Text = ""
                End If

                If VarType(oDataRow("AnysPracticaEsportiva")) <> VariantType.Null Then
                    Me.DetAnysEsport.Text = oDataRow("AnysPracticaEsportiva")
                Else
                    Me.DetAnysEsport.Text = ""
                End If

                If VarType(oDataRow("Observacions")) <> VariantType.Null Then
                    Me.DetObservacions.Text = oDataRow("Observacions")
                Else
                    Me.DetObservacions.Text = ""
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
        End If
        '''''''' OMPLIR LA PESTANYA EXPLORACIO ''''''
        If oDataSet.Tables("Exploracio").Rows.Count > 0 Then
            Try
                iPosicionActual = 0
                oDataRow = oDataSet.Tables("Exploracio").Rows(iPosicionActual)

                If VarType(oDataRow("Ulls")) <> VariantType.Null Then
                    Me.DetUlls.Text = oDataRow("Ulls")
                Else
                    Me.DetUlls.Text = ""
                End If

                If VarType(oDataRow("Nasofaringe")) <> VariantType.Null Then
                    Me.DetNassofarige.Text = oDataRow("Nasofaringe")
                Else
                    Me.DetNassofarige.Text = ""
                End If

                If VarType(oDataRow("Boca")) <> VariantType.Null Then
                    Me.DetBoca.Text = oDataRow("Boca")
                Else
                    Me.DetBoca.Text = ""
                End If

                If VarType(oDataRow("Coll")) <> VariantType.Null Then
                    Me.DetColl.Text = oDataRow("Coll")
                Else
                    Me.DetColl.Text = ""
                End If

                If VarType(oDataRow("Torax")) <> VariantType.Null Then
                    Me.DetTorax.Text = oDataRow("Torax")
                Else
                    Me.DetTorax.Text = ""
                End If

                If VarType(oDataRow("Pell")) <> VariantType.Null Then
                    Me.DetPell.Text = oDataRow("Pell")
                Else
                    Me.DetPell.Text = ""
                End If

                If VarType(oDataRow("AuscultacioPulmonar")) <> VariantType.Null Then
                    Me.DetAuscultacioPulmonar.Text = oDataRow("AuscultacioPulmonar")
                Else
                    Me.DetAuscultacioPulmonar.Text = ""
                End If

                If VarType(oDataRow("AuscultacioCardiaca")) <> VariantType.Null Then
                    Me.DetAuscultacioCardiaca.Text = oDataRow("AuscultacioCardiaca")
                Else
                    Me.DetAuscultacioCardiaca.Text = ""
                End If

                If VarType(oDataRow("AparellCirculatori")) <> VariantType.Null Then
                    Me.DetAparellCirculatori.Text = oDataRow("AparellCirculatori")
                Else
                    Me.DetAparellCirculatori.Text = ""
                End If

                If VarType(oDataRow("Abdomen")) <> VariantType.Null Then
                    Me.DetAbdomen.Text = oDataRow("Abdomen")
                Else
                    Me.DetAbdomen.Text = ""
                End If

                If VarType(oDataRow("AparellLocomotor")) <> VariantType.Null Then
                    Me.DetAparellLocomotor.Text = oDataRow("AparellLocomotor")
                Else
                    Me.DetAparellLocomotor.Text = ""
                End If

                If VarType(oDataRow("SistemaNervios")) <> VariantType.Null Then
                    Me.DetSistemaNervios.Text = oDataRow("SistemaNervios")
                Else
                    Me.DetSistemaNervios.Text = ""
                End If

                If VarType(oDataRow("Otoscopia")) <> VariantType.Null Then
                    Me.DetOtoscopia.Text = oDataRow("Otoscopia")
                Else
                    Me.DetOtoscopia.Text = ""
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
        End If

        '''''''' OMPLIR LA PESTANYA PROVES ''''''

        If oDataSet.Tables("Proves").Rows.Count > 0 Then

            Try

                iPosicionActual = 0

                oDataRow = oDataSet.Tables("Proves").Rows(iPosicionActual)

                If VarType(oDataRow("EcgRepos")) <> VariantType.Null Then
                    Me.DetECGrepos.Text = oDataRow("EcgRepos")
                Else
                    Me.DetECGrepos.Text = ""
                End If

                If VarType(oDataRow("ObservacionsEcgRepos")) <> VariantType.Null Then
                    Me.DetECGObs.Text = oDataRow("ObservacionsEcgRepos")
                Else
                    Me.DetECGObs.Text = ""
                End If

                If VarType(oDataRow("Espirometria")) <> VariantType.Null Then
                    Me.DetEspirometria.Text = oDataRow("Espirometria")
                Else
                    Me.DetEspirometria.Text = ""
                End If

                If VarType(oDataRow("ObservacionsEspirometria")) <> VariantType.Null Then
                    Me.DetEspirometriaObs.Text = oDataRow("ObservacionsEspirometria")
                Else
                    Me.DetEspirometriaObs.Text = ""
                End If

                If VarType(oDataRow("FVC")) <> VariantType.Null Then
                    Me.DetFVC.Text = oDataRow("FVC")
                Else
                    Me.DetFVC.Text = ""
                End If

                If VarType(oDataRow("FEV1")) <> VariantType.Null Then
                    Me.DetFEV1.Text = oDataRow("FEV1")
                Else
                    Me.DetFEV1.Text = ""
                End If

                If VarType(oDataRow("FEV1%FVC%")) <> VariantType.Null Then
                    Me.DetFEV1FVC.Text = oDataRow("FEV1%FVC%")
                Else
                    Me.DetFEV1FVC.Text = ""
                End If

                If VarType(oDataRow("PEF")) <> VariantType.Null Then
                    Me.DetPEF.Text = oDataRow("PEF")
                Else
                    Me.DetPEF.Text = ""
                End If

                If VarType(oDataRow("FEF25%")) <> VariantType.Null Then
                    Me.DetFEF25.Text = oDataRow("FEF25%")
                Else
                    Me.DetFEF25.Text = ""
                End If

                If VarType(oDataRow("FEF50%")) <> VariantType.Null Then
                    Me.DetFEF50.Text = oDataRow("FEF50%")
                Else
                    Me.DetFEF50.Text = ""
                End If

                If VarType(oDataRow("FEF75%")) <> VariantType.Null Then
                    Me.DetFEF75.Text = oDataRow("FEF75%")
                Else
                    Me.DetFEF75.Text = ""
                End If

                If VarType(oDataRow("FET")) <> VariantType.Null Then
                    Me.DetFet.Text = oDataRow("FET")
                Else
                    Me.DetFet.Text = ""
                End If

                If VarType(oDataRow("FEF2575")) <> VariantType.Null Then
                    Me.DetFEF2575.Text = oDataRow("FEF2575")
                Else
                    Me.DetFEF2575.Text = ""
                End If

                If VarType(oDataRow("VEXT")) <> VariantType.Null Then
                    Me.DetVEXT.Text = oDataRow("VEXT")
                Else
                    Me.DetVEXT.Text = ""
                End If

                If VarType(oDataRow("TA")) <> VariantType.Null Then
                    Me.DetTA.Text = oDataRow("TA")
                Else
                    Me.DetTA.Text = ""
                End If

                If VarType(oDataRow("SPO2")) <> VariantType.Null Then
                    Me.DetSPO2.Text = oDataRow("SPO2")
                Else
                    Me.DetSPO2.Text = ""
                End If

                If VarType(oDataRow("FC")) <> VariantType.Null Then
                    Me.DetFC.Text = oDataRow("FC")
                Else
                    Me.DetFC.Text = ""
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
        End If


        Me.DgEcg.DataSource = oDataSet
        Me.DgEcg.DataMember = "EcgRepos"



        With Me.DgEcg
            'COLOR
            .RowsDefaultCellStyle.BackColor = Color.Beige
            .BackgroundColor = Color.Beige

            'Només lectura i no es poden afegir registres
            .ReadOnly = True
            .AllowUserToAddRows = False

            'Columnes no visibles
            .RowHeadersVisible = False

            'Mides
            .Columns.Item(0).Width = CInt(Me.DgEcg.Width * 0.98)

            'Títols de columna
            .Columns.Item(0).HeaderText = "ECG"

            .Columns.Item(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter


            'No es poden canviar les mides de les files i columnes
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False

        End With

        '''''''' OMPLIR LA PESTANYA ANTROPOMETRIA ''''''

        If oDataSet.Tables("Antropometria").Rows.Count > 0 Then

            Try
                iPosicionActual = 0

                oDataRow = oDataSet.Tables("Antropometria").Rows(iPosicionActual)
                If VarType(oDataRow("Pes")) <> VariantType.Null Then
                    Me.DetPes.Text = Format(oDataRow("Pes"), "##,#")
                Else
                    Me.DetPes.Text = Format(0, "##,#")
                End If
                If VarType(oDataRow("Alçada")) <> VariantType.Null Then
                    Me.DetAlçada.Text = oDataRow("Alçada")
                Else
                    Me.DetAlçada.Text = Format(0, "#,##")
                End If

                If VarType(oDataRow("AlçadaAssegut")) <> VariantType.Null Then
                    Me.DetAlçadaAssegut.Text = oDataRow("AlçadaAssegut")
                Else
                    Me.DetAlçadaAssegut.Text = Format(0, "#,##")
                End If

                If VarType(oDataRow("Envergadura")) <> VariantType.Null Then
                    Me.DetEnvergadura.Text = oDataRow("Envergadura")
                Else
                    Me.DetEnvergadura.Text = Format(0, "#,##")
                End If

                If VarType(oDataRow("PerimetreCamaMaxima")) <> VariantType.Null Then
                    Me.DetPerCamaMax.Text = oDataRow("PerimetreCamaMaxima")
                Else
                    Me.DetPerCamaMax.Text = Format(0, "#,##")
                End If

                If VarType(oDataRow("PerimetreBraçRelax")) <> VariantType.Null Then
                    Me.DetPerBraçRelax.Text = oDataRow("PerimetreBraçRelax")
                Else
                    Me.DetPerBraçRelax.Text = Format(0, "#,##")
                End If

                If VarType(oDataRow("PCBiceps")) <> VariantType.Null Then
                    Me.DetPcBiceps.Text = oDataRow("PCBiceps")
                Else
                    Me.DetPcBiceps.Text = Format(0, "#,##")
                End If

                If VarType(oDataRow("PCTriceps")) <> VariantType.Null Then
                    Me.DetPcTriceps.Text = oDataRow("PCTriceps")
                Else
                    Me.DetPcTriceps.Text = Format(0, "#,##")
                End If

                If VarType(oDataRow("PCSubescapular")) <> VariantType.Null Then
                    Me.DetPcSubescapular.Text = oDataRow("PCSubescapular")
                Else
                    Me.DetPcSubescapular.Text = Format(0, "#,##")
                End If

                If VarType(oDataRow("PCCrestaIliaca")) <> VariantType.Null Then
                    Me.DetPcCrestaIliaca.Text = oDataRow("PCCrestaIliaca")
                Else
                    Me.DetPcCrestaIliaca.Text = Format(0, "#,##")
                End If

                If VarType(oDataRow("PCCamaMedial")) <> VariantType.Null Then
                    Me.DetPcCamaMedial.Text = oDataRow("PCCamaMedial")
                Else
                    Me.DetPcCamaMedial.Text = Format(0, "#,##")
                End If

                If VarType(oDataRow("NivellMaduratiu")) <> VariantType.Null Then
                    Me.DetNivellMaduratiu.Text = oDataRow("NivellMaduratiu")
                Else
                    Me.DetNivellMaduratiu.Text = ""
                End If
            Catch ex As Exception
                MsgBox(ex.Message + "Carregar antropometria")
            End Try
        Else
        End If
        'Càlcul IMC
        If Convert.ToDouble(Me.DetAlçada.Text) <> 0 And Convert.ToDouble(Me.DetPes.Text) <> 0 Then
            'MsgBox("calcual imc " + Me.DetPes.Text + "   " + Me.DetAlçada.Text)
            'Me.DetIMC.Text = Format(Convert.ToDouble((Convert.ToDouble(Me.DetPes.Text) / (Convert.ToDouble(Me.DetAlçada.Text) * Convert.ToDouble(Me.DetAlçada.Text)))), "##,#")

            Dim DblDetPes As Double
            Dim DblDetAlçada As Double
            DblDetPes = Convert.ToDouble(Me.DetPes.Text.Replace(".", ","))
            DblDetAlçada = Convert.ToDouble(Me.DetAlçada.Text.Replace(".", ","))

            Dim DblIMC As Double
            DblIMC = DblDetPes / (DblDetAlçada * DblDetAlçada)

            Dim StrIMC As String
            StrIMC = Format(DblIMC, "##.#")
            Me.DetIMC.Text = StrIMC

        Else
            Me.DetIMC.Text = Format(0, "##.#")
        End If
        'Càlcul Suma plecs cutanis Triceps + Subescapular
        Me.SumTricepsSubescapular.Text = Convert.ToDouble(Me.DetPcTriceps.Text) + Convert.ToDouble(Me.DetPcSubescapular.Text)

        'Càlcul Suma plecs cutanis Triceps + Cama medial
        Me.SumTricepsCamaMedial.Text = Convert.ToDouble(Me.DetPcTriceps.Text) + Convert.ToDouble(Me.DetPcCamaMedial.Text)

        'Càlcul 5 PLC
        Me.PLC5.Text = Convert.ToDouble(Me.DetPcBiceps.Text) + Convert.ToDouble(Me.DetPcTriceps.Text) + Convert.ToDouble(Me.DetPcSubescapular.Text) + Convert.ToDouble(Me.DetPcCamaMedial.Text) + Convert.ToDouble(Me.DetPcCrestaIliaca.Text)

        'Càlcul % de greix
        Dim PLC4 As Double
        PLC4 = Convert.ToDouble(Me.DetPcBiceps.Text) + Convert.ToDouble(Me.DetPcTriceps.Text) + Convert.ToDouble(Me.DetPcSubescapular.Text) + Convert.ToDouble(Me.DetPcCrestaIliaca.Text)

        If Me.Sexe.Text = "MASCULÍ" Then
            If Me.DetNivellMaduratiu.Text = "PRE-PUBERAL" Then
                Me.PercentatgeGreix.Text = Format(26.56 * (Math.Log(PLC4)) - 22.23, "0.000")

            ElseIf Me.DetNivellMaduratiu.Text = "PUBERAL" Then
                Me.PercentatgeGreix.Text = Format(18.7 * (Math.Log(PLC4)) - 11.91, "0.000")

            ElseIf Me.DetNivellMaduratiu.Text = "POST-PUBERAL" Then
                Me.PercentatgeGreix.Text = Format(18.88 * (Math.Log(PLC4)) - 15.58, "0.000")
            Else
                Me.PercentatgeGreix.Text = 0
            End If
        ElseIf Me.Sexe.Text = "FEMENÍ" Then
            If Me.DetNivellMaduratiu.Text = "PRE-PUBERAL" Then
                Me.PercentatgeGreix.Text = Format(29.85 * (Math.Log(PLC4)) - 25.87, "0.000")

            ElseIf Me.DetNivellMaduratiu.Text = "PUBERAL" Then
                Me.PercentatgeGreix.Text = Format(23.94 * (Math.Log(PLC4)) - 18.89, "0.000")

            ElseIf Me.DetNivellMaduratiu.Text = "POST-PUBERAL" Then
                Me.PercentatgeGreix.Text = Format(39.02 * (Math.Log(PLC4)) - 43.49, "0.000")
            Else
                Me.PercentatgeGreix.Text = 0
            End If
        Else
            Me.PercentatgeGreix.Text = 0
        End If

        'Càlcul Pes gras
        Me.PesGras.Text = Format((Convert.ToDouble(Me.PercentatgeGreix.Text) * Convert.ToDouble(Me.DetPes.Text)) / 100, "0.000")

        'Càlcul Percentage magre
        Me.PercentatgeMagre.Text = Format(100 - Convert.ToDouble(Me.PesGras.Text), "0.000")

        'Càlcul Pes magre
        Me.PesMagre.Text = Format(Convert.ToDouble(Me.DetPes.Text) - Convert.ToDouble(Me.PesGras.Text), "0.000")

        'Calcul Perimetre muscular del braç
        Me.PerimetreMsBraç.Text = Format(Convert.ToDouble(Me.DetPerBraçRelax.Text) - 3.1416 * (Convert.ToDouble(Me.DetPcTriceps.Text) / 10), "0.000")

        'Càlcul Perimetre muscular de la cama
        Me.PerimetreMsCama.Text = Format(Convert.ToDouble(Me.DetPerCamaMax.Text) - 3.1416 * (Convert.ToDouble(Me.DetPcCamaMedial.Text) / 10), "0.000")

        'Càlcul Index còrmic
        Me.IndexCormic.Text = Format(((Convert.ToDouble(Me.DetAlçadaAssegut.Text) * 100) / (Convert.ToDouble(Me.DetAlçada.Text) * 100) * 100), "0.000")

        'Càlcul Index esqueletic
        Me.IndexEsqueletic.Text = Format((((Convert.ToDouble(Me.DetAlçada.Text) * 100) - (Convert.ToDouble(Me.DetAlçadaAssegut.Text) * 100)) / (Convert.ToDouble(Me.DetAlçadaAssegut.Text) * 100) * 100), "0.000")

        'Càlcul Envergadura relativa
        Me.EnvergaduraRelativa.Text = Format(((Convert.ToDouble(Me.DetEnvergadura.Text) * 100) / (Convert.ToDouble(Me.DetAlçada.Text) * 100)) * 100, "0.000")


        '''''''' OMPLIR LA PESTANYA ERGOMETRIA ''''''

        Try

            Me.DgErgometria.DataSource = Nothing
            Me.DgErgometria.DataMember = Nothing
            Me.DgErgometria.DataSource = oDataSet
            Me.DgErgometria.DataMember = "Ergometria"

            With Me.DgErgometria
                'COLOR
                .RowsDefaultCellStyle.BackColor = Color.Beige

                'Només lectura i no es poden afegir registres
                .ReadOnly = True
                .AllowUserToAddRows = False

                'Columnes no visibles
                .Columns.Item(0).Visible = False
                .RowHeadersVisible = False

                'Mides
                .Columns.Item(1).Width = CInt(Me.DgErgometria.Width * 0.25)
                .Columns.Item(2).Width = CInt(Me.DgErgometria.Width * 0.06)
                .Columns.Item(3).Width = CInt(Me.DgErgometria.Width * 0.1)
                .Columns.Item(4).Width = CInt(Me.DgErgometria.Width * 0.06)
                .Columns.Item(5).Width = CInt(Me.DgErgometria.Width * 0.06)
                .Columns.Item(6).Width = CInt(Me.DgErgometria.Width * 0.06)
                .Columns.Item(7).Width = CInt(Me.DgErgometria.Width * 0.4)

                'Títols de columna
                .Columns.Item(1).HeaderText = "Valoració"
                .Columns.Item(2).HeaderText = "Minut prova"
                .Columns.Item(3).HeaderText = "Registre ECG"
                .Columns.Item(4).HeaderText = "TA"
                .Columns.Item(5).HeaderText = "SPO2"
                .Columns.Item(6).HeaderText = "FC"
                .Columns.Item(7).HeaderText = "Observacions"

                .Columns.Item(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
                .Columns.Item(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
                .Columns.Item(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
                .Columns.Item(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
                .Columns.Item(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
                .Columns.Item(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
                .Columns.Item(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter


                'No es poden canviar les mides de les files i columnes
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False

            End With

            With Me.ErgoValoracio
                .DataSource = oDataSet.Tables("ErgoValoracio")
                .DisplayMember = "Valoracio"
                .ValueMember = "Valoracio"

                .AutoCompleteSource = AutoCompleteSource.ListItems
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            End With

            Me.ErgoTA.Mask = "#00/00"

            'Calcular FcMax
            If Episodis.DetDn.Text = "" Then
                Me.FcMax.Text = 0
            Else
                Dim Edat As Integer
                Edat = DateDiff(DateInterval.Year, CDate(Episodis.DetDn.Text), CDate(Me.DataInici.Text))

                Me.FcMax.Text = (220 - Edat)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        '''''''' OMPLIR LA PESTANYA EXPLORACIÓ POSTURAL ''''''

        If oDataSet.Tables("ExploracioPostural").Rows.Count > 0 Then

            Try
                iPosicionActual = 0
                oDataRow = oDataSet.Tables("ExploracioPostural").Rows(iPosicionActual)

                If VarType(oDataRow("Informe")) <> VariantType.Null Then
                    Me.DetExploracioPostural.Text = oDataRow("Informe")
                Else
                    Me.DetExploracioPostural.Text = ""
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
        End If


        '''''''' OMPLIR LA PESTANYA OBSERVACIONS ''''''

        If oDataSet.Tables("RecoObservacions").Rows.Count > 0 Then

            Try
                iPosicionActual = 0
                oDataRow = oDataSet.Tables("RecoObservacions").Rows(iPosicionActual)

                If VarType(oDataRow("Observacions")) <> VariantType.Null Then
                    Me.DetRecoObservacions.Text = oDataRow("Observacions")
                Else
                    Me.DetRecoObservacions.Text = ""
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
        End If


        '''''''' OMPLIR LA PESTANYA EBM ''''''

        If oDataSet.Tables("Ebm").Rows.Count > 0 Then
            Try
                iPosicionActual = 0
                oDataRow = oDataSet.Tables("Ebm").Rows(iPosicionActual)

                If VarType(oDataRow("Ebm")) <> VariantType.Null Then
                    Me.DetRecoEbm.Text = oDataRow("Ebm")
                Else
                    Me.DetRecoEbm.Text = ""
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
        End If

        '''''''' OMPLIR LA PESTANYA ESTABILOMETRIA ''''''

        If oDataSet.Tables("Estabilometria").Rows.Count > 0 Then

            Try
                iPosicionActual = 0
                oDataRow = oDataSet.Tables("Estabilometria").Rows(iPosicionActual)

                If VarType(oDataRow("Estabilometria")) <> VariantType.Null Then
                    Me.DetEstabilometria.Text = oDataRow("Estabilometria")
                Else
                    Me.DetEstabilometria.Text = ""
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
        End If

        Me.OpAnamnesi.BackColor = Color.Beige
        Me.OpAntropometria.BackColor = Color.Beige
        Me.OpEBM.BackColor = Color.Beige
        Me.OpErgometria.BackColor = Color.Beige
        Me.OpEstabilometria.BackColor = Color.Beige
        Me.OpExploracio.BackColor = Color.Beige
        Me.OpExploracioPostural.BackColor = Color.Beige
        Me.OpObservacions.BackColor = Color.Beige
        Me.OpProves.BackColor = Color.Beige

        Me.OpAnamnesi.Show()
        Me.OpExploracio.Show()

        If Me.Espirometria.Checked = True Then
            Me.Panel1.Visible = True
        Else
            Me.Panel1.Visible = False
        End If

        If Me.AntropometriaAvançada.Checked = True Then
            Me.Panel4.Visible = True
            Me.Panel5.Visible = True
            Me.Panel6.Visible = True
            Me.Label60.Visible = True
            Me.Label61.Visible = True
            Me.DetAlçadaAssegut.Visible = True
            Me.DetEnvergadura.Visible = True
            Me.DetNivellMaduratiu.Visible = True
            Me.BtnNivellMaduratiu.Visible = True
        Else
            Me.Panel4.Visible = False
            Me.Panel5.Visible = False
            Me.Panel6.Visible = False
            Me.Label60.Visible = False
            Me.Label61.Visible = False
            Me.DetAlçadaAssegut.Visible = False
            Me.DetEnvergadura.Visible = False
            Me.DetNivellMaduratiu.Visible = False
            Me.BtnNivellMaduratiu.Visible = False
            Me.DetIMC.Visible = True
        End If

        If Me.Ergometria.Checked = False Then
            Me.ErgoValoracio.Visible = False
            Me.ErgoMinut.Visible = False
            Me.ErgoTA.Visible = False
            Me.ErgoSPO2.Visible = False
            Me.ErgoFC.Visible = False
            Me.ErgoObservacions.Visible = False
            Me.FcMax.Visible = False
            Me.Label91.Visible = False
            Me.Label92.Visible = False
            Me.Label94.Visible = False
            Me.Label95.Visible = False
            Me.Label96.Visible = False
            Me.Label97.Visible = False
            Me.Label98.Visible = False
            Me.BtnIntro.Visible = False
            Me.BtnInformar.Visible = False
            Me.DgErgometria.Visible = False

        Else
            Me.ErgoValoracio.Visible = True
            Me.ErgoMinut.Visible = True
            Me.ErgoTA.Visible = True
            Me.ErgoSPO2.Visible = True
            Me.ErgoFC.Visible = True
            Me.ErgoObservacions.Visible = True
            Me.FcMax.Visible = True
            Me.Label91.Visible = True
            Me.Label92.Visible = True
            Me.Label94.Visible = True
            Me.Label95.Visible = True
            Me.Label96.Visible = True
            Me.Label97.Visible = True
            Me.Label98.Visible = True
            Me.BtnIntro.Visible = True
            Me.BtnInformar.Visible = True
            Me.DgErgometria.Visible = True
        End If

        If Me.Estabilometria.Checked = False Then
            Me.DetEstabilometria.Visible = False
        Else
            Me.DetEstabilometria.Visible = True
        End If

        If Me.EBM.Checked = False Then
            Me.DetRecoEbm.Visible = False
        Else
            Me.DetRecoEbm.Visible = True
        End If
    End Sub
    Private Sub BtnModificarReco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificarReco.Click

        Me.BtnModificarReco.Visible = False
        Me.BtnOK.Visible = True
        Me.BtnCalendari.Visible = True

        Me.ModClub.Visible = True
        Me.ModEquip.Visible = True
        Me.ModProtocol.Visible = True
        Me.ModMetge.Visible = True

        Me.Club.Visible = False
        Me.Equip.Visible = False
        Me.Protocol.Visible = False
        Me.Metge.Visible = False

        Me.Anamnesi.Enabled = True
        Me.Exploracio.Enabled = True
        Me.ECGrepos.Enabled = True
        Me.Espirometria.Enabled = True
        Me.AntropometriaBasica.Enabled = True
        Me.Ergometria.Enabled = True
        Me.Estabilometria.Enabled = True
        Me.ExploracioPostural.Enabled = True
        Me.EBM.Enabled = True
        Me.AntropometriaAvançada.Enabled = True
        Me.Protocol.Enabled = True
        Me.Metge.Enabled = True
        Me.DataInici.Enabled = False

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        Try
            StrInstruccioSQL = ""
            StrInstruccioSQL = "SELECT TipusReconeixement.* FROM TipusReconeixement;"

            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)

            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "TipusReconeixement")
            oConexion.Close()

            With Me.ModProtocol
                .DataSource = oDataSet.Tables("TipusReconeixement")
                .DisplayMember = "TipusReconeixement"
                .ValueMember = "TipusReconeixement"

                Me.ModProtocol.Text = Me.Protocol.Text
                .AutoCompleteSource = AutoCompleteSource.ListItems
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            StrInstruccioSQL = ""
            oDataAdapter = Nothing
            oCb = Nothing

            StrInstruccioSQL = "SELECT Clubs.* FROM Clubs;"

            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)

            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Clubs")
            oConexion.Close()

            With Me.ModClub
                .DataSource = oDataSet.Tables("Clubs")
                .DisplayMember = "Club"
                .ValueMember = "Club"

                Me.ModClub.Text = Me.Club.Text
                .AutoCompleteSource = AutoCompleteSource.ListItems
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            StrInstruccioSQL = ""
            StrInstruccioSQL = "SELECT Terapeutes.* FROM Terapeutes;"

            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)

            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Terapeutes")
            oConexion.Close()

            With Me.ModMetge
                .DataSource = oDataSet.Tables("Terapeutes")
                .DisplayMember = "Terapeuta"
                .ValueMember = "Terapeuta"

                .Text = Me.Metge.Text
                .AutoCompleteSource = AutoCompleteSource.ListItems
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub ModClub_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModClub.SelectedIndexChanged

        Try
            StrInstruccioSQL = ""
            StrInstruccioSQL = "SELECT Equips.* FROM Equips WHERE Equips.Club=""" + Me.ModClub.Text + """;"

            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)

            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Equips")
            oConexion.Close()

            With Me.ModEquip
                .DataSource = oDataSet.Tables("Equips")
                .DisplayMember = "Equip"
                .ValueMember = "Equip"

                .AutoCompleteSource = AutoCompleteSource.ListItems
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ModProtocol_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModProtocol.SelectedValueChanged

        If Me.ModProtocol.Text = "BÀSIC" Then
            Me.Anamnesi.Checked = True
            Me.ECGrepos.Checked = True
            Me.Espirometria.Checked = False
            Me.AntropometriaBasica.Checked = True
            Me.Exploracio.Checked = True
            Me.ExploracioPostural.Checked = False
            Me.Ergometria.Checked = False
            Me.Estabilometria.Checked = False
            Me.EBM.Checked = False
            Me.AntropometriaAvançada.Checked = False

        ElseIf Me.ModProtocol.Text = "INTERMEDI" Then
            Me.Anamnesi.Checked = True
            Me.ECGrepos.Checked = True
            Me.Espirometria.Checked = True
            Me.AntropometriaBasica.Checked = True
            Me.Exploracio.Checked = True
            Me.ExploracioPostural.Checked = True
            Me.Ergometria.Checked = True
            Me.Estabilometria.Checked = True
            Me.EBM.Checked = False
            Me.AntropometriaAvançada.Checked = False

        ElseIf Me.ModProtocol.Text = "AVANÇAT" Then

            Me.Anamnesi.Checked = True
            Me.ECGrepos.Checked = True
            Me.Espirometria.Checked = True
            Me.AntropometriaBasica.Checked = True
            Me.Exploracio.Checked = True
            Me.ExploracioPostural.Checked = True
            Me.Ergometria.Checked = True
            Me.Estabilometria.Checked = True
            Me.EBM.Checked = True
            Me.AntropometriaAvançada.Checked = True
        Else
            Exit Sub

        End If
    End Sub
    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click

        Try
            Me.BtnOK.Visible = False
            Me.BtnModificarReco.Visible = True

            Dim RsAnamnesi As String = "False"
            Dim RsECGrepos As String = "False"
            Dim RsEspirometria As String = "False"
            Dim RsAntropometriaBasica As String = "False"
            Dim RsExploracio As String = "False"
            Dim RsExploracioPostural As String = "False"
            Dim RsErgometria As String = "False"
            Dim RsEstabilometria As String = "False"
            Dim RsEBM As String = "False"
            Dim RsAntropometriaAvançada As String = "False"

            If Me.Anamnesi.Checked = True Then RsAnamnesi = "True"
            If Me.ECGrepos.Checked = True Then RsECGrepos = "True"
            If Me.Espirometria.Checked = True Then RsEspirometria = "True"
            If Me.AntropometriaBasica.Checked = True Then RsAntropometriaBasica = "True"
            If Me.Exploracio.Checked = True Then RsExploracio = "True"
            If Me.ExploracioPostural.Checked = True Then RsExploracioPostural = "True"
            If Me.Ergometria.Checked = True Then RsErgometria = "True"
            If Me.Estabilometria.Checked = True Then RsEstabilometria = "True"
            If Me.EBM.Checked = True Then RsEBM = "True"
            If Me.AntropometriaAvançada.Checked = True Then RsAntropometriaAvançada = "True"


            StrInstruccioSQL = ""
            StrInstruccioSQL = "UPDATE Reconeixements SET Reconeixements.Club = """ + Me.ModClub.Text _
                            + """, Reconeixements.Equip = """ + Me.ModEquip.Text _
                            + """, Reconeixements.Protocol = """ + Me.ModProtocol.Text _
                            + """, Reconeixements.Anamnesi = " + RsAnamnesi _
                            + ", Reconeixements.EcgRepos = " + RsECGrepos _
                            + ", Reconeixements.Espirometria = " + RsEspirometria _
                            + ", Reconeixements.ExploracioMedica = " + RsExploracio _
                            + ", Reconeixements.Ergometria=" + RsErgometria _
                            + ", Reconeixements.ExploracioPostural=" + RsExploracioPostural _
                            + ", Reconeixements.EBM=" + RsEBM _
                            + ", Reconeixements.Estabilometria=" + RsEstabilometria _
                            + ", Reconeixements.AntropometriaBasica=" + RsAntropometriaBasica _
                            + ", Reconeixements.AntropometriaAvançada=" + RsAntropometriaAvançada _
                            + " WHERE Reconeixements.IdReco=" + StrIdEpisodi + ";"

            ExecutarSql(StrInstruccioSQL)

            StrInstruccioSQL = ""
            StrInstruccioSQL = "UPDATE Reconeixements SET Reconeixements.Metge=""" + Me.ModMetge.Text _
                    + """ WHERE Reconeixements.IdReco = " + StrIdEpisodi + ";"

            ExecutarSql(StrInstruccioSQL)

            CarregarDades()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub DonarFormatNumerosICalcul_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetPerCamaMax.Leave, DetPerBraçRelax.Leave, DetPcBiceps.Leave, DetPcTriceps.Leave, DetPcSubescapular.Leave, DetPcCrestaIliaca.Leave, DetPcCamaMedial.Leave, DetPes.Leave, DetAlçada.Leave

        Me.DetAlçada.Text = Replace(Me.DetAlçada.Text, ".", ",")
        Me.DetPes.Text = Replace(Me.DetPes.Text, ".", ",")
        Me.DetAlçadaAssegut.Text = Replace(Me.DetAlçadaAssegut.Text, ".", ",")
        Me.DetEnvergadura.Text = Replace(Me.DetEnvergadura.Text, ".", ",")
        Me.DetPerCamaMax.Text = Replace(Me.DetPerCamaMax.Text, ".", ",")
        Me.DetPerBraçRelax.Text = Replace(Me.DetPerBraçRelax.Text, ".", ",")
        Me.DetPcBiceps.Text = Replace(Me.DetPcBiceps.Text, ".", ",")
        Me.DetPcTriceps.Text = Replace(Me.DetPcTriceps.Text, ".", ",")
        Me.DetPcSubescapular.Text = Replace(Me.DetPcSubescapular.Text, ".", ",")
        Me.DetPcCrestaIliaca.Text = Replace(Me.DetPcCrestaIliaca.Text, ".", ",")
        Me.DetPcCamaMedial.Text = Replace(Me.DetPcCamaMedial.Text, ".", ",")

        'Evitar camps numèrics en blanc, els converteix en 0
        If Me.DetPes.Text = "" Then
            Me.DetPes.Text = 0
        ElseIf Me.DetAlçada.Text = "" Then
            Me.DetAlçada.Text = 0
        ElseIf Me.DetAlçadaAssegut.Text = "" Then
            Me.DetAlçadaAssegut.Text = 0
        ElseIf Me.DetEnvergadura.Text = "" Then
            Me.DetEnvergadura.Text = 0
        ElseIf Me.DetPerCamaMax.Text = "" Then
            Me.DetPerCamaMax.Text = 0
        ElseIf Me.DetPerBraçRelax.Text = "" Then
            Me.DetPerBraçRelax.Text = 0
        ElseIf Me.DetPcBiceps.Text = "" Then
            Me.DetPcBiceps.Text = 0
        ElseIf Me.DetPcTriceps.Text = "" Then
            Me.DetPcTriceps.Text = 0
        ElseIf Me.DetPcSubescapular.Text = "" Then
            Me.DetPcSubescapular.Text = 0
        ElseIf Me.DetPcCrestaIliaca.Text = "" Then
            Me.DetPcCrestaIliaca.Text = 0
        ElseIf Me.DetPcCamaMedial.Text = "" Then
            Me.DetPcCamaMedial.Text = 0
        End If

        'Càlcul IMC
        If Convert.ToDouble(Me.DetAlçada.Text) <> 0 And Convert.ToDouble(Me.DetPes.Text) <> 0 Then
            Dim DblDetPes As Double
            Dim DblDetAlçada As Double
            DblDetPes = Convert.ToDouble(Me.DetPes.Text.Replace(".", ","))
            DblDetAlçada = Convert.ToDouble(Me.DetAlçada.Text.Replace(".", ","))

            Dim DblIMC As Double
            DblIMC = DblDetPes / (DblDetAlçada * DblDetAlçada)

            Dim StrIMC As String
            StrIMC = Format(DblIMC, "##.#")
            Me.DetIMC.Text = StrIMC

        Else
            Exit Sub
        End If

        'Càlcul Suma plecs cutanis Triceps + Subescapular
        Me.SumTricepsSubescapular.Text = Convert.ToDouble(Me.DetPcTriceps.Text) + Convert.ToDouble(Me.DetPcSubescapular.Text)

        'Càlcul Suma plecs cutanis Triceps + Cama medial
        Me.SumTricepsCamaMedial.Text = Convert.ToDouble(Me.DetPcTriceps.Text) + Convert.ToDouble(Me.DetPcCamaMedial.Text)

        'Càlcul 5 PLC
        Me.PLC5.Text = Convert.ToDouble(Me.DetPcBiceps.Text) + Convert.ToDouble(Me.DetPcTriceps.Text) + Convert.ToDouble(Me.DetPcSubescapular.Text) + Convert.ToDouble(Me.DetPcCamaMedial.Text) + Convert.ToDouble(Me.DetPcCrestaIliaca.Text)

        'Càlcul % de greix
        Dim PLC4 As Double
        PLC4 = Convert.ToDouble(Me.DetPcBiceps.Text) + Convert.ToDouble(Me.DetPcTriceps.Text) + Convert.ToDouble(Me.DetPcSubescapular.Text) + Convert.ToDouble(Me.DetPcCrestaIliaca.Text)

        If Me.Sexe.Text = "MASCULÍ" Then

            If Me.DetNivellMaduratiu.Text = "PRE-PUBERAL" Then
                Me.PercentatgeGreix.Text = Format(26.56 * (Math.Log(PLC4)) - 22.23, "0.000")

            ElseIf Me.DetNivellMaduratiu.Text = "PUBERAL" Then
                Me.PercentatgeGreix.Text = Format(18.7 * (Math.Log(PLC4)) - 11.91, "0.000")

            ElseIf Me.DetNivellMaduratiu.Text = "POST-PUBERAL" Then
                Me.PercentatgeGreix.Text = Format(18.88 * (Math.Log(PLC4)) - 15.58, "0.000")
            Else
                Exit Sub
            End If
        ElseIf Me.Sexe.Text = "FEMENÍ" Then
            If Me.DetNivellMaduratiu.Text = "PRE-PUBERAL" Then
                Me.PercentatgeGreix.Text = Format(29.85 * (Math.Log(PLC4)) - 25.87, "0.000")

            ElseIf Me.DetNivellMaduratiu.Text = "PUBERAL" Then
                Me.PercentatgeGreix.Text = Format(23.94 * (Math.Log(PLC4)) - 18.89, "0.000")

            ElseIf Me.DetNivellMaduratiu.Text = "POST-PUBERAL" Then
                Me.PercentatgeGreix.Text = Format(39.02 * (Math.Log(PLC4)) - 43.49, "0.000")
            Else
                Exit Sub
            End If
        Else
        End If

        'Càlcul Pes gras
        Me.PesGras.Text = Format((Convert.ToDouble(Me.PercentatgeGreix.Text) * Convert.ToDouble(Me.DetPes.Text)) / 100, "0.000")

        'Càlcul Percentage magre
        Me.PercentatgeMagre.Text = Format(100 - Convert.ToDouble(Me.PesGras.Text), "0.000")

        'Calcul Perimetre muscular del braç
        Me.PerimetreMsBraç.Text = Format(Convert.ToDouble(Me.DetPerBraçRelax.Text) - 3.1416 * (Convert.ToDouble(Me.DetPcTriceps.Text) / 10), "0.000")

        'Càlcul Perimetre muscular de la cama
        Me.PerimetreMsCama.Text = Format(Convert.ToDouble(Me.DetPerCamaMax.Text) - 3.1416 * (Convert.ToDouble(Me.DetPcCamaMedial.Text) / 10), "0.000")

        'Càlcul Index còrmic
        Me.IndexCormic.Text = Format(((Convert.ToDouble(Me.DetAlçadaAssegut.Text) * 100) / (Convert.ToDouble(Me.DetAlçada.Text) * 100) * 100), "0.000")

        'Càlcul Index esqueletic
        Me.IndexEsqueletic.Text = Format((((Convert.ToDouble(Me.DetAlçada.Text) * 100) - (Convert.ToDouble(Me.DetAlçadaAssegut.Text) * 100)) / (Convert.ToDouble(Me.DetAlçadaAssegut.Text) * 100) * 100), "0.000")

        'Càlcul Envergadura relativa
        Me.EnvergaduraRelativa.Text = Format(((Convert.ToDouble(Me.DetEnvergadura.Text) * 100) / (Convert.ToDouble(Me.DetAlçada.Text) * 100)) * 100, "0.000")
    End Sub
    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected

        StrInstruccioSQL = "UPDATE Reconeixements, Episodis" _
                + " SET Reconeixements.DataInici = '" + Me.MonthCalendar1.SelectionStart _
                + "', Reconeixements.DataFi = '" + Me.MonthCalendar1.SelectionStart _
                + "', Episodis.DataInici = '" + Me.MonthCalendar1.SelectionStart _
                + "', Episodis.DataFi = '" + Me.MonthCalendar1.SelectionStart _
                + "' WHERE Reconeixements.IdReco=" + StrIdEpisodi + " AND  Episodis.IdEpisodi=" + StrIdEpisodi + ";"

        ExecutarSql(StrInstruccioSQL)
        Me.MonthCalendar1.Visible = False
        Me.DataInici.Text = Me.MonthCalendar1.SelectionStart
    End Sub
    Private Sub BtnCalendari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalendari.Click
        Me.MonthCalendar1.Visible = True
    End Sub
    Private Sub Sexe_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sexe.SelectedValueChanged

        StrInstruccioSQL = ""
        StrInstruccioSQL = "UPDATE Reconeixements SET Reconeixements.Sexe=""" + Me.Sexe.Text _
                + """ WHERE Reconeixements.IdPacient = " + StrIdPacient + ";"

        ExecutarSql(StrInstruccioSQL)
    End Sub
    Private Sub BtnSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSortir.Click

        If GuardarCanvis() = 1 Then
            Exit Sub
        Else
        End If
        If Me.DetAptitut.Text = "" Or Me.DetAptitut.Text = "PENDENT DE VALORAR" Then
            Aptitut.ShowDialog()
        Else
        End If

        Me.DgErgometria.DataSource = Nothing
        StrIdEpisodi = ""

        'Inicialitzo els camps de fórmula
        Me.DetIMC.Text = ""
        Me.SumTricepsSubescapular.Text = ""
        Me.SumTricepsCamaMedial.Text = ""
        Me.PLC5.Text = ""
        Me.PerimetreMsBraç.Text = ""
        Me.PerimetreMsCama.Text = ""
        Me.PercentatgeGreix.Text = ""
        Me.PercentatgeMagre.Text = ""
        Me.PesGras.Text = ""
        Me.PesMagre.Text = ""
        Me.IndexCormic.Text = ""
        Me.IndexEsqueletic.Text = ""
        Me.EnvergaduraRelativa.Text = ""

        Me.Close()
    End Sub
    Private Function GuardarCanvis()

        Me.BtnNivellMaduratiu.BackColor = Color.Beige
        GuardarCanvis = 1
        If Me.AntropometriaAvançada.Checked = True Then
            If Me.DetNivellMaduratiu.Text = "" Then
                Dim i As Integer
                i = MsgBox("El nivell maduratiu és un camp obligatori" + Chr(13) + "PREM CANCELAR PER SORTIR SENSE INTRODUÏR-LO", MsgBoxStyle.OkCancel, "Fisiomèdic")
                If i = vbOK Then
                    Me.BtnNivellMaduratiu.BackColor = Color.Red
                    GuardarCanvis = 1
                    Exit Function
                Else
                End If
            End If
        End If
        StrInstruccioSQL = ""
        StrInstruccioSQL = "UPDATE Anamnesi, Exploracio, Proves, Antropometria, ExploracioPostural, Estabilometria, Ebm, RecoObservacions SET " _
                + "Anamnesi.AP=""" + Me.DetAP.Text _
                + """, Anamnesi.AF=""" + Me.DetAF.Text _
                + """, Anamnesi.Medicacio=""" + Me.DetMedicacio.Text _
                + """, Anamnesi.Alergies= """ + Me.DetAlergies.Text _
                + """, Anamnesi.Tabac=""" + Me.DetTabac.Text _
                + """, Anamnesi.Alcohol=""" + Me.DetAlcohol.Text _
                + """, Anamnesi.Vacunes=""" + Me.DetVacunes.Text _
                + """, Anamnesi.AnysPracticaEsportiva=" + Me.DetAnysEsport.Text _
                + ", Anamnesi.Observacions = """ + Me.DetObservacions.Text _
                + """, Exploracio.Ulls=""" + Me.DetUlls.Text _
                + """, Exploracio.Nasofaringe=""" + Me.DetNassofarige.Text _
                + """, Exploracio.Boca=""" + Me.DetBoca.Text _
                + """, Exploracio.Coll=""" + Me.DetColl.Text _
                + """, Exploracio.Torax=""" + Me.DetTorax.Text _
                + """, Exploracio.Pell=""" + Me.DetPell.Text _
                + """, Exploracio.AuscultacioPulmonar=""" + Me.DetAuscultacioPulmonar.Text _
                + """, Exploracio.AuscultacioCardiaca=""" + Me.DetAuscultacioCardiaca.Text _
                + """, Exploracio.AparellCirculatori = """ + Me.DetAparellCirculatori.Text _
                + """, Exploracio.Abdomen = """ + Me.DetAbdomen.Text _
                + """, Exploracio.AparellLocomotor = """ + Me.DetAparellLocomotor.Text _
                + """, Exploracio.SistemaNervios = """ + Me.DetSistemaNervios.Text _
                + """, Exploracio.Otoscopia = """ + Me.DetOtoscopia.Text _
                + """, Proves.EcgRepos=""" + Me.DetECGrepos.Text _
                + """, Proves.ObservacionsEcgRepos=""" + Me.DetECGObs.Text _
                + """, Proves.Espirometria=""" + Me.DetEspirometria.Text _
                + """, Proves.ObservacionsEspirometria=""" + Me.DetEspirometriaObs.Text _
                + """, Proves.[FVC]=""" + Me.DetFVC.Text _
                + """, Proves.[FEV1]=""" + Me.DetFEV1.Text _
                + """, Proves.[FEV1%FVC%]=""" + Me.DetFEV1FVC.Text _
                + """, Proves.[PEF]=""" + Me.DetPEF.Text _
                + """, Proves.[FEF25%] = """ + Me.DetFEF25.Text _
                + """, Proves.[FEF50%] = """ + Me.DetFEF50.Text _
                + """, Proves.[FEF75%] = """ + Me.DetFEF75.Text _
                + """, Proves.[FEF2575] = """ + Me.DetFEF2575.Text _
                + """, Proves.FET = """ + Me.DetFet.Text _
                + """, Proves.VEXT = """ + Me.DetVEXT.Text _
                + """, Proves.TA = """ + Me.DetTA.Text _
                + """, Proves.SPO2 = " + Me.DetSPO2.Text _
                + ", Proves.FC = " + Me.DetFC.Text _
                + ", Antropometria.Alçada = """ + Me.DetAlçada.Text _
                + """, Antropometria.Pes=""" + Me.DetPes.Text _
                + """, Antropometria.AlçadaAssegut=""" + Me.DetAlçadaAssegut.Text _
                + """, Antropometria.Envergadura=""" + Me.DetEnvergadura.Text _
                + """, Antropometria.PerimetreCamaMaxima=""" + Me.DetPerCamaMax.Text _
                + """, Antropometria.PerimetreBraçRelax=""" + Me.DetPerBraçRelax.Text _
                + """, Antropometria.PCBiceps=""" + Me.DetPcBiceps.Text _
                + """, Antropometria.PCTriceps=""" + Me.DetPcTriceps.Text _
                + """, Antropometria.PCSubescapular=""" + Me.DetPcSubescapular.Text _
                + """, Antropometria.PCCrestailiaca=""" + Me.DetPcCrestaIliaca.Text _
                + """, Antropometria.PCCamaMedial=""" + Me.DetPcCamaMedial.Text _
                + """, Antropometria.NivellMaduratiu=""" + Me.DetNivellMaduratiu.Text _
                + """, ExploracioPostural.Informe = """ + Me.DetExploracioPostural.Text _
                + """, Estabilometria.Estabilometria =""" + Me.DetEstabilometria.Text _
                + """, Ebm.Ebm = """ + Me.DetRecoEbm.Text _
                + """, RecoObservacions.Observacions=""" + Me.DetRecoObservacions.Text _
                + """ WHERE Anamnesi.Pacient=" + StrIdPacient _
                + " AND Exploracio.IdReco=" + StrIdEpisodi _
                + " AND Proves.IdReco=" + StrIdEpisodi _
                + " AND Antropometria.IdReco=" + StrIdEpisodi _
                + " AND ExploracioPostural.IdReco=" + StrIdEpisodi _
                + " AND Estabilometria.IdReco=" + StrIdEpisodi _
                + " AND Ebm.IdReco=" + StrIdEpisodi _
                + " AND RecoObservacions.IdReco=" + StrIdEpisodi + ";"

        ExecutarSql(StrInstruccioSQL)
        GuardarCanvis = 0
    End Function
    Private Sub BtnNivellMaduratiu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNivellMaduratiu.Click
        NivellMaduratiu.ShowDialog()
    End Sub
    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles ErgoTA.MaskInputRejected
        MsgBox("El valor no coincideix amb una TA", , "Fisiomèdic")
    End Sub
    Private Sub BtnIntro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIntro.Click

        Dim StrData As String
        StrData = Format(Now, "yyyyMMddHHmmss")
        Dim IntroEgcRepos As String = ""
        IntroEgcRepos = StrIdEpisodi + StrData
        Dim Pantalla() As Screen
        Pantalla = Screen.AllScreens
        If Pantalla.Length = 1 Then
            MsgBox("No existeix la pantalla de l'ECG des d'on adquirir la imatge")
            Exit Sub
        ElseIf Pantalla.Length = 2 Then

            Try
                Dim CarpetaMare As DirectoryInfo = Directory.GetParent(StrOrigenDeDades)
                Dim RutaEcg As String = CarpetaMare.FullName + "\ECG\"

                Dim pantallasu As Image
                pantallasu = TakeShotOfScreens()

                pantallasu.Save(RutaEcg + IntroEgcRepos + ".jpg")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            StrInstruccioSQL = ""
            StrInstruccioSQL = "INSERT INTO Ergometria ( IdReco, IdValoracio, HoraProva, ValEcg, ValTA, ValSPO2, ValFC, Observacions )" _
                    + "SELECT " + StrIdEpisodi _
                    + ", """ + Me.ErgoValoracio.Text _
                    + """, " + Me.ErgoMinut.Text _
                    + ", " + IntroEgcRepos _
                    + ", """ + Me.ErgoTA.Text _
                    + """, " + Me.ErgoSPO2.Text _
                    + ", " + Me.ErgoFC.Text _
                    + ", """ + Me.ErgoObservacions.Text + """;"
            ExecutarSql(StrInstruccioSQL)

            oConexion = New OleDb.OleDbConnection
            StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
            oConexion.ConnectionString = StrCadenaConexio

            StrInstruccioSQL = "SELECT Ergometria.* FROM Ergometria WHERE Ergometria.IdReco=" + StrIdEpisodi + ";"
            Dim oDataAdapterErgometria = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapterErgometria.Fill(oDataSet, "Ergometria")
            oConexion.Close()

            Me.DgErgometria.DataSource = oDataSet
            Me.DgErgometria.DataMember = "Ergometria"

            With Me.DgErgometria
                'COLOR
                .RowsDefaultCellStyle.BackColor = Color.Beige

                'Només lectura i no es poden afegir registres
                .ReadOnly = True
                .AllowUserToAddRows = False

                'Columnes no visibles
                .Columns.Item(0).Visible = False
                .RowHeadersVisible = False

                'Mides
                .Columns.Item(1).Width = CInt(Me.DgErgometria.Width * 0.25)
                .Columns.Item(2).Width = CInt(Me.DgErgometria.Width * 0.06)
                .Columns.Item(3).Width = CInt(Me.DgErgometria.Width * 0.1)
                .Columns.Item(4).Width = CInt(Me.DgErgometria.Width * 0.06)
                .Columns.Item(5).Width = CInt(Me.DgErgometria.Width * 0.06)
                .Columns.Item(6).Width = CInt(Me.DgErgometria.Width * 0.06)
                .Columns.Item(7).Width = CInt(Me.DgErgometria.Width * 0.4)

                'Títols de columna
                .Columns.Item(1).HeaderText = "Valoració"
                .Columns.Item(2).HeaderText = "Minut prova"
                .Columns.Item(3).HeaderText = "Registre ECG"
                .Columns.Item(4).HeaderText = "TA"
                .Columns.Item(5).HeaderText = "SPO2"
                .Columns.Item(6).HeaderText = "FC"
                .Columns.Item(7).HeaderText = "Observacions"

                .Columns.Item(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
                .Columns.Item(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
                .Columns.Item(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
                .Columns.Item(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
                .Columns.Item(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
                .Columns.Item(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
                .Columns.Item(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter


                'No es poden canviar les mides de les files i columnes
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False

            End With

        Else
            MsgBox("Error, existeixen més de dues pantalles conectades", , "Fisiomèdic")
        End If

        Me.ErgoValoracio.Text = ""
        Me.ErgoMinut.Text = ""
        Me.ErgoTA.Text = ""
        Me.ErgoSPO2.Text = ""
        Me.ErgoFC.Text = ""
        Me.ErgoObservacions.Text = ""

        Me.ErgoFC.BackColor = Color.White
        Me.ErgoValoracio.Focus()
    End Sub
    Private Sub ErgoFC_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ErgoFC.Leave

        If Me.ErgoFC.Text = "" Then
            Exit Sub
        End If
        If Me.ErgoFC.Text < (Convert.ToDouble(Me.FcMax.Text) - 20) Then
            Me.ErgoFC.BackColor = System.Drawing.SystemColors.Window
        ElseIf Me.ErgoFC.Text >= (Convert.ToDouble(Me.FcMax.Text) - 20) And Me.ErgoFC.Text <= (Convert.ToDouble(Me.FcMax.Text)) Then
            Me.ErgoFC.BackColor = Color.Orange
        Else
            Me.ErgoFC.BackColor = Color.Red
        End If
    End Sub
    Private Sub LOPD(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuDocuments.Click

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT DadesPacient.Dni, DadesPacient.Nom, DadesPacient.PrimerCognom, DadesPacient.SegonCognom FROM DadesPacient WHERE DadesPacient.idPacient=" + StrIdPacient + ";"
        Dim oDataAdapterDadesPacient As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT Reconeixements.Metge, Reconeixements.DataInici FROM Reconeixements WHERE Reconeixements.IdReco=" + StrIdEpisodi + ";"
        Dim oDataAdapterReconeixements As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT Terapeutes.NumColegiat FROM Terapeutes WHERE Terapeutes.Terapeuta=""" + Me.Metge.Text + """;"
        Dim oDataAdapterTerapeutes As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        Dim Informe As New InformeLopdRecos()
        oDataSet = Nothing
        oDataSet = New DataSet()

        oConexion.Open()

        oDataAdapterDadesPacient.Fill(oDataSet, "DadesPacient")
        oDataAdapterReconeixements.Fill(oDataSet, "Reconeixements")
        oDataAdapterTerapeutes.Fill(oDataSet, "Terapeutes")

        oConexion.Close()

        Informe.SetDataSource(oDataSet)

        ImprimirReco.CrvReco.ReportSource = Informe
        ImprimirReco.Show()

    End Sub
    Private Sub DgErgometria_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgErgometria.CellContentDoubleClick

        StrValoracio = Me.DgErgometria.Rows(e.RowIndex).Cells(1).Value()
        StrMinutProva = Me.DgErgometria.Rows(e.RowIndex).Cells(2).Value()
        StrTa = Me.DgErgometria.Rows(e.RowIndex).Cells(4).Value()
        StrSpO2 = Me.DgErgometria.Rows(e.RowIndex).Cells(5).Value()
        StrFc = Me.DgErgometria.Rows(e.RowIndex).Cells(6).Value()
        StrObservacions = Me.DgErgometria.Rows(e.RowIndex).Cells(7).Value()


        StrECG = Me.DgErgometria.Rows(e.RowIndex).Cells(3).Value()
        RegistreErgo.ShowDialog()
    End Sub
    Private Sub ImprimirReconeixements(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuReconeixement.Click

        If GuardarCanvis() = 1 Then
            Exit Sub
        Else
        End If

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT Anamnesi.* FROM Anamnesi WHERE Anamnesi.Pacient=" + StrIdPacient + ";"
        Dim oDataAdapterAnamnesi As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = "SELECT Antropometria.* FROM Antropometria WHERE Antropometria.IdReco=" + StrIdEpisodi + ";"
        Dim oDataAdapterAntropometria As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = "SELECT Proves.* FROM Proves WHERE Proves.IdReco=" + StrIdEpisodi + ";"
        Dim oDataAdapterProves As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = "SELECT Exploracio.* FROM Exploracio WHERE Exploracio.IdReco=" + StrIdEpisodi + ";"
        Dim oDataAdapterExploracio As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = "SELECT Ergometria.*, ErgoInforme.*" _
            + " FROM Ergometria INNER JOIN ErgoInforme ON Ergometria.IdReco = ErgoInforme.IdReco" _
            + " WHERE Ergometria.IdReco=" + StrIdEpisodi + ";"
        Dim oDataAdapterErgometria As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = "SELECT DadesPacient.Dni, DadesPacient.Nom, DadesPacient.PrimerCognom, DadesPacient.SegonCognom, DadesPacient.DN, Reconeixements.IdReco, Reconeixements.Club, Reconeixements.Sexe, Reconeixements.Equip, Reconeixements.Metge, Reconeixements.DataInici, Terapeutes.NumColegiat" _
            + " FROM Terapeutes INNER JOIN (DadesPacient INNER JOIN Reconeixements ON (DadesPacient.IdPacient = Reconeixements.IdPacient) AND (DadesPacient.IdPacient = Reconeixements.IdPacient)) ON Terapeutes.Terapeuta = Reconeixements.Metge" _
            + " WHERE Reconeixements.IdReco=" + StrIdEpisodi + ";"
        Dim oDataAdapterDadesPacient As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = "SELECT Estabilometria.* FROM Estabilometria WHERE Estabilometria.IdReco=" + StrIdEpisodi + ";"
        Dim oDataAdapterEstabilometria As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = "SELECT ExploracioPostural.* FROM ExploracioPostural WHERE ExploracioPostural.IdReco=" + StrIdEpisodi + ";"
        Dim oDataAdapterExploracioPostural As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = "SELECT Ebm.* FROM Ebm WHERE Ebm.IdReco=" + StrIdEpisodi + ";"
        Dim oDataAdapterEbm As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = "SELECT RecoObservacions.* FROM RecoObservacions WHERE RecoObservacions.IdReco=" + StrIdEpisodi + ";"
        Dim oDataAdapterRecoObservacions As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = "SELECT Reconeixements.* FROM Reconeixements WHERE Reconeixements.IdReco=" + StrIdEpisodi + ";"
        Dim oDataAdapterReconeixements As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = "SELECT Terapeutes.* FROM Terapeutes WHERE Terapeutes.Terapeuta=""" + Me.Metge.Text + """;"
        Dim oDataAdapterTerapeutes As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = "SELECT ErgoInforme.* FROM ErgoInforme WHERE ErgoInforme.IdReco=" + StrIdEpisodi + ";"
        Dim oDataAdapterErgoInforme As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        Dim Informe As New InformeReco()
        oDataSet = Nothing
        oDataSet = New DataSet()

        oConexion.Open()

        oDataAdapterDadesPacient.Fill(oDataSet, "DadesPacient")
        oDataAdapterAnamnesi.Fill(oDataSet, "Anamnesi")
        oDataAdapterAntropometria.Fill(oDataSet, "Antropometria")
        oDataAdapterProves.Fill(oDataSet, "Proves")
        oDataAdapterExploracio.Fill(oDataSet, "Exploracio")
        oDataAdapterErgometria.Fill(oDataSet, "Ergometria")
        oDataAdapterEstabilometria.Fill(oDataSet, "Estabilometria")
        oDataAdapterExploracioPostural.Fill(oDataSet, "ExploracioPostural")
        oDataAdapterEbm.Fill(oDataSet, "Ebm")
        oDataAdapterRecoObservacions.Fill(oDataSet, "RecoObservacions")
        oDataAdapterReconeixements.Fill(oDataSet, "Reconeixements")
        oDataAdapterTerapeutes.Fill(oDataSet, "Terapeutes")
        oDataAdapterErgoInforme.Fill(oDataSet, "ErgoInforme")

        oConexion.Close()

        Informe.SetDataSource(oDataSet)

        Informe.DataDefinition.FormulaFields.Item("IMC").Text = """" + Me.DetIMC.Text + """"
        With Informe.DataDefinition.FormulaFields
            .Item("SumPcTricepsSubescapular").Text = """" + Me.SumTricepsSubescapular.Text + "mm"""
            .Item("SumPcTricepsCamaMedial").Text = """" + Me.SumTricepsCamaMedial.Text + "mm"""
            .Item("5PLC").Text = """" + Me.PLC5.Text + "mm"""
            .Item("PerMsBraç").Text = """" + Me.PerimetreMsBraç.Text + """"
            .Item("PerMsCama").Text = """" + Me.PerimetreMsCama.Text + """"
            .Item("PercentatgeGreix").Text = """" + Me.PercentatgeGreix.Text + """"
            .Item("PercentatgeMagre").Text = """" + Me.PercentatgeMagre.Text + """"
            .Item("PesGras").Text = """" + Me.PesGras.Text + """"
            .Item("PesMagre").Text = """" + Me.PesMagre.Text + """"
            .Item("IndexCornic").Text = """" + Me.IndexCormic.Text + """"
            .Item("IndexEsqueletic").Text = """" + Me.IndexEsqueletic.Text + """"
            .Item("EnvergaduraRelativa").Text = """" + Me.EnvergaduraRelativa.Text + """"
        End With

        'Configuració de les parts de l'informe visibles o no segons el tipus de reconeixement
        'ERGOMETRIA
        If Me.Ergometria.Checked = False Then
            Informe.DetailSection66.SectionFormat.EnableSuppress = True
            Informe.DetailSection67.SectionFormat.EnableSuppress = True
            Informe.DetailSection68.SectionFormat.EnableSuppress = True
            Informe.DetailSection11.SectionFormat.EnableSuppress = True
        Else
            Informe.DetailSection66.SectionFormat.EnableSuppress = False
            Informe.DetailSection67.SectionFormat.EnableSuppress = False
            Informe.DetailSection68.SectionFormat.EnableSuppress = False
            Informe.DetailSection11.SectionFormat.EnableSuppress = False
        End If

        'ESTABILOMETRIA
        If Me.Estabilometria.Checked = False Then
            Informe.DetailSection10.SectionFormat.EnableSuppress = True
        Else
            Informe.DetailSection10.SectionFormat.EnableSuppress = False
        End If

        'ESPIROMETRIA
        If Me.Espirometria.Checked = False Then
            Informe.DetailSection51.SectionFormat.EnableSuppress = True
        Else
            Informe.DetailSection51.SectionFormat.EnableSuppress = False
        End If

        ''EBM
        If Me.EBM.Checked = False Then
            Informe.DetailSection3.SectionFormat.EnableSuppress = True
            Informe.DetailSection4.SectionFormat.EnableSuppress = True
        Else
            Informe.DetailSection3.SectionFormat.EnableSuppress = False
            Informe.DetailSection4.SectionFormat.EnableSuppress = False
        End If

        'OBSERVACIONS
        If Me.DetRecoObservacions.Text = "" Then
            Informe.DetailSection5.SectionFormat.EnableSuppress = True
            Informe.DetailSection6.SectionFormat.EnableSuppress = True
        Else
            Informe.DetailSection5.SectionFormat.EnableSuppress = False
            Informe.DetailSection6.SectionFormat.EnableSuppress = False
        End If

        'ANTROPOMETRIA AVANÇADA
        If Me.AntropometriaAvançada.Checked = False Then
            Informe.DetailSection48.SectionFormat.EnableSuppress = True
            Informe.DetailSection49.SectionFormat.EnableSuppress = True
        Else
            Informe.DetailSection48.SectionFormat.EnableSuppress = False
            Informe.DetailSection49.SectionFormat.EnableSuppress = False
        End If

        'Informe.Section1.SectionFormat.EnableSuppress = True
        ImprimirReco.CrvReco.ReportSource = Informe
        ImprimirReco.Show()

    End Sub
    Private Sub DetFVC_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetFVC.Leave
        Me.DetFVC.Text = Me.DetFVC.Text.Replace(".", ",")
    End Sub
    Private Sub DetFEV1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetFEV1.Leave
        Me.DetFEV1.Text = Me.DetFEV1.Text.Replace(".", ",")
    End Sub
    Private Sub DetFEV1FVC_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetFEV1FVC.Leave
        Me.DetFEV1FVC.Text = Me.DetFEV1FVC.Text.Replace(".", ",")
    End Sub
    Private Sub DetPEF_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetPEF.Leave
        Me.DetPEF.Text = Me.DetPEF.Text.Replace(".", ",")
    End Sub
    Private Sub DetFEF25_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetFEF25.Leave
        Me.DetFEF25.Text = Me.DetFEF25.Text.Replace(".", ",")
    End Sub
    Private Sub DetFEF50_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetFEF50.Leave
        Me.DetFEF50.Text = Me.DetFEF50.Text.Replace(".", ",")
    End Sub
    Private Sub DetFEF75_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetFEF75.Leave
        Me.DetFEF75.Text = Me.DetFEF75.Text.Replace(".", ",")
    End Sub
    Private Sub DetFEF2575_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetFEF2575.Leave
        Me.DetFEF2575.Text = Me.DetFEF2575.Text.Replace(".", ",")
    End Sub
    Private Sub DetFet_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetFet.Leave
        Me.DetFet.Text = Me.DetFet.Text.Replace(".", ",")
    End Sub
    Private Sub DetVEXT_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetVEXT.Leave
        Me.DetVEXT.Text = Me.DetVEXT.Text.Replace(".", ",")
    End Sub
    Private Sub BtnInformar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInformar.Click

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = "SELECT ErgoInforme.* FROM ErgoInforme WHERE ErgoInforme.IdReco=" + StrIdEpisodi + ";"

        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
        oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)

        oDataSet = Nothing
        oDataSet = New DataSet()

        Try
            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "ErgoInforme")
            oConexion.Close()
            If oDataSet.Tables("ErgoInforme").Rows.Count = 1 Then
                Dim iPosicionActual As Integer
                iPosicionActual = 0

                Dim oDataRow As DataRow
                oDataRow = oDataSet.Tables("ErgoInforme").Rows(iPosicionActual)

                If VarType(oDataRow("ErgoInforme")) <> VariantType.Null Then
                    ErgometriaInforme.ErgoInforme.Text = oDataRow("ErgoInforme")
                    ErgometriaInforme.Pacient.Text = Me.Nom.Text
                Else
                    ErgometriaInforme.ErgoInforme.Text = ""
                    ErgometriaInforme.Pacient.Text = Me.Nom.Text
                End If
            ElseIf oDataSet.Tables("ErgoInforme").Rows.Count = 0 Then
                MsgBox("Error en la creació de l'episodi" + Chr(13) + "posa't en contacte amb l'adminsitrador", , "Fisiomèdic")
                Exit Sub
            Else
                MsgBox("ERROR" + Chr(13) + "POSA'T EN CONTACTE AMB L'ADMINISTRADOR", , "Fisiomèdic")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ErgometriaInforme.ShowDialog()
    End Sub
    'Private Sub ErgoValECG2_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)
    '    MsgBox("Aquest camp només accepta valors numerics", , "Fisiomèdic")
    'End Sub
    Private Sub BtnIntroEcg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIntroEcg.Click

        Dim StrData As String
        StrData = Format(Now, "yyyyMMddHHmmss")
        Dim IntroEgcRepos As String = ""
        IntroEgcRepos = StrIdEpisodi + StrData
        Dim Pantalla() As Screen
        Pantalla = Screen.AllScreens
        If Pantalla.Length = 1 Then
            MsgBox("No existeix la pantalla de l'ECG des d'on adquirir la imatge")
            Exit Sub
        ElseIf Pantalla.Length = 2 Then

            Try
                Dim CarpetaMare As DirectoryInfo = Directory.GetParent(StrOrigenDeDades)
                Dim RutaEcg As String = CarpetaMare.FullName + "\ECG\"

                Dim pantallasu As Image
                pantallasu = TakeShotOfScreens()

                pantallasu.Save(RutaEcg + IntroEgcRepos + ".jpg")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            StrInstruccioSQL = ""
            StrInstruccioSQL = "INSERT INTO EcgRepos (IdReco, ECG)" _
                    + " SELECT " + StrIdEpisodi _
                    + ", """ + IntroEgcRepos + """;"

            ExecutarSql(StrInstruccioSQL)


            StrInstruccioSQL = "SELECT EcgRepos.ECG FROM EcgRepos WHERE EcgRepos.IdReco=" + StrIdEpisodi + " ORDER BY EcgRepos.ECG DESC;"
            Dim oDataAdapterEcgRepos As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapterEcgRepos.Fill(oDataSet, "EcgRepos")
            oConexion.Close()

            Me.DgEcg.DataSource = oDataSet
            Me.DgEcg.DataMember = "EcgRepos"

            With Me.DgEcg
                'COLOR
                .RowsDefaultCellStyle.BackColor = Color.Beige
                .BackgroundColor = Color.Beige

                'Només lectura i no es poden afegir registres
                .ReadOnly = True
                .AllowUserToAddRows = False

                'Columnes no visibles
                .RowHeadersVisible = False

                'Mides
                .Columns.Item(0).Width = CInt(Me.DgEcg.Width * 0.98)

                'Títols de columna
                .Columns.Item(0).HeaderText = "ECG"

                .Columns.Item(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter


                'No es poden canviar les mides de les files i columnes
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False

            End With
        Else
            MsgBox("Error, existeixen més de dues pantalles conectades", , "Fisiomèdic")
        End If
    End Sub
    Friend RegistreEcgRepos As String
    Private Sub DgEcg_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgEcg.CellContentDoubleClick
        RegistreEcgRepos = Me.DgEcg.Rows(e.RowIndex).Cells(0).Value()
        VeureEcgRepos.ShowDialog()
    End Sub
    Private Sub BtnModificarAptitut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModifiarAptitut.Click
        Aptitut.ShowDialog()
    End Sub
    Private Function TakeShotOfScreens() As Bitmap

        Dim maxHeight As Integer = 0
        Dim maxWidth As Integer = 0

        Dim scr As Screen
        scr = Screen.AllScreens(1)
        maxWidth += scr.Bounds.Width
        maxHeight = scr.Bounds.Height
        'For Each scr As Screen In Screen.AllScreens
        '    maxWidth += scr.Bounds.Width
        '    If scr.Bounds.Height > maxHeight Then maxHeight = scr.Bounds.Height
        'Next

        Dim NewWidth As Integer = 1030
        Dim NewHeight As Integer = 760

        'Dim allScreensCapture As New Bitmap(maxWidth, maxHeight, System.Drawing.Imaging.PixelFormat.Format64bppArgb) 'Format48bppRgb
        Dim allScreensCapture As New Bitmap(NewWidth, NewHeight, System.Drawing.Imaging.PixelFormat.Format64bppArgb)
        Dim screenGrab As Bitmap
        Dim screenSize As Size
        Dim g As Graphics

        Dim g2 As Graphics = Graphics.FromImage(allScreensCapture)
        
        Dim a As New Point(190, 100)

        For Each scr In Screen.AllScreens 'As Screen
            screenSize = New Size(NewWidth, NewHeight)
            screenGrab = New Bitmap(NewWidth, NewHeight)
            'screenSize = New Size(scr.Bounds.Width, scr.Bounds.Height)
            'screenGrab = New Bitmap(scr.Bounds.Width, scr.Bounds.Height)
            g = Graphics.FromImage(screenGrab)
            g.CopyFromScreen(a, New Point(0, 0), screenSize)
            g2.DrawImage(screenGrab, a)
            a.X += scr.Bounds.Width
            If scr.Primary = False Then
                Return screenGrab
            Else
            End If
        Next

        Return allScreensCapture
    End Function
End Class