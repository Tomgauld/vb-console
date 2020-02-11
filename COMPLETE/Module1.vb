Module Module1
    Dim name As String
    Sub Main()
        'Sub main is where the user name is stored and is refered back to in each subprograms.'
        Console.ForegroundColor = ConsoleColor.Red
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Hello, what is your name?")
        name = Console.ReadLine()
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Hello " & name)
        Menu()
        Console.ReadLine()
    End Sub
    Sub Menu()
        Dim number As Integer
        'This is the Main Menu of the entire program and is refered back to in each subprogram.'
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("Welcome to the main menu.")
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Please enter whatever number it is that you would like to go to.")
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Or ask me a question of your choosing.")
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine()
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("(1) Maths test.")
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("(2) English test.")
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("(3) Computing test.")
        Console.WriteLine()
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("(4) Calculator")
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("(5) Higher or lower.")
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("(6) Current Projects.")
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("(7) Numbers mash.")
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("(8) Letter check.")
        Console.WriteLine()
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("(9) Quit.")
        number = Console.ReadLine()
        If number = "1" Then
            Maths()
        ElseIf number = "2" Then
            English()
        ElseIf number = "3" Then
            Computing()
        ElseIf number = "4" Then
            Calculator()
        ElseIf number = "5" Then
            HOL()
        ElseIf number = "6" Then
            Projects()
        ElseIf number = "7" Then
            Numbersmash()
        ElseIf number = "8" Then
            Quit()
        End If
        Console.ReadLine()
    End Sub
    Sub Maths()
        Dim count As Integer
        'This is a simple Maths Quiz subprogram.'
        count = 0
        Console.ForegroundColor = ConsoleColor.Yellow
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Hello " & name & " and welcome to the Maths test.")
        Console.WriteLine()
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("What is 30-2*7")
        If Console.ReadLine = "16" Then
            Console.WriteLine("Well done, that is correct.")
            count += 1
        Else
            Console.WriteLine("That is incorrect.")
        End If
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Next, What is 25*6?")
        If Console.ReadLine = "150" Then
            Console.WriteLine("Well done, that is correct.")
            count += 1
        Else
            Console.WriteLine("That is incorrect")
        End If
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Next, what is 15*6 + (3+10)")
        If Console.ReadLine = "103" Then
            Console.WriteLine("Well done, that is correct.")
            count += 1
        Else
            Console.WriteLine("That is incorrect.")
        End If
        If count = 3 Then
            Console.WriteLine("Well done! You got all of them right!")
        End If
        If count < 3 Then
            Console.WriteLine("You got: " & count & " right.")
        End If
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Would you like to go back to menu or quit?")
        If Console.ReadLine = "menu" Then
            Menu()
        End If
        Console.ReadLine()
    End Sub
    Sub English()
        Dim count As Integer
        'This is a simple English Quiz subprogram.'
        count = 0
        Console.ForegroundColor = ConsoleColor.White
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Hello " & name & " and welcome to the English test.")
        Console.WriteLine()
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("What is the name of the main character in 'A Christmas Carol'")
        If Console.ReadLine = "scrooge" Then
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Well done, that is correct.")
            count += 1
        Else
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("That is incorrect.")
        End If
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Next, in 'An Inspector Calls' what is the name of the inspector?")
        If Console.ReadLine = "inspector goole" Then
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Well done, that is correct.")
            count += 1
        Else
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("That is incorrect")
        End If
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Next, name all of the Ghosts of Christmas, in order of past, p and f")
        If Console.ReadLine = "past present future" Then
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Well done, that is correct.")
            count += 1
        Else
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("That is incorrect.")
        End If
        If count = 3 Then
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Well done! You got all of them right!")
        End If
        If count < 3 Then
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("You got: " & count & "right.")
        End If
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Would you like to go back to menu or quit?")
        If Console.ReadLine = "menu" Then
            Menu()
        End If
        Console.ReadLine()
    End Sub
    Sub Computing()
        'This is a simple Computing Quiz Subprogram.'
        Dim count As Integer
        count = 0
        Console.ForegroundColor = ConsoleColor.White
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Hello " & name & " and welcome to the Computing test.")
        Console.WriteLine()
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("What is the name of the two search algorithms, starting with (b)?")
        If Console.ReadLine = "binary and linear" Then
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Well done, that is correct.")
            count += 1
        Else
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("That is incorrect.")
        End If
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Next, in binary what are the only two numbers used starting from lowest?")
        If Console.ReadLine = "0 and 1" Then
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Well done, that is correct.")
            count += 1
        Else
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("That is incorrect")
        End If
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Next, how many gigabytes are in a terabyte?")
        If Console.ReadLine = "1000" Then
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Well done, that is correct.")
            count += 1
        Else
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("That is incorrect.")
        End If
        If count = 3 Then
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Well done! You got all of them right!")
        End If
        If count < 3 Then
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("You got: " & count & "right.")
        End If
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Would you like to go back to menu or quit?")
        If Console.ReadLine = "menu" Then
            Menu()
        End If
        Console.ReadLine()
    End Sub
    Sub Calculator()
        Dim first As Integer
        Dim second As Integer
        Dim choice As String
        'This subprogram is a Calculator that is user friendly and has a span of either Division, Subtraction, Multiplication or Addition.'
        Console.WriteLine("Hello " & name & " and welcome to the Calculator")
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Times, divide, subtraction, addition, menu or quit?")
        choice = Console.ReadLine
        If choice = "times" Then
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Okay, what would you like to times?")
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Enter first number:")
            first = Console.ReadLine()
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Enter second number:")
            second = Console.ReadLine
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Your answer is:" & first * second)
            Calculator()
        End If
        If choice = "divide" Then
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Okay, what would you like to divide?")
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Enter first number:")
            first = Console.ReadLine()
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Enter second number:")
            second = Console.ReadLine
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Your answer is:" & first / second)
            Calculator()
        End If
        If choice = "subtraction" Then
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Okay, what would you like to subtract?")
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Enter first number:")
            first = Console.ReadLine()
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Enter second number:")
            second = Console.ReadLine
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Your answer is:" & first - second)
            Calculator()
        End If
        If choice = "addition" Then
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Okay, what would you like to add?")
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Enter first number:")
            first = Console.ReadLine()
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Enter second number:")
            second = Console.ReadLine
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Your answer is:" & first + second)
            Calculator()
        End If
        If choice = "menu" Then
            Menu()
        End If
        If choice = "quit" Then
            Quit()
        End If
        Console.ReadLine()
    End Sub
    Sub HOL()
        'A simple higher or lower game 
        Dim number, number1, number2, count As Integer
        Dim goagain As String
        Console.ForegroundColor = ConsoleColor.Green
        count = 0
        While count = 0
            Console.WriteLine("Please enter a number.")
        number = Console.ReadLine
        Console.WriteLine("Please enter another number.")
        number1 = Console.ReadLine
        Console.WriteLine("Please enter one last number")
        number2 = Console.ReadLine
            If number > number1 And number2 Then
                Console.WriteLine("Your 1st number is bigger than your 2nd and 3rd")
            ElseIf number < number1 And number2 Then
                Console.WriteLine("Your 1st number is smaller than your 2nd and 3rd")
            ElseIf number2 < number And number1 Then
                Console.WriteLine("Your 3rd number is smaller than your 1st and 2nd")
            ElseIf number2 > number And number1 Then
                Console.WriteLine("Your 3rd number is bigger than your 1st and 2nd")
            ElseIf number1 > number And number2 Then
                Console.WriteLine("Your 2nd number is bigger than your 1st and 3rd")
            ElseIf number1 < number And number2 Then
                Console.WriteLine("Your 2nd number is smaller than your 1st and 3rd")
            End If
            Console.WriteLine("Go again? (Y/N)")
            goagain = Console.ReadLine
            If goagain = "y" Then
                count = 0
            ElseIf goagain = "n" Then
                count = 1
                Menu()
            End If
        End While
        Console.ReadLine()
    End Sub
    Sub Numbersmash()
        Dim choice As String
        Dim count As Integer
        count = 0
        'The Numbers Mash is a Sub program that lets the Console print out a series of numbers in a specific time table up to the number 5000.'
        'The user inputs the number and therefore the Console prints to the screen the numbers up to 5000.'
        Console.ForegroundColor = ConsoleColor.DarkGreen
        Console.WriteLine("Hello " & name & " and welcome to the Numbers Mash.")
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Your choices are:")
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("1, 2, 5 or 10")
        choice = Console.ReadLine
        If choice = "1" Then
            Do
                count += 1
                Console.WriteLine(count)
            Loop Until count = 5000
        ElseIf choice = "2" Then
            Do
                count += 2
                Console.WriteLine(count)
            Loop Until count = 5000
        ElseIf choice = "5" Then
            Do
                count += 5
                Console.WriteLine(count)
            Loop Until count = 5000
        ElseIf choice = "10" Then
            Do
                count += 10
                Console.WriteLine(count)
            Loop Until count = 5000
        End If
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Do you want to go back to the main menu?")
        If Console.ReadLine = "yes" Then
            Menu()
        Else
            Quit()
        End If
        Console.ReadLine()
    End Sub
    Sub Lettercheck()
        'WIP
        Dim mystring As String
        Dim stringlength As Integer
        Dim firstchar As Char
        Dim firstchar1 As Char
        Dim lastchar As Char
        Dim lastchar1 As Char
        Dim lastchar2 As Char
        Console.WriteLine("Please enter a sentence for me to")
        mystring = Console.ReadLine
        stringlength = Len(mystring)
        Console.WriteLine("There are " & stringlength & " characters in your text")
        firstchar = Left(mystring, 1)
        lastchar = Right(mystring, 1)
        Console.WriteLine("The first letter is " & firstchar)
        Console.WriteLine("The last letter is " & lastchar)
        firstchar1 = Left(mystring, 2)
        lastchar1 = Right(mystring, 2)
        Console.WriteLine("The second letter is " & firstchar1)
        Console.WriteLine("The second to last letter is " & lastchar1)
        lastchar2 = Right(mystring, 3)
        Console.WriteLine("The third to last letter is " & lastchar2)
        Console.ReadLine()
    End Sub
    Sub Projects()
        Dim backtomenu As String
        'The Sub Projects only show the current projects that Tom is working on, this can be accesed into the Console if need be.'
        Console.WriteLine("Hello " & name)
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Your current projects are:")
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Write the Higher or Lower Subprogram. (DONE)")
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Write the Computing quiz Subprogram.(DONE)")
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Write the numbers mash Subprogram(DONE)")
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Back to menu?")
        backtomenu = Console.ReadLine
        If backtomenu = "yes" Then
            Menu()
        Else
            Quit()
        End If
        Console.ReadLine()
    End Sub
    Sub Quit()
        'The Quit subprogram is fairly straight forward and is mainly used for other subprograms at the end of each one.'
        End
    End Sub
End Module
