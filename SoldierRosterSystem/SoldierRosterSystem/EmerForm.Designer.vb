<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmerForm
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
        Dim EmergIDLabel As System.Windows.Forms.Label
        Dim SoldierIDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim AptLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim ZipLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim RelationShipLabel As System.Windows.Forms.Label
        Dim SoldierIDLabel1 As System.Windows.Forms.Label
        Dim RankLastLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmerForm))
        Me.Soldier_RosterDataSet = New SoldierRosterSystem.Soldier_RosterDataSet()
        Me.TblEmergencyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblEmergencyTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblEmergencyTableAdapter()
        Me.TableAdapterManager = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.TableAdapterManager()
        Me.TblSoldierTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblSoldierTableAdapter()
        Me.TblEmergencyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.EmergIDTextBox = New System.Windows.Forms.TextBox()
        Me.SoldierIDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.AptTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateComboBox = New System.Windows.Forms.ComboBox()
        Me.ZipMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TelephoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.RelationShipTextBox = New System.Windows.Forms.TextBox()
        Me.TblSoldierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SoldierIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.RankLastTextBox = New System.Windows.Forms.TextBox()
        EmergIDLabel = New System.Windows.Forms.Label()
        SoldierIDLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        AptLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        ZipLabel = New System.Windows.Forms.Label()
        TelephoneLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        RelationShipLabel = New System.Windows.Forms.Label()
        SoldierIDLabel1 = New System.Windows.Forms.Label()
        RankLastLabel = New System.Windows.Forms.Label()
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmergencyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmergencyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblEmergencyBindingNavigator.SuspendLayout()
        CType(Me.TblSoldierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmergIDLabel
        '
        EmergIDLabel.AutoSize = True
        EmergIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmergIDLabel.Location = New System.Drawing.Point(21, 37)
        EmergIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmergIDLabel.Name = "EmergIDLabel"
        EmergIDLabel.Size = New System.Drawing.Size(71, 15)
        EmergIDLabel.TabIndex = 1
        EmergIDLabel.Text = "Emerg ID:"
        '
        'SoldierIDLabel
        '
        SoldierIDLabel.AutoSize = True
        SoldierIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SoldierIDLabel.Location = New System.Drawing.Point(196, 37)
        SoldierIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SoldierIDLabel.Name = "SoldierIDLabel"
        SoldierIDLabel.Size = New System.Drawing.Size(75, 15)
        SoldierIDLabel.TabIndex = 3
        SoldierIDLabel.Text = "Soldier ID:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.Location = New System.Drawing.Point(11, 150)
        FirstNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(81, 15)
        FirstNameLabel.TabIndex = 5
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel.Location = New System.Drawing.Point(295, 150)
        LastNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(80, 15)
        LastNameLabel.TabIndex = 7
        LastNameLabel.Text = "Last Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(29, 185)
        AddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(62, 15)
        AddressLabel.TabIndex = 9
        AddressLabel.Text = "Address:"
        '
        'AptLabel
        '
        AptLabel.AutoSize = True
        AptLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AptLabel.Location = New System.Drawing.Point(338, 185)
        AptLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AptLabel.Name = "AptLabel"
        AptLabel.Size = New System.Drawing.Size(31, 15)
        AptLabel.TabIndex = 11
        AptLabel.Text = "Apt:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CityLabel.Location = New System.Drawing.Point(458, 185)
        CityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(34, 15)
        CityLabel.TabIndex = 13
        CityLabel.Text = "City:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StateLabel.Location = New System.Drawing.Point(44, 218)
        StateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(44, 15)
        StateLabel.TabIndex = 15
        StateLabel.Text = "State:"
        '
        'ZipLabel
        '
        ZipLabel.AutoSize = True
        ZipLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ZipLabel.Location = New System.Drawing.Point(196, 218)
        ZipLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ZipLabel.Name = "ZipLabel"
        ZipLabel.Size = New System.Drawing.Size(31, 15)
        ZipLabel.TabIndex = 17
        ZipLabel.Text = "Zip:"
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelephoneLabel.Location = New System.Drawing.Point(347, 218)
        TelephoneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(79, 15)
        TelephoneLabel.TabIndex = 19
        TelephoneLabel.Text = "Telephone:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(40, 252)
        EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(48, 15)
        EmailLabel.TabIndex = 21
        EmailLabel.Text = "Email:"
        '
        'RelationShipLabel
        '
        RelationShipLabel.AutoSize = True
        RelationShipLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RelationShipLabel.Location = New System.Drawing.Point(351, 249)
        RelationShipLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RelationShipLabel.Name = "RelationShipLabel"
        RelationShipLabel.Size = New System.Drawing.Size(98, 15)
        RelationShipLabel.TabIndex = 23
        RelationShipLabel.Text = "Relation Ship:"
        '
        'SoldierIDLabel1
        '
        SoldierIDLabel1.AutoSize = True
        SoldierIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SoldierIDLabel1.Location = New System.Drawing.Point(351, 37)
        SoldierIDLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SoldierIDLabel1.Name = "SoldierIDLabel1"
        SoldierIDLabel1.Size = New System.Drawing.Size(75, 15)
        SoldierIDLabel1.TabIndex = 25
        SoldierIDLabel1.Text = "Soldier ID:"
        '
        'RankLastLabel
        '
        RankLastLabel.AutoSize = True
        RankLastLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RankLastLabel.Location = New System.Drawing.Point(248, 84)
        RankLastLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        'TblEmergencyBindingSource
        '
        Me.TblEmergencyBindingSource.DataMember = "tblEmergency"
        Me.TblEmergencyBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'TblEmergencyTableAdapter
        '
        Me.TblEmergencyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminLoginTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BMITableAdapter = Nothing
        Me.TableAdapterManager.MainLoginTableAdapter = Nothing
        Me.TableAdapterManager.tblEmergencyTableAdapter = Me.TblEmergencyTableAdapter
        Me.TableAdapterManager.tblFamilyTableAdapter = Nothing
        Me.TableAdapterManager.tblLicenseTableAdapter = Nothing
        Me.TableAdapterManager.tblNCOERTableAdapter = Nothing
        Me.TableAdapterManager.tblPropertyTableAdapter = Nothing
        Me.TableAdapterManager.tblRatingTableAdapter = Nothing
        Me.TableAdapterManager.tblSoldierInfoTableAdapter = Nothing
        Me.TableAdapterManager.tblSoldierTableAdapter = Me.TblSoldierTableAdapter
        Me.TableAdapterManager.tblTrainingTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblSoldierTableAdapter
        '
        Me.TblSoldierTableAdapter.ClearBeforeFill = True
        '
        'TblEmergencyBindingNavigator
        '
        Me.TblEmergencyBindingNavigator.AddNewItem = Nothing
        Me.TblEmergencyBindingNavigator.BindingSource = Me.TblEmergencyBindingSource
        Me.TblEmergencyBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblEmergencyBindingNavigator.DeleteItem = Nothing
        Me.TblEmergencyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator1, Me.ToolStripButton5})
        Me.TblEmergencyBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblEmergencyBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblEmergencyBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblEmergencyBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblEmergencyBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblEmergencyBindingNavigator.Name = "TblEmergencyBindingNavigator"
        Me.TblEmergencyBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblEmergencyBindingNavigator.Size = New System.Drawing.Size(705, 25)
        Me.TblEmergencyBindingNavigator.TabIndex = 0
        Me.TblEmergencyBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(57, 23)
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
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(108, 22)
        Me.ToolStripButton5.Text = "S&OLDIER FORM"
        Me.ToolStripButton5.ToolTipText = "ALT+O"
        '
        'EmergIDTextBox
        '
        Me.EmergIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmergencyBindingSource, "EmergID", True))
        Me.EmergIDTextBox.Location = New System.Drawing.Point(100, 34)
        Me.EmergIDTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EmergIDTextBox.Name = "EmergIDTextBox"
        Me.EmergIDTextBox.ReadOnly = True
        Me.EmergIDTextBox.Size = New System.Drawing.Size(56, 21)
        Me.EmergIDTextBox.TabIndex = 2
        '
        'SoldierIDTextBox
        '
        Me.SoldierIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmergencyBindingSource, "SoldierID", True))
        Me.SoldierIDTextBox.Location = New System.Drawing.Point(279, 34)
        Me.SoldierIDTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SoldierIDTextBox.Name = "SoldierIDTextBox"
        Me.SoldierIDTextBox.ReadOnly = True
        Me.SoldierIDTextBox.Size = New System.Drawing.Size(56, 21)
        Me.SoldierIDTextBox.TabIndex = 4
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmergencyBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(100, 147)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(173, 21)
        Me.FirstNameTextBox.TabIndex = 6
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmergencyBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(383, 147)
        Me.LastNameTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(173, 21)
        Me.LastNameTextBox.TabIndex = 8
        '
        'AddressTextBox
        '
        Me.AddressTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmergencyBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(100, 182)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(193, 21)
        Me.AddressTextBox.TabIndex = 10
        '
        'AptTextBox
        '
        Me.AptTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AptTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmergencyBindingSource, "Apt", True))
        Me.AptTextBox.Location = New System.Drawing.Point(371, 182)
        Me.AptTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AptTextBox.Name = "AptTextBox"
        Me.AptTextBox.Size = New System.Drawing.Size(58, 21)
        Me.AptTextBox.TabIndex = 12
        '
        'CityTextBox
        '
        Me.CityTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmergencyBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(494, 182)
        Me.CityTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(173, 21)
        Me.CityTextBox.TabIndex = 14
        '
        'StateComboBox
        '
        Me.StateComboBox.AutoCompleteCustomSource.AddRange(New String() {"AL      ", "AK      ", "AZ      ", "AR      ", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY", "DC", "AA", "AP", "AE"})
        Me.StateComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.StateComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.StateComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmergencyBindingSource, "State", True))
        Me.StateComboBox.FormattingEnabled = True
        Me.StateComboBox.Location = New System.Drawing.Point(89, 215)
        Me.StateComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StateComboBox.Name = "StateComboBox"
        Me.StateComboBox.Size = New System.Drawing.Size(71, 23)
        Me.StateComboBox.TabIndex = 16
        '
        'ZipMaskedTextBox
        '
        Me.ZipMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmergencyBindingSource, "Zip", True))
        Me.ZipMaskedTextBox.Location = New System.Drawing.Point(230, 215)
        Me.ZipMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ZipMaskedTextBox.Mask = "00000-9999"
        Me.ZipMaskedTextBox.Name = "ZipMaskedTextBox"
        Me.ZipMaskedTextBox.Size = New System.Drawing.Size(95, 21)
        Me.ZipMaskedTextBox.TabIndex = 18
        '
        'TelephoneMaskedTextBox
        '
        Me.TelephoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmergencyBindingSource, "Telephone", True))
        Me.TelephoneMaskedTextBox.Location = New System.Drawing.Point(434, 215)
        Me.TelephoneMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TelephoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.TelephoneMaskedTextBox.Name = "TelephoneMaskedTextBox"
        Me.TelephoneMaskedTextBox.Size = New System.Drawing.Size(109, 21)
        Me.TelephoneMaskedTextBox.TabIndex = 20
        '
        'EmailTextBox
        '
        Me.EmailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmergencyBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(89, 246)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(236, 21)
        Me.EmailTextBox.TabIndex = 22
        '
        'RelationShipTextBox
        '
        Me.RelationShipTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RelationShipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEmergencyBindingSource, "RelationShip", True))
        Me.RelationShipTextBox.Location = New System.Drawing.Point(457, 249)
        Me.RelationShipTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RelationShipTextBox.Name = "RelationShipTextBox"
        Me.RelationShipTextBox.Size = New System.Drawing.Size(140, 21)
        Me.RelationShipTextBox.TabIndex = 24
        '
        'TblSoldierBindingSource
        '
        Me.TblSoldierBindingSource.DataMember = "tblSoldier"
        Me.TblSoldierBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'SoldierIDTextBox1
        '
        Me.SoldierIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "SoldierID", True))
        Me.SoldierIDTextBox1.Location = New System.Drawing.Point(428, 34)
        Me.SoldierIDTextBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SoldierIDTextBox1.Name = "SoldierIDTextBox1"
        Me.SoldierIDTextBox1.ReadOnly = True
        Me.SoldierIDTextBox1.Size = New System.Drawing.Size(56, 21)
        Me.SoldierIDTextBox1.TabIndex = 26
        '
        'RankLastTextBox
        '
        Me.RankLastTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "RankLast", True))
        Me.RankLastTextBox.Location = New System.Drawing.Point(176, 102)
        Me.RankLastTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RankLastTextBox.Name = "RankLastTextBox"
        Me.RankLastTextBox.ReadOnly = True
        Me.RankLastTextBox.Size = New System.Drawing.Size(220, 21)
        Me.RankLastTextBox.TabIndex = 28
        '
        'EmerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 296)
        Me.ControlBox = False
        Me.Controls.Add(RankLastLabel)
        Me.Controls.Add(Me.RankLastTextBox)
        Me.Controls.Add(SoldierIDLabel1)
        Me.Controls.Add(Me.SoldierIDTextBox1)
        Me.Controls.Add(EmergIDLabel)
        Me.Controls.Add(Me.EmergIDTextBox)
        Me.Controls.Add(SoldierIDLabel)
        Me.Controls.Add(Me.SoldierIDTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(AptLabel)
        Me.Controls.Add(Me.AptTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateComboBox)
        Me.Controls.Add(ZipLabel)
        Me.Controls.Add(Me.ZipMaskedTextBox)
        Me.Controls.Add(TelephoneLabel)
        Me.Controls.Add(Me.TelephoneMaskedTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(RelationShipLabel)
        Me.Controls.Add(Me.RelationShipTextBox)
        Me.Controls.Add(Me.TblEmergencyBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "EmerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SOLDIER'S EMERGENCY CONTACT FORM"
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmergencyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmergencyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblEmergencyBindingNavigator.ResumeLayout(False)
        Me.TblEmergencyBindingNavigator.PerformLayout()
        CType(Me.TblSoldierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Soldier_RosterDataSet As Soldier_RosterDataSet
    Friend WithEvents TblEmergencyBindingSource As BindingSource
    Friend WithEvents TblEmergencyTableAdapter As Soldier_RosterDataSetTableAdapters.tblEmergencyTableAdapter
    Friend WithEvents TableAdapterManager As Soldier_RosterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblEmergencyBindingNavigator As BindingNavigator
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
    Friend WithEvents EmergIDTextBox As TextBox
    Friend WithEvents SoldierIDTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents AptTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateComboBox As ComboBox
    Friend WithEvents ZipMaskedTextBox As MaskedTextBox
    Friend WithEvents TelephoneMaskedTextBox As MaskedTextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents RelationShipTextBox As TextBox
    Friend WithEvents TblSoldierBindingSource As BindingSource
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents SoldierIDTextBox1 As TextBox
    Friend WithEvents RankLastTextBox As TextBox
End Class
