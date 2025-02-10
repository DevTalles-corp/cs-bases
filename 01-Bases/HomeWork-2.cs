using System.Globalization;

partial class Program
{
  static void DaysOfLife()
  {
    DateTime birthDate = new DateTime(1983, 3, 2);
    TimeSpan difference = DateTime.Now - birthDate;
    Console.WriteLine($"Has vivido {difference.Days} días.");
  }
  // 🏆 Ejercicio:
  // Pedir al usuario su fecha de nacimiento y calcular cuántos días faltan para su próximo cumpleaños.
  // Consideraciones:
  // - La fecha de nacimiento ingresada debe ser interpretada correctamente, 
  //   asegurando que las comparaciones de fechas no sean afectadas por las horas.
  // - Investigar acerca de `CultureInfo.InvariantCulture` para que no afecte la configuración regional del sistema.
  // - Se debe manejar el caso en que el cumpleaños ya haya pasado en el año actual, 
  //   sumando un año para calcular la fecha del próximo (opcional).
  static void DaysUntilNextBirthday()
  {
    Console.WriteLine("Introduce tu fecha de nacimiento (dd/mm/aaaa): ");
    string birthDateString = Console.ReadLine()!;
    DateTime birthDate = DateTime.ParseExact(birthDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
    DateTime currentDate = DateTime.Now.Date;
    DateTime nextBirthday = new DateTime(currentDate.Year, birthDate.Month, birthDate.Day);
    if (nextBirthday < currentDate)
    {
      nextBirthday = nextBirthday.AddYears(1);
    }
    int dayRemainig = (nextBirthday - currentDate).Days;
    Console.WriteLine($"Faltan {dayRemainig} días para tu próximo cumpleaños");
  }
}