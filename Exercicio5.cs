using System;

public class Exercicio5
{
    public static void Executar()
    {
        
        Console.WriteLine("Qual numero deseja ver a tabuada:");

        int tabuada = int.Parse(Console.ReadLine());

        int i = 1;
        int resultado;

        while (i <= 10)
        {
            resultado = tabuada * i;
            Console.WriteLine($"{tabuada} x {i}: {resultado}");
            i++;
        }

        
    }

}

