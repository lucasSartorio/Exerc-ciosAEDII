using System;

public class Exercicio4
{
    public static void Executar()
    {
        
        Console.WriteLine("Digite o nome do produto:");

        String produto = Console.ReadLine();

        Console.WriteLine("Digite o valor unitário do produto:");

        double valor = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade comprada:");

        int quantidade = int.Parse(Console.ReadLine());

        double percentual = 0;

        if (quantidade >= 11 && quantidade <= 21)
        {
            percentual = 0.10;
        } else if (quantidade >= 21 && quantidade <= 50) {
            percentual = 0.20;
        } else if (percentual > 50)
        {
            percentual = 0.25;
        }

        double total = (valor - (valor * percentual)) * quantidade;

        Console.WriteLine($"Produto comprado: {produto}");
        Console.WriteLine($"Valor a ser pago: {total}");
    }

}

