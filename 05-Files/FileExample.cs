partial class Program
{
  static void FileExample()
  {
    var filePath = "./05-Files/Ejemplo.txt";
    var content = File.ReadAllText(filePath);
    // WriteLine(content);
    var lines = File.ReadAllLines(filePath);
    foreach (var line in lines)
    {
      WriteLine(line);
    }
    WriteLine(lines[1]);
    File.Copy(filePath, "./05-Files/EjemploCopia.txt", overwrite: true);
    File.Delete("./05-Files/EjemploCopia.txt");
  }
}