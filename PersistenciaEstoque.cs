using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantinaa
{
    internal class PersistenciaEstoque
    {
        public static List<ProdutosEstoque> listaEstoque = new List<ProdutosEstoque>()
        {
            new ProdutosEstoque("Pão de Queijo", 0, true),
            new ProdutosEstoque("Coxinha", 0, true),
            new ProdutosEstoque("Pastel de Carne", 0, true),
            new ProdutosEstoque("Pastel de Queijo", 0, true),
            new ProdutosEstoque("Suco Natural (300ml)", 0, true),
            new ProdutosEstoque("Refrigerante Lata", 0, true),
            new ProdutosEstoque("Hambúrguer Simples", 0, true),
            new ProdutosEstoque("Hambúrguer com Queijo", 0, true),
            new ProdutosEstoque("X-Tudo", 0, true),
            new ProdutosEstoque("Água Mineral (500ml)", 0, true),
        };
    }
}
