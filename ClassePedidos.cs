using System;
using System.Data;
using System.Drawing;


namespace Cantinaa
{
    internal class ClassePedidos
    {
        private string NomeCliente;
        private string FormaPagamento;
        private string isViagem;


        public ClassePedidos()
        {
            NomeCliente = "";
            FormaPagamento = "";
            isViagem = "";

        }

        public ClassePedidos(string NomeCliente, string FormaPagamento, string isViagem)
        {
            this.NomeCliente = nomeCliente;
            this.FormaPagamento= formaPagamento;
            this.isViagem = isviagem;
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
        public string isviagem
        {
            get { return isViagem; }
            set { isViagem = value; }
        }

    }
}
