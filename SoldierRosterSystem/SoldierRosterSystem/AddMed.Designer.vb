<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMed
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
        Dim MEDIDLabel As System.Windows.Forms.Label
        Dim SoldierIDLabel As System.Windows.Forms.Label
        Dim PhyscalDateLabel As System.Windows.Forms.Label
        Dim LastDentalLabel As System.Windows.Forms.Label
        Dim VusionDateLabel As System.Windows.Forms.Label
        Dim GlassLabel As System.Windows.Forms.Label
        Dim NBCGlassLabel As System.Windows.Forms.Label
        Dim AudioDateLabel As System.Windows.Forms.Label
        Dim DeployableLabel As System.Windows.Forms.Label
        Dim HIVDateLabel As System.Windows.Forms.Label
        Dim G6PDDateLabel As System.Windows.Forms.Label
        Dim SoldierIDLabel1 As System.Windows.Forms.Label
        Dim RankLastLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddMed))
        Me.Soldier_RosterDataSet = New SoldierRosterSystem.Soldier_RosterDataSet()
        Me.TblmedprosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblmedprosTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblmedprosTableAdapter()
        Me.TableAdapterManager = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.TableAdapterManager()
        Me.TblmedprosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MEDIDTextBox = New System.Windows.Forms.TextBox()
        Me.SoldierIDTextBox = New System.Windows.Forms.TextBox()
        Me.PhyscalDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LastDentalDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.VusionDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GlassTextBox = New System.Windows.Forms.TextBox()
        Me.NBCGlassTextBox = New System.Windows.Forms.TextBox()
        Me.AudioDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DeployableTextBox = New System.Windows.Forms.TextBox()
        Me.HIVDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.G6PDDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TblSoldierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSoldierTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblSoldierTableAdapter()
        Me.SoldierIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.RankLastTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        MEDIDLabel = New System.Windows.Forms.Label()
        SoldierIDLabel = New System.Windows.Forms.Label()
        PhyscalDateLabel = New System.Windows.Forms.Label()
        LastDentalLabel = New System.Windows.Forms.Label()
        VusionDateLabel = New System.Windows.Forms.Label()
        GlassLabel = New System.Windows.Forms.Label()
        NBCGlassLabel = New System.Windows.Forms.Label()
        AudioDateLabel = New System.Windows.Forms.Label()
        DeployableLabel = New System.Windows.Forms.Label()
        HIVDateLabel = New System.Windows.Forms.Label()
        G6PDDateLabel = New System.Windows.Forms.Label()
        SoldierIDLabel1 = New System.Windows.Forms.Label()
        RankLastLabel = New System.Windows.Forms.Label()
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblmedprosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblmedprosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblmedprosBindingNavigator.SuspendLayout()
        CType(Me.TblSoldierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Soldier_RosterDataSet
        '
        Me.Soldier_RosterDataSet.DataSetName = "Soldier_RosterDataSet"
        Me.Soldier_RosterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblmedprosBindingSource
        '
        Me.TblmedprosBindingSource.DataMember = "tblmedpros"
        Me.TblmedprosBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'TblmedprosTableAdapter
        '
        Me.TblmedprosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblmedprosTableAdapter = Me.TblmedprosTableAdapter
        Me.TableAdapterManager.tblNCOERTableAdapter = Nothing
        Me.TableAdapterManager.tblPropertyTableAdapter = Nothing
        Me.TableAdapterManager.tblRatingTableAdapter = Nothing
        Me.TableAdapterManager.tblSoldierInfoTableAdapter = Nothing
        Me.TableAdapterManager.tblSoldierTableAdapter = Me.TblSoldierTableAdapter
        Me.TableAdapterManager.tblTrainingTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblmedprosBindingNavigator
        '
        Me.TblmedprosBindingNavigator.AddNewItem = Nothing
        Me.TblmedprosBindingNavigator.BindingSource = Me.TblmedprosBindingSource
        Me.TblmedprosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblmedprosBindingNavigator.DeleteItem = Nothing
        Me.TblmedprosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.TblmedprosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblmedprosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblmedprosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblmedprosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblmedprosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblmedprosBindingNavigator.Name = "TblmedprosBindingNavigator"
        Me.TblmedprosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblmedprosBindingNavigator.Size = New System.Drawing.Size(600, 25)
        Me.TblmedprosBindingNavigator.TabIndex = 0
        Me.TblmedprosBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MEDIDLabel
        '
        MEDIDLabel.AutoSize = True
        MEDIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MEDIDLabel.Location = New System.Drawing.Point(12, 45)
        MEDIDLabel.Name = "MEDIDLabel"
        MEDIDLabel.Size = New System.Drawing.Size(51, 13)
        MEDIDLabel.TabIndex = 1
        MEDIDLabel.Text = "MEDID:"
        '
        'MEDIDTextBox
        '
        Me.MEDIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblmedprosBindingSource, "MEDID", True))
        Me.MEDIDTextBox.Location = New System.Drawing.Point(69, 42)
        Me.MEDIDTextBox.Name = "MEDIDTextBox"
        Me.MEDIDTextBox.ReadOnly = True
        Me.MEDIDTextBox.Size = New System.Drawing.Size(49, 20)
        Me.MEDIDTextBox.TabIndex = 2
        '
        'SoldierIDLabel
        '
        SoldierIDLabel.AutoSize = True
        SoldierIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SoldierIDLabel.Location = New System.Drawing.Point(140, 45)
        SoldierIDLabel.Name = "SoldierIDLabel"
        SoldierIDLabel.Size = New System.Drawing.Size(67, 13)
        SoldierIDLabel.TabIndex = 3
        SoldierIDLabel.Text = "Soldier ID:"
        '
        'SoldierIDTextBox
        '
        Me.SoldierIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblmedprosBindingSource, "SoldierID", True))
        Me.SoldierIDTextBox.Location = New System.Drawing.Point(213, 42)
        Me.SoldierIDTextBox.Name = "SoldierIDTextBox"
        Me.SoldierIDTextBox.ReadOnly = True
        Me.SoldierIDTextBox.Size = New System.Drawing.Size(49, 20)
        Me.SoldierIDTextBox.TabIndex = 4
        '
        'PhyscalDateLabel
        '
        PhyscalDateLabel.AutoSize = True
        PhyscalDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhyscalDateLabel.Location = New System.Drawing.Point(12, 168)
        PhyscalDateLabel.Name = "PhyscalDateLabel"
        PhyscalDateLabel.Size = New System.Drawing.Size(86, 13)
        PhyscalDateLabel.TabIndex = 5
        PhyscalDateLabel.Text = "Physcal Date:"
        '
        'PhyscalDateDateTimePicker
        '
        Me.PhyscalDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblmedprosBindingSource, "PhyscalDate", True))
        Me.PhyscalDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.PhyscalDateDateTimePicker.Location = New System.Drawing.Point(104, 162)
        Me.PhyscalDateDateTimePicker.Name = "PhyscalDateDateTimePicker"
        Me.PhyscalDateDateTimePicker.Size = New System.Drawing.Size(103, 20)
        Me.PhyscalDateDateTimePicker.TabIndex = 6
        Me.PhyscalDateDateTimePicker.Value = New Date(2018, 4, 9, 0, 0, 0, 0)
        '
        'LastDentalLabel
        '
        LastDentalLabel.AutoSize = True
        LastDentalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastDentalLabel.Location = New System.Drawing.Point(228, 168)
        LastDentalLabel.Name = "LastDentalLabel"
        LastDentalLabel.Size = New System.Drawing.Size(76, 13)
        LastDentalLabel.TabIndex = 7
        LastDentalLabel.Text = "Last Dental:"
        '
        'LastDentalDateTimePicker
        '
        Me.LastDentalDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblmedprosBindingSource, "LastDental", True))
        Me.LastDentalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.LastDentalDateTimePicker.Location = New System.Drawing.Point(310, 162)
        Me.LastDentalDateTimePicker.Name = "LastDentalDateTimePicker"
        Me.LastDentalDateTimePicker.Size = New System.Drawing.Size(103, 20)
        Me.LastDentalDateTimePicker.TabIndex = 8
        Me.LastDentalDateTimePicker.Value = New Date(2018, 4, 9, 0, 0, 0, 0)
        '
        'VusionDateLabel
        '
        VusionDateLabel.AutoSize = True
        VusionDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VusionDateLabel.Location = New System.Drawing.Point(18, 207)
        VusionDateLabel.Name = "VusionDateLabel"
        VusionDateLabel.Size = New System.Drawing.Size(80, 13)
        VusionDateLabel.TabIndex = 9
        VusionDateLabel.Text = "Vusion Date:"
        '
        'VusionDateDateTimePicker
        '
        Me.VusionDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblmedprosBindingSource, "VusionDate", True))
        Me.VusionDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.VusionDateDateTimePicker.Location = New System.Drawing.Point(104, 200)
        Me.VusionDateDateTimePicker.Name = "VusionDateDateTimePicker"
        Me.VusionDateDateTimePicker.Size = New System.Drawing.Size(103, 20)
        Me.VusionDateDateTimePicker.TabIndex = 10
        Me.VusionDateDateTimePicker.Value = New Date(2018, 4, 9, 0, 0, 0, 0)
        '
        'GlassLabel
        '
        GlassLabel.AutoSize = True
        GlassLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GlassLabel.Location = New System.Drawing.Point(262, 206)
        GlassLabel.Name = "GlassLabel"
        GlassLabel.Size = New System.Drawing.Size(42, 13)
        GlassLabel.TabIndex = 11
        GlassLabel.Text = "Glass:"
        '
        'GlassTextBox
        '
        Me.GlassTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblmedprosBindingSource, "Glass", True))
        Me.GlassTextBox.Location = New System.Drawing.Point(310, 203)
        Me.GlassTextBox.Name = "GlassTextBox"
        Me.GlassTextBox.Size = New System.Drawing.Size(71, 20)
        Me.GlassTextBox.TabIndex = 12
        '
        'NBCGlassLabel
        '
        NBCGlassLabel.AutoSize = True
        NBCGlassLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NBCGlassLabel.Location = New System.Drawing.Point(237, 241)
        NBCGlassLabel.Name = "NBCGlassLabel"
        NBCGlassLabel.Size = New System.Drawing.Size(67, 13)
        NBCGlassLabel.TabIndex = 13
        NBCGlassLabel.Text = "NBCGlass:"
        '
        'NBCGlassTextBox
        '
        Me.NBCGlassTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblmedprosBindingSource, "NBCGlass", True))
        Me.NBCGlassTextBox.Location = New System.Drawing.Point(310, 238)
        Me.NBCGlassTextBox.Name = "NBCGlassTextBox"
        Me.NBCGlassTextBox.Size = New System.Drawing.Size(71, 20)
        Me.NBCGlassTextBox.TabIndex = 14
        '
        'AudioDateLabel
        '
        AudioDateLabel.AutoSize = True
        AudioDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AudioDateLabel.Location = New System.Drawing.Point(24, 292)
        AudioDateLabel.Name = "AudioDateLabel"
        AudioDateLabel.Size = New System.Drawing.Size(74, 13)
        AudioDateLabel.TabIndex = 15
        AudioDateLabel.Text = "Audio Date:"
        '
        'AudioDateDateTimePicker
        '
        Me.AudioDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblmedprosBindingSource, "AudioDate", True))
        Me.AudioDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.AudioDateDateTimePicker.Location = New System.Drawing.Point(104, 286)
        Me.AudioDateDateTimePicker.Name = "AudioDateDateTimePicker"
        Me.AudioDateDateTimePicker.Size = New System.Drawing.Size(103, 20)
        Me.AudioDateDateTimePicker.TabIndex = 16
        Me.AudioDateDateTimePicker.Value = New Date(2018, 4, 9, 0, 0, 0, 0)
        '
        'DeployableLabel
        '
        DeployableLabel.AutoSize = True
        DeployableLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DeployableLabel.Location = New System.Drawing.Point(230, 292)
        DeployableLabel.Name = "DeployableLabel"
        DeployableLabel.Size = New System.Drawing.Size(74, 13)
        DeployableLabel.TabIndex = 17
        DeployableLabel.Text = "Deployable:"
        '
        'DeployableTextBox
        '
        Me.DeployableTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblmedprosBindingSource, "Deployable", True))
        Me.DeployableTextBox.Location = New System.Drawing.Point(310, 289)
        Me.DeployableTextBox.Name = "DeployableTextBox"
        Me.DeployableTextBox.Size = New System.Drawing.Size(71, 20)
        Me.DeployableTextBox.TabIndex = 18
        '
        'HIVDateLabel
        '
        HIVDateLabel.AutoSize = True
        HIVDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HIVDateLabel.Location = New System.Drawing.Point(39, 337)
        HIVDateLabel.Name = "HIVDateLabel"
        HIVDateLabel.Size = New System.Drawing.Size(59, 13)
        HIVDateLabel.TabIndex = 19
        HIVDateLabel.Text = "HIVDate:"
        '
        'HIVDateDateTimePicker
        '
        Me.HIVDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblmedprosBindingSource, "HIVDate", True))
        Me.HIVDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HIVDateDateTimePicker.Location = New System.Drawing.Point(104, 331)
        Me.HIVDateDateTimePicker.Name = "HIVDateDateTimePicker"
        Me.HIVDateDateTimePicker.Size = New System.Drawing.Size(103, 20)
        Me.HIVDateDateTimePicker.TabIndex = 20
        Me.HIVDateDateTimePicker.Value = New Date(2018, 4, 9, 0, 0, 0, 0)
        '
        'G6PDDateLabel
        '
        G6PDDateLabel.AutoSize = True
        G6PDDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        G6PDDateLabel.Location = New System.Drawing.Point(233, 337)
        G6PDDateLabel.Name = "G6PDDateLabel"
        G6PDDateLabel.Size = New System.Drawing.Size(71, 13)
        G6PDDateLabel.TabIndex = 21
        G6PDDateLabel.Text = "G6PDDate:"
        '
        'G6PDDateDateTimePicker
        '
        Me.G6PDDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblmedprosBindingSource, "G6PDDate", True))
        Me.G6PDDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.G6PDDateDateTimePicker.Location = New System.Drawing.Point(310, 331)
        Me.G6PDDateDateTimePicker.Name = "G6PDDateDateTimePicker"
        Me.G6PDDateDateTimePicker.Size = New System.Drawing.Size(103, 20)
        Me.G6PDDateDateTimePicker.TabIndex = 22
        Me.G6PDDateDateTimePicker.Value = New Date(2018, 4, 9, 0, 0, 0, 0)
        '
        'TblSoldierBindingSource
        '
        Me.TblSoldierBindingSource.DataMember = "tblSoldier"
        Me.TblSoldierBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'TblSoldierTableAdapter
        '
        Me.TblSoldierTableAdapter.ClearBeforeFill = True
        '
        'SoldierIDLabel1
        '
        SoldierIDLabel1.AutoSize = True
        SoldierIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SoldierIDLabel1.Location = New System.Drawing.Point(282, 45)
        SoldierIDLabel1.Name = "SoldierIDLabel1"
        SoldierIDLabel1.Size = New System.Drawing.Size(67, 13)
        SoldierIDLabel1.TabIndex = 23
        SoldierIDLabel1.Text = "Soldier ID:"
        '
        'SoldierIDTextBox1
        '
        Me.SoldierIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "SoldierID", True))
        Me.SoldierIDTextBox1.Location = New System.Drawing.Point(355, 42)
        Me.SoldierIDTextBox1.Name = "SoldierIDTextBox1"
        Me.SoldierIDTextBox1.ReadOnly = True
        Me.SoldierIDTextBox1.Size = New System.Drawing.Size(49, 20)
        Me.SoldierIDTextBox1.TabIndex = 24
        '
        'RankLastLabel
        '
        RankLastLabel.AutoSize = True
        RankLastLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RankLastLabel.Location = New System.Drawing.Point(203, 100)
        RankLastLabel.Name = "RankLastLabel"
        RankLastLabel.Size = New System.Drawing.Size(61, 13)
        RankLastLabel.TabIndex = 25
        RankLastLabel.Text = "SOLDIER"
        '
        'RankLastTextBox
        '
        Me.RankLastTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "RankLast", True))
        Me.RankLastTextBox.Location = New System.Drawing.Point(122, 116)
        Me.RankLastTextBox.Name = "RankLastTextBox"
        Me.RankLastTextBox.ReadOnly = True
        Me.RankLastTextBox.Size = New System.Drawing.Size(227, 20)
        Me.RankLastTextBox.TabIndex = 26
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripButton1.Text = "ADD"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripButton2.Text = "SAVE"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripButton3.Text = "DELETE"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(117, 22)
        Me.ToolStripButton4.Text = "MEDPROS FORM"
        '
        'AddMed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 369)
        Me.ControlBox = False
        Me.Controls.Add(RankLastLabel)
        Me.Controls.Add(Me.RankLastTextBox)
        Me.Controls.Add(SoldierIDLabel1)
        Me.Controls.Add(Me.SoldierIDTextBox1)
        Me.Controls.Add(MEDIDLabel)
        Me.Controls.Add(Me.MEDIDTextBox)
        Me.Controls.Add(SoldierIDLabel)
        Me.Controls.Add(Me.SoldierIDTextBox)
        Me.Controls.Add(PhyscalDateLabel)
        Me.Controls.Add(Me.PhyscalDateDateTimePicker)
        Me.Controls.Add(LastDentalLabel)
        Me.Controls.Add(Me.LastDentalDateTimePicker)
        Me.Controls.Add(VusionDateLabel)
        Me.Controls.Add(Me.VusionDateDateTimePicker)
        Me.Controls.Add(GlassLabel)
        Me.Controls.Add(Me.GlassTextBox)
        Me.Controls.Add(NBCGlassLabel)
        Me.Controls.Add(Me.NBCGlassTextBox)
        Me.Controls.Add(AudioDateLabel)
        Me.Controls.Add(Me.AudioDateDateTimePicker)
        Me.Controls.Add(DeployableLabel)
        Me.Controls.Add(Me.DeployableTextBox)
        Me.Controls.Add(HIVDateLabel)
        Me.Controls.Add(Me.HIVDateDateTimePicker)
        Me.Controls.Add(G6PDDateLabel)
        Me.Controls.Add(Me.G6PDDateDateTimePicker)
        Me.Controls.Add(Me.TblmedprosBindingNavigator)
        Me.Name = "AddMed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD SOLDIER'S MEDPROS"
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblmedprosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblmedprosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblmedprosBindingNavigator.ResumeLayout(False)
        Me.TblmedprosBindingNavigator.PerformLayout()
        CType(Me.TblSoldierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Soldier_RosterDataSet As Soldier_RosterDataSet
    Friend WithEvents TblmedprosBindingSource As BindingSource
    Friend WithEvents TblmedprosTableAdapter As Soldier_RosterDataSetTableAdapters.tblmedprosTableAdapter
    Friend WithEvents TableAdapterManager As Soldier_RosterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblmedprosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents MEDIDTextBox As TextBox
    Friend WithEvents SoldierIDTextBox As TextBox
    Friend WithEvents PhyscalDateDateTimePicker As DateTimePicker
    Friend WithEvents LastDentalDateTimePicker As DateTimePicker
    Friend WithEvents VusionDateDateTimePicker As DateTimePicker
    Friend WithEvents GlassTextBox As TextBox
    Friend WithEvents NBCGlassTextBox As TextBox
    Friend WithEvents AudioDateDateTimePicker As DateTimePicker
    Friend WithEvents DeployableTextBox As TextBox
    Friend WithEvents HIVDateDateTimePicker As DateTimePicker
    Friend WithEvents G6PDDateDateTimePicker As DateTimePicker
    Friend WithEvents TblSoldierTableAdapter As Soldier_RosterDataSetTableAdapters.tblSoldierTableAdapter
    Friend WithEvents TblSoldierBindingSource As BindingSource
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents SoldierIDTextBox1 As TextBox
    Friend WithEvents RankLastTextBox As TextBox
End Class
