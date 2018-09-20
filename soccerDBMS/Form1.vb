Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "League administrator" And TextBox1.Text = "admin" Then
            MsgBox("Login successful", MsgBoxStyle.Information, "KPL")
        Else
            MsgBox("Login failed. Try again.", MsgBoxStyle.Critical, "KPL")
        End If
    End Sub
End Class
