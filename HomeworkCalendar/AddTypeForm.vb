Imports HWLib
Imports HWLib.Objects.Assignments
Imports System.IO

Public Class AddTypeForm
    Dim aa As AssignmentTypes
    Dim todaysDate As Objects.DueDate
    Public Sub New(aType As Objects.Assignments.AssignmentTypes)
        InitializeComponent()
        aa = aType
        Me.Text = "Add " & aType.ToString()
        ImageE()
        todaysDate = Objects.DueDate.parseDueDate(Calendar.SelectionRange.ToString.Substring(23, 33).Substring(0, 10))
    End Sub
    Sub ImageE()
        'WEB CLIENT IS NEEDED TO DO THE DOWNLOAD
        Dim MyWebClient As New System.Net.WebClient

        'BYTE ARRAY HOLDS THE DATA
        Dim ImageInBytes() As Byte = MyWebClient.DownloadData(URLString(aa))

        'CREATE A MEMORY STREAM USING THE BYTES
        Dim ImageStream As New IO.MemoryStream(ImageInBytes)

        'CREATE A BITMAP FROM THE MEMORY STREAM
        picType.Image = New System.Drawing.Bitmap(ImageStream)

        'AS U SEE, NO FILE NEEDS TO BE WRITTEN TO THE HARD DRIVE, ITS ALL DONE IN MEMORY
    End Sub
    Function URLString(x As AssignmentTypes)
        Select Case x
            Case AssignmentTypes.Assignment
                Return "http://homeworkcalendar.weebly.com/uploads/3/8/7/5/38754049/2265145_orig.png"
            Case AssignmentTypes.Homework
                Return "http://homeworkcalendar.weebly.com/uploads/3/8/7/5/38754049/9208837_orig.png"
            Case AssignmentTypes.Final
                Return "http://homeworkcalendar.weebly.com/uploads/3/8/7/5/38754049/2643554_orig.png"
            Case AssignmentTypes.Quiz
                Return "http://homeworkcalendar.weebly.com/uploads/3/8/7/5/38754049/5869833_orig.png"
            Case AssignmentTypes.Test
                Return "http://homeworkcalendar.weebly.com/uploads/3/8/7/5/38754049/9449883_orig.png"
            Case AssignmentTypes.Project
                Return "http://homeworkcalendar.weebly.com/uploads/3/8/7/5/38754049/4110745_orig.png"
            Case Else
                Return Nothing
        End Select
    End Function

    Private Sub numPoints_ValueChanged(sender As Object, e As EventArgs) Handles numPoints.ValueChanged
        If numPoints.Value < 1 Then
            numPoints.Value = 1
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If HasErrors() Then
            MsgBox(errors)
            errors = errors2
        Else
            ' Save Content to Appropiate File Type and Directory
            sDate = Objects.DueDate.parseDueDate(Calendar.SelectionRange.ToString.Substring(23, 33).Substring(0, 10))
            Select Case aa
                Case AssignmentTypes.Assignment
                    Dim assignment As New Assignment(IDGenerator.getRandomID(Base.Assignment), txtName.Text, _
                                                     sDate, numPoints.Value, chkBalloon.Checked)
                    assignment.Save()
                Case AssignmentTypes.Final
                    Dim final As New Final(IDGenerator.getRandomID(Base.Final), txtName.Text, _
                                           sDate, numPoints.Value, chkBalloon.Checked)
                    final.Save()
                Case AssignmentTypes.Homework
                    Dim homework As New Homework(IDGenerator.getRandomID(Base.Homework), txtName.Text, _
                                                 sDate, numPoints.Value, chkBalloon.Checked)
                    homework.Save()
                Case AssignmentTypes.Project
                    Dim project As New Project(IDGenerator.getRandomID(Base.Project), txtName.Text, _
                                               sDate, numPoints.Value, chkBalloon.Checked)
                    project.Save()
                Case AssignmentTypes.Quiz
                    Dim quiz As New Quiz(IDGenerator.getRandomID(Base.Quiz), txtName.Text, _
                                         sDate, numPoints.Value, chkBalloon.Checked)
                    quiz.Save()
                Case AssignmentTypes.Test
                    Dim test As New Test(IDGenerator.getRandomID(Base.Test), txtName.Text, _
                                         sDate, numPoints.Value, chkBalloon.Checked)
                    test.Save()
            End Select
        End If
    End Sub
    Dim sDate As Objects.DueDate = New Objects.DueDate()
    Dim errors As String = "You need to fix the following errors: " & (Chr(13)) & (Chr(13))
    Const errors2 As String = "You need to fix the following errors: " & (Chr(13)) & (Chr(13))
    Function HasErrors() As Boolean
        Try
            Dim x As String = txtName.Text
        Catch ex As Exception
            errors += "Name cannot be null!" & (Chr(13))
        End Try
        If numPoints.Value < 1 Then
            errors += "Point value needs to be at least 1" & (Chr(13))
        End If
        Dim selectedDate As Objects.DueDate = _
            Objects.DueDate.parseDueDate(Calendar.SelectionRange.ToString.Substring(23, 33).Substring(0, 10))
        If selectedDate.month = todaysDate.month AndAlso selectedDate.day = todaysDate.day AndAlso _
            selectedDate.year = todaysDate.year Then
            errors += "You need to select a date that is not today!" & (Chr(13))
        End If
        If todaysDate.year <> 2014 Then
            errors += "Only 2014 dates are supported" & (Chr(13))
        Else
            If todaysDate.month > selectedDate.month Then
                errors += "Select a date that is not in the past!" & (Chr(13))
            Else
                If todaysDate.month = selectedDate.month Then
                    If todaysDate.day > selectedDate.day Then
                        errors += "Select a date that is not in the past!" & (Chr(13))
                    End If
                End If
            End If
        End If
        If Not errors.Equals(errors2) Then
            Return True ' There were errors
        Else
            Return False ' There were no errors
        End If
    End Function

    Private Sub InvalidCharacters_Tick(sender As Object, e As EventArgs) Handles InvalidCharacters.Tick
        txtName.Text = System.Text.RegularExpressions.Regex.Replace(txtName.Text, "[^a-zA-Z0-9]", " ")
    End Sub
End Class