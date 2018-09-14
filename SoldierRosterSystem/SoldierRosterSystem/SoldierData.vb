Public Class SoldierData
    Private Sub SoldierData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblSoldier' table. You can move, or remove it, as needed.
        Me.TblSoldierTableAdapter.Fill(Me.Soldier_RosterDataSet.tblSoldier)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SoldierForm.MdiParent = MainForm
        SoldierForm.Show()
        Me.Close()
        MainForm.txtToolTitle.Text = "SOLDIER FORM IN PROGRESS..... * LAST FOUR MUST BE FILLED IN"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Address.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        IndividualSoldier.Show()
    End Sub
End Class