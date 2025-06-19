using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantinaa
{
    internal class Estoque
    {
        public Produtos Produtos { get; set; }
        public int quantidade { get; set; }

        public void AdicionarQuantidade(int quantidade)
        {
            this.quantidade += quantidade;
        }

        public void RemoverQuantidade(int quantidade)
        {
            if (quantidade > 0 && quantidade <= this.quantidade)
            {
                this.quantidade -= quantidade;
            }
        }

        public override string ToString()
        {
            string statusAtivo = "";
            if (!Produtos.ISAtivo) 
            {
                statusAtivo = " - desativado";
            }
            return $"{Produtos.Descricao} - Quant: {quantidade} {statusAtivo}";
        }


    }
}
