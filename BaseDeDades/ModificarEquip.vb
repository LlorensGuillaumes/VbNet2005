Public Class ModificarEquip

    Private Sub ModificarEquip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Me.AcceptButton = Me.BtnOK
        Me.Text = Me.Text + " " + StrOrigenDeDades

        CarregarDades()
    End Sub
    Private Sub CarregarDades()
        Me.Club.Text = Equips.Club.Text
        Me.Equip.Text = Equips.StrEquip

    End Sub
    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        StrInstruccioSQL = ""
        StrInstruccioSQL = "UPDATE Equips SET Equips.Equip = """ + Me.Equip.Text + """ WHERE Equips.Club = """ + Me.Club.Text + """;"

        ExecutarSql(StrInstruccioSQL)

        Me.Close()

    End Sub
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()

    End Sub
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        StrInstruccioSQL = ""
        StrInstruccioSQL = "DELETE Equips.Club, Equips.Equip FROM Equips WHERE Equips.Club = """ + Me.Club.Text + """ AND Equips.Equip=""" + Me.Equip.Text + """;"
        ExecutarSql(StrInstruccioSQL)

        Me.Close()
    End Sub
End Class