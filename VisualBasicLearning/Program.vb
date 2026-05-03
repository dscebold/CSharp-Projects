Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Timers

Module Program
              
    
    
    
    Sub Program1()
        
        Console.WriteLine("Hello World!")
        Console.ReadLine()
        
    End Sub
    
    Sub Variables()
        
'        Dim x As Integer
'        Dim y as Integer
'        
'        x = 7
'        y = x + 3
'        
'        Console.WriteLine(y)
        
        Console.WriteLine("What is your name?")
        Console.Write("Type your first name: ")
        
        Dim myFirstName As String
        
        myFirstName = Console.ReadLine()
        
        Console.Write("Type your last name: ")
        
        Dim myLastName As String = Console.ReadLine()
        
        Console.WriteLine("Hello " & myFirstName & " " & myLastName)
        
        
    End Sub
    
    Sub Branching()
        
'        Console.WriteLine("Bobs Big Giveaway!")
'        
'        Console.Write("Would you prefere what is behind door number 1, 2, or 3? ")
'        
'        Dim userValue as String = Console.ReadLine()
'        
'        Dim message as String = ""
'        
'        If userValue = "1"
'            message = "You won a new car!"
'            
'        Else If userValue = "2"
'            message = "You won a new boat!"
'            
'        Else If userValue = "3"
'            message = "You won a new cat!"
'        
'        Else 
'            message = "You lose."
'            
'        End If
'        
'        Console.WriteLine(message)
        
        Console.WriteLine("Bobs Big Giveaway!")
        
        Console.Write("Would you prefere what is behind door number 1, 2, or 3? ")
        
        Dim userValue as String = Console.ReadLine()
        
        Dim message as String = IIf( userValue = "1", "Car", "Cat")
        
        
        Console.WriteLine("You won a {0}", message)
        
    End Sub
    
    
    Sub Loops()
        
        For index = 1 to 10
            Console.WriteLine(index)
            If index = 7 Then 
                Console.WriteLine("Found Seven!")
                Exit For
            End If
        Next
        
        For index = 13 to 3 Step -1
            Console.WriteLine(index)
        Next
        
        For index = 1 to 10 Step 2
            Console.WriteLine(index)
        Next
        
    End Sub
    
    Sub Arrays()
        
