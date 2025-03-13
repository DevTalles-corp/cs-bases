using BetterConsoles.Tables;
using BetterConsoles.Tables.Configuration;

namespace TaskMaster
{
  public class Queries(List<Task> _tasks)
  {
    private List<Task> Tasks = _tasks;

    public void ListTasks()
    {
      ForegroundColor = ConsoleColor.DarkBlue;
      WriteLine("-----Lista de tareas-----");
      Table table = new Table("Id", "Descripción", "Estado");
      foreach (var task in Tasks)
      {
        table.AddRow(task.Id, task.Description, task.Completed ? "Completada" : "");
      }
      table.Config = TableConfig.Unicode();

      Write(table.ToString());
      ReadKey();
    }
    public List<Task> AddTask()
    {
      try
      {
        ResetColor();
        Clear();
        WriteLine("---Añadir tarea---");
        WriteLine("Ingrese la descripción de la tarea: ");
        var description = ReadLine()!;
        Task newTask = new Task(Utils.GenerateId(), description);
        Tasks.Add(newTask);
        ForegroundColor = ConsoleColor.Green;
        WriteLine("Tarea añadida con éxito");
        ResetColor();
        return Tasks;
      }
      catch (Exception ex)
      {
        ForegroundColor = ConsoleColor.Red;
        WriteLine(ex.Message);
        return Tasks;
      }
    }

  }
}