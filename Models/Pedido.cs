using System;
using System.Collections.Generic;
using System.Text;

namespace CarrinhoDeCompra.Models
{
    public class Pedido
    {
        public int ClienteId { get; private set; }

        public Guid PedidoId { get; private set; }

        public List<Produto> Produtos = new List<Produto>();

        public decimal ValorTotal { get; set; }

        public Pedido()
        {

        }

        public Pedido(int clienteId)
        {
            ClienteId = clienteId;
            PedidoId = Guid.NewGuid();
        }
    }
}
