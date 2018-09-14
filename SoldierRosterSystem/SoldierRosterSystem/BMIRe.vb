Public Class BMIRe
    Private Sub BMIRe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Soldier_RosterDataSet.BMI' table. You can move, or remove it, as needed.
        Me.BMITableAdapter.Fill(Me.Soldier_RosterDataSet.BMI)
        Me.ReportViewer1.RefreshReport()
        BtnLast.Visible = False
        coLast.Visible = False
    End Sub
    Private Sub srcId_CheckedChanged(sender As Object, e As EventArgs) Handles srcId.CheckedChanged
        Try
            If srcId.Checked Then
                BtnLast.Visible = True
                coLast.Visible = True
                srcAll.Checked = False
                srcCom.Checked = False
                schNon.Checked = False
            ElseIf srcId.Checked = False Then
                BtnLast.Visible = False
                coLast.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub srcAll_CheckedChanged(sender As Object, e As EventArgs) Handles srcAll.CheckedChanged
        If srcAll.Checked Then
            Me.BMITableAdapter.Fill(Me.Soldier_RosterDataSet.BMI)
            Me.ReportViewer1.RefreshReport()
            srcId.Checked = False
            srcCom.Checked = False
            schNon.Checked = False
            BtnLast.Visible = False
            coLast.Visible = False
        End If

    End Sub

    Private Sub srcCom_CheckedChanged(sender As Object, e As EventArgs) Handles srcCom.CheckedChanged
        Try
            If srcCom.Checked Then
                Me.BMITableAdapter.FillByComp(Me.Soldier_RosterDataSet.BMI)
                Me.ReportViewer1.RefreshReport()
                srcAll.Checked = False
                srcId.Checked = False
                schNon.Checked = False
                BtnLast.Visible = False
                coLast.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub schNon_CheckedChanged(sender As Object, e As EventArgs) Handles schNon.CheckedChanged
        Try
            If schNon.Checked Then
                Me.BMITableAdapter.FillByNon(Me.Soldier_RosterDataSet.BMI)
                Me.ReportViewer1.RefreshReport()
                srcAll.Checked = False
                srcCom.Checked = False
                srcId.Checked = False
                BtnLast.Visible = False
                coLast.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles BtnLast.Click
        Me.BMITableAdapter.FillBy1(Me.Soldier_RosterDataSet.BMI, coLast.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class