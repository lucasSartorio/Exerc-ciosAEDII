using System;

class Exercicio11
{
    internal static void Executar()
    {
        Console.WriteLine("--- Raiz Quadrada na Mão (Método Babilônico) ---");
        
        Console.Write("Informe o número inteiro: ");
        int numero = int.Parse(Console.ReadLine() ?? "0");

        if (numero < 0)
        {
            Console.WriteLine("Erro: Não existe raiz quadrada real de número negativo.");
            return;
        }
        if (numero == 0)
        {
            Console.WriteLine("A raiz aproximada é: 0");
            return;
        }

        Console.Write("Informe o erro máximo permitido (Ex: 0,001): ");
        double erroMaximo = double.Parse(Console.ReadLine() ?? "0");

        double palpite = numero / 2.0;
        
        double erroAtual = (palpite * palpite) - numero;
        
        if (erroAtual < 0) 
        {
            erroAtual = -erroAtual;
        }

        while (erroAtual > erroMaximo)
        {
            palpite = (palpite + (numero / palpite)) / 2.0;
            
            erroAtual = (palpite * palpite) - numero;
            if (erroAtual < 0) 
            {
                erroAtual = -erroAtual;
            }
        }

        Console.WriteLine($"\nA raiz aproximada é: {palpite}");
        Console.WriteLine($"Prova real (palpite * palpite): {palpite * palpite}");
    }
}