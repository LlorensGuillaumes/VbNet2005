Public Class DetallInforme
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection

    Private Sub DetallInforme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        StrInstruccioSQL = ""
        StrCadenaConexio = ""

        Me.StartPosition = FormStartPosition.CenterParent
        Me.WindowState = FormWindowState.Maximized
        Me.ControlBox = False
        Me.Text = "DETALL INFORME" + " " + StrOrigenDeDades

        'AGAFO LES DADES DEL PACIENT I COLOCO EL SEU NOM AL PRINCIPI DEL FORMULARI

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = "SELECT Informes.IdInforme, Informes.IdPacient, Informes.Titol, Informes.Diagnostic, Informes.Informe, Informes.Data, Informes.NumColegiat, Terapeutes.Terapeuta" _
            + " FROM Informes INNER JOIN Terapeutes ON Informes.NumColegiat=Terapeutes.NumColegiat" _
            + " WHERE Informes.IdInforme =" + StrIdInforme + ";"

        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
        oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
        oDataSet = Nothing
        oDataSet = New DataSet()

        Try
            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Informes")
            oConexion.Close()

            Dim iPosicionActual As Integer
            iPosicionActual = 0
            Dim oDataRow As DataRow
            oDataRow = oDataSet.Tables("Informes").Rows(iPosicionActual)

            If VarType(oDataRow("Titol")) <> VariantType.Null Then
                Me.DetTitolInforme.Text = oDataRow("Titol")
            Else
            End If

            If VarType(oDataRow("Diagnostic")) <> VariantType.Null Then
                Me.DetDiagnostic.Text = oDataRow("Diagnostic")
            Else
            End If

            If VarType(oDataRow("Informe")) <> VariantType.Null Then
                Me.DetInforme.Text = oDataRow("Informe")
            Else
            End If

            If VarType(oDataRow("Data")) <> VariantType.Null Then
                Me.DetData.Text = oDataRow("Data")

                Me.DetData.Text = CalcularData(CDate(oDataRow("Data")))

            Else
            End If

            If VarType(oDataRow("Terapeuta")) <> VariantType.Null Then
                Me.DetTerapeuta.Text = oDataRow("Terapeuta")
            Else
            End If

            If VarType(oDataRow("NumColegiat")) <> VariantType.Null Then
                Me.DetNumColegiat.Text = oDataRow("NumColegiat")
            Else
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'CARREGO LES DADES DEL PACIENT

        StrInstruccioSQL = ""
        StrCadenaConexio = ""

        Dim StrNom As String
        Dim StrPacient As String
        Dim StrDni As String

        StrNom = "DadesPacient.Nom & " + """ """ + "& DadesPacient.PrimerCognom &" + """ """ + "& DadesPacient.SegonCognom"

        StrInstruccioSQL = "SELECT DadesPacient.IdPacient, DadesPacient.Dni," + StrNom + " AS Pacient" _
           + " FROM DadesPacient" _
           + " WHERE DadesPacient.IdPacient=" + StrIdPacient + ";"

        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
        oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
        oDataSet = Nothing
        oDataSet = New DataSet()

        Try
            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "DadesPacient")
            oConexion.Close()

            Dim iPosicionActual As Integer
            iPosicionActual = 0
            Dim oDataRow As DataRow
            oDataRow = oDataSet.Tables("DadesPacient").Rows(iPosicionActual)

            If VarType(oDataRow("Pacient")) <> VariantType.Null Then
                StrPacient = oDataRow("Pacient")
            Else
                StrPacient = ""
            End If

            If VarType(oDataRow("Dni")) <> VariantType.Null Then
                StrDni = oDataRow("Dni")
            Else
                StrDni = ""
            End If

            Me.DetPacient.Text = StrDni + " " + StrPacient


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSortir.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = ""
        'StrInstruccioSQL = "SELECT Informes.* FROM Informes WHERE Informes.IdInforme=" + StrIdInforme + ";"
        StrInstruccioSQL = "SELECT Informes.*, Informes.IdInforme, Terapeutes.* FROM Informes INNER JOIN Terapeutes" _
        + " ON Informes.NumColegiat = Terapeutes.NumColegiat WHERE Informes.IdInforme=" + StrIdInforme + ";"

        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
        oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
        oDataSet = Nothing
        oDataSet = New DataSet()

        oConexion.Open()
        oDataAdapter.Fill(oDataSet, "Informes")
        oConexion.Close()

        Dim Informe As New InformeCapçalera()

        'Informe.Subreports(0).DataSourceConnections.Item(0).SetConnection(StrOrigenDeDades, "FisiomedicOd", "", "F1$10m3b1(")
        Informe.Subreports(0).SetDataSource(oDataSet.Tables("Informes"))

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT DadesPacient.Nom, DadesPacient.PrimerCognom, DadesPacient.SegonCognom, Informes.Data, Informes.NumColegiat, Terapeutes.Terapeuta, Informes.Diagnostic, DadesPacient.Dni" _
                + " FROM DadesPacient INNER JOIN (Informes INNER JOIN Terapeutes ON Informes.NumColegiat = Terapeutes.NumColegiat) ON DadesPacient.IdPacient = Informes.IdPacient" _
                + " WHERE DadesPacient.IdPacient=" + StrIdPacient + "AND Informes.IdInforme=" + StrIdInforme + ";"

        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
        oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
        oDataSet = Nothing
        oDataSet = New DataSet()

        oConexion.Open()
        oDataAdapter.Fill(oDataSet, "DadesPacient")
        oConexion.Close()

        Informe.SetDataSource(oDataSet.Tables("DadesPacient"))
        'Dim odatosInforme As SummaryInfo = Informe.SummaryInfo
        'odatosInforme.ReportTitle = "Factura"
        ImprimirInforme.CrvInforme.ReportSource = Informe
        Dim Formulari As New ImprimirInforme
        ImprimirInforme.Show()
    End Sub
End Class