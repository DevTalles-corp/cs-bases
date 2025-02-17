partial class Program
{
  static void Loops()
  {
    //while
    int counter = 1;
    while (counter <= 5)
    {
      // WriteLine($"Iteración: {counter}");
      counter++;
    }
    //do while
    int number = 0;
    do
    {
      // WriteLine($"Número: {number}");
      number++;
    } while (number < 3);

    for (int i = 0; i <= 5; i++)
    {
      WriteLine($"Iteración: {i}");
    }
    // Personalizando el for
    for (int i = 10; i >= 0; i -= 2)
    {
      WriteLine(i);
    }
    //foreach
    // Array
    string[] fruits = ["Manzana", "Pera", "Piña"];
    foreach (var fruit in fruits)
    {
      WriteLine(fruit);
    }
    // List
    List<string> names = ["Pedro", "Luis", "Nancy"];
    foreach (var name in names)
    {
      WriteLine(name);
    }
  }
}