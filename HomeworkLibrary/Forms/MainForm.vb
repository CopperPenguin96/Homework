Imports System.Windows.Forms
Imports HomeworkLibrary.Assignments
Imports HomeworkLibrary.Users

Namespace Forms
    Public Class MainForm
        Dim _isClosed As Boolean = False

        Private Sub MoveNav()
            Select Case _isClosed
                Case False
                    Do Until flpPanel.Right <= 0
                        flpPanel.Left -= 1
                    Loop
                    btnMoveNavigation.Text = ">>"
                    btnMoveNavigation.Left = 0
                    _isClosed = True
                    Return
                Case True
                    Do Until flpPanel.Left = _panelLocation
                        flpPanel.Left += 1
                    Loop
                    btnMoveNavigation.Text = "<<"
                    btnMoveNavigation.Left = _buttonLocation
                    _isClosed = False
                    Return
            End Select
        End Sub
        Dim _panelLocation As Integer
        Dim _buttonLocation As Integer
        Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            _panelLocation = flpPanel.Left
            _buttonLocation = btnMoveNavigation.Left
            MoveNav()

            ' Study tips
            Dim listToUse = StudyTips.RandomTips()
            lblTip1.Text = listToUse.ElementAt(0)
            lblTip2.Text = listToUse.ElementAt(1)
            lblTip3.Text = listToUse.ElementAt(2)

            ' User Info
            lblName.Text = lblName.Text & " " & User.AppUser.Name
            lblAge.Text = lblAge.Text & " " & User.AppUser.Age
            lblGrade.Text = lblGrade.Text & " " & User.AppUser.GradeLevel

            ' Courses
            Course.LoadCourses()
            For Each c In Course.ClassList
                listCourses.Items.Add(c.Name)
            Next
        End Sub


        Private Sub btnMoveNavigation_Click_2(sender As Object, e As EventArgs) Handles btnMoveNavigation.Click
            MoveNav()
        End Sub

        Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
            Application.Exit()
        End Sub

        Private Sub MainForm_Click(sender As Object, e As EventArgs) Handles Me.Click
            If Not _isClosed Then MoveNav()
        End Sub

        Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
            Dim addForm As New AssignmentTypeSelection(Method.Add)
            addForm.ShowDialog()
        End Sub

        Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
            MsgBox("This feature is currently under development.", MsgBoxStyle.Information, "Coming Soon...")
        End Sub
    End Class
End Namespace