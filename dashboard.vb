Public Class dashboard
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        Me.Hide()
        login.Show()
    End Sub


End Class