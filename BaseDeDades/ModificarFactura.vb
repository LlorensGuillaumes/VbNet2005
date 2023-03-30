Public Class ModificarFactura

    Private Sub ModificarFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarDades()
        Me.ControlBox = False
        Me.Text = Me.Text + " " + StrOrigenDeDades
    End Sub
    Private Sub CarregarDades()
        Me.Client.Text = DetallFactura.DetClient.Text
        Me.Cif.Text = DetallFactura.DetCif.Text
        Me.Adreça.Text = DetallFactura.DetAdreça.Text
        Me.CP.Text = DetallFactura.DetCP.Text
        Me.Poblacio.Text = DetallFactura.DetPoblacio.Text
        Me.Provincia.Text = DetallFactura.DetProvincia.Text
        Me.NumFactura.Text = DetallFactura.DetNumFactura.Text
        Me.DataEmisio.Text = DetallFactura.DetDataEmisio.Text
    End Sub
    Private Sub BtnSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSortir.Click

        StrInstruccioSQL = ""
        StrInstruccioSQL = "UPDATE Factures INNER JOIN ConceptesFactura ON Factures.NumFactura = ConceptesFactura.NumFactura SET" _
                    + " Factures.Client=""" + Me.Client.Text _
                    + """, Factures.Cif=""" + Me.Cif.Text _
                    + """, Factures.Adreça=""" + Me.Adreça.Text _
                    + """, Factures.CP=""" + Me.CP.Text _
                    + """, Factures.Poblacio=""" + Me.Poblacio.Text _
                    + """, Factures.Provincia=""" + Me.Provincia.Text _
                    + """, Factures.NumFactura=" + Me.NumFactura.Text _
                    + ", Factures.DataEmisio='" + Me.DataEmisio.Text _
                    + "', ConceptesFactura.NumFactura=" + Me.NumFactura.Text _
                    + " WHERE Factures.NumFactura=" + DetallFactura.DetNumFactura.Text _
                    + " AND ConceptesFactura.NumFactura=" + DetallFactura.DetNumFactura.Text + ";"
        ExecutarSql(StrInstruccioSQL)
        Me.Close()
    End Sub
    Private Sub NumFactura_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumFactura.Enter
        MsgBox("Modificar el número de factura pot crear errors de continuitat", , "Fisiomèdic")
    End Sub
    Private Sub DataEmisio_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataEmisio.Enter
        MsgBox("Modificar la data d'emisió pot donar errors fiscals", , "Fisiomèdic")
    End Sub
End Class