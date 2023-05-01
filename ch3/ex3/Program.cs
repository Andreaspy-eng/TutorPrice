using static System.Console;
internal partial class Program
{
  private static void Main(string[] args)
  {
    for(int i =0; i<=100; i++)
    {
      if (i % 15 == 0 )
      {
        Write("FizzBuzz, ");
      }
      else if (i % 5 == 0)
      {
        Write("Buzz, ");
      }
      else if (i %3 ==0)
      {
        Write("Fizz, ");
      }
      else
      {
        Write($"{i}, ");
      }
    }

  }
}