'        Dim number1 as Integer = 4
'        Dim number2 as Integer = 8
'        Dim number3 as Integer = 15
'        Dim number4 as Integer = 16
'        Dim number5 as Integer = 23
'        Dim number6 as Integer = 42
        
        Dim numbers(4) as Integer
        
        numbers(0) = 4
        numbers(1) = 8
        numbers(2) = 15
        numbers(3) = 16
        numbers(4) = 23
        
        
        Console.WriteLine("The third element of the array contains {0}", numbers(2))
        Console.WriteLine(numbers.Length)
        
        for index = 0 to numbers.Length - 1
            Console.WriteLine(numbers(index))
        Next
        
        
        Dim numbers2() as Integer = {4, 8, 15, 16, 23}
        
        for index = 0 to numbers2.Length - 1
            Console.WriteLine(numbers2(index))
        Next
        
        
        Dim names() as String = {"John", "Jane", "Jude", "Cardan"}
        
        For Each name in names
            Console.WriteLine(name)
        Next
        
        Dim myText as String = "You can have some very long lines of text " & _
                               "that can take up multiple lines"
        
        Dim charArray() as Char = myText.ToCharArray()
        
        Array.Reverse(charArray)
        
        for Each item in charArray
            Console.Write(item)
        Next
        
        
    End Sub
    
    
    Function GetReverseString(message as String) As String
        
        Dim messageArray as Char() = message.ToCharArray()
        Array.Reverse(messageArray)
        Return String.Concat(messageArray)
        
    End Function
    
    Sub ReverseString(ByRef message as String)
        
        Dim messageArray as Char() = message.ToCharArray()
        Array.Reverse(messageArray)
        message =  String.Concat(messageArray)
        
    End Sub
    
    
    Sub WhileLoops()
        
        Dim counter as Integer = 0 
        Dim userResponse as Boolean = True
        While(userResponse)
            counter = counter + 1
            Console.WriteLine("Code block has executed {0} times", counter)
            Console.Write("Continue? (Y or N?)")
            userResponse = IIf(Console.ReadLine() = "Y", True, False)
        End While
        
        Console.WriteLine("Finished.")
        
        Dim displayMenu as Boolean = True
        While(displayMenu)
            displayMenu = MainMenu()
        End While
        
    End Sub
    
    
    Function MainMenu() As Boolean
        Console.Clear()
        Console.WriteLine("Choose an option: ")
        Console.WriteLine("1 - Print Numbers")
        Console.WriteLine("2 - Guessing Game")
        Console.WriteLine("3 - Exit")
        
        Dim result as String = Console.ReadLine()
        
        
        If result = "1" Then
            Return PrintNumbers()
        ElseIf result = "2" Then 
            Return GuessingGame()
        ElseIf result = "3" Then
            Return False
        Else 
            Return True
        End If
        
    End Function
    
    Function PrintNumbers() As Boolean
        
        Console.Clear()
        Console.WriteLine("Type a number: ")
        Dim result as Integer = CInt(Console.ReadLine())
        Dim counter As Integer = 1
        
        While counter < result + 1
            Console.Write(counter)
            Console.Write("-")
            counter += 1
            
        End While
        
        Console.ReadLine()
        Return True
        
    End Function
    
    Function GuessingGame() As Boolean
        
        Console.Clear()
        Console.WriteLine("Type a number: ")
        
        Dim random as New Random()
        dim randomNumber as Integer = random.Next(1, 11)
        Dim guesses As Integer = 0
        Dim incorrect as Boolean = True
        
        
        Do While incorrect
            Console.Write("Guess a number between 1 and 10: ")
            Dim result as String = Console.ReadLine()
            guesses += 1
            If result = randomNumber.ToString()
                incorrect = False
            Else 
                Console.WriteLine("Wrong!")
            End If
        Loop
        
        Console.WriteLine("Correct! It took you {0} guesses.", guesses)
        Console.ReadLine()
        
        Return True
        
    End Function
    
    Sub Strings()
        
        dim myString as String = "My ""so called"" life"
        myString = "What if I need" & vblf & " a new line"
        myString = "What if I need" &vbTab & " a tab in my line"
        
        myString = String.Format("Hello {0}!", "Bob")
        myString = String.Format("Make: {0} -- Model: {1} -- Year: {2}", "BMW", "745li", 1995)
        myString = String.Format("{0:C}", 23.35)
        myString = String.Format("{0:N}", 1234567890)
        myString = String.Format("{0:P}", 0.123)
        myString = String.Format("Phone: {0:(###) ###-####}", 1234567890)
        
        
        dim myStringBuilder as new StringBuilder
        
        for index = 1 to 100
            myStringBuilder.Append(CStr(index))
            myStringBuilder.Append("--")
        Next
        
        myString = " Last summer we took threes across the board.  "
        
        myString = myString.Substring(13, 15)
        myString = myString.ToUpper()
        myString = myString.ToLower()
        myString = myString.Replace(" ", "--")
        myString = String.Format("myString is {0} characters long. After trim: {1} characters long.", myString.Length, myString.Trim().Length)
        
        
        Console.WriteLine(myString)
        
    End Sub
    
    
    Sub LearningDates()
        
        Dim myValue as Date = Now()
        
        Console.WriteLine(myValue.ToLongDateString())
        Console.WriteLine(myValue.ToShortDateString())
        Console.WriteLine(myValue.ToLongTimeString())
        Console.WriteLine(myValue.ToShortTimeString())
        
        Console.WriteLine(myValue.Month & " -- " & myValue.DayOfWeek)
        Console.WriteLine(myValue.ToString("MMMM"))
        
        Console.WriteLine(myValue.AddDays(3).ToShortDateString())
        Console.WriteLine(myValue.AddHours(3).ToShortTimeString())
        Console.WriteLine(myValue.AddDays(-3).ToShortDateString())
        
'        Dim myBirthdate as new Date(2003, 4, 15, 16, 32, 5)
        dim myBirthdate as New Date
        myBirthdate = Date.Parse("4/15/2003")
        myBirthdate = #4/15/2003#
        
'        Console.WriteLine(myBirthdate)
        
'        Dim myBirthdate as new Date(2003, 4, 15)
        
        dim myAge as TimeSpan = Date.Now.Subtract(myBirthdate)
        
        myAge.Add(New TimeSpan(100, 0, 0, 0))
        
        Console.WriteLine(myAge.TotalDays)
        
        
    End Sub
    
    
    Sub Classes()
        
        Dim myCar as New Car()
        
        Console.WriteLine(myCar.Make)
        
        myCar.Make = "Toyota"
        myCar.Model = "4Runner"
        myCar.Year = 2010
        myCar.Color = "White"
        
        Dim myOtherCar as New Car()
        
        myOtherCar.Make = "Honda"
        myOtherCar.Model = "Accord"
        myOtherCar.Year = 2012
        myOtherCar.Color = "Black"
        
        Console.WriteLine("{0} {1}", myCar.Make, myCar.Year)
        
        Console.WriteLine("{0} {1}", myOtherCar.Make, myOtherCar.Year)
        
