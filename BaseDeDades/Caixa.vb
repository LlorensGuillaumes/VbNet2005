Public Class Caixa
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection
    Private Sub Caixa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarDades()
        Me.Text = Me.Text + " " + StrOrigenDeDades

    End Sub
    Friend Sub CarregarDades()

        Me.WindowState = FormWindowState.Maximized
        Me.ControlBox = False
        Me.RbTotes.Checked = True
        Me.PaOpcions.Visible = False

        Me.CbTerapeuta.Checked = False
        Me.CbPacient.Checked = False
        Me.CbDescripcio.Checked = False

        Me.Terapeuta.Visible = False
        Me.Pacient.Visible = False
        Me.Descripcio.Visible = False

        Me.Label1.Visible = True
        Me.TotalCaixa.Visible = True

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT Caixa.* FROM Caixa ORDER BY Caixa.Data DESC;"
        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)


        Try
            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Caixa")
            oConexion.Close()

            Me.DgCaixa.DataSource = oDataSet
            Me.DgCaixa.DataMember = "Caixa"

            oDataSet = Nothing
            oDataSet = New DataSet()
            StrInstruccioSQL = ""
            StrInstruccioSQL = "SELECT Sum(Caixa.Preu) AS TotalCaixa FROM Caixa;"
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Caixa")
            oConexion.Close()

            Dim iPosicionActual As Integer
            iPosicionActual = 0
            Dim oDataRow As DataRow
            oDataRow = oDataSet.Tables("Caixa").Rows(iPosicionActual)

            If VarType(oDataRow("TotalCaixa")) <> VariantType.Null Then
                Me.TotalCaixa.Text = CStr(oDataRow("TotalCaixa")) + " €"
            Else
                Me.TotalCaixa.Text = ""
            End If

            ConfigurarCaixa()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ConfigurarCaixa()
        With Me.DgCaixa

            .RowsDefaultCellStyle.BackColor = Color.Beige
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua

            .Columns.Item(0).Visible = False
            .RowHeadersVisible = False 'Columna cursor lateral Selector de registre
            .AllowUserToAddRows = False 'No es poden afegir registres
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False

            'CONFIGURACIÓ DE COLUMNES
            .Columns.Item(1).HeaderText = "DATA"
            .Columns.Item(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns(1).Width = CInt(Me.DgCaixa.Width * 0.08)

            .Columns.Item(2).HeaderText = "TERAPEUTA"
            .Columns.Item(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns(2).Width = CInt(Me.DgCaixa.Width * 0.1)

            .Columns.Item(3).HeaderText = "PACIENT"
            .Columns.Item(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(3).Width = CInt(Me.DgCaixa.Width * 0.25)

            .Columns.Item(4).HeaderText = "DESCRIPCIÓ"
            .Columns.Item(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns(4).Width = CInt(Me.DgCaixa.Width * 0.4)

            .Columns.Item(5).HeaderText = "IMPORT"
            .Columns.Item(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns(5).Width = CInt(Me.DgCaixa.Width * 0.08)
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(5).DefaultCellStyle.Format = "0.00"

            .Columns.Item(6).HeaderText = "PRIVAT"
            .Columns.Item(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns(6).Width = CInt(Me.DgCaixa.Width * 0.07)
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        End With

    End Sub
    Private Sub BtnSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSortir.Click
        Me.Close()
    End Sub
    Private Sub RbFiltrar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbFiltrar.CheckedChanged
        Me.PaOpcions.Visible = True
        Me.AcceptButton = Me.BtnFiltar
    End Sub
    Private Sub RbTotes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbTotes.CheckedChanged
        Me.PaOpcions.Visible = False
        If Me.RbTotes.Checked = True Then
            CarregarDades()
            Me.Label1.Visible = True
            Me.TotalCaixa.Visible = True
        End If

    End Sub
    Private Sub CbTerapeuta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbTerapeuta.CheckedChanged
        If Me.CbTerapeuta.Checked = True Then
            Me.Terapeuta.Visible = True
            Me.Terapeuta.Focus()
        Else
            Me.Terapeuta.Visible = False
            Me.Terapeuta.Text = ""
        End If
    End Sub
    Private Sub CbPacient_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbPacient.CheckedChanged
        If Me.CbPacient.Checked = True Then
            Me.Pacient.Visible = True
            Me.Pacient.Focus()
        Else
            Me.Pacient.Visible = False
            Me.Pacient.Text = ""
        End If
    End Sub
    Private Sub CbDescripcio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbDescripcio.CheckedChanged
        If Me.CbDescripcio.Checked = True Then
            Me.Descripcio.Visible = True
            Me.Descripcio.Focus()
        Else
            Me.Descripcio.Visible = False
            Me.Descripcio.Text = ""
        End If
    End Sub
    Private Sub BtnFiltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFiltar.Click

        If Me.RbTotes.Checked = True Then
            CarregarDades()
            Exit Sub
        Else
        End If

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT Caixa.* FROM Caixa ORDER BY Caixa.Data DESC;"
        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)


        Try
            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Caixa")
            oConexion.Close()

            Me.DgCaixa.DataSource = oDataSet
            Me.DgCaixa.DataMember = "Caixa"

            Dim oDataView As New DataView()
            oDataView.Table = oDataSet.Tables("Caixa")
            oDataView.RowFilter = "Terapeuta Like '*" + Me.Terapeuta.Text + "*' and NomPacient LIKE '*" + Me.Pacient.Text + "*' AND Descripcio LIKE '*" + Me.Descripcio.Text + "*'"

            Me.DgCaixa.DataSource = oDataView

            oDataSet = Nothing
            oDataSet = New DataSet()
            StrInstruccioSQL = ""
            StrInstruccioSQL = "SELECT Sum(Caixa.Preu) AS TotalCaixa FROM Caixa;"
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Caixa")
            oConexion.Close()

            Dim iPosicionActual As Integer
            iPosicionActual = 0
            Dim oDataRow As DataRow
            oDataRow = oDataSet.Tables("Caixa").Rows(iPosicionActual)

            If VarType(oDataRow("TotalCaixa")) <> VariantType.Null Then
                Me.TotalCaixa.Text = CStr(oDataRow("TotalCaixa")) + " €"
            Else
                Me.TotalCaixa.Text = ""
            End If

            Me.TotalCaixa.Visible = False
            Me.Label1.Visible = False
            ConfigurarCaixa()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub BtnNovaEntrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNovaEntrada.Click
        NovaEntradaCaixa.ShowDialog()
    End Sub
End Class