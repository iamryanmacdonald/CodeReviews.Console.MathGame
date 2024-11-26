using ConsoleMathGame.Models;

namespace ConsoleMathGame;

internal class Helpers
{
    internal static List<Game> games = new();

    internal static void AddToHistory(int gameScore, GameType gameType)
    {
        games.Add(new Game
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

    internal static void PrintGames()
    {
        Console.Clear();
        Console.WriteLine("Games History");
        Console.WriteLine("----------------------------------------");
        foreach (var game in games) Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} pts");
        Console.WriteLine("----------------------------------------\n");
        Console.WriteLine("Press any key to go back to the main menu.");
        Console.ReadLine();
    }
}