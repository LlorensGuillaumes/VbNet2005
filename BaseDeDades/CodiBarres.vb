Public Class CodiBarres
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection

    Private Sub CodiBarres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Me.Text = "CODI DE BARRES " + StrOrigenDeDades
        Me.AcceptButton = Me.BtnOk
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
    Private Sub CodiBarres_Activate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.TbId.Text = ""
        Me.TbId.Focus()
    End Sub
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        If Me.TbId.Text = "" Then
            Me.Close()
            Exit Sub
        End If
        Try
            StrIdPacient = Me.TbId.Text
            Episodis.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Close()
    End Sub
End Class