using System;
using System.Collections.Generic;

class Exercicio16
{
    private abstract class FiguraGeometrica
    {
        internal abstract double CalcularArea();
    }
    
    private class Quadrado : FiguraGeometrica
    {
        internal double Lado { get; private set; }

        internal Quadrado(double lado)
        {
            Lado = lado;
        }

        internal override double CalcularArea()
        {
            return Lado * Lado; 
        }
    }

    private class Retangulo : FiguraGeometrica
    {
        internal double Base { get; private set; }
        internal double Altura { get; private set; }

        internal Retangulo(double baseRetangulo, double altura)
        {
            Base = baseRetangulo;
            Altura = altura;
        }

        internal override double CalcularArea()
        {
            return Base * Altura;
        }
    }

    private class Triangulo : FiguraGeometrica
    {
        internal double Base { get; private set; }
        internal double Altura { get; private set; }

        internal Triangulo(double baseTriangulo, double altura)
        {
            Base = baseTriangulo;
            Altura = altura;
        }

        internal override double CalcularArea()
        {
            return (Base * Altura) / 2.0;
        }
    }

    private class Circulo : FiguraGeometrica
    {
        internal double Raio { get; private set; }

        internal Circulo(double raio)
        {
            Raio = raio;
        }

        internal override double CalcularArea()
        {
            return Math.PI * (Raio * Raio); 
        }
    }

    internal static void Executar()
    {
        Console.WriteLine("--- Polimorfismo de Figuras Geométricas ---");

        List<FiguraGeometrica> minhasFiguras = new List<FiguraGeometrica>();

        minhasFiguras.Add(new Quadrado(5));               // Lado 5
        minhasFiguras.Add(new Retangulo(4, 6));           // Base 4, Altura 6
        minhasFiguras.Add(new Triangulo(4, 5));           // Base 4, Altura 5
        minhasFiguras.Add(new Circulo(3));                // Raio 3

        foreach (FiguraGeometrica figura in minhasFiguras)
        {
            Console.WriteLine($"A área do {figura.GetType().Name} é: {figura.CalcularArea():F2}");
        }
    }
}