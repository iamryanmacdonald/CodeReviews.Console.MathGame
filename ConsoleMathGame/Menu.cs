﻿namespace ConsoleMathGame;

internal class Menu
{
    private readonly GameEngine _engine = new();

    internal void ShowMenu(string name, DateTime date)
    {
        Console.Clear();
        Console.WriteLine(
            $"Hello {name}. It's {date}. This is your maths game. It's great that you're working on improving yourself.");
        Console.WriteLine("Press any key to show menu.");
        Console.ReadLine();
        Console.WriteLine("\n");

        var isGameOn = true;

        do
        {
            Console.Clear();
            Console.WriteLine("""
                              What game would you like to play today? Choose from the options below:
                              V - View Previous Games
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
                    _engine.AdditionGame("Addition game");
                    break;
                case "d":
                    _engine.DivisionGame("Division game");
                    break;
                case "m":
                    _engine.MultiplicationGame("Multiplication game");
                    break;
                case "q":
                    Console.WriteLine("Goodbye.");
                    isGameOn = false;
                    break;
                case "s":
                    _engine.SubtractionGame("Subtraction game");
                    break;
                case "v":
                    Helpers.PrintGames();
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    Environment.Exit(1);
                    break;
            }
        } while (isGameOn);
    }
}