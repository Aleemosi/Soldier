<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrintAll
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintAll))
        Me.tblSoldierInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Soldier_RosterDataSet = New SoldierRosterSystem.Soldier_RosterDataSet()
        Me.tblTrainingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblPropertyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblLicenseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblSoldierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tblSoldierInfoTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblSoldierInfoTableAdapter()
        Me.tblTrainingTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblTrainingTableAdapter()
        Me.tblPropertyTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblPropertyTableAdapter()
        Me.tblLicenseTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblLicenseTableAdapter()
        Me.tblSoldierTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblSoldierTableAdapter()
        CType(Me.tblSoldierInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblTrainingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblPropertyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblLicenseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblSoldierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblSoldierInfoBindingSource
        '
        Me.tblSoldierInfoBindingSource.DataMember = "tblSoldierInfo"
        Me.tblSoldierInfoBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'Soldier_RosterDataSet
        '
        Me.Soldier_RosterDataSet.DataSetName = "Soldier_RosterDataSet"
        Me.Soldier_RosterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tblTrainingBindingSource
        '
        Me.tblTrainingBindingSource.DataMember = "tblTraining"
        Me.tblTrainingBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'tblPropertyBindingSource
        '
        Me.tblPropertyBindingSource.DataMember = "tblProperty"
        Me.tblPropertyBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'tblLicenseBindingSource
        '
        Me.tblLicenseBindingSource.DataMember = "tblLicense"
        Me.tblLicenseBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'tblSoldierBindingSource
        '
        Me.tblSoldierBindingSource.DataMember = "tblSoldier"
        Me.tblSoldierBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblSoldierInfoBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.tblTrainingBindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.tblPropertyBindingSource
        ReportDataSource4.Name = "DataSet4"
        ReportDataSource4.Value = Me.tblLicenseBindingSource
        ReportDataSource5.Name = "DataSet5"
        ReportDataSource5.Value = Me.tblSoldierBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SoldierRosterSystem.All.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1183, 1025)
        Me.ReportViewer1.TabIndex = 0
        '
        'tblSoldierInfoTableAdapter
        '
        Me.tblSoldierInfoTableAdapter.ClearBeforeFill = True
        '
        'tblTrainingTableAdapter
        '
        Me.tblTrainingTableAdapter.ClearBeforeFill = True
        '
        'tblPropertyTableAdapter
        '
        Me.tblPropertyTableAdapter.ClearBeforeFill = True
        '
        'tblLicenseTableAdapter
        '
        Me.tblLicenseTableAdapter.ClearBeforeFill = True
        '
        'tblSoldierTableAdapter
        '
        Me.tblSoldierTableAdapter.ClearBeforeFill = True
        '
        'PrintAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 1025)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PrintAll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SOLDIER'S INFORATMION"
        CType(Me.tblSoldierInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblTrainingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblPropertyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblLicenseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblSoldierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblSoldierInfoBindingSource As BindingSource
    Friend WithEvents Soldier_RosterDataSet As Soldier_RosterDataSet
    Friend WithEvents tblTrainingBindingSource As BindingSource
    Friend WithEvents tblPropertyBindingSource As BindingSource
    Friend WithEvents tblLicenseBindingSource As BindingSource
    Friend WithEvents tblSoldierBindingSource As BindingSource
    Friend WithEvents tblSoldierInfoTableAdapter As Soldier_RosterDataSetTableAdapters.tblSoldierInfoTableAdapter
    Friend WithEvents tblTrainingTableAdapter As Soldier_RosterDataSetTableAdapters.tblTrainingTableAdapter
    Friend WithEvents tblPropertyTableAdapter As Soldier_RosterDataSetTableAdapters.tblPropertyTableAdapter
    Friend WithEvents tblLicenseTableAdapter As Soldier_RosterDataSetTableAdapters.tblLicenseTableAdapter
    Friend WithEvents tblSoldierTableAdapter As Soldier_RosterDataSetTableAdapters.tblSoldierTableAdapter
End Class
