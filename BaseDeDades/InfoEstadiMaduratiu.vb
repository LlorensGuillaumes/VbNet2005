Public Class InfoEstadiMaduratiu

    Private Sub InfoEstadiMaduratiu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = Me.Text + " " + StrOrigenDeDades
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.Close()
    End Sub
End Class