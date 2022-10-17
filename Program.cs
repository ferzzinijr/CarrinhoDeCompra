using CarrinhoDeCompra.Components;
using CarrinhoDeCompra.Models;
using System;

namespace CarrinhoDeCompra
{
    public class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opção: \n");
                Console.WriteLine("1 - Adicionar produto");
                Console.WriteLine("2 - Listar produtos");
                Console.WriteLine("3 - Editar produto");
                Console.WriteLine("4 - Excluir produto");
                Console.WriteLine("5 - Registrar um pedido");
                Console.WriteLine("6 - Listar pedidos por cliente");
                Console.WriteLine("7 - Listar todos os pedidos");
                Console.WriteLine("0 - Encerrar programa");
                Console.WriteLine();
                option = Convert.ToInt32(Console.ReadLine());


                switch (option)
                {
                    case 1:
                        ProdutoComponent.AdicionarProduto();
                        break;
                    case 2:
                        ProdutoComponent.ListarProdutos();
                        Console.ReadLine();
                        break;
                    case 3:
                        ProdutoComponent.EditarProduto();
                        break;
                    case 4:
                        ProdutoComponent.ExcluirProduto();
                        break;
                    case 5:
                        PedidoComponent.RegistrarPedido();
                        break;
                    case 6:
                        PedidoComponent.ListarPedidosPorRG();
                        break;
                    case 7:
                        PedidoComponent.ListarTodosPedidos();
                        break;
                    case 0:
                        break;
                }
            } while (option != 0);
        }
    }
}
