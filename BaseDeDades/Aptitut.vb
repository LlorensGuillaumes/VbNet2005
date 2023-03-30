Public Class Aptitut
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection
    Private Sub Aptitut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ControlBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = Me.Text + " " + StrOrigenDeDades

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = "SELECT Aptitut.* FROM Aptitut;"
        Try
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Aptitut")
            oConexion.Close()

            With Me.CbAptitut

                .DataSource = oDataSet.Tables("Aptitut")
                .DisplayMember = "Aptitut"
                .ValueMember = "Aptitut"

                .AutoCompleteSource = AutoCompleteSource.ListItems
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        StrInstruccioSQL = ""
        StrInstruccioSQL = "UPDATE Reconeixements SET Reconeixements.Aptitut = """ + Me.CbAptitut.Text _
                + """ WHERE Reconeixements.IdReco=" + StrIdEpisodi + ";"

        ExecutarSql(StrInstruccioSQL)
        Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class