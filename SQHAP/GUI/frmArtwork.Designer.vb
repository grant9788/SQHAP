<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArtwork
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
        Dim ArtworkIDLabel As System.Windows.Forms.Label
        Dim ArtistIDLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim MaterialLabel As System.Windows.Forms.Label
        Dim DimesnionsLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim CurrentLabel As System.Windows.Forms.Label
        Dim PermanentLabel As System.Windows.Forms.Label
        Dim DateMadeLabel As System.Windows.Forms.Label
        Dim MaintenanceRequiredLabel As System.Windows.Forms.Label
        Dim MaintenanceScheduleLabel As System.Windows.Forms.Label
        Dim ArtworkImageLabel As System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ArtworkIDTextBox = New System.Windows.Forms.TextBox()
        Me.ArtworkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SQHAP_DBDataSet = New SQHAP.SQHAP_DBDataSet()
        Me.ArtistIDTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.MaterialTextBox = New System.Windows.Forms.TextBox()
        Me.DimesnionsTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.CurrentCheckBox = New System.Windows.Forms.CheckBox()
        Me.PermanentCheckBox = New System.Windows.Forms.CheckBox()
        Me.DateMadeTextBox = New System.Windows.Forms.TextBox()
        Me.MaintenanceRequiredTextBox = New System.Windows.Forms.TextBox()
        Me.MaintenanceScheduleDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ArtworkImageTextBox = New System.Windows.Forms.TextBox()
        Me.ArtworkTableAdapter = New SQHAP.SQHAP_DBDataSetTableAdapters.ArtworkTableAdapter()
        Me.TableAdapterManager = New SQHAP.SQHAP_DBDataSetTableAdapters.TableAdapterManager()
        Me.ArtworkDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        ArtworkIDLabel = New System.Windows.Forms.Label()
        ArtistIDLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        MaterialLabel = New System.Windows.Forms.Label()
        DimesnionsLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        CurrentLabel = New System.Windows.Forms.Label()
        PermanentLabel = New System.Windows.Forms.Label()
        DateMadeLabel = New System.Windows.Forms.Label()
        MaintenanceRequiredLabel = New System.Windows.Forms.Label()
        MaintenanceScheduleLabel = New System.Windows.Forms.Label()
        ArtworkImageLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ArtworkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQHAP_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtworkDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ArtworkIDLabel
        '
        ArtworkIDLabel.AutoSize = True
        ArtworkIDLabel.Location = New System.Drawing.Point(15, 27)
        ArtworkIDLabel.Name = "ArtworkIDLabel"
        ArtworkIDLabel.Size = New System.Drawing.Size(60, 13)
        ArtworkIDLabel.TabIndex = 0
        ArtworkIDLabel.Text = "Artwork ID:"
        '
        'ArtistIDLabel
        '
        ArtistIDLabel.AutoSize = True
        ArtistIDLabel.Location = New System.Drawing.Point(15, 53)
        ArtistIDLabel.Name = "ArtistIDLabel"
        ArtistIDLabel.Size = New System.Drawing.Size(47, 13)
        ArtistIDLabel.TabIndex = 2
        ArtistIDLabel.Text = "Artist ID:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(15, 79)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(30, 13)
        TitleLabel.TabIndex = 4
        TitleLabel.Text = "Title:"
        '
        'MaterialLabel
        '
        MaterialLabel.AutoSize = True
        MaterialLabel.Location = New System.Drawing.Point(15, 109)
        MaterialLabel.Name = "MaterialLabel"
        MaterialLabel.Size = New System.Drawing.Size(47, 13)
        MaterialLabel.TabIndex = 6
        MaterialLabel.Text = "Material:"
        '
        'DimesnionsLabel
        '
        DimesnionsLabel.AutoSize = True
        DimesnionsLabel.Location = New System.Drawing.Point(15, 135)
        DimesnionsLabel.Name = "DimesnionsLabel"
        DimesnionsLabel.Size = New System.Drawing.Size(64, 13)
        DimesnionsLabel.TabIndex = 8
        DimesnionsLabel.Text = "Dimesnions:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(15, 191)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 10
        DescriptionLabel.Text = "Description:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Location = New System.Drawing.Point(15, 161)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(51, 13)
        LocationLabel.TabIndex = 12
        LocationLabel.Text = "Location:"
        '
        'CurrentLabel
        '
        CurrentLabel.AutoSize = True
        CurrentLabel.Location = New System.Drawing.Point(194, 25)
        CurrentLabel.Name = "CurrentLabel"
        CurrentLabel.Size = New System.Drawing.Size(44, 13)
        CurrentLabel.TabIndex = 14
        CurrentLabel.Text = "Current:"
        '
        'PermanentLabel
        '
        PermanentLabel.AutoSize = True
        PermanentLabel.Location = New System.Drawing.Point(194, 55)
        PermanentLabel.Name = "PermanentLabel"
        PermanentLabel.Size = New System.Drawing.Size(61, 13)
        PermanentLabel.TabIndex = 16
        PermanentLabel.Text = "Permanent:"
        '
        'DateMadeLabel
        '
        DateMadeLabel.AutoSize = True
        DateMadeLabel.Location = New System.Drawing.Point(194, 83)
        DateMadeLabel.Name = "DateMadeLabel"
        DateMadeLabel.Size = New System.Drawing.Size(63, 13)
        DateMadeLabel.TabIndex = 18
        DateMadeLabel.Text = "Date Made:"
        '
        'MaintenanceRequiredLabel
        '
        MaintenanceRequiredLabel.AutoSize = True
        MaintenanceRequiredLabel.Location = New System.Drawing.Point(6, 33)
        MaintenanceRequiredLabel.Name = "MaintenanceRequiredLabel"
        MaintenanceRequiredLabel.Size = New System.Drawing.Size(34, 13)
        MaintenanceRequiredLabel.TabIndex = 20
        MaintenanceRequiredLabel.Text = "Task:"
        '
        'MaintenanceScheduleLabel
        '
        MaintenanceScheduleLabel.AutoSize = True
        MaintenanceScheduleLabel.Location = New System.Drawing.Point(3, 107)
        MaintenanceScheduleLabel.Name = "MaintenanceScheduleLabel"
        MaintenanceScheduleLabel.Size = New System.Drawing.Size(55, 13)
        MaintenanceScheduleLabel.TabIndex = 22
        MaintenanceScheduleLabel.Text = "Schedule:"
        '
        'ArtworkImageLabel
        '
        ArtworkImageLabel.AutoSize = True
        ArtworkImageLabel.Location = New System.Drawing.Point(194, 113)
        ArtworkImageLabel.Name = "ArtworkImageLabel"
        ArtworkImageLabel.Size = New System.Drawing.Size(78, 13)
        ArtworkImageLabel.TabIndex = 24
        ArtworkImageLabel.Text = "Artwork Image:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SQHAP.My.Resources.Resources._2015_VerticalLogoRaw_feb2_01_1024x681_2_0_
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(205, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(261, 43)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 3
        Me.btnHome.Text = "Main Menu"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(246, 502)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(0, 13)
        Me.lblCurrent.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 502)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Record:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(310, 503)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(287, 503)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "of"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(456, 498)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 23)
        Me.btnLast.TabIndex = 32
        Me.btnLast.Text = "Last >>"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(352, 498)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 31
        Me.btnNext.Text = "Next >"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(112, 498)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 30
        Me.btnPrevious.Text = "< Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(12, 498)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 23)
        Me.btnFirst.TabIndex = 29
        Me.btnFirst.Text = "<< First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(456, 348)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 40
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(456, 303)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 39
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(456, 274)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 38
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(456, 195)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 37
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(ArtworkIDLabel)
        Me.GroupBox1.Controls.Add(Me.ArtworkIDTextBox)
        Me.GroupBox1.Controls.Add(ArtistIDLabel)
        Me.GroupBox1.Controls.Add(Me.ArtistIDTextBox)
        Me.GroupBox1.Controls.Add(TitleLabel)
        Me.GroupBox1.Controls.Add(Me.TitleTextBox)
        Me.GroupBox1.Controls.Add(MaterialLabel)
        Me.GroupBox1.Controls.Add(Me.MaterialTextBox)
        Me.GroupBox1.Controls.Add(DimesnionsLabel)
        Me.GroupBox1.Controls.Add(Me.DimesnionsTextBox)
        Me.GroupBox1.Controls.Add(DescriptionLabel)
        Me.GroupBox1.Controls.Add(Me.DescriptionTextBox)
        Me.GroupBox1.Controls.Add(LocationLabel)
        Me.GroupBox1.Controls.Add(Me.LocationTextBox)
        Me.GroupBox1.Controls.Add(CurrentLabel)
        Me.GroupBox1.Controls.Add(Me.CurrentCheckBox)
        Me.GroupBox1.Controls.Add(PermanentLabel)
        Me.GroupBox1.Controls.Add(Me.PermanentCheckBox)
        Me.GroupBox1.Controls.Add(DateMadeLabel)
        Me.GroupBox1.Controls.Add(Me.DateMadeTextBox)
        Me.GroupBox1.Controls.Add(ArtworkImageLabel)
        Me.GroupBox1.Controls.Add(Me.ArtworkImageTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 275)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Artwork Information"
        '
        'ArtworkIDTextBox
        '
        Me.ArtworkIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtworkBindingSource, "ArtworkID", True))
        Me.ArtworkIDTextBox.Location = New System.Drawing.Point(80, 24)
        Me.ArtworkIDTextBox.Name = "ArtworkIDTextBox"
        Me.ArtworkIDTextBox.Size = New System.Drawing.Size(108, 20)
        Me.ArtworkIDTextBox.TabIndex = 1
        '
        'ArtworkBindingSource
        '
        Me.ArtworkBindingSource.DataMember = "Artwork"
        Me.ArtworkBindingSource.DataSource = Me.SQHAP_DBDataSet
        '
        'SQHAP_DBDataSet
        '
        Me.SQHAP_DBDataSet.DataSetName = "SQHAP_DBDataSet"
        Me.SQHAP_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArtistIDTextBox
        '
        Me.ArtistIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtworkBindingSource, "ArtistID", True))
        Me.ArtistIDTextBox.Location = New System.Drawing.Point(80, 50)
        Me.ArtistIDTextBox.Name = "ArtistIDTextBox"
        Me.ArtistIDTextBox.Size = New System.Drawing.Size(108, 20)
        Me.ArtistIDTextBox.TabIndex = 3
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtworkBindingSource, "Title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(80, 76)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(108, 20)
        Me.TitleTextBox.TabIndex = 5
        '
        'MaterialTextBox
        '
        Me.MaterialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtworkBindingSource, "Material", True))
        Me.MaterialTextBox.Location = New System.Drawing.Point(80, 106)
        Me.MaterialTextBox.Name = "MaterialTextBox"
        Me.MaterialTextBox.Size = New System.Drawing.Size(108, 20)
        Me.MaterialTextBox.TabIndex = 7
        '
        'DimesnionsTextBox
        '
        Me.DimesnionsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtworkBindingSource, "Dimesnions", True))
        Me.DimesnionsTextBox.Location = New System.Drawing.Point(80, 132)
        Me.DimesnionsTextBox.Name = "DimesnionsTextBox"
        Me.DimesnionsTextBox.Size = New System.Drawing.Size(108, 20)
        Me.DimesnionsTextBox.TabIndex = 9
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtworkBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(80, 188)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(108, 70)
        Me.DescriptionTextBox.TabIndex = 11
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtworkBindingSource, "Location", True))
        Me.LocationTextBox.Location = New System.Drawing.Point(80, 158)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(108, 20)
        Me.LocationTextBox.TabIndex = 13
        '
        'CurrentCheckBox
        '
        Me.CurrentCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ArtworkBindingSource, "Current", True))
        Me.CurrentCheckBox.Location = New System.Drawing.Point(278, 20)
        Me.CurrentCheckBox.Name = "CurrentCheckBox"
        Me.CurrentCheckBox.Size = New System.Drawing.Size(83, 24)
        Me.CurrentCheckBox.TabIndex = 15
        Me.CurrentCheckBox.Text = "Yes"
        Me.CurrentCheckBox.UseVisualStyleBackColor = True
        '
        'PermanentCheckBox
        '
        Me.PermanentCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ArtworkBindingSource, "Permanent", True))
        Me.PermanentCheckBox.Location = New System.Drawing.Point(278, 50)
        Me.PermanentCheckBox.Name = "PermanentCheckBox"
        Me.PermanentCheckBox.Size = New System.Drawing.Size(83, 24)
        Me.PermanentCheckBox.TabIndex = 17
        Me.PermanentCheckBox.Text = "Yes"
        Me.PermanentCheckBox.UseVisualStyleBackColor = True
        '
        'DateMadeTextBox
        '
        Me.DateMadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtworkBindingSource, "DateMade", True))
        Me.DateMadeTextBox.Location = New System.Drawing.Point(278, 79)
        Me.DateMadeTextBox.Name = "DateMadeTextBox"
        Me.DateMadeTextBox.Size = New System.Drawing.Size(148, 20)
        Me.DateMadeTextBox.TabIndex = 19
        '
        'MaintenanceRequiredTextBox
        '
        Me.MaintenanceRequiredTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtworkBindingSource, "MaintenanceRequired", True))
        Me.MaintenanceRequiredTextBox.Location = New System.Drawing.Point(46, 19)
        Me.MaintenanceRequiredTextBox.Multiline = True
        Me.MaintenanceRequiredTextBox.Name = "MaintenanceRequiredTextBox"
        Me.MaintenanceRequiredTextBox.Size = New System.Drawing.Size(183, 78)
        Me.MaintenanceRequiredTextBox.TabIndex = 21
        '
        'MaintenanceScheduleDateTimePicker
        '
        Me.MaintenanceScheduleDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ArtworkBindingSource, "MaintenanceSchedule", True))
        Me.MaintenanceScheduleDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaintenanceScheduleDateTimePicker.Location = New System.Drawing.Point(58, 103)
        Me.MaintenanceScheduleDateTimePicker.Name = "MaintenanceScheduleDateTimePicker"
        Me.MaintenanceScheduleDateTimePicker.Size = New System.Drawing.Size(171, 18)
        Me.MaintenanceScheduleDateTimePicker.TabIndex = 23
        '
        'ArtworkImageTextBox
        '
        Me.ArtworkImageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtworkBindingSource, "ArtworkImage", True))
        Me.ArtworkImageTextBox.Location = New System.Drawing.Point(278, 105)
        Me.ArtworkImageTextBox.Name = "ArtworkImageTextBox"
        Me.ArtworkImageTextBox.Size = New System.Drawing.Size(83, 20)
        Me.ArtworkImageTextBox.TabIndex = 25
        '
        'ArtworkTableAdapter
        '
        Me.ArtworkTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArtistArtworkTableAdapter = Nothing
        Me.TableAdapterManager.ArtistTableAdapter = Nothing
        Me.TableAdapterManager.ArtworkTableAdapter = Me.ArtworkTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EventTableAdapter = Nothing
        Me.TableAdapterManager.MaintenanceTableAdapter = Nothing
        Me.TableAdapterManager.tblArtistArtworkTableAdapter = Nothing
        Me.TableAdapterManager.tblArtistTableAdapter = Nothing
        Me.TableAdapterManager.tblArtworkTableAdapter = Nothing
        Me.TableAdapterManager.tblMaintenanceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SQHAP.SQHAP_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ArtworkDataGridView
        '
        Me.ArtworkDataGridView.AutoGenerateColumns = False
        Me.ArtworkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArtworkDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.ArtworkDataGridView.DataSource = Me.ArtworkBindingSource
        Me.ArtworkDataGridView.Location = New System.Drawing.Point(550, 43)
        Me.ArtworkDataGridView.Name = "ArtworkDataGridView"
        Me.ArtworkDataGridView.Size = New System.Drawing.Size(887, 410)
        Me.ArtworkDataGridView.TabIndex = 42
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ArtworkID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ArtworkID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ArtistID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ArtistID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Material"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Material"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Dimesnions"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Dimesnions"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Location"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Current"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Current"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Permanent"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Permanent"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DateMade"
        Me.DataGridViewTextBoxColumn8.HeaderText = "DateMade"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "MaintenanceRequired"
        Me.DataGridViewTextBoxColumn9.HeaderText = "MaintenanceRequired"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "MaintenanceSchedule"
        Me.DataGridViewTextBoxColumn10.HeaderText = "MaintenanceSchedule"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ArtworkImage"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ArtworkImage"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(MaintenanceRequiredLabel)
        Me.GroupBox2.Controls.Add(Me.MaintenanceRequiredTextBox)
        Me.GroupBox2.Controls.Add(MaintenanceScheduleLabel)
        Me.GroupBox2.Controls.Add(Me.MaintenanceScheduleDateTimePicker)
        Me.GroupBox2.Location = New System.Drawing.Point(197, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(235, 127)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Maintenance Information"
        '
        'frmArtwork
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1362, 632)
        Me.Controls.Add(Me.ArtworkDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmArtwork"
        Me.Text = "Stone Quarry Hill Art Park :: Artwork"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ArtworkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQHAP_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtworkDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnHome As Button
    Friend WithEvents lblCurrent As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLast As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SQHAP_DBDataSet As SQHAP_DBDataSet
    Friend WithEvents ArtworkBindingSource As BindingSource
    Friend WithEvents ArtworkTableAdapter As SQHAP_DBDataSetTableAdapters.ArtworkTableAdapter
    Friend WithEvents TableAdapterManager As SQHAP_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ArtworkIDTextBox As TextBox
    Friend WithEvents ArtistIDTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents MaterialTextBox As TextBox
    Friend WithEvents DimesnionsTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents CurrentCheckBox As CheckBox
    Friend WithEvents PermanentCheckBox As CheckBox
    Friend WithEvents DateMadeTextBox As TextBox
    Friend WithEvents MaintenanceRequiredTextBox As TextBox
    Friend WithEvents MaintenanceScheduleDateTimePicker As DateTimePicker
    Friend WithEvents ArtworkImageTextBox As TextBox
    Friend WithEvents ArtworkDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
End Class
