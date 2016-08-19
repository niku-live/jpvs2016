using System;

namespace Testukas
{
  class Program
  {
    public string Calculate(string number1Text, string number2Text, string operation)
    {
      int number1;
      int number2;
      if (!int.TryParse(number1Text, out number1))
      {
        return "Klaida: pirmas duomuo nėra skaičius";
      }
      if (!int.TryParse(number2Text, out number2))
      {
        return "Klaida: antras duomuo nėra skaičius";
      }
      int result = 0;
      switch (operation)
      {
        case "+":
          result = number1 + number2;
          break;
        case "-":
          result = number1 - number2;
          break;
        case "*":
          result = number1 * number2;
          break;
        case "/":
          result = number1 / number2;
          break;
        case "%":
          result = number1 % number2;
          break;					
      }
      return String.Format("{0} {1} {2} = {3}", number1, operation, number2, result);
    }


    public void Run()
    {
      while (true)
      {
        Console.Write("Operacija (+, -, *, /, %, q - išeiti):");      
        string operation = Console.ReadLine();
        if (operation != "q")
        {
          Console.Write("Pirmas skaicius: ");
          string value1 = Console.ReadLine();      
          Console.Write("Antras skaicius: ");
          string value2 = Console.ReadLine();
          Console.WriteLine(Calculate(value1, value2, operation));        
        }      
        else
        {
          return;
        }
      }
    }
        
    public static void Main(string[] args)
    {
      new Program().Run();
    }
  }
}