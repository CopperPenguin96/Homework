Imports System.IO
Imports HomeworkLibrary.hSystem
Imports Newtonsoft.Json

Namespace Users
    Public Class Course
        Public Name As String
        Public Shared ClassList As List(Of Course)

        Public Shared Function ToJsonString() As String
            Return JsonConvert.SerializeObject(ClassList)
        End Function

        Public Shared Sub LoadCourses()
            ClassList = New List(Of Course)
            Try
                Dim filePath = Settings.ApplicationDirectory & "courses.json"
                Dim fileReader = File.ReadAllText(filePath)
                Dim jsonObject = TryCast(JsonConvert.DeserializeObject(fileReader), Course())
                For Each jsonObj In jsonObject
                    ClassList.Add(jsonObj)
                Next
            Catch ex As Exception
                ErrorLogging.Write(ex)
            End Try
        End Sub
        Private XError As String
        ''' <summary>
        ''' Saves the User Information
        ''' </summary>
        ''' <returns>Returns True/False, whether the sub worked</returns>
        ''' <remarks>If any exceptions are fired, this will return false</remarks>
        Public Shared Function Save() As Boolean
            Try
                Dim filePath = Settings.ApplicationDirectory + "courses.json"
                If Not Directory.Exists(Settings.ApplicationDirectory) Then
                    Directory.CreateDirectory(Settings.ApplicationDirectory)
                End If
                Dim fileWriter = File.CreateText(filePath)
                fileWriter.Write(ToJsonString())
                fileWriter.Flush()
                fileWriter.Close()
                Return True
            Catch ex As Exception
                ErrorLogging.Write(ex)
                Return False
            End Try
        End Function
    End Class
End Namespace