Public Class LoginForm
    Private Db As New DBHelper
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = txtUsername.Text
        Dim password = txtPassword.Text

        Dim userId = DBHelper.AuthenticateUser(username, password)
        If userId <> -1 Then
            Dim mainForm As New Calorie_Tracker
            mainForm.userId = userId
            mainForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Username or Password.")
        End If
    End Sub

    Private Sub lnkNewUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkNewUser.LinkClicked
        Db.AddUser(txtUsername.Text, txtPassword.Text)
        MessageBox.Show("User Successfully Added. Please Login.")
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub
End Class
