<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEvents
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
        Dim EventIDLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim EntryCostLabel As System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EventIDTextBox = New System.Windows.Forms.TextBox()
        Me.EventBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SQHAP_DBDataSet = New SQHAP.SQHAP_DBDataSet()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EntryCostTextBox = New System.Windows.Forms.TextBox()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.EventTableAdapter = New SQHAP.SQHAP_DBDataSetTableAdapters.EventTableAdapter()
        Me.TableAdapterManager = New SQHAP.SQHAP_DBDataSetTableAdapters.TableAdapterManager()
        Me.EventDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        EventIDLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        EntryCostLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EventBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQHAP_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EventIDLabel
        '
        EventIDLabel.AutoSize = True
        EventIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EventIDLabel.Location = New System.Drawing.Point(12, 49)
        EventIDLabel.Name = "EventIDLabel"
        EventIDLabel.Size = New System.Drawing.Size(61, 16)
        EventIDLabel.TabIndex = 0
        EventIDLabel.Text = "Event ID:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitleLabel.Location = New System.Drawing.Point(12, 75)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(37, 16)
        TitleLabel.TabIndex = 2
        TitleLabel.Text = "Title:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateLabel.Location = New System.Drawing.Point(12, 102)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(40, 16)
        DateLabel.TabIndex = 4
        DateLabel.Text = "Date:"
        '
        'EntryCostLabel
        '
        EntryCostLabel.AutoSize = True
        EntryCostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EntryCostLabel.Location = New System.Drawing.Point(12, 127)
        EntryCostLabel.Name = "EntryCostLabel"
        EntryCostLabel.Size = New System.Drawing.Size(71, 16)
        EntryCostLabel.TabIndex = 6
        EntryCostLabel.Text = "Entry Cost:"
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
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Main Menu"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(EventIDLabel)
        Me.GroupBox1.Controls.Add(Me.EventIDTextBox)
        Me.GroupBox1.Controls.Add(TitleLabel)
        Me.GroupBox1.Controls.Add(Me.TitleTextBox)
        Me.GroupBox1.Controls.Add(DateLabel)
        Me.GroupBox1.Controls.Add(Me.DateDateTimePicker)
        Me.GroupBox1.Controls.Add(EntryCostLabel)
        Me.GroupBox1.Controls.Add(Me.EntryCostTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 195)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 194)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Event Information"
        '
        'EventIDTextBox
        '
        Me.EventIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EventBindingSource, "EventID", True))
        Me.EventIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EventIDTextBox.Location = New System.Drawing.Point(112, 46)
        Me.EventIDTextBox.Name = "EventIDTextBox"
        Me.EventIDTextBox.Size = New System.Drawing.Size(235, 22)
        Me.EventIDTextBox.TabIndex = 1
        '
        'EventBindingSource
        '
        Me.EventBindingSource.DataMember = "Event"
        Me.EventBindingSource.DataSource = Me.SQHAP_DBDataSet
        '
        'SQHAP_DBDataSet
        '
        Me.SQHAP_DBDataSet.DataSetName = "SQHAP_DBDataSet"
        Me.SQHAP_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EventBindingSource, "Title", True))
        Me.TitleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.Location = New System.Drawing.Point(112, 72)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(235, 22)
        Me.TitleTextBox.TabIndex = 3
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EventBindingSource, "Date", True))
        Me.DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(112, 98)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(235, 22)
        Me.DateDateTimePicker.TabIndex = 5
        '
        'EntryCostTextBox
        '
        Me.EntryCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EventBindingSource, "EntryCost", True))
        Me.EntryCostTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntryCostTextBox.Location = New System.Drawing.Point(112, 124)
        Me.EntryCostTextBox.Name = "EntryCostTextBox"
        Me.EntryCostTextBox.Size = New System.Drawing.Size(235, 22)
        Me.EntryCostTextBox.TabIndex = 7
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(12, 498)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 23)
        Me.btnFirst.TabIndex = 3
        Me.btnFirst.Text = "<< First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(112, 498)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 4
        Me.btnPrevious.Text = "< Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(352, 498)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "Next >"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(456, 498)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 23)
        Me.btnLast.TabIndex = 6
        Me.btnLast.Text = "Last >>"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(287, 503)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "of"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(310, 503)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 502)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Record:"
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(246, 502)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(0, 13)
        Me.lblCurrent.TabIndex = 12
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(457, 195)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(457, 274)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(457, 303)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(457, 348)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'EventTableAdapter
        '
        Me.EventTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArtistArtworkTableAdapter = Nothing
        Me.TableAdapterManager.ArtistTableAdapter = Nothing
        Me.TableAdapterManager.ArtworkTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EventTableAdapter = Me.EventTableAdapter
        Me.TableAdapterManager.MaintenanceTableAdapter = Nothing
        Me.TableAdapterManager.tblArtistArtworkTableAdapter = Nothing
        Me.TableAdapterManager.tblArtistTableAdapter = Nothing
        Me.TableAdapterManager.tblArtworkTableAdapter = Nothing
        Me.TableAdapterManager.tblMaintenanceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SQHAP.SQHAP_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EventDataGridView
        '
        Me.EventDataGridView.AllowUserToAddRows = False
        Me.EventDataGridView.AllowUserToDeleteRows = False
        Me.EventDataGridView.AllowUserToOrderColumns = True
        Me.EventDataGridView.AutoGenerateColumns = False
        Me.EventDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.EventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EventDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.EventDataGridView.DataSource = Me.EventBindingSource
        Me.EventDataGridView.Location = New System.Drawing.Point(547, 93)
        Me.EventDataGridView.Name = "EventDataGridView"
        Me.EventDataGridView.ReadOnly = True
        Me.EventDataGridView.Size = New System.Drawing.Size(446, 406)
        Me.EventDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "EventID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "EventID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "EntryCost"
        Me.DataGridViewTextBoxColumn4.HeaderText = "EntryCost"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'frmEvents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 533)
        Me.Controls.Add(Me.EventDataGridView)
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
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmEvents"
        Me.Text = "Stone Quarry Hill Art Park :: Events"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EventBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQHAP_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnHome As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCurrent As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents SQHAP_DBDataSet As SQHAP_DBDataSet
    Friend WithEvents EventBindingSource As BindingSource
    Friend WithEvents EventTableAdapter As SQHAP_DBDataSetTableAdapters.EventTableAdapter
    Friend WithEvents TableAdapterManager As SQHAP_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EventIDTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents EntryCostTextBox As TextBox
    Friend WithEvents EventDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
