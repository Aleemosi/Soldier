<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BMIRe
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BMIRe))
        Me.BMIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SoldierRosterDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Soldier_RosterDataSet = New SoldierRosterSystem.Soldier_RosterDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.srcId = New System.Windows.Forms.CheckBox()
        Me.srcAll = New System.Windows.Forms.CheckBox()
        Me.srcCom = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.schNon = New System.Windows.Forms.CheckBox()
        Me.BMITableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.BMITableAdapter()
        Me.TableAdapterManager = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.TableAdapterManager()
        Me.coLast = New System.Windows.Forms.ComboBox()
        Me.BtnLast = New System.Windows.Forms.Button()
        CType(Me.BMIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoldierRosterDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BMIBindingSource
        '
        Me.BMIBindingSource.DataMember = "BMI"
        Me.BMIBindingSource.DataSource = Me.SoldierRosterDataSetBindingSource
        '
        'SoldierRosterDataSetBindingSource
        '
        Me.SoldierRosterDataSetBindingSource.DataSource = Me.Soldier_RosterDataSet
        Me.SoldierRosterDataSetBindingSource.Position = 0
        '
        'Soldier_RosterDataSet
        '
        Me.Soldier_RosterDataSet.DataSetName = "Soldier_RosterDataSet"
        Me.Soldier_RosterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.BMIBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SoldierRosterSystem.BMIIrep.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 82)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1110, 955)
        Me.ReportViewer1.TabIndex = 2
        '
        'srcId
        '
        Me.srcId.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.srcId.AutoSize = True
        Me.srcId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srcId.Location = New System.Drawing.Point(179, 14)
        Me.srcId.Name = "srcId"
        Me.srcId.Size = New System.Drawing.Size(170, 17)
        Me.srcId.TabIndex = 7
        Me.srcId.Text = "SEARCH BY LAST NAME"
        Me.srcId.UseVisualStyleBackColor = True
        '
        'srcAll
        '
        Me.srcAll.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.srcAll.AutoSize = True
        Me.srcAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srcAll.Location = New System.Drawing.Point(533, 14)
        Me.srcAll.Name = "srcAll"
        Me.srcAll.Size = New System.Drawing.Size(93, 17)
        Me.srcAll.TabIndex = 8
        Me.srcAll.Text = "RESET ALL"
        Me.srcAll.UseVisualStyleBackColor = True
        '
        'srcCom
        '
        Me.srcCom.AutoSize = True
        Me.srcCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srcCom.Location = New System.Drawing.Point(6, 19)
        Me.srcCom.Name = "srcCom"
        Me.srcCom.Size = New System.Drawing.Size(105, 17)
        Me.srcCom.TabIndex = 9
        Me.srcCom.Text = "COMPLIENCE"
        Me.srcCom.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.schNon)
        Me.GroupBox1.Controls.Add(Me.srcCom)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(641, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 66)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SEARCH BY COMPLIENCE"
        '
        'schNon
        '
        Me.schNon.AutoSize = True
        Me.schNon.Location = New System.Drawing.Point(7, 43)
        Me.schNon.Name = "schNon"
        Me.schNon.Size = New System.Drawing.Size(136, 17)
        Me.schNon.TabIndex = 10
        Me.schNon.Text = "NON COMPLIENCE"
        Me.schNon.UseVisualStyleBackColor = True
        '
        'BMITableAdapter
        '
        Me.BMITableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminLoginTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BMITableAdapter = Me.BMITableAdapter
        Me.TableAdapterManager.MainLoginTableAdapter = Nothing
        Me.TableAdapterManager.tblEmergencyTableAdapter = Nothing
        Me.TableAdapterManager.tblFamilyTableAdapter = Nothing
        Me.TableAdapterManager.tblLicenseTableAdapter = Nothing
        Me.TableAdapterManager.tblNCOERTableAdapter = Nothing
        Me.TableAdapterManager.tblPropertyTableAdapter = Nothing
        Me.TableAdapterManager.tblRatingTableAdapter = Nothing
        Me.TableAdapterManager.tblSoldierInfoTableAdapter = Nothing
        Me.TableAdapterManager.tblSoldierTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainingTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'coLast
        '
        Me.coLast.DataSource = Me.BMIBindingSource
        Me.coLast.DisplayMember = "RanLast"
        Me.coLast.FormattingEnabled = True
        Me.coLast.Location = New System.Drawing.Point(326, 37)
        Me.coLast.Name = "coLast"
        Me.coLast.Size = New System.Drawing.Size(222, 21)
        Me.coLast.TabIndex = 11
        '
        'BtnLast
        '
        Me.BtnLast.Location = New System.Drawing.Point(179, 37)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(138, 23)
        Me.BtnLast.TabIndex = 12
        Me.BtnLast.Text = "SEARCH BY LAST NAME"
        Me.BtnLast.UseVisualStyleBackColor = True
        '
        'BMIRe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 1039)
        Me.Controls.Add(Me.BtnLast)
        Me.Controls.Add(Me.coLast)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.srcAll)
        Me.Controls.Add(Me.srcId)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BMIRe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BMI REPORT"
        CType(Me.BMIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoldierRosterDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SoldierRosterDataSetBindingSource As BindingSource
    Friend WithEvents Soldier_RosterDataSet As Soldier_RosterDataSet
    Friend WithEvents BMIBindingSource As BindingSource
    Friend WithEvents BMITableAdapter As Soldier_RosterDataSetTableAdapters.BMITableAdapter
    Friend WithEvents TableAdapterManager As Soldier_RosterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents srcId As CheckBox
    Friend WithEvents srcAll As CheckBox
    Friend WithEvents srcCom As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents schNon As CheckBox
    Friend WithEvents coLast As ComboBox
    Friend WithEvents BtnLast As Button
End Class
