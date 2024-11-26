using ConsoleMathGame.Models;

namespace ConsoleMathGame;

internal static class GameEngine
{
    internal static void GameLoop(GameType gameType, string message)
    {
        var random = new Random();
        var score = 0;

        var gameOperator = "";

        switch (gameType)
        {
            case GameType.Addition:
            default:
                gameOperator = "+";
                break;
            case GameType.Division:
                gameOperator = "/";
                break;
            case GameType.Multiplication:
                gameOperator = "*";
                break;
            case GameType.Subtraction:
                gameOperator = "-";
                break;
        }

        for (var i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            int firstNumber;
            int secondNumber;

            if (gameType == GameType.Division)
            {
                var divisionNumbers = Helpers.GetDivisionNumbers();
                firstNumber = divisionNumbers[0];
                secondNumber = divisionNumbers[1];
            }
            else
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
            }

            int roundAnswer;

            switch (gameType)
            {
                case GameType.Addition:
                default:
                    roundAnswer = firstNumber + secondNumber;
                    break;
                case GameType.Division:
                    roundAnswer = firstNumber / secondNumber;
                    break;
                case GameType.Multiplication:
                    roundAnswer = firstNumber * secondNumber;
                    break;
                case GameType.Subtraction:
                    roundAnswer = firstNumber - secondNumber;
                    break;
            }

            Console.WriteLine($"{firstNumber} {gameOperator} {secondNumber}");
            var result = Console.ReadLine();
            result = Helpers.ValidateResult(result);

            if (int.Parse(result) == roundAnswer)
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
        }

        Helpers.AddToHistory(score, gameType);
        Console.WriteLine(
            $"Game over. Your final score is {score}. Press any key to go back to the main menu.");
        Console.ReadLine();
    }
}