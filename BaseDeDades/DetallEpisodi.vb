Public Class DetallEpisodi
    Friend i As Integer = 3
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection

    Private Sub DetallEpisodi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DetEpisodiCarregarDades()
        RecompteSessions()
        Me.Text = "DETALL EPISODI" + " " + StrOrigenDeDades

    End Sub
    Friend Sub DetEpisodiCarregarDades()

        Me.ControlBox = False

        StrInstruccioSQL = ""
        StrCadenaConexio = ""
        StrIdAssistencia = ""

        Dim BolAlta As Boolean
        Dim BolFactura As Boolean

        Me.DetMutua.Visible = True
        Me.ModMutua.Visible = False
        Me.Button1.Visible = True   'Modificar
        Me.Button2.Visible = False  'OK
        Me.Avui.Checked = True

        'AGAFO LES DADES DEL PACIENT I COLOCO EL SEU NOM AL PRINCIPI DEL FORMULARI
        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        Dim StrNom As String
        StrNom = "DadesPacient.Nom & " + """ """ + "& DadesPacient.PrimerCognom &" + """ """ + "& DadesPacient.SegonCognom"
        StrInstruccioSQL = "SELECT DadesPacient.IdPacient," + StrNom + " AS Pacient FROM DadesPacient" _
           + " WHERE DadesPacient.IdPacient=" + StrIdPacient + ";"

        oDataSet = Nothing
        oDataSet = New DataSet

        Try
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "DadesPacient")
            oConexion.Close()

            Dim iPosicionActual As Integer
            iPosicionActual = 0
            Dim oDataRow As DataRow
            oDataRow = oDataSet.Tables("DadesPacient").Rows(iPosicionActual)

            If VarType(oDataRow("Pacient")) <> VariantType.Null Then
                Me.Pacient.Text = oDataRow("Pacient")
            Else
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'A PARTIR D'AQUI, AGAFO DADES DE L'EPISODI I OMPLO ELS CAMPS DEL FORMULARI

        StrInstruccioSQL = "SELECT Episodis.* FROM Episodis WHERE Episodis.IdEpisodi =" + StrIdEpisodi + ";"

        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
        oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
        oDataSet = New DataSet()

        Try
            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Episodis")
            oConexion.Close()

            Dim iPosicionActual As Integer
            iPosicionActual = 0
            Dim oDataRow As DataRow
            oDataRow = oDataSet.Tables("Episodis").Rows(iPosicionActual)

            If VarType(oDataRow("Mutua")) <> VariantType.Null Then
                Me.DetMutua.Text = oDataRow("Mutua")
            Else
            End If

            If VarType(oDataRow("NumTargeta")) <> VariantType.Null Then
                Me.DetNumTargeta.Text = oDataRow("NumTargeta")
            Else
            End If

            If VarType(oDataRow("NumAutoritzacio")) <> VariantType.Null Then
                Me.DetNumAutoritzacio.Text = oDataRow("NumAutoritzacio")
            Else
            End If

            If VarType(oDataRow("SesAutoritzades")) <> VariantType.Null Then
                Me.DetSesAutoritzades.Text = oDataRow("SesAutoritzades")
            Else
            End If

            If VarType(oDataRow("DataInici")) <> VariantType.Null Then
                Me.DetDataInici.Text = oDataRow("DataInici")
            Else
            End If

            If VarType(oDataRow("DataFi")) <> VariantType.Null Then
                Me.DetDataFi.Text = oDataRow("DataFi")
            Else
            End If

            If VarType(oDataRow("PreuSessio")) <> VariantType.Null Then
                Me.DetPreuSessio.Text = CStr(oDataRow("PreuSessio")) + "€"

            Else
            End If

            BolAlta = oDataRow("Alta")
            BolFactura = oDataRow("Factura")


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Carrego les dades d'Assistència al DataGridView

        Try

            StrInstruccioSQL = "SELECT Assistencia.IdAssistencia, Assistencia.Data, Assistencia.Assistencia FROM Assistencia WHERE Assistencia.IdEpisodi =" + StrIdEpisodi _
            + " ORDER BY Assistencia.Data;"

            oConexion = New OleDb.OleDbConnection
            oConexion.ConnectionString = StrCadenaConexio
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)

            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Assistencia")
            oConexion.Close()

            Me.DgAssistencia.DataSource = oDataSet
            Me.DgAssistencia.DataMember = "Assistencia"

        Catch ex As Exception

            MsgBox(ex.Message)
        End Try

        ConfiguraDgAssistencia()
        RecompteSessions()
        ConfigurarBotons(BolAlta, BolFactura)


    End Sub
    Private Sub RecompteSessions()


        'Carrego el recompte de sessions que porta fetes el pacient
        Try
            oDataSet = Nothing
            oConexion = New OleDb.OleDbConnection
            StrInstruccioSQL = ""

            StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
            oConexion.ConnectionString = StrCadenaConexio

            StrInstruccioSQL = "SELECT Count(Assistencia.IdAssistencia) AS SesQuePorta, Assistencia.IdEpisodi" _
                + " FROM Assistencia" _
                + " GROUP BY Assistencia.IdEpisodi" _
                + " HAVING Assistencia.IdEpisodi=" + StrIdEpisodi + ";"


            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)

            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Assistencia")
            oConexion.Close()

            Dim Files As Integer
            Files = oDataSet.Tables("Assistencia").Rows.Count

            If Files = 1 Then
                Dim iPosicionActual As Integer
                iPosicionActual = 0
                Dim oDataRow As DataRow
                oDataRow = (oDataSet.Tables("Assistencia").Rows(iPosicionActual))

                If VarType(oDataRow("SesQuePorta")) <> VariantType.Null Then
                    Me.SesPorta.Text = oDataRow("SesQuePorta")
                Else
                End If

            ElseIf Files = 0 Then
                Me.SesPorta.Text = 0

            Else
                MsgBox("Error per duplicació d'index" + Chr(13) + "posa't en contacte amb l'administrador", 16, "Fisiomèdic")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Si les sessions que porta, són les mateixes que te autoritzades, no se'n poden afegir més
        If CInt(Me.SesPorta.Text) = CInt(Me.DetSesAutoritzades.Text) Then
            Me.Button3.Visible = False

        ElseIf CInt(Me.SesPorta.Text) < CInt(Me.DetSesAutoritzades.Text) Then   'Més ses autoritzades que fetes
            Me.Button3.Visible = True
        Else
            'Més ses fetes que autoritzades, no hauria de passar mai, però pot passar si modifiquem les
            'sessions autoritzades quant ja en porta de fetes, (ex. de 15 a 10 quant en porta 11) 

            MsgBox("Porta més sessions fetes que autoritzades" + Chr(13) + "Comprova l'error i corretgeix-lo si es necessari", MsgBoxStyle.Critical, "Fisiomèdic")

        End If
    End Sub
    Private Sub ConfiguraDgAssistencia()

        Me.DgAssistencia.ReadOnly = True
        Me.DgAssistencia.RowHeadersVisible = False
        Me.DgAssistencia.Columns.Item(0).Visible = False
        Me.DgAssistencia.AllowUserToResizeColumns = False
        Me.DgAssistencia.AllowUserToResizeRows = False
        Me.DgAssistencia.AllowUserToAddRows = False
        Me.DgAssistencia.Columns.Item(1).Width = CInt(Me.DetPreuSessio.Width * 0.85)
        Me.DgAssistencia.Columns.Item(2).Width = CInt(Me.DgAssistencia.Width * 0.505)

        Me.DgAssistencia.Columns.Item(1).HeaderText = "DATA"
        Me.DgAssistencia.Columns.Item(2).HeaderText = "ASSISTÈCIA"

        Me.DgAssistencia.Columns.Item(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Me.DgAssistencia.Columns.Item(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DgAssistencia.Columns.Item(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        'Me.DgPacients.Columns.Item(1).HeaderText = "PRIMER COGNOM"
        'Me.DgPacients.Columns.Item(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        'Me.DgPacients.Columns(1).Width = CInt(Me.DgPacients.Width * 0.2)

        Me.DgAssistencia.RowsDefaultCellStyle.BackColor = Color.Beige
        Me.DgAssistencia.BackgroundColor = Color.Beige

        Me.DgAssistencia.TabStop = False





    End Sub
    Private Sub BotoModificar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.DetNumTargeta.ReadOnly = False
        Me.DetNumTargeta.BackColor = Color.White
        Me.DetNumTargeta.BorderStyle = BorderStyle.Fixed3D

        Me.DetNumAutoritzacio.ReadOnly = False
        Me.DetNumAutoritzacio.BackColor = Color.White
        Me.DetNumAutoritzacio.BorderStyle = BorderStyle.Fixed3D

        Me.DetSesAutoritzades.ReadOnly = False
        Me.DetSesAutoritzades.BackColor = Color.White
        Me.DetSesAutoritzades.BorderStyle = BorderStyle.Fixed3D

        Me.DetDataInici.ReadOnly = False
        Me.DetDataInici.BackColor = Color.White
        Me.DetDataInici.BorderStyle = BorderStyle.Fixed3D

        Me.DetDataFi.ReadOnly = False
        Me.DetDataFi.BackColor = Color.White
        Me.DetDataFi.BorderStyle = BorderStyle.Fixed3D

        Me.DetPreuSessio.ReadOnly = False
        Me.DetPreuSessio.BackColor = Color.White
        Me.DetPreuSessio.BorderStyle = BorderStyle.Fixed3D

        Me.DetMutua.Visible = False
        Me.ModMutua.Visible = True

        Me.Button1.Visible = False  'Modificar
        Me.Button2.Visible = True   'OK
        Me.Button4.Visible = False    'Sortir

        'CARREGO DADES AL COMBOBOX

        StrInstruccioSQL = ""
        StrCadenaConexio = ""


        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        Dim StrInstruccioSQLMuta As String
        StrInstruccioSQLMuta = "SELECT Mutues.Nom FROM Mutues WHERE Mutues.Nom <> """ + "RECONEIXEMENT MÈDIC" + """;"

        Try
            Dim oDataAdapterTp As New OleDb.OleDbDataAdapter(StrInstruccioSQLMuta, oConexion)
            Dim oCbTp As OleDb.OleDbCommandBuilder = New OleDb.OleDbCommandBuilder(oDataAdapterTp)
            Dim oDataSetTp As New DataSet()

            oDataAdapterTp.Fill(oDataSetTp, "Mutues")
            Me.ModMutua.DataSource = oDataSetTp.Tables("Mutues")
            Me.ModMutua.DisplayMember = "Nom"
            Me.ModMutua.ValueMember = "Nom"

            Me.ModMutua.Text = Me.DetMutua.Text
            Me.ModMutua.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.ModMutua.AutoCompleteMode = AutoCompleteMode.SuggestAppend


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub BotoOK(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Button1.Visible = True
        Me.Button2.Visible = False
        Me.Button4.Visible = True

        Me.DetNumTargeta.ReadOnly = True
        Me.DetNumTargeta.BackColor = Color.Beige
        Me.DetNumTargeta.BorderStyle = BorderStyle.None

        Me.DetNumAutoritzacio.ReadOnly = True
        Me.DetNumAutoritzacio.BackColor = Color.Beige
        Me.DetNumAutoritzacio.BorderStyle = BorderStyle.None

        Me.DetSesAutoritzades.ReadOnly = True
        Me.DetSesAutoritzades.BackColor = Color.Beige
        Me.DetSesAutoritzades.BorderStyle = BorderStyle.None

        Me.DetDataInici.ReadOnly = True
        Me.DetDataInici.BackColor = Color.Beige
        Me.DetDataInici.BorderStyle = BorderStyle.None

        Me.DetDataFi.ReadOnly = True
        Me.DetDataFi.BackColor = Color.Beige
        Me.DetDataFi.BorderStyle = BorderStyle.None

        Me.DetPreuSessio.ReadOnly = True
        Me.DetPreuSessio.BackColor = Color.Beige
        Me.DetPreuSessio.BorderStyle = BorderStyle.None

        Me.DetMutua.Visible = True
        Me.ModMutua.Visible = False

        StrInstruccioSQL = ""
        If Me.DetDataInici.Text = "" And Me.DetDataFi.Text = "" Then    'Inici i fi buides

            StrInstruccioSQL = "UPDATE Episodis SET Episodis.Mutua = """ + Me.ModMutua.Text _
                        + """, Episodis.NumTargeta = """ + Me.DetNumTargeta.Text _
                        + """, Episodis.NumAutoritzacio = """ + Me.DetNumAutoritzacio.Text _
                        + """, Episodis.SesAutoritzades = " + Me.DetSesAutoritzades.Text _
                        + ", Episodis.DataInici = null" _
                        + ", Episodis.DataFi = null" _
                        + ", Episodis.PreuSessio=""" + Me.DetPreuSessio.Text _
                        + """ WHERE Episodis.IdEpisodi=" + StrIdEpisodi + ";"


        ElseIf Me.DetDataInici.Text = "" And Me.DetDataFi.Text <> "" Then   'Inici buida, fi plena

            StrInstruccioSQL = "UPDATE Episodis SET Episodis.Mutua = """ + Me.ModMutua.Text _
                        + """, Episodis.NumTargeta = """ + Me.DetNumTargeta.Text _
                        + """, Episodis.NumAutoritzacio = """ + Me.DetNumAutoritzacio.Text _
                        + """, Episodis.SesAutoritzades = " + Me.DetSesAutoritzades.Text _
                        + ", Episodis.DataInici = null" _
                        + ", Episodis.DataFi = '" + Me.DetDataFi.Text _
                        + "', Episodis.PreuSessio=""" + Me.DetPreuSessio.Text _
                        + """ WHERE Episodis.IdEpisodi=" + StrIdEpisodi + ";"


        ElseIf Me.DetDataInici.Text <> "" And Me.DetDataFi.Text = "" Then   'Inici plena, fi buida

            StrInstruccioSQL = "UPDATE Episodis SET Episodis.Mutua = """ + Me.ModMutua.Text _
                        + """, Episodis.NumTargeta = """ + Me.DetNumTargeta.Text _
                        + """, Episodis.NumAutoritzacio = """ + Me.DetNumAutoritzacio.Text _
                        + """, Episodis.SesAutoritzades = " + Me.DetSesAutoritzades.Text _
                        + ", Episodis.DataInici = '" + Me.DetDataInici.Text _
                        + "', Episodis.DataFi = null" _
                        + ", Episodis.PreuSessio=""" + Me.DetPreuSessio.Text _
                        + """ WHERE Episodis.IdEpisodi=" + StrIdEpisodi + ";"


        Else    'Inici plena, fi plena

            StrInstruccioSQL = "UPDATE Episodis SET Episodis.Mutua = """ + Me.ModMutua.Text _
                        + """, Episodis.NumTargeta = """ + Me.DetNumTargeta.Text _
                        + """, Episodis.NumAutoritzacio = """ + Me.DetNumAutoritzacio.Text _
                        + """, Episodis.SesAutoritzades = " + Me.DetSesAutoritzades.Text _
                        + ", Episodis.DataInici = '" + Me.DetDataInici.Text _
                        + "', Episodis.DataFi = '" + Me.DetDataFi.Text _
                        + "', Episodis.PreuSessio=""" + Me.DetPreuSessio.Text _
                        + """ WHERE Episodis.IdEpisodi=" + StrIdEpisodi + ";"

        End If

        'INICIO TRANSACCIÓ
        PeticioExecutada = 1
        PeticioExecutada = ExecutarSql(StrInstruccioSQL)

        If PeticioExecutada = 1 Then
            While Not PeticioExecutada = 0
                Dim i As Integer
                i = MsgBox("ERROR EN LA GRABACIÓ DE LES DADES", MsgBoxStyle.AbortRetryIgnore, "Fisiomèdic")
                If i = vbRetry Then
                    PeticioExecutada = ExecutarSql(StrInstruccioSQL)
                ElseIf i = vbAbort Then
                    Exit Sub
                Else
                    Exit While
                End If
            End While
        End If
        'SEGON UPDATE
        '..............
        'FI TRANSACCIÓ
        DetEpisodiCarregarDades()
    End Sub
    Private Sub DetPreuSessio_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetPreuSessio.Leave

        Dim StrPreuComa As String

        StrPreuComa = Me.DetPreuSessio.Text.Replace(".", ",")

        Me.DetPreuSessio.Text = StrPreuComa + "€"
    End Sub
    Private Sub IntroduirAssistencia(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        StrInstruccioSQL = ""

        Dim DataIntro As Date

        If Me.Avui.Checked = True Then

            DataIntro = Now

            DataIntro = Format(DataIntro, "short date")

        Else

            Dim strData As String

            strData = InputBox("Introdueix data d'assistència", "Fisiomèdic")

            If strData = "" Then    'Si no s'introdueix cap dada o es pulsa cancelar, retorna ""

                MsgBox("OPERACIÓ CANCELADA", , "Fisiomèdic")

                Exit Sub
            Else

                DataIntro = Format(CDate(strData), "short date")

            End If

        End If

        'Creo la intrucció SQL segons la opció data i el seu valor i la executo
        StrInstruccioSQL = "INSERT INTO Assistencia ( IdEpisodi, Data, Assistencia )" _
        + " SELECT " + StrIdEpisodi + ", '" + DataIntro + "', true;"

        ExecutarSql(StrInstruccioSQL)
        DetEpisodiCarregarDades()
    End Sub
    Private Sub DgAssistencia_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgAssistencia.CellContentClick
        StrIdAssistencia = Me.DgAssistencia.Rows(e.RowIndex).Cells(0).Value()
    End Sub
    Private Sub DgAssistencia_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgAssistencia.CellContentDoubleClick
        Dim Formulari As New ModificarAssistencia
        Formulari.Show()
    End Sub
    Private Sub BtnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrar.Click

        If StrIdAssistencia = "" Then
            MsgBox("Selecciona el registre que vols borrar", , "Fisiomèdic")

        Else

            StrInstruccioSQL = "DELETE Assistencia.* FROM Assistencia" _
            + " WHERE Assistencia.IdAssistencia=" + StrIdAssistencia + ";"

            ExecutarSql(StrInstruccioSQL)
            DetEpisodiCarregarDades()
           
        End If
    End Sub
    Private Sub BtnAltaEpisodi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAltaEpisodi.Click

        Dim i As Integer

        If CInt(Me.SesPorta.Text) > CInt(Me.DetSesAutoritzades.Text) Then
            MsgBox("No es poden haver fet més sessions que les autoritzades" + Chr(13) + "Modifica l'error", MsgBoxStyle.Critical, "Fisiomèdic")
            Exit Sub
        End If

        If CInt(Me.SesPorta.Text) < CInt(Me.DetSesAutoritzades.Text) Then
            i = MsgBox("No s'han realitzat totes les sessions" + Chr(13) + "Vols donar d'alta l'episodi", 36, "Fisiomèdic")

            If i = vbYes Then
            Else
                Exit Sub
            End If
        End If

        StrInstruccioSQL = "UPDATE Episodis SET" _
                + " Episodis.Alta= True" _
                + " WHERE Episodis.IdEpisodi=" + StrIdEpisodi + ";"

        ExecutarSql(StrInstruccioSQL)
        DetEpisodiCarregarDades()
    End Sub
    Private Sub DetDataInici_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetDataInici.Leave
        Try
            Me.DetDataInici.Text = Format(Me.DetDataInici.Text, "short date")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub DetDataFi_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetDataFi.Leave
        Try
            Me.DetDataFi.Text = Format(Me.DetDataFi.Text, "short date")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BtnSeguirTractament_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeguirTractament.Click

        StrInstruccioSQL = "UPDATE Episodis SET" _
                    + " Episodis.Alta= False" _
                    + " WHERE Episodis.IdEpisodi=" + StrIdEpisodi + ";"

        ExecutarSql(StrInstruccioSQL)
        DetEpisodiCarregarDades()
    End Sub
    Private Sub ConfigurarBotons(ByVal BolAlta As Boolean, ByVal BolFactura As Boolean)

        If BolAlta = True Then
            Me.BtnAltaEpisodi.Visible = False
            Me.BtnSeguirTractament.Visible = True
            Me.Button3.Visible = False  'Introduir assistencia
            Me.Panel2.Visible = False   'Requadre introduir assistencia
            Me.BtnBorrar.Visible = False    'Borrar Assistencia
        Else
            Me.BtnAltaEpisodi.Visible = True
            Me.BtnSeguirTractament.Visible = False
            Me.Button3.Visible = True  'Introduir assistencia
            Me.Panel2.Visible = True   'Requadre introduir assistencia
            Me.BtnBorrar.Visible = True    'Borrar Assistencia

            If SesPorta.Text = 0 Then
                Me.BtnBorrar.Visible = False
                Me.BtnAltaEpisodi.Visible = False
            ElseIf SesPorta.Text = DetSesAutoritzades.Text Then
                Me.Button3.Visible = False
                Me.Panel2.Visible = False

            End If
        End If

        If BolFactura = True Then
            Me.BtnFacturar.Visible = False
        Else
            Me.BtnFacturar.Visible = True

        End If
    End Sub
    Private Sub BtnFacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFacturar.Click

        'Per tal de facturar un episodi, s'ha de tenir en compte que la numeració ha de ser consecutiva, sense 
        'cap forat entremig i no hi pot haver cap factura amb numeració posterior i data anterior.
        'Per tant, primer haurem de buscar quina és la última factura realitzada, agafar el seu número i la
        'seva data d'emisió, per poder assignar el número següent al que tenim i la data igual o major que la 
        'optinguda. Si no existisin factures, demanarem la data i el número a l'usuari. Per altre banda, si la 
        'última factura és de l'any anterior a l'actual, demanarem també el número de factura, ja que la
        'numeració de les factures serà de 5 dígits, sent els dos primers els corresponents a l'any. 09001 (2009)

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Comprovo que les dades que són obligatòries hi siguin
        If Me.DetDataFi.Text = "" Then
            MsgBox("La data de Fi d'Episodi és valor obligatori", , "Fisiomèdic")
            Exit Sub
        ElseIf Me.DetSesAutoritzades.Text = 0 Or Me.DetSesAutoritzades.Text = "" Then
            MsgBox("Les Sessions autoritzades són un camp obligatori i no poden ser 0", , "Fisiomèdic")
            Exit Sub
        ElseIf Me.DetPreuSessio.Text = 0 Then
            MsgBox("El preu de les sessions no pot ser 0", , "Fisiomèdic")
            Exit Sub
        End If

        'Comprovo que la numeració de les factures sigui correlativa
        Dim Correlatiu As Integer
        Correlatiu = FacturesConsecutives()
        If Correlatiu = 1 Then
            MsgBox("Error en la numeració de les factures" + Chr(13) + "posa't en contacte amb l'administrador", , "Fisiomèdic")
            Exit Sub
        Else
        End If
        'Miro si existeix alguna factura compatible amb aquest episodi
        'Per començar, comprovo el tipus de mutua que pertany aquest espisodi (Privat o NoPrivat)
        StrInstruccioSQL = ""
        oDataSet = Nothing

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1(")
        oConexion.ConnectionString = StrCadenaConexio

        Dim StrTipusMutua As String
        StrInstruccioSQL = "SELECT Mutues.Nom, Mutues.Tipus" _
                        + " FROM Mutues" _
                        + " WHERE Mutues.Nom= """ + Me.DetMutua.Text + """;"

        Try
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Factures")
            oConexion.Close()

            Dim iPosicionActual As Integer
            iPosicionActual = 0
            Dim oDataRow As DataRow
            oDataRow = oDataSet.Tables("Factures").Rows(iPosicionActual)

            If VarType(oDataRow("Tipus")) <> VariantType.Null Then
                StrTipusMutua = oDataRow("Tipus")
            Else
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        'Ara Busco del llistat de factures una que sigui compatible amb l'episodi, depenenent de si es
        'una mútua privada o no

        Dim Client As String

        StrInstruccioSQL = ""
        oDataSet = Nothing
        oDataAdapter = Nothing
        oCb = Nothing

        If StrTipusMutua = "PRIVAT" Then
            Client = Me.Pacient.Text
        Else
            Client = Me.DetMutua.Text
        End If

        StrInstruccioSQL = "SELECT Factures.NumFactura, Factures.DataEmisio, Factures.Client" _
            + " FROM Factures" _
            + " WHERE Factures.DataEmisio>=#" + Me.DetDataFi.Text + "# AND Factures.Client=""" + Client + """;"

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        Try
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Factures")
            oConexion.Close()

            Dim Files As Integer
            Files = oDataSet.Tables("Factures").Rows.Count
            If Files = 0 Then   'Si no hi ha factures compatibles amb l'episodi, segueixo creant la factura
                Exit Try
            ElseIf Files = 1 Then   'Si hi ha una factura compatible, pregunto si es vol afegir l'episodi a aquesta factura
                'Previament, agafo el Número i la data de la factura comptible  

                Dim iPosicionActual As Integer
                iPosicionActual = 0

                Dim oDataRow As DataRow
                oDataRow = oDataSet.Tables("Factures").Rows(iPosicionActual)

                Dim StrNumFactura As String
                Dim StrDataEmisio As String

                If VarType(oDataRow("NumFactura")) <> VariantType.Null Then
                    StrNumFactura = oDataRow("NumFactura")
                Else
                End If

                If VarType(oDataRow("DataEmisio")) <> VariantType.Null Then
                    StrDataEmisio = oDataRow("DataEmisio")
                Else
                End If

                Dim i As Integer
                i = MsgBox("Vols afegir l'episodi a la factura número: " + StrNumFactura _
                + Chr(13) + "i data d'emisió del: " + StrDataEmisio, 68, "Fisimèdic")

                If i = vbYes Then   'Si es vol afegir l'episodi a la factura, creo la sentencia SQL i la envio
                    'al mòdul ModExecutarSQL
                    StrInstruccioSQL = ""

                    If StrTipusMutua = "PRIVAT" Then
                        StrInstruccioSQL = ""
                        StrInstruccioSQL = "INSERT INTO ConceptesFactura ( NumFactura, IdEpisodi, Concepte, Quantitat, Preu, Pacient, NumPolissa, NumAutoritzacio)" _
                                 + " SELECT " + StrNumFactura _
                                 + ", " + StrIdEpisodi _
                                 + ", """ + "SESSIONS DE FISIOTERÀPIA" _
                                 + """, " + Me.DetSesAutoritzades.Text _
                                 + ", """ + Me.DetPreuSessio.Text _
                                 + """, """ + Me.Pacient.Text _
                                 + """, """ + Me.DetNumTargeta.Text _
                                 + """, """ + Me.DetNumAutoritzacio.Text + """;"

                        PeticioExecutada = 1
                        PeticioExecutada = ExecutarSql(StrInstruccioSQL)

                        If PeticioExecutada = 1 Then
                            While Not PeticioExecutada = 0

                                i = MsgBox("ERROR EN LA GRABACIÓ DE LES DADES", MsgBoxStyle.AbortRetryIgnore, "Fisiomèdic")
                                If i = vbRetry Then
                                    PeticioExecutada = ExecutarSql(StrInstruccioSQL)
                                ElseIf i = vbAbort Then
                                    Exit Sub
                                Else
                                    Exit While
                                End If
                            End While
                        End If
                    Else
                        StrInstruccioSQL = ""
                        StrInstruccioSQL = "INSERT INTO ConceptesFactura ( NumFactura, IdEpisodi, Concepte, Quantitat, Preu, Pacient, NumPolissa, NumAutoritzacio, Retencio, RetencioImport )" _
                                 + " SELECT " + StrNumFactura _
                                 + ", " + StrIdEpisodi _
                                 + ", """ + "SESSIONS DE FISIOTERÀPIA" _
                                 + """, " + Me.DetSesAutoritzades.Text _
                                 + ", """ + Me.DetPreuSessio.Text _
                                 + """, """ + Me.Pacient.Text _
                                 + """, """ + Me.DetNumTargeta.Text _
                                 + """, """ + Me.DetNumAutoritzacio.Text _
                                 + """, " + "15" _
                                 + ", """ + CStr((((CDbl(Me.DetPreuSessio.Text) * CDbl(Me.DetSesAutoritzades.Text)) * 15) / 100)) + """;"

                        PeticioExecutada = 1
                        PeticioExecutada = ExecutarSql(StrInstruccioSQL)

                        If PeticioExecutada = 1 Then
                            While Not PeticioExecutada = 0

                                i = MsgBox("ERROR EN LA GRABACIÓ DE LES DADES", MsgBoxStyle.AbortRetryIgnore, "Fisiomèdic")
                                If i = vbRetry Then
                                    PeticioExecutada = ExecutarSql(StrInstruccioSQL)
                                ElseIf i = vbAbort Then
                                    Exit Sub
                                Else
                                    Exit While
                                End If
                            End While
                        End If

                    End If
                    ActualitzarEpisodi()
                    Exit Sub

                Else    'Si no es vol afegir l'episodi, segueixo el procès de creació de la factura
                    Exit Try
                End If
                Else    'Si hi ha més d'una factura compatible amb l'episodi, obro un formulari amb el llistat i les opcions

                    InsertarEpisodi.DgFactures.DataSource = oDataSet
                    InsertarEpisodi.DgFactures.DataMember = "Factures"

                    InsertarEpisodi.ShowDialog()    'el formulari InsertarEpisodi, dona valor a la varible Friend 
                    If i = 0 Then                   'declarada en aquest formulari al principi de la classe.
                        ActualitzarEpisodi()        'Al declarar-la se li dona valor=3, i InsertarEpisodi la 
                        Exit Sub                    'converteix en 0 o 1, segons si s'executa la consulta o no.
                    ElseIf i = 1 Then               'Per tant si te un valor diferent de 0 o 1, algo passa.
                    Exit Sub
                    Else
                        MsgBox("Errrooooorrrrr")
                        Exit Sub
                    End If
                End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        '''''''''''''''''''''''''''''''''''''''''''''''
        '&& ACONSEGUIR DADES PER CREAR FACTURA NOVA &&'
        '''''''''''''''''''''''''''''''''''''''''''''''

        Dim StrDataUltimaFactura As String
        Dim StrNumUltimaFactura As String

        oDataSet = Nothing
        StrInstruccioSQL = ""
        'Creo tot el tema per conectar amb la base de dades i busco la última factura
        StrInstruccioSQL = "SELECT Max(Factures.NumFactura) AS UltimNumero, Max(Factures.DataEmisio) AS UltimaData" _
                        + " FROM Factures;"

        Try
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Factures")
            oConexion.Close()

            Dim files As Integer
            files = oDataSet.Tables("Factures").Rows.Count

            If files = 0 Then
                MsgBox("Error")
            ElseIf files = 1 Then
                Dim iPosicionActual As Integer
                iPosicionActual = 0
                Dim oDataRow As DataRow
                oDataRow = oDataSet.Tables("Factures").Rows(iPosicionActual)
                If VarType(oDataRow("UltimNumero")) <> VariantType.Null Then
                    StrNumUltimaFactura = oDataRow("UltimNumero")
                Else
                    StrNumUltimaFactura = "0"
                End If

                If VarType(oDataRow("UltimaData")) <> VariantType.Null Then
                    StrDataUltimaFactura = oDataRow("UltimaData")
                Else
                    StrDataUltimaFactura = "01/01/1900"
                End If
            Else
                MsgBox("error")
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'StrDataUltimaFactura StrNumUltimaFactura corresponen a la última factura, si són ="01/01/1900" o 0, no hi ha factura

        'Creo les variables per crear la nova factura (Número i DataEmisio)
        Dim DatFactura As Date
        Dim NumFactura As Integer

        'si els valors que venen d'abans són 0, llavors és que no hi ha factures, s'ha de crear la primera
        If StrNumUltimaFactura = "0" And StrDataUltimaFactura = "01/01/1900" Then
            NumFactura = CInt(InputBox("Introdueix el número de factura", "Fisiomèdic"))
            DatFactura = CDate(InputBox("Introdueix la data de la factura", "Fisiomèdic"))

            'Si només un del valors anteriors és 0, hi ha un MACROERRORR    
        ElseIf (StrNumUltimaFactura = "0" And StrDataUltimaFactura <> "01/01/1900") Or (StrNumUltimaFactura <> "0" And StrDataUltimaFactura = "01/01/1900") Then
            MsgBox("ERROR" + Chr(13) + "posa't en contacte amb l'administrador", 16, "Fisiomèdic")
            Exit Sub

            'Existeix almenys una factura, compovo que no sigui de l'any anterior i assigno número i data
        Else
            'Si la última factura és d'un any diferent a l'actual, crea el primer número de factura d'aquest any
            If Year(CDate(StrDataUltimaFactura)) <> Year(Now) Then
                NumFactura = (Format(Now, "yy") + "000")

            Else    'Sinó, el número de factura és el que hi ha + 1
                NumFactura = CInt(StrNumUltimaFactura) + 1
            End If
        End If

        'Converteixo el numero de factura a una cadena de 5 dígits
        Dim StrNumFacturaIntro As String = CStr(Format(NumFactura, "00000"))

        'Demano la introducció de la data de facturació, si apretem "Cancelar", dona error de conversió, 
        'degut a que intenta convertir una "" a Data i no pot, pel que controlem aquesta expeció com sortida
        'de la subrutina
        Try
            DatFactura = CDate((InputBox("Introdueix la data d'emisió de la factura", "Fisiomèdic")))

        Catch ext As System.InvalidCastException 'Error controlat com a error de canvi de tipus
            MsgBox("Creació de factura cancelada", , "Fisiomèdic")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If StrDataUltimaFactura > CDate(Me.DetDataFi.Text) Then 'Si la data de l'ultima factura es major que la de fi d'episodi, comprovo, informo i repeteixo la pregunta
            Do While CDate(DatFactura) < CDate(StrDataUltimaFactura)
                Try
                    MsgBox("La data ha de ser major o igual al" + Chr(13) + StrDataUltimaFactura)
                    DatFactura = CDate(InputBox("Introdueix la data d'emisió de la factura", "Fisiomèdic"))
                Catch ext As System.InvalidCastException
                    MsgBox("Creació de factura cancelada", , "Fisiomèdic")
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try

            Loop
        Else    'Sinó, el mateix, però amb la data de fi d'episodi
            Do While CDate(DatFactura) < CDate(Me.DetDataFi.Text)

                MsgBox("La data ha de ser major o igual al" + Chr(13) + Me.DetDataFi.Text)
                DatFactura = CDate(InputBox("Introdueix la data d'emisió de la factura", "Fisiomèdic"))

            Loop

        End If

        '''''''''''''''''''''''''''''''''''''''''
        '''''''''CREAR FACTURA NOVA''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''

        'FALTA CREAR LA FACTURA I DESPRES AFEGIR L'EPISODI
        'Disposo del Client, StrTipusMutua, i de les dades de l'episdodi
        'DatFactura i NumFactura

        
        'Primer: Busco les dades del client, tenint en compte del tipus de mútua, les busco a una 
        'taula o una altre

        Dim StrCif As String
        Dim StrCp As String
        Dim StrPoblacio As String
        Dim StrProvincia As String
        Dim StrAdreça As String
        'Parts d'adreça
        Dim StrTipusCarrer As String
        Dim StrCarrer As String
        Dim StrNumero As String
        Dim StrPis As String
        Dim StrPorta As String

        If StrTipusMutua = "PRIVAT" Then

            StrInstruccioSQL = ""
            StrInstruccioSQL = "SELECT DadesPacient.Dni, TipusCarrer.TipusCarrer, DadesPacient.Carrer," _
                            + " DadesPacient.Numero, DadesPacient.Pis, DadesPacient.Porta," _
                            + " DadesPacient.CodiPostal, DadesPacient.Poblacio" _
                            + " FROM DadesPacient INNER JOIN TipusCarrer ON DadesPacient.Tipuscarrer = TipusCarrer.IdCarrer" _
                            + " WHERE DadesPacient.IdPacient=" + StrIdPacient + ";"
            
            Try
                oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
                oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
                oDataSet = New DataSet()

                oConexion.Open()
                oDataAdapter.Fill(oDataSet, "DadesPacient")
                oConexion.Close()

                Dim iPosicionActual As Integer
                iPosicionActual = 0
                Dim oDataRow As DataRow
                oDataRow = oDataSet.Tables("DadesPacient").Rows(iPosicionActual)

                If VarType(oDataRow("Dni")) <> VariantType.Null Then
                    StrCif = oDataRow("Dni")
                Else
                    MsgBox("Error, no es pot facturar a un client que no disposa de DNI", 16, "Fisiomèdic")
                    Exit Sub
                End If

                If VarType(oDataRow("TipusCarrer")) <> VariantType.Null Then
                    StrTipusCarrer = oDataRow("TipusCarrer")
                Else
                End If

                If VarType(oDataRow("Carrer")) <> VariantType.Null Then
                    StrCarrer = oDataRow("Carrer")
                Else
                    StrCarrer = ""
                End If

                If VarType(oDataRow("Numero")) <> VariantType.Null Then
                    StrNumero = oDataRow("Numero")
                Else
                    StrNumero = ""
                End If

                If VarType(oDataRow("Pis")) <> VariantType.Null Then
                    StrPis = oDataRow("Pis")
                Else
                    StrPis = ""
                End If

                If VarType(oDataRow("Porta")) <> VariantType.Null Then
                    StrPorta = oDataRow("Porta")
                Else
                    StrPorta = ""
                End If
                If VarType(oDataRow("CodiPostal")) <> VariantType.Null Then
                    StrCp = oDataRow("CodiPostal")
                Else
                    StrCp = ""
                End If

                If VarType(oDataRow("Poblacio")) <> VariantType.Null Then
                    StrPoblacio = oDataRow("Poblacio")
                Else
                    StrPoblacio = ""
                End If

                StrAdreça = StrCarrer + ", " + StrNumero + " " + StrPis + " " + StrPorta

                StrInstruccioSQL = ""
                StrInstruccioSQL = "INSERT INTO Factures (NumFactura, DataEmisio, Client, TipusMutua, Cif, Adreça, CP, Poblacio, Provincia)" _
                                + "SELECT " + StrNumFacturaIntro _
                                + ", '" + CStr(DatFactura) _
                                + "', """ + Client _
                                + """, """ + StrTipusMutua _
                                + """, """ + StrCif _
                                + """, """ + StrAdreça _
                                + """, """ + StrCp _
                                + """, """ + StrPoblacio _
                                + """, """ + "" + """;"

                PeticioExecutada = 1
                PeticioExecutada = ExecutarSql(StrInstruccioSQL)

                If PeticioExecutada = 1 Then
                    While Not PeticioExecutada = 0
                        Dim i As Integer
                        i = MsgBox("ERROR EN LA GRABACIÓ DE LES DADES", MsgBoxStyle.AbortRetryIgnore, "Fisiomèdic")
                        If i = vbRetry Then
                            PeticioExecutada = ExecutarSql(StrInstruccioSQL)
                        ElseIf i = vbAbort Then
                            Exit Sub
                        Else
                            Exit While
                        End If
                    End While
                End If
                Exit Try

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else    'No Privat

            StrInstruccioSQL = ""
            StrInstruccioSQL = "SELECT Mutues.Cif, Mutues.Nom, Mutues.Adreça, Mutues.CP, Mutues.Poblacio, Mutues.Provincia" _
                            + " FROM Mutues" _
                            + " WHERE Mutues.Nom=""" + Me.DetMutua.Text + """;"

            Try
                oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
                oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
                oDataSet = New DataSet()

                oConexion.Open()
                oDataAdapter.Fill(oDataSet, "Mutues")
                oConexion.Close()

                Dim iPosicionActual As Integer
                iPosicionActual = 0
                Dim oDataRow As DataRow
                oDataRow = oDataSet.Tables("Mutues").Rows(iPosicionActual)

                If VarType(oDataRow("Cif")) <> VariantType.Null Then
                    StrCif = oDataRow("Cif")
                Else
                    MsgBox("Error, no es pot facturar a un client que no disposa de CIF", 16, "Fisiomèdic")
                    Exit Sub
                End If

                If VarType(oDataRow("Adreça")) <> VariantType.Null Then
                    StrAdreça = oDataRow("Adreça")
                Else
                    StrAdreça = ""
                End If

                If VarType(oDataRow("CP")) <> VariantType.Null Then
                    StrCp = oDataRow("CP")
                Else
                    StrCp = ""
                End If

                If VarType(oDataRow("Poblacio")) <> VariantType.Null Then
                    StrPoblacio = oDataRow("Poblacio")
                Else
                    StrPoblacio = ""
                End If

                If VarType(oDataRow("Provincia")) <> VariantType.Null Then
                    StrProvincia = oDataRow("Provincia")
                Else
                    StrProvincia = ""
                End If



                StrInstruccioSQL = ""
                StrInstruccioSQL = "INSERT INTO Factures (NumFactura, DataEmisio, Client, TipusMutua, Cif, Adreça, CP, Poblacio, Provincia)" _
                                + " SELECT " + StrNumFacturaIntro _
                                + ", '" + CStr(DatFactura) _
                                + "', """ + Client _
                                + """, """ + StrTipusMutua _
                                + """, """ + StrCif _
                                + """, """ + StrAdreça _
                                + """, """ + StrCp _
                                + """, """ + StrPoblacio _
                                + """, """ + StrProvincia + """;"

                PeticioExecutada = 1
                PeticioExecutada = ExecutarSql(StrInstruccioSQL)

                If PeticioExecutada = 1 Then
                    While Not PeticioExecutada = 0
                        Dim i As Integer
                        i = MsgBox("ERROR EN LA GRABACIÓ DE LES DADES", MsgBoxStyle.AbortRetryIgnore, "Fisiomèdic")
                        If i = vbRetry Then
                            PeticioExecutada = ExecutarSql(StrInstruccioSQL)
                        ElseIf i = vbAbort Then
                            Exit Sub
                        Else
                            Exit While
                        End If
                    End While
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        'Afegeixo l'episodi a la taula ConceptesFactura

        If StrTipusMutua = "PRIVAT" Then
            StrInstruccioSQL = ""
            StrInstruccioSQL = "INSERT INTO ConceptesFactura ( NumFactura, IdEpisodi, Concepte, Quantitat, Preu, Pacient, NumPolissa, NumAutoritzacio)" _
                     + " SELECT " + StrNumFacturaIntro _
                     + ", " + StrIdEpisodi _
                     + ", """ + "SESSIONS DE FISIOTERÀPIA" _
                     + """, " + Me.DetSesAutoritzades.Text _
                     + ", """ + Me.DetPreuSessio.Text _
                     + """, """ + Me.Pacient.Text _
                     + """, """ + Me.DetNumTargeta.Text _
                     + """, """ + Me.DetNumAutoritzacio.Text + """;"

            PeticioExecutada = 1
            PeticioExecutada = ExecutarSql(StrInstruccioSQL)

            If PeticioExecutada = 1 Then
                While Not PeticioExecutada = 0
                    Dim i As Integer
                    i = MsgBox("ERROR EN LA GRABACIÓ DE LES DADES", MsgBoxStyle.AbortRetryIgnore, "Fisiomèdic")
                    If i = vbRetry Then
                        PeticioExecutada = ExecutarSql(StrInstruccioSQL)
                    ElseIf i = vbAbort Then
                        Exit Sub
                    Else
                        Exit While
                    End If
                End While
            End If
        Else
            StrInstruccioSQL = ""
            StrInstruccioSQL = "INSERT INTO ConceptesFactura ( NumFactura, IdEpisodi, Concepte, Quantitat, Preu, Pacient, NumPolissa, NumAutoritzacio, Retencio, RetencioImport )" _
                     + " SELECT " + StrNumFacturaIntro _
                     + ", " + StrIdEpisodi _
                     + ", """ + "SESSIONS DE FISIOTERÀPIA" _
                     + """, " + Me.DetSesAutoritzades.Text _
                     + ", """ + Me.DetPreuSessio.Text _
                     + """, """ + Me.Pacient.Text _
                     + """, """ + Me.DetNumTargeta.Text _
                     + """, """ + Me.DetNumAutoritzacio.Text _
                     + """, " + "15" _
                     + ", """ + CStr((((CDbl(Me.DetPreuSessio.Text) * CDbl(Me.DetSesAutoritzades.Text)) * 15) / 100)) + """;"

            PeticioExecutada = 1
            PeticioExecutada = ExecutarSql(StrInstruccioSQL)

            If PeticioExecutada = 1 Then
                While Not PeticioExecutada = 0
                    Dim i As Integer
                    i = MsgBox("ERROR EN LA GRABACIÓ DE LES DADES", MsgBoxStyle.AbortRetryIgnore, "Fisiomèdic")
                    If i = vbRetry Then
                        PeticioExecutada = ExecutarSql(StrInstruccioSQL)
                    ElseIf i = vbAbort Then
                        Exit Sub
                    Else
                        Exit While
                    End If
                End While
            End If

        End If
        ActualitzarEpisodi()
    End Sub
    Private Sub ActualitzarEpisodi()

        'Actualitzo el registre de l'episodi com a facturat
        StrInstruccioSQL = ""
        StrInstruccioSQL = "UPDATE Episodis SET Episodis.Factura = True" _
                    + " WHERE Episodis.IdEpisodi=" + StrIdEpisodi + ";"

        PeticioExecutada = 1
        PeticioExecutada = ExecutarSql(StrInstruccioSQL)

        If PeticioExecutada = 1 Then
            While Not PeticioExecutada = 0
                Dim i As Integer
                i = MsgBox("ERROR EN LA GRABACIÓ DE LES DADES", MsgBoxStyle.AbortRetryIgnore, "Fisiomèdic")
                If i = vbRetry Then
                    PeticioExecutada = ExecutarSql(StrInstruccioSQL)
                ElseIf i = vbAbort Then
                    Exit Sub
                Else
                    Exit While
                End If
            End While
        End If

    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Private Sub DetSesAutoritzades_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetSesAutoritzades.Leave

        If Me.DetSesAutoritzades.Text = "" Then
            Me.DetSesAutoritzades.Text = 0
        Else

        End If
    End Sub

End Class