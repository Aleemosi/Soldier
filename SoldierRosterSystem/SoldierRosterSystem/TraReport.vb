Public Class TraReport
    Public SpcID As Integer
    Public SoldierID As Integer
    Private Sub TraReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tblTrainingTableAdapter.FillBy(Me.Soldier_RosterDataSet.tblTraining, SoldierID)
        Me.tblSoldierTableAdapter.FillBy(Me.Soldier_RosterDataSet.tblSoldier, SpcID)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.tblTrainingTableAdapter.FillBy1(Me.Soldier_RosterDataSet.tblTraining, DateTimePicker1.Value)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.tblTrainingTableAdapter.FillBy2(Me.Soldier_RosterDataSet.tblTraining, DateTimePicker2.Value)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class