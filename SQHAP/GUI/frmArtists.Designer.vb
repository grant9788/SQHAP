<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArtists
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
        Dim ArtistIDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim WebPageLabel As System.Windows.Forms.Label
        Dim AIRLabel As System.Windows.Forms.Label
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ArtistIDTextBox = New System.Windows.Forms.TextBox()
        Me.ArtistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SQHAP_DBDataSet = New SQHAP.SQHAP_DBDataSet()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.WebPageTextBox = New System.Windows.Forms.TextBox()
        Me.AIRCheckBox = New System.Windows.Forms.CheckBox()
        Me.ArtistTableAdapter = New SQHAP.SQHAP_DBDataSetTableAdapters.ArtistTableAdapter()
        Me.TableAdapterManager = New SQHAP.SQHAP_DBDataSetTableAdapters.TableAdapterManager()
        Me.ArtistDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        ArtistIDLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        WebPageLabel = New System.Windows.Forms.Label()
        AIRLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ArtistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQHAP_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtistDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ArtistIDLabel
        '
        ArtistIDLabel.AutoSize = True
        ArtistIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ArtistIDLabel.Location = New System.Drawing.Point(32, 40)
        ArtistIDLabel.Name = "ArtistIDLabel"
        ArtistIDLabel.Size = New System.Drawing.Size(56, 16)
        ArtistIDLabel.TabIndex = 0
        ArtistIDLabel.Text = "Artist ID:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.Location = New System.Drawing.Point(32, 66)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(76, 16)
        FirstNameLabel.TabIndex = 2
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel.Location = New System.Drawing.Point(32, 92)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(76, 16)
        LastNameLabel.TabIndex = 4
        LastNameLabel.Text = "Last Name:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneNumberLabel.Location = New System.Drawing.Point(32, 118)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(101, 16)
        PhoneNumberLabel.TabIndex = 6
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(32, 144)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(45, 16)
        EmailLabel.TabIndex = 8
        EmailLabel.Text = "Email:"
        '
        'WebPageLabel
        '
        WebPageLabel.AutoSize = True
        WebPageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WebPageLabel.Location = New System.Drawing.Point(32, 170)
        WebPageLabel.Name = "WebPageLabel"
        WebPageLabel.Size = New System.Drawing.Size(76, 16)
        WebPageLabel.TabIndex = 10
        WebPageLabel.Text = "Web Page:"
        '
        'AIRLabel
        '
        AIRLabel.AutoSize = True
        AIRLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AIRLabel.Location = New System.Drawing.Point(32, 198)
        AIRLabel.Name = "AIRLabel"
        AIRLabel.Size = New System.Drawing.Size(33, 16)
        AIRLabel.TabIndex = 12
        AIRLabel.Text = "AIR:"
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(261, 43)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 2
        Me.btnHome.Text = "Main Menu"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(457, 348)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(457, 303)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 19
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(457, 274)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(457, 195)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(246, 502)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(0, 13)
        Me.lblCurrent.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 502)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Record:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(310, 503)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(287, 503)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "of"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(456, 498)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 23)
        Me.btnLast.TabIndex = 24
        Me.btnLast.Text = "Last >>"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(352, 498)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 23
        Me.btnNext.Text = "Next >"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(112, 498)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 22
        Me.btnPrevious.Text = "< Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(12, 498)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 23)
        Me.btnFirst.TabIndex = 21
        Me.btnFirst.Text = "<< First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(ArtistIDLabel)
        Me.GroupBox1.Controls.Add(Me.ArtistIDTextBox)
        Me.GroupBox1.Controls.Add(FirstNameLabel)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.Controls.Add(LastNameLabel)
        Me.GroupBox1.Controls.Add(Me.LastNameTextBox)
        Me.GroupBox1.Controls.Add(PhoneNumberLabel)
        Me.GroupBox1.Controls.Add(Me.PhoneNumberTextBox)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(WebPageLabel)
        Me.GroupBox1.Controls.Add(Me.WebPageTextBox)
        Me.GroupBox1.Controls.Add(AIRLabel)
        Me.GroupBox1.Controls.Add(Me.AIRCheckBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 253)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Artist Information"
        '
        'ArtistIDTextBox
        '
        Me.ArtistIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtistBindingSource, "ArtistID", True))
        Me.ArtistIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArtistIDTextBox.Location = New System.Drawing.Point(141, 37)
        Me.ArtistIDTextBox.Name = "ArtistIDTextBox"
        Me.ArtistIDTextBox.Size = New System.Drawing.Size(248, 22)
        Me.ArtistIDTextBox.TabIndex = 1
        '
        'ArtistBindingSource
        '
        Me.ArtistBindingSource.DataMember = "Artist"
        Me.ArtistBindingSource.DataSource = Me.SQHAP_DBDataSet
        '
        'SQHAP_DBDataSet
        '
        Me.SQHAP_DBDataSet.DataSetName = "SQHAP_DBDataSet"
        Me.SQHAP_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtistBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(141, 63)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(248, 22)
        Me.FirstNameTextBox.TabIndex = 3
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtistBindingSource, "LastName", True))
        Me.LastNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox.Location = New System.Drawing.Point(141, 89)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(248, 22)
        Me.LastNameTextBox.TabIndex = 5
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtistBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(141, 115)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(248, 22)
        Me.PhoneNumberTextBox.TabIndex = 7
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtistBindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(141, 141)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(248, 22)
        Me.EmailTextBox.TabIndex = 9
        '
        'WebPageTextBox
        '
        Me.WebPageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtistBindingSource, "WebPage", True))
        Me.WebPageTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WebPageTextBox.Location = New System.Drawing.Point(141, 167)
        Me.WebPageTextBox.Name = "WebPageTextBox"
        Me.WebPageTextBox.Size = New System.Drawing.Size(248, 22)
        Me.WebPageTextBox.TabIndex = 11
        '
        'AIRCheckBox
        '
        Me.AIRCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ArtistBindingSource, "AIR", True))
        Me.AIRCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AIRCheckBox.Location = New System.Drawing.Point(141, 193)
        Me.AIRCheckBox.Name = "AIRCheckBox"
        Me.AIRCheckBox.Size = New System.Drawing.Size(93, 24)
        Me.AIRCheckBox.TabIndex = 13
        Me.AIRCheckBox.Text = "Yes"
        Me.AIRCheckBox.UseVisualStyleBackColor = True
        '
        'ArtistTableAdapter
        '
        Me.ArtistTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArtistArtworkTableAdapter = Nothing
        Me.TableAdapterManager.ArtistTableAdapter = Me.ArtistTableAdapter
        Me.TableAdapterManager.ArtworkTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EventTableAdapter = Nothing
        Me.TableAdapterManager.MaintenanceTableAdapter = Nothing
        Me.TableAdapterManager.tblArtistArtworkTableAdapter = Nothing
        Me.TableAdapterManager.tblArtistTableAdapter = Nothing
        Me.TableAdapterManager.tblArtworkTableAdapter = Nothing
        Me.TableAdapterManager.tblMaintenanceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SQHAP.SQHAP_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ArtistDataGridView
        '
        Me.ArtistDataGridView.AllowUserToAddRows = False
        Me.ArtistDataGridView.AllowUserToDeleteRows = False
        Me.ArtistDataGridView.AllowUserToOrderColumns = True
        Me.ArtistDataGridView.AutoGenerateColumns = False
        Me.ArtistDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ArtistDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArtistDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn1})
        Me.ArtistDataGridView.DataSource = Me.ArtistBindingSource
        Me.ArtistDataGridView.Location = New System.Drawing.Point(561, 43)
        Me.ArtistDataGridView.Name = "ArtistDataGridView"
        Me.ArtistDataGridView.ReadOnly = True
        Me.ArtistDataGridView.Size = New System.Drawing.Size(714, 434)
        Me.ArtistDataGridView.TabIndex = 29
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ArtistID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ArtistID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 66
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 79
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PhoneNumber"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PhoneNumber"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 57
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "WebPage"
        Me.DataGridViewTextBoxColumn6.HeaderText = "WebPage"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "AIR"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "AIR"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 31
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
        'frmArtists
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 533)
        Me.Controls.Add(Me.ArtistDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmArtists"
        Me.Text = "Stone Quarry Hill Art Park :: Artists"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ArtistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQHAP_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtistDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnHome As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblCurrent As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLast As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SQHAP_DBDataSet As SQHAP_DBDataSet
    Friend WithEvents ArtistBindingSource As BindingSource
    Friend WithEvents ArtistTableAdapter As SQHAP_DBDataSetTableAdapters.ArtistTableAdapter
    Friend WithEvents TableAdapterManager As SQHAP_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ArtistIDTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents WebPageTextBox As TextBox
    Friend WithEvents AIRCheckBox As CheckBox
    Friend WithEvents ArtistDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
End Class
