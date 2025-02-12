partial class Program
{
  static void Arrays()
  {
    int[] numbers = new int[5];
    numbers[0] = 1;
    numbers[1] = 3;
    // Directa
    int[] numbersArray = [5, 10, 15, 20, 25, 30];
    // Índices
    Console.WriteLine($"Primer elemento {numbersArray[0]}");
    Console.WriteLine($"Tercer elemento {numbersArray[2]}");
    // Tamaño arreglo
    Console.WriteLine($"El numero de elementos es: {numbersArray.Length}");

  }
}