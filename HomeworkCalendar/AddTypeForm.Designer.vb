<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTypeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddTypeForm))
        Me.picType = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Calendar = New System.Windows.Forms.MonthCalendar()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.numPoints = New System.Windows.Forms.NumericUpDown()
        Me.chkBalloon = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.picType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPoints, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picType
        '
        Me.picType.Location = New System.Drawing.Point(13, 12)
        Me.picType.Name = "picType"
        Me.picType.Size = New System.Drawing.Size(542, 111)
        Me.picType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picType.TabIndex = 0
        Me.picType.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 130)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        '
        'Calendar
        '
        Me.Calendar.Location = New System.Drawing.Point(329, 130)
        Me.Calendar.MaxSelectionCount = 1
        Me.Calendar.Name = "Calendar"
        Me.Calendar.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(54, 130)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(263, 20)
        Me.txtName.TabIndex = 3
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.Location = New System.Drawing.Point(13, 156)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(36, 13)
        Me.lblPoints.TabIndex = 4
        Me.lblPoints.Text = "Points"
        '
        'numPoints
        '
        Me.numPoints.Location = New System.Drawing.Point(54, 156)
        Me.numPoints.Name = "numPoints"
        Me.numPoints.Size = New System.Drawing.Size(263, 20)
        Me.numPoints.TabIndex = 8
        '
        'chkBalloon
        '
        Me.chkBalloon.AutoSize = True
        Me.chkBalloon.Location = New System.Drawing.Point(16, 182)
        Me.chkBalloon.Name = "chkBalloon"
        Me.chkBalloon.Size = New System.Drawing.Size(214, 17)
        Me.chkBalloon.TabIndex = 9
        Me.chkBalloon.Text = "Display balloon notifications in task bar?"
        Me.chkBalloon.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(16, 206)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(301, 86)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'AddTypeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 306)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.chkBalloon)
        Me.Controls.Add(Me.numPoints)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Calendar)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.picType)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddTypeForm"
        Me.Text = "Add {Type}"
        CType(Me.picType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPoints, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picType As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Calendar As System.Windows.Forms.MonthCalendar
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblPoints As System.Windows.Forms.Label
    Friend WithEvents numPoints As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkBalloon As System.Windows.Forms.CheckBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
