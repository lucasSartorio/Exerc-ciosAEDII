using System;

public class Exercicio2
{
    public static void Executar()
    {
        
        Console.WriteLine("Digite os valores de x, y e z (pressione Enter após cada um) para o primeiro ponto:");

        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double z1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite os valores de x, y e z (pressione Enter após cada um) para o segundo ponto:");

        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double z2 = double.Parse(Console.ReadLine());


        double deltaX = Math.Pow((x2 - x1), 2);
        double deltaY = Math.Pow((y2 - y1), 2);
        double deltaZ = Math.Pow((z2 - z1), 2);

        double resultado = Math.Sqrt(deltaX + deltaY + deltaZ);

        Console.WriteLine($"Distancia: {resultado}");
    }

}