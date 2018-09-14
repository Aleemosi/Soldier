<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProperForm
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
        Dim SoldierIDLabel As System.Windows.Forms.Label
        Dim RankLastLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim SpcIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProperForm))
        Me.TblSoldierBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TblSoldierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Soldier_RosterDataSet = New SoldierRosterSystem.Soldier_RosterDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.SoldierIDTextBox = New System.Windows.Forms.TextBox()
        Me.RankLastTextBox = New System.Windows.Forms.TextBox()
        Me.TblPropertyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPropertyDataGridView = New System.Windows.Forms.DataGridView()
        Me.TblSoldierTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblSoldierTableAdapter()
        Me.TableAdapterManager = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.TableAdapterManager()
        Me.TblPropertyTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblPropertyTableAdapter()
        Me.SpcIDTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeaponNumberSerial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        SoldierIDLabel = New System.Windows.Forms.Label()
        RankLastLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        SpcIDLabel = New System.Windows.Forms.Label()
        CType(Me.TblSoldierBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblSoldierBindingNavigator.SuspendLayout()
        CType(Me.TblSoldierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPropertyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPropertyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SoldierIDLabel
        '
        SoldierIDLabel.AutoSize = True
        SoldierIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SoldierIDLabel.Location = New System.Drawing.Point(26, 46)
        SoldierIDLabel.Name = "SoldierIDLabel"
        SoldierIDLabel.Size = New System.Drawing.Size(75, 15)
        SoldierIDLabel.TabIndex = 1
        SoldierIDLabel.Text = "Soldier ID:"
        '
        'RankLastLabel
        '
        RankLastLabel.AutoSize = True
        RankLastLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RankLastLabel.Location = New System.Drawing.Point(261, 79)
        RankLastLabel.Name = "RankLastLabel"
        RankLastLabel.Size = New System.Drawing.Size(67, 15)
        RankLastLabel.TabIndex = 5
        RankLastLabel.Text = "SOLDIER"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(12, 122)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(203, 15)
        Label1.TabIndex = 8
        Label1.Text = "SOLDIER'S PROPERTY TABLE"
        '
        'SpcIDLabel
        '
        SpcIDLabel.AutoSize = True
        SpcIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SpcIDLabel.Location = New System.Drawing.Point(195, 48)
        SpcIDLabel.Name = "SpcIDLabel"
        SpcIDLabel.Size = New System.Drawing.Size(50, 13)
        SpcIDLabel.TabIndex = 8
        SpcIDLabel.Text = "Spc ID:"
        '
        'TblSoldierBindingNavigator
        '
        Me.TblSoldierBindingNavigator.AddNewItem = Nothing
        Me.TblSoldierBindingNavigator.BindingSource = Me.TblSoldierBindingSource
        Me.TblSoldierBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblSoldierBindingNavigator.DeleteItem = Nothing
        Me.TblSoldierBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.TblSoldierBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblSoldierBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblSoldierBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblSoldierBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblSoldierBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblSoldierBindingNavigator.Name = "TblSoldierBindingNavigator"
        Me.TblSoldierBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblSoldierBindingNavigator.Size = New System.Drawing.Size(715, 25)
        Me.TblSoldierBindingNavigator.TabIndex = 0
        Me.TblSoldierBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Margin = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(240, 22)
        Me.ToolStripButton1.Text = "&ADD/EDIT/DELETE SOLDIER'S PROPERTY"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripButton2.Text = "E&XIT"
        Me.ToolStripButton2.ToolTipText = "ATL+X"
        '
        'SoldierIDTextBox
        '
        Me.SoldierIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "SoldierID", True))
        Me.SoldierIDTextBox.Location = New System.Drawing.Point(107, 45)
        Me.SoldierIDTextBox.Name = "SoldierIDTextBox"
        Me.SoldierIDTextBox.ReadOnly = True
        Me.SoldierIDTextBox.Size = New System.Drawing.Size(67, 20)
        Me.SoldierIDTextBox.TabIndex = 2
        '
        'RankLastTextBox
        '
        Me.RankLastTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "RankLast", True))
        Me.RankLastTextBox.Location = New System.Drawing.Point(230, 97)
        Me.RankLastTextBox.Name = "RankLastTextBox"
        Me.RankLastTextBox.ReadOnly = True
        Me.RankLastTextBox.Size = New System.Drawing.Size(129, 20)
        Me.RankLastTextBox.TabIndex = 6
        '
        'TblPropertyBindingSource
        '
        Me.TblPropertyBindingSource.DataMember = "tblSoldiertblProperty"
        Me.TblPropertyBindingSource.DataSource = Me.TblSoldierBindingSource
        '
        'TblPropertyDataGridView
        '
        Me.TblPropertyDataGridView.AutoGenerateColumns = False
        Me.TblPropertyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblPropertyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.WeaponNumberSerial, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.TblPropertyDataGridView.DataSource = Me.TblPropertyBindingSource
        Me.TblPropertyDataGridView.Location = New System.Drawing.Point(15, 140)
        Me.TblPropertyDataGridView.Name = "TblPropertyDataGridView"
        Me.TblPropertyDataGridView.Size = New System.Drawing.Size(683, 220)
        Me.TblPropertyDataGridView.TabIndex = 7
        '
        'TblSoldierTableAdapter
        '
        Me.TblSoldierTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblNCOERTableAdapter = Nothing
        Me.TableAdapterManager.tblPropertyTableAdapter = Me.TblPropertyTableAdapter
        Me.TableAdapterManager.tblRatingTableAdapter = Nothing
        Me.TableAdapterManager.tblSoldierInfoTableAdapter = Nothing
        Me.TableAdapterManager.tblSoldierTableAdapter = Me.TblSoldierTableAdapter
        Me.TableAdapterManager.tblTrainingTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblPropertyTableAdapter
        '
        Me.TblPropertyTableAdapter.ClearBeforeFill = True
        '
        'SpcIDTextBox
        '
        Me.SpcIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "SpcID", True))
        Me.SpcIDTextBox.Location = New System.Drawing.Point(251, 45)
        Me.SpcIDTextBox.Name = "SpcIDTextBox"
        Me.SpcIDTextBox.ReadOnly = True
        Me.SpcIDTextBox.Size = New System.Drawing.Size(67, 20)
        Me.SpcIDTextBox.TabIndex = 9
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "WeaponType"
        Me.DataGridViewTextBoxColumn3.HeaderText = "WeaponType"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 110
        '
        'WeaponNumberSerial
        '
        Me.WeaponNumberSerial.DataPropertyName = "WeaponNumberSerial"
        Me.WeaponNumberSerial.HeaderText = "WeaponNumberSerial"
        Me.WeaponNumberSerial.Name = "WeaponNumberSerial"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "MaskNumber"
        Me.DataGridViewTextBoxColumn5.HeaderText = "MaskNumber"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "MaskSize"
        Me.DataGridViewTextBoxColumn6.HeaderText = "MaskSize"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NBCTopSIze"
        Me.DataGridViewTextBoxColumn7.HeaderText = "NBCTopSIze"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NBCBottomSize"
        Me.DataGridViewTextBoxColumn8.HeaderText = "NBCBottomSize"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NBCBootsSize"
        Me.DataGridViewTextBoxColumn9.HeaderText = "NBCBootsSize"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ACUCap"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ACUCap"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ACUTTop"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ACUTTop"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ACUBottom"
        Me.DataGridViewTextBoxColumn12.HeaderText = "ACUBottom"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "BOOTS"
        Me.DataGridViewTextBoxColumn13.HeaderText = "BOOTS"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'ProperForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 380)
        Me.ControlBox = False
        Me.Controls.Add(SpcIDLabel)
        Me.Controls.Add(Me.SpcIDTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TblPropertyDataGridView)
        Me.Controls.Add(RankLastLabel)
        Me.Controls.Add(Me.RankLastTextBox)
        Me.Controls.Add(SoldierIDLabel)
        Me.Controls.Add(Me.SoldierIDTextBox)
        Me.Controls.Add(Me.TblSoldierBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ProperForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SOLDIER'S PROPERTY FORM"
        CType(Me.TblSoldierBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblSoldierBindingNavigator.ResumeLayout(False)
        Me.TblSoldierBindingNavigator.PerformLayout()
        CType(Me.TblSoldierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPropertyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPropertyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Soldier_RosterDataSet As Soldier_RosterDataSet
    Friend WithEvents TblSoldierBindingSource As BindingSource
    Friend WithEvents TblSoldierTableAdapter As Soldier_RosterDataSetTableAdapters.tblSoldierTableAdapter
    Friend WithEvents TableAdapterManager As Soldier_RosterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblSoldierBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TblPropertyTableAdapter As Soldier_RosterDataSetTableAdapters.tblPropertyTableAdapter
    Friend WithEvents SoldierIDTextBox As TextBox
    Friend WithEvents RankLastTextBox As TextBox
    Friend WithEvents TblPropertyBindingSource As BindingSource
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents TblPropertyDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents SpcIDTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents WeaponNumberSerial As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
End Class
