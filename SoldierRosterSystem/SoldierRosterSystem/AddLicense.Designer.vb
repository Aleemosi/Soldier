<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddLicense
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
        Dim LicenseIDLabel As System.Windows.Forms.Label
        Dim SoldierIDLabel As System.Windows.Forms.Label
        Dim AACLabel As System.Windows.Forms.Label
        Dim _40TonLabel As System.Windows.Forms.Label
        Dim _10KLabel As System.Windows.Forms.Label
        Dim _4KLabel As System.Windows.Forms.Label
        Dim RTCHLabel As System.Windows.Forms.Label
        Dim PLSLabel As System.Windows.Forms.Label
        Dim HMMMVLabel As System.Windows.Forms.Label
        Dim FMTVLabel As System.Windows.Forms.Label
        Dim LMTVLabel As System.Windows.Forms.Label
        Dim MTVLabel As System.Windows.Forms.Label
        Dim M915Label As System.Windows.Forms.Label
        Dim BUSLabel As System.Windows.Forms.Label
        Dim GENERATORLabel As System.Windows.Forms.Label
        Dim CvilianLienceLabel As System.Windows.Forms.Label
        Dim SoldierIDLabel1 As System.Windows.Forms.Label
        Dim RankLastLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddLicense))
        Me.Soldier_RosterDataSet = New SoldierRosterSystem.Soldier_RosterDataSet()
        Me.TblLicenseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblLicenseTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblLicenseTableAdapter()
        Me.TableAdapterManager = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.TableAdapterManager()
        Me.TblSoldierTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblSoldierTableAdapter()
        Me.TblLicenseBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.LicenseIDTextBox = New System.Windows.Forms.TextBox()
        Me.SoldierIDTextBox = New System.Windows.Forms.TextBox()
        Me.AACTextBox = New System.Windows.Forms.TextBox()
        Me.Ton40TextBox = New System.Windows.Forms.TextBox()
        Me.K10TextBox = New System.Windows.Forms.TextBox()
        Me.K4TextBox = New System.Windows.Forms.TextBox()
        Me.RTCHTextBox = New System.Windows.Forms.TextBox()
        Me.PLSTextBox = New System.Windows.Forms.TextBox()
        Me.HMMMVTextBox = New System.Windows.Forms.TextBox()
        Me.FMTVTextBox = New System.Windows.Forms.TextBox()
        Me.LMTVTextBox = New System.Windows.Forms.TextBox()
        Me.MTVTextBox = New System.Windows.Forms.TextBox()
        Me.M915TextBox = New System.Windows.Forms.TextBox()
        Me.BUSTextBox = New System.Windows.Forms.TextBox()
        Me.GENERATORTextBox = New System.Windows.Forms.TextBox()
        Me.CvilianLienceTextBox = New System.Windows.Forms.TextBox()
        Me.TblSoldierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SoldierIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.RankLastTextBox = New System.Windows.Forms.TextBox()
        LicenseIDLabel = New System.Windows.Forms.Label()
        SoldierIDLabel = New System.Windows.Forms.Label()
        AACLabel = New System.Windows.Forms.Label()
        _40TonLabel = New System.Windows.Forms.Label()
        _10KLabel = New System.Windows.Forms.Label()
        _4KLabel = New System.Windows.Forms.Label()
        RTCHLabel = New System.Windows.Forms.Label()
        PLSLabel = New System.Windows.Forms.Label()
        HMMMVLabel = New System.Windows.Forms.Label()
        FMTVLabel = New System.Windows.Forms.Label()
        LMTVLabel = New System.Windows.Forms.Label()
        MTVLabel = New System.Windows.Forms.Label()
        M915Label = New System.Windows.Forms.Label()
        BUSLabel = New System.Windows.Forms.Label()
        GENERATORLabel = New System.Windows.Forms.Label()
        CvilianLienceLabel = New System.Windows.Forms.Label()
        SoldierIDLabel1 = New System.Windows.Forms.Label()
        RankLastLabel = New System.Windows.Forms.Label()
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblLicenseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblLicenseBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblLicenseBindingNavigator.SuspendLayout()
        CType(Me.TblSoldierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LicenseIDLabel
        '
        LicenseIDLabel.AutoSize = True
        LicenseIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LicenseIDLabel.Location = New System.Drawing.Point(12, 36)
        LicenseIDLabel.Name = "LicenseIDLabel"
        LicenseIDLabel.Size = New System.Drawing.Size(79, 15)
        LicenseIDLabel.TabIndex = 1
        LicenseIDLabel.Text = "License ID:"
        '
        'SoldierIDLabel
        '
        SoldierIDLabel.AutoSize = True
        SoldierIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SoldierIDLabel.Location = New System.Drawing.Point(186, 36)
        SoldierIDLabel.Name = "SoldierIDLabel"
        SoldierIDLabel.Size = New System.Drawing.Size(75, 15)
        SoldierIDLabel.TabIndex = 3
        SoldierIDLabel.Text = "Soldier ID:"
        '
        'AACLabel
        '
        AACLabel.AutoSize = True
        AACLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AACLabel.Location = New System.Drawing.Point(55, 126)
        AACLabel.Name = "AACLabel"
        AACLabel.Size = New System.Drawing.Size(36, 15)
        AACLabel.TabIndex = 5
        AACLabel.Text = "AAC:"
        '
        '_40TonLabel
        '
        _40TonLabel.AutoSize = True
        _40TonLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _40TonLabel.Location = New System.Drawing.Point(186, 126)
        _40TonLabel.Name = "_40TonLabel"
        _40TonLabel.Size = New System.Drawing.Size(51, 15)
        _40TonLabel.TabIndex = 7
        _40TonLabel.Text = "40Ton:"
        '
        '_10KLabel
        '
        _10KLabel.AutoSize = True
        _10KLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _10KLabel.Location = New System.Drawing.Point(333, 126)
        _10KLabel.Name = "_10KLabel"
        _10KLabel.Size = New System.Drawing.Size(36, 15)
        _10KLabel.TabIndex = 9
        _10KLabel.Text = "10K:"
        '
        '_4KLabel
        '
        _4KLabel.AutoSize = True
        _4KLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        _4KLabel.Location = New System.Drawing.Point(468, 126)
        _4KLabel.Name = "_4KLabel"
        _4KLabel.Size = New System.Drawing.Size(28, 15)
        _4KLabel.TabIndex = 11
        _4KLabel.Text = "4K:"
        '
        'RTCHLabel
        '
        RTCHLabel.AutoSize = True
        RTCHLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RTCHLabel.Location = New System.Drawing.Point(43, 164)
        RTCHLabel.Name = "RTCHLabel"
        RTCHLabel.Size = New System.Drawing.Size(48, 15)
        RTCHLabel.TabIndex = 13
        RTCHLabel.Text = "RTCH:"
        '
        'PLSLabel
        '
        PLSLabel.AutoSize = True
        PLSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PLSLabel.Location = New System.Drawing.Point(200, 164)
        PLSLabel.Name = "PLSLabel"
        PLSLabel.Size = New System.Drawing.Size(37, 15)
        PLSLabel.TabIndex = 15
        PLSLabel.Text = "PLS:"
        '
        'HMMMVLabel
        '
        HMMMVLabel.AutoSize = True
        HMMMVLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HMMMVLabel.Location = New System.Drawing.Point(333, 164)
        HMMMVLabel.Name = "HMMMVLabel"
        HMMMVLabel.Size = New System.Drawing.Size(65, 15)
        HMMMVLabel.TabIndex = 17
        HMMMVLabel.Text = "HMMMV:"
        '
        'FMTVLabel
        '
        FMTVLabel.AutoSize = True
        FMTVLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FMTVLabel.Location = New System.Drawing.Point(499, 164)
        FMTVLabel.Name = "FMTVLabel"
        FMTVLabel.Size = New System.Drawing.Size(47, 15)
        FMTVLabel.TabIndex = 19
        FMTVLabel.Text = "FMTV:"
        '
        'LMTVLabel
        '
        LMTVLabel.AutoSize = True
        LMTVLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LMTVLabel.Location = New System.Drawing.Point(44, 198)
        LMTVLabel.Name = "LMTVLabel"
        LMTVLabel.Size = New System.Drawing.Size(47, 15)
        LMTVLabel.TabIndex = 21
        LMTVLabel.Text = "LMTV:"
        '
        'MTVLabel
        '
        MTVLabel.AutoSize = True
        MTVLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MTVLabel.Location = New System.Drawing.Point(198, 198)
        MTVLabel.Name = "MTVLabel"
        MTVLabel.Size = New System.Drawing.Size(39, 15)
        MTVLabel.TabIndex = 23
        MTVLabel.Text = "MTV:"
        '
        'M915Label
        '
        M915Label.AutoSize = True
        M915Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        M915Label.Location = New System.Drawing.Point(322, 198)
        M915Label.Name = "M915Label"
        M915Label.Size = New System.Drawing.Size(47, 15)
        M915Label.TabIndex = 25
        M915Label.Text = "M915:"
        '
        'BUSLabel
        '
        BUSLabel.AutoSize = True
        BUSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BUSLabel.Location = New System.Drawing.Point(457, 198)
        BUSLabel.Name = "BUSLabel"
        BUSLabel.Size = New System.Drawing.Size(39, 15)
        BUSLabel.TabIndex = 27
        BUSLabel.Text = "BUS:"
        '
        'GENERATORLabel
        '
        GENERATORLabel.AutoSize = True
        GENERATORLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GENERATORLabel.Location = New System.Drawing.Point(44, 239)
        GENERATORLabel.Name = "GENERATORLabel"
        GENERATORLabel.Size = New System.Drawing.Size(95, 15)
        GENERATORLabel.TabIndex = 29
        GENERATORLabel.Text = "GENERATOR:"
        '
        'CvilianLienceLabel
        '
        CvilianLienceLabel.AutoSize = True
        CvilianLienceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CvilianLienceLabel.Location = New System.Drawing.Point(268, 239)
        CvilianLienceLabel.Name = "CvilianLienceLabel"
        CvilianLienceLabel.Size = New System.Drawing.Size(159, 15)
        CvilianLienceLabel.TabIndex = 31
        CvilianLienceLabel.Text = "Cvilian Lience # - State:"
        '
        'SoldierIDLabel1
        '
        SoldierIDLabel1.AutoSize = True
        SoldierIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SoldierIDLabel1.Location = New System.Drawing.Point(355, 36)
        SoldierIDLabel1.Name = "SoldierIDLabel1"
        SoldierIDLabel1.Size = New System.Drawing.Size(75, 15)
        SoldierIDLabel1.TabIndex = 33
        SoldierIDLabel1.Text = "Soldier ID:"
        '
        'RankLastLabel
        '
        RankLastLabel.AutoSize = True
        RankLastLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RankLastLabel.Location = New System.Drawing.Point(264, 74)
        RankLastLabel.Name = "RankLastLabel"
        RankLastLabel.Size = New System.Drawing.Size(67, 15)
        RankLastLabel.TabIndex = 35
        RankLastLabel.Text = "SOLDIER"
        '
        'Soldier_RosterDataSet
        '
        Me.Soldier_RosterDataSet.DataSetName = "Soldier_RosterDataSet"
        Me.Soldier_RosterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblLicenseBindingSource
        '
        Me.TblLicenseBindingSource.DataMember = "tblLicense"
        Me.TblLicenseBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'TblLicenseTableAdapter
        '
        Me.TblLicenseTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminLoginTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BMITableAdapter = Nothing
        Me.TableAdapterManager.MainLoginTableAdapter = Nothing
        Me.TableAdapterManager.tblEmergencyTableAdapter = Nothing
        Me.TableAdapterManager.tblFamilyTableAdapter = Nothing
        Me.TableAdapterManager.tblLicenseTableAdapter = Me.TblLicenseTableAdapter
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
        'TblLicenseBindingNavigator
        '
        Me.TblLicenseBindingNavigator.AddNewItem = Nothing
        Me.TblLicenseBindingNavigator.BindingSource = Me.TblLicenseBindingSource
        Me.TblLicenseBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblLicenseBindingNavigator.DeleteItem = Nothing
        Me.TblLicenseBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator1, Me.ToolStripButton4})
        Me.TblLicenseBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblLicenseBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblLicenseBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblLicenseBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblLicenseBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblLicenseBindingNavigator.Name = "TblLicenseBindingNavigator"
        Me.TblLicenseBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblLicenseBindingNavigator.Size = New System.Drawing.Size(627, 25)
        Me.TblLicenseBindingNavigator.TabIndex = 0
        Me.TblLicenseBindingNavigator.Text = "BindingNavigator1"
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
        Me.ToolStripButton4.Size = New System.Drawing.Size(107, 22)
        Me.ToolStripButton4.Text = "&LICENSE FORM"
        Me.ToolStripButton4.ToolTipText = "ALT+L"
        '
        'LicenseIDTextBox
        '
        Me.LicenseIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblLicenseBindingSource, "LicenseID", True))
        Me.LicenseIDTextBox.Location = New System.Drawing.Point(97, 35)
        Me.LicenseIDTextBox.Name = "LicenseIDTextBox"
        Me.LicenseIDTextBox.ReadOnly = True
        Me.LicenseIDTextBox.Size = New System.Drawing.Size(61, 20)
        Me.LicenseIDTextBox.TabIndex = 2
        '
        'SoldierIDTextBox
        '
        Me.SoldierIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblLicenseBindingSource, "SoldierID", True))
        Me.SoldierIDTextBox.Location = New System.Drawing.Point(267, 35)
        Me.SoldierIDTextBox.Name = "SoldierIDTextBox"
        Me.SoldierIDTextBox.ReadOnly = True
        Me.SoldierIDTextBox.Size = New System.Drawing.Size(61, 20)
        Me.SoldierIDTextBox.TabIndex = 4
        '
        'AACTextBox
        '
        Me.AACTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AACTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblLicenseBindingSource, "AAC", True))
        Me.AACTextBox.Location = New System.Drawing.Point(97, 125)
        Me.AACTextBox.Name = "AACTextBox"
        Me.AACTextBox.Size = New System.Drawing.Size(61, 20)
        Me.AACTextBox.TabIndex = 6
        '
        'Ton40TextBox
        '
        Me.Ton40TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Ton40TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblLicenseBindingSource, "Ton40", True))
        Me.Ton40TextBox.Location = New System.Drawing.Point(243, 125)
        Me.Ton40TextBox.Name = "Ton40TextBox"
        Me.Ton40TextBox.Size = New System.Drawing.Size(61, 20)
        Me.Ton40TextBox.TabIndex = 8
        '
        'K10TextBox
        '
        Me.K10TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.K10TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblLicenseBindingSource, "K40", True))
        Me.K10TextBox.Location = New System.Drawing.Point(375, 125)
        Me.K10TextBox.Name = "K10TextBox"
        Me.K10TextBox.Size = New System.Drawing.Size(61, 20)
        Me.K10TextBox.TabIndex = 10
        '
        'K4TextBox
        '
        Me.K4TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.K4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblLicenseBindingSource, "K4", True))
        Me.K4TextBox.Location = New System.Drawing.Point(502, 125)
        Me.K4TextBox.Name = "K4TextBox"
        Me.K4TextBox.Size = New System.Drawing.Size(61, 20)
        Me.K4TextBox.TabIndex = 12
        '
        'RTCHTextBox
        '
        Me.RTCHTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RTCHTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblLicenseBindingSource, "RTCH", True))
        Me.RTCHTextBox.Location = New System.Drawing.Point(97, 163)
        Me.RTCHTextBox.Name = "RTCHTextBox"
        Me.RTCHTextBox.Size = New System.Drawing.Size(61, 20)
        Me.RTCHTextBox.TabIndex = 14
        '
        'PLSTextBox
        '
        Me.PLSTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PLSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblLicenseBindingSource, "PLS", True))
        Me.PLSTextBox.Location = New System.Drawing.Point(243, 163)
        Me.PLSTextBox.Name = "PLSTextBox"
        Me.PLSTextBox.Size = New System.Drawing.Size(61, 20)
        Me.PLSTextBox.TabIndex = 16
        '
        'HMMMVTextBox
        '
        Me.HMMMVTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.HMMMVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblLicenseBindingSource, "HMMMV", True))
        Me.HMMMVTextBox.Location = New System.Drawing.Point(404, 163)
        Me.HMMMVTextBox.Name = "HMMMVTextBox"
        Me.HMMMVTextBox.Size = New System.Drawing.Size(61, 20)
        Me.HMMMVTextBox.TabIndex = 18
        '
        'FMTVTextBox
        '
        Me.FMTVTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FMTVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblLicenseBindingSource, "FMTV", True))
        Me.FMTVTextBox.Location = New System.Drawing.Point(552, 163)
        Me.FMTVTextBox.Name = "FMTVTextBox"
        Me.FMTVTextBox.Size = New System.Drawing.Size(61, 20)
        Me.FMTVTextBox.TabIndex = 20
        '
        'LMTVTextBox
        '
        Me.LMTVTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LMTVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblLicenseBindingSource, "LMTV", True))
        Me.LMTVTextBox.Location = New System.Drawing.Point(97, 197)
        Me.LMTVTextBox.Name = "LMTVTextBox"
        Me.LMTVTextBox.Size = New System.Drawing.Size(61, 20)
        Me.LMTVTextBox.TabIndex = 22
        '
        'MTVTextBox
        '
        Me.MTVTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MTVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblLicenseBindingSource, "MTV", True))
        Me.MTVTextBox.Location = New System.Drawing.Point(243, 197)
        Me.MTVTextBox.Name = "MTVTextBox"
        Me.MTVTextBox.Size = New System.Drawing.Size(61, 20)
        Me.MTVTextBox.TabIndex = 24
        '
        'M915TextBox
        '
        Me.M915TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.M915TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblLicenseBindingSource, "M915", True))
        Me.M915TextBox.Location = New System.Drawing.Point(375, 197)
        Me.M915TextBox.Name = "M915TextBox"
        Me.M915TextBox.Size = New System.Drawing.Size(61, 20)
        Me.M915TextBox.TabIndex = 26
        '
        'BUSTextBox
        '
        Me.BUSTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BUSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblLicenseBindingSource, "BUS", True))
        Me.BUSTextBox.Location = New System.Drawing.Point(502, 197)
        Me.BUSTextBox.Name = "BUSTextBox"
        Me.BUSTextBox.Size = New System.Drawing.Size(61, 20)
        Me.BUSTextBox.TabIndex = 28
        '
        'GENERATORTextBox
        '
        Me.GENERATORTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.GENERATORTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblLicenseBindingSource, "GENERATOR", True))
        Me.GENERATORTextBox.Location = New System.Drawing.Point(145, 238)
        Me.GENERATORTextBox.Name = "GENERATORTextBox"
        Me.GENERATORTextBox.Size = New System.Drawing.Size(61, 20)
        Me.GENERATORTextBox.TabIndex = 30
        '
        'CvilianLienceTextBox
        '
        Me.CvilianLienceTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CvilianLienceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblLicenseBindingSource, "CvilianLience", True))
        Me.CvilianLienceTextBox.Location = New System.Drawing.Point(433, 238)
        Me.CvilianLienceTextBox.Name = "CvilianLienceTextBox"
        Me.CvilianLienceTextBox.Size = New System.Drawing.Size(159, 20)
        Me.CvilianLienceTextBox.TabIndex = 32
        '
        'TblSoldierBindingSource
        '
        Me.TblSoldierBindingSource.DataMember = "tblSoldier"
        Me.TblSoldierBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'SoldierIDTextBox1
        '
        Me.SoldierIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "SoldierID", True))
        Me.SoldierIDTextBox1.Location = New System.Drawing.Point(436, 35)
        Me.SoldierIDTextBox1.Name = "SoldierIDTextBox1"
        Me.SoldierIDTextBox1.ReadOnly = True
        Me.SoldierIDTextBox1.Size = New System.Drawing.Size(60, 20)
        Me.SoldierIDTextBox1.TabIndex = 34
        '
        'RankLastTextBox
        '
        Me.RankLastTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "RankLast", True))
        Me.RankLastTextBox.Location = New System.Drawing.Point(189, 92)
        Me.RankLastTextBox.Name = "RankLastTextBox"
        Me.RankLastTextBox.ReadOnly = True
        Me.RankLastTextBox.Size = New System.Drawing.Size(209, 20)
        Me.RankLastTextBox.TabIndex = 36
        '
        'AddLicense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 269)
        Me.ControlBox = False
        Me.Controls.Add(RankLastLabel)
        Me.Controls.Add(Me.RankLastTextBox)
        Me.Controls.Add(SoldierIDLabel1)
        Me.Controls.Add(Me.SoldierIDTextBox1)
        Me.Controls.Add(LicenseIDLabel)
        Me.Controls.Add(Me.LicenseIDTextBox)
        Me.Controls.Add(SoldierIDLabel)
        Me.Controls.Add(Me.SoldierIDTextBox)
        Me.Controls.Add(AACLabel)
        Me.Controls.Add(Me.AACTextBox)
        Me.Controls.Add(_40TonLabel)
        Me.Controls.Add(Me.Ton40TextBox)
        Me.Controls.Add(_10KLabel)
        Me.Controls.Add(Me.K10TextBox)
        Me.Controls.Add(_4KLabel)
        Me.Controls.Add(Me.K4TextBox)
        Me.Controls.Add(RTCHLabel)
        Me.Controls.Add(Me.RTCHTextBox)
        Me.Controls.Add(PLSLabel)
        Me.Controls.Add(Me.PLSTextBox)
        Me.Controls.Add(HMMMVLabel)
        Me.Controls.Add(Me.HMMMVTextBox)
        Me.Controls.Add(FMTVLabel)
        Me.Controls.Add(Me.FMTVTextBox)
        Me.Controls.Add(LMTVLabel)
        Me.Controls.Add(Me.LMTVTextBox)
        Me.Controls.Add(MTVLabel)
        Me.Controls.Add(Me.MTVTextBox)
        Me.Controls.Add(M915Label)
        Me.Controls.Add(Me.M915TextBox)
        Me.Controls.Add(BUSLabel)
        Me.Controls.Add(Me.BUSTextBox)
        Me.Controls.Add(GENERATORLabel)
        Me.Controls.Add(Me.GENERATORTextBox)
        Me.Controls.Add(CvilianLienceLabel)
        Me.Controls.Add(Me.CvilianLienceTextBox)
        Me.Controls.Add(Me.TblLicenseBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AddLicense"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD/EDIT/DELETE SOLDIER'S LICENSE FORM"
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblLicenseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblLicenseBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblLicenseBindingNavigator.ResumeLayout(False)
        Me.TblLicenseBindingNavigator.PerformLayout()
        CType(Me.TblSoldierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Soldier_RosterDataSet As Soldier_RosterDataSet
    Friend WithEvents TblLicenseBindingSource As BindingSource
    Friend WithEvents TblLicenseTableAdapter As Soldier_RosterDataSetTableAdapters.tblLicenseTableAdapter
    Friend WithEvents TableAdapterManager As Soldier_RosterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblLicenseBindingNavigator As BindingNavigator
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
    Friend WithEvents LicenseIDTextBox As TextBox
    Friend WithEvents SoldierIDTextBox As TextBox
    Friend WithEvents AACTextBox As TextBox
    Friend WithEvents Ton40TextBox As TextBox
    Friend WithEvents K10TextBox As TextBox
    Friend WithEvents K4TextBox As TextBox
    Friend WithEvents RTCHTextBox As TextBox
    Friend WithEvents PLSTextBox As TextBox
    Friend WithEvents HMMMVTextBox As TextBox
    Friend WithEvents FMTVTextBox As TextBox
    Friend WithEvents LMTVTextBox As TextBox
    Friend WithEvents MTVTextBox As TextBox
    Friend WithEvents M915TextBox As TextBox
    Friend WithEvents BUSTextBox As TextBox
    Friend WithEvents GENERATORTextBox As TextBox
    Friend WithEvents CvilianLienceTextBox As TextBox
    Friend WithEvents TblSoldierBindingSource As BindingSource
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents SoldierIDTextBox1 As TextBox
    Friend WithEvents RankLastTextBox As TextBox
End Class
