Imports System.Windows.Forms

Public Class ModificarAssistencia
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        StrInstruccioSQL = "UPDATE Assistencia SET Assistencia.Data = '" + Me.ModData.Text _
            + "' WHERE Assistencia.IdAssistencia=" + StrIdAssistencia + ";"
        ExecutarSql(StrInstruccioSQL)
        DetallEpisodi.DetEpisodiCarregarDades()
        Me.Close()
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = Me.Text + " " + StrOrigenDeDades
        StrInstruccioSQL = "SELECT Assistencia.* FROM Assistencia WHERE Assistencia.IdAssistencia =" + StrIdAssistencia + ";"

        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        Try
            oConexion = New OleDb.OleDbConnection
            oConexion.ConnectionString = StrCadenaConexio
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Assistencia")
            oConexion.Close()

            Dim iPosicionActual As Integer
            iPosicionActual = 0
            Dim oDataRow As DataRow
            oDataRow = oDataSet.Tables("Assistencia").Rows(iPosicionActual)

            If VarType(oDataRow("Data")) <> VariantType.Null Then
                Me.ModData.Text = oDataRow("Data")
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
