<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DescForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkYesGlass = New System.Windows.Forms.CheckBox()
        Me.chkNoGlass = New System.Windows.Forms.CheckBox()
        Me.chkYesNBC = New System.Windows.Forms.CheckBox()
        Me.chkNoNBC = New System.Windows.Forms.CheckBox()
        Me.chkYesDep = New System.Windows.Forms.CheckBox()
        Me.chkNoDep = New System.Windows.Forms.CheckBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkYesGlass)
        Me.GroupBox1.Controls.Add(Me.chkNoGlass)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 68)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DOES SOLDIER WEAR GLASSES?"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkYesNBC)
        Me.GroupBox2.Controls.Add(Me.chkNoNBC)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(251, 68)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DOES SOLDIER WEAR NBC GLASSES?"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkNoDep)
        Me.GroupBox3.Controls.Add(Me.chkYesDep)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 160)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(251, 68)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "IS SOLDIER DEPLOYABLE?"
        '
        'chkYesGlass
        '
        Me.chkYesGlass.AutoSize = True
        Me.chkYesGlass.Location = New System.Drawing.Point(6, 19)
        Me.chkYesGlass.Name = "chkYesGlass"
        Me.chkYesGlass.Size = New System.Drawing.Size(50, 17)
        Me.chkYesGlass.TabIndex = 3
        Me.chkYesGlass.Text = "YES"
        Me.chkYesGlass.UseVisualStyleBackColor = True
        '
        'chkNoGlass
        '
        Me.chkNoGlass.AutoSize = True
        Me.chkNoGlass.Location = New System.Drawing.Point(6, 42)
        Me.chkNoGlass.Name = "chkNoGlass"
        Me.chkNoGlass.Size = New System.Drawing.Size(44, 17)
        Me.chkNoGlass.TabIndex = 4
        Me.chkNoGlass.Text = "NO"
        Me.chkNoGlass.UseVisualStyleBackColor = True
        '
        'chkYesNBC
        '
        Me.chkYesNBC.AutoSize = True
        Me.chkYesNBC.Location = New System.Drawing.Point(6, 19)
        Me.chkYesNBC.Name = "chkYesNBC"
        Me.chkYesNBC.Size = New System.Drawing.Size(50, 17)
        Me.chkYesNBC.TabIndex = 3
        Me.chkYesNBC.Text = "YES"
        Me.chkYesNBC.UseVisualStyleBackColor = True
        '
        'chkNoNBC
        '
        Me.chkNoNBC.AutoSize = True
        Me.chkNoNBC.Location = New System.Drawing.Point(6, 42)
        Me.chkNoNBC.Name = "chkNoNBC"
        Me.chkNoNBC.Size = New System.Drawing.Size(44, 17)
        Me.chkNoNBC.TabIndex = 4
        Me.chkNoNBC.Text = "NO"
        Me.chkNoNBC.UseVisualStyleBackColor = True
        '
        'chkYesDep
        '
        Me.chkYesDep.AutoSize = True
        Me.chkYesDep.Location = New System.Drawing.Point(6, 16)
        Me.chkYesDep.Name = "chkYesDep"
        Me.chkYesDep.Size = New System.Drawing.Size(50, 17)
        Me.chkYesDep.TabIndex = 0
        Me.chkYesDep.Text = "YES"
        Me.chkYesDep.UseVisualStyleBackColor = True
        '
        'chkNoDep
        '
        Me.chkNoDep.AutoSize = True
        Me.chkNoDep.Location = New System.Drawing.Point(6, 39)
        Me.chkNoDep.Name = "chkNoDep"
        Me.chkNoDep.Size = New System.Drawing.Size(44, 17)
        Me.chkNoDep.TabIndex = 1
        Me.chkNoDep.Text = "NO"
        Me.chkNoDep.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(85, 234)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 3
        Me.btnCheck.Text = "EXIT"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'DescForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 267)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "DescForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SOLDIER STATUS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkYesGlass As CheckBox
    Friend WithEvents chkNoGlass As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkYesNBC As CheckBox
    Friend WithEvents chkNoNBC As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkNoDep As CheckBox
    Friend WithEvents chkYesDep As CheckBox
    Friend WithEvents btnCheck As Button
End Class
