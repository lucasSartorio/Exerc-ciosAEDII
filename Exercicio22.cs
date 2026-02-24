using System;

class Exercicio22
{
    private class Pessoa
    {
        internal string Nome { get; private set; }
        internal int Idade { get; private set; }
        
        internal Pessoa Pai { get; private set; }
        internal Pessoa Mae { get; private set; }

        internal Pessoa(string nome, int idade, Pessoa pai = null, Pessoa mae = null)
        {
            Nome = nome;
            Idade = idade;
            Pai = pai;
            Mae = mae;
        }

        internal void ImprimirArvore(string espacamento = "")
        {
            Console.WriteLine($"{espacamento}- {Nome} ({Idade} anos)");
            
            if (Pai != null)
            {
                Console.WriteLine($"{espacamento}  Pai:");
                Pai.ImprimirArvore(espacamento + "    ");
            }
            
            if (Mae != null)
            {
                Console.WriteLine($"{espacamento}  Mãe:");
                Mae.ImprimirArvore(espacamento + "    ");
            }
        }
    }

    internal static void Executar()
    {
        Console.WriteLine("--- Árvore Genealógica ---");

        Pessoa avoPaterno = new Pessoa("José", 75);
        Pessoa avaPaterna = new Pessoa("Maria", 72);

        Pessoa avoMaterno = new Pessoa("Antônio", 80);
        Pessoa avaMaterna = new Pessoa("Ana", 78);

        Pessoa pai = new Pessoa("Carlos", 50, avoPaterno, avaPaterna);
        Pessoa mae = new Pessoa("Beatriz", 48, avoMaterno, avaMaterna);

        Pessoa filho = new Pessoa("Lucas", 20, pai, mae);

        filho.ImprimirArvore();
    }
}