partial class Program
{
  static void DataStructures()
  {
    User pedro = new User { Name = "Pedro", Age = 33 };
    pedro.Greet();
    Point punto = new Point { X = 30, Y = 20 };
    Console.WriteLine($"Punto ({punto.X},{punto.Y})");
    CellPhone nokia = new CellPhone("Nokia 225", 2024);
    System.Console.WriteLine(nokia);
  }
}
class User
{
  public string? Name { get; set; }
  public int Age { get; set; }

  public void Greet()
  {
    Console.WriteLine($"Hola, soy el usuario {Name} y tengo una edad de {Age} años");
  }
}
struct Point
{
  public int X { get; set; }
  public int Y { get; set; }
}

record CellPhone(string Model, int Year);