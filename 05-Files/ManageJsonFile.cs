using System.Text.Json;

namespace ManageJsonFile
{
  class Character
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Alias { get; set; }
    public string? Team { get; set; }
  }
  partial class Program
  {
    public static void ManageJsonFile()
    {
      List<Character> characters =
      [
        new Character { Id = 1, Name = "Peter Parker", Alias = "Spider", Team = "Avengers" },
        new Character { Id = 2, Name = "Tony Stark", Alias
        = "Iron Man", Team = "Avengers" },
        new Character { Id = 3, Name = "Steve Rogers", Alias = "Capitán América", Team = "Avengers" }
      ];
      var charactersJson = JsonSerializer.Serialize(characters, new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
      File.WriteAllText("./05-Files/characters.json", charactersJson);
      var charactersFromFile = File.ReadAllText("./05-Files/characters.json");
      var charactersList = JsonSerializer.Deserialize<List<Character>>(charactersFromFile)!;
      foreach (var character in charactersList)
      {
        WriteLine($"Id: {character.Id}, Nombre: {character.Name}, Alias: {character.Alias}, Equipo: {character.Team}");
      }
    }
  }
}