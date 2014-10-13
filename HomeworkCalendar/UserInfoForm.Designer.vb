<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserInfoForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserInfoForm))
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.numAge = New System.Windows.Forms.NumericUpDown()
        Me.lblClassCount = New System.Windows.Forms.Label()
        Me.numCourses = New System.Windows.Forms.NumericUpDown()
        Me.btnSubmit = New System.Windows.Forms.Button()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCourses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(12, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(412, 156)
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(9, 171)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(55, 13)
        Me.lblUserName.TabIndex = 1
        Me.lblUserName.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(71, 171)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(349, 20)
        Me.txtUsername.TabIndex = 2
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(9, 197)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(26, 13)
        Me.lblAge.TabIndex = 3
        Me.lblAge.Text = "Age"
        '
        'numAge
        '
        Me.numAge.Location = New System.Drawing.Point(71, 197)
        Me.numAge.Name = "numAge"
        Me.numAge.Size = New System.Drawing.Size(349, 20)
        Me.numAge.TabIndex = 4
        Me.numAge.Value = New Decimal(New Integer() {13, 0, 0, 0})
        '
        'lblClassCount
        '
        Me.lblClassCount.AutoSize = True
        Me.lblClassCount.Location = New System.Drawing.Point(9, 223)
        Me.lblClassCount.Name = "lblClassCount"
        Me.lblClassCount.Size = New System.Drawing.Size(45, 13)
        Me.lblClassCount.TabIndex = 5
        Me.lblClassCount.Text = "Courses"
        '
        'numCourses
        '
        Me.numCourses.Location = New System.Drawing.Point(71, 223)
        Me.numCourses.Name = "numCourses"
        Me.numCourses.Size = New System.Drawing.Size(349, 20)
        Me.numCourses.TabIndex = 6
        Me.numCourses.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.DimGray
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSubmit.Location = New System.Drawing.Point(12, 250)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(408, 63)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Finish"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(436, 325)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.numCourses)
        Me.Controls.Add(Me.lblClassCount)
        Me.Controls.Add(Me.numAge)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.picLogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "User Info"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCourses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents numAge As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblClassCount As System.Windows.Forms.Label
    Friend WithEvents numCourses As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnSubmit As System.Windows.Forms.Button

End Class
