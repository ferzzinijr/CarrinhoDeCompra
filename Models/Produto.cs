using System;
using System.Collections.Generic;
using System.Text;

namespace CarrinhoDeCompra.Models
{
    public class Produto
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public decimal Valor { get; private set; }
        public int QuantidadeEstoque { get; private set; }

        public Produto()
        {

        }

        public Produto(string nome, decimal valor, int quantidadeEstoque)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Valor = valor;
            QuantidadeEstoque = quantidadeEstoque;
        }

        public void AlterarNome()
        {
            Console.Clear();
            Console.WriteLine("Digite o novo nome: ");
            string nome = Console.ReadLine();
            if (nome == "" || nome == null)
            {
                Console.WriteLine("Nome inválido");
                return;
            }
            Nome = nome;
            Console.WriteLine("Nome alterado com sucesso");
        }

        public void AlterarValor()
        {
            Console.Clear();
            Console.WriteLine("Digite o novo valor: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());
            Valor = valor;
            Console.WriteLine("Valor alterado com sucesso");
        }

        public void AlterarQuantidadeEstoque()
        {
            Console.Clear();
            Console.WriteLine("Digite a nova quantidade em estoque: ");
            int estoque = Convert.ToInt32(Console.ReadLine());
            QuantidadeEstoque = estoque;
            Console.WriteLine("Quantidade em estoque alterado com sucesso");
        }

        public void AtualizaQuantidadeEstoque(int qtde)
        {
            QuantidadeEstoque -= qtde;
        }
    }
}
