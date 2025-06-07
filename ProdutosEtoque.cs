using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantinaa
{
    internal class ProdutosEstoque
    {
        private string descricao;
        private int quantidade;
        private bool isAtivo;

        public ProdutosEstoque()
        {
            descricao = "";
            quantidade = 0;
            isAtivo = false;
        }

        public ProdutosEstoque(string descricao, int quantidade, bool isAtivo)
        {
            this.descricao = descricao;
            this.quantidade = quantidade;
            this.isAtivo = isAtivo;
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public bool IsAtivo
        {
            get { return isAtivo; }
            set { isAtivo = value; }
        }

        public override string ToString()
        {
            return $"{descricao} , {quantidade}";
        }

    }

}
