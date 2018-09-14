Public Class AdminForm
    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.MainLogin' table. You can move, or remove it, as needed.
        Me.MainLoginTableAdapter.Fill(Me.Soldier_RosterDataSet.MainLogin)
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.AdminLogin' table. You can move, or remove it, as needed.
        Me.AdminLoginTableAdapter.Fill(Me.Soldier_RosterDataSet.AdminLogin)
    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            MetroFramework.MetroMessageBox.Show(Me, "ADD A NEW USER FOR THE ADMIN LOGIN FORM", "ADD")
            Me.AdminLoginBindingSource.AddNew()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try
    End Sub
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            Me.Validate()
            Me.AdminLoginBindingSource.EndEdit()
            Me.AdminLoginTableAdapter.Update(Me.Soldier_RosterDataSet.AdminLogin)
            MetroFramework.MetroMessageBox.Show(Me, "USER ADDED AND SAVED", "SAVE")
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try
    End Sub
    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Dim dialog As DialogResult
        Try
            dialog = MetroFramework.MetroMessageBox.Show(Me, "Would you like to delete the admin user?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialog = DialogResult.No Then
            Else
                MetroFramework.MetroMessageBox.Show(Me, "USER DELETED", "DELETE")
                Me.AdminLoginBindingSource.RemoveCurrent()
                Me.Validate()
                Me.AdminLoginBindingSource.EndEdit()
                Me.AdminLoginTableAdapter.Update(Me.Soldier_RosterDataSet.AdminLogin)
                MetroFramework.MetroMessageBox.Show(Me, "USER AND PASSWORD ADDED AND SAVED", "UDPATE")
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try
    End Sub
    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        AdminLoginBindingSource.MovePrevious()
        MainLoginBindingSource.MovePrevious()
    End Sub
    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        MainForm.Show()
        Me.Close()
    End Sub
    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles MetroButton6.Click
        AdminLoginBindingSource.MoveNext()
        MainLoginBindingSource.MoveNext()
    End Sub
    Private Sub MetroButton7_Click(sender As Object, e As EventArgs) Handles MetroButton7.Click
        Try
            MetroFramework.MetroMessageBox.Show(Me, "ADD A NEW USER FOR THE MAIN LOGIN", "ADD")
            MainLoginBindingSource.AddNew()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try
    End Sub
    Private Sub MetroButton8_Click(sender As Object, e As EventArgs) Handles MetroButton8.Click
        Try
            Me.Validate()
            Me.MainLoginBindingSource.EndEdit()
            Me.MainLoginTableAdapter.Update(Me.Soldier_RosterDataSet.MainLogin)
            MetroFramework.MetroMessageBox.Show(Me, "USER ADDED AND SAVED", "SAVE")
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try
    End Sub
    Private Sub MetroButton9_Click(sender As Object, e As EventArgs) Handles MetroButton9.Click
        Dim dialog As DialogResult
        Try
            dialog = MetroFramework.MetroMessageBox.Show(Me, "Would you like to delete the main login user?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialog = DialogResult.No Then
            Else
                MetroFramework.MetroMessageBox.Show(Me, "USER DELETED", "DELETE")
                Me.MainLoginBindingSource.RemoveCurrent()
                Me.Validate()
                Me.MainLoginBindingSource.EndEdit()
                Me.MainLoginTableAdapter.Update(Me.Soldier_RosterDataSet.MainLogin)
                MetroFramework.MetroMessageBox.Show(Me, "USER AND PASSWORD ADDED AND SAVED", "UDPATE")
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try
    End Sub
End Class