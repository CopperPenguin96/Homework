Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserInfoForm.Close()
        CourseForm.Close()
    End Sub

    
 
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim newType As TypeSelection = New TypeSelection(HWLib.Objects.Assignments.Action.AddNew)
        newType.ShowDialog()
    End Sub

    Private Sub btnExisting_Click(sender As Object, e As EventArgs) Handles btnExisting.Click
        Dim newType As TypeSelection = New TypeSelection(HWLib.Objects.Assignments.Action.AddExisting)
        newType.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim newType As TypeSelection = New TypeSelection(HWLib.Objects.Assignments.Action.Delete)
        newType.ShowDialog()
    End Sub
End Class