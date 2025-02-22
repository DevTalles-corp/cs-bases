partial class Program
{
  static void Methods()
  {
    Car car = new Car();
    car.Model = "Yaris";
    car.Year = 2022;
    WriteLine(car.ShowInfo());
    car.ShowMessage();
    car.ShowMessage("Cambiando de modelo");
    car.ChangeModel("Patrol");
    WriteLine(car.ShowInfo());

    Car.GeneralInfo();
  }
}
class Car
{
  public string? Model { get; set; }
  public int? Year { get; set; }

  public void ChangeModel(string newModel)
  {
    Model = newModel;
  }
  public string ShowInfo()
  {
    return $"Automóvil: {Model}, Año: {Year}";
  }
  public void ShowMessage() => WriteLine("Este es un autómovil");
  public void ShowMessage(string message) => WriteLine(message);

  public static void GeneralInfo()
  {
    WriteLine("El autómovil es uno de los transportes mas utilizados");
  }
}