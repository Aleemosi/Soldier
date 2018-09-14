Public Class SoldierPrint
    Private Sub SoldierPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblSoldier' table. You can move, or remove it, as needed.
        Me.tblSoldierTableAdapter.Fill(Me.Soldier_RosterDataSet.tblSoldier)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub SoldierPrint_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainForm.txtToolTitle.Text = "SOLDIER'S DATA FORM"
    End Sub
End Class