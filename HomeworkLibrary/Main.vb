Imports System.IO
Imports HomeworkLibrary.hSystem
Imports HomeworkLibrary.Users

Public Class Main
    Public Shared Sub InitLibrary()
        Settings.LoadSettings()
        User.AppUser = User.GetUser()
    End Sub
    ''' <summary>
    ''' Only used during set up
    ''' </summary>
    Public Shared SetUpCourses As Integer = 0
    Public Shared Function GetCurrentForm() As AppForms
        If Not File.Exists(Settings.ApplicationDirectory + "userInfo.json") Then
            Return AppForms.UserInfo
        End If
        Try
            If Not File.Exists(Settings.ApplicationDirectory & "courses.json") Then
                Return AppForms.Courses
            End If
        Catch exNull As NullReferenceException
            ErrorLogging.Write(exNull)
            Return AppForms.Courses
        End Try
        Return AppForms.Main
    End Function
End Class

Public Enum AppForms
    UserInfo
    Courses
    Main
End Enum
