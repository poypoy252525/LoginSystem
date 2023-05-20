Public Class changePass
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If uname.Text = Form1.username(Form1.userType) And pass.Text = Form1.password(Form1.userType) Then
            Form1.password(Form1.userType) = newPass.Text
            MsgBox("New password saved")
        Else
            MsgBox("wrong username and password")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()

    End Sub
End Class