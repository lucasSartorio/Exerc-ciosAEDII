using System;
using System.Collections.Generic;

class Exercicio21
{
    private class Pessoa
    {
        internal string Nome { get; private set; }

        internal Pessoa(string nome)
        {
            Nome = nome;
        }
    }

    private class Livro
    {
        internal string Titulo { get; private set; }
        internal string Autor { get; private set; }
        internal bool Disponivel { get; private set; }

        internal Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
            Disponivel = true;
        }

        internal void MarcarComoEmprestado()
        {
            Disponivel = false;
        }

        internal void MarcarComoDevolvido()
        {
            Disponivel = true;
        }
    }

    private class Emprestimo
    {
        internal Pessoa Cliente { get; private set; }
        internal Livro LivroEmprestado { get; private set; }
        internal DateTime DataRetirada { get; private set; }
        internal bool EmAndamento { get; private set; }

        internal Emprestimo(Pessoa cliente, Livro livro)
        {
            Cliente = cliente;
            LivroEmprestado = livro;
            DataRetirada = DateTime.Now;
            EmAndamento = true;

            livro.MarcarComoEmprestado(); 
            
            Console.WriteLine($"[EMPRÉSTIMO] '{livro.Titulo}' emprestado para {cliente.Nome}.");
        }

        internal void Devolver()
        {
            if (EmAndamento)
            {
                LivroEmprestado.MarcarComoDevolvido();
                EmAndamento = false;
                Console.WriteLine($"[DEVOLUÇÃO] '{LivroEmprestado.Titulo}' devolvido por {Cliente.Nome}.");
            }
            else
            {
                Console.WriteLine($"O livro '{LivroEmprestado.Titulo}' já havia sido devolvido.");
            }
        }
    }

    internal static void Executar()
    {
        Console.WriteLine("--- Sistema da Biblioteca ---");

        Pessoa lucas = new Pessoa("Lucas");
        Pessoa maria = new Pessoa("Maria");

        Livro senhorDosAneis = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien");
        Livro harryPotter = new Livro("Harry Potter e a Pedra Filosofal", "J.K. Rowling");

        if (senhorDosAneis.Disponivel)
        {
            Emprestimo emp1 = new Emprestimo(lucas, senhorDosAneis);
        }

        Console.WriteLine("\nMaria tentando pegar O Senhor dos Anéis...");
        if (senhorDosAneis.Disponivel)
        {
            Emprestimo emp2 = new Emprestimo(maria, senhorDosAneis);
        }
        else
        {
            Console.WriteLine($"Desculpe Maria, o livro '{senhorDosAneis.Titulo}' está indisponível no momento.");
        }

        if (harryPotter.Disponivel)
        {
            Emprestimo emp3 = new Emprestimo(maria, harryPotter);
        }

        Console.WriteLine("\nAlguns dias depois...");
        
        Emprestimo emprestimoLucas = new Emprestimo(lucas, senhorDosAneis);
    }
}