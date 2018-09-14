Public Class Address
    Private Sub Address_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblSoldier' table. You can move, or remove it, as needed.
        Me.tblSoldierTableAdapter.Fill(Me.Soldier_RosterDataSet.tblSoldier)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class