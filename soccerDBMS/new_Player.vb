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
        'TODO: This line of code loads data into the 'DbKPLDataSet.tblPlayers' table. You can move, or remove it, as needed.
        Me.TblPlayersTableAdapter.Fill(Me.DbKPLDataSet.tblPlayers)

    End Sub


End Class