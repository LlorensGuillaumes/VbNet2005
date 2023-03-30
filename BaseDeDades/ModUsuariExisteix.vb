Imports System.IO
Imports System.Text
Module ModUsuariExisteix
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection
    Private StrLlavor As String

    Public Function UsuariExsiteix(ByVal NouUsuari As String)

        oConexion = New OleDb.OleDbConnection
        oDataSet = Nothing
        oDataSet = New DataSet()

        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrDadesUsuaris + "\Projecte.mdb;Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = "SELECT Usuaris.Usuari FROM Usuaris WHERE Usuaris.Usuari = """ + NouUsuari + """;"
        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)

        Try
            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Usuaris")
            oConexion.Close()

            If oDataSet.Tables("Usuaris").Rows.Count = 0 Then
                Return 0
            ElseIf oDataSet.Tables("Usuaris").Rows.Count = 1 Then
                Return 1
            Else
                Return 2
            End If
        Catch ex As Exception
            Return 2
            MsgBox(ex.Message)
        End Try
    End Function

End Module
