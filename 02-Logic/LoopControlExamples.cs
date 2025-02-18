partial class Program
{
  static void LoopControlExamples()
  {
    for (int i = 0; i < 10; i++)
    {
      if (i == 5)
      {
        break;
      }
      // WriteLine(i);
    }
    for (int i = 0; i < 10; i++)
    {
      if (i == 5 || i == 7)
      {
        continue;
      }
      // WriteLine(i);
    }
    for (int i = 0; i < 10; i++)
    {
      if (i == 3)
      {
        //return;
      }
      // WriteLine(i);
    }
    // Bucle infinitos
    // while (true)
    // {
    //   WriteLine("Esto siempre se ejecutará");
    // }
    for (; ; )
    {
      WriteLine("Esto también siempre se ejecutará");
      break;
    }
  }
}