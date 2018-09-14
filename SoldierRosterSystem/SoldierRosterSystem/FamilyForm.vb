Public Class FamilyForm
    Public SpcID As Integer
    Public SoldierID As Integer
    Private Sub FamilyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblSoldier' table. You can move, or remove it, as needed.
        Me.TblSoldierTableAdapter.FillBy(Me.Soldier_RosterDataSet.tblSoldier, SpcID)
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblFamily' table. You can move, or remove it, as needed.
        Me.TblFamilyTableAdapter.FillBy(Me.Soldier_RosterDataSet.tblFamily, SoldierID)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            MessageBox.Show("ADD A NEW FAMILY MEMBER FOR " & RankLastTextBox.Text, "ADD")
            TblFamilyBindingSource.AddNew()
            SoldierIDTextBox.Text = SoldierIDTextBox1.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            Me.Validate()
            Me.TblFamilyBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Soldier_RosterDataSet)
            MessageBox.Show(RankLastTextBox.Text & "'S FAMILY ADDED AND SAVED", "SAVE")
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
            dialog = MessageBox.Show("Would you like to delete " & RankLastTextBox.Text & "'s family from the roster?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Me.TblFamilyBindingSource.RemoveCurrent()
            Me.Validate()
            Me.TblFamilyBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Soldier_RosterDataSet)
            MessageBox.Show("FAMILY ROSTER UPDATED", "UPDATE")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        SoldierForm.MdiParent = MainForm
        SoldierForm.Show()
        Me.Close()
        MainForm.txtToolTitle.Text = "SOLDIER FORM IN PROGRESS....."
    End Sub
End Class