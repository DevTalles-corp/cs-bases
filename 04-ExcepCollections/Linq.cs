partial class Program
{
  static void Linq()
  {
    List<int> numbers = [1, 2, 3, 4, 5, 6];
    List<int> evenNumbers = [];

    foreach (var number in numbers)
    {
      if (number % 2 == 0)
      {
        evenNumbers.Add(number);
      }
    }
    //Sintaxis de consulta
    var evenNumbersQuery = from num in numbers
                           where num % 2 == 0
                           select num;
    //Sintaxis de método
    var evenNumbersMethod = numbers.Where(n => n % 2 == 0);
    foreach (var number in evenNumbersMethod)
    {
      WriteLine(number);
    }
  }
}