'        Console.WriteLine("{0} {1:C}", myCar.Make, determineMarketValue(myCar))

        Console.WriteLine("{0} {1:C}", myCar.Make, myCar.marketValue())
        
        Dim myThirdCar as Car = myCar
        
        Console.WriteLine(myThirdCar.Make)
        
        myThirdCar.Color = "Black"
        
        myThirdCar = Nothing
        
        Console.WriteLine(myCar.Color)
        
        Dim myFourthCar as New Car("Ford", "F-150", 2020, "Silver")
        
        Console.WriteLine(myFourthCar.Model)
        
        CarLot.AddToInventory(myFourthCar)
        
        
    End Sub
    
    Private k as String = ""
    
    Sub Scope()
        
        Dim j as String = ""
        
        for i = 1 to 10
            Console.WriteLine("i: " & i)
            j = i.ToString()
            
            if i = 10 Then
                Dim l as String = i.ToString()
                Console.WriteLine("l: " & l)
            End If
        Next
        
        Console.WriteLine("j: " & j)
        Console.WriteLine("k: " & k )
        
    End Sub
    
    Sub Namespaces()
        
'        Dim client as WebClient = New WebClient()
'        Dim reply as String = client.DownloadString("https://hytale.com")
'        
'        Console.WriteLine(reply)
        
        
    End Sub
    
    
    Sub Collections()
        
        Dim car1 as New Car()
        Dim car2 as New Car()
        
        car1.Make = "Oldsmobile"
        car1.Model = "Cutlas Supreme"
        car2.Make = "Geo"
        car2.Model ="Prism"
        
        Dim book1 as new Book()
        
        book1.Author = "Robert Tabor"
        book1.Title = "Microsoft Web Services"
        book1.ISBN = "0-000-00000-0"
        
        Dim myArrayList as New ArrayList()
        
        myArrayList.Add(car1)
        myArrayList.Add(car2)
        myArrayList.Add(book1)
        myArrayList.Remove(book1)
        
        For Each item In myArrayList
            Console.WriteLine(item.Make)
        Next
        
        Dim myList as List(Of Car) = New List(Of Car)
        
        myList.Add(car1)
        myList.Add(car2)
        
        For Each item In myList
            Console.WriteLine(item.Make)
        Next
        
        Dim myDictionary as new Dictionary(Of String, Car)
        
        myDictionary.Add(car1.Make, car1)
        myDictionary.Add(car2.Make, car2)
        
        Console.WriteLine(myDictionary("Geo").Model)
        
        
        Dim myCar as new Car with { .Make = "BMW", .Model = "745li" }
        
        Dim myListOfCars as new List(Of Car) From {
                New Car With { .Make = "Aston Martin", .Model = "DBN"},
                New Car With { .Make = "Audi", .Model = "A8"},
                New Car With { .Make = "Dodge", .Model = "Dart"}}
        
        For Each item As Car In myListOfCars
            
            Console.WriteLine(item.Model)
            
        Next
        
    End Sub
    
    Sub FunSorting()
        
        Dim myCars as new List(Of Car) From {
                New Car With {.Make = "BMW", .Model = "550i", .SticerPrice = 55000, .Year = 2009},
                New Car With {.Make = "Toyota", .Model = "4Runner", .SticerPrice = 35000, .Year = 2010},
                New Car With {.Make = "BMW", .Model = "745li", .SticerPrice = 75000, .Year = 2008},
                New Car With {.Make = "Ford", .Model = "Escape", .SticerPrice = 28000, .Year = 2008},
                New Car With {.Make = "BMW", .Model = "550i", .SticerPrice = 57000, .Year = 2010}}
        
        
'        Dim bmws = From car in myCars
'                where car.Make = "BMW"
'                Select car
        
'        Dim bmws = From car in myCars
'                where car.Make = "BMW" And car.Year = 2010
'                Select car
                
        Dim newCars = From car in myCars
                where car.Year > 2009
                Select new with { car.Make, car.Model }
                
        
'        Dim orderedCars = From car in myCars
'                order by car.Year Descending
'                Select car
                
        
'        Dim bmws = myCars.Where(Function(car) car.make = "BMW")

'        Dim bmws = myCars.Where(Function(car) car.make = "BMW").Where(Function(car) car.Year = 2010)
        
'        dim orderedCars = myCars.OrderByDescending(Function(car) car.Year)
        
'        dim sum = myCars.Sum(Function(car) car.SticerPrice)
        
'        myCars.ForEach(Sub(car) car.SticerPrice += 10000)
        Console.WriteLine("Total Values {0:C}", 
                          myCars.Sum(
                              Function(car) car.SticerPrice + 10000))
        
