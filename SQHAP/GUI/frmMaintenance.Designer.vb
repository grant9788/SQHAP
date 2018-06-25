<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintenance
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
        Dim MaintenanceIDLabel As System.Windows.Forms.Label
        Dim ArtworkIDLabel As System.Windows.Forms.Label
        Dim MaintenanceDateLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.btnHome = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SQHAP_DBDataSet = New SQHAP.SQHAP_DBDataSet()
        Me.MaintenanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaintenanceTableAdapter = New SQHAP.SQHAP_DBDataSetTableAdapters.MaintenanceTableAdapter()
        Me.TableAdapterManager = New SQHAP.SQHAP_DBDataSetTableAdapters.TableAdapterManager()
        Me.MaintenanceIDTextBox = New System.Windows.Forms.TextBox()
        Me.ArtworkIDTextBox = New System.Windows.Forms.TextBox()
        Me.MaintenanceDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.MaintenanceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        MaintenanceIDLabel = New System.Windows.Forms.Label()
        ArtworkIDLabel = New System.Windows.Forms.Label()
        MaintenanceDateLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SQHAP_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaintenanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaintenanceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(245, 601)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(0, 13)
        Me.lblCurrent.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(193, 601)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Record:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(309, 602)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(286, 602)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "of"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(455, 597)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 23)
        Me.btnLast.TabIndex = 40
        Me.btnLast.Text = "Last >>"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(351, 597)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 39
        Me.btnNext.Text = "Next >"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(111, 597)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 38
        Me.btnPrevious.Text = "< Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(11, 597)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 23)
        Me.btnFirst.TabIndex = 37
        Me.btnFirst.Text = "<< First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(455, 438)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 48
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(455, 393)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 47
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(455, 364)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 46
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(455, 285)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 45
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(265, 104)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 49
        Me.btnHome.Text = "Main Menu"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(MaintenanceIDLabel)
        Me.GroupBox1.Controls.Add(Me.MaintenanceIDTextBox)
        Me.GroupBox1.Controls.Add(ArtworkIDLabel)
        Me.GroupBox1.Controls.Add(Me.ArtworkIDTextBox)
        Me.GroupBox1.Controls.Add(MaintenanceDateLabel)
        Me.GroupBox1.Controls.Add(Me.MaintenanceDateDateTimePicker)
        Me.GroupBox1.Controls.Add(DescriptionLabel)
        Me.GroupBox1.Controls.Add(Me.DescriptionTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 199)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 198)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Maintenance Information"
        '
        'SQHAP_DBDataSet
        '
        Me.SQHAP_DBDataSet.DataSetName = "SQHAP_DBDataSet"
        Me.SQHAP_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaintenanceBindingSource
        '
        Me.MaintenanceBindingSource.DataMember = "Maintenance"
        Me.MaintenanceBindingSource.DataSource = Me.SQHAP_DBDataSet
        '
        'MaintenanceTableAdapter
        '
        Me.MaintenanceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArtistArtworkTableAdapter = Nothing
        Me.TableAdapterManager.ArtistTableAdapter = Nothing
        Me.TableAdapterManager.ArtworkTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EventTableAdapter = Nothing
        Me.TableAdapterManager.MaintenanceTableAdapter = Me.MaintenanceTableAdapter
        Me.TableAdapterManager.tblArtistArtworkTableAdapter = Nothing
        Me.TableAdapterManager.tblArtistTableAdapter = Nothing
        Me.TableAdapterManager.tblArtworkTableAdapter = Nothing
        Me.TableAdapterManager.tblMaintenanceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SQHAP.SQHAP_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MaintenanceIDLabel
        '
        MaintenanceIDLabel.AutoSize = True
        MaintenanceIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MaintenanceIDLabel.Location = New System.Drawing.Point(15, 49)
        MaintenanceIDLabel.Name = "MaintenanceIDLabel"
        MaintenanceIDLabel.Size = New System.Drawing.Size(104, 16)
        MaintenanceIDLabel.TabIndex = 0
        MaintenanceIDLabel.Text = "Maintenance ID:"
        '
        'MaintenanceIDTextBox
        '
        Me.MaintenanceIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaintenanceBindingSource, "MaintenanceID", True))
        Me.MaintenanceIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaintenanceIDTextBox.Location = New System.Drawing.Point(137, 46)
        Me.MaintenanceIDTextBox.Name = "MaintenanceIDTextBox"
        Me.MaintenanceIDTextBox.Size = New System.Drawing.Size(229, 22)
        Me.MaintenanceIDTextBox.TabIndex = 1
        '
        'ArtworkIDLabel
        '
        ArtworkIDLabel.AutoSize = True
        ArtworkIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ArtworkIDLabel.Location = New System.Drawing.Point(15, 75)
        ArtworkIDLabel.Name = "ArtworkIDLabel"
        ArtworkIDLabel.Size = New System.Drawing.Size(71, 16)
        ArtworkIDLabel.TabIndex = 2
        ArtworkIDLabel.Text = "Artwork ID:"
        '
        'ArtworkIDTextBox
        '
        Me.ArtworkIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaintenanceBindingSource, "ArtworkID", True))
        Me.ArtworkIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArtworkIDTextBox.Location = New System.Drawing.Point(137, 72)
        Me.ArtworkIDTextBox.Name = "ArtworkIDTextBox"
        Me.ArtworkIDTextBox.Size = New System.Drawing.Size(229, 22)
        Me.ArtworkIDTextBox.TabIndex = 3
        '
        'MaintenanceDateLabel
        '
        MaintenanceDateLabel.AutoSize = True
        MaintenanceDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MaintenanceDateLabel.Location = New System.Drawing.Point(15, 102)
        MaintenanceDateLabel.Name = "MaintenanceDateLabel"
        MaintenanceDateLabel.Size = New System.Drawing.Size(120, 16)
        MaintenanceDateLabel.TabIndex = 4
        MaintenanceDateLabel.Text = "Maintenance Date:"
        '
        'MaintenanceDateDateTimePicker
        '
        Me.MaintenanceDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MaintenanceBindingSource, "MaintenanceDate", True))
        Me.MaintenanceDateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaintenanceDateDateTimePicker.Location = New System.Drawing.Point(137, 98)
        Me.MaintenanceDateDateTimePicker.Name = "MaintenanceDateDateTimePicker"
        Me.MaintenanceDateDateTimePicker.Size = New System.Drawing.Size(229, 22)
        Me.MaintenanceDateDateTimePicker.TabIndex = 5
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriptionLabel.Location = New System.Drawing.Point(15, 127)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(79, 16)
        DescriptionLabel.TabIndex = 6
        DescriptionLabel.Text = "Description:"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaintenanceBindingSource, "Description", True))
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(137, 124)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(229, 22)
        Me.DescriptionTextBox.TabIndex = 7
        '
        'MaintenanceDataGridView
        '
        Me.MaintenanceDataGridView.AutoGenerateColumns = False
        Me.MaintenanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MaintenanceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.MaintenanceDataGridView.DataSource = Me.MaintenanceBindingSource
        Me.MaintenanceDataGridView.Location = New System.Drawing.Point(566, 44)
        Me.MaintenanceDataGridView.Name = "MaintenanceDataGridView"
        Me.MaintenanceDataGridView.Size = New System.Drawing.Size(448, 531)
        Me.MaintenanceDataGridView.TabIndex = 50
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MaintenanceID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "MaintenanceID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ArtworkID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ArtworkID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MaintenanceDate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MaintenanceDate"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'frmMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 640)
        Me.Controls.Add(Me.MaintenanceDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnHome)
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
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMaintenance"
        Me.Text = "Stone Quarry Hill Art Park :: Maintenance"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SQHAP_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaintenanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaintenanceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
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
    Friend WithEvents btnHome As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SQHAP_DBDataSet As SQHAP_DBDataSet
    Friend WithEvents MaintenanceBindingSource As BindingSource
    Friend WithEvents MaintenanceTableAdapter As SQHAP_DBDataSetTableAdapters.MaintenanceTableAdapter
    Friend WithEvents TableAdapterManager As SQHAP_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MaintenanceIDTextBox As TextBox
    Friend WithEvents ArtworkIDTextBox As TextBox
    Friend WithEvents MaintenanceDateDateTimePicker As DateTimePicker
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents MaintenanceDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
