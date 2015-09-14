Public Class StudyTips
    Private Shared Function _studyTipList() As List(Of String)
        Return {"Clear all distractions. Less destractions means more focus on our work.",
            "Read the text completely and multiple times. You might miss something.",
            "Try turning on some music while studying. It could help you focus.",
            "Don't spead through a problem. Figure it out. If it takes too long, skip it and come back to it",
            "Keep a dictionary on you when studying. You might come across a word you don't know that you need to know.",
            "Don't use the internet to study unless your instructor/teacher gives you a good website.",
            "Takes notes when studying.",
            "Study what is hard and challenege yourself on what is easy.",
            "Study with a friend. Other insights on the same subject help increase knowledge.",
            "Do your homework. Homework is vitally important.",
            "Test yourself. Test your knowledge.",
            "Stretch. Rest. Don't stress out too much.",
            "Don't drink coffee or cafinated products. It will cause a crash which is not healthy for your brain.",
            "Study with a teacher. They have good insight"}.ToList()
    End Function


    Public Shared Function RandomTips() As List(Of String)
        Dim rnd As New Random()
        Dim max As Integer = _studyTipList.Count
        Dim listOfString As New List(Of String)
        Dim firstItem As Integer = rnd.Next(0, max)
        Dim secitem As Integer = rnd.Next(0, max)
        Do Until Not secitem = firstItem
            secitem = rnd.Next(0, max)
        Loop
        Dim thirdItem As Integer = rnd.Next(0, max)
        Do Until Not firstItem = thirdItem OrElse Not secitem = thirdItem
            thirdItem = rnd.Next(0, max)
        Loop
        Dim list As List(Of Integer) = {firstItem, secitem, thirdItem}.ToList()
        For x = 0 To 2
            listOfString.Add(_studyTipList.ElementAt(list.ElementAt(x)))
        Next
        Return listOfString
    End Function
End Class
