﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class new_Player
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim First_nameLabel As System.Windows.Forms.Label
        Dim Last_nameLabel As System.Windows.Forms.Label
        Dim DoBLabel As System.Windows.Forms.Label
        Dim CleansheetsLabel As System.Windows.Forms.Label
        Dim Goals_scoredLabel As System.Windows.Forms.Label
        Dim Goals_assistedLabel As System.Windows.Forms.Label
        Dim Yellow_cardsLabel As System.Windows.Forms.Label
        Dim Red_cardsLabel As System.Windows.Forms.Label
        Dim BlocksLabel As System.Windows.Forms.Label
        Dim InterceptionsLabel As System.Windows.Forms.Label
        Dim ClearencesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(new_Player))
        Dim PositionLabel As System.Windows.Forms.Label
        Me.DbKPLDataSet = New soccerDBMS.dbKPLDataSet()
        Me.TblPlayersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPlayersTableAdapter = New soccerDBMS.dbKPLDataSetTableAdapters.tblPlayersTableAdapter()
        Me.TableAdapterManager = New soccerDBMS.dbKPLDataSetTableAdapters.TableAdapterManager()
        Me.TblPlayersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblPlayersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.First_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_nameTextBox = New System.Windows.Forms.TextBox()
        Me.DoBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CleansheetsTextBox = New System.Windows.Forms.TextBox()
        Me.Goals_scoredTextBox = New System.Windows.Forms.TextBox()
        Me.Goals_assistedTextBox = New System.Windows.Forms.TextBox()
        Me.Yellow_cardsTextBox = New System.Windows.Forms.TextBox()
        Me.Red_cardsTextBox = New System.Windows.Forms.TextBox()
        Me.BlocksTextBox = New System.Windows.Forms.TextBox()
        Me.InterceptionsTextBox = New System.Windows.Forms.TextBox()
        Me.ClearencesTextBox = New System.Windows.Forms.TextBox()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.PositionComboBox = New System.Windows.Forms.ComboBox()
        Me.TblPositionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPositionsTableAdapter = New soccerDBMS.dbKPLDataSetTableAdapters.tblPositionsTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        First_nameLabel = New System.Windows.Forms.Label()
        Last_nameLabel = New System.Windows.Forms.Label()
        DoBLabel = New System.Windows.Forms.Label()
        CleansheetsLabel = New System.Windows.Forms.Label()
        Goals_scoredLabel = New System.Windows.Forms.Label()
        Goals_assistedLabel = New System.Windows.Forms.Label()
        Yellow_cardsLabel = New System.Windows.Forms.Label()
        Red_cardsLabel = New System.Windows.Forms.Label()
        BlocksLabel = New System.Windows.Forms.Label()
        InterceptionsLabel = New System.Windows.Forms.Label()
        ClearencesLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        CType(Me.DbKPLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPlayersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPlayersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblPlayersBindingNavigator.SuspendLayout()
        CType(Me.TblPositionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(5, 67)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'First_nameLabel
        '
        First_nameLabel.AutoSize = True
        First_nameLabel.Location = New System.Drawing.Point(5, 97)
        First_nameLabel.Name = "First_nameLabel"
        First_nameLabel.Size = New System.Drawing.Size(58, 13)
        First_nameLabel.TabIndex = 3
        First_nameLabel.Text = "First name:"
        '
        'Last_nameLabel
        '
        Last_nameLabel.AutoSize = True
        Last_nameLabel.Location = New System.Drawing.Point(5, 123)
        Last_nameLabel.Name = "Last_nameLabel"
        Last_nameLabel.Size = New System.Drawing.Size(59, 13)
        Last_nameLabel.TabIndex = 5
        Last_nameLabel.Text = "Last name:"
        '
        'DoBLabel
        '
        DoBLabel.AutoSize = True
        DoBLabel.Location = New System.Drawing.Point(5, 149)
        DoBLabel.Name = "DoBLabel"
        DoBLabel.Size = New System.Drawing.Size(34, 13)
        DoBLabel.TabIndex = 7
        DoBLabel.Text = "Do B:"
        '
        'CleansheetsLabel
        '
        CleansheetsLabel.AutoSize = True
        CleansheetsLabel.Location = New System.Drawing.Point(5, 201)
        CleansheetsLabel.Name = "CleansheetsLabel"
        CleansheetsLabel.Size = New System.Drawing.Size(68, 13)
        CleansheetsLabel.TabIndex = 11
        CleansheetsLabel.Text = "Cleansheets:"
        '
        'Goals_scoredLabel
        '
        Goals_scoredLabel.AutoSize = True
        Goals_scoredLabel.Location = New System.Drawing.Point(5, 227)
        Goals_scoredLabel.Name = "Goals_scoredLabel"
        Goals_scoredLabel.Size = New System.Drawing.Size(72, 13)
        Goals_scoredLabel.TabIndex = 13
        Goals_scoredLabel.Text = "Goals scored:"
        '
        'Goals_assistedLabel
        '
        Goals_assistedLabel.AutoSize = True
        Goals_assistedLabel.Location = New System.Drawing.Point(5, 253)
        Goals_assistedLabel.Name = "Goals_assistedLabel"
        Goals_assistedLabel.Size = New System.Drawing.Size(78, 13)
        Goals_assistedLabel.TabIndex = 15
        Goals_assistedLabel.Text = "Goals assisted:"
        '
        'Yellow_cardsLabel
        '
        Yellow_cardsLabel.AutoSize = True
        Yellow_cardsLabel.Location = New System.Drawing.Point(5, 279)
        Yellow_cardsLabel.Name = "Yellow_cardsLabel"
        Yellow_cardsLabel.Size = New System.Drawing.Size(70, 13)
        Yellow_cardsLabel.TabIndex = 17
        Yellow_cardsLabel.Text = "Yellow cards:"
        '
        'Red_cardsLabel
        '
        Red_cardsLabel.AutoSize = True
        Red_cardsLabel.Location = New System.Drawing.Point(5, 305)
        Red_cardsLabel.Name = "Red_cardsLabel"
        Red_cardsLabel.Size = New System.Drawing.Size(59, 13)
        Red_cardsLabel.TabIndex = 19
        Red_cardsLabel.Text = "Red cards:"
        '
        'BlocksLabel
        '
        BlocksLabel.AutoSize = True
        BlocksLabel.Location = New System.Drawing.Point(5, 331)
        BlocksLabel.Name = "BlocksLabel"
        BlocksLabel.Size = New System.Drawing.Size(42, 13)
        BlocksLabel.TabIndex = 21
        BlocksLabel.Text = "Blocks:"
        '
        'InterceptionsLabel
        '
        InterceptionsLabel.AutoSize = True
        InterceptionsLabel.Location = New System.Drawing.Point(5, 357)
        InterceptionsLabel.Name = "InterceptionsLabel"
        InterceptionsLabel.Size = New System.Drawing.Size(71, 13)
        InterceptionsLabel.TabIndex = 23
        InterceptionsLabel.Text = "Interceptions:"
        '
        'ClearencesLabel
        '
        ClearencesLabel.AutoSize = True
        ClearencesLabel.Location = New System.Drawing.Point(5, 383)
        ClearencesLabel.Name = "ClearencesLabel"
        ClearencesLabel.Size = New System.Drawing.Size(63, 13)
        ClearencesLabel.TabIndex = 25
        ClearencesLabel.Text = "Clearences:"
        '
        'DbKPLDataSet
        '
        Me.DbKPLDataSet.DataSetName = "dbKPLDataSet"
        Me.DbKPLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPlayersBindingSource
        '
        Me.TblPlayersBindingSource.DataMember = "tblPlayers"
        Me.TblPlayersBindingSource.DataSource = Me.DbKPLDataSet
        '
        'TblPlayersTableAdapter
        '
        Me.TblPlayersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblManagersTableAdapter = Nothing
        Me.TableAdapterManager.tblMatchesTableAdapter = Nothing
        Me.TableAdapterManager.tblPlayersTableAdapter = Me.TblPlayersTableAdapter
        Me.TableAdapterManager.tblPositionsTableAdapter = Nothing
        Me.TableAdapterManager.tblRefereesTableAdapter = Nothing
        Me.TableAdapterManager.tblResultsTableAdapter = Nothing
        Me.TableAdapterManager.tblTeamsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = soccerDBMS.dbKPLDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblPlayersBindingNavigator
        '
        Me.TblPlayersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblPlayersBindingNavigator.BindingSource = Me.TblPlayersBindingSource
        Me.TblPlayersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblPlayersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblPlayersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblPlayersBindingNavigatorSaveItem})
        Me.TblPlayersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblPlayersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblPlayersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblPlayersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblPlayersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblPlayersBindingNavigator.Name = "TblPlayersBindingNavigator"
        Me.TblPlayersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblPlayersBindingNavigator.Size = New System.Drawing.Size(669, 25)
        Me.TblPlayersBindingNavigator.TabIndex = 0
        Me.TblPlayersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        'TblPlayersBindingNavigatorSaveItem
        '
        Me.TblPlayersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblPlayersBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblPlayersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblPlayersBindingNavigatorSaveItem.Name = "TblPlayersBindingNavigatorSaveItem"
        Me.TblPlayersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblPlayersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPlayersBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(84, 64)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(121, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'First_nameTextBox
        '
        Me.First_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPlayersBindingSource, "First_name", True))
        Me.First_nameTextBox.Location = New System.Drawing.Point(84, 90)
        Me.First_nameTextBox.Name = "First_nameTextBox"
        Me.First_nameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.First_nameTextBox.TabIndex = 4
        '
        'Last_nameTextBox
        '
        Me.Last_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPlayersBindingSource, "Last_name", True))
        Me.Last_nameTextBox.Location = New System.Drawing.Point(84, 116)
        Me.Last_nameTextBox.Name = "Last_nameTextBox"
        Me.Last_nameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Last_nameTextBox.TabIndex = 6
        '
        'DoBDateTimePicker
        '
        Me.DoBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblPlayersBindingSource, "DoB", True))
        Me.DoBDateTimePicker.Location = New System.Drawing.Point(84, 142)
        Me.DoBDateTimePicker.Name = "DoBDateTimePicker"
        Me.DoBDateTimePicker.Size = New System.Drawing.Size(189, 20)
        Me.DoBDateTimePicker.TabIndex = 8
        '
        'CleansheetsTextBox
        '
        Me.CleansheetsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPlayersBindingSource, "Cleansheets", True))
        Me.CleansheetsTextBox.Location = New System.Drawing.Point(84, 194)
        Me.CleansheetsTextBox.Name = "CleansheetsTextBox"
        Me.CleansheetsTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CleansheetsTextBox.TabIndex = 12
        '
        'Goals_scoredTextBox
        '
        Me.Goals_scoredTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPlayersBindingSource, "Goals scored", True))
        Me.Goals_scoredTextBox.Location = New System.Drawing.Point(84, 220)
        Me.Goals_scoredTextBox.Name = "Goals_scoredTextBox"
        Me.Goals_scoredTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Goals_scoredTextBox.TabIndex = 14
        '
        'Goals_assistedTextBox
        '
        Me.Goals_assistedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPlayersBindingSource, "Goals assisted", True))
        Me.Goals_assistedTextBox.Location = New System.Drawing.Point(84, 246)
        Me.Goals_assistedTextBox.Name = "Goals_assistedTextBox"
        Me.Goals_assistedTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Goals_assistedTextBox.TabIndex = 16
        '
        'Yellow_cardsTextBox
        '
        Me.Yellow_cardsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPlayersBindingSource, "Yellow cards", True))
        Me.Yellow_cardsTextBox.Location = New System.Drawing.Point(84, 272)
        Me.Yellow_cardsTextBox.Name = "Yellow_cardsTextBox"
        Me.Yellow_cardsTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Yellow_cardsTextBox.TabIndex = 18
        '
        'Red_cardsTextBox
        '
        Me.Red_cardsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPlayersBindingSource, "Red cards", True))
        Me.Red_cardsTextBox.Location = New System.Drawing.Point(84, 298)
        Me.Red_cardsTextBox.Name = "Red_cardsTextBox"
        Me.Red_cardsTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Red_cardsTextBox.TabIndex = 20
        '
        'BlocksTextBox
        '
        Me.BlocksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPlayersBindingSource, "Blocks", True))
        Me.BlocksTextBox.Location = New System.Drawing.Point(84, 324)
        Me.BlocksTextBox.Name = "BlocksTextBox"
        Me.BlocksTextBox.Size = New System.Drawing.Size(121, 20)
        Me.BlocksTextBox.TabIndex = 22
        '
        'InterceptionsTextBox
        '
        Me.InterceptionsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPlayersBindingSource, "Interceptions", True))
        Me.InterceptionsTextBox.Location = New System.Drawing.Point(84, 350)
        Me.InterceptionsTextBox.Name = "InterceptionsTextBox"
        Me.InterceptionsTextBox.Size = New System.Drawing.Size(121, 20)
        Me.InterceptionsTextBox.TabIndex = 24
        '
        'ClearencesTextBox
        '
        Me.ClearencesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPlayersBindingSource, "Clearences", True))
        Me.ClearencesTextBox.Location = New System.Drawing.Point(84, 376)
        Me.ClearencesTextBox.Name = "ClearencesTextBox"
        Me.ClearencesTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ClearencesTextBox.TabIndex = 26
        '
        'btn_Save
        '
        Me.btn_Save.BackColor = System.Drawing.Color.Transparent
        Me.btn_Save.Location = New System.Drawing.Point(83, 424)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.btn_Save.TabIndex = 27
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = False
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Location = New System.Drawing.Point(5, 170)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(47, 13)
        PositionLabel.TabIndex = 27
        PositionLabel.Text = "Position:"
        '
        'PositionComboBox
        '
        Me.PositionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPlayersBindingSource, "Position", True))
        Me.PositionComboBox.DataSource = Me.TblPositionsBindingSource
        Me.PositionComboBox.DisplayMember = "Position"
        Me.PositionComboBox.FormattingEnabled = True
        Me.PositionComboBox.Location = New System.Drawing.Point(84, 167)
        Me.PositionComboBox.Name = "PositionComboBox"
        Me.PositionComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PositionComboBox.TabIndex = 28
        '
        'TblPositionsBindingSource
        '
        Me.TblPositionsBindingSource.DataMember = "tblPositions"
        Me.TblPositionsBindingSource.DataSource = Me.DbKPLDataSet
        '
        'TblPositionsTableAdapter
        '
        Me.TblPositionsTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(164, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(2, 424)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "New"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'new_Player
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(669, 459)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(PositionLabel)
        Me.Controls.Add(Me.PositionComboBox)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(ClearencesLabel)
        Me.Controls.Add(Me.ClearencesTextBox)
        Me.Controls.Add(InterceptionsLabel)
        Me.Controls.Add(Me.InterceptionsTextBox)
        Me.Controls.Add(BlocksLabel)
        Me.Controls.Add(Me.BlocksTextBox)
        Me.Controls.Add(Red_cardsLabel)
        Me.Controls.Add(Me.Red_cardsTextBox)
        Me.Controls.Add(Yellow_cardsLabel)
        Me.Controls.Add(Me.Yellow_cardsTextBox)
        Me.Controls.Add(Goals_assistedLabel)
        Me.Controls.Add(Me.Goals_assistedTextBox)
        Me.Controls.Add(Goals_scoredLabel)
        Me.Controls.Add(Me.Goals_scoredTextBox)
        Me.Controls.Add(CleansheetsLabel)
        Me.Controls.Add(Me.CleansheetsTextBox)
        Me.Controls.Add(DoBLabel)
        Me.Controls.Add(Me.DoBDateTimePicker)
        Me.Controls.Add(Last_nameLabel)
        Me.Controls.Add(Me.Last_nameTextBox)
        Me.Controls.Add(First_nameLabel)
        Me.Controls.Add(Me.First_nameTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.TblPlayersBindingNavigator)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "new_Player"
        Me.Text = "new_Player"
        CType(Me.DbKPLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPlayersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPlayersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblPlayersBindingNavigator.ResumeLayout(False)
        Me.TblPlayersBindingNavigator.PerformLayout()
        CType(Me.TblPositionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbKPLDataSet As dbKPLDataSet
    Friend WithEvents TblPlayersBindingSource As BindingSource
    Friend WithEvents TblPlayersTableAdapter As dbKPLDataSetTableAdapters.tblPlayersTableAdapter
    Friend WithEvents TableAdapterManager As dbKPLDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblPlayersBindingNavigator As BindingNavigator
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
    Friend WithEvents TblPlayersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents First_nameTextBox As TextBox
    Friend WithEvents Last_nameTextBox As TextBox
    Friend WithEvents DoBDateTimePicker As DateTimePicker
    Friend WithEvents CleansheetsTextBox As TextBox
    Friend WithEvents Goals_scoredTextBox As TextBox
    Friend WithEvents Goals_assistedTextBox As TextBox
    Friend WithEvents Yellow_cardsTextBox As TextBox
    Friend WithEvents Red_cardsTextBox As TextBox
    Friend WithEvents BlocksTextBox As TextBox
    Friend WithEvents InterceptionsTextBox As TextBox
    Friend WithEvents ClearencesTextBox As TextBox
    Friend WithEvents btn_Save As Button
    Friend WithEvents PositionComboBox As ComboBox
    Friend WithEvents TblPositionsBindingSource As BindingSource
    Friend WithEvents TblPositionsTableAdapter As dbKPLDataSetTableAdapters.tblPositionsTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
