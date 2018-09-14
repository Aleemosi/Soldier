Public Class NCOEReport

    Private Sub NCOEReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblRating' table. You can move, or remove it, as needed.
        Me.tblRatingTableAdapter.FillByNCOER(Me.Soldier_RosterDataSet.tblRating, NcoForm.RankLastTextBox.Text)
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblNCOER' table. You can move, or remove it, as needed.
        Me.tblNCOERTableAdapter.FillByNCOER1(Me.Soldier_RosterDataSet.tblNCOER, NcoForm.RankLastTextBox.Text)
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblSoldier' table. You can move, or remove it, as needed.
        Me.tblSoldierTableAdapter.FillByName(Me.Soldier_RosterDataSet.tblSoldier, NcoForm.RankLastTextBox.Text)
        TextBox1.Text = CType(NcoForm.TblNCOERDataGridView.CurrentRow.Cells(5).Value, Date)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.tblNCOERTableAdapter.FillBy1(Me.Soldier_RosterDataSet.tblNCOER, CType(NcoForm.TblNCOERDataGridView.CurrentRow.Cells(0).Value, Integer))
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class