Imports HWLib.Objects
Imports HWLib.JSON

Public Class CourseForm
    Sub assignTextBoxes(isStart As Boolean)
        If isStart Then
            txtArray(1) = TextBox1
            txtArray(2) = TextBox2
            txtArray(3) = TextBox3
            txtArray(4) = TextBox4
            txtArray(5) = TextBox5
            txtArray(6) = TextBox6
            txtArray(7) = TextBox7
            txtArray(8) = TextBox8
            txtArray(9) = TextBox9
            txtArray(10) = TextBox10
            txtArray(11) = TextBox11
            txtArray(12) = TextBox12
            txtArray(13) = TextBox13
            txtArray(14) = TextBox14
            txtArray(15) = TextBox15
        Else
            TextBox1 = txtArray(1)
            TextBox2 = txtArray(2)
            TextBox3 = txtArray(3)
            TextBox4 = txtArray(4)
            TextBox5 = txtArray(5)
            TextBox6 = txtArray(6)
            TextBox7 = txtArray(7)
            TextBox8 = txtArray(8)
            TextBox9 = txtArray(9)
            TextBox10 = txtArray(10)
            TextBox11 = txtArray(11)
            TextBox12 = txtArray(12)
            TextBox13 = txtArray(13)
            TextBox14 = txtArray(14)
            TextBox15 = txtArray(15)
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim clearText As String = btnClear.Text
        Dim submitText As String = btnFinish.Text
        For Each ctrl As Control In Me.Controls
            ctrl.Text = String.Empty
        Next
        btnClear.Text = clearText
        btnFinish.Text = submitText
    End Sub
    Dim txtArray(15) As TextBox
    Private Sub CourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        assignTextBoxes(True)
        UserInfoForm.Close()
        Dim uInfo As UserInfo = UserInfoReader.uInfo()
        For intLoop As Integer = 1 To 15
            If isAquired(intLoop, uInfo) Then
                txtArray(intLoop).Enabled = True
            Else
                txtArray(intLoop).Enabled = False
            End If
        Next
        assignTextBoxes(False)
    End Sub

    Function isAquired(intAlloc As Integer, ui As UserInfo)
        If (intAlloc < ui.classCount + 1) Then
            Return True
        Else
            Return False
        End If
    End Function
    Dim uuInfo As UserInfo = UserInfoReader.uInfo()
    Dim courses(uuInfo.classCount) As Course
    Dim strClasses(uuInfo.classCount) As String
    Dim isShown As Boolean = False
    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        For x = 1 To uuInfo.classCount
            courses(x) = New Course()
        Next
        assignTextBoxes(False)
        For loopCount = 1 To uuInfo.classCount
            Randomize()
            Dim intRandom As Integer = Int(Rnd() * (uuInfo.age) * 3) + (5 * (uuInfo.age) * 3) 'Generates Random ID
            Try
                strClasses(loopCount) = txtArray(loopCount).Text
                courses(loopCount).ID = Short.Parse(intRandom)
                courses(loopCount).name = strClasses(loopCount)
                courses(loopCount).tabOrder = loopCount
            Catch ex As NullReferenceException
                If Not isShown Then
                    MsgBox("You need to fill in all enabled course spaces!")
                    isShown = True
                End If
            Catch ex2 As IndexOutOfRangeException
                'Safe!
            Finally
                CourseWriter.write(courses)
                MainForm.Show()
            End Try
        Next

    End Sub
End Class