using System.Data;
using System.Data.Common;

partial class Program
{
  static void ShowTime()
  {
    DateTime now = DateTime.Now;
    DateTime today = DateTime.Today;
    DateTime nowWeekAgo = now.AddDays(-7);
    DateTime customDate = new DateTime(2025, 3, 2);

    DayOfWeek weekDay = now.DayOfWeek;

    Console.WriteLine($"Fecha y hora actual: {now}");
    Console.WriteLine($"Fecha actual: {today}");
    Console.WriteLine($"Hace una sema la fecha {now} era {nowWeekAgo.ToString("dd/MM/yyyy")}");
    Console.WriteLine($"Fecha personalizada: {customDate}");
    Console.WriteLine($"Día de la semana: {weekDay}");

  }
}