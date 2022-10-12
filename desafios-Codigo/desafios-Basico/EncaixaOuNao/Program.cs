using System.IO;
using System.Linq;
using System;

class Dio
{
    static void Main(string[] args)
    {
        //Para executar no Visual Studio
        Console.WriteLine("Digite a quantidade de casos: ");
        
        int qt = int.Parse(Console.ReadLine());

        //Para o caso de teste atual são 4 linhas. Mudar para outros casos de teste
        qt = 4;

        string[] valores = new string[qt];
        
        //Para executar no Visual Studio preencha os valores do caso de teste aqui:
        string[] linhas = { "56234523485723854755454545478690 78690",
                            "5434554 543",
                            "1243 1243",
                            "54 64545454545454545454545454545454554" };

        for (int i = 0; i < qt; i++)
        {
            // Para executar no ambiente da DIO
            //valores = Console.ReadLine().Split(" ");
            
            //Para executar no Visual Studio
            valores = linhas[i].Split(" ");
            
            string a = valores[0];
            string b = valores[1];

            if (a.Length > 0 && a.Length <= 1000 && b.Length < 0 && b.Length >= 1000)
                Console.WriteLine("nao encaixa");
            else if (a.EndsWith(b))
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");

        }

    }

}