using ConsoleMathGame;

var date = DateTime.UtcNow;
var name = Helpers.GetName();

var menu = new Menu();
menu.ShowMenu(name, date);