partial class Program
{
  static void Visibility()
  {
    Jedi jedi = new Jedi();
    jedi.PowerLevel = 5000;
    jedi.LightsaberColor = "azul";

    // jedi.UseForce();
    // WriteLine(jedi.PublicField);
    // WriteLine(jedi.PrivateField);
    // WriteLine(jedi.ProtectedField);
    // jedi.RevealSecrets();

    Sith sith = new Sith();
    sith.ShowProtected();
  }
}
class Jedi
{
  public string PublicField = "Soy un Jedi y mi es poder es conocido";

  private string PrivateField = "Mis pensamientos más profundos son privados";

  protected string ProtectedField = "El lado oscuro no debe conocer mis secretos";

  public int PowerLevel { get; set; }
  public string? LightsaberColor { get; set; }

  public void UseForce()
  {
    WriteLine($"Soy un jedi con un sable de  luz {LightsaberColor} y mi nivel de poder es: {PowerLevel}");
  }

  private void Meditate()
  {
    WriteLine("Estoy en profunda meditación con la fuerza");
  }
  protected void Train()
  {
    WriteLine("Estoy entrenando para convertirme en el mejor Jedi.");
  }
  public void RevealSecrets()
  {
    WriteLine(ProtectedField);
    WriteLine(PrivateField);
    Meditate();
  }
}
class Sith : Jedi
{
  public void ShowProtected()
  {
    WriteLine(ProtectedField);
    Train();
  }
}