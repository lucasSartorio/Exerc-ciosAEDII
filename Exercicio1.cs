using System;

public class Exercicio1
{
    public static void Executar()
    {
        
        Console.WriteLine("Digite os valores de a, b e c (pressione Enter após cada um):");

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());


        double delta = (b*b) - (4*a*c);

        if (delta < 0)
        {
            Console.WriteLine("A equação não possui raízes reais (Delta negativo).");
            return;
        }
        
        double raizNegativa = (-b - Math.Sqrt(delta)) / (2*a);
        double raizPositiva = (-b + Math.Sqrt(delta)) / (2*a);

        Console.WriteLine($"Raiz 1: {raizNegativa}");
        Console.WriteLine($"Raiz 2: {raizPositiva}");
    }

}