Imports HWLib
Public Class AddTypeForm
    Public Sub New(aType As Objects.Assignments.AssignmentTypes)
        InitializeComponent()
        Me.Text = "Add " & aType.ToString()

        Select Case aType
            Case Objects.Assignments.AssignmentTypes.Assignment
                picType.Image = Image.FromFile(AssignmentURL)
            Case Objects.Assignments.AssignmentTypes.Final
                picType.Image = Image.FromFile(FinalURL)
            Case Objects.Assignments.AssignmentTypes.Homework
                picType.Image = Image.FromFile(HomeworkURL)
            Case Objects.Assignments.AssignmentTypes.Project
                picType.Image = Image.FromFile(ProjectURL)
            Case Objects.Assignments.AssignmentTypes.Quiz
                picType.Image = Image.FromFile(QuizURL)
            Case Objects.Assignments.AssignmentTypes.Test
                picType.Image = Image.FromFile(TestURL)
        End Select
    End Sub
    Dim AssignmentURL As String = "http://homeworkcalendar.weebly.com/uploads/3/8/7/5/38754049/2265145_orig.png"
    Dim HomeworkURL As String = "http://homeworkcalendar.weebly.com/uploads/3/8/7/5/38754049/9208837_orig.png"
    Dim FinalURL As String = "http://homeworkcalendar.weebly.com/uploads/3/8/7/5/38754049/2643554_orig.png"
    Dim QuizURL As String = "http://homeworkcalendar.weebly.com/uploads/3/8/7/5/38754049/5869833_orig.png"
    Dim TestURL As String = "http://homeworkcalendar.weebly.com/uploads/3/8/7/5/38754049/9449883_orig.png"
    Dim ProjectURL As String = "http://homeworkcalendar.weebly.com/uploads/3/8/7/5/38754049/4110745_orig.png"
    Private Sub AddTypeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class