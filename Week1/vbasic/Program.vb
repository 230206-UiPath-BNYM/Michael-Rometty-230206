Imports System
'Something else to note: vb has not grouping symtols like cur;
' that define the scope of a code block, instead, it relies on,
' also, tabbing fro documentation purposes
' vb.net doesn't use semi colons, you get an error if you end with a semicolon


Module Program
    Sub Main(args As String())
   '     Console.WriteLine("Hello World!")
    ' variables - hold data, reference in memory    
    ' with VB, we create variables using the dim keyword,
    ' using dim, the syntax is dim name of var as datatype

    'The greeter function returns a string that we are passing to the 
    ' greeting variable
        dim greeting as String = greeter("casual")
        Console.WriteLine(greeting)
    '    GuessingGame(2)
    '    Counter(3)
        GuessingGameV2()
    End Sub

    ' You set the datatype with the "as" keyworkd
    function greeter(greeting_type as String) As String
        ' flow control statements, used to channel logic based on crertain
        ' conditions

        ' Select case AKA switch
        Select Case greeting_type
            Case "casual"
                return "'sup"
            Case "busingess casual"
                return "saluations!"
            Case "full business"
                Return "to whom it may concern"
            Case else 
                Return "Hello"
        End Select
    End Function


    sub GuessingGame( guess as Integer )
        ' We will use the random class to generate a random number
        dim rnd as Random = new Random()
        dim mystryNumber as integer = rnd.next( 1, 2 )

        ' We use <> to represent non equality (not !=)
        if( guess <> mystryNumber) Then 
            Console.WriteLine("Wrong guess :< the correct number was" )
            Console.WriteLine(mystryNumber)            
        else
            Console.WriteLine("Good Guess the number is " )    
            Console.WriteLine(mystryNumber)
        end if

    end Sub 

    Sub Counter( stopping_point as Integer )

        dim start as integer = 0

         Console.WriteLine( "" )

        While start < stopping_point
            Console.WriteLine(start)
            start = start + 1
        end While 

         Console.WriteLine( "" )

        for index as integer = 0 to stopping_point
            Console.WriteLine( index )
        Next


    End Sub

    Sub GuessingGameV2()
        
        dim rnd as Random = new Random()
        dim mysteryNumber as integer = rnd.Next(1, 100)
        console.WriteLine("Entger Guess: ")

        dim guess as String = Console.ReadLine()

'        Try
         dim guessNum as integer = Integer.Parse(guess)    
 '       Catch ex as Exception
  '          Console.WriteLine("Invalid imput, try again")
   '     End try    

'        dim guessNum as integer = Integer.Parse(guess)

        while guessNum <> mysteryNumber

            if guessNum < mysteryNumber Then
                Console.WriteLine("Too Low")
            Else
                Console.WriteLine("Too High")
            end if

            Console.WriteLine("Enter guess: ")
            guess = Console.ReadLine()

        Try
            guessNum = Integer.Parse(guess)            
        Catch ex as Exception
            Console.WriteLine("Invalid imput, try again")
        End try    


        End While 

        Console.WriteLine("Congratulations! You guessed Correctly")

    End Sub
    
End Module
