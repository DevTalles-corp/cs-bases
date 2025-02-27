partial class Program
{
  static void ShowEmpoyeesInformation()
  {
    // 7. Recorrer la lista de empleados y mostrar la información de cada uno con el método "ShowInfo()".
    List<Employee> employees = new List<Employee>();
    employees.Add(new TeamLeader("Carlos", 5000));
    employees.Add(new Developer("Ana", 4000));
    employees.Add(new TeamLeader("Laura", 6000));
    employees.Add(new Developer("Carlos", 3500));
    WriteLine("Lista de empleados: ");
    foreach (var employee in employees)
    {
      employee.ShowInfo();
    }
  }
}
class Employee
{
  protected string? Name { get; set; }
  protected string? Position { get; set; }
  protected double Salary { get; set; }

  public Employee(string name, double salary, string position)
  {
    Name = name;
    Salary = salary;
    Position = position;
  }
  public virtual double CalculateBonus()
  {
    return Salary * 0.05;
  }
  public void ShowInfo()
  {
    WriteLine($"Nombre: {Name}, Cargo: {Position}, Salario: {Salary:C}, Bono calculado: {CalculateBonus():C}");
  }
}
class TeamLeader : Employee
{
  public TeamLeader(string name, double salary) : base(name, salary, "Team Leader") { }
  public override double CalculateBonus()
  {
    return Salary * 0.10;
  }
}

class Developer : Employee
{
  public Developer(string name, double salary) : base(name, salary, "Developer") { }
  public override double CalculateBonus()
  {
    return Salary * 0.07;
  }
}