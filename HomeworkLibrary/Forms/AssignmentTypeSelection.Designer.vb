Imports HomeworkLibrary.Assignments

Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class AssignmentTypeSelection
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
            components = New System.ComponentModel.Container
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Text = "AssignmentTypeSelection"
        End Sub
        Public MethodUsing As Method
        Public Sub New(aType As Method)
            InitializeComponent()
            MethodUsing = aType
        End Sub
    End Class
End Namespace