Imports System.Data.OleDb

Public Class newPlayer
    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()

    End Sub

    Private Sub newPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source"
        datafile = "C:\Users\Tevin\Documents\Visual Studio 2017\Projects\soccerDBMS\db\dbKPL.mdb"
        connString = provider & datafile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "Insert into items([ID][First_name][Last_name][DoB][Position][Cleansheets][Goals scored][Goals assisted][Yellow cards][Red cards][Blocks][Interceptions][Clearences]) Values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("ID", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("First_name", CType(TextBox1.Text, String)))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            TextBox1.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = False
        Form1.Visible = True
    End Sub
End Class