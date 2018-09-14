<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddInfo
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
        Dim InfoIDLabel As System.Windows.Forms.Label
        Dim SoldierIDLabel As System.Windows.Forms.Label
        Dim DutyPositionLabel As System.Windows.Forms.Label
        Dim SquadLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim MOSLabel As System.Windows.Forms.Label
        Dim SecurityClearanceLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim BASDLabel As System.Windows.Forms.Label
        Dim ETSLabel As System.Windows.Forms.Label
        Dim BloodTypeLabel As System.Windows.Forms.Label
        Dim ReligionLabel As System.Windows.Forms.Label
        Dim SoldierIDLabel1 As System.Windows.Forms.Label
        Dim RankLastLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddInfo))
        Me.Soldier_RosterDataSet = New SoldierRosterSystem.Soldier_RosterDataSet()
        Me.TblSoldierInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSoldierInfoTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblSoldierInfoTableAdapter()
        Me.TableAdapterManager = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.TableAdapterManager()
        Me.TblSoldierTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblSoldierTableAdapter()
        Me.TblSoldierInfoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.InfoIDTextBox = New System.Windows.Forms.TextBox()
        Me.SoldierIDTextBox = New System.Windows.Forms.TextBox()
        Me.DutyPositionTextBox = New System.Windows.Forms.TextBox()
        Me.SquadTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.MOSTextBox = New System.Windows.Forms.TextBox()
        Me.SecurityClearanceTextBox = New System.Windows.Forms.TextBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BASDDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ETSDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BloodTypeTextBox = New System.Windows.Forms.TextBox()
        Me.ReligionTextBox = New System.Windows.Forms.TextBox()
        Me.TblSoldierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SoldierIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.RankLastTextBox = New System.Windows.Forms.TextBox()
        InfoIDLabel = New System.Windows.Forms.Label()
        SoldierIDLabel = New System.Windows.Forms.Label()
        DutyPositionLabel = New System.Windows.Forms.Label()
        SquadLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        MOSLabel = New System.Windows.Forms.Label()
        SecurityClearanceLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        BASDLabel = New System.Windows.Forms.Label()
        ETSLabel = New System.Windows.Forms.Label()
        BloodTypeLabel = New System.Windows.Forms.Label()
        ReligionLabel = New System.Windows.Forms.Label()
        SoldierIDLabel1 = New System.Windows.Forms.Label()
        RankLastLabel = New System.Windows.Forms.Label()
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSoldierInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSoldierInfoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblSoldierInfoBindingNavigator.SuspendLayout()
        CType(Me.TblSoldierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InfoIDLabel
        '
        InfoIDLabel.AutoSize = True
        InfoIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        InfoIDLabel.Location = New System.Drawing.Point(11, 42)
        InfoIDLabel.Name = "InfoIDLabel"
        InfoIDLabel.Size = New System.Drawing.Size(53, 15)
        InfoIDLabel.TabIndex = 1
        InfoIDLabel.Text = "Info ID:"
        '
        'SoldierIDLabel
        '
        SoldierIDLabel.AutoSize = True
        SoldierIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SoldierIDLabel.Location = New System.Drawing.Point(139, 42)
        SoldierIDLabel.Name = "SoldierIDLabel"
        SoldierIDLabel.Size = New System.Drawing.Size(75, 15)
        SoldierIDLabel.TabIndex = 3
        SoldierIDLabel.Text = "Soldier ID:"
        '
        'DutyPositionLabel
        '
        DutyPositionLabel.AutoSize = True
        DutyPositionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DutyPositionLabel.Location = New System.Drawing.Point(22, 145)
        DutyPositionLabel.Name = "DutyPositionLabel"
        DutyPositionLabel.Size = New System.Drawing.Size(95, 15)
        DutyPositionLabel.TabIndex = 5
        DutyPositionLabel.Text = "Duty Position:"
        '
        'SquadLabel
        '
        SquadLabel.AutoSize = True
        SquadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SquadLabel.Location = New System.Drawing.Point(294, 145)
        SquadLabel.Name = "SquadLabel"
        SquadLabel.Size = New System.Drawing.Size(52, 15)
        SquadLabel.TabIndex = 7
        SquadLabel.Text = "Squad:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(472, 145)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(58, 15)
        GenderLabel.TabIndex = 9
        GenderLabel.Text = "Gender:"
        '
        'MOSLabel
        '
        MOSLabel.AutoSize = True
        MOSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MOSLabel.Location = New System.Drawing.Point(75, 186)
        MOSLabel.Name = "MOSLabel"
        MOSLabel.Size = New System.Drawing.Size(42, 15)
        MOSLabel.TabIndex = 11
        MOSLabel.Text = "MOS:"
        '
        'SecurityClearanceLabel
        '
        SecurityClearanceLabel.AutoSize = True
        SecurityClearanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SecurityClearanceLabel.Location = New System.Drawing.Point(248, 186)
        SecurityClearanceLabel.Name = "SecurityClearanceLabel"
        SecurityClearanceLabel.Size = New System.Drawing.Size(131, 15)
        SecurityClearanceLabel.TabIndex = 13
        SecurityClearanceLabel.Text = "Security Clearance:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOBLabel.Location = New System.Drawing.Point(77, 229)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(40, 15)
        DOBLabel.TabIndex = 15
        DOBLabel.Text = "DOB:"
        '
        'BASDLabel
        '
        BASDLabel.AutoSize = True
        BASDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BASDLabel.Location = New System.Drawing.Point(267, 229)
        BASDLabel.Name = "BASDLabel"
        BASDLabel.Size = New System.Drawing.Size(47, 15)
        BASDLabel.TabIndex = 17
        BASDLabel.Text = "BASD:"
        '
        'ETSLabel
        '
        ETSLabel.AutoSize = True
        ETSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ETSLabel.Location = New System.Drawing.Point(459, 229)
        ETSLabel.Name = "ETSLabel"
        ETSLabel.Size = New System.Drawing.Size(37, 15)
        ETSLabel.TabIndex = 19
        ETSLabel.Text = "ETS:"
        '
        'BloodTypeLabel
        '
        BloodTypeLabel.AutoSize = True
        BloodTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BloodTypeLabel.Location = New System.Drawing.Point(35, 266)
        BloodTypeLabel.Name = "BloodTypeLabel"
        BloodTypeLabel.Size = New System.Drawing.Size(82, 15)
        BloodTypeLabel.TabIndex = 21
        BloodTypeLabel.Text = "Blood Type:"
        '
        'ReligionLabel
        '
        ReligionLabel.AutoSize = True
        ReligionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReligionLabel.Location = New System.Drawing.Point(217, 266)
        ReligionLabel.Name = "ReligionLabel"
        ReligionLabel.Size = New System.Drawing.Size(65, 15)
        ReligionLabel.TabIndex = 23
        ReligionLabel.Text = "Religion:"
        '
        'SoldierIDLabel1
        '
        SoldierIDLabel1.AutoSize = True
        SoldierIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SoldierIDLabel1.Location = New System.Drawing.Point(304, 44)
        SoldierIDLabel1.Name = "SoldierIDLabel1"
        SoldierIDLabel1.Size = New System.Drawing.Size(75, 15)
        SoldierIDLabel1.TabIndex = 25
        SoldierIDLabel1.Text = "Soldier ID:"
        '
        'RankLastLabel
        '
        RankLastLabel.AutoSize = True
        RankLastLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RankLastLabel.Location = New System.Drawing.Point(217, 87)
        RankLastLabel.Name = "RankLastLabel"
        RankLastLabel.Size = New System.Drawing.Size(67, 15)
        RankLastLabel.TabIndex = 27
        RankLastLabel.Text = "SOLDIER"
        '
        'Soldier_RosterDataSet
        '
        Me.Soldier_RosterDataSet.DataSetName = "Soldier_RosterDataSet"
        Me.Soldier_RosterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblSoldierInfoBindingSource
        '
        Me.TblSoldierInfoBindingSource.DataMember = "tblSoldierInfo"
        Me.TblSoldierInfoBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'TblSoldierInfoTableAdapter
        '
        Me.TblSoldierInfoTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblPropertyTableAdapter = Nothing
        Me.TableAdapterManager.tblRatingTableAdapter = Nothing
        Me.TableAdapterManager.tblSoldierInfoTableAdapter = Me.TblSoldierInfoTableAdapter
        Me.TableAdapterManager.tblSoldierTableAdapter = Me.TblSoldierTableAdapter
        Me.TableAdapterManager.tblTrainingTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblSoldierTableAdapter
        '
        Me.TblSoldierTableAdapter.ClearBeforeFill = True
        '
        'TblSoldierInfoBindingNavigator
        '
        Me.TblSoldierInfoBindingNavigator.AddNewItem = Nothing
        Me.TblSoldierInfoBindingNavigator.BindingSource = Me.TblSoldierInfoBindingSource
        Me.TblSoldierInfoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblSoldierInfoBindingNavigator.DeleteItem = Nothing
        Me.TblSoldierInfoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator1, Me.ToolStripButton4})
        Me.TblSoldierInfoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblSoldierInfoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblSoldierInfoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblSoldierInfoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblSoldierInfoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblSoldierInfoBindingNavigator.Name = "TblSoldierInfoBindingNavigator"
        Me.TblSoldierInfoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblSoldierInfoBindingNavigator.Size = New System.Drawing.Size(662, 25)
        Me.TblSoldierInfoBindingNavigator.TabIndex = 0
        Me.TblSoldierInfoBindingNavigator.Text = "BindingNavigator1"
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
        Me.ToolStripButton1.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripButton1.Text = "&ADD"
        Me.ToolStripButton1.ToolTipText = "ALT+A"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripButton2.Text = "&SAVE"
        Me.ToolStripButton2.ToolTipText = "ALT+S"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripButton3.Text = "&DELETE"
        Me.ToolStripButton3.ToolTipText = "ALT+D"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Margin = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(191, 22)
        Me.ToolStripButton4.Text = "SOLDIER &INFORMATION FORM"
        Me.ToolStripButton4.ToolTipText = "ALT+I"
        '
        'InfoIDTextBox
        '
        Me.InfoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierInfoBindingSource, "InfoID", True))
        Me.InfoIDTextBox.Location = New System.Drawing.Point(70, 41)
        Me.InfoIDTextBox.Name = "InfoIDTextBox"
        Me.InfoIDTextBox.ReadOnly = True
        Me.InfoIDTextBox.Size = New System.Drawing.Size(47, 20)
        Me.InfoIDTextBox.TabIndex = 2
        '
        'SoldierIDTextBox
        '
        Me.SoldierIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierInfoBindingSource, "SoldierID", True))
        Me.SoldierIDTextBox.Location = New System.Drawing.Point(220, 41)
        Me.SoldierIDTextBox.Name = "SoldierIDTextBox"
        Me.SoldierIDTextBox.ReadOnly = True
        Me.SoldierIDTextBox.Size = New System.Drawing.Size(47, 20)
        Me.SoldierIDTextBox.TabIndex = 4
        '
        'DutyPositionTextBox
        '
        Me.DutyPositionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DutyPositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierInfoBindingSource, "DutyPosition", True))
        Me.DutyPositionTextBox.Location = New System.Drawing.Point(123, 144)
        Me.DutyPositionTextBox.Name = "DutyPositionTextBox"
        Me.DutyPositionTextBox.Size = New System.Drawing.Size(144, 20)
        Me.DutyPositionTextBox.TabIndex = 6
        '
        'SquadTextBox
        '
        Me.SquadTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SquadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierInfoBindingSource, "Squad", True))
        Me.SquadTextBox.Location = New System.Drawing.Point(352, 144)
        Me.SquadTextBox.Name = "SquadTextBox"
        Me.SquadTextBox.Size = New System.Drawing.Size(80, 20)
        Me.SquadTextBox.TabIndex = 8
        '
        'GenderTextBox
        '
        Me.GenderTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierInfoBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(536, 144)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(119, 20)
        Me.GenderTextBox.TabIndex = 10
        '
        'MOSTextBox
        '
        Me.MOSTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierInfoBindingSource, "MOS", True))
        Me.MOSTextBox.Location = New System.Drawing.Point(123, 185)
        Me.MOSTextBox.Name = "MOSTextBox"
        Me.MOSTextBox.Size = New System.Drawing.Size(91, 20)
        Me.MOSTextBox.TabIndex = 12
        '
        'SecurityClearanceTextBox
        '
        Me.SecurityClearanceTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SecurityClearanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierInfoBindingSource, "SecurityClearance", True))
        Me.SecurityClearanceTextBox.Location = New System.Drawing.Point(395, 185)
        Me.SecurityClearanceTextBox.Name = "SecurityClearanceTextBox"
        Me.SecurityClearanceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SecurityClearanceTextBox.TabIndex = 14
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblSoldierInfoBindingSource, "DOB", True))
        Me.DOBDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(123, 224)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(108, 20)
        Me.DOBDateTimePicker.TabIndex = 16
        Me.DOBDateTimePicker.Value = New Date(2017, 7, 16, 0, 0, 0, 0)
        '
        'BASDDateTimePicker
        '
        Me.BASDDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblSoldierInfoBindingSource, "BASD", True))
        Me.BASDDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BASDDateTimePicker.Location = New System.Drawing.Point(320, 225)
        Me.BASDDateTimePicker.Name = "BASDDateTimePicker"
        Me.BASDDateTimePicker.Size = New System.Drawing.Size(108, 20)
        Me.BASDDateTimePicker.TabIndex = 18
        Me.BASDDateTimePicker.Value = New Date(2017, 7, 16, 0, 0, 0, 0)
        '
        'ETSDateTimePicker
        '
        Me.ETSDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblSoldierInfoBindingSource, "ETS", True))
        Me.ETSDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ETSDateTimePicker.Location = New System.Drawing.Point(502, 225)
        Me.ETSDateTimePicker.Name = "ETSDateTimePicker"
        Me.ETSDateTimePicker.Size = New System.Drawing.Size(108, 20)
        Me.ETSDateTimePicker.TabIndex = 20
        Me.ETSDateTimePicker.Value = New Date(2017, 7, 16, 0, 0, 0, 0)
        '
        'BloodTypeTextBox
        '
        Me.BloodTypeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BloodTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierInfoBindingSource, "BloodType", True))
        Me.BloodTypeTextBox.Location = New System.Drawing.Point(123, 265)
        Me.BloodTypeTextBox.Name = "BloodTypeTextBox"
        Me.BloodTypeTextBox.Size = New System.Drawing.Size(59, 20)
        Me.BloodTypeTextBox.TabIndex = 22
        '
        'ReligionTextBox
        '
        Me.ReligionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ReligionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierInfoBindingSource, "Religion", True))
        Me.ReligionTextBox.Location = New System.Drawing.Point(288, 265)
        Me.ReligionTextBox.Name = "ReligionTextBox"
        Me.ReligionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ReligionTextBox.TabIndex = 24
        '
        'TblSoldierBindingSource
        '
        Me.TblSoldierBindingSource.DataMember = "tblSoldier"
        Me.TblSoldierBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'SoldierIDTextBox1
        '
        Me.SoldierIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "SoldierID", True))
        Me.SoldierIDTextBox1.Location = New System.Drawing.Point(385, 41)
        Me.SoldierIDTextBox1.Name = "SoldierIDTextBox1"
        Me.SoldierIDTextBox1.ReadOnly = True
        Me.SoldierIDTextBox1.Size = New System.Drawing.Size(47, 20)
        Me.SoldierIDTextBox1.TabIndex = 26
        '
        'RankLastTextBox
        '
        Me.RankLastTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "RankLast", True))
        Me.RankLastTextBox.Location = New System.Drawing.Point(161, 105)
        Me.RankLastTextBox.Name = "RankLastTextBox"
        Me.RankLastTextBox.ReadOnly = True
        Me.RankLastTextBox.Size = New System.Drawing.Size(185, 20)
        Me.RankLastTextBox.TabIndex = 28
        '
        'AddInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 315)
        Me.ControlBox = False
        Me.Controls.Add(RankLastLabel)
        Me.Controls.Add(Me.RankLastTextBox)
        Me.Controls.Add(SoldierIDLabel1)
        Me.Controls.Add(Me.SoldierIDTextBox1)
        Me.Controls.Add(InfoIDLabel)
        Me.Controls.Add(Me.InfoIDTextBox)
        Me.Controls.Add(SoldierIDLabel)
        Me.Controls.Add(Me.SoldierIDTextBox)
        Me.Controls.Add(DutyPositionLabel)
        Me.Controls.Add(Me.DutyPositionTextBox)
        Me.Controls.Add(SquadLabel)
        Me.Controls.Add(Me.SquadTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(MOSLabel)
        Me.Controls.Add(Me.MOSTextBox)
        Me.Controls.Add(SecurityClearanceLabel)
        Me.Controls.Add(Me.SecurityClearanceTextBox)
        Me.Controls.Add(DOBLabel)
        Me.Controls.Add(Me.DOBDateTimePicker)
        Me.Controls.Add(BASDLabel)
        Me.Controls.Add(Me.BASDDateTimePicker)
        Me.Controls.Add(ETSLabel)
        Me.Controls.Add(Me.ETSDateTimePicker)
        Me.Controls.Add(BloodTypeLabel)
        Me.Controls.Add(Me.BloodTypeTextBox)
        Me.Controls.Add(ReligionLabel)
        Me.Controls.Add(Me.ReligionTextBox)
        Me.Controls.Add(Me.TblSoldierInfoBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AddInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD/EDIT/DELETE SOLDIER INFORMATION"
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSoldierInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSoldierInfoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblSoldierInfoBindingNavigator.ResumeLayout(False)
        Me.TblSoldierInfoBindingNavigator.PerformLayout()
        CType(Me.TblSoldierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Soldier_RosterDataSet As Soldier_RosterDataSet
    Friend WithEvents TblSoldierInfoBindingSource As BindingSource
    Friend WithEvents TblSoldierInfoTableAdapter As Soldier_RosterDataSetTableAdapters.tblSoldierInfoTableAdapter
    Friend WithEvents TableAdapterManager As Soldier_RosterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblSoldierInfoBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents InfoIDTextBox As TextBox
    Friend WithEvents SoldierIDTextBox As TextBox
    Friend WithEvents DutyPositionTextBox As TextBox
    Friend WithEvents SquadTextBox As TextBox
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents MOSTextBox As TextBox
    Friend WithEvents SecurityClearanceTextBox As TextBox
    Friend WithEvents DOBDateTimePicker As DateTimePicker
    Friend WithEvents BASDDateTimePicker As DateTimePicker
    Friend WithEvents ETSDateTimePicker As DateTimePicker
    Friend WithEvents BloodTypeTextBox As TextBox
    Friend WithEvents ReligionTextBox As TextBox
    Friend WithEvents TblSoldierTableAdapter As Soldier_RosterDataSetTableAdapters.tblSoldierTableAdapter
    Friend WithEvents TblSoldierBindingSource As BindingSource
    Friend WithEvents SoldierIDTextBox1 As TextBox
    Friend WithEvents RankLastTextBox As TextBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
End Class
