Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.data.OleDb
Public Class DetallFactura
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection

    Private Sub DetallFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarDades()
        Me.AcceptButton = Me.BtnSortir
        Me.ControlBox = False
        Me.CenterToParent()
        Me.Text = "DETALL FACTURA" + " " + StrOrigenDeDades
    End Sub
    Private Sub DetallFactura_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        CarregarDades()
    End Sub
    Private Sub CarregarDades()

        Me.StartPosition = FormStartPosition.CenterParent
        'Me.DetTotal.Text = Factures.DgFactures.Rows(e.RowIndex).Cells(4).Value

        StrInstruccioSQL = ""
        StrCadenaConexio = ""

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = "SELECT Factures.NumFactura, Factures.DataEmisio, Factures.Client, Factures.Cif, Factures.Adreça, Factures.CP, Factures.Poblacio, Factures.Provincia" _
                + " FROM Factures" _
                + " WHERE Factures.NumFactura=" + StrNumFactura + ";"


        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
        oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)

        oDataSet = Nothing
        oDataSet = New DataSet()

        Try
            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Factures")
            oConexion.Close()
            If oDataSet.Tables("Factures").Rows.Count = 0 Then
                Me.Close()
                Factures.CarregarDades()
                Exit Sub
            Else
            End If
            Dim iPosicionActual As Integer
            iPosicionActual = 0
            Dim oDataRow As DataRow
            oDataRow = oDataSet.Tables("Factures").Rows(iPosicionActual)

            If VarType(oDataRow("NumFactura")) <> VariantType.Null Then
                Me.DetNumFactura.Text = Format(oDataRow("NumFactura"), "00000")
            Else
            End If

            If VarType(oDataRow("DataEmisio")) <> VariantType.Null Then
                Me.DetDataEmisio.Text = oDataRow("DataEmisio")
            Else
            End If

            If VarType(oDataRow("Client")) <> VariantType.Null Then
                Me.DetClient.Text = oDataRow("Client")
            Else
            End If

            If VarType(oDataRow("Cif")) <> VariantType.Null Then
                Me.DetCif.Text = oDataRow("Cif")
            Else
            End If

            If VarType(oDataRow("Adreça")) <> VariantType.Null Then
                Me.DetAdreça.Text = oDataRow("Adreça")
            Else
            End If

            If VarType(oDataRow("CP")) <> VariantType.Null Then
                Me.DetCP.Text = oDataRow("CP")
            Else
            End If

            If VarType(oDataRow("Poblacio")) <> VariantType.Null Then
                Me.DetPoblacio.Text = oDataRow("Poblacio")
            Else
            End If

            If VarType(oDataRow("Provincia")) <> VariantType.Null Then
                Me.DetProvincia.Text = oDataRow("Provincia")
            Else
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        StrInstruccioSQL = "SELECT ConceptesFactura.NumFactura, ConceptesFactura.IdEpisodi, ConceptesFactura.Pacient, ConceptesFactura.NumPolissa, ConceptesFactura.NumAutoritzacio, ConceptesFactura.Concepte, ConceptesFactura.Quantitat, ConceptesFactura.Preu, ConceptesFactura.Quantitat*ConceptesFactura.Preu As SubTotal" _
                + " FROM ConceptesFactura" _
                + " WHERE ConceptesFactura.NumFactura=" + StrNumFactura + ";"

        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)

        oDataSet = Nothing
        oDataSet = New DataSet()

        Try
            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "ConceptesFactura")
            oConexion.Close()

            Me.DgConceptes.DataSource = oDataSet
            Me.DgConceptes.DataMember = "ConceptesFactura"

            ConfigurarDgConceptes()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'MsgBox(Factures.DgFactures.Rows(Factures.IndexFila).Cells(3).Value).ToString()

        Me.DetImport.Text = Format(Factures.DgFactures.Rows(Factures.IndexFila).Cells(3).Value, "currency")
        Me.DetRetencio.Text = CStr(Factures.DgFactures.Rows(Factures.IndexFila).Cells(4).Value) + "%"
        Me.DetRetencioImport.Text = Format(Factures.DgFactures.Rows(Factures.IndexFila).Cells(5).Value, "currency")
        Me.DetTotal.Text = Format(Factures.DgFactures.Rows(Factures.IndexFila).Cells(6).Value, "currency")

    End Sub
    Private Sub ConfigurarDgConceptes()

        With Me.DgConceptes
            'COLOR
            .RowsDefaultCellStyle.BackColor = Color.Beige
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua

            'Només lectura i no es poden afegir registres
            .ReadOnly = True
            .AllowUserToAddRows = False

            'Columnes no visibles
            .Columns.Item(0).Visible = False
            .Columns.Item(1).Visible = False
            .RowHeadersVisible = False

            'Mides
            .Columns.Item(2).Width = CInt(Me.DgConceptes.Width * 0.28)
            .Columns.Item(3).Width = CInt(Me.DgConceptes.Width * 0.15)
            .Columns.Item(4).Width = CInt(Me.DgConceptes.Width * 0.15)
            .Columns.Item(5).Width = CInt(Me.DgConceptes.Width * 0.2)
            .Columns.Item(6).Width = CInt(Me.DgConceptes.Width * 0.075)
            .Columns.Item(7).Width = CInt(Me.DgConceptes.Width * 0.07)
            .Columns.Item(8).Width = CInt(Me.DgConceptes.Width * 0.07)

            'Títols de columna
            .Columns.Item(2).HeaderText = "Pacient"
            .Columns.Item(3).HeaderText = "Número targeta"
            .Columns.Item(4).HeaderText = "Número Autorització"
            .Columns.Item(5).HeaderText = "Concepte"
            .Columns.Item(6).HeaderText = "Quantitat"
            .Columns.Item(7).HeaderText = "Preu"
            .Columns.Item(8).HeaderText = "SubTotal"

            .Columns.Item(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter

            'No es poden canviar les mides de les files i columnes
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False

            'Format de columnes
            .Columns.Item(7).DefaultCellStyle.Format = Format(.Columns.Item(7).ToString, "###.00") + "€"
            .Columns.Item(8).DefaultCellStyle.Format = Format(.Columns.Item(8).ToString, "###.00") + "€"

            .Columns.Item(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            .Columns.Item(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight



        End With
    End Sub
    Private Sub BtnSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSortir.Click
        Factures.CarregarDades()
        Me.Close()
    End Sub
    Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimir.Click

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT ConceptesFactura.* FROM ConceptesFactura WHERE ConceptesFactura.NumFactura=" + Me.DetNumFactura.Text + ";"

        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
        oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
        oDataSet = Nothing
        oDataSet = New DataSet()

        oConexion.Open()
        oDataAdapter.Fill(oDataSet, "ConceptesFactura")
        oConexion.Close()

        Dim Informe As New InformeFactura()
        Informe.Subreports(0).SetDataSource(oDataSet.Tables("ConceptesFactura"))

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT Factures.* FROM Factures WHERE Factures.NumFactura=" + Me.DetNumFactura.Text + ";"

        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
        oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
        oDataSet = Nothing
        oDataSet = New DataSet()

        oConexion.Open()
        oDataAdapter.Fill(oDataSet, "Factures")
        oConexion.Close()

        Informe.SetDataSource(oDataSet.Tables("Factures"))
        'Dim odatosInforme As SummaryInfo = Informe.SummaryInfo
        'odatosInforme.ReportTitle = "Factura"
        ImprimirFactura.CrvFactura.ReportSource = Informe
        ImprimirFactura.Show()
    End Sub
    Friend StrIdEpisodiFactura As String
    Private Sub DgConceptes_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgConceptes.CellContentDoubleClick
        StrIdEpisodiFactura = Me.DgConceptes.Rows(e.RowIndex).Cells(1).Value
        Dim Formulari As New ModificarConcepteFactura
        Formulari.ShowDialog()
    End Sub
    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        Dim Formulari As New ModificarFactura
        Formulari.ShowDialog()
    End Sub
End Class