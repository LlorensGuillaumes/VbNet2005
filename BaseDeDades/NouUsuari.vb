Imports System.IO
Imports System.Text

Public Class NouUsuari
    Private strLlavor As String
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection

    Private Sub CrearUsuari(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click

        If Me.IntroNouUsuari.Text = "" Or Me.IntroNovaContrasenya.Text = "" Or Me.NomUsuari.Text = "" Or Me.DniUsuari.Text = "" Then
            MsgBox("Tots els camps són obligatoris", , "Fisiomèdic")
            Exit Sub
        End If
        'Comprovo si que el nom d'usuari no existeixi ja
        Dim Existeix As Integer = 2
        Dim UsuariCodificat As String
        Dim ContrasenyaCodificada As String
        Dim Any As String = CStr(Year(Now))

        strLlavor = Semilla()
        UsuariCodificat = Codificar(Me.IntroNouUsuari.Text, strLlavor)
        ContrasenyaCodificada = Codificar(Me.IntroNovaContrasenya.Text, strLlavor)
        
        Existeix = UsuariExsiteix(UsuariCodificat)

        If Existeix = 1 Then    'Existeix un usuari amb el mateix nom
            MsgBox("Nou usuari incorrecte", , "Fisiomèdic")
            Me.IntroNouUsuari.Undo()
            Me.IntroNouUsuari.Focus()
            Exit Sub
        ElseIf Existeix = 0 Then    'Nom d'usuari correcte, sense duplicats
            'strIdGrupUsuari ; Usuari públic --- CREAR NOU USUARI
            'Comprovar grup d'usuari    
            Dim IdGrupUsuari As String
            Dim IdGrup1 As Integer
            Dim IdGrup2 As Integer
            Dim IdGrup3 As Integer
            Dim IdGrup4 As Integer

            IdGrup1 = Me.CbAdministrador.CheckState
            IdGrup2 = Me.CbSanitari.CheckState
            IdGrup3 = Me.CbAdministratiu.CheckState
            IdGrup4 = Me.CbPrivilegis.CheckState

            IdGrupUsuari = (CStr(IdGrup1) + CStr(IdGrup2) + CStr(IdGrup3) + CStr(IdGrup4))

            oConexion = New OleDb.OleDbConnection
            StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrDadesUsuaris + "\Projecte.mdb;Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
            oConexion.ConnectionString = StrCadenaConexio

            Dim Int As Integer = 0
            StrInstruccioSQL = ""
            
            StrInstruccioSQL = "INSERT INTO Usuaris ( Usuari, Contrasenya, GrupTreball, NomUsuari, Dni, [Any], Intent )" _
                    + " SELECT """ + UsuariCodificat + """ AS Expr1, """ + ContrasenyaCodificada + """ AS Expr2, """ + IdGrupUsuari + """ AS Expr3,""" + Me.NomUsuari.Text + """ AS Expr4, """ + Me.DniUsuari.Text + """ AS Expr5, " + Any + " AS Expr6, 0 AS Expr7;"

            Me.TextBox1.Text = StrInstruccioSQL
            Dim oComando As New OleDb.OleDbCommand(StrInstruccioSQL, oConexion)

            Try
                oConexion.Open()
                oComando.ExecuteNonQuery()
                oConexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
                    'MsgBox("Petició no executada", , "Fisiomèdic")
                Exit Sub
                End Try


        Else    'Errors varis en la comprovació
                MsgBox("Error en l'alta d'usuaris" + Chr(13) + "posa't en contacte amb l'administrador", , "Fisiomèdic")
                Me.IntroNouUsuari.Undo()
                Me.IntroNouUsuari.Focus()
                Exit Sub
        End If
        Me.Close()
    End Sub
    Private Sub NouUsuari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CbAdministrador.Checked = False
        Me.CbAdministratiu.Checked = False
        Me.CbPrivilegis.Checked = False
        Me.CbSanitari.Checked = False
        Me.ControlBox = False
        Me.AcceptButton = Me.Button1
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = Me.Text + " " + StrOrigenDeDades
    End Sub
    Private Sub CbAdministrador_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbAdministrador.CheckedChanged

        If Me.CbAdministrador.Checked = True Then

            Me.CbAdministratiu.Checked = True
            Me.CbPrivilegis.Checked = True
            Me.CbSanitari.Checked = True
        Else
            Me.CbAdministratiu.Checked = False
            Me.CbPrivilegis.Checked = False
            Me.CbSanitari.Checked = False
        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub DniUsuari_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DniUsuari.Leave
        If Me.DniUsuari.Text = "" Then
            Exit Sub
        Else
            Dim Correcte As Integer = 2
            Correcte = ValidacioDni(Me.DniUsuari.Text)
            If Correcte = 0 Then
                Exit Sub
            ElseIf Correcte = 1 Then
                MsgBox("Aquest número no pertany a un NIF", , "Fisiomèdic")
                Me.DniUsuari.Text = ""
                Me.DniUsuari.Focus()
                Exit Sub
            Else
                MsgBox("Erron en la comprovació del DNI" + Chr(13) + "posa't en contacte amb l'administrador", , "Fisiomèdic")
                Me.DniUsuari.Text = ""
                Exit Sub
            End If
        End If


    End Sub
End Class