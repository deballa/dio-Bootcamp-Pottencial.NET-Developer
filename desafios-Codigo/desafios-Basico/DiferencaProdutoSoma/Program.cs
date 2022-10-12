using System;

class DIO
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
        int produto = 1, soma = 0;
        while (numero > 0)
        {
            int restoDivisao = numero % 10;
            if (numero >= 1 && numero <= Math.Pow(10, 5))
            {
                produto *= restoDivisao;
                soma += restoDivisao;
                numero /= 10;
            }
        }
        Console.WriteLine("Diferença entre o produto: " + produto + " e a soma: " + soma + " é de: " + (produto - soma));
    }
}