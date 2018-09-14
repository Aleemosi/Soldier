Public Class AddNco
    Public SpcID As Integer
    Public SoldierID As Integer
    Private Sub AddNco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblSoldier' table. You can move, or remove it, as needed.
        Me.TblSoldierTableAdapter.FillBy(Me.Soldier_RosterDataSet.tblSoldier, SpcID)
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblNCOER' table. You can move, or remove it, as needed.
        Me.TblNCOERTableAdapter.FillBy(Me.Soldier_RosterDataSet.tblNCOER, SoldierID)
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            MessageBox.Show("ADD A NEW NCO EVALUATION DATES FOR " & RankLastTextBox.Text, "ADD")
            TblNCOERBindingSource.AddNew()
            SoldierIDTextBox.Text = SoldierIDTextBox1.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim FinalD As New DateTimePicker
        FinalNCOERDateTimePicker = FinalD
        Try
            FinalD = FourthQuaterDateTimePicker
            Me.Validate()
            Me.TblNCOERBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Soldier_RosterDataSet)
            MessageBox.Show(RankLastTextBox.Text & "'S NCO EVALUATION DATES ADDED AND SAVED", "SAVE")
            NcoForm.MdiParent = MainForm
            NcoForm.Show()
            Me.Close()
            MainForm.txtToolTitle.Text = "NON-COMMISSION OFFICER EVALUATION FORM IN PROGRESS....."
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim dialog As DialogResult
        Try
            dialog = MessageBox.Show("Would you like to delete " & RankLastTextBox.Text & "'s NCO evaluation dates?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialog = DialogResult.No Then
            Else
                MessageBox.Show(RankLastTextBox.Text & "'S NCO EVALUATION DATES DELETED", "DELETE")
                TblNCOERBindingSource.RemoveCurrent()
                Me.Validate()
                Me.TblNCOERBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Soldier_RosterDataSet)
                MessageBox.Show("NCO EVALUATION DATES UPDATED", "UPDATE")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        NcoForm.MdiParent = MainForm
        NcoForm.Show()
        Me.Close()
        MainForm.txtToolTitle.Text = "NON-COMMISSION OFFICER EVALUATION FORM IN PROGRESS....."
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim First As Date = FirstQuarterDateTimePicker.Value.Date
        Dim Second As Date = FirstQuarterDateTimePicker.Value.Date
        Dim Third As Date = FirstQuarterDateTimePicker.Value.Date
        First = DateAdd("m", 4, First)
        Second = DateAdd("m", 8, Second)
        Third = DateAdd("m", 12, Third)
        SecondQuaterDateTimePicker.Value = First
        ThirdQuaterDateTimePicker.Value = Second
        FourthQuaterDateTimePicker.Value = Third
        FinalNCOERDateTimePicker.Value = FourthQuaterDateTimePicker.Value
    End Sub
End Class