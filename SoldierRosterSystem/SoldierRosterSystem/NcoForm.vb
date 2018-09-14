Public Class NcoForm
    Private Sub NcoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblNCOER' table. You can move, or remove it, as needed.
        Me.TblNCOERTableAdapter.Fill(Me.Soldier_RosterDataSet.tblNCOER)
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblSoldier' table. You can move, or remove it, as needed.
        Me.TblSoldierTableAdapter.Fill(Me.Soldier_RosterDataSet.tblSoldier)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Dim title As New TextBox
            title.Text = RankLastTextBox.Text
            AddNco.MdiParent = MainForm
            AddNco.SoldierID = SoldierIDTextBox.Text
            AddNco.SpcID = SpcIDTextBox.Text
            AddNco.Show()
            Me.Close()
            MainForm.txtToolTitle.Text = "ADDING NON-COMMISSIONED OFFICER EVALUATION DATES FOR " & title.Text
        Catch ex As Exception
            MessageBox.Show("PLEASE ADD A SOLDIER BEFORE CONTINUING" & vbCrLf & "REDIRECTING YOU TO THE SOLDIER FORM", "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SoldierForm.MdiParent = MainForm
            SoldierForm.Show()
            Me.Close()
            MainForm.txtToolTitle.Text = "SOLDIER FORM IN PROGRESS....."
        End Try
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
        MainForm.txtToolTitle.Text = "LOGGED IN... WELCOME TO THE SOLDIER MAIN ROSTER FORM"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NCOEReport.Show()
    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
    End Sub
End Class