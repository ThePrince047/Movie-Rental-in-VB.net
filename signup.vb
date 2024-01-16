Public Class signup


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub signupSubmitBtn_Click(sender As Object, e As EventArgs) Handles signupSubmitBtn.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2PictureBox4_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox4.Click
        Application.Exit()
    End Sub
End Class