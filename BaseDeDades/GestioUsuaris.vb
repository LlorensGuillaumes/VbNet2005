Public Class GestioUsuaris
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection
    Private StrLlavor As String = Semilla()
    Private Sub GestioUsuaris_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Me.StartPosition = FormStartPosition.CenterParent
        With Me.Usuari
            .Text = TramitsUsuari.StrNomUsuari
            .TextAlign = HorizontalAlignment.Center
            .Enabled = False
        End With
    End Sub
    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        ModificarUsuari.ShowDialog()
        Me.Close()
    End Sub
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Dim i As Integer
        i = MsgBox("Vols eliminar l'usuari " + TramitsUsuari.StrNomUsuari + Chr(13) + "permanentment", MsgBoxStyle.YesNo, "Fisiomèdic")
        If i = vbNo Then
            Exit Sub
        Else
            oConexion = New OleDb.OleDbConnection
            StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrDadesUsuaris + "\Projecte.mdb;Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
            oConexion.ConnectionString = StrCadenaConexio

            StrInstruccioSQL = ""
            StrInstruccioSQL = "DELETE Usuaris.*, Usuaris.IdUsuari FROM Usuaris WHERE Usuaris.IdUsuari=" + TramitsUsuari.StrIdUsuari + ";"

            Dim oComando As New OleDb.OleDbCommand(StrInstruccioSQL, oConexion)
            Try
                oConexion.Open()
                oComando.ExecuteNonQuery()
                oConexion.Close()
            Catch ex As Exception
                MsgBox("Petició no executada", , "Fisiomèdic")
                Exit Sub
            End Try
        End If
        Me.Close()
    End Sub
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
    Private Sub BtnDesbloquejar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDesbloquejar.Click
        Dim IntroContrasenya As String
        IntroContrasenya = InputBox("Introdueix la contrasenya per a l'usuari " + Me.Usuari.Text, "Fisiomèdic")

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrDadesUsuaris + "\Projecte.mdb;Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = ""
        StrInstruccioSQL = "UPDATE Usuaris " _
            + " SET Usuaris.Contrasenya= """ + Codificar(IntroContrasenya, StrLlavor) _
            + """ WHERE usuaris.IdUsuari= " + TramitsUsuari.StrIdUsuari + ";"

        Dim oComando As New OleDb.OleDbCommand(StrInstruccioSQL, oConexion)
        Try
            oConexion.Open()
            oComando.ExecuteNonQuery()
            oConexion.Close()
        Catch ex As Exception
            MsgBox("Petició no executada", , "Fisiomèdic")
            Exit Sub
        End Try
    End Sub
End Class