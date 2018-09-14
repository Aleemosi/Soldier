Imports System.Data.OleDb
Public Class AdminLogin
    Private conn As OleDbConnection
    Private dapt As OleDbDataAdapter
    Private Sub MyConnection()
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Soldier Roster.accdb")
        conn.Open()
    End Sub
    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyConnection()
    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim tbl As New DataTable
        MyConnection()
        dapt = New OleDbDataAdapter("Select * From AdminLogin Where UserName='" & txtUserName.Text & "' and Password='" & txtPassword.Text & "'", conn)
        dapt.Fill(tbl)
        If tbl.Rows.Count > 0 Then
            MetroFramework.MetroMessageBox.Show(Me, "YOU ARE LOGGIN!", "LOGIN")
            AdminForm.Show()
            Me.Close()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "SORRY..USER AND OR PASSWORD ARE WRONG!")
            txtUserName.Clear()
            txtPassword.Clear()
        End If
    End Sub
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        MainForm.Show()
        Me.Close()
    End Sub
End Class