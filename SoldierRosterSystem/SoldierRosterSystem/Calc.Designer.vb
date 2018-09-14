<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calc
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
        Dim BMIIDLabel As System.Windows.Forms.Label
        Dim RankLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim AGELabel As System.Windows.Forms.Label
        Dim WEIGHTLabel As System.Windows.Forms.Label
        Dim HEIGHTLabel As System.Windows.Forms.Label
        Dim NECKLabel As System.Windows.Forms.Label
        Dim FATLabel As System.Windows.Forms.Label
        Dim GENDERLabel As System.Windows.Forms.Label
        Dim APFT_TESTLabel As System.Windows.Forms.Label
        Dim RanLastLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calc))
        Me.BMIBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BMIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Soldier_RosterDataSet = New SoldierRosterSystem.Soldier_RosterDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.NumID = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.BMIIDTextBox = New System.Windows.Forms.TextBox()
        Me.RankTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.AGETextBox = New System.Windows.Forms.TextBox()
        Me.WEIGHTTextBox = New System.Windows.Forms.TextBox()
        Me.HEIGHTTextBox = New System.Windows.Forms.TextBox()
        Me.NECKTextBox = New System.Windows.Forms.TextBox()
        Me.WAISTTextBox = New System.Windows.Forms.TextBox()
        Me.HIPSTextBox = New System.Windows.Forms.TextBox()
        Me.FATTextBox = New System.Windows.Forms.TextBox()
        Me.GENDERComboBox = New System.Windows.Forms.ComboBox()
        Me.APFTTESTDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.lblCompliance = New System.Windows.Forms.Label()
        Me.lblAllowFat = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblFat = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblRange = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblDifference = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblHips = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAbs = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk1720 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk2127 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblH = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chk2839 = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chk40 = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkFam1720 = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chkFam2127 = New System.Windows.Forms.CheckBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.chkFam2839 = New System.Windows.Forms.CheckBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.chkFam40 = New System.Windows.Forms.CheckBox()
        Me.RanLastTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BMITableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.BMITableAdapter()
        Me.TableAdapterManager = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.TableAdapterManager()
        Me.ComplienceTextBox = New System.Windows.Forms.TextBox()
        BMIIDLabel = New System.Windows.Forms.Label()
        RankLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        AGELabel = New System.Windows.Forms.Label()
        WEIGHTLabel = New System.Windows.Forms.Label()
        HEIGHTLabel = New System.Windows.Forms.Label()
        NECKLabel = New System.Windows.Forms.Label()
        FATLabel = New System.Windows.Forms.Label()
        GENDERLabel = New System.Windows.Forms.Label()
        APFT_TESTLabel = New System.Windows.Forms.Label()
        RanLastLabel = New System.Windows.Forms.Label()
        CType(Me.BMIBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BMIBindingNavigator.SuspendLayout()
        CType(Me.BMIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'BMIIDLabel
        '
        BMIIDLabel.AutoSize = True
        BMIIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BMIIDLabel.Location = New System.Drawing.Point(12, 48)
        BMIIDLabel.Name = "BMIIDLabel"
        BMIIDLabel.Size = New System.Drawing.Size(46, 13)
        BMIIDLabel.TabIndex = 1
        BMIIDLabel.Text = "BMIID:"
        '
        'RankLabel
        '
        RankLabel.AutoSize = True
        RankLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RankLabel.Location = New System.Drawing.Point(12, 88)
        RankLabel.Name = "RankLabel"
        RankLabel.Size = New System.Drawing.Size(41, 13)
        RankLabel.TabIndex = 3
        RankLabel.Text = "Rank:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel.Location = New System.Drawing.Point(415, 88)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(71, 13)
        LastNameLabel.TabIndex = 5
        LastNameLabel.Text = "Last Name:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.Location = New System.Drawing.Point(159, 88)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(71, 13)
        FirstNameLabel.TabIndex = 7
        FirstNameLabel.Text = "First Name:"
        '
        'AGELabel
        '
        AGELabel.AutoSize = True
        AGELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AGELabel.Location = New System.Drawing.Point(17, 172)
        AGELabel.Name = "AGELabel"
        AGELabel.Size = New System.Drawing.Size(36, 13)
        AGELabel.TabIndex = 9
        AGELabel.Text = "AGE:"
        '
        'WEIGHTLabel
        '
        WEIGHTLabel.AutoSize = True
        WEIGHTLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WEIGHTLabel.Location = New System.Drawing.Point(30, 256)
        WEIGHTLabel.Name = "WEIGHTLabel"
        WEIGHTLabel.Size = New System.Drawing.Size(57, 13)
        WEIGHTLabel.TabIndex = 11
        WEIGHTLabel.Text = "WEIGHT"
        '
        'HEIGHTLabel
        '
        HEIGHTLabel.AutoSize = True
        HEIGHTLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HEIGHTLabel.Location = New System.Drawing.Point(30, 216)
        HEIGHTLabel.Name = "HEIGHTLabel"
        HEIGHTLabel.Size = New System.Drawing.Size(54, 13)
        HEIGHTLabel.TabIndex = 13
        HEIGHTLabel.Text = "HEIGHT"
        '
        'NECKLabel
        '
        NECKLabel.AutoSize = True
        NECKLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NECKLabel.Location = New System.Drawing.Point(32, 376)
        NECKLabel.Name = "NECKLabel"
        NECKLabel.Size = New System.Drawing.Size(40, 13)
        NECKLabel.TabIndex = 15
        NECKLabel.Text = "NECK"
        '
        'FATLabel
        '
        FATLabel.AutoSize = True
        FATLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FATLabel.Location = New System.Drawing.Point(34, 428)
        FATLabel.Name = "FATLabel"
        FATLabel.Size = New System.Drawing.Size(47, 13)
        FATLabel.TabIndex = 21
        FATLabel.Text = "FAT %:"
        '
        'GENDERLabel
        '
        GENDERLabel.AutoSize = True
        GENDERLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GENDERLabel.Location = New System.Drawing.Point(18, 129)
        GENDERLabel.Name = "GENDERLabel"
        GENDERLabel.Size = New System.Drawing.Size(63, 13)
        GENDERLabel.TabIndex = 23
        GENDERLabel.Text = "GENDER:"
        '
        'APFT_TESTLabel
        '
        APFT_TESTLabel.AutoSize = True
        APFT_TESTLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        APFT_TESTLabel.Location = New System.Drawing.Point(13, 484)
        APFT_TESTLabel.Name = "APFT_TESTLabel"
        APFT_TESTLabel.Size = New System.Drawing.Size(78, 13)
        APFT_TESTLabel.TabIndex = 25
        APFT_TESTLabel.Text = "APFT TEST:"
        '
        'RanLastLabel
        '
        RanLastLabel.AutoSize = True
        RanLastLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RanLastLabel.Location = New System.Drawing.Point(648, 43)
        RanLastLabel.Name = "RanLastLabel"
        RanLastLabel.Size = New System.Drawing.Size(93, 13)
        RanLastLabel.TabIndex = 66
        RanLastLabel.Text = "ID RANK LAST"
        '
        'BMIBindingNavigator
        '
        Me.BMIBindingNavigator.AddNewItem = Nothing
        Me.BMIBindingNavigator.BindingSource = Me.BMIBindingSource
        Me.BMIBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BMIBindingNavigator.DeleteItem = Nothing
        Me.BMIBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.NumID, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.BMIBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BMIBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BMIBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BMIBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BMIBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BMIBindingNavigator.Name = "BMIBindingNavigator"
        Me.BMIBindingNavigator.PositionItem = Me.NumID
        Me.BMIBindingNavigator.Size = New System.Drawing.Size(818, 25)
        Me.BMIBindingNavigator.TabIndex = 0
        Me.BMIBindingNavigator.Text = "BindingNavigator1"
        '
        'BMIBindingSource
        '
        Me.BMIBindingSource.DataMember = "BMI"
        Me.BMIBindingSource.DataSource = Me.Soldier_RosterDataSet
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
        'NumID
        '
        Me.NumID.AccessibleName = "Position"
        Me.NumID.AutoSize = False
        Me.NumID.Name = "NumID"
        Me.NumID.Size = New System.Drawing.Size(50, 23)
        Me.NumID.Text = "0"
        Me.NumID.ToolTipText = "Current position"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(0, 1, 6, 2)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripButton1.Text = "ADD"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(0, 1, 6, 2)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(58, 22)
        Me.ToolStripButton2.Text = "SAVE"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Margin = New System.Windows.Forms.Padding(0, 1, 6, 2)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(71, 22)
        Me.ToolStripButton3.Text = "DELETE"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripButton4.Text = "EXIT"
        '
        'BMIIDTextBox
        '
        Me.BMIIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BMIBindingSource, "BMIID", True))
        Me.BMIIDTextBox.Location = New System.Drawing.Point(64, 45)
        Me.BMIIDTextBox.Name = "BMIIDTextBox"
        Me.BMIIDTextBox.ReadOnly = True
        Me.BMIIDTextBox.Size = New System.Drawing.Size(44, 20)
        Me.BMIIDTextBox.TabIndex = 2
        '
        'RankTextBox
        '
        Me.RankTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RankTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BMIBindingSource, "Rank", True))
        Me.RankTextBox.Location = New System.Drawing.Point(59, 85)
        Me.RankTextBox.Name = "RankTextBox"
        Me.RankTextBox.Size = New System.Drawing.Size(80, 20)
        Me.RankTextBox.TabIndex = 3
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BMIBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(492, 85)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(161, 20)
        Me.LastNameTextBox.TabIndex = 5
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BMIBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(236, 85)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(161, 20)
        Me.FirstNameTextBox.TabIndex = 4
        '
        'AGETextBox
        '
        Me.AGETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BMIBindingSource, "AGE", True))
        Me.AGETextBox.Location = New System.Drawing.Point(59, 169)
        Me.AGETextBox.Name = "AGETextBox"
        Me.AGETextBox.Size = New System.Drawing.Size(51, 20)
        Me.AGETextBox.TabIndex = 7
        '
        'WEIGHTTextBox
        '
        Me.WEIGHTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BMIBindingSource, "WEIGHT", True))
        Me.WEIGHTTextBox.Location = New System.Drawing.Point(33, 272)
        Me.WEIGHTTextBox.Name = "WEIGHTTextBox"
        Me.WEIGHTTextBox.Size = New System.Drawing.Size(51, 20)
        Me.WEIGHTTextBox.TabIndex = 9
        '
        'HEIGHTTextBox
        '
        Me.HEIGHTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BMIBindingSource, "HEIGHT", True))
        Me.HEIGHTTextBox.Location = New System.Drawing.Point(33, 232)
        Me.HEIGHTTextBox.Name = "HEIGHTTextBox"
        Me.HEIGHTTextBox.Size = New System.Drawing.Size(51, 20)
        Me.HEIGHTTextBox.TabIndex = 8
        '
        'NECKTextBox
        '
        Me.NECKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BMIBindingSource, "NECK", True))
        Me.NECKTextBox.Location = New System.Drawing.Point(35, 392)
        Me.NECKTextBox.Name = "NECKTextBox"
        Me.NECKTextBox.Size = New System.Drawing.Size(52, 20)
        Me.NECKTextBox.TabIndex = 12
        '
        'WAISTTextBox
        '
        Me.WAISTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BMIBindingSource, "WAIST", True))
        Me.WAISTTextBox.Location = New System.Drawing.Point(33, 314)
        Me.WAISTTextBox.Name = "WAISTTextBox"
        Me.WAISTTextBox.Size = New System.Drawing.Size(51, 20)
        Me.WAISTTextBox.TabIndex = 10
        '
        'HIPSTextBox
        '
        Me.HIPSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BMIBindingSource, "HIPS", True))
        Me.HIPSTextBox.Location = New System.Drawing.Point(33, 353)
        Me.HIPSTextBox.Name = "HIPSTextBox"
        Me.HIPSTextBox.Size = New System.Drawing.Size(51, 20)
        Me.HIPSTextBox.TabIndex = 11
        '
        'FATTextBox
        '
        Me.FATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BMIBindingSource, "FAT", True))
        Me.FATTextBox.Location = New System.Drawing.Point(82, 425)
        Me.FATTextBox.Name = "FATTextBox"
        Me.FATTextBox.Size = New System.Drawing.Size(52, 20)
        Me.FATTextBox.TabIndex = 13
        '
        'GENDERComboBox
        '
        Me.GENDERComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BMIBindingSource, "GENDER", True))
        Me.GENDERComboBox.FormattingEnabled = True
        Me.GENDERComboBox.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.GENDERComboBox.Location = New System.Drawing.Point(87, 126)
        Me.GENDERComboBox.Name = "GENDERComboBox"
        Me.GENDERComboBox.Size = New System.Drawing.Size(125, 21)
        Me.GENDERComboBox.TabIndex = 6
        '
        'APFTTESTDateTimePicker
        '
        Me.APFTTESTDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BMIBindingSource, "APFTTEST", True))
        Me.APFTTESTDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.APFTTESTDateTimePicker.Location = New System.Drawing.Point(97, 478)
        Me.APFTTESTDateTimePicker.Name = "APFTTESTDateTimePicker"
        Me.APFTTESTDateTimePicker.Size = New System.Drawing.Size(99, 20)
        Me.APFTTESTDateTimePicker.TabIndex = 14
        Me.APFTTESTDateTimePicker.Value = New Date(2018, 2, 16, 0, 0, 0, 0)
        '
        'lblCompliance
        '
        Me.lblCompliance.AutoSize = True
        Me.lblCompliance.Location = New System.Drawing.Point(171, 455)
        Me.lblCompliance.Name = "lblCompliance"
        Me.lblCompliance.Size = New System.Drawing.Size(0, 13)
        Me.lblCompliance.TabIndex = 46
        '
        'lblAllowFat
        '
        Me.lblAllowFat.AutoSize = True
        Me.lblAllowFat.Location = New System.Drawing.Point(292, 327)
        Me.lblAllowFat.Name = "lblAllowFat"
        Me.lblAllowFat.Size = New System.Drawing.Size(0, 13)
        Me.lblAllowFat.TabIndex = 45
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(201, 327)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 13)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "ACTUAL FAT:"
        '
        'lblFat
        '
        Me.lblFat.AutoSize = True
        Me.lblFat.Location = New System.Drawing.Point(292, 307)
        Me.lblFat.Name = "lblFat"
        Me.lblFat.Size = New System.Drawing.Size(0, 13)
        Me.lblFat.TabIndex = 43
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(172, 307)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 13)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "ALLOW BODY FAT:"
        '
        'lblRange
        '
        Me.lblRange.AutoSize = True
        Me.lblRange.Location = New System.Drawing.Point(292, 286)
        Me.lblRange.Name = "lblRange"
        Me.lblRange.Size = New System.Drawing.Size(0, 13)
        Me.lblRange.TabIndex = 41
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(182, 286)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 13)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "HEALTH RANGE:"
        '
        'lblDifference
        '
        Me.lblDifference.AutoSize = True
        Me.lblDifference.Location = New System.Drawing.Point(285, 265)
        Me.lblDifference.Name = "lblDifference"
        Me.lblDifference.Size = New System.Drawing.Size(0, 13)
        Me.lblDifference.TabIndex = 39
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(155, 265)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 13)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "WEIGHT DIFFERENCE:"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(285, 235)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(0, 13)
        Me.lblWeight.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(159, 235)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "SCREENING WEIGHT:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(460, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(316, 15)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "MAXIMUM BODY FAT PERCENTEGE STANDARD"
        '
        'btnCal
        '
        Me.btnCal.Location = New System.Drawing.Point(350, 455)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(92, 23)
        Me.btnCal.TabIndex = 47
        Me.btnCal.Text = "CALCULATE"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(457, 455)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 48
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblHips
        '
        Me.lblHips.AutoSize = True
        Me.lblHips.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHips.Location = New System.Drawing.Point(30, 337)
        Me.lblHips.Name = "lblHips"
        Me.lblHips.Size = New System.Drawing.Size(36, 13)
        Me.lblHips.TabIndex = 49
        Me.lblHips.Text = "HIPS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(148, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 26)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "PLEASE SELECT THE AGE GROUP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AFTER INTERING THE AGE"
        '
        'lblAbs
        '
        Me.lblAbs.AutoSize = True
        Me.lblAbs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbs.Location = New System.Drawing.Point(30, 298)
        Me.lblAbs.Name = "lblAbs"
        Me.lblAbs.Size = New System.Drawing.Size(68, 13)
        Me.lblAbs.TabIndex = 51
        Me.lblAbs.Text = "ABDOMEN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk1720)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(457, 187)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 41)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Group Age 17-20"
        '
        'chk1720
        '
        Me.chk1720.AutoSize = True
        Me.chk1720.Location = New System.Drawing.Point(11, 18)
        Me.chk1720.Name = "chk1720"
        Me.chk1720.Size = New System.Drawing.Size(123, 17)
        Me.chk1720.TabIndex = 0
        Me.chk1720.Text = "ALLOW FAT 20%"
        Me.chk1720.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk2127)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(457, 234)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(160, 41)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Group Age 21-27"
        '
        'chk2127
        '
        Me.chk2127.AutoSize = True
        Me.chk2127.Location = New System.Drawing.Point(6, 18)
        Me.chk2127.Name = "chk2127"
        Me.chk2127.Size = New System.Drawing.Size(123, 17)
        Me.chk2127.TabIndex = 0
        Me.chk2127.Text = "ALLOW FAT 22%"
        Me.chk2127.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "INCHES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "LBS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "INCHES"
        '
        'lblH
        '
        Me.lblH.AutoSize = True
        Me.lblH.Location = New System.Drawing.Point(94, 356)
        Me.lblH.Name = "lblH"
        Me.lblH.Size = New System.Drawing.Size(47, 13)
        Me.lblH.TabIndex = 57
        Me.lblH.Text = "INCHES"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(94, 395)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "INCHES"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chk2839)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(457, 282)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(160, 38)
        Me.GroupBox3.TabIndex = 59
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Group Age 28-39"
        '
        'chk2839
        '
        Me.chk2839.AutoSize = True
        Me.chk2839.Location = New System.Drawing.Point(7, 15)
        Me.chk2839.Name = "chk2839"
        Me.chk2839.Size = New System.Drawing.Size(123, 17)
        Me.chk2839.TabIndex = 0
        Me.chk2839.Text = "ALLOW FAT 24%"
        Me.chk2839.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(461, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 13)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "MALE AGE GROUP"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chk40)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(457, 326)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(160, 44)
        Me.GroupBox4.TabIndex = 61
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Group Age 40  and over"
        '
        'chk40
        '
        Me.chk40.AutoSize = True
        Me.chk40.Location = New System.Drawing.Point(7, 16)
        Me.chk40.Name = "chk40"
        Me.chk40.Size = New System.Drawing.Size(123, 17)
        Me.chk40.TabIndex = 0
        Me.chk40.Text = "ALLOW FAT 26%"
        Me.chk40.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkFam1720)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(633, 190)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(165, 38)
        Me.GroupBox5.TabIndex = 62
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Group Age 17-20"
        '
        'chkFam1720
        '
        Me.chkFam1720.AutoSize = True
        Me.chkFam1720.Location = New System.Drawing.Point(7, 16)
        Me.chkFam1720.Name = "chkFam1720"
        Me.chkFam1720.Size = New System.Drawing.Size(123, 17)
        Me.chkFam1720.TabIndex = 0
        Me.chkFam1720.Text = "ALLOW FAT 30%"
        Me.chkFam1720.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(630, 169)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(132, 13)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "FEMALE AGE GROUP"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chkFam2127)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(633, 234)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(165, 41)
        Me.GroupBox6.TabIndex = 64
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Group Age 21-27"
        '
        'chkFam2127
        '
        Me.chkFam2127.AutoSize = True
        Me.chkFam2127.Location = New System.Drawing.Point(7, 18)
        Me.chkFam2127.Name = "chkFam2127"
        Me.chkFam2127.Size = New System.Drawing.Size(123, 17)
        Me.chkFam2127.TabIndex = 0
        Me.chkFam2127.Text = "ALLOW FAT 32%"
        Me.chkFam2127.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.chkFam2839)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(633, 279)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(165, 41)
        Me.GroupBox7.TabIndex = 65
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Group Age 28-39"
        '
        'chkFam2839
        '
        Me.chkFam2839.AutoSize = True
        Me.chkFam2839.Location = New System.Drawing.Point(7, 18)
        Me.chkFam2839.Name = "chkFam2839"
        Me.chkFam2839.Size = New System.Drawing.Size(123, 17)
        Me.chkFam2839.TabIndex = 0
        Me.chkFam2839.Text = "ALLOW FAT 34%"
        Me.chkFam2839.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.chkFam40)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(633, 326)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(165, 41)
        Me.GroupBox8.TabIndex = 66
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Group Age 40 and over"
        '
        'chkFam40
        '
        Me.chkFam40.AutoSize = True
        Me.chkFam40.Location = New System.Drawing.Point(7, 20)
        Me.chkFam40.Name = "chkFam40"
        Me.chkFam40.Size = New System.Drawing.Size(123, 17)
        Me.chkFam40.TabIndex = 0
        Me.chkFam40.Text = "ALLOW FAT 36%"
        Me.chkFam40.UseVisualStyleBackColor = True
        '
        'RanLastTextBox
        '
        Me.RanLastTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BMIBindingSource, "RanLast", True))
        Me.RanLastTextBox.Location = New System.Drawing.Point(591, 59)
        Me.RanLastTextBox.Name = "RanLastTextBox"
        Me.RanLastTextBox.ReadOnly = True
        Me.RanLastTextBox.Size = New System.Drawing.Size(207, 20)
        Me.RanLastTextBox.TabIndex = 67
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(644, 455)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 23)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "BMI REPORT"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.tblmedprosTableAdapter = Nothing
        Me.TableAdapterManager.tblNCOERTableAdapter = Nothing
        Me.TableAdapterManager.tblPropertyTableAdapter = Nothing
        Me.TableAdapterManager.tblRatingTableAdapter = Nothing
        Me.TableAdapterManager.tblSoldierInfoTableAdapter = Nothing
        Me.TableAdapterManager.tblSoldierTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainingTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ComplienceTextBox
        '
        Me.ComplienceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BMIBindingSource, "Complience", True))
        Me.ComplienceTextBox.Location = New System.Drawing.Point(33, 452)
        Me.ComplienceTextBox.Name = "ComplienceTextBox"
        Me.ComplienceTextBox.Size = New System.Drawing.Size(132, 20)
        Me.ComplienceTextBox.TabIndex = 69
        '
        'Calc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 510)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComplienceTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(RanLastLabel)
        Me.Controls.Add(Me.RanLastTextBox)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblH)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblAbs)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHips)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.lblCompliance)
        Me.Controls.Add(Me.lblAllowFat)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblFat)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblRange)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblDifference)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(BMIIDLabel)
        Me.Controls.Add(Me.BMIIDTextBox)
        Me.Controls.Add(RankLabel)
        Me.Controls.Add(Me.RankTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(AGELabel)
        Me.Controls.Add(Me.AGETextBox)
        Me.Controls.Add(WEIGHTLabel)
        Me.Controls.Add(Me.WEIGHTTextBox)
        Me.Controls.Add(HEIGHTLabel)
        Me.Controls.Add(Me.HEIGHTTextBox)
        Me.Controls.Add(NECKLabel)
        Me.Controls.Add(Me.NECKTextBox)
        Me.Controls.Add(Me.WAISTTextBox)
        Me.Controls.Add(Me.HIPSTextBox)
        Me.Controls.Add(FATLabel)
        Me.Controls.Add(Me.FATTextBox)
        Me.Controls.Add(GENDERLabel)
        Me.Controls.Add(Me.GENDERComboBox)
        Me.Controls.Add(APFT_TESTLabel)
        Me.Controls.Add(Me.APFTTESTDateTimePicker)
        Me.Controls.Add(Me.BMIBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Calc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ARMY BMI CALCULATOR"
        CType(Me.BMIBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BMIBindingNavigator.ResumeLayout(False)
        Me.BMIBindingNavigator.PerformLayout()
        CType(Me.BMIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Soldier_RosterDataSet As Soldier_RosterDataSet
    Friend WithEvents BMIBindingSource As BindingSource
    Friend WithEvents BMITableAdapter As Soldier_RosterDataSetTableAdapters.BMITableAdapter
    Friend WithEvents TableAdapterManager As Soldier_RosterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BMIBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents NumID As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BMIIDTextBox As TextBox
    Friend WithEvents RankTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents AGETextBox As TextBox
    Friend WithEvents WEIGHTTextBox As TextBox
    Friend WithEvents HEIGHTTextBox As TextBox
    Friend WithEvents NECKTextBox As TextBox
    Friend WithEvents WAISTTextBox As TextBox
    Friend WithEvents HIPSTextBox As TextBox
    Friend WithEvents FATTextBox As TextBox
    Friend WithEvents GENDERComboBox As ComboBox
    Friend WithEvents APFTTESTDateTimePicker As DateTimePicker
    Friend WithEvents lblCompliance As Label
    Friend WithEvents lblAllowFat As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblFat As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblRange As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblDifference As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCal As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblHips As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAbs As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chk1720 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chk2127 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblH As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chk2839 As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents chk40 As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents chkFam1720 As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents chkFam2127 As CheckBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents chkFam2839 As CheckBox
    Friend WithEvents chkFam40 As CheckBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents RanLastTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComplienceTextBox As TextBox
End Class
