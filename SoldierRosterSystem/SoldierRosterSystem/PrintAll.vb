Public Class PrintAll
    Private Sub PrintAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblSoldierInfo' table. You can move, or remove it, as needed.
        Me.tblSoldierInfoTableAdapter.FillByLast3(Me.Soldier_RosterDataSet.tblSoldierInfo, SoldierForm.RankLastTextBox.Text)
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblProperty' table. You can move, or remove it, as needed.
        Me.tblPropertyTableAdapter.FillByLast1(Me.Soldier_RosterDataSet.tblProperty, SoldierForm.RankLastTextBox.Text)
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblLicense' table. You can move, or remove it, as needed.
        Me.tblLicenseTableAdapter.FillByLast(Me.Soldier_RosterDataSet.tblLicense, SoldierForm.RankLastTextBox.Text)
        Me.tblSoldierTableAdapter.FillByName(Me.Soldier_RosterDataSet.tblSoldier, SoldierForm.RankLastTextBox.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class