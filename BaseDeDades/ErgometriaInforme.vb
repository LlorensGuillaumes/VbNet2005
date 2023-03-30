Public Class ErgometriaInforme

    Private Sub BtnSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSortir.Click

        StrInstruccioSQL = ""
        StrInstruccioSQL = "UPDATE ErgoInforme SET ErgoInforme.ErgoInforme=""" + Me.ErgoInforme.Text _
                + """ WHERE ErgoInforme.IdReco = " + StrIdEpisodi + ";"

        ExecutarSql(StrInstruccioSQL)
        Me.Close()
    End Sub
    Private Sub ErgometriaInforme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = Me.Text + " " + StrOrigenDeDades
    End Sub
End Class