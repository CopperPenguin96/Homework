Imports HWLib.Objects.Assignments
Imports HWLib.Objects
Public Class TypeSelection
    Dim typeAction As Action
    Public Sub New(actType As Action)
        InitializeComponent()
        typeAction = actType
        Me.Text = getTypeOfAction(actType) + " Assignment"
    End Sub
    Function getTypeOfAction(actType As Action)
        If actType = Action.AddExisting Then
            Return "Add Existing"
        ElseIf actType = Action.AddNew Then
            Return "Add New"
        ElseIf actType = Action.Delete Then
            Return "Delete"
        Else
            Return Nothing
        End If
    End Function
    Sub StartForm(type As AssignmentTypes)
        Dim addType As AddTypeForm = New AddTypeForm(type)
        addType.ShowDialog()
    End Sub
    Private Sub btnAssignment_Click(sender As Object, e As EventArgs) Handles btnAssignment.Click
        StartForm(AssignmentTypes.Assignment)
    End Sub

    Private Sub btnHomework_Click(sender As Object, e As EventArgs) Handles btnHomework.Click
        StartForm(AssignmentTypes.Homework)
    End Sub

    Private Sub btnProject_Click(sender As Object, e As EventArgs) Handles btnProject.Click
        StartForm(AssignmentTypes.Project)
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        StartForm(AssignmentTypes.Test)
    End Sub

    Private Sub btnQuiz_Click(sender As Object, e As EventArgs) Handles btnQuiz.Click
        StartForm(AssignmentTypes.Quiz)
    End Sub

    Private Sub btnFinal_Click(sender As Object, e As EventArgs) Handles btnFinal.Click
        StartForm(AssignmentTypes.Final)
    End Sub
End Class