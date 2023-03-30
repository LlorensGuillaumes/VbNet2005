Imports System.IO
Imports System.Text

Public Class RegistreErgo
    Private Sub RegistreErgo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ControlBox = False
        Me.WindowState = FormWindowState.Maximized
        Me.Text = Me.Text + " " + StrOrigenDeDades

        Me.Pacient.Text = ReconeixementMedic.Nom.Text
        Me.Valoracio.Text = ReconeixementMedic.StrValoracio
        Me.MinProva.Text = ReconeixementMedic.StrMinutProva
        Me.TA.Text = ReconeixementMedic.StrTa
        Me.SPO2.Text = ReconeixementMedic.StrSpO2
        Me.FC.Text = ReconeixementMedic.StrFc
        Me.Observacions.Text = ReconeixementMedic.StrObservacions


        Me.Ecg.Invalidate()

        Dim CarpetaMare As DirectoryInfo = Directory.GetParent(StrOrigenDeDades)
        Dim RutaEcg As String = CarpetaMare.FullName + "\ECG\" + ReconeixementMedic.StrECG + ".jpg"

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
                        StrInstruccioSQL = "UPDATE Ergometria SET Ergometria.ValEcg = """ + Valor _
                                            + """ WHERE Ergometria.ValEcg=""" + ReconeixementMedic.StrECG + """;"


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
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click

        StrInstruccioSQL = ""
        StrInstruccioSQL = " UPDATE Ergometria SET " _
            + "Ergometria.IdVAloracio=""" + Me.Valoracio.Text _
            + """, Ergometria.HoraProva=""" + Me.MinProva.Text _
            + """, Ergometria.ValTa=""" + Me.TA.Text _
            + """, Ergometria.ValSPO2=""" + Me.SPO2.Text _
            + """, Ergometria.ValFc=""" + Me.FC.Text _
            + """, Ergometria.Observacions=""" + Me.Observacions.Text _
            + """ WHERE Ergometria.ValEcg=""" + ReconeixementMedic.StrECG + """;"

        ExecutarSql(StrInstruccioSQL)
        ReconeixementMedic.CarregarDades()
        Me.Close()
    End Sub
End Class