Imports HWLib
Imports HWLib.Objects.Assignments

Public Class AddTypeForm
    Dim aa As AssignmentTypes
    Public Sub New(aType As Objects.Assignments.AssignmentTypes)
        InitializeComponent()
        aa = aType
        Me.Text = "Add " & aType.ToString()
        ImageE()
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

    End Sub
End Class