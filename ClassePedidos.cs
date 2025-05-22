using System;
using System.Data;

namespace Cantinaa
{
    internal class ClassePedidos
    {
        private List<ClasseProdutos> ItensPedidos;
        private DateTime DataPedido;
        private string NomeCliente;
        private string FormaPagamento;
        private bool IsViagem;


        public ClassePedidos()
        {
            ItensPedidos = new List<ClasseProdutos>();
            DataPedido = DateTime.Now;
            NomeCliente = "";
            FormaPagamento = "";
            IsViagem = false;

        }

        public ClassePedidos(string nomeCliente, string formaPagamento, bool isViagem, List<ClasseProdutos> itensPedidos)
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

        public List<ClasseProdutos> itensPedidos
        { 
            get { return ItensPedidos; }
            set {  ItensPedidos = value; }
        }
    }
}

