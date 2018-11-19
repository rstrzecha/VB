Imports System.Data.OleDb
'Imports System.Data

Public Class admin

    'Inherits dbViewer 'Form


    Dim sTableName As String = dbViewer.lstTabels.Items(dbViewer.lstTabels.SelectedIndex)
    Dim sConstr As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & dbViewer.OpenFileDialog1.FileName & ";"
    Dim i As Integer
    Dim dbDataSet As DataSet = New DataSet()

    Public dbConnection As OleDbConnection = New OleDbConnection(sConStr) 'Robimy nowe połączenie
    Public dbAdapter As OleDbDataAdapter = New OleDb.OleDbDataAdapter() 'Robimy nowe połączenie

    'sTableName = Form1.lstTables.Items(Form1.lstTables.SelectedIndex)

    Public selectCMD As OleDbCommand = New OleDbCommand("SELECT * FROM " &
          "[" & sTableName & "]", dbConnection)

    Dim MyBindingSource As New BindingSource
    Dim MyDataTable As New DataTable

    Dim objCurrencyManager As CurrencyManager

    Public Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sFieldInfo As String

        objCurrencyManager = CType(Me.BindingContext(dbDataSet), CurrencyManager)

        dbAdapter.SelectCommand = selectCMD
        dbAdapter.Fill(MyDataTable)

        MyBindingSource.DataSource = MyDataTable
        DataGridView1.DataSource = MyBindingSource

        dbConnection.Close()    'Zmiana g.18:32

        dbDataSet.Clear()
        dbAdapter.Fill(dbDataSet, sTableName)

        txt_nb.DataBindings.Clear()
        txt_marka.DataBindings.Clear()
        txt_model.DataBindings.Clear()
        txt_silnik.DataBindings.Clear()
        txt_kolor.DataBindings.Clear()
        txt_metalic.DataBindings.Clear()
        txt_cena.DataBindings.Clear()
        txt_link.DataBindings.Clear()

        objCurrencyManager.Position = 1

        txt_nb.DataBindings.Add("Text", MyBindingSource, "Identyfikator")
        txt_marka.DataBindings.Add("Text", MyBindingSource, "marka")
        txt_model.DataBindings.Add("Text", MyBindingSource, "model")
        txt_silnik.DataBindings.Add("Text", MyBindingSource, "silnik")
        txt_kolor.DataBindings.Add("Text", MyBindingSource, "kolor")
        txt_metalic.DataBindings.Add("Text", MyBindingSource, "metalic")
        txt_cena.DataBindings.Add("Text", MyBindingSource, "cena")
        txt_link.DataBindings.Add("Text", MyBindingSource, "link")

        lstColumns.Items.Clear()

        For i = 0 To dbDataSet.Tables(0).Columns.Count - 1
            With dbDataSet.Tables(0).Columns(i)
                sFieldInfo = .ColumnName
                lstColumns.Items.Add(sFieldInfo)
            End With
        Next i
    End Sub

    Private Sub btn_change_Click(sender As Object, e As EventArgs) Handles btn_change.Click
        '        MyBindingSource.EndEdit()
        Dim cmd As OleDbCommand = New OleDbCommand()
        Dim metal As Boolean

        dbViewer.ClearClient()

        cmd.Connection = dbConnection
        cmd.CommandText = "UPDATE " & sTableName & " SET marka = @marka " _
            & ", model = @model, silnik = @silnik, kolor = @kolor, " _
            & "metalic = @metalic, cena = @cena, link = @link" _
            & " WHERE Identyfikator = @id_nb"
        cmd.CommandType = CommandType.Text

        If txt_metalic.Text = "True" Then
            metal = 1
        Else metal = 0
        End If

        cmd.Parameters.AddWithValue("@marka", txt_marka.Text)
        cmd.Parameters.AddWithValue("@model", txt_model.Text)
        cmd.Parameters.AddWithValue("@silnik", txt_silnik.Text)
        cmd.Parameters.AddWithValue("@kolor", txt_kolor.Text)
        cmd.Parameters.AddWithValue("@metalic", metal)
        cmd.Parameters.AddWithValue("@cena", txt_cena.Text)
        cmd.Parameters.AddWithValue("@link", txt_link.Text)
        cmd.Parameters.AddWithValue("@id_nb", txt_nb.Text)

        dbConnection.Open()

        cmd.ExecuteNonQuery()

        dbConnection.Close()

        dbAdapter.Fill(MyDataTable)

        MyBindingSource.Position = 0
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim cmd As OleDbCommand = New OleDbCommand()
        Dim metal As Boolean

        dbViewer.ClearClient()

        cmd.Connection = dbConnection
        cmd.CommandText = "INSERT INTO " & sTableName _
            & " (marka, model, silnik, kolor, metalic, cena, link) " _
            & "VALUES(@marka, @model, @silnik, @kolor, @metalic, @cena, @link)"
        cmd.CommandType = CommandType.Text

        If txt_metalic.Text = "True" Then
            metal = 1
        Else metal = 0
        End If

        cmd.Parameters.AddWithValue("@marka", txt_marka.Text)
        cmd.Parameters.AddWithValue("@model", txt_model.Text)
        cmd.Parameters.AddWithValue("@silnik", txt_silnik.Text)
        cmd.Parameters.AddWithValue("@kolor", txt_kolor.Text)
        cmd.Parameters.AddWithValue("@metalic", metal)
        cmd.Parameters.AddWithValue("@cena", txt_cena.Text)
        cmd.Parameters.AddWithValue("@link", txt_link.Text)
        'cmd.Parameters.AddWithValue("@id_nb", txt_nb.Text)

        dbConnection.Open()

        cmd.ExecuteNonQuery()

        dbConnection.Close()

        dbAdapter.Fill(MyDataTable)

        MyBindingSource.Position = 0
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim cmd As OleDbCommand = New OleDbCommand()

        dbViewer.ClearClient()

        cmd.Connection = dbConnection
        cmd.CommandText = "DELETE FROM " & sTableName _
            & " WHERE Identyfikator = @id_nb"
        cmd.CommandType = CommandType.Text

        cmd.Parameters.AddWithValue("@id_nb", txt_nb.Text)

        dbConnection.Open()

        cmd.ExecuteNonQuery()

        dbConnection.Close()

        MyDataTable.Clear()
        dbAdapter.Fill(MyDataTable)

        MyBindingSource.Position = 0
    End Sub

    Private Sub btn_first_Click(sender As Object, e As EventArgs) Handles btn_first.Click
        MyBindingSource.Position = 0
    End Sub

    Private Sub btn_previous_Click(sender As Object, e As EventArgs) Handles btn_previous.Click
        MyBindingSource.Position -= 1
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        MyBindingSource.Position += 1
    End Sub

    Private Sub btn_last_Click(sender As Object, e As EventArgs) Handles btn_last.Click
        MyBindingSource.Position = MyBindingSource.Count - 1
    End Sub
End Class