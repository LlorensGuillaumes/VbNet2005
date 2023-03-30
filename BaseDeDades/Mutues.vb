Public Class Mutues
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection

    Private MenuMutua As MenuItem

    WithEvents SubMenuNovaMutua As MenuItem
    Private EvSubMenuNovaMutua As System.EventHandler

    Private Sub Mutues_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarDgMutues()
        Me.ControlBox = False
        Me.WindowState = FormWindowState.Maximized
        Me.AcceptButton = BtnBuscar
        Me.BuscarMutua.CharacterCasing = CharacterCasing.Upper
        Me.BuscarMutua.Focus()
        Me.Text = Me.Text + " " + StrOrigenDeDades
    End Sub
    Friend Sub CarregarDgMutues()

        MenuMutua = New MenuItem
        MenuMutua.Text = "Mutua"

        SubMenuNovaMutua = New MenuItem
        SubMenuNovaMutua.Text = "Nova mútua"
        AddHandler SubMenuNovaMutua.Click, EvSubMenuNovaMutua


        MenuMutua.MenuItems.AddRange(New MenuItem() {SubMenuNovaMutua})

        Me.Menu = New MainMenu
        Me.Menu.MenuItems.Add(MenuMutua)
        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = "SELECT Mutues.Nom, Mutues.Telefon1, Mutues.Telefon2, Mutues.Telefon3, Mutues.Fax1, Mutues.Fax2, Mutues.Contacte" _
                + " FROM Mutues" _
                + " ORDER BY Mutues.Nom;"

        Try
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Mutues")
            oConexion.Close()

            Me.DgMutues.DataSource = oDataSet
            Me.DgMutues.DataMember = "Mutues"

        Catch ex As Exception
            MsgBox("Comprova que l'origen de dades, sigui vàlid", 16, "Fisiomèdic")
        End Try
        ConfigurarDgMutues()
    End Sub
    Private Sub ConfigurarDgMutues()
        'COLOR

        With Me.DgMutues

            .RowsDefaultCellStyle.BackColor = Color.Beige
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua

            .BackgroundColor = Color.Beige

            'COLUMNES NO VISIBLES
            .RowHeadersVisible = False 'Columna cursor lateral Selector de registre

            .AllowUserToAddRows = False 'No es poden afegir registres

            'SOLO LECTURA
            .ReadOnly = True

            'CONFIGURACIÓ DE COLUMNES
            .Columns.Item(0).HeaderText = "Mutua"    'Títol de columna
            .Columns.Item(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter    'Alineació d'encapçalament columna
            .Columns(0).Width = CInt(Me.DgMutues.Width * 0.3) 'Mides

            .Columns.Item(1).HeaderText = "Telf General"
            .Columns.Item(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns(1).Width = CInt(Me.DgMutues.Width * 0.075)

            'Me.DgMutues.Columns.Item(1).DefaultCellStyle = Format(Me.DgMutues.Columns.Item(1), "## ### ###")

            .Columns.Item(2).HeaderText = "Telf Autoritzacions"
            .Columns.Item(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns(2).Width = CInt(Me.DgMutues.Width * 0.075)

            .Columns.Item(3).HeaderText = "Teléfon"
            .Columns.Item(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns(3).Width = CInt(Me.DgMutues.Width * 0.075)

            .Columns.Item(4).HeaderText = "Fax general"
            .Columns.Item(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns(4).Width = CInt(Me.DgMutues.Width * 0.075)

            .Columns.Item(5).HeaderText = "Fax autoritzacions"
            .Columns.Item(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns(5).Width = CInt(Me.DgMutues.Width * 0.075)

            .Columns.Item(6).HeaderText = "Persona de contacte"
            .Columns.Item(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns(6).Width = CInt(Me.DgMutues.Width * 0.3)

        End With
    End Sub
    Private Sub DgMutues_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgMutues.CellContentDoubleClick
        StrMutua = Me.DgMutues.Rows(e.RowIndex).Cells(0).Value()
        DetallMutua.Show()
    End Sub
    Private Sub BtnSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSortir.Click
        Me.Close()
    End Sub
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = "SELECT Mutues.Nom, Mutues.Telefon1, Mutues.Telefon2, Mutues.Telefon3, Mutues.Fax1, Mutues.Fax2, Mutues.Contacte" _
                + " FROM Mutues" _
                + " ORDER BY Mutues.Nom;"
        Try
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Mutues")
            oConexion.Close()

            Me.DgMutues.DataSource = oDataSet
            Me.DgMutues.DataMember = "Mutues"

            Dim oDataView As New DataView()
            oDataView.Table = oDataSet.Tables("Mutues")
            oDataView.RowFilter = "Nom Like '*" + Me.BuscarMutua.Text + "*'"
            oDataView.Sort = "Nom"

            Me.DgMutues.DataSource = oDataView
            Me.BuscarMutua.Text = ""
        Catch ex As Exception
            MsgBox("Comprova que l'origen de dades, sigui vàlid", 16, "Fisiomèdic")
        End Try
        ConfigurarDgMutues()
    End Sub
    Private Sub MostrarTotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTotes.Click
        CarregarDgMutues()
    End Sub
    Private Sub CrearNovaMutua(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuNovaMutua.Click
        Dim oFormulari As New NovaMutua()
        oFormulari.ShowDialog()
    End Sub
End Class