'        For Each item As Car In newCars
'            Console.WriteLine("{0} {1} {2:C} {3}", item.Make, item.Model, item.SticerPrice, item.SticerPrice)
'        Next
        
'        For Each item In newCars
'            Console.WriteLine("{0} {1}", item.Make, item.Model)
'        Next
        
'        For Each item As Car In orderedCars
'            Console.WriteLine("{0} {1} {2:C} {3}", item.Make, item.Model, item.SticerPrice, item.SticerPrice)
'        Next
        
'        For Each item As Car In bmws
'            Console.WriteLine("{0} {1} {2:C} {3}", item.Make, item.Model, item.SticerPrice, item.SticerPrice)
'        Next
        
    End Sub
    
    Sub Cases()
        
        Dim myTODO as new TODO() With {
                .ID = 1,
                .Title = "First TODO",
                .Description = "This is my first TODO",
                .DueDate = #12/7/2017#,
                .Status = TodoStatus.NotStarted}
        
'        Console.ForegroundColor = ConsoleColor.DarkRed
'        Console.WriteLine("Hello World")
        
        
        Console.WriteLine("Type in a superhero's name to see his nickname: ")
        Dim userValue as String = Console.ReadLine()
        
        Dim myValue As Superhero
        
'        If Superhero.TryParse(userValue, True, myValue) Then
'            if myValue = Superhero.Batman Then 
'                Console.WriteLine("Caped Crusader")
'            ElseIf myValue = Superhero.Superman Then 
'                Console.WriteLine("Man of Steel")
'            ElseIf myValue = Superhero.GreenLantern Then 
'                Console.WriteLine("Emerald Knight")
'            End If
'        End If
        
        Dim result as String
        
        If Superhero.TryParse(userValue, True, myValue) Then
            Select Case myValue
                Case Superhero.Batman
                    result = "Caped Crusader"
                Case Superhero.Superman
                    result = "Man of Steel"
                Case Superhero.GreenLantern
                    result = "Emerald Knight"
                Case Else
                    result = "Not Found"
            End Select 
        End If
        
        Console.WriteLine(result)
        
        
'        Console.WriteLine("Type in a superhero's name to see his nickname: ")
'        Dim userValue2 as String = Console.ReadLine()
'        
'        Select Case userValue2.ToUpper()
'            Case "BATMAN"
'                Console.WriteLine("Caped Crusader")
'            Case "SUPERMAN"
'                Console.WriteLine("Man of Steel")
'            Case "GREEN LANTERN"
'                Console.WriteLine("Emerald Knight")
'            Case Else
'                Console.WriteLine("Not Found")
'        End Select
        
    End Sub
    
    Sub ErrorHandling()
        
        Dim content as String
        Try
            content = File.ReadAllText("C:\Users\fakefile.txt")
            
        Catch ex as DirectoryNotFoundException
            console.WriteLine("Could not locate the specified directory")
            
        Catch ex as FileNotFoundException
            Console.WriteLine("Could not locate the specified file")
            
        Catch ex as Exception
            Console.WriteLine("There was a problem: {0}.", ex.Message)
            
        Finally
            content = "No data found"
            
        End Try
        
        Console.WriteLine(content)
        
        
    End Sub
    
    Sub FinalStuff()
        
'        Dim myTimer as New Timers.Timer(1000)
'        
'        AddHandler myTimer.Elapsed, AddressOf Program.HandleTimer
'        AddHandler myTimer.Elapsed, AddressOf HandleTimer2
'        
'        myTimer.Start()
'        Console.WriteLine("Press Enter to stop handling the event twice.")
'        Console.ReadLine()
'        myTimer.Stop()
'        
'        RemoveHandler myTimer.Elapsed, AddressOf HandleTimer2
'        
'        myTimer.Start()
'        Console.ReadLine()
'        myTimer.Stop()
        
    End Sub
    
    Private Sub HandleTimer(sender as Object, e as ElapsedEventArgs)
        
        Console.WriteLine("HandledTimer Event: {0:HH:mm:ss.fff}", e.SignalTime)
        
    End Sub
    
    Private Sub HandleTimer2(sender as Object, e as ElapsedEventArgs)
        
        Console.WriteLine("HandledTimer Event: {0:HH:mm:ss.fff}", e.SignalTime)
        
    End Sub
    
    
    Sub Main(args As String())
        
'        Program1()
'        Variables()
'        Branching()
'        Loops()
'        Arrays()
'        WhileLoops()
'        Strings()
'        LearningDates()
'        Classes()
'        Scope()
'        Namespaces()
'        Collections()
'        FunSorting()
'        Cases()
'        ErrorHandling()
        FinalStuff()
        
    End Sub
    
    
    
End Module
