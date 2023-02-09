Imports System

Module Program
'our word: water
    Sub Main(args As String())
        Console.WriteLine("Hello World! Prepare to play hangman!")
        'idea: 1 letter per string, can + strings
        'start as all #####
        dim l1 as String = "#"
        dim l2 as String = "#"
        dim l3 as String = "#"
        dim l4 as String = "#"
        dim l5 as String = "#"

        dim ourWord as String = "water"
        dim guessWord as String = "#####"

        'chances
        dim chance as Integer = 6

        Console.Writeline("Current Word: " + l1 + l2 + l3 + l4 + l5)

        dim guess as String

        While chance > 0

        Console.WriteLine("Please guess a letter.")
        guess = Console.ReadLine()
        Console.WriteLine("Your letter is: " + guess)



        Select case guess
            case "w"
                l1 = "w"
                Console.WriteLine("Congragulations!")
                Console.Writeline("Current Word: " + l1 + l2 + l3 + l4 + l5)
            case "a"
                l2 = "a"
                Console.WriteLine("Congragulations!")
                Console.Writeline("Current Word: " + l1 + l2 + l3 + l4 + l5)
            case "t"
                l3 = "t"
                Console.WriteLine("Congragulations!")
                Console.Writeline("Current Word: " + l1 + l2 + l3 + l4 + l5)
            case "e"
                l4 = "e"
                Console.WriteLine("Congragulations!")
                Console.Writeline("Current Word: " + l1 + l2 + l3 + l4 + l5)
            case "r"
                l5 = "r"
                Console.WriteLine("Congragulations!")
                Console.Writeline("Current Word: " + l1 + l2 + l3 + l4 + l5)
            case else
                chance = chance - 1
                '& means I do not need to change chance
                Console.WriteLine("Sorry, " & chance & " chances left.")

        End Select

        guessWord = l1+l2+l3+l4+l5
        'checked, matching works
        'dim guessWord as String = "water"
        'Console.WriteLine("Our word: " + ourWord)
       ' Console.WriteLine("Guess word: " + guessWord)
        'Console.Writeline("Match? " & ourWord.Equals(guessWord))

        If ourWord.Equals(guessWord) Then
            Console.WriteLine("It matches!")
            Exit While
        End if



        End While

        Console.Writeline("Match? " & ourWord.Equals(guessWord))




    End Sub
End Module
