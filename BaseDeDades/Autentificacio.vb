Imports System.IO
Imports System.Text

Public Class Autentificacio
    Inherits System.Windows.Forms.Form
    Private oDataAdapter As OleDb.OleDbDataAdapter
    Private oCb As OleDb.OleDbCommandBuilder
    Private oConexion As OleDb.OleDbConnection

    Private MenuUsuaris As MenuItem
    WithEvents SubMenuResetUsuari As MenuItem
    Private EvSubMenuResetUsuari As System.EventHandler

    Private MenuConexio As MenuItem
    WithEvents SubMenuConexioUsuaris As MenuItem
    Private EvSubMenuConexioUsuaris As System.EventHandler

    Friend Registre As Integer

    Private Sub BotoOrigenDeDades(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog.InitialDirectory = "C:\OrigenDades"
        OpenFileDialog.Filter = "Base de Dases (Ms Access) (*.mdb)|*.mdb|Pojectes (Ms Access) (*.mde) |*.mde |Tots els arxius (*.*)|*.*"

        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            'Escric la ruta al camp de text
            Me.OrigenDadesPred.Text = FileName
        End If



    End Sub
    Private Sub BotoOK(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim SrLector As StreamReader
        SrLector = New StreamReader("C:\Fisiomedic\Fisiomedic\OrigenUsuaris.txt")
        Dim Linea As String
        Linea = SrLector.ReadLine
        StrDadesUsuaris = Linea
        'Carrego les dades de l'origen predeteminat al cuadre de text 
        'CarregarFormulari()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.ControlBox = False

        'Comprova que l'usuari existeix a la taula d'usuaris
        'si existeix, tindrà valor 0, si no, valor 1, qualsevol altre error, valor 2
        If Me.Contrasenya.Text = "" Then
            MsgBox("La contrasenya és un camp obligatori", , "Fisiomèdic")
            Me.Contrasenya.Focus()
            Exit Sub
        Else
        End If

        Dim Existeix As Integer = 3

        Existeix = ComprovarUsuari(Me.Usuari.Text, Me.Contrasenya.Text)

        If Existeix = 1 Then    'Usuari o contrasenya incorrecte
            MsgBox("Usuari o contrasenya incorrecte", , "Fisiomèdic")
            Intents = Intents + 1
            If Intents = 5 Then
                StrInstruccioSQL = ""
                StrInstruccioSQL = "UPDATE Usuaris SET Usuaris.Contrasenya= """ _
                            + """ WHERE Usuaris.IdUsuari=" + CStr(Registre) + ";"

                oConexion = New OleDb.OleDbConnection
                oConexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrDadesUsuaris + "\Projecte.mdb;Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
                Dim oComando As New OleDb.OleDbCommand(StrInstruccioSQL, oConexion)
                Try
                    oConexion.Open()
                    oComando.ExecuteNonQuery()
                    oConexion.Close()

                    MsgBox("Has exaurit les possibilitats" + Chr(13) + "USUARI BLOQUEJAT", , "Fisiomèdic")
                    Exit Sub

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            Me.Contrasenya.Text = ""
            Me.Contrasenya.Focus()
            Exit Sub
        ElseIf Existeix = 0 Then 'Usuari i contrasenya correcte
            StrUsuari = Me.Usuari.Text
        ElseIf Existeix = 3 Then 'Usuari bloquejat
            MsgBox("Usuari bloquejat", , "Fisiomèdic")
            Exit Sub
        Else   'Error (més d'un usuari amb el mateix nom o errors varis
            MsgBox(Existeix)
            MsgBox("Error a l'autentificació d'usuari, posa't en contacte amb l'administrador", , "Fisiomèdic")
            Exit Sub
        End If

        'Si vull guardar la ruta com a predeterminada, escric aquesta ruta al .txt 
        If Me.PredeterminatSiNo.CheckState = CheckState.Checked Then

            oConexion = New OleDb.OleDbConnection
            StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrDadesUsuaris + "\Projecte.mdb;Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
            oConexion.ConnectionString = StrCadenaConexio

            StrInstruccioSQL = ""
            StrInstruccioSQL = "UPDATE RutaDades SET RutaDades.RutaDades = """ + Me.OrigenDadesPred.Text + """;"

            Dim oComando As New OleDb.OleDbCommand(StrInstruccioSQL, oConexion)

            Try
                oConexion.Open()
                oComando.ExecuteNonQuery()
                oConexion.Close()

            Catch ex As Exception
                MsgBox("Petició no executada", , "Fisiomèdic")
            End Try
        End If

        Me.PredeterminatSiNo.CheckState = CheckState.Unchecked
        StrOrigenDeDades = Me.OrigenDadesPred.Text

        Dim Formulari As New Inici()
        Formulari.Show()
        'Tanco el formulari
        Me.Close()

    End Sub
    Private Sub Autentificacio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Me.Usuari.Text = ""
        Me.Contrasenya.Text = ""
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = Me.Text + " " + StrOrigenDeDades

        If Not Directory.Exists("C:\Fisiomedic\Fisiomedic\") Then
            Directory.CreateDirectory("C:\Fisiomedic\Fisiomedic")
            Dim Informacion As DirectoryInfo = New DirectoryInfo("C:\Fisiomedic\Fisiomedic")
            Informacion.Attributes = FileAttributes.Normal
        Else
        End If
        If Not File.Exists("C:\Fisiomedic\Fisiomedic\OrigenUsuaris.txt") Then
            CrearRutaAccesUsuaris()
        Else
            Dim SrLector As StreamReader

            Try
                SrLector = New StreamReader("C:\Fisiomedic\Fisiomedic\OrigenUsuaris.txt")
                Dim Linea As String
                Linea = SrLector.ReadLine
                StrDadesUsuaris = Linea
                If Linea = "" Then
                    SrLector.Close()
                    CrearRutaAccesUsuaris()
                End If
                SrLector.Close()
                'Carrego les dades de l'origen predeteminat al cuadre de text 
                CarregarFormulari()
                Me.StartPosition = FormStartPosition.CenterScreen
                Me.ControlBox = False

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
    Private Sub CrearRutaAccesUsuaris()
        'Borra l'arxiu per si de cas
        File.Delete("C:\Fisiomedic\Fisiomedic\OrigenUsuaris.txt")

        Dim FolderBrowserDialog As New FolderBrowserDialog

        With FolderBrowserDialog
            .RootFolder = Environment.SpecialFolder.MyComputer
            .ShowNewFolderButton = False
            .Description = "Indica la carpeta on es troba l'arxiu PROJECTE.MDB"
            .ShowNewFolderButton = False
        End With

        Dim Carpeta As String
        Dim oFileStream As FileStream
        Try
            If (FolderBrowserDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
                Carpeta = FolderBrowserDialog.SelectedPath
                oFileStream = New FileStream("C:\Fisiomedic\Fisiomedic\OrigenUsuaris.txt", FileMode.CreateNew)

                If File.Exists("C:\Fisiomedic\Fisiomedic\OrigenUsuaris.txt") Then
                    oFileStream.Close()
                    Dim swEsctritor As StreamWriter = New StreamWriter("C:\Fisiomedic\Fisiomedic\OrigenUsuaris.txt", False)
                    swEsctritor.WriteLine(Carpeta)
                    swEsctritor.Close()
                Else
                    MsgBox("Error en la creació de l'origen de dades", , "Fisiomèdic")
                End If
            Else
                Me.Close()
                Inici.Close()
            End If
        Catch ex As IOException
            MsgBox(ex.Message)
        Finally



        End Try

    End Sub
    Private Sub CarregarFormulari()

        'Carregar Menús
        MenuUsuaris = New MenuItem
        MenuUsuaris.Text = "Usuaris"

        SubMenuResetUsuari = New MenuItem
        SubMenuResetUsuari.Text = "Resetejar usuaris"
        AddHandler SubMenuResetUsuari.Click, EvSubMenuResetUsuari

        MenuConexio = New MenuItem
        MenuConexio.Text = "Conexions"

        SubMenuConexioUsuaris = New MenuItem
        SubMenuConexioUsuaris.Text = "Conexions internes"
        AddHandler SubMenuConexioUsuaris.Click, EvSubMenuConexioUsuaris

        MenuUsuaris.MenuItems.AddRange(New MenuItem() {SubMenuResetUsuari})
        MenuConexio.MenuItems.AddRange(New MenuItem() {SubMenuConexioUsuaris})

        Me.Menu = New MainMenu
        Me.Menu.MenuItems.Add(MenuUsuaris)
        Me.Menu.MenuItems.Add(MenuConexio)

        'Carregar Cadena predeterminada
        oConexion = New OleDb.OleDbConnection
        oDataSet = Nothing
        oDataSet = New DataSet()

        StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrDadesUsuaris + "\Projecte.mdb;Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
        oConexion.ConnectionString = StrCadenaConexio

        StrInstruccioSQL = "SELECT RutaDades.RutaDades FROM RutaDades WHERE RutaDades.Id = 1;"
        oDataAdapter = New OleDb.OleDbDataAdapter(StrInstruccioSQL, oConexion)

        oCb = New OleDb.OleDbCommandBuilder(oDataAdapter)

        Try
            oConexion.Open()
            oDataAdapter.Fill(oDataSet, "RutaDades")
            oConexion.Close()

            Dim oDataRow As DataRow
            If oDataSet.Tables("RutaDades").Rows.Count = 0 Then
                Exit Sub
            ElseIf oDataSet.Tables("RutaDades").Rows.Count = 1 Then
                Dim iPosicionActual As Integer
                iPosicionActual = 0
                oDataRow = oDataSet.Tables("RutaDades").Rows(iPosicionActual)
            Else
                MsgBox("Existeixen més d'un origen de dades" + Chr(13) + "Consulta a l'administrador", , "Fisiomèdic")
                Exit Sub
            End If

            If VarType(oDataRow("RutaDades")) <> VariantType.Null Then
                Me.OrigenDadesPred.Text = oDataRow("RutaDades")
            Else
                Me.OrigenDadesPred.Text = ""
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.ControlBox = False
        Me.AcceptButton = Me.Button2

    End Sub
    Private Sub ConexionsInternes(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuConexioUsuaris.Click

        Dim Clau As String
        Clau = InputBox("Introdueix contrasenya de conexions", "Fisiomèdic")
        If Clau = "FF4973D7EGDFFA7549" Then
            CrearRutaAccesUsuaris()
        Else
            MsgBox("Contrasenya incorrecte", , "Fisomèdic")
            Exit Sub
        End If
    End Sub
    Private Sub ResetejarUsuaris(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenuResetUsuari.Click
        Dim Clau As String
        Clau = InputBox("Introdueix contrasenya de reseteig", "Fisiomèdic")

        If Clau = "FF4973D7EGDFFA7549" Then
            oConexion = New OleDb.OleDbConnection
            StrCadenaConexio = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + StrDadesUsuaris + "\Projecte.mdb;Persist security Info=True; Jet OLEDB:Database Password=F1$10m3b1("
            oConexion.ConnectionString = StrCadenaConexio
            Dim oComando As OleDb.OleDbCommand

            'Elimino tots els usuaris i contrasenyes de la taula
            StrInstruccioSQL = ""
            StrInstruccioSQL = "DELETE Usuaris.* FROM Usuaris;"
            oComando = New OleDb.OleDbCommand(StrInstruccioSQL, oConexion)

            Try
                oConexion.Open()
                oComando.ExecuteNonQuery()
                oConexion.Close()

            Catch ex As Exception
                MsgBox("Petició no executada", , "Fisiomèdic")
                Exit Sub
            End Try

            'Creo un usuari inicial per poder començar

            Dim Llavor As String = Semilla()
            Dim iUsuari As String = Codificar("admin", Llavor)
            Dim iContraseya As String = Codificar("12345678", Llavor)

            StrInstruccioSQL = ""
            StrInstruccioSQL = "INSERT INTO Usuaris ( Usuari, Contrasenya, GrupTreball )" _
                        + " SELECT '" + iUsuari _
                        + "' , """ + iContraseya _
                        + """, """ + "1111" + """;"

            oComando = New OleDb.OleDbCommand(StrInstruccioSQL, oConexion)

            Try
                oConexion.Open()
                oComando.ExecuteNonQuery()
                oConexion.Close()
            Catch ex As Exception
                MsgBox("Petició no executada", , "Fisiomèdic")
                Exit Sub
            End Try

        Else
            MsgBox("Contrasenya incorrecte", , "Fisiomèdic")
            Exit Sub
        End If

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        Inici.Close()
    End Sub
End Class