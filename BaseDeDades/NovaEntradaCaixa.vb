Public Class NovaEntradaCaixa
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection

    Private Sub NovaEntradaCaixa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT MovimentsCaixa.* FROM MovimentsCaixa;"
        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        oDataSet = Nothing
        oDataSet = New DataSet

        oConexion.Open()
        oDataAdapter.Fill(oDataSet, "MovimentsCaixa")
        oConexion.Close()

        Me.CbTerapeuta.DataSource = oDataSet.Tables("MovimentsCaixa")
        Me.CbTerapeuta.DisplayMember = "MovimentCaixa"
        Me.CbTerapeuta.ValueMember = "MovimentCaixa"

        ''''''''''''''''''''''''

        Me.Data.Mask = "00/00/0000"
        Me.Data.Text = Format(Now, "short date")

        Me.Import.Text = "0,00"

        ''''''''''''''''

        Me.ControlBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = Me.Text + " " + StrOrigenDeDades


    End Sub
    Private Sub Import_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Import.Leave
        Me.Import.Text = Me.Import.Text.Replace(".", ",")
    End Sub
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()

    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click

        Dim PacPrivat As String
        If Me.CbPrivat.Checked = True Then
            PacPrivat = "True"
        Else
            PacPrivat = "False"
        End If
        If Me.CbTerapeuta.Text = "RETIRAR" Then
            Me.Import.Text = -(Me.Import.Text)
        End If
        StrInstruccioSQL = ""
        StrInstruccioSQL = "INSERT INTO Caixa ( Data, Terapeuta, NomPacient, Descripcio, Preu, PacientPrivat )" _
                + " SELECT '" + Me.Data.Text _
                + "', """ + Me.CbTerapeuta.Text _
                + """, """ + Me.Pacient.Text _
                + """, """ + Me.Descripcio.Text _
                + """, """ + Me.Import.Text _
                + """, " + PacPrivat + ";"

        ExecutarSql(StrInstruccioSQL)
        Caixa.CarregarDades()
        Me.Close()

    End Sub
End Class