<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SoldierData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SoldierData))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SpcID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.RankDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleInitialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelephoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarriedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SingleDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LastFourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblSoldierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Soldier_RosterDataSet = New SoldierRosterSystem.Soldier_RosterDataSet()
        Me.TblSoldierTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblSoldierTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSoldierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SpcID, Me.RankDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MiddleInitialDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.AptDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.ZipDataGridViewTextBoxColumn, Me.TelephoneDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.MarriedDataGridViewCheckBoxColumn, Me.SingleDataGridViewCheckBoxColumn, Me.LastFourDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblSoldierBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(944, 289)
        Me.DataGridView1.TabIndex = 0
        '
        'SpcID
        '
        Me.SpcID.DataPropertyName = "SpcID"
        Me.SpcID.HeaderText = "SpcID"
        Me.SpcID.Name = "SpcID"
        Me.SpcID.ReadOnly = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(198, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(180, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "SOLDIERS REPORT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 337)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(324, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "DROP DOWN TO PRINT INDIVIDUAL SOLDIER REPORT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'RankDataGridViewTextBoxColumn
        '
        Me.RankDataGridViewTextBoxColumn.DataPropertyName = "Rank"
        Me.RankDataGridViewTextBoxColumn.HeaderText = "Rank"
        Me.RankDataGridViewTextBoxColumn.Name = "RankDataGridViewTextBoxColumn"
        Me.RankDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MiddleInitialDataGridViewTextBoxColumn
        '
        Me.MiddleInitialDataGridViewTextBoxColumn.DataPropertyName = "MiddleInitial"
        Me.MiddleInitialDataGridViewTextBoxColumn.HeaderText = "MiddleInitial"
        Me.MiddleInitialDataGridViewTextBoxColumn.Name = "MiddleInitialDataGridViewTextBoxColumn"
        Me.MiddleInitialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AptDataGridViewTextBoxColumn
        '
        Me.AptDataGridViewTextBoxColumn.DataPropertyName = "Apt"
        Me.AptDataGridViewTextBoxColumn.HeaderText = "Apt"
        Me.AptDataGridViewTextBoxColumn.Name = "AptDataGridViewTextBoxColumn"
        Me.AptDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        Me.StateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ZipDataGridViewTextBoxColumn
        '
        Me.ZipDataGridViewTextBoxColumn.DataPropertyName = "Zip"
        Me.ZipDataGridViewTextBoxColumn.HeaderText = "Zip"
        Me.ZipDataGridViewTextBoxColumn.Name = "ZipDataGridViewTextBoxColumn"
        Me.ZipDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelephoneDataGridViewTextBoxColumn
        '
        Me.TelephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone"
        Me.TelephoneDataGridViewTextBoxColumn.HeaderText = "Telephone"
        Me.TelephoneDataGridViewTextBoxColumn.Name = "TelephoneDataGridViewTextBoxColumn"
        Me.TelephoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MarriedDataGridViewCheckBoxColumn
        '
        Me.MarriedDataGridViewCheckBoxColumn.DataPropertyName = "Married"
        Me.MarriedDataGridViewCheckBoxColumn.HeaderText = "Married"
        Me.MarriedDataGridViewCheckBoxColumn.Name = "MarriedDataGridViewCheckBoxColumn"
        Me.MarriedDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'SingleDataGridViewCheckBoxColumn
        '
        Me.SingleDataGridViewCheckBoxColumn.DataPropertyName = "Single"
        Me.SingleDataGridViewCheckBoxColumn.HeaderText = "Single"
        Me.SingleDataGridViewCheckBoxColumn.Name = "SingleDataGridViewCheckBoxColumn"
        Me.SingleDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'LastFourDataGridViewTextBoxColumn
        '
        Me.LastFourDataGridViewTextBoxColumn.DataPropertyName = "LastFour"
        Me.LastFourDataGridViewTextBoxColumn.HeaderText = "LastFour"
        Me.LastFourDataGridViewTextBoxColumn.Name = "LastFourDataGridViewTextBoxColumn"
        Me.LastFourDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblSoldierBindingSource
        '
        Me.TblSoldierBindingSource.DataMember = "tblSoldier"
        Me.TblSoldierBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'Soldier_RosterDataSet
        '
        Me.Soldier_RosterDataSet.DataSetName = "Soldier_RosterDataSet"
        Me.Soldier_RosterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblSoldierTableAdapter
        '
        Me.TblSoldierTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TblSoldierBindingSource
        Me.ComboBox1.DisplayMember = "RankLast"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(342, 339)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(190, 21)
        Me.ComboBox1.TabIndex = 6
        Me.ComboBox1.ValueMember = "RankLast"
        '
        'SoldierData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 366)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SoldierData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SOLDIER DATA"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSoldierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Soldier_RosterDataSet As Soldier_RosterDataSet
    Friend WithEvents TblSoldierBindingSource As BindingSource
    Friend WithEvents TblSoldierTableAdapter As Soldier_RosterDataSetTableAdapters.tblSoldierTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents SpcID As DataGridViewTextBoxColumn
    Friend WithEvents RankDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddleInitialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AptDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZipDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelephoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarriedDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents SingleDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents LastFourDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
End Class
