Public Class FamReport
    Public SoldierID As Integer
    Public SpcID As Integer
    Private Sub FamReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblFamily' table. You can move, or remove it, as needed.
        Me.tblFamilyTableAdapter.FillBy(Me.Soldier_RosterDataSet.tblFamily, SoldierID)
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblSoldier' table. You can move, or remove it, as needed.
        Me.tblSoldierTableAdapter.FillBy(Me.Soldier_RosterDataSet.tblSoldier, SpcID)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class