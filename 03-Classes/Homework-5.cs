partial class Program
{
  static void ProductSalesDemo()
  {
    Inventory inventory = new();
    Product laptop = new Product("Laptop", 1200.99, 5);
    Product mouse = new Product("Mouse", 100, 10);
    inventory.AddProduct(laptop);
    inventory.AddProduct(mouse);
    // inventory.ShowInventory();
    // laptop.Sell(1);
    // inventory.ShowInventory();
  }
  static void BusFleet()
  {
    Bus corollaBus = new Bus("Toyota", "Corolla", 2020, 30_000, 10_000);
    Bus hondaBus = new Bus("Honda", "Civic", 2019, 20_000, 8_000);
    Bus fordBus = new Bus("Ford", "Fiesta", 2018, 25_000, 9_000);

    Fleet fleet = new();
    fleet.AddBus(corollaBus);
    fleet.AddBus(hondaBus);
    fleet.AddBus(fordBus);

    fleet.ShowBuses();
    corollaBus.Drive(5000);
    hondaBus.Drive(5000);
    fordBus.Drive(5000);
    fleet.ShowBuses();

  }
  class Product
  {
    public string? Name { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }

    public Product(string name, double price, int stock)
    {
      Name = name;
      Price = price;
      Stock = stock;
    }
    public void ShowInfo()
    {
      WriteLine($"Producto: {Name}, Precio: {Price}, Stock:{Stock}");
    }
    public bool Sell(int quantity)
    {
      if (quantity <= Stock)
      {
        Stock -= quantity;
        WriteLine($"Venta realizada: {quantity} unidades de {Name} ");
        return true;
      }
      WriteLine($"Stock insuficiente para {Name}");
      return false;
    }
  }
  class Inventory
  {
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
      products.Add(product);
    }
    public void ShowInventory()
    {
      WriteLine("Inventario de productos");
      foreach (var product in products)
      {
        product.ShowInfo();
      }
    }
  }
}
class Bus
{
  public string? Brand { get; set; }
  public string? Model { get; set; }
  public int Year { get; set; }
  public double Price { get; set; }
  public double TotalKilometers { get; set; }

  public Bus(string brand, string model, int year, double price, double totalKilometers)
  {
    Brand = brand;
    Model = model;
    Year = year;
    Price = price;
    TotalKilometers = totalKilometers;
  }

  public void Drive(int kilometers)
  {
    TotalKilometers += kilometers;
  }
  public void ShowPrice()
  {
    WriteLine($"Precio: {Price:C}");
  }
}
class Fleet
{
  private List<Bus> buses = new List<Bus>();

  public void AddBus(Bus bus)
  {
    buses.Add(bus);
  }
  public void ShowBuses()
  {
    foreach (var bus in buses)
    {
      WriteLine($"Marca: {bus.Brand}, Modelo {bus.Model}, Año: {bus.Year}, Kilometraje: {bus.TotalKilometers}");
    }
  }
}