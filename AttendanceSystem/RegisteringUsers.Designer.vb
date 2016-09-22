<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisteringUsers
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
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim SectionLabel As System.Windows.Forms.Label
        Dim UserLevelLabel As System.Windows.Forms.Label
        Dim StampLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisteringUsers))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Bu_Ver = New System.Windows.Forms.Button()
        Me.Bu_Reg = New System.Windows.Forms.Button()
        Me.PB_finger = New System.Windows.Forms.PictureBox()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.UsersTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSheetDataSet = New AttendanceSystem.DataSheetDataSet()
        Me.StampTextBox = New System.Windows.Forms.TextBox()
        Me.UserLevelComboBox = New System.Windows.Forms.ComboBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.SectionComboBox = New System.Windows.Forms.ComboBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsersTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsersTableTableAdapter = New AttendanceSystem.DataSheetDataSetTableAdapters.UsersTableTableAdapter()
        Me.TableAdapterManager = New AttendanceSystem.DataSheetDataSetTableAdapters.TableAdapterManager()
        Me.UsersTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UsersTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.AxZKFPEngX1 = New AxZKFPEngXControl.AxZKFPEngX()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        UserIDLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        SectionLabel = New System.Windows.Forms.Label()
        UserLevelLabel = New System.Windows.Forms.Label()
        StampLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PB_finger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSheetDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UsersTableBindingNavigator.SuspendLayout()
        CType(Me.AxZKFPEngX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Location = New System.Drawing.Point(42, 49)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(64, 18)
        UserIDLabel.TabIndex = 1
        UserIDLabel.Text = "User ID:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(42, 81)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(80, 18)
        UsernameLabel.TabIndex = 3
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(42, 113)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(74, 18)
        PasswordLabel.TabIndex = 5
        PasswordLabel.Text = "Password:"
        '
        'SectionLabel
        '
        SectionLabel.AutoSize = True
        SectionLabel.Location = New System.Drawing.Point(42, 145)
        SectionLabel.Name = "SectionLabel"
        SectionLabel.Size = New System.Drawing.Size(59, 18)
        SectionLabel.TabIndex = 7
        SectionLabel.Text = "Section:"
        '
        'UserLevelLabel
        '
        UserLevelLabel.AutoSize = True
        UserLevelLabel.Location = New System.Drawing.Point(42, 177)
        UserLevelLabel.Name = "UserLevelLabel"
        UserLevelLabel.Size = New System.Drawing.Size(81, 18)
        UserLevelLabel.TabIndex = 9
        UserLevelLabel.Text = "User Level:"
        '
        'StampLabel
        '
        StampLabel.AutoSize = True
        StampLabel.Location = New System.Drawing.Point(42, 238)
        StampLabel.Name = "StampLabel"
        StampLabel.Size = New System.Drawing.Size(55, 18)
        StampLabel.TabIndex = 11
        StampLabel.Text = "Stamp:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.UsersTableDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 29)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(805, 633)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Info"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Bu_Ver)
        Me.GroupBox2.Controls.Add(Me.Bu_Reg)
        Me.GroupBox2.Controls.Add(Me.PB_finger)
        Me.GroupBox2.Controls.Add(Me.UserIDTextBox)
        Me.GroupBox2.Controls.Add(UserIDLabel)
        Me.GroupBox2.Controls.Add(Me.StampTextBox)
        Me.GroupBox2.Controls.Add(StampLabel)
        Me.GroupBox2.Controls.Add(UsernameLabel)
        Me.GroupBox2.Controls.Add(Me.UserLevelComboBox)
        Me.GroupBox2.Controls.Add(Me.UsernameTextBox)
        Me.GroupBox2.Controls.Add(UserLevelLabel)
        Me.GroupBox2.Controls.Add(PasswordLabel)
        Me.GroupBox2.Controls.Add(Me.SectionComboBox)
        Me.GroupBox2.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox2.Controls.Add(SectionLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 314)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(793, 312)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Stamp"
        '
        'Bu_Ver
        '
        Me.Bu_Ver.Location = New System.Drawing.Point(45, 272)
        Me.Bu_Ver.Name = "Bu_Ver"
        Me.Bu_Ver.Size = New System.Drawing.Size(177, 23)
        Me.Bu_Ver.TabIndex = 15
        Me.Bu_Ver.Text = "Verify "
        Me.Bu_Ver.UseVisualStyleBackColor = True
        '
        'Bu_Reg
        '
        Me.Bu_Reg.Location = New System.Drawing.Point(57, 206)
        Me.Bu_Reg.Name = "Bu_Reg"
        Me.Bu_Reg.Size = New System.Drawing.Size(177, 23)
        Me.Bu_Reg.TabIndex = 14
        Me.Bu_Reg.Text = "Register"
        Me.Bu_Reg.UseVisualStyleBackColor = True
        '
        'PB_finger
        '
        Me.PB_finger.Location = New System.Drawing.Point(461, 25)
        Me.PB_finger.Name = "PB_finger"
        Me.PB_finger.Size = New System.Drawing.Size(326, 270)
        Me.PB_finger.TabIndex = 0
        Me.PB_finger.TabStop = False
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersTableBindingSource, "UserID", True))
        Me.UserIDTextBox.Location = New System.Drawing.Point(129, 46)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.ReadOnly = True
        Me.UserIDTextBox.Size = New System.Drawing.Size(121, 26)
        Me.UserIDTextBox.TabIndex = 2
        '
        'UsersTableBindingSource
        '
        Me.UsersTableBindingSource.DataMember = "UsersTable"
        Me.UsersTableBindingSource.DataSource = Me.DataSheetDataSet
        '
        'DataSheetDataSet
        '
        Me.DataSheetDataSet.DataSetName = "DataSheetDataSet"
        Me.DataSheetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StampTextBox
        '
        Me.StampTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersTableBindingSource, "Stamp", True))
        Me.StampTextBox.Location = New System.Drawing.Point(129, 235)
        Me.StampTextBox.Name = "StampTextBox"
        Me.StampTextBox.Size = New System.Drawing.Size(121, 26)
        Me.StampTextBox.TabIndex = 12
        '
        'UserLevelComboBox
        '
        Me.UserLevelComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersTableBindingSource, "UserLevel", True))
        Me.UserLevelComboBox.FormattingEnabled = True
        Me.UserLevelComboBox.Items.AddRange(New Object() {"Admin", "Diroctor", "Manager", "User"})
        Me.UserLevelComboBox.Location = New System.Drawing.Point(129, 174)
        Me.UserLevelComboBox.Name = "UserLevelComboBox"
        Me.UserLevelComboBox.Size = New System.Drawing.Size(121, 26)
        Me.UserLevelComboBox.TabIndex = 10
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersTableBindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(129, 78)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(121, 26)
        Me.UsernameTextBox.TabIndex = 4
        '
        'SectionComboBox
        '
        Me.SectionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersTableBindingSource, "Section", True))
        Me.SectionComboBox.FormattingEnabled = True
        Me.SectionComboBox.Items.AddRange(New Object() {"Admin", "Architectural", "Structural", "MEP", "Contracts", "Project Coordination", "Business Development", "Secretary", "Other", "Site Engineer", "Drivers", "Accounter"})
        Me.SectionComboBox.Location = New System.Drawing.Point(129, 142)
        Me.SectionComboBox.Name = "SectionComboBox"
        Me.SectionComboBox.Size = New System.Drawing.Size(121, 26)
        Me.SectionComboBox.TabIndex = 8
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersTableBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(129, 110)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(121, 26)
        Me.PasswordTextBox.TabIndex = 6
        '
        'UsersTableDataGridView
        '
        Me.UsersTableDataGridView.AllowUserToAddRows = False
        Me.UsersTableDataGridView.AllowUserToDeleteRows = False
        Me.UsersTableDataGridView.AllowUserToResizeColumns = False
        Me.UsersTableDataGridView.AllowUserToResizeRows = False
        Me.UsersTableDataGridView.AutoGenerateColumns = False
        Me.UsersTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.UsersTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsersTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.UsersTableDataGridView.DataSource = Me.UsersTableBindingSource
        Me.UsersTableDataGridView.Location = New System.Drawing.Point(6, 26)
        Me.UsersTableDataGridView.Name = "UsersTableDataGridView"
        Me.UsersTableDataGridView.ReadOnly = True
        Me.UsersTableDataGridView.Size = New System.Drawing.Size(793, 282)
        Me.UsersTableDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "UserID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "UserID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Username"
        Me.DataGridViewTextBoxColumn2.FillWeight = 110.9452!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn3.FillWeight = 69.15678!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Section"
        Me.DataGridViewTextBoxColumn4.FillWeight = 142.963!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Section"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UserLevel"
        Me.DataGridViewTextBoxColumn5.FillWeight = 110.9452!
        Me.DataGridViewTextBoxColumn5.HeaderText = "UserLevel"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Stamp"
        Me.DataGridViewTextBoxColumn6.FillWeight = 65.98985!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Stamp"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'UsersTableTableAdapter
        '
        Me.UsersTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = AttendanceSystem.DataSheetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableTableAdapter = Me.UsersTableTableAdapter
        '
        'UsersTableBindingNavigator
        '
        Me.UsersTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UsersTableBindingNavigator.BindingSource = Me.UsersTableBindingSource
        Me.UsersTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UsersTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UsersTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UsersTableBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.UsersTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UsersTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UsersTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UsersTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UsersTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UsersTableBindingNavigator.Name = "UsersTableBindingNavigator"
        Me.UsersTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UsersTableBindingNavigator.Size = New System.Drawing.Size(843, 25)
        Me.UsersTableBindingNavigator.TabIndex = 1
        Me.UsersTableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
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
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'UsersTableBindingNavigatorSaveItem
        '
        Me.UsersTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UsersTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("UsersTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UsersTableBindingNavigatorSaveItem.Name = "UsersTableBindingNavigatorSaveItem"
        Me.UsersTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UsersTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Add new"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Delete"
        '
        'AxZKFPEngX1
        '
        Me.AxZKFPEngX1.Enabled = True
        Me.AxZKFPEngX1.Location = New System.Drawing.Point(685, 12)
        Me.AxZKFPEngX1.Name = "AxZKFPEngX1"
        Me.AxZKFPEngX1.OcxState = CType(resources.GetObject("AxZKFPEngX1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxZKFPEngX1.Size = New System.Drawing.Size(24, 24)
        Me.AxZKFPEngX1.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel3, Me.StatusLabel1, Me.StatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 680)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(843, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel3
        '
        Me.StatusLabel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel3.Name = "StatusLabel3"
        Me.StatusLabel3.Size = New System.Drawing.Size(118, 17)
        Me.StatusLabel3.Text = "ToolStripStatusLabel1"
        Me.StatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatusLabel1
        '
        Me.StatusLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel1.Name = "StatusLabel1"
        Me.StatusLabel1.Size = New System.Drawing.Size(92, 17)
        Me.StatusLabel1.Text = "Sensor Number :"
        Me.StatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatusLabel2
        '
        Me.StatusLabel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel2.Name = "StatusLabel2"
        Me.StatusLabel2.Size = New System.Drawing.Size(85, 17)
        Me.StatusLabel2.Text = "Serial Number :"
        Me.StatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RegisteringUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 702)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.AxZKFPEngX1)
        Me.Controls.Add(Me.UsersTableBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RegisteringUsers"
        Me.Text = "RegisteringUsers  / Coded by Ahmad Mansoor "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PB_finger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSheetDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UsersTableBindingNavigator.ResumeLayout(False)
        Me.UsersTableBindingNavigator.PerformLayout()
        CType(Me.AxZKFPEngX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataSheetDataSet As DataSheetDataSet
    Friend WithEvents UsersTableBindingSource As BindingSource
    Friend WithEvents UsersTableTableAdapter As DataSheetDataSetTableAdapters.UsersTableTableAdapter
    Friend WithEvents TableAdapterManager As DataSheetDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsersTableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents UsersTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents UsersTableDataGridView As DataGridView
    Friend WithEvents UserIDTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents SectionComboBox As ComboBox
    Friend WithEvents UserLevelComboBox As ComboBox
    Friend WithEvents StampTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents AxZKFPEngX1 As AxZKFPEngXControl.AxZKFPEngX
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusLabel1 As ToolStripStatusLabel
    Friend WithEvents StatusLabel2 As ToolStripStatusLabel
    Friend WithEvents StatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents Bu_Reg As Button
    Friend WithEvents PB_finger As PictureBox
    Friend WithEvents Bu_Ver As Button
End Class
