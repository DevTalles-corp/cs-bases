partial class Program
{
  static void ShowNumericTypes()
  {
    var integerNumber = 42m;
    double doubleNumber = 3.1416d;
    float floatingNumber = 274f;
    long longNumber = 300_200_100L;
    decimal monetaryNumber = 99.99m;
    Console.WriteLine($"Entero: {integerNumber}");
    Console.WriteLine($"Double: {doubleNumber}");
    Console.WriteLine($"Float: {floatingNumber}");
    Console.WriteLine($"Long: {longNumber}");
    Console.WriteLine($"Decimal: {monetaryNumber}");
  }
}