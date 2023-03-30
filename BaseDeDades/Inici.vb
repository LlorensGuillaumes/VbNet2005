Public Class Inici
    Inherits System.Windows.Forms.Form

    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection

    'Declaracions del Menú Arxiu
    Private MenuArxiu As MenuItem

    WithEvents SubMenuTancarSessio As MenuItem
    Private EvSubMenuTancarSessio As System.EventHandler

    WithEvents SubMenuSortir As MenuItem
    Private EvSubMenuSortir As System.EventHandler

    'Declaracions del Menú Llistats

    Private MenuLlistats As MenuItem

    WithEvents SubMenuRecosAptitut As MenuItem
    Private EvSubMenuRecosAptitut As System.EventHandler

    'Declaracions del Menú Mútes
    Private MenuMutues As MenuItem

    WithEvents SubMenuMutua As MenuItem
    Private EvSubMenuMutua As System.EventHandler

    'Declaracions del Menú Usuari

    Private MenuUsuari As MenuItem
    Private MenuEsports As MenuItem

    WithEvents SubMenuCanviarContrasenya As MenuItem
    Private EvSubMenuCanviarContrasenya As System.EventHandler

    WithEvents SubMenuTramits As MenuItem
    Private EvSubMenuTramits As System.EventHandler

    'Declaracions del Menú Factures
    Private MenuFactures As MenuItem

    WithEvents SubMenuFactures As MenuItem
    Private EvSubMenuFactures As System.EventHandler

    'Declaracions del Menú Caixa
    Private MenuCaixa As MenuItem

    WithEvents SubMenuCaixa As MenuItem
    Private EvSubMenuCaixa As System.EventHandler

    'Declaracions del Menú Esports

    WithEvents SubMenuClubs As MenuItem
    Private EvSubMenuClubs As System.EventHandler

    WithEvents SubMenuEquips As MenuItem
    Private EvSubMenuEquips As System.EventHandler

    'Declaracion del Menú Gestió
    Private MenuGestio As MenuItem

    WithEvents SubMenuTerapeutes As MenuItem
    Private EvSubMenuTerapeutes As System.EventHandler
    Private Sub MenuTerapeutes(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuTerapeutes.Click
        Terapeutes.ShowDialog()
    End Sub
    Private Sub BusquedaRapida(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BuscarNom.KeyDown, BuscarPrimerCognom.KeyDown, BuscarSegonCognom.KeyDown, DgPacients.KeyDown
        If e.KeyCode = Keys.F12 Then
            CodiBarres.ShowDialog()
        Else
        End If
    End Sub
    Private Sub Inici_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "BUSCAR PACIENTS" + " " + StrOrigenDeDades
        CarregarDadesInici()
        CrearBarraHerramientas()
    End Sub
    Private Sub Inici_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.BuscarNom.Text = ""
        Me.BuscarPrimerCognom.Text = ""
        Me.BuscarSegonCognom.Text = ""
        Me.BuscarNom.Focus()
    End Sub
    Private Sub CarregarDadesInici()

        'Assigno el butó predeterminat amb la tecla INTRO   
        Me.AcceptButton = Button2
        Me.WindowState = FormWindowState.Maximized
        Me.ControlBox = False

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = "SELECT DadesPacient.Nom, DadesPacient.PrimerCognom, DadesPacient.SegonCognom, DadesPacient.Dni, DadesPacient.TelFix, DadesPacient.TelMob, DadesPacient.TelFeina, Dadespacient.DN, DadesPacient.CI, DadesPacient.IdPacient FROM DadesPacient;"

        Try
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "dadespacient")
            oConexion.Close()

            Me.DgPacients.DataSource = oDataSet
            Me.DgPacients.DataMember = "dadespacient"

            'oDataView, serveix per treballar amb el DataGridView
            Dim oDataView As New DataView()

            'Assigno el DataSet i la taula al DataView
            oDataView.Table = oDataSet.Tables("DadesPacient")
            'Ordeno el DataGrid per la columna Nom, en cas d'ordenació múltiple, seria Columna1, Columna2,...
            oDataView.Sort = "Nom, PrimerCognom, SegonCognom"

            oDataView.RowFilter = ""

            'Assigno el DataView al DataSource del DataGrid
            Me.DgPacients.DataSource = oDataView

            ConfigurarDgPacients()
            StrInstruccioSQL = ""
            Me.BuscarNom.Text = ""
            Me.BuscarPrimerCognom.Text = ""
            Me.BuscarSegonCognom.Text = ""

        Catch ex As Exception
            MsgBox("Comprova que l'origen de dades, sigui vàlid", 16, "Fisiomèdic")
            Autentificacio.Close()
            Exit Sub
        End Try
    End Sub
    Private Sub CrearBarraHerramientas()

        'CREO LA BARRA DE HERRAMIENTAS

        ''''''''''''''''''''''''''''''''
        '''''''''' MENU ARXIU ''''''''''
        ''''''''''''''''''''''''''''''''

        MenuArxiu = New MenuItem
        MenuArxiu.Text = "Arxiu"

        SubMenuTancarSessio = New MenuItem
        SubMenuTancarSessio.Text = "Tancar sessió"
        AddHandler SubMenuTancarSessio.Click, EvSubMenuTancarSessio

        SubMenuSortir = New MenuItem
        SubMenuSortir.Text = "Sortir"
        AddHandler SubMenuSortir.Click, EvSubMenuSortir



        ''''''''''''''''''''''''''''''''
        ''''''''' MENU USUARI ''''''''''
        ''''''''''''''''''''''''''''''''

        MenuUsuari = New MenuItem
        MenuUsuari.Text = "Usuari"

        SubMenuCanviarContrasenya = New MenuItem
        SubMenuCanviarContrasenya.Text = "Canviar contrasenya"
        AddHandler SubMenuCanviarContrasenya.Click, EvSubMenuCanviarContrasenya

        SubMenuTramits = New MenuItem
        SubMenuTramits.Text = "Tràmits"
        AddHandler SubMenuTramits.Click, EvSubMenuTramits

        If strIdGrupUsuari = 1111 Then
            SubMenuTramits.Enabled = True
        Else
            SubMenuTramits.Enabled = False
        End If


        ''''''''''''''''''''''''''''''''
        ''''''''' MENU MÚTUES ''''''''''
        ''''''''''''''''''''''''''''''''

        MenuMutues = New MenuItem
        MenuMutues.Text = "Entitats"

        MenuEsports = New MenuItem
        MenuEsports.Text = "Esports"

        SubMenuMutua = New MenuItem
        SubMenuMutua.Text = "Llistat de mútues"
        AddHandler SubMenuMutua.Click, EvSubMenuMutua



        SubMenuClubs = New MenuItem
        SubMenuClubs.Text = "Clubs"
        AddHandler SubMenuClubs.Click, EvSubMenuClubs

        SubMenuEquips = New MenuItem
        SubMenuEquips.Text = "Equips"
        AddHandler SubMenuEquips.Click, EvSubMenuEquips



        ''''''''''''''''''''''''''''''''
        '''''''' MENU FACTURES '''''''''
        ''''''''''''''''''''''''''''''''

        MenuFactures = New MenuItem
        MenuFactures.Text = "Factures"

        SubMenuFactures = New MenuItem
        SubMenuFactures.Text = "Llistat de factures"
        AddHandler SubMenuFactures.Click, EvSubMenuFactures

        ''''''''''''''''''''''''''''''''
        ''''''''' MENU CAIXA '''''''''''
        ''''''''''''''''''''''''''''''''

        MenuCaixa = New MenuItem
        MenuCaixa.Text = "Caixa"

        SubMenuCaixa = New MenuItem
        SubMenuCaixa.Text = "Entrades"
        AddHandler SubMenuCaixa.Click, EvSubMenuCaixa

        ''''''''''''''''''''''''''''''''
        ''''''''' MENU LLISTATS '''''''''''
        ''''''''''''''''''''''''''''''''

        MenuLlistats = New MenuItem
        MenuLlistats.Text = "Llistats"

        SubMenuRecosAptitut = New MenuItem
        SubMenuRecosAptitut.Text = "Reconeixements"
        AddHandler SubMenuRecosAptitut.Click, EvSubMenuRecosAptitut

        ''''''''''''''''''''''''''''''''
        ''''''''' GESTIO  '''''''''''
        ''''''''''''''''''''''''''''''''

        MenuGestio = New MenuItem
        MenuGestio.Text = "Gestió de dades"

        SubMenuTerapeutes = New MenuItem
        SubMenuTerapeutes.Text = "Terapeutes"
        AddHandler SubMenuTerapeutes.Click, EvSubMenuTerapeutes


        'Poso les SubOpcions al menú
        MenuEsports.MenuItems.AddRange(New MenuItem() {SubMenuClubs, SubMenuEquips})

        MenuArxiu.MenuItems.AddRange(New MenuItem() {SubMenuTancarSessio, SubMenuSortir})
        MenuUsuari.MenuItems.AddRange(New MenuItem() {SubMenuTramits, SubMenuCanviarContrasenya})
        MenuMutues.MenuItems.AddRange(New MenuItem() {SubMenuMutua, MenuEsports})
        MenuFactures.MenuItems.AddRange(New MenuItem() {SubMenuFactures})
        MenuCaixa.MenuItems.AddRange(New MenuItem() {SubMenuCaixa})
        MenuLlistats.MenuItems.AddRange(New MenuItem() {SubMenuRecosAptitut})
        MenuGestio.MenuItems.AddRange(New MenuItem() {SubMenuTerapeutes})

        'Poso les opcions i SubOpcions a la barra menú
        Me.Menu = New MainMenu

        Me.Menu.MenuItems.Add(MenuArxiu)
        Me.Menu.MenuItems.Add(MenuUsuari)
        Me.Menu.MenuItems.Add(MenuMutues)
        Me.Menu.MenuItems.Add(MenuFactures)
        Me.Menu.MenuItems.Add(MenuCaixa)
        Me.Menu.MenuItems.Add(MenuLlistats)
        Me.Menu.MenuItems.Add(MenuGestio)
    End Sub
    Private Sub LlitatRecosAptitut(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuRecosAptitut.Click
        Dim Formulari As New LlistatRecos
        Formulari.ShowDialog()
    End Sub
    Private Sub ControlEquips(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuEquips.Click
        Equips.ShowDialog()
    End Sub
    Private Sub ControlClubs(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuClubs.Click
        ClubsEsportius.ShowDialog()
    End Sub
    Private Sub EntradaCaixa(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuCaixa.Click
        Caixa.ShowDialog()
    End Sub
    Private Sub LlistarFactures(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuFactures.Click
        Factures.ShowDialog()
    End Sub
    Private Sub LlistarMutues(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuMutua.Click
        Mutues.ShowDialog()
    End Sub
    Private Sub TancarSessio(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuTancarSessio.Click
        Autentificacio.ShowDialog()
        Me.Close()
    End Sub
    Private Sub Sortir(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuSortir.Click
        Me.Close()
    End Sub
    Private Sub ObrirTramitsUsuari(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuTramits.Click
        TramitsUsuari.ShowDialog()
    End Sub
    Private Sub MnCanviarContrasenya(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuCanviarContrasenya.Click
        CanviarContrasenya.ShowDialog()
    End Sub
    Public Sub ConfigurarDgPacients()
        'Configuro com es veu el DataGridView
        With Me.DgPacients

            'COLOR
            .RowsDefaultCellStyle.BackColor = Color.Beige
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua

            'COLUMNES NO VISIBLES
            .Columns(9).Visible = False 'IdPacient
            .RowHeadersVisible = False 'Columna cursor lateral Selector de registre

            .AllowUserToAddRows = False 'No es poden afegir registres

            'SOLO LECTURA
            .ReadOnly = True

            'CONFIGURACIÓ DE COLUMNES
            .Columns.Item(0).HeaderText = "NOM"    'Títol de columna
            .Columns.Item(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter    'Alineació d'encapçalament columna
            .Columns(0).Width = CInt(Me.DgPacients.Width * 0.2) 'Mides

            .Columns.Item(1).HeaderText = "PRIMER COGNOM"
            .Columns.Item(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns(1).Width = CInt(Me.DgPacients.Width * 0.2)

            .Columns.Item(2).HeaderText = "SEGON COGNOM"
            .Columns.Item(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns(2).Width = CInt(Me.DgPacients.Width * 0.2)

            .Columns.Item(3).HeaderText = "DNI"
            .Columns.Item(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter

            .Columns.Item(4).HeaderText = "TEL. FIXE"
            .Columns.Item(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns(4).Width = CInt(Me.DgPacients.Width * 0.095)

            .Columns.Item(5).HeaderText = "TEL. MÓBIL"
            .Columns.Item(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns(5).Width = CInt(Me.DgPacients.Width * 0.095)

            .Columns.Item(6).HeaderText = "TEL. FEINA"
            .Columns.Item(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns(6).Width = CInt(Me.DgPacients.Width * 0.095)

            .Columns.Item(7).HeaderText = "D/N"
            .Columns.Item(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter

            .Columns.Item(8).HeaderText = "CI"
            .Columns.Item(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        End With

    End Sub
    Private Sub DgPacients_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgPacients.CellContentDoubleClick
        Try
            StrIdPacient = Me.DgPacients.Rows(e.RowIndex).Cells(9).Value()
            Episodis.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub
    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio
        StrInstruccioSQL = "SELECT DadesPacient.Nom, DadesPacient.PrimerCognom, DadesPacient.SegonCognom, DadesPacient.Dni, DadesPacient.TelFix, DadesPacient.TelMob, DadesPacient.TelFeina, Dadespacient.DN, DadesPacient.CI, DadesPacient.IdPacient FROM DadesPacient;"

        Try
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
            oDataSet = Nothing
            oDataSet = New DataSet()

            oDataAdapter.Fill(oDataSet, "dadespacient")

            Me.DgPacients.DataSource = oDataSet
            Me.DgPacients.DataMember = "dadespacient"

            'oDataView, serveix per treballar amb el DataGridView
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim oDataView As New DataView()
            oDataView.Table = oDataSet.Tables("DadesPacient")
            oDataView.RowFilter = "Nom Like '*" + Me.BuscarNom.Text + "*' and PrimerCognom LIKE '*" + Me.BuscarPrimerCognom.Text + "*' AND SegonCognom LIKE '*" + Me.BuscarSegonCognom.Text + "*'"
            oDataView.Sort = "Nom, PrimerCognom, SegonCognom"

            Me.DgPacients.DataSource = oDataView

            'CRIDO LA SUBRUTINA DE CONFIGURACIÓ DEL DgPacients
            ConfigurarDgPacients()
        Catch ex As Exception
            MsgBox("Error en el filtrat de dades", , "Fisimèdic")
        End Try

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Formulari As New NouPacient
        Formulari.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
