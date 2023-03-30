Public Class Terapeutes
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection
    Private Sub Terapeutes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        CarregarDades()
    End Sub
    Private Sub CarregarDades()
        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = "SELECT Terapeutes.*FROM Terapeutes;"

        Try
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Terapeutes")
            oConexion.Close()

            Me.DgTerapeutes.DataSource = oDataSet
            Me.DgTerapeutes.DataMember = "Terapeutes"

            ConfigurarDgTerapeutes()

            With Me.CbTerapeuta
                .DataSource = oDataSet.Tables("Terapeutes")
                .DisplayMember = "Terapeuta"
                .ValueMember = "Terapeuta"

                .AutoCompleteSource = AutoCompleteSource.ListItems
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            End With

            Me.PanGestio.Visible = False
            Me.PanOpcions.Visible = True
            Me.RbNou.Checked = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ConfigurarDgTerapeutes()
        With Me.DgTerapeutes

            .RowsDefaultCellStyle.BackColor = Color.Beige
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .ReadOnly = True

            'CONFIGURACIÓ DE COLUMNES
            .Columns.Item(0).HeaderText = "Nom"
            .Columns.Item(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns(0).Width = CInt(Me.DgTerapeutes.Width * 0.75)

            .Columns.Item(1).HeaderText = "Núm. col·legiat"
            .Columns.Item(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            .Columns(1).Width = CInt(Me.DgTerapeutes.Width * 0.24)
        End With
    End Sub
    Private TerapeutaActual As String = ""
    Private Sub CbTerapeuta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbTerapeuta.SelectedIndexChanged

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = "SELECT Terapeutes.* FROM Terapeutes WHERE Terapeutes.Terapeuta=""" + Me.CbTerapeuta.Text + """;"

        Try
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Terapeutes")
            oConexion.Close()

            Dim oDataRow As DataRow
            Dim iPosicioActual As Integer = 0

            If oDataSet.Tables("Terapeutes").Rows.Count > 0 Then
                oDataRow = oDataSet.Tables("Terapeutes").Rows(iPosicioActual)
                TerapeutaActual = Me.CbTerapeuta.Text

                If VarType(oDataRow("NumColegiat")) <> VariantType.Null Then
                    Me.TbColegiat.Text = oDataRow("NumColegiat")
                Else
                    Me.TbColegiat.Text = ""
                End If
            Else
                Me.TbColegiat.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        Me.PanOpcions.Visible = False
        Me.PanGestio.Visible = True
        Me.BtnSortir.Visible = False

        If Me.RbNou.Checked = True Then
            Me.CbTerapeuta.Visible = False
            Me.TbTerapeuta.Visible = True

            Me.TbTerapeuta.TabIndex = 0
            Me.TbColegiat.TabIndex = 1
            Me.TbTerapeuta.Focus()

            Me.TbTerapeuta.Text = ""
            Me.TbColegiat.Text = ""

        Else
            Me.CbTerapeuta.Visible = True
            Me.TbTerapeuta.Visible = False

            Me.CbTerapeuta.TabIndex = 0
            Me.TbColegiat.TabIndex = 1
            Me.CbTerapeuta.Focus()
        End If
    End Sub
    Private Sub BtnOkGestio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOkGestio.Click

        Dim i As Integer
        Try
            If Me.RbNou.Checked = True Then
                If Me.TbTerapeuta.Text = "" Then
                    Exit Try
                End If
                StrInstruccioSQL = ""
                StrInstruccioSQL = "INSERT INTO Terapeutes ( Terapeuta, NumColegiat )" _
                    + " SELECT """ + Me.TbTerapeuta.Text _
                    + """, """ + Me.TbColegiat.Text + """;"

                ExecutarSql(StrInstruccioSQL)

            ElseIf Me.RbModificar.Checked = True Then
                i = MsgBox("Guardar canvis", MsgBoxStyle.YesNo, "Fisiomèdic")
                If i = vbYes Then
                    StrInstruccioSQL = ""
                    StrInstruccioSQL = "UPDATE Terapeutes SET" _
                            + " Terapeutes.Terapeuta = """ + Me.CbTerapeuta.Text _
                            + """, Terapeutes.NumColegiat=""" + Me.TbColegiat.Text _
                            + """ WHERE Terapeutes.Terapeuta=""" + Me.TerapeutaActual + """;"
                    ExecutarSql(StrInstruccioSQL)
                Else
                    Exit Try
                End If

                ElseIf Me.RbEliminar.Checked = True Then
                i = MsgBox("Vols eliminar el terapeuta " + Me.TbTerapeuta.Text, MsgBoxStyle.YesNo, "Fisiomèdic")
                    If i = vbYes Then
                        StrInstruccioSQL = ""
                        StrInstruccioSQL = "DELETE Terapeutes.* FROM Terapeutes WHERE Terapeutes.Terapeuta=""" + Me.TbTerapeuta.Text + """;"
                        ExecutarSql(StrInstruccioSQL)
                    Else
                        Exit Try
                End If

                Else
                    MsgBox("Error en la selecció de gestió", , "Fisiomèdic")
                End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.BtnSortir.Visible = True
        CarregarDades()
    End Sub
    Private Sub BtnSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSortir.Click
        Me.Close()
    End Sub
End Class