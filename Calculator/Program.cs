using System;

namespace Calculator
{
  class Program
  {
    public static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();

      short opcao = 0;

      System.Console.WriteLine("Calculator");
      System.Console.WriteLine("1 - Somar");
      System.Console.WriteLine("2 - Subtrair");
      System.Console.WriteLine("3 - Multiplicar");
      System.Console.WriteLine("4 - Dividir");
      System.Console.Write("Selecione uma opção:");
      opcao = short.Parse(Console.ReadLine());
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

    static void Multiplicar()
    {
      float primeiroValor = 0.0f;
      float segundoValor = 0.0f;
      float resultado = 0.0f;

      Console.Clear();

      Console.Write("Entre com o primeiro valor: ");
      primeiroValor = float.Parse(Console.ReadLine());

      Console.Write("Entre com o segundo valor: ");
      segundoValor = float.Parse(Console.ReadLine());

      resultado = primeiroValor * segundoValor;

      Console.WriteLine($"Resultado: {resultado}");

      Console.ReadKey();
    }

    static void Dividir()
    {
      float primeiroValor = 0.0f;
      float segundoValor = 0.0f;
      float resultado = 0.0f;

      Console.Clear();

      Console.Write("Entre com o primeiro valor: ");
      primeiroValor = float.Parse(Console.ReadLine());

      Console.Write("Entre com o segundo valor: ");
      segundoValor = float.Parse(Console.ReadLine());

      resultado = primeiroValor / segundoValor;

      Console.WriteLine($"Resultado: {resultado}");

      Console.ReadKey();
    }

  }
}