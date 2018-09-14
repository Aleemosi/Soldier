Public Class EmerForm
    Public SpcID As Integer
    Public SoldierID As Integer
    Private Sub EmerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblSoldier' table. You can move, or remove it, as needed.
        Me.TblSoldierTableAdapter.FillBy(Me.Soldier_RosterDataSet.tblSoldier, SpcID)
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblEmergency' table. You can move, or remove it, as needed.
        Me.TblEmergencyTableAdapter.FillBy(Me.Soldier_RosterDataSet.tblEmergency, SoldierID)
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            MessageBox.Show("ADD A NEW EMERGENCY CONTACT FOR " & RankLastTextBox.Text, "ADD")
            Me.TblEmergencyBindingSource.AddNew()
            SoldierIDTextBox.Text = SoldierIDTextBox1.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            Me.Validate()
            Me.TblEmergencyBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Soldier_RosterDataSet)
            MessageBox.Show(RankLastTextBox.Text & "'S EMERGENCY CONTACT ADDED AND SAVED", "SAVE")
            SoldierForm.MdiParent = MainForm
            SoldierForm.Show()
            Me.Close()
            MainForm.txtToolTitle.Text = "SOLDIER FORM IN PROGRESS....."
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim dialog As DialogResult
        Try
            dialog = MessageBox.Show("Would like to delete " & RankLastTextBox.Text & "'s emergency contact from the roster?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialog = DialogResult.No Then
            Else
                MessageBox.Show(RankLastTextBox.Text & "'S EMERGENCY CONTACT DELETED", "DELETE")
                Me.TblEmergencyBindingSource.RemoveCurrent()
                Me.Validate()
                Me.TblEmergencyBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Soldier_RosterDataSet)
                MessageBox.Show("EMERGENCY CONTACT UPDATED", "UPDATE")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        SoldierForm.MdiParent = MainForm
        SoldierForm.Show()
        Me.Close()
        MainForm.txtToolTitle.Text = "SOLDIER FORM IN PROGRESS....."
    End Sub
End Class