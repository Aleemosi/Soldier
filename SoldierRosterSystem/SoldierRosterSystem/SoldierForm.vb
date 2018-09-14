Public Class SoldierForm
    Private Sub SoldierForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblFamily' table. You can move, or remove it, as needed.
        Me.TblFamilyTableAdapter.Fill(Me.Soldier_RosterDataSet.tblFamily)
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblSoldier' table. You can move, or remove it, as needed.
        Me.TblSoldierTableAdapter.Fill(Me.Soldier_RosterDataSet.tblSoldier)
        If txtMaritalStatus.Text = "MARRIED" Then
            MarriedCheckBox.Checked = True
        End If
        If txtMaritalStatus.Text = "SINGLE" Then
            SingleCheckBox.Checked = True
        End If
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            MessageBox.Show("ADD A NEW SOLDIER", "ADD")
            TblSoldierBindingSource.AddNew()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim title As New TextBox
        title.Text = RankLastTextBox.Text
        RankLastTextBox.Text = RankTextBox.Text & " " & LastNameTextBox.Text & ", " & FirstNameTextBox.Text
        SpcIDTextBox.Text = txtNumber.Text
        Try
            If MarriedCheckBox.Checked Then
                txtMaritalStatus.Text = "MARRIED"
                Me.Validate()
                Me.TblSoldierBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Soldier_RosterDataSet)
                MessageBox.Show(RankLastTextBox.Text & " ADDED AND SAVED", "SAVE")
                MessageBox.Show("SOLDIER IS MARRIED. PLEASE ADD DEPENDENTS FOR " & RankLastTextBox.Text, "FAMILY FORM")
                FamilyForm.MdiParent = MainForm
                FamilyForm.SoldierID = SoldierIDTextBox.Text
                FamilyForm.SpcID = SpcIDTextBox.Text
                FamilyForm.Show()
                Me.Close()
                MainForm.txtToolTitle.Text = "ADDING FAMILY FOR " & title.Text
            ElseIf SingleCheckBox.Checked Then
                txtMaritalStatus.Text = "SINGLE"
                Me.Validate()
                Me.TblSoldierBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Soldier_RosterDataSet)
                MessageBox.Show(RankLastTextBox.Text & " ADDED AND SAVED", "SAVE")
                Dim dialog As DialogResult
                dialog = MessageBox.Show("DOES " & RankLastTextBox.Text & " HAS DEPENDENTS?", "DEPENDENTS", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialog = DialogResult.No Then
                    MessageBox.Show("The soldier is single. Please add an emergency contact for " & RankLastTextBox.Text, "EMERGENCY CONACT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    EmerForm.MdiParent = MainForm
                    EmerForm.SoldierID = SoldierIDTextBox.Text
                    EmerForm.SpcID = SpcIDTextBox.Text
                    EmerForm.Show()
                    Me.Close()
                    MainForm.txtToolTitle.Text = "ADDING EMERGENCY CONTACT FOR " & title.Text
                Else
                    FamilyForm.MdiParent = MainForm
                    FamilyForm.SoldierID = SoldierIDTextBox.Text
                    FamilyForm.SpcID = SpcIDTextBox.Text
                    FamilyForm.Show()
                    Me.Close()
                    MainForm.txtToolTitle.Text = "ADDING FAMILY FOR " & title.Text
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim dialog As DialogResult
        Try
            dialog = MessageBox.Show("Before deleting this soldier from the roster," & vbCrLf &
                                "Make sure that you delete all related data attahed to this soldier..." & vbCrLf &
                                "Would you like to delete " & RankLastTextBox.Text & " from the roster?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialog = DialogResult.No Then
            Else
                MessageBox.Show("SOLDIER DELETED", "DELETE")
                Me.TblSoldierBindingSource.RemoveCurrent()
                Me.Validate()
                Me.TblSoldierBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Soldier_RosterDataSet)
                MessageBox.Show("ROSTER UPDATED", "UPDATE")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Me.Close()
        MainForm.txtToolTitle.Text = "LOGGED IN... WELCOME TO THE SOLDIER MAIN ROSTER FORM"
    End Sub
    Private Sub FAMILYFORMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FAMILYFORMToolStripMenuItem.Click
        Dim title As New TextBox
        title.Text = RankLastTextBox.Text
        Try
            FamilyForm.MdiParent = MainForm
            FamilyForm.SoldierID = SoldierIDTextBox.Text
            FamilyForm.SpcID = SpcIDTextBox.Text
            FamilyForm.Show()
            Me.Close()
            MainForm.txtToolTitle.Text = "ADDING FAMILY ENTRY FOR " & title.Text
        Catch ex As Exception
            MessageBox.Show("PLEASE ADD A SOLDIER BEFORE CONTINUING", "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub EMERGENCYFORMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EMERGENCYFORMToolStripMenuItem.Click
        Dim title As New TextBox
        title.Text = RankLastTextBox.Text
        Try
            EmerForm.MdiParent = MainForm
            EmerForm.SoldierID = SoldierIDTextBox.Text
            EmerForm.SpcID = SpcIDTextBox.Text
            EmerForm.Show()
            Me.Close()
            MainForm.txtToolTitle.Text = "ADDING EMERGENCY CONTACT FOR " & title.Text
        Catch ex As Exception
            MessageBox.Show("PLEASE ADD A SOLDIER BEFORE CONTINUING", "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim title As New TextBox
        title.Text = RankLastTextBox.Text
        Try
            ViewEmer.MdiParent = MainForm
            ViewEmer.SoldierID = SoldierIDTextBox.Text
            ViewEmer.SpcID = SpcIDTextBox.Text
            ViewEmer.Show()
            Me.Close()
            MainForm.txtToolTitle.Text = title.Text & "'S EMERGENCY DATA TABLE"
        Catch ex As Exception
            MessageBox.Show("PLEASE ADD A SOLDIER BEFORE CONTINUING", "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Dim title As New TextBox
        title.Text = RankLastTextBox.Text
        Try
            TrainingForm.MdiParent = MainForm
            TrainingForm.SoldierID = SoldierIDTextBox.Text
            TrainingForm.SpcID = SpcIDTextBox.Text
            TrainingForm.Show()
            Me.Close()
            MainForm.txtToolTitle.Text = "ADDING TRAINING INFORMATION FOR " & title.Text
        Catch ex As Exception
            MessageBox.Show("PLEASE ADD A SOLDIER BEFORE CONTINUING", "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        SoldierData.MdiParent = MainForm
        SoldierData.Show()
        Me.Close()
        MainForm.txtToolTitle.Text = "SOLDIER'S DATA FORM"
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            FamReport.SoldierID = SoldierIDTextBox.Text
            FamReport.SpcID = SpcIDTextBox.Text
            FamReport.Show()
        Catch ex As Exception
            MessageBox.Show("THERE ARE NO REPORT TO PRINT OR VIEW!" & vbCr & "PLEASE ADD A SOLDIER'S FAMILY DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            EmerReport.SoldierID = SoldierIDTextBox.Text
            EmerReport.SpcID = SpcIDTextBox.Text
            EmerReport.Show()
        Catch ex As Exception
            MessageBox.Show("THERE ARE NO REPORT TO PRINT OR VIEW!" & vbCr & "PLEASE ADD A SOLDIER'S EMERGENCY DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PrintAll.Show()
    End Sub

    Private Sub Pre_Click(sender As Object, e As EventArgs) Handles Pre.Click
        'If txtMaritalStatus.Text = "MARRIED" Then
        '    MarriedCheckBox.Checked = False
        '    SingleCheckBox.Checked = True
        'End If
        'If txtMaritalStatus.Text = "SINGLE" Then
        '    SingleCheckBox.Checked = False
        '    MarriedCheckBox.Checked = True
        'End If
    End Sub

    Private Sub Nxt_Click(sender As Object, e As EventArgs) Handles Nxt.Click
        'If txtMaritalStatus.Text = "MARRIED" Then
        '    MarriedCheckBox.Checked = False
        '    SingleCheckBox.Checked = True
        'End If
        'If txtMaritalStatus.Text = "SINGLE" Then
        '    SingleCheckBox.Checked = False
        '    MarriedCheckBox.Checked = True
        'End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If txtMaritalStatus.Text = "MARRIED" Then
            MarriedCheckBox.Checked = True
            SingleCheckBox.Checked = False
        End If
        If txtMaritalStatus.Text = "SINGLE" Then
            SingleCheckBox.Checked = True
            MarriedCheckBox.Checked = False
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            TraReport.SpcID = SpcIDTextBox.Text
            TraReport.SoldierID = SoldierIDTextBox.Text
            TraReport.Show()
        Catch ex As Exception
            MessageBox.Show("THERE ARE NO REPORT TO PRINT OR VIEW!" & vbCr & "PLEASE ADD A SOLDIER'S EMERGENCY DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class