partial class Program
{
  static void SalesReport()
  {
    string product = "Laptop";
    int quantitySold = 3;
    double unitPrice = 750.99;
    double totalAmount = quantitySold * unitPrice;
    Console.WriteLine($"Producto: {product}");
    Console.WriteLine($"Cantidad vendida: {quantitySold}");
    Console.WriteLine($"Total generado: {totalAmount:C}");
  }
  // 🏆 Ejercicio:
  // Crear un programa que calcule el salario mensual de un trabajador
  // - Pedir al usuario su nombre, horas trabajadas y tarifa por hora
  // - Calcular el sueldo y mostrarlo en pantalla
  static void SalaryCalculator()
  {
    Console.WriteLine("Calculadora de salario");
    Console.WriteLine();
    Console.Write("Ingrese su nombre: ");
    string? name = Console.ReadLine();
    Console.Write("Ingrese el número de horas trabajadas: ");
    double hours = double.Parse(Console.ReadLine()!);
    Console.Write("Ingrese el salario por hora: ");
    double rate = double.Parse(Console.ReadLine()!);
    double salary = hours * rate;
    Console.WriteLine($"El salario para {name} es de {salary}");

  }
}