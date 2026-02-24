using System;
using System.Collections.Generic;

class Exercicio20
{
    private class Contato
    {
        internal string Nome { get; private set; }
        internal string Telefone { get; private set; }

        internal Contato(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }
    }

    private class Agenda
    {
        private List<Contato> contatos;

        internal Agenda()
        {
            contatos = new List<Contato>();
        }

        internal void AdicionarContato(string nome, string telefone)
        {
            Contato novoContato = new Contato(nome, telefone);
            contatos.Add(novoContato);
            Console.WriteLine($"[+] Contato '{nome}' adicionado com sucesso!");
        }

        internal void ListarContatos()
        {
            Console.WriteLine("\n--- Minha Agenda Telefônica ---");
            
            if (contatos.Count == 0)
            {
                Console.WriteLine("A agenda está vazia.");
            }
            else
            {
                foreach (var contato in contatos)
                {
                    Console.WriteLine($"Nome: {contato.Nome} | Telefone: {contato.Telefone}");
                }
            }
            Console.WriteLine("-------------------------------\n");
        }

        internal void BuscarPorNome(string nomeBuscado)
        {
            Console.WriteLine($"Buscando por '{nomeBuscado}'...");
            bool encontrou = false;

            foreach (var contato in contatos)
            {
                if (contato.Nome.ToUpper().Contains(nomeBuscado.ToUpper()))
                {
                    Console.WriteLine($"[ENCONTRADO] {contato.Nome} - {contato.Telefone}");
                    encontrou = true;
                }
            }

            if (!encontrou)
            {
                Console.WriteLine("Nenhum contato encontrado com esse nome.");
            }
        }
    }

    internal static void Executar()
    {
        Console.WriteLine("--- Sistema de Agenda ---");

        Agenda minhaAgenda = new Agenda();

        minhaAgenda.AdicionarContato("Lucas", "(11) 99999-1111");
        minhaAgenda.AdicionarContato("Ana Silva", "(21) 98888-2222");
        minhaAgenda.AdicionarContato("Carlos Mendes", "(31) 97777-3333");

        minhaAgenda.ListarContatos();

        minhaAgenda.BuscarPorNome("Ana");
        
        minhaAgenda.BuscarPorNome("João");
    }
}