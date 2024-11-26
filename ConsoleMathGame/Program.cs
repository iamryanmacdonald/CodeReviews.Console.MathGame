var date = DateTime.UtcNow;
var name = GetName();

Menu(name);

string GetName()
{
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine();
    return name;
}

void Menu(string name)
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine(
        $"Hello {name}. It's {date}. This is your maths game. It's great that you're working on improving yourself.");
    Console.WriteLine("\n");
    Console.WriteLine("""
                      What game would you like to play today? Choose from the options below:
                      A - Addition
                      S - Subtraction
                      M - Multiplication
                      D - Division
                      Q - Quit the program
                      """);
    Console.WriteLine("----------------------------------------");

    var gameSelection = Console.ReadLine().ToLower().Trim();

    switch (gameSelection)
    {
        case "a":
            AdditionGame("Addition game selected.");
            break;
        case "d":
            DivisionGame("Division game selected.");
            break;
        case "m":
            MultiplicationGame("Multiplication game selected.");
            break;
        case "q":
            Console.WriteLine("Goodbye.");
            Environment.Exit(1);
            break;
        case "s":
            SubtractionGame("Subtraction game selected.");
            break;
        default:
            Console.WriteLine("Invalid input.");
            Environment.Exit(1);
            break;
    }
}

void AdditionGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    int score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Your answer was correct!");
            score += 1;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect.");
        }

        if (i == 4)
            Console.WriteLine($"Game over. Your final score is {score}.");
    }
}

void DivisionGame(string message)
{
    Console.WriteLine(message);
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    int score = 0;

    int firstNumber;
    int secondNumber;


    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} * {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("Your answer was correct!");
            score += 1;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect.");
        }

        if (i == 4)
            Console.WriteLine($"Game over. Your final score is {score}.");
    }
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    int score = 0;

    int firstNumber;
    int secondNumber;


    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("Your answer was correct!");
            score += 1;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect.");
        }

        if (i == 4)
            Console.WriteLine($"Game over. Your final score is {score}.");
    }
}