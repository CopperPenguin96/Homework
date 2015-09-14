Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class UserInfoForm
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
            Me.lblBasics = New System.Windows.Forms.Label()
            Me.lblName = New System.Windows.Forms.Label()
            Me.txtName = New System.Windows.Forms.TextBox()
            Me.lblAge = New System.Windows.Forms.Label()
            Me.numAge = New System.Windows.Forms.NumericUpDown()
            Me.numCourses = New System.Windows.Forms.NumericUpDown()
            Me.lblClasses = New System.Windows.Forms.Label()
            Me.numGrade = New System.Windows.Forms.NumericUpDown()
            Me.lblGradeLevel = New System.Windows.Forms.Label()
            Me.btnSubmit = New System.Windows.Forms.Button()
            Me.picLogo = New System.Windows.Forms.PictureBox()
            CType(Me.numAge, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numCourses, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numGrade, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblBasics
            '
            Me.lblBasics.Location = New System.Drawing.Point(13, 93)
            Me.lblBasics.Name = "lblBasics"
            Me.lblBasics.Size = New System.Drawing.Size(163, 47)
            Me.lblBasics.TabIndex = 1
            Me.lblBasics.Text = "Welcome to Homework Calendar! Before we begin, we need some basic info!"
            '
            'lblName
            '
            Me.lblName.AutoSize = True
            Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblName.Location = New System.Drawing.Point(13, 146)
            Me.lblName.Name = "lblName"
            Me.lblName.Size = New System.Drawing.Size(39, 13)
            Me.lblName.TabIndex = 2
            Me.lblName.Text = "Name"
            '
            'txtName
            '
            Me.txtName.Location = New System.Drawing.Point(69, 143)
            Me.txtName.Name = "txtName"
            Me.txtName.Size = New System.Drawing.Size(107, 20)
            Me.txtName.TabIndex = 3
            '
            'lblAge
            '
            Me.lblAge.AutoSize = True
            Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblAge.Location = New System.Drawing.Point(13, 171)
            Me.lblAge.Name = "lblAge"
            Me.lblAge.Size = New System.Drawing.Size(29, 13)
            Me.lblAge.TabIndex = 4
            Me.lblAge.Text = "Age"
            '
            'numAge
            '
            Me.numAge.Location = New System.Drawing.Point(69, 169)
            Me.numAge.Maximum = New Decimal(New Integer() {175, 0, 0, 0})
            Me.numAge.Minimum = New Decimal(New Integer() {6, 0, 0, 0})
            Me.numAge.Name = "numAge"
            Me.numAge.Size = New System.Drawing.Size(50, 20)
            Me.numAge.TabIndex = 5
            Me.numAge.Value = New Decimal(New Integer() {13, 0, 0, 0})
            '
            'numCourses
            '
            Me.numCourses.Location = New System.Drawing.Point(69, 195)
            Me.numCourses.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
            Me.numCourses.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numCourses.Name = "numCourses"
            Me.numCourses.Size = New System.Drawing.Size(50, 20)
            Me.numCourses.TabIndex = 8
            Me.numCourses.Value = New Decimal(New Integer() {3, 0, 0, 0})
            '
            'lblClasses
            '
            Me.lblClasses.AutoSize = True
            Me.lblClasses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblClasses.Location = New System.Drawing.Point(13, 197)
            Me.lblClasses.Name = "lblClasses"
            Me.lblClasses.Size = New System.Drawing.Size(50, 13)
            Me.lblClasses.TabIndex = 7
            Me.lblClasses.Text = "Classes"
            '
            'numGrade
            '
            Me.numGrade.Location = New System.Drawing.Point(69, 221)
            Me.numGrade.Maximum = New Decimal(New Integer() {13, 0, 0, 0})
            Me.numGrade.Name = "numGrade"
            Me.numGrade.Size = New System.Drawing.Size(50, 20)
            Me.numGrade.TabIndex = 10
            Me.numGrade.Value = New Decimal(New Integer() {7, 0, 0, 0})
            '
            'lblGradeLevel
            '
            Me.lblGradeLevel.AutoSize = True
            Me.lblGradeLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblGradeLevel.Location = New System.Drawing.Point(13, 223)
            Me.lblGradeLevel.Name = "lblGradeLevel"
            Me.lblGradeLevel.Size = New System.Drawing.Size(41, 13)
            Me.lblGradeLevel.TabIndex = 9
            Me.lblGradeLevel.Text = "Grade"
            '
            'btnSubmit
            '
            Me.btnSubmit.Location = New System.Drawing.Point(16, 247)
            Me.btnSubmit.Name = "btnSubmit"
            Me.btnSubmit.Size = New System.Drawing.Size(160, 27)
            Me.btnSubmit.TabIndex = 11
            Me.btnSubmit.Text = "Submit"
            Me.btnSubmit.UseVisualStyleBackColor = True
            '
            'picLogo
            '
            Me.picLogo.Image = Global.HomeworkLibrary.My.Resources.Resources.main_icon
            Me.picLogo.Location = New System.Drawing.Point(13, 12)
            Me.picLogo.Name = "picLogo"
            Me.picLogo.Size = New System.Drawing.Size(163, 74)
            Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.picLogo.TabIndex = 0
            Me.picLogo.TabStop = False
            '
            'UserInfoForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(192, 284)
            Me.Controls.Add(Me.btnSubmit)
            Me.Controls.Add(Me.numGrade)
            Me.Controls.Add(Me.lblGradeLevel)
            Me.Controls.Add(Me.numCourses)
            Me.Controls.Add(Me.lblClasses)
            Me.Controls.Add(Me.numAge)
            Me.Controls.Add(Me.lblAge)
            Me.Controls.Add(Me.txtName)
            Me.Controls.Add(Me.lblName)
            Me.Controls.Add(Me.lblBasics)
            Me.Controls.Add(Me.picLogo)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(208, 323)
            Me.MinimizeBox = False
            Me.MinimumSize = New System.Drawing.Size(208, 323)
            Me.Name = "UserInfoForm"
            Me.ShowInTaskbar = False
            Me.Text = "Welcome!"
            CType(Me.numAge, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numCourses, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numGrade, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents picLogo As Windows.Forms.PictureBox
        Friend WithEvents lblBasics As Windows.Forms.Label
        Friend WithEvents lblName As Windows.Forms.Label
        Friend WithEvents txtName As Windows.Forms.TextBox
        Friend WithEvents lblAge As Windows.Forms.Label
        Friend WithEvents numAge As Windows.Forms.NumericUpDown
        Friend WithEvents numCourses As Windows.Forms.NumericUpDown
        Friend WithEvents lblClasses As Windows.Forms.Label
        Friend WithEvents numGrade As Windows.Forms.NumericUpDown
        Friend WithEvents lblGradeLevel As Windows.Forms.Label
        Friend WithEvents btnSubmit As Windows.Forms.Button
    End Class
End Namespace