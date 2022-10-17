using CarrinhoDeCompra.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarrinhoDeCompra.Components
{
    public class PedidoComponent
    {
        public static List<Pedido> Pedidos = new List<Pedido>();

        public static void RegistrarPedido()
        {
            int opt;
            Console.Clear();
            Console.WriteLine("Digite seu RG: ");
            int rg = Convert.ToInt32(Console.ReadLine());
            var pedido = new Pedido(rg);
            do
            {
                ProdutoComponent.ListarProdutos();
                Console.WriteLine("\nDigite o id do item que deseja adicionar: ");
                string id = Console.ReadLine();

                foreach (var prod in ProdutoComponent.Produtos)
                {
                    if (prod.Id.ToString() == id)
                    {
                        Console.WriteLine("\nDigite a quantidade que deseja: ");
                        int qtde = Convert.ToInt16(Console.ReadLine());
                        var pedidoItem = new PedidoItem(prod.Id, prod.Nome, prod.Valor, qtde);
                        pedido.ValorTotal += qtde * prod.Valor;
                        pedido.Produtos.Add(pedidoItem);
                        PedidoComponent.Pedidos.Add(pedido);
                        Console.WriteLine("\nProduto adicionado com sucesso");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nProduto não existente");
                        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
                        Console.ReadLine();
                    }
                }
                
                Console.Clear();
                Console.WriteLine("Deseja adicionar mais itens? 1 - Sim || 2 - Não");
                opt = Convert.ToInt16(Console.ReadLine());

            } while (opt != 2);
        }

        public static void ListarPedidosPorRG()
        {
            Console.Clear();

            Console.WriteLine("Digite seu RG: ");
            int rg = Convert.ToInt32(Console.ReadLine());

            foreach (var pedido in Pedidos)
            {
                if (pedido.ClienteId == rg)
                {
                    foreach (var produto in pedido.Produtos)
                    {
                        Console.WriteLine($"Id: {produto.Id}\nNome: {produto.Nome}\nValor unitário: {produto.Valor:f2}");
                        Console.WriteLine($"Valor Total: {pedido.ValorTotal:f2}");
                        Console.ReadLine();
                    }
                }
            }
        }

        public static void ListarTodosPedidos()
        {
            Console.Clear();

            foreach (var pedido in Pedidos)
            {
                Console.WriteLine($"Id do pedido: {pedido.PedidoId}\nId do cliente: {pedido.ClienteId}");
                foreach (var produto in pedido.Produtos)
                {
                    Console.WriteLine($"Id do produto: {produto.Id}\nNome: {produto.Nome}\nValor unitário: {produto.Valor:f2}");
                }
                Console.WriteLine($"Valor Total: {pedido.ValorTotal:f2}");
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
