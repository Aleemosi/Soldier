Public Class MEdForm
    Private Sub MEdForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblmedpros' table. You can move, or remove it, as needed.
        Me.TblmedprosTableAdapter.Fill(Me.Soldier_RosterDataSet.tblmedpros)
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblSoldier' table. You can move, or remove it, as needed.
        Me.TblSoldierTableAdapter.Fill(Me.Soldier_RosterDataSet.tblSoldier)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Dim title As New TextBox
            title.Text = RankLastTextBox.Text
            AddMed.MdiParent = MainForm
            AddMed.SoldierID = SoldierIDTextBox.Text
            AddMed.SpcID = SpcIDTextBox.Text
            AddMed.Show()
            Me.Close()
            MainForm.txtToolTitle.Text = "ADDING MEDPROS FOR " & title.Text
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
        Try
            MedReport.SoldierID = SoldierIDTextBox.Text
            MedReport.SpcID = SpcIDTextBox.Text
            MedReport.Show()
        Catch ex As Exception
            MessageBox.Show("THERE ARE NO REPORT TO PRINT OR VIEW!" & vbCr & "PLEASE ADD A SOLDIER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class