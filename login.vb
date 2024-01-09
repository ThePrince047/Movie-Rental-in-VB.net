Imports System.Drawing.Text
Imports System.Reflection.Emit
Public Class login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click, loginSubmitBtn.Click
        dashboard.Show()
        Hide()
    End Sub

    Private Sub signuptxt_Click(sender As Object, e As EventArgs) Handles signuptxt.Click
        signup.Show()
        Me.Hide()
    End Sub


End Class
