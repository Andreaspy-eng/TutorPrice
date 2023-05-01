using static System.Console;
internal class Program
{
  private static void Main(string[] args)
  {
    try
    {
      Write("Enter a number between 0 and 255: ");
      int first = Int32.Parse(ReadLine());
      Write($"Enter another number between 0 and 255: ");
      int second = Int32.Parse(ReadLine());
      WriteLine($"{first} divided by {second} is {first / second}");
    }
    catch(Exception ex)
    {
      WriteLine($"{ex.GetType().Name}: {ex.Message}");
    }
    
  }
}