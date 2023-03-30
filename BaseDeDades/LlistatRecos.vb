Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Enterprise.InfoStore
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System.IO
Imports System.Text
Imports System.Drawing.Printing
Imports System.Drawing.Graphics

Public Class LlistatRecos
    Friend Imatge As Bitmap
    Private oConexion As OleDb.OleDbConnection
    Private Sub LlistatRecos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.DataInici.Mask = "00/00/0000"
        Me.DataFi.Mask = "00/00/0000"

        Me.DataInici.Text = "01/01/" + CStr(Year(Now))
        Me.DataFi.Text = "31/12/" + CStr(Year(Now))

        Me.AcceptButton = Me.BtnImprimir
        Me.ControlBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "LLISTAT DE RECONEIXEMENTS" + " " + StrOrigenDeDades

        Me.Panel2.Visible = False

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT Clubs.Club FROM Clubs ORDER BY Club;"
        Dim oDataAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)


        Try
            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Clubs")
            oConexion.Close()

            Me.CbClub.DataSource = oDataSet.Tables("Clubs")
            Me.CbClub.DisplayMember = "Club"
            Me.CbClub.ValueMember = "Club"

            Me.CbClub.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.CbClub.AutoCompleteMode = AutoCompleteMode.SuggestAppend


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ConfigurarDgEquips()
    End Sub
    Private Sub CbClub_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbClub.SelectedIndexChanged

        'Elimino el DataGridView i el torno a crear de nou
        Me.DgEquips.Dispose()

        Me.DgEquips = New System.Windows.Forms.DataGridView
        Me.DgEquips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgEquips.Location = New System.Drawing.Point(448, 30)
        Me.DgEquips.Name = "DgEquips"
        Me.DgEquips.Size = New System.Drawing.Size(312, 389)
        Me.DgEquips.TabIndex = 1
        'L'incorporo al formulari
        Me.Controls.Add(Me.DgEquips)
        'I finalment l'omplo

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT Equips.Equip FROM Equips WHERE Equips.Club = """ + Me.CbClub.Text + """ ORDER BY Club;"
        Dim oDataAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        Try
            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Equips")
            oConexion.Close()

            Me.DgEquips.DataSource = oDataSet
            Me.DgEquips.DataMember = "Equips"

            Dim Columna As New System.Windows.Forms.DataGridViewCheckBoxColumn
            Me.DgEquips.Columns.Add(Columna)

            ConfigurarDgEquips()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ConfigurarDgEquips()

        If CInt(Me.DgEquips.Columns.Count) = 2 Then
            With Me.DgEquips

                'COLOR
                .RowsDefaultCellStyle.BackColor = Color.Beige
                .BackgroundColor = Color.Beige

                'COLUMNES NO VISIBLES
                .RowHeadersVisible = False 'Columna cursor lateral Selector de registre

                .AllowUserToAddRows = False 'No es poden afegir registres
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False

                'SOLO LECTURA
                .Columns.Item(0).ReadOnly = True

                'CONFIGURACIÓ DE COLUMNES
                .Columns.Item(0).HeaderText = "Equip"    'Títol de columna
                .Columns.Item(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter    'Alineació d'encapçalament columna
                .Columns(0).Width = CInt(Me.DgEquips.Width * 0.63) 'Mides
                .Columns.Item(1).HeaderText = "Llistar"
                .Columns.Item(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
                .Columns(1).Width = CInt(Me.DgEquips.Width * 0.35)

            End With

        Else
            MsgBox("error")
        End If

    End Sub
    Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimir.Click

        Dim Registres As Integer = DgEquips.Rows.Count
        Dim RegistreActual As Integer = 0
        Dim PrimerRegistre As Integer = 0
        Dim CbEquip As String = ""
        Dim CriterisSeleccio As String = ""

        For RegistreActual = 0 To Registres - 1
            If Me.DgEquips.Rows(RegistreActual).Cells(1).Value = True Then
                PrimerRegistre = PrimerRegistre + 1
                CbEquip = Me.DgEquips.Rows(RegistreActual).Cells(0).Value
                If PrimerRegistre = 1 Then
                    CriterisSeleccio = CriterisSeleccio + " AND Reconeixements.Equip=""" + CbEquip + """"
                Else
                    CriterisSeleccio = CriterisSeleccio + " OR Reconeixements.Equip = """ + CbEquip + """"
                End If
            Else
            End If
        Next
        If CriterisSeleccio = "" Then
            MsgBox("No hi ha llistats per aquests criteris de búsqueda", , "Fisiomèdic")
            Exit Sub
        End If

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        Dim DatDateInici As Date = Me.DataInici.Text
        DatDateInici = Format(DatDateInici, "short date")

        Dim DatDateFi As Date = Format(CStr(Me.DataFi.Text), "short date")

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT Reconeixements.* FROM Reconeixements WHERE Reconeixements.Club=""" + Me.CbClub.Text + """" + CriterisSeleccio + " AND Reconeixements.DataInici Between #" + CStr(DatDateInici) + "# AND #" + CStr(DatDateFi) + "#;"
        Dim oDataAdapterReconeixements As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT Clubs.* FROM Clubs WHERE Clubs.Club=""" + Me.CbClub.Text + """;"
        Dim oDataAdapterClubs As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT Terapeutes.* FROM Terapeutes;"
        Dim oDataAdapterTerapeutes As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)


        oDataSet = Nothing
        oDataSet = New DataSet

        oConexion.Open()
        oDataAdapterReconeixements.Fill(oDataSet, "Reconeixements")
        oDataAdapterClubs.Fill(oDataSet, "Clubs")
        oDataAdapterTerapeutes.Fill(oDataSet, "Terapeutes")
        oConexion.Close()

        Dim Jugadors As Integer = oDataSet.Tables("Reconeixements").Rows.Count
        Dim JugadorActual As Integer = 0

        Dim StrIdJugador As String = ""
        Dim StrIdTerapeutes As String = ""
        Dim StrIdReco As String = ""
        Dim DetReco(10) As Boolean
        Dim Observacions As String = ""
        Dim StrSexe As String = ""

        Dim StrCriterisJugador As String = ""
        Dim oDataRow As DataRow

        If Jugadors = 0 Then
            MsgBox("No hi ha Llistats per aquests criteris de búsqueda", , "Fisiomèdic")
            Exit Sub
        End If
        If Me.RbInformes.Checked = True Then
            Dim i As Integer
            i = MsgBox("Vols imprimir " + CStr(Jugadors) + " reconeixements", MsgBoxStyle.YesNo, "Fisiomèdic")
            If i = vbNo Then
                Exit Sub
            Else

            End If
        End If


        Dim Impresora As PrintDialog = New PrintDialog
        Dim NomImpresora As String = ""
        Dim Copies As Integer = 1


        With Impresora
            .AllowCurrentPage = False
            .AllowPrintToFile = False
            .AllowSelection = False
            .AllowSomePages = False
            .PrintToFile = False
            .ShowHelp = False
            .ShowNetwork = False
        End With

        If Me.RbInformes.Checked = True Then
            If (Impresora.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
                NomImpresora = Impresora.PrinterSettings.PrinterName
                Copies = Impresora.PrinterSettings.Copies
            Else
                Exit Sub
            End If
        End If

        For JugadorActual = 0 To Jugadors - 1
            oDataRow = oDataSet.Tables("Reconeixements").Rows(JugadorActual)
            StrIdJugador = oDataRow("IdPacient")
            StrIdReco = oDataRow("IdReco")
            DetReco(0) = oDataRow("Anamnesi")
            DetReco(1) = oDataRow("EcgRepos")
            DetReco(2) = oDataRow("Espirometria")
            DetReco(3) = oDataRow("ExploracioMedica")
            DetReco(4) = oDataRow("Ergometria")
            DetReco(5) = oDataRow("ExploracioPostural")
            DetReco(6) = oDataRow("EBM")
            DetReco(7) = oDataRow("Estabilometria")
            DetReco(8) = oDataRow("AntropometriaBasica")
            DetReco(9) = oDataRow("AntropometriaAvançada")
            If VarType(oDataRow("Sexe")) <> VariantType.Null Then
                StrSexe = oDataRow("Sexe")
            Else
                StrSexe = ""
            End If

            If VarType(oDataRow("Metge")) <> VariantType.Null Then
                StrIdTerapeutes = oDataRow("Metge")
            Else
                StrIdTerapeutes = "*"
            End If

            ''''''''''''ENVIO L'INFORME A LA IMPRESORA EN EL CAS DE DEMANAR INFORMES DE RECO
            If Me.RbInformes.Checked = True Then
                With Imprimint.ProgressBar1
                    .Minimum = 0
                    .Maximum = Jugadors
                    .Value = JugadorActual + 1
                    .Style = ProgressBarStyle.Continuous
                End With
                Imprimint.TextImprimir.Text = "Imprimint " + CStr(JugadorActual + 1) + " de " + CStr(Jugadors) + " reconeixements"
                Imprimint.Show()
                Imprimint.Focus()

                If Imprimint.Visible = False Then
                    MsgBox("tancat")
                Else

                End If
                ImprimirInforme(StrIdJugador, StrIdReco, StrIdTerapeutes, DetReco, StrSexe, NomImpresora, Copies)
                If JugadorActual = Jugadors - 1 Then
                    Imprimint.Close()
                    Exit Sub
                Else
                End If

            Else
            End If

            If JugadorActual = 0 Then
                StrCriterisJugador = StrCriterisJugador + " DadesPacient.IdPacient=" + StrIdJugador
            Else
                StrCriterisJugador = StrCriterisJugador + " OR DadesPacient.IdPacient=" + StrIdJugador
            End If

        Next
        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT DadesPacient.IdPacient, DadesPacient.Nom, DadesPacient.PrimerCognom, DadesPacient.SegonCognom, DadesPacient.Dni, DadesPacient.DN FROM DadesPacient WHERE " + StrCriterisJugador + ";"
        Dim oDataAdapterDadesPacient As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)


        oConexion.Open()
        oDataAdapterDadesPacient.Fill(oDataSet, "DadesPacient")
        oConexion.Close()

        Dim ColumnaPacientReco As DataColumn = oDataSet.Tables("Reconeixements").Columns.Item(0)
        Dim ColumnaPacientDadesPacient As DataColumn = oDataSet.Tables("DadesPacient").Columns.Item(0)

        Dim Relacio1 As DataRelation
        Relacio1 = New DataRelation("RelacioPacient", ColumnaPacientDadesPacient, ColumnaPacientReco)

        oDataSet.Relations.Add(Relacio1)

        If Me.RbAptitut.Checked = True Then
            If Me.RbLlista.Checked = True Then
                Dim oInforme As New InformeLlistatsRecos()

                oInforme.SetDataSource(oDataSet)
                ImprimirReco.CrvReco.ReportSource = oInforme

                ImprimirReco.Show()
            Else
                If (Impresora.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
                    NomImpresora = Impresora.PrinterSettings.PrinterName
                    Copies = Impresora.PrinterSettings.Copies


                Else
                    Exit Sub
                End If

                Dim Apte As String
                JugadorActual = 0
                For JugadorActual = 0 To Jugadors - 1
                    oDataRow = oDataSet.Tables("Reconeixements").Rows(JugadorActual)
                    If VarType(oDataRow("Aptitut")) <> VariantType.Null Then
                        Apte = oDataRow("Aptitut")
                    Else
                        Apte = ""
                    End If

                    If Apte = "APTE" Then
                        Dim oInforme As New InformeApte()
                        oInforme.SetDataSource(oDataSet)

                        oInforme.PrintOptions.PrinterName = NomImpresora
                        oInforme.PrintToPrinter(1, False, 0, 0)

                    ElseIf Apte = "NO APTE" Then

                        Dim oInforme As New InformeRecoNoConforme
                        oInforme.SetDataSource(oDataSet)

                        oInforme.PrintOptions.PrinterName = NomImpresora
                        oInforme.PrintToPrinter(1, False, 0, 0)
                    Else
                    End If
                Next
            End If


        ElseIf Me.RbLopd.Checked = True Then
            Dim oInforme As New InformeLopdRecos()

            oInforme.SetDataSource(oDataSet)
            ImprimirReco.CrvReco.ReportSource = oInforme

            ImprimirReco.Show()
        End If

    End Sub
    Private Sub ImprimirInforme(ByVal StrIdJugador As String, ByVal StrIdReco As String, ByVal StrIdTerapeutes As String, ByVal DetReco() As Boolean, ByVal StrSexe As String, ByVal NomImpresora As String, ByVal Copies As String)
        Dim ODataSetImprimir As DataSet = New DataSet
        Try
            StrInstruccioSQL = ""
            StrInstruccioSQL = "SELECT Anamnesi.* FROM Anamnesi WHERE Anamnesi.Pacient=" + StrIdJugador + ";"
            Dim oDataAdapterAnamnesi As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

            StrInstruccioSQL = "SELECT Antropometria.* FROM Antropometria WHERE Antropometria.IdReco=" + StrIdReco + ";"
            Dim oDataAdapterAntropometria As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

            StrInstruccioSQL = "SELECT Proves.* FROM Proves WHERE Proves.IdReco=" + StrIdReco + ";"
            Dim oDataAdapterProves As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

            StrInstruccioSQL = "SELECT Exploracio.* FROM Exploracio WHERE Exploracio.IdReco=" + StrIdReco + ";"
            Dim oDataAdapterExploracio As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

            StrInstruccioSQL = "SELECT Ergometria.*, ErgoInforme.*" _
                + " FROM Ergometria INNER JOIN ErgoInforme ON Ergometria.IdReco = ErgoInforme.IdReco" _
                + " WHERE Ergometria.IdReco=" + StrIdReco + ";"
            Dim oDataAdapterErgometria As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

            StrInstruccioSQL = "SELECT DadesPacient.Dni, DadesPacient.Nom, DadesPacient.PrimerCognom, DadesPacient.SegonCognom, DadesPacient.DN, Reconeixements.IdReco, Reconeixements.Club, Reconeixements.Sexe, Reconeixements.Equip, Reconeixements.Metge, Reconeixements.DataInici, Terapeutes.NumColegiat" _
                + " FROM Terapeutes INNER JOIN (DadesPacient INNER JOIN Reconeixements ON (DadesPacient.IdPacient = Reconeixements.IdPacient) AND (DadesPacient.IdPacient = Reconeixements.IdPacient)) ON Terapeutes.Terapeuta = Reconeixements.Metge" _
                + " WHERE Reconeixements.IdReco=" + StrIdReco + ";"
            Dim oDataAdapterDadesPacient As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

            StrInstruccioSQL = "SELECT Estabilometria.* FROM Estabilometria WHERE Estabilometria.IdReco=" + StrIdReco + ";"
            Dim oDataAdapterEstabilometria As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

            StrInstruccioSQL = "SELECT ExploracioPostural.* FROM ExploracioPostural WHERE ExploracioPostural.IdReco=" + StrIdReco + ";"
            Dim oDataAdapterExploracioPostural As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

            StrInstruccioSQL = "SELECT Ebm.* FROM Ebm WHERE Ebm.IdReco=" + StrIdReco + ";"
            Dim oDataAdapterEbm As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

            StrInstruccioSQL = "SELECT RecoObservacions.* FROM RecoObservacions WHERE RecoObservacions.IdReco=" + StrIdReco + ";"
            Dim oDataAdapterRecoObservacions As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

            StrInstruccioSQL = "SELECT Reconeixements.* FROM Reconeixements WHERE Reconeixements.IdReco=" + StrIdReco + ";"
            Dim oDataAdapterReconeixements As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

            StrInstruccioSQL = "SELECT Terapeutes.* FROM Terapeutes WHERE Terapeutes.Terapeuta=""" + StrIdTerapeutes + """;"
            Dim oDataAdapterTerapeutes As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

            StrInstruccioSQL = "SELECT ErgoInforme.* FROM ErgoInforme WHERE ErgoInforme.IdReco=" + StrIdReco + ";"
            Dim oDataAdapterErgoInforme As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

            StrInstruccioSQL = "SELECT EcgRepos.* FROM EcgRepos WHERE EcgRepos.IdReco=" + StrIdReco + ";"
            Dim oDataAdapterEcgRepos As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

            oConexion.Open()

            oDataAdapterDadesPacient.Fill(ODataSetImprimir, "DadesPacient")
            oDataAdapterAnamnesi.Fill(ODataSetImprimir, "Anamnesi")
            oDataAdapterAntropometria.Fill(ODataSetImprimir, "Antropometria")
            oDataAdapterProves.Fill(ODataSetImprimir, "Proves")
            oDataAdapterExploracio.Fill(ODataSetImprimir, "Exploracio")
            oDataAdapterErgometria.Fill(ODataSetImprimir, "Ergometria")
            oDataAdapterEstabilometria.Fill(ODataSetImprimir, "Estabilometria")
            oDataAdapterExploracioPostural.Fill(ODataSetImprimir, "ExploracioPostural")
            oDataAdapterEbm.Fill(ODataSetImprimir, "Ebm")
            oDataAdapterRecoObservacions.Fill(ODataSetImprimir, "RecoObservacions")
            oDataAdapterReconeixements.Fill(ODataSetImprimir, "Reconeixements")
            oDataAdapterTerapeutes.Fill(ODataSetImprimir, "Terapeutes")
            oDataAdapterErgoInforme.Fill(ODataSetImprimir, "ErgoInforme")
            oDataAdapterEcgRepos.Fill(ODataSetImprimir, "EcgRepos")

            oConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Agafo els valors antropomètrics i calculo els camps calculats
        Dim DetPes As String = ""
        Dim DetAlçada As String = ""
        Dim DetAlçadaAssegut As String = ""
        Dim DetEnvergadura As String = ""
        Dim DetPerCamaMax As String = ""
        Dim DetPerBraçRelax As String = ""
        Dim DetPcBiceps As String = ""
        Dim DetPcTriceps As String = ""
        Dim DetPcSubescapular As String = ""
        Dim DetPcCrestaIliaca As String = ""
        Dim DetPcCamaMedial As String = ""
        Dim DetNivellMaduratiu As String = ""

        Dim DetImc As String = ""
        Dim SumTricepsSubescapular As String = ""
        Dim SumTricepsCamaMedial As String = ""
        Dim PLC5 As String = ""
        Dim PercentatgeGreix As String = ""
        Dim PesGras As String = ""
        Dim PercentatgeMagre As String = ""
        Dim PesMagre As String = ""
        Dim PerimetreMsBraç As String = ""
        Dim PerimetreMsCama As String = ""
        Dim IndexCormic As String = ""
        Dim IndexEsqueletic As String = ""
        Dim EnvergaduraRelativa As String = ""

        Try
            Dim iPosicionActual As Integer = 0



            Dim oDataRowAntropometria As DataRow
            oDataRowAntropometria = ODataSetImprimir.Tables("Antropometria").Rows(iPosicionActual)

            If VarType(oDataRowAntropometria("Pes")) <> VariantType.Null Then
                DetPes = oDataRowAntropometria("Pes")
            Else
                DetPes = 0
            End If

            If VarType(oDataRowAntropometria("Alçada")) <> VariantType.Null Then
                DetAlçada = oDataRowAntropometria("Alçada")
            Else
                DetAlçada = 0
            End If

            If VarType(oDataRowAntropometria("AlçadaAssegut")) <> VariantType.Null Then
                DetAlçadaAssegut = oDataRowAntropometria("AlçadaAssegut")
            Else
                DetAlçadaAssegut = 0
            End If

            If VarType(oDataRowAntropometria("Envergadura")) <> VariantType.Null Then
                DetEnvergadura = oDataRowAntropometria("Envergadura")
            Else
                DetEnvergadura = 0
            End If

            If VarType(oDataRowAntropometria("PerimetreCamaMaxima")) <> VariantType.Null Then
                DetPerCamaMax = oDataRowAntropometria("PerimetreCamaMaxima")
            Else
                DetPerCamaMax = 0
            End If

            If VarType(oDataRowAntropometria("PerimetreBraçRelax")) <> VariantType.Null Then
                DetPerBraçRelax = oDataRowAntropometria("PerimetreBraçRelax")
            Else
                DetPerBraçRelax = 0
            End If

            If VarType(oDataRowAntropometria("PCBiceps")) <> VariantType.Null Then
                DetPcBiceps = oDataRowAntropometria("PCBiceps")
            Else
                DetPcBiceps = 0
            End If

            If VarType(oDataRowAntropometria("PCTriceps")) <> VariantType.Null Then
                DetPcTriceps = oDataRowAntropometria("PCTriceps")
            Else
                DetPcTriceps = 0
            End If

            If VarType(oDataRowAntropometria("PCSubescapular")) <> VariantType.Null Then
                DetPcSubescapular = oDataRowAntropometria("PCSubescapular")
            Else
                DetPcSubescapular = 0
            End If

            If VarType(oDataRowAntropometria("PCCrestaIliaca")) <> VariantType.Null Then
                DetPcCrestaIliaca = oDataRowAntropometria("PCCrestaIliaca")
            Else
                DetPcCrestaIliaca = 0
            End If

            If VarType(oDataRowAntropometria("PCCamaMedial")) <> VariantType.Null Then
                DetPcCamaMedial = oDataRowAntropometria("PCCamaMedial")
            Else
                DetPcCamaMedial = 0
            End If

            If VarType(oDataRowAntropometria("NivellMaduratiu")) <> VariantType.Null Then
                DetNivellMaduratiu = oDataRowAntropometria("NivellMaduratiu")
            Else
                DetNivellMaduratiu = ""
            End If




            'Càlcul IMC
            If Convert.ToDouble(DetAlçada) <> 0 And Convert.ToDouble(DetPes) <> 0 Then
                DetImc = Format(Convert.ToDouble((Convert.ToDouble(DetPes) / (Convert.ToDouble(DetAlçada) * Convert.ToDouble(DetAlçada)))), "0.000")
            Else
                DetImc = 0
            End If

            'Càlcul Suma plecs cutanis Triceps + Subescapular
            SumTricepsSubescapular = Convert.ToDouble(DetPcTriceps) + Convert.ToDouble(DetPcSubescapular)

            'Càlcul Suma plecs cutanis Triceps + Cama medial
            SumTricepsCamaMedial = Convert.ToDouble(DetPcTriceps) + Convert.ToDouble(DetPcCamaMedial)

            'Càlcul 5 PLC
            PLC5 = Convert.ToDouble(DetPcBiceps) + Convert.ToDouble(DetPcTriceps) + Convert.ToDouble(DetPcSubescapular) + Convert.ToDouble(DetPcCamaMedial) + Convert.ToDouble(DetPcCrestaIliaca)

            'Càlcul % de greix
            Dim PLC4 As Double
            PLC4 = Convert.ToDouble(DetPcBiceps) + Convert.ToDouble(DetPcTriceps) + Convert.ToDouble(DetPcSubescapular) + Convert.ToDouble(DetPcCrestaIliaca)

            If StrSexe = "MASCULÍ" Then
                If DetNivellMaduratiu = "PRE-PUBERAL" Then
                    PercentatgeGreix = Format(26.56 * (Math.Log(PLC4)) - 22.23, "0.000")

                ElseIf DetNivellMaduratiu = "PUBERAL" Then
                    PercentatgeGreix = Format(18.7 * (Math.Log(PLC4)) - 11.91, "0.000")

                ElseIf DetNivellMaduratiu = "POST-PUBERAL" Then
                    PercentatgeGreix = Format(18.88 * (Math.Log(PLC4)) - 15.58, "0.000")
                Else
                    PercentatgeGreix = 0
                End If
            ElseIf Text = "FEMENÍ" Then
                If DetNivellMaduratiu = "PRE-PUBERAL" Then
                    PercentatgeGreix = Format(29.85 * (Math.Log(PLC4)) - 25.87, "0.000")

                ElseIf DetNivellMaduratiu = "PUBERAL" Then
                    PercentatgeGreix = Format(23.94 * (Math.Log(PLC4)) - 18.89, "0.000")

                ElseIf DetNivellMaduratiu = "POST-PUBERAL" Then
                    PercentatgeGreix = Format(39.02 * (Math.Log(PLC4)) - 43.49, "0.000")
                Else
                    PercentatgeGreix = 0
                End If
            Else
                PercentatgeGreix = 0
            End If

            'Càlcul Pes gras
            PesGras = Format((Convert.ToDouble(PercentatgeGreix) * Convert.ToDouble(DetPes)) / 100, "0.000")

            'Càlcul Percentage magre
            PercentatgeMagre = Format(100 - Convert.ToDouble(PesGras), "0.000").ToString

            'Càlcul Pes magre
            PesMagre = Format(Convert.ToDouble(DetPes) - Convert.ToDouble(PesGras), "0.000").ToString

            'Calcul Perimetre muscular del braç
            PerimetreMsBraç = Format(Convert.ToDouble(DetPerBraçRelax) - 3.1416 * (Convert.ToDouble(DetPcTriceps) / 10), "0.000").ToString

            'Càlcul Perimetre muscular de la cama
            PerimetreMsCama = Format(Convert.ToDouble(DetPerCamaMax) - 3.1416 * (Convert.ToDouble(DetPcCamaMedial) / 10), "0.000").ToString

            'Càlcul Index còrmic
            IndexCormic = Format(((Convert.ToDouble(DetAlçadaAssegut) * 100) / (Convert.ToDouble(DetAlçada) * 100) * 100), "0.000").ToString

            'Càlcul Index esqueletic
            IndexEsqueletic = Format((((Convert.ToDouble(DetAlçada) * 100) - (Convert.ToDouble(DetAlçadaAssegut) * 100)) / (Convert.ToDouble(DetAlçadaAssegut) * 100) * 100), "0.000").ToString

            'Càlcul Envergadura relativa
            EnvergaduraRelativa = Format(((Convert.ToDouble(DetEnvergadura) * 100) / (Convert.ToDouble(DetAlçada) * 100)) * 100, "0.000").ToString

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




        'ASSIGNO INFORME

        Dim Informe As New InformeReco
        Informe.SetDataSource(ODataSetImprimir)

        'Configuració de les parts de l'informe visibles o no segons el tipus de reconeixement
        'ERGOMETRIA
        If DetReco(4) = False Then
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
        If DetReco(7) = False Then
            Informe.DetailSection10.SectionFormat.EnableSuppress = True
        Else
            Informe.DetailSection10.SectionFormat.EnableSuppress = False
        End If

        'ESPIROMETRIA
        If DetReco(2) = False Then
            Informe.DetailSection51.SectionFormat.EnableSuppress = True
        Else
            Informe.DetailSection51.SectionFormat.EnableSuppress = False
        End If

        ''EBM
        If DetReco(6) = False Then
            Informe.DetailSection3.SectionFormat.EnableSuppress = True
            Informe.DetailSection4.SectionFormat.EnableSuppress = True
        Else
            Informe.DetailSection3.SectionFormat.EnableSuppress = False
            Informe.DetailSection4.SectionFormat.EnableSuppress = False
        End If

        'ANTROPOMETRIA AVANÇADA
        If DetReco(9) = False Then
            Informe.DetailSection48.SectionFormat.EnableSuppress = True
            Informe.DetailSection49.SectionFormat.EnableSuppress = True
        Else
            Informe.DetailSection48.SectionFormat.EnableSuppress = False
            Informe.DetailSection49.SectionFormat.EnableSuppress = False
        End If


        'CAMPS DE FÓRMULA
        Informe.DataDefinition.FormulaFields.Item("IMC").Text = """" + DetImc + """"
        With Informe.DataDefinition.FormulaFields
            .Item("SumPcTricepsSubescapular").Text = """" + SumTricepsSubescapular + "mm"""
            .Item("SumPcTricepsCamaMedial").Text = """" + SumTricepsCamaMedial + "mm"""
            .Item("5PLC").Text = """" + PLC5 + "mm"""
            .Item("PerMsBraç").Text = """" + PerimetreMsBraç + """"
            .Item("PerMsCama").Text = """" + PerimetreMsCama + """"
            .Item("PercentatgeGreix").Text = """" + PercentatgeGreix + """"
            .Item("PercentatgeMagre").Text = """" + PercentatgeMagre + """"
            .Item("PesGras").Text = """" + PesGras + """"
            .Item("PesMagre").Text = """" + PesMagre + """"
            .Item("IndexCornic").Text = """" + IndexCormic + """"
            .Item("IndexEsqueletic").Text = """" + IndexEsqueletic + """"
            .Item("EnvergaduraRelativa").Text = """" + EnvergaduraRelativa + """"
        End With

        With Informe.PrintOptions
            .PaperOrientation = CrystalDecisions.Shared.PaperOrientation.DefaultPaperOrientation
            .PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
            .PaperSource = CrystalDecisions.Shared.PaperSource.Auto
            .PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default
            .PrinterName = NomImpresora
        End With


        'Agafar l'ECG per imprimir
        Dim CarpetaMare As DirectoryInfo = Directory.GetParent(StrOrigenDeDades)
        Dim RegistreEcg As String = ""
        Dim EcgArxiu As Bitmap = Nothing
        Dim CopiaActual As Integer = 1
        For CopiaActual = 1 To Copies
            Informe.PrintToPrinter(1, False, 0, 0)
            Try
                If ODataSetImprimir.Tables("EcgRepos").Rows.Count > 0 Then
                    Dim iPosicionActual As Integer = 0
                    Dim oDataRowEcgRepos As DataRow
                    Dim RutaEcg As String
                    oDataRowEcgRepos = ODataSetImprimir.Tables("EcgRepos").Rows(iPosicionActual)
                    For iPosicionActual = 0 To ODataSetImprimir.Tables("EcgRepos").Rows.Count - 1
                        If VarType(oDataRowEcgRepos("ECG")) <> VariantType.Null Then
                            RegistreEcg = oDataRowEcgRepos("ECG")
                        Else
                            DetPes = 0
                        End If
                        RutaEcg = CarpetaMare.FullName + "\ECG\" + RegistreEcg + ".jpg"
                        'RutaEcg = "C:\OrigenDades\ECG\20100506103242.jpg"
                        If File.Exists(RutaEcg) = True Then
                            Imatge = New Bitmap(RutaEcg)
                            With Me.PrintDocument1
                                .PrinterSettings.PrinterName = NomImpresora
                                .DefaultPageSettings.Landscape = True
                            End With
                            Me.PrintDocument1.Print()
                        Else
                            MsgBox("Error en la localització de l'ECG" + Chr(13) + "Comprova que s'hagi introduit correctament el nom de l'arxiu", MsgBoxStyle.OkOnly, "Fisiomèdic")
                            EcgArxiu = Nothing
                        End If
                    Next
                Else
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
    End Sub
    Private Sub DataInici_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataInici.Leave
        Try
            Me.DataInici.Text = Format(Me.DataInici.Text, "short date")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DataFi_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataFi.Leave
        Try
            Me.DataFi.Text = Format(Me.DataFi.Text, "short date")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSortir.Click
        Me.Close()
    End Sub
    Private Sub RbAptitut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbAptitut.CheckedChanged
        If Me.RbAptitut.Checked = True Then
            Me.Panel2.Visible = True
            Me.RbLlista.Checked = True
        Else
            Me.Panel2.Visible = False
        End If
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim RutaEcg As String = "C:\OrigenDades\ECG\20100506103242.jpg"
        Dim Imatge As New Bitmap(RutaEcg)

        e.Graphics.DrawImage(Imatge, 0, 0)

    End Sub
End Class