Imports System.IO
Imports HomeworkLibrary.hSystem
Imports Newtonsoft.Json

Namespace Users
    Public Class User
        Public Name As String
        Public Age As Short
        Public GradeLevel As Short
        Public ClassCount As Short

        Public Shared AppUser As User

        Public Overrides Function ToString() As String
            Return JsonConvert.SerializeObject(Me)
        End Function

        Public Shared Function GetUser() As User
            Using r = New StreamReader(Settings.ApplicationDirectory + "userInfo.json")
                Return JsonConvert.DeserializeObject(Of User)(r.ReadToEnd())
            End Using
        End Function
        Public XError As String
        ''' <summary>
        ''' Saves the User Information
        ''' </summary>
        ''' <returns>Returns True/False, whether the sub worked</returns>
        ''' <remarks>If any exceptions are fired, this will return false</remarks>
        Public Function Save() As Boolean
            Try
                Dim filePath = Settings.ApplicationDirectory + "userInfo.json"
                If Not Directory.Exists("Homework/") Then
                    Directory.CreateDirectory("Homework/")
                End If
                Dim fileWriter = File.CreateText(filePath)
                fileWriter.Write(ToString())
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