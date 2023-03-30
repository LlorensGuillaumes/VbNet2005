Public Class NouInforme
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection
    Private Sub NouInforme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        StrInstruccioSQL = ""
        StrCadenaConexio = ""

        Me.DetDataStr.Text = CalcularData(Now())
        Me.DetData.Text = Format(Now, "Short Date")
        Me.ControlBox = False
        Me.Text = "NOU INFORME" + " " + StrOrigenDeDades

        'AGAFO LES DADES DEL PACIENT I COLOCO EL SEU NOM AL PRINCIPI DEL FORMULARI
        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        Dim StrNom As String
        Dim StrPacient As String
        Dim StrDni As String

        StrNom = "DadesPacient.Nom & " + """ """ + "& DadesPacient.PrimerCognom &" + """ """ + "& DadesPacient.SegonCognom"

        StrInstruccioSQL = "SELECT DadesPacient.IdPacient, DadesPacient.Dni," + StrNom + " AS Pacient" _
           + " FROM DadesPacient" _
           + " WHERE DadesPacient.IdPacient=" + StrIdPacient + ";"

        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
        oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
        oDataSet = Nothing
        oDataSet = New DataSet()

        Try
            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "DadesPacient")
            oConexion.Close()

            Dim iPosicionActual As Integer
            iPosicionActual = 0
            Dim oDataRow As DataRow
            oDataRow = oDataSet.Tables("DadesPacient").Rows(iPosicionActual)

            If VarType(oDataRow("Pacient")) <> VariantType.Null Then
                StrPacient = oDataRow("Pacient")
            Else
                StrPacient = ""
            End If

            If VarType(oDataRow("Dni")) <> VariantType.Null Then
                StrDni = oDataRow("Dni")
            Else
                StrDni = ""
            End If
            Me.DetPacient.Text = StrDni + " " + StrPacient
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Carrego els terapeutes al desplegable

        StrInstruccioSQL = "SELECT Terapeutes.Terapeuta, Terapeutes.NumColegiat FROM Terapeutes;"

        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
        oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
        oDataSet = Nothing
        oDataSet = New DataSet()

        oConexion.Open()
        oDataAdapter.Fill(oDataSet, "Terapeutes")
        oConexion.Close()

        Me.DetTerapeuta.DataSource = oDataSet.Tables("Terapeutes")
        Me.DetTerapeuta.DisplayMember = "Terapeuta"
        Me.DetTerapeuta.ValueMember = "Terapeuta"

        Me.DetTerapeuta.AutoCompleteSource = AutoCompleteSource.ListItems
        Me.DetTerapeuta.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub
    Private Sub MostrarCalendari(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Calendari.Visible = True
        Me.Calendari.SetDate(Now)
        Me.Calendari.BackColor = Color.Beige
        Me.Calendari.TitleBackColor = Color.Beige
    End Sub
    Private Sub Calendari_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendari.DateSelected

        Me.DetDataStr.Text = CalcularData(Me.Calendari.SelectionStart)
        Me.DetData.Text = Me.Calendari.SelectionStart
        Me.Calendari.Visible = False
    End Sub
    Private Sub DetTerapeuta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetTerapeuta.SelectedIndexChanged

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = "SELECT Terapeutes.Terapeuta, Terapeutes.NumColegiat FROM Terapeutes WHERE Terapeutes.Terapeuta=""" + Me.DetTerapeuta.Text + """;"

        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
        oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
        oDataSet = Nothing
        oDataSet = New DataSet()

        oConexion.Open()
        oDataAdapter.Fill(oDataSet, "Terapeutes")
        oConexion.Close()

        Try
            Dim files As Integer = oDataSet.Tables("Terapeutes").Rows.Count
            If files = 0 Then
                Exit Sub
            Else
                Dim iPosicionActual As Integer
                iPosicionActual = 0
                Dim oDataRow As DataRow
                oDataRow = oDataSet.Tables("Terapeutes").Rows(iPosicionActual)

                If VarType(oDataRow("NumColegiat")) <> VariantType.Null Then
                    Me.DetNumColegiat.Text = (oDataRow("NumColegiat"))
                Else
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GuardarInforme()
    End Sub
    Private Sub GuardarInforme()

        StrInstruccioSQL = "INSERT INTO Informes (IdPacient, Titol, Diagnostic, Informe, Data, NumColegiat)" _
                + " SELECT " + StrIdPacient _
                + ", """ + Me.DetTitolInforme.Text _
                + """, """ + Me.DetDiagnostic.Text _
                + """, """ + Me.DetInforme.Text _
                + """, '" + CStr(Me.DetData.Text) _
                + "', " + Me.DetNumColegiat.Text + ";"

        ExecutarSql(StrInstruccioSQL)
        Me.Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim i As Integer
        i = MsgBox("Guardar Informe", 52, "Fisiomèdic")

        If i = vbYes Then
            GuardarInforme()
        Else
        End If
        Me.Close()
    End Sub
End Class