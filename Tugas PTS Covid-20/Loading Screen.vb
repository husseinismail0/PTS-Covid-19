Public Class Loading_Screen

    Private Sub Loading_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 1
        Else
            Timer1.Stop()
            Me.Hide()
            Form1.Show()
        End If
    End Sub
End Class