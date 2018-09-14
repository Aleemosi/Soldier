﻿Public Class InfoForm
    Private Sub InfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblSoldierInfo' table. You can move, or remove it, as needed.
        Me.TblSoldierInfoTableAdapter.Fill(Me.Soldier_RosterDataSet.tblSoldierInfo)
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.tblSoldier' table. You can move, or remove it, as needed.
        Me.TblSoldierTableAdapter.Fill(Me.Soldier_RosterDataSet.tblSoldier)
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Dim title As New TextBox
            title.Text = RankLastTextBox.Text
            AddInfo.MdiParent = MainForm
            AddInfo.SoldierID = SoldierIDTextBox.Text
            AddInfo.SpcId = SpcIDTextBox.Text
            AddInfo.Show()
            Me.Close()
            MainForm.txtToolTitle.Text = "ADDING SOLDIER'S INFORMATION FOR " & title.Text
        Catch ex As Exception
            MessageBox.Show("PLEASE ADD A SOLDIER BEFORE CONTINUING" & vbCrLf & "REDIRECTING YOU TO THE SOLDIER FORM", "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SoldierForm.MdiParent = MainForm
            SoldierForm.Show()
            Me.Close()
            MainForm.txtToolTitle.Text = "SOLDIER FORM IN PROGRESS....."
        End Try
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
        MainForm.txtToolTitle.Text = "LOGGED IN... WELCOME TO THE SOLDIER MAIN ROSTER FORM"
    End Sub
End Class