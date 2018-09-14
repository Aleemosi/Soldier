Public Class MedReport
    Public SoldierID As Integer
    Public SpcID As Integer
    Private Sub MedReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblSoldier' table. You can move, or remove it, as needed.
        Me.tblSoldierTableAdapter.FillBy(Me.Soldier_RosterDataSet.tblSoldier, SpcID)
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblmedpros' table. You can move, or remove it, as needed.
        Me.tblmedprosTableAdapter.FillBy(Me.Soldier_RosterDataSet.tblmedpros, SoldierID)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class