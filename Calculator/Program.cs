using System;

namespace Calculator
{
  class Program
  {
    public static void Main(string[] args)
    {
      float primeiroValor = 0.0f;

      Console.Clear();
      Console.Write("Entre com o primeiro valor: ");

      primeiroValor = float.Parse(Console.ReadLine());

      Console.WriteLine("Primeiro Valor: " + primeiroValor);
    }
  }
}