partial class Program
{
  static void PathExample()
  {
    var filePath = "./05-Files/Ejemplo.txt";
    var fileName = Path.GetFileName(filePath);
    WriteLine($"Nombre del archivo: {fileName}");
    var fileExtension = Path.GetExtension(filePath);
    WriteLine($"Extensión del archivo: {fileExtension}");
    var directoryName = Path.GetDirectoryName(filePath);
    WriteLine($"Nombre del directorio: {directoryName}");
    var combinedPath = Path.Combine("C:", "User", "Documents", "Ejemplo.txt");
    WriteLine($"Ruta combinada: {combinedPath}");
    var fullFilePath = Path.GetFullPath(filePath);
    WriteLine($"Ruta completa del archivo: {fullFilePath}");
  }
}