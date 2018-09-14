<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRating
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
        Dim RatingIDLabel As System.Windows.Forms.Label
        Dim SoldierIDLabel As System.Windows.Forms.Label
        Dim SeniorRankLabel As System.Windows.Forms.Label
        Dim SeniorFirstNameLabel As System.Windows.Forms.Label
        Dim SeniorLastNameLabel As System.Windows.Forms.Label
        Dim RaterRankLabel As System.Windows.Forms.Label
        Dim RaterFirstNameLabel As System.Windows.Forms.Label
        Dim RaterLastNameLabel As System.Windows.Forms.Label
        Dim SoldierIDLabel1 As System.Windows.Forms.Label
        Dim RankLastLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddRating))
        Me.Soldier_RosterDataSet = New SoldierRosterSystem.Soldier_RosterDataSet()
        Me.TblRatingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblRatingTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblRatingTableAdapter()
        Me.TableAdapterManager = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.TableAdapterManager()
        Me.TblSoldierTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblSoldierTableAdapter()
        Me.TblRatingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.RatingIDTextBox = New System.Windows.Forms.TextBox()
        Me.SoldierIDTextBox = New System.Windows.Forms.TextBox()
        Me.SeniorRankTextBox = New System.Windows.Forms.TextBox()
        Me.SeniorFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.SeniorLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.RaterRankTextBox = New System.Windows.Forms.TextBox()
        Me.RaterFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.RaterLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.TblSoldierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SoldierIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.RankLastTextBox = New System.Windows.Forms.TextBox()
        RatingIDLabel = New System.Windows.Forms.Label()
        SoldierIDLabel = New System.Windows.Forms.Label()
        SeniorRankLabel = New System.Windows.Forms.Label()
        SeniorFirstNameLabel = New System.Windows.Forms.Label()
        SeniorLastNameLabel = New System.Windows.Forms.Label()
        RaterRankLabel = New System.Windows.Forms.Label()
        RaterFirstNameLabel = New System.Windows.Forms.Label()
        RaterLastNameLabel = New System.Windows.Forms.Label()
        SoldierIDLabel1 = New System.Windows.Forms.Label()
        RankLastLabel = New System.Windows.Forms.Label()
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRatingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRatingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblRatingBindingNavigator.SuspendLayout()
        CType(Me.TblSoldierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RatingIDLabel
        '
        RatingIDLabel.AutoSize = True
        RatingIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RatingIDLabel.Location = New System.Drawing.Point(12, 46)
        RatingIDLabel.Name = "RatingIDLabel"
        RatingIDLabel.Size = New System.Drawing.Size(71, 15)
        RatingIDLabel.TabIndex = 1
        RatingIDLabel.Text = "Rating ID:"
        '
        'SoldierIDLabel
        '
        SoldierIDLabel.AutoSize = True
        SoldierIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SoldierIDLabel.Location = New System.Drawing.Point(191, 46)
        SoldierIDLabel.Name = "SoldierIDLabel"
        SoldierIDLabel.Size = New System.Drawing.Size(75, 15)
        SoldierIDLabel.TabIndex = 3
        SoldierIDLabel.Text = "Soldier ID:"
        '
        'SeniorRankLabel
        '
        SeniorRankLabel.AutoSize = True
        SeniorRankLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SeniorRankLabel.Location = New System.Drawing.Point(12, 165)
        SeniorRankLabel.Name = "SeniorRankLabel"
        SeniorRankLabel.Size = New System.Drawing.Size(90, 15)
        SeniorRankLabel.TabIndex = 5
        SeniorRankLabel.Text = "Senior Rank:"
        '
        'SeniorFirstNameLabel
        '
        SeniorFirstNameLabel.AutoSize = True
        SeniorFirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SeniorFirstNameLabel.Location = New System.Drawing.Point(231, 165)
        SeniorFirstNameLabel.Name = "SeniorFirstNameLabel"
        SeniorFirstNameLabel.Size = New System.Drawing.Size(127, 15)
        SeniorFirstNameLabel.TabIndex = 7
        SeniorFirstNameLabel.Text = "Senior First Name:"
        '
        'SeniorLastNameLabel
        '
        SeniorLastNameLabel.AutoSize = True
        SeniorLastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SeniorLastNameLabel.Location = New System.Drawing.Point(600, 165)
        SeniorLastNameLabel.Name = "SeniorLastNameLabel"
        SeniorLastNameLabel.Size = New System.Drawing.Size(126, 15)
        SeniorLastNameLabel.TabIndex = 9
        SeniorLastNameLabel.Text = "Senior Last Name:"
        '
        'RaterRankLabel
        '
        RaterRankLabel.AutoSize = True
        RaterRankLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RaterRankLabel.Location = New System.Drawing.Point(19, 210)
        RaterRankLabel.Name = "RaterRankLabel"
        RaterRankLabel.Size = New System.Drawing.Size(83, 15)
        RaterRankLabel.TabIndex = 11
        RaterRankLabel.Text = "Rater Rank:"
        '
        'RaterFirstNameLabel
        '
        RaterFirstNameLabel.AutoSize = True
        RaterFirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RaterFirstNameLabel.Location = New System.Drawing.Point(238, 210)
        RaterFirstNameLabel.Name = "RaterFirstNameLabel"
        RaterFirstNameLabel.Size = New System.Drawing.Size(120, 15)
        RaterFirstNameLabel.TabIndex = 13
        RaterFirstNameLabel.Text = "Rater First Name:"
        '
        'RaterLastNameLabel
        '
        RaterLastNameLabel.AutoSize = True
        RaterLastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RaterLastNameLabel.Location = New System.Drawing.Point(607, 210)
        RaterLastNameLabel.Name = "RaterLastNameLabel"
        RaterLastNameLabel.Size = New System.Drawing.Size(119, 15)
        RaterLastNameLabel.TabIndex = 15
        RaterLastNameLabel.Text = "Rater Last Name:"
        '
        'SoldierIDLabel1
        '
        SoldierIDLabel1.AutoSize = True
        SoldierIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SoldierIDLabel1.Location = New System.Drawing.Point(359, 46)
        SoldierIDLabel1.Name = "SoldierIDLabel1"
        SoldierIDLabel1.Size = New System.Drawing.Size(75, 15)
        SoldierIDLabel1.TabIndex = 17
        SoldierIDLabel1.Text = "Soldier ID:"
        '
        'RankLastLabel
        '
        RankLastLabel.AutoSize = True
        RankLastLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RankLastLabel.Location = New System.Drawing.Point(350, 92)
        RankLastLabel.Name = "RankLastLabel"
        RankLastLabel.Size = New System.Drawing.Size(67, 15)
        RankLastLabel.TabIndex = 21
        RankLastLabel.Text = "SOLDIER"
        '
        'Soldier_RosterDataSet
        '
        Me.Soldier_RosterDataSet.DataSetName = "Soldier_RosterDataSet"
        Me.Soldier_RosterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblRatingBindingSource
        '
        Me.TblRatingBindingSource.DataMember = "tblRating"
        Me.TblRatingBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'TblRatingTableAdapter
        '
        Me.TblRatingTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblRatingTableAdapter = Me.TblRatingTableAdapter
        Me.TableAdapterManager.tblSoldierInfoTableAdapter = Nothing
        Me.TableAdapterManager.tblSoldierTableAdapter = Me.TblSoldierTableAdapter
        Me.TableAdapterManager.tblTrainingTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblSoldierTableAdapter
        '
        Me.TblSoldierTableAdapter.ClearBeforeFill = True
        '
        'TblRatingBindingNavigator
        '
        Me.TblRatingBindingNavigator.AddNewItem = Nothing
        Me.TblRatingBindingNavigator.BindingSource = Me.TblRatingBindingSource
        Me.TblRatingBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblRatingBindingNavigator.DeleteItem = Nothing
        Me.TblRatingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator1, Me.ToolStripButton4})
        Me.TblRatingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblRatingBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblRatingBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblRatingBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblRatingBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblRatingBindingNavigator.Name = "TblRatingBindingNavigator"
        Me.TblRatingBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblRatingBindingNavigator.Size = New System.Drawing.Size(926, 25)
        Me.TblRatingBindingNavigator.TabIndex = 0
        Me.TblRatingBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Padding = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.ToolStripButton1.Size = New System.Drawing.Size(56, 22)
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
        Me.ToolStripButton4.Size = New System.Drawing.Size(153, 22)
        Me.ToolStripButton4.Text = "&RATING SCHEME FORM"
        Me.ToolStripButton4.ToolTipText = "ALT+R"
        '
        'RatingIDTextBox
        '
        Me.RatingIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRatingBindingSource, "RatingID", True))
        Me.RatingIDTextBox.Location = New System.Drawing.Point(89, 45)
        Me.RatingIDTextBox.Name = "RatingIDTextBox"
        Me.RatingIDTextBox.ReadOnly = True
        Me.RatingIDTextBox.Size = New System.Drawing.Size(60, 20)
        Me.RatingIDTextBox.TabIndex = 2
        '
        'SoldierIDTextBox
        '
        Me.SoldierIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRatingBindingSource, "SoldierID", True))
        Me.SoldierIDTextBox.Location = New System.Drawing.Point(272, 45)
        Me.SoldierIDTextBox.Name = "SoldierIDTextBox"
        Me.SoldierIDTextBox.ReadOnly = True
        Me.SoldierIDTextBox.Size = New System.Drawing.Size(60, 20)
        Me.SoldierIDTextBox.TabIndex = 4
        '
        'SeniorRankTextBox
        '
        Me.SeniorRankTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SeniorRankTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRatingBindingSource, "SeniorRank", True))
        Me.SeniorRankTextBox.Location = New System.Drawing.Point(108, 164)
        Me.SeniorRankTextBox.Name = "SeniorRankTextBox"
        Me.SeniorRankTextBox.Size = New System.Drawing.Size(85, 20)
        Me.SeniorRankTextBox.TabIndex = 6
        '
        'SeniorFirstNameTextBox
        '
        Me.SeniorFirstNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SeniorFirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRatingBindingSource, "SeniorFirstName", True))
        Me.SeniorFirstNameTextBox.Location = New System.Drawing.Point(376, 164)
        Me.SeniorFirstNameTextBox.Name = "SeniorFirstNameTextBox"
        Me.SeniorFirstNameTextBox.Size = New System.Drawing.Size(178, 20)
        Me.SeniorFirstNameTextBox.TabIndex = 8
        '
        'SeniorLastNameTextBox
        '
        Me.SeniorLastNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SeniorLastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRatingBindingSource, "SeniorLastName", True))
        Me.SeniorLastNameTextBox.Location = New System.Drawing.Point(732, 164)
        Me.SeniorLastNameTextBox.Name = "SeniorLastNameTextBox"
        Me.SeniorLastNameTextBox.Size = New System.Drawing.Size(178, 20)
        Me.SeniorLastNameTextBox.TabIndex = 10
        '
        'RaterRankTextBox
        '
        Me.RaterRankTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RaterRankTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRatingBindingSource, "RaterRank", True))
        Me.RaterRankTextBox.Location = New System.Drawing.Point(108, 209)
        Me.RaterRankTextBox.Name = "RaterRankTextBox"
        Me.RaterRankTextBox.Size = New System.Drawing.Size(85, 20)
        Me.RaterRankTextBox.TabIndex = 12
        '
        'RaterFirstNameTextBox
        '
        Me.RaterFirstNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RaterFirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRatingBindingSource, "RaterFirstName", True))
        Me.RaterFirstNameTextBox.Location = New System.Drawing.Point(376, 209)
        Me.RaterFirstNameTextBox.Name = "RaterFirstNameTextBox"
        Me.RaterFirstNameTextBox.Size = New System.Drawing.Size(178, 20)
        Me.RaterFirstNameTextBox.TabIndex = 14
        '
        'RaterLastNameTextBox
        '
        Me.RaterLastNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RaterLastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblRatingBindingSource, "RaterLastName", True))
        Me.RaterLastNameTextBox.Location = New System.Drawing.Point(732, 209)
        Me.RaterLastNameTextBox.Name = "RaterLastNameTextBox"
        Me.RaterLastNameTextBox.Size = New System.Drawing.Size(178, 20)
        Me.RaterLastNameTextBox.TabIndex = 16
        '
        'TblSoldierBindingSource
        '
        Me.TblSoldierBindingSource.DataMember = "tblSoldier"
        Me.TblSoldierBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'SoldierIDTextBox1
        '
        Me.SoldierIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "SoldierID", True))
        Me.SoldierIDTextBox1.Location = New System.Drawing.Point(440, 45)
        Me.SoldierIDTextBox1.Name = "SoldierIDTextBox1"
        Me.SoldierIDTextBox1.ReadOnly = True
        Me.SoldierIDTextBox1.Size = New System.Drawing.Size(60, 20)
        Me.SoldierIDTextBox1.TabIndex = 18
        '
        'RankLastTextBox
        '
        Me.RankLastTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "RankLast", True))
        Me.RankLastTextBox.Location = New System.Drawing.Point(292, 110)
        Me.RankLastTextBox.Name = "RankLastTextBox"
        Me.RankLastTextBox.ReadOnly = True
        Me.RankLastTextBox.Size = New System.Drawing.Size(198, 20)
        Me.RankLastTextBox.TabIndex = 22
        '
        'AddRating
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 244)
        Me.ControlBox = False
        Me.Controls.Add(RankLastLabel)
        Me.Controls.Add(Me.RankLastTextBox)
        Me.Controls.Add(SoldierIDLabel1)
        Me.Controls.Add(Me.SoldierIDTextBox1)
        Me.Controls.Add(RatingIDLabel)
        Me.Controls.Add(Me.RatingIDTextBox)
        Me.Controls.Add(SoldierIDLabel)
        Me.Controls.Add(Me.SoldierIDTextBox)
        Me.Controls.Add(SeniorRankLabel)
        Me.Controls.Add(Me.SeniorRankTextBox)
        Me.Controls.Add(SeniorFirstNameLabel)
        Me.Controls.Add(Me.SeniorFirstNameTextBox)
        Me.Controls.Add(SeniorLastNameLabel)
        Me.Controls.Add(Me.SeniorLastNameTextBox)
        Me.Controls.Add(RaterRankLabel)
        Me.Controls.Add(Me.RaterRankTextBox)
        Me.Controls.Add(RaterFirstNameLabel)
        Me.Controls.Add(Me.RaterFirstNameTextBox)
        Me.Controls.Add(RaterLastNameLabel)
        Me.Controls.Add(Me.RaterLastNameTextBox)
        Me.Controls.Add(Me.TblRatingBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AddRating"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD RATING SCHEME FORM"
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRatingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRatingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblRatingBindingNavigator.ResumeLayout(False)
        Me.TblRatingBindingNavigator.PerformLayout()
        CType(Me.TblSoldierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Soldier_RosterDataSet As Soldier_RosterDataSet
    Friend WithEvents TblRatingBindingSource As BindingSource
    Friend WithEvents TblRatingTableAdapter As Soldier_RosterDataSetTableAdapters.tblRatingTableAdapter
    Friend WithEvents TableAdapterManager As Soldier_RosterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblRatingBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TblSoldierTableAdapter As Soldier_RosterDataSetTableAdapters.tblSoldierTableAdapter
    Friend WithEvents RatingIDTextBox As TextBox
    Friend WithEvents SoldierIDTextBox As TextBox
    Friend WithEvents SeniorRankTextBox As TextBox
    Friend WithEvents SeniorFirstNameTextBox As TextBox
    Friend WithEvents SeniorLastNameTextBox As TextBox
    Friend WithEvents RaterRankTextBox As TextBox
    Friend WithEvents RaterFirstNameTextBox As TextBox
    Friend WithEvents RaterLastNameTextBox As TextBox
    Friend WithEvents TblSoldierBindingSource As BindingSource
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents SoldierIDTextBox1 As TextBox
    Friend WithEvents RankLastTextBox As TextBox
End Class
