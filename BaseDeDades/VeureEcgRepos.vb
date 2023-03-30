Imports System.IO
Imports System.Text
Public Class VeureEcgRepos

    Private Sub EcgRepos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Me.WindowState = FormWindowState.Maximized
        Me.Text = "ECG REPOS " + StrOrigenDeDades
        Me.Ecg.SizeMode = PictureBoxSizeMode.Zoom

        Me.Ecg.Invalidate()

        Dim CarpetaMare As DirectoryInfo = Directory.GetParent(StrOrigenDeDades)
        Dim RutaEcg As String = CarpetaMare.FullName + "\ECG\" + ReconeixementMedic.RegistreEcgRepos + ".jpg"

        If File.Exists(RutaEcg) = True Then
            Me.Ecg.Image = New Bitmap(RutaEcg)

        Else
            Dim i As Integer = MsgBox("Error en la localització de l'ECG" + Chr(13) + "Comprova que s'hagi introduit correctament el nom de l'arxiu" + Chr(13) + "Vols corregir aquest valor", MsgBoxStyle.YesNo, "Fisiomèdic")

            If i = vbYes Then
                Do While File.Exists(RutaEcg) = False
                    Dim Valor As String = InputBox("Introdueix el nom de l'arxiu", "Fisiomèdic")
                    If Valor = "" Then
                        Me.Ecg.Image = Nothing
                        Exit Sub
                    Else
                        RutaEcg = CarpetaMare.FullName + "\ECG\" + Valor + ".jpg"
                        StrInstruccioSQL = "UPDATE EcgRepos SET EcgRepos.ECG = """ + Valor _
                                            + """ WHERE EcgRepos.ECG=""" + ReconeixementMedic.RegistreEcgRepos + """;"


                    End If

                Loop
            Else
                Me.Ecg.Image = Nothing
                Exit Sub
            End If
            Me.Ecg.Image = New Bitmap(RutaEcg)
            ExecutarSql(StrInstruccioSQL)

        End If
    End Sub
    Private Sub BtnSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSortir.Click
        Me.Close()
    End Sub
End Class