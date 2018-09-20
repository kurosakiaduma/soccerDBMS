Public Class home_admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("You are about to logout of the system, are you sure?", MsgBoxStyle.YesNo, "KPL")
        If MsgBoxResult.Yes Then
            Close()
            Form1.Show()
        End If
    End Sub
End Class