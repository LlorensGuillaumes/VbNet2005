Public Class NouPacient
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection

    Private Sub NouPacient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarNouPacient()
        Me.Text = "NOU PACIENT" + " " + StrOrigenDeDades
    End Sub
    Private Sub CarregarNouPacient()

        StrInstruccioSQL = ""
        StrCadenaConexio = ""

        Me.IntroDN.Mask = "00/00/0000"
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        Dim StrInstruccioSQLMuta As String
        StrInstruccioSQLMuta = "SELECT TipusCarrer.* FROM TipusCarrer;"

        oConexion = New OleDb.OleDbConnection
        oConexion.ConnectionString = StrCadenaConexio

        Try
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQLMuta, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "TipusCarrer")
            oConexion.Close()

            Me.CbTipusCarrer.DataSource = oDataSet.Tables("TipusCarrer")
            Me.CbTipusCarrer.DisplayMember = "TipusCarrer"
            Me.CbTipusCarrer.ValueMember = "TipusCarrer"

            Me.CbTipusCarrer.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.CbTipusCarrer.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click

        If Me.IntroDN.Text = "" Then
            MsgBox("La data de naixement és un text obligatori", MsgBoxStyle.Critical, "Fisiomèdic")
            Me.IntroDN.Focus()
            Exit Sub
        Else
        End If
        StrInstruccioSQL = ""
        StrCadenaConexio = ""

        Dim StrIdTipusCarrer As String
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("

        Dim StrInstruccioSQLMuta As String
        StrInstruccioSQLMuta = "SELECT TipusCarrer.* FROM TipusCarrer WHERE TipusCarrer.TipusCarrer=""" + Me.CbTipusCarrer.Text + """;"

        oConexion = New OleDb.OleDbConnection
        oConexion.ConnectionString = StrCadenaConexio

        Try
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQLMuta, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)

            oDataSet = Nothing
            oDataSet = New DataSet

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "TipusCarrer")
            oConexion.Close()

            Dim iPosicionActual As Integer
            iPosicionActual = 0
            Dim oDataRow As DataRow
            oDataRow = oDataSet.Tables("TipusCarrer").Rows(iPosicionActual)

            If VarType(oDataRow("IdCarrer")) <> VariantType.Null Then
                StrIdTipusCarrer = oDataRow("IdCarrer")
            Else
                StrIdTipusCarrer = ""
            End If


            StrInstruccioSQL = "INSERT INTO DadesPacient ( Dni, Nom, PrimerCognom, SegonCognom," _
            + "TipusCarrer, Carrer, Numero, Pis, Porta, CodiPostal, Poblacio, TelFix, TelMob, TelFeina, DN, AE )" _
            + "SELECT """ + Me.IntroDni.Text _
            + """, """ + Me.IntroNom.Text _
            + """, """ + Me.IntroPrimerCognom.Text _
            + """, """ + Me.IntroSegonCognom.Text _
            + """, " + StrIdTipusCarrer _
            + ", """ + Me.IntroAdresa.Text _
            + """, """ + Me.IntroNum.Text _
            + """, """ + Me.IntroPis.Text _
            + """, """ + Me.IntroPorta.Text _
            + """, """ + Me.IntroCP.Text _
            + """, """ + Me.IntroPoblacio.Text _
            + """, """ + Me.IntroTelFix.Text _
            + """, """ + Me.IntroTelMob.Text _
            + """, """ + Me.IntroTelFeina.Text _
            + """, '" + Me.IntroDN.Text _
            + "', """ + Me.IntroAE.Text + """;"

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
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub IntroDni_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntroDni.Leave
        If Me.IntroDni.Text = "" Then
            Exit Sub
        Else
            Dim Validacio As Integer = 2
            Validacio = ValidacioDni(Me.IntroDni.Text)
            If Validacio = 1 Then
                MsgBox("Aquest número no pertany a un DNI", , "Fisiomèdic")
                Me.IntroDni.Focus()
                Exit Sub
            ElseIf Validacio = 0 Then
                Exit Sub
            Else
                MsgBox("Error en la validació del DNI" + Chr(13) + "posa't en contacte amb l'administrador", , "Fisiomèdic")
            End If
        End If

    End Sub
    Private Sub IntroDN_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Me.IntroDN.Text <> "" Then
            Try
                Me.IntroDN.Text = CDate(Me.IntroDN.Text)
            Catch ex As Exception
                MsgBox("El text introduit no correpon a una data", , "Fisiomèdic")
                Me.IntroDN.Text = ""
                Me.IntroDN.Focus()
            End Try
        Else
        End If
    End Sub
End Class