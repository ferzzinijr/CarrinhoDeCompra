using System;
using System.Collections.Generic;
using System.Text;

namespace CarrinhoDeCompra.Models
{
    public class PedidoItem
    {
        public Guid Id { get; set; }

        public string Nome { get; private set; }

        public decimal Valor { get; private set; }

        public int Quantidade{ get; private set; }

        public PedidoItem()
        {

        }

        public PedidoItem(Guid id, string nome, decimal valor, int quantidade)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }
    }
}
