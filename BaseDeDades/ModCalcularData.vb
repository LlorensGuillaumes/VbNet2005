Module ModCalcularData

    Public Function CalcularData(ByVal StrData As Date) As String

        Dim StrDia As String
        Dim StrMes As String

        If DatePart(DateInterval.Weekday, StrData) = 2 Then
            StrDia = "Dilluns, "
        ElseIf DatePart(DateInterval.Weekday, StrData) = 3 Then
            StrDia = "Dimarts, "
        ElseIf DatePart(DateInterval.Weekday, StrData) = 4 Then
            StrDia = "Dimecres, "
        ElseIf DatePart(DateInterval.Weekday, StrData) = 5 Then
            StrDia = "Dijous, "
        ElseIf DatePart(DateInterval.Weekday, StrData) = 6 Then
            StrDia = "Divendres, "
        ElseIf DatePart(DateInterval.Weekday, StrData) = 7 Then
            StrDia = "Dissabte, "
        ElseIf DatePart(DateInterval.Weekday, StrData) = 1 Then
            StrDia = "Diumenge, "
        End If


        If Month(StrData) = 1 Then
            StrMes = " de gener del "
        ElseIf Month(StrData) = 2 Then
            StrMes = " de febrer del "
        ElseIf Month(StrData) = 3 Then
            StrMes = " de març del "
        ElseIf Month(StrData) = 4 Then
            StrMes = " d'abril del "
        ElseIf Month(StrData) = 5 Then
            StrMes = " de maig del "
        ElseIf Month(StrData) = 6 Then
            StrMes = " de juny del "
        ElseIf Month(StrData) = 7 Then
            StrMes = " de juliol del "
        ElseIf Month(StrData) = 8 Then
            StrMes = " d'agost del "
        ElseIf Month(StrData) = 9 Then
            StrMes = " de setembre del "
        ElseIf Month(StrData) = 10 Then
            StrMes = " d'octubre del "
        ElseIf Month(StrData) = 11 Then
            StrMes = " de novembre del "
        ElseIf Month(StrData) = 12 Then
            StrMes = " de desembre del "

        End If

        Return StrDia + Format(StrData, "dd") + StrMes + Format(StrData, "yyyy")

    End Function
End Module
