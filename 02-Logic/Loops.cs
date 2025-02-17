partial class Program
{
  static void Loops()
  {
    //while
    int counter = 1;
    while (counter <= 5)
    {
      WriteLine($"Iteración: {counter}");
      counter++;
    }
    //do while
    int number = 0;
    do
    {
      WriteLine($"Número: {number}");
      number++;
    } while (number < 3);
  }
}