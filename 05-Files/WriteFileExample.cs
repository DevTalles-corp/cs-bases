partial class Program
{
  static void WriteFileExample()
  {
    var filePath = "./05-Files/EjemploEscritura.txt";
    var content = "Esto se añadira al final";
    var streamWriter = new StreamWriter(filePath, append: true);
    streamWriter.WriteLine(content);
    streamWriter.WriteLine("La hora actual es: " + DateTime.Now.ToString("HH:mm:ss"));
    streamWriter.Dispose();
    WriteLine("Archivo creado exitosamente");
  }
}