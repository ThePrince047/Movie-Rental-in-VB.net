Public Class dashboard
    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        login.Show()
        Me.Hide()
    End Sub
    Sub childform(ByVal panel As Form)
        pnlMain.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        pnlMain.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        childform(signup)
    End Sub
End Class