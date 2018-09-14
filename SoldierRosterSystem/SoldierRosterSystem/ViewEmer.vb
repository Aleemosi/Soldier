Public Class ViewEmer
    Public SpcID As Integer
    Public SoldierID As Integer
    Private Sub ViewEmer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblSoldier' table. You can move, or remove it, as needed.
        Me.TblSoldierTableAdapter.FillBy(Me.Soldier_RosterDataSet.tblSoldier, SpcID)
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblEmergency' table. You can move, or remove it, as needed.
        Me.TblEmergencyTableAdapter.FillBy(Me.Soldier_RosterDataSet.tblEmergency, SoldierID)
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        SoldierForm.MdiParent = MainForm
        SoldierForm.Show()
        Me.Close()
        MainForm.txtToolTitle.Text = "SOLDIER FORM IN PROGRESS....."
    End Sub
End Class