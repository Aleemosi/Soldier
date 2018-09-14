<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddNco
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
        Dim NCOERIDLabel As System.Windows.Forms.Label
        Dim SoldierIDLabel As System.Windows.Forms.Label
        Dim FirstQuarterLabel As System.Windows.Forms.Label
        Dim SecondQuaterLabel As System.Windows.Forms.Label
        Dim ThirdQuaterLabel As System.Windows.Forms.Label
        Dim FourthQuaterLabel As System.Windows.Forms.Label
        Dim FinalNCOERLabel As System.Windows.Forms.Label
        Dim SoldierIDLabel1 As System.Windows.Forms.Label
        Dim RankLastLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNco))
        Me.Soldier_RosterDataSet = New SoldierRosterSystem.Soldier_RosterDataSet()
        Me.TblNCOERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblNCOERTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblNCOERTableAdapter()
        Me.TableAdapterManager = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.TableAdapterManager()
        Me.TblSoldierTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblSoldierTableAdapter()
        Me.TblNCOERBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.NCOERIDTextBox = New System.Windows.Forms.TextBox()
        Me.SoldierIDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstQuarterDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SecondQuaterDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ThirdQuaterDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FourthQuaterDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FinalNCOERDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TblSoldierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SoldierIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.RankLastTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        NCOERIDLabel = New System.Windows.Forms.Label()
        SoldierIDLabel = New System.Windows.Forms.Label()
        FirstQuarterLabel = New System.Windows.Forms.Label()
        SecondQuaterLabel = New System.Windows.Forms.Label()
        ThirdQuaterLabel = New System.Windows.Forms.Label()
        FourthQuaterLabel = New System.Windows.Forms.Label()
        FinalNCOERLabel = New System.Windows.Forms.Label()
        SoldierIDLabel1 = New System.Windows.Forms.Label()
        RankLastLabel = New System.Windows.Forms.Label()
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblNCOERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblNCOERBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblNCOERBindingNavigator.SuspendLayout()
        CType(Me.TblSoldierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NCOERIDLabel
        '
        NCOERIDLabel.AutoSize = True
        NCOERIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NCOERIDLabel.Location = New System.Drawing.Point(12, 37)
        NCOERIDLabel.Name = "NCOERIDLabel"
        NCOERIDLabel.Size = New System.Drawing.Size(73, 15)
        NCOERIDLabel.TabIndex = 1
        NCOERIDLabel.Text = "NCOERID:"
        '
        'SoldierIDLabel
        '
        SoldierIDLabel.AutoSize = True
        SoldierIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SoldierIDLabel.Location = New System.Drawing.Point(174, 37)
        SoldierIDLabel.Name = "SoldierIDLabel"
        SoldierIDLabel.Size = New System.Drawing.Size(75, 15)
        SoldierIDLabel.TabIndex = 3
        SoldierIDLabel.Text = "Soldier ID:"
        '
        'FirstQuarterLabel
        '
        FirstQuarterLabel.AutoSize = True
        FirstQuarterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstQuarterLabel.Location = New System.Drawing.Point(21, 123)
        FirstQuarterLabel.Name = "FirstQuarterLabel"
        FirstQuarterLabel.Size = New System.Drawing.Size(91, 15)
        FirstQuarterLabel.TabIndex = 5
        FirstQuarterLabel.Text = "First Quarter:"
        '
        'SecondQuaterLabel
        '
        SecondQuaterLabel.AutoSize = True
        SecondQuaterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SecondQuaterLabel.Location = New System.Drawing.Point(262, 123)
        SecondQuaterLabel.Name = "SecondQuaterLabel"
        SecondQuaterLabel.Size = New System.Drawing.Size(111, 15)
        SecondQuaterLabel.TabIndex = 7
        SecondQuaterLabel.Text = "Second Quarter:"
        '
        'ThirdQuaterLabel
        '
        ThirdQuaterLabel.AutoSize = True
        ThirdQuaterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ThirdQuaterLabel.Location = New System.Drawing.Point(21, 155)
        ThirdQuaterLabel.Name = "ThirdQuaterLabel"
        ThirdQuaterLabel.Size = New System.Drawing.Size(96, 15)
        ThirdQuaterLabel.TabIndex = 9
        ThirdQuaterLabel.Text = "Third Quarter:"
        '
        'FourthQuaterLabel
        '
        FourthQuaterLabel.AutoSize = True
        FourthQuaterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FourthQuaterLabel.Location = New System.Drawing.Point(269, 155)
        FourthQuaterLabel.Name = "FourthQuaterLabel"
        FourthQuaterLabel.Size = New System.Drawing.Size(104, 15)
        FourthQuaterLabel.TabIndex = 11
        FourthQuaterLabel.Text = "Fourth Quarter:"
        '
        'FinalNCOERLabel
        '
        FinalNCOERLabel.AutoSize = True
        FinalNCOERLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FinalNCOERLabel.Location = New System.Drawing.Point(171, 193)
        FinalNCOERLabel.Name = "FinalNCOERLabel"
        FinalNCOERLabel.Size = New System.Drawing.Size(95, 15)
        FinalNCOERLabel.TabIndex = 13
        FinalNCOERLabel.Text = "Final NCOER:"
        '
        'SoldierIDLabel1
        '
        SoldierIDLabel1.AutoSize = True
        SoldierIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SoldierIDLabel1.Location = New System.Drawing.Point(335, 37)
        SoldierIDLabel1.Name = "SoldierIDLabel1"
        SoldierIDLabel1.Size = New System.Drawing.Size(75, 15)
        SoldierIDLabel1.TabIndex = 15
        SoldierIDLabel1.Text = "Soldier ID:"
        '
        'RankLastLabel
        '
        RankLastLabel.AutoSize = True
        RankLastLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RankLastLabel.Location = New System.Drawing.Point(235, 72)
        RankLastLabel.Name = "RankLastLabel"
        RankLastLabel.Size = New System.Drawing.Size(67, 15)
        RankLastLabel.TabIndex = 17
        RankLastLabel.Text = "SOLDIER"
        '
        'Soldier_RosterDataSet
        '
        Me.Soldier_RosterDataSet.DataSetName = "Soldier_RosterDataSet"
        Me.Soldier_RosterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblNCOERBindingSource
        '
        Me.TblNCOERBindingSource.DataMember = "tblNCOER"
        Me.TblNCOERBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'TblNCOERTableAdapter
        '
        Me.TblNCOERTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblNCOERTableAdapter = Me.TblNCOERTableAdapter
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
        'TblNCOERBindingNavigator
        '
        Me.TblNCOERBindingNavigator.AddNewItem = Nothing
        Me.TblNCOERBindingNavigator.BindingSource = Me.TblNCOERBindingSource
        Me.TblNCOERBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblNCOERBindingNavigator.DeleteItem = Nothing
        Me.TblNCOERBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.TblNCOERBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblNCOERBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblNCOERBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblNCOERBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblNCOERBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblNCOERBindingNavigator.Name = "TblNCOERBindingNavigator"
        Me.TblNCOERBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblNCOERBindingNavigator.Size = New System.Drawing.Size(662, 25)
        Me.TblNCOERBindingNavigator.TabIndex = 0
        Me.TblNCOERBindingNavigator.Text = "BindingNavigator1"
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
        Me.ToolStripButton1.ToolTipText = "ATL+A"
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
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripButton4.Text = "&NCO EVALUATION FORM"
        Me.ToolStripButton4.ToolTipText = "ALT+N"
        '
        'NCOERIDTextBox
        '
        Me.NCOERIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblNCOERBindingSource, "NCOERID", True))
        Me.NCOERIDTextBox.Location = New System.Drawing.Point(91, 36)
        Me.NCOERIDTextBox.Name = "NCOERIDTextBox"
        Me.NCOERIDTextBox.ReadOnly = True
        Me.NCOERIDTextBox.Size = New System.Drawing.Size(47, 20)
        Me.NCOERIDTextBox.TabIndex = 2
        '
        'SoldierIDTextBox
        '
        Me.SoldierIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblNCOERBindingSource, "SoldierID", True))
        Me.SoldierIDTextBox.Location = New System.Drawing.Point(255, 36)
        Me.SoldierIDTextBox.Name = "SoldierIDTextBox"
        Me.SoldierIDTextBox.ReadOnly = True
        Me.SoldierIDTextBox.Size = New System.Drawing.Size(47, 20)
        Me.SoldierIDTextBox.TabIndex = 4
        '
        'FirstQuarterDateTimePicker
        '
        Me.FirstQuarterDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblNCOERBindingSource, "FirstQuarter", True))
        Me.FirstQuarterDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FirstQuarterDateTimePicker.Location = New System.Drawing.Point(128, 119)
        Me.FirstQuarterDateTimePicker.Name = "FirstQuarterDateTimePicker"
        Me.FirstQuarterDateTimePicker.Size = New System.Drawing.Size(108, 20)
        Me.FirstQuarterDateTimePicker.TabIndex = 6
        Me.FirstQuarterDateTimePicker.Value = New Date(2017, 7, 20, 0, 0, 0, 0)
        '
        'SecondQuaterDateTimePicker
        '
        Me.SecondQuaterDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblNCOERBindingSource, "SecondQuater", True))
        Me.SecondQuaterDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.SecondQuaterDateTimePicker.Location = New System.Drawing.Point(374, 119)
        Me.SecondQuaterDateTimePicker.Name = "SecondQuaterDateTimePicker"
        Me.SecondQuaterDateTimePicker.Size = New System.Drawing.Size(108, 20)
        Me.SecondQuaterDateTimePicker.TabIndex = 8
        Me.SecondQuaterDateTimePicker.Value = New Date(2017, 7, 20, 0, 0, 0, 0)
        '
        'ThirdQuaterDateTimePicker
        '
        Me.ThirdQuaterDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblNCOERBindingSource, "ThirdQuater", True))
        Me.ThirdQuaterDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ThirdQuaterDateTimePicker.Location = New System.Drawing.Point(128, 151)
        Me.ThirdQuaterDateTimePicker.Name = "ThirdQuaterDateTimePicker"
        Me.ThirdQuaterDateTimePicker.Size = New System.Drawing.Size(108, 20)
        Me.ThirdQuaterDateTimePicker.TabIndex = 10
        Me.ThirdQuaterDateTimePicker.Value = New Date(2017, 7, 20, 0, 0, 0, 0)
        '
        'FourthQuaterDateTimePicker
        '
        Me.FourthQuaterDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblNCOERBindingSource, "FourthQuater", True))
        Me.FourthQuaterDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FourthQuaterDateTimePicker.Location = New System.Drawing.Point(374, 151)
        Me.FourthQuaterDateTimePicker.Name = "FourthQuaterDateTimePicker"
        Me.FourthQuaterDateTimePicker.Size = New System.Drawing.Size(108, 20)
        Me.FourthQuaterDateTimePicker.TabIndex = 12
        Me.FourthQuaterDateTimePicker.Value = New Date(2017, 7, 20, 0, 0, 0, 0)
        '
        'FinalNCOERDateTimePicker
        '
        Me.FinalNCOERDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblNCOERBindingSource, "FinalNCOER", True))
        Me.FinalNCOERDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FinalNCOERDateTimePicker.Location = New System.Drawing.Point(272, 189)
        Me.FinalNCOERDateTimePicker.Name = "FinalNCOERDateTimePicker"
        Me.FinalNCOERDateTimePicker.Size = New System.Drawing.Size(108, 20)
        Me.FinalNCOERDateTimePicker.TabIndex = 14
        Me.FinalNCOERDateTimePicker.Value = New Date(2017, 7, 20, 0, 0, 0, 0)
        '
        'TblSoldierBindingSource
        '
        Me.TblSoldierBindingSource.DataMember = "tblSoldier"
        Me.TblSoldierBindingSource.DataSource = Me.Soldier_RosterDataSet
        '
        'SoldierIDTextBox1
        '
        Me.SoldierIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "SoldierID", True))
        Me.SoldierIDTextBox1.Location = New System.Drawing.Point(416, 36)
        Me.SoldierIDTextBox1.Name = "SoldierIDTextBox1"
        Me.SoldierIDTextBox1.ReadOnly = True
        Me.SoldierIDTextBox1.Size = New System.Drawing.Size(47, 20)
        Me.SoldierIDTextBox1.TabIndex = 16
        '
        'RankLastTextBox
        '
        Me.RankLastTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "RankLast", True))
        Me.RankLastTextBox.Location = New System.Drawing.Point(177, 90)
        Me.RankLastTextBox.Name = "RankLastTextBox"
        Me.RankLastTextBox.ReadOnly = True
        Me.RankLastTextBox.Size = New System.Drawing.Size(178, 20)
        Me.RankLastTextBox.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(395, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(183, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "CALCULATE NCOER DATE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AddNco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 223)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(RankLastLabel)
        Me.Controls.Add(Me.RankLastTextBox)
        Me.Controls.Add(SoldierIDLabel1)
        Me.Controls.Add(Me.SoldierIDTextBox1)
        Me.Controls.Add(NCOERIDLabel)
        Me.Controls.Add(Me.NCOERIDTextBox)
        Me.Controls.Add(SoldierIDLabel)
        Me.Controls.Add(Me.SoldierIDTextBox)
        Me.Controls.Add(FirstQuarterLabel)
        Me.Controls.Add(Me.FirstQuarterDateTimePicker)
        Me.Controls.Add(SecondQuaterLabel)
        Me.Controls.Add(Me.SecondQuaterDateTimePicker)
        Me.Controls.Add(ThirdQuaterLabel)
        Me.Controls.Add(Me.ThirdQuaterDateTimePicker)
        Me.Controls.Add(FourthQuaterLabel)
        Me.Controls.Add(Me.FourthQuaterDateTimePicker)
        Me.Controls.Add(FinalNCOERLabel)
        Me.Controls.Add(Me.FinalNCOERDateTimePicker)
        Me.Controls.Add(Me.TblNCOERBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AddNco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD NON-COMMISSIONED OFFICER EVALUATION DATE FORM"
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblNCOERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblNCOERBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblNCOERBindingNavigator.ResumeLayout(False)
        Me.TblNCOERBindingNavigator.PerformLayout()
        CType(Me.TblSoldierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Soldier_RosterDataSet As Soldier_RosterDataSet
    Friend WithEvents TblNCOERBindingSource As BindingSource
    Friend WithEvents TblNCOERTableAdapter As Soldier_RosterDataSetTableAdapters.tblNCOERTableAdapter
    Friend WithEvents TableAdapterManager As Soldier_RosterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblNCOERBindingNavigator As BindingNavigator
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
    Friend WithEvents NCOERIDTextBox As TextBox
    Friend WithEvents SoldierIDTextBox As TextBox
    Friend WithEvents FirstQuarterDateTimePicker As DateTimePicker
    Friend WithEvents SecondQuaterDateTimePicker As DateTimePicker
    Friend WithEvents ThirdQuaterDateTimePicker As DateTimePicker
    Friend WithEvents FourthQuaterDateTimePicker As DateTimePicker
    Friend WithEvents FinalNCOERDateTimePicker As DateTimePicker
    Friend WithEvents TblSoldierBindingSource As BindingSource
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents SoldierIDTextBox1 As TextBox
    Friend WithEvents RankLastTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
