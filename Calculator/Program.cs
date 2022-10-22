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
      System.Console.WriteLine("5 - Sair");
      System.Console.Write("Selecione uma opção: ");
      opcao = short.Parse(Console.ReadLine());

      switch (opcao)
      {
        case 1: Somar(); break;
        case 2: Subtrair(); break;
        case 3: Multiplicar(); break;
        case 4: Dividir(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
      }
    }

    static void Somar()
    {
      float primeiroValor = 0.0f;
      float segundoValor = 0.0f;
      float resultado = 0.0f;

      Console.Clear();

      Console.Write("Entre com o primeiro valor: ");
      primeiroValor = float.Parse(System.Console.ReadLine());

      Console.Write("Entre com o segundo valor: ");
      segundoValor = float.Parse(System.Console.ReadLine());

      resultado = primeiroValor + segundoValor;

      Console.WriteLine($"Resultado: {resultado}");

      Console.ReadKey();

      Menu();
    }

    static void Subtrair()
    {
      float primeiroValor = 0.0f;
      float segundoValor = 0.0f;
      float resultado = 0.0f;

      Console.Clear();

      Console.Write("Entre com o primeiro valor: ");
      primeiroValor = float.Parse(System.Console.ReadLine());

      Console.Write("Entre com o segundo valor: ");
      segundoValor = float.Parse(System.Console.ReadLine());

      resultado = primeiroValor - segundoValor;

      Console.WriteLine($"Resultado: {resultado}");

      Console.ReadKey();

      Menu();
    }

    static void Multiplicar()
    {
      float primeiroValor = 0.0f;
      float segundoValor = 0.0f;
      float resultado = 0.0f;

      Console.Clear();

      Console.Write("Entre com o primeiro valor: ");
      primeiroValor = float.Parse(System.Console.ReadLine());

      Console.Write("Entre com o segundo valor: ");
      segundoValor = float.Parse(System.Console.ReadLine());

      resultado = primeiroValor * segundoValor;

      Console.WriteLine($"Resultado: {resultado}");

      Console.ReadKey();

      Menu();
    }

    static void Dividir()
    {
      float primeiroValor = 0.0f;
      float segundoValor = 0.0f;
      float resultado = 0.0f;

      Console.Clear();

      Console.Write("Entre com o primeiro valor: ");
      primeiroValor = float.Parse(System.Console.ReadLine());

      Console.Write("Entre com o segundo valor: ");
      segundoValor = float.Parse(System.Console.ReadLine());

      resultado = primeiroValor / segundoValor;

      Console.WriteLine($"Resultado: {resultado}");

      Console.ReadKey();

      Menu();
    }

  }
}