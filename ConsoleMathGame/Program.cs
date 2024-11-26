using ConsoleMathGame;

var date = DateTime.UtcNow;

var name = GetName();

var menu = new Menu();
menu.ShowMenu(name, date);


string GetName()
{
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine();
    return name;
}