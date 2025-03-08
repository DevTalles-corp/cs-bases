partial class Program
{
  static void DirectoryExample()
  {
    var directoryPath = "./05-Files/";
    Directory.CreateDirectory($"{directoryPath}/DirEjemplo/OtherDir");
    if (Directory.Exists($"{directoryPath}/DirEjemplo/OtherDir"))
    {
      WriteLine("El directorio ya existe");
    }
    Directory.Delete($"{directoryPath}/DirEjemplo", recursive: true);
  }
}