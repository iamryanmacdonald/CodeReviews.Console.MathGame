namespace ConsoleMathGame.Models;

internal class Game
{
    public DateTime Date { get; init; }
    public TimeSpan Duration { get; init; }
    public int Score { get; init; }
    public GameType Type { get; init; }
}

internal enum GameType
{
    Addition,
    Division,
    Multiplication,
    Subtraction
}