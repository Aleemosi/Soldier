Public Class AddInfo
    Public SpcId As Integer
    Public SoldierID As Integer
    Private Sub AddInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblSoldier' table. You can move, or remove it, as needed.
        Me.TblSoldierTableAdapter.FillBy(Me.Soldier_RosterDataSet.tblSoldier, SpcID)
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblSoldierInfo' table. You can move, or remove it, as needed.
        Me.TblSoldierInfoTableAdapter.FillBy(Me.Soldier_RosterDataSet.tblSoldierInfo, SoldierID)
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            MessageBox.Show("ADD A NEW SOLDIER INFORMATION FOR " & RankLastTextBox.Text, "ADD")
            Me.TblSoldierInfoBindingSource.AddNew()
            SoldierIDTextBox.Text = SoldierIDTextBox1.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            Me.Validate()
            Me.TblSoldierInfoBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Soldier_RosterDataSet)
            MessageBox.Show(RankLastTextBox.Text & "'S INFORMATION ADDED AND SAVED", "SAVE")
            InfoForm.MdiParent = MainForm
            InfoForm.Show()
            Me.Close()
            MainForm.txtToolTitle.Text = "SOLDIER'S LICENSE FORM IN PROGRESS....."
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim dialog As DialogResult
        Try
            dialog = MessageBox.Show("Would you like to delete " & RankLastTextBox.Text & "'s information from the roster?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialog = DialogResult.No Then
            Else
                MessageBox.Show(RankLastTextBox.Text & "'S INFORMATION DELETED", "DELETE")
                Me.TblSoldierInfoBindingSource.RemoveCurrent()
                Me.Validate()
                Me.TblSoldierInfoBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Soldier_RosterDataSet)
                MessageBox.Show("SOLDIER'S INFORMATION UPDATED", "UPDATE")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        InfoForm.MdiParent = MainForm
        InfoForm.Show()
        Me.Close()
        MainForm.txtToolTitle.Text = "SOLDIER'S LICENSE FORM IN PROGRESS....."
    End Sub
End Class