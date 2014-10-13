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

    Private Sub btnAssignment_Click(sender As Object, e As EventArgs) Handles btnAssignment.Click
        Dim addType As AddTypeForm = New AddTypeForm(AssignmentTypes.Assignment)
        addType.ShowDialog()
    End Sub
End Class