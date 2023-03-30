Public Class InsertarEpisodi
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection

    Private Sub InsertarEpisodi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarDades()
        Me.Text = Me.Text + " " + StrOrigenDeDades
    End Sub
    Private Sub CarregarDades()
        Me.ControlBox = False   'No es mostren els botons de maximitzar, minimitzar i tancar

        With Me.DgFactures
            'COLOR
            .RowsDefaultCellStyle.BackColor = Color.Beige
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua

            'Només lectura i no es poden afegir registres
            .ReadOnly = True
            .AllowUserToAddRows = False

            'Selector de registres no visible
            .RowHeadersVisible = False
            'Mides
            .Columns.Item(0).Width = CInt(Me.DgFactures.Width * 0.13)
            .Columns.Item(1).Width = CInt(Me.DgFactures.Width * 0.2)
            .Columns.Item(2).Width = CInt(Me.DgFactures.Width * 0.665)

            'Centrar columna 0 i 1

            .Columns.Item(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

            'Títols de columna
            .Columns.Item(0).HeaderText = "Factura"
            .Columns.Item(1).HeaderText = "Data"
            .Columns.Item(2).HeaderText = "Client"

            .Columns.Item(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns.Item(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter

            'No es poden canviar les mides de les files i columnes
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False

        End With
    End Sub
    Private Sub BtnNovaFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNovaFactura.Click
        DetallEpisodi.i = 1
        Me.Close()
    End Sub
    Private Sub DgFactures_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgFactures.CellContentDoubleClick
        Dim StrNumFactura As String

        StrNumFactura = Me.DgFactures.Rows(e.RowIndex).Cells(0).Value()

        StrInstruccioSQL = "INSERT INTO ConceptesFactura ( NumFactura, IdEpisodi, Concepte, Quantitat, Preu, Pacient, NumPolissa, NumAutoritzacio )" _
        + " SELECT " + StrNumFactura _
        + ", " + StrIdEpisodi _
        + ", """ + "SESSIONS DE FISIOTERÀPIA" _
        + """, " + DetallEpisodi.DetSesAutoritzades.Text _
        + ", " + DetallEpisodi.DetPreuSessio.Text _
        + ", """ + DetallEpisodi.Pacient.Text _
        + """, """ + DetallEpisodi.DetNumTargeta.Text _
        + """, """ + DetallEpisodi.DetNumAutoritzacio.Text + """;"

        DetallEpisodi.i = 0
        ExecutarSql(StrInstruccioSQL)
        Me.Close()
    End Sub
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
        DetallEpisodi.i = 0
    End Sub
End Class