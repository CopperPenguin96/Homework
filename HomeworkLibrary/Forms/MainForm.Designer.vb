Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class MainForm
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
            Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
            Me.listUpcoming = New System.Windows.Forms.ListBox()
            Me.lblUpcoming = New System.Windows.Forms.Label()
            Me.gboUser = New System.Windows.Forms.GroupBox()
            Me.listCourses = New System.Windows.Forms.ListBox()
            Me.lblAge = New System.Windows.Forms.Label()
            Me.lblGrade = New System.Windows.Forms.Label()
            Me.lblName = New System.Windows.Forms.Label()
            Me.lblStudyTips = New System.Windows.Forms.Label()
            Me.gboStudy1 = New System.Windows.Forms.GroupBox()
            Me.gboStudy2 = New System.Windows.Forms.GroupBox()
            Me.gboStudy3 = New System.Windows.Forms.GroupBox()
            Me.flpPanel = New System.Windows.Forms.FlowLayoutPanel()
            Me.picMainLogo = New System.Windows.Forms.PictureBox()
            Me.btnAdd = New System.Windows.Forms.Button()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnModify = New System.Windows.Forms.Button()
            Me.btnCalendar = New System.Windows.Forms.Button()
            Me.btnSettings = New System.Windows.Forms.Button()
            Me.btnExit = New System.Windows.Forms.Button()
            Me.btnMoveNavigation = New System.Windows.Forms.Button()
            Me.lblTip1 = New System.Windows.Forms.Label()
            Me.lblTip2 = New System.Windows.Forms.Label()
            Me.lblTip3 = New System.Windows.Forms.Label()
            Me.gboUser.SuspendLayout()
            Me.gboStudy1.SuspendLayout()
            Me.gboStudy2.SuspendLayout()
            Me.gboStudy3.SuspendLayout()
            Me.flpPanel.SuspendLayout()
            CType(Me.picMainLogo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'DateTimePicker1
            '
            Me.DateTimePicker1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.DateTimePicker1.Location = New System.Drawing.Point(49, 37)
            Me.DateTimePicker1.Name = "DateTimePicker1"
            Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
            Me.DateTimePicker1.TabIndex = 0
            '
            'listUpcoming
            '
            Me.listUpcoming.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.listUpcoming.FormattingEnabled = True
            Me.listUpcoming.Location = New System.Drawing.Point(49, 63)
            Me.listUpcoming.Name = "listUpcoming"
            Me.listUpcoming.Size = New System.Drawing.Size(200, 134)
            Me.listUpcoming.TabIndex = 1
            '
            'lblUpcoming
            '
            Me.lblUpcoming.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblUpcoming.AutoSize = True
            Me.lblUpcoming.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUpcoming.Location = New System.Drawing.Point(44, 9)
            Me.lblUpcoming.Name = "lblUpcoming"
            Me.lblUpcoming.Size = New System.Drawing.Size(116, 25)
            Me.lblUpcoming.TabIndex = 2
            Me.lblUpcoming.Text = "Upcoming"
            '
            'gboUser
            '
            Me.gboUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gboUser.Controls.Add(Me.listCourses)
            Me.gboUser.Controls.Add(Me.lblAge)
            Me.gboUser.Controls.Add(Me.lblGrade)
            Me.gboUser.Controls.Add(Me.lblName)
            Me.gboUser.Location = New System.Drawing.Point(49, 204)
            Me.gboUser.Name = "gboUser"
            Me.gboUser.Size = New System.Drawing.Size(200, 157)
            Me.gboUser.TabIndex = 3
            Me.gboUser.TabStop = False
            Me.gboUser.Text = "User"
            '
            'listCourses
            '
            Me.listCourses.FormattingEnabled = True
            Me.listCourses.Location = New System.Drawing.Point(7, 63)
            Me.listCourses.Name = "listCourses"
            Me.listCourses.Size = New System.Drawing.Size(187, 82)
            Me.listCourses.TabIndex = 3
            '
            'lblAge
            '
            Me.lblAge.AutoSize = True
            Me.lblAge.Location = New System.Drawing.Point(6, 46)
            Me.lblAge.Name = "lblAge"
            Me.lblAge.Size = New System.Drawing.Size(29, 13)
            Me.lblAge.TabIndex = 2
            Me.lblAge.Text = "Age:"
            '
            'lblGrade
            '
            Me.lblGrade.AutoSize = True
            Me.lblGrade.Location = New System.Drawing.Point(7, 33)
            Me.lblGrade.Name = "lblGrade"
            Me.lblGrade.Size = New System.Drawing.Size(39, 13)
            Me.lblGrade.TabIndex = 1
            Me.lblGrade.Text = "Grade:"
            '
            'lblName
            '
            Me.lblName.AutoSize = True
            Me.lblName.Location = New System.Drawing.Point(7, 20)
            Me.lblName.Name = "lblName"
            Me.lblName.Size = New System.Drawing.Size(38, 13)
            Me.lblName.TabIndex = 0
            Me.lblName.Text = "Name:"
            '
            'lblStudyTips
            '
            Me.lblStudyTips.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblStudyTips.AutoSize = True
            Me.lblStudyTips.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblStudyTips.Location = New System.Drawing.Point(257, 9)
            Me.lblStudyTips.Name = "lblStudyTips"
            Me.lblStudyTips.Size = New System.Drawing.Size(124, 25)
            Me.lblStudyTips.TabIndex = 4
            Me.lblStudyTips.Text = "Study Tips"
            '
            'gboStudy1
            '
            Me.gboStudy1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gboStudy1.Controls.Add(Me.lblTip1)
            Me.gboStudy1.Location = New System.Drawing.Point(262, 37)
            Me.gboStudy1.Name = "gboStudy1"
            Me.gboStudy1.Size = New System.Drawing.Size(200, 104)
            Me.gboStudy1.TabIndex = 5
            Me.gboStudy1.TabStop = False
            Me.gboStudy1.Text = "Tip #1"
            '
            'gboStudy2
            '
            Me.gboStudy2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gboStudy2.Controls.Add(Me.lblTip2)
            Me.gboStudy2.Location = New System.Drawing.Point(262, 147)
            Me.gboStudy2.Name = "gboStudy2"
            Me.gboStudy2.Size = New System.Drawing.Size(200, 104)
            Me.gboStudy2.TabIndex = 6
            Me.gboStudy2.TabStop = False
            Me.gboStudy2.Text = "Tip #2"
            '
            'gboStudy3
            '
            Me.gboStudy3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gboStudy3.Controls.Add(Me.lblTip3)
            Me.gboStudy3.Location = New System.Drawing.Point(262, 257)
            Me.gboStudy3.Name = "gboStudy3"
            Me.gboStudy3.Size = New System.Drawing.Size(200, 104)
            Me.gboStudy3.TabIndex = 7
            Me.gboStudy3.TabStop = False
            Me.gboStudy3.Text = "Tip #3"
            '
            'flpPanel
            '
            Me.flpPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.flpPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.flpPanel.Controls.Add(Me.picMainLogo)
            Me.flpPanel.Controls.Add(Me.btnAdd)
            Me.flpPanel.Controls.Add(Me.btnDelete)
            Me.flpPanel.Controls.Add(Me.btnModify)
            Me.flpPanel.Controls.Add(Me.btnCalendar)
            Me.flpPanel.Controls.Add(Me.btnSettings)
            Me.flpPanel.Controls.Add(Me.btnExit)
            Me.flpPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.flpPanel.Location = New System.Drawing.Point(0, 0)
            Me.flpPanel.Name = "flpPanel"
            Me.flpPanel.Size = New System.Drawing.Size(131, 377)
            Me.flpPanel.TabIndex = 8
            '
            'picMainLogo
            '
            Me.picMainLogo.Image = Global.HomeworkLibrary.My.Resources.Resources.main_logo
            Me.picMainLogo.Location = New System.Drawing.Point(3, 3)
            Me.picMainLogo.Name = "picMainLogo"
            Me.picMainLogo.Size = New System.Drawing.Size(128, 31)
            Me.picMainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.picMainLogo.TabIndex = 0
            Me.picMainLogo.TabStop = False
            '
            'btnAdd
            '
            Me.btnAdd.Location = New System.Drawing.Point(3, 40)
            Me.btnAdd.Name = "btnAdd"
            Me.btnAdd.Size = New System.Drawing.Size(128, 33)
            Me.btnAdd.TabIndex = 1
            Me.btnAdd.Text = "Add"
            Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnAdd.UseVisualStyleBackColor = True
            '
            'btnDelete
            '
            Me.btnDelete.Location = New System.Drawing.Point(3, 79)
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.Size = New System.Drawing.Size(128, 33)
            Me.btnDelete.TabIndex = 2
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDelete.UseVisualStyleBackColor = True
            '
            'btnModify
            '
            Me.btnModify.Location = New System.Drawing.Point(3, 118)
            Me.btnModify.Name = "btnModify"
            Me.btnModify.Size = New System.Drawing.Size(128, 33)
            Me.btnModify.TabIndex = 3
            Me.btnModify.Text = "Modify"
            Me.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnModify.UseVisualStyleBackColor = True
            '
            'btnCalendar
            '
            Me.btnCalendar.Location = New System.Drawing.Point(3, 157)
            Me.btnCalendar.Name = "btnCalendar"
            Me.btnCalendar.Size = New System.Drawing.Size(128, 33)
            Me.btnCalendar.TabIndex = 4
            Me.btnCalendar.Text = "Calendar"
            Me.btnCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCalendar.UseVisualStyleBackColor = True
            '
            'btnSettings
            '
            Me.btnSettings.Location = New System.Drawing.Point(3, 196)
            Me.btnSettings.Name = "btnSettings"
            Me.btnSettings.Size = New System.Drawing.Size(128, 33)
            Me.btnSettings.TabIndex = 5
            Me.btnSettings.Text = "Settings"
            Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSettings.UseVisualStyleBackColor = True
            '
            'btnExit
            '
            Me.btnExit.Location = New System.Drawing.Point(3, 235)
            Me.btnExit.Name = "btnExit"
            Me.btnExit.Size = New System.Drawing.Size(128, 33)
            Me.btnExit.TabIndex = 6
            Me.btnExit.Text = "Exit"
            Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExit.UseVisualStyleBackColor = True
            '
            'btnMoveNavigation
            '
            Me.btnMoveNavigation.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.btnMoveNavigation.AutoSize = True
            Me.btnMoveNavigation.Location = New System.Drawing.Point(137, 175)
            Me.btnMoveNavigation.Name = "btnMoveNavigation"
            Me.btnMoveNavigation.Size = New System.Drawing.Size(30, 23)
            Me.btnMoveNavigation.TabIndex = 9
            Me.btnMoveNavigation.Text = "<<"
            Me.btnMoveNavigation.UseVisualStyleBackColor = True
            '
            'lblTip1
            '
            Me.lblTip1.Location = New System.Drawing.Point(7, 22)
            Me.lblTip1.Name = "lblTip1"
            Me.lblTip1.Size = New System.Drawing.Size(187, 79)
            Me.lblTip1.TabIndex = 0
            Me.lblTip1.Text = "Tip"
            '
            'lblTip2
            '
            Me.lblTip2.Location = New System.Drawing.Point(7, 20)
            Me.lblTip2.Name = "lblTip2"
            Me.lblTip2.Size = New System.Drawing.Size(187, 79)
            Me.lblTip2.TabIndex = 1
            Me.lblTip2.Text = "Tip"
            '
            'lblTip3
            '
            Me.lblTip3.Location = New System.Drawing.Point(7, 16)
            Me.lblTip3.Name = "lblTip3"
            Me.lblTip3.Size = New System.Drawing.Size(187, 79)
            Me.lblTip3.TabIndex = 1
            Me.lblTip3.Text = "Tip"
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Maroon
            Me.ClientSize = New System.Drawing.Size(478, 373)
            Me.Controls.Add(Me.btnMoveNavigation)
            Me.Controls.Add(Me.flpPanel)
            Me.Controls.Add(Me.gboStudy3)
            Me.Controls.Add(Me.gboStudy2)
            Me.Controls.Add(Me.gboStudy1)
            Me.Controls.Add(Me.lblStudyTips)
            Me.Controls.Add(Me.gboUser)
            Me.Controls.Add(Me.lblUpcoming)
            Me.Controls.Add(Me.listUpcoming)
            Me.Controls.Add(Me.DateTimePicker1)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(494, 412)
            Me.MinimumSize = New System.Drawing.Size(494, 412)
            Me.Name = "MainForm"
            Me.Text = "MainForm"
            Me.gboUser.ResumeLayout(False)
            Me.gboUser.PerformLayout()
            Me.gboStudy1.ResumeLayout(False)
            Me.gboStudy2.ResumeLayout(False)
            Me.gboStudy3.ResumeLayout(False)
            Me.flpPanel.ResumeLayout(False)
            CType(Me.picMainLogo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents DateTimePicker1 As Windows.Forms.DateTimePicker
        Friend WithEvents listUpcoming As Windows.Forms.ListBox
        Friend WithEvents lblUpcoming As Windows.Forms.Label
        Friend WithEvents gboUser As Windows.Forms.GroupBox
        Friend WithEvents listCourses As Windows.Forms.ListBox
        Friend WithEvents lblAge As Windows.Forms.Label
        Friend WithEvents lblGrade As Windows.Forms.Label
        Friend WithEvents lblName As Windows.Forms.Label
        Friend WithEvents lblStudyTips As Windows.Forms.Label
        Friend WithEvents gboStudy1 As Windows.Forms.GroupBox
        Friend WithEvents gboStudy2 As Windows.Forms.GroupBox
        Friend WithEvents gboStudy3 As Windows.Forms.GroupBox
        Friend WithEvents flpPanel As Windows.Forms.FlowLayoutPanel
        Friend WithEvents btnMoveNavigation As Windows.Forms.Button
        Friend WithEvents picMainLogo As Windows.Forms.PictureBox
        Friend WithEvents btnAdd As Windows.Forms.Button
        Friend WithEvents btnDelete As Windows.Forms.Button
        Friend WithEvents btnModify As Windows.Forms.Button
        Friend WithEvents btnCalendar As Windows.Forms.Button
        Friend WithEvents btnSettings As Windows.Forms.Button
        Friend WithEvents btnExit As Windows.Forms.Button
        Friend WithEvents lblTip1 As Windows.Forms.Label
        Friend WithEvents lblTip2 As Windows.Forms.Label
        Friend WithEvents lblTip3 As Windows.Forms.Label
    End Class
End Namespace