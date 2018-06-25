<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SQHAPhome
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnArtists = New System.Windows.Forms.Button()
        Me.btnArtwork = New System.Windows.Forms.Button()
        Me.btnMaintenance = New System.Windows.Forms.Button()
        Me.btnEvents = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnArtists
        '
        Me.btnArtists.Location = New System.Drawing.Point(147, 304)
        Me.btnArtists.Name = "btnArtists"
        Me.btnArtists.Size = New System.Drawing.Size(151, 66)
        Me.btnArtists.TabIndex = 1
        Me.btnArtists.Text = "Artists"
        Me.btnArtists.UseVisualStyleBackColor = True
        '
        'btnArtwork
        '
        Me.btnArtwork.Location = New System.Drawing.Point(340, 304)
        Me.btnArtwork.Name = "btnArtwork"
        Me.btnArtwork.Size = New System.Drawing.Size(151, 66)
        Me.btnArtwork.TabIndex = 2
        Me.btnArtwork.Text = "Artwork"
        Me.btnArtwork.UseVisualStyleBackColor = True
        '
        'btnMaintenance
        '
        Me.btnMaintenance.Location = New System.Drawing.Point(534, 304)
        Me.btnMaintenance.Name = "btnMaintenance"
        Me.btnMaintenance.Size = New System.Drawing.Size(151, 66)
        Me.btnMaintenance.TabIndex = 3
        Me.btnMaintenance.Text = "Maintenance"
        Me.btnMaintenance.UseVisualStyleBackColor = True
        '
        'btnEvents
        '
        Me.btnEvents.Location = New System.Drawing.Point(724, 304)
        Me.btnEvents.Name = "btnEvents"
        Me.btnEvents.Size = New System.Drawing.Size(151, 66)
        Me.btnEvents.TabIndex = 4
        Me.btnEvents.Text = "Events"
        Me.btnEvents.UseVisualStyleBackColor = True
        '
        'SQHAPhome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 511)
        Me.Controls.Add(Me.btnEvents)
        Me.Controls.Add(Me.btnMaintenance)
        Me.Controls.Add(Me.btnArtwork)
        Me.Controls.Add(Me.btnArtists)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "SQHAPhome"
        Me.Text = "Stone Quarry Hill ArtPark :: Home"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnArtists As Button
    Friend WithEvents btnArtwork As Button
    Friend WithEvents btnMaintenance As Button
    Friend WithEvents btnEvents As Button
End Class
