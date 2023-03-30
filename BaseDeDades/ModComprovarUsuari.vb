Module ModComprovarUsuari
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection
    Private StrLlavor As String

    Public Function ComprovarUsuari(ByVal StrUsuariIntro As String, ByVal StrContrasenyaIntro As String)

        Dim UsuariCodificat As String
        Dim ContrasenyaCodificat As String

        StrLlavor = Semilla()
        UsuariCodificat = Codificar(StrUsuariIntro, StrLlavor)
        ContrasenyaCodificat = Codificar(StrContrasenyaIntro, StrLlavor)

        oConexion = New OleDb.OleDbConnection
        oDataSet = Nothing
        oDataSet = New DataSet()

        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrDadesUsuaris + "\Projecte.mdb;Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = "SELECT Usuaris.Usuari, Usuaris.Contrasenya, Usuaris.GrupTreball, Usuaris.IdUsuari FROM Usuaris;"
        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)

        Try
            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Usuaris")
            oConexion.Close()

            Dim Files As Integer
            Files = CInt(oDataSet.Tables("Usuaris").Rows.Count)
            If Files = 0 Then
                Return 2
            Else
                Dim iPosicioActual As Integer = 0
                Dim Usuari As String
                Dim Contrasenya As String
                Dim oDataRow As DataRow

                For iPosicioActual = 0 To Files - 1
                    oDataRow = oDataSet.Tables("Usuaris").Rows(iPosicioActual)
                    Usuari = oDataRow("Usuari")
                    Contrasenya = oDataRow("Contrasenya")
                    If Trim(Usuari) = Trim(UsuariCodificat) Then
                        If Contrasenya = "" Then
                            Return 3
                        End If
                        If Trim(Contrasenya) = Trim(ContrasenyaCodificat) Then
                            strIdGrupUsuari = Trim(oDataRow("GrupTreball"))
                            StrIdUsusuari = Trim(oDataRow("IdUsuari"))
                            Return 0
                        Else
                            Autentificacio.Registre = oDataRow("IdUsuari")
                            Return 1
                        End If
                    Else
                        'Segueix buscant, si és l'última fila, llavors retornarà 1
                    End If
                Next (iPosicioActual)
                Autentificacio.Registre = 0
                Return 1
            End If
            Return 2
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 2

        End Try
    End Function

End Module
