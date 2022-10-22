using System;

namespace Calculator
{
  class Program
  {
    public static void Main(string[] args)
    {
      Somar();
      Subtrair();
    }

    static void Somar()
    {
      float primeiroValor = 0.0f;
      float segundoValor = 0.0f;
      float resultado = 0.0f;

      Console.Clear();

      Console.Write("Entre com o primeiro valor: ");
      primeiroValor = float.Parse(Console.ReadLine());

      Console.Write("Entre com o segundo valor: ");
      segundoValor = float.Parse(Console.ReadLine());

      resultado = primeiroValor + segundoValor;

      Console.WriteLine($"Resultado: {resultado}");

      Console.ReadKey();
    }

    static void Subtrair()
    {
      float primeiroValor = 0.0f;
      float segundoValor = 0.0f;
      float resultado = 0.0f;

      Console.Clear();

      Console.Write("Entre com o primeiro valor: ");
      primeiroValor = float.Parse(Console.ReadLine());

      Console.Write("Entre com o segundo valor: ");
      segundoValor = float.Parse(Console.ReadLine());

      resultado = primeiroValor - segundoValor;

      Console.WriteLine($"Resultado: {resultado}");

      Console.ReadKey();
    }
  }
}