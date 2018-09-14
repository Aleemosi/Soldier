<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FamReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FamReport))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Soldier_RosterDataSet = New SoldierRosterSystem.Soldier_RosterDataSet()
        Me.tblFamilyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblFamilyTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblFamilyTableAdapter()
        Me.tblSoldierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblSoldierTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblSoldierTableAdapter()
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblFamilyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblSoldierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblFamilyBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.tblSoldierBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SoldierRosterSystem.FamilyReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(911, 787)
        Me.ReportViewer1.TabIndex = 0
        '
        'Soldier_RosterDataSet
        '
        Me.Soldier_RosterDataSet.DataSetName = "Soldier_RosterDataSet"
        Me.Soldier_RosterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tblFamilyBindingSource
        '
        Me.tblFamilyBindingSource.DataMember = "tblFamily"
        Me.tblFamilyBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'tblFamilyTableAdapter
        '
        Me.tblFamilyTableAdapter.ClearBeforeFill = True
        '
        'tblSoldierBindingSource
        '
        Me.tblSoldierBindingSource.DataMember = "tblSoldier"
        Me.tblSoldierBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'tblSoldierTableAdapter
        '
        Me.tblSoldierTableAdapter.ClearBeforeFill = True
        '
        'FamReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 787)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FamReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SOLDIER'S FAMILY REPORT"
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblFamilyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblSoldierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblFamilyBindingSource As BindingSource
    Friend WithEvents Soldier_RosterDataSet As Soldier_RosterDataSet
    Friend WithEvents tblSoldierBindingSource As BindingSource
    Friend WithEvents tblFamilyTableAdapter As Soldier_RosterDataSetTableAdapters.tblFamilyTableAdapter
    Friend WithEvents tblSoldierTableAdapter As Soldier_RosterDataSetTableAdapters.tblSoldierTableAdapter
End Class
