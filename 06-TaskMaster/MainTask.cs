using TaskMaster;
namespace TaskMaster
{
  partial class Program
  {
    static FileActions<Task> fileActions = new("./06-TaskMaster/tasks.json");
    static List<Task> tasks = fileActions.ReadFile();
    static Queries queries = new(tasks);

    public static void TaskMaster()
    {
      bool salir = false;
      while (!salir)
      {
        ForegroundColor = ConsoleColor.White;
        WriteLine("------Menú de tareas------");
        WriteLine("\n1. Listar tareas");
        WriteLine("2. Añadir tarea");
        WriteLine("3. Marcar tarea como completada");
        WriteLine("4. Editar tarea");
        WriteLine("5. Eliminar tarea");
        WriteLine("6. Consultar tareas por estado");
        WriteLine("7. Consultar tarea por descripción");
        WriteLine("8. Salir");
        Write("\nSeleccione una opción: ");

        switch (ReadLine())
        {
          case "1":
            queries.ListTasks();
            break;
          case "2":
            // AddTask();
            break;
          case "3":
            // MarkAsCompleted();
            break;
          case "4":
            // EditTask();
            break;
          case "5":
            // RemoveTask();
            break;
          case "6":
            //TasksByState();
            break;
          case "7":
            //TasksByDescription();
            break;
          case "8":
            salir = true;
            Console.Clear();
            break;
          default:
            Console.Clear();
            Console.WriteLine("Opción no válida. Intente nuevamente.");
            break;
        }
      }
    }

  }
}
