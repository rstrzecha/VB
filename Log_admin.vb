Public Class Log_admin

    Inherits Form

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "admin" Then
            Me.Close()
            dbViewer.ShowAdminBox()
        ElseIf UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Nie podano użytkownika i/lub hasła", MsgBoxStyle.Critical, "Błąd logowania")
            Show()
        Else
            MsgBox("Nieprawidłowe dane logowania", MsgBoxStyle.Critical, "Błąd logowania")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
