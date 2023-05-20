Public Class Form1
    Public username() = {"user", "123"}, password() As String = {"123", "admin"}
    Public userType As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If uname.Text = "" And pass.Text = "" Then
            MsgBox("Ehter username and password")
            Return
        ElseIf uname.Text = "" Then
            MsgBox("Enter username")
            Return
        ElseIf pass.Text = "" Then
            MsgBox("Enter password")
            Return
        End If

        If uType.SelectedItem.Equals("GUEST") Then
            If uname.Text = username(0) And pass.Text = password(0) Then
                MsgBox("Login success")
                userType = 0
                Me.Hide()
                changePass.Show()
            Else
                MsgBox("wrong username and password")
            End If
        ElseIf uType.SelectedItem.Equals("ADMIN") Then
            If uname.Text = username(1) And pass.Text = password(1) Then
                MsgBox("Login success")
                userType = 1
                Me.Hide()
                changePass.Show()
            Else
                MsgBox("wrong username and password")
            End If
        End If
    End Sub
End Class
