using System;
using System.Data;
using System.Drawing;

namespace Cantinaa
{
    internal class Pedidos
    {
        private List<Produtos> ItensPedidos;
        private DateTime DataPedido;
        private string NomeCliente;
        private string FormaPagamento;
        private bool IsViagem;
        private Status StatusPedido;

        public Pedidos()
        {
            ItensPedidos = new List<Produtos>();
            DataPedido = DateTime.Now;
            NomeCliente = "";
            FormaPagamento = "";
            IsViagem = false;

        }

        public Pedidos(string nomeCliente, string formaPagamento, bool isViagem, List<Produtos> itensPedidos)
        {
            this.ItensPedidos = itensPedidos;
            this.DataPedido = DateTime.Now;
            this.NomeCliente = nomeCliente;
            this.FormaPagamento = formaPagamento;
            this.IsViagem = isViagem;
        }

        public string nomeCliente
        {
            get { return NomeCliente; }
            set { NomeCliente = value; }
        }

        public string formaPagamento
        {
            get { return FormaPagamento; }
            set { FormaPagamento = value; }
        }
        public bool isviagem
        {
            get { return IsViagem; }
            set { IsViagem = value; }
        }

        public List<Produtos> itensPedidos
        {
            get { return ItensPedidos; }
            set { ItensPedidos = value; }
        }

        public Status statusPedido
        {
            get { return StatusPedido; }
            set { StatusPedido = value; }
        }
   
        public override string ToString()
        {
            return $"{itensPedidos.ToString}";
        }

    }
}


