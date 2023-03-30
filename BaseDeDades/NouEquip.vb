Public Class NouEquip
    Private Sub NouEquip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Club.Text = Equips.Club.Text
        Me.Text = "INTRODUIR NOU EQUIP" + " " + StrOrigenDeDades
    End Sub
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        StrInstruccioSQL = ""
        StrInstruccioSQL = "INSERT INTO Equips ( Club, Equip )" _
                + " SELECT """ + Me.Club.Text _
                + """, """ + Me.Equip.Text + """;"
        ExecutarSql(StrInstruccioSQL)
        Equips.CarregarDades()
        Me.Close()
    End Sub
End Class