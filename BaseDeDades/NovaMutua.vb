Public Class NovaMutua
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection

    Private Sub NovaMutua_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ControlBox = False
        Me.Text = Me.Text + " " + StrOrigenDeDades

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = "SELECT TipusMutua.TipusMutua FROM TipusMutua;"

        Try
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "TipusMutua")
            oConexion.Close()

            Me.CbTipusMutua.DataSource = oDataSet.Tables("TipusMutua")
            Me.CbTipusMutua.DisplayMember = "TipusMutua"
            Me.CbTipusMutua.ValueMember = "TipusMutua"

            Me.CbTipusMutua.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.CbTipusMutua.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Catch ex As Exception
            MsgBox("Comprova que l'origen de dades, sigui vàlid", 16, "Fisiomèdic")
        End Try
    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        StrInstruccioSQL = ""
        StrInstruccioSQL = "INSERT INTO Mutues ( Nom, Cif, Adreça, CP, Poblacio, Provincia, Telefon1, Telefon2, Telefon3, Fax1, Fax2, Contacte, Notes, Tipus, Preu )" _
                + "SELECT """ + Me.Nom.Text _
                + """, """ + Me.Cif.Text _
                + """, """ + Me.Adreça.Text _
                + """, """ + Me.Cp.Text _
                + """, """ + Me.Poblacio.Text _
                + """, """ + Me.Provincia.Text _
                + """, """ + Me.Telf1.Text _
                + """, """ + Me.Telf2.Text _
                + """, """ + Me.Telf3.Text _
                + """, """ + Me.Fax1.Text _
                + """, """ + Me.Fax2.Text _
                + """, """ + Me.Contacte.Text _
                + """, """ + Me.Notes.Text _
                + """, """ + Me.CbTipusMutua.Text _
                + """, """ + Me.Preu.Text + """;"

        ExecutarSql(StrInstruccioSQL)
        Mutues.CarregarDgMutues()

        Me.Close()
    End Sub
    Private Sub Preu_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Preu.Leave

        Me.Preu.Text = Replace(Me.Preu.Text, ".", ",")

    End Sub
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class