
using BeginnerLearning;

// Basics on Strings
static void Strings()
{
    Console.WriteLine("Hello, Drew!");


    var firstFriend = "Abby";

    var secondFriend = "Emma";

    Console.WriteLine("My friends are " + firstFriend + " and " + secondFriend);

    Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");


    var greeting = "      Hello World!       ";
    Console.WriteLine($"[{greeting}]");

    var trimmedGreeting = greeting.TrimStart();
    Console.WriteLine($"[{trimmedGreeting}]");

    trimmedGreeting = greeting.TrimEnd();
    Console.WriteLine($"[{trimmedGreeting}]");

    trimmedGreeting = greeting.Trim();
    Console.WriteLine($"[{trimmedGreeting}]");

    var sayHello = "Hello World!";
    Console.WriteLine(sayHello);
    sayHello = sayHello.Replace("Hello", "Greetings");
    Console.WriteLine(sayHello);


    var songLyrics = "You say goodbye, and I say hello";
    Console.WriteLine(songLyrics.Contains("goodbye"));
    Console.WriteLine(songLyrics.Contains("greetings"));
}


static void Numbers()
{
    var a = 18;
    var b = 6;
    var c = a + b;
    Console.WriteLine(c);

    a = 2147483647;
    b = 2147483647;
    c = a + b;
    Console.WriteLine(c);

    var d = a + (long)b;
    Console.WriteLine(d);

    // long e = checked(a + b);

    var f = 42.1; // natural type 
    var g = 38.2f;
    var h = f + g;
    Console.WriteLine(h);


    var k = 42.1m; // explicit type
    var l = 38.2m;
    var m = k + l;
    Console.WriteLine(m);
}

static void Branching()
{
    var a = 5;
    var b = 3;

    var c = a + b;

    var test = c > 10;

    if (test)
        Console.WriteLine("The answer is greater than 10");
    else
        Console.WriteLine("The answer is LESS than 10");


    var d = 5;
    var e = 3;
    var f = 4;
    if (d + e + f > 10 && d == e)
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("And the first number is equal to the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("Or the first number is not equal to the second");
    }

    var counter = 0;

    // counter = counter + 1; // old way

    while (counter < 10)
    {
        Console.WriteLine($"The counter is {counter}");
        counter++;
    }
    
    counter = 0;
    do
    {
        Console.WriteLine($"Hello World! The counter is {counter}");
        counter++;
    } while (counter < 10);
    
    
    for (int i = 0; i < 10; i++)
    {
        if (i == 3)
        {
            Console.WriteLine("i is 3");
        }
        Console.WriteLine($"Hello For loop! The counter is {i}");
    }
    
    for (int row = 1; row < 11; row++)
    {
        for (char column = 'a'; column < 'k'; column++)
        {
            Console.WriteLine($"The cell is ({row}, {column})");
        }
    }
    
}

static void Lists()
{
    
    List<string> names = ["<name>", "Ana", "Felipe"];
    foreach (var name in names)
    {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }
    
    Console.WriteLine();
    names.Add("Maria");
    names.Add("Bill");
    names.Remove("Ana");
    foreach (var name in names)
    {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }
    
    Console.WriteLine(names[^1]);
    
    foreach (var name in names[1..3])
    {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }
    
    string[] namesArray = ["<name>", "Ana", "Felipe"];
    foreach (var name in namesArray)
    {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }

    namesArray = [..namesArray, "Scott"]; 
    
    foreach (var name in namesArray)
    {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }
    
    names = new List<string>() {"Scott", "Ana", "Felipe"};
    
    names.Sort();
    
    foreach (var name in names)
    {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }

    List<int> numbers = [234, 123, 99, 12, 56, 79, 33]; 
    
    numbers.Sort();
    Console.WriteLine(numbers.IndexOf(234));
    
    foreach (var number in numbers)
    {
        Console.WriteLine($"{number}!");
    }
    
    
    // Specify the data source.
    int[] scores = [3, 45, 82, 97, 92, 100, 81, 60];

    // Define the query expression.
    IEnumerable<int> scoreQuery =
        from score in scores
        where score > 80
        select score;

    // Execute the query.
    foreach (var i in scoreQuery)
    {
        Console.Write(i + " ");
    }
    
    Console.WriteLine();

    // Output: 97 92 81
    
    // Define the query expression.
    IEnumerable<int> scoreQueryOrdered =
        from score in scores
        where score > 80
        orderby score descending
        select score;
    
    List<int> highScores = scoreQueryOrdered.ToList();
    
    // Execute the query.
    foreach (var i in highScores)
    {
        Console.Write(i + " ");
    }
    
    Console.WriteLine();
    
    // Define the query expression.
    IEnumerable<string> scoreQueryString =
        from score in scores
        where score > 80
        orderby score descending 
        select $"The score is {score}";

    // Execute the query.
    foreach (var i in scoreQueryString)
    {
        Console.WriteLine(i + " ");
    }


    var scoreQueryMethod = scores.Where(s => s > 80).OrderByDescending(s => s);
    

}

static void OOP()
{

    var p1 = new Person("John", "Doe", new DateOnly(2005, 6, 14));
    var p2 = new Person("Jane", "Buck", new DateOnly(2007, 2, 21));
    
    p1.pets.Add(new Dog("Solo"));
    p1.pets.Add(new Dog("Venture"));
    
    p2.pets.Add(new Cat("Snowball"));

    List<Person> people = [p1, p2]; 
    
    Console.WriteLine(people.Count);

    foreach (var person in people)
    {
        Console.WriteLine($"{person}");
        foreach (var pet in person.pets)
        {
            Console.WriteLine($"{pet}");
        }
    }
    {
        
    }


}


// Strings();
// Numbers();
// Branching();
// Lists();
OOP();