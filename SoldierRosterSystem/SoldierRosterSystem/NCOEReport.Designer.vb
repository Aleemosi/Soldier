<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NCOEReport
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NCOEReport))
        Me.tblRatingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Soldier_RosterDataSet = New SoldierRosterSystem.Soldier_RosterDataSet()
        Me.tblNCOERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblSoldierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tblRatingTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblRatingTableAdapter()
        Me.tblNCOERTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblNCOERTableAdapter()
        Me.tblSoldierTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblSoldierTableAdapter()
        Me.TableAdapterManager = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.tblRatingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblNCOERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblSoldierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblRatingBindingSource
        '
        Me.tblRatingBindingSource.DataMember = "tblRating"
        Me.tblRatingBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'Soldier_RosterDataSet
        '
        Me.Soldier_RosterDataSet.DataSetName = "Soldier_RosterDataSet"
        Me.Soldier_RosterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tblNCOERBindingSource
        '
        Me.tblNCOERBindingSource.DataMember = "tblNCOER"
        Me.tblNCOERBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'tblSoldierBindingSource
        '
        Me.tblSoldierBindingSource.DataMember = "tblSoldier"
        Me.tblSoldierBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblRatingBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.tblNCOERBindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.tblSoldierBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SoldierRosterSystem.NCO.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 61)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(981, 772)
        Me.ReportViewer1.TabIndex = 0
        '
        'tblRatingTableAdapter
        '
        Me.tblRatingTableAdapter.ClearBeforeFill = True
        '
        'tblNCOERTableAdapter
        '
        Me.tblNCOERTableAdapter.ClearBeforeFill = True
        '
        'tblSoldierTableAdapter
        '
        Me.tblSoldierTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminLoginTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BMITableAdapter = Nothing
        Me.TableAdapterManager.MainLoginTableAdapter = Nothing
        Me.TableAdapterManager.tblEmergencyTableAdapter = Nothing
        Me.TableAdapterManager.tblFamilyTableAdapter = Nothing
        Me.TableAdapterManager.tblLicenseTableAdapter = Nothing
        Me.TableAdapterManager.tblNCOERTableAdapter = Me.tblNCOERTableAdapter
        Me.TableAdapterManager.tblPropertyTableAdapter = Nothing
        Me.TableAdapterManager.tblRatingTableAdapter = Me.tblRatingTableAdapter
        Me.TableAdapterManager.tblSoldierInfoTableAdapter = Nothing
        Me.TableAdapterManager.tblSoldierTableAdapter = Me.tblSoldierTableAdapter
        Me.TableAdapterManager.tblTrainingTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(461, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "SEARCH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(370, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(85, 20)
        Me.TextBox1.TabIndex = 4
        '
        'NCOEReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 833)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NCOEReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NON-COMMISSIONER PRINT REPORT"
        CType(Me.tblRatingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblNCOERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblSoldierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblRatingBindingSource As BindingSource
    Friend WithEvents Soldier_RosterDataSet As Soldier_RosterDataSet
    Friend WithEvents tblNCOERBindingSource As BindingSource
    Friend WithEvents tblSoldierBindingSource As BindingSource
    Friend WithEvents tblRatingTableAdapter As Soldier_RosterDataSetTableAdapters.tblRatingTableAdapter
    Friend WithEvents tblNCOERTableAdapter As Soldier_RosterDataSetTableAdapters.tblNCOERTableAdapter
    Friend WithEvents tblSoldierTableAdapter As Soldier_RosterDataSetTableAdapters.tblSoldierTableAdapter
    Friend WithEvents TableAdapterManager As Soldier_RosterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
