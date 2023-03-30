Public Class ModificarUsuari
    Private strLlavor As String
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        If Me.IntroNouUsuari.Text = "" Or Me.IntroNovaContrasenya.Text = "" Or Me.NomUsuari.Text = "" Or Me.DniUsuari.Text = "" Then
            MsgBox("Tots els camps són obligatoris", , "Fisiomèdic")
            Exit Sub
        End If
        'Comprovo si que el nom d'usuari no existeixi ja
        Dim UsuariCodificat As String
        Dim ContrasenyaCodificada As String

        strLlavor = Semilla()
        UsuariCodificat = Codificar(Me.IntroNouUsuari.Text, strLlavor)
        ContrasenyaCodificada = Codificar(Me.IntroNovaContrasenya.Text, strLlavor)

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

        StrInstruccioSQL = ""
        StrInstruccioSQL = "UPDATE Usuaris " _
            + " SET Usuaris.Usuari= """ + UsuariCodificat _
            + """, Usuaris.Contrasenya= """ + ContrasenyaCodificada _
            + """, Usuaris.GrupTreball= """ + IdGrupUsuari _
            + """, Usuaris.NomUsuari= """ + Me.NomUsuari.Text _
            + """, Usuaris.Dni= """ + Me.DniUsuari.Text _
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
        Me.Close()
    End Sub
    Private Sub ModificarUsuari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Me.AcceptButton = Me.Button1
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = Me.Text + " " + StrOrigenDeDades

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrDadesUsuaris + "\Projecte.mdb;Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = "SELECT Usuaris.* FROM Usuaris WHERE Usuaris.IdUsuari=" + TramitsUsuari.StrIdUsuari + ";"

        Try
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Usuaris")
            oConexion.Close()

            Dim Files As Integer = oDataSet.Tables("Usuaris").Rows.Count
            If Files = 0 Then
                MsgBox("Error en la localització de les dades d'usuari" + Chr(13) + "posa't en contacte amb l'administrador", , "Fisiomèdic")
                Exit Sub

            Else
                Dim iPosicionActual As Integer = 0
                Dim oDataRow As DataRow
                oDataRow = oDataSet.Tables("Usuaris").Rows(iPosicionActual)

                If VarType(oDataRow("NomUsuari")) <> VariantType.Null Then
                    Me.NomUsuari.Text = oDataRow("NomUsuari")
                Else
                    Me.NomUsuari.Text = ""
                End If
                If VarType(oDataRow("Dni")) <> VariantType.Null Then
                    Me.DniUsuari.Text = oDataRow("Dni")
                Else
                    Me.DniUsuari.Text = ""
                End If
                If VarType(oDataRow("Usuari")) <> VariantType.Null Then
                    strLlavor = Semilla()
                    Me.IntroNouUsuari.Text = DeCodificar(oDataRow("Usuari"), strLlavor)
                Else
                    Me.IntroNouUsuari.Text = ""
                End If
                If VarType(oDataRow("Contrasenya")) <> VariantType.Null Then
                    strLlavor = Semilla()
                    Me.IntroNovaContrasenya.Text = DeCodificar(oDataRow("Contrasenya"), strLlavor)
                Else
                    Me.IntroNovaContrasenya.Text = ""
                End If
                If VarType(oDataRow("GrupTreball")) <> VariantType.Null Then
                    Dim StrGrupUsuari As String = oDataRow("GrupTreball")

                    Dim IdGrup1 As Integer
                    Dim IdGrup2 As Integer
                    Dim IdGrup3 As Integer
                    Dim IdGrup4 As Integer

                    IdGrup1 = Mid(StrGrupUsuari, 1, 1)
                    IdGrup2 = Mid(StrGrupUsuari, 2, 1)
                    IdGrup3 = Mid(StrGrupUsuari, 3, 1)
                    IdGrup4 = Mid(StrGrupUsuari, 4, 1)

                    If IdGrup1 = 1 Then
                        Me.CbAdministrador.Checked = True
                    Else
                        Me.CbAdministrador.Checked = False
                    End If

                    If IdGrup2 = 1 Then
                        Me.CbSanitari.Checked = True
                    Else
                        Me.CbSanitari.Checked = False
                    End If

                    If IdGrup3 = 1 Then
                        Me.CbAdministratiu.Checked = True
                    Else
                        Me.CbAdministratiu.Checked = False
                    End If

                    If IdGrup4 = 1 Then
                        Me.CbPrivilegis.Checked = True
                    Else
                        Me.CbPrivilegis.Checked = False
                    End If
                Else

                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class