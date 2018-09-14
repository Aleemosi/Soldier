<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProper
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
        Dim PropertyIDLabel As System.Windows.Forms.Label
        Dim SoldierIDLabel As System.Windows.Forms.Label
        Dim WeaponTypeLabel As System.Windows.Forms.Label
        Dim WeaponNumber_SerialLabel As System.Windows.Forms.Label
        Dim MaskNumberLabel As System.Windows.Forms.Label
        Dim MaskSizeLabel As System.Windows.Forms.Label
        Dim NBCTopSIzeLabel As System.Windows.Forms.Label
        Dim NBCBottomSizeLabel As System.Windows.Forms.Label
        Dim NBCBootsSizeLabel As System.Windows.Forms.Label
        Dim ACUCapLabel As System.Windows.Forms.Label
        Dim ACUTTopLabel As System.Windows.Forms.Label
        Dim ACUBottomLabel As System.Windows.Forms.Label
        Dim BOOTSLabel As System.Windows.Forms.Label
        Dim SoldierIDLabel1 As System.Windows.Forms.Label
        Dim RankLastLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddProper))
        Me.Soldier_RosterDataSet = New SoldierRosterSystem.Soldier_RosterDataSet()
        Me.TblPropertyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPropertyTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblPropertyTableAdapter()
        Me.TableAdapterManager = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.TableAdapterManager()
        Me.TblSoldierTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblSoldierTableAdapter()
        Me.TblPropertyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PropertyIDTextBox = New System.Windows.Forms.TextBox()
        Me.SoldierIDTextBox = New System.Windows.Forms.TextBox()
        Me.WeaponTypeTextBox = New System.Windows.Forms.TextBox()
        Me.WeaponNumberSerialTextBox = New System.Windows.Forms.TextBox()
        Me.MaskNumberTextBox = New System.Windows.Forms.TextBox()
        Me.MaskSizeTextBox = New System.Windows.Forms.TextBox()
        Me.NBCTopSIzeTextBox = New System.Windows.Forms.TextBox()
        Me.NBCBottomSizeTextBox = New System.Windows.Forms.TextBox()
        Me.NBCBootsSizeTextBox = New System.Windows.Forms.TextBox()
        Me.ACUCapTextBox = New System.Windows.Forms.TextBox()
        Me.ACUTTopTextBox = New System.Windows.Forms.TextBox()
        Me.ACUBottomTextBox = New System.Windows.Forms.TextBox()
        Me.BOOTSTextBox = New System.Windows.Forms.TextBox()
        Me.TblSoldierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SoldierIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.RankLastTextBox = New System.Windows.Forms.TextBox()
        PropertyIDLabel = New System.Windows.Forms.Label()
        SoldierIDLabel = New System.Windows.Forms.Label()
        WeaponTypeLabel = New System.Windows.Forms.Label()
        WeaponNumber_SerialLabel = New System.Windows.Forms.Label()
        MaskNumberLabel = New System.Windows.Forms.Label()
        MaskSizeLabel = New System.Windows.Forms.Label()
        NBCTopSIzeLabel = New System.Windows.Forms.Label()
        NBCBottomSizeLabel = New System.Windows.Forms.Label()
        NBCBootsSizeLabel = New System.Windows.Forms.Label()
        ACUCapLabel = New System.Windows.Forms.Label()
        ACUTTopLabel = New System.Windows.Forms.Label()
        ACUBottomLabel = New System.Windows.Forms.Label()
        BOOTSLabel = New System.Windows.Forms.Label()
        SoldierIDLabel1 = New System.Windows.Forms.Label()
        RankLastLabel = New System.Windows.Forms.Label()
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPropertyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPropertyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblPropertyBindingNavigator.SuspendLayout()
        CType(Me.TblSoldierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PropertyIDLabel
        '
        PropertyIDLabel.AutoSize = True
        PropertyIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PropertyIDLabel.Location = New System.Drawing.Point(11, 38)
        PropertyIDLabel.Name = "PropertyIDLabel"
        PropertyIDLabel.Size = New System.Drawing.Size(82, 15)
        PropertyIDLabel.TabIndex = 1
        PropertyIDLabel.Text = "Property ID:"
        '
        'SoldierIDLabel
        '
        SoldierIDLabel.AutoSize = True
        SoldierIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SoldierIDLabel.Location = New System.Drawing.Point(184, 38)
        SoldierIDLabel.Name = "SoldierIDLabel"
        SoldierIDLabel.Size = New System.Drawing.Size(75, 15)
        SoldierIDLabel.TabIndex = 3
        SoldierIDLabel.Text = "Soldier ID:"
        '
        'WeaponTypeLabel
        '
        WeaponTypeLabel.AutoSize = True
        WeaponTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WeaponTypeLabel.Location = New System.Drawing.Point(16, 130)
        WeaponTypeLabel.Name = "WeaponTypeLabel"
        WeaponTypeLabel.Size = New System.Drawing.Size(97, 15)
        WeaponTypeLabel.TabIndex = 5
        WeaponTypeLabel.Text = "Weapon Type:"
        '
        'WeaponNumber_SerialLabel
        '
        WeaponNumber_SerialLabel.AutoSize = True
        WeaponNumber_SerialLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WeaponNumber_SerialLabel.Location = New System.Drawing.Point(245, 130)
        WeaponNumber_SerialLabel.Name = "WeaponNumber_SerialLabel"
        WeaponNumber_SerialLabel.Size = New System.Drawing.Size(160, 15)
        WeaponNumber_SerialLabel.TabIndex = 7
        WeaponNumber_SerialLabel.Text = "Weapon Number/Serial:"
        '
        'MaskNumberLabel
        '
        MaskNumberLabel.AutoSize = True
        MaskNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MaskNumberLabel.Location = New System.Drawing.Point(13, 163)
        MaskNumberLabel.Name = "MaskNumberLabel"
        MaskNumberLabel.Size = New System.Drawing.Size(100, 15)
        MaskNumberLabel.TabIndex = 9
        MaskNumberLabel.Text = "Mask Number:"
        '
        'MaskSizeLabel
        '
        MaskSizeLabel.AutoSize = True
        MaskSizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MaskSizeLabel.Location = New System.Drawing.Point(245, 163)
        MaskSizeLabel.Name = "MaskSizeLabel"
        MaskSizeLabel.Size = New System.Drawing.Size(77, 15)
        MaskSizeLabel.TabIndex = 11
        MaskSizeLabel.Text = "Mask Size:"
        '
        'NBCTopSIzeLabel
        '
        NBCTopSIzeLabel.AutoSize = True
        NBCTopSIzeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NBCTopSIzeLabel.Location = New System.Drawing.Point(18, 200)
        NBCTopSIzeLabel.Name = "NBCTopSIzeLabel"
        NBCTopSIzeLabel.Size = New System.Drawing.Size(95, 15)
        NBCTopSIzeLabel.TabIndex = 13
        NBCTopSIzeLabel.Text = "NBCTop SIze:"
        '
        'NBCBottomSizeLabel
        '
        NBCBottomSizeLabel.AutoSize = True
        NBCBottomSizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NBCBottomSizeLabel.Location = New System.Drawing.Point(206, 200)
        NBCBottomSizeLabel.Name = "NBCBottomSizeLabel"
        NBCBottomSizeLabel.Size = New System.Drawing.Size(116, 15)
        NBCBottomSizeLabel.TabIndex = 15
        NBCBottomSizeLabel.Text = "NBCBottom Size:"
        '
        'NBCBootsSizeLabel
        '
        NBCBootsSizeLabel.AutoSize = True
        NBCBootsSizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NBCBootsSizeLabel.Location = New System.Drawing.Point(422, 200)
        NBCBootsSizeLabel.Name = "NBCBootsSizeLabel"
        NBCBootsSizeLabel.Size = New System.Drawing.Size(107, 15)
        NBCBootsSizeLabel.TabIndex = 17
        NBCBootsSizeLabel.Text = "NBCBoots Size:"
        '
        'ACUCapLabel
        '
        ACUCapLabel.AutoSize = True
        ACUCapLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ACUCapLabel.Location = New System.Drawing.Point(6, 237)
        ACUCapLabel.Name = "ACUCapLabel"
        ACUCapLabel.Size = New System.Drawing.Size(63, 15)
        ACUCapLabel.TabIndex = 19
        ACUCapLabel.Text = "ACUCap:"
        '
        'ACUTTopLabel
        '
        ACUTTopLabel.AutoSize = True
        ACUTTopLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ACUTTopLabel.Location = New System.Drawing.Point(172, 237)
        ACUTTopLabel.Name = "ACUTTopLabel"
        ACUTTopLabel.Size = New System.Drawing.Size(70, 15)
        ACUTTopLabel.TabIndex = 21
        ACUTTopLabel.Text = "ACUTTop:"
        '
        'ACUBottomLabel
        '
        ACUBottomLabel.AutoSize = True
        ACUBottomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ACUBottomLabel.Location = New System.Drawing.Point(366, 237)
        ACUBottomLabel.Name = "ACUBottomLabel"
        ACUBottomLabel.Size = New System.Drawing.Size(83, 15)
        ACUBottomLabel.TabIndex = 23
        ACUBottomLabel.Text = "ACUBottom:"
        '
        'BOOTSLabel
        '
        BOOTSLabel.AutoSize = True
        BOOTSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BOOTSLabel.Location = New System.Drawing.Point(556, 237)
        BOOTSLabel.Name = "BOOTSLabel"
        BOOTSLabel.Size = New System.Drawing.Size(57, 15)
        BOOTSLabel.TabIndex = 25
        BOOTSLabel.Text = "BOOTS:"
        '
        'SoldierIDLabel1
        '
        SoldierIDLabel1.AutoSize = True
        SoldierIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SoldierIDLabel1.Location = New System.Drawing.Point(358, 38)
        SoldierIDLabel1.Name = "SoldierIDLabel1"
        SoldierIDLabel1.Size = New System.Drawing.Size(75, 15)
        SoldierIDLabel1.TabIndex = 27
        SoldierIDLabel1.Text = "Soldier ID:"
        '
        'RankLastLabel
        '
        RankLastLabel.AutoSize = True
        RankLastLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RankLastLabel.Location = New System.Drawing.Point(245, 73)
        RankLastLabel.Name = "RankLastLabel"
        RankLastLabel.Size = New System.Drawing.Size(67, 15)
        RankLastLabel.TabIndex = 31
        RankLastLabel.Text = "SOLDIER"
        '
        'Soldier_RosterDataSet
        '
        Me.Soldier_RosterDataSet.DataSetName = "Soldier_RosterDataSet"
        Me.Soldier_RosterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPropertyBindingSource
        '
        Me.TblPropertyBindingSource.DataMember = "tblProperty"
        Me.TblPropertyBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'TblPropertyTableAdapter
        '
        Me.TblPropertyTableAdapter.ClearBeforeFill = True
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
        'TblSoldierTableAdapter
        '
        Me.TblSoldierTableAdapter.ClearBeforeFill = True
        '
        'TblPropertyBindingNavigator
        '
        Me.TblPropertyBindingNavigator.AddNewItem = Nothing
        Me.TblPropertyBindingNavigator.BindingSource = Me.TblPropertyBindingSource
        Me.TblPropertyBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblPropertyBindingNavigator.DeleteItem = Nothing
        Me.TblPropertyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator1, Me.ToolStripButton4})
        Me.TblPropertyBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblPropertyBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblPropertyBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblPropertyBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblPropertyBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblPropertyBindingNavigator.Name = "TblPropertyBindingNavigator"
        Me.TblPropertyBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblPropertyBindingNavigator.Size = New System.Drawing.Size(728, 25)
        Me.TblPropertyBindingNavigator.TabIndex = 0
        Me.TblPropertyBindingNavigator.Text = "BindingNavigator1"
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
        Me.ToolStripButton4.Size = New System.Drawing.Size(119, 22)
        Me.ToolStripButton4.Text = "&PROPERTY FORM"
        Me.ToolStripButton4.ToolTipText = "ALT+P"
        '
        'PropertyIDTextBox
        '
        Me.PropertyIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPropertyBindingSource, "PropertyID", True))
        Me.PropertyIDTextBox.Location = New System.Drawing.Point(99, 37)
        Me.PropertyIDTextBox.Name = "PropertyIDTextBox"
        Me.PropertyIDTextBox.ReadOnly = True
        Me.PropertyIDTextBox.Size = New System.Drawing.Size(57, 20)
        Me.PropertyIDTextBox.TabIndex = 2
        '
        'SoldierIDTextBox
        '
        Me.SoldierIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPropertyBindingSource, "SoldierID", True))
        Me.SoldierIDTextBox.Location = New System.Drawing.Point(265, 37)
        Me.SoldierIDTextBox.Name = "SoldierIDTextBox"
        Me.SoldierIDTextBox.ReadOnly = True
        Me.SoldierIDTextBox.Size = New System.Drawing.Size(57, 20)
        Me.SoldierIDTextBox.TabIndex = 4
        '
        'WeaponTypeTextBox
        '
        Me.WeaponTypeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.WeaponTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPropertyBindingSource, "WeaponType", True))
        Me.WeaponTypeTextBox.Location = New System.Drawing.Point(119, 129)
        Me.WeaponTypeTextBox.Name = "WeaponTypeTextBox"
        Me.WeaponTypeTextBox.Size = New System.Drawing.Size(79, 20)
        Me.WeaponTypeTextBox.TabIndex = 6
        '
        'WeaponNumberSerialTextBox
        '
        Me.WeaponNumberSerialTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.WeaponNumberSerialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPropertyBindingSource, "WeaponNumberSerial", True))
        Me.WeaponNumberSerialTextBox.Location = New System.Drawing.Point(411, 129)
        Me.WeaponNumberSerialTextBox.Name = "WeaponNumberSerialTextBox"
        Me.WeaponNumberSerialTextBox.Size = New System.Drawing.Size(195, 20)
        Me.WeaponNumberSerialTextBox.TabIndex = 8
        '
        'MaskNumberTextBox
        '
        Me.MaskNumberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MaskNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPropertyBindingSource, "MaskNumber", True))
        Me.MaskNumberTextBox.Location = New System.Drawing.Point(119, 162)
        Me.MaskNumberTextBox.Name = "MaskNumberTextBox"
        Me.MaskNumberTextBox.Size = New System.Drawing.Size(79, 20)
        Me.MaskNumberTextBox.TabIndex = 10
        '
        'MaskSizeTextBox
        '
        Me.MaskSizeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MaskSizeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPropertyBindingSource, "MaskSize", True))
        Me.MaskSizeTextBox.Location = New System.Drawing.Point(326, 162)
        Me.MaskSizeTextBox.Name = "MaskSizeTextBox"
        Me.MaskSizeTextBox.Size = New System.Drawing.Size(79, 20)
        Me.MaskSizeTextBox.TabIndex = 12
        '
        'NBCTopSIzeTextBox
        '
        Me.NBCTopSIzeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NBCTopSIzeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPropertyBindingSource, "NBCTopSIze", True))
        Me.NBCTopSIzeTextBox.Location = New System.Drawing.Point(119, 199)
        Me.NBCTopSIzeTextBox.Name = "NBCTopSIzeTextBox"
        Me.NBCTopSIzeTextBox.Size = New System.Drawing.Size(79, 20)
        Me.NBCTopSIzeTextBox.TabIndex = 14
        '
        'NBCBottomSizeTextBox
        '
        Me.NBCBottomSizeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NBCBottomSizeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPropertyBindingSource, "NBCBottomSize", True))
        Me.NBCBottomSizeTextBox.Location = New System.Drawing.Point(326, 199)
        Me.NBCBottomSizeTextBox.Name = "NBCBottomSizeTextBox"
        Me.NBCBottomSizeTextBox.Size = New System.Drawing.Size(79, 20)
        Me.NBCBottomSizeTextBox.TabIndex = 16
        '
        'NBCBootsSizeTextBox
        '
        Me.NBCBootsSizeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NBCBootsSizeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPropertyBindingSource, "NBCBootsSize", True))
        Me.NBCBootsSizeTextBox.Location = New System.Drawing.Point(535, 199)
        Me.NBCBootsSizeTextBox.Name = "NBCBootsSizeTextBox"
        Me.NBCBootsSizeTextBox.Size = New System.Drawing.Size(79, 20)
        Me.NBCBootsSizeTextBox.TabIndex = 18
        '
        'ACUCapTextBox
        '
        Me.ACUCapTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ACUCapTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPropertyBindingSource, "ACUCap", True))
        Me.ACUCapTextBox.Location = New System.Drawing.Point(75, 236)
        Me.ACUCapTextBox.Name = "ACUCapTextBox"
        Me.ACUCapTextBox.Size = New System.Drawing.Size(79, 20)
        Me.ACUCapTextBox.TabIndex = 20
        '
        'ACUTTopTextBox
        '
        Me.ACUTTopTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ACUTTopTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPropertyBindingSource, "ACUTTop", True))
        Me.ACUTTopTextBox.Location = New System.Drawing.Point(248, 236)
        Me.ACUTTopTextBox.Name = "ACUTTopTextBox"
        Me.ACUTTopTextBox.Size = New System.Drawing.Size(77, 20)
        Me.ACUTTopTextBox.TabIndex = 22
        '
        'ACUBottomTextBox
        '
        Me.ACUBottomTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ACUBottomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPropertyBindingSource, "ACUBottom", True))
        Me.ACUBottomTextBox.Location = New System.Drawing.Point(455, 236)
        Me.ACUBottomTextBox.Name = "ACUBottomTextBox"
        Me.ACUBottomTextBox.Size = New System.Drawing.Size(79, 20)
        Me.ACUBottomTextBox.TabIndex = 24
        '
        'BOOTSTextBox
        '
        Me.BOOTSTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BOOTSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPropertyBindingSource, "BOOTS", True))
        Me.BOOTSTextBox.Location = New System.Drawing.Point(619, 236)
        Me.BOOTSTextBox.Name = "BOOTSTextBox"
        Me.BOOTSTextBox.Size = New System.Drawing.Size(79, 20)
        Me.BOOTSTextBox.TabIndex = 26
        '
        'TblSoldierBindingSource
        '
        Me.TblSoldierBindingSource.DataMember = "tblSoldier"
        Me.TblSoldierBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'SoldierIDTextBox1
        '
        Me.SoldierIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "SoldierID", True))
        Me.SoldierIDTextBox1.Location = New System.Drawing.Point(439, 37)
        Me.SoldierIDTextBox1.Name = "SoldierIDTextBox1"
        Me.SoldierIDTextBox1.ReadOnly = True
        Me.SoldierIDTextBox1.Size = New System.Drawing.Size(57, 20)
        Me.SoldierIDTextBox1.TabIndex = 28
        '
        'RankLastTextBox
        '
        Me.RankLastTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "RankLast", True))
        Me.RankLastTextBox.Location = New System.Drawing.Point(187, 91)
        Me.RankLastTextBox.Name = "RankLastTextBox"
        Me.RankLastTextBox.ReadOnly = True
        Me.RankLastTextBox.Size = New System.Drawing.Size(201, 20)
        Me.RankLastTextBox.TabIndex = 32
        '
        'AddProper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 279)
        Me.ControlBox = False
        Me.Controls.Add(RankLastLabel)
        Me.Controls.Add(Me.RankLastTextBox)
        Me.Controls.Add(SoldierIDLabel1)
        Me.Controls.Add(Me.SoldierIDTextBox1)
        Me.Controls.Add(PropertyIDLabel)
        Me.Controls.Add(Me.PropertyIDTextBox)
        Me.Controls.Add(SoldierIDLabel)
        Me.Controls.Add(Me.SoldierIDTextBox)
        Me.Controls.Add(WeaponTypeLabel)
        Me.Controls.Add(Me.WeaponTypeTextBox)
        Me.Controls.Add(WeaponNumber_SerialLabel)
        Me.Controls.Add(Me.WeaponNumberSerialTextBox)
        Me.Controls.Add(MaskNumberLabel)
        Me.Controls.Add(Me.MaskNumberTextBox)
        Me.Controls.Add(MaskSizeLabel)
        Me.Controls.Add(Me.MaskSizeTextBox)
        Me.Controls.Add(NBCTopSIzeLabel)
        Me.Controls.Add(Me.NBCTopSIzeTextBox)
        Me.Controls.Add(NBCBottomSizeLabel)
        Me.Controls.Add(Me.NBCBottomSizeTextBox)
        Me.Controls.Add(NBCBootsSizeLabel)
        Me.Controls.Add(Me.NBCBootsSizeTextBox)
        Me.Controls.Add(ACUCapLabel)
        Me.Controls.Add(Me.ACUCapTextBox)
        Me.Controls.Add(ACUTTopLabel)
        Me.Controls.Add(Me.ACUTTopTextBox)
        Me.Controls.Add(ACUBottomLabel)
        Me.Controls.Add(Me.ACUBottomTextBox)
        Me.Controls.Add(BOOTSLabel)
        Me.Controls.Add(Me.BOOTSTextBox)
        Me.Controls.Add(Me.TblPropertyBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AddProper"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD PROPERTY FORM"
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPropertyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPropertyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblPropertyBindingNavigator.ResumeLayout(False)
        Me.TblPropertyBindingNavigator.PerformLayout()
        CType(Me.TblSoldierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Soldier_RosterDataSet As Soldier_RosterDataSet
    Friend WithEvents TblPropertyBindingSource As BindingSource
    Friend WithEvents TblPropertyTableAdapter As Soldier_RosterDataSetTableAdapters.tblPropertyTableAdapter
    Friend WithEvents TableAdapterManager As Soldier_RosterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblPropertyBindingNavigator As BindingNavigator
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
    Friend WithEvents PropertyIDTextBox As TextBox
    Friend WithEvents SoldierIDTextBox As TextBox
    Friend WithEvents WeaponTypeTextBox As TextBox
    Friend WithEvents WeaponNumberSerialTextBox As TextBox
    Friend WithEvents MaskNumberTextBox As TextBox
    Friend WithEvents MaskSizeTextBox As TextBox
    Friend WithEvents NBCTopSIzeTextBox As TextBox
    Friend WithEvents NBCBottomSizeTextBox As TextBox
    Friend WithEvents NBCBootsSizeTextBox As TextBox
    Friend WithEvents ACUCapTextBox As TextBox
    Friend WithEvents ACUTTopTextBox As TextBox
    Friend WithEvents ACUBottomTextBox As TextBox
    Friend WithEvents BOOTSTextBox As TextBox
    Friend WithEvents TblSoldierBindingSource As BindingSource
    Friend WithEvents SoldierIDTextBox1 As TextBox
    Friend WithEvents RankLastTextBox As TextBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
End Class
