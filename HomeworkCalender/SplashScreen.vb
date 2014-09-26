Imports HWLib
Imports System.IO
Imports HWLib.Assignments
Public NotInheritable Class SplashScreen
    Dim currentFile As Integer = 0
    Dim needsUserInfo = False
    Dim needsCourses = False
    'Shows which File is being created to the User Before the Application Starts
    Private Sub FileTimer_Tick(sender As Object, e As EventArgs) Handles FileTimer.Tick
        If currentFile = 0 Then
            If Not Constants.exists(Constants.pathName) Then
                Directory.CreateDirectory(Constants.pathName)
                lblLoading.Text = "Creating New Directory " + Constants.pathName
                sleep(2)
                needsUserInfo = True
                needsCourses = True
            End If
            currentFile += 1
        ElseIf currentFile = 1 Then
            If Not Constants.exists(Constants.infoJSON) Then
                lblLoading.Text = "Creating New File " + Constants.infoJSON
                File.Create(Constants.infoJSON)
                sleep(2)
                needsUserInfo = True
                If Directory.Exists(Constants.coursePath) Then
                    Directory.Delete(Constants.coursePath)
                    needsCourses = True
                End If
            End If
            currentFile += 1
        ElseIf currentFile = 2 Then
            If Not Constants.exists(Constants.coursePath) Then
                Directory.CreateDirectory(Constants.coursePath)
                lblLoading.Text = "Creating New Directory " + Constants.coursePath
                sleep(2)
                needsCourses = True
            End If
            currentFile += 1
        ElseIf currentFile = 3 Then
            If Not Constants.exists(Constants.assignmentPath) Then
                Directory.CreateDirectory(Constants.assignmentPath)
                lblLoading.Text = "Creating New Directory " + Constants.assignmentPath
                sleep(2)
            End If
            currentFile += 1
        ElseIf currentFile = 4 Then
            lblLoading.Text = "All Main Application Files Loaded...... Application is starting...."
            sleep(5)
            currentFile += 1
        ElseIf currentFile = 5 OrElse currentFile <= 7 Then
            currentFile += 1
            If needsUserInfo Then
                Form1.Show()
            ElseIf needsCourses Then
                COurses.Show()
            Else
                MainForm.Show()
            End If
            Me.Hide()
        End If
    End Sub
End Class
