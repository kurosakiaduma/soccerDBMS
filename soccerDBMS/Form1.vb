Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "League administrator" And TextBox1.Text = "admin" Then
            MsgBox("Login successful", MsgBoxStyle.Information, "KPL")
            Visible = False
            home_admin.Visible = True
        ElseIf ComboBox1.Text = "League manager" And TextBox1.Text = "manager" Then
            MsgBox("Login successful", MsgBoxStyle.Information, "KPL")
            Visible = False
            home_manager.Visible = True
        ElseIf ComboBox1.Text = "League referee" And TextBox1.Text = "referee" Then
            MsgBox("Login successful", MsgBoxStyle.Information, "KPL")
            Visible = False
            home_referee.Visible = True
        ElseIf ComboBox1.Text = "League fan" And TextBox1.Text = "fan" Then
            MsgBox("Login successful", MsgBoxStyle.Information, "KPL")
            Visible = False
            home_fan.Visible = True
        ElseIf ComboBox1.Text = "League player" And TextBox1.Text = "player" Then
            MsgBox("Login succesful", MsgBoxStyle.Information, "KPL")
            Visible = False
            home_player.Visible = True
        Else
            MsgBox("Login failed. Try again.", MsgBoxStyle.Critical, "KPL")
        End If
    End Sub
End Class
