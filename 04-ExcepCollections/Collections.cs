partial class Program
{
  static void Collections()
  {
    List<string> names = ["Luis", "Pedro", "Pablo"];
    names.Add("Ana");
    // ShowNames(names);
    // WriteLine("Después de remover a Luis");
    names.Remove("Luis");
    // ShowNames(names);

    Dictionary<int, string> students = new()
    {
      {1, "Ana"},
      {2,"Carlos"},
      {3,"Pablo"}
    };
    students.Add(4, "Roberto");
    // ShowStudents(students);
    students.Remove(1);
    // WriteLine("Después de remover a Ana");
    // ShowStudents(students);

    HashSet<string> users = ["Luis", "Pedro", "Pablo"];
    users.Add("Melisa");
    users.Add("Maria");
    users.Add("Luis");
    foreach (var user in users)
    {
      WriteLine(user);
    }

  }

  private static void ShowStudents(Dictionary<int, string> students)
  {
    foreach (var student in students)
    {
      WriteLine($"Llave: {student.Key}, Valor: {student.Value}");
    }
  }

  private static void ShowNames(List<string> names)
  {
    foreach (var name in names)
    {
      WriteLine(name);
    }
  }
}