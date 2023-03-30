Public Class Factures
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection
    Private oDataSetActual As DataSet

    Private Sub Factures_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarDades()
        Me.ControlBox = False
        Me.AcceptButton = Me.BtnSortir
        Me.Text = Me.Text + " " + StrOrigenDeDades
    End Sub
    Friend Sub CarregarDades()

        StrInstruccioSQL = ""
        StrCadenaConexio = ""

        Me.BuscarTotes.Checked = True
        Me.EntreA.Visible = False
        Me.EntreB.Visible = False
        Me.EtEntreA.Visible = False
        Me.EtEntreB.Visible = False
        Me.LlistatBuscar.Visible = False
        Me.RbLlistat.Checked = True

        Me.WindowState = FormWindowState.Maximized

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = "SELECT PreConsultaFactures.NumFactura, PreConsultaFactures.DataEmisio, PreConsultaFactures.Client, Sum(PreConsultaFactures.Import) AS SumaDeImport, PreConsultaFactures.Retencio, Sum(PreConsultaFactures.RetencioImport) AS SumaDeRetencioImport, Sum(PreConsultaFactures.Total) AS SumaDeTotal, PreConsultaFactures.Cobrada" _
                    + " FROM(PreConsultaFactures)" _
                    + " GROUP BY PreConsultaFactures.NumFactura, PreConsultaFactures.DataEmisio, PreConsultaFactures.Client, PreConsultaFactures.Retencio, PreConsultaFactures.Cobrada;"
        Try

            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
            oDataSet = Nothing
            ODataset = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(ODataset, "Factures")
            oConexion.Close()

            oDataSetActual = oDataSet
            Me.DgFactures.DataSource = ODataset
            Me.DgFactures.DataMember = "Factures"

            ConfigurarDgFactures()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public IndexFila As Integer
    Private Sub DgFactures_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgFactures.CellContentDoubleClick
        StrNumFactura = Me.DgFactures.Rows(e.RowIndex).Cells(0).Value()
        IndexFila = e.RowIndex
        DetallFactura.ShowDialog()
    End Sub
    Private Sub FormatCondicional(ByVal Sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DgFactures.CellFormatting
        If DgFactures.Rows(e.RowIndex).Cells("Cobrada").Value = True Then
            DgFactures.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Aqua
        Else
            DgFactures.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
        End If
    End Sub
    Private Sub ConfigurarDgFactures()

        With DgFactures

            'Només lectura i no es poden afegir registres
            .ReadOnly = True
            .AllowUserToAddRows = False

            'Columnes no visibles
            .RowHeadersVisible = False

            'Mides
            .Columns.Item(0).Width = CInt(Me.DgFactures.Width * 0.07) 'NumFactura
            .Columns.Item(1).Width = CInt(Me.DgFactures.Width * 0.09) 'DataEmisio
            .Columns.Item(2).Width = CInt(Me.DgFactures.Width * 0.415) 'Client
            .Columns.Item(3).Width = CInt(Me.DgFactures.Width * 0.09) 'Import
            .Columns.Item(4).Width = CInt(Me.DgFactures.Width * 0.07) '%Retencio
            .Columns.Item(5).Width = CInt(Me.DgFactures.Width * 0.07) '€ Retencio
            .Columns.Item(6).Width = CInt(Me.DgFactures.Width * 0.09) 'Total
            .Columns.Item(7).Width = CInt(Me.DgFactures.Width * 0.08) 'Cobrada

            .Columns.Item(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            .Columns.Item(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            .Columns.Item(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            .Columns.Item(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

            'Títols de columna
            .Columns.Item(0).HeaderText = "Núm. factura"
            .Columns.Item(1).HeaderText = "Data d'emisió"
            .Columns.Item(2).HeaderText = "Client"
            .Columns.Item(3).HeaderText = "Import"
            .Columns.Item(4).HeaderText = "Retenció %"
            .Columns.Item(5).HeaderText = "Retenció €"
            .Columns.Item(6).HeaderText = "Total"
            .Columns.Item(7).HeaderText = "Cobrada"

            .Columns.Item(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter

            'No es poden canviar les mides de les files i columnes
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False

            'Format de columnes
            .Columns.Item(0).DefaultCellStyle.Format = Format(.Columns.Item(0).ToString, "00000")
            .Columns.Item(3).DefaultCellStyle.Format = Format(.Columns.Item(3).ToString, "#0.00") + "€"
            .Columns.Item(5).DefaultCellStyle.Format = Format(.Columns.Item(5).ToString, "#0.00") + "€"
            .Columns.Item(6).DefaultCellStyle.Format = Format(.Columns.Item(7).ToString, "#0.00") + "€"
        End With
    End Sub
    Private Sub SeleccionarTipusFiltre(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarNumFactura.CheckedChanged, BuscarDataEmisio.CheckedChanged, BuscarClient.CheckedChanged, BuscarDetall.CheckedChanged

        Dim Taula As String
        Dim Llista As String

        If Me.BuscarNumFactura.Checked = True Then
            With Me.EntreA
                .Visible = True
                .Text = ""
                .MaxLength = 5
            End With

            With Me.EntreB
                .Visible = True
                .Text = ""
                .MaxLength = 5
            End With

            Me.EtEntreA.Visible = True
            Me.EtEntreB.Visible = True
            Me.LlistatBuscar.Visible = False

            Me.EntreA.Focus()
            Exit Sub

        ElseIf Me.BuscarDataEmisio.Checked = True Then
            With Me.EntreA
                .Visible = True
                .Text = ""
                .MaxLength = 10
            End With

            With Me.EntreB
                .Visible = True
                .Text = ""
                .MaxLength = 10
            End With

            Me.EtEntreA.Visible = True
            Me.EtEntreB.Visible = True
            Me.LlistatBuscar.Visible = False

            Me.EntreA.Focus()
            Exit Sub

        ElseIf Me.BuscarClient.Checked = True Then
            Me.EntreA.Visible = False
            Me.EntreB.Visible = False
            Me.EtEntreA.Visible = False
            Me.EtEntreB.Visible = False
            Me.LlistatBuscar.Visible = True

            StrInstruccioSQL = ""
            StrInstruccioSQL = "SELECT Factures.Client FROM Factures GROUP BY Factures.Client;"
            Taula = "Factures"
            Llista = "Client"

            Me.LlistatBuscar.Focus()

        ElseIf Me.BuscarDetall.Checked = True Then
            Me.EntreA.Visible = False
            Me.EntreB.Visible = False
            Me.EtEntreA.Visible = False
            Me.EtEntreB.Visible = False
            Me.LlistatBuscar.Visible = True

            StrInstruccioSQL = ""
            StrInstruccioSQL = "SELECT ConceptesFactura.Pacient FROM ConceptesFactura GROUP BY ConceptesFactura.Pacient;"
            Taula = "ConceptesFactura"
            Llista = "Pacient"

            Me.LlistatBuscar.Focus()

        ElseIf Me.BuscarNoCobrades.Checked = True Then
            Me.EntreA.Visible = False
            Me.EntreB.Visible = False
            Me.EtEntreA.Visible = False
            Me.EtEntreB.Visible = False
            Me.LlistatBuscar.Visible = False
            Exit Sub

        ElseIf Me.BuscarTotes.Checked = True Then
            Me.EntreA.Visible = False
            Me.EntreB.Visible = False
            Me.EtEntreA.Visible = False
            Me.EtEntreB.Visible = False
            Me.LlistatBuscar.Visible = False
            Exit Sub

        Else
            MsgBox("hla")
            Exit Sub
        End If

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
        oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
        ODataset = Nothing
        ODataset = New DataSet()

        Try
            oConexion.Open()
            oDataAdapter.Fill(oDataSet, Taula)
            oConexion.Close()

            Me.LlistatBuscar.DataSource = ODataset.Tables(Taula)
            Me.LlistatBuscar.DisplayMember = Llista
            Me.LlistatBuscar.ValueMember = Llista

            Me.LlistatBuscar.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.LlistatBuscar.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFiltrar.Click

        StrInstruccioSQL = ""
        If Me.BuscarNumFactura.Checked = True Then

            StrInstruccioSQL = "SELECT PreConsultaFactures.NumFactura, PreConsultaFactures.DataEmisio, PreConsultaFactures.Client, Sum(PreConsultaFactures.Import) AS SumaDeImport, PreConsultaFactures.Retencio, Sum(PreConsultaFactures.RetencioImport) AS SumaDeRetencioImport, Sum(PreConsultaFactures.Total) AS SumaDeTotal, PreConsultaFactures.Cobrada" _
                    + " FROM(PreConsultaFactures)" _
                    + " GROUP BY PreConsultaFactures.NumFactura, PreConsultaFactures.DataEmisio, PreConsultaFactures.Client, PreConsultaFactures.Retencio, PreConsultaFactures.Cobrada" _
                    + " HAVING PreConsultaFactures.NumFactura Between " + Me.EntreA.Text + " And " + Me.EntreB.Text + ";"


        ElseIf Me.BuscarDataEmisio.Checked = True Then

            StrInstruccioSQL = "SELECT PreConsultaFactures.NumFactura, PreConsultaFactures.DataEmisio, PreConsultaFactures.Client, Sum(PreConsultaFactures.Import) AS SumaDeImport, PreConsultaFactures.Retencio, Sum(PreConsultaFactures.RetencioImport) AS SumaDeRetencioImport, Sum(PreConsultaFactures.Total) AS SumaDeTotal, PreConsultaFactures.Cobrada" _
                    + " FROM(PreConsultaFactures)" _
                    + " GROUP BY PreConsultaFactures.NumFactura, PreConsultaFactures.DataEmisio, PreConsultaFactures.Client, PreConsultaFactures.Retencio, PreConsultaFactures.Cobrada" _
                    + " HAVING PreConsultaFactures.DataEmisio Between #" + CStr(Format(CDate(Me.EntreA.Text), "MM/dd/yyyy")) + "# And #" + CStr(Format(CDate(Me.EntreB.Text), "MM/dd/yyyy")) + "#;"

        ElseIf Me.BuscarNoCobrades.Checked = True Then

            StrInstruccioSQL = "SELECT PreConsultaFactures.NumFactura, PreConsultaFactures.DataEmisio, PreConsultaFactures.Client, Sum(PreConsultaFactures.Import) AS SumaDeImport, PreConsultaFactures.Retencio, Sum(PreConsultaFactures.RetencioImport) AS SumaDeRetencioImport, Sum(PreConsultaFactures.Total) AS SumaDeTotal, PreConsultaFactures.Cobrada" _
                    + " FROM(PreConsultaFactures)" _
                    + " GROUP BY PreConsultaFactures.NumFactura, PreConsultaFactures.DataEmisio, PreConsultaFactures.Client, PreConsultaFactures.Retencio, PreConsultaFactures.Cobrada" _
                    + " HAVING PreConsultaFactures.Cobrada=false;"

        ElseIf Me.BuscarTotes.Checked = True Then

            StrInstruccioSQL = "SELECT PreConsultaFactures.NumFactura, PreConsultaFactures.DataEmisio, PreConsultaFactures.Client, Sum(PreConsultaFactures.Import) AS SumaDeImport, PreConsultaFactures.Retencio, Sum(PreConsultaFactures.RetencioImport) AS SumaDeRetencioImport, Sum(PreConsultaFactures.Total) AS SumaDeTotal, PreConsultaFactures.Cobrada" _
                    + " FROM(PreConsultaFactures)" _
                    + " GROUP BY PreConsultaFactures.NumFactura, PreConsultaFactures.DataEmisio, PreConsultaFactures.Client, PreConsultaFactures.Retencio, PreConsultaFactures.Cobrada;"

        ElseIf Me.BuscarClient.Checked = True Then

            StrInstruccioSQL = "SELECT PreConsultaFactures.NumFactura, PreConsultaFactures.DataEmisio, PreConsultaFactures.Client, Sum(PreConsultaFactures.Import) AS SumaDeImport, PreConsultaFactures.Retencio, Sum(PreConsultaFactures.RetencioImport) AS SumaDeRetencioImport, Sum(PreConsultaFactures.Total) AS SumaDeTotal, PreConsultaFactures.Cobrada" _
                    + " FROM(PreConsultaFactures)" _
                    + " GROUP BY PreConsultaFactures.NumFactura, PreConsultaFactures.DataEmisio, PreConsultaFactures.Client, PreConsultaFactures.Retencio, PreConsultaFactures.Cobrada" _
                    + " HAVING PreConsultaFactures.Client=""" + Me.LlistatBuscar.Text + """;"

        ElseIf Me.BuscarDetall.Checked = True Then

            StrInstruccioSQL = "SELECT ConceptesFactura.NumFactura, PreConsultaFactures.DataEmisio, PreConsultaFactures.Client, Sum(PreConsultaFactures.Import) AS SumaDeImport, PreConsultaFactures.Retencio, Sum(PreConsultaFactures.RetencioImport) AS SumaDeRetencioImport, Sum(PreConsultaFactures.Total) AS SumaDeTotal, PreConsultaFactures.Cobrada, ConceptesFactura.Pacient" _
                    + " FROM(PreConsultaFactures) INNER JOIN ConceptesFactura ON PreConsultaFactures.NumFactura = ConceptesFactura.NumFactura" _
                    + " GROUP BY ConceptesFactura.NumFactura, PreConsultaFactures.DataEmisio, PreConsultaFactures.Client, PreConsultaFactures.Retencio, PreConsultaFactures.Cobrada, ConceptesFactura.Pacient" _
                    + " HAVING ConceptesFactura.Pacient=""" + Me.LlistatBuscar.Text + """;"

        End If

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        Try
            Dim oDataAdapter As New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            Dim oCb As OleDb.OleDbCommandBuilder = New OleDb.OleDbCommandBuilder(oDataAdapter)
            Dim ODataset As New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Factures")
            oConexion.Close()

            oDataSetActual = ODataset
            Me.DgFactures.DataSource = oDataSet
            Me.DgFactures.DataMember = "Factures"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ConfigurarDgFactures()
    End Sub
    Private Sub EntreA_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntreA.Leave, EntreB.Leave
        Try
            If Me.BuscarDataEmisio.Checked = True Then
                If Me.EntreA.Text <> "" Then
                    Me.EntreA.Text = CStr(Format(CDate(Me.EntreA.Text), "dd/MMM/yyyy"))
                End If
                If Me.EntreB.Text <> "" Then
                    Me.EntreB.Text = CStr(Format(CDate(Me.EntreB.Text), "dd/MMM/yyyy"))
                Else
                End If

            End If
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try

    End Sub
    Private Sub BtnSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSortir.Click
        Me.Close()
    End Sub
    Private Sub BtnLlitatFactures_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLlitatFactures.Click

        'StrNumFactura = Me.DgFactures.Rows(e.RowIndex).Cells(0).Value()
        'ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs
        Dim iPosicioActual As Integer
        Dim Files As Integer = Me.DgFactures.Rows.Count
        Dim oDataRow As DataRow

        Dim CriterisFactures As String = ""
        Dim CriterisDetall As String = ""

        If Files > 0 Then
            For iPosicioActual = 0 To Files - 1
                oDataRow = oDataSetActual.Tables("Factures").Rows(iPosicioActual)
                
                If iPosicioActual = 0 Then
                    CriterisFactures = "Factures.NumFactura=" + CStr(oDataRow("NumFactura"))
                    CriterisDetall = "ConceptesFactura.NumFactura=" + CStr(oDataRow("NumFactura"))
                ElseIf iPosicioActual <= Files - 2 Then
                    CriterisFactures = CriterisFactures + " OR Factures.NumFactura=" + CStr(oDataRow("NumFactura"))
                    CriterisDetall = CriterisDetall + " OR ConceptesFactura.NumFactura=" + CStr(oDataRow("NumFactura"))
                ElseIf iPosicioActual = Files - 1 Then
                    CriterisFactures = CriterisFactures + " OR Factures.NumFactura=" + CStr(oDataRow("NumFactura")) + " ORDER BY Factures.NumFactura;"
                    CriterisDetall = CriterisDetall + " OR ConceptesFactura.NumFactura=" + CStr(oDataRow("NumFactura")) + " ORDER BY ConceptesFactura.NumFactura;"
                Else
                    'MsgBox(CStr(Files) + "   " + CStr(iPosicioActual))
                End If
            Next
        Else
            Exit Sub
        End If

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        If Me.RbDetall.Checked = True Then

            StrInstruccioSQL = ""
            StrInstruccioSQL = "SELECT ConceptesFactura.* FROM ConceptesFactura WHERE " + CriterisDetall + ""
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "ConceptesFactura")
            oConexion.Close()

            Dim Informe As New InformeFactures()
            Informe.Subreports(0).SetDataSource(oDataSet.Tables("ConceptesFactura"))

            StrInstruccioSQL = ""
            StrInstruccioSQL = "SELECT Factures.* FROM Factures WHERE " + CriterisFactures + ""

            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Factures")
            oConexion.Close()

            Informe.SetDataSource(oDataSet.Tables("Factures"))
            ImprimirFactura.CrvFactura.ReportSource = Informe

            ImprimirFactura.Show()

        ElseIf Me.RbLlistat.Checked = True Then

            StrInstruccioSQL = ""
            StrInstruccioSQL = "SELECT ConceptesFactura.* FROM ConceptesFactura WHERE " + CriterisDetall + ""
            Dim oDataAdapterDetallFactures As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

            StrInstruccioSQL = ""
            StrInstruccioSQL = "SELECT Factures.* FROM Factures WHERE " + CriterisFactures + ""
            Dim oDataAdapterFactures As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapterDetallFactures.Fill(oDataSet, "ConceptesFactura")
            oDataAdapterFactures.Fill(oDataSet, "Factures")
            oConexion.Close()

            Dim ColumnaConcepte As DataColumn = oDataSet.Tables("ConceptesFactura").Columns.Item(0)
            Dim ColumnaFactura As DataColumn = oDataSet.Tables("Factures").Columns.Item(0)

            Dim Relacio As DataRelation
            Relacio = New DataRelation("RelacioFactura", ColumnaFactura, ColumnaConcepte)

            oDataSet.Relations.Add(Relacio)

            Dim Informe As New InformeImprimirFactures()

            Informe.SetDataSource(oDataSet)
            ImprimirFactura.CrvFactura.ReportSource = Informe

            ImprimirFactura.Show()

        Else
            MsgBox("Selecciona el tipus de llitat que vols", , "Fisiomèdic")
        End If

    End Sub
End Class