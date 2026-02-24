using System;

class Exercicio8
{
    internal static void Executar()
    {
        Console.WriteLine("Informe um número inteiro não negativo para a série de Fibonacci:");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("O número deve ser maior ou igual a zero.");
            return;
        }

        int anterior = 0;
        int atual = 1;

        Console.Write("Resultado: ");

        for (int i = 0; i <= n; i++)
        {
            if (i == n)
            {
                Console.Write(anterior);
            }
            else
            {
                Console.Write(anterior + ", ");
            }

            int proximo = anterior + atual;
            anterior = atual;
            atual = proximo;
        }
        
    }
}