using ConsoleMathGame.Models;

namespace ConsoleMathGame;

internal static class Helpers
{
    private static readonly List<Game> Games = [];

    internal static void AddToHistory(int gameScore, GameType gameType)
    {
        Games.Add(new Game
        {
            Date = DateTime.Now,
            Score = gameScore,
            Type = gameType
        });
    }

    internal static int[] GetDivisionNumbers()
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

    internal static string GetName()
    {
        Console.WriteLine("Please type your name");
        var name = Console.ReadLine();

        while (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Name can't be empty.");
            name = Console.ReadLine();
        }

        return name;
    }

    internal static void PrintGames()
    {
        var gamesToPrint = Games
            .OrderByDescending(x => x.Score)
            .ToList();

        Console.Clear();
        Console.WriteLine("Games History");
        Console.WriteLine("----------------------------------------");
        if (gamesToPrint.Count > 0)
            foreach (var game in gamesToPrint)
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} pts");
        else
            Console.WriteLine("No games found.");
        Console.WriteLine("----------------------------------------\n");
        Console.WriteLine("Press any key to go back to the main menu.");
        Console.ReadLine();
    }

    internal static string ValidateResult(string? result)
    {
        while (string.IsNullOrWhiteSpace(result) || !int.TryParse(result, out _))
        {
            Console.WriteLine("Your answer needs to be an integer. Try again.");
            result = Console.ReadLine();
        }

        return result;
    }
}