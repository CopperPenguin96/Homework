Imports System.Windows.Forms
Imports HomeworkLibrary.Users

Namespace Forms

    Public Class UserInfoForm

        Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
            If txtName.Text = String.Empty Then
                MsgBox("Please enter your name!")
            Else
                Dim newUser As New User
                newUser.Name = txtName.Text
                newUser.Age = numAge.Value
                newUser.GradeLevel = numGrade.Value
                newUser.ClassCount = numCourses.Value
                Main.SetUpCourses = numCourses.Value
                If newUser.Save() Then
                    Application.Restart()
                Else
                    MsgBox("Something went wrong. Please make sure you aren't using the app files in any other program. " & newUser.xError)
                End If
            End If
        End Sub
    End Class
End Namespace