Module Sleeper
    Public Sub sleep(seconds As Integer)
        Threading.Thread.Sleep(seconds * 1000)
    End Sub
End Module
