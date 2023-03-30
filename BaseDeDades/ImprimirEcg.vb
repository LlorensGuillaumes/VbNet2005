Imports System.IO
Imports System.Text

Public Class ImprimirEcg
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection

    Private Sub ImprimirEcg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarDades()
        Me.WindowState = FormWindowState.Maximized
        Me.Text = Me.Text + " " + StrOrigenDeDades

    End Sub
    Private Sub CarregarDades()

        StrCadenaConexio = ""

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        Try

            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)

            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "EcgRepos")
            oConexion.Close()

            If Me.DgEcg.Columns.Count > 0 Then
                Dim Posicio As Integer = 0
                For Posicio = 0 To Me.DgEcg.Columns.Count - 1
                    Me.DgEcg.Columns.RemoveAt(0)
                Next Posicio

            End If

            'Me.DgEcg.DataSource = Nothing
            'Me.DgEcg.DataMember = Nothing

            Me.DgEcg.DataSource = oDataSet
            Me.DgEcg.DataMember = "EcgRepos"

            'If Int(Me.DgEcg.Columns.Count) = 1 Then

            Dim Columna As New System.Windows.Forms.DataGridViewCheckBoxColumn
            Columna.Name = "ColImprimir"
            Me.DgEcg.Columns.Add(Columna)

            'Else
            'End If


            With Me.DgEcg

                'COLOR
                .RowsDefaultCellStyle.BackColor = Color.Beige
                .BackgroundColor = Color.Beige

                'COLUMNES NO VISIBLES
                .RowHeadersVisible = False 'Columna cursor lateral Selector de registre

                .AllowUserToAddRows = False 'No es poden afegir registres
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False

                'SOLO LECTURA
                .Columns.Item(0).ReadOnly = True

                'CONFIGURACIÓ DE COLUMNES
                .Columns.Item(0).HeaderText = "ECG"    'Títol de columna
                .Columns.Item(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter    'Alineació d'encapçalament columna
                .Columns(0).Width = CInt(Me.DgEcg.Width * 0.57) 'Mides
                .Columns.Item(1).HeaderText = "Imprimir"
                .Columns.Item(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
                .Columns(1).Width = CInt(Me.DgEcg.Width * 0.35)

            End With


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DgEcg_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgEcg.CellClick
        'Mostra l'Ecg referent al registre seleccionat
        Me.Ecg.Invalidate()

        Dim CarpetaMare As DirectoryInfo = Directory.GetParent(StrOrigenDeDades)
        Dim RegistreEcg As String = Me.DgEcg.Rows(e.RowIndex).Cells(0).Value()
        
        Dim RutaEcg As String = CarpetaMare.FullName + "\ECG\" + RegistreEcg + ".jpg"

        If File.Exists(RutaEcg) = True Then
            Me.Ecg.Image = New Bitmap(RutaEcg)

        Else
            MsgBox("Error en la localització de l'ECG" + Chr(13) + "Comprova que s'hagi introduit correctament el nom de l'arxiu", MsgBoxStyle.OkOnly, "Fisiomèdic")
            Me.Ecg.Image = Nothing
        End If
    End Sub
    Friend Imatge As Bitmap
    Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimir.Click
        Dim Impresora As PrintDialog = New PrintDialog
        Dim NomImpresora As String = ""
        Dim Copies As Integer = 1

        With Impresora
            .AllowCurrentPage = False
            .AllowPrintToFile = False
            .AllowSelection = False
            .AllowSomePages = False
            .PrintToFile = False
            .ShowHelp = False
            .ShowNetwork = False
        End With

        If (Impresora.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            NomImpresora = Impresora.PrinterSettings.PrinterName
            Copies = Impresora.PrinterSettings.Copies
        Else
            Exit Sub
        End If

        With Me.PrintDocument1
            .PrinterSettings.PrinterName = NomImpresora
            .DefaultPageSettings.Landscape = True
        End With
        Dim Registres As Integer = Me.DgEcg.Rows.Count 'Número de registre d'Ecg
        Dim imprimir As Boolean
        Dim RegistreActual As Integer = 0
        Dim ValorEcg As String
        Dim RutaEcg As String = ""
        Dim CarpetaMare As DirectoryInfo = Directory.GetParent(StrOrigenDeDades)

        If Registres > 0 Then
            For RegistreActual = 0 To (Registres - 1)
                imprimir = Me.DgEcg.Rows(RegistreActual).Cells("ColImprimir").Value
                If imprimir = True Then
                    ValorEcg = Me.DgEcg.Rows(RegistreActual).Cells(0).Value
                    'RutaEcg = "C:\OrigenDades\ECG\20100506103242.jpg"
                    RutaEcg = CarpetaMare.FullName + "\ECG\" + ValorEcg + ".jpg"
                    Imatge = New Bitmap(RutaEcg)
                    Me.PrintDocument1.Print()
                Else
                End If
            Next
        Else
        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(Imatge, 0, 0)
    End Sub
End Class