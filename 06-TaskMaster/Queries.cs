using System.Data;
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
    public List<Task> MarkAsCompleted()
    {
      try
      {
        ResetColor();
        Clear();
        WriteLine("---Marcar tarea como completada---");
        Write("Ingrese el id de la tarea que sea marcar como completada: ");
        var id = ReadLine()!;
        Task task = Tasks.Find(t => t.Id == id)!;
        if (task == null)
        {
          ForegroundColor = ConsoleColor.Red;
          WriteLine("No se encontró la tarea con el ID proporcionado");
          ResetColor();
          return Tasks;
        }
        task.Completed = true;
        task.ModifiedAt = DateTime.Now;
        ForegroundColor = ConsoleColor.Green;
        WriteLine("Tarea marcada como completada con éxito");
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
    public List<Task> EditTask()
    {
      try
      {
        ResetColor();
        Clear();
        WriteLine("---Editar tarea---");
        Write("Ingrese el id para editar la tarea: ");
        var id = ReadLine()!;
        Task task = Tasks.Find(t => t.Id == id)!;
        if (task == null)
        {
          ForegroundColor = ConsoleColor.Red;
          WriteLine("No se encontró la tarea con el ID proporcionado");
          ResetColor();
          return Tasks;
        }
        Write("Ingrese la descripción de la tarea: ");
        var description = ReadLine()!;
        task.Description = description;
        task.ModifiedAt = DateTime.Now;
        ForegroundColor = ConsoleColor.Green;
        WriteLine("Tarea modificada con éxito");
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
    public List<Task> RemoveTask()
    {
      try
      {
        ResetColor();
        Clear();
        WriteLine("---Eliminar tarea---");
        Write("Ingrese el id para eliminar la tarea: ");
        var id = ReadLine()!;
        Task task = Tasks.Find(t => t.Id == id)!;
        if (task == null)
        {
          ForegroundColor = ConsoleColor.Red;
          WriteLine("No se encontró la tarea con el ID proporcionado");
          ResetColor();
          return Tasks;
        }
        Tasks.Remove(task);
        ForegroundColor = ConsoleColor.Green;
        WriteLine("Tarea eliminada con éxito");
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
    public void TasksByState()
    {
      Clear();
      try
      {
        ResetColor();
        WriteLine("---Tareas por estado ---");
        WriteLine("1. Completadas");
        WriteLine("2. Pedientes");
        Write("Ingrese la opción de las tareas a mostrar: ");
        string taskState = ReadLine()!;
        if (taskState != "1" && taskState != "2")
        {
          ForegroundColor = ConsoleColor.Red;
          WriteLine("Opción inválida");
          ResetColor();
          return;
        }
        bool completed = taskState == "1";
        List<Task> filteredTasks = Tasks.Where(t => t.Completed == completed).ToList();
        if (filteredTasks.Count == 0)
        {
          ForegroundColor = ConsoleColor.Red;
          WriteLine("No se encontrarón tareas con el estado solicitado");
          ResetColor();
          return;
        }
        ForegroundColor = completed ? ConsoleColor.Green : ConsoleColor.Red;
        Table table = new Table("Id", "Descripción", "Estado");
        foreach (var task in filteredTasks)
        {
          table.AddRow(task.Id, task.Description, task.Completed ? "Completada" : "");
        }
        table.Config = TableConfig.Unicode();

        Write(table.ToString());
        ReadKey();

      }
      catch (Exception ex)
      {
        ForegroundColor = ConsoleColor.Red;
        WriteLine($"Ocurrió un error al filtrar las tareas: {ex.Message}");
      }
    }
    public void TasksByDescription()
    {
      Clear();
      try
      {
        ResetColor();
        WriteLine("---Tareas por descripción---");
        Write("Ingrese la descripción de las tareas a buscar: ");
        string description = ReadLine()!;
        List<Task> matchingTasks = Tasks.FindAll(t => t.Description?.Contains(description, StringComparison.OrdinalIgnoreCase) ?? false);
        if (matchingTasks.Count == 0)
        {
          ForegroundColor = ConsoleColor.Red;
          WriteLine("No se encontrarón tareas con la descripción proporcionada.");
          ResetColor();
          return;
        }
        Table table = new Table("Id", "Descripción", "Estado");
        foreach (var task in matchingTasks)
        {
          table.AddRow(task.Id, task.Description, task.Completed ? "Completada" : "");
        }
        table.Config = TableConfig.Unicode();

        Write(table.ToString());
        ReadKey();

      }
      catch (Exception ex)
      {
        ForegroundColor = ConsoleColor.Red;
        WriteLine($"Ocurrió un error al filtrar las tareas por descripción: {ex.Message}");
      }
    }
  }
}