partial class Program
{
  static void InventoryManager()
  {
    string[] products = ["Monitor", "Mouse", "Teclado"];
    int[] stock = [10, 25, 30];
    double[] prices = [250.50, 20.50, 45.00];
    Console.WriteLine("Inventario de Productos");
    Console.WriteLine("-----------------------");
    for (int i = 0; i < products.Length; i++)
    {
      Console.WriteLine($"Producto: {products[i]}, Stock: {stock[i]},Precio: {prices[i]}");
    }
    Console.WriteLine("\nIngrese el producto que desea comprar:");
    string? searchedProduct = Console.ReadLine();
    Console.WriteLine("Ingrese la cantidad que desea comprar: ");
    int quantity = int.Parse(Console.ReadLine()!);
    for (int i = 0; i < products.Length; i++)
    {
      if (products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase))
      {
        if (quantity <= stock[i])
        {
          double total = quantity * prices[i];
          Console.WriteLine($"Compra exitosa. El total a pagar: {total}");
        }
        else
        {
          Console.WriteLine("No hay suficiente stock disponible");
        }
      }
    }

  }
}