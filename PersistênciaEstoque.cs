using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantinaa
{
    internal class PersistênciaEstoque
    {
        public static List<Estoque> listaEstoque = new List<Estoque>();

        public static void IniciarEstoque()
        {
            listaEstoque.Clear();
            foreach (var item in PersistênciaProduto.listaProdutos)
            {
                Estoque estoque = new Estoque
                {
                    Produtos = item,
                    quantidade = 0
                };

                listaEstoque.Add(estoque);
            }
        }
    }
}
