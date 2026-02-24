using System;
using System.Collections.Generic;

class Exercicio19
{
    private enum MetodoPagamento
    {
        Dinheiro, Cheque, Cartao
    }

    private class Produto
    {
        internal string Nome { get; private set; }
        internal double Preco { get; private set; }
        internal int QuantidadeEstoque { get; private set; }

        internal Produto(string nome, double preco, int quantidadeEstoque)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;
        }

        internal void ReduzirEstoque(int quantidade)
        {
            QuantidadeEstoque -= quantidade;
        }
    }

    private class ItemPedido
    {
        internal Produto ProdutoEscolhido { get; private set; }
        internal int Quantidade { get; private set; }

        internal ItemPedido(Produto produto, int quantidade)
        {
            ProdutoEscolhido = produto;
            Quantidade = quantidade;
        }

        internal double CalcularSubtotal()
        {
            return ProdutoEscolhido.Preco * Quantidade;
        }
    }

    private class Pedido
    {
        private List<ItemPedido> Itens { get; set; } 
        private MetodoPagamento FormaPagamento { get; set; }

        internal Pedido()
        {
            Itens = new List<ItemPedido>(); 
        }

        internal void AdicionarItem(Produto produto, int quantidade)
        {
            if (produto.QuantidadeEstoque >= quantidade)
            {
                Itens.Add(new ItemPedido(produto, quantidade));
                
                produto.ReduzirEstoque(quantidade); 
                
                Console.WriteLine($"{quantidade}x {produto.Nome} adicionado(s) ao carrinho.");
            }
            else
            {
                Console.WriteLine($"ALERTA: Estoque insuficiente para {produto.Nome}. Disponível: {produto.QuantidadeEstoque}");
            }
        }

        private double CalcularTotal() 
        {
            double total = 0;
            foreach (var item in Itens)
            {
                total += item.CalcularSubtotal();
            }
            return total;
        }
        
        internal void FinalizarPedido(MetodoPagamento formaPagamento)
        {
            FormaPagamento = formaPagamento;
            Console.WriteLine("\n--- CUPOM FISCAL ---");
            foreach (var item in Itens)
            {
                Console.WriteLine($"{item.Quantidade}x {item.ProdutoEscolhido.Nome} - Subtotal: R$ {item.CalcularSubtotal():F2}");
            }
            Console.WriteLine($"\nTotal a pagar: R$ {CalcularTotal():F2}");
            Console.WriteLine($"Forma de Pagamento: {FormaPagamento}");
            Console.WriteLine("--------------------\n");
        }
    }

    internal static void Executar()
    {
        Console.WriteLine("--- Sistema do Supermercado (Encapsulado) ---");

        Produto arroz = new Produto("Arroz 5kg", 25.00, 50);
        Produto feijao = new Produto("Feijão 1kg", 8.50, 20);
        
        Pedido pedidoCliente = new Pedido();

        pedidoCliente.AdicionarItem(arroz, 2);
        pedidoCliente.AdicionarItem(feijao, 4);

        pedidoCliente.FinalizarPedido(MetodoPagamento.Cartao);
    }
}