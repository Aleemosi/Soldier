Public Class AddProper
    Public SpcID As Integer
    Public SoldierID As Integer
    Private Sub AddProper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblSoldier' table. You can move, or remove it, as needed.
        Me.TblSoldierTableAdapter.FillBy(Me.Soldier_RosterDataSet.tblSoldier, SpcID)
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblProperty' table. You can move, or remove it, as needed.
        Me.TblPropertyTableAdapter.FillBy(Me.Soldier_RosterDataSet.tblProperty, SoldierID)
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            MessageBox.Show("ADD A NEW PROPERTY INFORMATION FOR " & RankLastTextBox.Text, "ADD")
            Me.TblPropertyBindingSource.AddNew()
            SoldierIDTextBox.Text = SoldierIDTextBox1.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            Me.Validate()
            Me.TblPropertyBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Soldier_RosterDataSet)
            MessageBox.Show(RankLastTextBox.Text & "'S PROPERTY INFORMATION ADDED AND SAVED", "SAVE")
            ProperForm.MdiParent = MainForm
            ProperForm.Show()
            Me.Close()
            MainForm.txtToolTitle.Text = "SOLDIER'S PROPERTY FORM IN PROGRESS....."
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim dialog As DialogResult
        Try
            dialog = MessageBox.Show("Would you like to delete " & RankLastTextBox.Text & "'s property information?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialog = DialogResult.No Then
            Else
                MessageBox.Show(RankLastTextBox.Text & "'S INFORMATION DELETED", "DELETE")
                TblPropertyBindingSource.RemoveCurrent()
                Me.Validate()
                Me.TblPropertyBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Soldier_RosterDataSet)
                MessageBox.Show("PROPERTY INFORMATION UPDATED", "UPDATE")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        ProperForm.MdiParent = MainForm
        ProperForm.Show()
        Me.Close()
        MainForm.txtToolTitle.Text = "SOLDIER'S PROPERTY FORM IN PROGRESS....."
    End Sub
End Class