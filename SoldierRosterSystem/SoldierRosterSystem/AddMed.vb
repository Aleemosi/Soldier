Public Class AddMed
    Public SpcID As Integer
    Public SoldierID As Integer

    Private Sub AddMed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblSoldier' table. You can move, or remove it, as needed.
        Me.TblSoldierTableAdapter.FillBy(Me.Soldier_RosterDataSet.tblSoldier, SpcID)
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblmedpros' table. You can move, or remove it, as needed.
        Me.TblmedprosTableAdapter.FillBy(Me.Soldier_RosterDataSet.tblmedpros, SoldierID)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            MessageBox.Show("ADD NEW MEDPORS FOR " & RankLastTextBox.Text, "ADD")
            TblmedprosBindingSource.AddNew()
            SoldierIDTextBox.Text = SoldierIDTextBox1.Text
            DescForm.MdiParent = MainForm
            DescForm.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            Me.Validate()
            Me.TblmedprosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Soldier_RosterDataSet)
            MessageBox.Show(RankLastTextBox.Text & "'S MEDPROS ADDED AND SAVED", "SAVE")
            MEdForm.MdiParent = MainForm
            MEdForm.Show()
            Me.Close()
            MainForm.txtToolTitle.Text = "MEDPROS FORM IN PROGRESS....."
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim dialog As DialogResult
        Try
            dialog = MessageBox.Show("Would you like to delete " & RankLastTextBox.Text & "'s MEDPROS?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialog = DialogResult.No Then
            Else
                MessageBox.Show(RankLastTextBox.Text & "'S NCO EVALUATION DATES DELETED", "DELETE")
                TblmedprosBindingSource.RemoveCurrent()
                Me.Validate()
                Me.TblmedprosBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Soldier_RosterDataSet)
                MessageBox.Show("MEDPROS UPDATED", "UPDATE")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        MEdForm.MdiParent = MainForm
        MEdForm.Show()
        Me.Close()
        MainForm.txtToolTitle.Text = "MEDPROS FORM IN PROGRESS....."
    End Sub
End Class