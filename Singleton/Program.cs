using Singleton;

Console.WriteLine("Hola, ¿te quieres conectar?");
Console.WriteLine("1 - Si");
Console.WriteLine("2 - No \n");

var response = Console.ReadLine();
var conexion = Conexion.GetInstance();

if(response == "1")
    conexion.Conectar();

Console.WriteLine("\n" + conexion.GetMessage());
