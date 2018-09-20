Public Class mainBG
    Private Sub mainBG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(3)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            Form1.Visible = True
        End If
    End Sub
End Class