using static System.Console;
internal partial class Program
{
  private static void Main(string[] args)
  {
    int x = 0;

    while (x<10)
    {
      WriteLine(x);
      x++;
    }

    string password = string.Empty;
    int attempts = 0;

      do
      {
        attempts++;
        Write("Enter your password: ");
        password = ReadLine();
      }
      while ((password != "Pa$$w0rd") & (attempts < 10));

      if (attempts < 10)
      {
        WriteLine("Correct!");
      }
      else
      {
        WriteLine("You have used 10 attempts!");
      }

       for (int y = 1; y <= 10; y++)
      {
        WriteLine(y);
      }

      string[] names = { "Adam", "Barry", "Charlie" };

      foreach (string name in names)
      {
        WriteLine($"{name} has {name.Length} characters.");
      }
  }
}