using Abstract_Factory;
using Abstract_Factory.Abstract_Factory;
using Abstract_Factory.Abstract_Factory.Interfaces;

ThemeFactory darkFactory = new DarkThemeFactory();
ThemeFactory whiteFactory = new LightThemeFactory();
Application app;

Console.WriteLine("Hola, Elije un tema");
Console.WriteLine("1 - Oscuro");
Console.WriteLine("2 - Claro (Por defecto)\n");
var response = Console.ReadLine();

app = response != null && response == "1" ? new Application(darkFactory) : new Application(whiteFactory);
app.Draw();