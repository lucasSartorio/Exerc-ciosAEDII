using System;

class Exercicio10
{
    internal static void Executar()
    {
        Console.WriteLine("--- Simulador de Investimentos ---");
        
        Console.Write("Informe o valor a ser investido por mês (Ex: 100): ");
        double valorMensal = double.Parse(Console.ReadLine());

        Console.Write("Informe a taxa de juros mensal em % (Ex: 1): ");
        double taxaJuros = double.Parse(Console.ReadLine()) / 100.0;

        double saldo = 0;
        int anosPassados = 0;
        string resposta;

        do
        {
            anosPassados++; 

            for (int mes = 1; mes <= 12; mes++)
            {
                saldo = (saldo + valorMensal) * (1 + taxaJuros);
            }

            Console.WriteLine($"Saldo do investimento após {anosPassados} ano(s): {saldo}");
            
            Console.WriteLine("Deseja processar mais um ano? (S/N)");
            
            // A correção do aviso CS8602 está aqui:
            resposta = (Console.ReadLine() ?? "").Trim().ToUpper();

        } while (resposta == "S"); 
    }
}