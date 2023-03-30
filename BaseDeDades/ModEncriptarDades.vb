Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Module ModEncriptarDades
    Private Const StrClave = "F1$10m3d1("

    Public s As String

    '****************************  
    '**** CALCULA LA SEMILLA ****  
    '****************************  
    Public Function Semilla() As String

        Dim lngSemilla1 As Long
        Dim lngSemilla2 As Long
        Dim j As Long
        Dim i As Long
        lngSemilla1 = 0
        lngSemilla2 = 0
        j = Len(strClave)

        For i = 1 To Len(strClave)

            lngSemilla1 = lngSemilla1 + Asc(Mid$(strClave, i, 1)) * i
            lngSemilla2 = lngSemilla2 + Asc(Mid$(strClave, i, 1)) * j
            j = j - 1
        Next
        Semilla = LTrim$(Str$(lngSemilla1)) + "," + LTrim$(Str$(lngSemilla2))
    End Function

    '******************  
    '**** CODIFICA ****  
    '******************  
    Public Function Codificar(ByVal strCadena As String, ByVal strSemilla As String) As String

        Dim lngIi1 As Long
        Dim lngIi2 As Long
        Dim i As Long

        lngIi1 = Val(Left$(strSemilla, InStr(strSemilla, ",") - 1))
        lngIi2 = Val(Mid$(strSemilla, InStr(strSemilla, ",") + 1))

        For i = 1 To Len(strCadena)
            lngIi1 = lngIi1 - i
            lngIi2 = lngIi2 + i
            If (i Mod 2) = 0 Then
                Mid(strCadena, i, 1) = Chr((Asc(Mid$(strCadena, i, 1)) - lngIi1) And &HFF)
            Else
                Mid(strCadena, i, 1) = Chr((Asc(Mid$(strCadena, i, 1)) + lngIi2) And &HFF)
            End If
        Next
        Dim LongCadena As Integer = Len(strCadena)
        Dim Posicio As Integer = 1
        Dim Caracter As String
        Dim Final As String = ""
        For Posicio = 1 To LongCadena
            Caracter = Format(Asc(Mid(strCadena, Posicio, 1)), "0000")
            Final = Final + Caracter
        Next
        'Codificar = strCadena
        Codificar = Final

    End Function

    '********************  
    '**** DECODIFICA ****  
    '********************  
    Public Function DeCodificar(ByVal CadenaCodificada As String, ByVal strSemilla As String) As String

        Dim Caracter As String
        Dim Strcadena As String = ""
        Dim Posicio As Integer = 1
        Dim CaractersCadena As Integer = Len(CadenaCodificada)

        For Posicio = 1 To CaractersCadena Step 4
            Caracter = Chr(Mid(CadenaCodificada, Posicio, 4))
            Strcadena = Strcadena + Caracter
        Next

        Dim lngIi1 As Long
        Dim lngIi2 As Long
        Dim i As Long

        lngIi1 = Val(Left$(strSemilla, InStr(strSemilla, ",") - 1))
        lngIi2 = Val(Mid$(strSemilla, InStr(strSemilla, ",") + 1))

        For i = 1 To Len(Strcadena)

            lngIi1 = lngIi1 - i
            lngIi2 = lngIi2 + i

            If (i Mod 2) = 0 Then
                Mid(Strcadena, i, 1) = Chr((Asc(Mid$(Strcadena, i, 1)) + lngIi1) And &HFF)
            Else
                Mid(Strcadena, i, 1) = Chr((Asc(Mid$(Strcadena, i, 1)) - lngIi2) And &HFF)
            End If
        Next
        'MsgBox(Strcadena)
        DeCodificar = Strcadena
    End Function


End Module
