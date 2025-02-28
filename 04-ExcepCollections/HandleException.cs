partial class Program
{
  static string? amount;
  static void HandleException()
  {
    try
    {
      // int number = 10;
      // int result = number / 0;
      Write("Ingrese un monto: ");
      amount = ReadLine();
      if (string.IsNullOrEmpty(amount)) return;

      double amountValue = double.Parse(amount);
      WriteLine($"El monto que introdujiste es el siguiente: {amountValue:C}");
    }
    catch (DivideByZeroException)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      WriteLine("Error: División por cero");
    }
    catch (FormatException) when (amount?.Contains('$') == true)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      WriteLine("No es necesario usar '$'");
    }
    catch (Exception ex)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      WriteLine(ex.Message);
    }

  }
}