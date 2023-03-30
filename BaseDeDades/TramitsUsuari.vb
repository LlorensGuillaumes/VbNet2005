Public Class TramitsUsuari
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection
    Friend StrIdUsuari As String
    Friend StrNomUsuari As String
    Private Sub TramitsUsuari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarDades()
        Me.DgUsuaris.Visible = False
        Me.BtnNouUsuari.Visible = False
        Me.BtnAutentificar.Visible = True
        Me.AcceptButton = Me.BtnAutentificar
        Me.TextContrasenya.Focus()
        With Me.TextContrasenya
            .Visible = True
            .Text = ""
            .BackColor = System.Drawing.Color.White
            .BorderStyle = BorderStyle.Fixed3D
            .Enabled = True
        End With
        Me.StartPosition = FormStartPosition.CenterParent
    End Sub
    Private Sub TramitsUsuari_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        CarregarDades()
    End Sub
    Private Sub CarregarDades()
        Me.TextUsuari.Text = StrUsuari
        Me.ControlBox = False

        StrCadenaConexio = ""
        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrDadesUsuaris + "\Projecte.mdb;Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT Usuaris.Usuari, Usuaris.Contrasenya, Usuaris.GrupTreball, Usuaris.IdUsuari FROM USUARIS;"

        Try

            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Usuaris")
            oConexion.Close()

            With Me.DgUsuaris
                .DataSource = oDataSet
                .DataMember = "Usuaris"
                .RowHeadersVisible = False
                .BackgroundColor = Color.Beige
                .DefaultCellStyle.BackColor = Color.Beige
                With .Columns
                    .Item(1).Visible = False
                    .Item(2).Visible = False
                    .Item(3).Visible = False
                    With .Item(0)
                        .HeaderText = "Usuari"
                        .HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
                        .Width = CInt(Me.DgUsuaris.Width * 1.0)
                    End With
                End With
                .AllowUserToAddRows = False
                .RowHeadersVisible = False
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
            End With


            'Desencripto el nom d'usuari per mostrar al DataGridView
            Dim Llavor As String = Semilla()
            Dim Files As Integer
            Dim oDataRow As DataRow
            Dim iPosicioActual As Integer = 0

            Files = oDataSet.Tables("Usuaris").Rows.Count
            For iPosicioActual = 0 To Files - 1
                oDataRow = oDataSet.Tables("Usuaris").Rows(iPosicioActual)
                DgUsuaris.Rows(iPosicioActual).Cells("Usuari").Value = DeCodificar(DgUsuaris.Rows(iPosicioActual).Cells("Usuari").Value, Llavor)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub BtnNouUsuari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNouUsuari.Click
        Dim Existeix As Integer = 2
        Existeix = ComprovarUsuari(Me.TextUsuari.Text, Me.TextContrasenya.Text)

        If Existeix = 1 Then    'Usuari o contrasenya incorrecte
            MsgBox("No disposes dels permisos per crear usuaris" + Chr(13) + "posa't en contacte amb l'administrador", , "Fisiomèdic")
            Exit Sub
        ElseIf Existeix = 0 Then 'Usuari i contrasenya correcte
            NouUsuari.Show()
        Else   'Error (més d'un usuari amb el mateix nom o errors varis
            MsgBox("Error a l'autentificació d'usuari, posa't en contacte amb l'administrador", , "Fisiomèdic")
            Exit Sub
        End If
    End Sub
    Private Sub BtnAutentificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAutentificar.Click
        Dim Existeix As Integer = 2
        Existeix = ComprovarUsuari(Me.TextUsuari.Text, Me.TextContrasenya.Text)

        If Existeix = 1 Then
            MsgBox("No disposes dels permisos per eliminar usuaris" + Chr(13) + "posa't en contacte amb l'administrador", , "Fisiomèdic")
            Me.TextContrasenya.Text = ""
        ElseIf Existeix = 0 Then
            Me.DgUsuaris.Visible = True
            Me.BtnNouUsuari.Visible = True
            With Me.TextContrasenya
                .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
                .BorderStyle = BorderStyle.None
                .Enabled = False
            End With
            Me.BtnAutentificar.Visible = False
        Else   'Error (més d'un usuari amb el mateix nom o errors varis
            MsgBox("Error a l'autentificació d'usuari, posa't en contacte amb l'administrador", , "Fisiomèdic")
            Exit Sub
        End If



    End Sub
    Private Sub DgUsuaris_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgUsuaris.CellContentDoubleClick
        StrIdUsuari = Me.DgUsuaris.Rows(e.RowIndex).Cells(3).Value()
        StrNomUsuari = Me.DgUsuaris.Rows(e.RowIndex).Cells(0).Value()
        GestioUsuaris.ShowDialog()
    End Sub
End Class