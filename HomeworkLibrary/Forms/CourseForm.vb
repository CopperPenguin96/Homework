Imports System.Windows.Forms
Imports HomeworkLibrary.Users

Namespace Forms
    Public Class CourseForm
        Private Sub CourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            SetCourseCount()
        End Sub

        Private Sub SetCourseCount()
            Dim intCourses As Integer = User.AppUser.ClassCount
            If (intCourses >= 1) Then txtCourse1.Enabled = True
            If (intCourses >= 2) Then txtCourse2.Enabled = True
            If (intCourses >= 3) Then txtCourse3.Enabled = True
            If (intCourses >= 4) Then txtCourse4.Enabled = True
            If (intCourses >= 5) Then txtCourse5.Enabled = True
            If (intCourses >= 6) Then txtCourse6.Enabled = True
            If (intCourses >= 7) Then txtCourse7.Enabled = True
            If (intCourses >= 8) Then txtCourse8.Enabled = True
            If (intCourses >= 9) Then txtCourse9.Enabled = True
            If (intCourses >= 10) Then txtCourse10.Enabled = True
        End Sub
        Private Function TextFromBox(int As Integer) As String
            Select Case int
                Case 1
                    Return txtCourse1.Text
                Case 2
                    Return txtCourse2.Text
                Case 3
                    Return txtCourse3.Text
                Case 4
                    Return txtCourse4.Text
                Case 5
                    Return txtCourse5.Text
                Case 6
                    Return txtCourse6.Text
                Case 7
                    Return txtCourse7.Text
                Case 8
                    Return txtCourse8.Text
                Case 9
                    Return txtCourse9.Text
                Case 10
                    Return txtCourse10.Text
                Case Else
                    Return Nothing
            End Select
        End Function
        Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
            Dim txtList As New List(Of String)
            For x = 1 To User.AppUser.ClassCount
                txtList.Add(TextFromBox(x))
            Next
            Dim courseList As New List(Of Course)
            For Each txtItem In txtList
                Dim newCourse As New Course()
                newCourse.Name = txtItem
                courseList.Add(newCourse)
            Next
            Course.ClassList = courseList
            If Course.Save() Then
                MsgBox("Thank you for taking the time! Your information has been saved!")
                Application.Restart()
            Else
                MsgBox("There was a problem saving the file. Make sure it isn't open in any other program!")
            End If
        End Sub
    End Class
End Namespace