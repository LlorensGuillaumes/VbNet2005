Public Class ImprimirReco

    Private Sub ImprimirReco_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.ControlBox = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Text = Me.Text + " " + StrOrigenDeDades
    End Sub
End Class