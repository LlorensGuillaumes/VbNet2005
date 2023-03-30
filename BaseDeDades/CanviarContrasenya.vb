Public Class CanviarContrasenya
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection
    Private StrLlavor As String = Semilla()

    Private Sub CanviarContrasenya_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Me.Usuari.Text = StrUsuari
        Me.AcceptButton = Me.BtnOK

        Me.ContrasenyaVella.Text = ""
        Me.ContrasenyaNova1.Text = ""
        Me.ContrasenyaNova2.Text = ""
    End Sub
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click

        If Me.ContrasenyaNova1.Text = "" Or Me.ContrasenyaNova2.Text = "" Then
            MsgBox("La contrasenya és un camp obligatòri", , "Fisiomèdic")
            Exit Sub
        End If
        If Me.ContrasenyaNova1.Text <> Me.ContrasenyaNova2.Text Then
            MsgBox("Error en la confirmació de la contrasenya", , "Fisomèdic")
            Exit Sub
        End If

        Dim Existeix As Integer = 2
        Existeix = ComprovarUsuari(Me.Usuari.Text, Me.ContrasenyaVella.Text)
        If Existeix = 1 Then
            MsgBox("Contrasenya incorrecte", , "Fisiomèdic")
        ElseIf Existeix = 0 Then

            oConexion = New OleDb.OleDbConnection
            StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrDadesUsuaris + "\Projecte.mdb;Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
            oConexion.ConnectionString = StrCadenaConexio

            StrInstruccioSQL = ""
            StrInstruccioSQL = "UPDATE Usuaris" _
                + " SET Usuaris.Contrasenya= """ + Codificar(Me.ContrasenyaNova1.Text, StrLlavor) _
                + """, Usuaris.Any= " + CStr(Year(Now)) _
                + ", Usuaris.Intent= 0" _
                + " WHERE usuaris.IdUsuari= " + StrIdUsusuari + ";"

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
End Class