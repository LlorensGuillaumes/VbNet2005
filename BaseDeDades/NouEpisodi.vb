Public Class NouEpisodi
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection
    Private Sub BtnOK(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        StrInstruccioSQL = ""
        If Me.DetPreuSessio.Text = "" Then
            MsgBox("El preu sessió es un camp obligatori", , "Fisiomèdic")
            Me.DetPreuSessio.Focus()
            Exit Sub
        End If

        If Me.ModMutua.Text = "RECONEIXEMENT MÈDIC" Then
            If CDate(Me.DetDataInici.Text) <> CDate(Me.DetDataFi.Text) Then
                MsgBox("Els reconeixements mèdics, la data d'Inici i la de Fi, han de ser iguals", , "Fisiomèdic")
                Me.DetDataFi.Focus()
                Exit Sub
            End If
        End If

        If Me.DetDataInici.Text = "" And Me.DetDataFi.Text = "" Then
            StrInstruccioSQL = "INSERT INTO Episodis ( IdPacient, Mutua, NumTargeta, NumAutoritzacio, SesAutoritzades, PreuSessio ) " _
            + "SELECT " + StrIdPacient _
            + ", """ + Me.ModMutua.Text _
            + """, """ + Me.DetNumTargeta.Text _
            + """, """ + Me.DetNumAutoritzacio.Text _
            + """, " + Me.DetSesAutoritzades.Text _
            + ", """ + Me.DetPreuSessio.Text + """;"

        ElseIf Me.DetDataInici.Text <> "" And Me.DetDataFi.Text = "" Then
            StrInstruccioSQL = "INSERT INTO Episodis ( IdPacient, Mutua, NumTargeta, NumAutoritzacio, SesAutoritzades, DataInici, PreuSessio ) " _
            + "SELECT " + StrIdPacient _
            + ", """ + Me.ModMutua.Text _
            + """, """ + Me.DetNumTargeta.Text _
            + """, """ + Me.DetNumAutoritzacio.Text _
            + """, " + Me.DetSesAutoritzades.Text _
            + ", '" + Me.DetDataInici.Text _
            + "', """ + Me.DetPreuSessio.Text + """;"

        ElseIf Me.DetDataInici.Text = "" And Me.DetDataFi.Text <> "" Then
            StrInstruccioSQL = "INSERT INTO Episodis ( IdPacient, Mutua, NumTargeta, NumAutoritzacio, SesAutoritzades, DataFi, PreuSessio ) " _
            + "SELECT " + StrIdPacient _
            + ", """ + Me.ModMutua.Text _
            + """, """ + Me.DetNumTargeta.Text _
            + """, """ + Me.DetNumAutoritzacio.Text _
            + """, " + Me.DetSesAutoritzades.Text _
            + ", '" + Me.DetDataFi.Text _
            + " ', """ + Me.DetPreuSessio.Text + """;"
        Else
            StrInstruccioSQL = "INSERT INTO Episodis ( IdPacient, Mutua, NumTargeta, NumAutoritzacio, SesAutoritzades, DataInici, DataFi, PreuSessio ) " _
                + "SELECT " + StrIdPacient _
                + ", """ + Me.ModMutua.Text _
                + """, """ + Me.DetNumTargeta.Text _
                + """, """ + Me.DetNumAutoritzacio.Text _
                + """, " + Me.DetSesAutoritzades.Text _
                + ", '" + Me.DetDataInici.Text _
                + " ', '" + Me.DetDataFi.Text _
                + " ', """ + Me.DetPreuSessio.Text + """;"
        End If

        ExecutarSql(StrInstruccioSQL)

        If Me.ModMutua.Text = "RECONEIXEMENT MÈDIC" Then
            StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
            oConexion = New OleDb.OleDbConnection
            oConexion.ConnectionString = StrCadenaConexio

            StrInstruccioSQL = ""
            StrInstruccioSQL = "SELECT Max(Episodis.IdEpisodi) AS NumEpisodi FROM Episodis;"

            Try
                oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
                oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
                oDataSet = Nothing
                oDataSet = New DataSet()

                oConexion.Open()
                oDataAdapter.Fill(oDataSet, "Episodis")
                oConexion.Close()

                Dim iPosicionActual As Integer
                iPosicionActual = 0

                Dim oDataRow As DataRow
                oDataRow = oDataSet.Tables("Episodis").Rows(iPosicionActual)

                If VarType(oDataRow("NumEpisodi")) <> VariantType.Null Then
                    StrIdEpisodi = oDataRow("NumEpisodi")
                Else
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            'Obro un no reconeixement
            StrInstruccioSQL = ""
            StrInstruccioSQL = "INSERT INTO Reconeixements (IdPacient, IdReco, DataInici, DataFi)" _
                    + " SELECT " + StrIdPacient _
                    + ", " + StrIdEpisodi _
                    + ", '" + Me.DetDataInici.Text _
                    + "', '" + Me.DetDataFi.Text _
                    + "';"
            ExecutarSql(StrInstruccioSQL)

            'Obro el detall del nou reconeixement

            Try
                'Comprovo si aquest pacient te ja algun registre a a anamnesi, si no el te l'hi poso
                StrInstruccioSQL = ""
                StrInstruccioSQL = "SELECT Anamnesi.Pacient FROM Anamnesi WHERE Anamnesi.Pacient=" + StrIdPacient + ";"
                
                oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
                oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
                oDataSet = Nothing
                oDataSet = New DataSet()

                oConexion.Open()
                oDataAdapter.Fill(oDataSet, "Anamnesi")
                oConexion.Close()

                Dim i As Integer
                i = oDataSet.Tables("Anamnesi").Rows.Count
                If i = 0 Then
                    StrInstruccioSQL = ""
                    StrInstruccioSQL = "INSERT INTO Anamnesi (Pacient)" _
                            + " SELECT " + StrIdPacient + ";"
                    ExecutarSql(StrInstruccioSQL)
                Else
                    Exit Try
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            

            StrInstruccioSQL = ""
            StrInstruccioSQL = "INSERT INTO Exploracio (IdReco)" _
                    + " SELECT " + StrIdEpisodi + ";"
            ExecutarSql(StrInstruccioSQL)

            StrInstruccioSQL = ""
            StrInstruccioSQL = "INSERT INTO Proves (IdReco)" _
                    + " SELECT " + StrIdEpisodi + ";"
            ExecutarSql(StrInstruccioSQL)

            StrInstruccioSQL = ""
            StrInstruccioSQL = "INSERT INTO Antropometria (IdReco)" _
                    + " SELECT " + StrIdEpisodi + ";"
            ExecutarSql(StrInstruccioSQL)

            StrInstruccioSQL = ""
            StrInstruccioSQL = "INSERT INTO ExploracioPostural (IdReco)" _
                    + " SELECT " + StrIdEpisodi + ";"
            ExecutarSql(StrInstruccioSQL)

            StrInstruccioSQL = ""
            StrInstruccioSQL = "INSERT INTO ErgoInforme (IdReco)" _
                    + " SELECT " + StrIdEpisodi + ";"
            ExecutarSql(StrInstruccioSQL)

            StrInstruccioSQL = ""
            StrInstruccioSQL = "INSERT INTO RecoObservacions (IdReco)" _
                    + " SELECT " + StrIdEpisodi + ";"
            ExecutarSql(StrInstruccioSQL)

            StrInstruccioSQL = ""
            StrInstruccioSQL = "INSERT INTO Estabilometria (IdReco)" _
                    + " SELECT " + StrIdEpisodi + ";"
            ExecutarSql(StrInstruccioSQL)

            StrInstruccioSQL = ""
            StrInstruccioSQL = "INSERT INTO Ebm (IdReco)" _
                    + " SELECT " + StrIdEpisodi + ";"
            ExecutarSql(StrInstruccioSQL)

        Else

        End If

        'NETEJO CAMPS   

        Me.ModMutua.Text = ""
        Me.DetNumTargeta.Text = ""
        Me.DetNumAutoritzacio.Text = ""
        Me.DetDataInici.Text = ""
        Me.DetDataFi.Text = ""
        Me.DetPreuSessio.Text = ""

        Me.Close()



    End Sub
    Private Sub NouEpisodi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NouEpisodiCarregarDades()
        Me.StartPosition = FormStartPosition.CenterParent
        Me.ControlBox = False
        Me.Text = Me.Text + " " + StrOrigenDeDades
    End Sub
    Private Sub NouEpisodiCarregarDades()

        'CARREGO EL DESPLEGABLE DE MÚTUA

        StrInstruccioSQL = ""
        StrCadenaConexio = ""

        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("

        Dim StrInstruccioSQLMuta As String
        StrInstruccioSQLMuta = "SELECT Mutues.* FROM Mutues;"

        oConexion = New OleDb.OleDbConnection
        oConexion.ConnectionString = StrCadenaConexio

        Try
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQLMuta, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Mutues")
            oConexion.Close()

            Me.ModMutua.DataSource = oDataSet.Tables("Mutues")
            Me.ModMutua.DisplayMember = "Nom"
            Me.ModMutua.ValueMember = "Nom"

            Me.ModMutua.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.ModMutua.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'CONFIGURO LA VISIÓ DEL FORMULARI

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

        Me.ModMutua.Visible = True

        'CONFIGURO L'ÍNDEX DE TABULACIÓ

        Me.ModMutua.TabIndex = 1
        Me.DetNumTargeta.TabIndex = 2
        Me.DetNumAutoritzacio.TabIndex = 3
        Me.DetSesAutoritzades.TabIndex = 4
        Me.DetDataInici.TabIndex = 5
        Me.DetDataFi.TabIndex = 6
        Me.DetPreuSessio.TabIndex = 7
    End Sub
    Private Sub ModMutua_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModMutua.SelectedIndexChanged

        'CARREGO EL PREU/SESSIÓ SEGONS TAULA MUTUES
        oDataSet = Nothing
        oDataSet = New DataSet()

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT Mutues.Nom, Mutues.Preu FROM Mutues WHERE Mutues.Nom = """ + Me.ModMutua.Text + """;"

        Try
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Mutues")
            oConexion.Close()

            Dim files As Integer = oDataSet.Tables("Mutues").Rows.Count

            If files = 0 Then
                Exit Sub
            Else
                Dim iPosicionActual As Integer
                iPosicionActual = 0
                Dim oDataRow As DataRow
                oDataRow = oDataSet.Tables("Mutues").Rows(iPosicionActual)

                If VarType(oDataRow("Preu")) <> VariantType.Null Then
                    Me.DetPreuSessio.Text = CStr(oDataRow("Preu")) + "€"
                Else
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DetDataFi_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetDataFi.Leave

        Try
            Me.DetDataFi.Text = CDate(Me.DetDataFi.Text)
        Catch ex As Exception

            If Me.DetDataFi.Text = "" Then
                Exit Sub
            Else
                MsgBox("La dada introduida no correspon a una data", , "Fisiomèdic")
                Me.DetDataFi.Undo()
                Me.DetDataFi.Focus()
                Exit Sub
            End If
        End Try
    End Sub
    Private Sub DetDataInici_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetDataInici.Leave

        If Me.ModMutua.Text = "RECONEIXEMENT MÈDIC" Then
            Me.DetDataFi.Text = Me.DetDataInici.Text
        Else
        End If

        Try
            Me.DetDataInici.Text = CDate(Me.DetDataInici.Text)
        Catch ex As Exception

            If Me.DetDataInici.Text = "" Then
                Exit Sub
            Else
                MsgBox("La dada introduida no correspon a una data", , "Fisiomèdic")
                Me.DetDataInici.Undo()
                Me.DetDataInici.Focus()
                Exit Sub
            End If
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub DetSesAutoritzades_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetSesAutoritzades.Leave

        If Me.DetSesAutoritzades.Text = "" Then
            Me.DetSesAutoritzades.Text = 0
        Else
        End If
    End Sub
End Class