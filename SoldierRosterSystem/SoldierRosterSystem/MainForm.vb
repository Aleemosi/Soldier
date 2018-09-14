Public Class MainForm
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        SoldierForm.MdiParent = Me
        SoldierForm.Show()
        txtToolTitle.Text = "SOLDIER FORM IN PROGRESS..... * LAST FOUR MUST BE FILLED IN"
    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        InfoForm.MdiParent = Me
        InfoForm.Show()
        txtToolTitle.Text = "SOLDIER'S INFORMATION FORM IN PROGRESS....."
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        LicenseForm.MdiParent = Me
        LicenseForm.Show()
        txtToolTitle.Text = "SOLDIER'S LICENSE FORM IN PROGRESS....."
    End Sub
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        ProperForm.MdiParent = Me
        ProperForm.Show()
        txtToolTitle.Text = "SOLDIER'S PROPERTY FORM IN PROGRESS....."
    End Sub
    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        RatingForm.MdiParent = Me
        RatingForm.Show()
        txtToolTitle.Text = "SOLDIER'S RATING SCHEME FORM IN PROGRESS....."
    End Sub
    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        NcoForm.MdiParent = Me
        NcoForm.Show()
        txtToolTitle.Text = "NON-COMMISSION OFFICER EVALUATION FORM IN PROGRESS....."
    End Sub
    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Calc.MdiParent = Me
        Calc.Show()
        txtToolTitle.Text = "BMI CALCULATOR IN PROGRESS......."
    End Sub
    Private Sub LOGGOFFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGGOFFToolStripMenuItem.Click
        AdminLogin.Show()
        Me.Hide()
    End Sub

    Private Sub LOGGOFFToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LOGGOFFToolStripMenuItem1.Click
        Timer1.Stop()
        ToolStripStatusLabel1.Value = 0
        Dim dialog As DialogResult
        txtToolTitle.Text = "LOGGIN OFF....."
        dialog = MessageBox.Show("WOULD YOU LIKE TO LOGG OFF?", "LOGG OFF", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.No Then
            Timer1.Start()
            ToolStripStatusLabel1.PerformStep()
            txtToolTitle.Text = "LOGGED IN... WELCOME TO THE SOLDIER MAIN ROSTER FORM"
        Else
            txtToolTitle.Text = Me.Text = "LOGGED OFF....."
            Splash2.Show()
            Address.Close()
            IndividualSoldier.Close()
            FamReport.Close()
            EmerReport.Close()
            Me.Close()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.PerformStep()
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtToolTitle.Text = "LOGGED IN... WELCOME TO THE SOLDIER MAIN ROSTER FORM"
        Timer1.Start()
        txtToday.Text = Today
        txtTime.Text = TimeOfDay
        MainLogin.MdiParent = Me
        MainLogin.Show()
    End Sub

    Private Sub ABOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTToolStripMenuItem.Click
        About.MdiParent = Me
        About.Show()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        MEdForm.MdiParent = Me
        MEdForm.Show()
        txtToolTitle.Text = "MEDPROS FORM IN PROGRESS......."
    End Sub
End Class