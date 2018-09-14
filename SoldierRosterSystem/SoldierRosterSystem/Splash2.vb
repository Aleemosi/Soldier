﻿Public NotInheritable Class Splash2
    Private Sub Splash2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Left -= 20
    End Sub
    Private Sub tmrFadeIn_Tick(sender As Object, e As EventArgs) Handles tmrFadeIn.Tick
        Me.Opacity = Me.Opacity + 0.01
        If Me.Opacity = 1 Then
            tmrFadeIn.Enabled = False
            tmrWait.Enabled = True
            ProgressBar1.PerformStep()
        End If
    End Sub
    Private Sub tmrWait_Tick(sender As Object, e As EventArgs) Handles tmrWait.Tick
        tmrFadeOut.Enabled = True
        tmrFadeIn.Enabled = False
    End Sub
    Private Sub tmrFadeOut_Tick(sender As Object, e As EventArgs) Handles tmrFadeOut.Tick
        Me.Opacity = Me.Opacity - 0.01
        If Me.Opacity < 0.01 Then
            MainLogin.Show()
            Me.Close()
        End If
    End Sub
End Class
