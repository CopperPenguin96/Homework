Imports System.IO

Namespace hSystem
    Public Class ErrorLogging
        Public Shared Sub Write(ex As Exception)
            Dim fileLines As New List(Of String)
            fileLines.Add("-----Homework Calendar Error Log-----" & vbNewLine)
            fileLines.Add(vbNewLine)
            fileLines.Add(ex.ToString())
            fileLines.Add(vbNewLine & vbNewLine)
            fileLines.Add(ex.StackTrace)
            fileLines.Add("Log wrote at " & Now.ToLongDateString())
            Dim writingPath = Settings.ApplicationDirectory & Now.ToLongDateString() & "." & Now.Hour & "." & Now.Minute & "." &
                                                          Now.Second & ".txt"
            Dim fWriter As StreamWriter = File.CreateText(writingPath)
            For Each f In fileLines
                fWriter.Write(f & vbNewLine)
            Next
            fWriter.Flush()
            fWriter.Close()
        End Sub
    End Class
End Namespace