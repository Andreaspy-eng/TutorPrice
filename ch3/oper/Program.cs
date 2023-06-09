﻿using static System.Console;
internal partial class Program
{
  private static void Main(string[] args)
  {
    int a = 3;
    int b = a++;
    WriteLine($"a is {a}, b is {b}");

    WriteLine("----------------");

    int c = 3;
    int d = ++c; // увеличение с перед присваиванием
    WriteLine($"c is {c}, d is {d}");

    WriteLine("----------------");

    int e = 11;
    int f = 3;
    WriteLine($"e is {e}, f is {f}");
    WriteLine($"e + f = {e + f}");
    WriteLine($"e - f = {e - f}");
    WriteLine($"e * f = {e * f}");
    WriteLine($"e / f = {e / f}");
    WriteLine($"e % f = {e % f}");

    WriteLine("----------------");

    double g = 11.0;
    WriteLine($"g is {g:N1}, f is {f}");
    WriteLine($"g / f = {g / f}");
  }
}