Public Class TrainingForm
    Public SpcID As Integer
    Public SoldierID As Integer
    Private Sub TrainingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblSoldier' table. You can move, or remove it, as needed.
        Me.TblSoldierTableAdapter.FillBy(Me.Soldier_RosterDataSet.tblSoldier, SpcID)
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblTraining' table. You can move, or remove it, as needed.
        Me.TblTrainingTableAdapter.FillBy(Me.Soldier_RosterDataSet.tblTraining, SoldierID)
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            MessageBox.Show("ADD NEW TRAINING ENTRY FOR " & RankLastTextBox.Text, "ADD")
            TblTrainingBindingSource.AddNew()
            SoldierIDTextBox.Text = SoldierIDTextBox1.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Me.Validate()
            Me.TblTrainingBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Soldier_RosterDataSet)
            MessageBox.Show(RankLastTextBox.Text & "'S TRAINING ENTRY ADDED AND SAVED", "SAVE")
            SoldierForm.MdiParent = MainForm
            SoldierForm.Show()
            Me.Close()
            MainForm.txtToolTitle.Text = "SOLDIER FORM IN PROGRESS....."
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim dialog As DialogResult
        Try
            dialog = MessageBox.Show("Would you like to delete " & RankLastTextBox.Text & "' training entry?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialog = DialogResult.No Then
            Else
                MessageBox.Show(RankLastTextBox.Text & "'S TRAINING DELETED", "DELETE")
                Me.TblTrainingBindingSource.RemoveCurrent()
                Me.Validate()
                Me.TblTrainingBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Soldier_RosterDataSet)
                MessageBox.Show("TRAINING ROSTER UPDATED", "UPDATE")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        SoldierForm.MdiParent = MainForm
        SoldierForm.Show()
        Me.Close()
        MainForm.txtToolTitle.Text = "SOLDIER FORM IN PROGRESS....."
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        TraReport.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, num3, num As Integer
        num1 = Val(PushUpsTextBox.Text)
        num2 = Val(SitUpsTextBox.Text)
        num3 = Val(TwoMileRunTextBox.Text)
        num = (num1) + (num2) + (num3)
        PTScoreTextBox.Text = num
        If num >= 180 Then
            PASSFAILTextBox.Text = "PASS"
        End If
        If PTScoreTextBox.Text < 180 Or PushUpsTextBox.Text < 60 Or SitUpsTextBox.Text < 60 Or TwoMileRunTextBox.Text < 60 Then
            PASSFAILTextBox.Text = "FAIL"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If QualScoreTextBox.Text >= 23 And QualScoreTextBox.Text <= 29 Then
            AwardTextBox.Text = "MARKSMANSHIP"
        ElseIf QualScoreTextBox.Text >= 30 And QualScoreTextBox.Text <= 35 Then
            AwardTextBox.Text = "SHARPSHOOTER"
        ElseIf QualScoreTextBox.Text >= 36 And QualScoreTextBox.Text <= 40 Then
            AwardTextBox.Text = "EXPERT"
        Else
            AwardTextBox.Text = "NO BADGE"
        End If
    End Sub
End Class