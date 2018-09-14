<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SoldierForm
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
        Dim SoldierIDLabel As System.Windows.Forms.Label
        Dim RankLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim MiddleInitialLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim AptLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim ZipLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim MarriedLabel As System.Windows.Forms.Label
        Dim SingleLabel As System.Windows.Forms.Label
        Dim LastFourLabel As System.Windows.Forms.Label
        Dim RankLastLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim SpcIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SoldierForm))
        Me.Soldier_RosterDataSet = New SoldierRosterSystem.Soldier_RosterDataSet()
        Me.TblSoldierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSoldierTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblSoldierTableAdapter()
        Me.TableAdapterManager = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.TableAdapterManager()
        Me.TblFamilyTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblFamilyTableAdapter()
        Me.TblSoldierBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.Pre = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.txtNumber = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Nxt = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.FAMILYFORMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMERGENCYFORMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.SoldierIDTextBox = New System.Windows.Forms.TextBox()
        Me.RankTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.MiddleInitialTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.AptTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateComboBox = New System.Windows.Forms.ComboBox()
        Me.ZipMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TelephoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.MarriedCheckBox = New System.Windows.Forms.CheckBox()
        Me.SingleCheckBox = New System.Windows.Forms.CheckBox()
        Me.RankLastTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMaritalStatus = New System.Windows.Forms.TextBox()
        Me.TblFamilyDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblFamilyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SpcIDTextBox = New System.Windows.Forms.TextBox()
        Me.LastFourMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        SoldierIDLabel = New System.Windows.Forms.Label()
        RankLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        MiddleInitialLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        AptLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        ZipLabel = New System.Windows.Forms.Label()
        TelephoneLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        MarriedLabel = New System.Windows.Forms.Label()
        SingleLabel = New System.Windows.Forms.Label()
        LastFourLabel = New System.Windows.Forms.Label()
        RankLastLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        SpcIDLabel = New System.Windows.Forms.Label()
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSoldierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSoldierBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblSoldierBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblFamilyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblFamilyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SoldierIDLabel
        '
        SoldierIDLabel.AutoSize = True
        SoldierIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SoldierIDLabel.Location = New System.Drawing.Point(22, 45)
        SoldierIDLabel.Name = "SoldierIDLabel"
        SoldierIDLabel.Size = New System.Drawing.Size(75, 15)
        SoldierIDLabel.TabIndex = 1
        SoldierIDLabel.Text = "Soldier ID:"
        '
        'RankLabel
        '
        RankLabel.AutoSize = True
        RankLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RankLabel.Location = New System.Drawing.Point(53, 78)
        RankLabel.Name = "RankLabel"
        RankLabel.Size = New System.Drawing.Size(44, 15)
        RankLabel.TabIndex = 3
        RankLabel.Text = "Rank:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.Location = New System.Drawing.Point(16, 109)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(81, 15)
        FirstNameLabel.TabIndex = 5
        FirstNameLabel.Text = "First Name:"
        '
        'MiddleInitialLabel
        '
        MiddleInitialLabel.AutoSize = True
        MiddleInitialLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MiddleInitialLabel.Location = New System.Drawing.Point(315, 109)
        MiddleInitialLabel.Name = "MiddleInitialLabel"
        MiddleInitialLabel.Size = New System.Drawing.Size(95, 15)
        MiddleInitialLabel.TabIndex = 7
        MiddleInitialLabel.Text = "Middle Initial:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel.Location = New System.Drawing.Point(501, 109)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(80, 15)
        LastNameLabel.TabIndex = 9
        LastNameLabel.Text = "Last Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(35, 143)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(62, 15)
        AddressLabel.TabIndex = 11
        AddressLabel.Text = "Address:"
        '
        'AptLabel
        '
        AptLabel.AutoSize = True
        AptLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AptLabel.Location = New System.Drawing.Point(379, 143)
        AptLabel.Name = "AptLabel"
        AptLabel.Size = New System.Drawing.Size(31, 15)
        AptLabel.TabIndex = 13
        AptLabel.Text = "Apt:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CityLabel.Location = New System.Drawing.Point(547, 143)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(34, 15)
        CityLabel.TabIndex = 15
        CityLabel.Text = "City:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StateLabel.Location = New System.Drawing.Point(53, 180)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(44, 15)
        StateLabel.TabIndex = 17
        StateLabel.Text = "State:"
        '
        'ZipLabel
        '
        ZipLabel.AutoSize = True
        ZipLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ZipLabel.Location = New System.Drawing.Point(209, 180)
        ZipLabel.Name = "ZipLabel"
        ZipLabel.Size = New System.Drawing.Size(31, 15)
        ZipLabel.TabIndex = 19
        ZipLabel.Text = "Zip:"
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelephoneLabel.Location = New System.Drawing.Point(366, 180)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(79, 15)
        TelephoneLabel.TabIndex = 21
        TelephoneLabel.Text = "Telephone:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(49, 218)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(48, 15)
        EmailLabel.TabIndex = 23
        EmailLabel.Text = "Email:"
        '
        'MarriedLabel
        '
        MarriedLabel.AutoSize = True
        MarriedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MarriedLabel.Location = New System.Drawing.Point(6, 21)
        MarriedLabel.Name = "MarriedLabel"
        MarriedLabel.Size = New System.Drawing.Size(61, 15)
        MarriedLabel.TabIndex = 25
        MarriedLabel.Text = "Married:"
        '
        'SingleLabel
        '
        SingleLabel.AutoSize = True
        SingleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SingleLabel.Location = New System.Drawing.Point(15, 52)
        SingleLabel.Name = "SingleLabel"
        SingleLabel.Size = New System.Drawing.Size(52, 15)
        SingleLabel.TabIndex = 27
        SingleLabel.Text = "Single:"
        '
        'LastFourLabel
        '
        LastFourLabel.AutoSize = True
        LastFourLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastFourLabel.Location = New System.Drawing.Point(374, 218)
        LastFourLabel.Name = "LastFourLabel"
        LastFourLabel.Size = New System.Drawing.Size(77, 15)
        LastFourLabel.TabIndex = 29
        LastFourLabel.Text = "*Last Four:"
        '
        'RankLastLabel
        '
        RankLastLabel.AutoSize = True
        RankLastLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RankLastLabel.Location = New System.Drawing.Point(22, 257)
        RankLastLabel.Name = "RankLastLabel"
        RankLastLabel.Size = New System.Drawing.Size(75, 15)
        RankLastLabel.TabIndex = 31
        RankLastLabel.Text = "Rank Last:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(243, 286)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(216, 15)
        Label1.TabIndex = 34
        Label1.Text = "SOLDIER'S FAMILY DATA TABLE"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(584, 38)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(194, 15)
        Label2.TabIndex = 36
        Label2.Text = "NAME DROP DOWN SEARCH"
        '
        'SpcIDLabel
        '
        SpcIDLabel.AutoSize = True
        SpcIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SpcIDLabel.Location = New System.Drawing.Point(190, 47)
        SpcIDLabel.Name = "SpcIDLabel"
        SpcIDLabel.Size = New System.Drawing.Size(50, 13)
        SpcIDLabel.TabIndex = 38
        SpcIDLabel.Text = "Spc ID:"
        '
        'Soldier_RosterDataSet
        '
        Me.Soldier_RosterDataSet.DataSetName = "Soldier_RosterDataSet"
        Me.Soldier_RosterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminLoginTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BMITableAdapter = Nothing
        Me.TableAdapterManager.MainLoginTableAdapter = Nothing
        Me.TableAdapterManager.tblEmergencyTableAdapter = Nothing
        Me.TableAdapterManager.tblFamilyTableAdapter = Me.TblFamilyTableAdapter
        Me.TableAdapterManager.tblLicenseTableAdapter = Nothing
        Me.TableAdapterManager.tblNCOERTableAdapter = Nothing
        Me.TableAdapterManager.tblPropertyTableAdapter = Nothing
        Me.TableAdapterManager.tblRatingTableAdapter = Nothing
        Me.TableAdapterManager.tblSoldierInfoTableAdapter = Nothing
        Me.TableAdapterManager.tblSoldierTableAdapter = Me.TblSoldierTableAdapter
        Me.TableAdapterManager.tblTrainingTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblFamilyTableAdapter
        '
        Me.TblFamilyTableAdapter.ClearBeforeFill = True
        '
        'TblSoldierBindingNavigator
        '
        Me.TblSoldierBindingNavigator.AddNewItem = Nothing
        Me.TblSoldierBindingNavigator.BindingSource = Me.TblSoldierBindingSource
        Me.TblSoldierBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblSoldierBindingNavigator.DeleteItem = Nothing
        Me.TblSoldierBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.Pre, Me.BindingNavigatorSeparator, Me.txtNumber, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.Nxt, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripDropDownButton1, Me.ToolStripButton5, Me.ToolStripButton6})
        Me.TblSoldierBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblSoldierBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblSoldierBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblSoldierBindingNavigator.MoveNextItem = Me.Nxt
        Me.TblSoldierBindingNavigator.MovePreviousItem = Me.Pre
        Me.TblSoldierBindingNavigator.Name = "TblSoldierBindingNavigator"
        Me.TblSoldierBindingNavigator.PositionItem = Me.txtNumber
        Me.TblSoldierBindingNavigator.Size = New System.Drawing.Size(997, 25)
        Me.TblSoldierBindingNavigator.TabIndex = 0
        Me.TblSoldierBindingNavigator.Text = "BindingNavigator1"
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
        'Pre
        '
        Me.Pre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Pre.Image = CType(resources.GetObject("Pre.Image"), System.Drawing.Image)
        Me.Pre.Name = "Pre"
        Me.Pre.RightToLeftAutoMirrorImage = True
        Me.Pre.Size = New System.Drawing.Size(23, 22)
        Me.Pre.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'txtNumber
        '
        Me.txtNumber.AccessibleName = "Position"
        Me.txtNumber.AutoSize = False
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(50, 23)
        Me.txtNumber.Text = "0"
        Me.txtNumber.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Nxt
        '
        Me.Nxt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Nxt.Image = CType(resources.GetObject("Nxt.Image"), System.Drawing.Image)
        Me.Nxt.Name = "Nxt"
        Me.Nxt.RightToLeftAutoMirrorImage = True
        Me.Nxt.Size = New System.Drawing.Size(23, 22)
        Me.Nxt.Text = "Move next"
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
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripButton4.Text = "E&XIT"
        Me.ToolStripButton4.ToolTipText = "ALT+X"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Margin = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FAMILYFORMToolStripMenuItem, Me.EMERGENCYFORMToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(160, 22)
        Me.ToolStripDropDownButton1.Text = "SOLDIE&R MENU FORMS"
        '
        'FAMILYFORMToolStripMenuItem
        '
        Me.FAMILYFORMToolStripMenuItem.Name = "FAMILYFORMToolStripMenuItem"
        Me.FAMILYFORMToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.FAMILYFORMToolStripMenuItem.Text = "&FAMILY FORM"
        '
        'EMERGENCYFORMToolStripMenuItem
        '
        Me.EMERGENCYFORMToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.EMERGENCYFORMToolStripMenuItem.Name = "EMERGENCYFORMToolStripMenuItem"
        Me.EMERGENCYFORMToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.EMERGENCYFORMToolStripMenuItem.Text = "ADD &EMERGENCY FORM"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(178, 22)
        Me.ToolStripMenuItem1.Text = "EMERGENCY TABLE"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(117, 22)
        Me.ToolStripButton5.Text = "&TRAINING FORM"
        Me.ToolStripButton5.ToolTipText = "ALT+T"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(149, 22)
        Me.ToolStripButton6.Text = "SOLDIER'S &DATA PRINT"
        '
        'SoldierIDTextBox
        '
        Me.SoldierIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "SoldierID", True))
        Me.SoldierIDTextBox.Location = New System.Drawing.Point(103, 44)
        Me.SoldierIDTextBox.Name = "SoldierIDTextBox"
        Me.SoldierIDTextBox.ReadOnly = True
        Me.SoldierIDTextBox.Size = New System.Drawing.Size(71, 20)
        Me.SoldierIDTextBox.TabIndex = 2
        '
        'RankTextBox
        '
        Me.RankTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RankTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "Rank", True))
        Me.RankTextBox.Location = New System.Drawing.Point(103, 77)
        Me.RankTextBox.Name = "RankTextBox"
        Me.RankTextBox.Size = New System.Drawing.Size(71, 20)
        Me.RankTextBox.TabIndex = 4
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(103, 108)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(189, 20)
        Me.FirstNameTextBox.TabIndex = 6
        '
        'MiddleInitialTextBox
        '
        Me.MiddleInitialTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MiddleInitialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "MiddleInitial", True))
        Me.MiddleInitialTextBox.Location = New System.Drawing.Point(416, 108)
        Me.MiddleInitialTextBox.Name = "MiddleInitialTextBox"
        Me.MiddleInitialTextBox.Size = New System.Drawing.Size(56, 20)
        Me.MiddleInitialTextBox.TabIndex = 8
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(587, 108)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(189, 20)
        Me.LastNameTextBox.TabIndex = 10
        '
        'AddressTextBox
        '
        Me.AddressTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(103, 142)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(202, 20)
        Me.AddressTextBox.TabIndex = 12
        '
        'AptTextBox
        '
        Me.AptTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AptTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "Apt", True))
        Me.AptTextBox.Location = New System.Drawing.Point(416, 142)
        Me.AptTextBox.Name = "AptTextBox"
        Me.AptTextBox.Size = New System.Drawing.Size(71, 20)
        Me.AptTextBox.TabIndex = 14
        '
        'CityTextBox
        '
        Me.CityTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(587, 142)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(209, 20)
        Me.CityTextBox.TabIndex = 16
        '
        'StateComboBox
        '
        Me.StateComboBox.AutoCompleteCustomSource.AddRange(New String() {"AL      ", "AK      ", "AZ      ", "AR      ", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY", "DC", "AA", "AP", "AE"})
        Me.StateComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.StateComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.StateComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "State", True))
        Me.StateComboBox.FormattingEnabled = True
        Me.StateComboBox.Location = New System.Drawing.Point(103, 179)
        Me.StateComboBox.Name = "StateComboBox"
        Me.StateComboBox.Size = New System.Drawing.Size(71, 21)
        Me.StateComboBox.TabIndex = 18
        '
        'ZipMaskedTextBox
        '
        Me.ZipMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "Zip", True))
        Me.ZipMaskedTextBox.Location = New System.Drawing.Point(246, 179)
        Me.ZipMaskedTextBox.Mask = "00000-9999"
        Me.ZipMaskedTextBox.Name = "ZipMaskedTextBox"
        Me.ZipMaskedTextBox.Size = New System.Drawing.Size(85, 20)
        Me.ZipMaskedTextBox.TabIndex = 20
        '
        'TelephoneMaskedTextBox
        '
        Me.TelephoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "Telephone", True))
        Me.TelephoneMaskedTextBox.Location = New System.Drawing.Point(451, 179)
        Me.TelephoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.TelephoneMaskedTextBox.Name = "TelephoneMaskedTextBox"
        Me.TelephoneMaskedTextBox.Size = New System.Drawing.Size(85, 20)
        Me.TelephoneMaskedTextBox.TabIndex = 22
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(103, 217)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(246, 20)
        Me.EmailTextBox.TabIndex = 24
        '
        'MarriedCheckBox
        '
        Me.MarriedCheckBox.Location = New System.Drawing.Point(73, 18)
        Me.MarriedCheckBox.Name = "MarriedCheckBox"
        Me.MarriedCheckBox.Size = New System.Drawing.Size(31, 24)
        Me.MarriedCheckBox.TabIndex = 26
        Me.MarriedCheckBox.UseVisualStyleBackColor = True
        '
        'SingleCheckBox
        '
        Me.SingleCheckBox.Location = New System.Drawing.Point(73, 49)
        Me.SingleCheckBox.Name = "SingleCheckBox"
        Me.SingleCheckBox.Size = New System.Drawing.Size(31, 24)
        Me.SingleCheckBox.TabIndex = 28
        Me.SingleCheckBox.UseVisualStyleBackColor = True
        '
        'RankLastTextBox
        '
        Me.RankLastTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "RankLast", True))
        Me.RankLastTextBox.Location = New System.Drawing.Point(103, 256)
        Me.RankLastTextBox.Name = "RankLastTextBox"
        Me.RankLastTextBox.ReadOnly = True
        Me.RankLastTextBox.Size = New System.Drawing.Size(161, 20)
        Me.RankLastTextBox.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMaritalStatus)
        Me.GroupBox1.Controls.Add(MarriedLabel)
        Me.GroupBox1.Controls.Add(Me.MarriedCheckBox)
        Me.GroupBox1.Controls.Add(SingleLabel)
        Me.GroupBox1.Controls.Add(Me.SingleCheckBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(598, 196)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 93)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MARITAL STATUS"
        '
        'txtMaritalStatus
        '
        Me.txtMaritalStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "MaritalStatus", True))
        Me.txtMaritalStatus.Location = New System.Drawing.Point(98, 35)
        Me.txtMaritalStatus.Name = "txtMaritalStatus"
        Me.txtMaritalStatus.Size = New System.Drawing.Size(146, 20)
        Me.txtMaritalStatus.TabIndex = 29
        '
        'TblFamilyDataGridView
        '
        Me.TblFamilyDataGridView.AutoGenerateColumns = False
        Me.TblFamilyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblFamilyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.TblFamilyDataGridView.DataSource = Me.TblFamilyBindingSource
        Me.TblFamilyDataGridView.Location = New System.Drawing.Point(16, 304)
        Me.TblFamilyDataGridView.Name = "TblFamilyDataGridView"
        Me.TblFamilyDataGridView.Size = New System.Drawing.Size(714, 220)
        Me.TblFamilyDataGridView.TabIndex = 33
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "RelationShip"
        Me.DataGridViewTextBoxColumn3.HeaderText = "RelationShip"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 110
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 110
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn5.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 110
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Telephone"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Telephone"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 120
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NoOfDependants"
        Me.DataGridViewTextBoxColumn8.HeaderText = "NoOfDependants"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 110
        '
        'TblFamilyBindingSource
        '
        Me.TblFamilyBindingSource.DataMember = "tblSoldiertblFamily"
        Me.TblFamilyBindingSource.DataSource = Me.TblSoldierBindingSource
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TblSoldierBindingSource
        Me.ComboBox1.DisplayMember = "RankLast"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(587, 56)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(189, 21)
        Me.ComboBox1.TabIndex = 35
        Me.ComboBox1.ValueMember = "RankLast"
        '
        'SpcIDTextBox
        '
        Me.SpcIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "SpcID", True))
        Me.SpcIDTextBox.Location = New System.Drawing.Point(246, 44)
        Me.SpcIDTextBox.Name = "SpcIDTextBox"
        Me.SpcIDTextBox.ReadOnly = True
        Me.SpcIDTextBox.Size = New System.Drawing.Size(71, 20)
        Me.SpcIDTextBox.TabIndex = 39
        '
        'LastFourMaskedTextBox
        '
        Me.LastFourMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "LastFour", True))
        Me.LastFourMaskedTextBox.Location = New System.Drawing.Point(457, 217)
        Me.LastFourMaskedTextBox.Mask = "xxx-xx-0000"
        Me.LastFourMaskedTextBox.Name = "LastFourMaskedTextBox"
        Me.LastFourMaskedTextBox.Size = New System.Drawing.Size(79, 20)
        Me.LastFourMaskedTextBox.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(753, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(211, 23)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "SOLDIER'S FAMILY REPORT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(753, 333)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(211, 23)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "SOLDIER'S EMERGENCY REPORT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(733, 380)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 39)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "AFTER FILLLING ALL OF THE SOLDIER'S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "INFORMATION, YOU CAN VIEW REPORT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BY CLIKING" &
    " THE BUTTON AT THE BOTTOM"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(753, 422)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(211, 23)
        Me.Button3.TabIndex = 43
        Me.Button3.Text = "SOLDIER'S INFORMATION"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(753, 451)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(211, 23)
        Me.Button4.TabIndex = 44
        Me.Button4.Text = "SOLDIER WEAPON AND PT SOCRES"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'SoldierForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 524)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LastFourMaskedTextBox)
        Me.Controls.Add(SpcIDLabel)
        Me.Controls.Add(Me.SpcIDTextBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TblFamilyDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(SoldierIDLabel)
        Me.Controls.Add(Me.SoldierIDTextBox)
        Me.Controls.Add(RankLabel)
        Me.Controls.Add(Me.RankTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(MiddleInitialLabel)
        Me.Controls.Add(Me.MiddleInitialTextBox)
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
        Me.Controls.Add(LastFourLabel)
        Me.Controls.Add(RankLastLabel)
        Me.Controls.Add(Me.RankLastTextBox)
        Me.Controls.Add(Me.TblSoldierBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SoldierForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SOLDIER FORM"
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSoldierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSoldierBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblSoldierBindingNavigator.ResumeLayout(False)
        Me.TblSoldierBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TblFamilyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblFamilyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Pre As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents txtNumber As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents Nxt As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TblFamilyTableAdapter As Soldier_RosterDataSetTableAdapters.tblFamilyTableAdapter
    Friend WithEvents SoldierIDTextBox As TextBox
    Friend WithEvents RankTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents MiddleInitialTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents AptTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateComboBox As ComboBox
    Friend WithEvents ZipMaskedTextBox As MaskedTextBox
    Friend WithEvents TelephoneMaskedTextBox As MaskedTextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents MarriedCheckBox As CheckBox
    Friend WithEvents SingleCheckBox As CheckBox
    Friend WithEvents RankLastTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TblFamilyBindingSource As BindingSource
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TblFamilyDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents FAMILYFORMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EMERGENCYFORMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents SpcIDTextBox As TextBox
    Friend WithEvents LastFourMaskedTextBox As MaskedTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtMaritalStatus As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
