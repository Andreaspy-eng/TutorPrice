﻿using static System.Console;
class Program
{
  static int Factorial(int number)
  {
    if (number < 1)
    {
      return 0;
    }
    else if (number == 1)
    {
      return 1;
    }
    else
    checked
    {
      return number * Factorial(number - 1);
    }
  }

  static void RunFactorial()
  {
    for (int i = 1; i < 15; i++)
    try
    {
      WriteLine($"{i}! = {Factorial(i):N0}");
    }
    catch (System.OverflowException)
    {
      WriteLine($"{i}! is too big for a 32-bit integer.");
    }
  }
  static decimal CalculateTax(
    decimal amount, string twoLetterRegioneCode)
  {
    decimal rate = 0.0M;
    switch (twoLetterRegioneCode)
    {
      case "CH": //Швейцария
        rate = 0.08M;
        break;
      case "DK": //Дания
      case "NO": //Норвегия
        rate = 0.25M;
        break;
      case "GB": //Великобритания
      case "FR": //Франция
        rate = 0.2M;
        break;
      case "HU": //Венгрия
        rate = 0.27M;
        break;
      case "OR": //Орегон
      case "AK": //Аляска
      case "MT": //Монтана
        rate = 0.0M;
        break;
      case "ND": // Северная Дакота
      case "WI": // Висконсин
      case "ME": // Мэриленд
      case "VA": // Вирджиния
      rate = 0.05M;
      break;
      case "CA": // Калифорния
      rate = 0.0825M;
      break;
      default: // большинство штатов США
      rate = 0.06M;
      break;
      }
      return amount * rate;  
  }

  static void RunCalculateTax()
  {
    Write("Enter an amount: ");
    string amountInText = ReadLine();

    Write("Enter a two-letter region code: ");
    string region = ReadLine();

    if (decimal.TryParse(amountInText, out decimal amount))
    {
      decimal taxToPay = CalculateTax(amount, region);
      WriteLine($" You must pay {taxToPay} in sales tax");
    }
    else
    {
      WriteLine("You did not enter a valid amount!");
    }
  }

  static string CardinalToOrdinal(int number)
  {
    switch(number)
    {
      case 11:// case с 11 по 13
      case 12:
      case 13:
        return $"{number}th";
      default:
        int lastDigit = number % 10;

        string suffix = lastDigit switch
        {
          1 => "st",
          2 => "nd",
          3 => "rd",
          _ => "th"
        };
        return $"{number}{suffix}";
    }
  }

  static void RunCardinalToOrdinal()
  {
    for (int number = 1; number <= 40; number++)
    {
      Write($"{CardinalToOrdinal(number)} ");
    }
    WriteLine();
  }
  static void TimesTable(byte number)
  {
    WriteLine($"This is the {number} times table:");
    for (int row = 1; row <= 12;  row++)
    {
      WriteLine($"{number} * {row}= {number*row}");
    }
    WriteLine();
  }
  static void RunTimesTable()
  {
    bool isNumber;
    do
    {
      Write("Enter a number between 0 and 255: ");

      isNumber = byte.TryParse(
                  ReadLine(), out byte number);
                    
      if (isNumber)
      {
        TimesTable(number);
      }
      else
      {
        WriteLine("You did not enter a valid number!");
      }
    }  
    while (isNumber);
  }
  static void Main(string[] args)
  {
    //RunTimesTable();
    //RunCalculateTax();
    //RunCardinalToOrdinal();
    RunFactorial();
  }
}