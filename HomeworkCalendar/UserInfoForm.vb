Imports HWLib.Objects
Imports HWLib.JSON
Imports System.IO

Public Class UserInfoForm

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles numAge.ValueChanged
        If numAge.Value < 13 Then
            numAge.Value = 13
        ElseIf numAge.Value > 150 Then
            numAge.Value = 150
        End If
    End Sub
    Dim mainMessage As String = "You need to fix the following errors: " & (Chr(13)) & (Chr(13))
    Const FinalMessage As String = "You need to fix the following errors: " & (Chr(13)) & (Chr(13))

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If HasErrors() Then
            MsgBox(mainMessage)
        Else
            Try
                Dim uInfo As New UserInfo() With { _
                    .userName = txtUsername.Text,
                    .classCount = numCourses.Value,
                    .age = numAge.Value
                }
                UserInfoWriter.write(uInfo)
            Catch ex As Exception
                MsgBox("Oops! Something went wrong!")
            Finally
                CourseForm.Show()
            End Try
        End If
        mainMessage = FinalMessage
    End Sub
    Function HasErrors() As Boolean
        If txtUsername.TextLength < 6 Then
            mainMessage += "Username needs to be at least 6 characters"
        End If
        If txtUsername.TextLength > 15 Then
            mainMessage += "Username cannot exceed 15 characters"
        End If
        Try
            Dim x1 As String = txtUsername.Text
        Catch ex As NullReferenceException
            mainMessage += "Username cannot be empty"
        End Try
        If mainMessage <> FinalMessage Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub numCourses_ValueChanged(sender As Object, e As EventArgs) Handles numCourses.ValueChanged
        If numCourses.Value < 1 Then
            numCourses.Value = 1
        ElseIf numCourses.Value > 15 Then
            numCourses.Value = 15
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HWLib.Font.downloadFontIfNeeded()
        'HWLib.Objects.Assignments.Files.
        HWLib.JSON.Files.createDirectoryIfNeeded()
        If File.Exists(Files.JSONFiles(0)) Then
            If Not File.Exists(Files.JSONFiles(1)) Then
                CourseForm.Show()
            Else
                MainForm.Show()
            End If
        End If
    End Sub
End Class
