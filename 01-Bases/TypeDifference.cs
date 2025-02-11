partial class Program
{
  static void TypeDifference()
  {
    int x = 5;
    int y = x;
    y = 15;
    Console.WriteLine($"x:{x}, y: {y}");

    Person person1 = new Person { Name = "Carlos" };
    Person person2 = person1;
    person2.Name = "Alicia";
    Console.WriteLine($" person1.Name {person1.Name}");
  }
}
class Person
{
  public string? Name { get; set; }
}