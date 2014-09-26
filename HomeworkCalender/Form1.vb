Imports HWLib
Imports HWLib.User

Public Class Form1
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If txtUsername.Text.Length < getMin("Username") OrElse txtUsername.Text.Length > getMax("Username") Then
            lblUserName.ForeColor = Color.Red
        Else
            lblUserName.ForeColor = Color.Black
        End If
    End Sub

    Function getMin(type As String) As Integer
        Dim typeLower As String = type.ToLower()
        If typeLower.Equals("username") Then
            Return 6
        ElseIf typeLower.Equals("age") Then
            Return 13
        ElseIf type.ToLower.Equals("class") Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Function getMax(type As String) As Integer
        Dim typeLower As String = type.ToLower()
        If typeLower.Equals("username") Then
            Return 15
        ElseIf typeLower.Equals("age") Then
            Return 150
        ElseIf type.ToLower.Equals("class") Then
            Return 15
        Else
            Return 0
        End If
    End Function

    Private Sub txtAge_TextChanged(sender As Object, e As EventArgs) Handles txtAge.TextChanged
        lblAge.ForeColor = Color.Black
        Try
            Dim ageEntered As Integer = txtAge.Text
            If ageEntered < getMin("age") OrElse ageEntered > getMax("age") Then
                lblAge.ForeColor = Color.Red
            Else
                lblAge.ForeColor = Color.Black
            End If
        Catch ex As Exception
            lblAge.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub txtClassCount_TextChanged(sender As Object, e As EventArgs) Handles txtClassCount.TextChanged
        lblClassCount.ForeColor = Color.Black
        Try
            Dim countEntered As Integer = txtClassCount.Text
            If countEntered < getMin("class") OrElse countEntered > getMax("class") Then
                lblClassCount.ForeColor = Color.Red
            Else
                lblClassCount.ForeColor = Color.Black
            End If
        Catch ex As Exception
            lblClassCount.ForeColor = Color.Red
        End Try
    End Sub
    Dim strMsgBox As String = "You need to fix the following errors: " + (Chr(13))
    Friend Const strFinal As String = "You need to fix the following errors: " + (Chr(13))
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim intResponses() As Integer = Nothing
        Try
            intResponses = {txtUsername.Text.Length, txtAge.Text, txtClassCount.Text}
        Catch ex As InvalidCastException
            strMsgBox += (Chr(13)) + "Values cannot be empty or number values can only have numbers"
        Finally
            Try
                If intResponses(0) < getMin("username") Then
                    strMsgBox += (Chr(13)) + "Username must be at least 6 characters"
                ElseIf intResponses(0) > getMax("username") Then
                    strMsgBox += (Chr(13)) + "Username must be less than 15 characters"
                End If
                If intResponses(1) < getMin("age") Then
                    strMsgBox += (Chr(13)) + "You must be at least 13 to use this application"
                ElseIf intResponses(1) > getMax("age") Then
                    strMsgBox += (Chr(13)) + "Come on! You can't seriously be that old!"
                End If
                If intResponses(2) < getMin("class") Then
                    strMsgBox += (Chr(13)) + "You need at least 1 class"
                ElseIf intResponses(2) > getMax("class") Then
                    strMsgBox += (Chr(13)) + "You cannot have more than 15 classes in our system. Sorry."
                End If
            Catch exc As NullReferenceException
                'Do nothing
                'Just to prevent nullreferences
            End Try
        End Try
        If strMsgBox.Equals(strFinal) Then
            Dim ui As UserObj = New UserObj()
            ui.userName = Me.txtUsername.Text
            ui.age = Short.Parse(Me.txtAge.Text)
            ui.classCount = Short.Parse(Me.txtClassCount.Text)
            User.JSON.writeUserInfoJson(ui)
            COurses.Show() 'Pardon the COurses.vb Goof up. I don't want to mess with it
        Else
            MsgBox(strMsgBox) 'There had to be errors. They need to fix them
            strMsgBox = strFinal 'Resets so the same errors don't repeat themselves
        End If
    End Sub
End Class
