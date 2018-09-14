<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TrainingForm
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
        Dim TrainingIDLabel As System.Windows.Forms.Label
        Dim SoldierIDLabel As System.Windows.Forms.Label
        Dim APFTestDateLabel As System.Windows.Forms.Label
        Dim PushUpsLabel As System.Windows.Forms.Label
        Dim SitUpsLabel As System.Windows.Forms.Label
        Dim PTScoreLabel As System.Windows.Forms.Label
        Dim WeaponQualificationDateLabel As System.Windows.Forms.Label
        Dim QualScoreLabel As System.Windows.Forms.Label
        Dim AwardLabel As System.Windows.Forms.Label
        Dim PASSFAILLabel As System.Windows.Forms.Label
        Dim SoldierIDLabel1 As System.Windows.Forms.Label
        Dim RankLastLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrainingForm))
        Me.TblTrainingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TrainingIDTextBox = New System.Windows.Forms.TextBox()
        Me.SoldierIDTextBox = New System.Windows.Forms.TextBox()
        Me.APFTestDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PushUpsTextBox = New System.Windows.Forms.TextBox()
        Me.SitUpsTextBox = New System.Windows.Forms.TextBox()
        Me.TwoMileRunTextBox = New System.Windows.Forms.TextBox()
        Me.PTScoreTextBox = New System.Windows.Forms.TextBox()
        Me.WeaponQualificationDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.QualScoreTextBox = New System.Windows.Forms.TextBox()
        Me.AwardTextBox = New System.Windows.Forms.TextBox()
        Me.PASSFAILTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SoldierIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.RankLastTextBox = New System.Windows.Forms.TextBox()
        Me.RunComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TblTrainingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Soldier_RosterDataSet = New SoldierRosterSystem.Soldier_RosterDataSet()
        Me.TblSoldierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblTrainingTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblTrainingTableAdapter()
        Me.TableAdapterManager = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.TableAdapterManager()
        Me.TblSoldierTableAdapter = New SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.tblSoldierTableAdapter()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        TrainingIDLabel = New System.Windows.Forms.Label()
        SoldierIDLabel = New System.Windows.Forms.Label()
        APFTestDateLabel = New System.Windows.Forms.Label()
        PushUpsLabel = New System.Windows.Forms.Label()
        SitUpsLabel = New System.Windows.Forms.Label()
        PTScoreLabel = New System.Windows.Forms.Label()
        WeaponQualificationDateLabel = New System.Windows.Forms.Label()
        QualScoreLabel = New System.Windows.Forms.Label()
        AwardLabel = New System.Windows.Forms.Label()
        PASSFAILLabel = New System.Windows.Forms.Label()
        SoldierIDLabel1 = New System.Windows.Forms.Label()
        RankLastLabel = New System.Windows.Forms.Label()
        CType(Me.TblTrainingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblTrainingBindingNavigator.SuspendLayout()
        CType(Me.TblTrainingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSoldierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrainingIDLabel
        '
        TrainingIDLabel.AutoSize = True
        TrainingIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TrainingIDLabel.Location = New System.Drawing.Point(12, 46)
        TrainingIDLabel.Name = "TrainingIDLabel"
        TrainingIDLabel.Size = New System.Drawing.Size(74, 13)
        TrainingIDLabel.TabIndex = 1
        TrainingIDLabel.Text = "Training ID:"
        '
        'SoldierIDLabel
        '
        SoldierIDLabel.AutoSize = True
        SoldierIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SoldierIDLabel.Location = New System.Drawing.Point(174, 46)
        SoldierIDLabel.Name = "SoldierIDLabel"
        SoldierIDLabel.Size = New System.Drawing.Size(67, 13)
        SoldierIDLabel.TabIndex = 3
        SoldierIDLabel.Text = "Soldier ID:"
        '
        'APFTestDateLabel
        '
        APFTestDateLabel.AutoSize = True
        APFTestDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        APFTestDateLabel.Location = New System.Drawing.Point(22, 139)
        APFTestDateLabel.Name = "APFTestDateLabel"
        APFTestDateLabel.Size = New System.Drawing.Size(90, 13)
        APFTestDateLabel.TabIndex = 5
        APFTestDateLabel.Text = "APFTest Date:"
        '
        'PushUpsLabel
        '
        PushUpsLabel.AutoSize = True
        PushUpsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PushUpsLabel.Location = New System.Drawing.Point(60, 197)
        PushUpsLabel.Name = "PushUpsLabel"
        PushUpsLabel.Size = New System.Drawing.Size(65, 13)
        PushUpsLabel.TabIndex = 7
        PushUpsLabel.Text = "Push Ups:"
        '
        'SitUpsLabel
        '
        SitUpsLabel.AutoSize = True
        SitUpsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SitUpsLabel.Location = New System.Drawing.Point(73, 223)
        SitUpsLabel.Name = "SitUpsLabel"
        SitUpsLabel.Size = New System.Drawing.Size(52, 13)
        SitUpsLabel.TabIndex = 9
        SitUpsLabel.Text = "Sit Ups:"
        '
        'PTScoreLabel
        '
        PTScoreLabel.AutoSize = True
        PTScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PTScoreLabel.Location = New System.Drawing.Point(60, 272)
        PTScoreLabel.Name = "PTScoreLabel"
        PTScoreLabel.Size = New System.Drawing.Size(60, 13)
        PTScoreLabel.TabIndex = 13
        PTScoreLabel.Text = "PTScore:"
        '
        'WeaponQualificationDateLabel
        '
        WeaponQualificationDateLabel.AutoSize = True
        WeaponQualificationDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WeaponQualificationDateLabel.Location = New System.Drawing.Point(369, 139)
        WeaponQualificationDateLabel.Name = "WeaponQualificationDateLabel"
        WeaponQualificationDateLabel.Size = New System.Drawing.Size(164, 13)
        WeaponQualificationDateLabel.TabIndex = 15
        WeaponQualificationDateLabel.Text = "Weapon Qualification Date:"
        '
        'QualScoreLabel
        '
        QualScoreLabel.AutoSize = True
        QualScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QualScoreLabel.Location = New System.Drawing.Point(459, 197)
        QualScoreLabel.Name = "QualScoreLabel"
        QualScoreLabel.Size = New System.Drawing.Size(74, 13)
        QualScoreLabel.TabIndex = 17
        QualScoreLabel.Text = "Qual Score:"
        '
        'AwardLabel
        '
        AwardLabel.AutoSize = True
        AwardLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AwardLabel.Location = New System.Drawing.Point(487, 227)
        AwardLabel.Name = "AwardLabel"
        AwardLabel.Size = New System.Drawing.Size(46, 13)
        AwardLabel.TabIndex = 19
        AwardLabel.Text = "Award:"
        '
        'PASSFAILLabel
        '
        PASSFAILLabel.AutoSize = True
        PASSFAILLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PASSFAILLabel.Location = New System.Drawing.Point(34, 305)
        PASSFAILLabel.Name = "PASSFAILLabel"
        PASSFAILLabel.Size = New System.Drawing.Size(95, 13)
        PASSFAILLabel.TabIndex = 21
        PASSFAILLabel.Text = "PASS OR FAIL:"
        '
        'SoldierIDLabel1
        '
        SoldierIDLabel1.AutoSize = True
        SoldierIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SoldierIDLabel1.Location = New System.Drawing.Point(322, 46)
        SoldierIDLabel1.Name = "SoldierIDLabel1"
        SoldierIDLabel1.Size = New System.Drawing.Size(67, 13)
        SoldierIDLabel1.TabIndex = 24
        SoldierIDLabel1.Text = "Soldier ID:"
        '
        'RankLastLabel
        '
        RankLastLabel.AutoSize = True
        RankLastLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RankLastLabel.Location = New System.Drawing.Point(244, 66)
        RankLastLabel.Name = "RankLastLabel"
        RankLastLabel.Size = New System.Drawing.Size(61, 13)
        RankLastLabel.TabIndex = 26
        RankLastLabel.Text = "SOLDIER"
        '
        'TblTrainingBindingNavigator
        '
        Me.TblTrainingBindingNavigator.AddNewItem = Nothing
        Me.TblTrainingBindingNavigator.BindingSource = Me.TblTrainingBindingSource
        Me.TblTrainingBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblTrainingBindingNavigator.DeleteItem = Nothing
        Me.TblTrainingBindingNavigator.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TblTrainingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.btnAdd, Me.btnSave, Me.btnDelete, Me.ToolStripButton1})
        Me.TblTrainingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblTrainingBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblTrainingBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblTrainingBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblTrainingBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblTrainingBindingNavigator.Name = "TblTrainingBindingNavigator"
        Me.TblTrainingBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblTrainingBindingNavigator.Size = New System.Drawing.Size(704, 25)
        Me.TblTrainingBindingNavigator.TabIndex = 0
        Me.TblTrainingBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TrainingIDTextBox
        '
        Me.TrainingIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTrainingBindingSource, "TrainingID", True))
        Me.TrainingIDTextBox.Location = New System.Drawing.Point(92, 43)
        Me.TrainingIDTextBox.Name = "TrainingIDTextBox"
        Me.TrainingIDTextBox.ReadOnly = True
        Me.TrainingIDTextBox.Size = New System.Drawing.Size(58, 20)
        Me.TrainingIDTextBox.TabIndex = 2
        '
        'SoldierIDTextBox
        '
        Me.SoldierIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTrainingBindingSource, "SoldierID", True))
        Me.SoldierIDTextBox.Location = New System.Drawing.Point(247, 43)
        Me.SoldierIDTextBox.Name = "SoldierIDTextBox"
        Me.SoldierIDTextBox.ReadOnly = True
        Me.SoldierIDTextBox.Size = New System.Drawing.Size(58, 20)
        Me.SoldierIDTextBox.TabIndex = 4
        '
        'APFTestDateDateTimePicker
        '
        Me.APFTestDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblTrainingBindingSource, "APFTestDate", True))
        Me.APFTestDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.APFTestDateDateTimePicker.Location = New System.Drawing.Point(118, 133)
        Me.APFTestDateDateTimePicker.Name = "APFTestDateDateTimePicker"
        Me.APFTestDateDateTimePicker.Size = New System.Drawing.Size(101, 20)
        Me.APFTestDateDateTimePicker.TabIndex = 6
        Me.APFTestDateDateTimePicker.Value = New Date(2018, 2, 4, 0, 0, 0, 0)
        '
        'PushUpsTextBox
        '
        Me.PushUpsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTrainingBindingSource, "PushUps", True))
        Me.PushUpsTextBox.Location = New System.Drawing.Point(131, 194)
        Me.PushUpsTextBox.Name = "PushUpsTextBox"
        Me.PushUpsTextBox.Size = New System.Drawing.Size(58, 20)
        Me.PushUpsTextBox.TabIndex = 8
        '
        'SitUpsTextBox
        '
        Me.SitUpsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTrainingBindingSource, "SitUps", True))
        Me.SitUpsTextBox.Location = New System.Drawing.Point(131, 220)
        Me.SitUpsTextBox.Name = "SitUpsTextBox"
        Me.SitUpsTextBox.Size = New System.Drawing.Size(58, 20)
        Me.SitUpsTextBox.TabIndex = 10
        '
        'TwoMileRunTextBox
        '
        Me.TwoMileRunTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTrainingBindingSource, "TwoMileRun", True))
        Me.TwoMileRunTextBox.Location = New System.Drawing.Point(131, 243)
        Me.TwoMileRunTextBox.Name = "TwoMileRunTextBox"
        Me.TwoMileRunTextBox.Size = New System.Drawing.Size(58, 20)
        Me.TwoMileRunTextBox.TabIndex = 12
        '
        'PTScoreTextBox
        '
        Me.PTScoreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTrainingBindingSource, "PTScore", True))
        Me.PTScoreTextBox.Location = New System.Drawing.Point(131, 269)
        Me.PTScoreTextBox.Name = "PTScoreTextBox"
        Me.PTScoreTextBox.ReadOnly = True
        Me.PTScoreTextBox.Size = New System.Drawing.Size(58, 20)
        Me.PTScoreTextBox.TabIndex = 14
        '
        'WeaponQualificationDateDateTimePicker
        '
        Me.WeaponQualificationDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblTrainingBindingSource, "WeaponQualificationDate", True))
        Me.WeaponQualificationDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.WeaponQualificationDateDateTimePicker.Location = New System.Drawing.Point(539, 133)
        Me.WeaponQualificationDateDateTimePicker.Name = "WeaponQualificationDateDateTimePicker"
        Me.WeaponQualificationDateDateTimePicker.Size = New System.Drawing.Size(101, 20)
        Me.WeaponQualificationDateDateTimePicker.TabIndex = 16
        Me.WeaponQualificationDateDateTimePicker.Value = New Date(2018, 2, 4, 0, 0, 0, 0)
        '
        'QualScoreTextBox
        '
        Me.QualScoreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTrainingBindingSource, "QualScore", True))
        Me.QualScoreTextBox.Location = New System.Drawing.Point(539, 194)
        Me.QualScoreTextBox.Name = "QualScoreTextBox"
        Me.QualScoreTextBox.Size = New System.Drawing.Size(58, 20)
        Me.QualScoreTextBox.TabIndex = 18
        '
        'AwardTextBox
        '
        Me.AwardTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTrainingBindingSource, "Award", True))
        Me.AwardTextBox.Location = New System.Drawing.Point(539, 224)
        Me.AwardTextBox.Name = "AwardTextBox"
        Me.AwardTextBox.ReadOnly = True
        Me.AwardTextBox.Size = New System.Drawing.Size(135, 20)
        Me.AwardTextBox.TabIndex = 20
        '
        'PASSFAILTextBox
        '
        Me.PASSFAILTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTrainingBindingSource, "PASSFAIL", True))
        Me.PASSFAILTextBox.Location = New System.Drawing.Point(131, 302)
        Me.PASSFAILTextBox.Name = "PASSFAILTextBox"
        Me.PASSFAILTextBox.ReadOnly = True
        Me.PASSFAILTextBox.Size = New System.Drawing.Size(110, 20)
        Me.PASSFAILTextBox.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "PHYSICAL TRAINING TEST RAW SCORE"
        '
        'SoldierIDTextBox1
        '
        Me.SoldierIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "SoldierID", True))
        Me.SoldierIDTextBox1.Location = New System.Drawing.Point(395, 43)
        Me.SoldierIDTextBox1.Name = "SoldierIDTextBox1"
        Me.SoldierIDTextBox1.ReadOnly = True
        Me.SoldierIDTextBox1.Size = New System.Drawing.Size(58, 20)
        Me.SoldierIDTextBox1.TabIndex = 25
        '
        'RankLastTextBox
        '
        Me.RankLastTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSoldierBindingSource, "RankLast", True))
        Me.RankLastTextBox.Location = New System.Drawing.Point(177, 82)
        Me.RankLastTextBox.Name = "RankLastTextBox"
        Me.RankLastTextBox.ReadOnly = True
        Me.RankLastTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RankLastTextBox.TabIndex = 27
        '
        'RunComboBox
        '
        Me.RunComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTrainingBindingSource, "Run", True))
        Me.RunComboBox.FormattingEnabled = True
        Me.RunComboBox.Items.AddRange(New Object() {"2 Mile Run", "2.5 M Walk", "6.2M Bike", "800 Yard Swim"})
        Me.RunComboBox.Location = New System.Drawing.Point(32, 243)
        Me.RunComboBox.Name = "RunComboBox"
        Me.RunComboBox.Size = New System.Drawing.Size(93, 21)
        Me.RunComboBox.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(262, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "CALCULATE PT SCORE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(539, 251)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 23)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "SHOW AWARD BADGE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TblTrainingBindingSource
        '
        Me.TblTrainingBindingSource.DataMember = "tblTraining"
        Me.TblTrainingBindingSource.DataSource = Me.Soldier_RosterDataSet
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
        'TblTrainingTableAdapter
        '
        Me.TblTrainingTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblSoldierInfoTableAdapter = Nothing
        Me.TableAdapterManager.tblSoldierTableAdapter = Me.TblSoldierTableAdapter
        Me.TableAdapterManager.tblTrainingTableAdapter = Me.TblTrainingTableAdapter
        Me.TableAdapterManager.UpdateOrder = SoldierRosterSystem.Soldier_RosterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblSoldierTableAdapter
        '
        Me.TblSoldierTableAdapter.ClearBeforeFill = True
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
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(54, 22)
        Me.btnAdd.Text = "ADD"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(58, 22)
        Me.btnSave.Text = "SAVE"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(0, 1, 7, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(71, 22)
        Me.btnDelete.Text = "DELETE"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(0, 1, 7, 2)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(115, 22)
        Me.ToolStripButton1.Text = "SOLDIER FORM"
        '
        'TrainingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 342)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RunComboBox)
        Me.Controls.Add(RankLastLabel)
        Me.Controls.Add(Me.RankLastTextBox)
        Me.Controls.Add(SoldierIDLabel1)
        Me.Controls.Add(Me.SoldierIDTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(TrainingIDLabel)
        Me.Controls.Add(Me.TrainingIDTextBox)
        Me.Controls.Add(SoldierIDLabel)
        Me.Controls.Add(Me.SoldierIDTextBox)
        Me.Controls.Add(APFTestDateLabel)
        Me.Controls.Add(Me.APFTestDateDateTimePicker)
        Me.Controls.Add(PushUpsLabel)
        Me.Controls.Add(Me.PushUpsTextBox)
        Me.Controls.Add(SitUpsLabel)
        Me.Controls.Add(Me.SitUpsTextBox)
        Me.Controls.Add(Me.TwoMileRunTextBox)
        Me.Controls.Add(PTScoreLabel)
        Me.Controls.Add(Me.PTScoreTextBox)
        Me.Controls.Add(WeaponQualificationDateLabel)
        Me.Controls.Add(Me.WeaponQualificationDateDateTimePicker)
        Me.Controls.Add(QualScoreLabel)
        Me.Controls.Add(Me.QualScoreTextBox)
        Me.Controls.Add(AwardLabel)
        Me.Controls.Add(Me.AwardTextBox)
        Me.Controls.Add(PASSFAILLabel)
        Me.Controls.Add(Me.PASSFAILTextBox)
        Me.Controls.Add(Me.TblTrainingBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TrainingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRAINING FORM"
        CType(Me.TblTrainingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblTrainingBindingNavigator.ResumeLayout(False)
        Me.TblTrainingBindingNavigator.PerformLayout()
        CType(Me.TblTrainingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Soldier_RosterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSoldierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Soldier_RosterDataSet As Soldier_RosterDataSet
    Friend WithEvents TblTrainingBindingSource As BindingSource
    Friend WithEvents TblTrainingTableAdapter As Soldier_RosterDataSetTableAdapters.tblTrainingTableAdapter
    Friend WithEvents TableAdapterManager As Soldier_RosterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblTrainingBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents btnAdd As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents TrainingIDTextBox As TextBox
    Friend WithEvents SoldierIDTextBox As TextBox
    Friend WithEvents APFTestDateDateTimePicker As DateTimePicker
    Friend WithEvents PushUpsTextBox As TextBox
    Friend WithEvents SitUpsTextBox As TextBox
    Friend WithEvents TwoMileRunTextBox As TextBox
    Friend WithEvents PTScoreTextBox As TextBox
    Friend WithEvents WeaponQualificationDateDateTimePicker As DateTimePicker
    Friend WithEvents QualScoreTextBox As TextBox
    Friend WithEvents AwardTextBox As TextBox
    Friend WithEvents PASSFAILTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TblSoldierTableAdapter As Soldier_RosterDataSetTableAdapters.tblSoldierTableAdapter
    Friend WithEvents TblSoldierBindingSource As BindingSource
    Friend WithEvents SoldierIDTextBox1 As TextBox
    Friend WithEvents RankLastTextBox As TextBox
    Friend WithEvents RunComboBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
