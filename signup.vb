Public Class signup


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click, closeBtn.Click, signupCloseBtn.Click
        Close()
    End Sub
End Class