using CarrinhoDeCompra.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarrinhoDeCompra.Components
{
    public class ProdutoComponent
    {
        public static List<Produto> Produtos = new List<Produto>();


        public static void AdicionarProduto()
        {
            Console.Clear();
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("\nValor: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nQuantidade em estoque: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            
            var produto = new Produto(nome, valor, quantidade);
            ProdutoComponent.Produtos.Add(produto);
            Console.WriteLine("\nProduto criado com sucesso");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadLine();
        }

        public static void ListarProdutos()
        {
            Console.Clear();
            foreach (var produto in Produtos)
            {
                Console.WriteLine($"Id: {produto.Id}\nNome: {produto.Nome}\nValor: {produto.Valor}\nQuantidade em estoque: {produto.QuantidadeEstoque}");
                Console.WriteLine();
            }
        }

        public static void EditarProduto()
        {
            Console.Clear();
            ProdutoComponent.ListarProdutos();
            Console.WriteLine("Digite o id do produto que deseja alterar: \n");
            string id = Console.ReadLine();
            var produto = new Produto();
            foreach (var prod in Produtos)
            {
                if (prod.Id.ToString() == id)
                {
                    produto = prod;
                    int opcoes;
                    Console.Clear();
                    Console.WriteLine("Qual opção deseja editar: \n");
                    Console.WriteLine("1 - Nome");
                    Console.WriteLine("2 - Valor");
                    Console.WriteLine("3 - Quantidade em estoque");
                    Console.WriteLine("4 - Voltar ao menu\n");
                    opcoes = Convert.ToInt32(Console.ReadLine());

                    switch (opcoes)
                    {
                        case 1:
                            prod.AlterarNome();
                            break;
                        case 2:
                            prod.AlterarValor();
                            break;
                        case 3:
                            prod.AlterarQuantidadeEstoque();
                            break;
                        case 4:
                            break;
                    }

                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
                    Console.ReadLine();
                    break;
                }
            }
            if (produto.Id == Guid.Empty)
            {
                Console.WriteLine("\nProduto não existente");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
                Console.ReadLine();
            }
        }

        public static void ExcluirProduto()
        {
            Console.Clear();
            ProdutoComponent.ListarProdutos();
            Console.WriteLine("Digite o id do produto que deseja excluir: \n");
            string id = Console.ReadLine();
            var produto = new Produto();
            foreach (var prod in Produtos)
            {
                if (prod.Id.ToString() == id)
                {
                    produto = prod;
                    Produtos.Remove(produto);
                    Console.WriteLine("Produto excluido com sucesso");
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
                    Console.ReadLine();
                    break;
                }
            }
            if (produto.Id == Guid.Empty)
            {
                Console.WriteLine("\nProduto não existente");
                Console.WriteLine("\nPressione uma tecla para voltar ao menu");
                Console.ReadLine();
            }
        }
    }
}
