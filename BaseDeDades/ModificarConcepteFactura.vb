Public Class ModificarConcepteFactura
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection
    Private Sub ModificarConcepteFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ControlBox = False
        Me.AcceptButton = Me.BtnOk
        Me.Text = Me.Text + " " + StrOrigenDeDades

        StrInstruccioSQL = ""
        StrCadenaConexio = ""

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = "SELECT ConceptesFactura.* FROM ConceptesFactura WHERE ConceptesFactura.IdEpisodi=""" + DetallFactura.StrIdEpisodiFactura + """;"

        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
        oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)

        oDataSet = Nothing
        oDataSet = New DataSet()

        Try
            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "ConceptesFactura")
            oConexion.Close()

            Dim iPosicionActual As Integer
            iPosicionActual = 0
            Dim oDataRow As DataRow
            oDataRow = oDataSet.Tables("ConceptesFactura").Rows(iPosicionActual)

            If VarType(oDataRow("NumFactura")) <> VariantType.Null Then
                Me.NumFactura.Text = Format(oDataRow("NumFactura"), "00000")
            Else
                Me.NumFactura.Text = ""
            End If

            If VarType(oDataRow("Pacient")) <> VariantType.Null Then
                Me.Pacient.Text = oDataRow("Pacient")
            Else
                Me.Pacient.Text = ""
            End If

            If VarType(oDataRow("NumPolissa")) <> VariantType.Null Then
                Me.Polissa.Text = oDataRow("NumPolissa")
            Else
                Me.Polissa.Text = ""
            End If

            If VarType(oDataRow("NumAutoritzacio")) <> VariantType.Null Then
                Me.Autoritzacio.Text = oDataRow("NumAutoritzacio")
            Else
                Me.Autoritzacio.Text = ""
            End If

            If VarType(oDataRow("Concepte")) <> VariantType.Null Then
                Me.Concepte.Text = oDataRow("Concepte")
            Else
                Me.Concepte.Text = ""
            End If

            If VarType(oDataRow("Quantitat")) <> VariantType.Null Then
                Me.Sessions.Text = oDataRow("Quantitat")
            Else
                Me.Sessions.Text = ""
            End If

            If VarType(oDataRow("Preu")) <> VariantType.Null Then
                Me.PreuSessio.Text = Format(oDataRow("Preu"), "currency")
            Else
                Me.PreuSessio.Text = ""
            End If

            If VarType(oDataRow("Retencio")) <> VariantType.Null Then
                Me.RetIRPF.Text = oDataRow("Retencio")
            Else
                Me.RetIRPF.Text = ""
            End If

            If VarType(oDataRow("RetencioImport")) <> VariantType.Null Then
                Me.ImpIRPF.Text = Format(oDataRow("RetencioImport"), "currency")
            Else
                Me.ImpIRPF.Text = ""
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
    Private Sub NumFactura_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumFactura.Enter
        MsgBox("Modificar el número de factura, significa canviar l'episodi de factura", , "Fisiomèdic")
    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click

        StrInstruccioSQL = ""
        StrInstruccioSQL = "UPDATE ConceptesFactura SET" _
        + " ConceptesFactura.Pacient=""" + Me.Pacient.Text _
        + """, ConceptesFactura.NumFactura=" + Me.NumFactura.Text _
        + ", ConceptesFactura.NumPolissa=""" + Me.Polissa.Text _
        + """, ConceptesFactura.NumAutoritzacio=""" + Me.Autoritzacio.Text _
        + """, ConceptesFactura.Concepte=""" + Me.Concepte.Text _
        + """, ConceptesFactura.Quantitat= """ + Me.Sessions.Text _
        + """, ConceptesFactura.Preu=""" + Me.PreuSessio.Text _
        + """, ConceptesFactura.Retencio=""" + Me.RetIRPF.Text _
        + """, ConceptesFactura.RetencioImport=""" + Me.ImpIRPF.Text _
        + """ WHERE ConceptesFactura.IdEpisodi=""" + DetallFactura.StrIdEpisodiFactura + """;"

        ExecutarSql(StrInstruccioSQL)

        Me.Close()
    End Sub
    Private Sub CampModenda_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreuSessio.Leave
        Me.PreuSessio.Text = Me.PreuSessio.Text.Replace(".", ",")
    End Sub
    Private Sub ImpIRPF_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImpIRPF.Leave
        Me.ImpIRPF.Text = Me.ImpIRPF.Text.Replace(".", ",")
    End Sub
End Class