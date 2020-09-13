
'Luis Torres
'RCET0265
'Fall 2020
'Simple Calculator
'https://github.com/LuisTorres0419/SimpleCalculator.git
Option Strict On
Option Explicit On
Option Compare Text

Module SimpleCalculator

    Sub Main()
        Dim userInput1, userInput2, userRespons As String
        Dim firstNumber, seconNumber As Integer
        Dim betterData As Boolean
        Do
            Console.WriteLine("press q to Quit")

            Do

                Try

                    Console.WriteLine("give me the number.")
                    userInput1 = Console.ReadLine()
                    firstNumber = CInt(userInput1)
                    Console.WriteLine("give secon num")
                    userInput2 = Console.ReadLine()
                    seconNumber = CInt(userInput2)
                    betterData = True
                Catch ex As Exception
                    Console.WriteLine("numbers!!!!! you give me bad numbers!!! ")
                    betterData = False

                    If userInput1 = "q" Or userInput2 = "q" Then

                        Exit Sub

                    End If

                End Try
            Loop Until betterData = True
            Console.Clear()
            Do

                Console.WriteLine(" Do you Add or Multiply? ")
                userRespons = Console.ReadLine()

                If userRespons = "Add" Or userRespons = "+" Then

                    Console.WriteLine("You entered: " & firstNumber & " + " & seconNumber & " that = " &
                                      firstNumber + seconNumber)

                ElseIf userInput1 = "q" Or userInput2 = "q" Then

                    Exit Sub

                ElseIf userRespons = "multiply" Or userRespons = "*" Then

                    Console.WriteLine("You entered: " & firstNumber & " * " & seconNumber & " that = " &
                                      firstNumber * seconNumber)

                Else ' Else covers anything that didn't evaluate True above - TJR
                    Console.WriteLine("Big wrong try again!")
                End If
            Loop Until userRespons = "multiply" Or userRespons = "*" Or userRespons = "Add" Or userRespons = "+"
            Console.ReadLine()
            Console.Clear()
        Loop

    End Sub

End Module
