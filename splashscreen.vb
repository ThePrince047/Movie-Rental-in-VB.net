Public Class splashscreen
    Private Sub splashscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 2
        lb_percent.Text = ProgressBar1.Value & "%"
        If ProgressBar1.Value = 100 Then
            login.Show()
            Me.Hide()
            Timer1.Stop()
            Timer2.Start()
        End If
        If ProgressBar1.Value = 10 Then
            lb_text.Text = "Loading Modules..."
        End If
        If ProgressBar1.Value = 28 Then
            lb_text.Text = "Getting Database..."
        End If
        If ProgressBar1.Value = 48 Then
            lb_text.Text = "Preparing Assets..."
        End If
        If ProgressBar1.Value = 65 Then
            lb_text.Text = "Getting Ready..."
        End If
        If ProgressBar1.Value = 80 Then
            lb_text.Text = "Finishing Up..."
        End If
        If ProgressBar1.Value = 90 Then
            lb_text.Text = "Here You Go !"
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
    End Sub

End Class