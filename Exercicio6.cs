using System;

public class Exercicio6
{
    public static void Executar()
    {
        
        Console.WriteLine("Qual numero deseja ver a quantidade de digitos:");

        double numero = double.Parse(Console.ReadLine());

        double formula = Math.Truncate(Math.Log10(numero) + 1);

        Console.WriteLine($"quantidade de digitos: {formula}");

        
    }

}

