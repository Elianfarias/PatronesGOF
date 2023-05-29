using Abstract_Factory;
using Abstract_Factory.Abstract_Factory;
using Abstract_Factory.Abstract_Factory.Interfaces;


Application app;
ThemeFactory themeFactory;

Console.WriteLine("Hola, Elije un tema");
Console.WriteLine("1 - Oscuro");
Console.WriteLine("2 - Claro (Por defecto)\n");
Console.WriteLine("3 - Monocromatico\n");
var response = Console.ReadLine();

switch (response)
{
    case "1":
        themeFactory = new DarkThemeFactory();
        break;
    case "2":
        themeFactory = new LightThemeFactory();
        break;
    case "3":
        themeFactory = new MonochromeThemeFactory();
        break;
    default:
        themeFactory = new LightThemeFactory();
        break;

}

app = new Application(themeFactory);
app.Draw();