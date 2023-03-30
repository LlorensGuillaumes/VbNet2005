Public Class DetallMutua
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection

    Private StrMutuaActual As String

    Private Sub DetallMutua_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarDades()
        Me.ControlBox = False
        Me.AcceptButton = Me.BtnSortir
        Me.BtnSortir.Focus()
        Me.CenterToParent()
        Me.Text = Me.Text + " " + StrOrigenDeDades
    End Sub
    Private Sub CarregarDades()

        StrInstruccioSQL = ""
        StrCadenaConexio = ""

        Me.ModTipusMutua.Visible = False

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = "SELECT Mutues.Cif, Mutues.Nom, Mutues.Adreça, Mutues.CP, Mutues.Poblacio, Mutues.Provincia," _
            + " Mutues.Telefon1, Mutues.Telefon2, Mutues.Telefon3, Mutues.Fax1, Mutues.Fax2, Mutues.Contacte," _
            + " Mutues.Notes, Mutues.Tipus, Mutues.Preu" _
            + " FROM Mutues " _
            + " WHERE Mutues.Nom =""" + StrMutua + """;"

        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
        oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
        oDataSet = Nothing
        oDataSet = New DataSet()

        Try
            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Mutues")
            oConexion.Close()

            Dim iPosicionActual As Integer
            iPosicionActual = 0
            Dim oDataRow As DataRow
            oDataRow = oDataSet.Tables("Mutues").Rows(iPosicionActual)

            If VarType(oDataRow("Cif")) <> VariantType.Null Then
                Me.DetCif.Text = oDataRow("Cif")
            Else
            End If

            If VarType(oDataRow("Nom")) <> VariantType.Null Then
                Me.DetNom.Text = oDataRow("Nom")
            Else
            End If

            If VarType(oDataRow("Adreça")) <> VariantType.Null Then
                Me.DetAdreça.Text = oDataRow("Adreça")
            Else
            End If

            If VarType(oDataRow("CP")) <> VariantType.Null Then
                Me.DetCP.Text = oDataRow("CP")
            Else
            End If

            If VarType(oDataRow("Poblacio")) <> VariantType.Null Then
                Me.DetPoblacio.Text = oDataRow("Poblacio")
            Else
            End If

            If VarType(oDataRow("Provincia")) <> VariantType.Null Then
                Me.DetProvincia.Text = oDataRow("Provincia")
            Else
            End If

            If VarType(oDataRow("Telefon1")) <> VariantType.Null Then
                Me.DetTelfGeneral.Text = oDataRow("Telefon1")
            Else
            End If

            If VarType(oDataRow("Telefon2")) <> VariantType.Null Then
                Me.DetTelfAutoritzacions.Text = oDataRow("Telefon2")
            Else
            End If

            If VarType(oDataRow("Telefon3")) <> VariantType.Null Then
                Me.DetTelf3.Text = oDataRow("Telefon3")
            Else
            End If

            If VarType(oDataRow("Fax1")) <> VariantType.Null Then
                Me.DetFaxGeneral.Text = oDataRow("Fax1")
            Else
            End If

            If VarType(oDataRow("Fax2")) <> VariantType.Null Then
                Me.DetFaxAutoritzacions.Text = oDataRow("Fax2")
            Else
            End If

            If VarType(oDataRow("Contacte")) <> VariantType.Null Then
                Me.DetPersonaContacte.Text = oDataRow("Contacte")
            Else
            End If

            If VarType(oDataRow("Notes")) <> VariantType.Null Then
                Me.DetNotes.Text = oDataRow("Notes")
            Else
            End If

            If VarType(oDataRow("Tipus")) <> VariantType.Null Then
                Me.DetTipusMutua.Text = oDataRow("Tipus")
            Else
            End If

            If VarType(oDataRow("Preu")) <> VariantType.Null Then
                Me.DetPreu.Text = oDataRow("Preu")
                Me.DetPreu.Text = Format(Me.DetPreu.Text, "currency")
            Else
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Modificar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Button1.Visible = False
        Me.Button2.Visible = True
        Me.BtnSortir.Visible = False

        'Agafo el nom que te actualment la mútua per si es canvia, poder identificar el registre
        'la variable, la he creat com a privada dins de la classe
        StrMutuaActual = Me.DetNom.Text
        'OK

        With Me.DetNom
            .ReadOnly = False
            .BackColor = Color.White
            .TabStop = True
            .BorderStyle = BorderStyle.Fixed3D
            .ForeColor = Color.Black
        End With

        With Me.DetCif
            .ReadOnly = False
            .BackColor = Color.White
            .TabStop = True
            .BorderStyle = BorderStyle.Fixed3D
            .ForeColor = Color.Black
        End With

        With Me.DetAdreça
            .ReadOnly = False
            .BackColor = Color.White
            .TabStop = True
            .BorderStyle = BorderStyle.Fixed3D
            .ForeColor = Color.Black
        End With

        With Me.DetCP
            .ReadOnly = False
            .BackColor = Color.White
            .TabStop = True
            .BorderStyle = BorderStyle.Fixed3D
            .ForeColor = Color.Black
        End With

        With Me.DetPoblacio
            .ReadOnly = False
            .BackColor = Color.White
            .TabStop = True
            .BorderStyle = BorderStyle.Fixed3D
            .ForeColor = Color.Black
        End With

        With Me.DetProvincia
            .ReadOnly = False
            .BackColor = Color.White
            .TabStop = True
            .BorderStyle = BorderStyle.Fixed3D
            .ForeColor = Color.Black
        End With

        With Me.DetTelfGeneral
            .ReadOnly = False
            .BackColor = Color.White
            .TabStop = True
            .BorderStyle = BorderStyle.Fixed3D
            .ForeColor = Color.Black
        End With

        With Me.DetTelfAutoritzacions
            .ReadOnly = False
            .BackColor = Color.White
            .TabStop = True
            .BorderStyle = BorderStyle.Fixed3D
            .ForeColor = Color.Black
        End With

        With Me.DetTelf3
            .ReadOnly = False
            .BackColor = Color.White
            .TabStop = True
            .BorderStyle = BorderStyle.Fixed3D
            .ForeColor = Color.Black
        End With

        With Me.DetFaxGeneral
            .ReadOnly = False
            .BackColor = Color.White
            .TabStop = True
            .BorderStyle = BorderStyle.Fixed3D
            .ForeColor = Color.Black
        End With

        With Me.DetFaxAutoritzacions
            .ReadOnly = False
            .BackColor = Color.White
            .TabStop = True
            .BorderStyle = BorderStyle.Fixed3D
            .ForeColor = Color.Black
        End With

        With Me.DetPersonaContacte
            .ReadOnly = False
            .BackColor = Color.White
            .TabStop = True
            .BorderStyle = BorderStyle.Fixed3D
            .ForeColor = Color.Black
        End With

        With Me.DetNotes
            .ReadOnly = False
            .BackColor = Color.White
            .TabStop = True
            .BorderStyle = BorderStyle.Fixed3D
            .ForeColor = Color.Black
        End With

        With Me.DetPreu
            .ReadOnly = False
            .BackColor = Color.White
            .TabStop = True
            .BorderStyle = BorderStyle.Fixed3D
            .ForeColor = Color.Black
        End With

        Me.DetTipusMutua.Visible = False
        Me.ModTipusMutua.Visible = True

        Me.ModTipusMutua.Text = Me.DetTipusMutua.Text

        'CARREGO LES DADES DE TIPUS MÚTUA AL DESPLEGABLE

        StrInstruccioSQL = ""
        StrCadenaConexio = ""

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = "SELECT TipusMutua.TipusMutua" _
            + " FROM TipusMutua;"

        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
        oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
        oDataSet = Nothing
        oDataSet = New DataSet()

        Try
            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "TipusMutua")
            oConexion.Close()

            With Me.ModTipusMutua
                .DataSource = oDataSet.Tables("TipusMutua")
                .DisplayMember = "TipusMutua"
                .ValueMember = "TipusMutua"
                .Text = Me.DetTipusMutua.Text
                .AutoCompleteSource = AutoCompleteSource.ListItems
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            End With

        Catch ex As Exception

        End Try

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        StrInstruccioSQL = ""

        StrInstruccioSQL = "UPDATE Mutues SET Mutues.Cif = """ + Me.DetCif.Text _
        + """, Mutues.Nom = """ + Me.DetNom.Text _
        + """, Mutues.Adreça = """ + Me.DetAdreça.Text _
        + """, Mutues.CP = """ + Me.DetCP.Text _
        + """, Mutues.Poblacio = """ + Me.DetPoblacio.Text _
        + """, Mutues.Provincia= """ + Me.DetProvincia.Text _
        + """, Mutues.Telefon1= """ + Me.DetTelfGeneral.Text _
        + """, Mutues.Telefon2= """ + Me.DetTelfAutoritzacions.Text _
        + """, Mutues.Telefon3= """ + Me.DetTelf3.Text _
        + """, Mutues.Fax1= """ + Me.DetFaxGeneral.Text _
        + """, Mutues.Fax2= """ + Me.DetFaxAutoritzacions.Text _
        + """, Mutues.Contacte= """ + Me.DetPersonaContacte.Text _
        + """, Mutues.Notes= """ + Me.DetNotes.Text _
        + """, Mutues.Tipus= """ + Me.ModTipusMutua.Text _
        + """, Mutues.Preu= """ + Me.DetPreu.Text _
        + """ WHERE Mutues.Nom=""" + StrMutuaActual + """;"

        ExecutarSql(StrInstruccioSQL)

        CarregarDades()

        'Coloco tots els camps com estaven
        With Me.DetNom
            .ReadOnly = True
            .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            .TabStop = False
            .BorderStyle = BorderStyle.None
            .ForeColor = Color.Gray
        End With

        With Me.DetCif
            .ReadOnly = True
            .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            .TabStop = False
            .BorderStyle = BorderStyle.None
            .ForeColor = Color.Gray
        End With

        With Me.DetAdreça
            .ReadOnly = True
            .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            .TabStop = False
            .BorderStyle = BorderStyle.None
            .ForeColor = Color.Gray
        End With

        With Me.DetCP
            .ReadOnly = True
            .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            .TabStop = False
            .BorderStyle = BorderStyle.None
            .ForeColor = Color.Gray
        End With

        With Me.DetPoblacio
            .ReadOnly = True
            .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            .TabStop = False
            .BorderStyle = BorderStyle.None
            .ForeColor = Color.Gray
        End With

        With Me.DetProvincia
            .ReadOnly = True
            .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            .TabStop = False
            .BorderStyle = BorderStyle.None
            .ForeColor = Color.Gray
        End With

        With Me.DetTelfGeneral
            .ReadOnly = True
            .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            .TabStop = False
            .BorderStyle = BorderStyle.None
            .ForeColor = Color.Gray
        End With

        With Me.DetTelfAutoritzacions
            .ReadOnly = True
            .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            .TabStop = False
            .BorderStyle = BorderStyle.None
            .ForeColor = Color.Gray
        End With

        With Me.DetTelf3
            .ReadOnly = True
            .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            .TabStop = False
            .BorderStyle = BorderStyle.None
            .ForeColor = Color.Gray
        End With

        With Me.DetFaxGeneral
            .ReadOnly = True
            .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            .TabStop = False
            .BorderStyle = BorderStyle.None
            .ForeColor = Color.Gray
        End With

        With Me.DetFaxAutoritzacions
            .ReadOnly = True
            .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            .TabStop = False
            .BorderStyle = BorderStyle.None
            .ForeColor = Color.Gray
        End With

        With Me.DetPersonaContacte
            .ReadOnly = True
            .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            .TabStop = False
            .BorderStyle = BorderStyle.None
            .ForeColor = Color.Gray
        End With

        With Me.DetNotes
            .ReadOnly = True
            .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            .TabStop = False
            .BorderStyle = BorderStyle.None
            .ForeColor = Color.Gray
        End With

        With Me.DetPreu
            .ReadOnly = True
            .BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
            .TabStop = False
            .BorderStyle = BorderStyle.None
            .ForeColor = Color.Gray
        End With

        Me.DetTipusMutua.Visible = True
        Me.ModTipusMutua.Visible = False

        Me.Button2.Visible = False
        Me.Button1.Visible = True
        Me.BtnSortir.Visible = True

    End Sub
    Private Sub DetPreu_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetPreu.Leave
        Me.DetPreu.Text = Me.DetPreu.Text.Replace(".", ",")
    End Sub
    Private Sub BtnSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSortir.Click
        Me.Close()
    End Sub
End Class