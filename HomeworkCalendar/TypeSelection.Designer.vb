<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TypeSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TypeSelection))
        Me.btnAssignment = New System.Windows.Forms.Button()
        Me.btnHomework = New System.Windows.Forms.Button()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.btnQuiz = New System.Windows.Forms.Button()
        Me.btnFinal = New System.Windows.Forms.Button()
        Me.btnProject = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAssignment
        '
        Me.btnAssignment.Location = New System.Drawing.Point(13, 13)
        Me.btnAssignment.Name = "btnAssignment"
        Me.btnAssignment.Size = New System.Drawing.Size(259, 23)
        Me.btnAssignment.TabIndex = 0
        Me.btnAssignment.Text = "Assignment"
        Me.btnAssignment.UseVisualStyleBackColor = True
        '
        'btnHomework
        '
        Me.btnHomework.Location = New System.Drawing.Point(12, 42)
        Me.btnHomework.Name = "btnHomework"
        Me.btnHomework.Size = New System.Drawing.Size(259, 23)
        Me.btnHomework.TabIndex = 1
        Me.btnHomework.Text = "Homework"
        Me.btnHomework.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(13, 100)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(259, 23)
        Me.btnTest.TabIndex = 2
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'btnQuiz
        '
        Me.btnQuiz.Location = New System.Drawing.Point(13, 129)
        Me.btnQuiz.Name = "btnQuiz"
        Me.btnQuiz.Size = New System.Drawing.Size(259, 23)
        Me.btnQuiz.TabIndex = 3
        Me.btnQuiz.Text = "Quiz"
        Me.btnQuiz.UseVisualStyleBackColor = True
        '
        'btnFinal
        '
        Me.btnFinal.Location = New System.Drawing.Point(13, 158)
        Me.btnFinal.Name = "btnFinal"
        Me.btnFinal.Size = New System.Drawing.Size(259, 23)
        Me.btnFinal.TabIndex = 4
        Me.btnFinal.Text = "Final"
        Me.btnFinal.UseVisualStyleBackColor = True
        '
        'btnProject
        '
        Me.btnProject.Location = New System.Drawing.Point(12, 71)
        Me.btnProject.Name = "btnProject"
        Me.btnProject.Size = New System.Drawing.Size(259, 23)
        Me.btnProject.TabIndex = 5
        Me.btnProject.Text = "Project"
        Me.btnProject.UseVisualStyleBackColor = True
        '
        'TypeSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 194)
        Me.Controls.Add(Me.btnProject)
        Me.Controls.Add(Me.btnFinal)
        Me.Controls.Add(Me.btnQuiz)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.btnHomework)
        Me.Controls.Add(Me.btnAssignment)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TypeSelection"
        Me.Text = "{Action} Assignment"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAssignment As System.Windows.Forms.Button
    Friend WithEvents btnHomework As System.Windows.Forms.Button
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents btnQuiz As System.Windows.Forms.Button
    Friend WithEvents btnFinal As System.Windows.Forms.Button
    Friend WithEvents btnProject As System.Windows.Forms.Button
End Class
