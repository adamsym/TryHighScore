Module Module1

    Dim PlayerName(10) As String
    Dim PlayerScore(10) As Integer


    Sub Main()

        readhighscores()

        OutputHighScores()

        Console.ReadLine()


        Console.WriteLine("enter username")
        PlayerName(10) = "ABCD"

        While PlayerName(10).Length <> 3
            PlayerName(10) = Console.ReadLine()
        End While

        PlayerScore(10) = -1

        While PlayerName(10) < 1 Or PlayerName(10) > 100000

            Console.WriteLine("enter score")
            PlayerScore(10) = Console.ReadLine

        End While



        Console.WriteLine("please input a score from 1 to 100000")
        PlayerScore(10) = Console.ReadLine


    End Sub

    Sub readhighscores()
        Dim Filereader As New System.IO.StreamReader("HighScore.txt")

        For counter = 0 To 9
            PlayerName(counter) = Filereader.ReadLine
            PlayerScore(counter) = Filereader.ReadLine
        Next

        Filereader.Close()
    End Sub

    Sub OutputHighScores()

        For counter = 1 To 10

            Console.WriteLine(PlayerName(counter) & " " & PlayerScore(counter))

        Next

    End Sub


    Sub arrange(name As String, score As Integer)
        Dim tempname1 As String
        Dim tempname2 As String
        Dim tempscore1 As Integer
        Dim tempscore2 As Integer

        For x = 0 To 9
            If score > scores(x, 1) Then
                tempname1 = scores(x, 0)
                tempscore1 = scores(x, 1)

                scores(x, 0) = name
                scores(x, 1) = score

                For x2 = x + 1 To 9

                    tempname2 = scores(x2, 0)
                    tempscore2 = scores(x2, 1)





                Next
            End If
        Next

    End Sub


End Module
