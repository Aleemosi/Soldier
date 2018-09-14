Public Class DescForm
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If chkYesGlass.Checked Then
            AddMed.GlassTextBox.Text = "YES"
        End If
        If chkNoGlass.Checked Then
            AddMed.GlassTextBox.Text = "NO"
        End If
        If chkYesNBC.Checked Then
            AddMed.NBCGlassTextBox.Text = "YES"
        End If
        If chkNoNBC.Checked Then
            AddMed.NBCGlassTextBox.Text = "NO"
        End If
        If chkYesDep.Checked Then
            AddMed.DeployableTextBox.Text = "YES"
        End If
        If chkNoDep.Checked Then
            AddMed.DeployableTextBox.Text = "NO"
        End If
        Me.Close()
    End Sub
End Class