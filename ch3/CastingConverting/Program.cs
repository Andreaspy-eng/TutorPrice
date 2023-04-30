using static System.Console;
using static System.Convert;
internal class Program
{
  private static void Main(string[] args)
  {
    double c = 9.8;
    int d = (int)c;
    WriteLine(d);

     long e = 10;
    int f = (int)e;
    WriteLine($"e is {e:N0} and f is {f:N0}");
    e = long.MaxValue;
    f = (int)e;
    WriteLine($"e is {e:N0} and f is {f:N0}");

    double g = 9.8;
    int h = ToInt32(g);
    WriteLine($"g is {g} and h is {h}");

    foreach (double n in doubles)
    {
      WriteLine(format:
      "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
      arg0: n,
      arg1: Math.Round(value: n,
      digits: 0,
      mode: MidpointRounding.AwayFromZero));
    }

    int number = 12;
    WriteLine(number.ToString());
    bool boolean = true;
    WriteLine(boolean.ToString());
    DateTime now = DateTime.Now;
    WriteLine(now.ToString());
    object me = new object();
    WriteLine(me.ToString());
  }
}