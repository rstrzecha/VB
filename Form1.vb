Imports System.Data.OleDb

Public Class dbViewer

    Dim dbConnection As OleDbConnection
    Dim dbAdapter As OleDbDataAdapter = New OleDb.OleDbDataAdapter()
    'Dim sTableName As String
    Dim dbDataSet As DataSet = New DataSet()

    Public Sub ShowLogAdminBox()
        Using objloginform As New Log_admin
            objloginform.ShowDialog(Me)
        End Using
    End Sub

    Public Sub ShowAboutBox()
        Using objAbout As New About
            objAbout.ShowDialog(Me)
        End Using
    End Sub

    Public Sub ShowAdminBox()
        Using objAdmin As New admin
            objAdmin.ShowDialog(Me)
        End Using
    End Sub

    Sub ClearClient()
        lst_nb.Items.Clear()
        lst_marka.Items.Clear()
        lst_model.Items.Clear()
        lst_silnik.Items.Clear()
        lst_kolor.Items.Clear()
        lst_cena.Items.Clear()
        cmb_marka.Items.Clear()
        cmb_model.Items.Clear()
        cmb_silnik.Items.Clear()
        cmb_kolor.Items.Clear()
        cmb_marka.ResetText()
        cmb_model.ResetText()
        cmb_silnik.ResetText()
        cmb_kolor.ResetText()
        pbx_auto.Image = Nothing
    End Sub

    Sub listReader(ByVal selection As String, ByVal box_name As Object, ByVal column_name As String)

        Dim selectCMD As OleDbCommand

        Dim i As Integer
        Dim dt As New DataTable
        Dim bs As New BindingSource

        selectCMD = New OleDbCommand(selection, dbConnection)
        dbAdapter.SelectCommand = selectCMD
        dbAdapter.Fill(dt)

        For i = 0 To dt.Rows.Count - 1
            box_name.Items.Add(dt.Rows(i)(column_name))
        Next
    End Sub

    Private Sub btn_admin_Click(sender As Object, e As EventArgs) Handles btn_admin.Click
        If lstTabels.SelectedItem = "" Then
            MsgBox("Wybierz bazę danych", MsgBoxStyle.Critical, "Brak bazy")
        Else ShowLogAdminBox()
        End If
    End Sub

    Private Sub btn_about_Click(sender As Object, e As EventArgs) Handles btn_about.Click
        ShowAboutBox()
    End Sub

    Private Sub btn_Open_Click(sender As Object, e As EventArgs) Handles btn_Open.Click
        ' Private Sub dbViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim iResult As DialogResult
        Dim i As Integer

        ClearClient()
        OpenFileDialog1.Title = "Select a Database File"
        OpenFileDialog1.Filter = "MDB Files (*.mdb)|*.mdb"

        OpenFileDialog1.CheckFileExists = True
        iResult = OpenFileDialog1.ShowDialog()

        If iResult <> Windows.Forms.DialogResult.Cancel And OpenFileDialog1.FileName.Length <> 0 Then
            Dim sConStr As String
            sConStr = "Provider=Microsoft.Jet.OLEDB.4.0;"
            sConStr &= "Data Source=" & OpenFileDialog1.FileName & ";"
            'sConStr &= "Data Source=C:\rs\bazy\komis1.mdb;"

            If Not dbConnection Is Nothing Then
                dbConnection.Close()
                dbConnection = Nothing
            End If
            dbConnection = New OleDbConnection(sConStr)
            dbConnection.Open()

            Dim schemaTable As DataTable = dbConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                New Object() {Nothing, Nothing, Nothing, "TABLE"})
            dbConnection.Close()

            lstTabels.Items.Clear()
            For i = 0 To schemaTable.Rows.Count - 1
                lstTabels.Items.Add(schemaTable.Rows(i).Item(2))
            Next

        End If
    End Sub

    Private Sub lstTabels_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTabels.SelectedIndexChanged

        cmb_marka.Items.Clear()

        listReader("SELECT distinct marka FROM " & "[" & lstTabels.SelectedItem & "]", cmb_marka, "marka")

        cmb_marka.SelectedIndex = False

    End Sub

    Private Sub cmb_marka_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_marka.SelectedIndexChanged

        cmb_model.Items.Clear()

        listReader("SELECT distinct model FROM " & "[" & lstTabels.SelectedItem &
                   "] where marka = '" & cmb_marka.SelectedItem & "'", cmb_model, "model")

        cmb_model.SelectedIndex = False
    End Sub

    Private Sub cmb_model_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_model.SelectedIndexChanged

        cmb_silnik.Items.Clear()
        cmb_silnik.ResetText()

        listReader("SELECT distinct silnik FROM " & "[" & lstTabels.SelectedItem &
                   "] where marka = '" & cmb_marka.SelectedItem & "'" _
                   & "AND model = '" & cmb_model.SelectedItem & "'", cmb_silnik, "silnik")

        cmb_silnik.SelectedIndex = 0
    End Sub

    Private Sub cmb_silnik_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_silnik.SelectedIndexChanged

        cmb_kolor.Items.Clear()
        cmb_kolor.ResetText()
        lbl_na.Visible = False
        lst_nb.Items.Clear()
        lst_marka.Items.Clear()
        lst_model.Items.Clear()
        lst_silnik.Items.Clear()
        lst_kolor.Items.Clear()
        lst_cena.Items.Clear()
        pbx_auto.Image = Nothing

        If metalic.Checked = True Then
            listReader("SELECT distinct kolor FROM " & "[" & lstTabels.SelectedItem &
                   "] where marka = '" & cmb_marka.SelectedItem & "'" _
                   & "AND model = '" & cmb_model.SelectedItem & "'" &
                   "AND silnik = '" & cmb_silnik.SelectedItem & "'" &
                   "AND metalic = TRUE", cmb_kolor, "kolor")

        ElseIf metalic.Checked = False Then
            listReader("SELECT distinct kolor FROM " & "[" & lstTabels.SelectedItem &
                   "] where  marka = '" & cmb_marka.SelectedItem & "'" _
                   & "AND model = '" & cmb_model.SelectedItem & "'" &
                   "AND silnik = '" & cmb_silnik.SelectedItem & "'", cmb_kolor, "kolor")
        End If

        cmb_kolor.SelectedItem = -1

        If cmb_kolor.Items.Count = 0 Then
            lbl_na.Visible = True
        End If
    End Sub

    Private Sub metalic_CheckedChanged(sender As Object, e As EventArgs) Handles metalic.CheckedChanged
        cmb_silnik_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub cmb_kolor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_kolor.SelectedIndexChanged

        Dim MyBindingSource As New BindingSource
        Dim MyDataTable As New DataTable
        Dim selectCMD As OleDbCommand

        If metalic.Checked = True Then
            selectCMD = New OleDbCommand("SELECT Identyfikator, marka, model, silnik, kolor, metalic, cena FROM " & "[" & lstTabels.SelectedItem &
                   "] where marka = '" & cmb_marka.SelectedItem & "'" &
                   "AND model = '" & cmb_model.SelectedItem & "'" &
                   "AND silnik = '" & cmb_silnik.SelectedItem & "'" &
                   "AND kolor = '" & cmb_kolor.SelectedItem & "'" &
                   "AND metalic = TRUE", dbConnection)

        ElseIf metalic.Checked = False Then
            selectCMD = New OleDbCommand("SELECT Identyfikator, marka, model, silnik, kolor, metalic, cena FROM " & "[" & lstTabels.SelectedItem &
                   "] where marka = '" & cmb_marka.SelectedItem & "'" &
                   "AND model = '" & cmb_model.SelectedItem & "'" &
                   "AND silnik = '" & cmb_silnik.SelectedItem & "'" &
                   "AND kolor = '" & cmb_kolor.SelectedItem & "'", dbConnection)
        End If

        dbAdapter.SelectCommand = selectCMD

        dbAdapter.Fill(MyDataTable)
        MyBindingSource.DataSource = MyDataTable

        lst_nb.Items.Clear()
        lst_marka.Items.Clear()
        lst_model.Items.Clear()
        lst_silnik.Items.Clear()
        lst_kolor.Items.Clear()
        lst_cena.Items.Clear()
        lst_metalic.Items.Clear()
        For i = 0 To MyDataTable.Rows.Count - 1
            lst_nb.Items.Add(MyDataTable.Rows(i)("Identyfikator"))
            lst_marka.Items.Add(MyDataTable.Rows(i)("marka"))
            lst_model.Items.Add(MyDataTable.Rows(i)("model"))
            lst_silnik.Items.Add(MyDataTable.Rows(i)("silnik"))
            lst_kolor.Items.Add(MyDataTable.Rows(i)("kolor"))
            lst_cena.Items.Add(MyDataTable.Rows(i)("cena"))
            If MyDataTable.Rows(i)("metalic") = "True" Then
                lst_metalic.Items.Add("tak")
            Else lst_metalic.Items.Add("nie")
            End If
        Next
    End Sub

    Private Sub lst_nb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_nb.SelectedIndexChanged

        Dim selectCMD As OleDbCommand
        Dim dt As New DataTable
        Dim bs As New BindingSource
        Dim fileName As String

        selectCMD = New OleDbCommand("SELECT link FROM " & "[" & lstTabels.SelectedItem &
                   "] where Identyfikator = " & lst_nb.SelectedItem, dbConnection)
        dbAdapter.SelectCommand = selectCMD
        dbAdapter.Fill(dt)

        fileName = dt.Rows(0)("link").ToString

        Try
            pbx_auto.Image = Image.FromFile(fileName)
        Catch blad As Exception
            MessageBox.Show("Błąd podczas odczytu pliku", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class