Public Class ClubsEsportius
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection

    Private Sub ClubsEsportius_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        CarregarDades()
        Me.Text = Me.Text + " " + StrOrigenDeDades

    End Sub
    Private Sub CarregarDades()

        Me.BtnOk.Visible = False
        Me.BtnNouClub.Visible = True
        Me.BtnSortir.Visible = True

        Me.ModCif.Visible = False
        Me.ModCP.Visible = False
        Me.ModNom.Visible = False
        Me.ModPoblacio.Visible = False

        Me.Label3.Visible = False
        Me.Label4.Visible = False
        Me.Label5.Visible = False
        Me.Label6.Visible = False
        Me.Label7.Visible = False
        Me.Label8.Visible = False
        Me.Label9.Visible = False
        Me.Label10.Visible = False



        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT Clubs.Club FROM Clubs ORDER BY Club;"
        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)


        Try
            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Clubs")
            oConexion.Close()

            Me.DgClubsEsportius.DataSource = oDataSet
            Me.DgClubsEsportius.DataMember = "Clubs"

            ConfigurarDgClubsEsportius()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ConfigurarDgClubsEsportius()

        With Me.DgClubsEsportius
            .RowsDefaultCellStyle.BackColor = Color.Beige
            .BackgroundColor = Color.Beige
            .RowHeadersVisible = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            .ReadOnly = True

            .Columns.Item(0).HeaderText = "CLUB"    'Títol de columna
            .Columns.Item(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter    'Alineació d'encapçalament columna
            .Columns(0).Width = CInt(Me.DgClubsEsportius.Width * 0.99) 'Mides
        End With
    End Sub
    Private Sub BtnSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSortir.Click
        Me.Close()
    End Sub
    Private Sub DgClubsEsportius_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgClubsEsportius.CellContentDoubleClick

        Dim StrClub As String = Me.DgClubsEsportius.Rows(e.RowIndex).Cells(0).Value

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = ""
        StrInstruccioSQL = "SELECT Clubs.* FROM Clubs WHERE Clubs.Club=""" + Me.DgClubsEsportius.Rows(e.RowIndex).Cells(0).Value.ToString + """;"
        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)


        Try
            oDataSet = Nothing
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Clubs")
            oConexion.Close()

            If oDataSet.Tables("Clubs").Rows.Count > 0 Then
                Dim iPosicioActual As Integer = 0
                Dim oDataRow As DataRow

                oDataRow = oDataSet.Tables("Clubs").Rows(iPosicioActual)

                If VarType(oDataRow("Club")) <> VariantType.Null Then
                    Me.Nom.Text = oDataRow("Club")
                Else
                    Me.Nom.Text = ""
                End If

                If VarType(oDataRow("Cif")) <> VariantType.Null Then
                    Me.Nom.Text = Me.Nom.Text + " - " + oDataRow("Cif")
                Else
                    Me.Nom.Text = Me.Nom.Text
                End If

                If VarType(oDataRow("Adreça")) <> VariantType.Null Then
                    Me.Adreça.Text = oDataRow("Adreça")
                Else
                    Me.Adreça.Text = ""
                End If

                If VarType(oDataRow("CP")) <> VariantType.Null Then
                    Me.Poblacio.Text = oDataRow("CP")
                Else
                    Me.Poblacio.Text = ""
                End If

                If VarType(oDataRow("Poblacio")) <> VariantType.Null Then
                    Me.Poblacio.Text = Me.Poblacio.Text + " " + oDataRow("Poblacio")
                Else
                    Me.Poblacio = Me.Poblacio
                End If

                If VarType(oDataRow("Telefon")) <> VariantType.Null Then
                    Me.Telefon.Text = oDataRow("Telefon")
                Else
                    Me.Telefon.Text = ""
                End If

                If VarType(oDataRow("Fax")) <> VariantType.Null Then
                    Me.Fax.Text = oDataRow("Fax")
                Else
                    Me.Fax.Text = ""
                End If

                If VarType(oDataRow("Ae")) <> VariantType.Null Then
                    Me.Ae.Text = oDataRow("Ae")
                Else
                    Me.Ae.Text = ""
                End If

                If VarType(oDataRow("Notes")) <> VariantType.Null Then
                    Me.Notes.Text = oDataRow("Notes")
                Else
                    Me.Notes.Text = ""
                End If

                If VarType(oDataRow("PersonaContacte")) <> VariantType.Null Then
                    Me.Contacte.Text = oDataRow("PersonaContacte")
                Else
                    Me.Contacte.Text = ""
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BtnNouClub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNouClub.Click

        Me.Nom.Visible = False
        Me.Poblacio.Visible = False
        Me.ModNom.Visible = True
        Me.ModCif.Visible = True
        Me.ModCP.Visible = True
        Me.ModPoblacio.Visible = True

        Me.Label3.Visible = True
        Me.Label4.Visible = True
        Me.Label5.Visible = True
        Me.Label6.Visible = True
        Me.Label7.Visible = True
        Me.Label8.Visible = True
        Me.Label9.Visible = True
        Me.Label10.Visible = True

        With Me.Adreça
            .Text = ""
            .Enabled = True
            .BorderStyle = BorderStyle.Fixed3D
            .BackColor = Color.White
        End With

        With Me.Telefon
            .Text = ""
            .Enabled = True
            .BorderStyle = BorderStyle.Fixed3D
            .BackColor = Color.White
        End With

        With Me.Fax
            .Text = ""
            .Enabled = True
            .BorderStyle = BorderStyle.Fixed3D
            .BackColor = Color.White
        End With

        With Me.Ae
            .Text = ""
            .Enabled = True
            .BorderStyle = BorderStyle.Fixed3D
            .BackColor = Color.White
        End With

        With Me.Contacte
            .Text = ""
            .Enabled = True
            .BorderStyle = BorderStyle.Fixed3D
            .BackColor = Color.White
        End With

        With Me.Notes
            .Text = ""
            .Enabled = True
            .BorderStyle = BorderStyle.Fixed3D
            .BackColor = Color.White
        End With

        Me.BtnSortir.Visible = False
        Me.BtnNouClub.Visible = False
        Me.BtnOk.Visible = True

    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click

        Dim i As Integer = MsgBox("Guardar dades", MsgBoxStyle.YesNo, "Fisiomèdic")

        If i = vbYes Then
            Me.Nom.Visible = True
            Me.Poblacio.Visible = True
            Me.ModNom.Visible = False
            Me.ModCif.Visible = False
            Me.ModCP.Visible = False
            Me.ModPoblacio.Visible = False

            Me.Label3.Visible = False
            Me.Label4.Visible = False
            Me.Label5.Visible = False
            Me.Label6.Visible = False
            Me.Label7.Visible = False
            Me.Label8.Visible = False
            Me.Label9.Visible = False
            Me.Label10.Visible = False

            StrInstruccioSQL = ""
            StrInstruccioSQL = "INSERT INTO Clubs ( Club, Cif, Adreça, CP, Poblacio, Telefon, Fax, AE, Notes, PersonaContacte )" _
                + " SELECT """ + Me.ModNom.Text _
                + """, """ + Me.ModCif.Text _
                + """, """ + Me.Adreça.Text _
                + """, """ + Me.ModCP.Text _
                + """, """ + Me.ModPoblacio.Text _
                + """, """ + Me.Telefon.Text _
                + """, """ + Me.Fax.Text _
                + """, """ + Me.Ae.Text _
                + """, """ + Me.Notes.Text _
                + """, """ + Me.Contacte.Text + """;"

            ExecutarSql(StrInstruccioSQL)

            With Me.Nom
                .Text = ""
                .Enabled = False
                .BorderStyle = BorderStyle.None
                .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            End With

            With Me.Poblacio
                .Text = ""
                .Enabled = False
                .BorderStyle = BorderStyle.None
                .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            End With

            With Me.Adreça
                .Text = ""
                .Enabled = False
                .BorderStyle = BorderStyle.None
                .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            End With

            With Me.Telefon
                .Text = ""
                .Enabled = False
                .BorderStyle = BorderStyle.None
                .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            End With

            With Me.Fax
                .Text = ""
                .Enabled = False
                .BorderStyle = BorderStyle.None
                .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            End With

            With Me.Ae
                .Text = ""
                .Enabled = False
                .BorderStyle = BorderStyle.None
                .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            End With

            With Me.Contacte
                .Text = ""
                .Enabled = False
                .BorderStyle = BorderStyle.None
                .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            End With

            With Me.Notes
                .Text = ""
                .Enabled = False
                .BorderStyle = BorderStyle.None
                .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            End With

            Me.BtnSortir.Visible = False
            Me.BtnNouClub.Visible = False
            Me.BtnOk.Visible = True

        Else
            Me.Nom.Visible = True
            Me.Poblacio.Visible = True
            Me.ModNom.Visible = False
            Me.ModCif.Visible = False
            Me.ModCP.Visible = False
            Me.ModPoblacio.Visible = False

            Me.Label3.Visible = False
            Me.Label4.Visible = False
            Me.Label5.Visible = False
            Me.Label6.Visible = False
            Me.Label7.Visible = False
            Me.Label8.Visible = False
            Me.Label9.Visible = False
            Me.Label10.Visible = False

            With Me.Nom
                .Text = ""
                .Enabled = False
                .BorderStyle = BorderStyle.None
                .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            End With

            With Me.Poblacio
                .Text = ""
                .Enabled = False
                .BorderStyle = BorderStyle.None
                .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            End With

            With Me.Adreça
                .Text = ""
                .Enabled = False
                .BorderStyle = BorderStyle.None
                .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            End With

            With Me.Telefon
                .Text = ""
                .Enabled = False
                .BorderStyle = BorderStyle.None
                .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            End With

            With Me.Fax
                .Text = ""
                .Enabled = False
                .BorderStyle = BorderStyle.None
                .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            End With

            With Me.Ae
                .Text = ""
                .Enabled = False
                .BorderStyle = BorderStyle.None
                .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            End With

            With Me.Contacte
                .Text = ""
                .Enabled = False
                .BorderStyle = BorderStyle.None
                .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            End With

            With Me.Notes
                .Text = ""
                .Enabled = False
                .BorderStyle = BorderStyle.None
                .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            End With

            Me.BtnSortir.Visible = False
            Me.BtnNouClub.Visible = False
            Me.BtnOk.Visible = True

        End If
        Me.CarregarDades()
    End Sub
End Class