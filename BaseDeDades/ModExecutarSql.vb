Module ModExecutarSql

    Public Function ExecutarSql(ByVal StrInstruccioSQL As String)

        Dim oConexion As New OleDb.OleDbConnection
        oConexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("

        Dim oComando As New OleDb.OleDbCommand(StrInstruccioSQL, oConexion)
        Try
            oConexion.Open()
            oComando.ExecuteNonQuery()
            oConexion.Close()
            Return 0
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 1
        End Try
    End Function

End Module
