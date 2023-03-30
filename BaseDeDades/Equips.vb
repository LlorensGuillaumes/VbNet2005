Public Class Equips
    Private oConexion As OleDb.OleDbConnection
    Private Sub Equips_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarDades()
        Me.ControlBox = False
        Me.Text = Me.Text + " " + StrOrigenDeDades
    End Sub
    Friend Sub CarregarDades()

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

            Me.Club.DataSource = oDataSet.Tables("Clubs")
            Me.Club.DisplayMember = "Club"
            Me.Club.ValueMember = "Club"

            Me.Club.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.Club.AutoCompleteMode = AutoCompleteMode.SuggestAppend


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Club_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Club.SelectedIndexChanged

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT Equips.Equip FROM Equips WHERE Equips.Club = """ + Me.Club.Text + """ ORDER BY Club;"
        Dim oDataAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)


        Try
            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Equips")
            oConexion.Close()

            Me.DgEquips.DataSource = oDataSet
            Me.DgEquips.DataMember = "Equips"

            ConfigurarDgEquips()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ConfigurarDgEquips()

        With Me.DgEquips
            .RowsDefaultCellStyle.BackColor = Color.Beige
            .BackgroundColor = Color.Beige
            .RowHeadersVisible = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            .ReadOnly = True

            .Columns.Item(0).HeaderText = "EQUIPS"    'Títol de columna
            .Columns.Item(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter    'Alineació d'encapçalament columna
            .Columns(0).Width = CInt(Me.DgEquips.Width * 0.99) 'Mides
        End With
    End Sub
    Private Sub BtnSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSortir.Click
        Me.Close()
    End Sub
    Private Sub BtnNouEquip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNouEquip.Click
        NouEquip.ShowDialog()
    End Sub
    Friend StrEquip As String = ""
    Private Sub DgEquips_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgEquips.CellContentDoubleClick
        StrEquip = Me.DgEquips.Rows(e.RowIndex).Cells(0).Value
        Dim Formulari As New ModificarEquip
        Formulari.ShowDialog()
    End Sub
End Class