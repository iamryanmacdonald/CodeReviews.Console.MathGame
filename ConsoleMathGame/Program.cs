﻿var date = DateTime.UtcNow;
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
            AdditionGame("Addition game");
            break;
        case "d":
            DivisionGame("Division game");
            break;
        case "m":
            MultiplicationGame("Multiplication game");
            break;
        case "q":
            Console.WriteLine("Goodbye.");
            Environment.Exit(1);
            break;
        case "s":
            SubtractionGame("Subtraction game");
            break;
        default:
            Console.WriteLine("Invalid input.");
            Environment.Exit(1);
            break;
    }
}

void AdditionGame(string message)
{
    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (var i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Your answer was correct! Press any key for the next question.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect. Press any key for the next question.");
            Console.ReadLine();
        }

        if (i == 4)
            Console.WriteLine($"Game over. Your final score is {score}.");
    }
}

void DivisionGame(string message)
{
    var score = 0;

    for (var i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Your answer was correct! Press any key for the next question.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect. Press any key for the next question.");
            Console.ReadLine();
        }

        if (i == 4)
            Console.WriteLine($"Game over. Your final score is {score}.");
    }
}

void MultiplicationGame(string message)
{
    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;


    for (var i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} * {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("Your answer was correct! Press any key for the next question.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect. Press any key for the next question.");
            Console.ReadLine();
        }

        if (i == 4)
            Console.WriteLine($"Game over. Your final score is {score}.");
    }
}

void SubtractionGame(string message)
{
    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;


    for (var i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("Your answer was correct! Press any key for the next question.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect. Press any key for the next question.");
            Console.ReadLine();
        }

        if (i == 4)
            Console.WriteLine($"Game over. Your final score is {score}.");
    }
}

int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(1, 99);
    var secondNumber = random.Next(1, 99);

    var result = new int[2];

    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;
}