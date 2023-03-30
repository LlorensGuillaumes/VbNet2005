Module ModValidacioDni
    Public Function ValidacioDni(ByVal Dni As String)
        Dim StrNumero As String = Left(Dni, 8)
        Dim StrPrimerDigit As String = Left(StrNumero, 1)
        Dim StrDniLletra As String = Right(Dni, 1)
        If StrPrimerDigit = "X" Then
            StrNumero = Replace(StrNumero, "X", "0")
        ElseIf StrPrimerDigit = "Y" Then
            StrNumero = Replace(StrNumero, "Y", "1")
        ElseIf StrPrimerDigit = "Z" Then
            StrNumero = Replace(StrNumero, "Z", "2")
        Else
            StrNumero = StrNumero
        End If

        Dim Resto As Integer = Val(StrNumero) Mod (23)
        Dim Lletra As String = "I"
        Select Case Resto
            Case 0
                Lletra = "T"
            Case 1
                Lletra = "R"
            Case 2
                Lletra = "W"
            Case 3
                Lletra = "A"
            Case 4
                Lletra = "G"
            Case 5
                Lletra = "M"
            Case 6
                Lletra = "Y"
            Case 7
                Lletra = "F"
            Case 8
                Lletra = "P"
            Case 9
                Lletra = "D"
            Case 10
                Lletra = "X"
            Case 11
                Lletra = "B"
            Case 12
                Lletra = "N"
            Case 13
                Lletra = "J"
            Case 14
                Lletra = "Z"
            Case 15
                Lletra = "S"
            Case 16
                Lletra = "Q"
            Case 17
                Lletra = "V"
            Case 18
                Lletra = "H"
            Case 19
                Lletra = "L"
            Case 20
                Lletra = "C"
            Case 21
                Lletra = "K"
            Case 22
                Lletra = "E"
        End Select

        If StrDniLletra <> Lletra Then
            Return 1
        Else
            Return 0
        End If

    End Function
End Module
