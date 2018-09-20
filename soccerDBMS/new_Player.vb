Public Class new_Player
    Private Sub TblPlayersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblPlayersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbKPLDataSet)

    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Me.Validate()
        Me.TblPlayersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbKPLDataSet)
        MsgBox("New player saved", MsgBoxStyle.Information, "KPL")
    End Sub

    Private Sub new_Player_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
        'TODO: This line of code loads data into the 'DbKPLDataSet.tblPositions' table. You can move, or remove it, as needed.
        Me.TblPositionsTableAdapter.Fill(Me.DbKPLDataSet.tblPositions)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class