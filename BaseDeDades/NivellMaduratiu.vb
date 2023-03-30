Public Class NivellMaduratiu

    Private Sub RbMasculi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbMasculi.CheckedChanged, RbFemeni.CheckedChanged

        If Me.RbMasculi.Checked = True Then

            With Me.EtX
                .Text = "Desarrollament genital estadiu 3 o superior:"
                .TextAlign = ContentAlignment.BottomLeft
            End With

            With Me.EtY
                .Text = "Veu adulta:"
                .TextAlign = ContentAlignment.BottomLeft
            End With

        ElseIf Me.RbFemeni.Checked = True Then

            With Me.EtX
                .Text = "Desarrollament mamari estadiu 2 o superior:"
                .TextAlign = ContentAlignment.BottomLeft
            End With

            With Me.EtY
                .Text = "Menàrquia"
                .TextAlign = ContentAlignment.BottomLeft
            End With
        End If

    End Sub
    Private Sub NivellMaduratiu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = Me.Text + " " + StrOrigenDeDades
    End Sub
    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click

        If Me.RbXSi.Checked = True And Me.RbYSi.Checked = True Then 'Des. si , menar. si
            ReconeixementMedic.DetNivellMaduratiu.Text = "POST-PUBERAL"
        ElseIf Me.RbXSi.Checked = True And Me.RbYSi.Checked = False Then 'Si, No
            ReconeixementMedic.DetNivellMaduratiu.Text = "PUBERAL"
        ElseIf Me.RbXSi.Checked = False And Me.RbYSi.Checked = True Then    'No, Si
            MsgBox("Error")
        ElseIf Me.RbXSi.Checked = False And Me.RbYSi.Checked = False Then   'No, No
            ReconeixementMedic.DetNivellMaduratiu.Text = "PRE-PUBERAL"
        Else
            MsgBox("error")
        End If
        Me.Close()

    End Sub
    Private Sub RbXNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbXNo.CheckedChanged
        If Me.RbXNo.Checked = True Then
            Me.RbYNo.Checked = True
            Me.RbYSi.Enabled = False
        End If
    End Sub
    Private Sub RbXSi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbXSi.CheckedChanged
        Me.RbYSi.Enabled = True
    End Sub
    Private Sub BtnInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInfo.Click
        InfoEstadiMaduratiu.ShowDialog()
    End Sub
End Class