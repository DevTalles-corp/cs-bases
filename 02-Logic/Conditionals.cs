partial class Program
{
  static void Conditionals()
  {
    int age = 19;
    if (age >= 18)
    {
      WriteLine("Eres mayor de edad");
    }
    else
    {
      WriteLine("Eres menor de edad");
    }
    // if ternario
    string message = age >= 18 ? "Eres mayor de edad" : "Eres menor de edad";
    WriteLine(message);
    //Multiples condiciones
    int temperature = 30;
    if (temperature > 35)
    {
      WriteLine("Hace mucho calor.");
    }
    else if (temperature >= 20)
    {
      WriteLine("Es agradable");
    }
    else
    {
      WriteLine("Hace frío");
    }
    // Switch
    int day = 3;
    switch (day)
    {
      case 1:
        WriteLine("Lunes");
        break;
      case 2:
        WriteLine("Martes");
        break;
      case 3:
        WriteLine("Miércoles");
        break;
      default:
        WriteLine("Día no válido");
        break;
    }
    //Switch  con expresiones
    string dayMessage = day switch
    {
      1 => "Lunes",
      2 => "Martes",
      3 => "Miércoles",
      _ => "Día no válido"
    };
    WriteLine(dayMessage);
  }

}