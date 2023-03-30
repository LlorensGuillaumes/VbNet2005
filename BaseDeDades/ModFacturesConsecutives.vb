Module ModFacturesConsecutives
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection

    Public Function FacturesConsecutives() As Integer

        Dim Correlatiu As Integer = 1
        StrInstruccioSQL = ""
        oDataSet = Nothing

        Dim IntNumFactura As Integer

        oConexion = New OleDb.OleDbConnection
        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrOrigenDeDades + ";Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = "SELECT Factures.NumFactura" _
                        + " FROM Factures" _
                        + " ORDER BY Factures.NumFactura;"

        Try
            oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)
            oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)
            oDataSet = New DataSet()

            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "Factures")
            oConexion.Close()

            Dim Files As Integer
            Files = oDataSet.Tables("Factures").Rows.Count

            If Files = 0 Then 'Si no hi ha registres
                Correlatiu = 0
                Return Correlatiu
            ElseIf Files = 1 Then 'Si hi ha només un registre
                Correlatiu = 0
                Return Correlatiu
            Else    'Més d'un registre, assigno la consulta al DataRow
                Dim iPosicionActual As Integer = 0
                Dim NumFactura As Integer
                Dim oDataRow As DataRow
                oDataRow = oDataSet.Tables("Factures").Rows(iPosicionActual)

                If VarType(oDataRow("NumFactura")) <> VariantType.Null Then
                    IntNumFactura = CInt(oDataRow("NumFactura"))
                Else    'Si falta algún número de factura, no pot passar perque es clau única, torno 1
                    Correlatiu = 1
                    Return (Correlatiu)
                    Exit Function
                End If
                'Assigon el valor a NumFactura per tenir el número anterior i poder comprovar
                NumFactura = IntNumFactura

                'Creo un Bucle de les linies fins al final de la taula, al ser en base 0 l'ultim registre és igual al total
                'de registres menys 1
                For iPosicionActual = 1 To Files - 1
                    oDataRow = oDataSet.Tables("Factures").Rows(iPosicionActual)

                    If VarType(oDataRow("NumFactura")) <> VariantType.Null Then
                        IntNumFactura = CInt(oDataRow("NumFactura"))
                    Else    'Si falta algún número, no pot passar perque és clau única, torno 1
                        Correlatiu = 1
                        Return Correlatiu
                        Exit Function
                    End If
                    'Agafo el valor del registre actual i el comparo amb l'anterior, ha ser igual + 1
                    If IntNumFactura = NumFactura + 1 Then  'Si quadra, poso el registre actual com a anterior i comprovo el següent
                        NumFactura = IntNumFactura
                    Else    'Sinó quadra, miro si la factura és de l'any anterior
                        Dim AnyA As Integer
                        Dim AnyB As Integer
                        AnyA = (Left(Format((IntNumFactura), "00000"), 2))
                        AnyB = (Left(Format((NumFactura), "00000"), 2))

                        If CInt(AnyA) = CInt(AnyB) Then 'Si no és de l'any anterior, torno 1 com a error
                            Correlatiu = 1
                            Return Correlatiu
                            Exit Function
                        Else    'Si és de l'any anterior, segueixo mirant les següents
                            NumFactura = IntNumFactura
                        End If
                    End If
                Next iPosicionActual
                Correlatiu = 0
                Return Correlatiu
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
End Module
