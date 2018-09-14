Public NotInheritable Class About

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myYaer = Year(Now)
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("ABOUT", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = "SOLDIER ROSTER SYSTEM" 'My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = "Copyright © " & myYaer 'My.Application.Info.Copyright
        Me.LabelCompanyName.Text = "W S && DBS DESIGNS" 'My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = "DESCRIPTION" & vbCrLf & "" & vbCrLf & "THIS PROGRAM IS COPYRIGHTED BY LAWS" & vbCrLf &
            "THIS PROGRAM IS INTENDED FOR INTERNAL USE ONLY" & vbCrLf & "INFORMATION THAT IS STORED IN THE DATABASE ARE TO BE" & vbCrLf &
            "KEPT CONFIDENTIAL AND PRIVATE" & vbCrLf & "ALL PERSONEL HAVING ACCESS TO THIS PROGRAM IS SUBJECT" & vbCrLf &
            "TO HAVING A SECRET CLEARENCE" & vbCrLf & "W S & DBS IS NOT RESPONSIBLE FOR DATA LOST OR STOLEN" & vbCrLf & "USE ON OWN DISCRETION" & vbCrLf & "" & vbCrLf &
            "FOR QUESTIONS OR CONCERNS" & vbCrLf & "PLEASE EMAIL US AT" & vbCrLf & "LORALLC@HOTMAIL.COM" 'My.Application.Info.Description
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub
End Class
