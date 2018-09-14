Public Class AddRating
    Public SoldierID As Integer
    Public SpcID As Integer
    Private Sub AddRating_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblSoldier' table. You can move, or remove it, as needed.
        Me.TblSoldierTableAdapter.FillBy(Me.Soldier_RosterDataSet.tblSoldier, SpcID)
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblRating' table. You can move, or remove it, as needed.
        Me.TblRatingTableAdapter.FillBy(Me.Soldier_RosterDataSet.tblRating, SoldierID)
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            MessageBox.Show("ADD NEW RATING SCHEME FOR " & RankLastTextBox.Text, "ADD")
            Me.TblRatingBindingSource.AddNew()
            SoldierIDTextBox.Text = SoldierIDTextBox1.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            Me.Validate()
            Me.TblRatingBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Soldier_RosterDataSet)
            MessageBox.Show(RankLastTextBox.Text & "'S RATING SCHEME ADDED AND SAVED", "SAVE")
            RatingForm.MdiParent = MainForm
            RatingForm.Show()
            Me.Close()
            MainForm.txtToolTitle.Text = "SOLDIER'S RATING SCHEME FORM IN PROGRESS....."
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim dialog As DialogResult
        Try
            dialog = MessageBox.Show("Would you like to delete " & RankLastTextBox.Text & "'s rating scheme?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialog = DialogResult.No Then
            Else
                MessageBox.Show(RankLastTextBox.Text & "'S RATING SCHEME DELETED", "DELETE")
                Me.TblRatingBindingSource.RemoveCurrent()
                Me.Validate()
                Me.TblRatingBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Soldier_RosterDataSet)
                MessageBox.Show("RATING SCHEME ROSTER UPDATED", "UPDATE")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        RatingForm.MdiParent = MainForm
        RatingForm.Show()
        Me.Close()
        MainForm.txtToolTitle.Text = "SOLDIER'S RATING SCHEME FORM IN PROGRESS....."
    End Sub
End Class