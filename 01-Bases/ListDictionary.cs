partial class Program
{
  static void ListDictionary()
  {
    List<string> names = new List<string> { "Ana", "Carlos", "Juan" };
    names.Add("Lucia");
    System.Console.WriteLine($"Total de nombres: {names.Count}");
    foreach (var name in names)
    {
      System.Console.WriteLine(name);
    }
    names.Remove("Ana");
    bool isPresent = names.Contains("Ana");
    System.Console.WriteLine($"¿Ana está en la lista? {isPresent}");

    //Dictionary
    Dictionary<int, string> students = new Dictionary<int, string>
    {
      {1,"Ana"},
      {2,"Felipe"},
      {3,"Elena"}
    };
    System.Console.WriteLine($"El estudiante con ID 1 es: {students[1]}");
    foreach (var student in students)
    {
      System.Console.WriteLine($"ID: {student.Key}, Nombre: {student.Value}");
    }
  }
}