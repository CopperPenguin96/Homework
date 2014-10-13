<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.picHomework_Logo = New System.Windows.Forms.PictureBox()
        Me.gboAssignments = New System.Windows.Forms.GroupBox()
        Me.lboAssignments = New System.Windows.Forms.ListBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExisting = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.gboClasses = New System.Windows.Forms.GroupBox()
        Me.lboClasses = New System.Windows.Forms.ListBox()
        Me.gboPlugins = New System.Windows.Forms.GroupBox()
        Me.btnInstall = New System.Windows.Forms.Button()
        Me.btnViewInstalled = New System.Windows.Forms.Button()
        CType(Me.picHomework_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboAssignments.SuspendLayout()
        Me.gboClasses.SuspendLayout()
        Me.gboPlugins.SuspendLayout()
        Me.SuspendLayout()
        '
        'picHomework_Logo
        '
        Me.picHomework_Logo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picHomework_Logo.BackColor = System.Drawing.Color.Transparent
        Me.picHomework_Logo.Image = CType(resources.GetObject("picHomework_Logo.Image"), System.Drawing.Image)
        Me.picHomework_Logo.Location = New System.Drawing.Point(13, 13)
        Me.picHomework_Logo.Name = "picHomework_Logo"
        Me.picHomework_Logo.Size = New System.Drawing.Size(473, 157)
        Me.picHomework_Logo.TabIndex = 0
        Me.picHomework_Logo.TabStop = False
        '
        'gboAssignments
        '
        Me.gboAssignments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gboAssignments.BackColor = System.Drawing.Color.Transparent
        Me.gboAssignments.Controls.Add(Me.lboAssignments)
        Me.gboAssignments.Controls.Add(Me.btnDelete)
        Me.gboAssignments.Controls.Add(Me.btnExisting)
        Me.gboAssignments.Controls.Add(Me.btnNew)
        Me.gboAssignments.Font = New System.Drawing.Font("Capture it", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboAssignments.Location = New System.Drawing.Point(13, 176)
        Me.gboAssignments.Name = "gboAssignments"
        Me.gboAssignments.Size = New System.Drawing.Size(473, 321)
        Me.gboAssignments.TabIndex = 2
        Me.gboAssignments.TabStop = False
        Me.gboAssignments.Text = "Assignments"
        '
        'lboAssignments
        '
        Me.lboAssignments.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lboAssignments.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboAssignments.FormattingEnabled = True
        Me.lboAssignments.Location = New System.Drawing.Point(7, 114)
        Me.lboAssignments.Name = "lboAssignments"
        Me.lboAssignments.Size = New System.Drawing.Size(460, 199)
        Me.lboAssignments.TabIndex = 3
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Teal
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(380, 62)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 45)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnExisting
        '
        Me.btnExisting.BackColor = System.Drawing.Color.Teal
        Me.btnExisting.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExisting.Location = New System.Drawing.Point(180, 62)
        Me.btnExisting.Name = "btnExisting"
        Me.btnExisting.Size = New System.Drawing.Size(113, 45)
        Me.btnExisting.TabIndex = 1
        Me.btnExisting.Text = "Add Existing"
        Me.btnExisting.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Teal
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(6, 62)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(87, 45)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "Add New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'gboClasses
        '
        Me.gboClasses.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gboClasses.BackColor = System.Drawing.Color.Transparent
        Me.gboClasses.Controls.Add(Me.lboClasses)
        Me.gboClasses.Font = New System.Drawing.Font("Capture it", 36.0!)
        Me.gboClasses.Location = New System.Drawing.Point(493, 13)
        Me.gboClasses.Name = "gboClasses"
        Me.gboClasses.Size = New System.Drawing.Size(248, 290)
        Me.gboClasses.TabIndex = 3
        Me.gboClasses.TabStop = False
        Me.gboClasses.Text = "Classes"
        '
        'lboClasses
        '
        Me.lboClasses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboClasses.FormattingEnabled = True
        Me.lboClasses.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.lboClasses.Location = New System.Drawing.Point(7, 62)
        Me.lboClasses.Name = "lboClasses"
        Me.lboClasses.Size = New System.Drawing.Size(235, 212)
        Me.lboClasses.TabIndex = 0
        '
        'gboPlugins
        '
        Me.gboPlugins.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gboPlugins.BackColor = System.Drawing.Color.Transparent
        Me.gboPlugins.Controls.Add(Me.btnViewInstalled)
        Me.gboPlugins.Controls.Add(Me.btnInstall)
        Me.gboPlugins.Font = New System.Drawing.Font("Capture it", 36.0!)
        Me.gboPlugins.Location = New System.Drawing.Point(493, 309)
        Me.gboPlugins.Name = "gboPlugins"
        Me.gboPlugins.Size = New System.Drawing.Size(248, 188)
        Me.gboPlugins.TabIndex = 4
        Me.gboPlugins.TabStop = False
        Me.gboPlugins.Text = "Plugins"
        '
        'btnInstall
        '
        Me.btnInstall.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnInstall.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstall.Location = New System.Drawing.Point(7, 62)
        Me.btnInstall.Name = "btnInstall"
        Me.btnInstall.Size = New System.Drawing.Size(235, 45)
        Me.btnInstall.TabIndex = 4
        Me.btnInstall.Text = "Install"
        Me.btnInstall.UseVisualStyleBackColor = False
        '
        'btnViewInstalled
        '
        Me.btnViewInstalled.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnViewInstalled.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewInstalled.Location = New System.Drawing.Point(7, 124)
        Me.btnViewInstalled.Name = "btnViewInstalled"
        Me.btnViewInstalled.Size = New System.Drawing.Size(235, 45)
        Me.btnViewInstalled.TabIndex = 5
        Me.btnViewInstalled.Text = "View Installed"
        Me.btnViewInstalled.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(755, 509)
        Me.Controls.Add(Me.gboPlugins)
        Me.Controls.Add(Me.gboClasses)
        Me.Controls.Add(Me.gboAssignments)
        Me.Controls.Add(Me.picHomework_Logo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Homework Helper"
        CType(Me.picHomework_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboAssignments.ResumeLayout(False)
        Me.gboClasses.ResumeLayout(False)
        Me.gboPlugins.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picHomework_Logo As System.Windows.Forms.PictureBox
    Friend WithEvents gboAssignments As System.Windows.Forms.GroupBox
    Friend WithEvents gboClasses As System.Windows.Forms.GroupBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnExisting As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents lboAssignments As System.Windows.Forms.ListBox
    Friend WithEvents lboClasses As System.Windows.Forms.ListBox
    Friend WithEvents gboPlugins As System.Windows.Forms.GroupBox
    Friend WithEvents btnViewInstalled As System.Windows.Forms.Button
    Friend WithEvents btnInstall As System.Windows.Forms.Button
End Class
