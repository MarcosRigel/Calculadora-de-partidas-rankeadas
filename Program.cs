internal class Program
{
  static string nivel;
  public static void Main(string[] args)
  {
    char op = '0';
    do
    {
      System.Console.Write("Digite seu nome: ");
      string nome = Console.ReadLine();

      System.Console.Write("Quantidade de Vitórias: ");
      int vitorias = int.Parse(Console.ReadLine());
      System.Console.Write("Quantidade de Derrotas: ");
      int derrotas = int.Parse(Console.ReadLine());

      int saldoVitorias = partidasRanqueadas(vitorias, derrotas);

      System.Console.WriteLine($"O Herói tem de saldo de {saldoVitorias} está no nível {nivel}");
      System.Console.WriteLine();
      
      System.Console.Write("Deseja continuar com a execução? (S/N) ");
      op = char.Parse(Console.ReadLine());
      op = retornaOpcao(op);

    } while (op == '0');
  }

  public static int partidasRanqueadas(int quantidadeVitorias, int quantidadeDerrotas)
  {
    int resultado = quantidadeVitorias - quantidadeDerrotas;

    if (resultado < 10)
    {
      nivel = "Ferro";
    }
    else if (resultado >= 10 && resultado <= 20)
    {
      nivel = "Bronze";
    }
    else if (resultado > 20 && resultado <= 50)
    {
      nivel = "Prata";
    }
    else if (resultado > 50 && resultado <= 80)
    {
      nivel = "Ouro";
    }
    else if (resultado > 80 && resultado <= 90)
    {
      nivel = "Diamente";
    }
    else if (resultado > 90 && resultado <= 100)
    {
      nivel = "Lendário";
    }
    else if (resultado > 100)
    {
      nivel = "Imortal";
    }

    return resultado;
  }

  public static char retornaOpcao(char op)
  {
    if (op == 's' || op == 'S')
    {
      return op = '0';
    }
    else if (op == 'n' || op == 'N')
    {
      return op = '1';
    }
        
    while (op != 's' && op != 'S' && op != 'n' && op != 'N') 
    {
      System.Console.Write("Opção inválida Digite Novamente! ");
      op = char.Parse(Console.ReadLine());
    }

    return retornaOpcao(op);
  }

}